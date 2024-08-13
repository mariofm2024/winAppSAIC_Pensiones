using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compCatalogosSAIC
{
    public class FactConceptoTenedora
    {
        public Int64 IdFactConceptoTenedora { get; set; }
        public Int32 IdFactClaveProduServ { get; set; }
        public Int32 IdTenedoraMatriz { get; set; }
        public string DescConceptoInterno { get; set; }
        public Int32 IdEstatus { get; set; }
    }
}
