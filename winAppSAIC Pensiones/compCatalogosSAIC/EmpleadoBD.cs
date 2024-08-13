using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Security.Principal;

namespace compCatalogosSAIC
{
    public static class EmpleadoBD
    {
        /// <summary>
        /// Método para realizar la modificación del empleado que ha
        /// sido desplegado en la pantalla de Modificacion Empleado
        /// </summary>
        /// <param name="pIdEmpleado">Id Empleado</param>
        /// <param name="sConexionBD">Cadena de Conexion BD</param>
        /// <returns>Objeto Empleado</returns>
        public static Empleado ObtenerInfoEmpleadoModificacionCFDI(int pIdEmpleado, string sConexionBD)
        {
            SqlConnection Cnn = null;
            SqlCommand cmdSelect;
            SqlDataReader dr;
            Empleado objEmpleado = null;        //definir variable tipo Empleado
            try
            {
                Cnn = new SqlConnection(sConexionBD);       //crear conexion
                Cnn.Open();     //abrir conexion

                cmdSelect = new SqlCommand();
                cmdSelect.CommandType = System.Data.CommandType.StoredProcedure;
                cmdSelect.CommandText = "stpSelObtenerInfoEmpleadoModificacionCFDI";
                cmdSelect.Connection = Cnn;
                //agregar parametro para el stored procedure
                cmdSelect.Parameters.AddWithValue("@pIdEmpleado", pIdEmpleado);

                dr = cmdSelect.ExecuteReader();

                if (dr.HasRows)     //si existen registros
                {
                    objEmpleado = new Empleado();       //crear objeto
                    while (dr.Read())       //leer registros y asignar valores al objeto Empleado
                    {
                        //objEmpleado.IdEmpleado = (int)dr["IdEmpleado"];
                        objEmpleado.IdEmpleado = Convert.ToInt32(dr["IdEmpleado"]);
                        objEmpleado.APaternoEmpleado = dr["APaternoEmpleado"].ToString();
                        objEmpleado.AMaternoEmpleado = dr["AMaternoEmpleado"].ToString();
                        objEmpleado.NombreEmpleado = dr["NombreEmpleado"].ToString();
                        objEmpleado.NSS = dr["NSS"].ToString();
                        objEmpleado.RFC = dr["RFC"].ToString();
                        objEmpleado.CURP = dr["CURP"].ToString();
                        objEmpleado.FechaIngresoContrato = Convert.ToDateTime(dr["FechaIngresoContrato"]);
                        objEmpleado.SalarioDiarioContrato = (decimal)dr["SalarioDiarioContrato"];
                        objEmpleado.SalarioBaseCotizacionContrato = (decimal)dr["SalarioBaseCotizacionContrato"];
                        objEmpleado.SalarioDiarioIntegradoContrato = (decimal)dr["SalarioDiarioIntegradoContrato"];
                        objEmpleado.RazonSocialCliente = dr["RazonSocialCliente"].ToString();
                        objEmpleado.TenedoraSA = dr["TenedoraSA"].ToString();
                        objEmpleado.TenedoraSC = dr["TenedoraSC"].ToString();
                        objEmpleado.IdTipoMovimiento = dr["IdTipoMovimiento"].ToString();
                        objEmpleado.IdEstatus = (byte)dr["IdEstatus"];
                    }
                }
            }
            catch //(Exception ex)
            {
                return null;
            }
            finally
            {
                if (Cnn != null)
                {
                    if (Cnn.State == System.Data.ConnectionState.Open)
                    {
                        Cnn.Close();
                        Cnn.Dispose();
                    }
                    else
                        Cnn.Dispose();
                }
            }
            return objEmpleado;
        }       //metodo

