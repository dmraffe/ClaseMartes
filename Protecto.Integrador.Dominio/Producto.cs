using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protecto.Integrador.Dominio
{
    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; } 
        public string UrlImagen { get; set; }   

    }
}
