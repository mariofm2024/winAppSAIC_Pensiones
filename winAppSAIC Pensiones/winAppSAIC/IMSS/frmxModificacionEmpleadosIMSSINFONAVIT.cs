using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using winAppSAIC.Catalogos;
using compCatalogosSAIC;
using winAppSAIC.UtileriasLocal;

namespace winAppSAIC.IMSS
{
    public partial class frmxModificacionEmpleadosIMSSINFONAVIT : DevExpress.XtraEditors.XtraForm
    {
        Empleado objEmp;

        decimal dSD_Original = 0;
        decimal dSDC_Original = 0;
        decimal dSDI_Original = 0;

        ErrorProvider AvisoDe25UMAS = new ErrorProvider();
        public frmxModificacionEmpleadosIMSSINFONAVIT()
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
            calFechaBajaINF.EditValue = DateTime.Today;
            calFechaIngresoINF.EditValue = DateTime.Today;
            cboIdTipoDescuento.EditValue = 1;
            txtMontoDiario.Text = "0";
            cboTipoNomina.EditValue = -1;
            txtMontoPeriodo.Text = "0";

            txtPuestoContrato.Text = string.Empty;
            txtDepartamentoContrato.Text = string.Empty;
            cboIdTenedoraSA.EditValue = -1;
            cboIdEstatus.EditValue = -1;
            // cbTipoPago.EditValue = -1;
            txtNumCredito.Text = string.Empty;
            txtFactorDesc.Text = "0";
            txtMontoDesc.Text = "0";
            txtAdeudo.Text = "0";
            txtRecuperado.Text = "0";
            txtSaldo.Text = "0";

        }

