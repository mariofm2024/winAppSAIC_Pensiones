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
using winAppSAIC.Reportes;
using DevExpress.XtraReports.UI;        //namespace a partir version 12.2.4
using winAppSAIC.UtileriasLocal;

namespace winAppSAIC.ControlOperaciones
{
    public partial class frmxAdmonControlOperaciones : DevExpress.XtraEditors.XtraForm
    {

        private bool AutorizacionCancelar = false;
        private bool AutorizacionVincular = false;
        private bool AutorizacionDesVincular = false;
        private bool AutorizacionSolicitud = false;
        private bool AutorizacionBloquear = false;
        private bool AutorizacionBloquearO = false;
        private bool AutorizacionAbrirControl = false;
        private bool BotonCrearControl = true;
        private bool AutorizacionBloquearTesoreria = false;
        private bool AutorizacionBloquearOperaciones = false;
        private bool AutorizacionPago = false;

        decimal? pSaldo = 0;

        public frmxAdmonControlOperaciones()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            //Limpiar 
            txtId.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtCliente.Text = string.Empty;
            txtFronting1.Text = string.Empty;
            txtMonto1.Text = string.Empty;
            txtBanco1.Text = string.Empty;
            txtFronting2.Text = string.Empty;
            txtMonto2.Text = string.Empty;
            txtBanco2.Text = string.Empty;
            txtFronting3.Text = string.Empty;
            txtMonto3.Text = string.Empty;
            txtBanco3.Text = string.Empty;
            txtFronting4.Text = string.Empty;
            txtMonto4.Text = string.Empty;
            txtBanco4.Text = string.Empty;
            txtFronting5.Text = string.Empty;
            txtMonto5.Text = string.Empty;
            txtBanco5.Text = string.Empty;
            txtTipoNomina.Text = string.Empty;
            txtPeriodoPago.Text = string.Empty;
            txtOperador.Text = string.Empty;
            txtEstatus.Text = string.Empty;
            txtMotivo.Text = string.Empty;
            txtMoneda.Text = string.Empty;
            txtCambio.Text = string.Empty;
            txtFechas.Text=string.Empty;
            txtTotalCotrolD.Text = string.Empty;

            //Activar Botones

            txtToControlopera.Text = string.Empty;
            txtToperacion.Text = string.Empty;
            txtSaldoToOperacion.Text = string.Empty;

            txtTControl.Text = string.Empty;
            txtTFacturas.Text = string.Empty;
            txtSaldo.Text = string.Empty;

            cbControlRela.EditValue = -1;
            txtObservaciones.Text = string.Empty;

            txtMesAno.Text = string.Empty;
            chkCierre.Checked = false;
            chkPagado.Checked = false;
            txtSaldoCli.Text = string.Empty;

            pSaldo = 0;

            //cargar informacion detallada del Control de Operaciones
            this.dbSAICBPOFactura.stpFactSelDetailControlOperaciones.Clear();
            //Cargar Facturas
            this.dbSAICBPOFactura.stpFactSelFacturasControl.Clear();
            //Cargar Productos
            this.dbSAICBPOFactura.stpFactSelCOProductos.Clear();

            txtMesAno.Text = string.Empty;
            chkCierre.Checked = false;

            LimpiarBotones();
        }



