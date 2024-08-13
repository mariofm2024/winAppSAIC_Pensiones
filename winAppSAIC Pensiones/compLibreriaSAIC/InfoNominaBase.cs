using System;
using System.Collections.Generic;
using System.Text;

namespace compLibreriaSAIC
{
    /// <summary>
    /// Clase Base con Informacion de la Nómina
    /// </summary>
    public class InfoNominaBase
    {
        public long IdLoteCargaNomina { get; set; }
        public string FolioLoteCargaNomina { get; set; }
        public long idControl { get; set; }
        public Int32 IdTenedora { get; set; }
        public string RazonSocialTenedora { get; set; }
        public string NombreComercialTenedora { get; set; }
        public Int32 IdCliente { get; set; }
        public string RazonSocialCliente { get; set; }
        public string NombreComercialCliente { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string PeriodoPago { get; set; }
        public byte IdTipoPeriodoNomina { get; set; }
        public string TipoNomina { get; set; }
        public Int16 IdOperador { get; set; }
        public string Operador { get; set; }
    }
}
