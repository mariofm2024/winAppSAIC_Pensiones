using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using compNominaCFDI;
using compLibreriaSAIC;
using winAppSAIC.UtileriasLocal;
using compCatalogosSAIC;

namespace winAppSAIC.Cancelaciones
{
    public partial class frmxSolicitudCancelacionNomina : DevExpress.XtraEditors.XtraForm
    {
        public frmxSolicitudCancelacionNomina()
        {
            InitializeComponent();
        }

        #region "Propiedades"
        //propiedad que indicará si el formulario carga todo el combobox 
        //o unicamente filtra por No. Lote Nomina
        public Int64 NoLoteCargaNomina { get; set; }
        #endregion

        #region "Variables Globales"
        EstatusNomina objEstatusNomina;
        Estructuras.InformacionLoteCargaNomina objInfoLoteCargaNomina;
        InfoDetalleLoteCargaNomina objInfoDetalle;      //declarar objeto InfoDetalleLoteCargaNomina
        NominaControlCancelacionCFDI objNominaControlCancelacionCFDI = null;    //declarar objeto objNominaControlCancelacionCFDI

        //objeto que almacena los movs del Encabezado de la Nomina a Cancelar
        List<NominaCancelacion> objNominaList = null;

        #endregion


        #region "Metodos Propios"
        /// <summary>
        /// Método para mostrar Resumen de la Nómina Vs Timbrados, de un Lote de Nomina seleccionado
        /// </summary>
        /// <param name="pIdLoteCargaNomina">No. Lote de Nómina</param>
        private void MostrarResumenNominaSueldosVsTimbrados(long pIdLoteCargaNomina)
        {
            //obtener información Nómina Vs Timbrados
            DataTable objTable = this.stpSelObtenerEstatusNominaSueldosVsTimbradoTableAdapter1.GetData(pIdLoteCargaNomina);

            //Si existe registro entonces visualizar información
            if (objTable.Rows.Count > 0)
            {
                //asignar valores de la nomina
                objEstatusNomina = NominaBD.ObtenerEstatusNominaSueldosVsTimbrado(objTable);

                lblNoEmpleadosNomina.Text = objEstatusNomina.noEmpleadosNomina.ToString("N0");
                lblNoEmpleadosTimbrados.Text = objEstatusNomina.noEmpleadosTimbrados.ToString("N0");
                lblNoEmpleadosCancelados.Text = objEstatusNomina.noEmpleadosCancelados.ToString("N0");
                lblPctEmpleadosTimbrados.Text = (objEstatusNomina.pctEmpleadosTimbrados / 100).ToString("P2");
                lblPctEmpleadosPorTimbrar.Text = (objEstatusNomina.pctEmpleadosPorTimbrar / 100).ToString("P2");
                lblLeyendaEstatusNominaSueldosVsTimbrados.Text = objEstatusNomina.leyendaEstatusNominaSueldosVsTimbrado;
            }
        }


        /// <summary>
        /// Método para inicializar controles en pantalla
        /// </summary>
        private void InicializarControles()
        {
            //inicializar labels Resumen Nomina Vs Timbrados
            lblNoEmpleadosNomina.Text = "0";
            lblNoEmpleadosTimbrados.Text = "0";
            lblNoEmpleadosCancelados.Text = "0";
            lblPctEmpleadosTimbrados.Text = "0.00";
            lblPctEmpleadosPorTimbrar.Text = "0.00";
            lblLeyendaEstatusNominaSueldosVsTimbrados.Text = String.Empty;
            lblMensajeComoHacerCancelacion.Text = String.Empty;
        }


        /// <summary>
        /// Método que despliega la pantalla Motivo Cancelacion
        /// </summary>
        /// <returns>Texto escrito por el usuario</returns>
        public string MostrarCancelacionNominaDialogBox()
        {
            frmxMotivoCancelacionNomina objDialog = new frmxMotivoCancelacionNomina();
            string strMotivoCancelacion = "";

            // muestra la pantalla en modo Dialog
            //y se determina si DialogResult = OK
            if (objDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Leer el Motivo de la Cancelación
                strMotivoCancelacion = objDialog.txtMotivoCancelacion.Text.Trim();

                //si el usuario no escribió motivo entonces asignar valor default
                if (strMotivoCancelacion.Trim().Length == 0)
                    strMotivoCancelacion = "ERROR DE CAPTURA";
            }
            objDialog.Dispose();
            return strMotivoCancelacion;      //regresar motivo cancelacion
        }

