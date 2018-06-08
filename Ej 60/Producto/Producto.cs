using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto
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

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Id: {0}  Nombre: {1}\n", this.Id, this.Nombre);
            return sb.ToString();
        }
    }
}
