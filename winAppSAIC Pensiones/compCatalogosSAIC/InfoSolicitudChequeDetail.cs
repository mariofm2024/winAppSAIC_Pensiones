using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compCatalogosSAIC
{
    public class InfoSolicitudChequeDetail
    {
        public long IdSolicitudChequeDetail { get; set; }
        public long IdSolicitudChequeHeader { get; set; }
        public long IdPDOHeader { get; set; }
        public int IdEmpleado { get; set; }
        public int IdCuentaBanco { get; set; }
        public DateTime FechaTransaccion { get; set; }
        public string NoTransaccion { get; set; }
        public string NombreBeneficiarioTransaccionBanco { get; set; }
        public decimal MontoTransaccionRetiro { get; set; }
        public string MontoConLetra { get; set; }
        public string IdMoneda { get; set; }
        public int IdCategoriaTransaccionBanco { get; set; }
        public int IdSubCategoriaTransaccionBanco { get; set; }
        public string Observaciones { get; set; }
        public byte IdEstatus { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
    }
}
