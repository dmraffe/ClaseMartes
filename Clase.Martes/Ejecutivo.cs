using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Martes
{
    public class Ejecutivo : Empleado
    {
        private const decimal SalarioBase  = 10000;
            
        private const decimal bono = 10000;

        public string direccion {  get; set; } = string.Empty;
        public Ejecutivo(string nombre, string apellido) : base( nombre, apellido, SalarioBase, bono)
        {

        }

        public Ejecutivo() : base()
        { }

        public override string NombreCompleto => "Sr. "+Nombre + " " + Apellido;
    }
}
