using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace compCatalogosSAIC
{
    public static class FrontingClienteBD
    {
        public static FrontingCliente AsignarInfoCliente(DataRow row)
        {
            FrontingCliente objFrontingCliente = null;

            try
            {
                objFrontingCliente = new FrontingCliente();

                //asignar valores extraidos del Combobox
                objFrontingCliente.IdFactFrontingCliente = Convert.ToInt32(row[0]);
                objFrontingCliente.IdCliente = Convert.ToInt32(row[1]);
                objFrontingCliente.IdFronting = Convert.ToInt32(row[2]);
                objFrontingCliente.IdEstatus = Convert.ToInt16(row[3]);

            }
            catch   //(Exception ex)
            {
                //throw ex;
                return null;
            }
            return objFrontingCliente;
        }
        public static bool InsertarCliente(Cliente objCliente, string sConexionBD)
        {
            return true;
        }
        public static bool ActualizarInfoCliente(FrontingCliente objFrontingCliente, string sConexionBD)
        {
            SqlConnection Cnn = null;
            SqlCommand cmdUpdate;

            try
            {
                Cnn = new SqlConnection(sConexionBD);
                Cnn.Open();

                cmdUpdate = new SqlCommand("stpUpdFactFrontingCliente", Cnn);
                cmdUpdate.CommandType = System.Data.CommandType.StoredProcedure;

                //parametros
                cmdUpdate.Parameters.AddWithValue("@IdFactFrontingCliente", objFrontingCliente.IdFactFrontingCliente);
                cmdUpdate.Parameters.AddWithValue("@IdFronting", objFrontingCliente.IdCliente);
                cmdUpdate.Parameters.AddWithValue("@IdCliente", objFrontingCliente.IdFronting);
                cmdUpdate.Parameters.AddWithValue("@IdEstatus", objFrontingCliente.IdEstatus);
                cmdUpdate.Parameters.AddWithValue("@UsuarioModificacion", objFrontingCliente.UsuarioModificacion);
                cmdUpdate.ExecuteNonQuery();    //ejecutar stored procedure
            }
            catch //(Exception ex)
            {
                return false;
            }
            return true;
        }
        public static FrontingCliente ObtenerInfoFrontingCliente(DataRow row)
        {
            FrontingCliente objInfoDetalle = null;
            try
            {
                objInfoDetalle = new FrontingCliente();
                objInfoDetalle.IdFactFrontingCliente = (Int32)row["IdFactFrontingCliente"];
                objInfoDetalle.IdFronting = (Int32)row["IdFronting"];
                objInfoDetalle.IdCliente = (Int32)row["IdCliente"];
                objInfoDetalle.IdEstatus = (Int16)row["IdEstatus"];
            }
            catch (Exception ex)
            {
                return null;
            }
            return objInfoDetalle;
        }

    }
}
