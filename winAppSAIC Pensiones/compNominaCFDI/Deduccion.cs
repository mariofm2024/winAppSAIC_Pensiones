using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compNominaCFDI
{
    public class Deduccion
    {
        public string tipoDeduccion
        { get; set; }

        public string clave
        { get; set; }

        public string concepto
        { get; set; }

        public decimal importeGravado
        { get; set; }

        public decimal importeExento
        { get; set; }
    }
}
