using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Herencia.EjemploGrafica
{
    public class Clase
    {
        public Clase(DateTime pInicio, DateTime pFin, Aula pAula)
        {
            this.Inicio = pInicio;
            this.Fin = pFin;
            this.Aula = pAula;
        }
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public Aula Aula { get; set; } //Relación 1 a muchos

    }
}
