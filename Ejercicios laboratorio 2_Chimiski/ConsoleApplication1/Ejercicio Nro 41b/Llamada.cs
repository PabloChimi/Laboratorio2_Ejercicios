using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_41b
{
    public abstract class Llamada
    {
        #region atributos

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        #endregion

        #region propiedades

        public abstract float CostoLlamada
        {
            get;
        }

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

        #endregion

        #region constructores

        //Ver si esta bien la implementacion del constructor
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.nroOrigen = nroOrigen;
            this.nroDestino = nroDestino;
            this.duracion = duracion;
        }

        #endregion

        #region metodos

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno;
            if (llamada1.Duracion == llamada2.Duracion)
            {
                return 0;
            }
            retorno = (llamada1.Duracion > llamada2.Duracion) ? 1 : -1;
            return retorno;
        }

        #endregion

        #region sobrecarga de operadores

        public static bool operator ==(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.Equals(llamada2) && llamada1.NroOrigen == llamada2.NroOrigen && llamada1.NroDestino == llamada2.NroDestino)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Llamada llamada1, Llamada llamada2)
        {
            return !(llamada1 == llamada2);
        }

        #endregion

        #region sobrecarga de metodos

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Duracion: {0,2} NroDestino: {1,-10} NroOrigen: {2,-10}", this.Duracion, this.NroDestino, this.NroOrigen);
            return sb.ToString();
        }

        #endregion

        #region enums

        public enum TipoLlamada
        {
            Local = 0,
            Provincial = 1,
            Todas = 2,
        }

        #endregion

    }
}
