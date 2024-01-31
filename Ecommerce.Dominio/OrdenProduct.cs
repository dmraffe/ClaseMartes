using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Dominio
{
    public class OrdenProduct :TableBase
    {
       public int ProductID { get; set; }

       public int OrdenID { get; set; }

      public decimal Price { get; set; }

      public int Quantity { get; set; }

    }
}
