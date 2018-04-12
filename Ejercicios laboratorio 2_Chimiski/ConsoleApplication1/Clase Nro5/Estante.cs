using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Nro5
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }
        public Estante(int capacidad, int estante):this(capacidad)
        {
            this.productos = new Producto[capacidad];
            this.ubicacionEstante = estante;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static bool operator ==(Estante e, Producto p)
        {
            int i;
            bool retorno = false;
            for (i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i] == p)
                {
                    retorno = true;
                }
            }
            return retorno;
         }

        public static bool operator !=(Estante e, Producto p)
        {
            bool retorno = true;
            if (e == p)
            {
                retorno = false;
            }
            return retorno;

        }

        public static bool operator +(Estante e, Producto p)
        {
            
            int i;
            if(e!=p)
            {
                for(i=0 ; i < e.productos.Length ; i++)
                {
                    if (Object.ReferenceEquals(e.productos[i], null))
                    {
                        
                        e.productos[i] = p;
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator -(Estante e, Producto p)
        {
            bool retorno = false;
            int i;
            if (e == p)
            {
                for (i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] == p)
                    {
                        e.productos[i] = null;
                        retorno = true;
                    }
                }
            }
            return retorno;
        }

        public static string MostrarEstante(Estante e)
        {
            int i;
            string retorno;
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Estante Nro: {0} \n", e.ubicacionEstante);
            for (i = 0; i < e.productos.Length; i++)
            {
                if (!(Object.ReferenceEquals(e.productos[i], null)))
                {
                    //sb.Append(MostrarProducto(e.productos[i]));
                }
            }
            retorno = sb.ToString();
            return retorno;
        }
                

    }
}
