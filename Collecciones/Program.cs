using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Collecciones
{
    internal class Program
    {
        public static int MegaAniosLuz { get; private set; }
        public static string Nombre { get; private set; }

        static void Main(string[] args)
        {
            ArrayList ListaA = new ArrayList();

            /*  List<Persona> personas = new List<Persona>();


               personas.Add(new Persona("nombre", "apellido", "asda", 1));
               personas.Add(new Persona("nombre", "apellido", "asda", 1));
               personas.Add(new Persona("nombre", "apellido", "asda", 1));
               personas.Add(new Persona("nombre", "apellido", "asda", 1));
               personas.Add(new Persona("nombre", "apellido", "asda", 1));
               personas.Add(new Persona("nombre", "apellido", "asda", 1));
               personas.Add(new Persona("nombre", "apellido", "asda", 1));
               personas.Add(new Persona("nombre", "apellido", "asda", 1));
               personas.Add(new Persona("nombre", "apellido", "asda", 1)); 
               personas.Add(new Persona("nombre", "apellido", "asda", 1));
               personas.Add(new Persona("nombre", "apellido", "asda", 1));
               personas.Add(new Persona("nombre", "apellido", "asda", 1));
               personas.Add(new Persona("nombre", "apellido", "asda", 1));
               personas.Add(new Persona("nombre", "apellido", "asda", 1));
               personas.Add(new Persona("nombre", "apellido", "asda", 1));
               personas.Add(new Persona("nombre", "apellido", "asda", 1));
               personas.Add(new Persona("nombre", "apellido", "asda", 1));
               personas.Add(new Persona("nombre", "apellido", "asda", 1));
               personas.Add(new Persona("nombre", "apellido", "asda", 1));
               personas.Add(new Persona("nombre", "apellido", "asda", 1));
               personas.Add(new Persona("nombre", "apellido", "asda", 1));
               personas.Add(new Persona("nombre", "apellido", "asda", 1));


               foreach (Persona persona in personas)
               {

                   Console.WriteLine(persona.MostrarDatos());
               }

               ListaA.Add(new Persona("nombre","apellido","asda",1));




               foreach (object item in ListaA)
   {
                   //Se muestra el tipo de objeto

                   //Se decide como mostrar el item segun sea el tipo de objeto
                   if (item.GetType() == typeof(System.Int32))
                   {
                       Console.WriteLine("Valor: {0}", (int)item);
                   }
                   if (item.GetType() == typeof(string))
                   {
                       Console.WriteLine("Valor: {0}", item.ToString());
                   }
                   if (item.GetType() == typeof(Persona))
                   {
                       Persona objPersona = (Persona)item;
                       Console.WriteLine("Valor: {0}", objPersona.Nombre + " " +objPersona.Apellido);
                   }
               }
                       */



            /*SortedList<string, int> ListaOrdenada = new SortedList<string, int>();
            ListaOrdenada.Add("C", 300);
            ListaOrdenada.Add("A", 100);
            ListaOrdenada.Add("B", 200);


            Console.WriteLine(ListaOrdenada["A"]);
            Console.WriteLine(ListaOrdenada["B"]);
            Console.WriteLine(ListaOrdenada["C"]);


            foreach (KeyValuePair<string, int> item in ListaOrdenada)
            {
                Console.WriteLine("Clave: {0}. Valor: {1}",item.Key, item.Value);
            }     */


            /*Queue<Persona> Cola = new Queue<Persona>();
            Cola.Enqueue(new Persona("Ana", "González"));
            Cola.Enqueue(new Persona("Pedro", "Benítez"));
            Cola.Enqueue(new Persona("Isabel", "Pérez"));

            while (Cola.Count > 0)
            {
                Persona item = Cola.Dequeue();
                Console.WriteLine("{0}, {1}", item.Apellido, item.Nombre);
            }

                */


            /*
             Stack<Persona> Pila = new Stack<Persona>();
             Pila.Push(new Persona("Ana", "González"));
             Pila.Push(new Persona("Pedro", "Benítez"));
             Pila.Push(new Persona("Isabel", "Pérez"));


             while (Pila.Count > 0)
             {
                 Persona item = Pila.Pop();
                 Console.WriteLine("{0}, {1}", item.Apellido, item.Nombre);
             }    */


            var artesMarciales = new List<string> { "Taekwondo", "KungFu", "Karate", "Aikido" };

            //artesMarciales.Add("Taekwondo");
            //artesMarciales.Add("KungFu");
            //artesMarciales.Add("Karate");
            //artesMarciales.Add("Aikido");
            // Iterar cada elemento de la lista.

            artesMarciales.Remove("KungFu");
            /* foreach (var arte in artesMarciales)
             {
                 Console.WriteLine(arte + " ");
             }

             for (var index = 0; index < artesMarciales.Count; index++)
             {
                 Console.WriteLine(artesMarciales[index] + " ");
             }  */



            //var numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //// Remover números Pares. 
            //for (var index = numbers.Count - 1; index >= 0; index--)
            //{
            //    if (numbers[index] % 2 == 1)
            //    {
            //        // Remover el elemento especificando el
            //        numbers.RemoveAt(index); 
            //    }
            //}
            //// Iterar la lista 
            //numbers.ForEach(number => Console.WriteLine(number + " "));


            List<Galaxia> lasGalaxias = new List<Galaxia> {
                new Galaxia() { Nombre = "Tadpole", MegaAniosLuz = 400},
                new Galaxia() { Nombre = "Pinwheel", MegaAniosLuz = 25},
                new Galaxia() { Nombre = "MilkyWay", MegaAniosLuz = 0},
                new Galaxia() { Nombre = "Andromeda", MegaAniosLuz = 3}
            };
            foreach (Galaxia laGalaxia in lasGalaxias)
            {
                Console.WriteLine(laGalaxia.Nombre + " " + laGalaxia.MegaAniosLuz);
            }
            Dias ed = 0;
          
            
            
            switch (ed)
            {
                case Dias.Sab:
                    break;
                case Dias.Dom:
                    break;
                case Dias.Lun:
                    break;
                case Dias.Mar:
                    break;
                case Dias.Mie:
                    break;
                case Dias.Jue:
                    break;
                case Dias.Vie:
                    break;
            };



            Console.ReadKey();

        }

    }
}
