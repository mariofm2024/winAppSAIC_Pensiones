using System;
using System.Collections.Generic;
using System.Linq;

namespace compLayoutBancos
{
    /// <summary>
    /// Clase que engloba las propiedades comunes entre los Layout TEF C y TEF D
    /// </summary>
    public class Banamex
    {
        //CONTROL
        public string TipoRegistroControl
        {
            get; set;
        }

        public string NoIdentificacionCliente
        {
            get;
            set;
        }

        public string FechaPago
        {
            get;
            set;
        }

        public string SecuencialArchivo
        {
            get;
            set;
        }

        public string NombreEmpresa
        {
            get;
            set;
        }

        public string DescArchivo
        {
            get;
            set;
        }

        public string NaturalezaArchivo
        {
            get;
            set;
        }

        public string VersionLayout
        {
            get;
            set;
        }

        //GLOBAL
        public string TipoRegistroGlobal
        {
            get;
            set;
        }

        public string TipoOperacionGlobal
        {
            get;
            set;
        }

        public string ClaveMonedaGlobal
        {
            get;
            set;
        }

        public string ImporteAbonarPagar
        {
            get;
            set;
        }

        public string TipoCuentaGlobal
        {
            get;
            set;
        }

        public string NoCuentaGlobal
        {
            get;
            set;
        }

        //TOTAL
        public string TipoRegistroTotal
        {
            get;
            set;
        }

        public string ClaveMonedaTotal
        {
            get;
            set;
        }

        public string NoAbonos
        {
            get;
            set;
        }

        public string ImporteTotalAbonos
        {
            get;
            set;
        }

        public string NoCargos
        {
            get;
            set;
        }

        public string ImporteTotalCargos
        {
            get;
            set;
        }
    }
}
