using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace compLibreriaSAIC
{
    public class InfoDetalleLoteCargaNominaBD
    {
        /// <summary>
        /// Método que recibe un DataTable que contiene los datos
        /// el LoteCargaNomina consultado
        /// </summary>
        /// <param name="dt">DataTable</param>
        /// <returns>Objeto InfoDetalleLoteCargaNomina</returns>
        public static InfoDetalleLoteCargaNomina ObtenerInfoDetalleLoteCargaNomina(DataTable dt)
        {
            InfoDetalleLoteCargaNomina objInfoDetalle = null;

            //si existe un registro
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                //asignar valores al objeto InfoDetalleLoteCargaNomina
                objInfoDetalle = new InfoDetalleLoteCargaNomina();
                objInfoDetalle.IdLoteCargaNomina = (long)row["IdLoteCargaNomina"];
                objInfoDetalle.FolioLoteCargaNomina = row["FolioLoteCargaNomina"].ToString();
                objInfoDetalle.IdMatrizTenedora = (int)row["IdMatrizTenedora"];
                objInfoDetalle.RazonSocialMatrizTenedora = row["RazonSocialMatrizTenedora"].ToString();
                objInfoDetalle.IdTenedora = (int)row["IdTenedora"];
                objInfoDetalle.RazonSocialTenedora = row["RazonSocialTenedora"].ToString();
                objInfoDetalle.NombreComercialTenedora = row["NombreComercialTenedora"].ToString();
                objInfoDetalle.IdMatrizCliente = (int)row["IdMatrizCliente"];
                objInfoDetalle.RazonSocialMatrizCliente = row["RazonSocialMatrizCliente"].ToString();
                objInfoDetalle.IdCliente = (int)row["IdCliente"];
                objInfoDetalle.RazonSocialCliente = row["RazonSocialCliente"].ToString();
                objInfoDetalle.NombreComercialCliente = row["NombreComercialCliente"].ToString();
                objInfoDetalle.FechaInicio = (DateTime)row["FechaInicio"];
                objInfoDetalle.FechaFin = (DateTime)row["FechaFin"];
                objInfoDetalle.PeriodoPago = row["PeriodoPago"].ToString();
                objInfoDetalle.TipoCambio = (decimal)row["TipoCambio"];
                objInfoDetalle.IdMoneda = row["IdMoneda"].ToString();
                objInfoDetalle.IdTipoPeriodoNomina = (byte)row["IdTipoPeriodoNomina"];
                objInfoDetalle.TipoNomina = row["TipoNomina"].ToString();
                objInfoDetalle.IdOperador = (Int16)row["IdOperador"];
                objInfoDetalle.Operador = row["Operador"].ToString();
                objInfoDetalle.EstatusNominaContabilizada = (bool)row["EstatusNominaContabilizada"];
                objInfoDetalle.MesPago = row["MesPago"].ToString();
                objInfoDetalle.AnoPago = (short)row["AnoPago"];
                objInfoDetalle.IdEstatusCFDI = (byte)row["IdEstatusCFDI"];
                objInfoDetalle.APPJ = Convert.ToInt16(row["APPJ"]);
            }
            return objInfoDetalle;  //regresar objeto
        }

        /// <summary>
        /// Método que recibe un DataTable que contiene los datos
        /// el LoteCargaNomina consultado con Estatus CFDI
        /// </summary>
        /// <param name="dt">DataTable</param>
        /// <returns>Objeto InfoDetalleLoteCargaNomina</returns>
        public static InfoDetalleLoteCargaNomina ObtenerInfoDetalleLoteCargaNominaCFDI(DataTable dt)
        {
            InfoDetalleLoteCargaNomina objInfoDetalle = null;

            //si existe un registro
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                //asignar valores al objeto InfoDetalleLoteCargaNomina
                objInfoDetalle = new InfoDetalleLoteCargaNomina();
                objInfoDetalle.IdLoteCargaNomina = (long)row["IdLoteCargaNomina"];
                objInfoDetalle.FolioLoteCargaNomina = row["FolioLoteCargaNomina"].ToString();
                objInfoDetalle.IdMatrizTenedora = (int)row["IdMatrizTenedora"];
                objInfoDetalle.RazonSocialMatrizTenedora = row["RazonSocialMatrizTenedora"].ToString();
                objInfoDetalle.IdTenedora = (int)row["IdTenedora"];
                objInfoDetalle.RazonSocialTenedora = row["RazonSocialTenedora"].ToString();
                objInfoDetalle.NombreComercialTenedora = row["NombreComercialTenedora"].ToString();
                objInfoDetalle.IdMatrizCliente = (int)row["IdMatrizCliente"];
                objInfoDetalle.RazonSocialMatrizCliente = row["RazonSocialMatrizCliente"].ToString();
                objInfoDetalle.IdCliente = (int)row["IdCliente"];
                objInfoDetalle.RazonSocialCliente = row["RazonSocialCliente"].ToString();
                objInfoDetalle.NombreComercialCliente = row["NombreComercialCliente"].ToString();
                objInfoDetalle.FechaInicio = (DateTime)row["FechaInicio"];
                objInfoDetalle.FechaFin = (DateTime)row["FechaFin"];
                objInfoDetalle.PeriodoPago = row["PeriodoPago"].ToString();
                objInfoDetalle.TipoCambio = (decimal)row["TipoCambio"];
                objInfoDetalle.IdMoneda = row["IdMoneda"].ToString();
                objInfoDetalle.IdTipoPeriodoNomina = (byte)row["IdTipoPeriodoNomina"];
                objInfoDetalle.TipoNomina = row["TipoNomina"].ToString();
                objInfoDetalle.IdOperador = (Int16)row["IdOperador"];
                objInfoDetalle.Operador = row["Operador"].ToString();
                objInfoDetalle.EstatusNominaContabilizada = (bool)row["EstatusNominaContabilizada"];
                objInfoDetalle.MesPago = row["MesPago"].ToString();
                objInfoDetalle.AnoPago = (short)row["AnoPago"];
                objInfoDetalle.IdEstatusCFDI = (byte)row["IdEstatusCFDI"];
                objInfoDetalle.DescEstatusCFDI = row["DescEstatusCFDI"].ToString();
                objInfoDetalle.IdControl = (Int64)row["IdControl"];
            }
            return objInfoDetalle;  //regresar objeto
        }

        /// <summary>
        /// Método que recibe un DataTable que contiene los datos
        /// el LoteCargaNomina consultado
        /// </summary>
        /// <param name="dt">DataTable</param>
        /// <returns>Objeto InfoDetalleLoteCargaNomina</returns>
        public static InfoDetalleLoteCargaNomina ObtenerInfoDetalleLoteCargaNominaGenericoCheques(DataTable dt)
        {
            InfoDetalleLoteCargaNomina objInfoDetalle = null;

            //si existe un registro
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                //asignar valores al objeto InfoDetalleLoteCargaNomina
                objInfoDetalle = new InfoDetalleLoteCargaNomina();
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
                objInfoDetalle.TipoCambio = (decimal)row["TipoCambio"];
                objInfoDetalle.IdMoneda = row["IdMoneda"].ToString();
                objInfoDetalle.IdTipoPeriodoNomina = (byte)row["IdTipoPeriodoNomina"];
                objInfoDetalle.TipoNomina = row["TipoNomina"].ToString();
                objInfoDetalle.IdOperador = (Int16)row["IdOperador"];
                objInfoDetalle.Operador = row["Operador"].ToString();
                objInfoDetalle.EstatusNominaContabilizada = (bool)row["EstatusNominaContabilizada"];
            }
            return objInfoDetalle;  //regresar objeto
        }

    }
}
