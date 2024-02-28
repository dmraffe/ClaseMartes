using Ecommerce.Dominio.ModelDTIN;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.Carrito.Commands.ManagerCarrito
{
    public class ManagerCarritoCommand : IRequest<CarritoDto>
    {

        public int articulo { get; set; }
        public int idCarrito { get; set; }

        public int cantidad { get; set; }
    }
}
