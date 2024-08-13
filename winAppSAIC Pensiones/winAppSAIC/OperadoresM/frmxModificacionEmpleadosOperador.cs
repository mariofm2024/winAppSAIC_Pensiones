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
using System.Diagnostics;
using DevExpress.XtraReports.UI;
using System.IO;

namespace winAppSAIC.OperadoresM
{
    public partial class frmxModificacionEmpleadosOperador : DevExpress.XtraEditors.XtraForm
    {
        tools.dsc dsc = new tools.dsc();
        String stRutaEmpleados = String.Empty;
        Empleado objEmp;

        Boolean flageHabilitarSolicitudes_BajaCuentas;
        Boolean flageHabilitarSolicitudes_ActualizacionDeCuenta;
        Boolean flageHabilitarSolicitudes_ActualizacionDeSalarios;
        Boolean flageHabilitarCartas;

        public frmxModificacionEmpleadosOperador()
        {
            InitializeComponent();
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
        private byte byEstatusOriginal = 0;

        #endregion

        #region "Metodos Propios"

        /// <summary>
        /// Método para limpiar el contenido de los Controles
        /// </summary>
        private void LimpiarControles()
        {
            txtNoEmpleado.Text = string.Empty;
            txtAPaternoEmpleado.Text = string.Empty;
            txtAMaternoEmpleado.Text = string.Empty;
            txtNombreEmpleado.Text = string.Empty;
            txtNSS.Text = string.Empty;
            txtRFC.Text = string.Empty;
            txtCURP.Text = string.Empty;
            txtSalarioDiarioContrato.Text = string.Empty;
            txtSalarioBaseCotizacionContrato.Text = string.Empty;
            txtSalarioDiarioIntegradoContrato.Text = string.Empty;
            calFechaIngresoReingresoContrato.EditValue = DateTime.Today;
            calFechaBajaContrato.EditValue = DateTime.Today;
            calFechaReingresoContrato.EditValue = DateTime.Today;
            cboIdZonaSalario.EditValue = -1;
            cboIdTipoPeriodoNomina.EditValue = -1;
            cboIdTipoEmpleado.EditValue = -1;

            txtPuestoContrato.Text = string.Empty;
            txtDepartamentoContrato.Text = string.Empty;
            txtExpediente.Text = string.Empty;
            cboIdTenedoraSA.EditValue = -1;
            txtTenedoraSA.Text = string.Empty;
            txtTenedoraSC.Text = string.Empty;
            cboIdTipoMovimiento.EditValue = -1;        //ESQUEMA
            cboIdEstatus.EditValue = -1;

            calFechaNacimiento.EditValue = new DateTime(1900, 1, 1);
            txtNoDocMigratorio.Text = string.Empty;
            cboIdSexo.EditValue = -1;
            txtSalarioDiarioCliente.Text = "0.00";
            calFechaIngresoCliente.EditValue = DateTime.Today;
            cboIdTurno.EditValue = -1;
            cboIdTipoContrato.EditValue = -1;
            txtTiempoContrato.Text = string.Empty;
            txtUMF.Text = string.Empty;
            txtLugarNacimiento.Text = string.Empty;
            txtProfesion.Text = string.Empty;
            cboIdEstadoCivil.EditValue = -1;
            cboIdNacionalidad.EditValue = -1;
            txtDepartamentoCliente.Text = string.Empty;
            txtPuestoCliente.Text = string.Empty;
            txtDescJornada.Text = string.Empty;
            txtHorarioJornada.Text = string.Empty;
            txtTiempoComidaDescanso.Text = string.Empty;
            txtFuncionesEmpleado.Text = string.Empty;
            cboAutorizacionPermanenteIMSS.EditValue = "NO";
            txtNoCreditoInfonavit.Text = string.Empty;

            txtBancoDepositoNomina.Text = string.Empty;
            txtNoCuentaBanco.Text = string.Empty;
            txtNoReferenciaEmpleadoBanco.Text = string.Empty;
            txtCLABE.Text = string.Empty;
            cboIdFormaPago.EditValue = -1;
            txtObservaciones.Text = string.Empty;
            txtIdEstatusJuridico.Text = "0";
            txtCorreoElectronico.Text = String.Empty;



            txtEditTipoIdentificacion.Text = String.Empty;
            txtEditAutoridadExpide.Text = String.Empty;
            txtEditNumeroIdentificacion.Text = String.Empty;
            dteditVigenciaContrato.Text = "1900/01/01";
            txtEditEdad.Text = String.Empty;
            seVacaciones.Value = 0;
            sePrimaVacacional.Value = 0;
            seAguinaldo.Value = 0;
            mmContratacion.Text = String.Empty;
            mmHerramientas.Text = String.Empty;
            mmConfidencial.Text = String.Empty;
            txtCentroDeCosto1.Text = String.Empty;


        }

        /// <summary>
        /// Método para limpiar el contenido de los Controles de Direccion de Empleados
        /// </summary>
        private void LimpiarControlesDireccion()
        {
            //inicializar Direcciones Empleados
            txtCalleCT.Text = string.Empty;
            txtNoExteriorCT.Text = string.Empty;
            txtNoInteriorCT.Text = string.Empty;
            txtColoniaCT.Text = string.Empty;
            txtCodigoPostalCT.Text = string.Empty;
            txtDelegacionMunicipioCT.Text = string.Empty;
            txtPoblacionCiudadCT.Text = string.Empty;
            txtTelefono1CT.Text = string.Empty;
            txtTelefono2CT.Text = string.Empty;
            cboIdEstadoCT.EditValue = -1;

            txtCalleDP.Text = string.Empty;
            txtNoExteriorDP.Text = string.Empty;
            txtNoInteriorDP.Text = string.Empty;
            txtColoniaDP.Text = string.Empty;
            txtCodigoPostalDP.Text = string.Empty;
            txtDelegacionMunicipioDP.Text = string.Empty;
            txtPoblacionCiudadDP.Text = string.Empty;
            txtTelefono1DP.Text = string.Empty;
            txtTelefono2DP.Text = string.Empty;
            cboIdEstadoDP.EditValue = -1;

            txtCodigoPostalFiscal.Text = String.Empty;
            txtEstadoFiscal.Text = String.Empty;

            //inicializar propiedades TAG de los GroupControl de Domicilios
            gpcDomicilioCT.Tag = 0;
            gpcDomicilioPE.Tag = 0;
            gpcDomicilioFiscal.Tag = 0;
        }

        /// <summary>
        /// Método para limpiar el contenido de los Controles
        /// </summary>
        private void LimpiarControlesINFONAVIT()
        {

            cboIdTipoDescuento.EditValue = 1;
            txtMontoDiario.Text = "0";
            //txtPuestoContrato.Text = string.Empty;
            //txtDepartamentoContrato.Text = string.Empty;
            //boIdEstatus.EditValue = -1;
            txtNumCredito.Text = string.Empty;
            txtFactorDesc.Text = "0";
            txtMontoDesc.Text = "0";
            txtAdeudo.Text = "0";
            txtRecuperado.Text = "0";
            txtSaldo.Text = "0";
            chkEstatusCredito.Checked = false;
        }

        /// <summary>
        /// Método para activar o desactivar controles al momento de Editar/Cancelar/Guardar
        /// </summary>
        /// <param name="bFlag">Valor TRUE o FALSE</param>
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

            txtSalarioDiarioContrato.Enabled = bFlag;
            txtSalarioBaseCotizacionContrato.Enabled = bFlag;
            txtSalarioDiarioIntegradoContrato.Enabled = bFlag;
            calFechaIngresoReingresoContrato.Enabled = bFlag;
            calFechaBajaContrato.Enabled = bFlag;
            cboIdZonaSalario.Enabled = bFlag;
            cboIdTipoPeriodoNomina.Enabled = bFlag;
            cboIdTipoEmpleado.Enabled = bFlag;
            txtDepartamentoContrato.Enabled = bFlag;
            txtPuestoContrato.Enabled = bFlag;
            txtExpediente.Enabled = bFlag;
            cboIdTenedoraSA.Enabled = bFlag;
            txtTenedoraSA.Enabled = bFlag; ;
            txtTenedoraSC.Enabled = bFlag;
            cboIdTipoMovimiento.Enabled = bFlag;
            cboIdEstatus.Enabled = bFlag;

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
            txtBancoDepositoNomina.Enabled = bFlag;
            txtNoCuentaBanco.Enabled = bFlag;
            txtCLABE.Enabled = bFlag;
            txtNoReferenciaEmpleadoBanco.Enabled = bFlag;
            cboIdFormaPago.Enabled = bFlag;
            txtObservaciones.Enabled = bFlag;
            txtIdEstatusJuridico.Enabled = bFlag;
            txtCorreoElectronico.Enabled = bFlag;


            txtAPaternoEmpleado.Properties.ReadOnly = true;
            txtAMaternoEmpleado.Properties.ReadOnly = true;
            txtNombreEmpleado.Properties.ReadOnly = true;
            txtRFC.Properties.ReadOnly = true;
            txtCURP.Properties.ReadOnly = true;
            txtSalarioDiarioContrato.Properties.ReadOnly = true;
            txtSalarioBaseCotizacionContrato.Properties.ReadOnly = true;
            txtSalarioDiarioIntegradoContrato.Properties.ReadOnly = true;
            calFechaIngresoReingresoContrato.Properties.ReadOnly = true;
            calFechaBajaContrato.Properties.ReadOnly = true;
            cboIdZonaSalario.Properties.ReadOnly = true;
            cboIdTipoPeriodoNomina.Properties.ReadOnly = true;
            cboIdTipoEmpleado.Properties.ReadOnly = true;
            txtDepartamentoContrato.Properties.ReadOnly = true;
            txtPuestoContrato.Properties.ReadOnly = true;
            txtExpediente.Properties.ReadOnly = true;
            cboIdTenedoraSA.Properties.ReadOnly = true;
            txtTenedoraSA.Properties.ReadOnly = true; ;
            txtTenedoraSC.Properties.ReadOnly = true;
            cboIdTipoMovimiento.Properties.ReadOnly = true;
            cboIdEstatus.Properties.ReadOnly = true;

            txtUMF.Properties.ReadOnly = true;
            cboAutorizacionPermanenteIMSS.Properties.ReadOnly = true;
            txtNoCreditoInfonavit.Properties.ReadOnly = true;
            calFechaNacimiento.Properties.ReadOnly = true;
            txtNoDocMigratorio.Properties.ReadOnly = true;
            cboIdSexo.Properties.ReadOnly = true;
            cboIdEstadoCivil.Properties.ReadOnly = true;
            cboIdNacionalidad.Properties.ReadOnly = true;
            txtSalarioDiarioCliente.Properties.ReadOnly = true;
            calFechaIngresoCliente.Properties.ReadOnly = true;
            cboIdTurno.Properties.ReadOnly = true;
            cboIdTipoContrato.Properties.ReadOnly = true;
            txtTiempoContrato.Properties.ReadOnly = true;
            txtLugarNacimiento.Properties.ReadOnly = true;
            txtProfesion.Properties.ReadOnly = true;
            txtDepartamentoCliente.Properties.ReadOnly = true;
            txtPuestoCliente.Properties.ReadOnly = true;
            txtDescJornada.Properties.ReadOnly = true;
            txtHorarioJornada.Properties.ReadOnly = true;
            txtTiempoComidaDescanso.Properties.ReadOnly = true;
            txtFuncionesEmpleado.Properties.ReadOnly = true;
            txtBancoDepositoNomina.Properties.ReadOnly = true;
            txtNoCuentaBanco.Properties.ReadOnly = true;
            txtCLABE.Properties.ReadOnly = true;
            txtNoReferenciaEmpleadoBanco.Properties.ReadOnly = true;
            cboIdFormaPago.Properties.ReadOnly = true;
            txtObservaciones.Properties.ReadOnly = true;
            txtIdEstatusJuridico.Properties.ReadOnly = true;
            txtCorreoElectronico.Properties.ReadOnly = true;

            txtAPaternoEmpleado.TabStop = false;
            txtAMaternoEmpleado.TabStop = false;
            txtNombreEmpleado.TabStop = false;
            txtRFC.TabStop = false;
            txtCURP.TabStop = false;
            txtSalarioDiarioContrato.TabStop = false;
            txtSalarioBaseCotizacionContrato.TabStop = false;
            txtSalarioDiarioIntegradoContrato.TabStop = false;
            calFechaIngresoReingresoContrato.TabStop = false;
            calFechaBajaContrato.TabStop = false;
            cboIdZonaSalario.TabStop = false;
            cboIdTipoPeriodoNomina.TabStop = false;
            cboIdTipoEmpleado.TabStop = false;
            txtDepartamentoContrato.TabStop = false;
            txtPuestoContrato.TabStop = false;
            txtExpediente.TabStop = false;
            cboIdTenedoraSA.TabStop = false;
            txtTenedoraSA.TabStop = false; ;
            txtTenedoraSC.TabStop = false;
            cboIdTipoMovimiento.TabStop = false;
            cboIdEstatus.TabStop = false;
            txtUMF.TabStop = false;
            cboAutorizacionPermanenteIMSS.TabStop = false;
            txtNoCreditoInfonavit.TabStop = false;
            calFechaNacimiento.TabStop = false;
            txtNoDocMigratorio.TabStop = false;
            cboIdSexo.TabStop = false;
            cboIdEstadoCivil.TabStop = false;
            cboIdNacionalidad.TabStop = false;
            txtSalarioDiarioCliente.TabStop = false;
            calFechaIngresoCliente.TabStop = false;
            cboIdTurno.TabStop = false;
            cboIdTipoContrato.TabStop = false;
            txtTiempoContrato.TabStop = false;
            txtLugarNacimiento.TabStop = false;
            txtProfesion.TabStop = false;
            txtDepartamentoCliente.TabStop = false;
            txtPuestoCliente.TabStop = false;
            txtDescJornada.TabStop = false;
            txtHorarioJornada.TabStop = false;
            txtTiempoComidaDescanso.TabStop = false;
            txtFuncionesEmpleado.TabStop = false;
            txtBancoDepositoNomina.TabStop = false;
            txtNoCuentaBanco.TabStop = false;
            txtCLABE.TabStop = false;
            txtNoReferenciaEmpleadoBanco.TabStop = false;
            cboIdFormaPago.TabStop = false;
            txtObservaciones.TabStop = false;
            txtIdEstatusJuridico.TabStop = false;
            txtCorreoElectronico.TabStop = false;

            //sddBtnSolicitudes.Enabled = flagBtnSolicitudes;
            //Domicilios
            ActivarControlesDireccion(bFlag);
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

            txtCalleCT.TabStop = false;
            txtNoExteriorCT.TabStop = false;
            txtNoInteriorCT.TabStop = false;
            txtColoniaCT.TabStop = false;
            txtCodigoPostalCT.TabStop = false;
            txtDelegacionMunicipioCT.TabStop = false;
            txtPoblacionCiudadCT.TabStop = false;
            cboIdEstadoCT.TabStop = false;
            txtTelefono1CT.TabStop = false;
            txtTelefono2CT.TabStop = false;

            txtCalleDP.TabStop = false;
            txtNoExteriorDP.TabStop = false;
            txtNoInteriorDP.TabStop = false;
            txtColoniaDP.TabStop = false;
            txtCodigoPostalDP.TabStop = false;
            txtDelegacionMunicipioDP.TabStop = false;
            txtPoblacionCiudadDP.TabStop = false;
            cboIdEstadoDP.TabStop = false;
            txtTelefono1DP.TabStop = false;
            txtTelefono2DP.TabStop = false;


            txtCalleCT.Properties.ReadOnly = true;
            txtNoExteriorCT.Properties.ReadOnly = true;
            txtNoInteriorCT.Properties.ReadOnly = true;
            txtColoniaCT.Properties.ReadOnly = true;
            txtCodigoPostalCT.Properties.ReadOnly = true;
            txtDelegacionMunicipioCT.Properties.ReadOnly = true;
            txtPoblacionCiudadCT.Properties.ReadOnly = true;
            cboIdEstadoCT.Properties.ReadOnly = true;
            txtTelefono1CT.Properties.ReadOnly = true;
            txtTelefono2CT.Properties.ReadOnly = true;

            txtCalleDP.Properties.ReadOnly = true;
            txtNoExteriorDP.Properties.ReadOnly = true;
            txtNoInteriorDP.Properties.ReadOnly = true;
            txtColoniaDP.Properties.ReadOnly = true;
            txtCodigoPostalDP.Properties.ReadOnly = true;
            txtDelegacionMunicipioDP.Properties.ReadOnly = true;
            txtPoblacionCiudadDP.Properties.ReadOnly = true;
            cboIdEstadoDP.Properties.ReadOnly = true;
            txtTelefono1DP.Properties.ReadOnly = true;
            txtTelefono2DP.Properties.ReadOnly = true;
        }

