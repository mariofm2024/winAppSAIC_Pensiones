using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using compLibreriaSAIC;
using System.Data;
using System.Data.SqlClient;
using compNominaCFDI;
using compCatalogosSAIC;
using DevExpress.XtraEditors;

namespace winAppSAIC.Tesoreria
{
    public partial class frmxReporteCheques : DevExpress.XtraEditors.XtraForm
    {
        InfoDetalleLoteCargaNomina objInfoDetalle;      //declarar objeto InfoDetalleLoteCargaNomina

        #region "Variables Globales"
            EstatusNomina objNomina;
        InfoSolicitudChequeHeader objInfoDetalleSolicitudChequeMasivo = null;
        public int iTipoPantalla { get; set; }
        #endregion

        #region "Metodos Propios"

        /// <summary>
        /// Método para inicializar controles en pantalla
        /// </summary>
        private void InicializarControles()
        {
            //bloqueo de boton Exportar a Excel (XLS)
            btnExportarXLS.Enabled = false;
            cmExportarGrid.Enabled = false;
        }

        /// <summary>
        /// Método que despliega la Informacion Detallada
        /// del Lote Carga Nomina seleccionado
        /// </summary>
        private void MostrarInfoDetalleLoteCargaNomina(long pIdLoteCargaNomina)
        {
            //cargar informacion detalla LoteCargaNomina
            DataTable dt = null; // this.stpSelInfoDetalleLoteCargaNominaTableAdapter1.GetData(pIdLoteCargaNomina); comente

            //crear objeto y pasar el DataTable para asignar los valores
            objInfoDetalle = InfoDetalleLoteCargaNominaBD.ObtenerInfoDetalleLoteCargaNomina(dt);

            //si existe el objeto entonces mostrar los valores
            if (objInfoDetalle != null)
            {
               
            }
        }
        #endregion

        public frmxReporteCheques()
        {
            InitializeComponent();
        }

        private void frmxReporteCheques_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dbSAICBPODataSet.stpSelOperador' table. You can move, or remove it, as needed.
                this.stpSelOperadorTableAdapter.Fill(this.dbSAICBPODataSet.stpSelOperador);

                this.stpSelSolicitudesChequesMasivosReporteTableAdapter.Fill(dbSAICBPOReportesDataSet.stpSelSolicitudesChequesMasivosReporte, iTipoPantalla, OperadorBD.OperadorGlobal.IdOperador, -1);

                if (iTipoPantalla == 3)
                {
                    cboOperador.Enabled = false;
                    cboOperador.EditValue = OperadorBD.OperadorGlobal.IdOperador;
                }

