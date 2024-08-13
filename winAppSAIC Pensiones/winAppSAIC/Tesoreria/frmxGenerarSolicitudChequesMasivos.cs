using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;
using compLibreriaSAIC;
using compCatalogosSAIC;
using winAppSAIC.UtileriasLocal;

namespace winAppSAIC.Tesoreria
{
    public partial class frmxGenerarSolicitudChequesMasivos : DevExpress.XtraEditors.XtraForm
    {
        public frmxGenerarSolicitudChequesMasivos()
        {
            InitializeComponent();
        }

        #region "Variables Globales"
        private Int32 IdTenedora;
        private string sTipoNomina;
        private string sFolioLoteCargaNomina;
        private string sIdTipoMovimiento;
        private Int32 IdSubCategoriaTransaccionBanco;
        private Int32 IdCategoriaTransaccionBanco;

        InfoDetalleLoteCargaNomina objInfoDetalle;      //declarar objeto InfoDetalleLoteCargaNomina

        #endregion

        #region "Metodos Propios"
        /// <summary>
        /// Método que despliega la Informacion Detallada
        /// del Lote Carga Nomina seleccionado
        /// </summary>
        private void MostrarInfoDetalleLoteCargaNomina(long pIdLoteCargaNomina)
        {
            //cargar informacion detalla LoteCargaNomina
            DataTable dt = this.stpSelInfoDetalleLoteCargaNominaGenericoChequesTableAdapter.GetData(pIdLoteCargaNomina);

            //crear objeto y pasar el DataTable para asignar los valores
            objInfoDetalle = InfoDetalleLoteCargaNominaBD.ObtenerInfoDetalleLoteCargaNominaGenericoCheques(dt);

            //si existe el objeto entonces mostrar los valores
            if (objInfoDetalle != null)
            {
                txtNombreComercialTenedora.Text = objInfoDetalle.NombreComercialTenedora;
                txtNombreComercialCliente.Text = objInfoDetalle.NombreComercialCliente;
                txtNombreOperador.Text = objInfoDetalle.Operador;
                txtTipoNomina.Text = objInfoDetalle.TipoNomina;
                txtPeriodoPago.Text = objInfoDetalle.PeriodoPago;
                chkEstatusNominaContabilizada.Checked = objInfoDetalle.EstatusNominaContabilizada;
            }
        }

        #endregion

        private void cboFolioLoteCargaNomina_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //obtener el renglon completo del Combobox
                DataRow row = gridLookUpEdit1View.GetDataRow(gridLookUpEdit1View.FocusedRowHandle);
                //asignar valores extraidos del Combobox
                IdTenedora = Convert.ToInt32(row["IdTenedora"]);     //obtener IdTenedora
                sFolioLoteCargaNomina = row["FolioLoteCargaNomina"].ToString();
                sTipoNomina = row["FolioLoteCargaNomina"].ToString().Substring(2, 3);    //obtener Tipo Nomina (SEM, QUI, ASI, etc)
                sIdTipoMovimiento = sFolioLoteCargaNomina.Substring(0, 1);  //S o A
                IdCategoriaTransaccionBanco = Convert.ToInt32(row["IdCategoriaTransaccionBanco"]);
                IdSubCategoriaTransaccionBanco = Convert.ToInt32(row["IdSubCategoriaTransaccionBanco"]);

                //cargar informacion detallada LoteCargaNomina
                MostrarInfoDetalleLoteCargaNomina((long)cboFolioLoteCargaNomina.EditValue);
                //cargar los cheques del lote involucrado
                this.stpSelChequesPorLoteCargaNominaTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.stpSelChequesPorLoteCargaNomina, (long)cboFolioLoteCargaNomina.EditValue, sIdTipoMovimiento);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmxGenerarSolicitudCheques_Load(object sender, EventArgs e)
        {
            try
            {
                splashSMCargando.ShowWaitForm();
                this.Cursor = Cursors.AppStarting;      //cambiar cursor del mouse

                txtAno.EditValue = DateTime.Now.Year;       //asignar fecha del filtro
                txtMes.EditValue = DateTime.Now.Month;

                this.stpSelFolioLoteCargaNominaParaSolicitudChequesTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.stpSelFolioLoteCargaNominaParaSolicitudCheques, Convert.ToInt16(txtAno.EditValue), Convert.ToByte(txtMes.EditValue), OperadorBD.OperadorGlobal.IdOperador );
                // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet.stpSelBanco' table. You can move, or remove it, as needed.
                this.stpSelBancoTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelBanco);

