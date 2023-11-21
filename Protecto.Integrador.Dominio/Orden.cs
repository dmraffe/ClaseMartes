using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protecto.Integrador.Dominio
{
    public class Orden
    {
        public int Id {  get; set; }
        public Producto Producto { get; set; }

        public Cliente Cliente { get; set; }
        public DateTime Fecha { get; set; }

        public decimal Precio { get; set; }
    }
}
