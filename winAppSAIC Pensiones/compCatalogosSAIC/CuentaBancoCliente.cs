using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compCatalogosSAIC
{
    public class CuentaBancoCliente
    {
        public Int32 IdCuentaBanco { get; set; }
        public Int32 IdTipoBeneficiario { get; set; }
        public Int32 IdBeneficiario { get; set; }
        public Int32 IdBanco { get; set; }
        public string NoCuenta { get; set; }
        public Int32 IdEstatus { get; set; }
    }
}
