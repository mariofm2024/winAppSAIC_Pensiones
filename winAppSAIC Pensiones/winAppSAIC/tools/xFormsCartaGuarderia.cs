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
using winAppSAIC.UtileriasLocal;

namespace winAppSAIC.tools
{
    public partial class xFormsCartaGuarderia : DevExpress.XtraEditors.XtraForm
    {

        public String stPeridoVacacional { get; set; }
        public String stDiasDeDescanso { get; set; }
        public String stNumeroTelefonicoPersonal { get; set; }
        public String stNumeroTelefonicoOficina { get; set; }
        public String stNombreMenor { get; set; }
        public String CURPMenor { get; set; }
        public int idFirmanteCarta { get; set; }
        public String stNombreGuarderia { get; set; }
        public String stNombreDirectora { get; set; }

        String stTitulo;
        Empleado miEmpleado;
        public xFormsCartaGuarderia(String stTitulo, Empleado miEmpleado)
        {
            InitializeComponent();
            this.stTitulo = stTitulo;
            this.miEmpleado = miEmpleado;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xFormsCartaGuarderia_Load(object sender, EventArgs e)
        {
            String stNombreCompleatoEmpleado = miEmpleado.APaternoEmpleado + " " + miEmpleado.AMaternoEmpleado + " " + miEmpleado.NombreEmpleado;
            lblTitulo.Text = "Carta de" + stTitulo;
            txtNombreEmpleado.Text = stNombreCompleatoEmpleado;
            txtNSS.Text = miEmpleado.NSS;
            txtRFC.Text = miEmpleado.RFC;
            txtCURP.Text = miEmpleado.CURP;
            stpSelFirmanteCartasTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelFirmanteCartas, stTitulo);
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (gridLookUpFirmanteCartas.EditValue != null)
            {
                int idFirmante;
                int.TryParse(gridLookUpFirmanteCartas.EditValue.ToString(), out idFirmante);

                if (idFirmante > 0)
                {
                    if (Validator.IsPresent(txtNombreMenor) && Validator.IsPresent(txtPeriodoVacacional) && Validator.IsPresent(txtDiasDeDescanso)
                        && Validator.IsPresent(txtNombreGuarderia) && Validator.IsPresent(txtNombreDirectora))
                    {
                        DialogResult resultado = XtraMessageBox.Show("¿Esta correcta la información de la Carta de " + stTitulo + "?", "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (DialogResult.Yes == resultado)
                        {
                            stPeridoVacacional = txtPeriodoVacacional.Text;
                            stDiasDeDescanso = txtDiasDeDescanso.Text;
                            stNumeroTelefonicoOficina = txtNumeroOficina.Text;
                            stNumeroTelefonicoPersonal = txtNumeroPersonal.Text;
                            stNombreMenor = txtNombreMenor.Text;
                            CURPMenor = txtCURPMenor.Text;
                            idFirmanteCarta = idFirmante;
                            stNombreGuarderia = txtNombreGuarderia.Text;
                            stNombreDirectora = txtNombreDirectora.Text;
                            DialogResult = DialogResult.OK;
                            Close();
                        }
                        else
                        {
                            DialogResult = DialogResult.Cancel;
                            Close();
                        }
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridLookUpFirmanteCartas_EditValueChanged(object sender, EventArgs e)
        {
            DataRow[] unData = dbSAICBPOCatalogosDataSet1.stpSelFirmanteCartas.Select("idFirmantesCarta = '" + gridLookUpFirmanteCartas.EditValue.ToString() + "'");
            if (unData.Count() > 0)
            {
                lblDepartamento.Text = "Departamento: " + unData[0].ItemArray[2].ToString();
            }
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}