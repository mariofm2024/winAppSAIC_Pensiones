using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compCatalogosSAIC
{
    public class InfoSolicitudChequeHeader
    {
        public long IdSolicitudChequeHeader { get; set; }
        public long IdLoteCargaNomina { get; set; }
        public string FolioLoteCargaNomina { get; set; }
        public int IdTenedora { get; set; }
        public int IdMatrizTenedora { get; set; }
        public string RazonSocialTenedora { get; set; }
        public string NombreComercialTenedora { get; set; }
        public int IdCliente { get; set; }
        public string RazonSocialCliente { get; set; }
        public string NombreComercialCliente { get; set; }
        public byte IdBancoSolicitado { get; set; }
        public string BancoSolicitado { get; set; }
        public byte IdBancoAsignado { get; set; }
        public int IdCuentaBanco { get; set; }
        public int IdCategoriaTransaccionBanco { get; set; }
        public int IdSubCategoriaTransaccionBanco { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public byte IdTipoPeriodoNomina { get; set; }
        public string DescTipoPeriodoNomina { get; set; }
        public short IdOperador { get; set; }
        public string Operador { get; set; }
        public string IdMoneda { get; set; }
        public decimal TipoCambio { get; set; }
        public string NoControl { get; set; }
        public byte IdEstatus { get; set; }
        public bool EstatusBloqueado { get; set; }
        public string UsuarioSolicitante { get; set; }
        public string UsuarioTesoreria { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
    }
}