        /// <summary>
        /// Método para activar o desactivar controles al momento de Editar/Cancelar/Guardar
        /// </summary>
        /// <param name="bFlag">Valor TRUE o FALSE</param>
        private void ActivarControlesInfonavit(bool bFlag)
        {
            txtSalarioBaseCotizacionContrato.Enabled = bFlag;
            txtSalarioDiarioIntegradoContrato.Enabled = bFlag;
            calFechaIngresoINF.Enabled = bFlag;
            calFechaBajaINF.Enabled = bFlag;
            txtNumCredito.Enabled = bFlag;
            cboIdTipoDescuento.Enabled = bFlag;
            txtFactorDesc.Enabled = bFlag;
            chkEstatusCredito.Enabled = bFlag;
            txtMontoDesc.Enabled = bFlag;
            txtAdeudo.Enabled = bFlag;

            txtSalarioBaseCotizacionContrato.TabStop = false;
            txtSalarioDiarioIntegradoContrato.TabStop = false;
            calFechaIngresoINF.TabStop = false;
            calFechaBajaINF.TabStop = false;
            txtNumCredito.TabStop = false;
            cboIdTipoDescuento.TabStop = false;
            txtFactorDesc.TabStop = false;
            chkEstatusCredito.TabStop = false;
            txtMontoDesc.TabStop = false;
            txtAdeudo.TabStop = false;

            txtSalarioBaseCotizacionContrato.Properties.ReadOnly = true;
            txtSalarioDiarioIntegradoContrato.Properties.ReadOnly = true;
            calFechaIngresoINF.Properties.ReadOnly = true;
            calFechaBajaINF.Properties.ReadOnly = true;
            txtNumCredito.Properties.ReadOnly = true;
            cboIdTipoDescuento.Properties.ReadOnly = true;
            txtFactorDesc.Properties.ReadOnly = true;
            txtMontoDesc.Properties.ReadOnly = true;
            txtAdeudo.Properties.ReadOnly = true;

        }
        /// <summary>
        /// Método para obtener los valores de los controles
        /// y asignarlos al objeto Empleado
        /// </summary>
        /// <returns>Objeto Empleado</returns>
        private Empleado AsignarInfoEmpleado()
        {
            Empleado objEmp = new Empleado();

            objEmp.IdEmpleado = Convert.ToInt32(txtNoEmpleado.Text);
            objEmp.APaternoEmpleado = txtAPaternoEmpleado.Text.Trim();
            objEmp.AMaternoEmpleado = txtAMaternoEmpleado.Text.Trim();
            objEmp.NombreEmpleado = txtNombreEmpleado.Text.Trim();
            objEmp.NSS = txtNSS.Text.Trim();
            objEmp.RFC = txtRFC.Text.Trim();
            objEmp.CURP = txtCURP.Text.Trim();
            objEmp.SalarioDiarioContrato = Convert.ToDecimal(txtSalarioDiarioContrato.Text);
            objEmp.SalarioBaseCotizacionContrato = Convert.ToDecimal(txtSalarioBaseCotizacionContrato.Text);
            objEmp.SalarioDiarioIntegradoContrato = Convert.ToDecimal(txtSalarioDiarioIntegradoContrato.Text);
            objEmp.FechaIngresoContrato = Convert.ToDateTime(calFechaIngresoReingresoContrato.EditValue);
            objEmp.FechaBajaContrato = Convert.ToDateTime(calFechaBajaContrato.EditValue);
            objEmp.IdZonaSalario = Convert.ToByte(cboIdZonaSalario.EditValue);
            objEmp.IdTipoPeriodoNomina = (byte)cboIdTipoPeriodoNomina.EditValue;
            objEmp.IdTipoEmpleado = (byte)cboIdTipoEmpleado.EditValue;
            objEmp.DepartamentoContrato = txtDepartamentoContrato.Text.Trim();
            objEmp.PuestoContrato = txtPuestoContrato.Text.Trim();

            objEmp.Expediente = txtExpediente.Text.Trim();

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
            objEmp.IdJornadaServicio = 1;       //  N/D
            objEmp.IdEstatusJuridico = Convert.ToByte(txtIdEstatusJuridico.Text);
            objEmp.CorreoElectronico = txtCorreoElectronico.Text.Trim();
            objEmp.UsuarioCreacion = OperadorBD.OperadorGlobal.NombreUsuario;
            objEmp.UsuarioModificacion = OperadorBD.OperadorGlobal.NombreUsuario;

            return objEmp;
        }

