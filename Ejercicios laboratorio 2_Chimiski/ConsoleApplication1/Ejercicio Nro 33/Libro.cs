using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_33
{
    class Libro
    {
        private List<string> paginas = new List<string>(10);

        public string this[int i]
        {
            get
            {
                if (i < paginas.Capacity)
                {
                    return paginas.ElementAt(i);
                }
                else
                {
                    return "";
                }
            }

            set
            {

                if (i < paginas.Count) //Ver bien esta parte
                {
                    paginas[i] = value;
                }
                else
                {
                    List<string> nuevoLibro = new List<string>(paginas.Capacity - i);
                    nuevoLibro.Concat(nuevoLibro);
                    paginas[i] = value;
                }
            }
        }

    }
}
