using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using winAppSAIC.UtileriasLocal;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using compCatalogosSAIC;

namespace winAppSAIC.Catalogos
{
    public partial class XtraSubirCertificados : DevExpress.XtraEditors.XtraForm
    {
        public XtraSubirCertificados()
        {
            InitializeComponent();
        }
        public int pIdTenedora = 0;
        public string pNombreComercialTenedora = "";
        public string pRFC = "";
        private void XtraSubirCertificados_Load(object sender, EventArgs e)
        {
            txtId.Text = pIdTenedora.ToString();
            txtNombre.Text = pNombreComercialTenedora;
            txtRFC.Text = pRFC;
            txtUsuario.Text = pRFC;
            txtSerie.Text = pRFC.Substring(0, 2) + (pNombreComercialTenedora.Contains("HABER") ? "H" : "S");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarRegistros();     //guardar cambios
            }
            catch (DBConcurrencyException)
            {
                XtraMessageBox.Show("Error de concurrencia, NO fue insertardo/actualizado el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DataException ex)
            {
                XtraMessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarRegistros()
        {
            if (Validator.IsPresent(txtUsuario) && Validator.IsPresent(txtSerie) &&
                Validator.IsPresent(txtkey) &&  Validator.IsPresent(txtcer) &&
                Validator.IsPresent(txtContrasenaCer) && Validator.IsPresent(txtContrasenaPack))
            {

                string usuario = "";
                string NombreCer = "";
                string NombreKey = "";
                string certifi = "";
                string Nocertifi = "";
                string contrasenakey = "";
                string contrasena = "";
                int? id = 0;
                string serie = "";

                byte[] Certificado;
                byte[] CertificadoPen;
                byte[] key;
                byte[] keyPen;
                byte[] KeyEnc;

                Certificado = File.ReadAllBytes(txtcer.Text);
                CertificadoPen = File.ReadAllBytes(txtcer.Text);
                key = File.ReadAllBytes(txtkey.Text);
                keyPen = File.ReadAllBytes(txtkey.Text);
                KeyEnc = File.ReadAllBytes(txtkey.Text);

                Nocertifi = SerialNumber(txtcer.Text);
                certifi = Mex_CertToBase64String(txtcer.Text);
                contrasena = txtContrasenaPack.Text;
                contrasenakey = txtContrasenaCer.Text;
                usuario = txtUsuario.Text;
                serie = txtSerie.Text;

                queryCatalodos1.stpInsCertificados(pIdTenedora, Certificado, CertificadoPen, certifi, Nocertifi, key, keyPen, KeyEnc, contrasenakey, usuario, serie, contrasena, OperadorBD.OperadorGlobal.NombreUsuario,ref id);
                
                if (id==0)
                    XtraMessageBox.Show("El certificado fue cargado correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    XtraMessageBox.Show("Error: Intentelo mas tarde!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private string Mex_CertToBase64String(string strCertFile)
        {
            string Cert = "";
            try
            {
                CspParameters cspParams = new CspParameters();
                cspParams.KeyContainerName = strCertFile;
                RSACryptoServiceProvider key = new RSACryptoServiceProvider(cspParams);
                X509Certificate certificad = new X509Certificate(strCertFile);
                string resultsTrue = certificad.ToString(true);
                byte[] nombre = certificad.GetRawCertData();
                Cert = System.Convert.ToBase64String(nombre);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Cert;
        }

        private string SerialNumber(string strCertFile)
        {
            string Serial = "";
            try
            {
                X509Certificate2 Certificado = new X509Certificate2(strCertFile);
                string SerialNumber = Certificado.GetSerialNumberString();
                for (int i = 1; i <= 40;)
                {
                    string numero = SerialNumber.Substring(i, 1);
                    Serial = Serial + numero;
                    i = i + 2;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Serial;
        }

        private void txtcer_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ofdComprobante.Filter = "CER Files|*.cer";
            ofdComprobante.ShowDialog();
            txtcer.Text = ofdComprobante.FileName;
        }

        private void txtcerpem_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            ofdComprobante.Filter = "CER Files|*.cer.pem";
            ofdComprobante.ShowDialog();
            txtcerpem.Text = ofdComprobante.FileName;
        }

        private void txtkey_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            ofdComprobante.Filter = "KEY Files|*.key";
            ofdComprobante.ShowDialog();
            txtkey.Text = ofdComprobante.FileName;
        }

        private void txtkeyenc_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            ofdComprobante.Filter = "KEY Files|*.key.enc";
            ofdComprobante.ShowDialog();
            txtkeyenc.Text = ofdComprobante.FileName;
        }

        private void txtkeypem_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            ofdComprobante.Filter = "KEY Files|*.key.pem";
            ofdComprobante.ShowDialog();
            txtkeypem.Text = ofdComprobante.FileName;
        }
    }
}