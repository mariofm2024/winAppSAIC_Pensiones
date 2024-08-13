using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace compCatalogosSAIC
{
    public static class PromotorDB
    {
        public static Promotor ObtenerInfoPromotor(DataRow row)
        {
            Promotor objPromotor = null;        //definir variable tipo Operador
            try
            {
                //asignar valores al objeto Operador
                objPromotor = new Promotor();       //crear objeto Operador
                objPromotor.IdPromotor = (int)row["IdPromotor"];
                objPromotor.Nombre = row["NombrePromotor"].ToString();
                objPromotor.APaterno = row["APaternoPromotor"].ToString();
                objPromotor.AMaterno = row["AMaternoPromotor"].ToString();
                objPromotor.CorreoElectronico = row["CorreoElectronico"].ToString();
                objPromotor.Telefono = row["Telefono"].ToString();
                objPromotor.IdEstatus = (int)row["IdEstatus"];
            }
            catch //(Exception ex)
            {
                return null;
            }

            return objPromotor;
        }
    }
}
