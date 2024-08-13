using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using compLibreriaSAIC;
using compNominaCFDI;
using winAppSAIC.UtileriasLocal;
using System.Xml;
using System.IO;
using System.Xml.Linq;
using System.Security.Principal;
using compCatalogosSAIC;
using winAppSAIC.NominaCFDI;

namespace winAppSAIC.Cancelaciones
{
    public partial class frmxEliminarRegistrosNomina : DevExpress.XtraEditors.XtraForm
    {
        public frmxEliminarRegistrosNomina()
        {
            InitializeComponent();
        }

        #region "Variables Globales"
        EstatusNomina objNomina;
        Estructuras.InformacionLoteCargaNomina objInfoLoteCargaNomina;
        InfoDetalleLoteCargaNomina objInfoDetalle;      //declarar objeto InfoDetalleLoteCargaNomina
        NominaControlCancelacionCFDI objNominaControlCancelacionCFDI = null;    //declarar objeto objNominaControlCancelacionCFDI

        private string pathXmlFiles;
        private string pathDirectoryXMLFiles;
        private APIEF apiEF;
        private string sRutaArchivosCFDI;
        private string sRutaArchivosRespuestaCFDI;
        private static Int32 intContadorAceptados;     //contadores para registrar movs validos o inválidos
        private static Int32 intContadorRechazados;
        private static Int32 intContadorCancelados;

        //objeto que almacena los movs del Encabezado de la Nomina a Cancelar
        List<NominaCancelacion> objNominaList = null;

        #endregion

        #region "Métodos Propios"
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
                if (objInfoDetalle.AnoPago > 0)
                    txtFechaPago.Text = String.Format("{0} {1}", objInfoDetalle.MesPago, objInfoDetalle.AnoPago);
                else
                    txtFechaPago.Text = "";     //inicializar textbox