                // Set column widths according to their contents. 
                cboFolioLoteCargaNomina.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cboFolioLoteCargaNomina.Properties.PopupFormWidth = 900;
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);            
            }
            finally
            {
                this.Cursor = Cursors.Default;      //cambiar cursor del mouse
                splashSMCargando.CloseWaitForm();
            }
        }

        private void btnFiltrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                splashSMCargando.ShowWaitForm();
                this.Cursor = Cursors.AppStarting;      //cambiar cursor del mouse

                this.stpSelFolioLoteCargaNominaParaSolicitudChequesTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.stpSelFolioLoteCargaNominaParaSolicitudCheques, Convert.ToInt16(txtAno.EditValue), Convert.ToByte(txtMes.EditValue), OperadorBD.OperadorGlobal.IdOperador);
                // Set column widths according to their contents. 
                cboFolioLoteCargaNomina.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cboFolioLoteCargaNomina.Properties.PopupFormWidth = 900;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;      //cambiar cursor del mouse
                splashSMCargando.CloseWaitForm();
            }
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();        //cerrar pantalla
        }

        private void btnFiltrarRecibos_Click(object sender, EventArgs e)
        {
            //validar captura informacion complemento
            if (Validator.IsPresent(txtNoControl) && Validator.IsPresent(cboIdBancoSolicitado))
            {
                long? pIdSolicitudChequeHeader = 0;
                //si existen renglones seleccionados
                if (gridView1.SelectedRowsCount >0)
                {
                    try
                    {
                        ArrayList rows = new ArrayList();
                        int iRegAfectado = 0;

                        iRegAfectado = this.solicitudChequeHeaderTableAdapter1.Insert(objInfoDetalle.IdLoteCargaNomina, objInfoDetalle.FolioLoteCargaNomina, objInfoDetalle.IdTenedora, objInfoDetalle.IdCliente,
                            Convert.ToByte(cboIdBancoSolicitado.EditValue), IdCategoriaTransaccionBanco, IdSubCategoriaTransaccionBanco, objInfoDetalle.FechaInicio, objInfoDetalle.FechaFin, objInfoDetalle.IdTipoPeriodoNomina, objInfoDetalle.IdOperador,
                            objInfoDetalle.IdMoneda, objInfoDetalle.TipoCambio, txtNoControl.Text,"SCM", OperadorBD.OperadorGlobal.NombreUsuario, ref pIdSolicitudChequeHeader);

                        if (pIdSolicitudChequeHeader > 0)
                        {
                            // Add the selected rows to the list.
                            for (int i = 0; i < gridView1.SelectedRowsCount; i++)
                            {
                                if (gridView1.GetSelectedRows()[i] >= 0)
                                    rows.Add(gridView1.GetDataRow(gridView1.GetSelectedRows()[i]));
                            }

                            //insertar registros detalle de cheques masivos
                            for (int i = 0; i < rows.Count; i++)
                            {
                                DataRow row = rows[i] as DataRow;
                                iRegAfectado = this.solicitudChequeDetailTableAdapter1.Insert((long)pIdSolicitudChequeHeader, (long)row["IdPDOHeader"], 
                                    Convert.ToInt32(row["IdEmpleadoInterno"]),row["NombreEmpleado"].ToString(), row["NombreEmpleado"].ToString(),
                                    Convert.ToDecimal(row["MontoNetoPagar"]), row["ImporteConLetra"].ToString(),
                                    row["IdMoneda"].ToString(), Convert.ToInt32(row["IdCategoriaTransaccionBanco"]),
                                    Convert.ToInt32(row["IdSubCategoriaTransaccionBanco"]), "","",false, OperadorBD.OperadorGlobal.NombreUsuario);
                            }
                            //actualizar los cheques pendientes del lote involucrado
                            this.stpSelChequesPorLoteCargaNominaTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.stpSelChequesPorLoteCargaNomina, (long)cboFolioLoteCargaNomina.EditValue, sIdTipoMovimiento);

                            //sino existen más registros en el gridview
                            if (gridView1.RowCount == 0)
                            {
                                XtraMessageBox.Show("¡Ya no existen cheques por solicitar!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtNoControl.Text = string.Empty;
                                cboIdBancoSolicitado.EditValue = -1;
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show("¡No fue posible generar la Solicitud de Cheques Masivos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("¡No fue posible generar la Solicitud de Cheques Masivos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    XtraMessageBox.Show("¡Debe seleccionar al menos un cheque para generar\nla Solicitud de Cheques Masivos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBuscarNoLoteNomina_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    //si escribieron un valor
            //    if (txtNoLoteCargaNomina.Text.Trim().Length > 0)
            //    {
            //        if (Validator.IsPositiveNumber(txtNoLoteCargaNomina))
            //        {
            //            //cargar informacion detallada LoteCargaNomina
            //            MostrarInfoDetalleLoteCargaNomina(Convert.ToInt64(txtNoLoteCargaNomina.EditValue));

            //            //si existe el objeto InfoDetalle
            //            if (objInfoDetalle != null)
            //            {
            //                splashSMProcesando.ShowWaitForm();
            //                this.stpSelRecibosEmpleadosSueldosAsimiladosGenericoCFDITableAdapter.Fill(this.dbSAICBPONominaCFDIDataSet.stpSelRecibosEmpleadosSueldosAsimiladosGenericoCFDI, -1, -1, -1, Convert.ToInt64(txtNoLoteCargaNomina.EditValue), 0, 4);
            //                splashSMProcesando.CloseWaitForm();

            //                if (this.dbSAICBPONominaCFDIDataSet.stpSelRecibosEmpleadosSueldosAsimiladosGenericoCFDI.Count > 0)
            //                    //asignar los registros a un DataTable que LINQ filtrara para la selecciona de registros
            //                    dtInfoEmpleado = this.dbSAICBPONominaCFDIDataSet.stpSelRecibosEmpleadosSueldosAsimiladosGenericoCFDI;
            //                else
            //                    XtraMessageBox.Show(string.Format("¡No existen registros para este No. Lote Nómina {0}!", txtNoLoteCargaNomina.EditValue), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            }
            //            else
            //            {
            //                //mostrar registros del Lote Nomina = 0 para cuando el objeto InfoDetalle = null
            //                this.stpSelRecibosEmpleadosSueldosAsimiladosGenericoCFDITableAdapter.Fill(this.dbSAICBPONominaCFDIDataSet.stpSelRecibosEmpleadosSueldosAsimiladosGenericoCFDI, -1, -1, -1, 0, 0, 4);

            //                XtraMessageBox.Show(string.Format("¡No existen registros para este No. Lote Nómina {0}!", txtNoLoteCargaNomina.EditValue), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            }
            //        }
            //    }
            //    else
            //        XtraMessageBox.Show("Debe escribir el No. de Lote Nómina para obtener la Información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //catch (Exception ex)
            //{
            //    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}