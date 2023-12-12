using System.Data;

namespace ADO.Consola
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; internal set; }
        public string Apellido { get; internal set; }

        public Empleado(int id, string nombre, string apellido)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
        }

        public override string ToString()
        {
            return Nombre + " " + Apellido;
        }
    }
}