        /// <summary>
        /// Método que despliega la Informacion Detallada
        /// del Lote Carga Nomina seleccionado
        /// </summary>
        private void MostrarInfoDetalleLoteCargaNomina(long pIdLoteCargaNomina)
        {
            //cargar informacion detalle LoteCargaNomina
            DataTable dt = this.stpSelInfoDetalleLoteCargaNominaTableAdapter1.GetData(pIdLoteCargaNomina);

            //crear objeto y pasar el DataTable para asignar los valores
            objInfoDetalle = InfoDetalleLoteCargaNominaBD.ObtenerInfoDetalleLoteCargaNomina(dt);

            //si existe el objeto entonces mostrar los valores
            if (objInfoDetalle != null)
            {
                txtNombreComercialTenedora.Text = objInfoDetalle.NombreComercialTenedora;
                txtNombreComercialCliente.Text = objInfoDetalle.NombreComercialCliente;
                txtNombreOperador.Text = objInfoDetalle.Operador;
                txtTipoNomina.Text = objInfoDetalle.TipoNomina;
                txtPeriodoPago.Text = objInfoDetalle.PeriodoPago;
                chkEstatusNominaContabilizada.Checked = objInfoDetalle.EstatusNominaContabilizada;
                txtIdControl.Text = objInfoDetalle.idControl.ToString();
                if (objInfoDetalle.AnoPago > 0)
                    txtFechaPago.Text = String.Format("{0} {1}", objInfoDetalle.MesPago, objInfoDetalle.AnoPago);
                else
                    txtFechaPago.Text = "";     //inicializar textbox

                //desbloqueo de boton Solicitar Cancelacion Nomina
                //si el valor es true => convertir a false y viceversa
                if ((objInfoDetalle.idControl != -1 && objInfoDetalle.idControl != 0) || objInfoDetalle.EstatusNominaContabilizada)
                    btnSolicitarCancelacionNomina.Enabled = false;
                else
                    btnSolicitarCancelacionNomina.Enabled = true;
            }
        }


