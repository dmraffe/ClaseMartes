using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collecciones
{
    public class Persona
    {
        public int Id { get; set; }

        public string Comentario { get; set; }
        public string Nombre { get; internal set; }
        public string Apellido { get; internal set; }

        public Persona(string nombre, string apellido, string comentario,int id)
        {
            Nombre = nombre;
            Apellido = apellido;
            Comentario = comentario;
            Id = id;
        }

        public Persona(string nombre, string apellido )
        {
            Nombre = nombre;
            Apellido = apellido;
           
        }

        public string MostrarDatos()
        {
           
            return Id+" "+Nombre+" "+Apellido+ " "+Comentario;
        }
    }


    public enum Dias    
    {
        Sab  =7, 
        Dom = 1, 
        Lun =2, 
        Mar = 3, 
        Mie = 4, 
        Jue = 5, 
        Vie  = 6
        };
}
