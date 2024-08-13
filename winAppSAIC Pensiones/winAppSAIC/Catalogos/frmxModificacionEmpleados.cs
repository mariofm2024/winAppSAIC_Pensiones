using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using compCatalogosSAIC;
using winAppSAIC.UtileriasLocal;
using System.IO;
using System.Diagnostics;
using compSysAccesos;
using DevExpress.XtraReports.UI;
using winAppSAIC.OperadoresM;

namespace winAppSAIC.Catalogos
{
    public partial class frmxModificacionEmpleados : DevExpress.XtraEditors.XtraForm
    {
        int iIdEmpleado;
        int idSolicitud;
        Boolean banAltaEmpleados;

        Boolean Imss;
        Boolean Juridico;
        Boolean Tesoreria;

        Boolean flageHabilitarEsquema;
        Boolean flageHabilitarEstatusEmpleado;
        Boolean flageHabilitarCausabaja;
        Boolean flageHabilitarTenedoras;
        Boolean flageHabilitarCliente;

        Boolean flageHabilitarSalarios;

        byte bIdFormaPago;
        tools.dsc dsc = new tools.dsc();
        String stRutaEmpleados = String.Empty;

        Empleado objEmp;
        DateTime dtFechaServidor = new DateTime();
        Boolean flagConFiltro;
        ErrorProvider erroProviderSalarios = new ErrorProvider();
        ErrorProvider AvisoDe25UMAS = new ErrorProvider();

        public frmxModificacionEmpleados(int iIdEmpleado, Boolean flagConFiltro, Boolean banAltaEmpleados, Boolean Imss, Boolean Juridico, Boolean Tesoreria, int idSolicitud)
        {
            InitializeComponent();
            this.iIdEmpleado = iIdEmpleado;
            this.banAltaEmpleados = banAltaEmpleados;
            this.Imss = Imss;
            this.Juridico = Juridico;
            this.Tesoreria = Tesoreria;
            this.idSolicitud = idSolicitud;
            this.flagConFiltro = flagConFiltro;
        }

        private void iniComponentes(int iIdEmpleado, Boolean banAltaEmpleados)
        {
            if (banAltaEmpleados)
            {
                cboIdEmpleado.Text = iIdEmpleado.ToString();
                cboIdEmpleado.EditValue = iIdEmpleado;
                txtNoEmpleado.Text = iIdEmpleado.ToString();
                mostarInformacionEmpleado();
            }
            else
            {
                if (flagConFiltro && iIdEmpleado > 0)
                {
                    cboIdEmpleado.Text = iIdEmpleado.ToString();
                    cboIdEmpleado.EditValue = iIdEmpleado;
                    txtNoEmpleado.Text = iIdEmpleado.ToString();
                    mostarInformacionEmpleado();
                    //cboIdEmpleado.Enabled = true;
                    banAltaEmpleados = true;
                }
            }

            cboIdEmpleado.Enabled = !banAltaEmpleados;
        }

        #region "Propiedades"

        /// <summary>
        /// Propiedad para indicar el tipo de operación (MODIFICACION, ASIGNACION NSS-BAJA/REINGRESO)
        /// </summary>
        public Constantes.TipoOperacion tipoOperacion { get; set; }

        /// <summary>
        /// Propiedad para indicar el tipo de Perfil de Acceso para el Usuario
        /// </summary>
        public Constantes.TipoPerfil tipoPerfil { get; set; }

        #endregion

        #region "Variables Globales"

        private string strIdMovimientoOriginal = "";
        private string strNSSOriginal;
        String strRFCOriginal;
        String strCURPOriginal;
        private byte byEstatusOriginal = 0;
        DataTable dtTipoIdentificacion = new DataTable();

        #endregion

        #region "Metodos Propios"

        /// <summary>
        /// Método para limpiar el contenido de los Controles
        /// </summary>
        private void LimpiarControles()
        {
            txtNoEmpleado.Text = String.Empty;
            txtAPaternoEmpleado.Text = String.Empty;
            txtAMaternoEmpleado.Text = String.Empty;
            txtNombreEmpleado.Text = String.Empty;
            txtNSS.Text = String.Empty;
            txtRFC.Text = String.Empty;
            txtCURP.Text = String.Empty;
            txtSalarioDiarioContrato.Text = String.Empty;
            txtSalarioBaseCotizacionContrato.Text = String.Empty;
            txtSalarioDiarioIntegradoContrato.Text = String.Empty;
            calFechaIngresoReingresoContrato.EditValue = DateTime.Today;
            deteInicioContrato.EditValue = DateTime.Today;
            calFechaBajaContrato.EditValue = DateTime.Today;
            calFechaReingresoContrato.EditValue = DateTime.Today;
            cboIdZonaSalario.EditValue = -1;
            cboIdTipoPeriodoNomina.EditValue = -1;
            cboIdTipoEmpleado.EditValue = -1;

            txtPuestoContrato.Text = String.Empty;
            txtDepartamentoContrato.Text = String.Empty;
            txtExpediente.Text = String.Empty;

            cboIdTenedoraSA.EditValue = -1;
            txtTenedoraSA.Text = String.Empty;
            txtTenedoraSC.Text = String.Empty;
            cboIdTipoMovimiento.EditValue = -1;        //ESQUEMA
            cboIdEstatus.EditValue = -1;

            calFechaNacimiento.EditValue = new DateTime(1900, 1, 1);
            txtNoDocMigratorio.Text = String.Empty;
            cboIdSexo.EditValue = -1;
            txtSalarioDiarioCliente.Text = "0.00";
            calFechaIngresoCliente.EditValue = DateTime.Today;
            cboIdTurno.EditValue = -1;
            cboIdTipoContrato.EditValue = -1;
            txtTiempoContrato.Text = String.Empty;
            txtUMF.Text = String.Empty;
            txtLugarNacimiento.Text = String.Empty;
            txtProfesion.Text = String.Empty;
            cboIdEstadoCivil.EditValue = -1;
            cboIdNacionalidad.EditValue = -1;
            txtDepartamentoCliente.Text = String.Empty;
            txtPuestoCliente.Text = String.Empty;
            txtDescJornada.Text = String.Empty;
            txtHorarioJornada.Text = String.Empty;
            txtTiempoComidaDescanso.Text = String.Empty;
            txtFuncionesEmpleado.Text = String.Empty;
            cboAutorizacionPermanenteIMSS.EditValue = "NO";
            txtNoCreditoInfonavit.Text = String.Empty;

            txtBancoDepositoNomina.Text = String.Empty;
            txtNoCuentaBanco.Text = String.Empty;
            txtNoReferenciaEmpleadoBanco.Text = String.Empty;
            txtCLABE.Text = String.Empty;
            cboIdFormaPago.EditValue = -1;
            txtObservaciones.Text = String.Empty;
            txtIdEstatusJuridico.Text = "0";
            txtCorreoElectronico.Text = String.Empty;
            lookupMotivoBaja.EditValue = 0;
            cboIdJornadaServicio.EditValue = -1;
            txtCodigoPostalFiscal.Text = String.Empty;
            txtEstadoFiscal.Text = String.Empty;
        }

        /// <summary>
        /// Método para limpiar el contenido de los Controles de Direccion de Empleados
        /// </summary>
        private void LimpiarControlesDireccion()
        {
            //inicializar Direcciones Empleados
            txtCalleCT.Text = String.Empty;
            txtNoExteriorCT.Text = String.Empty;
            txtNoInteriorCT.Text = String.Empty;
            txtColoniaCT.Text = String.Empty;
            txtCodigoPostalCT.Text = String.Empty;
            txtDelegacionMunicipioCT.Text = String.Empty;
            txtPoblacionCiudadCT.Text = String.Empty;
            txtTelefono1CT.Text = String.Empty;
            txtTelefono2CT.Text = String.Empty;
            cboIdEstadoCT.EditValue = -1;

            txtCalleDP.Text = String.Empty;
            txtNoExteriorDP.Text = String.Empty;
            txtNoInteriorDP.Text = String.Empty;
            txtColoniaDP.Text = String.Empty;
            txtCodigoPostalDP.Text = String.Empty;
            txtDelegacionMunicipioDP.Text = String.Empty;
            txtPoblacionCiudadDP.Text = String.Empty;
            txtTelefono1DP.Text = String.Empty;
            txtTelefono2DP.Text = String.Empty;
            cboIdEstadoDP.EditValue = -1;

            //inicializar propiedades TAG de los GroupControl de Domicilios
            gpcDomicilioCT.Tag = 0;
            gpcDomicilioPE.Tag = 0;
            gpcDomicilioFiscal.Tag = 0;
        }
        /// <summary>
        /// Método para activar o desactivar controles al momento de Editar/Cancelar/Guardar
        /// </summary>
        /// <param name="bFlag"></param>
        /// <param name="pTipoPerfil"></param>
        /// <param name="bloquearTodos">para bloquear todos los botones(Guardar Datos)</param>
        private void ActivarControles(bool bFlag, Constantes.TipoPerfil pTipoPerfil)
        {
            txtAPaternoEmpleado.Enabled = bFlag;
            txtAMaternoEmpleado.Enabled = bFlag;
            txtNombreEmpleado.Enabled = bFlag;
            txtRFC.Enabled = bFlag;
            txtCURP.Enabled = bFlag;

            if (pTipoPerfil == Constantes.TipoPerfil.Juridico)
            {
                txtNSS.Properties.ReadOnly = false;
                txtNSS.Enabled = bFlag;
                txtNSS.TabStop = bFlag;
            }
            else
            {
                txtNSS.Properties.ReadOnly = true;
                txtNSS.TabStop = false;
            }

            DerechosAcceso objDAcceso = new DerechosAcceso();

            //DerechosAcceso objDAcceso

            cboIdTipoMovimiento.Enabled = flageHabilitarEsquema;
            cboIdEstatus.Enabled = flageHabilitarEstatusEmpleado;
            calFechaBajaContrato.Enabled = flageHabilitarCausabaja;

            dateFechaParaElCalculoSD.Enabled = bFlag;
            txtSalarioDiarioContrato.Enabled = flageHabilitarSalarios;
            txtSalarioBaseCotizacionContrato.Enabled = flageHabilitarSalarios;
            txtSalarioDiarioIntegradoContrato.Enabled = flageHabilitarSalarios;

            calFechaIngresoReingresoContrato.Enabled = bFlag;
            deteInicioContrato.Enabled = bFlag;
            cboIdZonaSalario.Enabled = bFlag;
            cboIdTipoPeriodoNomina.Enabled = bFlag;
            cboIdTipoEmpleado.Enabled = bFlag;
            txtDepartamentoContrato.Enabled = bFlag;
            txtPuestoContrato.Enabled = bFlag;

            txtExpediente.Enabled = bFlag;
            btnAsignarNumeroDeExpediente.Enabled = bFlag;
            upEditHistoricoExpedientes.Enabled = bFlag;

            cboIdCliente.Enabled = flageHabilitarCliente;
            cboIdTenedoraSA.Enabled = flageHabilitarTenedoras;
            txtTenedoraSA.Enabled = flageHabilitarTenedoras;
            txtTenedoraSC.Enabled = flageHabilitarTenedoras;

            txtUMF.Enabled = bFlag;
            cboAutorizacionPermanenteIMSS.Enabled = bFlag;
            txtNoCreditoInfonavit.Enabled = bFlag;

            calFechaNacimiento.Enabled = bFlag;
            txtNoDocMigratorio.Enabled = bFlag;
            cboIdSexo.Enabled = bFlag;
            cboIdEstadoCivil.Enabled = bFlag;
            cboIdNacionalidad.Enabled = bFlag;
            txtSalarioDiarioCliente.Enabled = bFlag;
            calFechaIngresoCliente.Enabled = bFlag;
            cboIdTurno.Enabled = bFlag;
            cboIdTipoContrato.Enabled = bFlag;
            txtTiempoContrato.Enabled = bFlag;
            txtLugarNacimiento.Enabled = bFlag;
            txtProfesion.Enabled = bFlag;
            txtDepartamentoCliente.Enabled = bFlag;
            txtPuestoCliente.Enabled = bFlag;
            txtDescJornada.Enabled = bFlag;
            txtHorarioJornada.Enabled = bFlag;
            txtTiempoComidaDescanso.Enabled = bFlag;
            txtFuncionesEmpleado.Enabled = bFlag;

            txtBancoDepositoNomina.Enabled = false;
            txtNoCuentaBanco.Enabled = false;
            txtCLABE.Enabled = false;
            txtNoReferenciaEmpleadoBanco.Enabled = false;
            cboIdFormaPago.Enabled = false;

            txtObservaciones.Enabled = bFlag;
            txtIdEstatusJuridico.Enabled = bFlag;
            txtCorreoElectronico.Enabled = bFlag;
            //lookupMotivoBaja.Enabled = bFlag;

            //Domicilios
            ActivarControlesDireccion(bFlag);
            ActivarControlesContrato(bFlag);

            cboIdJornadaServicio.Enabled = bFlag;

            mmObservacionesBaja.Enabled = bFlag;
            dteditVigenciaContrato.Enabled = bFlag;


            txtCentroDeCosto1.Enabled = bFlag;
            txtCodigoPostalFiscal.Enabled = bFlag;
            txtEstadoFiscal.Enabled = bFlag;
            checkEditSindicalizado.Enabled = bFlag;

        }

        /// <summary>
        /// Metodo para activar controles por solicitud y por area.
        /// </summary>
        private void ActivarControlesAltaEmpledos()
        {
            if (Imss)
            {
                txtNSS.Properties.ReadOnly = !Imss;
                txtNSS.Enabled = Imss;
                txtNSS.TabStop = Imss;

                dateFechaParaElCalculoSD.Enabled = Imss;
                txtSalarioDiarioContrato.Enabled = Imss;
                txtSalarioBaseCotizacionContrato.Enabled = Imss;
                txtSalarioDiarioIntegradoContrato.Enabled = Imss;
                txtNoCreditoInfonavit.Enabled = Imss;
                txtFuncionesEmpleado.Enabled = Imss;

                //cboIdTipoMovimiento.Enabled = Imss;
                cboIdTipoMovimiento.Enabled = flageHabilitarEsquema;
                txtNombreEmpleado.Enabled = Imss;
                txtAPaternoEmpleado.Enabled = Imss;
                txtAMaternoEmpleado.Enabled = Imss;
            }
            if (Tesoreria)
            {
                txtBancoDepositoNomina.Enabled = Tesoreria;
                txtNoCuentaBanco.Enabled = Tesoreria;
                txtCLABE.Enabled = Tesoreria;
                txtNoReferenciaEmpleadoBanco.Enabled = Tesoreria;
                cboIdFormaPago.Enabled = Tesoreria;
                txtTelefono1DP.Enabled = Tesoreria;
                cboIdTipoMovimiento.Enabled = flageHabilitarEsquema;
                //cboIdTipoMovimiento.Enabled = Tesoreria;

            }
            if (Juridico)
            {
                txtCodigoPostalCT.Enabled = Juridico;
                txtCodigoPostalDP.Enabled = Juridico;
                txtNombreEmpleado.Enabled = Juridico;
                txtAPaternoEmpleado.Enabled = Juridico;
                txtAMaternoEmpleado.Enabled = Juridico;
                txtRFC.Enabled = Juridico;
                txtCURP.Enabled = Juridico;
                calFechaIngresoReingresoContrato.Enabled = Juridico;
                deteInicioContrato.Enabled = Juridico;
                cboIdZonaSalario.Enabled = Juridico;
                cboIdTipoPeriodoNomina.Enabled = Juridico;
                cboIdTipoEmpleado.Enabled = Juridico;
                txtDepartamentoContrato.Enabled = Juridico;
                txtPuestoContrato.Enabled = Juridico;
                calFechaNacimiento.Enabled = Juridico;
                txtNoDocMigratorio.Enabled = Juridico;
                cboIdSexo.Enabled = Juridico;
                cboIdNacionalidad.Enabled = Juridico;
                txtSalarioDiarioCliente.Enabled = Juridico;
                calFechaIngresoCliente.Enabled = Juridico;
                cboIdTurno.Enabled = Juridico;
                cboIdTipoContrato.Enabled = Juridico;
                txtFuncionesEmpleado.Enabled = Juridico;
                txtTiempoContrato.Enabled = Juridico;
                txtLugarNacimiento.Enabled = Juridico;
                txtProfesion.Enabled = Juridico;
                txtDepartamentoCliente.Enabled = Juridico;
                txtPuestoCliente.Enabled = Juridico;
                txtDescJornada.Enabled = Juridico;
                txtHorarioJornada.Enabled = Juridico;
                txtTiempoComidaDescanso.Enabled = Juridico;
                txtObservaciones.Enabled = Juridico;
                txtCorreoElectronico.Enabled = Juridico;
                txtCalleCT.Enabled = Juridico;
                txtNoExteriorCT.Enabled = Juridico;
                txtNoInteriorCT.Enabled = Juridico;
                txtColoniaCT.Enabled = Juridico;
                txtDelegacionMunicipioCT.Enabled = Juridico;
                txtPoblacionCiudadCT.Enabled = Juridico;
                cboIdEstadoCT.Enabled = Juridico;
                txtTelefono1CT.Enabled = Juridico;
                txtTelefono2CT.Enabled = Juridico;
                txtCalleDP.Enabled = Juridico;
                txtNoExteriorDP.Enabled = Juridico;
                txtNoInteriorDP.Enabled = Juridico;
                txtColoniaDP.Enabled = Juridico;
                txtDelegacionMunicipioDP.Enabled = Juridico;
                txtPoblacionCiudadDP.Enabled = Juridico;
                cboIdEstadoDP.Enabled = Juridico;
                txtTelefono1DP.Enabled = Juridico;
                txtTelefono2DP.Enabled = Juridico;
                lueTipoIdentificacion.Enabled = Juridico;
                txtEditNumeroIdentificacion.Enabled = Juridico;
                txtEditEdad.Enabled = Juridico;
                seVacaciones.Enabled = Juridico;
                sePrimaVacacional.Enabled = Juridico;
                seAguinaldo.Enabled = Juridico;
                mmContratacion.Enabled = Juridico;
                mmHerramientas.Enabled = Juridico;
                mmConfidencial.Enabled = Juridico;

                //calFechaBajaContrato.Enabled = Juridico;
                calFechaBajaContrato.Enabled = flageHabilitarCausabaja;

                //cboIdTipoMovimiento.Enabled = Juridico;
                cboIdTipoMovimiento.Enabled = flageHabilitarEsquema;

                cboIdEstatus.Enabled = flageHabilitarEstatusEmpleado;
                cboIdJornadaServicio.Enabled = Juridico;
                checkEditSindicalizado.Enabled = Juridico;
                txtCodigoPostalFiscal.Enabled = Juridico;
                dateFechaParaElCalculoSD.Enabled = Juridico;
            }
        }

