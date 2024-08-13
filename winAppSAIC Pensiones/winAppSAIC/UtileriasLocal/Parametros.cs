using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace winAppSAIC.UtileriasLocal
{
    public static class Parametros
    {
        public static string ObtenerValorParametro(DataTable objDT)
        {
            DataRow row = objDT.Rows[0];
            return row["ValorParametro"].ToString();
        }
    }
}
