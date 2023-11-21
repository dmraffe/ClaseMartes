using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Martes
{
    public class Obreros:Empleado
    {
        private const decimal SalarioBase = 10000;

        private const decimal bono = 10000;
        public Obreros(string nombre, string apellido) : base(nombre, apellido, SalarioBase, bono)
        {

        }
    }

}

