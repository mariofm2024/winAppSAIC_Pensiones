using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace compCatalogosSAIC
{
    public static class PolizaBD
    {
        /// <summary>
        /// Método para asignar al Objeto Cliente la información que se visualiza
        /// </summary>
        /// <param name="objCliente"></param>
        /// <param name="row"></param>
        public static Poliza AsignarInfoPoliza(DataRow row)
        {
            Poliza objPoliza = null;

            try
            {
                objPoliza = new Poliza();

                //asignar valores extraidos del Combobox
                objPoliza.IdPoliza = Convert.ToInt32(row[0]);
                objPoliza.NoPoliza = row[1].ToString();
                objPoliza.IdCIAAseguradora = Convert.ToInt32(row[2].ToString());
                objPoliza.IdTipoSeguro = Convert.ToInt32(row[3].ToString());
                objPoliza.Concepto = row[4].ToString();
                objPoliza.IdCliente = Convert.ToInt32(row[5].ToString());
                objPoliza.IdTenedora = Convert.ToInt32(row[6].ToString());
                objPoliza.IdTipoMetodoPago = Convert.ToInt32(row[7].ToString());
                objPoliza.IdEstatus = Convert.ToInt32(row[8].ToString());
                objPoliza.FechaEMI = Convert.ToDateTime(row[9].ToString());
                objPoliza.FechaIniVig = Convert.ToDateTime(row[10].ToString());
                objPoliza.FechaFinVig = Convert.ToDateTime(row[11].ToString());
                objPoliza.UsuarioCreacion = row[13].ToString();
                objPoliza.IdTipoPagadorPoliza = Convert.ToInt32(row[14].ToString());

            }
            catch   //(Exception ex)
            {
                //throw ex;
                return null;
            }
            return objPoliza;
        }
        
        
        
        public static bool InsertarPoliza(Cliente objPoliza, string sConexionBD)
        {
            return true;
        }
        


        public static bool ActualizarInfoPoliza(Poliza objPoliza, string sConexionBD)
        {
            SqlConnection Cnn = null;
            SqlCommand cmdUpdate;

            try
            {
                Cnn = new SqlConnection(sConexionBD);
                Cnn.Open();

                cmdUpdate = new SqlCommand("stpUpdCatPoliza", Cnn);
                cmdUpdate.CommandType = System.Data.CommandType.StoredProcedure;

                //parametros
                cmdUpdate.Parameters.AddWithValue("@pIdPoliza", objPoliza.IdPoliza);
                cmdUpdate.Parameters.AddWithValue("@pNoPoliza", objPoliza.NoPoliza);
                cmdUpdate.Parameters.AddWithValue("@pIdCIAAseguradora", objPoliza.IdCIAAseguradora);
                cmdUpdate.Parameters.AddWithValue("@pIdTipoSeguro", objPoliza.IdTipoSeguro);
                cmdUpdate.Parameters.AddWithValue("@pConcepto", objPoliza.Concepto);
                cmdUpdate.Parameters.AddWithValue("@pIdCliente", objPoliza.IdCliente);
                cmdUpdate.Parameters.AddWithValue("@pIdTenedora", objPoliza.IdTenedora);
                cmdUpdate.Parameters.AddWithValue("@pIdTipoMetodoPago", objPoliza.IdTipoMetodoPago);
                cmdUpdate.Parameters.AddWithValue("@pIdEstatus", objPoliza.IdEstatus);
                cmdUpdate.Parameters.AddWithValue("@pFechaEMI", objPoliza.FechaEMI);
                cmdUpdate.Parameters.AddWithValue("@pFechaIinVig", objPoliza.FechaIniVig);
                cmdUpdate.Parameters.AddWithValue("@pFechaFinVig", objPoliza.FechaFinVig);
                cmdUpdate.Parameters.AddWithValue("@pUsuarioModificacion", objPoliza.UsuarioCreacion);
                
                cmdUpdate.ExecuteNonQuery();    //ejecutar stored procedure
            }
            catch //(Exception ex)
            {
                return false;
            }
            return true;
        }

    }
}
