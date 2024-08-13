using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace compCatalogosSAIC
{
    public static class InfoSolicitudChequeHeaderBD
    {
        public static InfoSolicitudChequeHeader ObtenerInfoDetalleSolicitudChequeMasivo(DataRow row)
        {
            InfoSolicitudChequeHeader objInfoDetalle = null;
            try
            {
                objInfoDetalle = new InfoSolicitudChequeHeader();
                objInfoDetalle.IdSolicitudChequeHeader = (Int64)row["IdSolicitudChequeHeader"];
                objInfoDetalle.IdLoteCargaNomina = (Int64)row["IdLoteCargaNomina"];
                objInfoDetalle.FolioLoteCargaNomina = row["FolioLoteCargaNomina"].ToString();
                objInfoDetalle.IdTenedora = (Int32)row["IdTenedora"];
                objInfoDetalle.IdMatrizTenedora = (Int32)row["IdMatrizTenedora"];
                objInfoDetalle.RazonSocialTenedora = row["RazonSocialTenedora"].ToString();
                objInfoDetalle.NombreComercialTenedora = row["NombreComercialTenedora"].ToString();
                objInfoDetalle.IdCliente = (Int32)row["IdCliente"];
                objInfoDetalle.RazonSocialCliente = row["RazonSocialCliente"].ToString();
                objInfoDetalle.NombreComercialCliente = row["NombreComercialCliente"].ToString();
                objInfoDetalle.IdBancoSolicitado = Convert.ToByte(row["IdBancoSolicitado"]);
                objInfoDetalle.BancoSolicitado = row["BancoSolicitado"].ToString();
                objInfoDetalle.IdBancoAsignado = Convert.ToByte(row["IdBancoAsignado"]);
                objInfoDetalle.IdCuentaBanco = (Int32)row["IdCuentaBanco"];
                objInfoDetalle.IdCategoriaTransaccionBanco = (Int32)row["IdCategoriaTransaccionBanco"];
                objInfoDetalle.IdSubCategoriaTransaccionBanco = (Int32)row["IdSubCategoriaTransaccionBanco"];
                objInfoDetalle.FechaInicio = Convert.ToDateTime(row["FechaInicio"]);
                objInfoDetalle.FechaFin = Convert.ToDateTime(row["FechaFin"]);
                objInfoDetalle.IdTipoPeriodoNomina = Convert.ToByte(row["IdTipoPeriodoNomina"]);
                objInfoDetalle.DescTipoPeriodoNomina = row["DescTipoPeriodoNomina"].ToString();
                objInfoDetalle.IdOperador = Convert.ToInt16(row["IdOperador"]);
                objInfoDetalle.Operador = row["Operador"].ToString();
                objInfoDetalle.IdMoneda = row["IdMoneda"].ToString();
                objInfoDetalle.TipoCambio = (decimal)row["TipoCambio"];
                objInfoDetalle.NoControl = row["NoControl"].ToString();
                objInfoDetalle.IdEstatus = Convert.ToByte(row["IdEstatus"]);
                objInfoDetalle.EstatusBloqueado = (bool)row["EstatusBloqueado"];
                objInfoDetalle.UsuarioSolicitante = row["UsuarioSolicitante"].ToString();
                objInfoDetalle.UsuarioTesoreria = row["UsuarioTesoreria"].ToString();
                objInfoDetalle.FechaCreacion = Convert.ToDateTime(row["FechaCreacion"]);
                objInfoDetalle.FechaModificacion = Convert.ToDateTime(row["FechaModificacion"]);
                objInfoDetalle.UsuarioCreacion = row["UsuarioCreacion"].ToString();
                objInfoDetalle.UsuarioModificacion = row["UsuarioModificacion"].ToString();
            }
            catch (Exception ex)
            {
                return null;
            }
            return objInfoDetalle;
        }
    }
}
