using AutoMapper;
using Ecommerce.Application.Contract.Repository;
using Ecommerce.Dominio.ModelDTIN;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.Category.Querys.GetAllCategory
{
    public class GetAllCategoryQueryHandle : IRequestHandler<GetAllCategoryQuery, List<CategoryDTO>>
    {
        IRepositoryAsync<Ecommerce.Dominio.Category>  RepositoryAsync { get; set; }
        IMapper _mapper;
        public GetAllCategoryQueryHandle(IRepositoryAsync<Dominio.Category> repositoryAsync, IMapper mapper)
        {
            RepositoryAsync = repositoryAsync;
            _mapper = mapper;
        }

        public async Task<List<CategoryDTO>> Handle(GetAllCategoryQuery request, CancellationToken cancellationToken)
        {

            var lista = await RepositoryAsync.GetAllAsync();


            List<CategoryDTO> categoryDTOs = lista.Select(cat => _mapper.Map<Ecommerce.Dominio.Category, CategoryDTO>(cat)).ToList();

         

            return categoryDTOs;
        }
    }
}
