using AutoMapper;
using Ecommerce.Application.Contract.Repository;
using Ecommerce.Application.Features.Product.Commands.UpdateProduct;
using Ecommerce.Dominio.ModelDTIN;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.Product.Commands.DeleteProduct
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, bool>
    {
        IRepositoryAsync<Ecommerce.Dominio.Product> RepositoryAsync { get; set; }
        IMapper _mapper;

        public DeleteProductCommandHandler(IRepositoryAsync<Dominio.Product> repositoryAsync, IMapper mapper)
        {
            RepositoryAsync = repositoryAsync;
            _mapper = mapper;
        }

        public async Task<bool> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<Dominio.Product>(request);
            var proresult = await RepositoryAsync.DeleteAsync(product);
            return true;
        }
    }
}
