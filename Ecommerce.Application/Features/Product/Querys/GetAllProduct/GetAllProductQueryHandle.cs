using AutoMapper;
using Ecommerce.Application.Contract.Repository;
using Ecommerce.Application.Features.Category.Querys.GetAllCategory;
using Ecommerce.Dominio.ModelDTIN;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.Product.Querys.GetAllProduct
{
    public class GetAllProductQueryHandle : IRequestHandler<GetAllProductQuery, List<ProductDTO>>
    {

        IRepositoryAsync<Ecommerce.Dominio.Product> RepositoryAsync { get; set; }
        IMapper _mapper;

        public GetAllProductQueryHandle(IRepositoryAsync<Dominio.Product> repositoryAsync, IMapper mapper)
        {
            RepositoryAsync = repositoryAsync;
            _mapper = mapper;
        }

        public async Task<List<ProductDTO>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            var lista = await RepositoryAsync.GetAllAsync();


            List<ProductDTO> categoryDTOs = lista.Select(cat => _mapper.Map<Ecommerce.Dominio.Product, ProductDTO>(cat)).ToList();



            return categoryDTOs;
        }
    }
}
