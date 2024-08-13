using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compLayoutBancos
{
    public class HSBC
    {
        public string NoCuentaBanco
        {
            get;
            set;
        }

        public decimal Importe
        {
            get;
            set;
        }

        public string Beneficiario
        {
            get;
            set;
        }

        public string DescPago
        {
            get;
            set;
        }

        public string ReferenciaNumerica
        {
            get;
            set;
        }

         public string DescPagoOrdenante
         {
             get;
             set;
         }

        public string NoTotalRegistrosEnviados
        {
            get;
            set;
        }

        public string ImporteTotalRegistrosEnviados
        {
            get;
            set;
        }
    }
}