        /// <summary>
        /// Método para asignar los valores de la Direccion Empleado
        /// </summary>
        /// <param name="pIdDireccion">Valor IdDireccion registrada inicialmente</param>
        /// <param name="pIdTipoDireccion">Valor IdTipoDireccion 1 = Centro de Trabajo, 2 = Domicilio Particular</param>
        /// <returns></returns>
        private DireccionEmpleado AsignarInfoDireccionEmpleado(Int64 pIdDireccion, Constantes.TipoDireccionEmpleado pIdTipoDireccion)
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
            txtExpediente.Text = objEmp.Expediente;
            txtRazonSocialCliente.Text = objEmp.RazonSocialCliente;
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
            txtTiempoContrato.Text = objEmp.TiempoContrato;
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
            txtCliente.Text = objEmp.RazonSocialCliente;
            cboIdJornadaServicio.EditValue = objEmp.IdJornadaServicio;
            mmObservacionesBaja.Text = objEmp.ObservacionesBaja;
            txtCentroDeCosto1.Text = objEmp.CentroDeCosto;
            checkEditSindicalizado.Checked = objEmp.Sindicalizado == "SI" ? true : false;

            txtParteVariable.Value = objEmp.dcParteVariable;
            if (objEmp.idSolicitudParteVariable == 0)
            {
                lblInfoParteVariable.Visible = false;
                lblInfoParteVariable.ToolTip = String.Empty;
            }
            else
            {
                lblInfoParteVariable.Visible = true;
                lblInfoParteVariable.ToolTip = "Solicitud: " + objEmp.idSolicitudParteVariable.ToString();
            }
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
                    //asignar el IdDireccion que tiene asignado
                    gpcDomicilioFiscal.Tag = direccion.Field<Int64>("IdDireccion");
                    txtCodigoPostalFiscal.Text = direccion.Field<string>("CodigoPostal");
                }
            }   //foreach
        }


        /// <summary>
        /// Método para visualizar la información de los Domicilios del Empleados
        /// </summary>
        private void MostrarInfoDireccionEmpleado()
        {
            LimpiarControlesDireccion();        //limpiar controles Direccion

            //obtener las direcciones del empleado
            DataTable dtDireccionEmpleado = this.stpSelObtenerInfoDireccionEmpleadoModificacionCFDITableAdapter1.GetData(Convert.ToInt32(cboIdEmpleado.EditValue));

            if (dtDireccionEmpleado.Rows.Count > 0)
                //visualizar las Direcciones de los Empleados
                MostrarInfoLINQDireccionEmpleado(dtDireccionEmpleado);
        }

        /// <summary>
        /// Método para visualizar la información de los Domicilios del Empleados
        /// </summary>
        private void MostrarInfoINFONAVITEmpleado()
        {
            LimpiarControlesINFONAVIT();        //limpiar controles Direccion

            //cargar informacion detalla del Empleado CFDI
            DataTable dt = this.stpSelObtenerInfoEmpleadoModificacionCFDIvIMSSTableAdapter1.GetData(Convert.ToInt32(cboIdEmpleado.EditValue));

            //Asignar información detallada del Empleado CFDI al Objeto Empleado
            Empleado objEmp = EmpleadoBD.ObtenerInfoEmpleadoModificacionCFDIvIMSS(dt);

            if (objEmp != null)
            {
                MostrarInfoEmpleadoInfonavit(objEmp);        //mostrar informacion del Emplead
                ActivarControlesInfonavit(true);
            }
        }

        private void MostrarInfoContratoEmpleado(Empleado objEmp)
        {
            Catalogos.frmxModificacionEmpleados ModificacionEmpleado = new Catalogos.frmxModificacionEmpleados(0, false, false, false, false, false, 0);
            txtEditTipoIdentificacion.Text = objEmp.TipoIdentificacion;
            txtEditAutoridadExpide.Text = objEmp.AutoridadExpide;
            txtEditNumeroIdentificacion.Text = objEmp.NumeroIdentificacion;
            dteditVigenciaContrato.Text = objEmp.VigenciaContrato.ToShortDateString();
            txtEditEdad.Text = ModificacionEmpleado.obtenerCURP(objEmp.CURP);
            txtEditEdad.Text = objEmp.Edad.ToString();
            seVacaciones.Text = objEmp.Vacaciones.ToString("N2");
            sePrimaVacacional.Text = objEmp.PrimaVacacional.ToString("N2");
            seAguinaldo.Text = objEmp.Aguinaldo.ToString("N2");
            mmContratacion.Text = objEmp.ConceptoContratacion;
            mmHerramientas.Text = objEmp.HerramientasTrabajo;
            mmConfidencial.Text = objEmp.InformacionConfidencial;
            txtbxIdSolicitusAlta.Text = objEmp.NumSolicitudAlta.ToString();
            txtbxIdSolicitusBaja.Text = objEmp.NumSolicitudBaja.ToString();

            DataRow[] unRow = dbSAICBPOCatalogosDataSet.stpSelObtenerConceptosBaja.Select("idConcepto = '" + objEmp.IdConceptoBaja + "'");
            if (unRow.Count() > 0)
            {
                txtEMotivoBaja.Text = unRow[0].ItemArray[2].ToString();
            }
        }

        /// <summary>
        /// Metodo para desplegar el contenido del objeto Empleado
        /// </summary>
        /// <param name="objEmp">Objeto Empleado</param>
        private void MostrarInfoEmpleadoInfonavit(Empleado objEmp)
        {
            txtNumCredito.Text = objEmp.NoCreditoInfonavit;
            chkEstatusCredito.Checked = objEmp.EstatusINFONAVIT;
            cboIdTipoDescuento.EditValue = objEmp.IdTipoFactorDescuento;
            cbTipoPago.EditValue = objEmp.IdParametroPagoInfonavit;
            txtValorTipoPago.Text = objEmp.ValorTipoPago.ToString("N2");
            txtFactorDesc.Text = objEmp.FactorDescuento.ToString("N2");
            txtMontoDesc.Text = objEmp.MontoDescuento.ToString("N2");
            txtMontoDiario.Text = objEmp.MontoDescuentoDiario.ToString("N2");
            calFechaIngresoINF.EditValue = objEmp.FechaInicioDesc;
            calFechaBajaINF.EditValue = objEmp.FechaFinDesc;
            txtAdeudo.Text = objEmp.MontoRecuperar.ToString("N2");
            txtRecuperado.Text = objEmp.MontoRecuperado.ToString("N2");
            txtSaldo.Text = objEmp.Saldo.ToString("N2");
        }

        /// <summary>
        /// Método que actualiza la información del empleado
        /// </summary>
        private void ActualizarInfoEmpleado()
        {
            Empleado objEmp = AsignarInfoEmpleado();    //crear objeto y asignar valores

            //accion de actualizar
            bool bFlagUpdate = EmpleadoBD.ActualizarInfoEmpleado(objEmp, winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString);

            bool bFlagUpdateDireccionEmpleado = ActualizarInfoDireccionEmpleado();
            MostrarInfoDireccionEmpleado(); //recargar los ajustes a los Domicilios del Empleado

            if (bFlagUpdate && bFlagUpdateDireccionEmpleado)    //fue correcta la modificacion
            {
                ActivarBotones(true);
                estatusBoton = EstatusBotones.Ninguno;    //asignar accion NINGUNO
                ActivarControles(false, tipoPerfil);     //bloqueo de controles permitidos
                XtraMessageBox.Show("La información del Empleado se actualizó satisfactoriamente",
                    "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboIdEmpleado.Focus();
            }
            else  //error en actualizacion
                XtraMessageBox.Show("NO fue posible actualizar la información del Empleado", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }


        /// <summary>
        /// Método que realiza la asignación y actualizacion de las Direcciones
        /// del Empleado (Centro de Trabajo y Domicilio Particular)
        /// </summary>
        /// <returns>Valor TRUE o FALSE</returns>
        private bool ActualizarInfoDireccionEmpleado()
        {
            DireccionEmpleado objDireccionEmpCT = AsignarInfoDireccionEmpleado(Convert.ToInt64(gpcDomicilioCT.Tag), Constantes.TipoDireccionEmpleado.CentroTrabajo);    //crear objeto y asignar valores
            DireccionEmpleado objDireccionEmpDP = AsignarInfoDireccionEmpleado(Convert.ToInt64(gpcDomicilioPE.Tag), Constantes.TipoDireccionEmpleado.Particular);    //crear objeto y asignar valores

            //accion de actualizar
            bool bFlagUpdateCT = DireccionEmpleadoBD.ActualizarInfoDireccionEmpleado(objDireccionEmpCT, winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString);
            bool bFlagUpdateDP = DireccionEmpleadoBD.ActualizarInfoDireccionEmpleado(objDireccionEmpDP, winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString);

            return bFlagUpdateCT && bFlagUpdateDP;
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
                    XtraMessageBox.Show(string.Format("{0} no es válida.",
                                          objVisual.Tag), "Error de Captura",
                                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (fechaControl.Year == DateTime.Today.Year)
                    return true;
                else if (fechaControl.Year > DateTime.Today.Year)
                {
                    XtraMessageBox.Show(string.Format("{0} no es válida.",
                                          objVisual.Tag), "Error de Captura",
                                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (DateTime.Today.Year - fechaControl.Year <= 15)
                    return true;
                else
                {
                    XtraMessageBox.Show(string.Format("{0} no es válida.",
                                          objVisual.Tag), "Error de Captura",
                                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
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

        private void frmxModificacionEmpleadosOperador_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet.stpSelSexo1' table. You can move, or remove it, as needed.
            this.stpSelSexo1TableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelSexo1);

            try
            {
                splashScreenManager2.ShowWaitForm();


                stpSelObtenerConceptosBajaTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelObtenerConceptosBaja, false);
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
                // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet.stpSelSexo' table. You can move, or remove it, as needed.
                this.stpSelSexoTableAdapter1.Fill(this.dbSAICBPOCatalogosDataSet.stpSelSexo);
                // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet.stpSelEmpleadosDisponibles' table. You can move, or remove it, as needed.
                this.stpSelEmpleadosDisponiblesTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelEmpleadosDisponibles);
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.CatMatrizCliente' table. You can move, or remove it, as needed.
                //this.catMatrizClienteTableAdapter.Fill(this.dbSAIC_Catalogos.CatMatrizCliente);

                // TODO: This line of code loads data into the 'dbSAICBPODataSet.vwCatTenedoraSA' table. You can move, or remove it, as needed.
                this.vwCatTenedoraSATableAdapter.Fill(this.dbSAICBPODataSet.vwCatTenedoraSA);
                // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet.stpSelEstado' table. You can move, or remove it, as needed.
                this.stpSelEstadoTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelEstado);
                // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet.stpSelFormaPago' table. You can move, or remove it, as needed.
                this.stpSelFormaPagoTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelFormaPago);
                //llenar combobox Estatus Empleados
                this.vwCatEstatusEmpleadoCFDITableAdapter.Fill(this.dbSAICBPONominaCFDIDataSet.vwCatEstatusEmpleadoCFDI);
                // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet.vwCatTipoDescuento' table. You can move, or remove it, as needed.
                this.vwCatTipoDescuentoTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.vwCatTipoDescuento);

                stpSelJornadaServicioTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelJornadaServicio);

                stpSelTipoCartasTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelTipoCartas, 0);

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
                ActivarControles(true, tipoPerfil);        //desactivar controles estava en false 
                LimpiarControles();     //limpiar contenido controles
                LimpiarControlesDireccion();        //limpiar contenido controles Direccion

                // Set column widths according to their contents. 
                cboIdEmpleado.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cboIdEmpleado.Properties.PopupFormWidth = 700;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                splashScreenManager2.CloseWaitForm();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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
                    Validator.IsPositiveNumber(cboIdTenedoraSA) &&
                    IsValidDate(calFechaIngresoReingresoContrato))
                {
                    switch (cboIdTipoMovimiento.EditValue.ToString())
                    {
                        case "P":
                        case "S":
                            txtTenedoraSC.Text = string.Empty;
                            break;

                        case "D":
                            txtTenedoraSC.Text = string.Empty;
                            txtSalarioDiarioContrato.Value = 0;
                            txtSalarioBaseCotizacionContrato.Value = 0;
                            txtSalarioDiarioIntegradoContrato.Value = 0;
                            break;

                        case "M":
                            break;

                        case "A":
                            cboIdTenedoraSA.EditValue = 1;      //NO APLICA TENEDORA
                            txtTenedoraSA.Text = string.Empty;
                            //txtSalarioDiarioContrato.Value = 0;
                            //txtSalarioBaseCotizacionContrato.Value = 0;
                            //txtSalarioDiarioIntegradoContrato.Value = 0;
                            break;
                    } //switch

                    //Buscar informacion del Empleado CFDI con NSS por actualizar
                    DataTable dt = this.stpSelValidarExistenciaNSSTableAdapter1.GetData(txtNSS.Text);

                    //validar NSS
                    if (Validator.NotExistNSS(dt, txtNSS, strNSSOriginal, txtNSS.Text))
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
                    Validator.IsPositiveNumber(cboIdTenedoraSA) &&
                    IsValidDate(calFechaIngresoReingresoContrato))
                {
                    switch (cboIdTipoMovimiento.EditValue.ToString())
                    {
                        case "P":
                        case "S":
                            txtTenedoraSC.Text = string.Empty;
                            break;

                        case "D":
                            txtTenedoraSC.Text = string.Empty;
                            txtSalarioDiarioContrato.Value = 0;
                            txtSalarioBaseCotizacionContrato.Value = 0;
                            txtSalarioDiarioIntegradoContrato.Value = 0;
                            break;

                        case "M":
                            break;

                        case "A":
                            cboIdTenedoraSA.EditValue = 1;      //NO APLICA TENEDORA
                            txtTenedoraSA.Text = string.Empty;
                            //txtSalarioDiarioContrato.Value = 0;
                            //txtSalarioBaseCotizacionContrato.Value = 0;
                            //txtSalarioDiarioIntegradoContrato.Value = 0;
                            break;
                    } //switch

                    //Buscar informacion del Empleado CFDI con NSS por actualizar
                    DataTable dt = this.stpSelValidarExistenciaNSSTableAdapter1.GetData(txtNSS.Text);

                    //validar NSS
                    if (Validator.NotExistNSS(dt, txtNSS, strNSSOriginal, txtNSS.Text))
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
                    Validator.IsValidRFC(txtRFC, "El RFC", Validator.PatternRFC_COMODIN, Validator.PatternRFC) &&
                    Validator.IsValidCURP(txtCURP, "El CURP", Validator.PatternCURP_COMODIN, Validator.PatternCURP) &&
                    Validator.IsDecimal(txtSalarioDiarioContrato) &&
                    Validator.IsDecimal(txtSalarioBaseCotizacionContrato) &&
                    Validator.IsDecimal(txtSalarioDiarioIntegradoContrato) &&
                    Validator.IsPositiveOrZeroNumber(txtSalarioDiarioContrato) &&
                    Validator.IsPositiveOrZeroNumber(txtSalarioBaseCotizacionContrato) &&
                    Validator.IsPositiveOrZeroNumber(txtSalarioDiarioIntegradoContrato) &&
                    IsValidDate(calFechaIngresoReingresoContrato))
                {
                    switch (cboIdTipoMovimiento.EditValue.ToString())
                    {
                        case "S":
                            txtTenedoraSC.Text = string.Empty;
                            break;

                        case "P":
                        case "D":
                            txtTenedoraSC.Text = string.Empty;
                            txtSalarioDiarioContrato.Value = 0;
                            txtSalarioBaseCotizacionContrato.Value = 0;
                            txtSalarioDiarioIntegradoContrato.Value = 0;
                            break;

                        case "M":
                            break;

                        case "A":
                            cboIdTenedoraSA.EditValue = 1;      //NO APLICA TENEDORA
                            txtTenedoraSA.Text = string.Empty;
                            //txtNSS.Text = string.Empty;
                            //txtSalarioDiarioContrato.Value = 0;
                            //txtSalarioBaseCotizacionContrato.Value = 0;
                            //txtSalarioDiarioIntegradoContrato.Value = 0;
                            break;
                    } //switch
                    ActualizarInfoEmpleado();       //actualizar la información del empleado
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
                    Validator.IsPositiveNumber(cboIdTenedoraSA) &&
                    IsValidDate(calFechaIngresoReingresoContrato))
                {
                    switch (cboIdTipoMovimiento.EditValue.ToString())
                    {
                        case "S":
                            txtTenedoraSC.Text = string.Empty;
                            break;

                        case "P":
                        case "D":
                            txtTenedoraSC.Text = string.Empty;
                            txtSalarioDiarioContrato.Value = 0;
                            txtSalarioBaseCotizacionContrato.Value = 0;
                            txtSalarioDiarioIntegradoContrato.Value = 0;
                            break;

                        case "M":
                            break;

                        case "A":
                            cboIdTenedoraSA.EditValue = 1;      //NO APLICA TENEDORA
                            //txtNSS.Text = string.Empty;
                            txtTenedoraSA.Text = string.Empty;
                            //txtSalarioDiarioContrato.Value = 0;
                            //txtSalarioBaseCotizacionContrato.Value = 0;
                            //txtSalarioDiarioIntegradoContrato.Value = 0;
                            break;
                    } //switch
                    ActualizarInfoEmpleado();       //actualizar la información del empleado
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
                    Validator.IsPositiveNumber(txtSalarioDiarioContrato) &&
                    Validator.IsPositiveNumber(txtSalarioBaseCotizacionContrato) &&
                    Validator.IsPositiveNumber(txtSalarioDiarioIntegradoContrato) &&
                    Validator.IsPositiveNumber(cboIdTenedoraSA) &&
                    IsValidDate(calFechaIngresoReingresoContrato))
                {
                    switch (cboIdTipoMovimiento.EditValue.ToString())
                    {
                        case "P":
                        case "S":
                            txtTenedoraSC.Text = string.Empty;
                            break;

                        case "D":
                            txtTenedoraSC.Text = string.Empty;
                            txtSalarioDiarioContrato.Value = 0;
                            txtSalarioBaseCotizacionContrato.Value = 0;
                            txtSalarioDiarioIntegradoContrato.Value = 0;
                            break;

                        case "M":
                            break;

                        case "A":
                            cboIdTenedoraSA.EditValue = 1;      //NO APLICA TENEDORA
                            txtTenedoraSA.Text = string.Empty;
                            //txtSalarioDiarioContrato.Value = 0;
                            //txtSalarioBaseCotizacionContrato.Value = 0;
                            //txtSalarioDiarioIntegradoContrato.Value = 0;
                            break;
                    } //switch

                    //Buscar informacion del Empleado CFDI con NSS por actualizar
                    DataTable dt = this.stpSelValidarExistenciaNSSTableAdapter1.GetData(txtNSS.Text);

                    //validar NSS
                    if (Validator.NotExistNSS(dt, txtNSS, strNSSOriginal, txtNSS.Text))
                    {
                        ActualizarInfoEmpleado();       //actualizar la información del empleado
                    }
                }
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ActivarBotones(true);
            estatusBoton = EstatusBotones.Ninguno;    //asignar accion NINGUNO
            ActivarControles(false, tipoPerfil);     //bloqueo de controles permitidos
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNoEmpleado.Text.Length > 0)
            {
                ActivarBotones(false);
                estatusBoton = EstatusBotones.Editar;    //asignar accion EDITAR
                ActivarControles(true, tipoPerfil);     //desbloqueo de controles permitidos

                //asignar el Id de Movimiento Original
                //para que al momento de guardar pueda verificar
                //si existió un nuevo valor y validar las condiciones
                //que debe cumplir el usuario
                strIdMovimientoOriginal = cboIdTipoMovimiento.EditValue.ToString();
                //asignar el NSS Original
                strNSSOriginal = txtNSS.Text;
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
                    lblFechaIngresoReingreso.Location = new Point(180, 35);
                    lblFechaIngresoReingreso.Text = "Fecha de Ingreso";
                    //calFechaBajaContrato.EditValue = new DateTime(1900, 1, 1);
                    break;

                case 8:          //8=BAJA
                    //calFechaBajaContrato.EditValue = DateTime.Now.ToShortDateString();      //asignar fecha actual
                    break;

                case 9:         //9=REINGRESO
                    lblFechaIngresoReingreso.Location = new Point(170, 35);
                    lblFechaIngresoReingreso.Text = "Fecha de Reingreso";
                    //calFechaIngresoReingresoContrato.EditValue = DateTime.Now.ToShortDateString();       //asignar fecha actual
                    break;
            }
        }

        private void cboIdEmpleado_EditValueChanged(object sender, EventArgs e)
        {
            cargarInformacion();
        }

        private void cargarInformacion()
        {
            if (Convert.ToInt32(cboIdEmpleado.EditValue) <= 0)  //si el No. de empleado es menor o igual a 0
            {
                XtraMessageBox.Show("No ha escrito un No. de Empleado válido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                cboIdEmpleado.Focus();        //colocar cursor en control
            }
            else
            {

                habilitarBotones();

                //cargar informacion detalla del Empleado CFDI
                DataTable dt = this.stpSelObtenerInfoEmpleadoModificacionCFDITableAdapter1.GetData(Convert.ToInt32(cboIdEmpleado.EditValue));

                //Asignar información detallada del Empleado CFDI al Objeto Empleado
                objEmp = EmpleadoBD.ObtenerInfoEmpleadoModificacionCFDI(dt);

                if (objEmp != null)
                {
                    MostrarInfoEmpleado(objEmp);        //mostrar informacion del Empleado
                    MostrarInfoDireccionEmpleado();     //mostrar informacion de los Domicilios
                    MostrarInfoINFONAVITEmpleado();
                    MostrarInfoContratoEmpleado(objEmp);
                    stRutaEmpleados = dsc.stRutaEmpleados;
                    btnExportarExcel.Enabled = true;
                    btnAbrirCarpeta.Enabled = true;
                    cITToolStripMenuItem.Enabled = true;
                    documentaciónToolStripMenuItem.Enabled = objEmp.ConDocumentacion == 1 ? true : false;
                    habilitarBotonBaja(objEmp);
                    MostrarInfoEmpleadoSeguros(objEmp);
                    AgregarOpcionesCartas(objEmp);
                }
                else
                {
                    LimpiarControles();     //limpiar controles
                    XtraMessageBox.Show("No existe el empleado solicitado.", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboIdEmpleado.Focus();        //colocar cursor en control
                    btnAbrirCarpeta.Enabled = false;
                    cITToolStripMenuItem.Enabled = false;
                    btnExportarExcel.Enabled = false;
                    solicitudDeAltaDeCuentaToolStripMenuItem.Enabled = false;
                    actualizaciónDeSalariosToolStripMenuItem.Visible = false;
                    actualizaciónDeSalariosToolStripMenuItem.Enabled = false;
                }
            }
        }

        private void habilitarBotones()
        {
            try
            {
                this.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1.Fill(this.dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion, OperadorBD.OperadorGlobal.IdOperador, "informacionEmpleadosOperacines.Botones", "btnAcceso");
                if (dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion.Rows.Count > 0)
                {
                    Boolean.TryParse(dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion.Rows[0]["Consultar"].ToString(), out flageHabilitarSolicitudes_BajaCuentas);
                    Boolean.TryParse(dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion.Rows[0]["Actualizar"].ToString(), out flageHabilitarSolicitudes_ActualizacionDeCuenta);
                    Boolean.TryParse(dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion.Rows[0]["Insertar"].ToString(), out flageHabilitarSolicitudes_ActualizacionDeSalarios);
                    Boolean.TryParse(dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion.Rows[0]["Eliminar"].ToString(), out flageHabilitarCartas);
                    
                }
                else
                {
                    flageHabilitarSolicitudes_BajaCuentas = false;
                    flageHabilitarSolicitudes_ActualizacionDeCuenta = false;
                    flageHabilitarSolicitudes_ActualizacionDeSalarios = false;
                    flageHabilitarCartas = false;
                }
            }
            catch (Exception ex)
            {
                flageHabilitarSolicitudes_BajaCuentas = false;
                flageHabilitarSolicitudes_ActualizacionDeCuenta = false;
                flageHabilitarSolicitudes_ActualizacionDeSalarios = false;
                flageHabilitarCartas = false;
            }
        }


        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();        //cerrar pantalla
        }

        private void cboIdTipoDescuento_EditValueChanged(object sender, EventArgs e)
        {
            this.stpSelObtenerTipoUnidadMedidaPagoTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelObtenerTipoUnidadMedidaPago, Convert.ToInt32(cboIdTipoDescuento.EditValue));
            if (dbSAICBPOCatalogosDataSet.stpSelObtenerTipoUnidadMedidaPago != null && dbSAICBPOCatalogosDataSet.stpSelObtenerTipoUnidadMedidaPago.Rows.Count > 0)
            {
                cbTipoPago.EditValue = dbSAICBPOCatalogosDataSet.stpSelObtenerTipoUnidadMedidaPago.Rows[0]["idParametroPagoInfonavit"].ToString();
                if (cbTipoPago.EditValue.ToString() != "")
                {
                    this.stpSelObtenerValorTipodePagoInfonavitTableAdapter1.Fill(this.dbSAICBPOCatalogosDataSet.stpSelObtenerValorTipodePagoInfonavit, Convert.ToInt32(cbTipoPago.EditValue), DateTime.Today);

                    if (this.dbSAICBPOCatalogosDataSet.stpSelObtenerValorTipodePagoInfonavit != null && this.dbSAICBPOCatalogosDataSet.stpSelObtenerValorTipodePagoInfonavit.Rows.Count > 0)
                        txtValorTipoPago.Text = this.dbSAICBPOCatalogosDataSet.stpSelObtenerValorTipodePagoInfonavit.Rows[0]["Monto"].ToString();
                    else
                    {
                        if (cbTipoPago.EditValue.ToString() == "2")
                            txtValorTipoPago.Text = txtSalarioBaseCotizacionContrato.Text;
                        else
                            txtValorTipoPago.Text = "0";
                    }
                }

            }

            txtFactorDesc.Text = "0";
            txtMontoDesc.Text = "0";
            txtMontoDiario.Text = "0";
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            Catalogos.frmxModificacionEmpleados ModificarEmpleados = new Catalogos.frmxModificacionEmpleados(0, false, false, false, false, false, 0);
            ModificarEmpleados.exportarInformacionEmpleadoAExcel(Convert.ToInt32(cboIdEmpleado.EditValue), objEmp);
        }

        private void toolBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void documentaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splashScreenManager2.ShowWaitForm();
            splashScreenManager2.SetWaitFormCaption("Descargando Documento");
            splashScreenManager2.SetWaitFormDescription("Empleado: " + txtAPaternoEmpleado.Text + " " + txtAMaternoEmpleado.Text + " " + txtNombreEmpleado.Text);

            String stMensaje = String.Empty;
            String stRutaDescarga = String.Empty;

            stRutaDescarga = dsc.stRutaEmpleados + txtNoEmpleado.Text + @"\";
            dsc.CheckandCreateFolder(stRutaDescarga);
            DataTable dt = this.stpSelObtenerInfoEmpleadoModificacionCFDITableAdapter1.GetData(Convert.ToInt32(cboIdEmpleado.EditValue));
            Empleado objEmp = EmpleadoBD.ObtenerInfoEmpleadoModificacionCFDI(dt);

            OperadoresM.XtraMonitoreoSolicitudesOperaciones Monitoreo = new OperadoresM.XtraMonitoreoSolicitudesOperaciones(0);
            stMensaje = Monitoreo.descargarDocumentacionEmpleado(objEmp, stRutaDescarga);

            if (splashScreenManager2.IsSplashFormVisible) { splashScreenManager2.CloseWaitForm(); }

            XtraMessageBox.Show(stMensaje
              , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catalogos.frmxModificacionEmpleados ofrmxModificacionEmpleados = new Catalogos.frmxModificacionEmpleados(0, false, false, false, false, false, 0);
            ofrmxModificacionEmpleados.descargarContratoActivo(
                txtAPaternoEmpleado.Text + " " + txtAMaternoEmpleado.Text + " " + txtNombreEmpleado.Text,
                objEmp.IdEmpleado, 0);
        }

        private void btnAbrirCarpeta_Click(object sender, EventArgs e)
        {
            String stRutaSolicitud = stRutaEmpleados + cboIdEmpleado.EditValue + @"\";
            if (String.IsNullOrEmpty(cboIdEmpleado.EditValue.ToString())) { stRutaSolicitud = stRutaEmpleados; }

            dsc.CheckandCreateFolder(stRutaSolicitud);
            Process.Start(stRutaSolicitud);
        }

        private void btnSolicitarBaja_Click(object sender, EventArgs e)
        {
            DialogResult drResultado = XtraMessageBox.Show("¿Desea Solicitar la Baja de " + cboIdEmpleado.Text + "?"
         , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes == drResultado)
            {
                XtraMotivoBajaEmpleado bajaEmpleado = new XtraMotivoBajaEmpleado(objEmp, 1, DateTime.Now);
                bajaEmpleado.ShowDialog();
                cargarInformacion();
            }
        }

        private void habilitarBotonBaja(Empleado miEmpleado)
        {
            sddBtnSolicitudes.Enabled = flageHabilitarSolicitudes_BajaCuentas;

            if (miEmpleado.IdEstatus == 7 || miEmpleado.IdEstatus == 9) { btnSolicitarBaja.Enabled = true; } else { btnSolicitarBaja.Enabled = false; }
            if (miEmpleado.IdEstatus == 7 || miEmpleado.IdEstatus == 9) { bajaDeEmpleadoToolStripMenuItem.Enabled = true; } else { bajaDeEmpleadoToolStripMenuItem.Enabled = false; }
            if ((miEmpleado.IdEstatus == 7 || miEmpleado.IdEstatus == 9) && flageHabilitarSolicitudes_ActualizacionDeCuenta) { solicitudDeAltaDeCuentaToolStripMenuItem.Enabled = true; } else { solicitudDeAltaDeCuentaToolStripMenuItem.Enabled = false; }
            if ((miEmpleado.IdTipoMovimiento == "S" || miEmpleado.IdTipoMovimiento == "M") && (miEmpleado.IdEstatus == 7 || miEmpleado.IdEstatus == 9) && flageHabilitarSolicitudes_ActualizacionDeSalarios)
            {
                actualizaciónDeSalariosToolStripMenuItem.Visible = true;
                actualizaciónDeSalariosToolStripMenuItem.Enabled = true;
            }
            else
            {
                actualizaciónDeSalariosToolStripMenuItem.Visible = false;
                actualizaciónDeSalariosToolStripMenuItem.Enabled = false;
            }
        }

        private void obtenerDatosCarta(int idCarta, Decimal dcImporte, Boolean ConImporte, int idFirmanteCarta, Empleado miEmpleado, int idTenedoraSC, String stPeridoVacacional, String stNumeroTelefonicoPersonal, String stNumeroTelefonicoOficina, String stDiasDeDescanso, String stNombreMenor, String CURPMenor, String stNombreGuarderia, String stNombreDirectora, Decimal dcImporteSA, Decimal dcImporteSC)
        {
            stpSelObtenerCartaTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelObtenerCarta, idCarta, dcImporte, ConImporte, idFirmanteCarta, miEmpleado.IdEmpleado, idTenedoraSC, stPeridoVacacional, stNumeroTelefonicoPersonal, stNumeroTelefonicoOficina, stDiasDeDescanso, stNombreMenor, CURPMenor, stNombreGuarderia, stNombreDirectora, dcImporteSA, dcImporteSC);

            if (dbSAICBPOCatalogosDataSet.stpSelObtenerCarta.Rows.Count > 0)
            {
                if (!String.IsNullOrEmpty(dbSAICBPOCatalogosDataSet.stpSelObtenerCarta.Rows[0]["Carta"].ToString()))
                {
                    Juridico.Cartas.Carta_ConstanciaLaboral myReport = new Juridico.Cartas.Carta_ConstanciaLaboral();

                    try
                    {
                        //historial
                        queriesTableAdapter1.stpInsHisCartas(idCarta, dbSAICBPOCatalogosDataSet.stpSelObtenerCarta.Rows[0]["Carta"].ToString(), OperadorBD.OperadorGlobal.IdOperador);

                        int IdMatrizTenedora = 0;

                        int.TryParse(dbSAICBPOCatalogosDataSet.stpSelObtenerCarta.Rows[0]["IdMatrizTenedora"].ToString(), out IdMatrizTenedora);
                        myReport.Parameters["idMatrizTenedora"].Value = IdMatrizTenedora;
                        myReport.Parameters["stCarta"].Value = dbSAICBPOCatalogosDataSet.stpSelObtenerCarta.Rows[0]["Carta"].ToString();
                        myReport.ShowPrintMarginsWarning = false;
                        myReport.ShowPreview();
                    }
                    catch (Exception ex) { }
                }
                else
                {
                    XtraMessageBox.Show("Sin Información para generar la Carta.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                XtraMessageBox.Show("Sin Información para generar la Carta. 1", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MostrarInfoEmpleadoSeguros(Empleado miEmpleado)
        {
            stpSelObtenerInfoEmpleadoSegurosTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelObtenerInfoEmpleadoSeguros, miEmpleado.IdEmpleado);
        }

        private void AgregarOpcionesCartas(Empleado miEmpleado)
        {
            stpSelTipoCartasTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelTipoCartas, miEmpleado.IdEmpleado);
            cartasToolStripMenuItem.DropDownItems.Clear();
            if (dbSAICBPOCatalogosDataSet.stpSelTipoCartas.Rows.Count > 0)
            {
                cartasToolStripMenuItem.Enabled = flageHabilitarCartas;
                foreach (DataRow unData in dbSAICBPOCatalogosDataSet.stpSelTipoCartas.Rows)
                {
                    Boolean flat = false;

                    flat = unData["Habilitar"].ToString() == "1" ? true : false;

                    ToolStripMenuItem itemCarta = new ToolStripMenuItem();
                    itemCarta.Name = unData["DesTipoCarta"].ToString();
                    itemCarta.Text = unData["DesTipoCarta"].ToString();
                    itemCarta.Enabled = flat;
                    itemCarta.Click += ItemCartasToolStripMenuItem_Click;
                    cartasToolStripMenuItem.DropDownItems.Add(itemCarta);
                }
            }
            else
            {
                cartasToolStripMenuItem.Enabled = false;
            }
        }

        private void ItemCartasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow[] unData = dbSAICBPOCatalogosDataSet.stpSelTipoCartas.Select("DesTipoCarta = '" + sender.ToString() + "'");
            int idCarta = 0;
            Decimal dcImporte = 0.00M;
            Decimal dcImporteSA = 0.00M;
            Decimal dcImporteSC = 0.00M;
            Boolean ConImporte = false;
            int idFirmanteCarta = 0;
            int idTenedoraSC = 0;

            //variables Guarderia
            String stPeridoVacacional = String.Empty;
            String stNumeroTelefonicoOficina = String.Empty;
            String stNombreMenor = String.Empty;
            String CURPMenor = String.Empty;
            String stNumeroTelefonicoPersonal = String.Empty;
            String stDiasDeDescanso = String.Empty;
            String stNombreGuarderia = String.Empty;
            String stNombreDirectora = String.Empty;
            //variables Guarderia

            String stTitutlo = sender.ToString();

            Boolean flagCartaConImporte = false;
            Boolean conTenedoraSC = false;

            if (unData.Count() > 0)
            {
                int.TryParse(unData[0].ItemArray[0].ToString(), out idCarta);

                flagCartaConImporte = unData[0].ItemArray[0].ToString() == "1" || unData[0].ItemArray[0].ToString() == "2" || unData[0].ItemArray[0].ToString() == "7" ? true : false;
                conTenedoraSC = unData[0].ItemArray[1].ToString().Contains("EXCEDENTE") || unData[0].ItemArray[1].ToString().Contains("APPJ") ? true : false;

                if (idCarta == 5)//Validar Carta de Guarderia
                {
                    using (var form = new tools.xFormsCartaGuarderia(stTitutlo, objEmp))
                    {
                        var result = form.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            stPeridoVacacional = form.stPeridoVacacional;
                            stNumeroTelefonicoOficina = form.stNumeroTelefonicoOficina;
                            stNombreMenor = form.stNombreMenor;
                            stNumeroTelefonicoPersonal = form.stNumeroTelefonicoPersonal;
                            stDiasDeDescanso = form.stDiasDeDescanso;
                            CURPMenor = form.CURPMenor;
                            idFirmanteCarta = form.idFirmanteCarta;
                            stNombreGuarderia = form.stNombreGuarderia;
                            stNombreDirectora = form.stNombreDirectora;

                            obtenerDatosCarta(idCarta, dcImporte, ConImporte, idFirmanteCarta, objEmp, idTenedoraSC, stPeridoVacacional, stNumeroTelefonicoPersonal, stNumeroTelefonicoOficina, stDiasDeDescanso, stNombreMenor, CURPMenor, stNombreGuarderia, stNombreDirectora, 0.00M, 0.00M);
                        }
                    }
                }
                else
                {
                    using (var form = new tools.xFormsSolicitarMonto(stTitutlo, flagCartaConImporte, conTenedoraSC, idCarta))
                    {
                        var result = form.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            dcImporte = form.dcImporte;
                            dcImporteSA = form.dcImporteSA;
                            dcImporteSC = form.dcImporteSC;
                            ConImporte = form.ConImporte;

                            idFirmanteCarta = form.idFirmanteCarta;
                            idTenedoraSC = form.idTenedoraSC;
                            obtenerDatosCarta(idCarta, dcImporte, ConImporte, idFirmanteCarta, objEmp, idTenedoraSC, stPeridoVacacional, stNumeroTelefonicoPersonal, stNumeroTelefonicoOficina, stDiasDeDescanso, stNombreMenor, CURPMenor, stNombreGuarderia, stNombreDirectora, dcImporteSA, dcImporteSC);
                        }
                    }
                }
            }
        }

        private void bajaDeEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult drResultado = XtraMessageBox.Show("¿Desea Solicitar la Baja de " + cboIdEmpleado.Text + "?"
  , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes == drResultado)
            {
                XtraMotivoBajaEmpleado bajaEmpleado = new XtraMotivoBajaEmpleado(objEmp, 1, DateTime.Now);
                bajaEmpleado.ShowDialog();
                cargarInformacion();
            }
        }

        private void solicitudDeAltaDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objEmp != null)
            {
                stpSelSolicitudAltaCuentaEmpleadoConSolicitudTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelSolicitudAltaCuentaEmpleadoConSolicitud, objEmp.IdEmpleado);

                if (dbSAICBPOCatalogosDataSet.stpSelSolicitudAltaCuentaEmpleadoConSolicitud.Rows.Count == 0)
                {
                    String stNombreCompletoEmpleado = objEmp.APaternoEmpleado + " " + objEmp.AMaternoEmpleado + " " + objEmp.NombreEmpleado;
                    XtraSolicitudAltaCtaBancarias xtraSolCtabancarias =
                        new XtraSolicitudAltaCtaBancarias(objEmp, 0, false);
                    xtraSolCtabancarias.ShowDialog();
                    cargarInformacion();
                }
                else
                {
                    XtraMessageBox.Show("El Empleado tiene una Solicitud de Actualización de Cuenta activa. Solicitud " +
                        dbSAICBPOCatalogosDataSet.stpSelSolicitudAltaCuentaEmpleadoConSolicitud.Rows[0]["IdSolicitud"].ToString() + " en Estatus: " +
                        dbSAICBPOCatalogosDataSet.stpSelSolicitudAltaCuentaEmpleadoConSolicitud.Rows[0]["DescEstatus"].ToString() + "." + Environment.NewLine +
                        "No se puede solicitar la actualización de cuenta."
                    , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void eliminarArchivos(List<String> lstRutaArchvios)
        {
            foreach (String item in lstRutaArchvios) { File.Delete(item); }
        }

        private void txtCodigoPostalFiscal_EditValueChanged(object sender, EventArgs e)
        {
            if (txtCodigoPostalFiscal.Text.Count() > 4)
            {
                String sResultado = String.Empty;
                String sDescEstadoFiscal = String.Empty;
                int? idEstado = 0;

                stpSelValidarCodigoPostalTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelValidarCodigoPostal,
                    txtCodigoPostalFiscal.Text,
                    ref idEstado,
                    ref sDescEstadoFiscal,
                    ref sResultado);

                if (!String.IsNullOrEmpty(sResultado))
                {
                    XtraMessageBox.Show(sResultado,
                    "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEstadoFiscal.Text = String.Empty;
                }
                else
                {
                    txtEstadoFiscal.Text = sDescEstadoFiscal;
                }
            }
            else
            {
                txtEstadoFiscal.Text = String.Empty;
            }
        }

        private void actualizaciónDeSalariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //revisar si el empleado cuenta con solicitud de salarios activa
            stpSelValidacionDeSolicitudesActivasTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelValidacionDeSolicitudesActivas, objEmp.IdEmpleado);
            if (dbSAICBPOCatalogosDataSet.stpSelValidacionDeSolicitudesActivas.Rows.Count == 0)
            {
                //      Boolean flagSolicitar
                //, int idSolicitud
                //, int idEmpleado
                //, String stNombreCompletoEmpleado
                //  , decimal dcParteVariable
                //  , String stObservaciones
                //  , DateTime dtFechaDeAplicacion

                XtrasSolicitudSalariosEmpleado oXtrasSolicitudSalariosEmpleado = new XtrasSolicitudSalariosEmpleado(
                    true
                    , 0
                    , objEmp
                    , 0
                    , 0
                    , DateTime.Now);
                oXtrasSolicitudSalariosEmpleado.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Empleado con Solicitud pendiente por Atender " + dbSAICBPOCatalogosDataSet.stpSelValidacionDeSolicitudesActivas.Rows[0]["idSolicitud"].ToString() + ". No se puede Solicitar el cambio de Salario."
                    , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public Empleado ObtenerInformacionEmpleado(int IdEmpleado)
        {
            DataTable dt = this.stpSelObtenerInfoEmpleadoModificacionCFDITableAdapter1.GetData(IdEmpleado);
            Empleado oEmpleado = EmpleadoBD.ObtenerInfoEmpleadoModificacionCFDI(dt);
            return oEmpleado;
        }
    }
}