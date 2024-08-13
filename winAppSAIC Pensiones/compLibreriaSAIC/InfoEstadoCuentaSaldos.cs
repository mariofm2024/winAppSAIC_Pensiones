using System;
using System.Collections.Generic;
using System.Text;

namespace compLibreriaSAIC
{
    public class InfoEstadoCuentaSaldos
    {
        public Int32 IdEstadoCuentaDetail { get; set; }
        public Int32 IdMatrizTenedora { get; set; }
        public Int32 IdCuentaBanco { get; set; }
        public string IdEsquema { get; set; }
        public string NombreArchivo { get; set; }

        public Int32 Registros { get; set; }
        public DateTime FechaSaldoInicial { get; set; }

        public Int32 IdConcepto { get; set; }

        public Decimal SaldoInicial { get; set; }

        public string Consecutivo { get; set; }
        public string ClienteProveedor { get; set; }
        public Int32 IdOperador { get; set; }

        public string NombreOperador { get; set; }
        public string Cheque { get; set; }
        public string Lote { get; set; }
        public string Factura { get; set; }
        public string Control { get; set; }
        public string NombreHoja { get; set; }

        public DateTime FechaRegistro { get; set; }
        //public DateTime FechaInicio { get; set; }
        //public DateTime FechaFin { get; set; }

        public Decimal Ingreso { get; set; }

        public Decimal Egreso { get; set; }

        public string Observaciones { get; set; }

        public Int32 IdEstatus { get; set; }

        public string UsuarioModificacion { get; set; }









    }
}
