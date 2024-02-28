using AutoMapper;
using Ecommerce.Application.Contract.Repository;
using Ecommerce.Application.Features.Category.Commands.DeleteCategory;
using Ecommerce.Dominio.ModelDTIN;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.Product.Commands.CreateProduct
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, ProductDTO>
    {
        IRepositoryAsync<Ecommerce.Dominio.Product> RepositoryAsync { get; set; }
        IMapper _mapper;

        public CreateProductHandler(IRepositoryAsync<Dominio.Product> repositoryAsync, IMapper mapper)
        {
            RepositoryAsync = repositoryAsync;
            _mapper = mapper;
        }

        public async Task<ProductDTO> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<Dominio.Product>(request);
            var proresult = await RepositoryAsync.AddAsync(product);  
            return _mapper.Map<ProductDTO>(proresult);
        }
    }
}
