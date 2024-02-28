using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Dominio.ModelDTIN
{
    public class CarritoDto
    {
        public CarritoDto()
        {
            Products = new List<ProductDTO>();
        }

        public int Id { get; set; }
        public decimal Total { get; set; }
        public string Status { get; set; }
     
        public List<ProductDTO> Products { get; set; }  
    }
}
