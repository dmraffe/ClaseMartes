using AutoMapper;
using Ecommerce.Application.Contract.Repository;
using Ecommerce.Dominio.ModelDTIN;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.Product.Querys.GetProductById
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ProductDTO>
    {
        IRepositoryAsync<Ecommerce.Dominio.Product> RepositoryAsync { get; set; }
        IMapper _mapper;

        public GetProductByIdQueryHandler(IRepositoryAsync<Dominio.Product> repositoryAsync, IMapper mapper)
        {
            RepositoryAsync = repositoryAsync;
            _mapper = mapper;
        }

        public async Task<ProductDTO> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)

        {
            var lista = await RepositoryAsync.GetByIdAsync(request.Id);


            ProductDTO product = _mapper.Map<Ecommerce.Dominio.Product, ProductDTO>(lista);



            return product;
        }
    }
}
