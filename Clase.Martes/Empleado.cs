using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Martes
{
    public class Empleado  
    {
        
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public decimal SalarioBase { get; private set; }
        public decimal Bono{ get; private set; }

        public Empleado(string nombre, string apellido, decimal salarioBase, decimal bono)
        {
            
            Nombre = nombre;
            Apellido = apellido;
            SalarioBase = salarioBase;
            Bono = bono;

           
        }

        public Empleado() { 
        }

        public virtual string NombreCompleto => Nombre + " " + Apellido;
       
    }

    
}
