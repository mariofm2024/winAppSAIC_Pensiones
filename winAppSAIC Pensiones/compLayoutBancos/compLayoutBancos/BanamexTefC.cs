using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compLayoutBancos
{
    public class BanamexTefC: Banamex
    {
        //CONTROL
        public string InstruccionesOrdenesPago
        {
            get;
            set;
        }

        public string Volumen
        {
            get;
            set;
        }

        public string CaracteristicaArchivo
        {
            get;
            set;
        }

        //GLOBAL
        public string NoSucursalGlobal
        {
            get;
            set;
        }

        public string EspacioBlanco
        {
            get;
            set;
        }
    }
}
