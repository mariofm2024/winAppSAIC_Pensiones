using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace compLayoutBancos
{
    public static class SantanderDetalleBD
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
        /// Método que construye una lista con los registros de pago de cada Empleado/Asociado Formato "Pago Nominas Entrada"
        /// </summary>
        /// <param name="objTable">Objeto DataTable con los registros seleccionados de la Base de Datos</param>
        /// <returns>Objeto Lista Santander</returns>
        public static List<SantanderDetalle> ObtenerInformacionBancariaNominasEmpleado(DataTable objTable)
        {
            List<SantanderDetalle> objInfoBancariaEmpleadoList = new List<SantanderDetalle>();
            SantanderDetalle objInfoBancariaEmpleado = null;
            ImporteDetalle = 0;     //inicializar propiedad
            try
            {
                foreach (DataRow row in objTable.Rows)
                {
                    objInfoBancariaEmpleado = new SantanderDetalle();
                    objInfoBancariaEmpleado.TipoRegistro = row[0].ToString();
                    objInfoBancariaEmpleado.NoSecuencia = row[1].ToString().PadLeft(5,'0');
                    objInfoBancariaEmpleado.NoEmpleado = row[2].ToString().PadLeft(7, '0');
                    objInfoBancariaEmpleado.ApellidoPaterno = row[3].ToString().PadRight(30,' ');
                    objInfoBancariaEmpleado.ApellidoMaterno = row[4].ToString().PadRight(20,' ');
                    objInfoBancariaEmpleado.Nombre = row[5].ToString().PadRight(30,' ');
                    objInfoBancariaEmpleado.NoCuenta = row[6].ToString().PadRight(11,' ');
                    objInfoBancariaEmpleado.Importe = (decimal)row[7];
                    ImporteDetalle += (decimal)row[7];  //acumula importes
                    objInfoBancariaEmpleadoList.Add(objInfoBancariaEmpleado);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objInfoBancariaEmpleadoList;     //regresar informacion
        }
    }
}
