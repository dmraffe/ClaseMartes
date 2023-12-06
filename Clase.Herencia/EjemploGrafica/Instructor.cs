using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Herencia.EjemploGrafica
{
    public class Instructor : Persona
    {
        public Instructor(string pNombre, string pApellido, List<Materia> pMaterias)
        {
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.Materias = pMaterias;
        }
        public List<Materia> Materias { get; set; } //Relación muchos a muchos
    }
}
