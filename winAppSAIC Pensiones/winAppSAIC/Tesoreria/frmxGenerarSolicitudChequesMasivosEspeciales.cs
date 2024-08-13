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
using System.Data.SqlClient;

namespace winAppSAIC.Tesoreria
{
    public partial class frmxGenerarSolicitudChequesMasivosEspeciales : DevExpress.XtraEditors.XtraForm
    {
        public frmxGenerarSolicitudChequesMasivosEspeciales()
        {
            InitializeComponent();
        }

        #region "Variables Globales"
        private Int64 IdLoteCargaNomina;
        private Int32 IdTenedora;
        private Int32 IdCliente;
        private string sTipoNomina;
        private string sFolioLoteCargaNomina;
        private string sIdTipoMovimiento;
        private Int32 IdSubCategoriaTransaccionBanco;
        private Int32 IdCategoriaTransaccionBanco;

        private ChequePorProcesar chequePP;
        private CurrencyManager cm;

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

        private void RemoverRegistrosListChequesGridView()
        {
            chequePP.ListCheques.Clear();      //remover cheques de la Lista
            cm.Refresh();       //actualizar objeto
        }

        #endregion

        private void cboFolioLoteCargaNomina_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //obtener el renglon completo del Combobox
                DataRow row = gridLookUpEdit1View.GetDataRow(gridLookUpEdit1View.FocusedRowHandle);
                //asignar valores extraidos del Combobox
                IdLoteCargaNomina = Convert.ToInt64(row["IdLoteCargaNomina"]);
                IdTenedora = Convert.ToInt32(row["IdTenedora"]);     //obtener IdTenedora
                sFolioLoteCargaNomina = row["FolioLoteCargaNomina"].ToString();
                IdCliente = Convert.ToInt32(row["IdCliente"]);
                sTipoNomina = row["FolioLoteCargaNomina"].ToString().Substring(2, 3);    //obtener Tipo Nomina (SEM, QUI, ASI, etc)
                sIdTipoMovimiento = sFolioLoteCargaNomina.Substring(0, 1);  //S o A
                IdCategoriaTransaccionBanco = Convert.ToInt32(row["IdCategoriaTransaccionBanco"]);
                IdSubCategoriaTransaccionBanco = Convert.ToInt32(row["IdSubCategoriaTransaccionBanco"]);

                //cargar informacion detallada LoteCargaNomina
                MostrarInfoDetalleLoteCargaNomina((long)cboFolioLoteCargaNomina.EditValue);
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

