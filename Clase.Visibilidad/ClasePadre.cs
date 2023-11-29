using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Visibilidad
{
    public class ClasePadre
    {
           public int valorPublico {  get; set; }

         int ValorPrivado { get; set; }

        internal int ValorInternal { get; set; }

        protected int ValorProtected { get; set; }

        protected internal int protectedinternal { get; set; }

    }
}
