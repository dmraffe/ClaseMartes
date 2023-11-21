using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Martes.OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new MercedesBens();

            auto.Acelerar(1);
            auto.Acelerar(1);
            auto.Acelerar(1);
            auto.Acelerar(1);
            auto.Acelerar(1);
            auto.Acelerar(1);
            auto.Acelerar(1);


            auto.Frenar(2);
            auto.Frenar(2);
            Console.WriteLine($"mi velociada actual es: {auto.velocidad}");

            /**POlimorfismo**/




            var ejecutivo = new Ejecutivo("Wilson","Perez");
            var Admin = new Administrativo("Jose", "Carrera");
            var Obrero = new Obreros("Pedro", "Montiel");

            
            MostrarNombreEmpleado(ejecutivo);
            MostrarNombreEmpleado(Admin);
            MostrarNombreEmpleado(Obrero);

          

            ejecutivo = new Ejecutivo("Wilson", "Perez");
            ejecutivo = new Ejecutivo();
          ClasedePrueba clasedePrueba = new ClasedePrueba();

            clasedePrueba.Horas = 24;
         
            Console.WriteLine($"La cantidad de Horas  es: {clasedePrueba.Horas}");


            Coordenadas p1 = new Coordenadas();
            Coordenadas p2 = new Coordenadas(5, 3);
            Console.ReadKey(); 

        }

        public static void MostrarNombreEmpleado(Empleado empleado)
        {
            Console.WriteLine(empleado.NombreCompleto);
        }
    }
}
