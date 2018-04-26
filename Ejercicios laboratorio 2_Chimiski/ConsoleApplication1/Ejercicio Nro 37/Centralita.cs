using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_Nro_37
{
    public class Centralita
    {

        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public float GananciasPorLocal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }
        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }
        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa)
            : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float gananciaTotal = 0;
            float gananciaLocal = 0;
            float gananciaProvincial = 0;
            float retorno = 0;
            int i;
            
            for (i = 0; i < this.Llamadas.Count; i++)
            {
                if (this.Llamadas[i] is Local)
                {
                    Local local = (Local)this.Llamadas[i];
                    gananciaLocal = local.CostoLlamada + gananciaLocal;
                    gananciaTotal = local.CostoLlamada + gananciaTotal;
                }
                else
                {
                    Provincial provincial = (Provincial)this.Llamadas[i];
                    gananciaProvincial = provincial.CostoLlamada + gananciaProvincial;
                    gananciaTotal = provincial.CostoLlamada + gananciaTotal;
                }
            }

            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    {
                        retorno = gananciaLocal;
                        break;
                    }
                case Llamada.TipoLlamada.Provincial:
                    {
                        retorno = gananciaProvincial;
                        break;
                    }
                case Llamada.TipoLlamada.Todas:
                    {
                        retorno = gananciaTotal;
                        break;
                    }
            }
            return retorno;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Razon social: {0} Ganancia por llamados locales: {1} Ganancia por llamados provinciales: {2} Ganancias totales: {3}\n", this.razonSocial, this.GananciasPorLocal, this.GananciasPorProvincial, this.GananciasPorTotal);
            sb.AppendLine("Detalles de llamadas realizadas");
            for (int i = 0; i < this.Llamadas.Count; i++)
            {
                if (this.Llamadas[i] is Local)
                {
                    Local local = (Local)this.Llamadas[i];
                    sb.AppendFormat("Llamada local--> {0}", local.Mostrar());
                }
                else
                {
                    Provincial provincial = (Provincial)this.Llamadas[i];
                    sb.AppendFormat("Llamada provincial--> {0}", provincial.Mostrar());
                }
            }
            
            return sb.ToString();
        }
    }
}