        /// <summary>
        /// Método para realizar la modificación del empleado que ha
        /// sido desplegado en la pantalla de Modificacion Empleado
        /// </summary>
        /// <param name="dt">Objeto tipo DataTable</param>
        /// <returns>Objeto Empleado</returns>
        public static Empleado ObtenerInfoEmpleadoModificacionCFDI(DataTable dt)
        {
            Empleado objEmpleado = null;        //definir variable tipo Empleado

            try
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    objEmpleado = new Empleado();       //crear objeto
                    objEmpleado.IdEmpleado = Convert.ToInt32(row["IdEmpleado"]);
                    objEmpleado.APaternoEmpleado = row["APaternoEmpleado"].ToString();
                    objEmpleado.AMaternoEmpleado = row["AMaternoEmpleado"].ToString();
                    objEmpleado.NombreEmpleado = row["NombreEmpleado"].ToString();
                    objEmpleado.NSS = row["NSS"].ToString();
                    objEmpleado.RFC = row["RFC"].ToString();
                    objEmpleado.CURP = row["CURP"].ToString();
                    objEmpleado.FechaIngresoContrato = Convert.ToDateTime(row["FechaIngresoContrato"]);
                    objEmpleado.SalarioDiarioContrato = (decimal)row["SalarioDiarioContrato"];
                    objEmpleado.SalarioBaseCotizacionContrato = (decimal)row["SalarioBaseCotizacionContrato"];
                    objEmpleado.SalarioDiarioIntegradoContrato = (decimal)row["SalarioDiarioIntegradoContrato"];
                    objEmpleado.RazonSocialCliente = row["RazonSocialCliente"].ToString();
                    objEmpleado.TenedoraSA = row["TenedoraSA"].ToString();
                    objEmpleado.TenedoraSC = row["TenedoraSC"].ToString();
                    objEmpleado.IdTipoMovimiento = row["IdTipoMovimiento"].ToString();
                    objEmpleado.IdEstatus = (byte)row["IdEstatus"];
                    objEmpleado.IdTenedoraSA = Convert.ToInt32(row["IdTenedoraSA"]);
                    objEmpleado.IdNacionalidad = (short)row["IdNacionalidad"];
                    objEmpleado.IdEstadoCivil = (byte)row["IdEstadoCivil"];
                    objEmpleado.IdSexo = (byte)row["IdSexo"];
                    objEmpleado.PuestoCliente = row["PuestoCliente"].ToString();
                    objEmpleado.DepartamentoCliente = row["DepartamentoCliente"].ToString();
                    objEmpleado.SalarioDiarioCliente = (decimal)row["SalarioDiarioCliente"];
                    objEmpleado.FechaIngresoCliente = Convert.ToDateTime(row["FechaIngresoCliente"]);
                    objEmpleado.IdTipoPeriodoNomina = (byte)row["IdTipoPeriodoNomina"];
                    objEmpleado.FuncionesEmpleado = row["FuncionesEmpleado"].ToString();
                    objEmpleado.IdTurno = (byte)row["IdTurno"];
                    objEmpleado.DescJornada = row["DescJornada"].ToString();
                    objEmpleado.HorarioJornada = row["HorarioJornada"].ToString();
                    objEmpleado.IdJornadaServicio = Convert.ToInt32(row["IdJornadaServicio"]);
                    objEmpleado.TiempoComidaDescanso = row["TiempoComidaDescanso"].ToString();
                    objEmpleado.IdTipoContrato = (byte)row["IdTipoContrato"];
                    objEmpleado.TiempoContrato = row["TiempoContrato"].ToString();
                    objEmpleado.UMF = row["UMF"].ToString();
                    objEmpleado.AutorizacionPermanenteIMSS = row["AutorizacionPermanenteIMSS"].ToString();
                    objEmpleado.NoCreditoInfonavit = row["NoCreditoInfonavit"].ToString();
                    objEmpleado.BancoDepositoNomina = row["BancoDepositoNomina"].ToString();
                    objEmpleado.NoCuentaBanco = row["NoCuentaBanco"].ToString();
                    objEmpleado.NoReferenciaEmpleadoBanco = row["NoReferenciaEmpleadoBanco"].ToString();
                    objEmpleado.CLABE = row["CLABE"].ToString();
                    objEmpleado.Observaciones = row["Observaciones"].ToString();
                    objEmpleado.PuestoContrato = row["PuestoContrato"].ToString();
                    objEmpleado.DepartamentoContrato = row["DepartamentoContrato"].ToString();
                    objEmpleado.FechaBajaContrato = Convert.ToDateTime(row["FechaBajaContrato"]);
                    objEmpleado.IdBasePago = (byte)row["IdBasePago"];
                    objEmpleado.IdFormaPago = (byte)row["IdFormaPago"];
                    objEmpleado.IdZonaSalario = (byte)row["IdZonaSalario"];
                    objEmpleado.IdTipoEmpleado = (byte)row["IdTipoEmpleado"];
                    objEmpleado.Expediente = row["Expediente"].ToString();
                    objEmpleado.FechaNacimiento = Convert.ToDateTime(row["FechaNacimiento"]);
                    objEmpleado.LugarNacimiento = row["LugarNacimiento"].ToString();
                    objEmpleado.NoDocMigratorio = row["NoDocMigratorio"].ToString();
                    objEmpleado.Profesion = row["Profesion"].ToString();
                    objEmpleado.IdEstatusJuridico = (byte)row["IdEstatusJuridico"];
                    objEmpleado.CorreoElectronico = row["CorreoElectronico"].ToString();
                    objEmpleado.IdCliente = Convert.ToInt32(row["IdCliente"].ToString());
                    objEmpleado.IdMatrizCliente = 0;
                    objEmpleado.ConDocumentacion = Convert.ToInt32(row["ConDocumentacion"].ToString());
                    objEmpleado.VigenciaContrato = Convert.ToDateTime(row["VigenciaContrato"]);
                    objEmpleado.IdConceptoBaja = Convert.ToInt32(row["IdConceptoBaja"].ToString());

                    objEmpleado.IdTipoIdentificacion = Convert.ToInt32(row["idTipoIdentificacion"].ToString());
                    objEmpleado.TipoIdentificacion = row["TipoIdentificacion"].ToString();
                    objEmpleado.AutoridadExpide = row["AutoridadExpide"].ToString();
                    objEmpleado.NumeroIdentificacion = row["NumeroIdentificacion"].ToString();
                    objEmpleado.Vacaciones = (decimal)row["Vacaciones"];
                    objEmpleado.PrimaVacacional = (decimal)row["PrimaVacacional"];
                    objEmpleado.Aguinaldo = (decimal)row["Aguinaldo"];
                    objEmpleado.ConceptoContratacion = row["ConceptoContratacion"].ToString();
                    objEmpleado.HerramientasTrabajo = row["HerramientasTrabajo"].ToString();
                    objEmpleado.InformacionConfidencial = row["InformacionConfidencial"].ToString();
                    objEmpleado.ObservacionesBaja = row["ObservacionesBaja"].ToString();
                    objEmpleado.Edad = Convert.ToInt32(row["Edad"].ToString());
                    objEmpleado.FechaInicioContrato = Convert.ToDateTime(row["FechaInicioContrato"]);
                    objEmpleado.ContratoFirmado = Convert.ToBoolean(row["ContratoFirmado"]);

                    objEmpleado.NumSolicitudAlta = Convert.ToInt32(row["idSolicitud"].ToString());
                    objEmpleado.NumSolicitudBaja = Convert.ToInt32(row["idSolicitudBaja"].ToString());

                    objEmpleado.Nacionalidad = row["DescNacionalidad"].ToString();
                    objEmpleado.Sexo = row["DescSexo"].ToString();
                    objEmpleado.EstadoCivil = row["DescEstadoCivil"].ToString();
                    objEmpleado.IdMatrizTenedora = Convert.ToInt32(row["IdMatrizTenedora"].ToString());
                    objEmpleado.IdTenedoraSC = Convert.ToInt32(row["IdTenedoraSC"].ToString());
                    objEmpleado.CentroDeCosto = row["CentroDeCosto"].ToString();
                    objEmpleado.Sindicalizado = row["SindicalizadoSAT"].ToString();

                    objEmpleado.dcParteVariable = Convert.ToDecimal(row["SBCParteVariable"].ToString());
                    objEmpleado.idSolicitudParteVariable = Convert.ToInt32(row["idSolicitudPVariable"].ToString());
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return objEmpleado;
        }       //metodo

