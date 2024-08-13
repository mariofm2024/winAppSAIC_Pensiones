using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compLayoutBancos
{
    public class HSBCNET
    {
        //Encabezado
        public string IndicadorFormatoArchivo
        {
            get;
            set;
        }

        public string NivelAutorizacion
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

        public string HoraAplicacion
        {
            get;
            set;
        }

        public string ReferenciaLote
        {
            get;
            set;
        }

        //Total
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
