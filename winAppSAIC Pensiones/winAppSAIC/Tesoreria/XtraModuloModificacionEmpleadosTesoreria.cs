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
using System.IO;
using compLibreriaSAIC;
using DevExpress.Pdf;
using System.Text.RegularExpressions;


//using iTextSharp.text.pdf;
//using iTextSharp.text.pdf.parser;

namespace winAppSAIC.Tesoreria
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        tools.dsc dsc = new tools.dsc();
        ErrorProvider erroProviderCampos = new ErrorProvider();

        Boolean flagTarjeta = false;
        Boolean flagClabe = false;

        int idempleado;
        String stNombreCompleto;
        String stCURP;
        String stRFC;
        String stNSS;
        String stTipoPago;
        String stBanco;
        String stCuanta;
        String stClabe;
        String stNoTarjeta;


        public XtraForm1(int idempleado, String stNombreCompleto, String stCURP, String stRFC, String stNSS, String stTipoPago, String stBanco, String stCuanta, String stClabe, String stNoTarjeta)
        {
            InitializeComponent();

            this.idempleado = idempleado;
            this.stNombreCompleto = stNombreCompleto;
            this.stCURP = stCURP;
            this.stRFC = stRFC;
            this.stNSS = stNSS;
            this.stTipoPago = stTipoPago;
            this.stBanco = stBanco;
            this.stCuanta = stCuanta;
            this.stClabe = stClabe;
            this.stNoTarjeta = stNoTarjeta;

            txtidEmpleado.Text = idempleado.ToString();
            txtNombre.Text = stNombreCompleto;
            txtCURP.Text = stCURP;
            txtNSS.Text = stNSS;
            txtRFC.Text = stRFC;
            txtTipoPago.Text = stTipoPago;
            txtBanco.Text = stBanco;
            txtCuenta.Text = stCuanta;
            txtClabe.Text = stClabe;
            txtNoTarjeta.Text = stNoTarjeta;

            //txtClabe.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            //txtClabe.Properties.Mask.EditMask = "00000";
            //txtClabe.Properties.Mask.UseMaskAsDisplayFormat = true;
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtClabe_EditValueChanged(object sender, EventArgs e)
        {
            String stClabe = String.Empty;
            stClabe = txtClabe.Text.Replace("-", "").Replace("_", "");
            txtClabe.Text = stClabe;
            //txtClabe.Text = txtClabe.Text.Replace("-", "").Replace("_", "");
            lblLenClabe.Text = txtClabe.Text.Count().ToString();
            if (ValidarTarjeta() && ValidarClabe())
            {
                btnActualizar.Enabled = true;
            }
            else
            {
                btnActualizar.Enabled = false;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            //txtClabe.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            //txtClabe.Properties.Mask.EditMask = "[^ ]*";
        }

        private void btnSubirContrato_Click(object sender, EventArgs e)
        {
            String stRutaContrato = String.Empty;
            String stValorDocumento = String.Empty;
            Boolean flatSubirContrato = true;
            //rempleazar archivo preguntar
            int? iContar = 0;
            queriesTableAdapter1.stpSelEmpleadoConDocumento(idempleado, 2, ref iContar);

            if (iContar > 0)
            {
                DialogResult resultado = XtraMessageBox.Show("El Empleado: " + stNombreCompleto + ", ya tiene un contrato asignado." + Environment.NewLine + "¿Desea remplazar el contrato?"
          , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult.Yes == resultado)
                {
                    flatSubirContrato = true;
                }
                else
                {
                    flatSubirContrato = false;
                }
            }

            if (flatSubirContrato)
            {
                XtraMessageBox.Show("Por favor seleccione el Contrato del Empleado."
               , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                OpenFileDialog ofdSelecFile = new OpenFileDialog();
                ofdSelecFile.Filter = "Pdf Files| *.pdf";
                ofdSelecFile.Title = "SAIC | Seleccione Contrato";
                ofdSelecFile.Multiselect = false;
                ofdSelecFile.ShowDialog();

                stRutaContrato = ofdSelecFile.FileName;

                if (!String.IsNullOrEmpty(stRutaContrato))
                {
                    splashScreenManager1.ShowWaitForm();
                    splashScreenManager1.SetWaitFormCaption("Cargando Contrato");

                    stValorDocumento = dsc.ConvertToBytes(stRutaContrato);
                    if (!String.IsNullOrEmpty(stValorDocumento))
                    {
                        FileInfo miArchivo = new FileInfo(stRutaContrato);

                        stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "LIMITEARCHIVO");
                        if (dbSAICBPOValidacionDataSet1.stpSelParametro.Rows.Count > 0)
                        {
                            int iValorLimiteArchivos;
                            int.TryParse(dbSAICBPOValidacionDataSet1.stpSelParametro.Rows[0]["ValorParametro"].ToString(), out iValorLimiteArchivos);

                            if (miArchivo.Length <= iValorLimiteArchivos)
                            {

                                try
                                {
                                    queriesTableAdapter1.stpInsDocumentoEmpleados(
                                                            idempleado,
                                                            stValorDocumento,
                                                           "pdf",
                                                           2,
                                                           OperadorBD.OperadorGlobal.NombreUsuario
                                                           );
                                }
                                catch (Exception ex)
                                {
                                    if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                                    XtraMessageBox.Show("No se puede guardar en el archivo en el servidor." + Environment.NewLine + ex.Message
                                    , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }

                                XtraMessageBox.Show("Archivo guardado con Exito"
                                   , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                                XtraMessageBox.Show("El Archivo no debe exceder de " + iValorLimiteArchivos + " KB"
                                 , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                        }
                        else
                        {
                            if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                            XtraMessageBox.Show("No se tiene valor de limite para archivos."
                    , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    else
                    {
                        if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                        XtraMessageBox.Show("No se puede convertir el Archivo para Subir."
                        , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnObtenerClabe_Click(object sender, EventArgs e)
        {
            try
            {

                String stRutaContrato = String.Empty;

                XtraMessageBox.Show("Por favor seleccione el Contrato del Empleado."
               , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                OpenFileDialog ofdSelecFile = new OpenFileDialog();
                ofdSelecFile.Filter = "Pdf Files| *.pdf";
                ofdSelecFile.Title = "SAIC | Seleccione Contrato";
                ofdSelecFile.Multiselect = false;
                ofdSelecFile.ShowDialog();

                stRutaContrato = ofdSelecFile.FileName;

                if (!String.IsNullOrEmpty(stRutaContrato))
                {
                    String sttexto = String.Empty;
                    String stClabeContrato = String.Empty;
                    sttexto = ExtractTextFromPDF(stRutaContrato);
                    //sttexto = InfoPDF.obtenerTexto(stRutaContrato);

                    Boolean flatRFCEmpleado = false;
                    Boolean flatCURPEmpleado = false;

                    //validarRFC
                    if (!String.IsNullOrEmpty(sttexto))
                    {
                        flatRFCEmpleado = valRFCEmpleado(sttexto, stRFC);
                        flatCURPEmpleado = valCURPEmpleado(sttexto, stCURP);

                        if (flatRFCEmpleado)
                        {
                            if (flatCURPEmpleado)
                            {
                                String bancoContrato = String.Empty;
                                bancoContrato = encontrarBanco(sttexto);

                                if (!String.IsNullOrEmpty(bancoContrato))
                                {
                                    stpSelParametrosContratoTarjetasBancosTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelParametrosContratoTarjetasBancos, bancoContrato);
                                    if (dbSAICBPOCatalogosDataSet1.stpSelParametrosContratoTarjetasBancos.Rows.Count > 0)
                                    {
                                        String StClabe = String.Empty;
                                        foreach (DataRow unRow in dbSAICBPOCatalogosDataSet1.stpSelParametrosContratoTarjetasBancos.Rows)
                                        {
                                            String[] separarClabe1 = dsc.StrExtract(sttexto, unRow["Parametro1"].ToString(), unRow["Parametro2"].ToString()).Split(' ');
                                            separarClabe1 = separarClabe1.Select(x => x.ToString().Replace("\n", "").Replace(" ", "")).ToArray();
                                            separarClabe1 = separarClabe1.Where(x => !String.IsNullOrEmpty(x.ToString())).ToArray();

                                            if (separarClabe1.Length <= 10)
                                            {
                                                Boolean esClabe = false;
                                                for (int a = 0; a < separarClabe1.Length; a++)
                                                {
                                                    StClabe = String.Empty;
                                                    for (int i = a; i < separarClabe1.Length; i++)
                                                    {
                                                        StClabe += separarClabe1[i];
                                                        var varMiclabe = queriesTableAdapter1.ValidarClabe(StClabe);
                                                        Boolean.TryParse(varMiclabe.ToString(), out esClabe);
                                                        //esClabe = queriesTableAdapter1.ValidarClabe(StClabe);
                                                        if (esClabe == true)
                                                        {
                                                            txtClabe.Text = StClabe;
                                                            break;
                                                        }
                                                    }
                                                    if (esClabe == true) { break; }
                                                }
                                                if (esClabe == true) { break; }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        XtraMessageBox.Show("No se tienen Parametros para el contrato."
                                , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else
                                {
                                    XtraMessageBox.Show("El Contrato no pertenece a Banorte o Bancomer."
                              , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                XtraMessageBox.Show("No se encuentra el CURP del Empleado: " + stNombreCompleto + ", en el Contrato."
                            , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show("No se encuentra el RFC del Empleado: " + stNombreCompleto + ", en el Contrato."
                            , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                        // if (flatRFCEmpleado)
                        // {
                        //     String[] separarClabe = dsc.StrExtract(sttexto, "(GAT)", "BENEFICIARIO(S)").Split(' ');
                        //     if (separarClabe.Length > 5)
                        //     {
                        //         stClabeContrato = separarClabe[1] + separarClabe[2] + separarClabe[3] + separarClabe[4];

                        //         String stbancodesc = queriesTableAdapter1.ClaveBanco(stClabeContrato.Substring(0, 3));
                        //         String stCuenta = queriesTableAdapter1.CuentaClabe(stClabeContrato.Substring(0, 3), stClabeContrato);

                        //         txtBanco.Text = stbancodesc;
                        //         txtCuenta.Text = stCuenta;
                        //         txtClabe.Text = stClabeContrato;
                        //     }

                        //     separarClabe = dsc.StrExtract(sttexto, "GAT real", "N/A").Split(' ');
                        //     separarClabe = separarClabe.Select(x => x.ToString().Replace("\n", "")).ToArray();
                        //     separarClabe = separarClabe.Where(x => !String.IsNullOrEmpty(x.ToString())).ToArray();

                        //     if (separarClabe.Length > 5)
                        //     {
                        //         stClabeContrato = separarClabe[1] + separarClabe[2] + separarClabe[3] + separarClabe[4];

                        //         String stbancodesc = queriesTableAdapter1.ClaveBanco(stClabeContrato.Substring(0, 3));
                        //         String stCuenta = queriesTableAdapter1.CuentaClabe(stClabeContrato.Substring(0, 3), stClabeContrato);

                        //         txtBanco.Text = stbancodesc;
                        //         txtCuenta.Text = stCuenta;
                        //         txtClabe.Text = stClabeContrato;
                        //     }
                        // }
                        // else
                        // {
                        //     XtraMessageBox.Show("El Contrato Ingresado no corresponde al Empleado: " + stNombreCompleto
                        //, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // }
                    }
                    else
                    {
                        XtraMessageBox.Show("No se puede leer el Archivo PDF."
                        , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show("Error al Subir Contrato de Empleado." + Environment.NewLine + Ex
                      , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = XtraMessageBox.Show("¿Esta seguro de que desea guardar la informacion del Empleado?"
                   , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    txtClabe.Text = txtClabe.Text.Replace(" ", "").Replace("_", "").Trim(); //Por si las dudas...
                    queriesTableAdapter1.stpUpdDatosBancariosEmpleado(idempleado, txtBanco.Text.Trim(), txtCuenta.Text.Trim(), txtClabe.Text, txtNoTarjeta.Text, txtTipoPago.Text, OperadorBD.OperadorGlobal.NombreUsuario);
                    this.Close();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("No se pudo guardar la informacion del empleado." + Environment.NewLine + ex.Message
                 , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private Boolean valRFCEmpleado(String stTexto, String stRFCEmpleado)
        {
            Boolean flatEstaBien = false;
            String stRfcTexto = String.Empty;

            if (stTexto.Contains(stRFCEmpleado + " "))
            {
                flatEstaBien = true;
            }

            return flatEstaBien;
        }

        private Boolean valCURPEmpleado(String stTexto, String stCURPEmpleado)
        {
            Boolean flatEstaBien = false;
            String stRfcTexto = String.Empty;

            if (stTexto.Contains(stCURPEmpleado + " "))
            {
                flatEstaBien = true;
            }

            return flatEstaBien;
        }

        private String encontrarBanco(String stTexto)
        {
            String stBanco = String.Empty;
            if (stTexto.Contains("BANORTE"))
            {
                stBanco = "BANORTE";
            }
            else if (stTexto.Contains("BANCOMER"))
            {
                stBanco = "BANCOMER";
            }
            return stBanco;
        }

        string ExtractTextFromPDF(string filePath)
        {
            string documentText = "";
            try
            {
                using (PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor())
                {
                    documentProcessor.LoadDocument(filePath);
                    documentText = documentProcessor.Text;
                }
            }
            catch { }
            return documentText;
        }

        private Boolean ValidarClabe()
        {
            Boolean flagClabe = false;

            String stClabeInterbancaria = String.Empty;
            stClabeInterbancaria = txtClabe.Text.Replace(" ", "").Replace("_", "");

            if (txtClabe.Text.Length == 0)
            {
                flagClabe = true;
                txtTipoPago.Text = "TARJETA";
                txtBanco.Text = String.Empty;
                txtCuenta.Text = String.Empty;
            }
            else
            {
                if (stClabeInterbancaria.Length > 16)
                {
                    if (stClabeInterbancaria.Length > 2)
                    {
                        txtBanco.Text = queriesTableAdapter1.ClaveBanco(stClabeInterbancaria.Substring(0, 3));
                    }
                    if (stClabeInterbancaria.Length > 16)
                    {
                        var miCuenta = queriesTableAdapter1.CuentaClabe(stClabeInterbancaria.Substring(0, 3), stClabeInterbancaria);
                        txtCuenta.Text = miCuenta.ToString();
                    }
                    if (stClabeInterbancaria.Length == 18)
                    {
                        Boolean esClabe = false;
                        var varEsClabe = queriesTableAdapter1.ValidarClabe(stClabeInterbancaria);
                        Boolean.TryParse(varEsClabe.ToString(), out esClabe);

                        if (esClabe == false)
                        {
                            erroProviderCampos.Icon = Properties.Resources.warning1;
                            erroProviderCampos.SetError(txtClabe, "La Clabe Ingresada no es Valida");
                            flagClabe = false;
                            txtBanco.Text = String.Empty;
                            txtCuenta.Text = String.Empty;
                            txtTipoPago.Text = "TARJETA";
                        }
                        else
                        {
                            erroProviderCampos.Clear();
                            flagClabe = true;
                            txtTipoPago.Text = "TRANSFERENCIA";
                        }
                    }
                    else
                    {
                        erroProviderCampos.Icon = Properties.Resources.warning1;
                        erroProviderCampos.SetError(txtClabe, "la Clabe es muy Corta, No es Valida");
                        flagClabe = false;
                        txtBanco.Text = String.Empty;
                        txtCuenta.Text = String.Empty;
                        txtTipoPago.Text = "TARJETA";
                    }
                }
                else
                {
                    txtBanco.Text = String.Empty;
                    txtCuenta.Text = String.Empty;
                    txtTipoPago.Text = "TARJETA";
                }
            }
            return flagClabe;
        }

        private Boolean ValidarTarjeta()
        {
            Boolean flagTarjeta = false;

            if (txtNoTarjeta.Text.Length == 0)
            {
                flagTarjeta = true;
            }
            else if (txtNoTarjeta.Text.Length == 16)
            {
                String stTarjeta = String.Empty;
                String reg = "^[0-9]{16}$";
                Regex regex = new Regex(reg);
                if (regex.IsMatch(txtNoTarjeta.Text))
                {
                    flagTarjeta = true;
                    erroProviderCampos.Clear();
                }
                else
                {
                    flagTarjeta = false;
                    erroProviderCampos.Icon = Properties.Resources.warning1;
                    erroProviderCampos.SetError(txtNoTarjeta, "La Tarjeta Ingresada no es Valida");
                }
            }

            return flagTarjeta;
        }
        
        private void txtNoTarjeta_EditValueChanged_1(object sender, EventArgs e)
        {
            lblLenTarjeta.Text = txtNoTarjeta.Text.Count().ToString();
            if (ValidarTarjeta() && ValidarClabe())
            {
                btnActualizar.Enabled = true;
            }
            else
            {
                btnActualizar.Enabled = false;
            }
        }
    }
}