using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protecto.Integrador.Dominio
{
    public class Cliente
    {
        public int Id {  get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Sexo Sexo { get; set; }

        public Ciudad  Ciudad { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public  bool Activo { get; set; }

    }

    public enum Sexo
    {
        Femenino = 0,
        Masculino = 1
    }
}
