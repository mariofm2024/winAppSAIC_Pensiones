using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace compNominaCFDI
{
    public static class NominaTimbreFacilBD
    {
        public static Decimal ImporteDetalleGravado { get; set; }
        public static Decimal ImporteDetalleExento { get; set; }
        public static Decimal ImporteDetalleGravadoPercepcion { get; set; }
        public static Decimal ImporteDetalleExentoPercepcion { get; set; }
        public static Decimal ImporteDetalleGravadoDeduccion { get; set; }
        public static Decimal ImporteDetalleExentoDeduccion { get; set; }

        /// <summary>
        /// Método para obtener la información Encabezado del Lote de Nómina
        /// seleccionado para el Layout XML Timbre Facil
        /// </summary>
        /// <param name="objTable">Objeto de Tipo DataTable</param>
        /// <returns>Objeto HeaderNominaTimbreFacil</returns>
        public static HeaderNominaTimbreFacil ObtenerEncabezadoNominas2XLS(DataTable objTable)
        {
            HeaderNominaTimbreFacil objNomina = null;

            try
            {
                foreach (DataRow row in objTable.Rows)
                {
                    objNomina = new HeaderNominaTimbreFacil();
                    objNomina.IdentificadorNomina = row["IdentificadorNomina"].ToString();
                    objNomina.Ano = row["Ano"].ToString();
                    objNomina.Periodo = row["Periodo"].ToString();
                    objNomina.Parcial = row["Parcial"].ToString();
                    objNomina.RazonSocial = row["RazonSocial"].ToString();
                    objNomina.RFC = row["RFC"].ToString();
                    objNomina.Calle = row["Calle"].ToString();
                    objNomina.NoExterior = row["NoExterior"].ToString();
                    objNomina.NoInterior = row["NoInterior"].ToString();
                    objNomina.Colonia = row["Colonia"].ToString();
                    objNomina.CodigoPostal = row["CodigoPostal"].ToString();
                    objNomina.Estado = row["Estado"].ToString();
                    objNomina.Pais = row["Pais"].ToString();
                    objNomina.DelegacionMunicipio = row["DelegacionMunicipio"].ToString();
                    objNomina.PoblacionCiudad = row["PoblacionCiudad"].ToString();
                    objNomina.LeyendaIDCONSAR = row["IDCONSAR"].ToString();
                    objNomina.CondicionesPago = row["CondicionesPago"].ToString();
                    objNomina.DescConcepto = row["DescConcepto"].ToString();
                    objNomina.UnidadConcepto = row["UnidadConcepto"].ToString();
                    objNomina.IdTenedora = Convert.ToInt32(row["IdTenedora"]);
                    objNomina.IdLoteCargaNomina = Convert.ToInt64(row["IdLoteCargaNomina"]);
                    objNomina.LeyendaLugarExpedicion = row["LeyendaLugarExpedicion"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objNomina;
        }
    }
}
