using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clase.Martes
{
    public class MetodosSobrecarga
    {
        string Nombre;
        string Apellido;
        string Inicial;

        public MetodosSobrecarga()
        {

        }

        public MetodosSobrecarga(string Nombre, string Apellido)
        {

        }

        public MetodosSobrecarga(string nombre, string apellido, string inicial)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Inicial = inicial;
        }

        public string MostrarNombreCompleto(string Nombre, string Apellido)
        {
            return $"{Nombre} {Apellido}";
        }
        public string MostrarNombreCompleto(string Nombre)
        {
            return $"{Nombre} ";
        }

        public string MostrarNombreCompleto(string Nombre, string Apellido, string Inicial)
        {
            return $"{Nombre} {Inicial} {Apellido}";
        }

        public string MostrarNombreCompleto()
        {
            return $"{Nombre} {Inicial} {Apellido}";
        }

        public void MostrarArreglo(int[] array)
        {
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }

        public void MostrarArreglo(int[] array, int final)
        {
            for (int i = 0; i < final; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public void MostrarArreglo(int[] array, int inicio, int final)
        {
            for (int i = inicio; i < final; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public void MostrarArreglo(int inicio, int final)
        {
            int[] array = new int[final];
            Random rr;
            for (int i = 0; i < final; i++)
            {
                rr = new Random();
                array[i] = rr.Next();
                Thread.Sleep(1000);

            }


            for (int i = inicio; i < final; i++)
            {
                Console.WriteLine(array[i]);
            }
        }


        private MetodosSobrecarga[] arr = new MetodosSobrecarga[100];

        // Define the indexer to allow client code to use [] notation.
        public MetodosSobrecarga this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
    }

}
