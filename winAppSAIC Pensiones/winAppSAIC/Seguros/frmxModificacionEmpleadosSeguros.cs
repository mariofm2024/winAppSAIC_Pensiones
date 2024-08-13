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

namespace winAppSAIC.Seguros
{
    public partial class frmxModificacionEmpleadosSeguros : DevExpress.XtraEditors.XtraForm
    {
        public frmxModificacionEmpleadosSeguros()
        {
            InitializeComponent();
        }

        Boolean flagGuardar = false;
        Boolean flagActualizar = false;

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
            calFechaIngresoReingresoContrato.EditValue = DateTime.Today;
            calFechaBajaContrato.EditValue = DateTime.Today;

            txtPuestoContrato.Text = string.Empty;
            txtDepartamentoContrato.Text = string.Empty;
            cboIdTenedoraSA.EditValue = -1;
            cboIdEstatus.EditValue = -1;
            cboIdTipoPoliza.EditValue = -1;
            cboIdCliente.EditValue = -1;
            cboIdTipoSeguro.EditValue = -1;
            txtFolio.Text = String.Empty;
        }

        private void LimpiarControlesPoliza()
        {
            cboIdTipoSeguro.EditValue = -1;
            cboIdTipoPoliza.EditValue = -1;
            txtFolio.Text = String.Empty;
            txtEmpleadoPoliza.Text = "0";
        }

        /// <summary>
        /// Método para activar o desactivar controles al momento de Editar/Cancelar/Guardar
        /// </summary>
        /// <param name="bFlag">Valor TRUE o FALSE</param>

        private void MostrarBotones(bool bFlag)
        {
            //btnActualizar.Visible = bFlag;
            //btnCancelar.Visible = !bFlag;
            //btnGuardar.Visible = !bFlag;
            //btnCancelarPoliza.Visible = !bFlag;
            //simpleButton1.Visible = !bFlag;
        }

        private Empleado AsignarInfoEmpleado()
        {
            Empleado objEmp = new Empleado();

            objEmp.IdEmpleado = Convert.ToInt32(txtNoEmpleado.Text);
            objEmp.IdEmpleadoPoliza = Convert.ToInt32(txtEmpleadoPoliza.Text);
            objEmp.IdTipoSeguro = Convert.ToInt32(cboIdTipoSeguro.EditValue);
            objEmp.IdPoliza = Convert.ToInt32(cboIdTipoPoliza.EditValue);
            objEmp.UsuarioCreacion = OperadorBD.OperadorGlobal.NombreUsuario;
            objEmp.UsuarioModificacion = OperadorBD.OperadorGlobal.NombreUsuario;
            objEmp.Folio_Poliza = txtFolio.Text;
            objEmp.IdEstatus = (byte)cboIdEstatus.EditValue;
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
            calFechaIngresoReingresoContrato.EditValue = objEmp.FechaIngresoContrato;
            calFechaBajaContrato.EditValue = objEmp.FechaBajaContrato;
            txtPuestoContrato.Text = objEmp.PuestoContrato;
            txtDepartamentoContrato.Text = objEmp.DepartamentoContrato;
            cboIdTenedoraSA.EditValue = objEmp.IdTenedoraSA;
            cboIdEstatus.EditValue = objEmp.IdEstatus;
            cboIdCliente.EditValue = objEmp.IdCliente;
        }

        /// <summary>
        /// Metodo para desplegar el contenido del objeto Empleado
        /// </summary>
        /// <param name="objEmp">Objeto Empleado</param>
        private void MostrarInfoPoliza(Empleado objEmp)
        {
            habilitarBotonAgregar(objEmp);
            cboIdTipoSeguro.EditValue = objEmp.IdTipoSeguro;
            cboIdTipoPoliza.EditValue = objEmp.IdPoliza;
            txtEmpleadoPoliza.Text = objEmp.IdEmpleadoPoliza.ToString();
            txtFolio.Text = objEmp.Folio_Poliza;
            btnCancelarPoliza.Enabled = true;
            btnCancelar.Enabled = true;
        }