        /// <summary>
        /// Método para Solicitar la Cancelacion de una Nómina
        /// </summary>
        private void SolicitudCancelacionNomina()
        {
            long? pIdSolicitudCancelacionNomina = 0;
            bool? pEstatusCancelacionNomina = false;

            //si existe Lote seleccionado
            if (objInfoLoteCargaNomina.idLoteCargaNomina > 0)
            {
                try
                {
                    if (XtraMessageBox.Show(String.Format("¿Está seguro que desea cancelar el No. de Lote {0} ?", objInfoLoteCargaNomina.idLoteCargaNomina), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                            //validar si el LoteCargaNomina está contabilizado
                            //bool bEstatusNominaContabilizada = Convert.ToBoolean(this.stpSelEstatusNominaContabilizadaTableAdapter1.ObtenerEstatusNominaContabilizada(objInfoLoteCargaNomina.idLoteCargaNomina));

                            //si no está contabilizada => se puede eliminar
                            if (chkEstatusNominaContabilizada.Checked == false)
                            {
                                //validar si el IdLoteCargaNomina no está en la tabla SolicitudCancelacionNomina
                                this.stpSelValidarLoteCargaNominaEnSolicitudCancelacionNominaTableAdapter1.Fill(this.dbSAICBPOValidacionDataSet.stpSelValidarLoteCargaNominaEnSolicitudCancelacionNomina,
                                    objInfoLoteCargaNomina.idLoteCargaNomina, ref pIdSolicitudCancelacionNomina, ref pEstatusCancelacionNomina);

                                //si no existe folio de SolicitudCancelacionNomina
                                if (pIdSolicitudCancelacionNomina == 0)
                                {
                                    //Obtener estatus de timbrado
                                    switch (objInfoDetalle.IdEstatusCFDI)
                                    {
                                        case 2:     //LOTE DE NOMINA CON MOVIMIENTOS POR TIMBRAR CFDI
                                            {
                                                //si tiene EstatusCFDI = 2 y no tiene ningun movimiento Timbrado CFDI
                                                if (objEstatusNomina.noEmpleadosTimbrados.Equals(0))
                                                {
                                                    //obtener el motivo de la cancelacion
                                                    string strMotivoCancelacion = MostrarCancelacionNominaDialogBox();

                                                    //insertar registro de Solicitud
                                                    this.solicitudCancelacionNominaTableAdapter1.Insert(objInfoLoteCargaNomina.idLoteCargaNomina, objInfoLoteCargaNomina.folioLoteCargaNomina,
                                                        OperadorBD.OperadorGlobal.NombreUsuario,
                                                        strMotivoCancelacion,
                                                        OperadorBD.OperadorGlobal.NombreUsuario,
                                                        ref pIdSolicitudCancelacionNomina);

                                                    //si se inserto correctamente
                                                    if (pIdSolicitudCancelacionNomina > 0)
                                                    {
                                                        XtraMessageBox.Show(String.Format("La solicitud de cancelación # {0} ha sido generada.", pIdSolicitudCancelacionNomina), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    }
                                                    else
                                                        XtraMessageBox.Show("¡La solicitud de cancelación no fue generada, contacte a Sistemas!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                                else
                                                    XtraMessageBox.Show(String.Format("El No. de Lote {0} tiene Recibos CFDI.\n\n¡Para solicitar la Cancelación PRIMERO realice el cancelado del Timbrado CFDI!", objInfoLoteCargaNomina.idLoteCargaNomina), "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                                break;
                                            }

                                        case 0:     //PENDIENTE POR AUTORIZACION TIMBRADO CFDI
                                        case 1:     //OPERADOR AUTORIZA LOTE DE NOMINA PARA TIMBRAR CFDI
                                        case 4:     //LOTE DE NOMINA TIMBRADA Y CANCELAR TOTALMENTE EN SAIC POR ERRORES
                                        case 8:     //LOTE DE NOMINA TIMBRADA Y CANCELAR PARCIALMENTE EN SAIC POR ERRORES
                                        case 9:     //LOTE DE NOMINA SIN TIMBRAR Y CANCELAR EN SAIC POR ERRORES
                                            {
                                                    //obtener el motivo de la cancelacion
                                                    string strMotivoCancelacion = MostrarCancelacionNominaDialogBox();

                                                    //insertar registro de Solicitud
                                                    this.solicitudCancelacionNominaTableAdapter1.Insert(objInfoLoteCargaNomina.idLoteCargaNomina, objInfoLoteCargaNomina.folioLoteCargaNomina,
                                                        OperadorBD.OperadorGlobal.NombreUsuario,
                                                        strMotivoCancelacion,
                                                        OperadorBD.OperadorGlobal.NombreUsuario,
                                                        ref pIdSolicitudCancelacionNomina);

                                                    //si se inserto correctamente
                                                    if (pIdSolicitudCancelacionNomina > 0)
                                                    {
                                                        XtraMessageBox.Show(String.Format("La solicitud de cancelación # {0} ha sido generada.", pIdSolicitudCancelacionNomina), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    }
                                                    else
                                                        XtraMessageBox.Show("¡La solicitud de cancelación no fue generada, contacte a Sistemas!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                break;
                                            }
                                        
                                        case 3:     //LOTE DE NOMINA ESTA COMPLETO PARA ENVIOS CFDI
                                            {
                                                XtraMessageBox.Show(String.Format("El No. de Lote {0} ya procesó todos los Recibos CFDI.\n\n¡Para solicitar la Cancelación PRIMERO realice el cancelado del Timbrado CFDI!", objInfoLoteCargaNomina.idLoteCargaNomina), "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                break;
                                            }
                                        default:
                                            {
                                                XtraMessageBox.Show("¡No se puede validar el Estatus de Timbrado para la Nómina!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                                break;
                                            }
                                    } //switch
                                }   //if (pIdSolicitudCancelacionNomina == 0)
                                else
                                {
                                    //si el EstatusCancelación es 1 entonces ya fue cancelado
                                    if (pEstatusCancelacionNomina == true)
                                        XtraMessageBox.Show(String.Format("El No. de Lote {0} ya está cancelado.", objInfoLoteCargaNomina.idLoteCargaNomina), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    else
                                        //si el EstatusCancelación es 0 entonces está en espera de cancelarse
                                        XtraMessageBox.Show(String.Format("El No. de Lote {0} está en proceso de cancelación.", objInfoLoteCargaNomina.idLoteCargaNomina), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }   //else
                            }   //if (chkEstatusNominaContabilizada.Checked == false)
                            else
                                XtraMessageBox.Show(String.Format("¡El No. de Lote {0} está contabilizado, NO puede cancelar la Nómina!", objInfoLoteCargaNomina.idLoteCargaNomina), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }   //if XtraMessageBox(Está seguro que desea cancelar el Folio)
                }       //try
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }   
            else
                XtraMessageBox.Show("Seleccione un No. de Lote para cancelar la Nómina.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        #endregion

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();        //cerrar pantalla
        }

        private void btnFiltrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                splashSMCargando.ShowWaitForm();
                this.stpSelFolioLoteCargaNominaPorCancelarTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelFolioLoteCargaNominaPorCancelar, Convert.ToInt16(txtAno.EditValue),Convert.ToByte(txtMes.EditValue));
                // Set column widths according to their contents. 
                cboFolioLoteCargaNomina.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cboFolioLoteCargaNomina.Properties.PopupFormWidth = 900;

                splashSMCargando.CloseWaitForm();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboFolioLoteCargaNomina_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //obtener el renglon completo del Combobox
                DataRow row = gridLookUpEdit1View.GetDataRow(gridLookUpEdit1View.FocusedRowHandle);
                //asignar valores extraidos del Combobox a Objeto Struct
                objInfoLoteCargaNomina.idLoteCargaNomina = (long)cboFolioLoteCargaNomina.EditValue;
                objInfoLoteCargaNomina.folioLoteCargaNomina = row[1].ToString();
                objInfoLoteCargaNomina.tipoNomina = row[1].ToString().Substring(2, 3);    //obtener Tipo Nomina (SEM, QUI, ASI, etc)
                objInfoLoteCargaNomina.idTenedora = Convert.ToInt32(row[2]);     //obtener IdTenedora
                objInfoLoteCargaNomina.rfcTenedora = row[4].ToString();       //obtener RFCTenedora
                objInfoLoteCargaNomina.idTipoMovimiento = row[1].ToString().Substring(0, 1);    //S, A, P

                //cargar informacion detallada LoteCargaNomina
                MostrarInfoDetalleLoteCargaNomina((long)cboFolioLoteCargaNomina.EditValue);

                if (objInfoDetalle.EstatusNominaContabilizada == true)
                    lblMensajeComoHacerCancelacion.Text = "Para Cancelar una Nómina Contabilizada, debe contactar a Contabilidad para eliminar el registro en Sistema Contable!";
                else
                    lblMensajeComoHacerCancelacion.Text = "";

                //si se puede timbrar, entonces mostrar estatus CFDI
                if (objInfoLoteCargaNomina.idTipoMovimiento.Equals("S") || objInfoLoteCargaNomina.idTipoMovimiento.Equals("A"))
                {
                    txtEstatusCFDI.Text = String.Format("ESTATUS {0}: {1}", objInfoDetalle.IdEstatusCFDI, objInfoDetalle.DescEstatusCFDI);
                    //Obtener Informacion del Estatus Nomina Vs Timbrados
                    MostrarResumenNominaSueldosVsTimbrados((long)cboFolioLoteCargaNomina.EditValue);
                }
                else if (objInfoLoteCargaNomina.idTipoMovimiento.Equals("A") || objInfoLoteCargaNomina.idTipoMovimiento.Equals("P"))
                {
                    txtEstatusCFDI.Text = "NO APLICA";
                    InicializarControles();     //inicializar controles Resumen CFDI
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSolicitarCancelacionNomina_Click(object sender, EventArgs e)
        {
            SolicitudCancelacionNomina();       //Solicitar Cancelacion Nomina
        }

        private void frmxSolicitudCancelacionNomina_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    txtAno.EditValue = DateTime.Now.Year;       //asignar fecha del filtro
            //    txtMes.EditValue = DateTime.Now.Month;

            //    splashSMCargando.ShowWaitForm();
            //    this.stpSelFolioLoteCargaNominaPorCancelarTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelFolioLoteCargaNominaPorCancelar, Convert.ToInt16(txtAno.EditValue), Convert.ToByte(txtMes.EditValue));
            //    // Set column widths according to their contents. 
            //    cboFolioLoteCargaNomina.Properties.View.BestFitColumns();
            //    // Specify the total dropdown width. 
            //    cboFolioLoteCargaNomina.Properties.PopupFormWidth = 900;
            //    //Inicializar controles en pantalla
            //    InicializarControles();

            //    splashSMCargando.CloseWaitForm();
            //}
            //catch (Exception ex)
            //{
            //    XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            try
            {
                lblMensajeComoHacerCancelacion.Text = "";

                txtAno.EditValue = DateTime.Now.Year;       //asignar fecha del filtro
                txtMes.EditValue = DateTime.Now.Month;

                splashSMCargando.ShowWaitForm();

                //si el No. de Lote = 0, entonces cargar todos los lotes en base al filtro
                if (NoLoteCargaNomina.Equals(0))
                {
                    txtNoLoteCargaNomina.Visible = false;   //ocultar textbox
                    this.stpSelFolioLoteCargaNominaPorCancelarTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelFolioLoteCargaNominaPorCancelar, Convert.ToInt16(txtAno.EditValue), Convert.ToByte(txtMes.EditValue));
                    // Set column widths according to their contents. 
                    cboFolioLoteCargaNomina.Properties.View.BestFitColumns();
                    // Specify the total dropdown width. 
                    cboFolioLoteCargaNomina.Properties.PopupFormWidth = 900;
                    //Inicializar controles en pantalla
                    InicializarControles();
                }
                else
                {   //sino mostrar informacion del No. Lote que fue seleccionado en otra pantalla
                    cboFolioLoteCargaNomina.Visible = false;     //ocultar combobox
                    btnFiltrar.Enabled = false;     //deshabilitar boton Filtrar
                    txtNoLoteCargaNomina.Text = NoLoteCargaNomina.ToString();

                    //cargar informacion detallada LoteCargaNomina
                    MostrarInfoDetalleLoteCargaNomina(NoLoteCargaNomina);
                    //asignar el idNoLoteCargaNomina y FolioLoteCargaNomina al Objeto Global del Formulario
                    objInfoLoteCargaNomina.idLoteCargaNomina = objInfoDetalle.IdLoteCargaNomina;
                    objInfoLoteCargaNomina.folioLoteCargaNomina = objInfoDetalle.FolioLoteCargaNomina;

                    if (objInfoDetalle.EstatusNominaContabilizada == true)
                        lblMensajeComoHacerCancelacion.Text = "Para Cancelar una Nómina Contabilizada, debe contactar a Contabilidad para eliminar el registro en Sistema Contable!";
                    else
                        lblMensajeComoHacerCancelacion.Text = "";

                    if (objInfoDetalle.idControl != -1 && objInfoDetalle.idControl != 0)
                        lblMensajeComoHacerCancelacion.Text = lblMensajeComoHacerCancelacion.Text + "Para Cancelar una Nómina de un Control, debe cancelar el Control de Operaciones!";
                    else
                        lblMensajeComoHacerCancelacion.Text = lblMensajeComoHacerCancelacion.Text;


                    //si se puede timbrar, entonces mostrar estatus CFDI
                    if (objInfoDetalle.FolioLoteCargaNomina.Substring(0, 1).Equals("S") || objInfoDetalle.FolioLoteCargaNomina.Substring(0, 1).Equals("A"))
                    {
                        txtEstatusCFDI.Text = String.Format("ESTATUS {0}: {1}", objInfoDetalle.IdEstatusCFDI, objInfoDetalle.DescEstatusCFDI);
                        //Obtener Informacion del Estatus Nomina Vs Timbrados
                        MostrarResumenNominaSueldosVsTimbrados(NoLoteCargaNomina);
                    }
                    else if (objInfoDetalle.FolioLoteCargaNomina.Substring(0, 1).Equals("A") || objInfoDetalle.FolioLoteCargaNomina.Substring(0, 1).Equals("P"))
                    {
                        txtEstatusCFDI.Text = "NO APLICA";
                        InicializarControles();     //inicializar controles Resumen CFDI
                    }
                }
                splashSMCargando.CloseWaitForm();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}