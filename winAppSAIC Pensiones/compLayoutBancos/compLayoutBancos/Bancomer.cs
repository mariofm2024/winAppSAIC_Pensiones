using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compLayoutBancos
{
    /// <summary>
    /// Clase que engloba las columnas
    /// del Layout Bancomer en el Archivo de Excel
    /// proporcionado por el Banco
    /// </summary>
    public class Bancomer
    {
        public string NoRenglon
        {
            get;
            set;
        }

        public string RFC
        {
            get;
            set;
        }

        public string TipoCuenta
        {
            get;
            set;
        }

        public string NoCuenta
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

        public string BancoDestino
        {
            get;
            set;
        }

        public string PlazaDestino
        {
            get;
            set;
        }
    }
}
