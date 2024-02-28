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

namespace Ecommerce.Application.Features.Category.Commands.UpdateCategory
{
    public class UpdateCategoryHandler : IRequestHandler<UpdateCategoryCommand, CategoryDTO>
    {
        IRepositoryAsync<Ecommerce.Dominio.Category> RepositoryAsync { get; set; }
        IMapper _mapper;

        public UpdateCategoryHandler(IRepositoryAsync<Dominio.Category> repositoryAsync, IMapper mapper)
        {
            RepositoryAsync = repositoryAsync;
            _mapper = mapper;
        }

        public async Task<CategoryDTO> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var cate = _mapper.Map<Dominio.Category>(request);

            var categoriaaux = await RepositoryAsync.GetByIdAsync(cate.Id);

            categoriaaux.Name = cate.Name;

            var categoriaupdate = await RepositoryAsync.UpdateAsync(categoriaaux);

            return _mapper.Map<CategoryDTO>(categoriaupdate);
        }
    }
}
