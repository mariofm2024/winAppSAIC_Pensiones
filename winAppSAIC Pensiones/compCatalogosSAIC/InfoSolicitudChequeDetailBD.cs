using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace compCatalogosSAIC
{
    public static class InfoSolicitudChequeDetailBD
    {
        public static InfoSolicitudChequeDetail ObtenerInfoDetalleSolicitudChequeMasivo(DataRow row)
        {
            InfoSolicitudChequeDetail objInfoDetalle = null;
            try
            {
                objInfoDetalle = new InfoSolicitudChequeDetail();
                objInfoDetalle.IdSolicitudChequeDetail = (Int64)row["IdSolicitudChequeDetail"];
                objInfoDetalle.IdSolicitudChequeHeader = (Int64)row["IdSolicitudChequeHeader"];
                objInfoDetalle.IdPDOHeader = (Int64)row["IdPDOHeader"];
                objInfoDetalle.IdEmpleado = (Int32)row["IdEmpleado"];
                objInfoDetalle.IdCuentaBanco = (Int32)row["IdCuentaBanco"];
                objInfoDetalle.FechaTransaccion = Convert.ToDateTime(row["FechaTransaccion"]);
                objInfoDetalle.NoTransaccion = row["NoTransaccion"].ToString();
                objInfoDetalle.NombreBeneficiarioTransaccionBanco = row["NombreBeneficiarioTransaccionBanco"].ToString();
                objInfoDetalle.MontoTransaccionRetiro = Convert.ToDecimal(row["MontoTransaccionRetiro"]);
                objInfoDetalle.MontoConLetra = row["MontoConLetra"].ToString();
                objInfoDetalle.IdMoneda = row["IdMoneda"].ToString();
                objInfoDetalle.IdCategoriaTransaccionBanco = (Int32)row["IdCategoriaTransaccionBanco"];
                objInfoDetalle.IdSubCategoriaTransaccionBanco = (Int32)row["IdSubCategoriaTransaccionBanco"];
                objInfoDetalle.Observaciones = row["Observaciones"].ToString();
                objInfoDetalle.IdEstatus = Convert.ToByte(row["IdEstatus"]);
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
