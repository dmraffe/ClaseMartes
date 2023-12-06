using Clase.Herencia.EjemploInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StaticTests.caminar();

            var Impleuno = new ImplementacionUno();
            var Impledos = new ImplementacionDos();

            MostrarMensajes(Impleuno);
            MostrarMensajes(Impledos);

            ClaseSingleton cs =   ClaseSingleton.GetClaseSingleton("asdas");


           

            cs = ClaseSingleton.GetClaseSingleton("asdas");
            cs.Nombre = "Jose";
            cs = ClaseSingleton.GetClaseSingleton("asdas");
            cs.Nombre = "Pepe";
            cs = ClaseSingleton.GetClaseSingleton("asdas");

            cs.Nombre = "Pedro";
            
       

            Math.Min(1, 1); 

            var Circulo = new Circulo(2);

            var Cuadrado = new Cuadrado(4);

            var Rect = new Rectangulo(3);

            var Pepito = new Pepito(2, 36);

            imprimir(Circulo);
            imprimir(Cuadrado);
            imprimir(Rect);
            imprimir(Pepito);


            Console.Clear();
            #region Conversiones 

            //valueanint can hold, and more!
            int num = 2147483647;
            long bigNum = num;

            Console.WriteLine(bigNum);




            double x = 1234.7;
            int a;
            // Cast doubletoint.
            a = (int)x;
            System.Console.WriteLine(a);



            Jirafa g = new Jirafa();
            // La conversión implícita al tipo base es segura 
            // Pasa implícitamente de tipo Jirafa a tipo Animal. 
            // La clase derivada Jirafa tiene herencia de la clase base Animal. 
            Animal ani = g;

            g = (Jirafa)ani;

            int i = 123;
            // Thefollowing line boxes i.
            object o = i;

            o = 123;
            i = (int)o; // unboxing 



            Console.WriteLine(o);
            Console.WriteLine(i);


            int t = 123;
            object to = t; // implicitboxing
            try
            {
                string sr = i.ToString();
                int j = (int)to; // attempttounbox
                System.Console.WriteLine("Unboxing OK.");
            }
            catch (System.InvalidCastException e)
            {
                System.Console.WriteLine("{0} Error: Incorrectunboxing.",
                e.Message);
            }


                                

            Console.ReadKey();
            #endregion

        }


        public static void MostrarMensajes(IbaseEjemplo ibaseEjemplo)
        {

            ibaseEjemplo.Crear();
            ibaseEjemplo.Eliminar();
            ibaseEjemplo.Modificar();
             
        }

        public static void imprimir(Figura fr)
        {


            Console.WriteLine(fr.Perimetro());
        }

        public static double CalcularPerimetro(Circulo cr)
        {


            return cr.ValorLados * 2 * Math.PI;
        }


        public static double CalcularPerimetro(Cuadrado cr)
        {


            return cr.ValorLados * cr.NumeroDeLados;
        }

        public static double CalcularPerimetro(Rectangulo cr)
        {


            return cr.ValorLados * cr.NumeroDeLados;
        }

        public static double CalcularPerimetro(double valordelados, int numerodelados, string figura)
        {
            switch (figura)
            {
                case "cuadrado": return valordelados * numerodelados;
                case "circulo": return valordelados * 2 * Math.PI;
                case "triangulo": return valordelados * numerodelados;
                default:
                    break;
            }

            return 0;
        }



        public class PersonaEjmplo
        {
            public string Nombre { get; set; }
        }

        public class PersonaEjmploSistema
        {
            public string Name { get; set; }
        }


        public static class StaticTests
        {

       
            public static void caminar()
            { 
            
            }

            public static PersonaEjmploSistema PersonaEjmploSistema(PersonaEjmplo personaEjmplo)
            {   
                return new PersonaEjmploSistema { Name = personaEjmplo.Nombre};
            }
        }

      

        
    }



    public class ClaseSingleton
    { 
    
         public static ClaseSingleton claseSingleton {  get; set; }
        public string Nombre { get; set; }


        private ClaseSingleton(string nombre) {
            Nombre = nombre;
        
        }
        public static ClaseSingleton GetClaseSingleton(string nombre)
        { 
               if(claseSingleton == null)
                claseSingleton = new ClaseSingleton(nombre);

               return claseSingleton;
        }
         
    }


   
}
 
