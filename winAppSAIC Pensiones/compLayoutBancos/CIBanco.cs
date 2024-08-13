using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compLayoutBancos
{
    /// <summary>
    /// Clase que engloba las propiedades de CIBanco
    /// </summary>
    public class CIBanco
    {
        public string TipoPago
        {
            get;
            set;
        }

        public decimal Importe
        {
            get;
            set;
        }

        public string NoCuentaBanco
        {
            get;
            set;
        }

        public string Beneficiario
        {
            get;
            set;
        }

        public string RFC
        {
            get;
            set;
        }

        public string DescPago
        {
            get;
            set;
        }
    }
}