        public static Empleado ObtenerInfoEmpleadoModificacionCFDIvIMSS(DataTable dt)
        {
            Empleado objEmpleado = null;        //definir variable tipo Empleado

            try
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    objEmpleado = new Empleado();       //crear objeto
                    objEmpleado.IdEmpleado = Convert.ToInt32(row["IdEmpleado"]);
                    objEmpleado.APaternoEmpleado = row["APaternoEmpleado"].ToString();
                    objEmpleado.AMaternoEmpleado = row["AMaternoEmpleado"].ToString();
                    objEmpleado.NombreEmpleado = row["NombreEmpleado"].ToString();
                    objEmpleado.NSS = row["NSS"].ToString();
                    objEmpleado.RFC = row["RFC"].ToString();
                    objEmpleado.CURP = row["CURP"].ToString();
                    objEmpleado.FechaIngresoContrato = Convert.ToDateTime(row["FechaIngresoContrato"]);
                    objEmpleado.SalarioDiarioContrato = (decimal)row["SalarioDiarioContrato"];
                    objEmpleado.SalarioBaseCotizacionContrato = (decimal)row["SalarioBaseCotizacionContrato"];
                    objEmpleado.SalarioDiarioIntegradoContrato = (decimal)row["SalarioDiarioIntegradoContrato"];
                    objEmpleado.TenedoraSA = row["TenedoraSA"].ToString();
                    objEmpleado.IdEstatus = (byte)row["IdEstatus"];
                    objEmpleado.IdTenedoraSA = Convert.ToInt32(row["IdTenedoraSA"]);
                    objEmpleado.PuestoCliente = row["PuestoCliente"].ToString();
                    objEmpleado.DepartamentoCliente = row["DepartamentoCliente"].ToString();
                    objEmpleado.PuestoContrato = row["PuestoContrato"].ToString();
                    objEmpleado.DepartamentoContrato = row["DepartamentoContrato"].ToString();
                    objEmpleado.SalarioDiarioCliente = (decimal)row["SalarioDiarioCliente"];
                    objEmpleado.FechaIngresoCliente = Convert.ToDateTime(row["FechaIngresoCliente"]);
                    objEmpleado.AutorizacionPermanenteIMSS = row["AutorizacionPermanenteIMSS"].ToString();
                    objEmpleado.NoCreditoInfonavit = row["NoCreditoInfonavit"].ToString();
                    objEmpleado.Observaciones = row["Observaciones"].ToString();
                    objEmpleado.PuestoContrato = row["PuestoContrato"].ToString();
                    objEmpleado.DepartamentoContrato = row["DepartamentoContrato"].ToString();
                    objEmpleado.FechaBajaContrato = Convert.ToDateTime(row["FechaBajaContrato"]);
                    objEmpleado.IdTipoPeriodoNomina = (byte)(row["IdTipoPeriodoNomina"]);


                    objEmpleado.NoCreditoInfonavit = row["NoCreditoInfonavit"].ToString();
                    objEmpleado.EstatusINFONAVIT = Convert.ToBoolean(row["EstatusINFONAVIT"]);
                    objEmpleado.IdTipoFactorDescuento = Convert.ToInt32(row["IdTipoFactorDescuento"].ToString());
                    objEmpleado.IdParametroPagoInfonavit = Convert.ToInt32(row["IdParametroPagoInfonavit"].ToString());
                    objEmpleado.IdTipoUnidadMedidaPago = Convert.ToInt32(row["IdTipoUnidadMedidaPago"].ToString());
                    objEmpleado.FechaSalario = Convert.ToDateTime(row["FechaSalario"].ToString());
                    objEmpleado.ValorTipoPago = Convert.ToDecimal(row["ValorTipoPago"].ToString());
                    objEmpleado.FactorDescuento = Convert.ToDecimal(row["FactorDescuento"].ToString());
                    objEmpleado.MontoDescuento = Convert.ToDecimal(row["MontoDescuento"].ToString());
                    objEmpleado.MontoDescuentoDiario = Convert.ToDecimal(row["MontoDescuentoDiario"].ToString());
                    objEmpleado.MontoDescuentoPeriodo = Convert.ToDecimal(row["MontoDescuentoPeriodo"].ToString());
                    objEmpleado.FechaInicioDesc = Convert.ToDateTime(row["FechaInicioDesc"].ToString());
                    objEmpleado.FechaFinDesc = Convert.ToDateTime(row["FechaFinDesc"].ToString());
                    objEmpleado.MontoRecuperar = Convert.ToDecimal(row["MontoRecuperar"].ToString());
                    objEmpleado.MontoRecuperado = Convert.ToDecimal(row["MontoRecuperado"].ToString());
                    objEmpleado.Saldo = Convert.ToDecimal(row["Saldo"].ToString());
                    objEmpleado.RazonSocialCliente = row["RazonSocialCliente"].ToString();

                    objEmpleado.descJornadaServicio = row["DescJornadaServicio"].ToString();
                    objEmpleado.IdTipoMovimiento = row["IdTipoMovimiento"].ToString();
                    objEmpleado.dcParteVariable = Convert.ToDecimal(row["SBCParteVariable"].ToString());
                    objEmpleado.idSolicitudParteVariable = Convert.ToInt32(row["idSolicitudPVariable"].ToString());
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return objEmpleado;
        }       //metodo

