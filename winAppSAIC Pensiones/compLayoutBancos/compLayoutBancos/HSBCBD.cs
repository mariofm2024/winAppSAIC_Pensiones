using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace compLayoutBancos
{
    /// <summary>
    /// Clase para manipular información de Empleados/Asociados
    /// </summary>
    public static class HSBCBD
    {
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
        /// <returns>Objeto Lista HSBC Otras Cuentas</returns>
        public static List<HSBCOtrasCuentas> ObtenerInformacionBancariaEmpleadoOtrasCuentas(DataTable objTable)
        {
            List<HSBCOtrasCuentas> objInfoBancariaEmpleadoList = new List<HSBCOtrasCuentas>();
            HSBCOtrasCuentas objInfoBancariaEmpleado = null;
            ImporteDetalle = 0;     //inicializar propiedad
            try
            {
                foreach (DataRow row in objTable.Rows)
                {
                    objInfoBancariaEmpleado = new HSBCOtrasCuentas();
                    objInfoBancariaEmpleado.NoCuentaBanco = row[0].ToString();
                    objInfoBancariaEmpleado.Importe = (decimal)row[1];
                    objInfoBancariaEmpleado.ClaveMoneda = row[2].ToString();
                    objInfoBancariaEmpleado.DescPago = row[3].ToString();
                    objInfoBancariaEmpleado.Beneficiario = row[4].ToString().PadRight(40,' ');
                    objInfoBancariaEmpleado.ComprobanteFiscal = row[5].ToString();
                    objInfoBancariaEmpleado.RFCBeneficiario = row[6].ToString();
                    objInfoBancariaEmpleado.IVA = row[7].ToString();
                    objInfoBancariaEmpleado.Email = row[8].ToString();
                    ImporteDetalle += (decimal)row[1];  //acumula importes
                    objInfoBancariaEmpleadoList.Add(objInfoBancariaEmpleado);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objInfoBancariaEmpleadoList;     //regresar informacion
        }

        /// <summary>
        /// Método que construye una lista con los registros de pago de cada Empleado/Asociado
        /// </summary>
        /// <param name="objTable">Objeto DataTable con los registros seleccionados de la Base de Datos</param>
        /// <returns>Objeto Lista HSBC SPEI</returns>
        public static List<HSBCSPEI> ObtenerInformacionBancariaEmpleadoSPEI(DataTable objTable)
        {
            List<HSBCSPEI> objInfoBancariaEmpleadoList = new List<HSBCSPEI>();
            HSBCSPEI objInfoBancariaEmpleado = null;
            ImporteDetalle = 0;     //inicializar propiedad
            try
            {
                foreach (DataRow row in objTable.Rows)
                {
                    objInfoBancariaEmpleado = new HSBCSPEI();
                    objInfoBancariaEmpleado.NoCuentaBanco = row[0].ToString();
                    objInfoBancariaEmpleado.Importe = (decimal)row[1];
                    objInfoBancariaEmpleado.ReferenciaNumerica = row[2].ToString();
                    objInfoBancariaEmpleado.DescPago = row[3].ToString();
                    objInfoBancariaEmpleado.DescPagoOrdenante = row[4].ToString();
                    ImporteDetalle += (decimal)row[1];  //acumula importes
                    objInfoBancariaEmpleadoList.Add(objInfoBancariaEmpleado);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objInfoBancariaEmpleadoList;     //regresar informacion
        }


        /// <summary>
        /// Método que construye una lista con los registros de pago de cada Empleado
        /// </summary>
        /// <param name="objTable">Objeto DataTable con los registros seleccionados de la Base de Datos</param>
        /// <returns>Objeto Lista HSBC Nóminas</returns>
        public static List<HSBCNominas> ObtenerInformacionBancariaEmpleadoNominas(DataTable objTable)
        {
            List<HSBCNominas> objInfoBancariaEmpleadoList = new List<HSBCNominas>();
            HSBCNominas objInfoBancariaEmpleado = null;
            ImporteDetalle = 0;     //inicializar propiedad
            try
            {
                foreach (DataRow row in objTable.Rows)
                {
                    objInfoBancariaEmpleado = new HSBCNominas();
                    objInfoBancariaEmpleado.NoCuentaBanco = row[0].ToString();
                    objInfoBancariaEmpleado.Importe = (decimal)row[1];
                    objInfoBancariaEmpleado.DescPago = row[2].ToString();
                    objInfoBancariaEmpleado.Beneficiario = row[3].ToString();
                    ImporteDetalle += (decimal)row[1];  //acumula importes
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
