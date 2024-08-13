using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace compCatalogosSAIC
{
    public static class InfoCuentaBancoBD
    {
        /// <summary>
        /// Método que almacena la información de Cuenta de Banco
        /// </summary>
        /// <param name="row">Variable tipo DataRow</param>
        /// <returns>Objeto InfoCuentaBanco</returns>
        public static InfoCuentaBanco ObtenerInfoCuentabanco(DataRow row)
        {
            InfoCuentaBanco objInfoCuentaBanco = null;
            try
            {
                objInfoCuentaBanco = new InfoCuentaBanco();
                objInfoCuentaBanco.IdCuentaBanco = (Int32)row["IdCuentaBanco"];
                objInfoCuentaBanco.IdMatrizTenedora  = (Int32)row["IdMatrizTenedora"];
                objInfoCuentaBanco.IdClasifCuentaBanco = Convert.ToByte(row["IdClasifCuentaBanco"]);
                objInfoCuentaBanco.NombreCuentaBanco = row["NombreCuentaBanco"].ToString();
                objInfoCuentaBanco.IdBanco = Convert.ToByte(row["IdBanco"]);
                objInfoCuentaBanco.NoCuenta = row["NoCuenta"].ToString();
                objInfoCuentaBanco.NoSucursal = row["NoSucursal"].ToString();
                objInfoCuentaBanco.NoCliente = row["NoCliente"].ToString();
                objInfoCuentaBanco.NoCLABE = row["NoCLABE"].ToString();
                objInfoCuentaBanco.SaldoInicial = Convert.ToDecimal(row["SaldoInicial"]);
                objInfoCuentaBanco.IdMoneda = row["IdMoneda"].ToString();
                objInfoCuentaBanco.DescMoneda = row["DescMoneda"].ToString();
                objInfoCuentaBanco.NombreContacto = row["NombreContacto"].ToString();
                objInfoCuentaBanco.Telefono1 = row["Telefono1"].ToString();
                objInfoCuentaBanco.Telefono2 = row["Telefono2"].ToString();
                objInfoCuentaBanco.CorreoElectronico = row["CorreoElectronico"].ToString();
                objInfoCuentaBanco.Observaciones = row["Observaciones"].ToString();
                objInfoCuentaBanco.CuentaContable = row["CuentaContable"].ToString();
                objInfoCuentaBanco.IdEstatus = (byte)row["IdEstatus"];
            }
            catch   //(Exception ex)
            {
                //throw ex;
                return null;
            }
            return objInfoCuentaBanco;
        }
    }
}
