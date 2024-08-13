using System;
using System.Collections.Generic;
using System.Text;
using System.Data;


namespace compLibreriaSAIC
{
    public class InfoDetalleCierreNominaContableBD
    {
        /// <summary>
        /// Método que recibe un DataTable que contiene los datos
        /// el LoteCargaNomina consultado
        /// </summary>
        /// <param name="dt">DataTable</param>
        /// <returns>Objeto InfoDetalleCierreNominaContable</returns>
        public static InfoDetalleCierreNominaContable ObtenerInfoDetalleCierreNominaContable(DataTable dt)
        {
            InfoDetalleCierreNominaContable objInfoDetalle = null;

            //si existe un registro
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                //asignar valores al objeto InfoDetalleSolicitudCancelacionNomina
                objInfoDetalle = new InfoDetalleCierreNominaContable();
                objInfoDetalle.IdCierreNominaContable = (long)row["IdCierreNominaContable"];
                objInfoDetalle.IdLoteCargaNomina = (long)row["IdLoteCargaNomina"];
                objInfoDetalle.FolioLoteCargaNomina = row["FolioLoteCargaNomina"].ToString();
                objInfoDetalle.IdTenedora = (int)row["IdTenedora"];
                objInfoDetalle.RazonSocialTenedora = row["RazonSocialTenedora"].ToString();
                objInfoDetalle.NombreComercialTenedora = row["NombreComercialTenedora"].ToString();
                objInfoDetalle.IdCliente = (int)row["IdCliente"];
                objInfoDetalle.RazonSocialCliente = row["RazonSocialCliente"].ToString();
                objInfoDetalle.NombreComercialCliente = row["NombreComercialCliente"].ToString();
                objInfoDetalle.FechaInicio = (DateTime)row["FechaInicio"];
                objInfoDetalle.FechaFin = (DateTime)row["FechaFin"];
                objInfoDetalle.PeriodoPago = row["PeriodoPago"].ToString();
                objInfoDetalle.IdTipoPeriodoNomina = (byte)row["IdTipoPeriodoNomina"];
                objInfoDetalle.TipoNomina = row["TipoNomina"].ToString();
                objInfoDetalle.IdOperador = (Int16)row["IdOperador"];
                objInfoDetalle.Operador = row["Operador"].ToString();
                objInfoDetalle.TipoPoliza = row["TipoPoliza"].ToString();
                objInfoDetalle.FolioPoliza = row["FolioPoliza"].ToString();
                objInfoDetalle.FechaPoliza = (DateTime)row["FechaPoliza"];
                objInfoDetalle.ImportePoliza = (decimal)row["ImportePoliza"];
                objInfoDetalle.MesPago = row["MesPago"].ToString();
                objInfoDetalle.AnoPago = row["AnoPago"].ToString();
                objInfoDetalle.Observaciones = row["Observaciones"].ToString();
                objInfoDetalle.EstatusNominaContabilizada = (bool)row["EstatusNominaContabilizada"];
            }
            return objInfoDetalle;  //regresar objeto
        }
    }
}
