using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloModulo9
{
    public class Producto : TablaBase
    {
        public decimal Precio {  get; set; }

        public string Nombre { get; set; }

        public bool EsPromocion {  get; set; }

    }
}