                //desbloqueo de boton Cerrar Nomina
                //si el valor es true => convertir a false y viceversa
                //***COMENTADA TEMPORALMENTE ***
                //btnCancelarXML.Enabled = !objInfoDetalle.EstatusNominaContabilizada;
            }
        }

        #endregion

        private void frmxCancelarXMLCFDI_Load(object sender, EventArgs e)
        {
            try
            {
                splashSMCargando.ShowWaitForm();
                
                this.stpSelFolioLoteCargaNominaTableAdapter.Fill(this.dbSAICBPODataSet.stpSelFolioLoteCargaNomina, OperadorBD.OperadorGlobal.Confidencial);
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
            Int32 intError = 0;
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

                //llenar Gridview Cambiar 
                this.stpSelInfoCancelacionDetalleLoteCargaNominaRegistroTableAdapter.Fill(this.dbSAICBPODataSet.stpSelInfoCancelacionDetalleLoteCargaNominaRegistro, (long)cboFolioLoteCargaNomina.EditValue);
                //cargar informacion detallada LoteCargaNomina
                MostrarInfoDetalleLoteCargaNomina((long)cboFolioLoteCargaNomina.EditValue);

                if (this.dbSAICBPODataSet.stpSelInfoCancelacionDetalleLoteCargaNominaRegistro.Count > 0)
                {
                    if (chkListNominas.ItemCount > 0)
                        chkListNominas.UnCheckAll();        //por seguridad se deseleccionan todos
                }
                else
                {
                    XtraMessageBox.Show("¡El Lote de Nómina esta Contabilizado y/o Timbrado, No se puede Eliminar registros!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();        //cerrar pantalla
        }

        private void chkListNominas_DrawItem(object sender, ListBoxDrawItemEventArgs e)
        {
            //e.Appearance.ForeColor = Color.Red;       //cambiar texto a Rojo
            if ((e.State & DrawItemState.Selected) == 0)
                e.Appearance.BackColor = Color.LightSteelBlue;
        }

        private void btnSeleccionarTodos_Click(object sender, EventArgs e)
        {
            chkListNominas.CheckAll();    //seleccionar todos
        }

        private void btnDeseleccionarTodo_Click(object sender, EventArgs e)
        {
            chkListNominas.UnCheckAll();    //deseleccionar todos
        }

        private void btnCancelarXML_Click(object sender, EventArgs e)
        {
            string dtHoraInicial = DateTime.Now.ToLongTimeString();
            //string dtHoraFinal = "";
            //Int32 intError = 0;
            try
            {
                //inicializar Contadores
                intContadorAceptados = 0;
                intContadorRechazados = 0;
                intContadorCancelados = 0;

                //obtener el No. de Items seleccionados
                Int32 intNoRecibosActivos = chkListNominas.CheckedItems.Count;

                //validar que exista al menos 1 movimiento activos para procesar
                if (intNoRecibosActivos > 0)
                {
                    if (XtraMessageBox.Show(String.Format("¿Está seguro que desea eliminar {1} registro(s) del No. de Lote {0}?", objInfoLoteCargaNomina.idLoteCargaNomina, intNoRecibosActivos), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        splashSMProcesando.ShowWaitForm();        //mostrar pantalla de espera
                        this.Cursor = Cursors.AppStarting;      //cambiar cursor del mouse

                        for (int i = 0; i < chkListNominas.ItemCount; i++)
                        {
                            if (chkListNominas.GetItemCheckState(i) == CheckState.Checked)
                            {
                                //obtener el FolioRecibo seleccionado
                                Int64 intPDOHeaderCFDI = Convert.ToInt64(chkListNominas.GetItemValue(i));

                                //si la Nóminas es SA
                                if (objInfoLoteCargaNomina.folioLoteCargaNomina.Substring(0, 1) == "S")
                                {
                                    //cambiar estatus Registro Nómina SA: borrado = 1
                                    this.seguridadTableAdapter1.stpUpdEstatusBorradoSA((long)cboFolioLoteCargaNomina.EditValue, intPDOHeaderCFDI, 1, OperadorBD.OperadorGlobal.NombreUsuario);
                                }

                                //si la Nóminas es SC
                                if (objInfoLoteCargaNomina.folioLoteCargaNomina.Substring(0, 1) == "A")
                                {
                                    //cambiar estatus Registro Nómina SC: borrado = 1
                                    this.seguridadTableAdapter1.stpUpdEstatusBorradoSC((long)cboFolioLoteCargaNomina.EditValue, intPDOHeaderCFDI, 1, OperadorBD.OperadorGlobal.NombreUsuario);
                                }

                                // XtraMessageBox.Show(String.Format("¡Los Registros de la Nómina con Folio {0} ha sido cancelada!", intPDOHeaderCFDI), "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                            }
                        }  //for

                        this.Cursor = Cursors.Default;      //cambiar cursor del mouse
                        splashSMProcesando.CloseWaitForm();   //quitar pantalla de espera

                        //dtHoraFinal = DateTime.Now.ToLongTimeString();
                        XtraMessageBox.Show(String.Format("¡Los Registros de la Nómina han sido cancelados!"), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cboFolioLoteCargaNomina_EditValueChanged(sender, e);     //recargar gridview
                                                                                 //mostrar el no. de elementos seleccionados
                        lblNoFoliosSeleccionados.Text = chkListNominas.CheckedItems.Count.ToString();
                    }//IF Pregunta afirmar
                }
                else
                    XtraMessageBox.Show("¡No existen Movimientos activos para la Eliminación de Registros!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                splashSMProcesando.CloseWaitForm();   //quitar pantalla de espera
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboFolioLoteCargaNomina_EditValueChanged(sender, e);     //recargar gridview aunque haya falla
            }
            finally
            {
                this.Cursor = Cursors.Default;      //cambiar cursor del mouse
            }
        }

       
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Cancelaciones.frmxSolicitudCancelacionNomina objSolicitudCancelacionNomina = new Cancelaciones.frmxSolicitudCancelacionNomina();

            objSolicitudCancelacionNomina.ShowDialog();     //mostrar pantalla
        }

        private void chkListNominas_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            //mostrar el no. de elementos seleccionados
            lblNoFoliosSeleccionados.Text = chkListNominas.CheckedItems.Count.ToString();
        }

        private void btnVisualizarErroresTimbrado_Click(object sender, EventArgs e)
        {
            //si existe lote de nómna valido
            if (!cboFolioLoteCargaNomina.EditValue.Equals(""))
            {
                //crear objeto y pasar el valor de la propiedad pIdLoteCargaNomina
                frmxErroresTimbradoCFDI objFrmErroresTimbrado = new frmxErroresTimbradoCFDI() { pIdLoteCargaNomina = (long)cboFolioLoteCargaNomina.EditValue, pIdTipoError = 2 };

                objFrmErroresTimbrado.ShowDialog();     //mostrar pantalla
            }
            else
                XtraMessageBox.Show("¡Para visualizar los errores de cancelación, debe seleccionar un Lote de Nómina!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}