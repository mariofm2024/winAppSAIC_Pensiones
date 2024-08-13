using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compNominaCFDI
{
    public class NominaTimbradoErrorCFDI
    {
        public string NumeroReferencia { get; set; }
        public string EstatusDocumento { get; set; }
        public string FechaMensaje { get; set; }
        public string codigoError { get; set; }
        public string descripcionError { get; set; }
        public string cEsCancelable { get; set; }
        public string cEstatusCancelacion { get; set; }
    }
}
