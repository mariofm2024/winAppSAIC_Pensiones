using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compLayoutBancos
{
    /// <summary>
    /// Clase que engloba las propiedades comunes del Layout Santander
    /// </summary>
    public class Santander
    {
        //Encabezado
        public string TipoRegistroEncabezado
        {
            get;
            set;
        }

        public string SecuencialArchivoConsecutivo
        {
            get;
            set;
        }

        public string Sentido
        {
            get;
            set;
        }

        public string FechaGeneracion
        {
            get;
            set;
        }

        public string NoCuentaCargo
        {
            get;
            set;
        }

        public string FechaAplicacion
        {
            get;
            set;
        }


        //Total
        public string TipoRegistroTotal
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
