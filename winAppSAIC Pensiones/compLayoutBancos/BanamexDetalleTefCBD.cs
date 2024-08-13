using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace compLayoutBancos
{
    public static class BanamexDetalleTefCBD
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
        /// <returns>Objeto Lista BanamexDetalleTEFC</returns>
        public static List<BanamexDetalleTefC> ObtenerInformacionBancariaEmpleado(DataTable objTable)
        {

            List<BanamexDetalleTefC> objInfoBancariaEmpleadoList = new List<BanamexDetalleTefC>();
            BanamexDetalleTefC objInfoBancariaEmpleado = null;
            ImporteDetalle = 0;     //inicializar propiedad
            try
            {
                foreach (DataRow row in objTable.Rows)
                {
                    objInfoBancariaEmpleado = new BanamexDetalleTefC();
                    objInfoBancariaEmpleado.TipoRegistro = row[0].ToString();
                    objInfoBancariaEmpleado.TipoOperacion = row[1].ToString();
                    objInfoBancariaEmpleado.ClaveMoneda = row[2].ToString();
                    objInfoBancariaEmpleado.Importe = (decimal)row[3];
                    ImporteDetalle += (decimal)row[3];  //acumula importes
                    objInfoBancariaEmpleado.TipoCuenta = row[4].ToString();
                    objInfoBancariaEmpleado.NoCuentaBanco = row[5].ToString();
                    objInfoBancariaEmpleado.RefAlfanumerica = row[6].ToString();
                    objInfoBancariaEmpleado.Beneficiario = row[7].ToString();
                    objInfoBancariaEmpleado.Instrucciones = row[8].ToString();
                    objInfoBancariaEmpleado.DescTEF = row[9].ToString();
                    objInfoBancariaEmpleado.ClaveBanco = row[10].ToString();
                    objInfoBancariaEmpleado.RefNum = row[11].ToString();
                    objInfoBancariaEmpleado.Plazo = row[12].ToString();
                    objInfoBancariaEmpleado.DescBanco = row[13].ToString();
                    objInfoBancariaEmpleado.IdLoteCargaNomina = (Int64)row[14];
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