        /// <summary>
        /// Método para Habilitar o Deshabilitar Controles de Direccion
        /// </summary>
        /// <param name="bFlag">Valor TRUE o FALSE</param>
        private void ActivarControlesDireccion(bool bFlag)
        {
            txtCalleCT.Enabled = bFlag;
            txtNoExteriorCT.Enabled = bFlag;
            txtNoInteriorCT.Enabled = bFlag;
            txtColoniaCT.Enabled = bFlag;
            txtCodigoPostalCT.Enabled = bFlag;
            txtDelegacionMunicipioCT.Enabled = bFlag;
            txtPoblacionCiudadCT.Enabled = bFlag;
            cboIdEstadoCT.Enabled = bFlag;
            txtTelefono1CT.Enabled = bFlag;
            txtTelefono2CT.Enabled = bFlag;

            txtCalleDP.Enabled = bFlag;
            txtNoExteriorDP.Enabled = bFlag;
            txtNoInteriorDP.Enabled = bFlag;
            txtColoniaDP.Enabled = bFlag;
            txtCodigoPostalDP.Enabled = bFlag;
            txtDelegacionMunicipioDP.Enabled = bFlag;
            txtPoblacionCiudadDP.Enabled = bFlag;
            cboIdEstadoDP.Enabled = bFlag;
            txtTelefono1DP.Enabled = bFlag;
            txtTelefono2DP.Enabled = bFlag;
        }

        /// <summary>
        ///  Método para Habilitar o Deshabilitar Controles del Contrato
        /// </summary>
        /// <param name="bFlag">Valor TRUE o FALSE</param>
        private void ActivarControlesContrato(bool bFlag)
        {
            lueTipoIdentificacion.Enabled = bFlag;
            txtEditNumeroIdentificacion.Enabled = bFlag;
            txtEditIdPlan.Enabled = bFlag;
            seVacaciones.Enabled = bFlag;
            sePrimaVacacional.Enabled = bFlag;
            seAguinaldo.Enabled = bFlag;
            mmContratacion.Enabled = bFlag;
            mmHerramientas.Enabled = bFlag;
            mmConfidencial.Enabled = bFlag;
            txtEditEdad.Enabled = bFlag;
            dteditVigenciaContrato.Enabled = bFlag;
        }

        /// <summary>
        /// Método para obtener los valores de los controles
        /// y asignarlos al objeto Empleado
        /// </summary>
        /// <returns>Objeto Empleado</returns>
        private Empleado AsignarInfoEmpleado()
        {
            Empleado objEmp = new Empleado();
            int idCliente = 0;

            objEmp.IdEmpleado = Convert.ToInt32(txtNoEmpleado.Text);

            objEmp.APaternoEmpleado = txtAPaternoEmpleado.Text.Trim();
            objEmp.AMaternoEmpleado = txtAMaternoEmpleado.Text.Trim();
            objEmp.NombreEmpleado = txtNombreEmpleado.Text.Trim();

            if (banAltaEmpleados && Imss)
            {
                objEmp.APaternoEmpleado = stEmpleadoAPaterno;
                objEmp.AMaternoEmpleado = stEmpleadoAMaterno;
                objEmp.NombreEmpleado = stEmpleadoNombre;
            }

            if (banAltaEmpleados && Juridico)
            {
                objEmp.APaternoEmpleado = txtAPaternoEmpleado.Text.Trim();
                objEmp.AMaternoEmpleado = txtAMaternoEmpleado.Text.Trim();
                objEmp.NombreEmpleado = txtNombreEmpleado.Text.Trim();
            }


            objEmp.NSS = txtNSS.Text.Trim();
            objEmp.RFC = txtRFC.Text.Trim();
            objEmp.CURP = txtCURP.Text.Trim();
            objEmp.SalarioDiarioContrato = Convert.ToDecimal(txtSalarioDiarioContrato.Text);
            objEmp.SalarioBaseCotizacionContrato = Convert.ToDecimal(txtSalarioBaseCotizacionContrato.Text);
            objEmp.SalarioDiarioIntegradoContrato = Convert.ToDecimal(txtSalarioDiarioIntegradoContrato.Text);
            objEmp.FechaIngresoContrato = Convert.ToDateTime(calFechaIngresoReingresoContrato.EditValue);
            objEmp.FechaInicioContrato = Convert.ToDateTime(deteInicioContrato.EditValue);
            objEmp.FechaBajaContrato = Convert.ToDateTime(calFechaBajaContrato.EditValue);
            objEmp.IdZonaSalario = Convert.ToByte(cboIdZonaSalario.EditValue);
            objEmp.IdTipoPeriodoNomina = (byte)cboIdTipoPeriodoNomina.EditValue;
            objEmp.IdTipoEmpleado = (byte)cboIdTipoEmpleado.EditValue;
            objEmp.DepartamentoContrato = txtDepartamentoContrato.Text.Trim();
            objEmp.PuestoContrato = txtPuestoContrato.Text.Trim();

            objEmp.Expediente = txtExpediente.Text.Trim();

            //objEmp.RazonSocialCliente = txtRazonSocialCliente.Text.Trim();
            objEmp.RazonSocialCliente = cboIdCliente.Text;
            int.TryParse(cboIdCliente.EditValue.ToString(), out idCliente);
            objEmp.IdCliente = idCliente;

            objEmp.IdTenedoraSA = Convert.ToInt32(cboIdTenedoraSA.EditValue);
            objEmp.TenedoraSA = cboIdTenedoraSA.Text.Trim();
            objEmp.TenedoraSC = txtTenedoraSC.Text.Trim();
            objEmp.IdTipoMovimiento = cboIdTipoMovimiento.EditValue.ToString();
            objEmp.IdEstatus = Convert.ToByte(cboIdEstatus.EditValue);

            objEmp.FechaNacimiento = Convert.ToDateTime(calFechaNacimiento.EditValue);
            objEmp.NoDocMigratorio = txtNoDocMigratorio.Text.Trim();
            objEmp.IdSexo = (byte)cboIdSexo.EditValue;
            objEmp.SalarioDiarioCliente = Convert.ToDecimal(txtSalarioDiarioCliente.Text);
            objEmp.FechaIngresoCliente = Convert.ToDateTime(calFechaIngresoCliente.EditValue);
            objEmp.IdTurno = (byte)cboIdTurno.EditValue;
            objEmp.IdTipoContrato = (byte)cboIdTipoContrato.EditValue;
            objEmp.TiempoContrato = txtTiempoContrato.Text.Trim();
            objEmp.LugarNacimiento = txtLugarNacimiento.Text.Trim();
            objEmp.Profesion = txtProfesion.Text.Trim();
            objEmp.IdEstadoCivil = (byte)cboIdEstadoCivil.EditValue;
            objEmp.IdNacionalidad = (short)cboIdNacionalidad.EditValue;
            objEmp.DepartamentoCliente = txtDepartamentoCliente.Text.Trim();
            objEmp.PuestoCliente = txtPuestoCliente.Text.Trim();
            objEmp.DescJornada = txtDescJornada.Text.Trim();
            objEmp.HorarioJornada = txtHorarioJornada.Text.Trim();
            objEmp.TiempoComidaDescanso = txtTiempoComidaDescanso.Text.Trim();
            objEmp.FuncionesEmpleado = txtFuncionesEmpleado.Text.Trim();

            objEmp.UMF = txtUMF.Text.Trim();
            objEmp.AutorizacionPermanenteIMSS = cboAutorizacionPermanenteIMSS.Text;
            objEmp.NoCreditoInfonavit = txtNoCreditoInfonavit.Text.Trim();

            objEmp.BancoDepositoNomina = txtBancoDepositoNomina.Text.Trim();
            objEmp.NoCuentaBanco = txtNoCuentaBanco.Text.Trim();
            objEmp.NoReferenciaEmpleadoBanco = txtNoReferenciaEmpleadoBanco.Text.Trim();
            objEmp.CLABE = txtCLABE.Text.Trim();
            objEmp.IdFormaPago = (byte)cboIdFormaPago.EditValue;
            objEmp.Observaciones = txtObservaciones.Text.Trim();
            objEmp.IdBasePago = 1;      //SUELDO
            objEmp.IdJornadaServicio = Convert.ToInt32(cboIdJornadaServicio.EditValue);
            objEmp.IdEstatusJuridico = Convert.ToByte(txtIdEstatusJuridico.Text);
            objEmp.CorreoElectronico = txtCorreoElectronico.Text.Trim();
            objEmp.UsuarioCreacion = OperadorBD.OperadorGlobal.NombreUsuario;
            objEmp.UsuarioModificacion = OperadorBD.OperadorGlobal.NombreUsuario;
            objEmp.IdConceptoBaja = Convert.ToInt32(lookupMotivoBaja.EditValue);
            objEmp.ObservacionesBaja = mmObservacionesBaja.Text.Trim();

            objEmp.IdTipoIdentificacion = int.Parse(lueTipoIdentificacion.EditValue.ToString());
            objEmp.NumeroIdentificacion = txtEditNumeroIdentificacion.Text;
            objEmp.FechaInicioContrato = deteInicioContrato.DateTime;
            objEmp.VigenciaContrato = dteditVigenciaContrato.DateTime;

            objEmp.Vacaciones = seVacaciones.Value;
            objEmp.PrimaVacacional = sePrimaVacacional.Value;
            objEmp.Aguinaldo = seAguinaldo.Value;

            objEmp.ConceptoContratacion = mmContratacion.Text;
            objEmp.HerramientasTrabajo = mmHerramientas.Text;
            objEmp.InformacionConfidencial = mmConfidencial.Text;
            objEmp.ContratoFirmado = checkContratoFisico.Checked;
            objEmp.IdTenedoraSC = Convert.ToInt32(cboIdTenedoraSC.EditValue);
            objEmp.CentroDeCosto = txtCentroDeCosto1.Text;

            objEmp.CodigoPostal_Fiscal = txtCodigoPostalFiscal.Text;
            objEmp.IdEstadoDomicilioFiscal = idEstadoDomicilioFiscal;
            objEmp.Sindicalizado = checkEditSindicalizado.Checked ? "SI" : "NO";

            return objEmp;
        }

        /// <summary>
        /// Método para asignar los valores de la Direccion Empleado
        /// </summary>
        /// <param name="pIdDireccion">Valor IdDireccion registrada inicialmente</param>
        /// <param name="pIdTipoDireccion">Valor IdTipoDireccion 1 = Centro de Trabajo, 2 = Domicilio Particular</param>
        /// <returns></returns>
        private DireccionEmpleado AsignarInfoDireccionEmpleado(Empleado objEmp, Int64 pIdDireccion, Constantes.TipoDireccionEmpleado pIdTipoDireccion)
        {
            DireccionEmpleado objDireccionEmp = new DireccionEmpleado();

            if (pIdTipoDireccion == Constantes.TipoDireccionEmpleado.CentroTrabajo)     //Centro de Trabajo = CT
            {
                objDireccionEmp.IdDireccion = pIdDireccion;
                objDireccionEmp.IdEmpleado = Convert.ToInt32(txtNoEmpleado.Text);
                objDireccionEmp.Calle = txtCalleCT.Text.Trim();
                objDireccionEmp.NoExterior = txtNoExteriorCT.Text.Trim();
                objDireccionEmp.NoInterior = txtNoInteriorCT.Text.Trim();
                objDireccionEmp.Colonia = txtColoniaCT.Text.Trim();
                objDireccionEmp.CodigoPostal = txtCodigoPostalCT.Text.Trim();
                objDireccionEmp.NombreDelegacionMunicipio = txtDelegacionMunicipioCT.Text.Trim();
                objDireccionEmp.NombrePoblacionCiudad = txtPoblacionCiudadCT.Text.Trim();
                objDireccionEmp.Telefono1 = txtTelefono1CT.Text.Trim();
                objDireccionEmp.Telefono2 = txtTelefono2CT.Text.Trim();
                objDireccionEmp.IdEstado = (int)cboIdEstadoCT.EditValue;
                objDireccionEmp.IdTipoDireccion = (byte)pIdTipoDireccion;
            }
            else if (pIdTipoDireccion == Constantes.TipoDireccionEmpleado.Particular)    //Domicilio Particular = DP
            {
                objDireccionEmp.IdDireccion = pIdDireccion;
                objDireccionEmp.IdEmpleado = Convert.ToInt32(txtNoEmpleado.Text);
                objDireccionEmp.Calle = txtCalleDP.Text.Trim();
                objDireccionEmp.NoExterior = txtNoExteriorDP.Text.Trim();
                objDireccionEmp.NoInterior = txtNoInteriorDP.Text.Trim();
                objDireccionEmp.Colonia = txtColoniaDP.Text.Trim();
                objDireccionEmp.CodigoPostal = txtCodigoPostalDP.Text.Trim();
                objDireccionEmp.NombreDelegacionMunicipio = txtDelegacionMunicipioDP.Text.Trim();
                objDireccionEmp.NombrePoblacionCiudad = txtPoblacionCiudadDP.Text.Trim();
                objDireccionEmp.Telefono1 = txtTelefono1DP.Text.Trim();
                objDireccionEmp.Telefono2 = txtTelefono2DP.Text.Trim();
                objDireccionEmp.IdEstado = (int)cboIdEstadoDP.EditValue;
                objDireccionEmp.IdTipoDireccion = (byte)pIdTipoDireccion;
            }
            else if (pIdTipoDireccion == Constantes.TipoDireccionEmpleado.Fiscal)    //Domicilio Particular = DP
            {
                objDireccionEmp.IdDireccion = pIdDireccion;
                objDireccionEmp.IdEmpleado = Convert.ToInt32(txtNoEmpleado.Text);
                objDireccionEmp.Calle = String.Empty;
                objDireccionEmp.NoExterior = String.Empty;
                objDireccionEmp.NoInterior = String.Empty;
                objDireccionEmp.Colonia = String.Empty;

                objDireccionEmp.CodigoPostal = objEmp.CodigoPostal_Fiscal;

                objDireccionEmp.NombreDelegacionMunicipio = String.Empty;
                objDireccionEmp.NombrePoblacionCiudad = String.Empty;
                objDireccionEmp.Telefono1 = String.Empty;
                objDireccionEmp.Telefono2 = String.Empty;

                objDireccionEmp.IdEstado = objEmp.IdEstadoDomicilioFiscal;
                objDireccionEmp.IdTipoDireccion = (byte)pIdTipoDireccion;
            }

            //asignar usuarios
            objDireccionEmp.UsuarioCreacion = OperadorBD.OperadorGlobal.NombreUsuario;
            objDireccionEmp.UsuarioModificacion = OperadorBD.OperadorGlobal.NombreUsuario;

            return objDireccionEmp;     //regresar objeto Direccion
        }


