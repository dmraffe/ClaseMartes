using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Herencia
{
    public class Rectangulo : Figura
    {
        const int numerodelados = 4;
        public Rectangulo(double valordelados) : base(numerodelados, valordelados)
        {
        }
    }
}
