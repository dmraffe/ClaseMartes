using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Herencia
{
    public class Cuadrado : Figura
    {
        const int numerodelados = 4;
        public Cuadrado(double valordelados) : base(numerodelados, valordelados)
        {
        }

        public override double Perimetro()
        {
            Console.WriteLine("Estoy en la clase Cuadrado");
            return base.ValorLados * base.NumeroDeLados;
        }
    }
}
