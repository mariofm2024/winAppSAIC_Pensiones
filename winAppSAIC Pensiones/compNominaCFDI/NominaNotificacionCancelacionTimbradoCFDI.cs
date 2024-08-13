using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compNominaCFDI
{
    public class NominaNotificacionCancelacionTimbradoCFDI
    {
        public string NumeroReferencia { get; set; }
        public string EstatusDocumento { get; set; }
        public string FechaMensaje { get; set; }
        public string EstatusCancelacion { get; set; }
        public string FechaCancelacion { get; set; }
        public string FolioFiscalUUID { get; set; }
        public string Serie { get; set; }
        public string FolioInterno { get; set; }
        public string XmlCFDI { get; set; }
        public string UrlDescargaXmlCFDI { get; set; }   
    }
}
