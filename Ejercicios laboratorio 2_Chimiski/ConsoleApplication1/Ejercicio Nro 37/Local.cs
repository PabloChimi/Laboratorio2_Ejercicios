using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_37
{
    public class Local : Llamada
    {
        protected float costo;

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        public Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        private float CalcularCosto()
        {
            return this.costo * Duracion;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Caracteristicas llamada: {0} \n Costo llamada: {1} \n", base.Mostrar(), this.CostoLlamada);
            return sb.ToString();
        }
    }
}
