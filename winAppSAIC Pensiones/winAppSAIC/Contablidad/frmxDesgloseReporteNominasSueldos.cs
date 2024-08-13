using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using compLibreriaSAIC;
using System.Data;
using System.Data.SqlClient;
using compNominaCFDI;
using DevExpress.XtraEditors;
using compCatalogosSAIC;

namespace winAppSAIC.Contablidad
{
    public partial class frmxDesgloseReporteNominasSueldos : DevExpress.XtraEditors.XtraForm
    {
        InfoDetalleLoteCargaNomina objInfoDetalle;      //declarar objeto InfoDetalleLoteCargaNomina

        #region "Variables Globales"
            EstatusNomina objNomina;
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
            //bloqueo de boton Cerrar Nomina
            btnCerrarNominaContabilizada.Enabled = false;

            //inicializar labels Resumen Nomina Vs Timbrados
            lblNoEmpleadosNomina.Text = "0";
            lblNoEmpleadosTimbrados.Text = "0";
            lblNoEmpleadosCancelados.Text = "0";
            lblPctEmpleadosTimbrados.Text = "0.00";
            lblPctEmpleadosPorTimbrar.Text = "0.00";
            lblLeyendaEstatusNominaSueldosVsTimbrados.Text = String.Empty;
        }

        /// <summary>
        /// Método que despliega la pantalla para asignar
        /// valores contables antes de realizar el cierre de una
        /// nómina
        /// </summary>
        public InfoCierreNominaContable MostrarCierreNominaContableDialogBox()
        {
            frmxCierreNominaContable objDialog = new frmxCierreNominaContable();
            InfoCierreNominaContable objCierreNominaContable = null;

            // muestra la pantalla en modo Dialog
            //y se determina si DialogResult = OK
            if (objDialog.ShowDialog(this) == DialogResult.OK)
            {
                //crear objeto
                objCierreNominaContable = new InfoCierreNominaContable();   

                // Asignar información complemento Cierre Poliza
                objCierreNominaContable.TipoPoliza = objDialog.cboTipoPoliza.EditValue.ToString();
                objCierreNominaContable.FechaPoliza = Convert.ToDateTime(objDialog.cboFechaPoliza.Text);
                objCierreNominaContable.FolioPoliza = objDialog.txtFolioPoliza.Text.Trim();
                objCierreNominaContable.ImportePoliza = objDialog.txtImportePoliza.Text.Trim();
                objCierreNominaContable.Observaciones = objDialog.txtObservaciones.Text.Trim();
                objCierreNominaContable.MesPago = Convert.ToByte(objDialog.cboMesPago.EditValue);
                objCierreNominaContable.AnoPago = (short)(objDialog.spAnoPago.Value);
            }
            objDialog.Dispose();

            return objCierreNominaContable;
        }


