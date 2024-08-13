using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace compCatalogosSAIC
{
    public static class FactConceptoTenedoraDB
    {
        public static FactConceptoTenedora ObtenerInfoDetalleFactConceptoTenedora(DataRow row)
        {
            FactConceptoTenedora objInfoDetalle = null;
            try
            {
                objInfoDetalle = new FactConceptoTenedora();
                objInfoDetalle.IdFactConceptoTenedora = Convert.ToInt64(row[0].ToString());
                objInfoDetalle.IdFactClaveProduServ = Convert.ToInt32(row[1].ToString());
                objInfoDetalle.IdTenedoraMatriz = Convert.ToInt32(row[3].ToString());
                objInfoDetalle.DescConceptoInterno = row[5].ToString();
                objInfoDetalle.IdEstatus = Convert.ToInt32(row[6].ToString());
            }
            catch (Exception ex)
            {
                return null;
            }
            return objInfoDetalle;
        }
    }
}
