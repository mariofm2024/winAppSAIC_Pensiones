using System;
using System.Collections.Generic;
using System.Text;

namespace compLibreriaSAIC
{
    public class InfoDetalleCierreNominaContable : InfoNominaBase
    {
        public long IdCierreNominaContable { get; set; }
        public string TipoPoliza { get; set; }
        public string FolioPoliza { get; set; }
        public DateTime FechaPoliza { get; set; }
        public Decimal ImportePoliza { get; set; }
        public string MesPago { get; set; }
        public string AnoPago { get; set; }
        public bool EstatusNominaContabilizada { get; set; }
        public string Observaciones { get; set; }
    }
}
