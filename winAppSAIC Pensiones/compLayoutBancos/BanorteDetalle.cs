using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compLayoutBancos
{
    public class BanorteDetalle
    {
        public string TipoRegistro
        {
            get;
            set;
        }

        public string FechaAplicacion
        {
            get;
            set;
        }

        public string NoEmpleado
        {
            get;
            set;
        }

        public string ReferenciaServicio
        {
            get;
            set;
        }
        
        public string ReferenciaLeyenda
        {
            get;
            set;
        }

        public decimal Importe
        {
            get;
            set;
        }

        public string NoBancoReceptor
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

        public string TipoMovimiento
        {
            get;
            set;
        }

        public string Accion
        {
            get;
            set;
        }

        public string ImporteIVAOperacion
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
