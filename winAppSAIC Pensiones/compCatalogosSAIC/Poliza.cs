using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compCatalogosSAIC
{
    public class Poliza
    {
        public Int32 IdPoliza { get; set; }
        public string NoPoliza { get; set; }
        public Int32 IdCIAAseguradora { get; set; }
        public Int32 IdTipoSeguro { get; set; }
        public string Concepto { get; set; }
        public Int32 IdCliente { get; set; }
        public Int32 IdTenedora { get; set; }
        public Int32 IdTipoMetodoPago { get; set; }
        public Int32 IdEstatus { get; set; }
        public DateTime FechaEMI { get; set; }
        public DateTime FechaIniVig { get; set; }
        public DateTime FechaFinVig { get; set; }
        public string UsuarioCreacion { get; set; }
        public Int32 IdTipoPagadorPoliza { get; set; }
    }
}
