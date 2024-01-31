using Ecommerce.Dominio.ModelDTIN;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.Category.Querys.GetByIdCategory
{
    public class GetByIdQuery : IRequest< CategoryDTO>
    {

        public int Id { get; set; }
    }
}
