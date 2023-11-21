using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protecto.Integrador.Dominio
{
    public class Comprobante
    {    
        public DateTime  Fecha {  get; set; }
        public Producto Producto { get; set; }

        public int TotalCantidad { get; set; }

        public decimal TotalPrecio { get; set; }

    }
}
