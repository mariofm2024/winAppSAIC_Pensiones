using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace winAppSAIC.Tesoreria
{
    public class DetalleChequesMasivos
    {
        public string TipoImpresora { get; set; }
        public Int32 IdCuentaBanco { get; set; }
        public string NombreCuentaBanco { get; set; }
        public Int64 IdTransaccionBancoInicial { get; set; }
        public Int64 IdTransaccionBancoFinal { get; set; }
        public string NoChequeInicial { get; set; }
        public string NoChequeFinal { get; set; }
    }
}
