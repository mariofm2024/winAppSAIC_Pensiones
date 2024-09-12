using System;
using System.Collections.Generic;
using System.Text;

namespace compLibreriaSAIC
{
    public class InfoDetalleSolPagoProveedores: InfoSolicitudPagoProveedores
    {
        public Int32 IdSolicitudDetallePagoProv { get; set; } //IdDetSolTipoPProveedor
        public Int32 IdTipoPagoProveedor { get; set; }
        public Int32 IdMatrizTenedora { get; set; }
        public Int32 IdCliente { get; set; }
        public Decimal Monto { get; set; }
        public Int32 IdStatusPago { get; set; }
        public String IdOperadorPago { get; set; }

    }
}
