using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_60
{
    public class Producto
    {
        private int id;
        private string nombre;

        public int Id
        {
            get
            {
                return this.id;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public Producto(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
    }
}