        private void ActivarBotonesC(bool bflag, bool bflagFactura, bool bflagBloquear, int intPago, bool bFlagTesoreria, bool bFlagAutorizacion)
        {
            //***************Bloquear Control***************************
            if (AutorizacionBloquear == true)  //Solicitar Cancelación/
            {
                btnActualizar.Visible = bflag;
                btnCerrarC.Visible = !bflagBloquear;
            }
            else
            {
                btnActualizar.Visible = false;
                btnCerrarC.Visible = false;
            }

            if (AutorizacionAbrirControl == true)
                btnAbrirC.Visible = bflagBloquear;
            else
                btnAbrirC.Visible = false;

            if (bflagBloquear)
            {

                btnSolicitudCancelacion.Visible = false;
                btnCancelarControl.Visible = false;

                btnHabilitar.Visible = false;
                btnVincular.Visible = false;
                btnDesvincular.Visible = false;
                btnActualizar.Visible = false;

                if (intPago == 35)
                    btnSolicitarPago.Visible = true;
                else
                    btnSolicitarPago.Visible = false;

                //***************Realizar Bloqueo para Tesoreria***************************
                if (AutorizacionBloquearTesoreria)
                {
                    btnPago.Visible = !bFlagTesoreria;
                    btnPagoEliminar.Visible = bFlagTesoreria;
                }
                else
                {

                    btnPago.Visible = false;
                    btnPagoEliminar.Visible = false;
                }

                if (bFlagTesoreria)
                {
                    btnSolicitudCancelacion.Visible = false;
                    btnCancelarControl.Visible = false;
                }

                //******************************************
            }
            else
            {
                //***************Realizar la Solicitud***************************
                if (AutorizacionSolicitud && AutorizacionBloquear)  //Solicitar Cancelación/
                {
                    btnSolicitudCancelacion.Visible = bflag;
                    if (intPago == 35)
                        btnSolicitarPago.Visible = true;
                    else
                        btnSolicitarPago.Visible = false;
                }
                else
                {
                    btnSolicitarPago.Visible = false;
                    btnSolicitudCancelacion.Visible = false;
                }

                //***************Realizar la Cancelación***************************
                if (AutorizacionCancelar == true && AutorizacionSolicitud == false)  //Eliminar/
                {
                    btnCancelarControl.Visible = bflag;
                    btnHabilitar.Visible = bflag;
                }
                else
                {
                    btnCancelarControl.Visible = false;
                    btnHabilitar.Visible = false;
                }

                //***************Realizar la Vinculación***************************
                if (AutorizacionVincular == true && AutorizacionDesVincular == true) // Actualizar
                {
                    btnVincular.Visible = !bflagFactura;
                    btnDesvincular.Visible = bflagFactura;
                }
                else if (AutorizacionVincular == true)  //Solicitar Cancelación/
                {
                    btnVincular.Visible = !bflagFactura;
                    btnDesvincular.Visible = false;
                }
                else
                {
                    btnVincular.Visible = false;
                    btnDesvincular.Visible = false;
                }
                //******************************************

                //***************Realizar Bloqueo para Tesoreria***************************
                if (AutorizacionBloquearTesoreria)
                {
                    btnPago.Visible = !bFlagTesoreria;
                    btnPagoEliminar.Visible = bFlagTesoreria;
                }
                else
                {

                    btnPago.Visible = false;
                    btnPagoEliminar.Visible = false;
                }

                if (bFlagTesoreria)
                {
                    btnSolicitudCancelacion.Visible = false;
                    btnCancelarControl.Visible = false;
                }

                //******************************************
            }

            if (AutorizacionBloquearOperaciones)
            {
                btnAutControl.Visible = !bFlagAutorizacion;
                btnEAutControl.Visible = bFlagAutorizacion;

                //Limpiar 
                btnDescargar.Visible = bFlagAutorizacion;
            }
            else
            {
                btnAutControl.Visible = false;
                btnAutControl.Visible = false;

                //Limpiar 
                btnDescargar.Visible = bFlagAutorizacion;
            }

            if (AutorizacionPago && bflag)
            {
                if (intPago == 35)
                    btnSolicitarPago.Visible = true;
                else
                    btnSolicitarPago.Visible = false;
            }
            else
            {
                btnSolicitarPago.Visible = false;
            }
        }

