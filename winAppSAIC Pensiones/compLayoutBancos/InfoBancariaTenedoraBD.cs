using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace compLayoutBancos
{
    public static class InfoBancariaTenedoraBD
    {
        /// <summary>
        /// Método que regresa una lista de los registros con la Informacion Bancaria
        /// de la Tenedora seleccionada
        /// </summary>
        /// <param name="row">Variable tipo DataRow</param>
        /// <returns>Lista de Objeto InfoBaDncariaTenedora</returns>
        public static List<InfoBancariaTenedora> ObtenerInfoBancaria(DataRow row, string pFormatoLayout)
        {
            List<InfoBancariaTenedora> objInfoBancariaList = new List<InfoBancariaTenedora>();
            InfoBancariaTenedora objInfoBancaria = null;
            try
            {
                objInfoBancaria = new InfoBancariaTenedora();
                objInfoBancaria.IdTenedora = (Int32)row[0];
                
                //Razon Social Tenedora
                if (row[25].ToString() == "L")
                    //concatenar ESPACIO en BLANCO a la izquierda y extraer solamente la longitud definida en la columna 24
                    objInfoBancaria.RazonSocial = row[1].ToString().PadLeft((byte)row[24],' ').Substring(0,36);
                else if (row[25].ToString() == "R")
                    //concatenar ESPACIO en BLANCO a la derecha y extraer solamente la longitud definida en la columna 24
                    objInfoBancaria.RazonSocial = row[1].ToString().PadRight((byte)row[24], ' ').Substring(0, 36);

                objInfoBancaria.IdBanco = (byte) row[2];
                objInfoBancaria.NombreBanco = row[3].ToString();
                objInfoBancaria.IdMoneda = row[4].ToString();

                //No. de Cliente Banco    
                if (row[7].ToString() == "L")
                    objInfoBancaria.NoCliente = row[5].ToString().PadLeft((byte)row[6],'0');
                else if (row[7].ToString() == "R")
                    objInfoBancaria.NoCliente = row[5].ToString().PadRight((byte)row[6], '0');

                objInfoBancaria.NoCaracteresNoCliente = (byte)row[6];
                objInfoBancaria.AlineacionNoCliente = row[7].ToString();

                //No. Sucusal Banco
                if (row[10].ToString() == "L")
                    objInfoBancaria.NoSucursal = row[8].ToString().PadLeft((byte)row[9], '0'); 
                else if (row[10].ToString() == "R")
                    objInfoBancaria.NoSucursal = row[8].ToString().PadRight((byte)row[9], '0'); 

                objInfoBancaria.NoCaracteresNoSucursal = (byte)row[9];
                objInfoBancaria.AlineacionNoSucursal = row[10].ToString();

                //No. de Cuenta Banco
                if (pFormatoLayout.Equals("SANTANDER-NOMINAS PAG"))
                {
                    if (row[13].ToString() == "L")
                        objInfoBancaria.NoCuenta = row[11].ToString().PadLeft((byte)row[12], ' ');
                    else if (row[13].ToString() == "R")
                        objInfoBancaria.NoCuenta = row[11].ToString().PadRight((byte)row[12], ' ');
                }
                else
                {
                    if (row[13].ToString() == "L")
                        objInfoBancaria.NoCuenta = row[11].ToString().PadLeft((byte)row[12], '0');
                    else if (row[13].ToString() == "R")
                        objInfoBancaria.NoCuenta = row[11].ToString().PadRight((byte)row[12], '0');
                }

                objInfoBancaria.NoCaracteresNoCuenta = (byte)row[12];
                objInfoBancaria.AlineacionNoCuenta = row[13].ToString();

                //Cuenta CLABE
                if (row[16].ToString() == "L")
                    objInfoBancaria.NoCLABE = row[14].ToString().PadLeft((byte)row[15], '0'); 
                else if (row[16].ToString() == "R")
                    objInfoBancaria.NoCLABE = row[14].ToString().PadRight((byte)row[15], '0'); 

                objInfoBancaria.NoCaracteresNoCLABE = (byte)row[15];
                objInfoBancaria.AlineacionNoCLABE = row[16].ToString();

                //Referencia Numerica
                if (row[19].ToString() == "L")
                    objInfoBancaria.RefNumerica = row[17].ToString().PadLeft((byte)row[18], '0'); 
                else if (row[19].ToString() == "R")
                    objInfoBancaria.RefNumerica = row[17].ToString().PadRight((byte)row[18], '0'); 

                objInfoBancaria.NoCaracteresRefNumerica = (byte)row[18];
                objInfoBancaria.AlineacionRefNumerica = row[19].ToString();

                //Referencia Numerica
                if (row[22].ToString() == "L")
                    objInfoBancaria.RefAlfanumerica = row[20].ToString().PadLeft((byte)row[21], '0');
                else if (row[22].ToString() == "R")
                    objInfoBancaria.RefAlfanumerica = row[20].ToString().PadRight((byte)row[21], '0');

                objInfoBancaria.NoCaracteresRefAlfanumerica = (byte)row[21];
                objInfoBancaria.AlineacionRefAlfanumerica = row[22].ToString();
                objInfoBancaria.CuentaContable = row[23].ToString();
                objInfoBancaria.NoCaracteresRazonSocial = (byte)row[24];
                objInfoBancaria.AlineacionRazonSocial = row[25].ToString();
                objInfoBancaria.IdEstatus = (byte)row[26];
                objInfoBancariaList.Add(objInfoBancaria);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return objInfoBancariaList;
        }
    }
}
