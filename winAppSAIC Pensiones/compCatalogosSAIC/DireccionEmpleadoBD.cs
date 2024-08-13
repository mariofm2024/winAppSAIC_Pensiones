using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace compCatalogosSAIC
{
    public static class DireccionEmpleadoBD
    {

        /// <summary>
        /// Método para obtener las direcciones Centro Trabajo y Domicilio Particular
        /// del Empleados
        /// </summary>
        /// <param name="pIdEmpleado">Id del Empleado</param>
        /// <param name="sConexionBD">String de Conexion</param>
        /// <returns>Lista de Objetos DIreccionEmpleado</returns>
        //public static List<DireccionEmpleado> ObtenerInfoDomicilioEmpleadoModificacionCFDI(DataTable dt)
        //{
        //    List<DireccionEmpleado> objListDireccionEmpleado = new List<DireccionEmpleado>();
        //    DireccionEmpleado objDireccionEmpleado = null;        //definir variable tipo DireccionEmpleado
        //    try
        //    {
        //        if (dt.Rows.Count > 0) 
        //        {
        //            DataRow row = dt.Rows[0];

        //            objDireccionEmpleado = new DireccionEmpleado();       //crear objeto
        //            objDireccionEmpleado.IdDireccion = Convert.ToInt64(row["IdDireccion"]);
        //            objDireccionEmpleado.IdEmpleado = Convert.ToInt32(row["IdEmpleado"]);
        //            objDireccionEmpleado.Calle = row["Calle"].ToString();
        //            objDireccionEmpleado.NoExterior = row["NoExterior"].ToString();
        //            objDireccionEmpleado.NoInterior = row["NoInterior"].ToString();
        //            objDireccionEmpleado.Colonia = row["Colonia"].ToString();
        //            objDireccionEmpleado.CodigoPostal = row["CodigoPostal"].ToString();
        //            objDireccionEmpleado.NombreDelegacionMunicipio = row["NombreDelegacionMunicipio"].ToString();
        //            objDireccionEmpleado.NombrePoblacionCiudad = row["NombrePoblacionCiudad"].ToString();
        //            objDireccionEmpleado.Telefono1 = row["Telefono1"].ToString();
        //            objDireccionEmpleado.Telefono2 = row["Telefono2"].ToString();
        //            objDireccionEmpleado.IdEstado = (int)row["IdEstado"];
        //            objDireccionEmpleado.IdTipoDireccion = (byte)row["IdTipoDireccion"];
        //            objListDireccionEmpleado.Add(objDireccionEmpleado);     //agregar objeto a Lista
        //        }
        //    }
        //    catch //(Exception ex)
        //    {
        //        return null;
        //    }
        //    return objListDireccionEmpleado;
        //}       //metodo


        /// <summary>
        /// Método que actualiza la información de la Direccion del Empleado
        /// </summary>
        /// <param name="objEmp">Objeto Tipo DireccionEmpleado</param>
        /// <param name="sConexionBD">String de Conexión</param>
        /// <returns></returns>
        public static bool ActualizarInfoDireccionEmpleado(DireccionEmpleado objDireccionEmp, string sConexionBD)
        {
            SqlConnection Cnn = null;
            SqlCommand cmdUpdate;

            try
            {
                Cnn = new SqlConnection(sConexionBD);
                Cnn.Open();

                cmdUpdate = new SqlCommand("stpUpdInfoDireccionEmpleadoModificacionCFDI", Cnn);
                cmdUpdate.CommandType = System.Data.CommandType.StoredProcedure;

                //parametros
                cmdUpdate.Parameters.AddWithValue("@pIdDireccion", objDireccionEmp.IdDireccion);
                cmdUpdate.Parameters.AddWithValue("@pIdEmpleado", objDireccionEmp.IdEmpleado);
                cmdUpdate.Parameters.AddWithValue("@pCalle", objDireccionEmp.Calle);
                cmdUpdate.Parameters.AddWithValue("@pNoExterior", objDireccionEmp.NoExterior);
                cmdUpdate.Parameters.AddWithValue("@pNoInterior", objDireccionEmp.NoInterior);
                cmdUpdate.Parameters.AddWithValue("@pColonia", objDireccionEmp.Colonia);
                cmdUpdate.Parameters.AddWithValue("@pCodigoPostal", objDireccionEmp.CodigoPostal);
                cmdUpdate.Parameters.AddWithValue("@pNombreDelegacionMunicipio", objDireccionEmp.NombreDelegacionMunicipio);
                cmdUpdate.Parameters.AddWithValue("@pNombrePoblacionCiudad", objDireccionEmp.NombrePoblacionCiudad);
                cmdUpdate.Parameters.AddWithValue("@pTelefono1", objDireccionEmp.Telefono1);
                cmdUpdate.Parameters.AddWithValue("@pTelefono2", objDireccionEmp.Telefono2);
                cmdUpdate.Parameters.AddWithValue("@pIdEstado", objDireccionEmp.IdEstado);
                cmdUpdate.Parameters.AddWithValue("@pIdTipoDireccion", objDireccionEmp.IdTipoDireccion);
                cmdUpdate.Parameters.AddWithValue("@pUsuarioModificacion", objDireccionEmp.UsuarioModificacion);

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
