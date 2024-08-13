using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace compLayoutBancos
{
    /// <summary>
    /// Clase para manipular información de Empleados/Asociados Inbursa
    /// </summary>
    public static class InbursaBD
    {
        /// Propiedad que almacena el importe total de los N registros procesados
        /// </summary>
        public static Decimal ImporteDetalle {get; set;}

        /// <summary>
        /// Método que construye una lista con los registros de pago de cada Empleado/Asociado
        /// </summary>
        /// <param name="objTable">Objeto DataTable con los registros seleccionados de la Base de Datos</param>
        /// <returns>Objeto Lista Inbursa SPEI</returns>
        public static List<InbursaSPEI> ObtenerInformacionBancariaEmpleadoSPEI(DataTable objTable)
        {
            List<InbursaSPEI> objInfoBancariaEmpleadoList = new List<InbursaSPEI>();
            InbursaSPEI objInfoBancariaEmpleado = null;
            ImporteDetalle = 0;     //inicializar propiedad
            try
            {
                foreach (DataRow row in objTable.Rows)
                {
                    objInfoBancariaEmpleado = new InbursaSPEI();
                    objInfoBancariaEmpleado.FechaAplicacion = row[0].ToString();
                    objInfoBancariaEmpleado.NoCuentaBanco = row[1].ToString();
                    objInfoBancariaEmpleado.Importe = (decimal)row[2];
                    objInfoBancariaEmpleado.ReferenciaLeyenda = row[3].ToString();
                    objInfoBancariaEmpleado.ReferenciaExt = row[4].ToString();
                    objInfoBancariaEmpleado.ReferenciaNumerica = row[5].ToString();
                    objInfoBancariaEmpleado.RFC = row[6].ToString();
                    objInfoBancariaEmpleado.Identificador = row[7].ToString();
                    ImporteDetalle += (decimal)row[2];  //acumula importes
                    objInfoBancariaEmpleadoList.Add(objInfoBancariaEmpleado);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return objInfoBancariaEmpleadoList;     //regresar informacion
        }

    }
}
