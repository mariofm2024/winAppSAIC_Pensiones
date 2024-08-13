using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace compIMSS
{
    public static class InfoDetalleSolicitudTramiteBD
    {
        /// <summary>
        /// Método que almacena la información detalle de la Solicitud de Tramite IMSS
        /// </summary>
        /// <param name="row">Variable tipo DataRow</param>
        /// <returns>Objeto SolicitudTramite</returns>
        public static SolicitudTramite ObtenerInfoDetalleSolicitudTramiteIMSS(DataRow row)
        {
            SolicitudTramite objInfoDetalleSolicitudTramiteIMSS = null;
            try
            {
                objInfoDetalleSolicitudTramiteIMSS = new SolicitudTramite();
                objInfoDetalleSolicitudTramiteIMSS.IdSolicitudTramiteIMSS = (Int64)row["IdSolicitudTramiteIMSS"];
                objInfoDetalleSolicitudTramiteIMSS.IdTipoMovimientoSolicitud = (byte)row["IdTipoMovimientoSolicitud"];
                objInfoDetalleSolicitudTramiteIMSS.DescTipoMovimientoSolicitud = row["DescTipoMovimientoSolicitud"].ToString();
                objInfoDetalleSolicitudTramiteIMSS.IdTenedora = (Int32)row["IdTenedora"];
                objInfoDetalleSolicitudTramiteIMSS.RazonSocialTenedora = row["RazonSocialTenedora"].ToString();
                objInfoDetalleSolicitudTramiteIMSS.NombreComercialTenedora = row["NombreComercialTenedora"].ToString();
                objInfoDetalleSolicitudTramiteIMSS.IdCliente = (Int32)row["IdCliente"];
                objInfoDetalleSolicitudTramiteIMSS.RazonSocialCliente = row["RazonSocialCliente"].ToString();
                objInfoDetalleSolicitudTramiteIMSS.NombreComercialCliente = row["NombreComercialCliente"].ToString();
                objInfoDetalleSolicitudTramiteIMSS.IdEmpleado = (Int32)row["IdEmpleado"];
                objInfoDetalleSolicitudTramiteIMSS.APaternoEmpleado = row["APaternoEmpleado"].ToString();
                objInfoDetalleSolicitudTramiteIMSS.AMaternoEmpleado = row["AMaternoEmpleado"].ToString();
                objInfoDetalleSolicitudTramiteIMSS.NombreEmpleado = row["NombreEmpleado"].ToString();
                objInfoDetalleSolicitudTramiteIMSS.NombreEmpleadoCompleto = row["NombreEmpleadoCompleto"].ToString();
                objInfoDetalleSolicitudTramiteIMSS.NSS = row["NSS"].ToString();
                objInfoDetalleSolicitudTramiteIMSS.RFC = row["RFC"].ToString();
                objInfoDetalleSolicitudTramiteIMSS.CURP = row["CURP"].ToString();
                objInfoDetalleSolicitudTramiteIMSS.IdOperador = (short)row["IdOperador"];
                objInfoDetalleSolicitudTramiteIMSS.Operador = row["Operador"].ToString();
                objInfoDetalleSolicitudTramiteIMSS.FechaMovimiento = Convert.ToDateTime(row["FechaMovimiento"]);
                objInfoDetalleSolicitudTramiteIMSS.SalarioDiarioAnterior = (decimal)row["SalarioDiarioAnteriorSolicitado"];
                objInfoDetalleSolicitudTramiteIMSS.SalarioDiarioNuevo = (decimal)row["SalarioDiarioNuevoSolicitado"];
                objInfoDetalleSolicitudTramiteIMSS.IdCausaBajaIMSS = (short)row["IdCausaBajaIMSS"];
                objInfoDetalleSolicitudTramiteIMSS.DescCausaBajaIMSS = row["DescCausaBajaIMSS"].ToString();
                objInfoDetalleSolicitudTramiteIMSS.Observaciones = row["Observaciones"].ToString();
                objInfoDetalleSolicitudTramiteIMSS.FolioMovimientoIMSS = row["FolioMovimientoIMSS"].ToString();
                objInfoDetalleSolicitudTramiteIMSS.IdEstatusMovimientoIMSS = (byte)row["IdEstatusMovimientoIMSS"];
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objInfoDetalleSolicitudTramiteIMSS;
        }
    }
}
