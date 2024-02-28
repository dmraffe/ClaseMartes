using AutoMapper;
using Ecommerce.Application.Contract.Repository;
using Ecommerce.Application.Features.Category.Querys.GetAllCategory;
using Ecommerce.Dominio;
using Ecommerce.Dominio.ModelDTIN;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.Carrito.Commands.ManagerCarrito
{
    public  class ManagerCarritoHandler : IRequestHandler<ManagerCarritoCommand, CarritoDto>
    {

        IRepositoryAsync<Dominio.Orden> _repositoryAsync;
        IRepositoryAsync<Dominio.OrdenProduct> _ordenproduct;
        IRepositoryAsync<Dominio.Product> _repositoryproductAsync;
        IMapper _mapper;
        public ManagerCarritoHandler(IRepositoryAsync<Dominio.Orden> repositoryAsync, IRepositoryAsync<Dominio.OrdenProduct> ordenproduct, IRepositoryAsync<Dominio.Product> repositoryproductAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync;
            _ordenproduct = ordenproduct;
            _repositoryproductAsync = repositoryproductAsync;
           _mapper = mapper;
        }
        public async Task<CarritoDto> Handle(ManagerCarritoCommand request, CancellationToken cancellationToken)
        {

            Dominio.Orden orden = null;
            CarritoDto carritoDto = new CarritoDto();
            try
            {
                if (request.idCarrito == 0)
                {
                    orden = await _repositoryAsync.AddAsync(new Orden
                    {
                        Status = "Creada",
                        Total = 0,

                    });
                }
                else
                { 
                   orden = await _repositoryAsync.GetByIdAsync(request.idCarrito);
                
                }

                var producto = await _repositoryproductAsync.GetByIdAsync(request.articulo);


              var ordnpr = await _ordenproduct.GetAsync(a=>a.ProductID  == request.articulo && a.OrdenID == request.idCarrito);


                if (ordnpr.Any())
                {

                    var auxactual = ordnpr.FirstOrDefault();

                    auxactual.Quantity++;

                    await _ordenproduct.UpdateAsync(auxactual);

                }
                else
                {
                    await _ordenproduct.AddAsync(new OrdenProduct
                    {
                        OrdenID = orden.Id,
                        Price = producto.precio,
                        ProductID = producto.Id,
                        Quantity = 1


                    });

                }

                  carritoDto = _mapper.Map<CarritoDto>(orden);

                var ordenproducts = await _ordenproduct.GetAsync(a => a.OrdenID == request.idCarrito);

                foreach (var item in ordenproducts.ToList())
                {
                    var pr = await _repositoryproductAsync.GetByIdAsync(item.ProductID);

                    carritoDto.Products.Add(new ProductDTO
                    {
                       Cantidad = item.Quantity,
                       Description = pr.Description,
                       Name = pr.Name,
                       precio = item.Price
                    });
                  carritoDto.Total = carritoDto.Total +(item.Quantity* item.Price);
                }


            }
            catch (Exception ex)
            {
                var t = 0;
            }




            return carritoDto;
        }
    }
}
