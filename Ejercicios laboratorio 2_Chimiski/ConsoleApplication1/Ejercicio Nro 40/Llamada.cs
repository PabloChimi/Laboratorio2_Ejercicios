﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_37
{
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

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

        //Ver si esta bien la implementacion del constructor
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.nroOrigen = nroOrigen;
            this.nroDestino = nroDestino;
            this.duracion = duracion;
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno;
            if(llamada1.Duracion == llamada2.Duracion)
            {
                return 0;
            }
            retorno = (llamada1.Duracion > llamada2.Duracion) ? 1 : -1;
            return retorno;
        }

        public static bool operator ==(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.Equals(llamada2))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Llamada llamada1, Llamada llamada2)
        {
            return !(llamada1 == llamada2);
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Duracion: {0,2} NroDestino: {1,-10} NroOrigen: {2,-10}", this.Duracion, this.NroDestino, this.NroOrigen);
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
