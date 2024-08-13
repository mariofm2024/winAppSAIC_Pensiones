using System;
using System.Collections.Generic;
using System.Text;

namespace compLibreriaSAIC
{
    public class InfoDetalleSolicitudCancelacionNomina: InfoNominaBase
    {
        public Decimal TipoCambio { get; set; }
        public string MotivoCancelacion { get; set; }
    }
}
