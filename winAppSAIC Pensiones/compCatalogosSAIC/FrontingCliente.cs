using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compCatalogosSAIC
{
    public class FrontingCliente
    {
        public Int32 IdFactFrontingCliente { get; set; }
        public Int32 IdCliente { get; set; }
        public Int32 IdFronting { get; set; }
        public Int16 IdEstatus { get; set; }
        public string UsuarioModificacion { get; set; }

    }
}
