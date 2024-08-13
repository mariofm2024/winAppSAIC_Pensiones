using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compIMSS
{
    public class SolicitudTramite
    {
        public Int64 IdSolicitudTramiteIMSS { get; set; }
        public byte IdTipoMovimientoSolicitud { get; set; }
        public string DescTipoMovimientoSolicitud { get; set; }
        public Int32 IdTenedora { get; set; }
        public string RazonSocialTenedora { get; set; }
        public string NombreComercialTenedora { get; set; }
        public Int32 IdCliente { get; set; }
        public string RazonSocialCliente { get; set; }
        public string NombreComercialCliente { get; set; }
        public Int32 IdEmpleado { get; set; }
        public string APaternoEmpleado { get; set; }
        public string AMaternoEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public string NombreEmpleadoCompleto { get; set; }
        public string NSS { get; set; }
        public string RFC { get; set; }
        public string CURP { get; set; }
        public Int16 IdOperador { get; set; }
        public string Operador { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public decimal SalarioDiarioAnterior { get; set; }
        public decimal SalarioDiarioNuevo { get; set; }
        public Int16 IdCausaBajaIMSS { get; set; }
        public string DescCausaBajaIMSS { get; set; }
        public string Observaciones { get; set; }
        public string FolioMovimientoIMSS { get; set; }
        public byte IdEstatusMovimientoIMSS { get; set; }
    }
}
