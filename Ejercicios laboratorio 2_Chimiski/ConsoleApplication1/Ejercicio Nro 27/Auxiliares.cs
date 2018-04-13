using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_27
{
    class Auxiliares
    {
        public static int CompararEnteros(int a, int b)
        {
            return Math.Sign(a.CompareTo(b));
        }
    }
}