        public static Empleado ObtenerInfoEmpleadoModificacionSeguro(DataTable dt)
        {
            Empleado objEmpleado = null;        //definir variable tipo Empleado

            try
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    objEmpleado = new Empleado();       //crear objeto
                    objEmpleado.IdEmpleado = Convert.ToInt32(row["IdEmpleado"]);
                    objEmpleado.APaternoEmpleado = row["APaternoEmpleado"].ToString();
                    objEmpleado.AMaternoEmpleado = row["AMaternoEmpleado"].ToString();
                    objEmpleado.NombreEmpleado = row["NombreEmpleado"].ToString();
                    objEmpleado.NSS = row["NSS"].ToString();
                    objEmpleado.RFC = row["RFC"].ToString();
                    objEmpleado.CURP = row["CURP"].ToString();
                    objEmpleado.PuestoCliente = row["PuestoCliente"].ToString();
                    objEmpleado.DepartamentoCliente = row["DepartamentoCliente"].ToString();
                    objEmpleado.FechaIngresoContrato = Convert.ToDateTime(row["FechaIngresoContrato"]);
                    objEmpleado.PuestoContrato = row["PuestoContrato"].ToString();
                    objEmpleado.DepartamentoContrato = row["DepartamentoContrato"].ToString();
                    objEmpleado.IdTenedoraSA = Convert.ToInt32(row["IdTenedoraSA"]);
                    objEmpleado.TenedoraSA = row["TenedoraSA"].ToString();
                    objEmpleado.IdEstatus = (byte)row["IdEstatus"];
                    objEmpleado.FechaBajaContrato = Convert.ToDateTime(row["FechaBajaContrato"]);

                    objEmpleado.IdCliente = (int)row["IdCliente"];
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return objEmpleado;
        }       //metodo

