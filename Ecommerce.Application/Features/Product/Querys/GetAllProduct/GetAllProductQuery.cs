using Ecommerce.Dominio.ModelDTIN;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.Product.Querys.GetAllProduct
{
    public class GetAllProductQuery : IRequest<List<ProductDTO>>
    {
    }
}
