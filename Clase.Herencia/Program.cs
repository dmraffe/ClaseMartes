using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            g = (Jirafa) ani;

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
                string sr =  i.ToString();
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

        public static void imprimir(Figura fr)
        {


              Console.WriteLine(fr.Perimetro());
        }

        public static double CalcularPerimetro(Circulo cr)
        {


            return cr.ValorLados * 2 * Math.PI ;
        }


        public static double CalcularPerimetro(Cuadrado cr)
        {


            return cr.ValorLados *cr.NumeroDeLados;
        }

        public static double CalcularPerimetro(Rectangulo cr)
        {


            return cr.ValorLados * cr.NumeroDeLados;
        }

        public static double CalcularPerimetro(double valordelados, int numerodelados, string figura)
        {
            switch (figura)
            {
                case "cuadrado": return  valordelados* numerodelados;
                case "circulo": return valordelados * 2 * Math.PI;
                case "triangulo": return valordelados * numerodelados;
                default:
                    break;
            }

            return 0;
        }
    }
}
