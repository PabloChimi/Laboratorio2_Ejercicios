using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_37
{
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }
        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        //Ver si esta bien la implementacion del constructor
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.nroOrigen = nroOrigen;
            this.nroDestino = nroDestino;
            this.duracion = duracion;
        }

        public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno;
            if(llamada1.Duracion == llamada2.Duracion)
            {
                return 0;
            }
            retorno = (llamada1.Duracion > llamada2.Duracion) ? 1 : 2;
            return retorno;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Duracion: {0} NroDestino: {1} NroOrigen: {2}", this.Duracion, this.NroDestino, this.NroOrigen);
            return sb.ToString();
        }

        public enum TipoLlamada
        {
            Local = 0,
            Provincial = 1,
            Todas = 2,
        }
        

    }
}
