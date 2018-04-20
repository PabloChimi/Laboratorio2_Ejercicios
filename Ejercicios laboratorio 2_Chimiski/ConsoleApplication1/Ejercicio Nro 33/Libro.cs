using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_33
{
    class Libro
    {
        private List<string> paginas;

        public Libro()
        {
            this.paginas = new List<string>(10);
        }
        public string this[int i]
        {
            get
            {
                if (i < paginas.Count)
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
                    for (int j = 0; j < 0; j++)
                    {
                        if (ReferenceEquals(paginas[j], null) && i != j)
                        {
                        }
                    }
                    paginas[i] = value;
                }
                else
                {
                    paginas.Add(value);
                }
            }
        }

    }
}
