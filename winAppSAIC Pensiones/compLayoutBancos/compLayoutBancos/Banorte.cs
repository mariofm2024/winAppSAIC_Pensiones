using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compLayoutBancos
{
    /// <summary>
    /// Clase que engloba las propiedades de Banorte
    /// </summary>
    public class Banorte
    {
        //ENCABEZADO
        public string TipoRegistro
        {
            get;
            set;
        }

        public string ClaveServicio
        {
            get;
            set;
        }

        public string Emisora
        {
            get;
            set;
        }

        public string FechaProceso
        {
            get;
            set;
        }

        public string SecuencialArchivoConsecutivo
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

        public string NoTotalAltasEnviados
        {
            get;
            set;
        }

        public string ImporteTotalAltasEnviados
        {
            get;
            set;
        }

        public string NoTotalBajasEnviados
        {
            get;
            set;
        }

        public string ImporteTotalBajasEnviados
        {
            get;
            set;
        }

        public string NoTotalCuentasVerificar
        {
            get;
            set;
        }

        public string Accion
        {
            get;
            set;
        }

        public string Filler
        {
            get;
            set;
        }
    }
}
