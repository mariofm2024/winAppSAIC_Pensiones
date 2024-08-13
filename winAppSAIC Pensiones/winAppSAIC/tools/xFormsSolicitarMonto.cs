using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace winAppSAIC.tools
{
    public partial class xFormsSolicitarMonto : DevExpress.XtraEditors.XtraForm
    {

        public Decimal dcImporte { get; set; }
        public Decimal dcImporteSA { get; set; }
        public Decimal dcImporteSC { get; set; }
        public Boolean ConImporte { get; set; }
        public int idFirmanteCarta { get; set; }
        public int idTenedoraSC { get; set; }

        String stTitulo;
        Boolean flagCartaConImporte;
        Boolean conTenedoraSC;
        int idTipoCarta;
        public xFormsSolicitarMonto(String stTitulo, Boolean flagCartaConImporte, Boolean conTenedoraSC, int idTipoCarta)
        {
            InitializeComponent();
            this.stTitulo = stTitulo;
            this.flagCartaConImporte = flagCartaConImporte;
            this.conTenedoraSC = conTenedoraSC;
            this.idTipoCarta = idTipoCarta;
            habilitarBotones();
        }

        private void habilitarBotones()
        {
            if (!flagCartaConImporte)
            {
                rdSinImporte.Checked = true;
                rdConImporte.Enabled = false;
                seImporte.Enabled = false;
            }

            if (!conTenedoraSC)
            {
                UpEditTenedoraSC.Enabled = false;
            }

            if (idTipoCarta == 1)
            {
                rdSinImporte.Checked = false;
                rdConImporte.Checked = true;
            }

            if (idTipoCarta == 3)
            {
                seImporteSA.Enabled = true;
                seImporteSC.Enabled = true;
            }
            else
            {
                seImporteSA.Enabled = false;
                seImporteSC.Enabled = false;
            }

            if (idTipoCarta == 7)
            {
                rdConImporte.Checked = true;
                rdSinImporte.Enabled = false;
            }
        }

        private void rdConImporte_CheckedChanged(object sender, EventArgs e)
        {
            if (rdConImporte.Checked && idTipoCarta != 1)
            {
                seImporte.Enabled = true;
            }
            else if (rdConImporte.Checked && idTipoCarta == 1)
            {
                seImporteSA.Enabled = true;
                seImporteSC.Enabled = true;
            }
        }

        private void rdSinImporte_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSinImporte.Checked)
            {
                seImporte.Enabled = false;
                seImporte.Value = 0.00M;
                lblImporteLetra.Text = String.Empty;
            }
            else if (rdSinImporte.Checked && idTipoCarta == 1)
            {
                seImporteSA.Enabled = false;
                seImporteSC.Enabled = false;
            }

        }
        private void lnlImporteLetra_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = stTitulo;
            stpSelFirmanteCartasTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelFirmanteCartas, stTitulo);
            stpSelObtenerInfoGenericaTenedoraSC_1TableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoGenericaTenedoraSC_1, 0, false);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (gridLookUpFirmanteCartas.EditValue != null)
            {
                int idFirmante;
                int idTenedoraSC1;

                if (UpEditTenedoraSC.EditValue == null) { UpEditTenedoraSC.EditValue = 0; }

                int.TryParse(UpEditTenedoraSC.EditValue.ToString(), out idTenedoraSC1);

                int.TryParse(gridLookUpFirmanteCartas.EditValue.ToString(), out idFirmante);
                if (idFirmante > 0)
                {
                    DialogResult resultado = XtraMessageBox.Show("¿Esta correcta la información de la " + stTitulo + "?", "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (DialogResult.Yes == resultado)
                    {
                        dcImporte = seImporte.Value;
                        ConImporte = rdConImporte.Checked;
                        idFirmanteCarta = idFirmante;
                        idTenedoraSC = idTenedoraSC1;

                        dcImporteSA = seImporteSA.Value;
                        dcImporteSC = seImporteSC.Value;

                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        DialogResult = DialogResult.Cancel;
                        Close();
                    }
                }
                else
                {
                    XtraMessageBox.Show("Seleccione un firmante para la Carta",
                        "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gridLookUpFirmanteCartas.Focus();
                }
            }
            else
            {
                XtraMessageBox.Show("Seleccione un firmante para la Carta",
                      "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gridLookUpFirmanteCartas.Focus();
            }
        }

        private void seImporte_EditValueChanged(object sender, EventArgs e)
        {
            var query = queriesTableAdapter1.fnConvertirCantidadALetraMinusc(seImporte.Value);
            lblImporteLetra.Text = query.ToString();
        }

        private void gridLookUpFirmanteCartas_EditValueChanged(object sender, EventArgs e)
        {
            DataRow[] unData = dbSAICBPOCatalogosDataSet1.stpSelFirmanteCartas.Select("idFirmantesCarta = '" + gridLookUpFirmanteCartas.EditValue.ToString() + "'");
            if (unData.Count() > 0)
            {
                lblDepartamento.Text = "Departamento: " + unData[0].ItemArray[2].ToString();
            }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void seImporteSA_EditValueChanged(object sender, EventArgs e)
        {
            var query = queriesTableAdapter1.fnConvertirCantidadALetraMinusc(seImporteSA.Value);
            lblImporteLetraSA.Text = query.ToString();
        }

        private void seImporteSC_EditValueChanged(object sender, EventArgs e)
        {
            var query = queriesTableAdapter1.fnConvertirCantidadALetraMinusc(seImporteSC.Value);
            lblImporteLetraSC.Text = query.ToString();
        }
    }
}