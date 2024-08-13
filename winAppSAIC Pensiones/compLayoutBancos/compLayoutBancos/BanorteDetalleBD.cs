﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace compLayoutBancos
{
    public static class BanorteDetalleBD
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
        /// <returns>Objeto Lista Bancomer</returns>
        public static List<BanorteDetalle> ObtenerInformacionBancariaEmpleado(DataTable objTable, string strFechaAplicacion)
        {

            List<BanorteDetalle> objInfoBancariaEmpleadoList = new List<BanorteDetalle>();
            BanorteDetalle objInfoBancariaEmpleado = null;
            ImporteDetalle = 0;     //inicializar propiedad
            try
            {
                foreach (DataRow row in objTable.Rows)
                {
                    objInfoBancariaEmpleado = new BanorteDetalle();
                    objInfoBancariaEmpleado.TipoRegistro = row[0].ToString();
                    objInfoBancariaEmpleado.FechaAplicacion = strFechaAplicacion;
                    objInfoBancariaEmpleado.NoEmpleado = row[1].ToString().PadLeft(10,'0');
                    objInfoBancariaEmpleado.ReferenciaServicio = row[2].ToString();
                    objInfoBancariaEmpleado.ReferenciaLeyenda = row[3].ToString();
                    objInfoBancariaEmpleado.Importe = (decimal)row[4];
                    objInfoBancariaEmpleado.NoBancoReceptor = row[5].ToString();
                    objInfoBancariaEmpleado.TipoCuenta = row[6].ToString();
                    objInfoBancariaEmpleado.NoCuenta = row[7].ToString().PadLeft(18,'0');
                    objInfoBancariaEmpleado.TipoMovimiento = row[8].ToString();
                    objInfoBancariaEmpleado.Accion = row[9].ToString();
                    objInfoBancariaEmpleado.ImporteIVAOperacion = row[10].ToString();
                    objInfoBancariaEmpleado.Filler = row[11].ToString();
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
