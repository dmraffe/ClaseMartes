using Clase.Visibilidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Martes
{
    public class ClasePruebaInternal  : ClasePadre
    {

        public ClasePruebaInternal()
        {
          
            base.protectedinternal = 1;
        }
    }
}
