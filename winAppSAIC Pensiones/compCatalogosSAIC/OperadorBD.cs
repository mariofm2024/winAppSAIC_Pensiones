using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace compCatalogosSAIC
{
    public static class OperadorBD
    {
        //propiedad global que almacenará la información del Operador
        public static Operador OperadorGlobal
        {
            get;
            set;
        }

        public static Operador ObtenerInfoOperador(DataTable dt)
        {
            Operador objOperador = null;        //definir variable tipo Operador
            try
            {
                //si existe un registro
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    //asignar valores al objeto Operador
                    objOperador = new Operador();       //crear objeto Operador
                    objOperador.IdOperador = (short)row["IdOperador"];
                    objOperador.NombreOperador = row["NombreCompletoOperador"].ToString();
                    objOperador.NombreUsuario = row["NombreUsuario"].ToString();
                    objOperador.CorreoElectronico = row["CorreoElectronico"].ToString();
                    objOperador.IdAreaOperativa = (byte)row["IdAreaOperativa"];
                    objOperador.Confidencial = (bool)row["Confidencial"];
                    objOperador.Activo = (bool)row["Activo"];
                    objOperador.AreaOperativa = row["DescAreaOperativa"].ToString();
                    objOperador.IdGrupo = (short)row["IdGrupo"];
                    objOperador.Grupo = row["DescGrupo"].ToString();
                    objOperador.VigenciaContrasenia = Convert.ToInt32(row["VigenciaContrasenia"].ToString());
                }
            }
            catch //(Exception ex)
            {
                return null;
            }

            return objOperador;
        }

        public static short InsertarOperador(Operador objOperador, string sConexionBD)
        {
            short shIdOperador = 0;
            try
            {
                using (SqlConnection Cnn = new SqlConnection(sConexionBD))
                {
                    SqlCommand cmd = new SqlCommand("dbo.stpInsOperador", Cnn) 
                    { CommandType = CommandType.StoredProcedure };

                    cmd.Parameters.AddWithValue("@pClaveInternaOperador", objOperador.ClaveInternaOperador);
                    cmd.Parameters.AddWithValue("@pNombreCompletoOperador", objOperador.NombreOperador);
                    cmd.Parameters.AddWithValue("@pNombreUsuario", objOperador.NombreUsuario);
                    cmd.Parameters.AddWithValue("@pContrasena", objOperador.Contrasena);
                    cmd.Parameters.AddWithValue("@pCorreoElectronico", objOperador.CorreoElectronico);
                    cmd.Parameters.AddWithValue("@pIdAreaOperativa", objOperador.IdAreaOperativa);
                    cmd.Parameters.AddWithValue("@pActivo", objOperador.Activo);
                    cmd.Parameters.AddWithValue("@pConfidencial", objOperador.Confidencial);
                    cmd.Parameters.AddWithValue("@pActivoParaNominas", objOperador.ActivoParaNominas);
                    cmd.Parameters.AddWithValue("@pIdEstatusReportes", objOperador.IdEstatusReportes);
                    cmd.Parameters.AddWithValue("@pIdPlaza", objOperador.IdPlaza);
                    cmd.Parameters.AddWithValue("@pUsuarioCreacion", objOperador.UsuarioCreacion);
                    cmd.Parameters.AddWithValue("@pIdGrupo", objOperador.IdGrupo);

                    //parámetro de salida OUTPUT
                    SqlParameter param = new SqlParameter("@pIdOperador", SqlDbType.SmallInt);
                    param.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(param);

                    Cnn.Open(); //abrir conexion
                    cmd.ExecuteNonQuery();  //ejecutar stored procedure
                    
                    //asigna IdOperador generado en stored procedure
                    shIdOperador = Convert.ToInt16(cmd.Parameters["@pIdOperador"].Value); 
                    Cnn.Close();    //cerrar conexion
                }  //using
            }
            catch (SqlException ex)
            {
                return 0;
            }
            catch (Exception ex)
            {
                return 0;
            }
            return shIdOperador;
        }

    }
}
