using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compLayoutBancos
{
    public class Banorte2016
    {
        public string ClaveID { get; set; }

        public string ClaveTipoCambio { get; set; }

        public string CuentaOrigen { get; set; }

        public string Descripcion { get; set; }

        public string FechaAplicacion { get; set; }

        public long IdLoteCargaNomina { get; set; }

        public decimal Importe { get; set; }

        public string InstruccionPago { get; set; }

        public string IVA { get; set; }

        public string NoCuentaBanco { get; set; }

        public string Operacion { get; set; }

        public string Referencia { get; set; }

        public string RFCOrdenante { get; set; }
    }
}
