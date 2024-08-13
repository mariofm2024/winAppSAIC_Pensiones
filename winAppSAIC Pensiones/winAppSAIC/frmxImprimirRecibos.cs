using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using compLayoutBancos;
using DevExpress.XtraReports.UI;        //namespace a partir version 12.2.4
using compCatalogosSAIC;
using winAppSAIC.Reportes;
using winAppSAIC.UtileriasLocal;
using System.Diagnostics;
using winAppSAIC.NominaCFDI.Clases;

namespace winAppSAIC
{
    public partial class frmxImprimirRecibos : DevExpress.XtraEditors.XtraForm
    {
        #region "Variables"
        short shNoSecuencialArchivo;
        #endregion

        #region "Metodos Propios"

        /// <summary>
        /// Método para validar el estatus de una Nómina por Timbrar CFDI
        /// </summary>
        /// <param name="pIdLoteCargaNomina">Valor del IdLoteCargaNomina</param>
        /// <returns></returns>
        private byte ValidarEstatusNominaTimbradoCFDI(long pIdLoteCargaNomina)
        {
            byte pEstatusTimbradoCFDI = Convert.ToByte(seguridadTableAdapter1.stpSelObtenerEstatusTimbradoCFDI(pIdLoteCargaNomina));

            //obtener el Estatus Autorizacion Timbrar CFDI del Lote actual
            return pEstatusTimbradoCFDI;
        }

