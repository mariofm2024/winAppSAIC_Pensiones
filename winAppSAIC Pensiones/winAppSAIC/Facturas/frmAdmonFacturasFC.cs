using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using winAppSAIC.NominaCFDI;
using System.Xml;
using compNominaCFDI;
using winAppSAIC.UtileriasLocal;
using compCatalogosSAIC;
using System.Xml.Linq;
using winAppSAIC.ReportesCFDI;
using DevExpress.XtraReports.UI;        //namespace a partir version 12.2.4
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using System.Net;
using DevExpress.XtraGrid.Views.Grid;
using System.Diagnostics;

namespace winAppSAIC.Facturas
{
    public partial class frmAdmonFacturasFC : DevExpress.XtraEditors.XtraForm
    {
        public Int64 IdSolicitudFactura = 0;
        public Int64 IdFactura = 0;
        private Int32 Header = 0;
        private Int64 IdFacturas = 0;
        private Int32 Estatus = 0;
        private string idTipoFactura = "N";
        private string sRutaArchivosCFDI;
        private string sRutaArchivosRespuestaCFDI;
        private string pathXmlFiles;
        private string pathXmlFilesRespuesta;
        private bool ActualizarCombo = false;
        private bool PTimbrar = false; //Habilitar
        private int ContarNoTimbrados = 0;
        private int ContarTimbrados = 0;
        private int idTipoBeneficiario = 0, IdBeneficiario = 0, idUsoCFDI = 0, IdFronting = 0;

        DateTime dFechaInicial = new DateTime();
        DateTime dtFechaFinal = new DateTime();

        FacturaRelacionada oFacturaRelacionada = new FacturaRelacionada();
        public frmAdmonFacturasFC()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close(); //SALIR
        }

        private void ActivarBotones(bool bflagTimbre, bool bflagVinvular, bool bflagFactura, bool bflagContabilizar)
        {
            if (Estatus == 2)
            {
                if (PTimbrar)
                {
                    btnFacturar.Visible = bflagTimbre;
                    //btnCancelarFactura.Visible = bflagTimbre;
                    btnCancelarTimbre.Visible = !bflagTimbre;
                }
                else
                {
                    btnFacturar.Visible = false;
                    btnCancelarFactura.Visible = false;
                    btnCancelarTimbre.Visible = false;
                }

                btnDescargar.Visible = !bflagTimbre;
                btnVisualizarErrores.Visible = true;
                //if (PContabilizar)
                //{
                //    btnContabilizar.Visible = bflagContabilizar;
                //    btnDescontabilizar.Visible = !bflagContabilizar;
                //}
                //else
                //{
                //    btnContabilizar.Visible = false;
                //    btnDescontabilizar.Visible = false;
                //}

                if (PTimbrar && chkContabilizado.Checked == true)// btnContabilizar.Visible == false)
                {
                    btnCancelarTimbre.Visible = false;
                    btnCancelarFactura.Visible = false;
                }
            }
            else
            {
                btnFacturar.Visible = false;
                btnCancelarFactura.Visible = false;
                btnDescargar.Visible = false;
                btnCancelarTimbre.Visible = false;
                //btnContabilizar.Visible = false;
                //btnDescontabilizar.Visible = false;
            }
        }

        private void OcultarBotones(bool bflag)
        {
            btnFacturar.Visible = bflag;
            btnCancelarFactura.Visible = bflag;
            btnDescargar.Visible = bflag;
            btnVisualizarErrores.Visible = bflag;
            btnCancelarTimbre.Visible = bflag;
            //btnContabilizar.Visible = bflag;
            //btnDescontabilizar.Visible = bflag;
        }

        private void Limpiar()
        {
            txtIdSolicitud.Text = string.Empty;
            txtFronting.Text = string.Empty;
            txtTipoBeneficiarios.Text = string.Empty;
            txtBeneficiario.Text = string.Empty;
            txtMetodoPago.Text = string.Empty;
            txtFormaPago.Text = string.Empty;
            txtBancoOrigen.Text = string.Empty;
            txtCuentaOrigen.Text = string.Empty;
            txtTotalDeposito.Text = string.Empty;
            txtFechaPago.Text = string.Empty;
            txtMoneda.Text = string.Empty;
            txtTipoCambio.Text = string.Empty;
            txtMesAno.Text = string.Empty;
            txtEstatus.Text = string.Empty;
            txtSerie.Text = string.Empty;
            txtOperador.Text = string.Empty;
            txtProducto.Text = string.Empty;
            btnComprobante.Enabled = false;
            chkContabilizado.Checked = false;
            idTipoBeneficiario = 0;
            IdBeneficiario = 0;
            idUsoCFDI = 0;
            IdFronting = 0;
            txtUsoCFDI.EditValue = -1;
            this.dbSAICBPOFactura.stpFactSelControlOperacionesFacturas.Clear();
            this.dbSAICBPOFactura.stpFactSelDetailFacturas.Clear();
            this.dbSAICBPOFactura.stpFactSelFacturasARelacionar.Clear();
            this.dbSAICBPOFactura.stpFactSelFacturasARelacionarSAT.Clear();
        }

