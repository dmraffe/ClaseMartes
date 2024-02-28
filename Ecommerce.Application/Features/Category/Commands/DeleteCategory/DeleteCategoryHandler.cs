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

namespace Ecommerce.Application.Features.Category.Commands.DeleteCategory
{
    public class DeleteCategoryHandler : IRequestHandler<DeleteCategoryCommand, bool>
    {
        IRepositoryAsync<Ecommerce.Dominio.Category> RepositoryAsync { get; set; }
        IMapper _mapper;

        public DeleteCategoryHandler(IRepositoryAsync<Dominio.Category> repositoryAsync, IMapper mapper)
        {
            RepositoryAsync = repositoryAsync;
            _mapper = mapper;
        }

        public async Task<bool> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            var cate = _mapper.Map<Dominio.Category>(request);

            var categoriaaux = await RepositoryAsync.DeleteAsync(cate);

            

            return true;
        }
    }
}
