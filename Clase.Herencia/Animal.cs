using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Herencia
{
    public abstract class Animal
    {

        public abstract void Caminar(int paso);

        public virtual void Caminar()
        {
            Console.WriteLine("caminado");
        }
    }


    public class Jirafa : Animal
    {
        public override void Caminar(int paso)
        {
            Console.WriteLine($"caminado {paso}");
        }
    }


    
}