                //si existen registros entonces habilitar el boton Exportar a Excel (XLS)
                if (this.dbSAICBPOReportesDataSet.stpSelSolicitudesChequesMasivosReporte.Count > 0)
                {
                    //desbloqueo de boton Exportar a Excel (XLS)
                    btnExportarXLS.Enabled = true;
                    cmExportarGrid.Enabled = true;
                    gvSolicitudChequesMasivos.Enabled = true;
                }
                else
                {

                    //desbloqueo de boton Exportar a Excel (XLS)
                    btnExportarXLS.Enabled = false;
                    gvSolicitudChequesMasivos.Enabled = false;

                }

               
                cboOperador.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cboOperador.Properties.PopupFormWidth = 900;
                //Inicializar controles en pantalla
                InicializarControles();
                
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
                //mostrar datos en base al IdLoteCargaNomina
                if (cboOperador.EditValue.ToString() != "")
                {
                    this.stpSelSolicitudesChequesMasivosReporteTableAdapter.Fill(dbSAICBPOReportesDataSet.stpSelSolicitudesChequesMasivosReporte, 1, Convert.ToInt32(cboOperador.EditValue), -1);


                    //si existen registros entonces habilitar el boton Exportar a Excel (XLS)
                    if (this.dbSAICBPOReportesDataSet.stpSelSolicitudesChequesMasivosReporte.Count > 0)
                    {
                        //desbloqueo de boton Exportar a Excel (XLS)
                        btnExportarXLS.Enabled = true;
                        cmExportarGrid.Enabled = true;
                        gvSolicitudChequesMasivos.Enabled = true;
                    }
                    else
                    {

                        //desbloqueo de boton Exportar a Excel (XLS)
                        btnExportarXLS.Enabled = false;
                        gvSolicitudChequesMasivos.Enabled = false;
                        
                    }
                }
                else
                {
                    XtraMessageBox.Show("Debe de seleccionar un Operador" , "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void exportarAExcelXLSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (sfdRutaArchivo.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    //stpSelReporteNominaSueldosSA_XLSGridControl.ExportToXls(sfdRutaArchivo.FileName);

                    //Solicitar la visualización del nuevo archivo en Excel
                    if (XtraMessageBox.Show("¿Desea abrir el archivo en Excel?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        // Mostrar resultado en Excel.
                        Utilerias.StartProcess(sfdRutaArchivo.FileName);
                    }
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

        private void btnMostrarTodas_Click(object sender, EventArgs e)
        {
            this.stpSelSolicitudesChequesMasivosReporteTableAdapter.Fill(dbSAICBPOReportesDataSet.stpSelSolicitudesChequesMasivosReporte, iTipoPantalla, OperadorBD.OperadorGlobal.IdOperador, -1);
            //si existen registros entonces habilitar el boton Exportar a Excel (XLS)
            if (this.dbSAICBPOReportesDataSet.stpSelSolicitudesChequesMasivosReporte.Count > 0)
            {
                //desbloqueo de boton Exportar a Excel (XLS)
                btnExportarXLS.Enabled = true;
                cmExportarGrid.Enabled = true;
                gvSolicitudChequesMasivos.Enabled = true;
            }
            else
            {

                //desbloqueo de boton Exportar a Excel (XLS)
                btnExportarXLS.Enabled = false;
                gvSolicitudChequesMasivos.Enabled = false;

            }
        }

        private void btnExportarXLS_Click(object sender, EventArgs e)
        {
            try
            {
                if (sfdRutaArchivo.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    gvSolicitudChequesMasivos.ExportToXls(sfdRutaArchivo.FileName); 

                    //Solicitar la visualización del nuevo archivo en Excel
                    if (XtraMessageBox.Show("¿Desea abrir el archivo en Excel?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        // Mostrar resultado en Excel.
                        Utilerias.StartProcess(sfdRutaArchivo.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();        //cerrar pantalla
        }

        private void gvSolicitudChequesMasivos_DoubleClick(object sender, EventArgs e)
        {

            bool? bFlagBloqueado = false;
            string sUsuario = "";

            objInfoDetalleSolicitudChequeMasivo = ObtenerInfoSolicitudChequeMasivo();
            try
            {
                if (objInfoDetalleSolicitudChequeMasivo != null)
                {
                        Tesoreria.frmxReporteDetalleCheques objForm = new frmxReporteDetalleCheques() { objInfoDetalle = objInfoDetalleSolicitudChequeMasivo };
                    objForm.ShowDialog();       //mostrar pantalla

                    // Cargar nuevamente el Gridview
                    this.stpSelSolicitudesChequesMasivosReporteTableAdapter.Fill(dbSAICBPOReportesDataSet.stpSelSolicitudesChequesMasivosReporte, iTipoPantalla, OperadorBD.OperadorGlobal.IdOperador, -1);
                }
            }
            catch (SqlException ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private InfoSolicitudChequeHeader ObtenerInfoSolicitudChequeMasivo()
        {
            //si el usuario seleccionó un renglon, entonces regresar el valor IdTransaccionBanco
            if (gridView1.FocusedRowHandle >= 0)
            {
                //obtener la información del renglon completo
                DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                //asignar InfoDetalle Solicitud Cheque Masivo
                return InfoSolicitudChequeHeaderBD.ObtenerInfoDetalleSolicitudChequeMasivo(row);
            }
            else
                return null;       //si no se ha seleccionado un renglon válido, entonces regresar 0
        }
        private InfoSolicitudChequeHeader ObtenerInfoSolicitudChequeMasivoMultiple(DataRow row)
        {
            //asignar InfoDetalle Solicitud Cheque Masivo
            return InfoSolicitudChequeHeaderBD.ObtenerInfoDetalleSolicitudChequeMasivo(row);
        }


        private void btnCancelarSolicitud_Click(object sender, EventArgs e)
        {

            // Create an empty list.
            List<DataRow> rows = new List<DataRow>();

            try
            {

                // Add the selected rows to the list.
                for (int i = 0; i < gridView1.SelectedRowsCount; i++)
                {
                    if (gridView1.GetSelectedRows()[i] >= 0)
                        rows.Add(gridView1.GetDataRow(gridView1.GetSelectedRows()[i]));
                }

                for (int i = 0; i < rows.Count; i++)
                {
                    objInfoDetalleSolicitudChequeMasivo = ObtenerInfoSolicitudChequeMasivoMultiple(rows[i]);

                    if (objInfoDetalleSolicitudChequeMasivo != null)
                    {
                        ////Eliminar la Solicitud
                        this.stpSelSolicitudesChequesMasivosReporteDetalleEliminarTableAdapter1.Fill(dbSAICBPOReportesDataSet.stpSelSolicitudesChequesMasivosReporteDetalleEliminar, Convert.ToInt32(objInfoDetalleSolicitudChequeMasivo.IdSolicitudChequeHeader), OperadorBD.OperadorGlobal.NombreUsuario);
                        if (dbSAICBPOReportesDataSet.stpSelSolicitudesChequesMasivosReporteDetalleEliminar.Rows.Count == 0)
                        {
                            XtraMessageBox.Show("La Solicitud #" + objInfoDetalleSolicitudChequeMasivo.IdSolicitudChequeHeader.ToString() + " ya fue Cancelada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            XtraMessageBox.Show("La Solicitud #" + objInfoDetalleSolicitudChequeMasivo.IdSolicitudChequeHeader.ToString() + "  tiene cheques Activos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            DialogResult resul = XtraMessageBox.Show("¿Desea Continuar con la Solicitud?", "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (resul == DialogResult.Yes)
                            {
                                int? pOk;
                                pOk = 0;

                                stpQueryTableAdapter1.stpUpdSolicitudesChequesMasivosReporteDetalleEliminar2019(Convert.ToInt32(objInfoDetalleSolicitudChequeMasivo.IdSolicitudChequeHeader), OperadorBD.OperadorGlobal.NombreUsuario, ref pOk);

                                if (pOk == 1)
                                {
                                    XtraMessageBox.Show("La Solicitud #" + objInfoDetalleSolicitudChequeMasivo.IdSolicitudChequeHeader.ToString() + " ya fue Cancelada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    XtraMessageBox.Show("Error intentelo mas tarde.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }

                    }
                }

                if (rows.Count > 0)
                {
                    // TODO: This line of code loads data into the 'dbSAICBPODataSet.stpSelOperador' table. You can move, or remove it, as needed.
                    this.stpSelOperadorTableAdapter.Fill(this.dbSAICBPODataSet.stpSelOperador);
                    this.stpSelSolicitudesChequesMasivosReporteTableAdapter.Fill(dbSAICBPOReportesDataSet.stpSelSolicitudesChequesMasivosReporte, iTipoPantalla, OperadorBD.OperadorGlobal.IdOperador, -1);
                }

            }
            catch (SqlException ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}