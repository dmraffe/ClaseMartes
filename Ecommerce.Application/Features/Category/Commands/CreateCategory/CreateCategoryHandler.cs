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

namespace Ecommerce.Application.Features.Category.Commands.CreateCategory
{
    public class CreateCategoryHandler : IRequestHandler<CreateCategoryCommand, CategoryDTO>
    {
        IRepositoryAsync<Ecommerce.Dominio.Category> RepositoryAsync { get; set; }
        IMapper _mapper;

        public CreateCategoryHandler(IRepositoryAsync<Dominio.Category> repositoryAsync, IMapper mapper)
        {
            RepositoryAsync = repositoryAsync;
            _mapper = mapper;
        }

        public async Task<CategoryDTO> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var cateogria =  _mapper.Map<Dominio.Category>(request);

            var cat = await RepositoryAsync.AddAsync(cateogria);
            
           return _mapper.Map<CategoryDTO>(cat);
        }
    }
}
