using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace winAppSAIC.UtileriasLocal
{
    public static class Conversiones
    {
        public static string ConvertirFechaAAAAMMDD(string pFecha)
        {
            string dtFechaNueva = Convert.ToDateTime(pFecha).ToString("yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);

            return dtFechaNueva;
        }

        public static string AgregarDiagonales2Fecha(string pFecha)
        {
            string strTemp = pFecha.Insert(4, "/");
            strTemp = strTemp.Insert(7, "/");

            return strTemp;
        }

        public static string AgregarGuiones2Fecha(string pFecha)
        {
            string strTemp = pFecha.Insert(4, "-");
            strTemp = strTemp.Insert(7, "-");

            return strTemp;
        }
    }
}
