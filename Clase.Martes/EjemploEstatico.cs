using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Martes
{
    public class EjemploEstatico
    {

        public static EjemploEstatico objetoestatico { get; private set; }
        public static EjemploEstatico CreateObject()
        {
            if (objetoestatico == null)
            {
                objetoestatico = new EjemploEstatico();
            }

            return objetoestatico;
        }
        public static void HolaMundo()
        {
            if (string.IsNullOrEmpty(Saludo))
            {
                Console.WriteLine("Saludo no tiene ningun valor");
                return;
            }
            Console.WriteLine(Saludo);
        }


        public static string Saludo = string.Empty;

        public void SaludarInstancia()
        {
            Console.WriteLine(SaludoInstancia);
        }

        public string SaludoInstancia { get; set; }
    }
}
