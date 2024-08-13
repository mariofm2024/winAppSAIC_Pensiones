using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace compLayoutBancos
{
    public static class BanamexDetalleTefDBD
    {
        /// <summary>
        /// Propiedad que almacena el importe total de los N registros procesados
        /// </summary>
        public static Decimal ImporteDetalle
        {
            get;
            set;
        }

        /// <summary>
        /// Método que construye una lista con los registros de pago de cada Empleado/Asociado
        /// </summary>
        /// <param name="objTable">Objeto DataTable con los registros seleccionados de la Base de Datos</param>
        /// <returns>Objeto Lista BanamexDetalleTEFD</returns>
        public static List<BanamexDetalleTefD> ObtenerInformacionBancariaEmpleado(DataTable objTable)
        {

            List<BanamexDetalleTefD> objInfoBancariaEmpleadoList = new List<BanamexDetalleTefD>();
            BanamexDetalleTefD objInfoBancariaEmpleado = null;
            ImporteDetalle = 0;     //inicializar propiedad
            try
            {
                foreach (DataRow row in objTable.Rows)
                {
                    objInfoBancariaEmpleado = new BanamexDetalleTefD();
                    objInfoBancariaEmpleado.TipoRegistro = row[0].ToString();
                    objInfoBancariaEmpleado.TipoOperacion = row[1].ToString();
                    objInfoBancariaEmpleado.MetodoPago = row[2].ToString();
                    objInfoBancariaEmpleado.TipoPago = row[3].ToString();
                    objInfoBancariaEmpleado.ClaveMoneda = row[4].ToString();
                    objInfoBancariaEmpleado.Importe = (decimal)row[5];
                    ImporteDetalle += (decimal)row[5];  //acumula importes
                    objInfoBancariaEmpleado.TipoCuenta = row[6].ToString();
                    objInfoBancariaEmpleado.NoCuentaBanco = row[7].ToString();
                    objInfoBancariaEmpleado.RefAlfanumerica = row[8].ToString();
                    objInfoBancariaEmpleado.Beneficiario = row[9].ToString();
                    objInfoBancariaEmpleado.Referencia1 = row[10].ToString();
                    objInfoBancariaEmpleado.Referencia2 = row[11].ToString();
                    objInfoBancariaEmpleado.Referencia3 = row[12].ToString();
                    objInfoBancariaEmpleado.Referencia4 = row[13].ToString();
                    objInfoBancariaEmpleado.ClaveBanco = row[14].ToString();
                    objInfoBancariaEmpleado.Plazo = row[15].ToString();
                    objInfoBancariaEmpleado.RFC = row[16].ToString();
                    objInfoBancariaEmpleado.IVA = row[17].ToString();
                    objInfoBancariaEmpleado.UsoFuturo1  = row[18].ToString();
                    objInfoBancariaEmpleado.UsoFuturo2 = row[19].ToString();
                    objInfoBancariaEmpleado.DescBanco = row[20].ToString();
                    objInfoBancariaEmpleado.IdLoteCargaNomina = (Int64)row[21];
                    objInfoBancariaEmpleadoList.Add(objInfoBancariaEmpleado);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objInfoBancariaEmpleadoList;
        }

    }
}
