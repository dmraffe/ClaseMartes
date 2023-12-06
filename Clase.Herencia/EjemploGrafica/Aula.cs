using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Herencia.EjemploGrafica
{
    public class Aula
    {
        public Aula(string pCodigo, int pCapacidad)
        {
            this.Codigo = pCodigo;
            this.Capacidad = pCapacidad;
        }
        public string Codigo { get; set; }
        public int Capacidad { get; set; }

    }
}
