using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace compLibreriaSAIC
{
    public class InfoDetalleSolicitudCancelacionNominaBD
    {
        /// <summary>
        /// Método que recibe un DataTable que contiene los datos
        /// el LoteCargaNomina consultado
        /// </summary>
        /// <param name="dt">DataTable</param>
        /// <returns>Objeto InfoDetalleSolicitudCancelacionNomina</returns>
        public static InfoDetalleSolicitudCancelacionNomina ObtenerInfoDetalleSolicitudCancelacionNomina(DataTable dt)
        {
            InfoDetalleSolicitudCancelacionNomina objInfoDetalle = null;

            //si existe un registro
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                //asignar valores al objeto InfoDetalleSolicitudCancelacionNomina
                objInfoDetalle = new InfoDetalleSolicitudCancelacionNomina();
                objInfoDetalle.IdLoteCargaNomina = (long)row["IdLoteCargaNomina"];
                objInfoDetalle.FolioLoteCargaNomina = row["FolioLoteCargaNomina"].ToString();
                objInfoDetalle.NombreComercialTenedora = row["NombreComercialTenedora"].ToString();
                objInfoDetalle.NombreComercialCliente = row["NombreComercialCliente"].ToString();
                objInfoDetalle.PeriodoPago = row["PeriodoPago"].ToString();
                objInfoDetalle.TipoCambio = (decimal)row["TipoCambio"];
                objInfoDetalle.TipoNomina = row["TipoNomina"].ToString();
                objInfoDetalle.Operador = row["Operador"].ToString();
                objInfoDetalle.MotivoCancelacion = row["MotivoCancelacion"].ToString();
            }
            return objInfoDetalle;  //regresar objeto
        }
    }
}