        /// <summary>
        /// Método que despliega la Informacion Detallada
        /// del Lote Carga Nomina seleccionado
        /// </summary>
        private void MostrarInfoDetalleLoteCargaNomina(long pIdLoteCargaNomina)
        {
            //cargar informacion detalla LoteCargaNomina
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
                btnCerrarNominaContabilizada.Enabled = !objInfoDetalle.EstatusNominaContabilizada;
            }
        }

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
                objNomina = NominaBD.ObtenerEstatusNominaSueldosVsTimbrado(objTable);

                lblNoEmpleadosNomina.Text = objNomina.noEmpleadosNomina.ToString("N0");
                lblNoEmpleadosTimbrados.Text = objNomina.noEmpleadosTimbrados.ToString("N0");
                lblNoEmpleadosCancelados.Text = objNomina.noEmpleadosCancelados.ToString("N0");
                lblPctEmpleadosTimbrados.Text = (objNomina.pctEmpleadosTimbrados / 100).ToString("P2");
                lblPctEmpleadosPorTimbrar.Text = (objNomina.pctEmpleadosPorTimbrar / 100).ToString("P2");
                lblLeyendaEstatusNominaSueldosVsTimbrados.Text = objNomina.leyendaEstatusNominaSueldosVsTimbrado;
            }
        }

        #endregion

        public frmxDesgloseReporteNominasSueldos()
        {
            InitializeComponent();
        }

        private void frmxDesgloseReporteNominasSueldos_Load(object sender, EventArgs e)
        {
            try
            {
                //splashSMCargando.ShowWaitForm();
                this.stpSelFolioLoteCargaNominaSATableAdapter.Fill(this.dbSAICBPODataSet.stpSelFolioLoteCargaNominaSA);
                // Set column widths according to their contents. 
                cboFolioLoteCargaNomina.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cboFolioLoteCargaNomina.Properties.PopupFormWidth = 900;
                //Inicializar controles en pantalla
                InicializarControles();

               // splashSMCargando.CloseWaitForm();
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
                this.stpSelReporteNominaSueldosSA_XLSTableAdapter.Fill(this.dbSAICBPOReportesDataSet.stpSelReporteNominaSueldosSA_XLS, (long)cboFolioLoteCargaNomina.EditValue);

                //si existen registros entonces habilitar el boton Exportar a Excel (XLS)
                if (this.dbSAICBPOReportesDataSet.stpSelReporteNominaSueldosSA_XLS.Count > 0)
                {
                    //desbloqueo de boton Exportar a Excel (XLS)
                    btnExportarXLS.Enabled = true;
                    cmExportarGrid.Enabled = true;

                    //cargar informacion detalla LoteCargaNomina
                    MostrarInfoDetalleLoteCargaNomina((long)cboFolioLoteCargaNomina.EditValue);

                    //Obtener Informacion del Estatus Nomina Vs Timbrados
                    MostrarResumenNominaSueldosVsTimbrados((long)cboFolioLoteCargaNomina.EditValue);
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
                    stpSelReporteNominaSueldosSA_XLSGridControl.ExportToXls(sfdRutaArchivo.FileName);

                    //Solicitar la visualización del nuevo archivo en Excel
                    if (XtraMessageBox.Show("¿Desea abrir el archivo en Excel?", "Confirmación", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
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

        private void btnCerrarNominaContabilizada_Click(object sender, EventArgs e)
        {
            long? pIdSolicitudCancelacionNomina = 0;
            bool? pEstatusCancelacionNomina = false;

            //validar que la nómina se encuentre 100% timbrada
//            if (objNomina.pctEmpleadosTimbrados.Equals(100))
//            {
                if (XtraMessageBox.Show(String.Format("¿Está seguro que desea cerrar la Nómina con el Folio {0}?", cboFolioLoteCargaNomina.Text), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        //validar si el IdLoteCargaNomina no está en la tabla SolicitudCancelacionNomina
                        this.stpSelValidarLoteCargaNominaEnSolicitudCancelacionNominaTableAdapter1.Fill(this.dbSAICBPOValidacionDataSet1.stpSelValidarLoteCargaNominaEnSolicitudCancelacionNomina,
                            (long)cboFolioLoteCargaNomina.EditValue, ref pIdSolicitudCancelacionNomina, ref pEstatusCancelacionNomina);

                        //si no existe folio de SolicitudCancelacionNomina entonces procede Cierre de Nómina
                        if (pIdSolicitudCancelacionNomina == 0)
                        {
                            //obtener los valores del Cierre Nómina Contable
                            InfoCierreNominaContable objCierreNominaContable = MostrarCierreNominaContableDialogBox();

                            //si tiene valores
                            if (objCierreNominaContable != null)
                            {
                                long intIdCierreNominaContable = 0;

                                //realizar cierre de nomina por contabilidad
                                intIdCierreNominaContable = (long) this.actualizacionesGeneralTableAdapter1.stpUpdCierreNominaContabilizada(objInfoDetalle.IdTenedora,
                                    objInfoDetalle.IdCliente, objInfoDetalle.FechaInicio, objInfoDetalle.FechaFin,
                                    objInfoDetalle.IdTipoPeriodoNomina, objInfoDetalle.IdOperador, objInfoDetalle.IdLoteCargaNomina,
                                    objInfoDetalle.FolioLoteCargaNomina, OperadorBD.OperadorGlobal.NombreUsuario,
                                    objCierreNominaContable.TipoPoliza,objCierreNominaContable.FolioPoliza, 
                                    objCierreNominaContable.FechaPoliza, Convert.ToDecimal(objCierreNominaContable.ImportePoliza),
                                    objCierreNominaContable.Observaciones,objCierreNominaContable.MesPago, 
                                    objCierreNominaContable.AnoPago);

                                //si se recibe IdCierreNominaContable > 0 en la Tabla trn.CierreNominaContable 
                                if (intIdCierreNominaContable > 0)
                                {
                                    //actualizar cambios en la informacion detalla LoteCargaNomina
                                    MostrarInfoDetalleLoteCargaNomina((long)cboFolioLoteCargaNomina.EditValue);

                                    //desplegar mensaje de confirmación
                                    XtraMessageBox.Show(String.Format("El Folio {0} ya está CERRADO.", cboFolioLoteCargaNomina.Text), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                    //desplegar mensaje de error enel cierre de nomina
                                    XtraMessageBox.Show(String.Format("Surgió un error en el cierre del folio {0}. \n ¡Contacte a Sistemas!.", cboFolioLoteCargaNomina.Text), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                XtraMessageBox.Show(String.Format("El Folio {0} NO está CERRADO.", cboFolioLoteCargaNomina.Text), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            //si el EstatusCancelación es 1 entonces ya fue cancelado
                            if (pEstatusCancelacionNomina == true)
                                XtraMessageBox.Show(String.Format("El Folio {0} ya está cancelado.", cboFolioLoteCargaNomina.Text), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            else
                                //si el EstatusCancelación es 0 entonces está en espera de cancelarse
                                XtraMessageBox.Show(String.Format("El Folio {0} está en proceso de cancelación, NO puede realizar el cierre de la Nómina", cboFolioLoteCargaNomina.Text), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
//            }
//            else
//                XtraMessageBox.Show(String.Format("No puedes CERRAR la Nómina con el Folio {0}\nporque no ha sido timbrada al 100%", cboFolioLoteCargaNomina.Text), "Error en Nómina", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}