        /// <summary>
        /// Metodo para desplegar el contenido del objeto Empleado
        /// </summary>
        /// <param name="objEmp">Objeto Empleado</param>
        private void MostrarInfoEmpleado(Empleado objEmp)
        {
            txtNoEmpleado.Text = objEmp.IdEmpleado.ToString();
            txtAPaternoEmpleado.Text = objEmp.APaternoEmpleado;
            txtAMaternoEmpleado.Text = objEmp.AMaternoEmpleado;
            txtNombreEmpleado.Text = objEmp.NombreEmpleado;

            //Asignando valores de nombre del empleado
            stEmpleadoNombre = objEmp.NombreEmpleado;
            stEmpleadoAPaterno = objEmp.APaternoEmpleado;
            stEmpleadoAMaterno = objEmp.AMaternoEmpleado;

            txtNSS.Text = objEmp.NSS;
            txtRFC.Text = objEmp.RFC;
            txtCURP.Text = objEmp.CURP;
            txtSalarioDiarioContrato.Text = objEmp.SalarioDiarioContrato.ToString("N2");
            txtSalarioBaseCotizacionContrato.Text = objEmp.SalarioBaseCotizacionContrato.ToString("N2");
            txtSalarioDiarioIntegradoContrato.Text = objEmp.SalarioDiarioIntegradoContrato.ToString("N2");
            calFechaIngresoReingresoContrato.EditValue = objEmp.FechaIngresoContrato;
            calFechaBajaContrato.EditValue = objEmp.FechaBajaContrato;
            cboIdZonaSalario.EditValue = objEmp.IdZonaSalario;
            cboIdTipoPeriodoNomina.EditValue = objEmp.IdTipoPeriodoNomina;
            cboIdTipoEmpleado.EditValue = objEmp.IdTipoEmpleado;
            txtPuestoContrato.Text = objEmp.PuestoContrato;
            txtDepartamentoContrato.Text = objEmp.DepartamentoContrato;

            cboIdCliente.EditValue = objEmp.IdCliente;
            //cboIdCliente.EditValue = cboIdCliente.Text == String.Empty ? 0 : objEmp.IdCliente;

            cboIdTenedoraSA.EditValue = objEmp.IdTenedoraSA;
            txtTenedoraSA.Text = objEmp.TenedoraSA;
            txtTenedoraSC.Text = objEmp.TenedoraSC;
            cboIdTipoMovimiento.EditValue = objEmp.IdTipoMovimiento;        //ESQUEMA
            cboIdEstatus.EditValue = objEmp.IdEstatus;

            calFechaNacimiento.EditValue = objEmp.FechaNacimiento;
            txtNoDocMigratorio.Text = objEmp.NoDocMigratorio;
            cboIdSexo.EditValue = objEmp.IdSexo;
            txtSalarioDiarioCliente.Text = objEmp.SalarioDiarioCliente.ToString("N2");
            calFechaIngresoCliente.EditValue = objEmp.FechaIngresoCliente;
            cboIdTurno.EditValue = objEmp.IdTurno;
            cboIdTipoContrato.EditValue = objEmp.IdTipoContrato;

            //*******Validacion del tiempo de contrato*********//
            //txtTiempoContrato.Text = objEmp.TiempoContrato;
            int iTiempoContrato = 0;
            int.TryParse(objEmp.TiempoContrato, out iTiempoContrato);
            txtTiempoContrato.Text = iTiempoContrato.ToString();
            //*******Validacion del tiempo de contrato*********//
            txtUMF.Text = objEmp.UMF;
            txtLugarNacimiento.Text = objEmp.LugarNacimiento;
            txtProfesion.Text = objEmp.Profesion;
            cboIdEstadoCivil.EditValue = objEmp.IdEstadoCivil;
            cboIdNacionalidad.EditValue = objEmp.IdNacionalidad;
            txtDepartamentoCliente.Text = objEmp.DepartamentoCliente;
            txtPuestoCliente.Text = objEmp.PuestoCliente;
            txtDescJornada.Text = objEmp.DescJornada;
            txtHorarioJornada.Text = objEmp.HorarioJornada;
            txtTiempoComidaDescanso.Text = objEmp.TiempoComidaDescanso;
            txtFuncionesEmpleado.Text = objEmp.FuncionesEmpleado;
            cboAutorizacionPermanenteIMSS.EditValue = objEmp.AutorizacionPermanenteIMSS;
            txtNoCreditoInfonavit.Text = objEmp.NoCreditoInfonavit;

            txtBancoDepositoNomina.Text = objEmp.BancoDepositoNomina;
            txtNoCuentaBanco.Text = objEmp.NoCuentaBanco;
            txtNoReferenciaEmpleadoBanco.Text = objEmp.NoReferenciaEmpleadoBanco;
            txtCLABE.Text = objEmp.CLABE;
            cboIdFormaPago.EditValue = objEmp.IdFormaPago;
            txtObservaciones.Text = objEmp.Observaciones;
            txtIdEstatusJuridico.Text = objEmp.IdEstatusJuridico.ToString();
            txtCorreoElectronico.Text = objEmp.CorreoElectronico;

            //Asignanco el valor de la forma de pago para el cambio de forma de pago
            bIdFormaPago = objEmp.IdFormaPago;
            lookupMotivoBaja.EditValue = objEmp.IdConceptoBaja;
            cboIdJornadaServicio.EditValue = objEmp.IdJornadaServicio;
            mmObservacionesBaja.Text = objEmp.ObservacionesBaja;
            deteInicioContrato.EditValue = objEmp.FechaInicioContrato;
            cboIdTenedoraSC.EditValue = objEmp.IdTenedoraSC;
            txtCentroDeCosto1.Text = objEmp.CentroDeCosto;
            checkEditSindicalizado.Checked = objEmp.Sindicalizado == "SI" ? true : false;
        }


        /// <summary>
        /// Método para desplegar las Direcciones de Empleados
        /// </summary>
        /// <param name="dtDireccionEmpleado">Objeto DataTable</param>
        private void MostrarInfoLINQDireccionEmpleado(DataTable dtDireccionEmpleado)
        {
            var linqDireccion = from myRow in dtDireccionEmpleado.AsEnumerable()
                                select myRow;

            //recorrer registros
            foreach (var direccion in linqDireccion)
            {
                if (direccion.Field<byte>("IdTipoDireccion").Equals(1))
                {
                    //asignar el IdDireccion que tiene registrado
                    gpcDomicilioCT.Tag = direccion.Field<Int64>("IdDireccion");
                    txtCalleCT.Text = direccion.Field<string>("Calle");
                    txtNoExteriorCT.Text = direccion.Field<string>("NoExterior");
                    txtNoInteriorCT.Text = direccion.Field<string>("NoInterior");
                    txtColoniaCT.Text = direccion.Field<string>("Colonia");
                    txtCodigoPostalCT.Text = direccion.Field<string>("CodigoPostal");
                    txtDelegacionMunicipioCT.Text = direccion.Field<string>("NombreDelegacionMunicipio");
                    txtPoblacionCiudadCT.Text = direccion.Field<string>("NombrePoblacionCiudad");
                    txtTelefono1CT.Text = direccion.Field<string>("Telefono1");
                    txtTelefono2CT.Text = direccion.Field<string>("Telefono2");
                    cboIdEstadoCT.EditValue = direccion.Field<int>("IdEstado");
                }
                else if (direccion.Field<byte>("IdTipoDireccion").Equals(2))
                {
                    //asignar el IdDireccion que tiene asignado
                    gpcDomicilioPE.Tag = direccion.Field<Int64>("IdDireccion");
                    txtCalleDP.Text = direccion.Field<string>("Calle");
                    txtNoExteriorDP.Text = direccion.Field<string>("NoExterior");
                    txtNoInteriorDP.Text = direccion.Field<string>("NoInterior");
                    txtColoniaDP.Text = direccion.Field<string>("Colonia");
                    txtCodigoPostalDP.Text = direccion.Field<string>("CodigoPostal");
                    txtDelegacionMunicipioDP.Text = direccion.Field<string>("NombreDelegacionMunicipio");
                    txtPoblacionCiudadDP.Text = direccion.Field<string>("NombrePoblacionCiudad");
                    txtTelefono1DP.Text = direccion.Field<string>("Telefono1");
                    txtTelefono2DP.Text = direccion.Field<string>("Telefono2");
                    cboIdEstadoDP.EditValue = direccion.Field<int>("IdEstado");
                }
                else if (direccion.Field<byte>("IdTipoDireccion").Equals(3))
                {
                    gpcDomicilioFiscal.Tag = direccion.Field<Int64>("IdDireccion");
                    txtCodigoPostalFiscal.Tag = direccion.Field<Int64>("IdDireccion");
                    txtCodigoPostalFiscal.Text = direccion.Field<string>("CodigoPostal");
                }
            }   //foreach
        }


        private Empleado MostrarInfoLINQDireccionEmpleado(DataTable dtDireccionEmpleado, Empleado miEmpleado)
        {
            try
            {
                var linqDireccion = from myRow in dtDireccionEmpleado.AsEnumerable()
                                    select myRow;

                //recorrer registros
                foreach (var direccion in linqDireccion)
                {
                    if (direccion.Field<byte>("IdTipoDireccion").Equals(1))
                    {
                        miEmpleado.idDireccion_CT = direccion.Field<Int64>("IdDireccion");
                        miEmpleado.Calle_CT = direccion.Field<string>("Calle");
                        miEmpleado.NoExterior_CT = direccion.Field<string>("NoExterior");
                        miEmpleado.NoInterior_CT = direccion.Field<string>("NoInterior");
                        miEmpleado.Colonia_CT = direccion.Field<string>("Colonia");
                        miEmpleado.CodigoPostal_CT = direccion.Field<string>("CodigoPostal");
                        miEmpleado.NombreDelegacionMunicipio_CT = direccion.Field<string>("NombreDelegacionMunicipio");
                        miEmpleado.NombrePoblacionCiudad_CT = direccion.Field<string>("NombrePoblacionCiudad");
                        miEmpleado.Telefono1_CT = direccion.Field<string>("Telefono1");
                        miEmpleado.Telefono2_CT = direccion.Field<string>("Telefono2");
                        miEmpleado.IdEstado_CT = direccion.Field<int>("IdEstado");
                    }
                    else if (direccion.Field<byte>("IdTipoDireccion").Equals(2))
                    {
                        miEmpleado.idDireccion_DP = direccion.Field<Int64>("IdDireccion");
                        miEmpleado.Calle_DP = direccion.Field<string>("Calle");
                        miEmpleado.NoExterior_DP = direccion.Field<string>("NoExterior");
                        miEmpleado.NoInterior_DP = direccion.Field<string>("NoInterior");
                        miEmpleado.Colonia_DP = direccion.Field<string>("Colonia");
                        miEmpleado.CodigoPostal_DP = direccion.Field<string>("CodigoPostal");
                        miEmpleado.NombreDelegacionMunicipio_DP = direccion.Field<string>("NombreDelegacionMunicipio");
                        miEmpleado.NombrePoblacionCiudad_DP = direccion.Field<string>("NombrePoblacionCiudad");
                        miEmpleado.Telefono1_DP = direccion.Field<string>("Telefono1");
                        miEmpleado.Telefono2_DP = direccion.Field<string>("Telefono2");
                        miEmpleado.IdEstado_DP = direccion.Field<int>("IdEstado");
                    }
                    else if (direccion.Field<byte>("IdTipoDireccion").Equals(3))
                    {
                        miEmpleado.idDireccion_Fiscal = direccion.Field<Int64>("IdDireccion");
                        miEmpleado.CodigoPostal_Fiscal = direccion.Field<string>("CodigoPostal");
                        miEmpleado.IdEstadoDomicilioFiscal = direccion.Field<int>("IdEstado");
                    }
                }   //foreach
            }
            catch (Exception ex) { }

            return miEmpleado;
        }


        /// <summary>
        /// Método para visualizar la información de los Domicilios del Empleados
        /// </summary>
        private void MostrarInfoDireccionEmpleado(Empleado miEmpleado)
        {
            LimpiarControlesDireccion();        //limpiar controles Direccion

            //obtener las direcciones del empleado
            DataTable dtDireccionEmpleado = this.stpSelObtenerInfoDireccionEmpleadoModificacionCFDITableAdapter1.GetData(Convert.ToInt32(cboIdEmpleado.EditValue));

            if (dtDireccionEmpleado.Rows.Count > 0)
            {
                //visualizar las Direcciones de los Empleados
                MostrarInfoLINQDireccionEmpleado(dtDireccionEmpleado);

                //Asignar valores de Direccion del Empleado
                miEmpleado = MostrarInfoLINQDireccionEmpleado(dtDireccionEmpleado, miEmpleado);
            }

        }

        private void MostrarInfoContratoEmpleado(Empleado objEmp)
        {
            LimpiarControlesContrato();

            txtEditNumeroIdentificacion.Text = objEmp.NumeroIdentificacion;
            dteditVigenciaContrato.Text = objEmp.VigenciaContrato.ToShortDateString(); ;
            seVacaciones.Text = objEmp.Vacaciones.ToString("N2");
            sePrimaVacacional.Text = objEmp.PrimaVacacional.ToString("N2");
            seAguinaldo.Text = objEmp.Aguinaldo.ToString("N2");
            mmContratacion.Text = objEmp.ConceptoContratacion;
            mmHerramientas.Text = objEmp.HerramientasTrabajo;
            mmConfidencial.Text = objEmp.InformacionConfidencial;
            txtEditAutoridadExpide.Text = objEmp.AutoridadExpide;
            lueTipoIdentificacion.EditValue = objEmp.IdTipoIdentificacion;

            txtbxIdSolicitusAlta.Text = objEmp.NumSolicitudAlta.ToString();
            txtbxIdSolicitusBaja.Text = objEmp.NumSolicitudBaja.ToString();
            checkContratoFisico.Checked = objEmp.ContratoFirmado;

        }

        private void LimpiarControlesContrato()
        {
            lueTipoIdentificacion.Text = String.Empty;
            txtEditNumeroIdentificacion.Text = String.Empty;
            dteditVigenciaContrato.Text = String.Empty;
            txtEditIdPlan.Text = String.Empty;
            seVacaciones.Value = 0;
            sePrimaVacacional.Value = 0;
            seAguinaldo.Value = 0;
            mmContratacion.Text = String.Empty;
            mmHerramientas.Text = String.Empty;
            mmConfidencial.Text = String.Empty;
            txtEditEdad.Text = String.Empty;
        }

