using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace compCatalogosSAIC
{
    public static class ClienteBD
    {
        /// <summary>
        /// Método para asignar al Objeto Cliente la información que se visualiza
        /// </summary>
        /// <param name="objCliente"></param>
        /// <param name="row"></param>
        public static Cliente AsignarInfoCliente(DataRow row)
        {
            Cliente objCliente = null;

            try
            {
                objCliente = new Cliente();

                //asignar valores extraidos del Combobox
                objCliente.IdCliente = Convert.ToInt32(row[0]);
                objCliente.CodigoClienteProvedor = row[1].ToString();
                objCliente.RazonSocial = row[2].ToString();
                objCliente.NombreComercial = row[3].ToString();
                objCliente.RFC = row[4].ToString();
                objCliente.CURP = row[5].ToString();
                objCliente.IdActividadComercial = Convert.ToInt16(row[6]);
                objCliente.IdMatrizCliente = Convert.ToInt32(row[7]);
                //
                objCliente.Calle = row[8].ToString();
                objCliente.NoExterior = row[9].ToString();
                objCliente.NoInterior = row[10].ToString();
                objCliente.Colonia = row[11].ToString();
                objCliente.CodigoPostal = row[12].ToString();
                objCliente.IdPais = Convert.ToInt16(row[13]);
                objCliente.IdEstado = Convert.ToInt32(row[14]);
                objCliente.NombreDelegacionMunicipio = row[15].ToString();
                objCliente.NombrePoblacionCiudad = row[16].ToString();
                //
                objCliente.CalleOperacion = row[17].ToString();
                objCliente.NoExteriorOperacion = row[18].ToString();
                objCliente.NoInteriorOperacion = row[19].ToString();
                objCliente.ColoniaOperacion = row[20].ToString();
                objCliente.CodigoPostalOperacion = row[21].ToString();
                objCliente.IdPaisOperacion = Convert.ToInt16(row[22]);
                objCliente.IdEstadoOperacion = Convert.ToInt32(row[23]);
                objCliente.NombreDelegacionMunicipioOperacion = row[24].ToString();
                objCliente.NombrePoblacionCiudadOperacion = row[25].ToString();
                //
                objCliente.RepresentanteLegal = row[26].ToString();
                objCliente.Contacto = row[27].ToString();
                objCliente.Telefono1 = row[28].ToString();
                objCliente.Telefono2 = row[29].ToString();
                objCliente.CorreoElectronico = row[30].ToString();
                objCliente.PaginaWeb = row[31].ToString();
                objCliente.IdOperador = Convert.ToInt32(row[32]);
                //
                objCliente.IdTipoClienteProveedor = Convert.ToInt16(row[33]);
                objCliente.IdClaseRiesgo = Convert.ToInt16(row[34]);
                objCliente.ISN = Convert.ToDecimal(row[35]);
                objCliente.TieneSucursales = Convert.ToBoolean(row[36]);
                objCliente.Confidencial = Convert.ToBoolean(row[37]);
                objCliente.Seguro = Convert.ToBoolean(row[38]);
                objCliente.Decreto = Convert.ToBoolean(row[39]);
                objCliente.Sindicato = Convert.ToBoolean(row[40]);
                objCliente.PctComisionBPO = Convert.ToDecimal(row[41]);
                objCliente.PctAsimilados = Convert.ToDecimal(row[42]);
                objCliente.SaldoAFavor = Convert.ToDecimal(row[51]);
                objCliente.Financiamiento = Convert.ToDecimal(row[52]);
                //
                objCliente.FechaBaja = Convert.ToDateTime(row[43]);
                objCliente.Observaciones = row[44].ToString();
                objCliente.IdEstatus = Convert.ToByte(row[45]);
                objCliente.FechaModificacion = Convert.ToDateTime(row[46]);
                objCliente.UsuarioCreacion = row[47].ToString();
                objCliente.UsuarioModificacion = row[48].ToString();
                objCliente.idPlazaCliente = Convert.ToInt32(row[49].ToString());
                objCliente.IdRegimenFiscal = Convert.ToInt32(row[50].ToString());
                objCliente.RegimenCapital = row[53].ToString();
                objCliente.idCategoriaCliente = Convert.ToInt32(row["idCategoriaCliente"].ToString());
                objCliente.IdPestana = Convert.ToInt32(row["IdPestana"].ToString());

                //
                //objCliente.IdPestana = Convert.ToInt32(row["IdPestana"].ToString());

            }
            catch   //(Exception ex)
            {
                //throw ex;
                return null;
            }
            return objCliente;
        }



        public static bool InsertarCliente(Cliente objCliente, string sConexionBD)
        {
            return true;
        }



        public static bool ActualizarInfoCliente(Empleado objEmp, string sConexionBD)
        {
            SqlConnection Cnn = null;
            SqlCommand cmdUpdate;

            try
            {
                Cnn = new SqlConnection(sConexionBD);
                Cnn.Open();

                cmdUpdate = new SqlCommand("stpUpdInfoEmpleadoModificacionCFDI", Cnn);
                cmdUpdate.CommandType = System.Data.CommandType.StoredProcedure;

                //parametros
                cmdUpdate.Parameters.AddWithValue("@pIdEmpleado", objEmp.IdEmpleado);
                cmdUpdate.Parameters.AddWithValue("@pAPaternoEmpleado", objEmp.APaternoEmpleado);
                cmdUpdate.Parameters.AddWithValue("@pAMaternoEmpleado", objEmp.AMaternoEmpleado);
                cmdUpdate.Parameters.AddWithValue("@pNombreEmpleado", objEmp.NombreEmpleado);
                cmdUpdate.Parameters.AddWithValue("@pNSS", objEmp.NSS);
                cmdUpdate.Parameters.AddWithValue("@pRFC", objEmp.RFC);
                cmdUpdate.Parameters.AddWithValue("@pCURP", objEmp.CURP);
                cmdUpdate.Parameters.AddWithValue("@pSalarioDiarioContrato", objEmp.SalarioDiarioContrato);
                cmdUpdate.Parameters.AddWithValue("@pSalarioBaseCotizacionContrato", objEmp.SalarioBaseCotizacionContrato);
                cmdUpdate.Parameters.AddWithValue("@pSalarioDiarioIntegradoContrato", objEmp.SalarioDiarioIntegradoContrato);
                cmdUpdate.Parameters.AddWithValue("@pFechaIngresoContrato", objEmp.FechaIngresoContrato);
                cmdUpdate.Parameters.AddWithValue("@pFechaBajaContrato", objEmp.FechaBajaContrato);
                cmdUpdate.Parameters.AddWithValue("@pIdZonaSalario", objEmp.IdZonaSalario);
                cmdUpdate.Parameters.AddWithValue("@pIdTipoPeriodoNomina", objEmp.IdTipoPeriodoNomina);
                cmdUpdate.Parameters.AddWithValue("@pIdTipoEmpleado", objEmp.IdTipoEmpleado);
                cmdUpdate.Parameters.AddWithValue("@pDepartamentoContrato", objEmp.DepartamentoContrato);
                cmdUpdate.Parameters.AddWithValue("@pPuestoContrato", objEmp.PuestoContrato);
                cmdUpdate.Parameters.AddWithValue("@pExpediente", objEmp.Expediente);
                cmdUpdate.Parameters.AddWithValue("@pRazonSocialCliente", objEmp.RazonSocialCliente);
                cmdUpdate.Parameters.AddWithValue("@pIdTenedoraSA", objEmp.IdTenedoraSA);
                cmdUpdate.Parameters.AddWithValue("@pTenedoraSA", objEmp.TenedoraSA);
                cmdUpdate.Parameters.AddWithValue("@pTenedoraSC", objEmp.TenedoraSC);
                cmdUpdate.Parameters.AddWithValue("@pIdTipoMovimiento", objEmp.IdTipoMovimiento);
                cmdUpdate.Parameters.AddWithValue("@pIdEstatus", objEmp.IdEstatus);
                cmdUpdate.Parameters.AddWithValue("@pUMF", objEmp.UMF);
                cmdUpdate.Parameters.AddWithValue("@pAutorizacionPermanenteIMSS", objEmp.AutorizacionPermanenteIMSS);
                cmdUpdate.Parameters.AddWithValue("@pNoCreditoInfonavit", objEmp.NoCreditoInfonavit);
                cmdUpdate.Parameters.AddWithValue("@pFechaNacimiento", objEmp.FechaNacimiento);
                cmdUpdate.Parameters.AddWithValue("@pNoDocMigratorio", objEmp.NoDocMigratorio);
                cmdUpdate.Parameters.AddWithValue("@pIdSexo", objEmp.IdSexo);
                cmdUpdate.Parameters.AddWithValue("@pIdEstadoCivil", objEmp.IdEstadoCivil);
                cmdUpdate.Parameters.AddWithValue("@pIdNacionalidad", objEmp.IdNacionalidad);
                cmdUpdate.Parameters.AddWithValue("@pSalarioDiarioCliente", objEmp.SalarioDiarioCliente);
                cmdUpdate.Parameters.AddWithValue("@pFechaIngresoCliente", objEmp.FechaIngresoCliente);
                cmdUpdate.Parameters.AddWithValue("@pIdTurno", objEmp.IdTurno);
                cmdUpdate.Parameters.AddWithValue("@pIdTipoContrato", objEmp.IdTipoContrato);
                cmdUpdate.Parameters.AddWithValue("@pTiempoContrato", objEmp.TiempoContrato);
                cmdUpdate.Parameters.AddWithValue("@pLugarNacimiento", objEmp.LugarNacimiento);
                cmdUpdate.Parameters.AddWithValue("@pProfesion", objEmp.Profesion);
                cmdUpdate.Parameters.AddWithValue("@pDepartamentoCliente", objEmp.DepartamentoCliente);
                cmdUpdate.Parameters.AddWithValue("@pPuestoCliente", objEmp.PuestoCliente);
                cmdUpdate.Parameters.AddWithValue("@pDescJornada", objEmp.DescJornada);
                cmdUpdate.Parameters.AddWithValue("@pHorarioJornada", objEmp.HorarioJornada);
                cmdUpdate.Parameters.AddWithValue("@pTiempoComidaDescanso", objEmp.TiempoComidaDescanso);
                cmdUpdate.Parameters.AddWithValue("@pFuncionesEmpleado", objEmp.FuncionesEmpleado);
                cmdUpdate.Parameters.AddWithValue("@pBancoDepositoNomina", objEmp.BancoDepositoNomina);
                cmdUpdate.Parameters.AddWithValue("@pNoCuentaBanco", objEmp.NoCuentaBanco);
                cmdUpdate.Parameters.AddWithValue("@pCLABE", objEmp.CLABE);
                cmdUpdate.Parameters.AddWithValue("@pNoReferenciaEmpleadoBanco", objEmp.NoReferenciaEmpleadoBanco);
                cmdUpdate.Parameters.AddWithValue("@pIdFormaPago", objEmp.IdFormaPago);
                cmdUpdate.Parameters.AddWithValue("@pObservaciones", objEmp.Observaciones);
                cmdUpdate.Parameters.AddWithValue("@pIdBasePago", objEmp.IdBasePago);
                cmdUpdate.Parameters.AddWithValue("@pIdJornadaServicio", objEmp.IdJornadaServicio);
                cmdUpdate.Parameters.AddWithValue("@pUsuarioModificacion", objEmp.UsuarioModificacion);

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
