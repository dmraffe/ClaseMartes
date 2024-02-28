using Ecommerce.Dominio.ModelDTIN;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.Category.Commands.UpdateCategory
{
    public class UpdateCategoryCommand : IRequest<CategoryDTO>
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