        /// <summary>
        /// Método para activar o desactivar controles al momento de Editar/Cancelar/Guardar
        /// </summary>
        /// <param name="bFlag">Valor TRUE o FALSE</param>
        private void ActivarControles(bool bFlag, Constantes.TipoPerfil pTipoPerfil)
        {
            // txtSalarioDiarioContrato.Enabled = bFlag;
            dateFechaParaElCalculoSD.Enabled = bFlag;
            txtSalarioDiarioContrato.Enabled = bFlag;
            txtSalarioBaseCotizacionContrato.Enabled = bFlag;
            txtSalarioDiarioIntegradoContrato.Enabled = bFlag;
            calFechaIngresoINF.Enabled = bFlag;
            calFechaBajaINF.Enabled = bFlag;
            txtNumCredito.Enabled = bFlag;
            cboIdTipoDescuento.Enabled = bFlag;
            //cbTipoPago.Enabled = bFlag;
            txtFactorDesc.Enabled = bFlag;
            chkEstatusCredito.Enabled = bFlag;
            txtMontoDesc.Enabled = bFlag;
            txtAdeudo.Enabled = bFlag;

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
            objEmp.IdTenedoraSA = Convert.ToInt32(cboIdTenedoraSA.EditValue);
            objEmp.TenedoraSA = cboIdTenedoraSA.Text.Trim();
            objEmp.IdEstatus = Convert.ToByte(cboIdEstatus.EditValue);
            objEmp.IdTipoPeriodoNomina = (byte)cboTipoNomina.EditValue;

            objEmp.SalarioDiarioContrato = Convert.ToDecimal(txtSalarioDiarioContrato.Text);
            objEmp.SalarioBaseCotizacionContrato = Convert.ToDecimal(txtSalarioBaseCotizacionContrato.Text);
            objEmp.SalarioDiarioIntegradoContrato = Convert.ToDecimal(txtSalarioDiarioIntegradoContrato.Text);

            objEmp.EstatusINFONAVIT = chkEstatusCredito.Checked;
            objEmp.NoCreditoInfonavit = txtNumCredito.Text.Trim();
            objEmp.IdParametroPagoInfonavit = cbTipoPago.EditValue != null ? Convert.ToInt32(cbTipoPago.EditValue) : 0;
            objEmp.IdTipoFactorDescuento = cboIdTipoDescuento.EditValue != null ? Convert.ToInt32(cboIdTipoDescuento.EditValue) : 0;
            objEmp.IdTipoUnidadMedidaPago = 0;
            objEmp.FechaSalario = DateTime.Today;
            objEmp.ValorTipoPago = Convert.ToDecimal(txtValorTipoPago.Text);
            objEmp.FactorDescuento = Convert.ToDecimal(txtFactorDesc.Text);
            objEmp.MontoDescuento = Convert.ToDecimal(txtMontoDesc.Text);
            objEmp.MontoDescuentoDiario = Convert.ToDecimal(txtMontoDiario.Text);
            objEmp.FechaInicioDesc = Convert.ToDateTime(calFechaIngresoINF.EditValue);
            objEmp.FechaFinDesc = Convert.ToDateTime(calFechaBajaINF.EditValue);
            objEmp.MontoRecuperar = Convert.ToDecimal(txtAdeudo.Text);
            objEmp.MontoRecuperado = Convert.ToDecimal(txtRecuperado.Text);
            objEmp.Saldo = Convert.ToDecimal(txtSaldo.Text);

            objEmp.UsuarioCreacion = OperadorBD.OperadorGlobal.NombreUsuario;
            objEmp.UsuarioModificacion = OperadorBD.OperadorGlobal.NombreUsuario;

            return objEmp;
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

            dSD_Original = objEmp.SalarioDiarioContrato;
            dSDI_Original = objEmp.SalarioBaseCotizacionContrato;
            dSDC_Original = objEmp.SalarioDiarioIntegradoContrato;

            calFechaIngresoReingresoContrato.EditValue = objEmp.FechaIngresoContrato;
            calFechaBajaContrato.EditValue = objEmp.FechaBajaContrato;
            txtPuestoContrato.Text = objEmp.PuestoContrato;
            txtDepartamentoContrato.Text = objEmp.DepartamentoContrato;
            cboIdTenedoraSA.EditValue = objEmp.IdTenedoraSA;
            cboIdEstatus.EditValue = objEmp.IdEstatus;
            txtNumCredito.Text = objEmp.NoCreditoInfonavit;
            chkEstatusCredito.Checked = objEmp.EstatusINFONAVIT;
            cboTipoNomina.EditValue = objEmp.IdTipoPeriodoNomina;
            txtMontoPeriodo.EditValue = objEmp.MontoDescuentoPeriodo;

            cboIdTipoDescuento.EditValue = objEmp.IdTipoFactorDescuento;
            cbTipoPago.EditValue = objEmp.IdParametroPagoInfonavit;
            txtValorTipoPago.Text = objEmp.ValorTipoPago.ToString("N2");
            txtFactorDesc.Text = objEmp.FactorDescuento.ToString("N4");
            txtMontoDesc.Text = objEmp.MontoDescuento.ToString("N2");
            txtMontoDiario.Text = objEmp.MontoDescuentoDiario.ToString("N2");
            calFechaIngresoINF.EditValue = objEmp.FechaInicioDesc;
            calFechaBajaINF.EditValue = objEmp.FechaFinDesc;
            txtAdeudo.Text = objEmp.MontoRecuperar.ToString("N2");
            txtRecuperado.Text = objEmp.MontoRecuperado.ToString("N2");
            txtSaldo.Text = objEmp.Saldo.ToString("N2");
            txtEsquema.Text = objEmp.IdTipoMovimiento;
            txtCliente.Text = objEmp.RazonSocialCliente;
            txtJornadaDeServicio.Text = objEmp.descJornadaServicio;

            EstatusCredito();            
            //txtParteVariable.Value = objEmp.dcParteVariable;
        }

        /// <summary>
        /// Método que actualiza la información del empleado
        /// </summary>
        private void ActualizarInfoEmpleado()
        {
            Empleado objEmp = AsignarInfoEmpleado();    //crear objeto y asignar valores

            //accion de actualizar
            bool bFlagUpdateDatosEmpleado = EmpleadoBD.ActualizarInfoEmpleadoIMSS(objEmp, winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString);

            bool bFlagUpdate = EmpleadoBD.ActualizarInfoEmpleadoINFONAVIT(objEmp, winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString);

            if (bFlagUpdate && bFlagUpdateDatosEmpleado)    //fue correcta la modificacion
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

            txtNombreEmpleado.Enabled = !bFlag;
            txtAPaternoEmpleado.Enabled = !bFlag;
            txtAMaternoEmpleado.Enabled = !bFlag;
            txtNSS.Enabled = !bFlag;
            txtRFC.Enabled = !bFlag;
            txtCURP.Enabled = !bFlag;
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

        private void frmxModificacionEmpleadosIMSSINFONAVIT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet.stpSelTipoPeriodoNomina' table. You can move, or remove it, as needed.
            this.stpSelTipoPeriodoNominaTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelTipoPeriodoNomina);

