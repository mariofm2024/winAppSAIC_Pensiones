using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace compCatalogosSAIC
{
    public static class FactConceptoTenedoraBeneficiarioDB
    {
        public static FactConceptoTenedoraBeneficiario ObtenerInfoDetalleFactConceptoTenedoraBeneficiario(DataRow row)
        {
            FactConceptoTenedoraBeneficiario objInfoDetalle = null;
            try
            {
                objInfoDetalle = new FactConceptoTenedoraBeneficiario();
                objInfoDetalle.IdFactConceptoTenedoraBeneficiario = Convert.ToInt64(row[0].ToString());
                objInfoDetalle.IdFronting= Convert.ToInt32(row[13].ToString());
                objInfoDetalle.IdConceptoTenedora = Convert.ToInt64(row[1].ToString());
                objInfoDetalle.IdBeneficiario = Convert.ToInt32(row[4].ToString());
                objInfoDetalle.IdUsoCFDI = Convert.ToInt32(row[7].ToString());
                objInfoDetalle.IdTipoBeneficiario = Convert.ToInt32(row[9].ToString());
                objInfoDetalle.DescConceptoInterno = row[10].ToString();
                objInfoDetalle.IVA = Convert.ToBoolean(row[14]);
                objInfoDetalle.Retencion = Convert.ToBoolean(row[15]);
                objInfoDetalle.Monto = Convert.ToDecimal(row[16].ToString().Replace("$", string.Empty).Replace(",", string.Empty));
                objInfoDetalle.FechaInicio = Convert.ToDateTime(row[17].ToString());
                objInfoDetalle.FechaFin = Convert.ToDateTime(row[18].ToString());
                objInfoDetalle.IdEstatus = Convert.ToInt32(row[11].ToString());
                objInfoDetalle.ObjetoImpuesto = Convert.ToBoolean(row[19].ToString());
            }
            catch (Exception ex)
            {
                return null;
            }
            return objInfoDetalle;
        }
    }
}
