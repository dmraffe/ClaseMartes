using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Dominio
{
    public class Orden : TableBase
    {

        public decimal Total { get; set; }
        public string Status { get; set; }


    }
}
