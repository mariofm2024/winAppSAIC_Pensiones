using System;
using System.Collections.Generic;
using System.Text;

namespace compLibreriaSAIC
{
    public class InfoCierreNominaContable
    {
        public string TipoPoliza { get; set; }
        public DateTime FechaPoliza { get; set; }
        public string FolioPoliza { get; set; }
        public string ImportePoliza { get; set; }
        public string Observaciones { get; set; }
        public byte MesPago { get; set; }
        public short AnoPago { get; set; }
    }
}