        /// <summary>
        /// Método que actualiza la información del empleado
        /// </summary>
        private void ActualizarInfoEmpleado()
        {
            Empleado objEmp = AsignarInfoEmpleado();    //crear objeto y asignar valores

            //accion de actualizar
            bool bFlagUpdate = EmpleadoBD.ActualizarInfoEmpleado(objEmp, winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString);
            bool bFlagUpdateContrato = EmpleadoBD.ActualizarInfoEmpleadoContrato(objEmp, winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString);
            bool bFlagUpdateDireccionEmpleado = ActualizarInfoDireccionEmpleado(objEmp);

            MostrarInfoDireccionEmpleado(objEmp); //recargar los ajustes a los Domicilios del Empleado

            if (bFlagUpdate && bFlagUpdateDireccionEmpleado && bFlagUpdateContrato)    //fue correcta la modificacion
            {
                inicializarVariablesDeBotones();
                ActivarBotones(true);
                estatusBoton = EstatusBotones.Ninguno;    //asignar accion NINGUNO
                ActivarControles(false, tipoPerfil);     //bloqueo de controles permitidos
                mostarInformacionEmpleado();
                XtraMessageBox.Show("La información del Empleado se actualizó Correctamente.",
                    "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboIdEmpleado.Focus();
            }
            else  //error en actualizacion
            {
                XtraMessageBox.Show("NO fue posible actualizar la información del Empleado" + Environment.NewLine +
                    (bFlagUpdate == true ? String.Empty : "Error en Información de Empleado ") + Environment.NewLine +
                     (bFlagUpdateDireccionEmpleado == true ? String.Empty : "Error en Domicilios del Empleado ") + Environment.NewLine +
                      (bFlagUpdateContrato == true ? String.Empty : "Error en Información de Contrato del Empleado "), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        /// <summary>
        /// Método que realiza la asignación y actualizacion de las Direcciones
        /// del Empleado (Centro de Trabajo y Domicilio Particular)
        /// </summary>
        /// <returns>Valor TRUE o FALSE</returns>
        private bool ActualizarInfoDireccionEmpleado(Empleado objEmp)
        {
            DireccionEmpleado objDireccionEmpCT = AsignarInfoDireccionEmpleado(objEmp, Convert.ToInt64(gpcDomicilioCT.Tag), Constantes.TipoDireccionEmpleado.CentroTrabajo);    //crear objeto y asignar valores
            DireccionEmpleado objDireccionEmpDP = AsignarInfoDireccionEmpleado(objEmp, Convert.ToInt64(gpcDomicilioPE.Tag), Constantes.TipoDireccionEmpleado.Particular);    //crear objeto y asignar valores
            DireccionEmpleado objDireccionEmpFiscal = AsignarInfoDireccionEmpleado(objEmp, Convert.ToInt64(gpcDomicilioFiscal.Tag), Constantes.TipoDireccionEmpleado.Fiscal);    //crear objeto y asignar valores

            //accion de actualizar
            bool bFlagUpdateCT = DireccionEmpleadoBD.ActualizarInfoDireccionEmpleado(objDireccionEmpCT, winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString);
            bool bFlagUpdateDP = DireccionEmpleadoBD.ActualizarInfoDireccionEmpleado(objDireccionEmpDP, winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString);
            bool bFlagUpdateFiscal = DireccionEmpleadoBD.ActualizarInfoDireccionEmpleado(objDireccionEmpFiscal, winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString);

            return bFlagUpdateCT && bFlagUpdateDP && bFlagUpdateFiscal;
        }


        /// <summary>
        /// Método que se encargará de validar los objetos Obligatorios
        /// dentro de la pantalla
        /// </summary>
        /// <returns>Valor TRUE o FALSE</returns>
        private bool IsValidData()
        {
            return true;
        }


        /// <summary>
        /// Método que se encarga de validar la fecha del objeto DateTimePicker
        /// </summary>
        /// <param name="objVisual">Nombre del Objeto DateTimePicker</param>
        /// <returns>Valor TRUE o FALSE</returns>
        private bool IsValidDate(DateTimePicker objVisual)
        {
            try
            {
                DateTime fechaControl = objVisual.Value;

                if (fechaControl.Year <= DateTime.Today.Year - 5)
                    return true;
                else
                    return false;
            }
            catch (FormatException)
            {
                XtraMessageBox.Show(string.Format("{0} no es válida.",
                                     objVisual.Tag), "Error de Captura",
                                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        /// <summary>
        /// Método que se encarga de validar la fecha del objeto DateEdit
        /// </summary>
        /// <param name="objVisual">Nombre del Objeto DateEdit</param>
        /// <returns>Valor TRUE o FALSE</returns>
        private bool IsValidDate(DateEdit objVisual)
        {
            try
            {
                DateTime fechaControl = Convert.ToDateTime(objVisual.Text);

                if (fechaControl.Year == 1900)
                {
                    XtraMessageBox.Show(String.Format("{0} no es válida.",
                                          objVisual.Tag), "Error de Captura",
                                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (fechaControl.Year == DateTime.Today.Year)
                    return true;
                else if (fechaControl.Year > DateTime.Today.Year)
                {
                    XtraMessageBox.Show(String.Format("{0} no es válida.",
                                          objVisual.Tag), "Error de Captura",
                                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (DateTime.Today.Year - fechaControl.Year <= 15)
                    return true;
                else
                {
                    XtraMessageBox.Show(String.Format("{0} no es válida.",
                                          objVisual.Tag), "Error de Captura",
                                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (FormatException)
            {
                XtraMessageBox.Show(String.Format("{0} no es válida.",
                                      objVisual.Tag), "Error de Captura",
                                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        private bool validarFecha(DateTime dtFecha)
        {
            bool boolEstaMuyBien = true;
            if (dtFecha.Year.ToString() == "1900")
            {
                XtraMessageBox.Show(string.Format("{0} no es válida.",
                                       dtFecha.ToShortDateString()), "Error de Captura",
                                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                boolEstaMuyBien = false;
            }
            else if (dtFecha > dtFechaServidor.Date.AddDays(15))
            {
                XtraMessageBox.Show(string.Format("{0} no es válida.",
                                        dtFecha.ToShortDateString()), "Error de Captura",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                boolEstaMuyBien = false;
            }

            return boolEstaMuyBien;
        }


        /// <summary>
        /// Método para cambiar comportamiento de los botones
        /// </summary>
        /// <param name="bFlag">Valor TRUE o FALSE</param>
        private void ActivarBotones(bool bFlag)
        {
            btnCancelar.Enabled = !bFlag;
            btnEditar.Enabled = bFlag;
            btnGuardar.Enabled = !bFlag;
        }


        /// <summary>
        /// Método para mostrar u ocultar botones de las Operaciones
        /// permitidas en la pantalla
        /// </summary>
        /// <param name="bFlag">Valor VERDADERO o FALSO</param>
        private void ActivarBotonesOperaciones(bool bFlag)
        {
            btnEditar.Visible = bFlag;
            btnCancelar.Visible = bFlag;
            btnGuardar.Visible = bFlag;

            btnSolicitarTramiteIMSS.Visible = !bFlag;
        }

        private EstatusBotones estatusBoton;

        //enumeracion con estatus de las acciones
        enum EstatusBotones
        {
            Nuevo = 1,
            Editar = 2,
            Ninguno = 0
        }

        #endregion

        private void frmxModificacionEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet.stpSelObtenerInfoGenericaTenedoraSC1' table. You can move, or remove it, as needed.
            this.stpSelObtenerInfoGenericaTenedoraSC1TableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelObtenerInfoGenericaTenedoraSC1);
            // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet.stpSelSexo1' table. You can move, or remove it, as needed.
            this.stpSelSexo1TableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelSexo1);
            // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet.stpSelSexo' table. You can move, or remove it, as needed.
            this.stpSelSexoTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelSexo);
            try
            {
                splashSMCargando.ShowWaitForm();
                splashSMCargando.SetWaitFormCaption("Cargando");
                splashSMCargando.SetWaitFormDescription("Modulo de Empleados...");
                dtFechaServidor = ObtenerFechaServidor();


                stpSelObtenerConceptosBajaTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelObtenerConceptosBaja, false);
                //this.stpSelSexo1TableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelSexo1);
                // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet.stpSelTipoEmpleado' table. You can move, or remove it, as needed.
                this.stpSelTipoEmpleadoTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelTipoEmpleado);
                // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet.stpSelZonaSalario' table. You can move, or remove it, as needed.
                this.stpSelZonaSalarioTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelZonaSalario);
                // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet.stpSelTipoContrato' table. You can move, or remove it, as needed.
                this.stpSelTipoContratoTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelTipoContrato);
                // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet.stpSelTurno' table. You can move, or remove it, as needed.
                this.stpSelTurnoTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelTurno);
                // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet.stpSelTipoPeriodoNominaEmpleadoCFDI' table. You can move, or remove it, as needed.
                this.stpSelTipoPeriodoNominaEmpleadoCFDITableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelTipoPeriodoNominaEmpleadoCFDI);
                // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet.stpSelNacionalidad' table. You can move, or remove it, as needed.
                this.stpSelNacionalidadTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelNacionalidad);
                // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet.stpSelEstadoCivil' table. You can move, or remove it, as needed.
                this.stpSelEstadoCivilTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelEstadoCivil);

                // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet.stpSelEmpleadosDisponibles' table. You can move, or remove it, as needed.
                this.stpSelEmpleadosDisponiblesTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelEmpleadosDisponibles);

                // TODO: This line of code loads data into the 'dbSAICBPODataSet.vwCatTenedoraSA' table. You can move, or remove it, as needed.
                this.vwCatTenedoraSATableAdapter.Fill(this.dbSAICBPODataSet.vwCatTenedoraSA);
                // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet.stpSelEstado' table. You can move, or remove it, as needed.
                this.stpSelEstadoTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelEstado);
                // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet.stpSelFormaPago' table. You can move, or remove it, as needed.
                this.stpSelFormaPagoTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelFormaPago);
                //llenar combobox Estatus Empleados
                this.vwCatEstatusEmpleadoCFDITableAdapter.Fill(this.dbSAICBPONominaCFDIDataSet.vwCatEstatusEmpleadoCFDI);

                stpSelTipoIdentificacionTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelTipoIdentificacion);
                dtTipoIdentificacion = dbSAICBPOCatalogosDataSet.stpSelTipoIdentificacion;

                this.stpSelTipoIdentificacionTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelTipoIdentificacion);

                this.stpSelClientesConfidencialTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelClientesConfidencial, true);
                stpSelJornadaServicioTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelJornadaServicio);

                stpSelObtenerInfoGenericaTenedoraSC_1TableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoGenericaTenedoraSC_1, 0, false);

                if (tipoOperacion == Constantes.TipoOperacion.ModificacionEmpleado)
                {
                    this.Text = "Modificación de Información Empleados";
                    ActivarBotones(true);
                    estatusBoton = EstatusBotones.Ninguno;      //inicializo valor bandera estatus
                    ActivarBotonesOperaciones(true);
                }
                else if (tipoOperacion == Constantes.TipoOperacion.AsignacionNSSBajaReingreso)
                {
                    this.Text = "Asignación de NSS, Modificación de Salario, Baja y Reingreso Empleados";
                    ActivarBotonesOperaciones(false);
                }

                cboIdEmpleado.Focus();        //colocar cursor en objeto
                ActivarControles(false, tipoPerfil);        //desactivar controles
                LimpiarControles();     //limpiar contenido controles
                LimpiarControlesDireccion();        //limpiar contenido controles Direccion
                LimpiarControlesContrato();

                // Set column widths according to their contents. 
                cboIdEmpleado.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cboIdEmpleado.Properties.PopupFormWidth = 700;

                iniComponentes(this.iIdEmpleado, this.banAltaEmpleados);

                stRutaEmpleados = dsc.stRutaEmpleados;
            }
            catch (Exception ex)
            {
                if (splashSMCargando.IsSplashFormVisible) { splashSMCargando.CloseWaitForm(); }

                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (splashSMCargando.IsSplashFormVisible) { splashSMCargando.CloseWaitForm(); }
            }
        }

        private DateTime ObtenerFechaServidor()
        {
            // Obtener la fecha del servidor
            DateTime dtFechaServidor = new DateTime();
            String stfechaServidor = String.Empty;
            stfechaServidor = stpSelEstatusNominaContabilizadaTableAdapter1.ObtenerFechaServidor().ToString();
            DateTime.TryParse(stfechaServidor, out dtFechaServidor);
            return dtFechaServidor;
        }


