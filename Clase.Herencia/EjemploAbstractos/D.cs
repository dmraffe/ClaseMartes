using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Herencia.EjemploAbstractos
{
    public class D
    {
        public virtual void HacerAlgo(int i)
        {
            // Implementación Original.
        }
    }

    public class J : D
    {
        public override void HacerAlgo(int i)
        {
            base.HacerAlgo(i);
        }
    }


    public abstract class E: D
    {
        public abstract override void HacerAlgo(int i);
    }

    public class F : E
    {
        public override void HacerAlgo(int i)
        {
             
        }
    }


}