                this.stpSelFolioLoteCargaNominaParaSolicitudChequesEspecialesTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.stpSelFolioLoteCargaNominaParaSolicitudChequesEspeciales, Convert.ToInt16(txtAno.EditValue), Convert.ToByte(txtMes.EditValue), OperadorBD.OperadorGlobal.IdOperador);
                // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet.stpSelBanco' table. You can move, or remove it, as needed.
                this.stpSelBancoTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.stpSelBanco);

                //asociar objeto Lista Cheques Por Procesar a GridView
                chequePP = new ChequePorProcesar();
                //stpSelGenerarSolicitudChequesGridControl.DataSource = chequePP.ListCheques;
                //cm = (CurrencyManager)stpSelGenerarSolicitudChequesGridControl.BindingContext[chequePP.ListCheques];

                ChequeLineItemDataGridView.DataSource = chequePP.ListCheques;
                cm = (CurrencyManager)ChequeLineItemDataGridView.BindingContext[chequePP.ListCheques];

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

                this.stpSelFolioLoteCargaNominaParaSolicitudChequesEspecialesTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.stpSelFolioLoteCargaNominaParaSolicitudChequesEspeciales, Convert.ToInt16(txtAno.EditValue), Convert.ToByte(txtMes.EditValue), OperadorBD.OperadorGlobal.IdOperador);
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

        private void btnAgregarCheque_Click(object sender, EventArgs e)
        {
            ChequesLineItem Cheque = null;

            frmxAgregarChequeEspecial objChequeEspecial = new frmxAgregarChequeEspecial();
            DialogResult result = objChequeEspecial.ShowDialog();
            if (result == DialogResult.OK)
            {
                Cheque = (ChequesLineItem) objChequeEspecial.Tag;       //recibir objeto Cheque

                if (Cheque != null)
                {
                    //agregar más valores al objeto
                    Cheque.IdLoteCargaNomina = IdLoteCargaNomina;
                    Cheque.FolioLoteCargaNomina = sFolioLoteCargaNomina;
                    Cheque.IdTenedora = IdTenedora;
                    Cheque.IdCliente = IdCliente;
                    Cheque.IdPDOHeader = -1;

                    chequePP.ListCheques.Add(Cheque);   //agregar cheque al arreglo
                    cm.Refresh();   //actualizar objeto
                }
            }

        }

        private void ChequeLineItemDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)     //si el usuario presiona botón eliminar
            {
                chequePP.ListCheques.RemoveAt(e.RowIndex);      //remover cheque del arreglo
                cm.Refresh();       //actualizar objeto
            }
        }

        private void btnGenerarSolicitud_Click(object sender, EventArgs e)
        {
            //validar captura informacion complemento
            if (Validator.IsPresent(cboFolioLoteCargaNomina) && Validator.IsPresent(txtNoControl) && Validator.IsPresent(cboIdBancoSolicitado))
            {
                long? pIdSolicitudChequeHeader = 0;
                if (chequePP.ListCheques.Count == 0)
                {
                    XtraMessageBox.Show("¡Debe registrar al menos un cheque para generar\nla Solicitud de Cheques Masivos Especiales!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    try
                    {
                        //insertar encabezado Solicitud
                        int iRegAfectado = this.solicitudChequeHeaderTableAdapter1.Insert(objInfoDetalle.IdLoteCargaNomina,
                            objInfoDetalle.FolioLoteCargaNomina, objInfoDetalle.IdTenedora,
                            objInfoDetalle.IdCliente, Convert.ToByte(cboIdBancoSolicitado.EditValue),
                            IdCategoriaTransaccionBanco, IdSubCategoriaTransaccionBanco,
                            objInfoDetalle.FechaInicio, objInfoDetalle.FechaFin, objInfoDetalle.IdTipoPeriodoNomina,
                            objInfoDetalle.IdOperador, objInfoDetalle.IdMoneda, objInfoDetalle.TipoCambio,
                            txtNoControl.Text, "SCE", OperadorBD.OperadorGlobal.NombreUsuario,
                            ref pIdSolicitudChequeHeader);


                        if (pIdSolicitudChequeHeader > 0)
                        {
                            //insertar registros detalle de cheques masivos
                            foreach (ChequesLineItem li in chequePP.ListCheques)
                            {
                                 iRegAfectado = this.solicitudChequeDetailTableAdapter1.Insert((long)pIdSolicitudChequeHeader,
                                    li.IdPDOHeader, li.IdEmpleadoInterno, li.BeneficiarioCheque, li.BeneficiarioPoliza,
                                    li.MontoNetoPagar, li.ImporteConLetra, li.IdMoneda, li.IdCategoriaTransaccionBanco,
                                    li.IdSubCategoriaTransaccionBanco, li.OtroConcepto, li.Observaciones,
                                    li.AjusteContable, OperadorBD.OperadorGlobal.NombreUsuario);
                            }
                            XtraMessageBox.Show(string.Format("La Solicitud de Cheques Masivos # {0}\nha sido generada.", pIdSolicitudChequeHeader), "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //actualizar los cheques pendientes del lote involucrado
                            this.stpSelChequesPorLoteCargaNominaTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.stpSelChequesPorLoteCargaNomina, (long)cboFolioLoteCargaNomina.EditValue, sIdTipoMovimiento);
                            RemoverRegistrosListChequesGridView();  //eliminar filas DataGridView
                            txtNoControl.Text = "";
                        }
                        else
                        {
                            XtraMessageBox.Show("¡No fue posible generar la Solicitud (ENC) de Cheques Masivos Especiales!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (SqlException ex)
                    {
                        //XtraMessageBox.Show("¡No fue posible generar la Solicitud de Cheques Masivos Especiales!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("¡No fue posible generar la Solicitud de Cheques Masivos Especiales!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}