        /// <summary>
        /// Método que actualiza la información del empleado
        /// </summary>
        private void ActualizarInfoEmpleado()
        {
            Empleado objEmp = AsignarInfoEmpleado();    //crear objeto y asignar valores

            //accion de actualizar
            bool bFlagUpdate = EmpleadoBD.ActualizarInfoEmpleadoSeguro(objEmp, winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString);


            if (bFlagUpdate)    //fue correcta la modificacion
            {
                estatusBoton = EstatusBotones.Ninguno;    //asignar accion NINGUNO
                XtraMessageBox.Show("La Póliza del Empleado se Elimino satisfactoriamente",
                    "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboIdEmpleado.Focus();
            }
            else  //error en actualizacion
                XtraMessageBox.Show("NO fue posible Eliminar la Póliza del Empleado", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        private void AgregarInfoEmpleado()
        {
            Empleado objEmp = AsignarInfoEmpleado();    //crear objeto y asignar valores

            //accion de actualizar
            bool bFlagUpdate = EmpleadoBD.CrearInfoEmpleadoSeguro(objEmp, winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString);


            if (bFlagUpdate)    //fue correcta la modificacion
            {
                estatusBoton = EstatusBotones.Ninguno;    //asignar accion NINGUNO
                XtraMessageBox.Show("La Póliza del Empleado se agrego satisfactoriamente",
                    "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboIdEmpleado.Focus();
            }
            else  //error en actualizacion
                XtraMessageBox.Show("NO fue posible agregar la Póliza del Empleado", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        private void CancelarInfoEmpleado()
        {
            Empleado objEmp = AsignarInfoEmpleado();    //crear objeto y asignar valores

            //accion de actualizar
            bool bFlagUpdate = EmpleadoBD.CancelarInfoEmpleadoSeguro(objEmp, winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString);


            if (bFlagUpdate)    //fue correcta la modificacion
            {
                estatusBoton = EstatusBotones.Ninguno;    //asignar accion NINGUNO
                XtraMessageBox.Show("La Póliza del Empleado se cancelo satisfactoriamente",
                    "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboIdEmpleado.Focus();
            }
            else  //error en actualizacion
                XtraMessageBox.Show("NO fue posible cancelar la Póliza del Empleado", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void EliminarInfoEmpleado()
        {
            Empleado objEmp = AsignarInfoEmpleado();    //crear objeto y asignar valores

            //accion de actualizar
            bool bFlagUpdate = EmpleadoBD.EliminarInfoEmpleadoSeguro(objEmp, winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString);

            if (bFlagUpdate)    //fue correcta la modificacion
            {
                estatusBoton = EstatusBotones.Ninguno;    //asignar accion NINGUNO
                XtraMessageBox.Show("La Póliza del Empleado se elimino satisfactoriamente",
                    "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboIdEmpleado.Focus();
            }
            else  //error en actualizacion
                XtraMessageBox.Show("NO fue posible eliminar la Póliza del Empleado", "Error",
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

        private EstatusBotones estatusBoton;

        //enumeracion con estatus de las acciones
        enum EstatusBotones
        {
            Nuevo = 1,
            Editar = 2,
            Ninguno = 0
        }

        #endregion

        private void frmxModificacionEmpleadosSeguros_Load(object sender, EventArgs e)
        {

            try
            {
                splashScreenManager1.ShowWaitForm();
                splashScreenManager1.SetWaitFormDescription("Modulo de Seguros...");
                //MostrarBotones(true);
                // TODO: This line of code loads data into the 'dbSAICBPODataSet.vwCatCliente' table. You can move, or remove it, as needed.
                this.vwCatClienteTableAdapter.Fill(this.dbSAICBPODataSet.vwCatCliente);
                // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet.stpSelEmpleadosDisponiblesSEGUROS' table. You can move, or remove it, as needed.
                this.stpSelEmpleadosDisponiblesSEGUROSTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelEmpleadosDisponiblesSEGUROS);
                // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet.vwCatTipoDescuento' table. You can move, or remove it, as needed.
                this.stpSelEmpleadosDisponiblesTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelEmpleadosDisponibles);
                // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet.vwCatTipoSeguro' table. You can move, or remove it, as needed.
                this.vwCatTipoSeguroTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.vwCatTipoSeguro);
                // TODO: This line of code loads data into the 'dbSAICBPODataSet.vwCatTenedoraSA' table. You can move, or remove it, as needed.
                this.vwCatTenedoraSATableAdapter.Fill(this.dbSAICBPODataSet.vwCatTenedoraSA);
                //llenar combobox Estatus Empleados
                this.vwCatEstatusEmpleadoCFDITableAdapter.Fill(this.dbSAICBPONominaCFDIDataSet.vwCatEstatusEmpleadoCFDI);

                stpSelTipoSeguroTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelTipoSeguro);

                if (tipoOperacion == Constantes.TipoOperacion.ModificacionEmpleado)
                {
                    this.Text = "Modificación de Información Empleados";
                    estatusBoton = EstatusBotones.Ninguno;      //inicializo valor bandera estatus
                }
                else if (tipoOperacion == Constantes.TipoOperacion.AsignacionNSSBajaReingreso)
                {
                    this.Text = "Asignación de NSS, Modificación de Salario, Baja y Reingreso Empleados";
                }

                cboIdEmpleado.Focus();        //colocar cursor en objeto
                LimpiarControles();     //limpiar contenido controles
                bloquearElementos(false);

                // Set column widths according to their contents. 
                cboIdEmpleado.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cboIdEmpleado.Properties.PopupFormWidth = 700;

                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
            }
            catch (Exception ex)
            {
                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        Empleado objEmp;
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
                this.stpSelObtenerInfoEmpleadoSegurosTableAdapter.Fill(dbSAICBPOCatalogosDataSet.stpSelObtenerInfoEmpleadoSeguros, Convert.ToInt32(cboIdEmpleado.EditValue));
                DataTable dt = this.stpSelObtenerInfoEmpleadoSegurosTableAdapter.GetData(Convert.ToInt32(cboIdEmpleado.EditValue));

                //Asignar información detallada del Empleado CFDI al Objeto Empleado
                objEmp = EmpleadoBD.ObtenerInfoEmpleadoModificacionSeguro(dt);

                if (objEmp != null)
                {
                    LimpiarControles();
                    MostrarInfoEmpleado(objEmp);        //mostrar informacion del Empleado
                    //stpSelObtenerInfoEmpleadoSeguros.Enabled = true;
                    habilitarBotonesEmpleado(objEmp);
                }
                else
                {

                    DataTable dt1 = this.stpSelObtenerInfoEmpleadoSegurosCrearTableAdapter1.GetData(Convert.ToInt32(cboIdEmpleado.EditValue));
                    objEmp = EmpleadoBD.ObtenerInfoEmpleadoModificacionSeguro(dt1);

                    if (objEmp != null)
                    {
                        MostrarInfoEmpleado(objEmp);        //mostrar informacion del Emplead
                        //stpSelObtenerInfoEmpleadoSeguros.Enabled = false;
                        habilitarBotonesEmpleado(objEmp);
                    }
                    else
                    {
                        LimpiarControles(); //limpiar controles
                        XtraMessageBox.Show("No existe el empleado solicitado..", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cboIdEmpleado.Focus();        //colocar cursor en control
                    }
                }
            }
        }

        /// <summary>
        /// habilitar botones dependienteo del estatus del empleado
        /// </summary>
        /// <param name="miEmpleado"></param>
        private void habilitarBotonesEmpleado(Empleado miEmpleado)
        {
            if (miEmpleado.IdEstatus == 7 || miEmpleado.IdEstatus == 9) // Alta || Reingreso
            {
                btnAgregar_Poliza.Enabled = true;
            }
            else
            {
                btnAgregar_Poliza.Enabled = false;
            }

            btnEditar.Enabled = false;
            btnCancelarPoliza.Enabled = false;
            btnCancelar.Enabled = false;
            simpleButton1.Enabled = false;
            simpleButton2.Enabled = false;
            LimpiarTextPoliza();
        }

        private void habilitarBotonAgregar(Empleado miEmpleado)
        {
            if (miEmpleado.IdEstatus == 7 || miEmpleado.IdEstatus == 9) // Alta || Reingreso
            {
                btnAgregar_Poliza.Enabled = true;
                btnEditar.Enabled = true;
            }
            else
            {
                btnAgregar_Poliza.Enabled = false;
                btnEditar.Enabled = false;
            }
        }

        private void LimpiarTextPoliza()
        {
            txtEmpleadoPoliza.Text = String.Empty;
            cboIdTipoSeguro.EditValue = -1;
            cboIdTipoPoliza.EditValue = -1;
            txtFolio.Text = String.Empty;
        }

        private void ActualizarGrid()
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
                this.stpSelObtenerInfoEmpleadoSegurosTableAdapter.Fill(dbSAICBPOCatalogosDataSet.stpSelObtenerInfoEmpleadoSeguros, Convert.ToInt32(cboIdEmpleado.EditValue));
                DataTable dt = this.stpSelObtenerInfoEmpleadoSegurosTableAdapter.GetData(Convert.ToInt32(cboIdEmpleado.EditValue));

                //Asignar información detallada del Empleado CFDI al Objeto Empleado
                Empleado objEmp = EmpleadoBD.ObtenerInfoEmpleadoModificacionSeguro(dt);

                if (objEmp != null)
                {
                    MostrarInfoEmpleado(objEmp);        //mostrar informacion del Emplead
                    //stpSelObtenerInfoEmpleadoSeguros.Enabled = true;
                    habilitarBotonesEmpleado(objEmp);
                }
                else
                {

                    DataTable dt1 = this.stpSelObtenerInfoEmpleadoSegurosCrearTableAdapter1.GetData(Convert.ToInt32(cboIdEmpleado.EditValue));
                    Empleado objEmp2 = EmpleadoBD.ObtenerInfoEmpleadoModificacionSeguro(dt1);

                    if (objEmp2 != null)
                    {
                        MostrarInfoEmpleado(objEmp2);        //mostrar informacion del Emplead
                        //stpSelObtenerInfoEmpleadoSeguros.Enabled = false;
                        habilitarBotonesEmpleado(objEmp2);
                    }
                    else
                    {
                        LimpiarControles(); //limpiar controles
                        XtraMessageBox.Show("No existe el empleado solicitado..", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cboIdEmpleado.Focus();        //colocar cursor en control
                    }
                }
            }

        }
        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();        //cerrar pantalla
        }

        private void stpSelObtenerInfoEmpleadoSeguros_DoubleClick(object sender, EventArgs e)
        {

        }

        private void stpSelObtenerInfoEmpleadoSeguros_Click(object sender, EventArgs e)
        {

            if (gridViewPolizasEmpleados.FocusedRowHandle >= 0)
            {
                btnAgregar_Poliza.Enabled = true;
                //btnActualizar.Enabled = true;
                MostrarInfoPoliza(ObtenerInfoPoliza());
            }
        }

        private Empleado ObtenerInfoPoliza()
        {
            //si el usuario seleccionó un renglon, entonces regresar el valor IdTransaccionBanco
            if (gridViewPolizasEmpleados.FocusedRowHandle >= 0)
            {
                //obtener la información del renglon completo
                DataRow row = gridViewPolizasEmpleados.GetDataRow(gridViewPolizasEmpleados.FocusedRowHandle);
                //asignar InfoDetalle Solicitud Cheque Masivo
                return EmpleadoBD.ObtenerInfoPolizaEmpleadoGrid(row);
            }
            else
                return null;       //si no se ha seleccionado un renglon válido, entonces regresar 0
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (Validator.IsPresent(cboIdTipoSeguro) &&
                Validator.IsPresent(cboIdTipoPoliza))
            {
                ActualizarInfoEmpleado();       //actualizar la información del empleado
                ActualizarGrid();
                txtEmpleadoPoliza.Text = "0";
                MostrarBotones(true);
            }
            else
                XtraMessageBox.Show("NO fue posible guardar la Póliza del Empleado, La Póliza ya está asignada", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            DialogResult resultado = XtraMessageBox.Show("¿Desea Eliminar la Póliza del Empleado?", "SAIC",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes == resultado)
            {
                if (Validator.IsPresent(cboIdTipoSeguro) &&
                    Validator.IsPresent(cboIdTipoPoliza))
                {
                    EliminarInfoEmpleado();       //actualizar la información del empleado
                    ActualizarGrid();
                    txtEmpleadoPoliza.Text = "0";
                    habilitarBotonesEmpleado(objEmp);
                    LimpiarControlesA();
                }
                else
                    XtraMessageBox.Show("NO fue posible Cancelar la Póliza del Empleado", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void cboIdTipoSeguro_EditValueChanged(object sender, EventArgs e)
        {
            if (cboIdTipoSeguro.EditValue.ToString() != "")
                this.stpSelObtenerTipoPolizaTableAdapter1.Fill(this.dbSAICBPOCatalogosDataSet.stpSelObtenerTipoPoliza, Convert.ToInt32(cboIdTipoSeguro.EditValue));
        }

        private void btnCancelarPoliza_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(cboIdTipoSeguro) &&
               Validator.IsPresent(cboIdTipoPoliza))
            {
                String stNombreCompleto = txtNombreEmpleado.Text + " " + txtAPaternoEmpleado.Text + " " + txtAMaternoEmpleado.Text;
                DialogResult Resultado = XtraMessageBox.Show("¿Esta seguro de Cancelar la Póliza del Empleado " + stNombreCompleto + "?", "SAIC",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult.Yes == Resultado)
                {
                    CancelarInfoEmpleado();       //actualizar la información del empleado
                    ActualizarGrid();
                    txtEmpleadoPoliza.Text = "0";
                    habilitarBotonesEmpleado(objEmp);
                    LimpiarControlesA();
                }
            }
            else
            {
                XtraMessageBox.Show("NO fue posible Cancelar la Póliza del Empleado", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void LimpiarControlesA()
        {
            txtEmpleadoPoliza.Text = "0";
            cboIdTipoSeguro.EditValue = -1;
            cboIdTipoPoliza.EditValue = -1;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            habilitarBotonesPoliza(false);
            flagGuardar = false;
            flagActualizar = false;
            simpleButton2.Enabled = false;
            simpleButton1.Enabled = false;
            btnAgregar_Poliza.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelarPoliza.Enabled = false;
            btnCancelar.Enabled = false;
            habilitarBotonesEmpleado(objEmp);
        }

        private void repositoryItemButtonCancelarPoliza_Click(object sender, EventArgs e)
        {

        }

        private void repositoryItemButtonEliminarPoliza_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            habilitarBotonesPoliza(true);
            btnAgregar_Poliza.Enabled = false;
            simpleButton1.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelarPoliza.Enabled = false;
            btnCancelar.Enabled = false;
            simpleButton2.Enabled = true;
            LimpiarControlesPoliza();
            flagGuardar = true;
            flagActualizar = false;
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnCancelarPoliza.Enabled = false;
            btnCancelar.Enabled = false;
            txtFolio.Enabled = true;
            cboIdTipoPoliza.Enabled = false;
            simpleButton1.Enabled = true;
            btnAgregar_Poliza.Enabled = false;
            simpleButton2.Enabled = true;
            flagActualizar = true;
            flagGuardar = false;
        }
        private void habilitarBotonesPoliza(Boolean flaghabilitar)
        {
            cboIdTipoSeguro.Enabled = flaghabilitar;
            cboIdTipoPoliza.Enabled = flaghabilitar;
            txtFolio.Enabled = flaghabilitar;
        }

        private void habilitarBotonesPolizaEditar(Boolean flaghabilitar)
        {
            cboIdTipoPoliza.Enabled = flaghabilitar;
            txtFolio.Enabled = flaghabilitar;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (flagGuardar)
                {
                    if (Validator.IsPresent(cboIdTipoSeguro) &&
                          Validator.IsPresent(cboIdTipoPoliza))
                    {
                        AgregarInfoEmpleado();       //actualizar la información del empleado
                        ActualizarGrid();
                        LimpiarControlesA();
                        bloquearElementos(false);
                    }
                    else
                        XtraMessageBox.Show("NO fue posible Agregar la Póliza del Empleado, La Póliza ya esta asignada.", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    txtEmpleadoPoliza.Text = "0";

                    btnAgregar_Poliza.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelarPoliza.Enabled = true;
                    btnCancelar.Enabled = true;
                    simpleButton2.Enabled = false;
                }
                else if (flagActualizar)
                {
                    if (Validator.IsPresent(cboIdTipoSeguro) &&
                          Validator.IsPresent(cboIdTipoPoliza))
                    {
                        int IdEmpleadoPoliza = 0;
                        int idEmpleado = 0;

                        int.TryParse(txtEmpleadoPoliza.Text, out IdEmpleadoPoliza);
                        int.TryParse(txtNoEmpleado.Text, out idEmpleado);

                        queriesTableAdapter1.stpUpdEmpledoPoliza(txtFolio.Text, IdEmpleadoPoliza, idEmpleado, OperadorBD.OperadorGlobal.NombreUsuario);
                        ActualizarGrid();
                        bloquearElementos(false);
                        XtraMessageBox.Show("Información Actualizada", "Saic",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        XtraMessageBox.Show("Seleccione una Poliza para actualizar", "SAIC",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("No se puede guardar la informacion" + Environment.NewLine + ex.Message, "SAIC",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bloquearElementos(Boolean flag)
        {
            txtEmpleadoPoliza.Enabled = flag;
            cboIdTipoSeguro.Enabled = flag;
            cboIdTipoPoliza.Enabled = flag;
            txtFolio.Enabled = flag;
            simpleButton1.Enabled = flag;
            simpleButton2.Enabled = flag;
            btnEditar.Enabled = flag;
            btnCancelarPoliza.Enabled = flag;
            btnCancelar.Enabled = flag;
        }

        private void repositoryItemButtonCancelar_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(cboIdTipoSeguro) &&
               Validator.IsPresent(cboIdTipoPoliza))
            {
                String stNombreCompleto = txtNombreEmpleado.Text + " " + txtAPaternoEmpleado.Text + " " + txtAMaternoEmpleado.Text;
                DialogResult Resultado = XtraMessageBox.Show("¿Esta seguro de Cancelar la Póliza del Empleado " + stNombreCompleto + "?", "SAIC",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult.Yes == Resultado)
                {
                    CancelarInfoEmpleado();       //actualizar la información del empleado
                    ActualizarGrid();
                    txtEmpleadoPoliza.Text = "0";
                    MostrarBotones(true);
                    LimpiarControlesA();
                }
            }
            else
            {
                XtraMessageBox.Show("NO fue posible Cancelar la Póliza del Empleado", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void repositoryItemButtonEliminar_Click(object sender, EventArgs e)
        {
            String stNombreCompleto = txtNombreEmpleado.Text + " " + txtAPaternoEmpleado.Text + " " + txtAMaternoEmpleado.Text;
            DialogResult resultado = XtraMessageBox.Show("¿Desea Eliminar la Póliza del Empleado " + stNombreCompleto + "?", "SAIC",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes == resultado)
            {
                if (Validator.IsPresent(cboIdTipoSeguro) &&
                    Validator.IsPresent(cboIdTipoPoliza))
                {
                    EliminarInfoEmpleado();       //actualizar la información del empleado
                    ActualizarGrid();
                    txtEmpleadoPoliza.Text = "0";
                    MostrarBotones(true);
                    LimpiarControlesA();
                }
                else
                    XtraMessageBox.Show("NO fue posible Cancelar la Póliza del Empleado", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void gridViewPolizasEmpleados_Click(object sender, EventArgs e)
        {
            if (gridViewPolizasEmpleados.FocusedRowHandle >= 0)
            {
                btnAgregar_Poliza.Enabled = true;
                //btnActualizar.Enabled = true;
                MostrarInfoPoliza(ObtenerInfoPoliza());
            }
        }

        private void ControlPolizas_Click(object sender, EventArgs e)
        {
            if (gridViewPolizasEmpleados.FocusedRowHandle >= 0)
            {
                btnAgregar_Poliza.Enabled = true;
                //btnActualizar.Enabled = true;
                MostrarInfoPoliza(ObtenerInfoPoliza());
            }
        }

        private void gridViewPolizasEmpleados_DoubleClick(object sender, EventArgs e)
        {
            if (gridViewPolizasEmpleados.FocusedRowHandle >= 0)
            {
                btnAgregar_Poliza.Enabled = true;
                //btnActualizar.Enabled = true;
                MostrarInfoPoliza(ObtenerInfoPoliza());
            }
        }

        private void GridEmpleados_Click(object sender, EventArgs e)
        {
            if (gridViewPolizasEmpleados.FocusedRowHandle >= 0)
            {
                btnAgregar_Poliza.Enabled = true;
                //btnActualizar.Enabled = true;
                MostrarInfoPoliza(ObtenerInfoPoliza());
            }
        }
    }
}