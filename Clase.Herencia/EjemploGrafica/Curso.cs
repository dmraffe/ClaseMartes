using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Herencia.EjemploGrafica
{
    public class Curso
    {
        public Curso(Instructor pInstructor, Materia pMateria, List<Alumno> pAlumnos, List<Clase> PClases)
        {
            this.Instructor = pInstructor;
            this.Materia = pMateria;
            this.Alumnos = pAlumnos;
            this.Clases = PClases;
        }
        public Instructor Instructor { get; private set; } //Relación 1 a muchos
        public Materia Materia { get; private set; } //Relación 1 a muchos
        public List<Alumno> Alumnos { get; private set; } //Relación muchos a muchos
        public List<Clase> Clases { get; private set; } //Relación muchos a muchos


        public void Cambiarmateria(Materia materia)
        {
            this.Materia = materia;
        }

    }
}
