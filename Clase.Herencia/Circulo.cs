using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Herencia
{
    public class Circulo : Figura
    {

      
        public Circulo(double valor) : base(0, valor)
        {

        }


        public override double Perimetro()
        {
            Console.WriteLine("Estoy en la clase Circulo");
            return base.ValorLados * 2 * Math.PI;
        }
    }
}
