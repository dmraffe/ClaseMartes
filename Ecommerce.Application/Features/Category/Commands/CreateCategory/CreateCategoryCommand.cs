using Ecommerce.Dominio.ModelDTIN;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.Category.Commands.CreateCategory
{
    public class CreateCategoryCommand : IRequest<CategoryDTO>
    {
        public string Name { get; set; }
    }
}
