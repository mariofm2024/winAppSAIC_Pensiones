using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compCatalogosSAIC
{
    public class FactConceptoTenedoraBeneficiario
    {
        public Int64 IdFactConceptoTenedoraBeneficiario { get; set; }
        public Int64 IdConceptoTenedora { get; set; }
        public Int32 IdFronting { get; set; }
        public Int32 IdTipoBeneficiario { get; set; }
        public Int32 IdBeneficiario { get; set; }
        public Int32 IdUsoCFDI { get; set; }
        public string DescConceptoInterno { get; set; }
        public bool IVA { get; set; }
        public bool Retencion { get; set; }
        public bool ObjetoImpuesto { get; set; }
        public Int32 IdEstatus { get; set; }
        public Decimal Monto { get; set; } 
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}