        private void Timbrar(long IdFactura, Int32 IdFronting)
        {
            string pUsuarioCFDI = "";
            string pContrasenaCFDI = "";
            string pAPIKEY = "";
            long pNoFolioSiguiente = 0;
            string dtHoraInicial = DateTime.Now.ToLongTimeString();
            int ptipoRela = 0;
            long pIdFacturaCFDI = 0;
            string sArchivo = "";

            try
            {
                Version ver = new Version(System.Windows.Forms.Application.ProductVersion);
                //Obtener el Usuario y Contraseña de la Tenedora activa en el Lote
                this.spSoloRespuesta1.stpFactSelSeguridadCFDIFacturasAPI(IdFronting, ref pUsuarioCFDI, ref pContrasenaCFDI, ref pAPIKEY);

                //obtener el No. de Items seleccionados

                splashSMProcesando.ShowWaitForm();        //mostrar pantalla de espera
                this.Cursor = Cursors.AppStarting;      //cambiar cursor del mouse
                                                        //obtener la ruta RAIZ en dónde se almacenarán los archivos PDF y XML
                string strRutaArchivosXML = this.validacionesGeneralTableAdapter1.ObtenerValorParametro("FOLDER_XML_FACTURA_CFDI").ToString();

                //Generar carpeta para colocar archivos XML
                sRutaArchivosCFDI = compNominaCFDI.AccesoIO.ValidarCrearDirectorioCFDI(strRutaArchivosXML, cbFacturas.EditValue.ToString(), compNominaCFDI.AccesoIO.ISO_Date());
                sRutaArchivosRespuestaCFDI = compNominaCFDI.AccesoIO.ValidarCrearDirectorioRespuestaCFDI(sRutaArchivosCFDI + @"\XMLTimbrados\");

                string FIni = Convert.ToDateTime(dtFechaIni.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Day.ToString();

                //obtener Factra = FolioRecibo
                this.stpFactSelGenerarFactura2020TableAdapter1.Fill(dbSAICBPOFactura.stpFactSelGenerarFactura2020, IdFactura, ver.ToString(), OperadorBD.OperadorGlobal.IdOperador, OperadorBD.OperadorGlobal.NombreUsuario, FIni);

                if (dbSAICBPOFactura.stpFactSelGenerarFactura2020.Count > 0)
                {
                    DataRow Row = dbSAICBPOFactura.stpFactSelGenerarFactura2020.Rows[0];
                    //Asignar Valores
                    sArchivo = Row[0].ToString();
                    pNoFolioSiguiente = Convert.ToInt64(Row[2].ToString() == string.Empty ? "0" : Row[2].ToString());
                    pIdFacturaCFDI = Convert.ToInt64(Row[3].ToString());
                    ptipoRela = Convert.ToInt32(Row[4].ToString());
                    XmlWriterSettings settings = new XmlWriterSettings() { Indent = true, IndentChars = ("     ") };
                    pathXmlFiles = string.Format(@"{0}F{1}-{2}.json", sRutaArchivosCFDI + "\\", IdFactura.ToString(), pNoFolioSiguiente);
                    pathXmlFilesRespuesta = string.Format(@"{0}Res{1}-{2}.json", sRutaArchivosCFDI + "\\", IdFactura.ToString(), pNoFolioSiguiente);
                    File.WriteAllText(pathXmlFiles, sArchivo, Encoding.UTF8);

                    EnviarXML2wsPACv12(IdFactura, pIdFacturaCFDI, pUsuarioCFDI, pContrasenaCFDI, pAPIKEY, pNoFolioSiguiente.ToString(), sArchivo, ptipoRela);
                    this.Cursor = Cursors.Default;      //cambiar cursor del mouse
                    splashSMProcesando.CloseWaitForm();
                }
                else
                {
                    this.Cursor = Cursors.Default;      //cambiar cursor del mouse
                    splashSMProcesando.CloseWaitForm();
                    XtraMessageBox.Show("¡Error al Generar Factura, Contacte a Sistemas!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;      //cambiar cursor del mouse
                splashSMProcesando.CloseWaitForm();
                throw ex;
            }
        }

        private void EnviarXML2wsPACv12(Int64 IdFactura, Int64 pIdFacturaCFDI, string pUsuarioCFDI, string pContrasenaCFDI, string pAPIKEY, string pNoFolioSiguiente, string sArchivo, int ptipoRelacion)
        {
            //string URL = "https://api.enlacefiscal.com/v6/probarConexion?";
            string URL = "";
            if (ptipoRelacion == 11)
                URL = "https://api.enlacefiscal.com/v6/generarReciboElectronicoPago";
            else
                URL = "https://api.enlacefiscal.com/v6/generarCfdi";

            string sDATA = string.Format("{0}", sArchivo);// @"{ ""Solicitud"" : { ""rfc"" : """ + pUsuarioCFDI + @""", ""accion"": ""probarConexion"" } }";
            var Base64Encode = Encoding.UTF8.GetBytes(string.Format("{0}:{1}", pUsuarioCFDI, pContrasenaCFDI));
            string strUserPWDX64 = Convert.ToBase64String(Base64Encode);

            HttpWebRequest request = WebRequest.Create(URL) as HttpWebRequest;
            WebHeaderCollection headers = new WebHeaderCollection();
            headers.Add("Authorization", "Basic " + strUserPWDX64);
            headers.Add("x-api-key:" + pAPIKEY);
            request.Headers.Add(headers);
            request.Method = "POST";
            request.Accept = "application/json;charset=\"utf-8\"";
            request.ContentType = "application/json; charset=utf-8";

            //request.UserAgent = "Microsoft ADO.NET Data Services";
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                //string json = "{ \"method\" : \"guru.test\", \"params\" : [ \"Guru\" ], \"id\" : 123 }";

                streamWriter.Write(sDATA);
                streamWriter.Flush();
                streamWriter.Close();
            }
            //var bytes = Encoding.UTF8.GetBytes(sDATA);
            //request.ContentLength = bytes.Length;
            //request.GetRequestStream().Write(bytes, 0, bytes.Length);

            try
            {
                WebResponse webResponse = request.GetResponse();
                Stream webStream = webResponse.GetResponseStream();
                StreamReader responseReader = new StreamReader(webStream, Encoding.UTF8);
                string response = responseReader.ReadToEnd();
                responseReader.Close();

                response = response.Replace(@"\/", "/");
                File.WriteAllText(pathXmlFilesRespuesta, response, Encoding.UTF8);
                response = File.ReadAllText(pathXmlFilesRespuesta);
                //Método que recibe el XML de respuesta del WSEnlaceFiscal
                ObtenerValoresXMLRespuesta(IdFactura, pIdFacturaCFDI, response, sRutaArchivosRespuestaCFDI, pNoFolioSiguiente, ptipoRelacion);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método que obtienes la información del XML de respuesta
        /// del WS Enlace Fiscal
        /// </summary>
        /// <param name="objNominaControlCFDI">Objeto Nomina Control v1.2</param>
        /// <param name="strXMLResponse">Valor string del XML</param>
        /// <param name="sRutaArchivosRespuestaCFDI"></param>
        /// <param name="sRFCTenedora"></param>
        private void ObtenerValoresXMLRespuesta(Int64 IdFactura, Int64 pIdFacturaCFDI, string strXMLResponse, string sRutaArchivosRespuestaCFDI, string pNoFolioSiguiente, int ptipoRelacion)
        {
            Version ver = new Version(System.Windows.Forms.Application.ProductVersion);
            try
            {
                if (strXMLResponse.Contains("AckEnlaceFiscal"))
                //Obtener Estatus Respuesta del Documento XML enviado
                {
                    if (strXMLResponse.Contains(@"""estatusDocumento"":""rechazado"""))
                    {
                        Int64? pidRespuesta = 0;
                        //Metodo que almacenara la informacion que fue enviada a Timbrar
                        spSoloRespuesta1.stpFactInsFacturaCFDIErrores(IdFactura, pIdFacturaCFDI, strXMLResponse, "SAIC Windows", ver.ToString(), "Timbrar", OperadorBD.OperadorGlobal.NombreUsuario, ref pidRespuesta);
                        ContarNoTimbrados = 1;
                    }
                    else if (strXMLResponse.Contains(@"""estatusDocumento"":""aceptado"""))
                    {

                        //Metodo que almacenara la informacion que fue enviada a Timbrar
                        string pXML = "", pQR = "", Serie = "";
                        spSoloRespuesta1.stpFactUpdFacturaCFDI(IdFactura, pIdFacturaCFDI, strXMLResponse, "SAIC Windows", ver.ToString(), OperadorBD.OperadorGlobal.NombreUsuario, ref pQR, ref pXML, ref Serie);

                        // Para Generar QR y XML se deben conbertit a Base 64
                        //Asignar Valores

                        byte[] dataQRCode = Convert.FromBase64String(pQR); // archivoQR
                        string decodedQRCode = Encoding.UTF8.GetString(dataQRCode);
                        long LongitudQRCode = pQR.ToString().Length; // archivoQR

                        //decodificar Contenido XML
                        byte[] data = Convert.FromBase64String(pXML);  //xmlCFDi
                        string decodedXmlCFDI = Encoding.UTF8.GetString(data);

                        int? pOk = 0;
                        //Insertar Imagen y XML de respuesta
                        spSoloRespuesta1.stpFactInsDocumentoFacturaCFDI(pIdFacturaCFDI, dataQRCode, decodedXmlCFDI, ref pOk);

                        //TODO: Instrucciones para crear Archivo XML CFDI
                        //Crear archivo XML desde un string
                        XmlDocument xdoc = new XmlDocument();
                        xdoc.LoadXml(decodedXmlCFDI);
                        xdoc.Save(string.Format(@"{0}\F{1}_{2}_{3}.xml", sRutaArchivosRespuestaCFDI, IdFactura, Serie, pNoFolioSiguiente));

                        //TODO: Instrucciones para generar Archivo PDF
                        string strNombreArchivoPDF = string.Format(@"{0}\F{1}_{2}_{3}.pdf", sRutaArchivosRespuestaCFDI, IdFactura, Serie, pNoFolioSiguiente);

                        Estructuras.InformacionError objError;      //variable que recibe comportamiento del reporte

                        if (ptipoRelacion == 11)
                            objError = ExportarCFDI2PDF.GenerarTimbradosPDFacturaRecibo(strNombreArchivoPDF, IdFactura, ver.ToString());
                        else
                            objError = ExportarCFDI2PDF.GenerarTimbradosPDFactura(strNombreArchivoPDF, IdFactura, ver.ToString());
                        ContarTimbrados = 1;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método que obtienes la información del XML de respuesta
        /// del WS Enlace Fiscal
        /// </summary>
        /// <param name="objNominaControlCFDI">Objeto Nomina Control v1.2</param>
        /// <param name="strXMLResponse">Valor string del XML</param>
        /// <param name="sRutaArchivosRespuestaCFDI"></param>
        /// <param name="sRFCTenedora"></param>
        private void ObtenerValoresXMLRespuestaCancelar(Int64 IdFactura, Int64 pIdFacturaCFDI, string strXMLResponse, string Motivo, Int32 IdMotivoCance)
        {

            Version ver = new Version(System.Windows.Forms.Application.ProductVersion);
            string pxml = "";
            try
            {
                if (strXMLResponse.Contains("AckEnlaceFiscal"))
                //Obtener Estatus Respuesta del Documento XML enviado
                {
                    if (strXMLResponse.Contains(@"""estatusDocumento"":""rechazado"""))
                    {
                        Int64? pidRespuesta = 0;
                        //Metodo que almacenara la informacion que fue enviada a Timbrar
                        spSoloRespuesta1.stpFactInsFacturaCFDIErrores(IdFactura, pIdFacturaCFDI, strXMLResponse, "SAIC ", ver.ToString(), "Cancelar", OperadorBD.OperadorGlobal.NombreUsuario, ref pidRespuesta);
                        ContarNoTimbrados = 1;
                    }
                    else if (strXMLResponse.Contains(@"""estatusDocumento"":""aceptado"""))
                    {
                        //Metodo que almacenara la informacion que fue enviada a Timbrar
                        int? pRespuesta = 0;
                        spSoloRespuesta1.stpFactUpdFacturaCFDICancelar(IdFactura, pIdFacturaCFDI, strXMLResponse, Motivo, "SAIC Windows", ver.ToString(), OperadorBD.OperadorGlobal.NombreUsuario, ref pRespuesta, ref pxml);
                        ContarTimbrados = Convert.ToInt32(pRespuesta);
                    }

                    //Crear archivo XML desde un string
                    pathXmlFiles = string.Format(@"{0}\F{1}_CANCELACION_SOAP.json", sRutaArchivosRespuestaCFDI + "\\", IdFactura.ToString());
                    File.WriteAllText(pathXmlFiles, strXMLResponse, Encoding.UTF8);

                    if (pxml != "")
                    {
                        XmlDocument xdocR = new XmlDocument();
                        xdocR.LoadXml(pxml);
                        xdocR.Save(string.Format(@"{0}\CANCELACION_F{1}.xml", sRutaArchivosRespuestaCFDI, IdFactura));
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CancelarTimbre(long IdFactura, Int32 IdFronting, long pIdFacturaCFDI, String Motivo, string Serie, long IdFacturaRela, Int32 IdMotivoCance)
        {
            string pUsuarioCFDI = "";
            string pContrasenaCFDI = "";
            string APIKEY = "";
            string dtHoraInicial = DateTime.Now.ToLongTimeString();

            string sArchivo = "";
            //Generar carpeta para colocar archivos XML Cancelados
            sRutaArchivosCFDI = compNominaCFDI.AccesoIO.ValidarCrearDirectorioCFactura(@"C:\BPOCFDI\FACTURAS", "CANCELACION_" + IdFactura.ToString(), Serie, compNominaCFDI.AccesoIO.ISO_Date());
            sRutaArchivosRespuestaCFDI = compNominaCFDI.AccesoIO.ValidarCrearDirectorioRespuestaCFDI(sRutaArchivosCFDI + @"\XMLCancelados\");


            Version ver = new Version(System.Windows.Forms.Application.ProductVersion);
            //Obtener el Usuario y Contraseña de la Tenedora activa en el Lote
            this.spSoloRespuesta1.stpFactSelSeguridadCFDIFacturasAPI(IdFronting, ref pUsuarioCFDI, ref pContrasenaCFDI, ref APIKEY);

            //obtener Cancelacion = FolioRecibo
            this.spSoloRespuesta1.stpFactSelGenerarCancelarFacturaV2(IdFactura, IdFacturaRela, IdMotivoCance, Motivo, OperadorBD.OperadorGlobal.NombreUsuario, ref sArchivo);

            //TODO: Instrucciones para crear Archivo XML CFDI
            //Crear archivo XML desde un string

            //StreamWriter xdoc = new StreamWriter(string.Format(@"{0}\F{1}_Solicitud.json", sRutaArchivosCFDI, IdFactura));
            //xdoc.Write(sArchivo);

            pathXmlFiles = string.Format(@"{0}\F{1}_Solicitud.json", sRutaArchivosCFDI + "\\", IdFactura.ToString());
            File.WriteAllText(pathXmlFiles, sArchivo, Encoding.UTF8);

            if (sArchivo != "" && sArchivo != null)
            {
                //string URL = "https://api.enlacefiscal.com/v6/probarConexion?";
                string URL = "https://api.enlacefiscal.com/v6/cancelarCfdi";
                string sDATA = sArchivo; // @"{""Solicitud"" : { ""rfc"" : """ + pUsuarioCFDI + @""", ""accion"": ""probarConexion"" } }";
                var Base64Encode = System.Text.Encoding.UTF8.GetBytes(string.Format("{0}:{1}", pUsuarioCFDI, pContrasenaCFDI));
                string strUserPWDX64 = System.Convert.ToBase64String(Base64Encode);


                HttpWebRequest request = WebRequest.Create(URL) as HttpWebRequest;
                WebHeaderCollection headers = new WebHeaderCollection();
                headers.Add("Authorization", "Basic " + strUserPWDX64);
                headers.Add("x-api-key:" + APIKEY);
                request.Headers.Add(headers);
                request.Method = "POST";
                request.ContentType = "application/json"; //"application/x-www-form-urlencoded"; //

                byte[] buffer = Encoding.UTF8.GetBytes(sDATA);
                request.ContentLength = buffer.Length;

                //iniciar la petición para enviar datos
                using (Stream oStream = request.GetRequestStream())
                {
                    oStream.Write(buffer, 0, buffer.Length);
                }
                try
                {
                    WebResponse webResponse = request.GetResponse();
                    Stream webStream = webResponse.GetResponseStream();
                    StreamReader responseReader = new StreamReader(webStream);
                    string response = responseReader.ReadToEnd();
                    responseReader.Close();

                    //Método que recibe el XML de respuesta del WSEnlaceFiscal
                    ObtenerValoresXMLRespuestaCancelar(IdFactura, pIdFacturaCFDI, response, Motivo, IdMotivoCance);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("¡Problema al construir solicitud, Intentelo mas tarde!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CargarCombos()
        {
            splashSMProcesando.ShowWaitForm();
            splashSMProcesando.SetWaitFormDescription("Cargando Facturas");
            this.stpFactSelHeaderFacturasTimbrarTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelHeaderFacturasTimbrar, 3, "", "", OperadorBD.OperadorGlobal.IdOperador, IdFactura);
            //cbFacturas.EditValue = -1;
            Limpiar();
            if (splashSMProcesando.IsSplashFormVisible) { splashSMProcesando.CloseWaitForm(); }
        }

        private void Filtro()
        {
            ColumnView view = dgvFacturas;
            ViewColumnFilterInfo viewFilterInfo = new ViewColumnFilterInfo(view.Columns["IdSolicitudFactura"],
            new ColumnFilterInfo("[IdSolicitudFactura] = " + IdSolicitudFactura.ToString(), ""));
            dgvFacturas.ActiveFilter.Add(viewFilterInfo);
        }

        private void frmAdmonFacturas_Load(object sender, EventArgs e)
        {
            try
            {
                ///Activar Botones 
                this.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1.Fill(this.dbSAICBPOFactura.stpFactSelDerechosAccesoOperadorFacturacion, OperadorBD.OperadorGlobal.IdOperador, "Facturas.frmAdmonFacturas", "btnCancelarFactura");
                this.stpFactSelUsoCFDITableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelUsoCFDI, 3, "", 0, 0);

                if (this.dbSAICBPOFactura.stpFactSelDerechosAccesoOperadorFacturacion.Count > 0)
                {
                    DataRow row = this.dbSAICBPOFactura.stpFactSelDerechosAccesoOperadorFacturacion.Rows[0];
                    PTimbrar = (bool)row[15];
                }
                else
                {
                    PTimbrar = false;
                }

                this.stpFactSelHeaderFacturasTimbrarTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelHeaderFacturasTimbrar, 3, "", "", OperadorBD.OperadorGlobal.IdOperador, IdFactura);

                // Set column widths according to their contents. 
                cbFacturas.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cbFacturas.Properties.PopupFormWidth = 900;

                if (IdSolicitudFactura != 0 && IdFactura != 0)
                {
                    Filtro();
                }

                AsignarFechaDeEmision();
                AsignarFechaFinal();

                if (OperadorBD.OperadorGlobal.IdAreaOperativa == 1)
                {
                    simpleButton1.Visible = true;
                }
                else
                {
                    simpleButton1.Visible = false;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Boolean flagConTimbradoAnterior = false;
        private void cbFacturas_EditValueChanged(object sender, EventArgs e)
        {
            splashSMProcesando.ShowWaitForm();
            bool Timbrado = false, control = false, contabilizado = false, facturas = false;
            Int64 IdControl = 0;
            ContarNoTimbrados = 0;
            ContarTimbrados = 0;

            try
            {
                //Limpiar();
                IdFacturas = 0;
                DataRow row = null;
                //obtener el renglon completo del Combobox
                if (!ActualizarCombo)
                    row = dgvFacturas.GetDataRow(dgvFacturas.FocusedRowHandle);
                else
                    row = dgvFacturas.GetDataRow(Header);

                if (row != null)
                {
                    //asignar valores extraidos del Combobox
                    txtIdSolicitud.Text = row[1].ToString();
                    txtFronting.Text = row[4].ToString();
                    txtBeneficiario.Text = row[6].ToString();
                    txtTipoBeneficiarios.Text = row[8].ToString();
                    txtUsoCFDI.EditValue = Convert.ToInt32(row[48].ToString());
                    idUsoCFDI = Convert.ToInt32(row[48].ToString());
                    txtMetodoPago.Text = row[10].ToString();
                    txtFormaPago.Text = row[13].ToString().ToUpper();
                    txtBancoOrigen.Text = row[29].ToString();
                    txtCuentaOrigen.Text = row[45].ToString();
                    txtBancoDestino.Text = row[31].ToString();
                    txtTotalDeposito.Text = Convert.ToDecimal(row[24].ToString()).ToString("C");
                    txtFechaPago.Text = Convert.ToDateTime(row[16].ToString()).ToShortDateString();
                    txtMoneda.Text = row[14].ToString();
                    txtTipoCambio.Text = Convert.ToDecimal(row[15].ToString()).ToString("C");
                    txtMesAno.Text = row[38].ToString().Length > 1 ? row[38].ToString() : "0" + row[38].ToString() + "/" + row[37].ToString();
                    txtEstatus.Text = row[26].ToString();
                    txtOperador.Text = row[34].ToString();
                    idTipoFactura = row[42].ToString();
                    Estatus = Convert.ToInt32(row[43].ToString());
                    IdControl = Convert.ToInt64(row[2]);
                    IdFacturas = Convert.ToInt64(row[0]);
                    txtSerie.Text = row[47].ToString() + '-' + row[46].ToString();
                    txtProducto.Text = row[49].ToString();
                    idTipoBeneficiario = Convert.ToInt32(row[7].ToString());
                    IdBeneficiario = Convert.ToInt32(row[5].ToString());
                    IdFronting = Convert.ToInt32(row[3].ToString());
                    txtPeriodicidad.Text = row[55].ToString();

                    if (!ActualizarCombo)
                        Header = dgvFacturas.FocusedRowHandle;

                    if (row[40].ToString() != "")
                        Timbrado = false;
                    else
                        Timbrado = true;

                    if (row[37].ToString() != "0")
                    {
                        contabilizado = false;
                        chkContabilizado.Checked = true;
                    }
                    else
                    {
                        chkContabilizado.Checked = false;
                        contabilizado = true;
                    }

                    if (row[32].ToString() != "0")
                        btnComprobante.Enabled = true;
                    else
                        btnComprobante.Enabled = false;

                    this.stpFactSelControlOperacionesFacturasTableAdapter1.Fill(dbSAICBPOFactura.stpFactSelControlOperacionesFacturas, IdFacturas);
                    this.stpFactSelFacturasARelacionarSATTableAdapter.Fill(dbSAICBPOFactura.stpFactSelFacturasARelacionarSAT, 0, 0, 0, "", IdFacturas, 0);

                    //*****Saber si la factura tiene facturas relacionadas con "Sustitución de los CFDI previos"
                    bool? iQuery = false;
                    string bEstatus = "";
                    this.spSoloRespuesta1.stpFactSelObtenerbFalgSusti(IdFacturas, ref iQuery, ref bEstatus);

                    oFacturaRelacionada.flagConRelacion = Convert.ToBoolean(iQuery);

                    if (oFacturaRelacionada.flagConRelacion)
                    {
                        oFacturaRelacionada.sTipoRelacion = "Sustitución de los CFDI previos";
                        oFacturaRelacionada.sDescEstatus = bEstatus;
                    }
                    else
                    {
                        oFacturaRelacionada.sTipoRelacion = String.Empty;
                        oFacturaRelacionada.sDescEstatus = String.Empty;
                    }

                    //*****Saber si la factura tiene facturas relacionadas con "Sustitución de los CFDI previos"
                    this.stpFactSelDetailFacturasTableAdapter.Fill(dbSAICBPOFactura.stpFactSelDetailFacturas, IdFacturas);
                    this.spSoloRespuesta1.stpFactUpdSolicitudFactura(Convert.ToInt64(txtIdSolicitud.Text), OperadorBD.OperadorGlobal.NombreUsuario);

                    this.stpFactSelConceptoTenedoraBeneficiarioFiltroTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelConceptoTenedoraBeneficiarioFiltro, 2, idTipoBeneficiario, IdBeneficiario, idUsoCFDI, IdFronting, false);

                    ActivarBotones(Timbrado, control, facturas, contabilizado);

                    flagConTimbradoAnterior = txtSerie.Text == "-" ? true : false;
                    //dtFechaIni.Text = 
                    dtFechaIni.Enabled = flagConTimbradoAnterior;

                    if (!flagConTimbradoAnterior)
                    {
                        DateTime dtFechaEmisonTabla;
                        DateTime.TryParse(row[52].ToString(), out dtFechaEmisonTabla);
                        dtFechaIni.Text = dtFechaEmisonTabla.ToShortDateString();
                    }
                    if (splashSMProcesando.IsSplashFormVisible) { splashSMProcesando.CloseWaitForm(); }
                }
                else
                {
                    Header = -1;
                    OcultarBotones(false); //Activar Botones
                    if (splashSMProcesando.IsSplashFormVisible) { splashSMProcesando.CloseWaitForm(); }
                    XtraMessageBox.Show("¡Debe de Seleccionar una Factura!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                if (splashSMProcesando.IsSplashFormVisible) { splashSMProcesando.CloseWaitForm(); }
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Close(); //Salir
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            try
            {
                //obtener el renglon completo del Combobox
                if (cbFacturas.EditValue != null)
                {
                    DataRow Row = dgvFacturas.GetDataRow(Header);
                    if (Row != null)
                    {
                        DateTime fefin = DateTime.Now.Date.AddDays(-3);
                        if (Convert.ToDateTime(dtFechaIni.Text) >= fefin)
                        {
                            Timbrar(Convert.ToInt64(Row[0].ToString()), Convert.ToInt32(Row[3].ToString()));
                            if (ContarNoTimbrados == 1)
                                XtraMessageBox.Show("¡Error al Timbrar Factura!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else if (ContarTimbrados == 1)
                                XtraMessageBox.Show("¡Se timbro Correctamente la Factura!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ContarNoTimbrados = 0;
                            ContarTimbrados = 0;
                        }
                        else
                            XtraMessageBox.Show("¡La fecha es Inorrecta!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    OcultarBotones(false); //Activar Botones
                    XtraMessageBox.Show("¡Debe de Seleccionar una Factura!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                CargarCombos();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarTimbre_Click(object sender, EventArgs e)
        {
            string Serie = "";
            try
            {
                Boolean flagtaMuyBien = true;

                if (oFacturaRelacionada.sTipoRelacion == "Sustitución de los CFDI previos")
                {
                    if (oFacturaRelacionada.sDescEstatus == "FACTURA TIMBRADA")
                    {
                        flagtaMuyBien = true;
                    }
                    else
                    {
                        flagtaMuyBien = false;
                    }
                }

                if (flagtaMuyBien)
                {
                    //obtener el renglon completo del Combobox
                    if (cbFacturas.EditValue != null)
                    {
                        DataRow Row = dgvFacturas.GetDataRow(Header);
                        if (Row != null)
                        {
                            if (Convert.ToInt64(Row[2].ToString()) <= 0)
                            {
                                Facturas.frmCancelarFactura objAsignarXML = new Facturas.frmCancelarFactura()
                                {
                                    pIdSolicitud = IdFacturas
                                    ,
                                    flagConRelacion = oFacturaRelacionada.flagConRelacion
                                    ,
                                    pIdFacturaRela = oFacturaRelacionada.idHeaderFactura_FacturaRelacion
                                };
                                objAsignarXML.ShowDialog();     //mostrar pantalla
                                if (objAsignarXML.pflag && objAsignarXML.pIdMotivoCancela > 0 && objAsignarXML.pRespuesta != "")
                                {
                                    Serie = Row[47].ToString() + '_' + Row[46].ToString();

                                    CancelarTimbre(Convert.ToInt64(Row[0].ToString()), Convert.ToInt32(Row[3].ToString()), Convert.ToInt64(Row[36].ToString()), objAsignarXML.pRespuesta, Serie, objAsignarXML.pIdFacturaRela, objAsignarXML.pIdMotivoCancela);
                                    if (ContarNoTimbrados == 1)
                                        XtraMessageBox.Show("¡Error al Cancelar Timbre de la Factura!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    else if (ContarTimbrados == 1)
                                        XtraMessageBox.Show("¡Se Cancelo Correctamente el Timbre de la Factura!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ContarNoTimbrados = 0;
                                    ContarTimbrados = 0;
                                    CargarCombos();
                                }
                            }
                            else
                            {
                                XtraMessageBox.Show("¡La Factura pertence a  un Control de Operaciones!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CargarCombos();
                            }
                        }
                    }
                    else
                    {
                        OcultarBotones(false); //Activar Botones
                        XtraMessageBox.Show("¡Debe de Seleccionar una Factura!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    XtraMessageBox.Show("La factura no puede ser cancelada, ya que la factura con relación por sustitución no está timbrada (ver Facturas Relacionadas SAT).",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            try
            {
                string sArchivo = "";
                string sRutaArchivosCFDI = "";
                //obtener el renglon completo del Combobox
                if (cbFacturas.EditValue != null)
                {
                    //obtener la ruta RAIZ en dónde se almacenarán los archivos PDF y XML
                    string strRutaArchivosXML = this.validacionesGeneralTableAdapter1.ObtenerValorParametro("FOLDER_RECIBOS_PAGOS").ToString();

                    //Crear archivo Comprobante
                    DataRow row = dgvFacturas.GetDataRow(Header);
                    if (row != null)
                    {

                        this.spSoloRespuesta1.stpFactSelComprobantePago(Convert.ToInt64(row[0].ToString()), ref sArchivo);
                        Byte[] bytes = Convert.FromBase64String(sArchivo);

                        //Generar carpeta para colocar archivos XML
                        sRutaArchivosCFDI = compNominaCFDI.AccesoIO.ValidarCrearDirectorioCPago(strRutaArchivosXML, row[0].ToString(), compNominaCFDI.AccesoIO.ISO_Date());
                        sRutaArchivosCFDI = string.Format(@"{0}\COMPROBANTE_PAGO.pdf", sRutaArchivosCFDI);
                        File.WriteAllBytes(sRutaArchivosCFDI, bytes);
                        XtraMessageBox.Show("¡El Archivo se descargo Correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                }
                else
                {
                    XtraMessageBox.Show("¡Debe de Seleccionar una Factura!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnContabilizar_Click(object sender, EventArgs e)
        {

            Int32 pIdCliente = 0, pIdFronting = 0;
            try
            {
                //Crear archivo Comprobante
                DataRow row = dgvFacturas.GetDataRow(dgvFacturas.FocusedRowHandle);// Header);
                if (row != null)
                {
                    ActualizarCombo = true;
                    pIdCliente = Convert.ToInt32(row[5].ToString());
                    pIdFronting = Convert.ToInt32(row[3].ToString());

                    Facturas.frmContabilizarFactura objAsignarXML = new Facturas.frmContabilizarFactura()
                    {
                        pIdFactura = IdFacturas
                    };

                    objAsignarXML.ShowDialog();     //mostrar pantalla
                }
                else
                    XtraMessageBox.Show("¡Debe de Seleccionar una Factura!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarCombos();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDescontabilizar_Click(object sender, EventArgs e)
        {
            int? pOk = 0;
            try
            {
                //Crear archivo Comprobante
                DataRow row = dgvFacturas.GetDataRow(dgvFacturas.FocusedRowHandle);// Header);
                if (IdFacturas > 0)
                {
                    if (XtraMessageBox.Show(String.Format("¿Está seguro que desea Descontabilizar la Factura {0}?", IdFacturas), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.spSoloRespuesta1.stpFactDelContabilizarFactura(IdFacturas, OperadorBD.OperadorGlobal.NombreUsuario, ref pOk);
                        if (pOk == 1)
                        {
                            XtraMessageBox.Show("¡La Descontabilización de la Factura fue exitosa!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            XtraMessageBox.Show("¡Error al Descontabilización la Factura, intentelo mas tarde!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    XtraMessageBox.Show("¡Debe de Seleccionar una Factura!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarCombos();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            string sRutaArchivosCFDI = "";
            string sRutaArchivosPDF = "";
            string Serie = "";
            int ptipoRelacion = 0;
            string pIdTipoFactura = "N";
            Estructuras.InformacionError objError;      //variable que recibe comportamiento de la exportacion

            //si existen Lotes de Carga de Nomina en el gridview
            if (cbFacturas.EditValue != null)
            {
                //Obtener el Id del Lote de Carga Nomina
                //para asignarlo a los recibos
                DataRow row = dgvFacturas.GetDataRow(dgvFacturas.FocusedRowHandle);
                if (row != null)     //si seleccionamos un Lote de Carga Nomina
                {
                    //obtener la ruta RAIZ en dónde se almacenarán los archivos PDF y XML
                    string strRutaArchivosXML = this.validacionesGeneralTableAdapter1.ObtenerValorParametro("FOLDER_XML_FACTURA_CFDI").ToString();

                    Serie = row[47].ToString() + '_' + row[46].ToString();
                    ptipoRelacion = Convert.ToInt32(row[22].ToString());
                    pIdTipoFactura = row[42].ToString();

                    this.stpFactSelComprobantesFacturaTableAdapter1.Fill(this.dbSAICBPOFactura.stpFactSelComprobantesFactura, Convert.ToInt64(row[0].ToString()), Convert.ToInt64(row[36].ToString()));
                    row = null;
                    if (this.dbSAICBPOFactura.stpFactSelComprobantesFactura.Count > 0)
                        row = this.dbSAICBPOFactura.stpFactSelComprobantesFactura.Rows[0];
                    if (row != null)
                    {
                        Byte[] bytes = Convert.FromBase64String(row[2].ToString());
                        //Generar carpeta para colocar archivos XML
                        sRutaArchivosCFDI = compNominaCFDI.AccesoIO.ValidarCrearDirectorioCFactura(strRutaArchivosXML, row[0].ToString(), Serie, compNominaCFDI.AccesoIO.ISO_Date());

                        sRutaArchivosPDF = string.Format(@"{0}\FACTURA{1}.pdf", sRutaArchivosCFDI, row[1].ToString());
                        sRutaArchivosCFDI = string.Format(@"{0}\FACTURA{1}.xml", sRutaArchivosCFDI, row[1].ToString());
                        File.WriteAllBytes(sRutaArchivosCFDI, bytes);

                        if (ptipoRelacion == 11 || pIdTipoFactura == "R")
                            objError = GenerarReporteRecibo(Convert.ToInt64(row[0].ToString()), sRutaArchivosPDF);
                        else
                            objError = GenerarReporte(Convert.ToInt64(row[0].ToString()), sRutaArchivosPDF);

                        if (objError.existeError == false)
                            XtraMessageBox.Show("La Factura se descargo Correctamente. " + strRutaArchivosXML, "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                else
                    XtraMessageBox.Show("Seleccione una Factura", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                XtraMessageBox.Show("Seleccione una Factura.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private Estructuras.InformacionError GenerarReporte(Int64 idFactura, string sRutaArchivosPDF)
        {
            //inicializar valores de objError
            Estructuras.InformacionError objError = new Estructuras.InformacionError { existeError = false, noError = 0, mensajeError = String.Empty };

            //crear reporte
            ReciboFacturacion report = new ReciboFacturacion();
            try
            {
                //asignar parametros del reporte
                report.Parameters["pIdFactura"].Value = idFactura;
                report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes
                // Asignar opciones de Exportacion
                PdfExportOptions pdfOptions = report.ExportOptions.Pdf;
                pdfOptions.Compressed = true;
                pdfOptions.ImageQuality = PdfJpegImageQuality.Highest;
                pdfOptions.NeverEmbeddedFonts = "Tahoma;Courier New";
                //pdfOptions.DocumentOptions.Application = String.Format("{0} {1}", objNominaControlCFDI.SoftwareNombre, objNominaControlCFDI.SoftwareVersion);
                pdfOptions.DocumentOptions.Author = "Gabriela Rodriguez C.";
                pdfOptions.DocumentOptions.Keywords = "Recibo, Facturación, CFDI";
                pdfOptions.DocumentOptions.Title = "Recibo Facturación CFDI";

                // Exportar reporte a PDF
                report.ExportToPdf(sRutaArchivosPDF);
            }
            catch (Exception ex)
            {
                objError.existeError = true;
                objError.noError = -99;
                objError.mensajeError = ex.Message;
            }
            return objError;        //regresar estatus OK o ERROR
        }

        private Estructuras.InformacionError GenerarReporteRecibo(Int64 idFactura, string sRutaArchivosPDF)
        {
            //inicializar valores de objError
            Estructuras.InformacionError objError = new Estructuras.InformacionError { existeError = false, noError = 0, mensajeError = String.Empty };

            //crear reporte
            ReciboFacturacionRecibo report = new ReciboFacturacionRecibo();
            try
            {
                //asignar parametros del reporte
                report.Parameters["pIdFactura"].Value = idFactura;
                report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes
                // Asignar opciones de Exportacion
                PdfExportOptions pdfOptions = report.ExportOptions.Pdf;
                pdfOptions.Compressed = true;
                pdfOptions.ImageQuality = PdfJpegImageQuality.Highest;
                pdfOptions.NeverEmbeddedFonts = "Tahoma;Courier New";
                //pdfOptions.DocumentOptions.Application = String.Format("{0} {1}", objNominaControlCFDI.SoftwareNombre, objNominaControlCFDI.SoftwareVersion);
                pdfOptions.DocumentOptions.Author = "Gabriela Rodriguez C.";
                pdfOptions.DocumentOptions.Keywords = "Recibo, Facturación, REP";
                pdfOptions.DocumentOptions.Title = "Recibo Facturación REP";

                // Exportar reporte a PDF
                report.ExportToPdf(sRutaArchivosPDF);
            }
            catch (Exception ex)
            {
                objError.existeError = true;
                objError.noError = -99;
                objError.mensajeError = ex.Message;
            }
            return objError;        //regresar estatus OK o ERROR
        }

        private void MostrarReporte()
        {
            //crear reporte
            ReciboFacturacion report = new ReciboFacturacion();
            try
            {
                //asignar parametros del reporte
                report.Parameters["pIdFactura"].Value = IdFacturas;

                report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes

                //mostrar reporte
                report.ShowPreview();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarFactura_Click(object sender, EventArgs e)
        {
            try
            {
                //Crear archivo Comprobante
                DataRow row = dgvFacturas.GetDataRow(dgvFacturas.FocusedRowHandle);// Header);
                if (row != null)
                {
                    ActualizarCombo = true;
                    if (row[2].ToString() != "0" && row[2].ToString() != "-1")
                    {
                        Facturas.frmCancelarFactura objAsignarXML = new Facturas.frmCancelarFactura()
                        {
                            pIdSolicitud = IdFacturas
                            ,
                            flagConRelacion = true
                        };
                        objAsignarXML.ShowDialog();     //mostrar pantalla
                    }
                    else
                        XtraMessageBox.Show("¡La Factura está vinculada a un Control de Operaciones!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    XtraMessageBox.Show("¡Debe de Seleccionar una Factura!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarCombos();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFacturas_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {

        }

        private void txtBeneficiario_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtFechaIni_ValueChanged(object sender, EventArgs e)
        {
            DateTime dtFechaEmision;
            DateTime.TryParse(dtFechaIni.Text, out dtFechaEmision);
            //validar Fecha Futura
            if (dFechaInicial.AddDays(1).ToShortDateString() == dtFechaEmision.ToShortDateString())
            {
                XtraMessageBox.Show("No se puede seleccionar Fechas Futuras.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (flagConTimbradoAnterior)
                {
                    AsignarFechaDeEmision();
                }
            }
            else
            {
                if (dtFechaEmision.Date < dtFechaFinal.Date)
                {
                    if (dtFechaIni.Enabled)
                    {
                        XtraMessageBox.Show("Fecha de Emision excede las 72 horas.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (flagConTimbradoAnterior)
                        {
                            AsignarFechaDeEmision();
                        }
                    }
                }
            }
        }

        private void btnConcepto_Click(object sender, EventArgs e)
        {
            try
            {
                if (IdBeneficiario > 0)
                {
                    if (Validator.IsPresent(txtUsoCFDI))
                    {
                        //Crear archivo Comprobante
                        DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);// Header);
                        if (row != null)
                        {
                            Facturas.frmActualizarConceptos objAsignarXML = new Facturas.frmActualizarConceptos()
                            {
                                pIdDetaill = Convert.ToInt64(row[0].ToString()),
                                pCantidad = Convert.ToDecimal(row[2].ToString()),
                                pIdUnidad = Convert.ToInt32(row[3].ToString()),
                                pIdUsoCFDI = Convert.ToInt32(txtUsoCFDI.EditValue.ToString()),
                                pIdFronting = IdFronting,
                                pIdTipoBeneficiario = idTipoBeneficiario,
                                pIdBeneficiario = IdBeneficiario
                            };
                            objAsignarXML.ShowDialog();     //mostrar pantalla
                        }
                        else
                            XtraMessageBox.Show("¡Debe de Seleccionar un Concepto!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVisualizarErrores_Click(object sender, EventArgs e)
        {

            //si existe lote de nómna valido
            if (cbFacturas.EditValue != null)
            {
                DataRow row = dgvFacturas.GetDataRow(Header);
                if (row != null)
                {
                    //crear objeto y pasar el valor de la propiedad pIdLoteCargaNomina
                    Facturas.frmxErroresTimbradoCFDIFactura objFrmErroresTimbrado = new Facturas.frmxErroresTimbradoCFDIFactura() { pIdFactura = Convert.ToInt64(row[0].ToString()), pIdTipoError = 1 };

                    objFrmErroresTimbrado.ShowDialog();     //mostrar pantalla
                }
            }
            else
                XtraMessageBox.Show("¡Para visualizar los errores de timbrado, debe seleccionar un Lote de Nómina!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(sRutaArchivosCFDI))
            {
                Process.Start(sRutaArchivosCFDI);
            }
        }

        private void txtUsoCFDI_EditValueChanged(object sender, EventArgs e)
        {
            this.stpFactSelConceptoTenedoraBeneficiarioFiltroTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelConceptoTenedoraBeneficiarioFiltro, 2, idTipoBeneficiario, IdBeneficiario, idUsoCFDI, IdFronting, false);
        }


        private void AsignarFechaDeEmision()
        {
            //AsignarFecha de Hoy
            String stFechaincial = String.Empty;

            stFechaincial = stpSelEstatusNominaContabilizadaTableAdapter1.ObtenerFechaServidor().ToString();
            DateTime.TryParse(stFechaincial, out dFechaInicial);

            if (dFechaInicial.Date.ToShortDateString() == "01/01/0001") { dtFechaIni.Text = DateTime.Now.ToShortDateString(); }
            else
            {
                dtFechaIni.Text = dFechaInicial.ToShortDateString();
            }
        }

        private void AsignarFechaFinal()
        {
            String stNumdeDias = String.Empty;
            int iNumdeDias = 3;
            stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "FechaEmision_DiasAtras");

            if (dbSAICBPOValidacionDataSet1.stpSelParametro.Count > 0)
            {
                int.TryParse(dbSAICBPOValidacionDataSet1.stpSelParametro[0]["ValorParametro"].ToString(), out iNumdeDias);
            }
            iNumdeDias = iNumdeDias * -1;
            dtFechaFinal = dFechaInicial.AddDays(iNumdeDias);
        }
    }



    public class FacturaRelacionada
    {
        public FacturaRelacionada()
        {
            idHeaderFactura_FacturaRelacion = 0;
            IdFacturas = 0;
            idEstatus = 0;
            sDescEstatus = String.Empty;
            flagConRelacion = false;
            sTipoRelacion = String.Empty;
        }
        public int idHeaderFactura_FacturaRelacion { get; set; }
        public int IdFacturas { get; set; }
        public int idEstatus { get; set; }
        public String sDescEstatus { get; set; }
        public Boolean flagConRelacion { get; set; }
        public String sTipoRelacion { get; set; }
    }
}
