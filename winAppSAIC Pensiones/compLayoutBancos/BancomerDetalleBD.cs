using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace compLayoutBancos
{
    public static class BancomerDetalleBD
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
        /// <returns>Objeto Lista Banorte</returns>
        public static List<Bancomer> ObtenerInformacionBancariaEmpleado(DataTable objTable)
        {
            List<Bancomer> objInfoBancariaEmpleadoList = new List<Bancomer>();
            Bancomer objInfoBancariaEmpleado = null;
            ImporteDetalle = 0;     //inicializar propiedad
            try
            {
                foreach (DataRow row in objTable.Rows)
                {
                    objInfoBancariaEmpleado = new Bancomer();
                    objInfoBancariaEmpleado.NoRenglon = row[0].ToString();
                    objInfoBancariaEmpleado.RFC = row[1].ToString();
                    objInfoBancariaEmpleado.TipoCuenta = row[2].ToString();
                    objInfoBancariaEmpleado.NoCuenta = row[3].ToString();
                    objInfoBancariaEmpleado.Importe = (decimal)row[4];
                    objInfoBancariaEmpleado.Beneficiario = row[5].ToString();
                    objInfoBancariaEmpleado.BancoDestino = row[6].ToString();
                    objInfoBancariaEmpleado.PlazaDestino = row[7].ToString();
                    ImporteDetalle += (decimal)row[4];  //acumula importes
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