        public static Empleado ObtenerInfoEmpleadoModificacionDescuentos(DataTable dt)
        {
            Empleado objEmpleado = null;        //definir variable tipo Empleado

            try
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    objEmpleado = new Empleado();       //crear objeto
                    objEmpleado.IdEmpleado = Convert.ToInt32(row["IdEmpleado"]);
                    objEmpleado.APaternoEmpleado = row["APaternoEmpleado"].ToString();
                    objEmpleado.AMaternoEmpleado = row["AMaternoEmpleado"].ToString();
                    objEmpleado.NombreEmpleado = row["NombreEmpleado"].ToString();
                    objEmpleado.NSS = row["NSS"].ToString();
                    objEmpleado.RFC = row["RFC"].ToString();
                    objEmpleado.CURP = row["CURP"].ToString();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return objEmpleado;
        }

        /// <summary>
        /// Método que actualiza la información del empleado
        /// </summary>
        /// <param name="objEmp">Objeto Tipo Empleado</param>
        /// <param name="sConexionBD">String de Conexión</param>
        /// <returns></returns>

        public static bool ActualizarInfoEmpleado(Empleado objEmp, string sConexionBD)
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
                cmdUpdate.Parameters.AddWithValue("@pIdEstatusJuridico", objEmp.IdEstatusJuridico);
                cmdUpdate.Parameters.AddWithValue("@pCorreoElectronico", objEmp.CorreoElectronico);
                cmdUpdate.Parameters.AddWithValue("@pUsuarioModificacion", objEmp.UsuarioModificacion);
                cmdUpdate.Parameters.AddWithValue("@pIdMatrizCliente", objEmp.IdMatrizCliente);
                cmdUpdate.Parameters.AddWithValue("@pIdCliente", objEmp.IdCliente);
                cmdUpdate.Parameters.AddWithValue("@pIdConceptoBaja", objEmp.IdConceptoBaja);
                cmdUpdate.Parameters.AddWithValue("@pObservacionesBaja", objEmp.ObservacionesBaja);
                cmdUpdate.Parameters.AddWithValue("@pIdTenedoraSC", objEmp.IdTenedoraSC);
                cmdUpdate.Parameters.AddWithValue("@pIdOperador", OperadorBD.OperadorGlobal.IdOperador);
                cmdUpdate.Parameters.AddWithValue("@pCentroDeCosto", objEmp.CentroDeCosto);
                cmdUpdate.Parameters.AddWithValue("@pSindicalizadoSAT", objEmp.Sindicalizado);
                
                cmdUpdate.ExecuteNonQuery();    //Ejecutar Stored Procedure
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }


