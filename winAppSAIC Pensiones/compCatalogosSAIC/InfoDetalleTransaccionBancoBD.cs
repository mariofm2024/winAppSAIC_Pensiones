using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace compCatalogosSAIC
{
    public static class InfoDetalleTransaccionBancoBD
    {
        /// <summary>
        /// Método que almacena la información detalle de un Cheque emitido
        /// </summary>
        /// <param name="row">Variable tipo DataRow</param>
        /// <returns>Objeto InfoDetalleCheque</returns>
        public static InfoDetalleTransaccionBanco ObtenerInfoDetalleCheque(DataRow row)
        {
            InfoDetalleTransaccionBanco objInfoDetalleCheque = null;
            try
            {
                objInfoDetalleCheque = new InfoDetalleTransaccionBanco();
                objInfoDetalleCheque.IdTransaccionBanco = (Int64)row["IdTransaccionBanco"];
                objInfoDetalleCheque.IdLoteCargaNomina = (Int64)row["IdLoteCargaNomina"];
                objInfoDetalleCheque.FolioLoteCargaNomina = row["FolioLoteCargaNomina"].ToString();
                objInfoDetalleCheque.IdPDOHeader = (Int64)row["IdPDOHeader"];
                objInfoDetalleCheque.IdCuentaBanco = (Int32)row["IdCuentaBanco"];
                objInfoDetalleCheque.FechaTransaccion = Convert.ToDateTime(row["FechaTransaccion"]);
                objInfoDetalleCheque.NoTransaccion = row["NoTransaccion"].ToString();
                objInfoDetalleCheque.IdBeneficiarioTransaccionBanco = (Int32)row["IdBeneficiarioTransaccionBanco"];
                objInfoDetalleCheque.NombreBeneficiarioTransaccionBanco = row["NombreBeneficiarioTransaccionBanco"].ToString();
                objInfoDetalleCheque.IdBeneficiarioTransaccionPoliza = (Int32)row["IdBeneficiarioTransaccionPoliza"];
                objInfoDetalleCheque.NombreBeneficiarioTransaccionPoliza = row["NombreBeneficiarioTransaccionPoliza"].ToString();
                objInfoDetalleCheque.MontoTransaccionRetiro = (decimal)row["MontoTransaccionRetiro"];
                objInfoDetalleCheque.MontoConLetra = row["MontoConLetra"].ToString();
                objInfoDetalleCheque.IdMoneda = row["IdMoneda"].ToString();
                objInfoDetalleCheque.DescMoneda = row["DescMoneda"].ToString();
                objInfoDetalleCheque.IdCategoriaTransaccionBanco = (Int32)row["IdCategoriaTransaccionBanco"];
                objInfoDetalleCheque.IdSubCategoriaTransaccionBanco = (Int32)row["IdSubCategoriaTransaccionBanco"];
                objInfoDetalleCheque.OtroConcepto = row["OtroConcepto"].ToString();
                objInfoDetalleCheque.Observaciones = row["Observaciones"].ToString();
                objInfoDetalleCheque.EstatusCancelado = (bool)row["EstatusCancelado"];
                objInfoDetalleCheque.DescEstatusCancelado = row["DescEstatusCancelado"].ToString();
                objInfoDetalleCheque.IdClienteProveedor = (Int32)row["IdClienteProveedor"];
                objInfoDetalleCheque.EstatusAjusteContable = (bool)row["EstatusAjusteContable"];
                objInfoDetalleCheque.EstatusConciliado = (bool)row["EstatusConciliado"];
                objInfoDetalleCheque.EstatusTransaccionBanco = (byte)row["IdEstatusTransaccionBanco"];
                objInfoDetalleCheque.DescEstatusTransaccionBanco = row["DescEstatusTransaccionBanco"].ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objInfoDetalleCheque;
        }
    }
}
