using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ADO.Conectar();
                Console.WriteLine("Conexion exitosa");

                Console.WriteLine(ADO.ContarProductos());

                ADO.GuardarEmpleado(new Empleado(0, "Dixon", "Raffe"));
                ADO.GuardarEmpleado(new Empleado(0, "Dixon 2 ", "Raffe"));
                ADO.GuardarEmpleado(new Empleado(0, "Dixon 23", "Raffe"));
                ADO.GuardarEmpleado(new Empleado(0, "Dixon 123", "Raffe"));

                ADO.GuardarEmpleado(new Empleado(0, "Dixon asdas", "Raffe"));
                ADO.GuardarEmpleado(new Empleado(0, "Dixon asdas" , "Raffe"));

                var listaempleados = ADO.ListarEmpleados();

                foreach (var item in listaempleados)
                { 
                  Console.WriteLine(item.ToString());
                }

                var listadeproductos = ADO.TopTenProductosCaros();

                foreach (var item in listadeproductos)
                {
                    Console.WriteLine(item);
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
            
           Console.ReadLine();
        }
    }
}
