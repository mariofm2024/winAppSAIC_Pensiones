using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using System.IO;

namespace winAppSAIC.Seguridad
{
    public partial class frmxTemas : DevExpress.XtraEditors.XtraForm
    {
        tools.dsc dsc = new tools.dsc();
        public frmxTemas()
        {
            InitializeComponent();
        }

        private void frmxTemas_Load(object sender, EventArgs e)
        {
            foreach (SkinContainer item in SkinManager.Default.Skins)
            {
                cboxTemas.Properties.Items.Add(item.SkinName);
            }
        }

        private void cboxTemas_SelectedIndexChanged(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(cboxTemas.Text);
        }
        Boolean banConCambios = false;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cboxTemas.Text))
            {
                guarArchivo(cboxTemas.Text);
            }
        }

        private void frmxTemas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!banConCambios)
            {
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            }
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            guarArchivo("DevExpress Style");
        }

        private void guarArchivo(String stTema)
        {
            Boolean taMuyBien = false;

            try
            {
                String stRutaArchivo = String.Empty;
                String sttema = String.Empty;
                sttema = "<Tema>" + cboxTemas.Text + "</Tema>";
                stRutaArchivo = dsc.stRutaSAIC + "tema.ini";
                File.WriteAllText(stRutaArchivo, sttema);
                banConCambios = true;

                XtraMessageBox.Show("Tema " + stTema + ", guardado."
                 , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("No se pudo guardar el Tema:" + Environment.NewLine + ex.Message
                  , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}