using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Martes
{
    public class ClasedePrueba
    {
        private double segundos;
        public double Horas
        {
            get { return segundos / 3600; }
            set { segundos = value * 3600; }
        }


        public int valor {  get; set; }

        public string NombreCompleto => Nombre + " " + Apellido;

        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
    }
}
