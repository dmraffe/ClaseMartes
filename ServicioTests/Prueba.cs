using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTests
{
    public class Prueba
    {
        public float BasePrice{ get; set; }

        public Prueba(float basePrice)
        {
            BasePrice = basePrice;
        }

        public float GetPriceWithTax(float taxPercent)
        {
            return BasePrice + (BasePrice * (taxPercent / 100));
           
        }
    }
}
