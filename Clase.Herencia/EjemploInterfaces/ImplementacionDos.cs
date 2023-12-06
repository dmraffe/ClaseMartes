using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Herencia.EjemploInterfaces
{
    public class ImplementacionDos : IbaseEjemplo
    {
        public void Crear()
        {
            Console.WriteLine($"Crear ImplementacionUno {this.GetType().Name}");
        }

        public void Eliminar()
        {
            Console.WriteLine($"Eliminar ImplementacionUno {this.GetType().Name}");
        }

        public void Modificar()
        {
            Console.WriteLine($"Modificar ImplementacionUno {this.GetType().Name}");
        }
    }
}
