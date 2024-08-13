using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using winAppSAIC.UtileriasLocal;
using compCatalogosSAIC;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;


namespace winAppSAIC.Catalogos
{
    public partial class frmxPeriodosCliente : Form
    {
        public frmxPeriodosCliente()
        {
            InitializeComponent();
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmxPeriodosCliente_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.PeriodoCliente' table. You can move, or remove it, as needed.
                this.periodoClienteTableAdapter.Fill(this.dbSAIC_Catalogos.PeriodoCliente);
                // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwFactBeneficiarioCliente' table. You can move, or remove it, as needed.
                this.vwFactBeneficiarioClienteTableAdapter.Fill(this.dbSAICBPOFactura.vwFactBeneficiarioCliente);

                this.stpFactSelTipoPeriodoNominaTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelTipoPeriodoNomina, 2);

                txtAnoFiscal.Text = DateTime.Now.Year.ToString();

                // Set column widths according to their contents. 
                cboIdClienteProveedor.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cboIdClienteProveedor.Properties.PopupFormWidth = 800;

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                Int64? vId = 0;
                string FFin, FIni, FPago;

                if (Validator.IsPresent(cboIdClienteProveedor) && Validator.IsPresent(cbTipoPeriodo) &&
                    Validator.IsPositiveNumber(txtAnoFiscal) && Validator.IsPositiveNumber(txtNoPeriodo))
                {
                    FIni = dtFechaInicio.Value.Year.ToString() + "-" + dtFechaInicio.Value.Month.ToString() + "-" + dtFechaInicio.Value.Day.ToString();
                    FFin = dtFechaFin.Value.Year.ToString() + "-" + dtFechaFin.Value.Month.ToString() + "-" + dtFechaFin.Value.Day.ToString();
                    FPago = dtFechaPago.Value.Year.ToString() + "-" + dtFechaPago.Value.Month.ToString() + "-" + dtFechaPago.Value.Day.ToString();

                    this.periodoClienteTableAdapter.stpInsPeriodoCliente(Convert.ToInt32(cboIdClienteProveedor.EditValue), Convert.ToInt16(cbTipoPeriodo.EditValue),
                                                                         FIni, FFin, FPago, Convert.ToInt32(txtAnoFiscal.Text.Replace(",", "").Replace(".", "")),
                                                                         Convert.ToBoolean(chePPeriodos.Checked),
                                                                         Convert.ToInt32(txtNoPeriodo.Text.Replace(",", "").Replace(".", "")),
                                                                         Convert.ToInt32(txtNodiaPago.Text.Replace(",", "").Replace(".", "")),
                                                                         OperadorBD.OperadorGlobal.NombreUsuario, ref vId);

                    if (vId > 0)
                        XtraMessageBox.Show("¡El o los Periodos se generaron correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (vId == -1)
                        XtraMessageBox.Show("¡Ya existe(n) el (los) Periodo(s)!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("¡Error en Conexión Intente más tarde!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    this.periodoClienteTableAdapter.Fill(this.dbSAIC_Catalogos.PeriodoCliente);

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chePPeriodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chePPeriodos.Checked)
            {
                txtNoPeriodo.Value = 1;
                txtNoPeriodo.ReadOnly = true;
            }
            else
                txtNoPeriodo.ReadOnly = false;
        }

        private void cboIdClienteProveedor_EditValueChanged(object sender, EventArgs e)
        {
            gridView1.ActiveFilter.Clear();

            ColumnView view = gridView1;
            ViewColumnFilterInfo viewFilterInfo = new ViewColumnFilterInfo(view.Columns["IdCliente"],
            new ColumnFilterInfo("[IdCliente] = " + cboIdClienteProveedor.EditValue.ToString(), ""));
            gridView1.ActiveFilter.Add(viewFilterInfo);

            ActivarBotones(true);
        }

        private void ActivarBotones(bool bFlag)
        {
            btnActualizar.Enabled = !bFlag;
            btnCancelar.Visible = !bFlag;
            btnBorrar.Enabled = !bFlag;
            btnCargar.Enabled = bFlag;
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Int32? pOk = 0;
                string FFin, FIni, FPago;

                if (lblIdPeriodo.Text != "0.")
                {
                    FIni = dtFechaInicio.Value.Year.ToString() + "-" + dtFechaInicio.Value.Month.ToString() + "-" + dtFechaInicio.Value.Day.ToString();
                    FFin = dtFechaFin.Value.Year.ToString() + "-" + dtFechaFin.Value.Month.ToString() + "-" + dtFechaFin.Value.Day.ToString();
                    FPago = dtFechaPago.Value.Year.ToString() + "-" + dtFechaPago.Value.Month.ToString() + "-" + dtFechaPago.Value.Day.ToString();

                    this.periodoClienteTableAdapter.stpUpdPeriodoCliente(Convert.ToInt64(lblIdPeriodo.Text.Replace(",", "").Replace(".", "")), FIni, FFin, FPago, OperadorBD.OperadorGlobal.NombreUsuario, ref pOk);

                    if (pOk > 0)
                    {
                        XtraMessageBox.Show("¡El Periodo se actualizo correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblIdPeriodo.Text = "0";
                        ActivarBotones(true);
                    }
                    else
                        XtraMessageBox.Show("¡Error en Conexión Intente más tarde!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    this.periodoClienteTableAdapter.Fill(this.dbSAIC_Catalogos.PeriodoCliente);

                }
                else
                    XtraMessageBox.Show("¡Debe de Seleccionar un Periodo!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                Int32? pOk = 0;
                if (Validator.IsPresent(cboIdClienteProveedor) && Validator.IsPresent(cbTipoPeriodo) &&
                    Validator.IsPositiveNumber(txtAnoFiscal))
                {

                    this.periodoClienteTableAdapter.stpDelPeriodoCliente(Convert.ToInt64(cboIdClienteProveedor.EditValue), Convert.ToInt32(txtAnoFiscal.EditValue),
                                                                            Convert.ToInt16(cbTipoPeriodo.EditValue), OperadorBD.OperadorGlobal.NombreUsuario, ref pOk);

                    if (pOk > 0)
                    {
                        XtraMessageBox.Show("¡El Periodo se Elimino correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblIdPeriodo.Text = "0";
                    }
                    else
                        XtraMessageBox.Show("¡Error en Conexión Intente más tarde!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    this.periodoClienteTableAdapter.Fill(this.dbSAIC_Catalogos.PeriodoCliente);

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridPeriodoCliente_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.FocusedRowHandle >= 0)
                {
                    //obtener la información del renglon completo
                    DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);

                    lblIdPeriodo.Text = row[0].ToString();
                    cboIdClienteProveedor.EditValue = row[1].ToString();
                    cbTipoPeriodo.EditValue = row[4].ToString();
                    txtNoPeriodo.Text = row[6].ToString();
                    dtFechaInicio.Text = row[7].ToString();
                    dtFechaFin.Text = row[8].ToString();
                    dtFechaPago.Text = row[15].ToString();
                    txtAnoFiscal.Text = row[9].ToString();
                    chePPeriodos.Checked = false;

                    ActivarBotones(false);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                ActivarBotones(true);
                lblIdPeriodo.Text = "0";
                cboIdClienteProveedor.EditValue = -1;
                cbTipoPeriodo.EditValue = -1;
                txtAnoFiscal.Text = DateTime.Now.Year.ToString();

                gridView1.ActiveFilter.Clear();

                // TODO: This line of code loads data into the 'dbSAIC_Catalogos.PeriodoCliente' table. You can move, or remove it, as needed.
                this.periodoClienteTableAdapter.Fill(this.dbSAIC_Catalogos.PeriodoCliente);
            }

            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
