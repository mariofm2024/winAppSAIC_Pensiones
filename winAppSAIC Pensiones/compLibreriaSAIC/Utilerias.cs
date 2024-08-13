using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Data.SqlClient;




namespace compLibreriaSAIC
{
    public class Utilerias
    {
        /// <summary>
        /// Valida si el servidor SQL está activo
        /// </summary>
        /// <param name="connectionString">String de Conexion</param>
        /// <returns>Verdadero si la Conexión fué exitosa</returns>
        public static bool IsServidorConectado(string connectionString)
        {
            using (SqlConnection Cnn = new SqlConnection(connectionString))
            {
                try
                {
                    Cnn.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
                finally
                {
                    if (Cnn != null)    //si existe conexion
                    {
                        if (Cnn.State == System.Data.ConnectionState.Open)
                        {
                            Cnn.Close();        //cerrar conexion
                            Cnn.Dispose();      //destruir conexion
                        }
                        else
                            Cnn.Dispose();      //destruir conexion
                    }
                }
            }
        }

        /// <summary>
        /// Método que automáticamente abre un archivo
        /// asociado con el programa instalado (XLS)
        /// </summary>
        /// <param name="path">Ruta y nombre dle archivo</param>
        public static void StartProcess(string path)
        {
            Process process = new Process();
            try
            {
                process.StartInfo.FileName = path;
                process.Start();
                process.WaitForInputIdle();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                //MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
