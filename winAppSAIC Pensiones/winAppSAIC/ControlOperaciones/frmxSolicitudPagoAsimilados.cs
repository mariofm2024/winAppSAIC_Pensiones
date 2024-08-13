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
    public partial class frmxSolicitudPagoAsimilados : DevExpress.XtraEditors.XtraForm
    {

        public long IdControlA;
        public bool Actualizar;
        public string TipoNomina = "";
        decimal TotalSolicitud = 0;
        int TipoSA = 0;
        int TipoSC = 0;
        string pTipo = "";
        string pTipoN = "";
        string Banco = "";
        public DataTable dt = new DataTable();

        public Boolean flagControlConIAS = false;

        public frmxSolicitudPagoAsimilados()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            this.stpTesSelLayoutBancoFormatoPorBancoTableAdapter.Fill(dbSAICAsimilados.stpTesSelLayoutBancoFormatoPorBanco, "");
            txtEmisora.Text = "";
        }

        private void frmxSolicitudPagoAsimilados_Load(object sender, EventArgs e)
        {
            try
            {
                groupControlIAS.Visible = flagControlConIAS;

                txtIdControl.Text = IdControlA.ToString();
                this.stpFactSelDetailCOSolicitudPagoTableAdapter.Fill(this.dbSAICAsimilados.stpFactSelDetailCOSolicitudPago, IdControlA);
                if (this.dbSAICAsimilados.stpFactSelDetailCOSolicitudPago.Count >= 0)
                    CrearTabla();  //Crear Tabla de Transferencias                
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
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
                                dr["colIdTenedoraPF"] = Convert.ToInt32(row[11]);

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
            dt.Columns.Add("colIdTenedoraPF", typeof(Int32));
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
                Int64? pIdLeyoutPago = 0;
                Int64? pIdLeyoutPagoSA = 0;
                Int64? pIdLeyoutPagoSC = 0;
                Int64? pIdDetailLeyoutPago = 0;
                string Tipo = "O";
                string sRespuesta = "";
                Total();

                if (dt.Rows.Count == gvTransferencias.RowCount && gvTransferencias.RowCount > 0)
                {
                    Close();
                }
                else
                {
                    XtraMessageBox.Show("¡No Todos los layout han sido cargados!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                this.stpTesSelLayoutBancoFormatoPorBancoTableAdapter.Fill(dbSAICAsimilados.stpTesSelLayoutBancoFormatoPorBanco, Banco);

                ActivarControlEmisora(Banco);        //activar o desactivar control txtEmisora para banorte

                //Obtener Emisora de BAnorte
                if (Banco.Contains("BANORTE"))
                {
                    try
                    {

                        if (IdTenedora > 0)
                        {
                            String stEmision = "00000";
                            queriesAsimilados1.stpSelTenedoraEmisoraBanorte(IdTenedora,Banco, ref stEmision);
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
    }
}