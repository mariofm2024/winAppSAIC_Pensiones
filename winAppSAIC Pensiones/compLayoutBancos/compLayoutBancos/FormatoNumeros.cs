using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compLayoutBancos
{
    public static class FormatoNumeros
    {
        /// <summary>
        /// Método que recibe un valor decimal y genera el mismo valor sin punto decimal
        /// </summary>
        public static string ObtenerNumeroSinDecimal(decimal pImporte)
        {
            string strNumeroSinDecimal = "0";
            try
            {
                string strImporte = string.Format("{0:0.00}", pImporte);    //formateo a 2 decimales
                int intPosicionPunto = strImporte.IndexOf(".");     //obtener posicion del punto decimal
                string strParteDecimal = strImporte.Substring(intPosicionPunto + 1, 2);     //extraer la seccion decimal
                string strParteEntera = Math.Truncate(Convert.ToDecimal(strImporte)).ToString();    //extraer la seccion entera
                strNumeroSinDecimal = strParteEntera + strParteDecimal;     //concatenar numero parte entera y decimal
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return strNumeroSinDecimal;
        }
    }
}