        /// <summary>
        ///Validar el acceso HABILITADO de los botones cboIdTipoMovimiento, cboIdEstatus, calFechaBajaContrato
        /// </summary>
        private void validarAccesoBotoenesModificacion()
        {
            if (objEmp != null)
            {
                try
                {
                    Boolean flagActivoEmpleadoPrueba = false;
                    stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "EMPLEADO PRUEBA");
                    if (dbSAICBPOValidacionDataSet1.stpSelParametro.Rows.Count > 0)
                    {
                        flagActivoEmpleadoPrueba = dbSAICBPOValidacionDataSet1.stpSelParametro.Rows[0]["ValorParametro"].ToString() == "SI" ? true : false;
                    }

                    if (objEmp.NombreEmpleado == "EMPLEADO" && objEmp.APaternoEmpleado == "PRUEBA" && objEmp.AMaternoEmpleado == "PRUEBA" && flagActivoEmpleadoPrueba)
                    {
                        flageHabilitarEsquema = true;
                        flageHabilitarEstatusEmpleado = true;
                        flageHabilitarCausabaja = true;
                        flageHabilitarTenedoras = true;
                        flageHabilitarCliente = true;
                    }
                    else
                    {
                        this.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1.Fill(this.dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion, OperadorBD.OperadorGlobal.IdOperador, "ModificacionEmpleados.Botones", "btnAcceso");
                        if (dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion.Rows.Count > 0)
                        {
                            Boolean.TryParse(dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion.Rows[0]["Consultar"].ToString(), out flageHabilitarEsquema);
                            Boolean.TryParse(dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion.Rows[0]["Actualizar"].ToString(), out flageHabilitarEstatusEmpleado);
                            Boolean.TryParse(dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion.Rows[0]["Insertar"].ToString(), out flageHabilitarCausabaja);
                            Boolean.TryParse(dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion.Rows[0]["Eliminar"].ToString(), out flageHabilitarTenedoras);
                            Boolean.TryParse(dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion.Rows[0]["Habilitar"].ToString(), out flageHabilitarCliente);
                        }
                        else
                        {
                            flageHabilitarEsquema = false;
                            flageHabilitarEstatusEmpleado = false;
                            flageHabilitarCausabaja = false;
                            flageHabilitarTenedoras = false;
                            flageHabilitarCliente = false;
                        }
                    }

                }
                catch (Exception ex)
                {
                    flageHabilitarEsquema = false;
                    flageHabilitarEstatusEmpleado = false;
                    flageHabilitarCausabaja = false;
                    flageHabilitarTenedoras = false;
                    flageHabilitarCliente = false;
                }
            }
        }

        private void validarSolicitudDeSalarios()
        {
            if (objEmp != null)
            {
                stpSelValidacionDeSolicitudesActivasTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelValidacionDeSolicitudesActivas, objEmp.IdEmpleado);

                if (dbSAICBPOCatalogosDataSet1.stpSelValidacionDeSolicitudesActivas.Rows.Count > 0)
                {
                    flageHabilitarSalarios = false;
                    erroProviderSalarios.Icon = Properties.Resources.warning1;
                    erroProviderSalarios.SetError(txtSalarioDiarioContrato, "Empleado con Solicitud de Salario Activa " + dbSAICBPOCatalogosDataSet1.stpSelValidacionDeSolicitudesActivas.Rows[0]["idSolicitud"].ToString());
                }
                else
                {
                    this.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1.Fill(this.dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion, OperadorBD.OperadorGlobal.IdOperador, "ModificacionEmpleados.Botones", "btnAcceso2");
                    if (dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion.Rows.Count > 0)
                    {
                        Boolean.TryParse(dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion.Rows[0]["Consultar"].ToString(), out flageHabilitarSalarios);
                    }
                    else
                    {
                        flageHabilitarSalarios = false;
                    }

                    erroProviderSalarios.Clear();
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarInformacionEmpleado();
        }


        private void GuardarInformacionEmpleado()
        {
            Boolean flagAutorizado = false;

            if (cboIdEstatus.EditValue.ToString() == "8") //Cuando es baja
            {
                if (calFechaBajaContrato.DateTime >= calFechaIngresoReingresoContrato.DateTime)
                {
                    flagAutorizado = true;

                    //if (lookupMotivoBaja.Text != "")
                    //{
                    //    flagAutorizado = true;
                    //}
                    //else
                    //{
                    //    flagAutorizado = false;
                    //    lookupMotivoBaja.Focus();
                    //    XtraMessageBox.Show("El Motivo de baja no puede estar Vacio.", "SAIC",
                    //        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                }
                else
                {
                    flagAutorizado = false;
                    calFechaBajaContrato.Focus();
                    XtraMessageBox.Show("La Fecha de Baja no puede ser menor a la Fecha de Ingreso", "SAIC",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                flagAutorizado = true;
            }

            if (flagAutorizado)
            {

                Boolean flagEmpleadoSolicitado = true;

                if (cboIdEstatus.Text == "SOLICITADO")
                {
                    DialogResult oDialogResult = XtraMessageBox.Show("El empleado se encuentra en estatus SOLICITADO. Los cambios pueden afectar a otras areas." + Environment.NewLine +
                        "¿Desea continuar?", "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (DialogResult.No == oDialogResult)
                    {
                        flagEmpleadoSolicitado = false;
                    }
                }

                if (flagEmpleadoSolicitado)
                {
                    Boolean flagSalariosCorrectos = false;
                    Boolean flagValidacionDeFechasParaContrato = false;
                    Decimal SD = 0;
                    Decimal SBC = 0;
                    Decimal SDI = 0;

                    decimal.TryParse(txtSalarioDiarioContrato.Text, out SD);
                    decimal.TryParse(txtSalarioBaseCotizacionContrato.Text, out SBC);
                    decimal.TryParse(txtSalarioDiarioIntegradoContrato.Text, out SDI);

                    flagValidacionDeFechasParaContrato = valFechasParaCIT();

                    if (cboIdEstatus.EditValue.ToString() == "8")
                    {
                        flagSalariosCorrectos = true;
                    }
                    else
                    {
                        //Validacion de SD y SDI
                        flagSalariosCorrectos = validarSalariosEmpleadoContrato(SD, SBC, SDI, cboIdTipoMovimiento.Text, cboIdJornadaServicio.Text, false, dateFechaParaElCalculoSD.DateTime, seVacaciones.Text, sePrimaVacacional.Text, seAguinaldo.Text);
                    }

                    if (flagSalariosCorrectos && flagValidacionDeFechasParaContrato)
                    {
                        if ((strIdMovimientoOriginal.Equals("S") && cboIdTipoMovimiento.EditValue.Equals("S")) ||
                                    (strIdMovimientoOriginal.Equals("M") && cboIdTipoMovimiento.EditValue.Equals("S")) ||
                                    (strIdMovimientoOriginal.Equals("A") && cboIdTipoMovimiento.EditValue.Equals("S")) ||
                                    (strIdMovimientoOriginal.Equals("D") && cboIdTipoMovimiento.EditValue.Equals("S")) ||
                                    (strIdMovimientoOriginal.Equals("P") && cboIdTipoMovimiento.EditValue.Equals("S")))
                        {
                            if (Validator.IsPresent(txtNombreEmpleado) &&
                                Validator.IsPresent(txtAPaternoEmpleado) &&
                                Validator.IsPresent(txtNSS) &&
                                Validator.IsPresent(txtRFC) &&
                                Validator.IsPresent(txtCURP) &&
                                Validator.IsValidNSS(txtNSS, "El NSS", Validator.PatternNNS) &&
                                Validator.IsValidRFC(txtRFC, "El RFC", Validator.PatternRFC_COMODIN, Validator.PatternRFC) &&
                                Validator.IsValidCURP(txtCURP, "El CURP", Validator.PatternCURP) &&
                                Validator.IsDecimal(txtSalarioDiarioContrato) &&
                                Validator.IsDecimal(txtSalarioBaseCotizacionContrato) &&
                                Validator.IsDecimal(txtSalarioDiarioIntegradoContrato) &&
                                Validator.IsPositiveNumber(txtSalarioDiarioContrato) &&
                                Validator.IsPositiveNumber(txtSalarioBaseCotizacionContrato) &&
                                Validator.IsPositiveNumber(txtSalarioDiarioIntegradoContrato) &&
                                Validator.IsPositiveNumber(cboIdCliente) &&
                                Validator.IsPositiveNumber(cboIdTenedoraSA) &&
                                /*IsValidDate(calFechaIngresoReingresoContrato)*/
                                validarFecha(calFechaIngresoReingresoContrato.DateTime) && validarDireccionFiscal(idEstadoDomicilioFiscal, cboIdTipoMovimiento.EditValue.ToString()))
                            {
                                switch (cboIdTipoMovimiento.EditValue.ToString())
                                {
                                    case "P":
                                    case "S":
                                        txtTenedoraSC.Text = string.Empty;
                                        break;

                                    case "D":
                                        txtTenedoraSC.Text = String.Empty;
                                        txtSalarioDiarioContrato.Value = 0;
                                        txtSalarioBaseCotizacionContrato.Value = 0;
                                        txtSalarioDiarioIntegradoContrato.Value = 0;
                                        break;

                                    case "M":
                                        break;

                                    case "A":
                                        cboIdTenedoraSA.EditValue = 1;      //NO APLICA TENEDORA
                                        txtTenedoraSA.Text = String.Empty;
                                        txtSalarioDiarioContrato.Value = 0;
                                        txtSalarioBaseCotizacionContrato.Value = 0;
                                        txtSalarioDiarioIntegradoContrato.Value = 0;
                                        break;
                                } //switch

                                //Buscar informacion del Empleado CFDI con NSS por actualizar
                                DataTable dt = this.stpSelValidarExistenciaNSSTableAdapter1.GetData(txtNSS.Text);
                                DataTable dtRFC = this.stpSelValidarExistenciaRFCTableAdapter1.GetData(txtRFC.Text);
                                DataTable dtCURP = this.stpSelValidarExistenciaCURPTableAdapter1.GetData(txtCURP.Text);

                                //validar NSS
                                if (Validator.NotExistNSS(dt, txtNSS, strNSSOriginal, txtNSS.Text) &&
                                    Validator.NotExistRFC(dtRFC, txtRFC, strRFCOriginal, txtRFC.Text) &&
                                    Validator.NotExistCURP(dtCURP, txtCURP, strCURPOriginal, txtCURP.Text)
                                    )
                                {
                                    ActualizarInfoEmpleado();       //actualizar la información del empleado
                                }
                            }
                        }
                        else if ((strIdMovimientoOriginal.Equals("S") && cboIdTipoMovimiento.EditValue.Equals("M")) ||
                            (strIdMovimientoOriginal.Equals("M") && cboIdTipoMovimiento.EditValue.Equals("M")) ||
                            (strIdMovimientoOriginal.Equals("A") && cboIdTipoMovimiento.EditValue.Equals("M")) ||
                            (strIdMovimientoOriginal.Equals("D") && cboIdTipoMovimiento.EditValue.Equals("M")) ||
                            (strIdMovimientoOriginal.Equals("P") && cboIdTipoMovimiento.EditValue.Equals("M")))
                        {
                            if (Validator.IsPresent(txtNombreEmpleado) &&
                                Validator.IsPresent(txtNSS) &&
                                Validator.IsPresent(txtRFC) &&
                                Validator.IsPresent(txtCURP) &&
                                Validator.IsValidNSS(txtNSS, "El NSS", Validator.PatternNNS) &&
                                Validator.IsValidRFC(txtRFC, "El RFC", Validator.PatternRFC_COMODIN, Validator.PatternRFC) &&
                                Validator.IsValidCURP(txtCURP, "El CURP", Validator.PatternCURP) &&
                                Validator.IsDecimal(txtSalarioDiarioContrato) &&
                                Validator.IsDecimal(txtSalarioBaseCotizacionContrato) &&
                                Validator.IsDecimal(txtSalarioDiarioIntegradoContrato) &&
                                Validator.IsPositiveNumber(txtSalarioDiarioContrato) &&
                                Validator.IsPositiveNumber(txtSalarioBaseCotizacionContrato) &&
                                Validator.IsPositiveNumber(txtSalarioDiarioIntegradoContrato) &&
                                Validator.IsPositiveNumber(cboIdCliente) &&
                                Validator.IsPositiveNumber(cboIdTenedoraSA) &&
                                //IsValidDate(calFechaIngresoReingresoContrato)
                                validarFecha(calFechaIngresoReingresoContrato.DateTime) && validarDireccionFiscal(idEstadoDomicilioFiscal, cboIdTipoMovimiento.EditValue.ToString()))
                            {
                                switch (cboIdTipoMovimiento.EditValue.ToString())
                                {
                                    case "P":
                                    case "S":
                                        txtTenedoraSC.Text = string.Empty;
                                        break;

                                    case "D":
                                        txtTenedoraSC.Text = String.Empty;
                                        txtSalarioDiarioContrato.Value = 0;
                                        txtSalarioBaseCotizacionContrato.Value = 0;
                                        txtSalarioDiarioIntegradoContrato.Value = 0;
                                        break;

                                    case "M":
                                        break;

                                    case "A":
                                        cboIdTenedoraSA.EditValue = 1;      //NO APLICA TENEDORA
                                        txtTenedoraSA.Text = String.Empty;
                                        txtSalarioDiarioContrato.Value = 0;
                                        txtSalarioBaseCotizacionContrato.Value = 0;
                                        txtSalarioDiarioIntegradoContrato.Value = 0;
                                        break;
                                } //switch

                                //Buscar informacion del Empleado CFDI con NSS por actualizar
                                DataTable dt = this.stpSelValidarExistenciaNSSTableAdapter1.GetData(txtNSS.Text);
                                DataTable dtRFC = this.stpSelValidarExistenciaRFCTableAdapter1.GetData(txtRFC.Text);
                                DataTable dtCURP = this.stpSelValidarExistenciaCURPTableAdapter1.GetData(txtCURP.Text);

                                //validar NSS
                                if (Validator.NotExistNSS(dt, txtNSS, strNSSOriginal, txtNSS.Text) &&
                                    Validator.NotExistRFC(dtRFC, txtRFC, strRFCOriginal, txtRFC.Text) &&
                                    Validator.NotExistCURP(dtCURP, txtCURP, strCURPOriginal, txtCURP.Text))
                                {
                                    ActualizarInfoEmpleado();       //actualizar la información del empleado
                                }
                            }
                        }
                        else if ((strIdMovimientoOriginal.Equals("S") && cboIdTipoMovimiento.EditValue.Equals("A")) ||
                            (strIdMovimientoOriginal.Equals("M") && cboIdTipoMovimiento.EditValue.Equals("A")) ||
                            (strIdMovimientoOriginal.Equals("A") && cboIdTipoMovimiento.EditValue.Equals("A")) ||
                            (strIdMovimientoOriginal.Equals("D") && cboIdTipoMovimiento.EditValue.Equals("A")))
                        {
                            if (Validator.IsPresent(txtNombreEmpleado) &&
                                Validator.IsPresent(txtRFC) &&
                                Validator.IsPresent(txtCURP) &&
                               Validator.IsValidNSS(txtNSS, "El NSS", Validator.PatternNNS) &&
                                Validator.IsValidRFC(txtRFC, "El RFC", Validator.PatternRFC_COMODIN, Validator.PatternRFC) &&
                                Validator.IsValidCURP(txtCURP, "El CURP", Validator.PatternCURP_COMODIN, Validator.PatternCURP) &&
                                Validator.IsDecimal(txtSalarioDiarioContrato) &&
                                Validator.IsDecimal(txtSalarioBaseCotizacionContrato) &&
                                Validator.IsDecimal(txtSalarioDiarioIntegradoContrato) &&
                                Validator.IsPositiveOrZeroNumber(txtSalarioDiarioContrato) &&
                                Validator.IsPositiveOrZeroNumber(txtSalarioBaseCotizacionContrato) &&
                                Validator.IsPositiveOrZeroNumber(txtSalarioDiarioIntegradoContrato) &&
                                Validator.IsPositiveNumber(cboIdCliente) &&
                                //IsValidDate(calFechaIngresoReingresoContrato)
                                validarFecha(calFechaIngresoReingresoContrato.DateTime) && validarDireccionFiscal(idEstadoDomicilioFiscal, cboIdTipoMovimiento.EditValue.ToString()))
                            {
                                switch (cboIdTipoMovimiento.EditValue.ToString())
                                {
                                    case "S":
                                        txtTenedoraSC.Text = string.Empty;
                                        break;

                                    case "P":
                                    case "D":
                                        txtTenedoraSC.Text = String.Empty;
                                        txtSalarioDiarioContrato.Value = 0;
                                        txtSalarioBaseCotizacionContrato.Value = 0;
                                        txtSalarioDiarioIntegradoContrato.Value = 0;
                                        break;

                                    case "M":
                                        break;

                                    case "A":
                                        cboIdTenedoraSA.EditValue = 1;      //NO APLICA TENEDORA
                                        txtTenedoraSA.Text = String.Empty;
                                        txtSalarioDiarioContrato.Value = 0;
                                        txtSalarioBaseCotizacionContrato.Value = 0;
                                        txtSalarioDiarioIntegradoContrato.Value = 0;
                                        break;
                                } //switch

                                DataTable dtRFC = this.stpSelValidarExistenciaRFCTableAdapter1.GetData(txtRFC.Text);
                                DataTable dtCURP = this.stpSelValidarExistenciaCURPTableAdapter1.GetData(txtCURP.Text);

                                if (Validator.NotExistRFC(dtRFC, txtRFC, strRFCOriginal, txtRFC.Text) &&
                                  Validator.NotExistCURP(dtCURP, txtCURP, strCURPOriginal, txtCURP.Text))
                                {
                                    ActualizarInfoEmpleado();       //actualizar la información del empleado
                                }
                            }
                        }
                        else if ((strIdMovimientoOriginal.Equals("S") && cboIdTipoMovimiento.EditValue.Equals("D")) ||
                            (strIdMovimientoOriginal.Equals("M") && cboIdTipoMovimiento.EditValue.Equals("D")) ||
                            (strIdMovimientoOriginal.Equals("A") && cboIdTipoMovimiento.EditValue.Equals("D")) ||
                            (strIdMovimientoOriginal.Equals("D") && cboIdTipoMovimiento.EditValue.Equals("D")) ||
                            (strIdMovimientoOriginal.Equals("P") && cboIdTipoMovimiento.EditValue.Equals("D")))
                        {
                            if (Validator.IsPresent(txtNombreEmpleado) &&
                                Validator.IsPresent(txtRFC) &&
                                Validator.IsPresent(txtCURP) &&
                                Validator.IsValidRFC(txtRFC, "El RFC", Validator.PatternRFC_COMODIN, Validator.PatternRFC) &&
                                Validator.IsValidCURP(txtCURP, "El CURP", Validator.PatternCURP) &&
                                Validator.IsDecimal(txtSalarioDiarioContrato) &&
                                Validator.IsDecimal(txtSalarioBaseCotizacionContrato) &&
                                Validator.IsDecimal(txtSalarioDiarioIntegradoContrato) &&
                                Validator.IsPositiveOrZeroNumber(txtSalarioDiarioContrato) &&
                                Validator.IsPositiveOrZeroNumber(txtSalarioBaseCotizacionContrato) &&
                                Validator.IsPositiveOrZeroNumber(txtSalarioDiarioIntegradoContrato) &&
                                Validator.IsPositiveNumber(cboIdCliente) &&
                                Validator.IsPositiveNumber(cboIdTenedoraSA) &&
                                //IsValidDate(calFechaIngresoReingresoContrato)
                                validarFecha(calFechaIngresoReingresoContrato.DateTime) && validarDireccionFiscal(idEstadoDomicilioFiscal, cboIdTipoMovimiento.EditValue.ToString()))
                            {
                                switch (cboIdTipoMovimiento.EditValue.ToString())
                                {
                                    case "S":
                                        txtTenedoraSC.Text = string.Empty;
                                        break;

                                    case "P":
                                    case "D":
                                        txtTenedoraSC.Text = String.Empty;
                                        txtSalarioDiarioContrato.Value = 0;
                                        txtSalarioBaseCotizacionContrato.Value = 0;
                                        txtSalarioDiarioIntegradoContrato.Value = 0;
                                        break;

                                    case "M":
                                        break;

                                    case "A":
                                        cboIdTenedoraSA.EditValue = 1;      //NO APLICA TENEDORA
                                        txtTenedoraSA.Text = String.Empty;
                                        txtSalarioDiarioContrato.Value = 0;
                                        txtSalarioBaseCotizacionContrato.Value = 0;
                                        txtSalarioDiarioIntegradoContrato.Value = 0;
                                        break;
                                } //switch

                                DataTable dtRFC = this.stpSelValidarExistenciaRFCTableAdapter1.GetData(txtRFC.Text);
                                DataTable dtCURP = this.stpSelValidarExistenciaCURPTableAdapter1.GetData(txtCURP.Text);

                                if (Validator.NotExistRFC(dtRFC, txtRFC, strRFCOriginal, txtRFC.Text) &&
                                  Validator.NotExistCURP(dtCURP, txtCURP, strCURPOriginal, txtCURP.Text))
                                {
                                    ActualizarInfoEmpleado();       //actualizar la información del empleado
                                }
                            }
                        }
                        else if ((strIdMovimientoOriginal.Equals("S") && cboIdTipoMovimiento.EditValue.Equals("P")) ||
                                (strIdMovimientoOriginal.Equals("M") && cboIdTipoMovimiento.EditValue.Equals("P")) ||
                                (strIdMovimientoOriginal.Equals("A") && cboIdTipoMovimiento.EditValue.Equals("P")) ||
                                (strIdMovimientoOriginal.Equals("D") && cboIdTipoMovimiento.EditValue.Equals("P")) ||
                                (strIdMovimientoOriginal.Equals("P") && cboIdTipoMovimiento.EditValue.Equals("P")))
                        {
                            if (Validator.IsPresent(txtNombreEmpleado) &&
                                Validator.IsPresent(txtAPaternoEmpleado) &&
                                Validator.IsPresent(txtNSS) &&
                                Validator.IsPresent(txtRFC) &&
                                Validator.IsPresent(txtCURP) &&
                                Validator.IsValidNSS(txtNSS, "El NSS", Validator.PatternNNS) &&
                                Validator.IsValidRFC(txtRFC, "El RFC", Validator.PatternRFC_COMODIN, Validator.PatternRFC) &&
                                Validator.IsValidCURP(txtCURP, "El CURP", Validator.PatternCURP) &&
                                Validator.IsDecimal(txtSalarioDiarioContrato) &&
                                Validator.IsDecimal(txtSalarioBaseCotizacionContrato) &&
                                Validator.IsDecimal(txtSalarioDiarioIntegradoContrato) &&
                                //Validator.IsPositiveNumber(txtSalarioDiarioContrato) &&
                                Validator.IsPositiveNumber(txtSalarioBaseCotizacionContrato) &&
                                Validator.IsPositiveNumber(txtSalarioDiarioIntegradoContrato) &&
                                Validator.IsPositiveNumber(cboIdCliente) &&
                                //Validator.IsPositiveNumber(cboIdTenedoraSA) &&
                                //IsValidDate(calFechaIngresoReingresoContrato)
                                validarFecha(calFechaIngresoReingresoContrato.DateTime) && validarDireccionFiscal(idEstadoDomicilioFiscal, cboIdTipoMovimiento.EditValue.ToString())
                                )
                            {
                                switch (cboIdTipoMovimiento.EditValue.ToString())
                                {
                                    case "P":
                                    case "S":
                                        txtTenedoraSC.Text = string.Empty;
                                        break;

                                    case "D":
                                        txtTenedoraSC.Text = String.Empty;
                                        txtSalarioDiarioContrato.Value = 0;
                                        txtSalarioBaseCotizacionContrato.Value = 0;
                                        txtSalarioDiarioIntegradoContrato.Value = 0;
                                        break;

                                    case "M":
                                        break;

                                    case "A":
                                        cboIdTenedoraSA.EditValue = 1;      //NO APLICA TENEDORA
                                        txtTenedoraSA.Text = String.Empty;
                                        txtSalarioDiarioContrato.Value = 0;
                                        txtSalarioBaseCotizacionContrato.Value = 0;
                                        txtSalarioDiarioIntegradoContrato.Value = 0;
                                        break;
                                } //switch

                                //Buscar informacion del Empleado CFDI con NSS por actualizar
                                DataTable dt = this.stpSelValidarExistenciaNSSTableAdapter1.GetData(txtNSS.Text);
                                DataTable dtRFC = this.stpSelValidarExistenciaRFCTableAdapter1.GetData(txtRFC.Text);
                                DataTable dtCURP = this.stpSelValidarExistenciaCURPTableAdapter1.GetData(txtCURP.Text);

                                //validar NSS
                                if (Validator.NotExistNSS(dt, txtNSS, strNSSOriginal, txtNSS.Text) &&
                                    Validator.NotExistRFC(dtRFC, txtRFC, strRFCOriginal, txtRFC.Text) &&
                                    Validator.NotExistCURP(dtCURP, txtCURP, strCURPOriginal, txtCURP.Text))
                                {
                                    ActualizarInfoEmpleado();       //actualizar la información del empleado
                                }
                            }
                        }

                        //insertar/Actualizar Datos de Contrato
                        //insUpdDatosContrato();

                        //Actualizar Informacion de empleados cuando es por solicitud y es por rechazo del Area de IMSS
                        if (banAltaEmpleados && Imss)
                        {
                            UpdateDatosEmpleadoIMSS();
                        }

                        cboIdTipoMovimiento.Enabled = false;
                        cboIdEstatus.Enabled = false;
                        calFechaBajaContrato.Enabled = false;
                    }
                }
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            inicializarVariablesDeBotones();
            ActivarBotones(true);
            estatusBoton = EstatusBotones.Ninguno;    //asignar accion NINGUNO
            ActivarControles(false, tipoPerfil);     //bloqueo de controles permitidos
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //hablitar botones especiales
            if (txtNoEmpleado.Text.Length > 0)
            {
                validarAccesoBotoenesModificacion();
                validarSolicitudDeSalarios();
                ActivarBotones(false);
                estatusBoton = EstatusBotones.Editar; //asignar accion EDITAR

                if (!banAltaEmpleados)
                {
                    ActivarControles(true, tipoPerfil);     //desbloqueo de controles permitidos 
                }
                else
                {
                    ActivarControlesAltaEmpledos(); //Desbloqueo de controles cuando es por solicitud
                }

                //asignar el Id de Movimiento Original
                //para que al momento de guardar pueda verificar
                //si existió un nuevo valor y validar las condiciones
                //que debe cumplir el usuario
                strIdMovimientoOriginal = cboIdTipoMovimiento.EditValue.ToString();

                //asignar el NSS Original
                strNSSOriginal = txtNSS.Text;
                strRFCOriginal = txtRFC.Text;
                strCURPOriginal = txtCURP.Text;

                //asignar el Estatus Original
                byEstatusOriginal = Convert.ToByte(cboIdEstatus.EditValue);
            }
            else
                XtraMessageBox.Show("No existe empleado activo para Editar su información.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtSalarioBaseCotizacionContrato_EditValueChanged(object sender, EventArgs e)
        {
            //asignar por default el mismo valor
            txtSalarioDiarioIntegradoContrato.Text = txtSalarioBaseCotizacionContrato.Text;
            if (txtSalarioBaseCotizacionContrato.Text.Length > 3)
            {
                validarSBCvs25UMA();
            }
        }

        Decimal dcmUMA;
        Decimal dcmUMA25;
        private void ObtenerValorUMA()
        {
            //validar las 25 umas
            XtraAltaEmpleados AltaEmpleados = new XtraAltaEmpleados("");
            dcmUMA = AltaEmpleados.obtenerUMA(dateFechaParaElCalculoSD.DateTime);
            dateFechaParaElCalculoSD.ToolTip = "Valor UMA: " + dcmUMA.ToString("$0.##");
            dcmUMA25 = dcmUMA * 25;

            int idempleado = 0;
            int.TryParse(txtNoEmpleado.Text, out idempleado);
            decimal dsParteVaribleEmpleado = 0;

            dsParteVaribleEmpleado = AltaEmpleados.obtenerParteVariable(idempleado, dateFechaParaElCalculoSD.DateTime);
            txtParteVariable.Text = dsParteVaribleEmpleado.ToString("N2");
        }

        private void validarSBCvs25UMA()
        {
            Decimal dcSBC;
            dcSBC = txtSalarioBaseCotizacionContrato.Value;

            if (dcmUMA25 == dcSBC)
            {
                AvisoDe25UMAS.Icon = Properties.Resources.importante_16_1;
                AvisoDe25UMAS.SetError(txtSalarioBaseCotizacionContrato, "Limite de 25 UMAs " + dcmUMA.ToString("$0.##") + ".");
            }
            else
            {
                AvisoDe25UMAS.Clear();
            }
        }

        private void btnSolicitarTramiteIMSS_Click(object sender, EventArgs e)
        {
            //validar que exista un empleado activo
            if (txtNoEmpleado.Text.Length > 0)
            {
                //validar que el empleados tenga esquema S o M
                if (cboIdTipoMovimiento.Text.Equals("S") || cboIdTipoMovimiento.Text.Equals("M"))
                {
                    IMSS.frmxSolicitudTramiteIMSSOperaciones objSolicitudTramiteIMSS = new IMSS.frmxSolicitudTramiteIMSSOperaciones();

                    objSolicitudTramiteIMSS.txtNoEmpleado.Text = txtNoEmpleado.Text;
                    objSolicitudTramiteIMSS.txtNSS.Text = txtNSS.Text;
                    objSolicitudTramiteIMSS.txtNombreEmpleado.Text = txtNombreEmpleado.Text;
                    objSolicitudTramiteIMSS.txtAPaternoEmpleado.Text = txtAPaternoEmpleado.Text;
                    objSolicitudTramiteIMSS.txtAMaternoEmpleado.Text = txtAMaternoEmpleado.Text;

                    objSolicitudTramiteIMSS.ShowDialog();   //mostrar pantalla
                }
                else
                    XtraMessageBox.Show("Para realizar una Solicitud debe seleccionar\nun empleado con Tipo de Esquema S o M.", "Información requerida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                XtraMessageBox.Show("¡Debe visualizar la información del Empleado \npara realizar una Solicitud!", "Información requerida", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void cboIdEstatus_EditValueChanged(object sender, EventArgs e)
        {
            //modificar comportamiento de propiedad Text en base al tipo de Estatus del Empleado
            switch (Convert.ToInt16(cboIdEstatus.EditValue))
            {
                case 1:         //1=N/D, 7=ALTA
                case 7:
                    lblFechaIngresoReingreso.Location = new Point(195, 36);
                    lblFechaIngresoReingreso.Text = "Fecha de Ingreso";
                    //calFechaBajaContrato.EditValue = new DateTime(1900, 1, 1);
                    break;

                case 8:          //8=BAJA
                    //calFechaBajaContrato.EditValue = DateTime.Now.ToShortDateString();      //asignar fecha actual
                    break;

                case 9:         //9=REINGRESO
                    lblFechaIngresoReingreso.Location = new Point(185, 36);
                    lblFechaIngresoReingreso.Text = "Fecha de Reingreso";
                    //calFechaIngresoReingresoContrato.EditValue = DateTime.Now.ToShortDateString();       //asignar fecha actual
                    break;
            }
        }

        //Varibles para almacenar nombre del empleado al consultar empleados
        String stEmpleadoAPaterno = String.Empty;
        String stEmpleadoAMaterno = String.Empty;
        String stEmpleadoNombre = String.Empty;

        int conDomentacion = 0;



        private void mostarInformacionEmpleado()
        {
            //toolBtnSubirDocumentos.Enabled = false;
            btnSubirDocumentacion.Enabled = false;

            if (cboIdEmpleado.Text != "0")
            {
                if (Convert.ToInt32(cboIdEmpleado.EditValue) < 0)  //si el No. de empleado es menor a 10,000
                {
                    XtraMessageBox.Show("No ha escrito un No. de Empleado válido.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    cboIdEmpleado.Focus();        //colocar cursor en control
                }
                else
                {
                    //cargar informacion detalla del Empleado CFDI
                    DataTable dt = this.stpSelObtenerInfoEmpleadoModificacionCFDITableAdapter1.GetData(Convert.ToInt32(cboIdEmpleado.EditValue));

                    //Asignar información detallada del Empleado CFDI al Objeto Empleado
                    objEmp = EmpleadoBD.ObtenerInfoEmpleadoModificacionCFDI(dt);

                    if (objEmp != null)
                    {
                        LimpiarControles();
                        MostrarInfoEmpleado(objEmp);        //mostrar informacion del Empleado
                        MostrarInfoDireccionEmpleado(objEmp);     //mostrar informacion de los Domicilios
                        MostrarInfoContratoEmpleado(objEmp);
                        txtEditEdad.Text = objEmp.Edad.ToString();
                        //txtEditEdad.Text = obtenerCURP(objEmp.CURP);
                        conDomentacion = objEmp.ConDocumentacion;
                        MostrarBotonesDocumentacion(conDomentacion);
                        obtenerHistorialDeExpedienteContrato(objEmp.IdEmpleado);

                        cITToolStripMenuItem.Enabled = true;
                        btnExportarExcel.Enabled = true;

                        ObtenerFechaCalculoSD();
                        ObtenerValorUMA();

                        if (!banAltaEmpleados)
                        {
                            toolStripDropDownButton2.Enabled = true;
                            consultarToolStripMenuItem.Enabled = true;
                            autorizarToolStripMenuItem.Enabled = true;
                        }
                        else { toolStripDropDownButton2.Enabled = false; }

                        //asignar el NSS Original
                        strNSSOriginal = txtNSS.Text;
                        strRFCOriginal = txtRFC.Text;
                        strCURPOriginal = txtCURP.Text;
                    }
                    else
                    {
                        if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                        LimpiarControles();     //limpiar controles
                        cITToolStripMenuItem.Enabled = false;
                        consultarToolStripMenuItem.Enabled = false;
                        autorizarToolStripMenuItem.Enabled = false;
                        XtraMessageBox.Show("No existe el empleado solicitado.", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cboIdEmpleado.Focus();        //colocar cursor en control
                        btnExportarExcel.Enabled = false;
                    }
                }
            }

            if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
        }

        private void MostrarBotonesDocumentacion(int conDocumentacion)
        {
            //toolBtnSubirDocumentos.Enabled = true;
            btnSubirDocumentacion.Enabled = true;

            if (conDocumentacion == 1)
            {
                //btnDescargarDocumentacion.Enabled = true;
                documentaciónToolStripMenuItem.Enabled = true;
            }
            else
            {
                documentaciónToolStripMenuItem.Enabled = false;
            }
        }

        private void cboIdEmpleado_EditValueChanged(object sender, EventArgs e)
        {
            mostarInformacionEmpleado();
            inicializarVariablesDeBotones();
            ActivarBotones(true);
            estatusBoton = EstatusBotones.Ninguno;    //asignar accion NINGUNO
            ActivarControles(false, tipoPerfil);     //bloqueo de controles permitidos
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();        //cerrar pantalla
        }

        private void lueTipoIdentificacion_EditValueChanged(object sender, EventArgs e)
        {
            String stValor = String.Empty;
            stValor = lueTipoIdentificacion.Text;

            DataRow[] unRow = dtTipoIdentificacion.Select("[TipoIdentificacionNombre] = '" + stValor + "'");
            if (unRow.Count() > 0)
            {
                txtEditAutoridadExpide.Text = unRow[0].ItemArray[2].ToString();
            }
        }

        /// <summary>
        /// Obtener Fecha de nacimiento apartir del CURP
        /// </summary>
        /// <param name="stCURP"></param>
        public String obtenerCURP(String stCURP)
        {
            String stAniosCumplidos = String.Empty;

            try
            {
                stAniosCumplidos = stpSelEstatusNominaContabilizadaTableAdapter1.ObtenerEdadEmpleado(stCURP).ToString();
            }
            catch (Exception ex)
            {
                DateTime dtFechaNacimiento = dsc.ObtenerFechaNacimiento(stCURP);
                stAniosCumplidos = (DateTime.Now.Year - dtFechaNacimiento.Year).ToString();
            }

            return stAniosCumplidos;
        }

        private void insUpdDatosContrato()
        {
            try
            {
                int? iTaMuyBien = 0;
                int iEmpleado = 0;
                int iTipoIdentificacion = 0;
                String stNumeroIdentificacion = String.Empty;
                DateTime dtimeVigenciaContrato = new DateTime();
                String stIdPlan = String.Empty;
                String stVacaciones = String.Empty;
                String stPrimavacional = String.Empty;
                String stAguinaldo = String.Empty;
                String stConceptoContratacion = String.Empty;
                String stHerramientasTrabajo = String.Empty;
                String stInformacionConfidencial = String.Empty;
                String stUsuario = String.Empty;

                int.TryParse(txtNoEmpleado.Text, out iEmpleado);
                int.TryParse(lueTipoIdentificacion.EditValue.ToString(), out iTipoIdentificacion);
                stNumeroIdentificacion = txtEditNumeroIdentificacion.Text;
                dtimeVigenciaContrato = dteditVigenciaContrato.DateTime;
                stIdPlan = txtEditIdPlan.Text;
                stVacaciones = seVacaciones.Text;
                stPrimavacional = sePrimaVacacional.Text;
                stAguinaldo = seAguinaldo.Text;
                stConceptoContratacion = mmContratacion.Text;
                stHerramientasTrabajo = mmHerramientas.Text;
                stInformacionConfidencial = mmConfidencial.Text;
                stUsuario = OperadorBD.OperadorGlobal.NombreUsuario;

                DateTime FechaVigenciaContrato;
                DateTime.TryParse(dtimeVigenciaContrato.ToShortDateString(), out FechaVigenciaContrato);
                if (FechaVigenciaContrato.ToShortDateString().Contains("01/01/0001"))
                {
                    FechaVigenciaContrato = new DateTime(1900, 01, 01);
                }

                if (iEmpleado > 0)
                {
                    queriesTableAdapter1.stpUpdContratoEmpleado(iEmpleado,
                        iTipoIdentificacion,
                        stNumeroIdentificacion,
                        FechaVigenciaContrato,
                        stVacaciones,
                        stPrimavacional,
                        stAguinaldo,
                        stConceptoContratacion,
                        stHerramientasTrabajo,
                        stInformacionConfidencial,
                        stUsuario,
                        ref iTaMuyBien);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hubo un error al intentar subir los datos de Contrato del Empleado." + Environment.NewLine + ex
                        , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Actualizar datos de empleado cuando hay rechazo por parte del IMSS
        /// </summary>
        private void UpdateDatosEmpleadoIMSS()
        {
            try
            {
                int idEmpleado;
                int.TryParse(txtNoEmpleado.Text, out idEmpleado);

                if (idEmpleado > 0)
                {
                    queriesTableAdapter1.stpUpdInfoEmpleadoIMSS(
                        txtNombreEmpleado.Text.ToUpper(),
                        txtAPaternoEmpleado.Text.ToUpper(),
                        txtAMaternoEmpleado.Text.ToUpper(),
                        idEmpleado
                        );
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("No se puede actualizar informacion del Empleado en la tabla del IMSS." + Environment.NewLine + ex
                       , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolBtnSubirDocumentos_Click(object sender, EventArgs e)
        {
            Boolean banderaRemplezar = true;

            if (conDomentacion == 1)
            {
                DialogResult resul = XtraMessageBox.Show("Ya existe un documento para " + txtAPaternoEmpleado.Text + " " + txtAMaternoEmpleado.Text + " " + txtNombreEmpleado.Text + ", ¿Desea Remplazarlo?"
        , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resul == DialogResult.Yes)
                {
                    banderaRemplezar = true;
                }
                else
                {
                    banderaRemplezar = false;
                }
            }

            if (banderaRemplezar)
            {
                XtraMessageBox.Show("Por favor seleccione el Documento del Empleado."
              , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                String stRutaContrato = String.Empty;
                String StValorDocumento = String.Empty;
                OpenFileDialog ofdSelecFile = new OpenFileDialog();
                ofdSelecFile.Filter = "Pdf Files| *.pdf";
                ofdSelecFile.Title = "SAIC | Seleccione Documento";
                ofdSelecFile.Multiselect = false;
                ofdSelecFile.ShowDialog();
                stRutaContrato = ofdSelecFile.FileName;

                FileInfo miArchivo = new FileInfo(stRutaContrato);

                try
                {
                    stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "LIMITEARCHIVO");
                    if (dbSAICBPOValidacionDataSet1.stpSelParametro.Rows.Count > 0)
                    {
                        int iValorLimiteArchivos;
                        int.TryParse(dbSAICBPOValidacionDataSet1.stpSelParametro.Rows[0]["ValorParametro"].ToString(), out iValorLimiteArchivos);
                        if (miArchivo.Length <= iValorLimiteArchivos)
                        {
                            splashSMCargando.ShowWaitForm();
                            splashSMCargando.SetWaitFormCaption("Subiendo Documento");

                            StValorDocumento = dsc.ConvertToBytes(stRutaContrato);

                            queriesTableAdapter1.stpInsDocumentoEmpleados(
                                                  Convert.ToInt32(txtNoEmpleado.Text),
                                                  StValorDocumento,
                                                  "pdf",
                                                  1,
                                                  OperadorBD.OperadorGlobal.NombreUsuario
                                                  );

                            splashSMCargando.CloseWaitForm();
                            XtraMessageBox.Show("Documento del empelado " + txtAPaternoEmpleado.Text + " " + txtAMaternoEmpleado.Text + " " + txtNombreEmpleado.Text + ", Subido con Exito"
                           , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            mostarInformacionEmpleado();
                        }
                        else
                        {
                            XtraMessageBox.Show("Archivo del Empleado: " + txtNoEmpleado.Text + ", Su tamaño no puede exceder de " + iValorLimiteArchivos + " KB"
                             , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        DialogResult resultado = XtraMessageBox.Show("No se tiene valor de limite para archivos."
                   , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                catch (Exception ex)
                {
                    splashSMCargando.CloseWaitForm();
                    XtraMessageBox.Show("Archivo del Empleado: " + txtNoEmpleado.Text + ", No se puede subir." + Environment.NewLine + ex.Message
                  , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDescargarDocumentacion_Click(object sender, EventArgs e)
        {
            String stMensaje = String.Empty;
            try
            {
                splashSMCargando.ShowWaitForm();
                splashSMCargando.SetWaitFormCaption("Descargando Documento");
                splashSMCargando.SetWaitFormDescription("Empleado: " + txtAPaternoEmpleado.Text + " " + txtAMaternoEmpleado.Text + " " + txtNombreEmpleado.Text);
                stpSelDocumentoEmpleadoTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelDocumentoEmpleado, Convert.ToInt32(txtNoEmpleado.Text));

                String stRutaEmpleado = dsc.stRutaSAIC + @"Empleados\" + txtNoEmpleado.Text + @"\";
                dsc.CheckandCreateFolder(stRutaEmpleado);

                if (dbSAICBPOCatalogosDataSet1.stpSelDocumentoEmpleado.Rows.Count > 0)
                {
                    //Creando Carpeta por Empleado
                    foreach (DataRow unRow in dbSAICBPOCatalogosDataSet1.stpSelDocumentoEmpleado.Rows)
                    {
                        String stNombreEmpleado = unRow["NombreEmpleadoCompleto"].ToString();
                        stNombreEmpleado = stNombreEmpleado.Replace("\\", "").Replace("/", "").Replace(":", "").Replace("+", "").Replace("?", "").Replace("\"", "").Replace("<", "").Replace(">", "").Replace("|", "");
                        dsc.ConvertToFile(unRow["DesDocumento"].ToString(), stRutaEmpleado + unRow["DesTipoDocumento"].ToString() + " " + stNombreEmpleado + ".pdf");
                    }

                    stMensaje = "Documento Descargado con Exito." + Environment.NewLine + "Ruta de Descarga:" + stRutaEmpleado;
                }
                else
                {
                    stMensaje = "No se encuentra el documento del empleado: " + txtAPaternoEmpleado.Text + " " + txtAMaternoEmpleado.Text + " " + txtNombreEmpleado.Text;
                }

            }
            catch (Exception ex)
            {
                stMensaje = "No se puede descargar el documento de " + txtAPaternoEmpleado.Text + " " + txtAMaternoEmpleado.Text + " " + txtNombreEmpleado.Text + Environment.NewLine + ex.Message;
            }
            finally
            {
                splashSMCargando.CloseWaitForm();
            }

            XtraMessageBox.Show(stMensaje
              , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void stpSelNominaCFDIBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void cboIdTipoMovimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (banAltaEmpleados)
            //{
            //    DialogResult resultado = XtraMessageBox.Show("Esta accion modificara el Esquema del Empleado. ¿Desea Continuar?"
            //  , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //    if (DialogResult.Yes == resultado)
            //    {
            //        GuardarInformacionEmpleado();
            //        if (cboIdTipoMovimiento.Text == "A")
            //        {

            //        }
            //    }
            //}
        }

        private void cboIdFormaPago_EditValueChanged(object sender, EventArgs e)
        {
            if (banAltaEmpleados)
            {
                if (cboIdFormaPago.Text == "CHEQUE")
                {
                    DialogResult resultado = XtraMessageBox.Show("Esta accion modificara el tipo de pago a CHEQUE. Atendiendo al Empleado en el area de Tesoreria de la Solicitud " + idSolicitud + ". ¿Desea Continuar?"
                  , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (DialogResult.Yes == resultado)
                    {
                        GuardarInformacionEmpleado();
                        queriesTableAdapter1.stpUpdEstatusSolicitudAlta(2, idSolicitud, iIdEmpleado, OperadorBD.OperadorGlobal.NombreOperador, OperadorBD.OperadorGlobal.NombreUsuario, DateTime.Now);
                        queriesTableAdapter1.stpUpdEstatusSolicitudAlta(3, idSolicitud, iIdEmpleado, OperadorBD.OperadorGlobal.NombreOperador, OperadorBD.OperadorGlobal.NombreUsuario, DateTime.Now);
                        queriesTableAdapter1.stpUpdSolicitudEmpleadoRespuestaRechazo(idSolicitud, false, false, true, OperadorBD.OperadorGlobal.NombreUsuario);

                        XtraMessageBox.Show("La información del Empleado se actualizó satisfactoriamente."
                 , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        cboIdFormaPago.EditValue = bIdFormaPago;
                    }
                }
            }
        }

        /// <summary>
        /// Validar la fecha de contrato para calcular la vigencia de contrato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calFechaIngresoReingresoContrato_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTiempoContrato_EditValueChanged(object sender, EventArgs e)
        {
            validarFechaVigenciaContrato();
        }

        private void validarFechaVigenciaContrato()
        {
            if (estatusBoton.ToString() == "Editar")
            {
                if (cboIdTipoContrato.Text == "DETERMINADO" || cboIdTipoContrato.Text == "OBRA")
                {
                    int iNumDias;
                    int.TryParse(txtTiempoContrato.Text, out iNumDias);

                    if (iNumDias == 0) { iNumDias = 1; }

                    dteditVigenciaContrato.EditValue = deteInicioContrato.DateTime.AddDays(iNumDias - 1);
                }
                else if (cboIdTipoContrato.Text == "INDETERMINADO")
                {
                    txtTiempoContrato.Text = "0";
                    dteditVigenciaContrato.DateTime = new DateTime(1900, 01, 01);
                }
            }
        }


        public void exportarInformacionEmpleadoAExcel(int idEmpleado, Empleado objEmp)
        {
            try
            {
                stpSelInformacionAltaEmpleadosTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelInformacionAltaEmpleados, idEmpleado, -1);
                if (dbSAICBPOCatalogosDataSet1.stpSelInformacionAltaEmpleados.Rows.Count > 0)
                {
                    DataTable dtInformacionEmpleado = dbSAICBPOCatalogosDataSet1.stpSelInformacionAltaEmpleados.Clone();
                    dtInformacionEmpleado = dbSAICBPOCatalogosDataSet1.stpSelInformacionAltaEmpleados;

                    if (dtInformacionEmpleado.Columns.IndexOf("Razon Social Tenedora SA") == -1) { dtInformacionEmpleado.Columns.Add("Razon Social Tenedora SA"); }
                    if (dtInformacionEmpleado.Columns.IndexOf("Registro Patronal") == -1) { dtInformacionEmpleado.Columns.Add("Registro Patronal"); }
                    if (dtInformacionEmpleado.Columns.IndexOf("Razon Social Excedente") == -1) { dtInformacionEmpleado.Columns.Add("Razon Social Excedente"); }
                    if (dtInformacionEmpleado.Columns.IndexOf("IdCliente") == -1) { dtInformacionEmpleado.Columns.Add("IdCliente"); }
                    if (dtInformacionEmpleado.Columns.IndexOf("Razon Social Cliente") == -1) { dtInformacionEmpleado.Columns.Add("Razon Social Cliente"); }

                    //dtInformacionEmpleado.Columns.Add("Razon Social Tenedora SA");
                    //dtInformacionEmpleado.Columns.Add("Registro Patronal");
                    //dtInformacionEmpleado.Columns.Add("Razon Social Excedente");
                    //dtInformacionEmpleado.Columns.Add("IdCliente");
                    //dtInformacionEmpleado.Columns.Add("Razon Social Cliente");

                    dtInformacionEmpleado.Columns["Razon Social Tenedora SA"].Expression = "'" + objEmp.TenedoraSA + "'";
                    dtInformacionEmpleado.Columns["Registro Patronal"].Expression = "";
                    dtInformacionEmpleado.Columns["Razon Social Excedente"].Expression = "'" + objEmp.TenedoraSC + "'";
                    dtInformacionEmpleado.Columns["Razon Social Cliente"].Expression = "'" + objEmp.RazonSocialCliente + "'";
                    dtInformacionEmpleado.Columns["IdCliente"].Expression = "'" + objEmp.IdCliente + "'";

                    dsc.ExportarDatosExcel(dtInformacionEmpleado, "Info Empleado " + idEmpleado.ToString());

                }
                else
                {
                    XtraMessageBox.Show("No se encuentra Información del Empleado en SAIC."
                     , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("error al Consultar informacion del Empleado." + Environment.NewLine + ex.Message
                   , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void documentaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splashSMCargando.ShowWaitForm();
            splashSMCargando.SetWaitFormCaption("Descargando Documento");
            splashSMCargando.SetWaitFormDescription("Empleado: " + txtAPaternoEmpleado.Text + " " + txtAMaternoEmpleado.Text + " " + txtNombreEmpleado.Text);

            String stMensaje = String.Empty;
            String stRutaDescarga = String.Empty;

            stRutaDescarga = dsc.stRutaEmpleados + txtNoEmpleado.Text + @"\";
            dsc.CheckandCreateFolder(stRutaDescarga);
            DataTable dt = this.stpSelObtenerInfoEmpleadoModificacionCFDITableAdapter1.GetData(Convert.ToInt32(cboIdEmpleado.EditValue));
            Empleado objEmp = EmpleadoBD.ObtenerInfoEmpleadoModificacionCFDI(dt);

            OperadoresM.XtraMonitoreoSolicitudesOperaciones Monitoreo = new OperadoresM.XtraMonitoreoSolicitudesOperaciones(0);
            stMensaje = Monitoreo.descargarDocumentacionEmpleado(objEmp, stRutaDescarga);


            if (splashSMCargando.IsSplashFormVisible) { splashSMCargando.CloseWaitForm(); }

            XtraMessageBox.Show(stMensaje
              , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnExportarExcel_Click_1(object sender, EventArgs e)
        {
            exportarInformacionEmpleadoAExcel(Convert.ToInt32(cboIdEmpleado.EditValue), objEmp);
        }

        private void cITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Juridico.XtraHistorialDeContratosEmpleado oXtraHistorialDeContratosEmpleado = new Juridico.XtraHistorialDeContratosEmpleado(objEmp);
            oXtraHistorialDeContratosEmpleado.ShowDialog();
        }

        public void descargarContratoActivo(String stNombreEmpleado, int idempleado, int idContratosEmpleado)
        {
            try
            {
                splashSMCargando.ShowWaitForm();
                splashSMCargando.SetWaitFormCaption("Descargando Contrato");
                tools.dsc oDsc = new tools.dsc();

                String stRutaEmpleado_1 = oDsc.stRutaEmpleados + idempleado.ToString() + @"\";
                int idEmpleado = 0;
                int.TryParse(idempleado.ToString(), out idEmpleado);

                stpSelConsultaContratoEmpleado_2022TableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelConsultaContratoEmpleado_2022, idEmpleado, idContratosEmpleado);

                //OperadoresM.XtraMonitoreoSolicitudesOperaciones OperacionesMonitoreo = new OperadoresM.XtraMonitoreoSolicitudesOperaciones();
                //stpSelConsultaContratoEmpleadoTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelConsultaContratoEmpleado, idEmpleado);
                //if (dbSAICBPOCatalogosDataSet1.stpSelConsultaContratoEmpleado.Rows.Count > 0)
                if (dbSAICBPOCatalogosDataSet1.stpSelConsultaContratoEmpleado_2022.Rows.Count > 0)
                {
                    if (dbSAICBPOCatalogosDataSet1.stpSelConsultaContratoEmpleado_2022.Rows.Count == 1)
                    {
                        Boolean flagContratoGenerico = false;
                        dsc.CheckandCreateFolder(stRutaEmpleado_1);
                        String sNombreCit = stRutaEmpleado_1 +
                                          stNombreEmpleado + " " + dsc.nombreAleatorio() +
                                          ".pdf";

                        flagContratoGenerico = dbSAICBPOCatalogosDataSet1.stpSelConsultaContratoEmpleado_2022.Rows[0]["TipoDocumentoContrato"].ToString() == "HTML" ? true : false;

                        Juridico.Reportes.CIT_PPP myReport = new Juridico.Reportes.CIT_PPP();
                        myReport.Parameters["flagConGenerico"].Value = flagContratoGenerico;
                        myReport.Parameters["tipoConsulta"].Value = 1;
                        //myReport.Parameters["ResultadoHTML"].Value = dbSAICBPOCatalogosDataSet1.stpSelConsultaContratoEmpleado.Rows[0]["Contrato"].ToString();
                        myReport.Parameters["ResultadoHTML"].Value = dbSAICBPOCatalogosDataSet1.stpSelConsultaContratoEmpleado_2022.Rows[0]["Contrato"].ToString();
                        myReport.ExportToPdf(sNombreCit);

                        if (flagContratoGenerico)
                        {
                            //descargar contrato de confidencialidad
                            Solicitud miSolicitud = new Solicitud();
                            Juridico.XtraEmpleadosXSolicitudJuridico juridico = new Juridico.XtraEmpleadosXSolicitudJuridico(miSolicitud);
                            juridico.DescargarContratoConficialidad(stRutaEmpleado_1, idEmpleado, stNombreEmpleado);
                        }

                        if (splashSMCargando.IsSplashFormVisible) { splashSMCargando.CloseWaitForm(); }

                        XtraMessageBox.Show("Contrato Descargado." + Environment.NewLine + stRutaEmpleado_1
                            , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        XtraMessageBox.Show("El empleado cuenta con mas de un contrato activado"
                           , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    if (splashSMCargando.IsSplashFormVisible) { splashSMCargando.CloseWaitForm(); }
                    XtraMessageBox.Show("El Empleado no tiene Contrato Autorizado."
                         , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                if (splashSMCargando.IsSplashFormVisible) { splashSMCargando.CloseWaitForm(); }
                XtraMessageBox.Show("Error al Descargar Contrato." + Environment.NewLine + ex.Message
                         , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnGuardar.Enabled)
                {
                    XtraMessageBox.Show("Para Generar el Contrato es necesario guardar la información del Empleado."
                     , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Boolean flagEstaMuyBien = false;

                    if (cboIdTipoMovimiento.Text == "A" || cboIdTipoMovimiento.Text == "P")
                    {
                        if (Validator.IsPresent(txtNombreEmpleado) &&
                       Validator.IsPresent(txtAPaternoEmpleado) &&
                       Validator.IsPresent(txtRFC) &&
                       Validator.IsPresent(txtCURP) &&
                       Validator.IsValidRFC(txtRFC, "El RFC", Validator.PatternRFC_COMODIN, Validator.PatternRFC) &&
                       Validator.IsValidCURP(txtCURP, "El CURP", Validator.PatternCURP) &&
                       Validator.IsDecimal(txtSalarioDiarioIntegradoContrato) &&
                       Validator.IsPositiveNumber(cboIdCliente) &&
                       Validator.IsPositiveNumber(cboIdTenedoraSA) &&
                       //IsValidDate(calFechaIngresoReingresoContrato)
                       validarFecha(calFechaIngresoReingresoContrato.DateTime))
                        {
                            flagEstaMuyBien = true;
                        }
                    }
                    else if (cboIdTipoMovimiento.Text == "M" || cboIdTipoMovimiento.Text == "S")
                    {
                        if (Validator.IsPresent(txtNombreEmpleado) &&
                        Validator.IsPresent(txtAPaternoEmpleado) &&
                        Validator.IsPresent(txtNSS) &&
                        Validator.IsPresent(txtRFC) &&
                        Validator.IsPresent(txtCURP) &&
                        Validator.IsValidNSS(txtNSS, "El NSS", Validator.PatternNNS) &&
                        Validator.IsValidRFC(txtRFC, "El RFC", Validator.PatternRFC_COMODIN, Validator.PatternRFC) &&
                        Validator.IsValidCURP(txtCURP, "El CURP", Validator.PatternCURP) &&
                        Validator.IsDecimal(txtSalarioDiarioContrato) &&
                        Validator.IsDecimal(txtSalarioBaseCotizacionContrato) &&
                        Validator.IsDecimal(txtSalarioDiarioIntegradoContrato) &&
                        Validator.IsPositiveNumber(txtSalarioDiarioContrato) &&
                        Validator.IsPositiveNumber(txtSalarioBaseCotizacionContrato) &&
                        Validator.IsPositiveNumber(txtSalarioDiarioIntegradoContrato) &&
                        Validator.IsPositiveNumber(cboIdCliente) &&
                        Validator.IsPositiveNumber(cboIdTenedoraSA) &&
                        //IsValidDate(calFechaIngresoReingresoContrato)
                        validarFecha(calFechaIngresoReingresoContrato.DateTime))
                        {
                            flagEstaMuyBien = true;
                        }
                    }

                    if (flagEstaMuyBien)
                    {
                        ContratoEmpleado(1, objEmp);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("No se puede descargar el Contrato del Empleado." + Environment.NewLine + ex.Message
                                    , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ContratoEmpleado(int iTipoAccion, Empleado objEmp)
        {
            Boolean flagContratoGenerico = true;
            Boolean flagContratoActivado = false;
            stpSelObtenerInfoContratosTenedorasTableAdapter1.Fill(dataSetJuridico1.stpSelObtenerInfoContratosTenedoras, objEmp.IdEmpleado, 0, objEmp.IdTipoContrato);

            if (dataSetJuridico1.stpSelObtenerInfoContratosTenedoras.Rows.Count > 0)
            {
                Boolean.TryParse(dataSetJuridico1.stpSelObtenerInfoContratosTenedoras.Rows[0]["ContratoGenerico"].ToString(), out flagContratoGenerico);
                Boolean.TryParse(dataSetJuridico1.stpSelObtenerInfoContratosTenedoras.Rows[0]["ContratoActivado"].ToString(), out flagContratoActivado);
            }

            if (flagContratoGenerico)
            {
                int idmatrizTenedora = 0;
                DataTable dt = this.stpSelObtenerInfoEmpleadoModificacionCFDITableAdapter1.GetData(Convert.ToInt32(cboIdEmpleado.EditValue));
                //Empleado objEmp = EmpleadoBD.ObtenerInfoEmpleadoModificacionCFDI(dt);
                stpSelObtenerMatriztenedoraVsTenedoraTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelObtenerMatriztenedoraVsTenedora, objEmp.IdTenedoraSA);

                if (dbSAICBPOCatalogosDataSet1.stpSelObtenerMatriztenedoraVsTenedora.Rows.Count > 0)
                {
                    int.TryParse(dbSAICBPOCatalogosDataSet1.stpSelObtenerMatriztenedoraVsTenedora.Rows[0]["IdMatrizTenedora"].ToString(), out idmatrizTenedora);

                    stpSelCITFirmantesTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelCITFirmantes, idmatrizTenedora);
                    if (dbSAICBPOCatalogosDataSet1.stpSelCITFirmantes.Rows.Count > 0)
                    {
                        OperadoresM.Solicitud miSolicitud = new OperadoresM.Solicitud();
                        miSolicitud.idMatrizTenedora = idmatrizTenedora;
                        miSolicitud.TenedoraSA = objEmp.TenedoraSA;
                        miSolicitud.sRutaSolicitud = stRutaEmpleados + objEmp.IdEmpleado + @"\";

                        //DataTable dtEmpleasosSeleccionados = dsc.deGridViewSelectedToDataTable(gridViewEmpleados);
                        Juridico.XtraDatosContrato datosContrato = new Juridico.XtraDatosContrato(miSolicitud, dt, iTipoAccion);
                        datosContrato.ShowDialog();
                    }
                    else
                    {
                        XtraMessageBox.Show("La Empresa: " + cboIdTenedoraSA.Text + ", No tiene Firmante. Por favor Agrege un Firmante a la Empresa para Continuar."
                             , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else if (flagContratoActivado)
            {
                if (iTipoAccion == 1)// visualizar Contrato
                {
                    Juridico.XtraContratos oXtraContratos = new Juridico.XtraContratos();
                    oXtraContratos.VisualizarContrato(0, objEmp.IdEmpleado, 1, String.Empty);
                }
            }
            else
            {
                XtraMessageBox.Show(" La Tenedora " + cboIdTenedoraSA.Text + ", No tiene contrato Activado."
                             , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAbrirCarpeta_Click(object sender, EventArgs e)
        {
            String stRutaSolicitud = stRutaEmpleados + cboIdEmpleado.EditValue + @"\";
            if (String.IsNullOrEmpty(cboIdEmpleado.EditValue.ToString())) { stRutaSolicitud = stRutaEmpleados; }

            dsc.CheckandCreateFolder(stRutaSolicitud);
            Process.Start(stRutaSolicitud);
        }

        private void autorizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult drResultado = XtraMessageBox.Show("¿Desea Autorizar el Contrato para el Empleado " + cboIdEmpleado.Text + "?"
           , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes == drResultado)
            {
                Boolean flagContratoGenerico = true;
                Boolean flagContratoActivado = false;

                stpSelObtenerInfoContratosTenedorasTableAdapter1.Fill(dataSetJuridico1.stpSelObtenerInfoContratosTenedoras, objEmp.IdEmpleado, 0, objEmp.IdTipoContrato);

                if (dataSetJuridico1.stpSelObtenerInfoContratosTenedoras.Rows.Count > 0)
                {
                    Boolean.TryParse(dataSetJuridico1.stpSelObtenerInfoContratosTenedoras.Rows[0]["ContratoGenerico"].ToString(), out flagContratoGenerico);
                    Boolean.TryParse(dataSetJuridico1.stpSelObtenerInfoContratosTenedoras.Rows[0]["ContratoActivado"].ToString(), out flagContratoActivado);
                }

                if (flagContratoGenerico)
                {
                    ContratoEmpleado(4, objEmp);
                }
                else if (flagContratoActivado)
                {
                    Juridico.XtraContratos oXtraContratos = new Juridico.XtraContratos();
                    oXtraContratos.VisualizarContrato(0, objEmp.IdEmpleado, 2, String.Empty);
                    XtraMessageBox.Show("Contrato Autorizado", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show(" La Tenedora " + cboIdTenedoraSA.Text + ", No tiene contrato Activado."
                            , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSubirDocumentacion_Click(object sender, EventArgs e)
        {
            Boolean banderaRemplezar = true;

            if (conDomentacion == 1)
            {
                DialogResult resul = XtraMessageBox.Show("Ya existe un documento para " + txtAPaternoEmpleado.Text + " " + txtAMaternoEmpleado.Text + " " + txtNombreEmpleado.Text + ", ¿Desea Remplazarlo?"
        , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resul == DialogResult.Yes)
                {
                    banderaRemplezar = true;
                }
                else
                {
                    banderaRemplezar = false;
                }
            }

            if (banderaRemplezar)
            {
                XtraMessageBox.Show("Por favor seleccione el Documento del Empleado."
              , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                String stRutaContrato = String.Empty;
                String StValorDocumento = String.Empty;
                OpenFileDialog ofdSelecFile = new OpenFileDialog();
                ofdSelecFile.Filter = "Pdf Files| *.pdf";
                ofdSelecFile.Title = "SAIC | Seleccione Documento";
                ofdSelecFile.Multiselect = false;
                ofdSelecFile.ShowDialog();
                stRutaContrato = ofdSelecFile.FileName;

                if (!String.IsNullOrEmpty(stRutaContrato))
                {
                    FileInfo miArchivo = new FileInfo(stRutaContrato);

                    try
                    {
                        stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "LIMITEARCHIVO");
                        if (dbSAICBPOValidacionDataSet1.stpSelParametro.Rows.Count > 0)
                        {
                            int iValorLimiteArchivos;
                            int.TryParse(dbSAICBPOValidacionDataSet1.stpSelParametro.Rows[0]["ValorParametro"].ToString(), out iValorLimiteArchivos);
                            if (miArchivo.Length <= iValorLimiteArchivos)
                            {
                                splashScreenManager1.ShowWaitForm();
                                splashScreenManager1.SetWaitFormCaption("Subiendo Documento");

                                StValorDocumento = dsc.ConvertToBytes(stRutaContrato);

                                queriesTableAdapter1.stpInsDocumentoEmpleados(
                                                      Convert.ToInt32(txtNoEmpleado.Text),
                                                      StValorDocumento,
                                                      "pdf",
                                                      1,
                                                      OperadorBD.OperadorGlobal.NombreUsuario
                                                      );

                                splashScreenManager1.CloseWaitForm();
                                XtraMessageBox.Show("Documento del empelado " + txtAPaternoEmpleado.Text + " " + txtAMaternoEmpleado.Text + " " + txtNombreEmpleado.Text + ", Subido con Exito"
                               , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                mostarInformacionEmpleado();
                            }
                            else
                            {
                                XtraMessageBox.Show("Archivo del Empleado: " + txtNoEmpleado.Text + ", Su tamaño no puede exceder de " + iValorLimiteArchivos + " KB"
                                 , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            DialogResult resultado = XtraMessageBox.Show("No se tiene valor de limite para archivos."
                       , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                    catch (Exception ex)
                    {
                        splashScreenManager1.CloseWaitForm();
                        XtraMessageBox.Show("Archivo del Empleado: " + txtNoEmpleado.Text + ", No se puede subir." + Environment.NewLine + ex.Message
                      , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        /// <summary>
        /// Validar SD, SDI, Jornadas, Movimientos.
        /// </summary>
        /// <param name="dmSD"></param>
        /// <param name="dmSDI"></param>
        /// <param name="idTipoMovimiento"></param>
        /// <param name="JornadaServicio"></param>
        /// <param name="flagFronterizo"></param>
        /// <param name="dtFechaIngresoContrato"></param>
        /// <param name="stVacaciones"></param>
        /// <param name="stPrimaVacacional"></param>
        /// <param name="stAguinaldo"></param>
        /// <returns></returns>
        public Boolean validarSalariosEmpleadoContrato(Decimal dmSD, Decimal dmSBC, Decimal dmSDI, String idTipoMovimiento, String JornadaServicio, Boolean flagFronterizo, DateTime dtFechaIngresoContrato, String stVacaciones, String stPrimaVacacional, String stAguinaldo)
        {
            XtraAltaEmpleados AltaEmpleados = new XtraAltaEmpleados("");

            Boolean taMuyBien = true;
            String stMensajeError = String.Empty;

            Decimal SDGV;
            Decimal SDFI;
            Decimal dcmUMA;
            Decimal dcmUMA25;
            Decimal dcmFactorIntegracion = 0;
            //Decimal SDI

            dcmUMA = AltaEmpleados.obtenerUMA(dtFechaIngresoContrato);
            dcmUMA25 = dcmUMA * 25;

            if (idTipoMovimiento == "M" || idTipoMovimiento == "S")
            {
                //Obteniendo Salario diario vigente
                stpSelSMGVTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelSMGV, dtFechaIngresoContrato);
                if (dbSAICBPOCatalogosDataSet1.stpSelSMGV.Rows.Count > 0)
                {
                    decimal.TryParse(dbSAICBPOCatalogosDataSet1.stpSelSMGV.Rows[0]["Monto"].ToString(), out SDGV);
                    SDGV = decimal.Round(SDGV, 2);

                    stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "VALIDACION DE SD - MOV JURIDICO");
                    Boolean stValidacionSD = true;

                    if (dbSAICBPOValidacionDataSet1.stpSelParametro.Rows.Count > 0)
                    {
                        stValidacionSD = dbSAICBPOValidacionDataSet1.stpSelParametro.Rows[0]["ValorParametro"].ToString() == "NO" ? false : true;
                    }

                    if (stValidacionSD)
                    {
                        if (JornadaServicio.Contains("HORAS"))
                        {
                            if (dmSD <= 0)
                            {
                                stMensajeError += "-Salario Diario debe ser Mayor 0 (Cero) con un tipo de Jornada de Servicio por HORAS." + Environment.NewLine;
                                taMuyBien = false;
                            }

                            if (dmSBC > dcmUMA25)
                            {
                                stMensajeError += "-Salario Base de Cotización: Supera el calculo de 25 UMAs. (" + dcmUMA.ToString("#.##") + ")." + Environment.NewLine;
                                taMuyBien = false;
                            }

                            if (dmSDI < dmSBC)
                            {
                                stMensajeError += "-Salario Diario Integrado no puede ser menor que el Salarios Base de Cotizacion." + Environment.NewLine;
                                taMuyBien = false;
                            }
                        }
                        else
                        {
                            if (dmSD >= SDGV)
                            {

                                Boolean flagValidar = true;

                                if (dmSBC == dcmUMA25)
                                {
                                    flagValidar = true;
                                }
                                else
                                {
                                    flagValidar = false;
                                }

                                if (dmSBC <= dmSD && !flagValidar)
                                {
                                    stMensajeError += "-Salario Base de Cotización no puede ser igual o menor al Salario Diario (" + dmSD + ")." + Environment.NewLine;
                                    taMuyBien = false;
                                }

                                if (dmSBC > dcmUMA25 && !flagValidar)
                                {
                                    stMensajeError += "-Salario Base de Cotización: Supera el calculo de 25 UMAs. (" + dcmUMA.ToString("#.##") + ")." + Environment.NewLine;
                                    taMuyBien = false;
                                }

                                if (dmSDI <= dmSD && !flagValidar)
                                {
                                    stMensajeError += "-Salario Diario Integrado no puede ser igual o menor al Salario Diario (" + dmSD + ")." + Environment.NewLine;
                                    taMuyBien = false;
                                }

                                if (dmSDI < dmSBC)
                                {
                                    stMensajeError += "-Salario Diario Integrado no puede ser menor que el Salarios Base de Cotizacion." + Environment.NewLine;
                                    taMuyBien = false;
                                }
                            }
                            else
                            {
                                stMensajeError = "Salario Diario Contrato no puede ser Menor al SDGV(" + SDGV + ").";
                                taMuyBien = false;
                            }
                        }
                    }

                    else
                    {
                        stMensajeError = String.Empty;
                        taMuyBien = true;
                    }
                }
                else
                {
                    stMensajeError = "No se tiene SDGV, para la fecha de Ingreso Contrato del Empleado.";
                }
            }
            else if (idTipoMovimiento == "A")
            {
                if (dmSD != 0)
                {
                    stMensajeError = "Tipo de Esquema no permite Salarioa Diario.";
                    taMuyBien = false;
                }
                else if (dmSDI != 0)
                {
                    stMensajeError = "Tipo de Esquema no permite Salarioa Diario Integrado.";
                    taMuyBien = false;
                }
            }
            else
            {
                stMensajeError = "Tipo de Esquema no valido";
                taMuyBien = false;
            }


            if (!String.IsNullOrEmpty(stMensajeError))
            {
                XtraMessageBox.Show(stMensajeError, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                taMuyBien = false;
            }

            return taMuyBien;
        }

        private void toolBtnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gpcInformacionContrato_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deteInicioContrato_EditValueChanged(object sender, EventArgs e)
        {
            validarFechaVigenciaContrato();
        }

        private void dteditVigenciaContrato_EditValueChanged(object sender, EventArgs e)
        {
            txtTiempoContrato.Text = ((dteditVigenciaContrato.DateTime - deteInicioContrato.DateTime).Days + 1).ToString();
        }

        private void cboIdTipoContrato_EditValueChanged(object sender, EventArgs e)
        {
            validarFechaVigenciaContrato();
        }

        private void inicializarVariablesDeBotones()
        {
            flageHabilitarEsquema = false;
            flageHabilitarEstatusEmpleado = false;
            flageHabilitarCausabaja = false;
            flageHabilitarTenedoras = false;
            flageHabilitarCliente = false;
            flageHabilitarSalarios = false;
        }

        public Empleado ObtenerInfoEmpleado(int idEmpleado)
        {
            Empleado miEmpleado = null;
            try
            {
                DataTable dt = this.stpSelObtenerInfoEmpleadoModificacionCFDITableAdapter1.GetData(idEmpleado);
                miEmpleado = EmpleadoBD.ObtenerInfoEmpleadoModificacionCFDI(dt);

                DataTable dtDireccionEmpleado = this.stpSelObtenerInfoDireccionEmpleadoModificacionCFDITableAdapter1.GetData(idEmpleado);
                miEmpleado = MostrarInfoLINQDireccionEmpleado(dtDireccionEmpleado, miEmpleado);
            }
            catch (Exception) { }

            return miEmpleado;
        }

        private void btnAsignarNumeroDeExpediente_Click(object sender, EventArgs e)
        {
            try
            {
                String stNumeroDeExpedienteContrato = String.Empty;
                stpSelObtenerNumeroDeExpedienteContratoTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelObtenerNumeroDeExpedienteContrato, objEmp.IdTenedoraSA, objEmp.IdCliente, objEmp.IdEmpleado, compCatalogosSAIC.OperadorBD.OperadorGlobal.NombreUsuario, false, ref stNumeroDeExpedienteContrato);
                txtExpediente.Text = stNumeroDeExpedienteContrato;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("No se puede obtener el Numero de expediente."
                    + Environment.NewLine + ex.Message, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void obtenerHistorialDeExpedienteContrato(int idEmpleado)
        {
            stpObtenerHistorialExpedienteContratoEmpleadoTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpObtenerHistorialExpedienteContratoEmpleado, idEmpleado);
            if (dbSAICBPOCatalogosDataSet.stpObtenerHistorialExpedienteContratoEmpleado.Rows.Count > 0)
            {
                int idExpediente;
                int.TryParse(dbSAICBPOCatalogosDataSet.stpObtenerHistorialExpedienteContratoEmpleado.Rows[0]["idHistoricoExpedienteContrato"].ToString(), out idExpediente);
                //upEditHistoricoExpedientes.SelectedText = dbSAICBPOCatalogosDataSet.stpObtenerHistorialExpedienteContratoEmpleado.Rows[0]["ExpedienteContrato"].ToString();
                upEditHistoricoExpedientes.EditValue = idExpediente;
            }
        }

        private void cboIdTenedoraSA_EditValueChanged(object sender, EventArgs e)
        {
            int idTendora = 0;
            int.TryParse(cboIdTenedoraSA.EditValue.ToString(), out idTendora);

            stpSelObtenerInfoGenericaTenedoraSC_1TableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoGenericaTenedoraSC_1, idTendora, true);

            if (dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoGenericaTenedoraSC_1.Rows.Count > 0)
            {
                cboIdTenedoraSC.EditValue = dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoGenericaTenedoraSC_1.Rows[0]["IdTenedora"];
            }
        }

        private void txtCentroDeCosto1_EditValueChanged(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Obtener fecha para el calculo del SD.
        /// </summary>
        private void ObtenerFechaCalculoSD()
        {
            DateTime dtimeHoy = DateTime.Now;

            if (!banAltaEmpleados)
            {
                dtimeHoy = ObtenerFechaServidor();

                if (dtimeHoy.Date.ToShortDateString() == "01/01/1900" || dtimeHoy.Date.ToShortDateString() == "01/01/0001")
                {
                    dtimeHoy = DateTime.Now;
                }
            }
            else
            {
                dtimeHoy = calFechaIngresoReingresoContrato.DateTime;
            }

            dateFechaParaElCalculoSD.Text = dtimeHoy.Date.ToShortDateString();
        }

        int idEstadoDomicilioFiscal = 0;
        private void txtCodigoPostalFiscal_EditValueChanged(object sender, EventArgs e)
        {
            if (txtCodigoPostalFiscal.Text.Count() > 4)
            {
                String sResultado = String.Empty;
                String sDescEstadoFiscal = String.Empty;
                int? idEstado = 0;

                stpSelValidarCodigoPostalTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelValidarCodigoPostal,
                    txtCodigoPostalFiscal.Text,
                    ref idEstado,
                    ref sDescEstadoFiscal,
                    ref sResultado);

                if (!String.IsNullOrEmpty(sResultado))
                {
                    XtraMessageBox.Show(sResultado,
                    "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    idEstadoDomicilioFiscal = Convert.ToInt32(idEstado);
                    txtEstadoFiscal.Text = String.Empty;
                }
                else
                {
                    idEstadoDomicilioFiscal = Convert.ToInt32(idEstado);
                    txtEstadoFiscal.Text = sDescEstadoFiscal;
                }
            }
            else
            {
                txtEstadoFiscal.Text = String.Empty;
                idEstadoDomicilioFiscal = 0;
            }
        }
        private Boolean validarDireccionFiscal(int idEstadoDomicilioFiscal, String stEsquema)
        {
            Boolean flagEstaMuyBien = true;

            if (stEsquema == "S" || stEsquema == "M")
            {
                if (idEstadoDomicilioFiscal <= 0)
                {
                    XtraMessageBox.Show("Codigo Postal Direccion Fiscal es Obligatorio.",
                      "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigoPostalFiscal.Focus();
                    flagEstaMuyBien = false;
                }
            }
            else
            {
                if (!String.IsNullOrEmpty(txtCodigoPostalFiscal.Text))
                {
                    if (idEstadoDomicilioFiscal <= 0)
                    {
                        XtraMessageBox.Show("Codigo Postal Direccion Fiscal Incorrecto.",
                       "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCodigoPostalFiscal.Focus();
                        flagEstaMuyBien = false;
                    }
                }
            }

            return flagEstaMuyBien;
        }



        private Boolean valFechasParaCIT()
        {
            Boolean flagTaMuyBien = true;

            if (cboIdTipoContrato.Text == "DETERMINADO" || cboIdTipoContrato.Text == "OBRA")
            {
                if (deteInicioContrato.DateTime.Date < calFechaIngresoReingresoContrato.DateTime.Date)
                {
                    XtraMessageBox.Show("Fecha Inicio Contrato CIT: NO puede ser menor a la Fecha Ingreso Contrato",
                    "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //deteInicioContrato.Focus();
                    flagTaMuyBien = false;
                }
                else if (dteditVigenciaContrato.DateTime.Date < calFechaIngresoReingresoContrato.DateTime.Date)
                {
                    XtraMessageBox.Show("Fecha Vigencia Contrato: NO puede ser menor a la Fecha Ingreso Contrato",
                "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //dteditVigenciaContrato.Focus();
                    flagTaMuyBien = false;
                }
                else if (dteditVigenciaContrato.DateTime.Date < deteInicioContrato.DateTime.Date)
                {
                    XtraMessageBox.Show("Fecha Vigencia Contrato: NO puede ser menor a la Fecha Ingreso Contrato CIT",
               "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //dteditVigenciaContrato.Focus();
                    flagTaMuyBien = false;
                }
            }

            return flagTaMuyBien;
        }

        private void dateFechaParaElCalculoSD_EditValueChanged(object sender, EventArgs e)
        {
            ObtenerValorUMA();
        }
    }
}