using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Martes
{
    public class Auto
    {
        public int velocidad {  get; private  set; }

        public Auto() {
            velocidad = 0;
        }

        public void Acelerar(int velocidad)
        {
            this.velocidad += velocidad;
        }

        public void Frenar(int velocidad) { 
            this.velocidad -= velocidad; 
        }

    }
}
