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

namespace Ecommerce.Application.Features.Category.Querys.GetByIdCategory
{
    internal class GetByIdQueryHandle : IRequestHandler<GetByIdQuery,  CategoryDTO>
    {
        IRepositoryAsync<Ecommerce.Dominio.Category> RepositoryAsync { get; set; }
        IMapper _mapper;
        public GetByIdQueryHandle(IRepositoryAsync<Dominio.Category> repositoryAsync, IMapper mapper)
        {
            RepositoryAsync = repositoryAsync;
            _mapper = mapper;
        }

        public async Task<CategoryDTO> Handle(GetByIdQuery request, CancellationToken cancellationToken)
        {
            var lista = await RepositoryAsync.GetByIdAsync(request.Id);


            CategoryDTO categoryDTOs =  _mapper.Map<Ecommerce.Dominio.Category, CategoryDTO>(lista);



            return categoryDTOs;
        }
    }
}
