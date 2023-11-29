using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Herencia
{
    public class Figura  
    {
        public int NumeroDeLados { get; private set; }
        public double ValorLados { get; private set; }

        public Figura(int numeroDeLados,double valor)
        {
            NumeroDeLados = numeroDeLados;
            ValorLados = valor;
        }

        public virtual double Perimetro() {
            Console.WriteLine("Estoy en la clase padre");
            return 0; 
        }
    }
}
