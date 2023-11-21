using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Martes
{
    public class Administrativo : Empleado
    {
        private const decimal SalarioBase = 10000;

        private const decimal bono = 10000;
        public Administrativo(string nombre, string apellido) : base(nombre, apellido, SalarioBase, bono)
        {

        }

        public override string NombreCompleto => Nombre + " " + Apellido;
    }
}
