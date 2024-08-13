using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace compCatalogosSAIC
{
    public static class ClienteMatrizBD
    {
        /// <summary>
        /// Método para asignar al Objeto Cliente la información que se visualiza
        /// </summary>
        /// <param name="objCliente"></param>
        /// <param name="row"></param>
        public static ClienteMatriz AsignarInfoCliente(DataRow row)
        {
            ClienteMatriz objCliente = null;

            try
            {
                objCliente = new ClienteMatriz();

                //asignar valores extraidos del Combobox
                objCliente.IdCliente = Convert.ToInt32(row[0]);
                objCliente.CodigoClienteProvedor = "";
                objCliente.RazonSocial = row[1].ToString();
                objCliente.NombreComercial = row[2].ToString();
                objCliente.RFC = row[3].ToString();
                objCliente.IdActividadComercial = Convert.ToInt16(row[4]);
                //
                objCliente.Calle = row[5].ToString();
                objCliente.NoExterior = row[6].ToString();
                objCliente.NoInterior = row[7].ToString();
                objCliente.Colonia = row[8].ToString();
                objCliente.CodigoPostal = row[9].ToString();
                objCliente.IdPais = Convert.ToInt16(row[10]);
                objCliente.IdEstado = Convert.ToInt32(row[11]);
                objCliente.NombreDelegacionMunicipio = row[12].ToString();
                objCliente.NombrePoblacionCiudad = row[13].ToString();
                //
                objCliente.RepresentanteLegal = row[14].ToString();
                objCliente.Contacto = row[15].ToString();
                objCliente.Telefono1 = row[16].ToString();
                objCliente.Telefono2 = row[17].ToString();
                objCliente.CorreoElectronico = row[18].ToString();
                objCliente.PaginaWeb = row[19].ToString();      
                //
                objCliente.IdEstatus = Convert.ToByte(row[20]);
                objCliente.FechaBaja = Convert.ToDateTime(row[21]);
                objCliente.FechaModificacion = Convert.ToDateTime(row[22]);
                objCliente.UsuarioCreacion = row[23].ToString();
                objCliente.UsuarioModificacion = row[24].ToString();

            }
            catch   //(Exception ex)
            {
                //throw ex;
                return null;
            }
            return objCliente;
        }
        public static bool InsertarCliente(ClienteMatriz objCliente, string sConexionBD)
        {
            return true;
        }
    }
}
