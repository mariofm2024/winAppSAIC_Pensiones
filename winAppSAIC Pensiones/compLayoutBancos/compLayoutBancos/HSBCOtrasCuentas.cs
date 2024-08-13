using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compLayoutBancos
{
    public class HSBCOtrasCuentas: HSBC 
    {
        public string ClaveMoneda
        { get; set; }

        public string ComprobanteFiscal
        { get; set; }

        public string RFCBeneficiario
        { get; set; }

        public string IVA
        { get; set; }

        public string Email
        { get; set; }
    }
}
