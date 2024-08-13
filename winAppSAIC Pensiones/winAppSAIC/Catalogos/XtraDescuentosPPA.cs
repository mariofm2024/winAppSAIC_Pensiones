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
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using Excel = Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;

namespace winAppSAIC.Catalogos
{
    public partial class XtraDescuentosPPA : DevExpress.XtraEditors.XtraForm
    {
        public XtraDescuentosPPA()
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

            cboTipoNomina.EditValue = -1;
            calFechaIni.EditValue = DateTime.Today;
            CalFechaFin.EditValue = DateTime.Today;
            txtMonto.Text = "0";
            txtObserva.Text = "";
            cboIdEstatus.EditValue = -1;
            txtIdDescuento.Text = "0";
        }

        /// <summary>
        /// Método para activar o desactivar controles al momento de Editar/Cancelar/Guardar
        /// </summary>
        /// <param name="bFlag">Valor TRUE o FALSE</param>
        private void ActivarControles(bool bFlag, Constantes.TipoPerfil pTipoPerfil)
        {
            cbotipoDescuento.Enabled = bFlag;
            cboTipoNomina.Enabled = bFlag;
            calFechaIni.Enabled = bFlag;
            CalFechaFin.Enabled = bFlag;
            txtMonto.Enabled = bFlag;
            txtObserva.Enabled = bFlag;
            cboIdEstatus.Enabled = bFlag;
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

            if (estatusBoton == EstatusBotones.Nuevo || estatusBoton == EstatusBotones.Editar)
            {
                objEmp.IdTipoDescuento = Convert.ToByte(cbotipoDescuento.EditValue);
                objEmp.IdTipoPeriodoNomina = Convert.ToByte(cboTipoNomina.EditValue);
                objEmp.FechaInicio = Convert.ToDateTime(calFechaIni.EditValue);
                objEmp.FechaFin = Convert.ToDateTime(CalFechaFin.EditValue);
                objEmp.MontoD = Convert.ToDecimal(txtMonto.Text);
                objEmp.ObservacionesD = txtObserva.Text;
                objEmp.IdEstatusD = Convert.ToByte(cboIdEstatus.EditValue);
                objEmp.IdEmpleadoDescuento = Convert.ToInt64(txtIdDescuento.Text);
            }
            else
            {
                cboTipoNomina.EditValue = -1;
                calFechaIni.EditValue = DateTime.Today;
                CalFechaFin.EditValue = DateTime.Today;
                txtMonto.Text = "0";
                txtObserva.Text = "";
                cboIdEstatus.EditValue = -1;
                txtIdDescuento.Text = "0";
            }

            objEmp.UsuarioCreacion = OperadorBD.OperadorGlobal.NombreUsuario;
            objEmp.UsuarioModificacion = OperadorBD.OperadorGlobal.NombreUsuario;
            return objEmp;
        }

        /// <summary>
        /// Metodo para desplegar el contenido del objeto Empleado
        /// </summary>
        /// <param name="objEmp">Objeto Empleado</param>
        private void MostrarInfoEmpleado(DataRow objEmp)
        {
            txtNoEmpleado.Text = objEmp["IdEmpleado"].ToString();
            txtAPaternoEmpleado.Text = objEmp["APaternoEmpleado"].ToString();
            txtAMaternoEmpleado.Text = objEmp["AMaternoEmpleado"].ToString();
            txtNombreEmpleado.Text = objEmp["NombreEmpleado"].ToString();
            txtNSS.Text = objEmp["NSS"].ToString();
            txtRFC.Text = objEmp["RFC"].ToString();
            txtCURP.Text = objEmp["CURP"].ToString();

            ObtenerDescuentos(Convert.ToInt32(txtNoEmpleado.Text));
        }

