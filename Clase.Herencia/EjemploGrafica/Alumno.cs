using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Herencia.EjemploGrafica
{
    public class Alumno : Persona
    {
        public Alumno(string pNombre, string pApellido, bool pRegular)
        {
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.Regular = pRegular;
        }
        public bool Regular { get; set; }
    }
}
