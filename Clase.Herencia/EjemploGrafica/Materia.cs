using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Herencia.EjemploGrafica
{
    public class Materia
    {
        public Materia(string pNombre, string pPrograma)
        {
            this.Nombre = pNombre;
            this.Programa = pPrograma;
        }
        public string Nombre { get; set; }
        public string Programa { get; set; }

    }
}
