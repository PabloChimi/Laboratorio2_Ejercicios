using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Nro5
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;


        public Producto(string marca, string codigo, float precio)
        {
            this.codigoDeBarra = codigo;
            this.marca = marca;
            this.precio = precio;
        }


        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }
        /*
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;

            return Equals((Producto)obj);
        }

        public override int GetHashCode()
        {
            return int.Parse(this.codigoDeBarra);
        }
        */
        public static bool operator ==(Producto p, string marca)
        {
            
            if (!(Object.ReferenceEquals(p, null)) && !(Object.ReferenceEquals(marca, null)))
            {
                if (object.ReferenceEquals(p.marca, marca))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Producto p, string marca)
        {
            
            if (p.marca == marca)
            {
                return false;
            }
            return true;
        }
        
        public static bool operator ==(Producto p, Producto t)
        {
            bool retorno = false;
            if (!Object.ReferenceEquals(p, null) && !Object.ReferenceEquals(t, null))
            {
                if (Object.Equals(p.marca, t.marca) && Object.ReferenceEquals(p.codigoDeBarra, t.codigoDeBarra))
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Producto p, Producto t)
        {
            bool retorno = true;
            if (p == t)
            {
                retorno = false;
            }
            return retorno;
        }
        
        public static string MostrarProducto(Producto p)
        {
            string retorno;
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0,20}", p.codigoDeBarra);
            sb.AppendFormat("{0,20}", p.marca);
            sb.AppendFormat("{0,20}", p.precio);
            retorno = sb.ToString();

            return retorno;
        }

    }
}
