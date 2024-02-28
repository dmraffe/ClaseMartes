using AutoMapper;
using Ecommerce.Application.Contract.Repository;
using Ecommerce.Application.Features.Product.Commands.CreateProduct;
using Ecommerce.Dominio.ModelDTIN;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.Product.Commands.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, ProductDTO>
    {
        IRepositoryAsync<Ecommerce.Dominio.Product> RepositoryAsync { get; set; }
        IMapper _mapper;

        public UpdateProductCommandHandler(IRepositoryAsync<Dominio.Product> repositoryAsync, IMapper mapper)
        {
            RepositoryAsync = repositoryAsync;
            _mapper = mapper;
        }

        public async Task<ProductDTO> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var actual = await RepositoryAsync.GetByIdAsync(request.Id);


            var product = _mapper.Map<Dominio.Product>(request);
           
            actual.precio = product.precio;
            actual.Cantidad = product.Cantidad;
            actual.CategoryId = product.CategoryId;
            actual.Name = product.Name;

             
            var proresult = await RepositoryAsync.UpdateAsync(actual);
            return _mapper.Map<ProductDTO>(proresult);
        }
    }
}
