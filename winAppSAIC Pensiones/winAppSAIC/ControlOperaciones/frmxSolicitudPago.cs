using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using winAppSAIC.Tesoreria;
using winAppSAIC.UtileriasLocal;
using compCatalogosSAIC;

namespace winAppSAIC.ControlOperaciones
{
    public partial class frmxSolicitudPago : DevExpress.XtraEditors.XtraForm
    {

        public long IdControl;
        public bool Actualizar;
        public string TipoNomina = "";
        decimal TotalSolicitud = 0;
        int TipoSA = 0;
        int TipoSC = 0;
        string pTipo = "";
        string pTipoN = "";
        string Banco = "";
        DataTable dt = new DataTable();
        DataTable dtAsimilados = new DataTable();

        public Boolean flagControlConIAS = false;

        public frmxSolicitudPago()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            this.stpTesSelLayoutBancoFormatoPorBancoTableAdapter.Fill(dbSAICBPOTesoreriaDataSet.stpTesSelLayoutBancoFormatoPorBanco, "");
            txtEmisora.Text = "";
        }

        private void frmxSolicitudPago_Load(object sender, EventArgs e)
        {
            try
            {
                groupControlIAS.Visible = flagControlConIAS;

                txtIdControl.Text = IdControl.ToString();
                this.stpFactSelDetailCOSolicitudPagoTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.stpFactSelDetailCOSolicitudPago, IdControl);
                this.stpFactSelDetailCOSolicitudPagoTableAdapter1.Fill(this.dbSAICAsimilados.stpFactSelDetailCOSolicitudPago, IdControl);
                if (this.dbSAICBPOTesoreriaDataSet.stpFactSelDetailCOSolicitudPago.Count >= 0)
                    CrearTabla();  //Crear Tabla de Transferencias                
                else
                {
                    XtraMessageBox.Show("¡El Control no tiene Solicitudes de Pago que realizar!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }

                if (this.dbSAICAsimilados.stpFactSelDetailCOSolicitudPago.Count >= 0)
                {
                    CrearTablaASimilados();  //Crear Tabla de Transferencias 
                    btnAsimilados.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvTransferencias.RowCount == 0)
                Actualizar = true;
            Close();
        }

        private void dgvLotes_DoubleClick(object sender, EventArgs e)
        {
            Int32 IdTenedora = 0;
            Int64 IdLOTE = 0;
            DataRow row = null;
            try
            {
                row = gvTransferencias.GetDataRow(gvTransferencias.FocusedRowHandle);
                Banco = row[7].ToString();
                IdTenedora = Convert.ToInt32(row[3]);
                IdLOTE = Convert.ToInt32(row[1]);
                pTipo = row[10].ToString();
                pTipoN = row[9].ToString();
                //obtener los formatos del banco seleccionado previamente
                this.stpTesSelLayoutBancoFormatoPorBancoTableAdapter.Fill(dbSAICBPOTesoreriaDataSet.stpTesSelLayoutBancoFormatoPorBanco, Banco);

                ActivarControlEmisora(Banco);        //activar o desactivar control txtEmisora para banorte

                //Obtener Emisora de BAnorte
                if (Banco.Contains("BANORTE"))
                {
                    try
                    {

                        if (IdTenedora > 0)
                        {
                            String stEmision = "00000";
                            stpUpdAutorizacionNominaTableAdapter1.stpSelTenedoraEmisoraBanorte(IdTenedora, ref stEmision);
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
                    txtEmisora.Text = "00000";
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Método que bloquea o desbloquea el textbox Emisora
        /// </summary>
        private void ActivarControlEmisora(string IdBanco)
        {
            if (IdBanco == "BANORTE")
                txtEmisora.Enabled = false;
            else
                txtEmisora.Enabled = false;

            txtEmisora.Text = "00000";       //inicializar control
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                DataRow row = null;
                DataRow row1 = null;
                bool bAgregar = false;
                bool bLayout = true;

                row = gvTransferencias.GetDataRow(gvTransferencias.FocusedRowHandle);
                if (row != null)
                {
                    if (Banco != "CI BANCO" && Banco != "BANAMEX")
                    {
                        if (pTipo.Contains("INTER"))
                        {
                            if (!cboFormatoBanco.Text.Contains("INTER"))
                            {
                                if (XtraMessageBox.Show(String.Format("El Formato de Layout es diferente,\nEl número de Empleados por layout será DIFERENTE\n¿Estás seguro de Continuar?", row[0].ToString()), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                                {
                                    bLayout = true;
                                }
                                else
                                {
                                    bLayout = false;
                                }
                            }
                            else
                                bLayout = true;
                        }
                        else if (cboFormatoBanco.Text.Contains("INTER"))
                        {
                            if (XtraMessageBox.Show(String.Format("El Formato de Layout es diferente,\nEl número de Empleados por layout será DIFERENTE\n¿Estás seguro de Continuar?", row[0].ToString()), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                            {
                                bLayout = true;
                            }
                            else
                            {
                                bLayout = false;
                            }
                        }
                        else
                            bLayout = true;
                    }
                    else
                        bLayout = true;

                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            row1 = dt.Rows[i];
                            if (Convert.ToInt32(row1[0]) == gvTransferencias.FocusedRowHandle)
                            {
                                bAgregar = true;
                                break;
                            }
                            else
                                bAgregar = false;
                        }
                    }
                    else
                        bAgregar = false;

                    if (bLayout)
                    {
                        if (!bAgregar)
                        {
                            //obtener No. de Version CFDI
                            if (Validator.IsPresent(cboFormatoBanco) && Validator.IsPositiveOrZeroNumber(txtEmisora))
                            {
                                DataRow dr = dt.NewRow();
                                dr["colIdTabla"] = Convert.ToInt64(gvTransferencias.FocusedRowHandle);
                                dr["colIdLote"] = Convert.ToInt64(row[1]);
                                dr["colTenedora"] = row[4];
                                dr["colIdTenedora"] = Convert.ToInt32(row[3]);
                                dr["colBancoOrigen"] = row[7];
                                dr["colFormato"] = cboFormatoBanco.Text;
                                dr["colIdFormato"] = Convert.ToInt32(cboFormatoBanco.SelectedValue);
                                dr["colEmisora"] = txtEmisora.Text;
                                dr["colFecha"] = dpFechaPago.Value.ToString("yyyy-MM-dd");
                                dr["colTotalPagar"] = Convert.ToDecimal(row[6]);
                                dr["colNoEmpleados"] = Convert.ToInt32(row[8]);
                                dr["colTipo"] = row[9];

                                dt.Rows.Add(dr);
                                dgvTransferencias.DataSource = dt;
                                Total();
                                Limpiar();
                            }
                        }
                        else
                            XtraMessageBox.Show("¡Ya existe dispersión cargada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    XtraMessageBox.Show("¡Debe de Seleccionar por lo menos una dispersión!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Total()
        {
            try
            {
                TotalSolicitud = 0;
                TipoSA = 0;
                TipoSC = 0;
                //obtener el No. de Items seleccionados
                DataRow row = null;
                if (gvTransferencias.RowCount > 0)
                {
                    for (int i = 0; i < gvTransferencias.RowCount; i++) //foreach (int indice in gvTransferencias.GetSelectedRows())
                    {
                        row = gvTransferencias.GetDataRow(i);
                        TotalSolicitud = Math.Round(TotalSolicitud + Convert.ToDecimal(row[6].ToString()), 2);
                        if (row[9].ToString() == "S")
                            TipoSA = TipoSA + 1;
                        else
                            TipoSC = TipoSC + 1;
                    }
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Metodo que nos Crea Tablas para las Transacciones
        /// </summary>
        private void CrearTabla()
        {
            dt = new DataTable();
            dt.TableName = "Transacciones";
            dt.Columns.Add("colIdTabla", typeof(Int64));
            dt.Columns.Add("colIdLote", typeof(Int64));
            dt.Columns.Add("colTenedora", typeof(String));
            dt.Columns.Add("colIdTenedora", typeof(Int32));
            dt.Columns.Add("colBancoOrigen", typeof(String));
            dt.Columns.Add("colFormato", typeof(String));
            dt.Columns.Add("colIdFormato", typeof(Int32));
            dt.Columns.Add("colEmisora", typeof(String));
            dt.Columns.Add("colFecha", typeof(String));
            dt.Columns.Add("colTotalPagar", typeof(Decimal));
            dt.Columns.Add("colNoEmpleados", typeof(Int32));
            dt.Columns.Add("colTipo", typeof(String));
        }

        public void CrearTablaASimilados()
        {
            dtAsimilados = new DataTable();
            dtAsimilados.TableName = "Transacciones";
            dtAsimilados.Columns.Add("colIdTabla", typeof(Int64));
            dtAsimilados.Columns.Add("colIdLote", typeof(Int64));
            dtAsimilados.Columns.Add("colTenedora", typeof(String));
            dtAsimilados.Columns.Add("colIdTenedora", typeof(Int32));
            dtAsimilados.Columns.Add("colBancoOrigen", typeof(String));
            dtAsimilados.Columns.Add("colFormato", typeof(String));
            dtAsimilados.Columns.Add("colIdFormato", typeof(Int32));
            dtAsimilados.Columns.Add("colEmisora", typeof(String));
            dtAsimilados.Columns.Add("colFecha", typeof(String));
            dtAsimilados.Columns.Add("colTotalPagar", typeof(Decimal));
            dtAsimilados.Columns.Add("colNoEmpleados", typeof(Int32));
            dtAsimilados.Columns.Add("colTipo", typeof(String));
            dtAsimilados.Columns.Add("colIdTenedoraPF", typeof(Int32));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvtransaccion.GetSelectedRows().Count() > 0)
                {
                    gvtransaccion.DeleteSelectedRows();
                }
                else
                    XtraMessageBox.Show("¡Debe de Seleccionar por lo menos un Concepto!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSolicitarPagar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DataRow row1 = null;
                int CountLe = 0;
                bool pflag = false;
                Int64? pIdLeyoutPago = 0;
                Int64? pIdLeyoutPagoSA = 0;
                Int64? pIdLeyoutPagoSC = 0;
                Int64? pIdDetailLeyoutPago = 0;
                string Tipo = "O";
                string sRespuesta = "";
                Total();


                if (btnAsimilados.Enabled)
                {
                    if (dtAsimilados.Rows.Count == this.dbSAICAsimilados.stpFactSelDetailCOSolicitudPago.Count)
                    {
                        pflag = true;
                    }
                    else
                        pflag = false;
                }
                else
                    pflag = true;

                if (pflag)
                {
                    if (dt.Rows.Count == gvTransferencias.RowCount && gvTransferencias.RowCount > 0)
                    {
                        this.respuestasTesoreria1.stpTesInsSolicitudPago(IdControl, OperadorBD.OperadorGlobal.NombreUsuario, ref sRespuesta);

                        if (sRespuesta.Contains("EL Control No."))
                        {
                            XtraMessageBox.Show(sRespuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                row1 = dt.Rows[i];

                                this.respuestasTesoreria1.stpTesInsSolicitudPagoDetail(Convert.ToInt64(sRespuesta), Convert.ToInt64(row1[1]), Convert.ToInt32(row1[3]),
                                                                      row1[4].ToString(), Convert.ToInt16(row1[6]), row1[7].ToString(), row1[8].ToString(),
                                                                      Convert.ToDecimal(row1[9].ToString()), Convert.ToInt32(row1[10]), OperadorBD.OperadorGlobal.IdOperador, OperadorBD.OperadorGlobal.NombreUsuario,
                                                                      ref pIdDetailLeyoutPago);
                                if (pIdDetailLeyoutPago > 0)
                                    CountLe = CountLe + 1;

                            }

                            if (dt.Rows.Count == CountLe)
                            {
                                CountLe = 0;
                                for (int i = 0; i < dtAsimilados.Rows.Count; i++)
                                {
                                    row1 = dtAsimilados.Rows[i];

                                    this.queriesAsimilados1.stpTesInsSolicitudPagoDetail(Convert.ToInt64(sRespuesta), Convert.ToInt64(row1[1]), Convert.ToInt32(row1[3]),
                                                                          row1[4].ToString(), Convert.ToInt16(row1[6]), row1[7].ToString(), row1[8].ToString(),
                                                                          Convert.ToDecimal(row1[9].ToString()), Convert.ToInt32(row1[10]), OperadorBD.OperadorGlobal.IdOperador, OperadorBD.OperadorGlobal.NombreUsuario,
                                                                          ref pIdDetailLeyoutPago);

                                    if (pIdDetailLeyoutPago > 0)
                                        this.respuestasTesoreria1.stpTesInsSolicitudPagoDetailASIMILADOS(Convert.ToInt64(sRespuesta), Convert.ToInt64(row1[1]), Convert.ToInt32(row1[12]),row1[4].ToString(),
                                                                           Convert.ToInt16(row1[6]), row1[7].ToString(), row1[8].ToString(), Convert.ToDecimal(row1[9].ToString()), Convert.ToInt32(row1[10]), 
                                                                           OperadorBD.OperadorGlobal.IdOperador, OperadorBD.OperadorGlobal.NombreUsuario,
                                                                         ref pIdDetailLeyoutPago);

                                    if (pIdDetailLeyoutPago > 0)
                                        CountLe = CountLe + 1;

                                }

                                if (dtAsimilados.Rows.Count == CountLe)
                                {
                                    XtraMessageBox.Show("¡La solicitud de Pago fue exitosa!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Actualizar = true;
                                    Close();
                                }
                            }
                            else
                            {
                                spSoloRespuesta1.stpTesUpdSolicitudPago(Convert.ToInt64(sRespuesta), 23,"Error al dar de alta El detalle", OperadorBD.OperadorGlobal.NombreUsuario, ref sRespuesta);

                                XtraMessageBox.Show("¡Error al insertar el detalle de Pago PF, Intente nuevamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }

                        }
                    }
                    else
                    {
                        if (gvTransferencias.RowCount == 0)
                        {
                            this.respuestasTesoreria1.stpTesInsSolicitudPago(IdControl, OperadorBD.OperadorGlobal.NombreUsuario, ref sRespuesta);

                            if (sRespuesta.Contains("EL Control No."))
                            {
                                XtraMessageBox.Show(sRespuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if (dtAsimilados.Rows.Count >0)
                                {
                                    CountLe = 0;
                                    for (int i = 0; i < dtAsimilados.Rows.Count; i++)
                                    {
                                        row1 = dtAsimilados.Rows[i];

                                        this.queriesAsimilados1.stpTesInsSolicitudPagoDetail(Convert.ToInt64(sRespuesta), Convert.ToInt64(row1[1]), Convert.ToInt32(row1[3]),
                                                                              row1[4].ToString(), Convert.ToInt16(row1[6]), row1[7].ToString(), row1[8].ToString(),
                                                                              Convert.ToDecimal(row1[9].ToString()), Convert.ToInt32(row1[10]), OperadorBD.OperadorGlobal.IdOperador, OperadorBD.OperadorGlobal.NombreUsuario,
                                                                              ref pIdDetailLeyoutPago);


                                        if (pIdDetailLeyoutPago > 0)
                                            this.respuestasTesoreria1.stpTesInsSolicitudPagoDetailASIMILADOS(Convert.ToInt64(sRespuesta), Convert.ToInt64(row1[1]), Convert.ToInt32(row1[12]),
                                                                             row1[4].ToString(), Convert.ToInt16(row1[6]), row1[7].ToString(), row1[8].ToString(),
                                                                             Convert.ToDecimal(row1[9].ToString()), Convert.ToInt32(row1[10]), OperadorBD.OperadorGlobal.IdOperador, OperadorBD.OperadorGlobal.NombreUsuario,
                                                                             ref pIdDetailLeyoutPago);
                                        if (pIdDetailLeyoutPago > 0)
                                            CountLe = CountLe + 1;

                                    }

                                    if (dtAsimilados.Rows.Count == CountLe)
                                    {
                                        XtraMessageBox.Show("¡La solicitud de Pago fue exitosa!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Actualizar = true;
                                        Close();
                                    }
                                    else
                                        XtraMessageBox.Show("¡Error en conexión, Intente más tarde!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    XtraMessageBox.Show("¡La solicitud de Pago fue exitosa!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Actualizar = true;
                                    Close();
                                }
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show("¡No Todos los layout han sido cargados!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                    XtraMessageBox.Show("¡No ha cargado los layout de Asimilados !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAsimilados_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ControlOperaciones.frmxSolicitudPagoAsimilados objPantalla = new ControlOperaciones.frmxSolicitudPagoAsimilados()
            {
                IdControlA = IdControl
            };
            objPantalla.ShowDialog();

            dtAsimilados = objPantalla.dt;
        }
    }
}