        private void LimpiarBotones()
        {
            //Limpiar 
            btnDescargar.Visible = false;
            btnSolicitudCancelacion.Visible = false;
            btnCancelarControl.Visible = false;
            btnHabilitar.Visible = false;
            btnDesvincular.Visible = false;
            btnVincular.Visible = false;
            btnAbrirC.Visible = false;
            btnCerrarC.Visible = false;
            btnActualizar.Visible = false;
            btnSolicitarPago.Visible = false;
            btnPago.Visible = false;
            btnPagoEliminar.Visible = false;
            btnAutControl.Visible = false;
            btnEAutControl.Visible = false;
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            try
            {
                ControlOperaciones.frmNuevoControlOperaciones objMCliente = new ControlOperaciones.frmNuevoControlOperaciones();
                objMCliente.ShowDialog();
                Limpiar();
                Actualizar();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close(); //SALIR
        }

        private void frmxAdmonControlOperaciones_Load(object sender, EventArgs e)
        {
            try
            {
                this.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1.Fill(this.dbSAICBPOFactura.stpFactSelDerechosAccesoOperadorFacturacion, OperadorBD.OperadorGlobal.IdOperador, "ControlOperaciones.frmxAdmonControlOperaciones", "btnCancelarControl");

                if (this.dbSAICBPOFactura.stpFactSelDerechosAccesoOperadorFacturacion.Count > 0)
                {
                    DataRow row = this.dbSAICBPOFactura.stpFactSelDerechosAccesoOperadorFacturacion.Rows[0];
                    AutorizacionBloquearO = (bool)row[11];
                    AutorizacionVincular = (bool)row[12];
                    AutorizacionDesVincular = (bool)row[13];
                    AutorizacionCancelar = (bool)row[14];
                    AutorizacionBloquear = (bool)row[15];
                    row = null;
                }
                else
                {
                    AutorizacionBloquearO = false;
                    AutorizacionCancelar = false;
                    AutorizacionVincular = false;
                    AutorizacionDesVincular = false;
                    AutorizacionBloquear = false;
                }

                this.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1.Fill(this.dbSAICBPOFactura.stpFactSelDerechosAccesoOperadorFacturacion, OperadorBD.OperadorGlobal.IdOperador, "ControlOperaciones.frmxAdmonControlOperaciones", "btnCancelarControlC");

                if (this.dbSAICBPOFactura.stpFactSelDerechosAccesoOperadorFacturacion.Count > 0)
                {
                    DataRow row = this.dbSAICBPOFactura.stpFactSelDerechosAccesoOperadorFacturacion.Rows[0];
                    AutorizacionAbrirControl = (bool)row[11];
                    BotonCrearControl = (bool)row[12];
                    AutorizacionBloquearTesoreria = (bool)row[13];
                    AutorizacionBloquearOperaciones = (bool)row[14];
                    AutorizacionPago = (bool)row[15];
                }
                else
                {
                    AutorizacionAbrirControl = false;
                    BotonCrearControl = false;
                    AutorizacionBloquearTesoreria = false;
                    AutorizacionBloquearOperaciones = false;
                    AutorizacionPago = false;
                }

                btnFacturar.Visible = BotonCrearControl;


                dtFechaIni.Value = DateTime.Now.AddDays(-30);
                dtFechaFin.Value = DateTime.Now;

                Actualizar();

                // Set column widths according to their contents. 
                cbControl.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cbControl.Properties.PopupFormWidth = 900;
                // Set column widths according to their contents. 
                cbControlRela.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cbControlRela.Properties.PopupFormWidth = 50;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbControl_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                bool bflagBloquear = false;
                int bflagSolicitudPago = 35;
                bool bFlagTesoreria = false;
                bool bFlagAutorizacion = false;
                Int32 idCliente = 0;
                splashSMCargando.ShowWaitForm();
                Limpiar();

                if (gridLookUpEdit1View.FocusedRowHandle >= 0)
                {
                    //obtener el renglon completo del Combobox
                    DataRow row = gridLookUpEdit1View.GetDataRow(gridLookUpEdit1View.FocusedRowHandle);

                    if (row != null)
                    {
                        //asignar valores extraidos del Combobox
                        txtId.Text = row[0].ToString();
                        idCliente = Convert.ToInt32(row[1].ToString());
                        txtDescripcion.Text = row[14].ToString();
                        txtCliente.Text = row[43].ToString();
                        if (row[30].ToString() == "2")
                            AutorizacionSolicitud = true;
                        else
                            AutorizacionSolicitud = false;
                        txtFronting1.Text = row[46].ToString();
                        txtMonto1.Text = Convert.ToDecimal(row[3].ToString()).ToString("C");
                        txtBanco1.Text = row[36].ToString();
                        txtFronting2.Text = row[47].ToString();
                        txtMonto2.Text = Convert.ToDecimal(row[6].ToString()).ToString("C");
                        txtBanco2.Text = row[37].ToString();
                        txtFronting3.Text = row[48].ToString();
                        txtMonto3.Text = Convert.ToDecimal(row[9].ToString()).ToString("C");
                        txtBanco3.Text = row[38].ToString();
                        txtFronting4.Text = row[66].ToString();
                        txtMonto4.Text = Convert.ToDecimal(row[64].ToString()).ToString("C");
                        txtBanco4.Text = row[68].ToString();
                        txtFronting5.Text = row[72].ToString();
                        txtMonto5.Text = Convert.ToDecimal(row[70].ToString()).ToString("C");
                        txtBanco5.Text = row[74].ToString();                        
                        txtTipoNomina.Text = row[84].ToString();
                        txtFechas.Text = Convert.ToDateTime(row[12].ToString()).ToString("yyyy/MM/dd") + " Al " + Convert.ToDateTime(row[13].ToString()).ToString("yyyy/MM/dd");
                        txtPeriodoPago.Text = row[40].ToString();
                        txtOperador.Text = row[42].ToString();
                        txtCambio.Text = row[29].ToString();
                        txtMoneda.Text = row[28].ToString();
                        txtEstatus.Text = row[44].ToString() + " / PAGO: " + row[62].ToString();
                        txtMotivo.Text = row[45].ToString();

                        txtTotalCotrolD.Text = Convert.ToDecimal(row[27].ToString()).ToString("C");
                        txtTControl.Text = Convert.ToDecimal(row[27].ToString()).ToString("C");
                        txtToControlopera.Text = Convert.ToDecimal(row[27].ToString()).ToString("C");
                        txtToperacion.Text = Convert.ToDecimal(Convert.ToDecimal(row[3].ToString()) + Convert.ToDecimal(row[6].ToString()) + Convert.ToDecimal(row[9].ToString()) + Convert.ToDecimal(row[64].ToString()) + Convert.ToDecimal(row[70].ToString())).ToString("C");

                        bflagBloquear = Convert.ToBoolean(row[53].ToString());
                        chkCierre.Checked = Convert.ToBoolean(row[53].ToString());
                        cbControlRela.EditValue = Convert.ToInt64(row[55].ToString());
                        txtObservaciones.Text = row[54].ToString();
                        txtMesAno.Text = row[60].ToString();
                        bflagSolicitudPago = Convert.ToInt32(row[61].ToString());
                        bFlagTesoreria = Convert.ToBoolean(row[81].ToString());
                        chkPagado.Checked = Convert.ToBoolean(row[81].ToString());
                        bFlagAutorizacion = Convert.ToBoolean(row[82].ToString());

                        this.stpFactSelControlOperacionesRelaTableAdapter.Fill(dbSAICBPOFactura.stpFactSelControlOperacionesRela, idCliente, (Int32)OperadorBD.OperadorGlobal.IdOperador);
                        //cargar informacion detallada del Control de Operaciones
                        this.stpFactSelDetailControlOperacionesTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelDetailControlOperaciones, Convert.ToInt64(row[0].ToString()));
                        //Cargar Facturas
                        this.stpFactSelFacturasControlTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelFacturasControl, Convert.ToInt64(row[0].ToString())); 
                        //Cargar Productos
                        this.stpFactSelCOProductosControlTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelCOProductosControl, Convert.ToInt64(row[0].ToString()));
                        //Cargar Saldo
                        this.spSoloRespuesta1.stpFactSelDetailCOSaldo(Convert.ToInt64(row[0].ToString()), ref pSaldo);

                        txtSaldoCli.Text = Convert.ToDecimal(pSaldo).ToString("C");

                        decimal totalFactura = 0;
                        decimal totalFacturaSaldo = 0;
                        // Si existen Facturas Ligadas 
                        if (dbSAICBPOFactura.stpFactSelFacturasControl.Count > 0)
                        {
                            //obtener el No. de Items seleccionados
                            DataRow row1 = null;
                            for (int i = 0; i < dbSAICBPOFactura.stpFactSelFacturasControl.Count; i++)
                            {
                                row1 = gridView2.GetDataRow(i);
                                if (row1[45].ToString() != "28" && row1[45].ToString() != "3")
                                {
                                    totalFactura = totalFactura + Convert.ToDecimal(row1[29].ToString());
                                    totalFacturaSaldo = totalFacturaSaldo + Convert.ToDecimal(row1[51].ToString());
                                }
                            }

                            //Activar Botones
                            ActivarBotonesC(true, true, bflagBloquear, bflagSolicitudPago, bFlagTesoreria, bFlagAutorizacion);
                        }
                        else
                        {
                            //Activar Botones
                            ActivarBotonesC(true, false, bflagBloquear, bflagSolicitudPago, bFlagTesoreria, bFlagAutorizacion);
                        }

                        txtTFacturas.Text = Convert.ToDecimal(totalFactura).ToString("C");

                        txtTControl2.Text = Convert.ToDecimal(totalFactura).ToString("C");
                        txtTFacturasSaldo.Text = Convert.ToDecimal(totalFactura - totalFacturaSaldo).ToString("C");

                        txtSaldoToOperacion.Text = (Convert.ToDecimal(txtToperacion.Text.Replace(",", "").Replace("$", "")) - Convert.ToDecimal(txtToControlopera.Text.Replace(",", "").Replace("$", ""))).ToString("C2").Replace("-", "");
                        txtSaldo.Text = (Convert.ToDecimal(totalFactura) - Convert.ToDecimal(txtTControl.Text.Replace(",", "").Replace("$", ""))).ToString("C2").Replace("-", "");
                        txtSaldo2.Text = (Convert.ToDecimal(txtTControl2.Text.Replace(",", "").Replace("$", "")) - Convert.ToDecimal(txtTFacturasSaldo.Text.Replace(",", "").Replace("$", ""))).ToString("C2").Replace("-", "");

                        if (Convert.ToDecimal(totalFactura) - Convert.ToDecimal(txtTControl.Text.Replace(",", "").Replace("$", "")) < 0)
                            txtSaldo.ForeColor = Color.Red;
                        else
                            txtSaldo.ForeColor = Color.Black;

                        if (Convert.ToDecimal(txtTFacturasSaldo.Text.Replace(",", "").Replace("$", "")) - Convert.ToDecimal(txtTControl2.Text.Replace(",", "").Replace("$", "")) < 0)
                            txtSaldo2.ForeColor = Color.Red;
                        else
                            txtSaldo2.ForeColor = Color.Black;

                        if (Convert.ToDecimal(txtToperacion.Text.Replace(",", "").Replace("$", "")) - Convert.ToDecimal(txtToControlopera.Text.Replace(",", "").Replace("$", "")) < 0)
                            txtSaldoToOperacion.ForeColor = Color.Red;
                        else
                            txtSaldoToOperacion.ForeColor = Color.Black;

                    }
                    else
                    {
                        //Activar Botones
                        ActivarBotonesC(false, false, false, 35, false, false);
                        XtraMessageBox.Show("¡Debe de Seleccionar un Control!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                splashSMCargando.CloseWaitForm();
            }
        }

        private void btnCancelarControl_Click(object sender, EventArgs e)
        {
            try
            {
                //obtener el renglon completo del Combobox
                DataRow row = gridLookUpEdit1View.GetDataRow(gridLookUpEdit1View.FocusedRowHandle);

                if (row != null)
                {
                    if (XtraMessageBox.Show(String.Format("¿Está seguro que desea cancelar el No. de Control {0}?", row[0].ToString()), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.spSoloRespuesta1.stpFactDelControlOperaciones(Convert.ToInt64(row[0].ToString()), "", OperadorBD.OperadorGlobal.NombreUsuario);
                        this.queriesAsimilados1.stpDelControlOperaciones(Convert.ToInt64(row[0].ToString()), OperadorBD.OperadorGlobal.NombreUsuario);
                        Actualizar();
                        Limpiar();
                    }
                }
                else
                {
                    XtraMessageBox.Show("¡Debe de Seleccionar un Control!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //Activar Botones
                ActivarBotonesC(false, false, false, 35, false, false);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVincular_Click(object sender, EventArgs e)
        {

            try
            {
                //obtener el renglon completo del Combobox
                DataRow row = gridLookUpEdit1View.GetDataRow(gridLookUpEdit1View.FocusedRowHandle);

                if (row != null)
                {
                    ControlOperaciones.frmVicularFacControl objPantalla = new ControlOperaciones.frmVicularFacControl() { IdControl = (long)row[0] };
                    objPantalla.ShowDialog();
                    Actualizar();
                    Limpiar();
                }
                else
                {
                    //Activar Botones
                    XtraMessageBox.Show("¡Debe de Seleccionar un Control!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesvincular_Click(object sender, EventArgs e)
        {
            try
            {
                //obtener el renglon completo del Combobox
                DataRow row = gridLookUpEdit1View.GetDataRow(gridLookUpEdit1View.FocusedRowHandle);

                if (row != null)
                {
                    if (XtraMessageBox.Show(String.Format("¿Está seguro que desea Desvincular la(s) Factura(s) del No. de Control {0}?", row[0].ToString()), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        int? pOk = 0;
                        this.spSoloRespuesta1.stpFactUpdFacturaControles(Convert.ToInt64(row[0].ToString()), OperadorBD.OperadorGlobal.NombreUsuario, ref pOk);
                        if (pOk == 1)
                        {
                            XtraMessageBox.Show("!El Control se Desvinculo Correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            XtraMessageBox.Show("¡Error al Desvincular Control, intentelo mas tarde!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        Actualizar();
                        Limpiar();
                    }
                }
                else
                {
                    XtraMessageBox.Show("¡Debe de Seleccionar un Control!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //Activar Botones
                ActivarBotonesC(false, false, false, 35, false, false);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            Int64 intIdControlOperaciones = 0;
            //si existen Lotes de Carga de Nomina en el gridview
            if (cbControl.EditValue != null)
            {
                //Obtener el Id del Lote de Carga Nomina
                //para asignarlo a los recibos
                intIdControlOperaciones = Convert.ToInt64(cbControl.EditValue.ToString());

                if (intIdControlOperaciones > 0)       //si seleccionamos un Lote de Carga Nomina
                {
                    // splashScreenManager1.ShowWaitForm();        //mostrar pantalla de espera
                    this.Cursor = Cursors.AppStarting;      //cambiar cursor del mouse

                    MostrarReporte(intIdControlOperaciones);

                    this.Cursor = Cursors.Default;      //cambiar cursor del mouse
                                                        // splashScreenManager1.CloseWaitForm();   //quitar pantalla de espera
                }
                else
                    XtraMessageBox.Show("Seleccione un Control para obtener el reporte", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                XtraMessageBox.Show("Seleccione un control de operaciones para obtener el reporte.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void MostrarReporte(Int64 pIdControl)
        {
            //crear reporte
            ReporteControlOperaciones report = new ReporteControlOperaciones();
            try
            {
                //asignar parametros del reporte
                report.Parameters["pIdControlOperaciones"].Value = pIdControl;

                report.Parameters["pSaldo"].Value = pSaldo;

                report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes

                //mostrar reporte
                report.ShowPreview();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSolicitudCancelacion_Click(object sender, EventArgs e)
        {
            try
            {
                //obtener el renglon completo del Combobox
                DataRow row = gridLookUpEdit1View.GetDataRow(gridLookUpEdit1View.FocusedRowHandle);

                if (row != null)
                {
                    ControlOperaciones.frmxCancelarControl objPantalla = new ControlOperaciones.frmxCancelarControl() { objPantalla = (long)row[0] };
                    objPantalla.ShowDialog();
                    Actualizar();
                    Limpiar();
                }
                else
                {
                    XtraMessageBox.Show("¡Debe de Seleccionar un Control!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ActivarBotonesC(false, false, false, 35, false, false);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                //obtener el renglon completo del Combobox
                DataRow row = gridLookUpEdit1View.GetDataRow(gridLookUpEdit1View.FocusedRowHandle);

                if (row != null)
                {
                    if (XtraMessageBox.Show(String.Format("¿Está seguro que desea Habilitar el No. de Control {0}?", row[0].ToString()), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.spSoloRespuesta1.stpFactUpdControlOperaciones(Convert.ToInt64(row[0].ToString()), "", OperadorBD.OperadorGlobal.NombreUsuario);
                        Actualizar();
                        Limpiar();
                    }
                }
                else
                {
                    XtraMessageBox.Show("¡Debe de Seleccionar un Control!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ActivarBotonesC(false, false, false, 35, false, false);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAbrirC_Click(object sender, EventArgs e)
        {

            try
            {
                //obtener el renglon completo del Combobox
                DataRow row = gridLookUpEdit1View.GetDataRow(gridLookUpEdit1View.FocusedRowHandle);

                if (row != null)
                {
                    if (XtraMessageBox.Show(String.Format("¿Está seguro que desea Abrir el Control {0}?", row[0].ToString()), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        int? pOk = 0;
                        this.spSoloRespuesta1.stpFactUpdBloquearControles(Convert.ToInt64(row[0].ToString()), false, OperadorBD.OperadorGlobal.NombreUsuario, ref pOk);
                        if (pOk == 1)
                        {
                            XtraMessageBox.Show("!El Control se Abrio Correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            XtraMessageBox.Show("¡Error al Abrir el Control, intentelo mas tarde!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        Actualizar();
                        Limpiar();
                    }
                }
                else
                {
                    XtraMessageBox.Show("¡Debe de Seleccionar un Control!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //Activar Botones
                ActivarBotonesC(false, false, false, 35, false, false);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrarC_Click(object sender, EventArgs e)
        {
            try
            {
                //obtener el renglon completo del Combobox
                DataRow row = gridLookUpEdit1View.GetDataRow(gridLookUpEdit1View.FocusedRowHandle);

                if (row != null)
                {
                    //DSC - 20230731
                    stpControlCerradoCountTableAdapter1.Fill(dbSAICBPOFactura.stpControlCerradoCount, Convert.ToInt64(row[0].ToString()));
                    int iControlCerrado = 0;
                    int.TryParse(dbSAICBPOFactura.stpControlCerradoCount.Rows[0]["ControlCerradoCount"].ToString(), out iControlCerrado);

                    if (iControlCerrado > 0)
                    {
                        if (AutorizacionBloquearO)
                        {
                            Facturas.frmCierreControl objAsignarXML = new Facturas.frmCierreControl()
                            {
                                pIdControl = Convert.ToInt64(row[0].ToString()),
                                pFLAG = AutorizacionBloquearO
                            };
                            objAsignarXML.ShowDialog();     //mostrar pantalla

                            if (objAsignarXML.pRespuesta != "")
                            {
                                Actualizar();
                                Limpiar();
                            }
                        }
                        else if (Convert.ToDouble(txtSaldo2.Text.Replace("$", "").Replace(",", "")) > -1 && Convert.ToDouble(txtSaldo2.Text.Replace("$", "").Replace(",", "")) < 1 &&
                                 Convert.ToDouble(txtSaldo.Text.Replace("$", "").Replace(",", "")) > -1 && Convert.ToDouble(txtSaldo.Text.Replace("$", "").Replace(",", "")) < 1)
                        {
                            Facturas.frmCierreControl objAsignarXML = new Facturas.frmCierreControl()
                            {
                                pIdControl = Convert.ToInt64(row[0].ToString()),
                                pFLAG = AutorizacionBloquearO
                            };
                            objAsignarXML.ShowDialog();     //mostrar pantalla

                            if (objAsignarXML.pRespuesta != "")
                            {
                                Actualizar();
                                Limpiar();
                            }
                        }
                        else
                            XtraMessageBox.Show("¡El control es Financiado, Se requiere Autorización!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Activar Botones
                        ActivarBotonesC(false, false, false, 35, false, false);
                    }
                    else
                    {
                        XtraMessageBox.Show("No se puede Cerrar Control. El control sera cerrado por área de Tesoreria (Control Pago).", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    XtraMessageBox.Show("¡Debe de Seleccionar un Control!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Int64 idControlRe = 0;
                //obtener el renglon completo del Combobox
                DataRow row = gridLookUpEdit1View.GetDataRow(gridLookUpEdit1View.FocusedRowHandle);

                if (row != null)
                {
                    if (XtraMessageBox.Show(String.Format("¿Está seguro que desea Actualizar el Control {0}?", row[0].ToString()), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (cbControlRela.EditValue != null && cbControlRela.EditValue.ToString() != "-1")
                            idControlRe = Convert.ToInt64(cbControlRela.EditValue);

                        int? pOk = 0;
                        this.spSoloRespuesta1.stpFactUpdActualizarControles(Convert.ToInt64(row[0].ToString()), idControlRe, txtObservaciones.Text, OperadorBD.OperadorGlobal.NombreUsuario, ref pOk);
                        if (pOk == 1)
                        {
                            XtraMessageBox.Show("!El Control se Actualizo Correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            XtraMessageBox.Show("¡Error al Actualizar el Control, intentelo mas tarde!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        Actualizar();
                        Limpiar();
                    }
                }
                else
                {
                    XtraMessageBox.Show("¡Debe de Seleccionar un Control!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //Activar Botones
                ActivarBotonesC(false, false, false, 35, false, false);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSolicitarPago_Click(object sender, EventArgs e)
        {
            try
            {
                string sRespuesta = "";
                //obtener el renglon completo del Combobox
                DataRow row = gridLookUpEdit1View.GetDataRow(gridLookUpEdit1View.FocusedRowHandle);

                if (row != null)
                {
                    if (XtraMessageBox.Show(String.Format("¿Está seguro que desea Solicitar la Solicitud de Pago del Control No. {0}?", row[0].ToString()), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        ControlOperaciones.frmxSolicitudPago objPantalla = new ControlOperaciones.frmxSolicitudPago()
                        {
                            IdControl = (long)row[0],
                            Actualizar = false,
                            TipoNomina = txtTipoNomina.Text
                        };
                        objPantalla.ShowDialog();

                        if (objPantalla.Actualizar || sRespuesta != "")
                        {
                            Actualizar();
                            Limpiar();
                        }
                    }
                }
                else
                {
                    //Activar Botones
                    XtraMessageBox.Show("¡Debe de Seleccionar un Control!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            string FIni = Convert.ToDateTime(dtFechaIni.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Day.ToString();
            string FFin = Convert.ToDateTime(dtFechaFin.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Day.ToString();
            Actualizar();
        }

        private void btnEliminarFiltro_Click(object sender, EventArgs e)
        {
            dtFechaIni.Value = DateTime.Now.AddDays(-30);
            dtFechaFin.Value = DateTime.Now;

            string FIni = Convert.ToDateTime(dtFechaIni.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Day.ToString();
            string FFin = Convert.ToDateTime(dtFechaFin.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Day.ToString();
            Actualizar();
        }

        private void Actualizar()
        {
            try
            {
                string FIni = Convert.ToDateTime(dtFechaIni.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Day.ToString();
                string FFin = Convert.ToDateTime(dtFechaFin.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Day.ToString();

                this.stpFactSelControlOperacionesV2TableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelControlOperacionesV2, -1, -1, -1, -1, -1, OperadorBD.OperadorGlobal.IdOperador, false, FIni, FFin);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sidePanel2_Click(object sender, EventArgs e)
        {

        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            try
            {

                DateTime dtFechaDePago;
                //obtener el renglon completo del Combobox
                DataRow row = gridLookUpEdit1View.GetDataRow(gridLookUpEdit1View.FocusedRowHandle);

                if (row != null)
                {
                    if (AutorizacionBloquearTesoreria)
                    {
                        //Solicitar Fecha de Pago
                        dtFechaDePago = solicitarFechaDePago();

                        if (dtFechaDePago.ToShortDateString().ToString() != "01/01/1900")
                        {
                            string pOk = "";
                            this.spSoloRespuesta1.stpFactUpdBloquearControlesTesoreria(Convert.ToInt64(row[0].ToString()), true, OperadorBD.OperadorGlobal.NombreUsuario, string.Format("{0:yyyy-MM-dd}", dtFechaDePago), ref pOk);

                            //DSC - 20230731***********************                            
                            //**********Cerrar Control*************
                            //*************************************
                            stpControlCerradoCountTableAdapter1.Fill(dbSAICBPOFactura.stpControlCerradoCount, Convert.ToInt64(row[0].ToString()));
                            int iControlCerrado = 0;
                            int.TryParse(dbSAICBPOFactura.stpControlCerradoCount.Rows[0]["ControlCerradoCount"].ToString(), out iControlCerrado);

                            if (iControlCerrado == 0)
                            {
                                String pRespuesta = String.Empty;
                                this.spSoloRespuesta1.stpFactUpdBloquearControlesV2(Convert.ToInt64(row[0].ToString()), true, Convert.ToInt16(dtFechaDePago.Year.ToString()), Convert.ToByte(dtFechaDePago.Month.ToString()),
                                                                                        String.Empty, OperadorBD.OperadorGlobal.NombreOperador, ref pRespuesta);

                                if (pRespuesta.Length > 0)
                                    pRespuesta = Environment.NewLine + "Cerrar Control: " + pRespuesta;
                                else
                                    pRespuesta = Environment.NewLine + "Cerrar Control: Error el Cerrar Control";

                                pOk = pOk + pRespuesta;
                            }

                            //*************************************
                            //**********Cerrar Control*************
                            //*************************************

                            XtraMessageBox.Show(pOk, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Actualizar();
                            Limpiar();
                        }
                        else
                        {
                            if (splashSMCargando.IsSplashFormVisible) { splashSMCargando.CloseWaitForm(); }
                            XtraMessageBox.Show("Control" + Environment.NewLine + Environment.NewLine + "No se selecciono una Fecha de Pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show("¡Debe de Seleccionar un Control!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnPagoEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                //obtener el renglon completo del Combobox
                DataRow row = gridLookUpEdit1View.GetDataRow(gridLookUpEdit1View.FocusedRowHandle);

                if (row != null)
                {
                    if (AutorizacionBloquearTesoreria)
                    {
                        if (XtraMessageBox.Show(String.Format("¿Está seguro que desea Abrir el Control {0}?", row[0].ToString()), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                        {
                            string pOk = "";
                            this.spSoloRespuesta1.stpFactUpdBloquearControlesTesoreria(Convert.ToInt64(row[0].ToString()), false, OperadorBD.OperadorGlobal.NombreUsuario, "1900-01-01", ref pOk);

                            XtraMessageBox.Show(pOk, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Actualizar();
                            Limpiar();
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show("¡Debe de Seleccionar un Control!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Seleccion de fecha de pago para el Lote
        /// </summary>
        /// <returns></returns>
        private DateTime solicitarFechaDePago()
        {
            DateTime dtFechaSeleccionada;
            using (var form = new tools.xFormsSolicitarFecha("Fecha de Pago", "Confirmar Fecha de Pago", "Seleccione Fecha de Pago:"))
            {
                //Point temp = new Point();
                //Point location = new Point(temp.Y + this.Width / 2,
                //                           temp.X + this.Height / 2);
                //form.Location = location;
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    dtFechaSeleccionada = form.dtFechaSeleccionada;
                }
                else
                {
                    dtFechaSeleccionada = new DateTime(1900, 01, 01);
                }
            }
            return dtFechaSeleccionada;
        }

        private void btnAutControl_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dtFechaDePago;
                //obtener el renglon completo del Combobox
                DataRow row = gridLookUpEdit1View.GetDataRow(gridLookUpEdit1View.FocusedRowHandle);

                if (row != null)
                {
                    if (AutorizacionBloquearOperaciones)
                    {
                        //Solicitar Fecha de Pago
                        //dtFechaDePago = solicitarFechaDePago();

                        //if (dtFechaDePago.ToShortDateString().ToString() != "01/01/1900")
                        //{
                        string pOk = "";
                        this.spSoloRespuesta1.stpFactUpdAutorizarControlesTesoreria(Convert.ToInt64(row[0].ToString()), true, OperadorBD.OperadorGlobal.NombreUsuario, "", ref pOk);

                        XtraMessageBox.Show(pOk, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Actualizar();
                        Limpiar();
                        //}
                        //else
                        //{
                        //    if (splashSMCargando.IsSplashFormVisible) { splashSMCargando.CloseWaitForm(); }
                        //    XtraMessageBox.Show("Control" + Environment.NewLine + Environment.NewLine + "No se selecciono una Fecha de Pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //}
                    }
                }
                else
                {
                    XtraMessageBox.Show("¡Debe de Seleccionar un Control!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEAutControl_Click(object sender, EventArgs e)
        {

            try
            {
                //obtener el renglon completo del Combobox
                DataRow row = gridLookUpEdit1View.GetDataRow(gridLookUpEdit1View.FocusedRowHandle);

                if (row != null)
                {
                    if (AutorizacionBloquearOperaciones)
                    {
                        if (XtraMessageBox.Show(String.Format("¿Está seguro que desea Eliminar la Autorizaión del Control {0}?", row[0].ToString()), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                        {
                            string pOk = "";
                            this.spSoloRespuesta1.stpFactUpdAutorizarControlesTesoreria(Convert.ToInt64(row[0].ToString()), false, OperadorBD.OperadorGlobal.NombreUsuario, "1900-01-01", ref pOk);

                            XtraMessageBox.Show(pOk, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Actualizar();
                            Limpiar();
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show("¡Debe de Seleccionar un Control!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