        public static bool ActualizarInfoEmpleadoIMSS(Empleado objEmp, string sConexionBD)
        {
            SqlConnection Cnn = null;
            SqlCommand cmdUpdate;

            try
            {
                Cnn = new SqlConnection(sConexionBD);
                Cnn.Open();

                cmdUpdate = new SqlCommand("stpUpdInfoEmpleadoModificacionDatosIMSS_v1", Cnn);
                cmdUpdate.CommandType = System.Data.CommandType.StoredProcedure;

                //parametros
                cmdUpdate.Parameters.AddWithValue("@pIdEmpleado", objEmp.IdEmpleado);
                cmdUpdate.Parameters.AddWithValue("@pAPaternoEmpleado", objEmp.APaternoEmpleado);
                cmdUpdate.Parameters.AddWithValue("@pAMaternoEmpleado", objEmp.AMaternoEmpleado);
                cmdUpdate.Parameters.AddWithValue("@pNombreEmpleado", objEmp.NombreEmpleado);
                cmdUpdate.Parameters.AddWithValue("@pRFC", objEmp.RFC);
                cmdUpdate.Parameters.AddWithValue("@pCURP", objEmp.CURP);
                cmdUpdate.Parameters.AddWithValue("@pOperador", OperadorBD.OperadorGlobal.NombreUsuario);

                cmdUpdate.Parameters.AddWithValue("@pSalarioDiarioContrato", objEmp.SalarioDiarioContrato);
                cmdUpdate.Parameters.AddWithValue("@pSalarioBaseCotizacionContrato", objEmp.SalarioBaseCotizacionContrato);
                cmdUpdate.Parameters.AddWithValue("@pSalarioDiarioIntegradoContrato", objEmp.SalarioDiarioIntegradoContrato);
                
                cmdUpdate.ExecuteNonQuery();    //Ejecutar Stored Procedure
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Método que actualiza la información del empleado del Contrato
        /// </summary>
        /// <returns></returns>
        public static bool ActualizarInfoEmpleadoContrato(Empleado objEmp, string sConexionBD)
        {
            SqlConnection Cnn = null;
            SqlCommand cmdUpdate;

            try
            {
                Cnn = new SqlConnection(sConexionBD);
                Cnn.Open();

                cmdUpdate = new SqlCommand("stpUpdContratoEmpleado", Cnn);
                cmdUpdate.CommandType = System.Data.CommandType.StoredProcedure;

                //Parametros
                cmdUpdate.Parameters.AddWithValue("@pidEmpleado", objEmp.IdEmpleado);
                cmdUpdate.Parameters.AddWithValue("@pidTipoIdentificacion", objEmp.IdTipoIdentificacion);
                cmdUpdate.Parameters.AddWithValue("@pNumeroIdentificacion", objEmp.NumeroIdentificacion);
                cmdUpdate.Parameters.AddWithValue("@pFechaInicioContrato", objEmp.FechaInicioContrato);
                cmdUpdate.Parameters.AddWithValue("@pVigenciaContrato", objEmp.VigenciaContrato);
                cmdUpdate.Parameters.AddWithValue("@pVacaciones", objEmp.Vacaciones);
                cmdUpdate.Parameters.AddWithValue("@pPrimaVacional", objEmp.PrimaVacacional);
                cmdUpdate.Parameters.AddWithValue("@pAguinaldo", objEmp.Aguinaldo);
                cmdUpdate.Parameters.AddWithValue("@pConceptoContratacion", objEmp.ConceptoContratacion);
                cmdUpdate.Parameters.AddWithValue("@pHerramientasTrabajo", objEmp.HerramientasTrabajo);
                cmdUpdate.Parameters.AddWithValue("@InformacionConfidencial", objEmp.InformacionConfidencial);
                cmdUpdate.Parameters.AddWithValue("@ContratoFirmado", objEmp.ContratoFirmado);
                cmdUpdate.Parameters.AddWithValue("@pUsuario", OperadorBD.OperadorGlobal.NombreUsuario);

                cmdUpdate.ExecuteNonQuery();    //Ejecutar Stored Procedure
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public static bool ActualizarInfoEmpleadoINFONAVIT(Empleado objEmp, string sConexionBD)
        {
            SqlConnection Cnn = null;
            SqlCommand cmdUpdate;

            try
            {
                Cnn = new SqlConnection(sConexionBD);
                Cnn.Open();

                cmdUpdate = new SqlCommand("stpUpdInfoEmpleadoModificacionCFDIINFONAVIT", Cnn);
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

                cmdUpdate.Parameters.AddWithValue("@pEstatusINFONAVIT", objEmp.EstatusINFONAVIT);
                cmdUpdate.Parameters.AddWithValue("@pNoCreditoInfonavit", objEmp.NoCreditoInfonavit);
                cmdUpdate.Parameters.AddWithValue("@pIdParametroPagoInfonavit", objEmp.IdParametroPagoInfonavit);
                cmdUpdate.Parameters.AddWithValue("@pIdTipoFactorDescuento", objEmp.IdTipoFactorDescuento);
                cmdUpdate.Parameters.AddWithValue("@pIdTipoUnidadMedidaPago", objEmp.IdTipoUnidadMedidaPago);
                cmdUpdate.Parameters.AddWithValue("@pFechaSalario", objEmp.FechaSalario);
                cmdUpdate.Parameters.AddWithValue("@pValorTipoPago", objEmp.ValorTipoPago);
                cmdUpdate.Parameters.AddWithValue("@pFactorDescuento", objEmp.FactorDescuento);
                cmdUpdate.Parameters.AddWithValue("@pMontoDescuento", objEmp.MontoDescuento);
                cmdUpdate.Parameters.AddWithValue("@pMontoDescuentoDiario", objEmp.MontoDescuentoDiario);
                cmdUpdate.Parameters.AddWithValue("@pFechaInicioDesc", objEmp.FechaInicioDesc);
                cmdUpdate.Parameters.AddWithValue("@pFechaFinDesc", objEmp.FechaFinDesc);
                cmdUpdate.Parameters.AddWithValue("@pMontoRecuperar", objEmp.MontoRecuperar);
                cmdUpdate.Parameters.AddWithValue("@pMontoRecuperado", objEmp.MontoRecuperado);
                cmdUpdate.Parameters.AddWithValue("@pSaldo", objEmp.Saldo);

                cmdUpdate.Parameters.AddWithValue("@pUsuarioModificacion", objEmp.UsuarioModificacion);

                cmdUpdate.ExecuteNonQuery();    //ejecutar stored procedure
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public static bool ActualizarInfoEmpleadoSeguro(Empleado objEmp, string sConexionBD)
        {
            SqlConnection Cnn = null;
            SqlCommand cmdUpdate;

            try
            {
                Cnn = new SqlConnection(sConexionBD);
                Cnn.Open();

                cmdUpdate = new SqlCommand("stpUpdPoliza", Cnn);
                cmdUpdate.CommandType = System.Data.CommandType.StoredProcedure;

                //parametros
                cmdUpdate.Parameters.AddWithValue("@pIdEmpleadoPoliza", objEmp.IdEmpleadoPoliza);
                cmdUpdate.Parameters.AddWithValue("@pIdEmpleado", objEmp.IdEmpleado);
                cmdUpdate.Parameters.AddWithValue("@pIdTipoPoliza", objEmp.IdPoliza);

                cmdUpdate.Parameters.AddWithValue("@pUsuarioModificacion", objEmp.UsuarioModificacion);

                cmdUpdate.ExecuteNonQuery();    //ejecutar stored procedure
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }
        public static bool CrearInfoEmpleadoSeguro(Empleado objEmp, string sConexionBD)
        {
            SqlConnection Cnn = null;
            SqlCommand cmdUpdate;

            try
            {
                Cnn = new SqlConnection(sConexionBD);
                Cnn.Open();

                cmdUpdate = new SqlCommand("stpInsPoliza", Cnn);
                cmdUpdate.CommandType = System.Data.CommandType.StoredProcedure;

                //parametros
                cmdUpdate.Parameters.AddWithValue("@pIdEmpleado", objEmp.IdEmpleado);
                cmdUpdate.Parameters.AddWithValue("@pIdTipoPoliza", objEmp.IdPoliza);
                cmdUpdate.Parameters.AddWithValue("@pFolioPoliza", objEmp.Folio_Poliza);
                cmdUpdate.Parameters.AddWithValue("@pUsuarioModificacion", objEmp.UsuarioModificacion);

                cmdUpdate.ExecuteNonQuery();    //ejecutar stored procedure
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }
        public static bool CancelarInfoEmpleadoSeguro(Empleado objEmp, string sConexionBD)
        {
            SqlConnection Cnn = null;
            SqlCommand cmdUpdate;

            try
            {
                Cnn = new SqlConnection(sConexionBD);
                Cnn.Open();

                cmdUpdate = new SqlCommand("stpCancPoliza", Cnn);
                cmdUpdate.CommandType = System.Data.CommandType.StoredProcedure;

                //parametros
                cmdUpdate.Parameters.AddWithValue("@pIdEmpleadoPoliza", objEmp.IdEmpleadoPoliza);
                cmdUpdate.Parameters.AddWithValue("@pIdEmpleado", objEmp.IdEmpleado);

                cmdUpdate.Parameters.AddWithValue("@pUsuarioModificacion", objEmp.UsuarioModificacion);

                cmdUpdate.ExecuteNonQuery();    //ejecutar stored procedure
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }
        public static bool EliminarInfoEmpleadoSeguro(Empleado objEmp, string sConexionBD)
        {
            SqlConnection Cnn = null;
            SqlCommand cmdUpdate;

            try
            {
                Cnn = new SqlConnection(sConexionBD);
                Cnn.Open();

                cmdUpdate = new SqlCommand("stpDelCatPolizaEmpleado", Cnn);
                cmdUpdate.CommandType = System.Data.CommandType.StoredProcedure;

                //parametros
                cmdUpdate.Parameters.AddWithValue("@pIdEmpleadoPoliza", objEmp.IdEmpleadoPoliza);
                cmdUpdate.Parameters.AddWithValue("@pIdEmpleado", objEmp.IdEmpleado);

                cmdUpdate.Parameters.AddWithValue("@pUsuarioModificacion", objEmp.UsuarioModificacion);

                cmdUpdate.ExecuteNonQuery();    //ejecutar stored procedure
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }


        /* Inicio Metodo Para crear Descuentos*/
        public static bool CrearInfoEmpleadoDescuentos(Empleado objEmp, string sConexionBD)
        {
            SqlConnection Cnn = null;
            SqlCommand cmdUpdate;

            try
            {
                Cnn = new SqlConnection(sConexionBD);
                Cnn.Open();

                cmdUpdate = new SqlCommand("stpInsDescuento", Cnn);
                cmdUpdate.CommandType = System.Data.CommandType.StoredProcedure;

                //parametros
                cmdUpdate.Parameters.AddWithValue("@pIdEmpleado", objEmp.IdEmpleado);
                cmdUpdate.Parameters.AddWithValue("@pIdTipoDescuento", objEmp.IdTipoDescuento);
                cmdUpdate.Parameters.AddWithValue("@pIdTipoPeriodo", objEmp.IdTipoPeriodoNomina);
                cmdUpdate.Parameters.AddWithValue("@pMonto", objEmp.MontoD);
                cmdUpdate.Parameters.AddWithValue("@pFechaInicio", objEmp.FechaInicio);
                cmdUpdate.Parameters.AddWithValue("@pFechaFin", objEmp.FechaFin);
                cmdUpdate.Parameters.AddWithValue("@pObservaciones", objEmp.ObservacionesD);
                cmdUpdate.Parameters.AddWithValue("@pIdEstatus", objEmp.IdEstatusD);
                cmdUpdate.Parameters.AddWithValue("@pUsuario", objEmp.UsuarioModificacion);

                cmdUpdate.ExecuteNonQuery();    //ejecutar stored procedure
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public static bool ModificarInfoEmpleadoDescuentos(Empleado objEmp, string sConexionBD)
        {
            SqlConnection Cnn = null;
            SqlCommand cmdUpdate;

            try
            {
                Cnn = new SqlConnection(sConexionBD);
                Cnn.Open();

                cmdUpdate = new SqlCommand("stpUpdDescuento", Cnn);
                cmdUpdate.CommandType = System.Data.CommandType.StoredProcedure;

                //parametros
                cmdUpdate.Parameters.AddWithValue("@pIdEmpleadoDescuento", objEmp.IdEmpleadoDescuento);
                cmdUpdate.Parameters.AddWithValue("@pIdEmpleado", objEmp.IdEmpleado);
                cmdUpdate.Parameters.AddWithValue("@pIdTipoDescuento", objEmp.IdTipoDescuento);
                cmdUpdate.Parameters.AddWithValue("@pIdTipoPeriodo", objEmp.IdTipoPeriodoNomina);
                cmdUpdate.Parameters.AddWithValue("@pMonto", objEmp.MontoD);
                cmdUpdate.Parameters.AddWithValue("@pFechaInicio", objEmp.FechaInicio);
                cmdUpdate.Parameters.AddWithValue("@pFechaFin", objEmp.FechaFin);
                cmdUpdate.Parameters.AddWithValue("@pObservaciones", objEmp.ObservacionesD);
                cmdUpdate.Parameters.AddWithValue("@pIdEstatus", objEmp.IdEstatusD);
                cmdUpdate.Parameters.AddWithValue("@pUsuario", objEmp.UsuarioModificacion);

                cmdUpdate.ExecuteNonQuery();    //ejecutar stored procedure
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }
        /* Fin Metodo Para crear Descuentos*/

        /// <summary>
        /// Método para realizar la consulta del empleado que ha
        /// sido desplegado en la pantalla de CFDIs por Empleado
        /// </summary>
        /// <param name="dt">Objeto tipo DataTable</param>
        /// <returns>Objeto Empleado Generico</returns>
        public static EmpleadoGenerico ObtenerInfoGenericaEmpleadoCFDI(DataTable dt)
        {
            EmpleadoGenerico objEmpleado = null;        //definir variable tipo Empleado

            try
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    objEmpleado = new EmpleadoGenerico();       //crear objeto
                    objEmpleado.IdEmpleado = Convert.ToInt32(row["IdEmpleado"]);
                    objEmpleado.APaternoEmpleado = row["APaternoEmpleado"].ToString();
                    objEmpleado.AMaternoEmpleado = row["AMaternoEmpleado"].ToString();
                    objEmpleado.NombreEmpleado = row["NombreEmpleado"].ToString();
                    objEmpleado.NombreEmpleadoCompleto = row["NombreEmpleadoCompleto"].ToString();
                    objEmpleado.NSS = row["NSS"].ToString();
                    objEmpleado.RFC = row["RFC"].ToString();
                    objEmpleado.CURP = row["CURP"].ToString();
                    //objEmpleado.RazonSocialCliente = row["RazonSocialCliente"].ToString();
                    objEmpleado.IdEstatus = (byte)row["IdEstatus"];
                    objEmpleado.DescEstatus = row["DescEstatus"].ToString();
                    objEmpleado.IdTenedoraSA = Convert.ToInt32(row["IdTenedora"]);
                    objEmpleado.TenedoraSA = row["NombreComercialTenedora"].ToString();
                    objEmpleado.IdTipoMovimiento = row["IdTipoMovimiento"].ToString();
                    objEmpleado.CorreoElectronico = row["CorreoElectronico"].ToString();
                }
            }
            catch //(Exception ex)
            {
                return null;
            }
            return objEmpleado;
        }       //metodo
        public static Empleado ObtenerInfoPolizaEmpleadoGrid(DataRow row)
        {
            Empleado objInfoDetalle = null;
            try
            {
                objInfoDetalle = new Empleado();
                objInfoDetalle.IdEmpleadoPoliza = (Int32)row["IdEmpleadoPoliza"];
                objInfoDetalle.IdTipoSeguro = (Int32)row["IdTipoSeguro"];
                objInfoDetalle.IdPoliza = (Int32)row["IdPoliza"];
                objInfoDetalle.IdEmpleado = (Int32)row["IdEmpleado"];
                objInfoDetalle.Folio_Poliza = row["Folio"].ToString();
                objInfoDetalle.IdEstatus = (byte)row["IdEstatus"];
            }
            catch (Exception ex)
            {
                return null;
            }
            return objInfoDetalle;
        }
    }
}
