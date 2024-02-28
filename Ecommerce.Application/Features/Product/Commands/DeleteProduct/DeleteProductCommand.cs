using Ecommerce.Dominio.ModelDTIN;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.Product.Commands.DeleteProduct
{
    public class DeleteProductCommand : IRequest<bool>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int Cantidad { get; set; }
        public decimal precio { get; set; }

        public int CategoryId { get; set; }

        public int Id { get; set; }
    }
}
