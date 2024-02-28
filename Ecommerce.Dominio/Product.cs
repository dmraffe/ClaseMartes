using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Dominio
{
    public class Product : TableBase
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int CategoryId { get; set; }

        public int Cantidad { get; set; }
        public decimal precio { get; set; }

        public virtual Category Category { get; set; }

    }
}
