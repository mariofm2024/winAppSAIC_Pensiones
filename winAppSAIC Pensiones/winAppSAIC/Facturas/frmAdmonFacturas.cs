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
using DevExpress.XtraGrid.Views.Grid;

namespace winAppSAIC.Facturas
{
    public partial class frmAdmonFacturas : DevExpress.XtraEditors.XtraForm
    {
        public Int64 IdSolicitudFactura = 0;
        public Int64 IdFactura = 0;
        private Int64 IdFacturas = 0;
        private Int32 Header = 0;
        private Int32 Estatus = 0;
        private string sRutaArchivosCFDI;
        private string sRutaArchivosRespuestaCFDI;
        private APIEF apiEF;
        private string pathXmlFiles;
        private bool ActualizarCombo = false;
        private bool PTimbrar = false; //Habilitar
        private bool PContabilizar = false; //Actualizar
        private bool PControles = false; //Insertar
        private bool PFacturas = false; //Eliminar
        public frmAdmonFacturas()
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
                btnDescargar.Visible = !bflagTimbre;
                if (PControles)
                {
                    btnVinvularControl.Visible = bflagVinvular;
                    btnDesvincularControl.Visible = !bflagVinvular;
                }
                else
                {
                    btnVinvularControl.Visible = false;
                    btnDesvincularControl.Visible = false;
                }
                if (PFacturas)
                {
                    btnVicularFacturas.Visible = bflagFactura;
                    btnDesvincularFacturas.Visible = !bflagFactura;
                }
                else
                {
                    btnVicularFacturas.Visible = false;
                    btnDesvincularFacturas.Visible = false;
                }

            }
            else
            {

                btnDescargar.Visible = false;

                btnVinvularControl.Visible = false;
                btnDesvincularControl.Visible = false;

                btnVicularFacturas.Visible = false;
                btnDesvincularFacturas.Visible = false;
            }
        }

        private void OcultarBotones(bool bflag)
        {
            btnDescargar.Visible = bflag;
            btnVinvularControl.Visible = bflag;
            btnDesvincularControl.Visible = bflag;
            btnDesvincularFacturas.Visible = bflag;
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
            txtBancoDestino.Text = string.Empty;
            txtTotalDeposito.Text = string.Empty;
            txtFechaPago.Text = string.Empty;
            txtMoneda.Text = string.Empty;
            txtTipoCambio.Text = string.Empty;
            txtMesAno.Text = string.Empty;
            txtMesAno.Text = string.Empty;
            txtSerie.Text = string.Empty;
            btnComprobante.Enabled = false;
            chkContabilizado.Checked = false;
            this.dbSAICBPOFactura.stpFactSelControlOperacionesFacturas.Clear();
            this.dbSAICBPOFactura.stpFactSelDetailFacturas.Clear();
            this.dbSAICBPOFactura.stpFactSelFacturasARelacionar.Clear();
            this.dbSAICBPOFactura.stpFactSelFacturasARelacionarSAT.Clear();
            txtTControl.Text = string.Empty;
            txtTFacS.Text = string.Empty;
            txtTTFac.Text = string.Empty;
        }

        private void Totales(Int32 IdFactura)
        {
            Decimal TotalControl = 0, TotalFactura = 0, Saldo = 0;

            DataRow row = null;

            row = dgvFacturas.GetDataRow(IdFactura);
            TotalFactura = TotalFactura + Convert.ToDecimal(row[19].ToString());


            row = null;
            for (int i = 0; i < gridView2.DataRowCount; i++)
            {
                row = gridView2.GetDataRow(i);
                TotalControl = TotalControl + Convert.ToDecimal(row[26].ToString());
            }

            row = null;
            for (int i = 0; i < gridView3.DataRowCount; i++)
            {
                row = gridView3.GetDataRow(i);
                if (row[25].ToString() != "28")
                    TotalFactura = TotalFactura + Convert.ToDecimal(row[19].ToString());
            }

            Saldo = TotalFactura - TotalControl;

            txtTControl.Text = TotalControl.ToString("C");
            txtTFacS.Text = TotalFactura.ToString("C");
            txtTTFac.Text = Saldo.ToString("C");

            if (Saldo < 0)
                txtTTFac.ForeColor = Color.Red;
            else
                txtTTFac.ForeColor = Color.Black;
        }

        private void Timbrar(long IdFactura, Int32 IdFronting)
        {
            string pUsuarioCFDI = "";
            string pContrasenaCFDI = "";
            long pNoFolioSiguiente = 0;
            string dtHoraInicial = DateTime.Now.ToLongTimeString();
            string dtHoraFinal = "";
            long pIdFacturaCFDI = 0;
            string sArchivo = "";

            try
            {
                //Obtener el Usuario y Contraseña de la Tenedora activa en el Lote
                this.seguridadTableAdapter1.stpSelSeguridadCFDI(IdFronting, ref pUsuarioCFDI, ref pContrasenaCFDI);
                //Se especifican las credenciales de acceso creando una instancia a la clase APIEF
                apiEF = new APIEF(pUsuarioCFDI, pContrasenaCFDI);
                //obtener el No. de Items seleccionados

                splashSMProcesando.ShowWaitForm();        //mostrar pantalla de espera
                this.Cursor = Cursors.AppStarting;      //cambiar cursor del mouse
                                                        //obtener la ruta RAIZ en dónde se almacenarán los archivos PDF y XML
                string strRutaArchivosXML = this.validacionesGeneralTableAdapter1.ObtenerValorParametro("FOLDER_XML_FACTURA_CFDI").ToString();

                //Generar carpeta para colocar archivos XML
                sRutaArchivosCFDI = compNominaCFDI.AccesoIO.ValidarCrearDirectorioCFDI(strRutaArchivosXML, cbFacturas.EditValue.ToString(), compNominaCFDI.AccesoIO.ISO_Date());
                sRutaArchivosRespuestaCFDI = compNominaCFDI.AccesoIO.ValidarCrearDirectorioRespuestaCFDI(sRutaArchivosCFDI + @"\XMLTimbrados\");

                //obtener Factra = FolioRecibo
                //  this.stpSelGenerarFacturaTableAdapter1.Fill(dbSAICBPOFactura.stpSelGenerarFactura, IdFactura, OperadorBD.OperadorGlobal.IdOperador, OperadorBD.OperadorGlobal.NombreUsuario);

                if (true)//(dbSAICBPOFactura.stpSelGenerarFactura.Count > 0)
                {
                    DataRow Row = null;// dbSAICBPOFactura.stpSelGenerarFactura.Rows[0];
                    //Asignar Valores
                    sArchivo = Row[0].ToString();
                    pNoFolioSiguiente = Convert.ToInt64(Row[2].ToString() == string.Empty ? "0" : Row[2].ToString());

                    XmlWriterSettings settings = new XmlWriterSettings() { Indent = true, IndentChars = ("     ") };
                    pathXmlFiles = string.Format(@"{0}F{1}-{2}.xml", sRutaArchivosCFDI + "\\", IdFactura.ToString(), pNoFolioSiguiente);

                    File.WriteAllText(pathXmlFiles, sArchivo, Encoding.ASCII);

                    EnviarXML2wsPACv12(IdFactura);
                    this.Cursor = Cursors.Default;      //cambiar cursor del mouse
                    splashSMProcesando.CloseWaitForm();
                }
                else
                {
                    this.Cursor = Cursors.Default;      //cambiar cursor del mouse
                    splashSMProcesando.CloseWaitForm();
                    XtraMessageBox.Show("¡Error al Generar Factura, Contacte a Sistemas!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;      //cambiar cursor del mouse
                splashSMProcesando.CloseWaitForm();
                throw ex;
            }
        }

        private void EnviarXML2wsPACv12(Int64 IdFactura)
        {
            //Prueba de envío XML SAIC
            string documentType = "Facturacion";
            string operationType = "generar" + documentType;
            string xmlRequestString = File.ReadAllText(pathXmlFiles);
            string response = apiEF.executeOperation(xmlRequestString, operationType);
            string strXMLResponse = apiEF.FormatXml(response);

            //Método que recibe el XML de respuesta del WSEnlaceFiscal
            ObtenerValoresXMLRespuestaSueldosV12(IdFactura, strXMLResponse, sRutaArchivosRespuestaCFDI);
        }

        /// <summary>
        /// Método que obtienes la información del XML de respuesta
        /// del WS Enlace Fiscal
        /// </summary>
        /// <param name="objNominaControlCFDI">Objeto Nomina Control v1.2</param>
        /// <param name="strXMLResponse">Valor string del XML</param>
        /// <param name="sRutaArchivosRespuestaCFDI"></param>
        /// <param name="sRFCTenedora"></param>
        private void ObtenerValoresXMLRespuestaSueldosV12(Int64 IdFactura, string strXMLResponse, string sRutaArchivosRespuestaCFDI)
        {

            XDocument xmlDoc = XDocument.Parse(strXMLResponse);
            try
            {
                //Obtener Estatus Respuesta del Documento XML enviado
                var objXMLValidaEstatusDocumento = from docValido in xmlDoc.Descendants("AckEnlaceFiscal")
                                                   select new
                                                   {
                                                       estatusDocumento = docValido.Attribute("estatusDocumento").Value.ToUpper()
                                                   };

                foreach (var itemValida in objXMLValidaEstatusDocumento)
                {
                    if (itemValida.estatusDocumento.Equals("RECHAZADO"))
                    {
                        NominaTimbradoErrorCFDI objErrorTimbrado = new NominaTimbradoErrorCFDI();

                        //Obtener informacion de Rechazo
                        var objXMLRechazo = from v in xmlDoc.Descendants("AckEnlaceFiscal")
                                            select new
                                            {
                                                numeroReferencia = v.Attribute("numeroReferencia").Value,
                                                estatusDocumento = v.Attribute("estatusDocumento").Value,
                                                fechaMensaje = v.Attribute("fechaMensaje").Value,
                                                codigoError = v.Element("mensajeError").Element("codigoError").Value,
                                                descripcionError = v.Element("mensajeError").Element("descripcionError").Element("texto").Value
                                            };

                        //Mostrar valores de Rechazo
                        foreach (var itemRechazo in objXMLRechazo)
                        {
                            objErrorTimbrado.NumeroReferencia = itemRechazo.numeroReferencia;
                            objErrorTimbrado.EstatusDocumento = itemRechazo.estatusDocumento.ToUpper();
                            objErrorTimbrado.FechaMensaje = itemRechazo.fechaMensaje;
                            objErrorTimbrado.codigoError = itemRechazo.codigoError;
                            objErrorTimbrado.descripcionError = itemRechazo.descripcionError;
                        }
                        //Metodo que almacenara la informacion que fue enviada a Timbrar
                        //  Int64 IdLoteCargaNominaCFDI = InsertarBitacoraErrorXMLCFDIv12(objNominaControlCFDI, objErrorTimbrado);

                    }
                    else if (itemValida.estatusDocumento.Equals("ACEPTADO"))
                    {
                        NominaTimbradoCFDI objTimbrado = new NominaTimbradoCFDI();

                        //Obtener informacion XML Timbrado
                        var objXMLAceptado = from c in xmlDoc.Descendants("AckEnlaceFiscal")
                                             select new
                                             {
                                                 numeroReferencia = c.Attribute("numeroReferencia").Value,
                                                 estatusDocumento = c.Attribute("estatusDocumento").Value,
                                                 fechaMensaje = c.Attribute("fechaMensaje").Value,
                                                 folioInterno = c.Element("folioInterno").Value,
                                                 folioFiscalUUID = c.Element("folioFiscalUUID").Value,
                                                 serie = c.Element("serie").Value,
                                                 noSerieCertificado = c.Element("noSerieCertificado").Value,
                                                 noSerieCertificadoSAT = c.Element("noSerieCertificadoSAT").Value,
                                                 selloCFDi = c.Element("selloCFDi").Value,
                                                 selloSAT = c.Element("selloSAT").Value,
                                                 cadenaTFD = c.Element("cadenaTFD").Value,
                                                 fechaGeneracionCFDi = c.Element("fechaGeneracionCFDi").Value,
                                                 fechaTFD = c.Element("fechaTFD").Value,
                                                 estadoCFDi = c.Element("estadoCFDi").Value,
                                                 archivoQR = c.Element("archivoQR").Value,
                                                 descargaArchivoQR = c.Element("descargaArchivoQR").Value,
                                                 xmlCFDi = c.Element("xmlCFDi").Value,
                                                 descargaXmlCFDi = c.Element("descargaXmlCFDi").Value
                                             };

                        //Mostrar valores XML Timbrado
                        foreach (var itemAceptado in objXMLAceptado)
                        {
                            objTimbrado.NumeroReferencia = itemAceptado.numeroReferencia;
                            objTimbrado.EstatusDocumento = itemAceptado.estatusDocumento.ToUpper();
                            objTimbrado.FechaMensaje = itemAceptado.fechaMensaje;
                            objTimbrado.FolioInterno = itemAceptado.folioInterno;
                            objTimbrado.FolioFiscalUUID = itemAceptado.folioFiscalUUID;
                            objTimbrado.Serie = itemAceptado.serie;
                            objTimbrado.NoSerieCertificado = itemAceptado.noSerieCertificado;
                            objTimbrado.NoSerieCertificadoSAT = itemAceptado.noSerieCertificadoSAT;
                            objTimbrado.SelloCFDI = itemAceptado.selloCFDi;
                            objTimbrado.SelloSAT = itemAceptado.selloSAT;
                            objTimbrado.CadenaTFD = itemAceptado.cadenaTFD;
                            objTimbrado.FechaGeneracionCFDI = itemAceptado.fechaGeneracionCFDi;
                            objTimbrado.FechaTFD = itemAceptado.fechaTFD;
                            objTimbrado.EstadoCFDI = itemAceptado.estadoCFDi.ToUpper();

                            byte[] dataQRCode = Convert.FromBase64String(itemAceptado.archivoQR);
                            string decodedQRCode = Encoding.UTF8.GetString(dataQRCode);
                            long LongitudQRCode = itemAceptado.archivoQR.Length;

                            objTimbrado.ArchivoQR = decodedQRCode;
                            objTimbrado.UrlDescargaArchivoQR = itemAceptado.descargaArchivoQR;

                            //decodificar Contenido XML
                            byte[] data = Convert.FromBase64String(itemAceptado.xmlCFDi);
                            string decodedXmlCFDI = Encoding.UTF8.GetString(data);

                            objTimbrado.XmlCFDI = decodedXmlCFDI;
                            objTimbrado.UrlDescargaXmlCFDI = itemAceptado.descargaXmlCFDi;

                            //Metodo que almacenara la informacion que fue enviada a Timbrar
                            // Int64 IdLoteCargaNominaCFDI = InsertarBitacoraXMLCFDIv12(objNominaControlCFDI, objTimbrado);
                            //Insertar Imagen y XML de respuesta
                            //this.seguridadTableAdapter1.stpInsPDOHeaderDocumentoSACFDI(IdLoteCargaNominaCFDI, dataQRCode, decodedXmlCFDI);

                            //TODO: Instrucciones para crear Archivo XML CFDI
                            //Crear archivo XML desde un string
                            XmlDocument xdoc = new XmlDocument();
                            xdoc.LoadXml(decodedXmlCFDI);
                            xdoc.Save(string.Format(@"{0}\F{1}_{2}{3}.xml", sRutaArchivosRespuestaCFDI, IdFactura, itemAceptado.serie, itemAceptado.folioInterno));

                            //TODO: Instrucciones para generar Archivo PDF
                            string strNombreArchivoPDF = string.Format(@"{0}\F{1}_{2}{3}.pdf", sRutaArchivosRespuestaCFDI, IdFactura, itemAceptado.serie, itemAceptado.folioInterno);

                            Estructuras.InformacionError objError;      //variable que recibe comportamiento del reporte
                            Version ver = new Version(System.Windows.Forms.Application.ProductVersion);
                            objError = ExportarCFDI2PDF.GenerarTimbradosPDFactura(strNombreArchivoPDF, IdFactura, ver.ToString());
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CancelarTimbre(Int64 IdFactura)
        {

        }

        private void CargarCombos()
        {
            this.stpFactSelHeaderFacturasTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelHeaderFacturas, -1, "", "", OperadorBD.OperadorGlobal.IdOperador);
            cbFacturas.EditValue = -1;
            Limpiar();
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

                if (this.dbSAICBPOFactura.stpFactSelDerechosAccesoOperadorFacturacion.Count > 0)
                {
                    DataRow row = this.dbSAICBPOFactura.stpFactSelDerechosAccesoOperadorFacturacion.Rows[0];

                    PContabilizar = (bool)row[12];
                    PControles = (bool)row[13];
                    PFacturas = (bool)row[14];
                    PTimbrar = (bool)row[15];
                }

                this.stpFactSelHeaderFacturasTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelHeaderFacturas, -1, "", "", OperadorBD.OperadorGlobal.IdOperador);
                // Set column widths according to their contents. 
                cbFacturas.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cbFacturas.Properties.PopupFormWidth = 900;

                if (IdSolicitudFactura != 0 && IdFactura != 0)
                {
                    Filtro();
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbFacturas_EditValueChanged(object sender, EventArgs e)
        {
            bool Timbrado = false, control = false, contabilizado = false, facturas = false;
            Int64 IdControl = 0;
            try
            {
                Limpiar();
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
                    txtMetodoPago.Text = row[10].ToString();
                    txtFormaPago.Text = row[13].ToString().ToUpper();
                    txtBancoOrigen.Text = row[29].ToString();
                    txtBancoDestino.Text = row[31].ToString();
                    txtTotalDeposito.Text = Convert.ToDecimal(row[24].ToString()).ToString("C");
                    txtFechaPago.Text = row[16].ToString();
                    txtMoneda.Text = row[14].ToString();
                    txtTipoCambio.Text = Convert.ToDecimal(row[15].ToString()).ToString("C");
                    txtMesAno.Text = row[38].ToString().Length > 1 ? row[38].ToString() : "0" + row[38].ToString() + "/" + row[37].ToString();
                    txtEstatus.Text = row[26].ToString();
                    txtSerie.Text = row[47].ToString() + '-' + row[46].ToString();

                    Estatus = Convert.ToInt32(row[43].ToString());
                    IdControl = Convert.ToInt64(row[2]);
                    IdFacturas = Convert.ToInt64(row[0]);
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

                    this.stpFactSelControlOperacionesFacturasTableAdapter.Fill(dbSAICBPOFactura.stpFactSelControlOperacionesFacturas, IdFacturas);
                    this.stpFactSelDetailFacturasTableAdapter.Fill(dbSAICBPOFactura.stpFactSelDetailFacturas, IdFacturas);
                    this.stpFactSelFacturasARelacionarTableAdapter.Fill(dbSAICBPOFactura.stpFactSelFacturasARelacionar, IdFacturas, 0, 0, 0, 0);
                    this.stpFactSelFacturasARelacionarSATTableAdapter.Fill(dbSAICBPOFactura.stpFactSelFacturasARelacionarSAT, 0, 0, 0, "", IdFacturas, 0);

                    if (gridView2.DataRowCount > 0)
                        control = false;
                    else
                        control = true;

                    if (gridView3.DataRowCount > 0)
                        facturas = false;
                    else
                        facturas = true;

                    ActivarBotones(Timbrado, control, facturas, contabilizado);
                    Totales(Header);

                }
                else
                {
                    Header = -1;
                    OcultarBotones(false); //Activar Botones
                    XtraMessageBox.Show("¡Debe de Seleccionar una Factura!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Close(); //Salir
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
                        //Byte[] bytes = Convert.FromBase64String(row[32].ToString());

                        //Generar carpeta para colocar archivos XML
                        sRutaArchivosCFDI = compNominaCFDI.AccesoIO.ValidarCrearDirectorioCPago(strRutaArchivosXML, row[0].ToString(), compNominaCFDI.AccesoIO.ISO_Date());
                        sRutaArchivosCFDI = string.Format(@"{0}\COMPROBANTE_PAGO.pdf", sRutaArchivosCFDI);
                        File.WriteAllBytes(sRutaArchivosCFDI, bytes);
                        XtraMessageBox.Show("¡El Archivo se descargo Correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnVinvularControl_Click(object sender, EventArgs e)
        {
            Int32 pIdCliente = 0, pIdFronting = 0;
            try
            {

                //Crear archivo Comprobante
                DataRow row = dgvFacturas.GetDataRow(dgvFacturas.FocusedRowHandle);// Header);
                if (row != null)
                {
                    IdFacturas = Convert.ToInt32(row[0].ToString());
                    pIdCliente = Convert.ToInt32(row[5].ToString());
                    pIdFronting = Convert.ToInt32(row[3].ToString());

                    Facturas.frmVicularControl objAsignarXML = new Facturas.frmVicularControl()
                    {
                        IdFactura = IdFacturas,
                        IdCliente = pIdCliente,
                        IdFronting = pIdFronting
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

        private void btnDesvincularControl_Click(object sender, EventArgs e)
        {
            int? pOk = 0;
            try
            {

                //Crear archivo Comprobante
                DataRow row = dgvFacturas.GetDataRow(dgvFacturas.FocusedRowHandle);// Header);
                if (IdFacturas > 0)
                {
                    if (XtraMessageBox.Show(String.Format("¿Está seguro que desea Desvicular el (los) controle(s)?"), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.spSoloRespuesta1.stpFactDelControlesFactura(IdFacturas, OperadorBD.OperadorGlobal.NombreUsuario, ref pOk);
                        if (pOk == 1)
                        {
                            XtraMessageBox.Show("¡La Desvinculación de Control(es) fue exitosa!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            XtraMessageBox.Show("¡Error al Desvincular Control(es), intentelo mas tarde!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    CargarCombos();
                }
                else
                    XtraMessageBox.Show("¡Debe de Seleccionar una Factura!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVicularFacturas_Click(object sender, EventArgs e)
        {
            Int32 pIdCliente = 0, pIdFronting = 0, pIdBeneficiario = 0;
            try
            {
                //Crear archivo Comprobante
                DataRow row = dgvFacturas.GetDataRow(dgvFacturas.FocusedRowHandle);// Header);
                if (row != null)
                {
                    pIdCliente = Convert.ToInt32(row[5].ToString());
                    pIdBeneficiario = Convert.ToInt32(row[7].ToString());
                    pIdFronting = Convert.ToInt32(row[3].ToString());

                    Facturas.frmVincularFactura objAsignarXML = new Facturas.frmVincularFactura()
                    {
                        IdFactura = IdFacturas,
                        IdFronting = pIdFronting,
                        IdCliente = pIdCliente,
                        IdBeneficiario = pIdBeneficiario
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

        private void btnDesvincularFacturas_Click(object sender, EventArgs e)
        {
            int? pOk = 0;
            try
            {
                //Crear archivo Comprobante
                DataRow row = dgvFacturas.GetDataRow(dgvFacturas.FocusedRowHandle);// Header);
                if (IdFacturas > 0)
                {
                    if (XtraMessageBox.Show(String.Format("¿Está seguro que desea Desvicular la(s) Factura(s)?"), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.spSoloRespuesta1.stpFactDelFacturasFactura(IdFacturas, OperadorBD.OperadorGlobal.NombreUsuario, ref pOk);
                        if (pOk == 1)
                        {
                            XtraMessageBox.Show("¡La Desvinculación de Factura(s) fue exitosa!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            XtraMessageBox.Show("¡Error al Desvincular Factura, intentelo mas tarde!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    CargarCombos();
                }
                else
                    XtraMessageBox.Show("¡Debe de Seleccionar una Factura!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgvFacturas_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string category = View.GetRowCellDisplayText(e.RowHandle, View.Columns[11]);
                if (category == "28")
                {
                    e.Appearance.BackColor = Color.Salmon;
                    e.Appearance.BackColor2 = Color.SeaShell;
                }
            }
        }
    }
}