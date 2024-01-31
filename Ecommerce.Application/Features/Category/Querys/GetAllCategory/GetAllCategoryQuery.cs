using Ecommerce.Dominio.ModelDTIN;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.Category.Querys.GetAllCategory
{
    public class GetAllCategoryQuery  : IRequest<List<CategoryDTO>>
    {
    }
}
