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

namespace winAppSAIC.Catalogos
{
    public partial class frmxRepresentanteLegal : DevExpress.XtraEditors.XtraForm
    {
        String stTenedoraRazonSocial = String.Empty;
        int iIDTenedora = 0;
        int iIDRepresentanteLegal = 0;
        Boolean boolEditar = false;
        DataTable dtRepresentanteLegal = new DataTable();


        public frmxRepresentanteLegal(int idTenedora, String stTenedoraRazonSocial)
        {
            InitializeComponent();
            this.iIDTenedora = idTenedora;
            this.stTenedoraRazonSocial = stTenedoraRazonSocial;
        }

        private void frmxRepresentanteLegal_Load(object sender, EventArgs e)
        {
            txtIdTenedora.Text = iIDTenedora.ToString();
            txtTenedora.Text = stTenedoraRazonSocial;
            habilitarCampos(false);

            stpSelRepresentanteLegalTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelRepresentanteLegal, iIDTenedora);
            dtRepresentanteLegal = dbSAICBPOCatalogosDataSet1.stpSelRepresentanteLegal;

            if (dtRepresentanteLegal.Rows.Count > 0)
            {
                btnEditarInformacion.Enabled = true;

                int.TryParse(dtRepresentanteLegal.Rows[0]["IdRepresentanteLegal"].ToString(), out iIDRepresentanteLegal);
                txtNombre.Text = dtRepresentanteLegal.Rows[0]["Nombre"].ToString();
                txtPaterno.Text = dtRepresentanteLegal.Rows[0]["Apaterno"].ToString();
                txtMaterno.Text = dtRepresentanteLegal.Rows[0]["Amaterno"].ToString();
                txtCURP.Text = dtRepresentanteLegal.Rows[0]["CURP"].ToString();
                txtRFC.Text = dtRepresentanteLegal.Rows[0]["RFC"].ToString();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void limpiarCampos()
        {
            txtNombre.Text = String.Empty;
            txtPaterno.Text = String.Empty;
            txtMaterno.Text = String.Empty;
            txtCURP.Text = String.Empty;
            txtRFC.Text = String.Empty;
        }
        private void habilitarCampos(Boolean bandera)
        {
            txtNombre.Enabled = bandera;
            txtPaterno.Enabled = bandera;
            txtMaterno.Enabled = bandera;
            txtCURP.Enabled = bandera;
            txtRFC.Enabled = bandera;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            habilitarCampos(true);
        }

        private void btnEditarInformacion_Click(object sender, EventArgs e)
        {
            habilitarCampos(true);
            boolEditar = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String stNombre = String.Empty;
            String stPaterno = String.Empty;
            String stMaterno = String.Empty;
            String stCURP = String.Empty;
            String stRFC = String.Empty;

            int? tamuyBien = 0;

            stNombre = txtNombre.Text.Trim().ToUpper();
            stPaterno = txtPaterno.Text.Trim().ToUpper();
            stMaterno = txtMaterno.Text.Trim().ToUpper();
            stCURP = txtCURP.Text.Trim().ToUpper();
            stRFC = txtRFC.Text.Trim().ToUpper();

            if (boolEditar)
            {
                queriesTableAdapter1.stpUpdRepresentanteLegal(iIDRepresentanteLegal, stNombre, stPaterno, stMaterno, stRFC, stCURP, DateTime.Now, OperadorBD.OperadorGlobal.NombreUsuario, ref tamuyBien);
            }
            else
            {
                if (!String.IsNullOrEmpty(stNombre))
                {
                    queriesTableAdapter1.stpInsRepresentanteLegal(iIDRepresentanteLegal, iIDTenedora, stNombre, stPaterno, stMaterno, stRFC, stCURP, DateTime.Now, OperadorBD.OperadorGlobal.NombreUsuario, ref tamuyBien);
                }
            }

            boolEditar = false;
            habilitarCampos(false);
        }
    }
}