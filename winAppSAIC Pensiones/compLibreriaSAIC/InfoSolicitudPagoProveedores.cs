using System;
using System.Collections.Generic;
using System.Text;

namespace compLibreriaSAIC
{
    public class InfoSolicitudPagoProveedores
    {
        public Int32 IdOpcion { get; set; }
        public Int32 IdSolicitud { get; set; }
        public Int32 IdAreaOperativa { get; set; }
        public Int32 IdOperador { get; set; }
        public Int32 IdStatus { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }

    }
}
