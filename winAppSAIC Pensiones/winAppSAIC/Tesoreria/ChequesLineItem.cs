using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace winAppSAIC.Tesoreria
{
    public class ChequesLineItem
    {
        public Int64 IdLoteCargaNomina {get; set;}
        public string FolioLoteCargaNomina {get; set;}
        public Int32 IdTenedora {get; set;}
        public string RazonSocialTenedora {get; set;}
        public string NombreComercialTenedora {get; set;}
        public Int32 IdCliente {get; set;}
        public string RazonSocialCliente {get; set;}
        public string NombreComercialCliente {get; set;}
        public byte IdTipoPeriodoNomina {get; set;}
        public string DescTipoPeriodoNomina {get; set;}
        public Int64 IdPDOHeader {get; set;}
        public string NoRecibo {get; set;}
        public string NombreEmpleado {get; set;}
        public string BeneficiarioCheque { get; set; }
        public string BeneficiarioPoliza { get; set; }
        public decimal MontoNetoPagar {get; set;}
        public string ImporteConLetra {get; set;}
        public string TipoPago {get; set;}
        public short IdOperador {get; set;}
        public string NombreCompletoOperador {get; set;}
        public string IdMoneda {get; set;}
        public string DescMoneda {get; set;}
        public string PeriodoPago {get; set;}
        public Int32 IdEmpleadoInterno {get; set;}
        public Int32 IdSubCategoriaTransaccionBanco {get; set;}
        public Int32 IdCategoriaTransaccionBanco { get; set; }
        public bool AjusteContable { get; set; }
        public string OtroConcepto { get; set; }
        public string Observaciones { get; set; }
    }
}
