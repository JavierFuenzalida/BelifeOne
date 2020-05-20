using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeLife.Negocio
{
    public class Contrato
    {
        public string Numero { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public string RutCliente { get; set; }
        public string CodigoPlan { get; set; }
        public System.DateTime FechaInicioVigencia { get; set; }
        public System.DateTime FechaFinVigencia { get; set; }
        public bool Vigente { get; set; }
        public bool DeclaracionSalud { get; set; }
        public double PrimaAnual { get; set; }
        public double PrimaMensual { get; set; }
        public string Observaciones { get; set; }


        public Contrato()
        {
            this.Init();
        }

        void Init()
        {
            Numero = string.Empty;
            FechaCreacion = DateTime.Today;
            RutCliente = string.Empty;
            CodigoPlan = string.Empty;
            FechaInicioVigencia = DateTime.Today;
            FechaFinVigencia = DateTime.Today;
            Vigente = true;
            DeclaracionSalud = true;
            PrimaAnual = 0.0;
            PrimaMensual = 0.0;
            Observaciones = string.Empty;
        }
    }
}