        private void ObtenerDescuentos(Int32 IdEmpleado)
        {
            try
            {
                this.stpSelObtenerDescuentosTableAdapter.Fill(dbSAIC_Catalogos.stpSelObtenerDescuentos, IdEmpleado);

            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Metodo para desplegar el contenido del objeto Empleado
        /// </summary>
        /// <param name="objEmp">Objeto Empleado</param>
        private void MostrarInfoDescuentos(Empleado objEmp)
        {
            cbotipoDescuento.EditValue = objEmp.IdTipoDescuento;
            cboTipoNomina.EditValue = objEmp.IdTipoPeriodoNomina;
            calFechaIni.EditValue = objEmp.FechaInicio;
            CalFechaFin.EditValue = objEmp.FechaFin;
            txtMonto.Text = objEmp.MontoD.ToString("N2");
            txtObserva.Text = objEmp.ObservacionesD;
            cboIdEstatus.EditValue = objEmp.IdEstatusD;
        }

        /// <summary>
        /// Método que actualiza la información del empleado
        /// </summary>
        private void ActualizarInfoEmpleado()
        {
            Empleado objEmp = AsignarInfoEmpleado();    //crear objeto y asignar valores

            bool bFlagUpdate = false;

            if (estatusBoton == EstatusBotones.Nuevo)
            {

                bFlagUpdate = EmpleadoBD.CrearInfoEmpleadoDescuentos(objEmp, winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString);
            }
            else
            {
                bFlagUpdate = EmpleadoBD.ModificarInfoEmpleadoDescuentos(objEmp, winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString);
            }

            if (bFlagUpdate)    //fue correcta la modificacion
            {
                estatusBoton = EstatusBotones.Ninguno;    //asignar accion NINGUNO

                ActivarBotones(true);
                ActivarControles(false, tipoPerfil);     //bloqueo de controles permitidos
                XtraMessageBox.Show("La información del Empleado se actualizó satisfactoriamente",
                    "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ObtenerDescuentos(Convert.ToInt32(txtNoEmpleado.Text));
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
            if (estatusBoton == EstatusBotones.Ninguno)
            {
                btnAgregar.Enabled = bFlag;
                btnGuardar.Enabled = !bFlag;
                btnCancelar.Enabled = !bFlag;
            }
            else if (estatusBoton == EstatusBotones.Nuevo || estatusBoton == EstatusBotones.Editar)
            {
                btnAgregar.Enabled = !bFlag;
                btnGuardar.Enabled = bFlag;
                btnCancelar.Enabled = bFlag;
            }
            else 
            {
                btnAgregar.Enabled = !bFlag;
                btnGuardar.Enabled = bFlag;
                btnCancelar.Enabled = bFlag;
            }

            //dtDatos.Enabled = !bFlag;
            cboTipoNomina.Enabled = !bFlag;
            txtMonto.Enabled = !bFlag;
            txtObserva.Enabled = !bFlag;
            cboIdEstatus.Enabled = !bFlag;
            calFechaIni.Enabled = !bFlag;
            CalFechaFin.Enabled = !bFlag;
        }
        
        /// <summary>
        /// Método para mostrar u ocultar botones de las Operaciones
        /// permitidas en la pantalla
        /// </summary>
        /// <param name="bFlag">Valor VERDADERO o FALSO</param>
        private void ActivarBotonesOperaciones(bool bFlag)
        {
            btnCancelar.Visible = bFlag;
            btnGuardar.Visible = bFlag;
        }

        private EstatusBotones estatusBoton;

        //enumeracion con estatus de las acciones
        enum EstatusBotones
        {
            Nuevo = 1,
            Editar = 2,
            Ninguno = 0,
        }

        #endregion


        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void XtraDescuentosPPA_Load(object sender, EventArgs e)
        {
           
            try
            {
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.stpSelEmpleadosDisponiblesDescuentos' table. You can move, or remove it, as needed.
                this.stpSelEmpleadosDisponiblesDescuentosTableAdapter.Fill(this.dbSAIC_Catalogos.stpSelEmpleadosDisponiblesDescuentos);
                // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwFactCatEstatusGlobal' table. You can move, or remove it, as needed.
                this.vwFactCatEstatusGlobalTableAdapter.Fill(this.dbSAICBPOFactura.vwFactCatEstatusGlobal);
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.stpSelTipoDescuento' table. You can move, or remove it, as needed.
                this.stpSelTipoDescuentoTableAdapter.Fill(this.dbSAIC_Catalogos.stpSelTipoDescuento);
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.stpSelTipoPeriodoNomina' table. You can move, or remove it, as needed.
                this.stpFactSelTipoPeriodoNominaDATableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelTipoPeriodoNominaDA,1,0);

                // Set column widths according to their contents. 
                cboIdEmpleado.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cboIdEmpleado.Properties.PopupFormWidth = 700;

                this.Text = "Modificación de Información Empleados";
                ActivarBotones(true);
                estatusBoton = EstatusBotones.Ninguno;      //inicializo valor bandera estatus
                ActivarBotonesOperaciones(true);

                cboIdEmpleado.Focus();        //colocar cursor en objeto
                ActivarControles(false, tipoPerfil);        //desactivar controles
                LimpiarControles();     //limpiar contenido controles
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);

                if (row != null)
                {
                    MostrarInfoEmpleado(row);        //mostrar informacion del Emplead
                    ActivarBotones(true);
                    ActivarControles(false, tipoPerfil);
                }
                else
                {
                    LimpiarControles();     //limpiar controles

                    XtraMessageBox.Show("No existe el empleado solicitado.", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboIdEmpleado.Focus();        //colocar cursor en control
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            estatusBoton = EstatusBotones.Nuevo;    //asignar accion EDITAR
            ActivarBotones(true);
            ActivarControles(true, tipoPerfil);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (Validator.IsPresent(cbotipoDescuento) && Validator.IsPresent(cboTipoNomina) &&
                Validator.IsDecimal(txtMonto) && Validator.IsDate(calFechaIni) && Validator.IsDate(CalFechaFin) && Validator.IsPresent(cboIdEstatus))
            {
                if (cbotipoDescuento.EditValue.ToString() == "5")
                {
                    if (Convert.ToDecimal(txtMonto.Text.ToString()) > 100)
                        XtraMessageBox.Show("El % no debe de superar 100%", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        ActualizarInfoEmpleado();       //actualizar la información del empleado
                }
                else
                    ActualizarInfoEmpleado();       //actualizar la información del empleado
            }
            else
                XtraMessageBox.Show("NO fue posible el Alta del Descuento.", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            estatusBoton = EstatusBotones.Editar;    //asignar accion EDITAR
            ActivarBotones(false);
            ActivarControles(true, tipoPerfil);     //desbloqueo de controles permitidos
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estatusBoton = EstatusBotones.Ninguno;    //asignar accion NINGUNO
            ActivarBotones(true);
            ActivarControles(false, tipoPerfil);     //bloqueo de controles permitidos
        }

        private void dtDatos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //Crear archivo Comprobante
                DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                if (row != null)
                {
                    txtIdDescuento.Text = row[0].ToString();
                    cbotipoDescuento.EditValue = Convert.ToInt32(row[2].ToString());
                    cboTipoNomina.EditValue = Convert.ToInt32(row[4].ToString());
                    txtMonto.Text = Convert.ToDecimal(row[6].ToString()).ToString("N6");
                    calFechaIni.EditValue = Convert.ToDateTime(row[7].ToString());
                    CalFechaFin.EditValue = Convert.ToDateTime(row[8].ToString());
                    txtObserva.Text = row[9].ToString();
                    cboIdEstatus.EditValue = Convert.ToInt32(row[10].ToString());

                    estatusBoton = EstatusBotones.Editar;    //asignar accion EDITAR
                    ActivarBotones(true);
                    ActivarControles(true, tipoPerfil);     //desbloqueo de controles permitidos
                }
                else
                    XtraMessageBox.Show("¡Debe de Seleccionar un descuento!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbotipoDescuento_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbotipoDescuento.EditValue != null)
                {
                    this.stpFactSelTipoPeriodoNominaDATableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelTipoPeriodoNominaDA, 1, Convert.ToInt32(cbotipoDescuento.EditValue.ToString()));

                    if (cbotipoDescuento.EditValue.ToString() == "5")
                        if (Validator.IsDecimal(txtMonto) && Convert.ToDecimal(txtMonto.Text.ToString()) > 100)
                        {                           
                            XtraMessageBox.Show("El % no debe de superar 100%", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMonto_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbotipoDescuento.EditValue !=null)
                {
                    if (cbotipoDescuento.EditValue.ToString() == "5")
                        if (Validator.IsDecimal(txtMonto) && Convert.ToDecimal(txtMonto.Text.ToString()) > 100)
                        {
                            XtraMessageBox.Show("El % no debe de superar 100%", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                            
                        }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barEditItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ObtenerArchivo.Filter = "Excel Files (*.xls;*.xlsm;*.xlsb;*.xlsx)|*.xls;*.xlsm;*.xlsb;*.xlsx";
            ObtenerArchivo.ShowDialog();
            barEditItem2.EditValue = ObtenerArchivo.FileName;
        }

        private void btnMasio_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DataTable dtDatos = new DataTable();
                DataRow row = null;
                string pOk;
                string pErrores = "Error en Descuentos y Ahorros:";
                if (barEditItem2.EditValue != null && barEditItem2.EditValue.ToString().Trim().Length > 0)
                {
                    splashScreenManager1.ShowWaitForm();
                    dtDatos = ConvertExcelToDataTable(barEditItem2.EditValue.ToString().Trim());
                    if (dtDatos.Rows.Count > 0)
                    {
                        for (int i = 0; i < dtDatos.Rows.Count; i++)
                        {
                            row = dtDatos.Rows[i];
                            if (Convert.ToInt32(row[0].ToString().Replace(",", "").Replace("$", "")) > 0)
                            {
                                if (Convert.ToDecimal(row[4].ToString().Replace(",", "").Replace("$", "")) > 0)
                                {
                                    pOk = "";

                                    this.spSoloRespuesta1.stpCargarDescuentosAhorros(Convert.ToInt32(row[0].ToString()), row[1].ToString(), row[2].ToString(), row[3].ToString(), Convert.ToDecimal(row[4].ToString()), row[5].ToString(), Convert.ToDateTime(row[6].ToString()), Convert.ToDateTime(row[7].ToString()), OperadorBD.OperadorGlobal.NombreUsuario, ref pOk);
                                    if (pOk != "")
                                        pErrores = pErrores + " FILA:" + (i + 2).ToString() + " " + pOk + " \n ";
                                }
                                else
                                    pErrores = pErrores = "El monto debe ser mayor a 0";
                            }
                            else
                                pErrores = pErrores = "El No. Empleado debe ser mayor a 0";
                        }
                        if (pErrores != "" && pErrores != "Error en Descuentos y Ahorros:")
                        {
                            splashScreenManager1.CloseWaitForm();
                            XtraMessageBox.Show(pErrores, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            splashScreenManager1.CloseWaitForm();
                            XtraMessageBox.Show("Los Descuentos se Cargaron Correctamente", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }                        
                    }
                    else
                    {
                        splashScreenManager1.CloseWaitForm();
                        XtraMessageBox.Show(String.Format("!El Archivo no cumple con las columnas requeridas!."), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    XtraMessageBox.Show(String.Format("!Debes de Cargar el Archivo de Alta!."), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                if (splashScreenManager1.IsSplashFormVisible)
                {
                    splashScreenManager1.CloseWaitForm();
                }
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable ConvertExcelToDataTable(String stRutaArchivo)
        {
            DataTable dtDatos = new DataTable();

            String ultimaCelda = String.Empty;
            String losDatos = String.Empty;
            String stUltimaColumna = "H";
            Excel.Application appExcel;
            Excel.Workbooks booksExcel;
            Excel.Workbook bookExcel = null;
            Excel.Worksheet SheetExcel;
            Excel.Range unRango;

            appExcel = new Excel.Application();
            booksExcel = appExcel.Workbooks;

            try
            {
                appExcel.Visible = true;
                appExcel.DisplayAlerts = false;
                bookExcel = booksExcel.Open(stRutaArchivo);
                ((Excel.Worksheet)appExcel.Sheets[1]).Select();
                SheetExcel = (Excel.Worksheet)bookExcel.ActiveSheet;
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Por favor asegúrese de Cerrar la ventana de Validacion de Office y despues de Click en Aceptar de este mensaje."
                          , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                ((Excel.Worksheet)appExcel.Sheets[1]).Select();
                SheetExcel = (Excel.Worksheet)bookExcel.ActiveSheet;
                unRango = SheetExcel.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
                ultimaCelda = unRango.get_AddressLocal(false, false, Excel.XlReferenceStyle.xlA1, false, false);
                unRango = SheetExcel.get_Range("A2", stUltimaColumna + soloNumeros(ultimaCelda));
                unRango.Select();
                unRango.Copy();
                System.Threading.Thread.Sleep(2000);
                losDatos = Clipboard.GetText();
                losDatos = losDatos.ToUpper();
                dtDatos = ConvertToDataTable(losDatos);
                appExcel.Quit();
            }

            return dtDatos;

        }

        private String soloNumeros(String valor)
        {
            Regex regex = new Regex("[A-Z]");
            return regex.Replace(valor, "");
        }

        private DataTable ConvertToDataTable(String stLosDatos)
        {
            stLosDatos = stLosDatos.Replace("\r", "");
            DataTable valores = new DataTable();
            String[] registros = stLosDatos.Split('\n');
            int iContaColumnas = 0;

            for (int i = 0; i < registros.Length; i++)
            {
                if (!String.IsNullOrEmpty(registros[i]))
                {
                    DataRow unData = valores.NewRow();
                    String[] rows = registros[i].Split('\t');

                    if (iContaColumnas == 0)
                    {
                        for (int col = 0; col < rows.Length; col++) { valores.Columns.Add(); }
                        iContaColumnas++;
                    }

                    for (int cel = 0; cel < rows.Length; cel++)
                    {
                        unData[cel] = rows[cel].Trim();
                    }

                    valores.Rows.Add(unData);
                }
            }

            return valores;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Catalogos.XtraCancelarDescuentos obj = new Catalogos.XtraCancelarDescuentos();
            obj.Show();
        }
    }
}