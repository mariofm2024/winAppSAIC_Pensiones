using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compNominaCFDI
{
    public class EstatusNomina
    {
        public decimal noEmpleadosNomina { get; set; }
        public decimal noEmpleadosTimbrados { get; set; }
        public decimal noEmpleadosPorTimbrar { get; set; }
        public decimal noEmpleadosCancelados { get; set; }
        public decimal pctEmpleadosTimbrados { get; set; }
        public decimal pctEmpleadosPorTimbrar { get; set; }
        public string leyendaEstatusNominaSueldosVsTimbrado { get; set; }
    }
}