            try
            {
                // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet.vwCatTipoDescuento' table. You can move, or remove it, as needed.
                this.vwCatTipoDescuentoTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.vwCatTipoDescuento);

                this.stpSelEmpleadosDisponiblesIMSSTableAdapter1.Fill(this.dbSAICBPOCatalogosDataSet.stpSelEmpleadosDisponiblesIMSS);

                // TODO: This line of code loads data into the 'dbSAICBPODataSet.vwCatTenedoraSA' table. You can move, or remove it, as needed.
                this.vwCatTenedoraSATableAdapter.Fill(this.dbSAICBPODataSet.vwCatTenedoraSA);
                //llenar combobox Estatus Empleados
                this.vwCatEstatusEmpleadoCFDITableAdapter.Fill(this.dbSAICBPONominaCFDIDataSet.vwCatEstatusEmpleadoCFDI);

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


                // Set column widths according to their contents. 
                cboIdEmpleado.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cboIdEmpleado.Properties.PopupFormWidth = 700;

                habilitarBotonVariables();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        Boolean flagHabilitarBoton;
        private void habilitarBotonVariables()
        {
            this.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1.Fill(this.dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion, OperadorBD.OperadorGlobal.IdOperador, "ModificacionEmpleadosIMSS.Botones", "btnAcceso1");
            if (dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion.Rows.Count > 0)
            {
                Boolean.TryParse(dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion.Rows[0]["Consultar"].ToString(), out flagHabilitarBoton);
            }
            else
            {
                flagHabilitarBoton = false;
            }

            if (flagHabilitarBoton)
            {
                barVariablesEmpleados.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                barVariablesEmpleados.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
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
                frmxModificacionEmpleados ofrmxModificacionEmpleados = new frmxModificacionEmpleados(0, false, false, false, false, false, 0);

                decimal dSD = 0;
                decimal dSBC = 0;
                decimal dSDI = 0;
                DateTime dtFechaParaElCalculo = new DateTime();

                decimal.TryParse(txtSalarioDiarioContrato.Text, out dSD);
                decimal.TryParse(txtSalarioBaseCotizacionContrato.Text, out dSBC);
                decimal.TryParse(txtSalarioDiarioIntegradoContrato.Text, out dSDI);
                DateTime.TryParse(dateFechaParaElCalculoSD.Text, out dtFechaParaElCalculo);

                Boolean flagValidacionDeSalarios = ofrmxModificacionEmpleados.validarSalariosEmpleadoContrato(dSD, dSBC, dSDI, txtEsquema.Text, txtJornadaDeServicio.Text, false, dtFechaParaElCalculo, String.Empty, String.Empty, String.Empty);

                int bflag = 0;
                if (Validator.IsDecimal(txtSalarioBaseCotizacionContrato) &&
                    Validator.IsDecimal(txtSalarioDiarioIntegradoContrato) &&
                    Validator.IsPositiveNumber(txtSalarioDiarioContrato) &&
                    Validator.IsPositiveNumber(txtSalarioBaseCotizacionContrato) &&
                    Validator.IsPositiveNumber(txtSalarioDiarioIntegradoContrato) && flagValidacionDeSalarios)
                {
                    bflag = 1;
                    if (chkEstatusCredito.Checked == true)
                    {
                        if (Validator.IsPresent(txtNumCredito) &&
                            Validator.IsPositiveNumber(txtNumCredito) &&
                            Validator.IsWithinRange(txtNumCredito, "El No. de Credito Infonavit, debe de contener 10 dig.", 10) &&
                            Validator.IsDecimal(txtFactorDesc) &&
                            Validator.IsDecimal(txtMontoDesc) &&
                            IsValidDate(calFechaIngresoINF))
                        {
                            bflag = 1;
                        }
                        else
                        {
                            bflag = 0;
                        }
                    }

                    //Buscar informacion del Empleado CFDI con NSS por actualizar
                    DataTable dt = this.stpSelValidarExistenciaNSSTableAdapter1.GetData(txtNSS.Text);

                    //validar NSS
                    if (Validator.NotExistNSS(dt, txtNSS, strNSSOriginal, txtNSS.Text) && bflag == 1)
                    {
                        ActualizarInfoEmpleado();       //actualizar la información del empleado
                    }
                }
                else
                {
                    XtraMessageBox.Show("NO fue posible actualizar la información del Empleado", "SAIC",
                       MessageBoxButtons.OK, MessageBoxIcon.Stop);
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

            ActivarBotones(false);
            estatusBoton = EstatusBotones.Editar;    //asignar accion EDITAR
            ActivarControles(true, tipoPerfil);     //desbloqueo de controles permitidos
            EstatusCredito();
            if (chkEstatusCredito.Checked == false && txtNumCredito.Text == "")
                calFechaIngresoINF.Text = calFechaIngresoReingresoContrato.Text;

            //asignar el NSS Original
            strNSSOriginal = txtNSS.Text;
            //asignar el Estatus Original
            byEstatusOriginal = Convert.ToByte(cboIdEstatus.EditValue);

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

        private void btnSolicitarTramiteIMSS_Click(object sender, EventArgs e)
        {
            //validar que exista un empleado activo
            if (txtNoEmpleado.Text.Length > 0)
            {
                //validar que el empleados tenga esquema S o M

                IMSS.frmxSolicitudTramiteIMSSOperaciones objSolicitudTramiteIMSS = new IMSS.frmxSolicitudTramiteIMSSOperaciones();

                objSolicitudTramiteIMSS.txtNoEmpleado.Text = txtNoEmpleado.Text;
                objSolicitudTramiteIMSS.txtNSS.Text = txtNSS.Text;
                objSolicitudTramiteIMSS.txtNombreEmpleado.Text = txtNombreEmpleado.Text;
                objSolicitudTramiteIMSS.txtAPaternoEmpleado.Text = txtAPaternoEmpleado.Text;
                objSolicitudTramiteIMSS.txtAMaternoEmpleado.Text = txtAMaternoEmpleado.Text;

                objSolicitudTramiteIMSS.ShowDialog();   //mostrar pantalla
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
                    lblFechaIngresoReingreso.Location = new Point(171, 36);
                    lblFechaIngresoReingreso.Text = "Fecha de Ingreso";
                    //calFechaBajaContrato.EditValue = new DateTime(1900, 1, 1);
                    break;

                case 8:          //8=BAJA
                    //calFechaBajaContrato.EditValue = DateTime.Now.ToShortDateString();      //asignar fecha actual
                    break;

                case 9:         //9=REINGRESO
                    lblFechaIngresoReingreso.Location = new Point(160, 36);
                    lblFechaIngresoReingreso.Text = "Fecha de Reingreso";
                    //calFechaIngresoReingresoContrato.EditValue = DateTime.Now.ToShortDateString();       //asignar fecha actual
                    break;
            }
        }



        private void cboIdEmpleado_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cboIdEmpleado.EditValue) <= 0)  //si el No. de empleado es menor o igual a 0
            {
                XtraMessageBox.Show("No ha escrito un No. de Empleado válido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                cboIdEmpleado.Focus();        //colocar cursor en control
            }
            else
            {
                //cargar informacion detalla del Empleado CFDI
                DataTable dt = this.stpSelObtenerInfoEmpleadoModificacionCFDIvIMSSTableAdapter.GetData(Convert.ToInt32(cboIdEmpleado.EditValue));

                //Asignar información detallada del Empleado CFDI al Objeto Empleado
                objEmp = EmpleadoBD.ObtenerInfoEmpleadoModificacionCFDIvIMSS(dt);

                if (objEmp != null)
                {
                    MostrarInfoEmpleado(objEmp);        //mostrar informacion del Emplead
                    ObtenerFechaCalculoSD();
                    ActivarBotones(true);
                    ActivarControles(false, tipoPerfil);
                    ObtenerValorUMA();
                }
                else
                {
                    LimpiarControles();     //limpiar controles

                    XtraMessageBox.Show("No existe el empleado solicitado.", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboIdEmpleado.Focus();        //colocar cursor en control
                }
            }
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();        //cerrar pantalla
        }

        private void chkEstatusCredito_CheckedChanged(object sender, EventArgs e)
        {
            EstatusCredito();
        }

        private void EstatusCredito()
        {
            bool bFlag = false;

            if (chkEstatusCredito.Checked == true)
            {
                bFlag = true;
                calFechaIngresoINF.Enabled = bFlag;
                calFechaBajaINF.Enabled = bFlag;
                txtNumCredito.Enabled = bFlag;
                cboIdTipoDescuento.Enabled = bFlag;
                // cbTipoPago.Enabled = bFlag;
                txtFactorDesc.Enabled = bFlag;
                txtMontoDesc.Enabled = bFlag;
            }
            else
            {
                calFechaIngresoINF.Enabled = bFlag;
                calFechaBajaINF.Enabled = bFlag;
                txtNumCredito.Enabled = bFlag;
                cboIdTipoDescuento.Enabled = bFlag;
                // cbTipoPago.Enabled = bFlag;
                txtFactorDesc.Enabled = bFlag;
                txtMontoDesc.Enabled = bFlag;
            }
        }

        private void cboIdTipoDescuento_EditValueChanged(object sender, EventArgs e)
        {
            this.stpSelObtenerTipoUnidadMedidaPagoTableAdapter1.Fill(this.dbSAICBPOCatalogosDataSet.stpSelObtenerTipoUnidadMedidaPago, Convert.ToInt32(cboIdTipoDescuento.EditValue));
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

        private void txtFactorDesc_EditValueChanged(object sender, EventArgs e)
        {
            if (txtNoEmpleado.Text != "" && cbTipoPago.EditValue.ToString() != "" && txtFactorDesc.Text != "")
            {
                if (Convert.ToDecimal(txtFactorDesc.Text) > 0)
                {
                    this.stpSelObtenerCalculoInfonavitTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelObtenerCalculoInfonavit, Convert.ToInt32(txtNoEmpleado.Text), Convert.ToInt32(cbTipoPago.EditValue), Convert.ToDateTime(DateTime.Today), Convert.ToDouble(txtFactorDesc.Text));
                    if (this.dbSAICBPOCatalogosDataSet.stpSelObtenerCalculoInfonavit != null && this.dbSAICBPOCatalogosDataSet.stpSelObtenerCalculoInfonavit.Rows.Count > 0)
                    {
                        txtMontoDesc.Text = this.dbSAICBPOCatalogosDataSet.stpSelObtenerCalculoInfonavit.Rows[0]["MontoMensual"].ToString();
                        txtMontoDiario.Text = this.dbSAICBPOCatalogosDataSet.stpSelObtenerCalculoInfonavit.Rows[0]["MontoDiario"].ToString();
                    }
                    else
                    {
                        txtMontoDesc.Text = txtFactorDesc.Text;
                    }
                }
                else
                {
                    txtMontoDesc.Text = txtFactorDesc.Text;
                }

            }
        }

        private void cbTipoPago_EditValueChanged(object sender, EventArgs e)
        {
            txtValorTipoPago.Text = "0";
            txtFactorDesc.Text = "0";
            txtMontoDesc.Text = "0";
            txtMontoDiario.Text = "0";
            if (cbTipoPago.EditValue.ToString() != "")
            {
                this.stpSelObtenerValorTipodePagoInfonavitTableAdapter1.Fill(this.dbSAICBPOCatalogosDataSet.stpSelObtenerValorTipodePagoInfonavit, Convert.ToInt32(cbTipoPago.EditValue), DateTime.Today);

                if (this.dbSAICBPOCatalogosDataSet.stpSelObtenerValorTipodePagoInfonavit != null && this.dbSAICBPOCatalogosDataSet.stpSelObtenerValorTipodePagoInfonavit.Rows.Count > 0)
                    txtValorTipoPago.Text = this.dbSAICBPOCatalogosDataSet.stpSelObtenerValorTipodePagoInfonavit.Rows[0]["Monto"].ToString();

            }
        }

        private void txtMontoDesc_EditValueChanged(object sender, EventArgs e)
        {
            txtMontoDiario.Text = Convert.ToString(Convert.ToDouble(txtMontoDesc.Text) / 30.4);
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }


        private void ObtenerFechaCalculoSD()
        {
            dateFechaParaElCalculoSD.Text = ObtenerFechaServidor().Date.ToShortDateString();
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

        private void dateFechaParaElCalculoSD_EditValueChanged(object sender, EventArgs e)
        {
            ObtenerValorUMA();
        }

        Decimal dcmUMA;
        Decimal dcmUMA25;
        private void ObtenerValorUMA()
        {
            //validar las 25 umas
            OperadoresM.XtraAltaEmpleados AltaEmpleados = new OperadoresM.XtraAltaEmpleados("");
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

        private void barVariablesEmpleados_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (objEmp != null)
            {
                XtraAsignarVariablesEmpleado oXtraAsignarVariablesEmpleado = new XtraAsignarVariablesEmpleado(objEmp.IdEmpleado, objEmp.APaternoEmpleado + " " + objEmp.AMaternoEmpleado + " " + objEmp.NombreEmpleado);
                oXtraAsignarVariablesEmpleado.ShowDialog();
            }
        }
    }
}