using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compCatalogosSAIC
{
    public class InfoDetalleTransaccionBanco
    {
        public Int64 IdTransaccionBanco { get; set; }
        public Int64 IdLoteCargaNomina { get; set; }
        public string FolioLoteCargaNomina { get; set; }
        public Int64 IdPDOHeader { get; set; }
        public Int32 IdCuentaBanco { get; set; }
        public Int32 AIdCuentaBanco { get; set; }
        public DateTime FechaTransaccion { get; set; }
        public DateTime FechaPagoBanco { get; set; }
        public string NoTransaccion { get; set; }
        public Int32 IdBeneficiarioTransaccionBanco { get; set; }
        public Int32 IdBeneficiarioTransaccionPoliza { get; set; }
        public string NombreBeneficiarioTransaccionBanco { get; set; }
        public string NombreBeneficiarioTransaccionPoliza { get; set; }
        public string IdCodigoTransaccionBanco { get; set; }
        public decimal MontoTransaccionRetiro { get; set; }
        public decimal MontoTransaccionDeposito { get; set; }
        public string MontoConLetra { get; set; }
        public decimal AMontoTransaccion { get; set; }
        public Int32 IdClienteProveedor { get; set; }
        public string IdMoneda { get; set; }
        public string DescMoneda { get; set; }
        public Int32 IdCategoriaTransaccionBanco { get; set; }
        public Int32 IdSubCategoriaTransaccionBanco { get; set; }
        public string OtroConcepto { get; set; }
        public string Observaciones {get; set;}
        public byte EstatusTransaccionBanco { get; set; }
        public string DescEstatusTransaccionBanco { get; set; }
        public bool EstatusAjusteContable { get; set; }
        public bool EstatusConciliado { get; set; }
        public bool EstatusCancelado { get; set; }
        public string DescEstatusCancelado { get; set; }
    }
}
