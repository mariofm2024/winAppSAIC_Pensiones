using System;
using System.Collections.Generic;
using System.Text;

namespace compLibreriaSAIC
{
    public class InfoDetalleLoteCargaNomina: InfoNominaBase
    {
        public Int32 IdMatrizTenedora { get; set; }
        public string RazonSocialMatrizTenedora { get; set; }
        public Int32 IdMatrizCliente { get; set; }
        public string RazonSocialMatrizCliente { get; set; }
        public Decimal TipoCambio { get; set; }
        public string IdMoneda { get; set; }
        public bool EstatusNominaContabilizada { get; set; }
        public byte IdMesPago { get; set; }
        public string MesPago { get; set; }
        public short AnoPago { get; set; }
        public byte IdEstatusCFDI { get; set; }
        public string DescEstatusCFDI { get; set; }
        public Int64 IdControl { get; set; }
        public int APPJ { get; set; }
    }
}