        /// <summary>
        /// Método para mostrar los recibos de Asimilados
        /// en base al IdLoteCargaNomina seleccionado
        /// </summary>
        /// <param name="pIdLoteCargaNomina">Valor del IdLoteCargaNomina</param>
        private void MostrarRecibosAsimilados(long pIdLoteCargaNomina)
        {
            //crear reporte
            reportes.ReporteAsimilados report = new reportes.ReporteAsimilados();
            try
            {
                //asignar parametros del reporte
                report.Parameters["pIdLoteCargaNomina"].Value = pIdLoteCargaNomina;

                //asigna tamaño de papel
                report.PaperKind = System.Drawing.Printing.PaperKind.Letter;
                report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes

                //mostrar reporte
                report.ShowPreview();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método que despliega la pantalla Motivo Cancelacion
        /// </summary>
        /// <returns>Texto escrito por el usuario</returns>
        public string MostrarCancelacionNominaDialogBox()
        {
            Cancelaciones.frmxMotivoCancelacionNomina objDialog = new Cancelaciones.frmxMotivoCancelacionNomina();
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
        /// Método para cambiar el comportamiento de acceso a
        /// los controles Comboboxes Tenedora SA y Tenedora SC
        /// </summary>
        /// <param name="bFlag">Valor TRUE o FALSE</param>
        private void CambiarEstatusComboboxes(bool bFlag)
        {
            cboIdTenedoraSA.Enabled = bFlag;
            cboIdTenedoraSC.Enabled = !bFlag;

            if (this.gvLotesCargaNomina.DataSource != null)
            {
                this.gvLotesCargaNomina.DataSource = null;
            }
            else
            {
                this.gvLotesCargaNomina.Rows.Clear();
            }
        }

        /// <summary>
        /// Método que procesa los Recibos Tenedora SA
        /// </summary>
        private void MostrarRecibosSueldos(Int64 pIdLoteCargaNomina)
        {
            //crear reporte
            RecibosEmpleadosSueldos report = new RecibosEmpleadosSueldos();
            try
            {
                //asignar parametros del reporte
                report.Parameters["pIdLoteCargaNomina"].Value = pIdLoteCargaNomina;

                report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes

                //mostrar reporte
                report.ShowPreview();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método que procesa los Acuses de Recibos Tenedora SA
        /// </summary>
        private void MostrarAcuseRecibosNominaSueldosSA(Int64 pIdLoteCargaNomina)
        {
            AcuseRecibosEmpleadosSueldos report = new AcuseRecibosEmpleadosSueldos();

            try
            {
                //asignar parametros del reporte
                report.Parameters["pIdLoteCargaNomina"].Value = pIdLoteCargaNomina;

                //asigna tamaño de papel
                report.PaperKind = System.Drawing.Printing.PaperKind.Letter;
                //mostrar reporte
                report.ShowPreview();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método que procesa el Reporte de NóminaTenedora SA
        /// </summary>
        private void MostrarReporteNominaSA(Int64 pIdLoteCargaNomina)
        {
            ReporteNominaSueldos report = new ReporteNominaSueldos();

            try
            {
                //asignar parametros del reporte
                report.Parameters["pIdLoteCargaNomina"].Value = pIdLoteCargaNomina;

                //asigna tamaño de papel y orientacion horizontal
                report.PaperKind = System.Drawing.Printing.PaperKind.Letter;
                report.Landscape = true;
                //mostrar reporte
                report.ShowPreview();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método que procesa el Acuse de Cheques Tenedora SA
        /// </summary>
        private void MostrarAcuseChequesNominaSueldosSA(Int64 pIdLoteCargaNomina)
        {
            //crear reporte
            AcuseChequesNominaSueldos report = new AcuseChequesNominaSueldos();
            try
            {
                //asignar parametros del reporte
                report.Parameters["pIdLoteCargaNomina"].Value = pIdLoteCargaNomina;

                report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes

                //asigna tamaño de papel
                report.PaperKind = System.Drawing.Printing.PaperKind.Letter;
                //mostrar reporte
                report.ShowPreview();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método que procesa los Recibos Tenedora SC
        /// </summary>
        private void MostrarRecibosAlimentos(Int64 pIdLoteCargaNomina)
        {
            //crear reporte
            RecibosEmpleadosAlimentos report = new RecibosEmpleadosAlimentos();
            try
            {
                //asignar parametros del reporte
                report.Parameters["pIdLoteCargaNomina"].Value = pIdLoteCargaNomina;

                //mostrar reporte
                report.ShowPreview();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método que procesa los Acuses de Recibos Tenedora SC
        /// </summary>
        private void MostrarAcuseRecibosNominaAlimentosSC(Int64 pIdLoteCargaNomina)
        {
            AcuseRecibosEmpleadosAlimentos report = new AcuseRecibosEmpleadosAlimentos();
            try
            {
                //asignar parametros del reporte
                report.Parameters["pIdLoteCargaNomina"].Value = pIdLoteCargaNomina;

                //asigna tamaño de papel
                report.PaperKind = System.Drawing.Printing.PaperKind.Letter;
                //mostrar reporte
                report.ShowPreview();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método que procesa el Reporte de Alimentos Tenedora SC
        /// </summary>
        private void MostrarReporteAlimentosSC(Int64 pIdLoteCargaNomina)
        {
            ReporteNominaAlimentos report = new ReporteNominaAlimentos();

            try
            {
                //asignar parametros del reporte
                report.Parameters["pIdLoteCargaNomina"].Value = pIdLoteCargaNomina;

                //asigna tamaño de papel y orientacion horizontal
                report.PaperKind = System.Drawing.Printing.PaperKind.Letter;
                report.Landscape = true;
                //mostrar reporte
                report.ShowPreview();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método que procesa el Acuse de Cheques Tenedora SC
        /// </summary>
        private void MostrarAcuseChequesNominaAlimentosSC(Int64 pIdLoteCargaNomina)
        {
            //crear reporte
            AcuseChequesNominaAlimentos report = new AcuseChequesNominaAlimentos();
            try
            {
                //asignar parametros del reporte
                report.Parameters["pIdLoteCargaNomina"].Value = pIdLoteCargaNomina;

                report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes
                //asigna tamaño de papel
                report.PaperKind = System.Drawing.Printing.PaperKind.Letter;

                //mostrar reporte
                report.ShowPreview();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método que obtiene los registros de Lotes de Carga Nómina
        /// </summary>
        private void MostrarLoteCargaNomina(Int32 Lote, bool bBuscarxLote)
        {
            try
            {
                if (Lote == -1 && bBuscarxLote == false)
                {
                    if ((rbTenedoraSA.Checked == true) || (rbAcuseTenedoraSA.Checked == true) ||
                    (rbReporteNominaSA.Checked == true) || (rbRelacionChequesSA.Checked == true))
                    {
                        //mostrar Lotes Carga Nomina en base a parametros
                        this.stpSelLoteCargaNominaTableAdapter.ObtenerMovsLoteCargaNomina(this.dbSAICBPODataSet.stpSelLoteCargaNomina,
                                    Convert.ToInt32(cboIdTenedoraSA.EditValue), Convert.ToInt32(cboIdCliente.EditValue),
                                    Convert.ToInt16(dtFechaInicio.Value.Date.Year), Convert.ToByte(dtFechaInicio.Value.Date.Month),
                                    Convert.ToByte(dtFechaInicio.Value.Date.Day),
                                    Convert.ToInt16(dtFechaFin.Value.Year), Convert.ToByte(dtFechaFin.Value.Month),
                                    Convert.ToByte(dtFechaFin.Value.Day),
                                    Convert.ToByte(cboIdTipoPeriodoNomina.SelectedValue),
                                    Convert.ToInt16(OperadorBD.OperadorGlobal.IdOperador), Lote);
                    }
                    else
                    {
                        //mostrar Lotes Carga Nomina en base a parametros
                        this.stpSelLoteCargaNominaTableAdapter.ObtenerMovsLoteCargaNomina(this.dbSAICBPODataSet.stpSelLoteCargaNomina,
                                    Convert.ToInt32(cboIdTenedoraSC.EditValue), Convert.ToInt32(cboIdCliente.EditValue),
                                    Convert.ToInt16(dtFechaInicio.Value.Date.Year), Convert.ToByte(dtFechaInicio.Value.Date.Month),
                                    Convert.ToByte(dtFechaInicio.Value.Date.Day),
                                    Convert.ToInt16(dtFechaFin.Value.Year), Convert.ToByte(dtFechaFin.Value.Month),
                                    Convert.ToByte(dtFechaFin.Value.Day),
                                    Convert.ToByte(cboIdTipoPeriodoNomina.SelectedValue),
                                    Convert.ToInt16(OperadorBD.OperadorGlobal.IdOperador), Lote);
                    }
                    //asociamos nuevamente el gridview a los datos
                }
                else
                {
                    //mostrar Lotes Carga Nomina en base a parametros
                    this.stpSelLoteCargaNominaTableAdapter.ObtenerMovsLoteCargaNomina(this.dbSAICBPODataSet.stpSelLoteCargaNomina,
                                Convert.ToInt32(cboIdTenedoraSC.EditValue), Convert.ToInt32(cboIdCliente.EditValue),
                                Convert.ToInt16(dtFechaInicio.Value.Date.Year), Convert.ToByte(dtFechaInicio.Value.Date.Month),
                                Convert.ToByte(dtFechaInicio.Value.Date.Day),
                                Convert.ToInt16(dtFechaFin.Value.Year), Convert.ToByte(dtFechaFin.Value.Month),
                                Convert.ToByte(dtFechaFin.Value.Day),
                                Convert.ToByte(cboIdTipoPeriodoNomina.SelectedValue),
                                Convert.ToInt16(OperadorBD.OperadorGlobal.IdOperador), Lote);


                    if (this.dbSAICBPODataSet.stpSelLoteCargaNomina.Rows.Count > 0)
                    {
                        if (this.dbSAICBPODataSet.stpSelLoteCargaNomina.Rows[0].ItemArray[12].ToString().Substring(0, 1) == "S")
                        {
                            //if ((rbTenedoraSC.Checked == true) || (rbAcuseTenedoraSC.Checked == true) ||
                            //        (rbReporteNominaSC.Checked == true) || (rbRelacionChequesSC.Checked == true))
                            //    rbTenedoraSA.Checked = true;

                            rbReporteNominaSA.Checked = true;

                            cboIdTenedoraSA.ItemIndex = Convert.ToInt32(this.dbSAICBPODataSet.stpSelLoteCargaNomina.Rows[0].ItemArray[2].ToString());
                            cboIdTenedoraSA.EditValue = Convert.ToInt32(this.dbSAICBPODataSet.stpSelLoteCargaNomina.Rows[0].ItemArray[2].ToString());
                            cboIdTenedoraSC.ItemIndex = 0;
                            cboIdTenedoraSC.EditValue = 0;
                        }
                        else
                        {
                            //if ((rbTenedoraSA.Checked == true) || (rbAcuseTenedoraSA.Checked == true) ||
                            //        (rbReporteNominaSA.Checked == true) || (rbRelacionChequesSA.Checked == true))
                            //    rbTenedoraSC.Checked = true;

                            rbReporteNominaSC.Checked = true;

                            cboIdTenedoraSA.ItemIndex = 0;
                            cboIdTenedoraSA.EditValue = 0;
                            cboIdTenedoraSC.ItemIndex = Convert.ToInt32(this.dbSAICBPODataSet.stpSelLoteCargaNomina.Rows[0].ItemArray[2].ToString());
                            cboIdTenedoraSC.EditValue = Convert.ToInt32(this.dbSAICBPODataSet.stpSelLoteCargaNomina.Rows[0].ItemArray[2].ToString());
                        }


                        cboIdCliente.ItemIndex = Convert.ToInt32(this.dbSAICBPODataSet.stpSelLoteCargaNomina.Rows[0].ItemArray[3].ToString());
                        cboIdCliente.EditValue = Convert.ToInt32(this.dbSAICBPODataSet.stpSelLoteCargaNomina.Rows[0].ItemArray[3].ToString());
                        dtFechaInicio.Value = Convert.ToDateTime(this.dbSAICBPODataSet.stpSelLoteCargaNomina.Rows[0].ItemArray[6].ToString() + "/" + this.dbSAICBPODataSet.stpSelLoteCargaNomina.Rows[0].ItemArray[5].ToString() + "/" + this.dbSAICBPODataSet.stpSelLoteCargaNomina.Rows[0].ItemArray[4].ToString());
                        dtFechaFin.Value = Convert.ToDateTime(this.dbSAICBPODataSet.stpSelLoteCargaNomina.Rows[0].ItemArray[9].ToString() + "/" + this.dbSAICBPODataSet.stpSelLoteCargaNomina.Rows[0].ItemArray[8].ToString() + "/" + this.dbSAICBPODataSet.stpSelLoteCargaNomina.Rows[0].ItemArray[7].ToString());
                        cboIdTipoPeriodoNomina.SelectedValue = Convert.ToInt16(this.dbSAICBPODataSet.stpSelLoteCargaNomina.Rows[0].ItemArray[10].ToString());


                        cboIdOperador.ItemIndex = Convert.ToInt16(this.dbSAICBPODataSet.stpSelLoteCargaNomina.Rows[0].ItemArray[13].ToString());
                        cboIdOperador.EditValue = Convert.ToInt16(this.dbSAICBPODataSet.stpSelLoteCargaNomina.Rows[0].ItemArray[13].ToString());
                    }
                }

                gvLotesCargaNomina.DataSource = stpSelLoteCargaNominaBindingSource;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método para autorizar el Lote de Carga Nomina seleccionado. Con este proceso
        /// se puede generar el Layout de Banco
        /// </summary>
        private void AutorizarLoteCargaNomina()
        {
            Int32 intError = 0;
            dbSAICBPODataSetTableAdapters.stpUpdAutorizacionNominaTableAdapter dt = new dbSAICBPODataSetTableAdapters.stpUpdAutorizacionNominaTableAdapter();
            long? pIdPDOAutorizacionNomina = 0;
            Int64 intIdLoteCargaNomina = 0;
            string strFolioLoteCargaNomina = "";

            //si existen Lotes de Carga de Nomina en el gridview
            if (gvLotesCargaNomina.RowCount > 0)
            {
                //si la nómina NO está en proceso de Cancelación => Validar autorización Nómina para uso Layout Bancario
                // if ((bool)gvLotesCargaNomina.Rows[gvLotesCargaNomina.SelectedCells[0].RowIndex].Cells[5].Value == false)
                if (Convert.ToInt16(gvLotesCargaNomina.Rows[gvLotesCargaNomina.SelectedCells[0].RowIndex].Cells[5].Value) == 0)
                {
                    //si no esta autorizada la nomina
                    if ((bool)gvLotesCargaNomina.Rows[gvLotesCargaNomina.SelectedCells[0].RowIndex].Cells[4].Value == false)
                    {
                        //Obtener el Id del Lote de Carga Nomina
                        //para asignarlo a los recibos
                        intIdLoteCargaNomina = Convert.ToInt64(gvLotesCargaNomina.Rows[gvLotesCargaNomina.SelectedCells[0].RowIndex].Cells[0].Value);
                        strFolioLoteCargaNomina = gvLotesCargaNomina.Rows[gvLotesCargaNomina.SelectedCells[0].RowIndex].Cells[1].Value.ToString();
                        try
                        {
                            //if (XtraMessageBox.Show(String.Format("¿Está seguro que desea Autorizar el Folio {0}?", strFolioLoteCargaNomina), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                            //{
                            if (gvLotesCargaNomina.Rows[gvLotesCargaNomina.SelectedCells[0].RowIndex].Cells[1].Value.ToString().Substring(0, 1) == "S")
                            {
                                //Actualizar EstatusNominaCerrada = 1 en PDOHeaderSA
                                intError = Convert.ToInt32(dt.AutorizarNominas(Convert.ToInt32(cboIdTenedoraSA.EditValue),
                                                Convert.ToInt32(cboIdCliente.EditValue),
                                                dtFechaInicio.Value.Date,
                                                dtFechaFin.Value.Date,
                                                Convert.ToInt16(dtFechaInicio.Value.Year),
                                                Convert.ToByte(dtFechaInicio.Value.Month),
                                                Convert.ToByte(dtFechaInicio.Value.Day),
                                                Convert.ToInt16(dtFechaFin.Value.Year),
                                                Convert.ToByte(dtFechaFin.Value.Month),
                                                Convert.ToByte(dtFechaFin.Value.Day),
                                                Convert.ToByte(cboIdTipoPeriodoNomina.SelectedValue),
                                                1, "S", Convert.ToInt16(cboIdOperador.EditValue),
                                                intIdLoteCargaNomina, strFolioLoteCargaNomina,
                                                OperadorBD.OperadorGlobal.NombreUsuario,
                                                ref pIdPDOAutorizacionNomina));
                            }
                            else
                            {
                                //Actualizar EstatusNominaCerrada = 1 en PDOHeaderSC
                                intError = Convert.ToInt32(dt.AutorizarNominas(Convert.ToInt32(cboIdTenedoraSC.EditValue),
                                                Convert.ToInt32(cboIdCliente.EditValue),
                                                dtFechaInicio.Value.Date,
                                                dtFechaFin.Value.Date,
                                                Convert.ToInt16(dtFechaInicio.Value.Year),
                                                Convert.ToByte(dtFechaInicio.Value.Month),
                                                Convert.ToByte(dtFechaInicio.Value.Day),
                                                Convert.ToInt16(dtFechaFin.Value.Year),
                                                Convert.ToByte(dtFechaFin.Value.Month),
                                                Convert.ToByte(dtFechaFin.Value.Day),
                                                Convert.ToByte(cboIdTipoPeriodoNomina.SelectedValue),
                                                1, "A", Convert.ToInt16(cboIdOperador.EditValue),
                                                intIdLoteCargaNomina, strFolioLoteCargaNomina,
                                                OperadorBD.OperadorGlobal.NombreUsuario,
                                                ref pIdPDOAutorizacionNomina));
                            }

                            //si hubo error en la actualizacion, entonces notificar al usuario
                            //if (pIdPDOAutorizacionNomina == 0)
                            //    XtraMessageBox.Show("No se logró Autorizar la Nómina, contacte a Sistemas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //else
                            //    MostrarLoteCargaNomina(-1, false);       //mostrar registros de Lotes de Carga Nomina
                            //} //if
                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    //else
                    //    XtraMessageBox.Show("¡La nómina seleccionada ya está Autorizada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    XtraMessageBox.Show("El Folio está en proceso de Cancelación,\nno puede autorizar el uso de Layout Bancario.", "Error en Autorización", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } //if gvLotesCargaNomina.RowCount>0
            else
                XtraMessageBox.Show("Seleccione un Folio para Autorizar la Nómina.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// Método para Solicitar la Cancelacion de una Nómina
        /// </summary>
        private void SolicitudCancelacionNomina()
        {
            long? pIdSolicitudCancelacionNomina = 0;
            bool? pEstatusCancelacionNomina = false;
            Int64 intIdLoteCargaNomina = 0;
            string strFolioLoteCargaNomina = "";
            byte pEstatusTimbradoCFDI = 0;

            //si existen Lotes de Carga de Nomina en el gridview
            if (gvLotesCargaNomina.RowCount > 0)
            {
                try
                {
                    //Obtener el Id del Lote de Carga Nomina
                    //para asignarlo a la Validacion del IdLoteCargaNomina 
                    //en la Tabla SolicitudCancelacionNomina
                    intIdLoteCargaNomina = Convert.ToInt64(gvLotesCargaNomina.Rows[gvLotesCargaNomina.SelectedCells[0].RowIndex].Cells[0].Value);
                    strFolioLoteCargaNomina = gvLotesCargaNomina.Rows[gvLotesCargaNomina.SelectedCells[0].RowIndex].Cells[1].Value.ToString();

                    //si la nómina NO está en proceso de Cancelación => Validar autorización Nómina para uso Layout Bancario
                    if ((bool)gvLotesCargaNomina.Rows[gvLotesCargaNomina.SelectedCells[0].RowIndex].Cells[5].Value == false)
                    {
                        if (XtraMessageBox.Show(String.Format("¿Está seguro que desea cancelar el Folio {0}?", strFolioLoteCargaNomina), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            //validar si el LoteCargaNomina está contabilizado
                            bool bEstatusNominaContabilizada = Convert.ToBoolean(this.stpSelEstatusNominaContabilizadaTableAdapter1.ObtenerEstatusNominaContabilizada(intIdLoteCargaNomina));

                            //si no está contabilizada => se puede eliminar
                            if (bEstatusNominaContabilizada == false)
                            {
                                //validar si el IdLoteCargaNomina no está en la tabla SolicitudCancelacionNomina
                                this.stpSelValidarLoteCargaNominaEnSolicitudCancelacionNominaTableAdapter1.Fill(this.dbSAICBPOValidacionDataSet.stpSelValidarLoteCargaNominaEnSolicitudCancelacionNomina,
                                    intIdLoteCargaNomina, ref pIdSolicitudCancelacionNomina, ref pEstatusCancelacionNomina);

                                //si no existe folio de SolicitudCancelacionNomina
                                if (pIdSolicitudCancelacionNomina == 0)
                                {
                                    //Obtener estatus de timbrado
                                    pEstatusTimbradoCFDI = ValidarEstatusNominaTimbradoCFDI(intIdLoteCargaNomina);
                                    switch (pEstatusTimbradoCFDI)
                                    {
                                        case 0:     //PENDIENTE POR AUTORIZACION TIMBRADO CFDI
                                        case 1:     //OPERADOR AUTORIZA LOTE DE NOMINA PARA TIMBRAR CFDI
                                        case 4:     //LOTE DE NOMINA TIMBRADA Y CANCELAR TOTALMENTE EN SAIC POR ERRORES
                                        case 8:     //LOTE DE NOMINA TIMBRADA Y CANCELAR PARCIALMENTE EN SAIC POR ERRORES
                                        case 9:     //LOTE DE NOMINA SIN TIMBRAR Y CANCELAR EN SAIC POR ERRORES
                                            {
                                                //obtener el motivo de la cancelacion
                                                string strMotivoCancelacion = MostrarCancelacionNominaDialogBox();

                                                //insertar registro de Solicitud
                                                this.solicitudCancelacionNominaTableAdapter1.Insert(intIdLoteCargaNomina, strFolioLoteCargaNomina,
                                                    OperadorBD.OperadorGlobal.NombreUsuario,
                                                    strMotivoCancelacion,
                                                    OperadorBD.OperadorGlobal.NombreUsuario,
                                                    ref pIdSolicitudCancelacionNomina);

                                                //si se inserto correctamente
                                                if (pIdSolicitudCancelacionNomina > 0)
                                                {
                                                    XtraMessageBox.Show(String.Format("La solicitud de cancelación # {0} ha sido generada.", pIdSolicitudCancelacionNomina), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    MostrarLoteCargaNomina(-1, false);       //mostrar registros de Lotes de Carga Nomina
                                                }
                                                else
                                                    XtraMessageBox.Show("¡La solicitud de cancelación no fue generada, contacte a Sistemas!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                                break;
                                            }
                                        case 2:     //LOTE DE NOMINA CON MOVIMIENTOS POR TIMBRAR CFDI
                                            {
                                                XtraMessageBox.Show(String.Format("¡El Folio {0} ya tiene Movimientos \npor Timbrar CFDI, NO se puede Cancelar!", strFolioLoteCargaNomina), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                break;
                                            }
                                        case 3:     //LOTE DE NOMINA ESTA COMPLETO PARA ENVIOS CFDI
                                            {
                                                XtraMessageBox.Show(String.Format("¡El Folio {0} ya procesó todos \nlos Recibos CFDI, NO se puede Cancelar!", strFolioLoteCargaNomina), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                break;
                                            }
                                        default:
                                            {
                                                XtraMessageBox.Show("¡No se puede validar el Estatus de Timbrado para la Nómina!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                                break;
                                            }
                                    } //switch
                                }
                                else
                                {
                                    //si el EstatusCancelación es 1 entonces ya fue cancelado
                                    if (pEstatusCancelacionNomina == true)
                                        XtraMessageBox.Show(String.Format("El Folio {0} ya está cancelado.", strFolioLoteCargaNomina), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    else
                                        //si el EstatusCancelación es 0 entonces está en espera de cancelarse
                                        XtraMessageBox.Show(String.Format("El Folio {0} está en proceso de cancelación.", strFolioLoteCargaNomina), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }   //else
                            }
                            else
                                XtraMessageBox.Show(String.Format("¡El Folio {0} está contabilizado, NO puede cancelar la Nómina!", strFolioLoteCargaNomina), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }   //if XtraMessageBox
                    }
                    else
                        XtraMessageBox.Show(String.Format("El Folio {0} \nya está en proceso de cancelación.", strFolioLoteCargaNomina), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }       //try
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }   //if (gvLotesCargaNomina.RowCount > 0)
            else
                XtraMessageBox.Show("Seleccione un Folio para cancelar la Nómina.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        #endregion

        #region "Métodos Layouts"

        /// <summary>
        /// Método para activar o desactivar combobox Leyenda Dispersion
        /// </summary>
        private void MostrarLeyendaDispersion()
        {
            if (cboIdBanco.Text.Equals("HSBC"))   //HSBC
            {
                lblLeyendaDispersion.Visible = true;
                cboLeyendaDispersion.Visible = true;
            }
            else
            {
                lblLeyendaDispersion.Visible = false;
                cboLeyendaDispersion.Visible = false;
            }

            cboLeyendaDispersion.SelectedIndex = -1;       //inicializar control
        }
        /// <summary>
        /// Método que bloquea o desbloquea el textbox Emisora
        /// </summary>
        private void ActivarControlEmisora()
        {
            if (Convert.ToByte(cboIdBanco.SelectedValue) == 4)  //Banorte
                txtEmisora.Enabled = false;
            else
                txtEmisora.Enabled = false;

            txtEmisora.Text = "";       //inicializar control
        }

        /// <summary>
        /// Método para generar Layout Banamex TEF C
        /// </summary>
        /// <param name="objInfoBanco">Objeto con los Valores del Encabezado
        /// y Pie de Archivo de la Informacion Bancaria Tenedora</param>
        /// <param name="objInfoBancariaList">Objeto tipo Lista con los valores de los movimientos
        /// de cada pago por Empleado/Asociado</param>
        /// <param name="pFolioLoteCargaNomina">Clave Folio Lote de Carga</param>
        /// <param name="pIdTipoMovimientoBanco">Clave que otorga el Banco para clasificar el movimiento</param>
        /// <param name="pNoRegistrosPagos">No. total de movimientos de Empleados/Asociados procesados</param>
        /// <param name="pImportePagos">Importe total del pago de todos los movimientos individuales de
        /// Empleados/Asociados</param>
        /// <param name="pNoSecuenciaArchivo">No. de Archivo generado</param>
        /// <param name="pIdTipoMovimientoNomina">S=SUELDOS, A=ALIMENTOS</param>
        private void GenerarLayoutBancarioBanamexTEFC(InfoBancariaTenedora objInfoBanco, List<BanamexDetalleTefC> objInfoBancariaList, string pFolioLoteCargaNomina, string pIdTipoMovimientoBanco, Int32 pNoRegistrosPagos, decimal pImportePagos, short pNoSecuenciaArchivo, string pIdTipoMovimientoNomina)
        {
            BanamexTefC objTEFC = new BanamexTefC();
            string strLeyendaTipoMovimientoNomina = string.Empty;
            try
            {
                //informacion para asignar descripcion del archivo el Layout
                if (pIdTipoMovimientoNomina == "S")
                    strLeyendaTipoMovimientoNomina = this.validacionesGeneralTableAdapter1.ObtenerValorParametro("LEYENDA_TIPO_NOMINA_LAYOUT_BANAMEX_SA").ToString();
                else
                    strLeyendaTipoMovimientoNomina = this.validacionesGeneralTableAdapter1.ObtenerValorParametro("LEYENDA_TIPO_NOMINA_LAYOUT_BANAMEX_SC").ToString();

                //Control
                objTEFC.TipoRegistroControl = "1";      //constante
                objTEFC.NoIdentificacionCliente = objInfoBanco.NoCliente;
                objTEFC.FechaPago = dtFechaPago.Value.Day.ToString().PadLeft(2, '0') + dtFechaPago.Value.Month.ToString().PadLeft(2, '0') + dtFechaPago.Value.Year.ToString().Substring(2, 2);
                objTEFC.SecuencialArchivo = pNoSecuenciaArchivo.ToString().PadLeft(4, '0');
                objTEFC.NombreEmpresa = objInfoBanco.RazonSocial;
                objTEFC.DescArchivo = strLeyendaTipoMovimientoNomina.PadRight(20, ' ');
                objTEFC.NaturalezaArchivo = pIdTipoMovimientoBanco;     //05=Tarjetas Banames ó 12= Cheques o Interbancarios
                objTEFC.InstruccionesOrdenesPago = ' '.ToString().PadRight(40, ' ');
                objTEFC.VersionLayout = "C";        //constante
                objTEFC.Volumen = "0";
                objTEFC.CaracteristicaArchivo = "0";
                //Global
                objTEFC.TipoRegistroGlobal = "2";       //constante
                objTEFC.TipoOperacionGlobal = "1";
                objTEFC.ClaveMonedaGlobal = "001";      //constante

                //generar formato del importe total sin PUNTO decimal
                string strImporte = FormatoNumeros.ObtenerNumeroSinDecimal(pImportePagos);
                objTEFC.ImporteAbonarPagar = strImporte.PadLeft(18, '0');
                objTEFC.TipoCuentaGlobal = "01";
                objTEFC.NoSucursalGlobal = objInfoBanco.NoSucursal;
                objTEFC.NoCuentaGlobal = objInfoBanco.NoCuenta;
                objTEFC.EspacioBlanco = ' '.ToString().PadLeft(20, ' ');
                //Total
                objTEFC.TipoRegistroTotal = "4";    //constante
                objTEFC.ClaveMonedaTotal = "001";
                objTEFC.NoAbonos = pNoRegistrosPagos.ToString().PadLeft(6, '0');
                objTEFC.ImporteTotalAbonos = strImporte.PadLeft(18, '0');
                objTEFC.NoCargos = "000001";
                objTEFC.ImporteTotalCargos = strImporte.PadLeft(18, '0');


                //Escribir archivo Layout TEF C
                FileInfo f = new FileInfo(string.Format(@"C:\LAYOUTS\{0}L{1}-BXC{2}.{3}", pIdTipoMovimientoNomina, pFolioLoteCargaNomina, pIdTipoMovimientoBanco, "TXT"));
                StreamWriter w = f.CreateText();
                //Seccion Control
                w.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}", objTEFC.TipoRegistroControl, objTEFC.NoIdentificacionCliente,
                                                        objTEFC.FechaPago, objTEFC.SecuencialArchivo, objTEFC.NombreEmpresa,
                                                        objTEFC.DescArchivo, objTEFC.NaturalezaArchivo, objTEFC.InstruccionesOrdenesPago,
                                                        objTEFC.VersionLayout, objTEFC.Volumen, objTEFC.CaracteristicaArchivo);
                //Seccion Global
                w.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}", objTEFC.TipoRegistroGlobal, objTEFC.TipoOperacionGlobal,
                                                                        objTEFC.ClaveMonedaGlobal, objTEFC.ImporteAbonarPagar,
                                                                        objTEFC.TipoCuentaGlobal, objTEFC.NoSucursalGlobal,
                                                                        objTEFC.NoCuentaGlobal, objTEFC.EspacioBlanco);


                //Seccion Individual
                if (objInfoBancariaList.Count > 0)      //valido si existen valores en la lista
                {
                    for (int i = 0; i < objInfoBancariaList.Count; i++)     //recorrer cada uno de los elementos de la lista
                    {
                        BanamexDetalleTefC objTEFCDetalle = objInfoBancariaList[i];        //asignar los valores
                        string strRefAlfanumerica = "";
                        string strRefNumerica = "";

                        //si el tipo de movimiento Bancario es 05 => mantener las referencias originales
                        if (pIdTipoMovimientoBanco.Equals("05"))
                        {
                            strRefAlfanumerica = objTEFCDetalle.RefAlfanumerica.PadLeft(10, '0') + ' '.ToString().PadLeft(30, ' ');
                            strRefNumerica = objTEFCDetalle.RefNum.PadLeft(7, '0');
                        }
                        //si el tipo de movimiento Bancario es 12 => modificar las referencias originales
                        else if (pIdTipoMovimientoBanco.Equals("12"))
                        {
                            strRefAlfanumerica = objTEFCDetalle.RefAlfanumerica.PadRight(40, ' ');
                            strRefNumerica = objTEFCDetalle.RefNum.PadLeft(7, '0');
                        }

                        //enviar datos al archivo de texto
                        w.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}", objTEFCDetalle.TipoRegistro, objTEFCDetalle.TipoOperacion,
                                                                                objTEFCDetalle.ClaveMoneda,
                                                                                FormatoNumeros.ObtenerNumeroSinDecimal(objTEFCDetalle.Importe).PadLeft(18, '0'),
                                                                                objTEFCDetalle.TipoCuenta, objTEFCDetalle.NoCuentaBanco.PadLeft(20, '0'),
                                                                                strRefAlfanumerica,
                                                                                objTEFCDetalle.Beneficiario.PadRight(55, ' '), objTEFCDetalle.Instrucciones.PadRight(40, ' '),
                                                                                objTEFCDetalle.DescTEF.PadRight(24, ' '), objTEFCDetalle.ClaveBanco.PadLeft(4, '0'),
                                                                                strRefNumerica, objTEFCDetalle.Plazo.PadLeft(2, '0'));
                    }
                }


                //Seccion Total
                w.WriteLine("{0}{1}{2}{3}{4}{5}", objTEFC.TipoRegistroTotal, objTEFC.ClaveMonedaTotal,
                                                                objTEFC.NoAbonos, objTEFC.ImporteTotalAbonos,
                                                                objTEFC.NoCargos, objTEFC.ImporteTotalCargos);
                w.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("¡Error al generar Layout Bancario. \n{0} Contacte a Aplicaciones de Negocio!", ex.Message), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método para generar Layout Banamex TEF D
        /// </summary>
        /// <param name="objInfoBanco">Objeto con los Valores del Encabezado
        /// y Pie de Archivo de la Informacion Bancaria Tenedora</param>
        /// <param name="objInfoBancariaList">Objeto tipo Lista con los valores de los movimientos
        /// de cada pago por Empleado/Asociado</param>
        /// <param name="pFolioLoteCargaNomina">Clave Folio Lote de Carga</param>
        /// <param name="pIdTipoMovimientoBanco">Clave que otorga el Banco para clasificar el movimiento</param>
        /// <param name="pNoRegistrosPagos">No. total de movimientos de Empleados/Asociados procesados</param>
        /// <param name="pImportePagos">Importe total del pago de todos los movimientos individuales de
        /// Empleados/Asociados</param>
        /// <param name="pNoSecuenciaArchivo">No. de Archivo generado</param>
        /// <param name="pIdTipoMovimientoNomina">S=SUELDOS, A=ALIMENTOS</param>
        private void GenerarLayoutBancarioBanamexTEFD(InfoBancariaTenedora objInfoBanco, List<BanamexDetalleTefD> objInfoBancariaList, string pFolioLoteCargaNomina, string pIdTipoMovimientoBanco, Int32 pNoRegistrosPagos, decimal pImportePagos, short pNoSecuenciaArchivo, string pIdTipoMovimientoNomina)
        {
            BanamexTefD objTEFD = new BanamexTefD();
            string strLeyendaTipoMovimientoNomina = string.Empty;

            try
            {
                //informacion para asignar descripcion del archivo el Layout
                if (pIdTipoMovimientoNomina == "S")
                    strLeyendaTipoMovimientoNomina = this.validacionesGeneralTableAdapter1.ObtenerValorParametro("LEYENDA_TIPO_NOMINA_LAYOUT_BANAMEX_SA").ToString();
                else
                    strLeyendaTipoMovimientoNomina = this.validacionesGeneralTableAdapter1.ObtenerValorParametro("LEYENDA_TIPO_NOMINA_LAYOUT_BANAMEX_SC").ToString();

                //Control
                objTEFD.TipoRegistroControl = "1";      //constante
                objTEFD.NoIdentificacionCliente = objInfoBanco.NoCliente;
                objTEFD.FechaPago = dtFechaPago.Value.Year.ToString().Substring(2, 2) + dtFechaPago.Value.Month.ToString().PadLeft(2, '0') + dtFechaPago.Value.Day.ToString().PadLeft(2, '0');
                objTEFD.SecuencialArchivo = pNoSecuenciaArchivo.ToString().PadLeft(4, '0');
                objTEFD.NombreEmpresa = objInfoBanco.RazonSocial;
                objTEFD.DescArchivo = strLeyendaTipoMovimientoNomina.PadRight(20, ' ');
                objTEFD.NaturalezaArchivo = "15";     //15=Constante
                objTEFD.VersionLayout = "D";        //constante
                objTEFD.TipoCargo = "01";           //constante
                //Global
                objTEFD.TipoRegistroGlobal = "2";       //constante
                objTEFD.TipoOperacionGlobal = "1";
                objTEFD.ClaveMonedaGlobal = "001";      //constante

                //generar formato del importe total sin PUNTO decimal
                string strImporte = FormatoNumeros.ObtenerNumeroSinDecimal(pImportePagos);
                objTEFD.ImporteAbonarPagar = strImporte.PadLeft(18, '0');
                objTEFD.TipoCuentaGlobal = "01";
                objTEFD.NoCuentaGlobal = (objInfoBanco.NoSucursal + objInfoBanco.NoCuenta.Substring(13, 7)).PadLeft(20, '0');
                objTEFD.TotalAbonos = pNoRegistrosPagos.ToString().PadLeft(6, '0');
                //Total
                objTEFD.TipoRegistroTotal = "4";    //constante
                objTEFD.ClaveMonedaTotal = "001";
                objTEFD.NoAbonos = pNoRegistrosPagos.ToString().PadLeft(6, '0');
                objTEFD.ImporteTotalAbonos = strImporte.PadLeft(18, '0');
                objTEFD.NoCargos = "000001";
                objTEFD.ImporteTotalCargos = strImporte.PadLeft(18, '0');


                //Escribir archivo Layout TEF C
                FileInfo f = new FileInfo(string.Format(@"C:\LAYOUTS\{0}L{1}-BXD{2}.{3}", pIdTipoMovimientoNomina, pFolioLoteCargaNomina, pIdTipoMovimientoBanco, "TXT"));
                StreamWriter w = f.CreateText();
                //Seccion Control
                w.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}", objTEFD.TipoRegistroControl, objTEFD.NoIdentificacionCliente,
                                                        objTEFD.FechaPago, objTEFD.SecuencialArchivo, objTEFD.NombreEmpresa,
                                                        objTEFD.DescArchivo, objTEFD.NaturalezaArchivo,
                                                        objTEFD.VersionLayout, objTEFD.TipoCargo);
                //Seccion Global
                w.WriteLine("{0}{1}{2}{3}{4}{5}{6}", objTEFD.TipoRegistroGlobal, objTEFD.TipoOperacionGlobal,
                                                                        objTEFD.ClaveMonedaGlobal, objTEFD.ImporteAbonarPagar,
                                                                        objTEFD.TipoCuentaGlobal, objTEFD.NoCuentaGlobal,
                                                                        objTEFD.TotalAbonos);


                //Seccion Individual
                if (objInfoBancariaList.Count > 0)      //valido si existen valores en la lista
                {
                    for (int i = 0; i < objInfoBancariaList.Count; i++)     //recorrer cada uno de los elementos de la lista
                    {
                        BanamexDetalleTefD objTEFDDetalle = objInfoBancariaList[i];        //asignar los valores
                        //enviar datos al archivo de texto
                        w.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}",
                                                                                objTEFDDetalle.TipoRegistro, objTEFDDetalle.TipoOperacion,
                                                                                objTEFDDetalle.MetodoPago, objTEFDDetalle.TipoPago, objTEFDDetalle.ClaveMoneda,
                                                                                FormatoNumeros.ObtenerNumeroSinDecimal(objTEFDDetalle.Importe).PadLeft(18, '0'),
                                                                                objTEFDDetalle.TipoCuenta, objTEFDDetalle.NoCuentaBanco.PadLeft(20, '0'),
                                                                                objTEFDDetalle.RefAlfanumerica.PadRight(16, ' '),
                                                                                objTEFDDetalle.Beneficiario.PadRight(55, ' '), objTEFDDetalle.Referencia1.PadRight(35, ' '),
                                                                                objTEFDDetalle.Referencia2.PadRight(35, ' '), objTEFDDetalle.Referencia3.PadRight(35, ' '),
                                                                                objTEFDDetalle.Referencia4.PadRight(35, ' '), objTEFDDetalle.ClaveBanco.PadLeft(4, '0'),
                                                                                objTEFDDetalle.Plazo.PadLeft(2, '0'), objTEFDDetalle.RFC.PadRight(14, ' '),
                                                                                objTEFDDetalle.IVA.PadRight(8, ' '), objTEFDDetalle.UsoFuturo1.PadRight(80, ' '),
                                                                                objTEFDDetalle.UsoFuturo2.PadRight(50, ' '));
                    }
                }


                //Seccion Total
                w.WriteLine("{0}{1}{2}{3}{4}{5}", objTEFD.TipoRegistroTotal, objTEFD.ClaveMonedaTotal,
                                                                objTEFD.NoAbonos, objTEFD.ImporteTotalAbonos,
                                                                objTEFD.NoCargos, objTEFD.ImporteTotalCargos);
                w.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("¡Error al generar Layout Bancario. \n{0} Contacte a Aplicaciones de Negocio!", ex.Message), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Método para generar Layout Bancomer Nomina-TDP
        /// </summary>
        /// <param name="objInfoBanco">Objeto con los Valores del Encabezado
        /// y Pie de Archivo de la Informacion Bancaria Tenedora</param>
        /// <param name="objInfoBancariaList">Objeto tipo Lista con los valores de los movimientos
        /// de cada pago por Empleado/Asociado</param>
        /// <param name="pFolioLoteCargaNomina">Clave Folio Lote de Carga</param>
        /// <param name="pIdTipoMovimientoBanco">Clave que otorga el Banco para clasificar el movimiento</param>
        /// <param name="pNoRegistrosPagos">No. total de movimientos de Empleados/Asociados procesados</param>
        /// <param name="pImportePagos">Importe total del pago de todos los movimientos individuales de
        /// Empleados/Asociados</param>
        /// <param name="pNoSecuenciaArchivo">No. de Archivo generado</param>
        /// <param name="pIdTipoMovimientoNomina">S=SUELDOS, A=ALIMENTOS</param>
        private void GenerarLayoutBancarioBancomer(InfoBancariaTenedora objInfoBanco, List<Bancomer> objInfoBancariaList, string pFolioLoteCargaNomina, string pIdTipoMovimientoBanco, Int32 pNoRegistrosPagos, decimal pImportePagos, short pNoSecuenciaArchivo, string pIdTipoMovimientoNomina)
        {
            Bancomer objBBVA = new Bancomer();

            try
            {
                //Escribir archivo Layout Bancomer
                FileInfo f = new FileInfo(string.Format(@"C:\LAYOUTS\{0}L{1}-BBVA{2}.{3}", pIdTipoMovimientoNomina, pFolioLoteCargaNomina, pIdTipoMovimientoBanco, "TXT"));
                StreamWriter w = f.CreateText();

                //Seccion Detalle
                if (objInfoBancariaList.Count > 0)      //valido si existen valores en la lista
                {
                    for (int i = 0; i < objInfoBancariaList.Count; i++)     //recorrer cada uno de los elementos de la lista
                    {
                        Bancomer objBBVADetalle = objInfoBancariaList[i];        //asignar los valores
                        //enviar datos al archivo de texto
                        w.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}",
                                                                                objBBVADetalle.NoRenglon.PadLeft(9, '0'),
                                                                                objBBVADetalle.RFC.PadRight(16, ' '),
                                                                                objBBVADetalle.TipoCuenta,
                                                                                objBBVADetalle.NoCuenta.PadRight(20, ' '),
                                                                                FormatoNumeros.ObtenerNumeroSinDecimal(objBBVADetalle.Importe).PadLeft(15, '0'),
                                                                                objBBVADetalle.Beneficiario.PadRight(40, ' '),
                                                                                objBBVADetalle.BancoDestino,
                                                                                objBBVADetalle.PlazaDestino);
                    }
                }
                w.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("¡Error al generar Layout Bancario. \n{0} Contacte a Aplicaciones de Negocio!", ex.Message), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Método para generar Layout Banorte 
        /// </summary>
        /// <param name="objInfoBanco">Objeto con los Valores del Encabezado
        /// y Pie de Archivo de la Informacion Bancaria Tenedora</param>
        /// <param name="objInfoBancariaList">Objeto tipo Lista con los valores de los movimientos
        /// de cada pago por Empleado/Asociado</param>
        /// <param name="pEmisora">Clave de Emisora</param>
        /// <param name="pFechaProceso">Fecha del Proceso de la Nomina</param>
        /// <param name="pFolioLoteCargaNomina">Clave Folio Lote de Carga</param>
        /// <param name="pIdTipoMovimientoBanco">Clave que otorga el Banco para clasificar el movimiento</param>
        /// <param name="pNoRegistrosPagos">No. total de movimientos de Empleados/Asociados procesados</param>
        /// <param name="pImportePagos">Importe total del pago de todos los movimientos individuales de
        /// Empleados/Asociados</param>
        /// <param name="pNoSecuenciaArchivo">No. de Archivo generado</param>
        /// <param name="pIdTipoMovimientoNomina">S=SUELDOS, A=ALIMENTOS</param>
        private void GenerarLayoutBancarioBanorte(InfoBancariaTenedora objInfoBanco, List<BanorteDetalle> objInfoBancariaList, string pFolioLoteCargaNomina, Int32 pNoRegistrosPagos, decimal pImportePagos, string pIdTipoMovimientoNomina, string pFechaProceso, string pEmisora, short pNoSecuenciaArchivo)
        {
            Banorte objBanorte = new Banorte();
            try
            {
                //Encabezado
                objBanorte.TipoRegistro = "H";      //constante
                objBanorte.ClaveServicio = "NE";    //constante
                objBanorte.Emisora = pEmisora.PadLeft(5, '0');
                objBanorte.FechaProceso = dtFechaPago.Value.Year.ToString() + dtFechaPago.Value.Month.ToString().PadLeft(2, '0') + dtFechaPago.Value.Day.ToString().PadLeft(2, '0');
                objBanorte.SecuencialArchivoConsecutivo = pNoSecuenciaArchivo.ToString().PadLeft(2, '0');
                objBanorte.NoTotalRegistrosEnviados = pNoRegistrosPagos.ToString().PadLeft(6, '0');

                string strImporte = FormatoNumeros.ObtenerNumeroSinDecimal(pImportePagos);
                objBanorte.ImporteTotalRegistrosEnviados = strImporte.PadLeft(15, '0');

                objBanorte.NoTotalAltasEnviados = "0".PadRight(6, '0');
                objBanorte.ImporteTotalAltasEnviados = "0".PadRight(15, '0');

                objBanorte.NoTotalBajasEnviados = "0".PadRight(6, '0');
                objBanorte.ImporteTotalBajasEnviados = "0".PadRight(15, '0');

                objBanorte.NoTotalCuentasVerificar = "0".PadLeft(6, '0');
                if (pIdTipoMovimientoNomina == "A")
                    objBanorte.Accion = "8";
                else
                    objBanorte.Accion = "0";
                objBanorte.Filler = ' '.ToString().PadRight(77, ' ');

                //Escribir archivo Layout Banorte
                //se modificó 11/04/2013 porque banorte no acepta nombres Personalizados
                //la sintaxis del archivo es: NI + No. Emisora + Consecutivo + .pag
                //FileInfo f = new FileInfo(string.Format(@"C:\LAYOUTS\{0}L{1}-BAN{2}{3}.{4}", pIdTipoMovimientoNomina, pFolioLoteCargaNomina, objBanorte.Emisora, objBanorte.SecuencialArchivoConsecutivo, "pag"));
                FileInfo f = new FileInfo(string.Format(@"C:\LAYOUTS\NI{2}{3}L{1}.{4}", pIdTipoMovimientoNomina, pFolioLoteCargaNomina, objBanorte.Emisora, objBanorte.SecuencialArchivoConsecutivo, "pag"));
                StreamWriter w = f.CreateText();
                //Seccion Encabezado
                w.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}", objBanorte.TipoRegistro, objBanorte.ClaveServicio, objBanorte.Emisora,
                                                        objBanorte.FechaProceso, objBanorte.SecuencialArchivoConsecutivo, objBanorte.NoTotalRegistrosEnviados,
                                                        objBanorte.ImporteTotalRegistrosEnviados, objBanorte.NoTotalAltasEnviados, objBanorte.ImporteTotalAltasEnviados,
                                                        objBanorte.NoTotalBajasEnviados, objBanorte.ImporteTotalBajasEnviados, objBanorte.NoTotalCuentasVerificar,
                                                        objBanorte.Accion, objBanorte.Filler);

                //Seccion Individual
                if (objInfoBancariaList.Count > 0)      //valido si existen valores en la lista
                {
                    for (int i = 0; i < objInfoBancariaList.Count; i++)     //recorrer cada uno de los elementos de la lista
                    {
                        BanorteDetalle objBanorteDetalle = objInfoBancariaList[i];        //asignar los valores

                        //enviar datos al archivo de texto
                        w.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}", objBanorteDetalle.TipoRegistro, objBanorteDetalle.FechaAplicacion,
                                                                                objBanorteDetalle.NoEmpleado, objBanorteDetalle.ReferenciaServicio,
                                                                                objBanorteDetalle.ReferenciaLeyenda,
                                                                                FormatoNumeros.ObtenerNumeroSinDecimal(objBanorteDetalle.Importe).PadLeft(15, '0'),
                                                                                objBanorteDetalle.NoBancoReceptor, objBanorteDetalle.TipoCuenta,
                                                                                objBanorteDetalle.NoCuenta, objBanorteDetalle.TipoMovimiento,
                                                                                objBanorteDetalle.Accion, objBanorteDetalle.ImporteIVAOperacion,
                                                                                objBanorteDetalle.Filler);
                    }
                }

                w.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("¡Error al generar Layout Bancario. \n{0} Contacte a Aplicaciones de Negocio!", ex.Message), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método para generar Layout Santander 
        /// </summary>
        /// <param name="objInfoBanco">Objeto con los Valores del Encabezado
        /// y Pie de Archivo de la Informacion Bancaria Tenedora</param>
        /// <param name="objInfoBancariaList">Objeto tipo Lista con los valores de los movimientos
        /// de cada pago por Empleado/Asociado</param>
        /// <param name="pEmisora">Clave de Emisora</param>
        /// <param name="pFechaProceso">Fecha del Proceso de la Nomina</param>
        /// <param name="pFolioLoteCargaNomina">Clave Folio Lote de Carga</param>
        /// <param name="pIdTipoMovimientoBanco">Clave que otorga el Banco para clasificar el movimiento</param>
        /// <param name="pNoRegistrosPagos">No. total de movimientos de Empleados/Asociados procesados</param>
        /// <param name="pImportePagos">Importe total del pago de todos los movimientos individuales de
        /// Empleados/Asociados</param>
        /// <param name="pNoSecuenciaArchivo">No. de Archivo generado</param>
        /// <param name="pIdTipoMovimientoNomina">S=SUELDOS, A=ALIMENTOS/PENSION</param>
        private void GenerarLayoutBancarioSantander(InfoBancariaTenedora objInfoBanco, List<SantanderDetalle> objInfoBancariaList, string pFolioLoteCargaNomina, Int32 pNoRegistrosPagos, decimal pImportePagos, string pIdTipoMovimientoNomina, string pFechaProceso, short pNoSecuenciaArchivo)
        {
            Santander objSantander = new Santander();
            Int32 intConsecutivoRenglon = 1;
            string sDesconocido = "     ";
            try
            {
                //Encabezado
                objSantander.TipoRegistroEncabezado = "1";      //constante
                objSantander.SecuencialArchivoConsecutivo = pNoSecuenciaArchivo.ToString().PadLeft(5, '0');
                objSantander.Sentido = "E";    //constante
                objSantander.FechaGeneracion = pFechaProceso;
                objSantander.NoCuentaCargo = objInfoBanco.NoCuenta.PadLeft(16, ' ');
                objSantander.FechaAplicacion = pFechaProceso;

                //Total
                objSantander.TipoRegistroTotal = "3";       //constante
                objSantander.NoTotalRegistrosEnviados = pNoRegistrosPagos.ToString().PadLeft(5, '0');

                string strImporte = FormatoNumeros.ObtenerNumeroSinDecimal(pImportePagos);
                objSantander.ImporteTotalRegistrosEnviados = strImporte.PadLeft(18, '0');

                //Escribir archivo Layout Banorte
                FileInfo f = new FileInfo(string.Format(@"C:\LAYOUTS\{0}L{1}-SAN_{2}.{3}", pIdTipoMovimientoNomina, pFolioLoteCargaNomina, objSantander.SecuencialArchivoConsecutivo, "TXT"));
                StreamWriter w = f.CreateText();

                //Seccion Encabezado
                w.WriteLine("{0}{1}{2}{3}{4}{5}", objSantander.TipoRegistroEncabezado, intConsecutivoRenglon.ToString().PadLeft(5, '0'),
                                                        objSantander.Sentido, objSantander.FechaGeneracion, objSantander.NoCuentaCargo, objSantander.FechaAplicacion);

                //Seccion Individual
                if (objInfoBancariaList.Count > 0)      //valido si existen valores en la lista
                {
                    for (int i = 0; i < objInfoBancariaList.Count; i++)     //recorrer cada uno de los elementos de la lista
                    {
                        SantanderDetalle objSantanderDetalle = objInfoBancariaList[i];        //asignar los valores
                        intConsecutivoRenglon++;    //incrementa en 1 el contador de renglones

                        //enviar datos al archivo de texto
                        w.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}", objSantanderDetalle.TipoRegistro, intConsecutivoRenglon.ToString().PadLeft(5, '0'),
                                                                                objSantanderDetalle.NoEmpleado,
                                                                                objSantanderDetalle.ApellidoPaterno,
                                                                                objSantanderDetalle.ApellidoMaterno, objSantanderDetalle.Nombre,
                                                                                objSantanderDetalle.NoCuenta,
                                                                                sDesconocido,
                                                                                FormatoNumeros.ObtenerNumeroSinDecimal(objSantanderDetalle.Importe).PadLeft(18, '0'));
                    }
                }
                intConsecutivoRenglon++;    //incrementa en 1 el contador de renglones
                //Seccion Total
                w.WriteLine("{0}{1}{2}{3}", objSantander.TipoRegistroTotal, intConsecutivoRenglon.ToString().PadLeft(5, '0'),
                                                        objSantander.NoTotalRegistrosEnviados, objSantander.ImporteTotalRegistrosEnviados);

                w.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("¡Error al generar Layout Bancario. \n{0} Contacte a Aplicaciones de Negocio!", ex.Message), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método para generar Layout CIBanco 
        /// </summary>
        /// <param name="objInfoBanco">Objeto con los Valores del Encabezado
        /// y Pie de Archivo de la Informacion Bancaria Tenedora</param>
        /// <param name="objInfoBancariaList">Objeto tipo Lista con los valores de los movimientos
        /// de cada pago por Empleado/Asociado</param>
        /// <param name="pFechaProceso">Fecha del Proceso de la Nomina</param>
        /// <param name="pCuentaCargo">Cuenta de Cargo de la empresa pagadora</param>
        /// <param name="pNoRegistrosPagos">No. total de movimientos de Empleados/Asociados procesados</param>
        /// <param name="pImportePagos">Importe total del pago de todos los movimientos individuales de
        /// Empleados/Asociados</param>
        /// <param name="pEmisora">Clave de Emisora (Empresa Pagadora)</param>
        private void GenerarLayoutBancarioCIBanco(InfoBancariaTenedora objInfoBanco, List<CIBanco> objInfoBancariaList, Int32 pNoRegistrosPagos, decimal pImportePagos, string pEmisora)
        {
            try
            {
                //Escribir archivo Layout CIBanco
                FileInfo f = new FileInfo(string.Format(@"C:\LAYOUTS\O_{0}.{1}", objInfoBanco.NoCliente, "TXT"));
                StreamWriter w = f.CreateText();

                //Seccion Detalle
                if (objInfoBancariaList.Count > 0)      //valido si existen valores en la lista
                {
                    for (int i = 0; i < objInfoBancariaList.Count; i++)     //recorrer cada uno de los elementos de la lista
                    {
                        CIBanco objCIBancoDetalle = objInfoBancariaList[i];        //asignar los valores
                        //enviar datos al archivo de texto
                        w.WriteLine("{0},{1},{2},{3},{4},{5},{6}",
                                                                                objCIBancoDetalle.TipoPago,
                                                                                objInfoBanco.NoCuenta,
                                                                                string.Format("{0:0.00}", objCIBancoDetalle.Importe),    //formateo a 2 decimales
                                                                                objCIBancoDetalle.NoCuentaBanco,
                                                                                objCIBancoDetalle.Beneficiario, //.PadRight(35, ' '),
                                                                                objCIBancoDetalle.RFC.PadRight(13, ' '),
                                                                                objCIBancoDetalle.DescPago);
                    }
                    //anexar última línea al archivo
                    w.WriteLine("{0},{1},{2}", "T", pNoRegistrosPagos, string.Format("{0:0.00}", pImportePagos));
                }
                w.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("¡Error al generar Layout Bancario. \n{0} Contacte a Aplicaciones de Negocio!", ex.Message), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método para generar Layout HSBC Otras Cuentas HSBC 
        /// </summary>
        /// <param name="objInfoBanco">Objeto con los Valores del Encabezado
        /// y Pie de Archivo de la Informacion Bancaria Tenedora</param>
        /// <param name="objInfoBancariaList">Objeto tipo Lista con los valores de los movimientos
        /// de cada pago por Empleado/Asociado</param>
        ///<param name="pFolioLoteCargaNomina">No. Folio Lote carga Nomina</param>
        /// <param name="pNoRegistrosPagos">No. total de movimientos de Empleados/Asociados procesados</param>
        /// <param name="pImportePagos">Importe total del pago de todos los movimientos individuales de
        /// Empleados/Asociados</param>
        /// <param name="pConsecutivo">No. Consecutivo</param>
        private void GenerarLayoutBancarioHSBCOtrasCuentas(InfoBancariaTenedora objInfoBanco, List<HSBCOtrasCuentas> objInfoBancariaList, string pFolioLoteCargaNomina, Int32 pNoRegistrosPagos, decimal pImportePagos, string pConsecutivo, string pLeyendaDispersion)
        {
            Int32 intConsecutivoRenglon = 1;
            string strLeyendaConceptoFinArchivo = pLeyendaDispersion.PadRight(40, ' ');

            try
            {
                //Escribir archivo Layout HSBC
                FileInfo f = new FileInfo(string.Format(@"C:\LAYOUTS\HSBC_OCT_L{0}.{1}", pFolioLoteCargaNomina, "TXT"));
                StreamWriter w = f.CreateText();

                //Seccion Detalle
                if (objInfoBancariaList.Count > 0)      //valido si existen valores en la lista
                {
                    for (int i = 0; i < objInfoBancariaList.Count; i++)     //recorrer cada uno de los elementos de la lista
                    {
                        HSBCOtrasCuentas objHSBCBancoDetalle = objInfoBancariaList[i];        //asignar los valores
                        //enviar datos al archivo de texto
                        w.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}",
                                                            intConsecutivoRenglon.ToString().PadLeft(6, '0'),
                                                            objInfoBanco.NoCuenta,
                                                            objHSBCBancoDetalle.NoCuentaBanco,
                                                            FormatoNumeros.ObtenerNumeroSinDecimal(objHSBCBancoDetalle.Importe).PadLeft(13, '0'),
                                                            objHSBCBancoDetalle.ClaveMoneda,
                                                            objHSBCBancoDetalle.DescPago,
                                                            objHSBCBancoDetalle.Beneficiario,
                                                            objHSBCBancoDetalle.ComprobanteFiscal,
                                                            objHSBCBancoDetalle.RFCBeneficiario,
                                                            objHSBCBancoDetalle.IVA,
                                                            objHSBCBancoDetalle.Email);
                        intConsecutivoRenglon++;
                    }
                    //anexar última línea al archivo
                    w.WriteLine("{0}{1}{2}", pConsecutivo.PadLeft(6, '0'), pNoRegistrosPagos.ToString().PadLeft(6, '0'), strLeyendaConceptoFinArchivo);
                }
                w.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("¡Error al generar Layout Bancario. \n{0} Contacte a Aplicaciones de Negocio!", ex.Message), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Método para generar Layout HSBC Interbancarios SPEI
        /// </summary>
        /// <param name="objInfoBanco">Objeto con los Valores del Encabezado
        /// y Pie de Archivo de la Informacion Bancaria Tenedora</param>
        /// <param name="objInfoBancariaList">Objeto tipo Lista con los valores de los movimientos
        /// de cada pago por Empleado/Asociado</param>
        ///<param name="pFolioLoteCargaNomina">No. Folio Lote carga Nomina</param>
        private void GenerarLayoutBancarioHSBCSPEI(InfoBancariaTenedora objInfoBanco, List<HSBCSPEI> objInfoBancariaList, string pIdTipoMovimientoNomina, string pFolioLoteCargaNomina)
        {
            try
            {
                //Escribir archivo Layout HSBC
                FileInfo f = new FileInfo(string.Format(@"C:\LAYOUTS\{0}L{1}-HSBC_SPEI.{2}", pIdTipoMovimientoNomina, pFolioLoteCargaNomina, "TXT"));
                StreamWriter w = f.CreateText();

                //Seccion Detalle
                if (objInfoBancariaList.Count > 0)      //valido si existen valores en la lista
                {
                    for (int i = 0; i < objInfoBancariaList.Count; i++)     //recorrer cada uno de los elementos de la lista
                    {
                        HSBCSPEI objHSBCBancoDetalle = objInfoBancariaList[i];        //asignar los valores
                        //enviar datos al archivo de texto
                        w.WriteLine("{0}{1}{2}{3}{4}{5}{6}",
                                                objInfoBanco.NoCuenta,
                                                objInfoBanco.RefAlfanumerica.PadRight(18, ' '),
                                                objHSBCBancoDetalle.NoCuentaBanco,
                                                FormatoNumeros.ObtenerNumeroSinDecimal(objHSBCBancoDetalle.Importe).PadLeft(18, '0'),
                                                objHSBCBancoDetalle.ReferenciaNumerica,
                                                objHSBCBancoDetalle.DescPago,
                                                objHSBCBancoDetalle.DescPagoOrdenante);
                    }
                }
                w.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("¡Error al generar Layout Bancario. \n{0} Contacte a Aplicaciones de Negocio!", ex.Message), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Método para generar Layout HSBC Nomina
        /// </summary>
        /// <param name="objInfoBanco">Objeto con los Valores del Encabezado
        /// y Pie de Archivo de la Informacion Bancaria Tenedora</param>
        /// <param name="objInfoBancariaList">Objeto tipo Lista con los valores de los movimientos
        /// de cada pago por Empleado/Asociado</param>
        ///<param name="pFolioLoteCargaNomina">No. Folio Lote carga Nomina</param>
        private void GenerarLayoutBancarioHSBCNominas(InfoBancariaTenedora objInfoBanco, List<HSBCNominas> objInfoBancariaList, string pIdTipoMovimientoNomina, string pFolioLoteCargaNomina)
        {
            try
            {
                //Escribir archivo Layout HSBC
                FileInfo f = new FileInfo(string.Format(@"C:\LAYOUTS\{0}L{1}-HSBC_NOM.{2}", pIdTipoMovimientoNomina, pFolioLoteCargaNomina, "TXT"));
                StreamWriter w = f.CreateText();

                //Seccion Detalle
                if (objInfoBancariaList.Count > 0)      //valido si existen valores en la lista
                {
                    for (int i = 0; i < objInfoBancariaList.Count; i++)     //recorrer cada uno de los elementos de la lista
                    {
                        HSBCNominas objHSBCBancoDetalle = objInfoBancariaList[i];        //asignar los valores
                        //enviar datos al archivo de texto
                        w.WriteLine("{0}{1}{2}{3}",
                                                objHSBCBancoDetalle.NoCuentaBanco,
                                                FormatoNumeros.ObtenerNumeroSinDecimal(objHSBCBancoDetalle.Importe).PadLeft(13, '0'),
                                                objHSBCBancoDetalle.DescPago,
                                                objHSBCBancoDetalle.Beneficiario.PadRight(40, ' '));
                    }
                }
                w.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("¡Error al generar Layout Bancario. \n{0} Contacte a Aplicaciones de Negocio!", ex.Message), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Método para generar Layout HSBC Nomina
        /// </summary>
        /// <param name="objInfoBanco">Objeto con los Valores del Encabezado
        /// y Pie de Archivo de la Informacion Bancaria Tenedora</param>
        /// <param name="objInfoBancariaList">Objeto tipo Lista con los valores de los movimientos
        /// de cada pago por Empleado/Asociado</param>
        ///<param name="pFolioLoteCargaNomina">No. Folio Lote carga Nomina</param>
        private void GenerarLayoutBancarioHSBCNETNominas(InfoBancariaTenedora objInfoBanco, List<HSBCNominas> objInfoBancariaList, string pFolioLoteCargaNomina, Int32 pNoRegistrosPagos, decimal pImportePagos, string pFechaProceso, string pReferenciaLote, string pIdTipoMovimientoNomina)
        {
            HSBCNET objHSBCNet = new HSBCNET();

            try
            {
                objHSBCNet.IndicadorFormatoArchivo = "MXPRLF";
                objHSBCNet.NivelAutorizacion = "F";     //constante
                objHSBCNet.NoCuentaCargo = objInfoBanco.NoCuenta.PadLeft(10, '0');

                string strImporte = FormatoNumeros.ObtenerNumeroSinDecimal(pImportePagos);
                objHSBCNet.ImporteTotalRegistrosEnviados = strImporte.PadLeft(14, '0');
                objHSBCNet.NoTotalRegistrosEnviados = pNoRegistrosPagos.ToString().PadLeft(7, '0');
                objHSBCNet.FechaAplicacion = pFechaProceso;
                objHSBCNet.HoraAplicacion = "".PadRight(5, ' ');
                objHSBCNet.ReferenciaLote = pReferenciaLote.PadRight(34, ' ');

                //Escribir archivo Layout HSBCNET
                FileInfo f = new FileInfo(string.Format(@"C:\LAYOUTS\{0}L{1}-HSBCNET_NOM.{2}", pIdTipoMovimientoNomina, pFolioLoteCargaNomina, "TXT"));
                StreamWriter w = f.CreateText();

                //Seccion Encabezado
                w.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}", objHSBCNet.IndicadorFormatoArchivo, objHSBCNet.NivelAutorizacion,
                        objHSBCNet.NoCuentaCargo, objHSBCNet.ImporteTotalRegistrosEnviados,
                        objHSBCNet.NoTotalRegistrosEnviados, objHSBCNet.FechaAplicacion,
                        objHSBCNet.HoraAplicacion, objHSBCNet.ReferenciaLote);


                //Seccion Detalle
                if (objInfoBancariaList.Count > 0)      //valido si existen valores en la lista
                {
                    for (int i = 0; i < objInfoBancariaList.Count; i++)     //recorrer cada uno de los elementos de la lista
                    {
                        HSBCNominas objHSBCBancoDetalle = objInfoBancariaList[i];        //asignar los valores
                        //enviar datos al archivo de texto
                        w.WriteLine("{0}{1}{2}{3}",
                                                objHSBCBancoDetalle.NoCuentaBanco,
                                                FormatoNumeros.ObtenerNumeroSinDecimal(objHSBCBancoDetalle.Importe).PadLeft(14, '0'),
                                                objHSBCBancoDetalle.DescPago,
                                                objHSBCBancoDetalle.Beneficiario.PadRight(35, ' '));
                    }
                }
                w.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("¡Error al generar Layout Bancario. \n{0} Contacte a Aplicaciones de Negocio!", ex.Message), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Método para generar Layout Inbursa SPEI
        /// </summary>
        /// <param name="objInfoBanco">Objeto con los Valores del Encabezado
        /// y Pie de Archivo de la Informacion Bancaria Tenedora</param>
        /// <param name="objInfoBancariaList">Objeto tipo Lista con los valores de los movimientos
        /// de cada pago por Empleado/Asociado</param>
        ///<param name="pFolioLoteCargaNomina">No. Folio Lote carga Nomina</param>
        private void GenerarLayoutBancarioInbursaSPEI(InfoBancariaTenedora objInfoBanco, List<InbursaSPEI> objInfoBancariaList, string pIdTipoMovimiento, string pFolioLoteCargaNomina, Int32 pNoRegistrosPagos, decimal pImportePagos, string pFechaProceso)
        {
            Inbursa objInbursa = new Inbursa();     //objeto para informacion Encabezado Layout Inbursa

            try
            {
                objInbursa.FechaAplicacion = pFechaProceso;
                objInbursa.NoSucursal = objInfoBanco.NoSucursal;
                objInbursa.NoCuentaCargo = objInfoBanco.NoCuenta;
                objInbursa.NoTotalRegistrosEnviados = pNoRegistrosPagos.ToString().PadLeft(5, '0');

                string strImporte = pImportePagos.ToString("N2");
                objInbursa.ImporteTotalRegistrosEnviados = strImporte.Replace(",", "").PadLeft(15, '0');

                //Escribir archivo Layout Inbursa SPEI
                FileInfo f = new FileInfo(string.Format(@"C:\LAYOUTS\{0}L{1}-INBUR_SPEI.{2}", pIdTipoMovimiento, pFolioLoteCargaNomina, "TXT"));
                StreamWriter w = f.CreateText();

                //Seccion Encabezado
                w.WriteLine("{0}\t{1}", objInbursa.NoTotalRegistrosEnviados, objInbursa.ImporteTotalRegistrosEnviados);


                //Seccion Detalle
                if (objInfoBancariaList.Count > 0)      //valido si existen valores en la lista
                {
                    for (int i = 0; i < objInfoBancariaList.Count; i++)     //recorrer cada uno de los elementos de la lista
                    {
                        InbursaSPEI objInbursaBancoDetalle = objInfoBancariaList[i];        //asignar los valores
                        //enviar datos al archivo de texto
                        w.WriteLine("{0}\t{1}{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}",
                                                objInbursa.FechaAplicacion,
                                                objInbursa.NoSucursal,
                                                objInbursa.NoCuentaCargo,
                                                objInbursaBancoDetalle.NoCuentaBanco,
                                                objInbursaBancoDetalle.Importe.ToString("N2").Replace(",", "").PadLeft(15, '0'),
                                                objInbursaBancoDetalle.ReferenciaLeyenda,
                                                objInbursaBancoDetalle.ReferenciaExt,
                                                objInbursaBancoDetalle.ReferenciaNumerica,
                                                objInbursaBancoDetalle.RFC,
                                                objInbursaBancoDetalle.Identificador);
                    }
                }
                w.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("¡Error al generar Layout Bancario. \n{0} Contacte a Aplicaciones de Negocio!", ex.Message), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método para generar Layout Banorte Proveedores
        /// </summary>
        /// <param name="objInfoBanco">Objeto con información del Banco</param>
        /// <param name="objInfoBancariaEmpleadoList">Objeto tipo Lista con los valores de los movimientos
        /// de cada pago por Empleado/Asociado</param>
        /// <param name="pFolioLoteCargaNomina">No. Lote Nómina</param>
        /// <param name="pIdTipoMovimientoNomina">Tipo de Movimiento</param>
        /// <param name="pFechaProceso">Fecha de la Operación</param>
        /// <param name="pEmisora">No. Emisora (NO SE UTILIZA)</param>
        /// <param name="pNoSecuenciaArchivo">No. Consecutivo Archivo</param>
        /// <param name="pTipoLayout">Clave para identificar Banorte-Banorte y Banorte-Interbancario</param>
        private void GenerarLayoutBancarioBanorte2016(InfoBancariaTenedora objInfoBanco, List<Banorte2016> objInfoBancariaEmpleadoList, string pFolioLoteCargaNomina, string pIdTipoMovimientoNomina, string pFechaProceso, string pEmisora, short pNoSecuenciaArchivo, string pTipoLayout)
        {
            Banorte2016 objBanorte = new Banorte2016();
            try
            {
                FileInfo f = null;

                if (pTipoLayout.Equals("BAN2BAN"))
                {
                    //la sintaxis del archivo es: BAN2BANPROV_ + TIPO NOMINA + L + LOTE NOMINA + .TXT
                    f = new FileInfo(string.Format(@"C:\LAYOUTS\BAN2BANPROV_{0}L{1}.{2}", pIdTipoMovimientoNomina, pFolioLoteCargaNomina, "txt"));
                }
                else if (pTipoLayout.Equals("BAN2INT"))
                {
                    //la sintaxis del archivo es: BAN2INTPROV_ + TIPO NOMINA + L + LOTE NOMINA + .TXT
                    f = new FileInfo(string.Format(@"C:\LAYOUTS\BAN2INTPROV_{0}L{1}.{2}", pIdTipoMovimientoNomina, pFolioLoteCargaNomina, "txt"));
                }
                StreamWriter w = f.CreateText();

                //Seccion Detalle
                if (objInfoBancariaEmpleadoList.Count > 0)      //valido si existen valores en la lista
                {
                    for (int i = 0; i < objInfoBancariaEmpleadoList.Count; i++)     //recorrer cada uno de los elementos de la lista
                    {
                        Banorte2016 objBanorteDetalle = objInfoBancariaEmpleadoList[i];        //asignar los valores

                        //enviar datos al archivo de texto
                        w.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}\t{10}", objBanorteDetalle.Operacion, objBanorteDetalle.ClaveID,
                                                                                objInfoBanco.NoCuenta.Substring(10, objInfoBanco.NoCuenta.Length - 10), objBanorteDetalle.NoCuentaBanco,
                                                                                string.Format("{0:0.00}", objBanorteDetalle.Importe),
                                                                                objBanorteDetalle.Referencia, objBanorteDetalle.Descripcion,
                                                                                objBanorteDetalle.RFCOrdenante, objBanorteDetalle.IVA,
                                                                                "", objBanorteDetalle.InstruccionPago);
                    }
                }

                w.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("¡Error al generar Layout Bancario. \n{0} Contacte a Aplicaciones de Negocio!", ex.Message), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método que genera la visualización de los registros procesados
        /// en el Layout Bancario Banamex
        /// </summary>
        /// <param name="objTarjetasCheques">DataTable con Tarjetas y Cheques</param>
        /// <param name="objInterbancarios">DataTable con Interbancarios</param>
        private void VisualizarRelacionMovimientosBancariosLayout(DataTable objTarjetasCheques, DataTable objInterbancarios)
        {
            try
            {
                /*                frmxVisualizarRelacionMovimientos objVisualizarRelacionMovimientos = new frmxVisualizarRelacionMovimientos();
                                //asignar DataTable
                                objVisualizarRelacionMovimientos.dtMovsTarjetasCheques = objTarjetasCheques;
                                objVisualizarRelacionMovimientos.dtMovsInterbancarios = objInterbancarios;
                                objVisualizarRelacionMovimientos.ShowDialog();      //mostrar pantalla
                 */
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("¡Error al Visualizar la Relación de Movimientos \n {0}. Contacte a Sistemas!", ex.Message), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        tools.dsc dsc = new tools.dsc();

        public frmxImprimirRecibos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();        //cerrar pantalla
        }

        private void frmxImprimirRecibos_Load(object sender, EventArgs e)
        {
            try
            {
                //splashSMCargando.ShowWaitForm();
                this.vwCatTenedoraSA_AsimiladosTableAdapter.Fill(this.dbSAICBPODataSet.vwCatTenedoraSA_Asimilados);
                this.stpSelTipoPeriodoNominaTableAdapter.Fill(this.dbSAICBPODataSet.stpSelTipoPeriodoNomina);
                this.stpSelOperadorTableAdapter.Fill(this.dbSAICBPODataSet.stpSelOperador);
                this.vwCatClienteTableAdapter.Fill(this.dbSAICBPODataSet.vwCatCliente);
                this.vwCatTenedoraSCTableAdapter.Fill(this.dbSAICBPODataSet.vwCatTenedoraSC);
                //this.vwCatTenedoraSATableAdapter.Fill(this.dbSAICBPODataSet.vwCatTenedoraSA);
                this.vwCatBancoLayoutActivoTableAdapter.Fill(this.dbSAICBPODataSet.vwCatBancoLayoutActivo);
                this.leyendaDispersionTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.LeyendaDispersion);

                //asignar valores de radio boton
                rbTenedoraSA.Checked = true;
                rbTenedoraSC.Checked = false;
                cboIdBanco.SelectedIndex = -1;      //no mostrar ningun valor
                speNoSecuencia.Value = 0;       //inicializar No. Secuencia

                //asignar el IdOperador que ha ingresado al sistema
                //cboIdOperador.SelectedValue = OperadorBD.OperadorGlobal.IdOperador;

                //si el usuario pertenece al Area Operativa = OPERACIONES (2)
                if (OperadorBD.OperadorGlobal.IdAreaOperativa.Equals(2))
                {
                    //asignar el IdOperador que ha ingresado al sistema
                    cboIdOperador.EditValue = OperadorBD.OperadorGlobal.IdOperador;
                    cboIdOperador.Enabled = false;
                }
                else
                    cboIdOperador.Enabled = true;

                ActivarControlEmisora();        //activar o desactivar control txtEmisora para banorte
                MostrarLeyendaDispersion();     //visualizar u ocultar control cboLeyendaDispersion para HSBC
                //splashSMCargando.CloseWaitForm();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnMostrarLotes_Click(object sender, EventArgs e)
        {
            if (dtFechaFin.Value.Date < dtFechaInicio.Value.Date)
                XtraMessageBox.Show("La Fecha Final no puede ser menor a la Fecha Inicial", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MostrarLoteCargaNomina(-1, false);       //mostrar registros de Lotes de Carga Nomina
            txtLote.Text = "";
        }

        private void btnVisualizarReporte_Click(object sender, EventArgs e)
        {
            Int64 intIdLoteCargaNomina = 0;
            string strTipoNomina = "";

            //si existen Lotes de Carga de Nomina en el gridview
            if (gvLotesCargaNomina.RowCount > 0)
            {
                //si la nómina NO está en proceso de Cancelación => Generar Reporte
                if (Convert.ToInt16(gvLotesCargaNomina.Rows[gvLotesCargaNomina.SelectedCells[0].RowIndex].Cells[5].Value) == 0)
                {
                    //Obtener el Id del Lote de Carga Nomina
                    //para asignarlo a los recibos
                    intIdLoteCargaNomina = Convert.ToInt64(gvLotesCargaNomina.Rows[gvLotesCargaNomina.SelectedCells[0].RowIndex].Cells[0].Value);
                    strTipoNomina = gvLotesCargaNomina.Rows[gvLotesCargaNomina.SelectedCells[0].RowIndex].Cells[1].Value.ToString().Substring(2, 3);
                    if (intIdLoteCargaNomina > 0)       //si seleccionamos un Lote de Carga Nomina
                    {
                        //splashScreenManager1.ShowWaitForm();        //mostrar pantalla de espera
                        this.Cursor = Cursors.AppStarting;      //cambiar cursor del mouse

                        //si el radio boton Tenedora SA está seleccionado, entonces mostrar Recibos Sueldos
                        if (rbTenedoraSA.Checked)
                        {
                            if (!strTipoNomina.Equals("ASI"))
                                MostrarRecibosSueldos(intIdLoteCargaNomina);
                            else
                                MostrarRecibosAsimilados(intIdLoteCargaNomina);
                        }
                        else if (rbAcuseTenedoraSA.Checked)
                            //si el radio boton Acuse Tenedora SA está seleccionado, entonces mostrar Acuse Recibos Sueldos
                            MostrarAcuseRecibosNominaSueldosSA(intIdLoteCargaNomina);
                        else if (rbReporteNominaSA.Checked)
                            //si el radio boton Tenedora SA está seleccionado, entonces mostrar Reporte Nomina SA
                            MostrarReporteNominaSA(intIdLoteCargaNomina);
                        else if (rbRelacionChequesSA.Checked)
                            //si el radio boton Cheques Tenedora SA está seleccionado, entonces mostrar Acuse Cheques Sueldos
                            MostrarAcuseChequesNominaSueldosSA(intIdLoteCargaNomina);
                        else if (rbTenedoraSC.Checked)
                            //si el radio boton Tenedora SC está seleccionado, entonces mostrar Recibos Alimentos
                            MostrarRecibosAlimentos(intIdLoteCargaNomina);
                        else if (rbAcuseTenedoraSC.Checked)
                            //si el radio boton Acuse Tenedora SC está seleccionado, entonces mostrar Acuse Recibos Alimentos
                            MostrarAcuseRecibosNominaAlimentosSC(intIdLoteCargaNomina);
                        else if (rbReporteNominaSC.Checked)
                            //si el radio boton Acuse Tenedora SC está seleccionado, entonces mostrar Reporte Alimentos
                            MostrarReporteAlimentosSC(intIdLoteCargaNomina);
                        else if (rbRelacionChequesSC.Checked)
                            //si el radio boton Acuse Cheques Tenedora SC está seleccionado, entonces mostrar Acuse Cheques Alimentos
                            MostrarAcuseChequesNominaAlimentosSC(intIdLoteCargaNomina);

                        this.Cursor = Cursors.Default;      //cambiar cursor del mouse
                        //splashScreenManager1.CloseWaitForm();   //quitar pantalla de espera
                    }
                    else
                        XtraMessageBox.Show("Seleccione un Folio para obtener el reporte", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }       //verificar estatus Por Cancelar
                else
                    XtraMessageBox.Show("El Folio está en proceso de Cancelación, NO\n puede realizar impresión de documentos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                XtraMessageBox.Show("Seleccione un Folio para obtener el reporte.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnAutorizarNomina_Click(object sender, EventArgs e)
        {
            AutorizarLoteCargaNomina();     //autorizar el lote de carga seleccionado
        }

        private void cboIdBanco_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbTenedoraSA_CheckedChanged(object sender, EventArgs e)
        {
            CambiarEstatusComboboxes(true);     //habilita combobox TenedoraSA, bloquea combobox TenedoraSC
        }

        private void rbAcuseTenedoraSA_CheckedChanged(object sender, EventArgs e)
        {
            CambiarEstatusComboboxes(true);     //habilita combobox TenedoraSA, bloquea combobox TenedoraSC
        }

        private void rbReporteNominaSA_CheckedChanged(object sender, EventArgs e)
        {
            CambiarEstatusComboboxes(true);     //habilita combobox TenedoraSA, bloquea combobox TenedoraSC
        }

        private void rbTenedoraSC_CheckedChanged(object sender, EventArgs e)
        {
            CambiarEstatusComboboxes(false);    //bloquea combobox TenedoraSA, habilita combobox TenedoraSC
        }

        private void rbAcuseTenedoraSC_CheckedChanged(object sender, EventArgs e)
        {
            CambiarEstatusComboboxes(false);    //bloquea combobox TenedoraSA, habilita combobox TenedoraSC
        }

        private void rbReporteNominaSC_CheckedChanged(object sender, EventArgs e)
        {
            CambiarEstatusComboboxes(false);    //bloquea combobox TenedoraSA, habilita combobox TenedoraSC
        }

        private void rbRelacionChequesSA_CheckedChanged(object sender, EventArgs e)
        {
            CambiarEstatusComboboxes(true);     //habilita combobox TenedoraSA, bloquea combobox TenedoraSC
        }

        private void rbRelacionChequesSC_CheckedChanged(object sender, EventArgs e)
        {
            CambiarEstatusComboboxes(false);    //bloquea combobox TenedoraSA, habilita combobox TenedoraSC
        }

        private void btnSolicitarCancelacionNomina_Click(object sender, EventArgs e)
        {
            //SolicitudCancelacionNomina();       //Solicitar Cancelacion Nomina

            Int64 intIdLoteCargaNomina = 0;

            //si existen Lotes de Carga de Nomina en el gridview
            if (gvLotesCargaNomina.RowCount > 0)
            {
                //si la nómina NO está en proceso de Cancelación => No generar solicitud
                //if ((bool)gvLotesCargaNomina.Rows[gvLotesCargaNomina.SelectedCells[0].RowIndex].Cells[5].Value == false)
                if (Convert.ToInt16(gvLotesCargaNomina.Rows[gvLotesCargaNomina.SelectedCells[0].RowIndex].Cells[5].Value) == 0)
                {
                    //Obtener el Id del Lote de Carga Nomina
                    //para asignarlo a los recibos
                    intIdLoteCargaNomina = Convert.ToInt64(gvLotesCargaNomina.Rows[gvLotesCargaNomina.SelectedCells[0].RowIndex].Cells[0].Value);
                    if (intIdLoteCargaNomina > 0)       //si seleccionamos un Lote de Carga Nomina
                    {
                        //mostrar pantalla Solicitud Cancelacion Nomina y pasar el No. de Lote
                        Cancelaciones.frmxSolicitudCancelacionNomina objCancelacionNomina = new Cancelaciones.frmxSolicitudCancelacionNomina() { NoLoteCargaNomina = intIdLoteCargaNomina };
                        objCancelacionNomina.ShowDialog();  //mostrar pantalla

                        MostrarLoteCargaNomina(-1, false);       //mostrar registros de Lotes de Carga Nomina
                    }
                    else
                        XtraMessageBox.Show("Seleccione un Folio para obtener el reporte", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }       //verificar estatus Por Cancelar
                else
                    XtraMessageBox.Show("El Folio está en proceso de Cancelación, NO puede realizar la Solicitud.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                XtraMessageBox.Show("Seleccione un Folio para generar la Solicitud de Cancelación.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnLayoutBancario_Click(object sender, EventArgs e)
        {

        }

        private void gvLotesCargaNomina_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // si tiene estatus < Por Cancelar > entonces colorear renglon
            if (!(Convert.ToInt16(gvLotesCargaNomina.Rows[e.RowIndex].Cells[5].Value) == 0))
            {
                e.CellStyle.BackColor = Color.LightCoral;
            }
        }

        private void btnAutorizarNominaCFDI_Click(object sender, EventArgs e)
        {
            Int32 intError = 0;
            Int64 intIdLoteCargaNomina = 0;
            string strFolioLoteCargaNomina = "";
            byte pEstatusTimbradoCFDI = 0;

            //si existen Lotes de Carga de Nomina en el gridview
            if (gvLotesCargaNomina.RowCount > 0)
            {
                //Obtener el Id del Lote de Carga Nomina
                //para asignarlo a los recibos
                intIdLoteCargaNomina = Convert.ToInt64(gvLotesCargaNomina.Rows[gvLotesCargaNomina.SelectedCells[0].RowIndex].Cells[0].Value);
                strFolioLoteCargaNomina = gvLotesCargaNomina.Rows[gvLotesCargaNomina.SelectedCells[0].RowIndex].Cells[1].Value.ToString();

                //si la nómina NO está en proceso de Cancelación => Validar autorización Nómina para CFDI
                if (Convert.ToInt16(gvLotesCargaNomina.Rows[gvLotesCargaNomina.SelectedCells[0].RowIndex].Cells[5].Value) == 0)
                //if ((bool)gvLotesCargaNomina.Rows[gvLotesCargaNomina.SelectedCells[0].RowIndex].Cells[5].Value == false)
                {
                    try
                    {
                        //obtener el Estatus Autorizacion Timbrar CFDI del Lote actual
                        pEstatusTimbradoCFDI = ValidarEstatusNominaTimbradoCFDI(intIdLoteCargaNomina);
                        switch (pEstatusTimbradoCFDI)
                        {
                            case 0:     //No tiene asignado estatus
                                {
                                    if (XtraMessageBox.Show(String.Format("¿Está seguro que desea Autorizar el Folio {0} \npara Timbrar CFDI?", strFolioLoteCargaNomina), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                                    {
                                        //Actualizar Estatus Timbrado CFDI = 1
                                        intError = this.seguridadTableAdapter1.stpUpdEstatusTimbradoCFDI(intIdLoteCargaNomina, 1, OperadorBD.OperadorGlobal.NombreUsuario);

                                        //si hubo error en la actualizacion, entonces notificar al usuario
                                        if (intError != -1)
                                            XtraMessageBox.Show(String.Format("¡NO se logró autorizar el Folio {0} \npara Timbrar CFDI! Contacte a Sistemas", strFolioLoteCargaNomina), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        else
                                        {
                                            XtraMessageBox.Show(String.Format("¡El Folio {0} ya está Autorizado \npara Timbrar CFDI!", strFolioLoteCargaNomina), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            MostrarLoteCargaNomina(-1, false);       //mostrar registros de Lotes de Carga Nomina
                                        }
                                    } //if
                                    break;
                                }
                            case 1:
                                {
                                    XtraMessageBox.Show(String.Format("¡El Folio {0} ya está Autorizado \npara Timbrar CFDI!", strFolioLoteCargaNomina), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    break;
                                }
                            case 2:
                                {
                                    XtraMessageBox.Show(String.Format("¡El Folio {0} ya tiene Movimientos \npor Timbrar CFDI!", strFolioLoteCargaNomina), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    break;
                                }
                            case 3:
                                {
                                    XtraMessageBox.Show(String.Format("¡El Folio {0} ya procesó todos \nlos Recibos CFDI!", strFolioLoteCargaNomina), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    break;
                                }
                            default:
                                {
                                    XtraMessageBox.Show("¡No se puede validar el Estatus de Timbrado para la Nómina!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    break;
                                }
                        }  //switch
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    XtraMessageBox.Show(String.Format("¡El Folio {0} está en proceso de Cancelación, NO puede autorizar el Timbrado CFDI!", strFolioLoteCargaNomina), "Error en Autorización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                XtraMessageBox.Show("¡Seleccione un Folio para Autorizar el Timbrado CFDI!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void sbBuscarIdLoteCargaNomina_Click(object sender, EventArgs e)
        {
            MostrarLoteCargaNominaxLoteCargaNomina();       //mostrar registros de Lotes de Carga Nomina
        }

        private void MostrarLoteCargaNominaxLoteCargaNomina()
        {
            try
            {
                if (txtLote.Text != "")
                {
                    int iLote;
                    int.TryParse(txtLote.Text, out iLote);

                    if (iLote > 0)
                    {
                        //mostrar Lotes Carga Nomina en base a parametros
                        MostrarLoteCargaNomina(Convert.ToInt32(txtLote.Text), true);
                        txtLote.Text = "";
                    }
                    else
                    {
                        XtraMessageBox.Show(String.Format("Debe de Ingresar un Lote valido"), "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    XtraMessageBox.Show(String.Format("Debe de Ingresar un Lote valido"), "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                txtEmisora.Text = String.Empty;
                //asociamos nuevamente el gridview a los datos

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtIdLoteCargaNomina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    MostrarLoteCargaNominaxLoteCargaNomina();
                    return;
                }
                else
                {
                    MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Int64 intIdLoteCargaNomina = 0;
            intIdLoteCargaNomina = Convert.ToInt64(gvLotesCargaNomina.Rows[gvLotesCargaNomina.SelectedCells[0].RowIndex].Cells[0].Value);
            if (intIdLoteCargaNomina > 0)
            {
                NominaCFDI.frmxAsignarNomina2XMLCFDI objAsignarXML = new NominaCFDI.frmxAsignarNomina2XMLCFDI(false) { filtraIdLoteCargaNomina = UtileriasLocal.Constantes.FiltraPorIdLoteCargaNomina.Si, pIdLoteCargaNomina = intIdLoteCargaNomina /*pasar el No. version CFDI*/ };
                objAsignarXML.ShowDialog();     //mostrar pantalla 
            }
        }

        private void btnLayoutBancario_Click_1(object sender, EventArgs e)
        {
            Int64 intIdLoteCargaNomina = 0;
            string strFolioLoteCargaNomina = "";
            string strIdMoneda = "";
            Int32 intIdTenedora = 0;
            string strIdTipoMovimiento = "S";

            shNoSecuencialArchivo = Convert.ToInt16(speNoSecuencia.Value - 1);      //inicializar contador Secuencial Archivo Layout

            //si existen Lotes de Carga de Nomina en el gridview
            if (gvLotesCargaNomina.RowCount > 0)
            {
                //si la nómina NO está en proceso de Cancelación => Generar Reporte
                //if (bool)(gvLotesCargaNomina.Rows[gvLotesCargaNomina.SelectedCells[0].RowIndex].Cells[5].Value == false)
                if (Convert.ToInt16(gvLotesCargaNomina.Rows[gvLotesCargaNomina.SelectedCells[0].RowIndex].Cells[5].Value) == 0)
                {
                    AutorizarLoteCargaNomina();
                    //si está autorizada la nomina
                    //if ((bool)gvLotesCargaNomina.Rows[gvLotesCargaNomina.SelectedCells[0].RowIndex].Cells[4].Value == true)
                    //{
                    //Obtener el Id del Lote de Carga Nomina
                    //para asignarlo a los recibos
                    intIdLoteCargaNomina = Convert.ToInt64(gvLotesCargaNomina.Rows[gvLotesCargaNomina.SelectedCells[0].RowIndex].Cells[0].Value);
                    strFolioLoteCargaNomina = gvLotesCargaNomina.Rows[gvLotesCargaNomina.SelectedCells[0].RowIndex].Cells[1].Value.ToString();
                    strIdMoneda = gvLotesCargaNomina.Rows[gvLotesCargaNomina.SelectedCells[0].RowIndex].Cells[2].Value.ToString();

                    //validar selección de Banco
                    if (Convert.ToInt16(cboIdBanco.SelectedValue) > 0)
                    {
                        try
                        {
                            //si el combobox Tenedora SA está habilitado, entonces asignar valor
                            if (cboIdTenedoraSA.Enabled)
                            {
                                strIdTipoMovimiento = "S";      //Sueldos
                                intIdTenedora = Convert.ToInt32(cboIdTenedoraSA.EditValue);
                            }
                            else
                            {
                                strIdTipoMovimiento = "A";      //Alimentos
                                                                //si el combobox Tenedora SC está habilitado, entonces asignar valor
                                intIdTenedora = Convert.ToInt32(cboIdTenedoraSC.EditValue);
                            }

                            //Obtener registro de la Informacion Bancaria de la Tenedora seleccionada
                            this.stpSelInfoBancoCuentasLayoutTableAdapter.Fill(this.dbSAICBPOValidacionDataSet.stpSelInfoBancoCuentasLayout, intIdTenedora, cboIdBanco.Text);

                            //si existen registros
                            if (this.dbSAICBPOValidacionDataSet.stpSelInfoBancoCuentasLayout.Count > 0)
                            {
                                Int32 intNoRegistrosPagos = 0;
                                decimal decImportePagos = 0M;
                                Int32 intNoRegistros05 = 0;
                                Int32 intNoRegistros12 = 0;
                                Int32 intNoRegistros98 = 0;
                                Int32 intNoRegistros99 = 0;

                                //asignar el renglon a variable DataRow
                                DataRow row = this.dbSAICBPOValidacionDataSet.stpSelInfoBancoCuentasLayout.Rows[0];
                                //asignar la informacion bancaria en un objeto List<InfoBancariaTenedora>
                                List<InfoBancariaTenedora> objInfoBancariaList = InfoBancariaTenedoraBD.ObtenerInfoBancaria(row, cboFormatoBanco.Text);
                                //asignar valores de la Informacion Bancaria Tenedora
                                InfoBancariaTenedora objInfoBanco = objInfoBancariaList[0];

                                if (cboFormatoBanco.Text.Equals("TEF C-BILLETE"))
                                {
                                    //*** Tipo Movimiento 05 = Nomina ***
                                    //Obtener registros de la Informacion Bancaria de los Empleados. 
                                    this.stpSelLayoutBanamexTEFC05TableAdapter.Fill(this.dbSAICBPOReportesDataSet.stpSelLayoutBanamexTEFC05, strIdTipoMovimiento, "05", intIdLoteCargaNomina);
                                    //asignar el No. de registros procesados para Tipo de Nomina 05
                                    intNoRegistros05 = this.dbSAICBPOReportesDataSet.stpSelLayoutBanamexTEFC05.Count;
                                    if (this.dbSAICBPOReportesDataSet.stpSelLayoutBanamexTEFC05.Count > 0)
                                    {
                                        shNoSecuencialArchivo += 1;        //incrementar secuencia archivo
                                        List<BanamexDetalleTefC> objInfoBancariaEmpleadoList05 = BanamexDetalleTefCBD.ObtenerInformacionBancariaEmpleado(this.dbSAICBPOReportesDataSet.stpSelLayoutBanamexTEFC05);
                                        intNoRegistrosPagos = objInfoBancariaEmpleadoList05.Count;    //No. Registros de Empleados/Asociados 
                                        decImportePagos = BanamexDetalleTefCBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                                                  //Generar Layout Bancario Banamex TEF C
                                        GenerarLayoutBancarioBanamexTEFC(objInfoBanco, objInfoBancariaEmpleadoList05, intIdLoteCargaNomina.ToString(), "05", intNoRegistrosPagos, decImportePagos, shNoSecuencialArchivo, strIdTipoMovimiento);
                                    }

                                    //*** Tipo Movimiento 12 = Cheques/Interbancarios ***
                                    //Obtener registros de la Informacion Bancaria de los Empleados. 
                                    this.stpSelLayoutBanamexTEFC12TableAdapter.Fill(this.dbSAICBPOReportesDataSet.stpSelLayoutBanamexTEFC12, strIdTipoMovimiento, "12", intIdLoteCargaNomina);
                                    //asignar el No. de registros procesados para Tipo de Nomina 12
                                    intNoRegistros12 = this.dbSAICBPOReportesDataSet.stpSelLayoutBanamexTEFC12.Count;
                                    if (this.dbSAICBPOReportesDataSet.stpSelLayoutBanamexTEFC12.Count > 0)
                                    {
                                        shNoSecuencialArchivo += 1;        //incrementar secuencia archivo
                                        List<BanamexDetalleTefC> objInfoBancariaEmpleadoList12 = BanamexDetalleTefCBD.ObtenerInformacionBancariaEmpleado(this.dbSAICBPOReportesDataSet.stpSelLayoutBanamexTEFC12);
                                        intNoRegistrosPagos = objInfoBancariaEmpleadoList12.Count;    //No. Registros de Empleados/Asociados 
                                        decImportePagos = BanamexDetalleTefCBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                                                  //Generar Layout Bancario Banamex TEF C
                                        GenerarLayoutBancarioBanamexTEFC(objInfoBanco, objInfoBancariaEmpleadoList12, intIdLoteCargaNomina.ToString(), "12", intNoRegistrosPagos, decImportePagos, shNoSecuencialArchivo, strIdTipoMovimiento);
                                    }

                                    XtraMessageBox.Show(string.Format(@"Se han generado los Layout Bancarios correctamente. Busque los archivos en la carpeta C:\LAYOUTS." +
                                            "\n\n Registros procesados: \n\t Tipo Nómina 05(Tarjetas)= {0} \n\t Tipo Nómina 12(Cheques/Interbancarios)= {1}",
                                                        intNoRegistros05, intNoRegistros12), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }   //if TEF C-BILLETE
                                else if (cboFormatoBanco.Text.Equals("TEF D-TRADICIONAL"))
                                {
                                    //*** Tipo Movimiento 05 = Nomina ***
                                    //Obtener registros de la Informacion Bancaria de los Empleados. 
                                    this.stpSelLayoutBanamexTEFD05TableAdapter.Fill(this.dbSAICBPOReportesDataSet.stpSelLayoutBanamexTEFD05, strIdTipoMovimiento, "05", intIdLoteCargaNomina);
                                    //asignar el No. de registros procesados para Tipo de Nomina 05
                                    intNoRegistros05 = this.dbSAICBPOReportesDataSet.stpSelLayoutBanamexTEFD05.Count;
                                    if (this.dbSAICBPOReportesDataSet.stpSelLayoutBanamexTEFD05.Count > 0)
                                    {
                                        shNoSecuencialArchivo += 1;        //incrementar secuencia archivo
                                        List<BanamexDetalleTefD> objInfoBancariaEmpleadoList05 = BanamexDetalleTefDBD.ObtenerInformacionBancariaEmpleado(this.dbSAICBPOReportesDataSet.stpSelLayoutBanamexTEFD05);
                                        intNoRegistrosPagos = objInfoBancariaEmpleadoList05.Count;    //No. Registros de Empleados/Asociados 
                                        decImportePagos = BanamexDetalleTefDBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                                                  //Generar Layout Bancario Banamex TEF D
                                        GenerarLayoutBancarioBanamexTEFD(objInfoBanco, objInfoBancariaEmpleadoList05, intIdLoteCargaNomina.ToString(), "05", intNoRegistrosPagos, decImportePagos, shNoSecuencialArchivo, strIdTipoMovimiento);
                                    }

                                    //*** Tipo Movimiento 12 = Cheques/Interbancarios ***
                                    //Obtener registros de la Informacion Bancaria de los Empleados. 
                                    this.stpSelLayoutBanamexTEFD12TableAdapter.Fill(this.dbSAICBPOReportesDataSet.stpSelLayoutBanamexTEFD12, strIdTipoMovimiento, "12", intIdLoteCargaNomina);
                                    //asignar el No. de registros procesados para Tipo de Nomina 12
                                    intNoRegistros12 = this.dbSAICBPOReportesDataSet.stpSelLayoutBanamexTEFD12.Count;
                                    if (this.dbSAICBPOReportesDataSet.stpSelLayoutBanamexTEFD12.Count > 0)
                                    {
                                        shNoSecuencialArchivo += 1;        //incrementar secuencia archivo
                                        List<BanamexDetalleTefD> objInfoBancariaEmpleadoList12 = BanamexDetalleTefDBD.ObtenerInformacionBancariaEmpleado(this.dbSAICBPOReportesDataSet.stpSelLayoutBanamexTEFD12);
                                        intNoRegistrosPagos = objInfoBancariaEmpleadoList12.Count;    //No. Registros de Empleados/Asociados 
                                        decImportePagos = BanamexDetalleTefDBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                                                  //Generar Layout Bancario Banamex TEF D
                                        GenerarLayoutBancarioBanamexTEFD(objInfoBanco, objInfoBancariaEmpleadoList12, intIdLoteCargaNomina.ToString(), "12", intNoRegistrosPagos, decImportePagos, shNoSecuencialArchivo, strIdTipoMovimiento);
                                    }

                                    XtraMessageBox.Show(string.Format(@"Se han generado los Layout Bancarios correctamente. Busque los archivos en la carpeta C:\LAYOUTS." +
                                            "\n\n Registros procesados: \n\t Tipo Nómina 05(Tarjetas)= {0} \n\t Tipo Nómina 12(Cheques/Interbancarios)= {1}",
                                                        intNoRegistros05, intNoRegistros12), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }   //if TEF D-TRADICIONAL
                                else if (cboFormatoBanco.Text.Equals("BANCOMER-XLS"))
                                {
                                    //*** Tipo Movimiento 99 = Nomina ***
                                    //Obtener registros de la Informacion Bancaria de los Empleados. 
                                    this.stpSelLayoutBancomer99TableAdapter1.Fill(this.dbSAICBPOReportesDataSet.stpSelLayoutBancomer99, strIdTipoMovimiento, "99", intIdLoteCargaNomina);
                                    //asignar el No. de registros procesados para Tipo de Nomina 99
                                    intNoRegistros99 = this.dbSAICBPOReportesDataSet.stpSelLayoutBancomer99.Count;
                                    if (this.dbSAICBPOReportesDataSet.stpSelLayoutBancomer99.Count > 0)
                                    {
                                        List<Bancomer> objInfoBancariaEmpleadoList99 = BancomerDetalleBD.ObtenerInformacionBancariaEmpleado(this.dbSAICBPOReportesDataSet.stpSelLayoutBancomer99);
                                        intNoRegistrosPagos = objInfoBancariaEmpleadoList99.Count;    //No. Registros de Empleados/Asociados 
                                        decImportePagos = BancomerDetalleBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                                               //Generar Layout Bancario Bancomer 99-NOMINA
                                        GenerarLayoutBancarioBancomer(objInfoBanco, objInfoBancariaEmpleadoList99, intIdLoteCargaNomina.ToString(), "99", intNoRegistrosPagos, decImportePagos, shNoSecuencialArchivo, strIdTipoMovimiento);
                                    }

                                    //*** Tipo Movimiento 98 = TDP (Tarjeta de Pagos) ***
                                    //Obtener registros de la Informacion Bancaria de los Empleados. 
                                    this.stpSelLayoutBancomer98TableAdapter1.Fill(this.dbSAICBPOReportesDataSet.stpSelLayoutBancomer98, strIdTipoMovimiento, "98", intIdLoteCargaNomina);
                                    //asignar el No. de registros procesados para Tipo de Nomina 98-TDP
                                    intNoRegistros98 = this.dbSAICBPOReportesDataSet.stpSelLayoutBancomer98.Count;
                                    if (this.dbSAICBPOReportesDataSet.stpSelLayoutBancomer98.Count > 0)
                                    {
                                        List<Bancomer> objInfoBancariaEmpleadoList98 = BancomerDetalleBD.ObtenerInformacionBancariaEmpleado(this.dbSAICBPOReportesDataSet.stpSelLayoutBancomer98);
                                        intNoRegistrosPagos = objInfoBancariaEmpleadoList98.Count;    //No. Registros de Empleados/Asociados 
                                        decImportePagos = BanamexDetalleTefDBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                                                  //Generar Layout Bancario Bancomer 98-TDP
                                        GenerarLayoutBancarioBancomer(objInfoBanco, objInfoBancariaEmpleadoList98, intIdLoteCargaNomina.ToString(), "98", intNoRegistrosPagos, decImportePagos, shNoSecuencialArchivo, strIdTipoMovimiento);
                                    }

                                    XtraMessageBox.Show(string.Format(@"Se han generado los Layout Bancarios correctamente. Busque los archivos en la carpeta C:\LAYOUTS." +
                                            "\n\n Registros procesados: \n\t Tipo Nómina 99(Cuentas)= {0} \n\t Tipo Nómina 98(TDP)= {1}",
                                                        intNoRegistros99, intNoRegistros98), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                } //if BANCOMER-XLS
                                else if (cboFormatoBanco.Text.Equals("BANORTE-BANORTE PAG"))
                                {
                                    int intNoEmisora = 0;
                                    bool bEsNumerico = int.TryParse(txtEmisora.Text, out intNoEmisora);

                                    if ((txtEmisora.Text.Length == 5) && (intNoEmisora > 0))        //que tenga valor y sea > 0
                                    {
                                        if (shNoSecuencialArchivo == -1)     //si es -1 entonces incrementar en 2 para convertir a 1
                                            shNoSecuencialArchivo += 2;
                                        else
                                            shNoSecuencialArchivo += 1;        //incrementar secuencia archivo

                                        //Obtener registros de la Informacion Bancaria de los Empleados. 
                                        this.stpSelLayoutBanorteTableAdapter1.Fill(this.dbSAICBPOReportesDataSet.stpSelLayoutBanorte, strIdTipoMovimiento, intIdLoteCargaNomina);
                                        //asignar el No. de registros procesados
                                        intNoRegistrosPagos = this.dbSAICBPOReportesDataSet.stpSelLayoutBanorte.Count;
                                        if (this.dbSAICBPOReportesDataSet.stpSelLayoutBanorte.Count > 0)
                                        {
                                            //generar fecha aplicacion pago
                                            string strFechaAplicacion = dtFechaPago.Value.Year.ToString() + dtFechaPago.Value.Month.ToString().PadLeft(2, '0') + dtFechaPago.Value.Day.ToString().PadLeft(2, '0');

                                            List<BanorteDetalle> objInfoBancariaEmpleadoList = BanorteDetalleBD.ObtenerInformacionBancariaEmpleado(this.dbSAICBPOReportesDataSet.stpSelLayoutBanorte, strFechaAplicacion);
                                            intNoRegistrosPagos = objInfoBancariaEmpleadoList.Count;    //No. Registros de Empleados/Asociados 
                                            decImportePagos = BanorteDetalleBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                                                  //Generar Layout Bancario Banorte
                                            GenerarLayoutBancarioBanorte(objInfoBanco, objInfoBancariaEmpleadoList, intIdLoteCargaNomina.ToString(), intNoRegistrosPagos, decImportePagos, strIdTipoMovimiento, strFechaAplicacion, txtEmisora.Text, shNoSecuencialArchivo);
                                        }

                                        XtraMessageBox.Show(string.Format(@"Se han generado los Layout Bancarios correctamente. Busque los archivos en la carpeta C:\LAYOUTS." +
                                                "\n\n Registros procesados: {0}", intNoRegistrosPagos), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        XtraMessageBox.Show(string.Format(@"¡Debe escribir el No. de Emisora para generar el Layout BANORTE!"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtEmisora.Focus();     //colocar cursor en Emisora
                                    }
                                } //if BANORTE-BANORTE PAG
                                else if (cboFormatoBanco.Text.Equals("BANORTE-INTERBANCARIOS PAG"))
                                {
                                    int intNoEmisora = 0;
                                    bool bEsNumerico = int.TryParse(txtEmisora.Text, out intNoEmisora);

                                    if ((txtEmisora.Text.Length == 5) && (intNoEmisora > 0))        //que tenga valor y sea > 0
                                    {
                                        if (shNoSecuencialArchivo == -1)     //si es -1 entonces incrementar en 2 para convertir a 1
                                            shNoSecuencialArchivo += 2;
                                        else
                                            shNoSecuencialArchivo += 1;        //incrementar secuencia archivo

                                        //Obtener registros de la Informacion Bancaria de los Empleados. 
                                        this.stpSelLayoutBanorteInterbancarioTableAdapter1.Fill(this.dbSAICBPOReportesDataSet.stpSelLayoutBanorteInterbancario, strIdTipoMovimiento, intIdLoteCargaNomina);
                                        //asignar el No. de registros procesados
                                        intNoRegistrosPagos = this.dbSAICBPOReportesDataSet.stpSelLayoutBanorteInterbancario.Count;
                                        if (this.dbSAICBPOReportesDataSet.stpSelLayoutBanorteInterbancario.Count > 0)
                                        {
                                            //generar fecha aplicacion pago
                                            string strFechaAplicacion = dtFechaPago.Value.Year.ToString() + dtFechaPago.Value.Month.ToString().PadLeft(2, '0') + dtFechaPago.Value.Day.ToString().PadLeft(2, '0');

                                            List<BanorteDetalle> objInfoBancariaEmpleadoList = BanorteDetalleBD.ObtenerInformacionBancariaEmpleado(this.dbSAICBPOReportesDataSet.stpSelLayoutBanorteInterbancario, strFechaAplicacion);
                                            intNoRegistrosPagos = objInfoBancariaEmpleadoList.Count;    //No. Registros de Empleados/Asociados 
                                            decImportePagos = BanorteDetalleBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                                                  //Generar Layout Bancario Banorte
                                            GenerarLayoutBancarioBanorte(objInfoBanco, objInfoBancariaEmpleadoList, intIdLoteCargaNomina.ToString(), intNoRegistrosPagos, decImportePagos, strIdTipoMovimiento, strFechaAplicacion, txtEmisora.Text, shNoSecuencialArchivo);
                                        }

                                        XtraMessageBox.Show(string.Format(@"Se han generado los Layout Bancarios correctamente. Busque los archivos en la carpeta C:\LAYOUTS." +
                                                "\n\n Registros procesados: {0}", intNoRegistrosPagos), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        XtraMessageBox.Show(string.Format(@"¡Debe escribir el No. de Emisora para generar el Layout BANORTE!"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtEmisora.Focus();     //colocar cursor en Emisora
                                    }
                                } //if BANORTE-INTERBANCARIOS PAG
                                else if (cboFormatoBanco.Text.Equals("SANTANDER-NOMINAS PAG"))
                                {
                                    shNoSecuencialArchivo += 1;        //incrementar secuencia archivo
                                                                       //Obtener registros de la Informacion Bancaria de los Empleados. 
                                    this.stpSelLayoutSantanderTableAdapter1.Fill(this.dbSAICBPOReportesDataSet.stpSelLayoutSantander, strIdTipoMovimiento, intIdLoteCargaNomina);
                                    //asignar el No. de registros procesados
                                    intNoRegistrosPagos = this.dbSAICBPOReportesDataSet.stpSelLayoutSantander.Count;
                                    if (this.dbSAICBPOReportesDataSet.stpSelLayoutSantander.Count > 0)
                                    {
                                        //generar fecha aplicacion pago
                                        string strFechaAplicacion = dtFechaPago.Value.Month.ToString().PadLeft(2, '0') + dtFechaPago.Value.Day.ToString().PadLeft(2, '0') + dtFechaPago.Value.Year.ToString();

                                        List<SantanderDetalle> objInfoBancariaEmpleadoList = SantanderDetalleBD.ObtenerInformacionBancariaNominasEmpleado(this.dbSAICBPOReportesDataSet.stpSelLayoutSantander);
                                        intNoRegistrosPagos = objInfoBancariaEmpleadoList.Count;    //No. Registros de Empleados/Asociados 
                                        decImportePagos = SantanderDetalleBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                                                //Generar Layout Bancario Santander
                                        GenerarLayoutBancarioSantander(objInfoBanco, objInfoBancariaEmpleadoList, intIdLoteCargaNomina.ToString(), intNoRegistrosPagos, decImportePagos, strIdTipoMovimiento, strFechaAplicacion, shNoSecuencialArchivo);
                                    }

                                    XtraMessageBox.Show(string.Format(@"Se han generado los Layout Bancarios correctamente. Busque los archivos en la carpeta C:\LAYOUTS." +
                                            "\n\n Registros procesados: {0}", intNoRegistrosPagos), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                } //if SANTANDER-NOMINAS PAG                                                               
                                else if (cboFormatoBanco.Text.Equals("CI BANCO-XLS"))
                                {
                                    //Obtener registros de la Informacion Bancaria de los Empleados. 
                                    this.stpSelLayoutCIBancoTableAdapter1.Fill(this.dbSAICBPOReportesDataSet.stpSelLayoutCIBanco, strIdTipoMovimiento, intIdLoteCargaNomina);
                                    //asignar el No. de registros procesados
                                    //intNoRegistrosPagos = this.dbSAICBPOReportesDataSet.stpSelLayoutCIBanco.Count;
                                    if (this.dbSAICBPOReportesDataSet.stpSelLayoutCIBanco.Count > 0)
                                    {
                                        List<CIBanco> objInfoBancariaEmpleadoList = CIBancoDetalleBD.ObtenerInformacionBancariaEmpleado(this.dbSAICBPOReportesDataSet.stpSelLayoutCIBanco);
                                        intNoRegistrosPagos = objInfoBancariaEmpleadoList.Count;    //No. Registros de Empleados/Asociados 
                                        decImportePagos = CIBancoDetalleBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                                              //Generar Layout CI Banco
                                        GenerarLayoutBancarioCIBanco(objInfoBanco, objInfoBancariaEmpleadoList, intNoRegistrosPagos, decImportePagos, txtEmisora.Text);
                                    }

                                    XtraMessageBox.Show(string.Format(@"Se ha generado el Layout Bancario correctamente. Busque los archivos en la carpeta C:\LAYOUTS." +
                                            "\n\n Registros procesados = {0}",
                                                        intNoRegistrosPagos), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                } //if CI BANCO-XLS
                                else if (cboFormatoBanco.Text.Equals("HSBC-OTRAS CUENTAS HSBC"))
                                {
                                    //validar leyenda dispersion
                                    if (cboLeyendaDispersion.Text.Length > 0)
                                    {
                                        //Obtener registros de la Informacion Bancaria de los Empleados. 
                                        this.stpSelLayoutHSBCOtrasCuentasTableAdapter1.Fill(this.dbSAICBPOReportesDataSet.stpSelLayoutHSBCOtrasCuentas, strIdTipoMovimiento, intIdLoteCargaNomina, cboLeyendaDispersion.Text);
                                        //asignar el No. de registros procesados
                                        if (this.dbSAICBPOReportesDataSet.stpSelLayoutHSBCOtrasCuentas.Count > 0)
                                        {
                                            List<HSBCOtrasCuentas> objInfoBancariaEmpleadoList = HSBCBD.ObtenerInformacionBancariaEmpleadoOtrasCuentas(this.dbSAICBPOReportesDataSet.stpSelLayoutHSBCOtrasCuentas);
                                            intNoRegistrosPagos = objInfoBancariaEmpleadoList.Count;    //No. Registros de Empleados/Asociados 
                                            decImportePagos = HSBCBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                                        //Generar Layout HSBC
                                            GenerarLayoutBancarioHSBCOtrasCuentas(objInfoBanco, objInfoBancariaEmpleadoList, intIdLoteCargaNomina.ToString(), intNoRegistrosPagos, decImportePagos, speNoSecuencia.Text, cboLeyendaDispersion.Text);
                                        }

                                        XtraMessageBox.Show(string.Format(@"Se ha generado el Layout Bancario correctamente. Busque los archivos en la carpeta C:\LAYOUTS." +
                                                "\n\n Registros procesados = {0}",
                                                            intNoRegistrosPagos), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        XtraMessageBox.Show("¡Para generar el Layout Bancario HSBC debe \n seleccionar la Leyenda de Dispersión!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        cboLeyendaDispersion.Focus();       //colocar curso en control
                                    }
                                } //if HSBC-OTRAS CUENTAS HSBC
                                else if (cboFormatoBanco.Text.Equals("HSBC-INTERBANCARIO SPEI"))
                                {
                                    //validar leyenda dispersion
                                    if (cboLeyendaDispersion.Text.Length > 0)
                                    {
                                        //Obtener registros de la Informacion Bancaria de los Empleados. 
                                        this.stpSelLayoutHSBCSPEITableAdapter1.Fill(this.dbSAICBPOReportesDataSet.stpSelLayoutHSBCSPEI, strIdTipoMovimiento, intIdLoteCargaNomina, cboLeyendaDispersion.Text);
                                        //asignar el No. de registros procesados
                                        if (this.dbSAICBPOReportesDataSet.stpSelLayoutHSBCSPEI.Count > 0)
                                        {
                                            List<HSBCSPEI> objInfoBancariaEmpleadoList = HSBCBD.ObtenerInformacionBancariaEmpleadoSPEI(this.dbSAICBPOReportesDataSet.stpSelLayoutHSBCSPEI);
                                            intNoRegistrosPagos = objInfoBancariaEmpleadoList.Count;    //No. Registros de Empleados/Asociados 
                                            decImportePagos = HSBCBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                                        //Generar Layout HSBC
                                            GenerarLayoutBancarioHSBCSPEI(objInfoBanco, objInfoBancariaEmpleadoList, strIdTipoMovimiento, intIdLoteCargaNomina.ToString());
                                        }

                                        XtraMessageBox.Show(string.Format(@"Se ha generado el Layout Bancario correctamente. Busque los archivos en la carpeta C:\LAYOUTS." +
                                                "\n\n Registros procesados = {0}",
                                                            intNoRegistrosPagos), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        XtraMessageBox.Show("¡Para generar el Layout Bancario HSBC debe \n seleccionar la Leyenda de Dispersión!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        cboLeyendaDispersion.Focus();       //colocar curso en control
                                    }
                                } //if HSBC-INTERBANCARIO SPEI
                                else if (cboFormatoBanco.Text.Equals("HSBC-NOMINAS"))
                                {
                                    //validar leyenda dispersion
                                    if (cboLeyendaDispersion.Text.Length > 0)
                                    {
                                        //Obtener registros de la Informacion Bancaria de los Empleados. 
                                        this.stpSelLayoutHSBCNominasTableAdapter1.Fill(this.dbSAICBPOReportesDataSet.stpSelLayoutHSBCNominas, intIdLoteCargaNomina, cboLeyendaDispersion.Text);
                                        //asignar el No. de registros procesados
                                        if (this.dbSAICBPOReportesDataSet.stpSelLayoutHSBCNominas.Count > 0)
                                        {
                                            List<HSBCNominas> objInfoBancariaEmpleadoList = HSBCBD.ObtenerInformacionBancariaEmpleadoNominas(this.dbSAICBPOReportesDataSet.stpSelLayoutHSBCNominas);
                                            intNoRegistrosPagos = objInfoBancariaEmpleadoList.Count;    //No. Registros de Empleados/Asociados 
                                            decImportePagos = HSBCBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                                        //Generar Layout HSBC
                                            GenerarLayoutBancarioHSBCNominas(objInfoBanco, objInfoBancariaEmpleadoList, strIdTipoMovimiento, intIdLoteCargaNomina.ToString());
                                        }

                                        XtraMessageBox.Show(string.Format(@"Se ha generado el Layout Bancario correctamente. Busque los archivos en la carpeta C:\LAYOUTS." +
                                                "\n\n Registros procesados = {0}",
                                                            intNoRegistrosPagos), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        XtraMessageBox.Show("¡Para generar el Layout Bancario HSBC debe \n seleccionar la Leyenda de Dispersión!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        cboLeyendaDispersion.Focus();       //colocar curso en control
                                    }
                                } //if HSBC-NOMINAS
                                else if (cboFormatoBanco.Text.Equals("HSBCNET-NOMINAS"))
                                {
                                    //validar leyenda dispersion
                                    if (cboLeyendaDispersion.Text.Length > 0)
                                    {
                                        //Obtener registros de la Informacion Bancaria de los Empleados. 
                                        this.stpSelLayoutHSBCNETNominasTableAdapter1.Fill(this.dbSAICBPOReportesDataSet.stpSelLayoutHSBCNETNominas, strIdTipoMovimiento, intIdLoteCargaNomina, cboLeyendaDispersion.Text);
                                        //asignar el No. de registros procesados
                                        if (this.dbSAICBPOReportesDataSet.stpSelLayoutHSBCNETNominas.Count > 0)
                                        {
                                            //generar fecha aplicacion pago
                                            string strFechaAplicacion = dtFechaPago.Value.Day.ToString().PadLeft(2, '0') + dtFechaPago.Value.Month.ToString().PadLeft(2, '0') + dtFechaPago.Value.Year.ToString();

                                            List<HSBCNominas> objInfoBancariaEmpleadoList = HSBCBD.ObtenerInformacionBancariaEmpleadoNominas(this.dbSAICBPOReportesDataSet.stpSelLayoutHSBCNETNominas);
                                            intNoRegistrosPagos = objInfoBancariaEmpleadoList.Count;    //No. Registros de Empleados/Asociados 
                                            decImportePagos = HSBCBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                                        //Generar Layout HSBC
                                            GenerarLayoutBancarioHSBCNETNominas(objInfoBanco, objInfoBancariaEmpleadoList, intIdLoteCargaNomina.ToString(), intNoRegistrosPagos, decImportePagos, strFechaAplicacion, cboLeyendaDispersion.Text, strIdTipoMovimiento);
                                        }

                                        XtraMessageBox.Show(string.Format(@"Se ha generado el Layout Bancario correctamente. Busque los archivos en la carpeta C:\LAYOUTS." +
                                                "\n\n Registros procesados = {0}",
                                                            intNoRegistrosPagos), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        XtraMessageBox.Show("¡Para generar el Layout Bancario HSBC debe \n seleccionar la Leyenda de Dispersión!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        cboLeyendaDispersion.Focus();       //colocar curso en control
                                    }
                                }  //HSBCNET-NOMINAS
                                else if (cboFormatoBanco.Text.Equals("INBURSA-INTERBANCARIO SPEI"))
                                {
                                    //Obtener registros de la Informacion Bancaria de los Empleados. 
                                    this.stpSelLayoutInbursaSPEITableAdapter1.Fill(this.dbSAICBPOReportesDataSet.stpSelLayoutInbursaSPEI, intIdLoteCargaNomina, strIdTipoMovimiento);
                                    //asignar el No. de registros procesados
                                    if (this.dbSAICBPOReportesDataSet.stpSelLayoutInbursaSPEI.Count > 0)
                                    {
                                        //generar fecha aplicacion pago
                                        string strFechaAplicacion = dtFechaPago.Value.Year.ToString() + dtFechaPago.Value.Month.ToString().PadLeft(2, '0') + dtFechaPago.Value.Day.ToString().PadLeft(2, '0');

                                        List<InbursaSPEI> objInfoBancariaEmpleadoList = InbursaBD.ObtenerInformacionBancariaEmpleadoSPEI(this.dbSAICBPOReportesDataSet.stpSelLayoutInbursaSPEI);
                                        intNoRegistrosPagos = objInfoBancariaEmpleadoList.Count;    //No. Registros de Empleados/Asociados 
                                        decImportePagos = InbursaBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                                       //Generar Layout Inbursa SPEI
                                        GenerarLayoutBancarioInbursaSPEI(objInfoBanco, objInfoBancariaEmpleadoList, strIdTipoMovimiento, intIdLoteCargaNomina.ToString(), intNoRegistrosPagos, decImportePagos, strFechaAplicacion);
                                    }

                                    XtraMessageBox.Show(string.Format(@"Se ha generado el Layout Bancario correctamente. Busque los archivos en la carpeta C:\LAYOUTS." +
                                            "\n\n Registros procesados = {0}",
                                                        intNoRegistrosPagos), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }  //INBURSA-INTERBANCARIO SPEI
                                else if (cboFormatoBanco.Text.Equals("BANORTE-BANORTE PROV"))
                                {
                                    if (shNoSecuencialArchivo == -1)     //si es -1 entonces incrementar en 2 para convertir a 1
                                        shNoSecuencialArchivo += 2;
                                    else
                                        shNoSecuencialArchivo += 1;        //incrementar secuencia archivo

                                    //Obtener registros de la Informacion Bancaria de los Empleados. 
                                    this.stpSelLayoutBanorte2016TableAdapter1.Fill(this.dbSAICBPOReportesDataSet.stpSelLayoutBanorte2016, strIdTipoMovimiento, intIdLoteCargaNomina);
                                    //asignar el No. de registros procesados
                                    intNoRegistrosPagos = this.dbSAICBPOReportesDataSet.stpSelLayoutBanorte2016.Count;
                                    if (this.dbSAICBPOReportesDataSet.stpSelLayoutBanorte2016.Count > 0)
                                    {
                                        //generar fecha aplicacion pago
                                        string strFechaAplicacion = dtFechaPago.Value.Day.ToString().PadLeft(2, '0') + dtFechaPago.Value.Month.ToString().PadLeft(2, '0') + dtFechaPago.Value.Year.ToString();

                                        List<Banorte2016> objInfoBancariaEmpleadoList = BanorteDetalleBD.ObtenerInformacionBancariaEmpleado2016(this.dbSAICBPOReportesDataSet.stpSelLayoutBanorte2016, strFechaAplicacion);
                                        //Generar Layout Bancario Banorte
                                        GenerarLayoutBancarioBanorte2016(objInfoBanco, objInfoBancariaEmpleadoList, intIdLoteCargaNomina.ToString(), strIdTipoMovimiento, strFechaAplicacion, txtEmisora.Text, shNoSecuencialArchivo, "BAN2BAN");
                                    }

                                    XtraMessageBox.Show(string.Format(@"Se han generado los Layout Bancarios correctamente. Busque los archivos en la carpeta C:\LAYOUTS." +
                                            "\n\n Registros procesados: {0}", intNoRegistrosPagos), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                } //BANORTE-BANORTE PROVEEDOR
                                else if (cboFormatoBanco.Text.Equals("BANORTE-INTERBANCARIOS PROV"))
                                {
                                    if (shNoSecuencialArchivo == -1)     //si es -1 entonces incrementar en 2 para convertir a 1
                                        shNoSecuencialArchivo += 2;
                                    else
                                        shNoSecuencialArchivo += 1;        //incrementar secuencia archivo

                                    //Obtener registros de la Informacion Bancaria de los Empleados. 
                                    this.stpSelLayoutBanorteInterbancario2016TableAdapter1.Fill(this.dbSAICBPOReportesDataSet.stpSelLayoutBanorteInterbancario2016, strIdTipoMovimiento, intIdLoteCargaNomina);
                                    //asignar el No. de registros procesados
                                    intNoRegistrosPagos = this.dbSAICBPOReportesDataSet.stpSelLayoutBanorteInterbancario2016.Count;
                                    if (this.dbSAICBPOReportesDataSet.stpSelLayoutBanorteInterbancario2016.Count > 0)
                                    {
                                        //generar fecha aplicacion pago
                                        string strFechaAplicacion = dtFechaPago.Value.Day.ToString().PadLeft(2, '0') + dtFechaPago.Value.Month.ToString().PadLeft(2, '0') + dtFechaPago.Value.Year.ToString();

                                        List<Banorte2016> objInfoBancariaEmpleadoList = BanorteDetalleBD.ObtenerInformacionBancariaEmpleado2016(this.dbSAICBPOReportesDataSet.stpSelLayoutBanorteInterbancario2016, strFechaAplicacion);
                                        //Generar Layout Bancario Banorte
                                        GenerarLayoutBancarioBanorte2016(objInfoBanco, objInfoBancariaEmpleadoList, intIdLoteCargaNomina.ToString(), strIdTipoMovimiento, strFechaAplicacion, txtEmisora.Text, shNoSecuencialArchivo, "BAN2INT");
                                    }

                                    XtraMessageBox.Show(string.Format(@"Se han generado los Layout Bancarios correctamente. Busque los archivos en la carpeta C:\LAYOUTS." +
                                            "\n\n Registros procesados: {0}", intNoRegistrosPagos), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                } //BANORTE-INTERBANCARIOS PROVEEDOR

                                else if (cboFormatoBanco.Text.Equals("SANTANDER-SANTANDER PROV"))
                                {
                                    int idLote;

                                    int.TryParse(intIdLoteCargaNomina.ToString(), out idLote);

                                    if (idLote > 0)
                                    {
                                        try { stpSelLayOutBancariosTableAdapter1.Fill(dbSAICBPOReportesDataSet.stpSelLayOutBancarios, cboFormatoBanco.Text, idLote); } catch (Exception) { }
                                        if (dbSAICBPOReportesDataSet.stpSelLayOutBancarios.Rows.Count > 0)
                                        {
                                            //Obteniendo el nombre del archivo a Crear
                                            String stNombreArchivos = dbSAICBPOReportesDataSet.stpSelLayOutBancarios.Rows[0]["NombreArchivo"].ToString();
                                            stNombreArchivos = stNombreArchivos == String.Empty ? cboFormatoBanco.Text + ".txt" : stNombreArchivos;

                                            //Obteniendo el formato de la fecha
                                            String stFormatoFecha = dbSAICBPOReportesDataSet.stpSelLayOutBancarios.Rows[0]["FechaPagoFormato"].ToString();

                                            intNoRegistrosPagos = GenerarLayoutBancarioSantander_1(dbSAICBPOReportesDataSet.stpSelLayOutBancarios, stNombreArchivos, stFormatoFecha);
                                        }
                                    }

                                    XtraMessageBox.Show(string.Format(@"Se han generado los Layout Bancarios correctamente. Busque los archivos en la carpeta C:\LAYOUTS." +
                                       "\n\n Registros procesados: {0}", intNoRegistrosPagos), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                else if (cboFormatoBanco.Text.Equals("SANTANDER-INTERBANCARIOS PROV"))
                                {
                                    int idLote;
                                    int.TryParse(intIdLoteCargaNomina.ToString(), out idLote);

                                    if (idLote > 0)
                                    {
                                        try { stpSelLayOutBancariosTableAdapter1.Fill(dbSAICBPOReportesDataSet.stpSelLayOutBancarios, cboFormatoBanco.Text, idLote); } catch (Exception) { }
                                        if (dbSAICBPOReportesDataSet.stpSelLayOutBancarios.Rows.Count > 0)
                                        {
                                            String stNombreArchivos = dbSAICBPOReportesDataSet.stpSelLayOutBancarios.Rows[0]["NombreArchivo"].ToString();
                                            stNombreArchivos = stNombreArchivos == String.Empty ? cboFormatoBanco.Text + ".txt" : stNombreArchivos;

                                            String stFormatoFecha = dbSAICBPOReportesDataSet.stpSelLayOutBancarios.Rows[0]["FechaPagoFormato"].ToString();

                                            intNoRegistrosPagos = GenerarLayoutBancarioSantander_1(dbSAICBPOReportesDataSet.stpSelLayOutBancarios, stNombreArchivos, stFormatoFecha);
                                        }
                                    }

                                    XtraMessageBox.Show(string.Format(@"Se han generado los Layout Bancarios correctamente. Busque los archivos en la carpeta C:\LAYOUTS." +
                                       "\n\n Registros procesados: {0}", intNoRegistrosPagos), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else//Todos los demas layOuts
                                {
                                    int idLote;
                                    int.TryParse(intIdLoteCargaNomina.ToString(), out idLote);

                                    if (idLote > 0)
                                    {
                                        Boolean flagEstaMuyBien = true;

                                        if (cboFormatoBanco.Text.Contains("SCOTIABANK PAG"))
                                        {
                                            int intNoEmisora = 0;
                                            bool bEsNumerico = int.TryParse(txtEmisora.Text, out intNoEmisora);

                                            if ((txtEmisora.Text.Length != 5) || (intNoEmisora == 0))
                                            {
                                                XtraMessageBox.Show(string.Format(@"¡Debe escribir el No. de Emisora para generar el Layout SCOTIABANK!"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                txtEmisora.Focus();     //colocar cursor en Emisora
                                                flagEstaMuyBien = false;
                                            }
                                        }

                                        if (flagEstaMuyBien)
                                        {
                                            try { stpSelLayOutBancariosTableAdapter1.Fill(dbSAICBPOReportesDataSet.stpSelLayOutBancarios, cboFormatoBanco.Text, idLote); } catch (Exception ex) { }
                                            if (dbSAICBPOReportesDataSet.stpSelLayOutBancarios.Rows.Count > 0)
                                            {
                                                String stNombreArchivos = dbSAICBPOReportesDataSet.stpSelLayOutBancarios.Rows[0]["NombreArchivo"].ToString();
                                                stNombreArchivos = stNombreArchivos == String.Empty ? cboFormatoBanco.Text + ".txt" : stNombreArchivos;

                                                String stFormatoFecha = dbSAICBPOReportesDataSet.stpSelLayOutBancarios.Rows[0]["FechaPagoFormato"].ToString();

                                                intNoRegistrosPagos = GenerarLayoutBancarioSantander_1(dbSAICBPOReportesDataSet.stpSelLayOutBancarios, stNombreArchivos, stFormatoFecha);
                                            }
                                        }
                                    }

                                    XtraMessageBox.Show(string.Format(@"Se han generado los Layout Bancarios correctamente. Busque los archivos en la carpeta C:\LAYOUTS." +
                                       "\n\n Registros procesados: {0}", intNoRegistrosPagos), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                speNoSecuencia.Value = shNoSecuencialArchivo + 1;       //reasignar nuevo valor al NoSecuencial
                            }   //this.dbSAICBPOValidacionDataSet.stpSelInfoBancoCuentasLayout.Count 
                            else
                                XtraMessageBox.Show("¡La Tenedora seleccionada no tiene asociada \n Información Bancaria para realizar el Layout. \n Contacte a Aplicaciones de Negocio y Tesorería!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        } //try
                        catch (SqlException ex)
                        {
                            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }   //if (Convert.ToInt16(cboIdBanco.SelectedValue) > 0)
                    else
                        XtraMessageBox.Show("¡Para generar un Layout Bancario debe \n seleccionar Banco y Tipo de Formato!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //}
                    //else
                    //    XtraMessageBox.Show("¡Para generar un Layout Bancario debe Autorizar la Nómina!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    XtraMessageBox.Show("El Folio está en proceso de Cancelación, NO\n puede realizar Layout Bancarios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } //if gvLotesCargaNomina.RowCount>0
            else
                XtraMessageBox.Show("Seleccione un Folio para generar Layout Bancario.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void cboIdBanco_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //obtener los formatos del banco seleccionado previamente
            this.stpSelFormatoLayoutBancoPorIdBancoTableAdapter.Fill(dbSAICBPODataSet.stpSelFormatoLayoutBancoPorIdBanco, Convert.ToByte(cboIdBanco.SelectedValue));

            ActivarControlEmisora();        //activar o desactivar control txtEmisora para banorte
            MostrarLeyendaDispersion();     //visualizar u ocultar control cboLeyendaDispersion para HSBC

            //Obtener Emisora de BAnorte
            if (cboIdBanco.Text.Contains("BANORTE") || cboIdBanco.Text.Contains("SCOTIABANK"))
            {
                try
                {
                    int idTendora;
                    int.TryParse(dbSAICBPODataSet.stpSelLoteCargaNomina.Rows[0].ItemArray[2].ToString(), out idTendora);
                    if (idTendora > 0)
                    {
                        String stEmision = String.Empty;
                        int idBanco = 0;

                        int.TryParse(cboIdBanco.SelectedValue.ToString(), out idBanco);

                        stpUpdAutorizacionNominaTableAdapter1.stpSelTenedoraEmisoraBanorte_V1(idTendora, idBanco, ref stEmision);
                        stEmision = stEmision.Trim();
                        if (!String.IsNullOrEmpty(stEmision))
                        {
                            txtEmisora.Text = stEmision;
                        }
                        else
                        {
                            txtEmisora.Enabled = true;
                        }
                    }
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Error al Asignar Emisora" + Environment.NewLine + "Por favor de ingresar Emisora Manualemnte.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmisora.Enabled = true;
                }
            }
            else
            {
                txtEmisora.Text = String.Empty;
                txtEmisora.Enabled = false;

                //asociamos nuevamente el gridview a los datos

            }
        }

        private void cboFormatoBanco_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            String stRutaLayOut = @"C:\LAYOUTS\";
            dsc.CheckandCreateFolder(stRutaLayOut);
            Process.Start(stRutaLayOut);
        }

        private int GenerarLayoutBancarioSantander_1(DataTable dtstpSelLayOutBancarios, String stNombreLayOut, String stFormatoFecha)
        {
            int intNoRegistrosPagos = 0;
            String stRutaLayOut = @"C:\LAYOUTS\";

            try
            {
                if (dtstpSelLayOutBancarios.Rows.Count > 0)
                {
                    dsc.CheckandCreateFolder(stRutaLayOut);
                    List<String> ListaEmpleados = new List<String>();

                    foreach (DataRow item in dtstpSelLayOutBancarios.Rows)
                    {
                        if (!String.IsNullOrEmpty(item["LayOut"].ToString()))
                        {
                            ListaEmpleados.Add(item["LayOut"].ToString());
                        }
                    }

                    //Agregando la fecha de Pago en el Layout
                    for (int i = 0; i < ListaEmpleados.Count; i++)
                    {
                        if (ListaEmpleados[i].Contains("@pFechaPago")) // Actualizando fecha de Pago en el LayOut
                        {
                            ListaEmpleados[i] = ListaEmpleados[i].Replace("@pFechaPago", dtFechaPago.Value.Date.ToString(stFormatoFecha));
                        }
                        if (ListaEmpleados[i].Contains("@pEmisora"))// Actualizando la Emisora en el LayOUt
                        {
                            ListaEmpleados[i] = ListaEmpleados[i].Replace("@pEmisora", txtEmisora.Text);
                        }
                    }

                    File.WriteAllLines(stRutaLayOut + stNombreLayOut, ListaEmpleados);
                    int.TryParse(dtstpSelLayOutBancarios.Rows[0]["NumeroDeRegistros"].ToString(), out intNoRegistrosPagos);
                }
            }
            catch (Exception)
            {
                intNoRegistrosPagos = 0;
            }

            return intNoRegistrosPagos;
        }

        private void txtIdLote_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    try
                    {
                        if (txtIdLote.Text != "")
                        {
                            //mostrar Lotes Carga Nomina en base a parametros
                            MostrarLoteCargaNomina(Convert.ToInt32(txtIdLote.Text.Replace(",", "").Replace(".", "")), true);
                            txtIdLote.Text = "";
                        }
                        else
                        {
                            XtraMessageBox.Show(String.Format("Debe de Ingresar un Lote valido"), "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        txtEmisora.Text = String.Empty;
                        txtEmisora.Enabled = false;

                        //asociamos nuevamente el gridview a los datos
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }
                else
                {
                    MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
        }

        private void btnActualizarFormaPagoLote_Click(object sender, EventArgs e)
        {
            int numEmpleadosDisponibles = 0;
            if (gvLotesCargaNomina.RowCount > 0)
            {
                int intIdLoteCargaNomina = Convert.ToInt32(gvLotesCargaNomina.Rows[gvLotesCargaNomina.SelectedCells[0].RowIndex].Cells[0].Value);

                if (intIdLoteCargaNomina != 0)
                {
                    stpSelObtenerInfoEmpleadosLoteCargaNominaTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelObtenerInfoEmpleadosLoteCargaNomina, intIdLoteCargaNomina);
                    if (dbSAICBPOCatalogosDataSet.stpSelObtenerInfoEmpleadosLoteCargaNomina.Rows.Count > 0)
                    {

                        numEmpleadosDisponibles = dbSAICBPOCatalogosDataSet.stpSelObtenerInfoEmpleadosLoteCargaNomina.Select("[Estatus Empleado] <> ''").Length;

                        //if (dbSAICBPOCatalogosDataSet.stpSelObtenerInfoEmpleadosLoteCargaNomina.Rows.Count != numEmpleadosDisponibles)
                        //{
                            Lote miLote = new Lote();
                            miLote = miLote.ObtenerInformacionLoteCargaNomina(intIdLoteCargaNomina);
                            NominaCFDI.frmxActualizarFormaPagoLote ActFormaPago = new NominaCFDI.frmxActualizarFormaPagoLote(miLote);
                            ActFormaPago.ShowDialog();
                        //}
                        //else
                        //{
                        //    XtraMessageBox.Show("El Lote no cuenta con Empleados disponibles para cambiar Tipo de Pago.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //}
                    }
                    else
                    {
                        XtraMessageBox.Show("El Lote no cuenta con Empleados Activos.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Consulte un lote para Actualizar el metodo de Pago.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtIdLote_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    try
                    {
                        if (txtIdLote.Text != "")
                        {
                            //mostrar Lotes Carga Nomina en base a parametros
                            MostrarLoteCargaNomina(Convert.ToInt32(txtIdLote.Text.Replace(",", "").Replace(".", "")), true);
                            txtIdLote.Text = "";
                        }
                        else
                        {
                            XtraMessageBox.Show(String.Format("Debe de Ingresar un Lote valido"), "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        txtEmisora.Text = String.Empty;
                        txtEmisora.Enabled = false;

                        //asociamos nuevamente el gridview a los datos
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }
                else
                {
                    MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
        }

        private void txtLote_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    try
                    {
                        int iLote;
                        int.TryParse(txtLote.Text, out iLote);

                        if (iLote > 0)
                        {
                            //mostrar Lotes Carga Nomina en base a parametros
                            MostrarLoteCargaNomina(iLote, true);
                            txtLote.Text = "";
                        }
                        else
                        {
                            XtraMessageBox.Show(String.Format("Debe de Ingresar un Lote valido"), "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        txtEmisora.Text = String.Empty;
                        txtEmisora.Enabled = false;

                        //asociamos nuevamente el gridview a los datos
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }
                //else
                //{
                //    MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    e.Handled = true;
                //    return;
                //}
            }
        }
    }
}