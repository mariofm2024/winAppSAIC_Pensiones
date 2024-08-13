using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using compLibreriaSAIC;
using compNominaCFDI;
using winAppSAIC.UtileriasLocal;
using System.Xml;
using System.IO;
using System.Xml.Linq;
using System.Security.Principal;
using compCatalogosSAIC;
using Microsoft.VisualBasic.FileIO;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Net;
using winAppSAIC.LucasServCancela;


namespace winAppSAIC.NominaCFDI
{
    public partial class frmxCancelarXMLCFDI : DevExpress.XtraEditors.XtraForm
    {
        public frmxCancelarXMLCFDI()
        {
            InitializeComponent();
        }

        #region "Variables Globales"
        EstatusNomina objNomina;
        Estructuras.InformacionLoteCargaNomina objInfoLoteCargaNomina;
        InfoDetalleLoteCargaNomina objInfoDetalle;      //declarar objeto InfoDetalleLoteCargaNomina
        NominaControlCancelacionCFDI objNominaControlCancelacionCFDI = null;    //declarar objeto objNominaControlCancelacionCFDI

        private string pathXmlFiles;
        //private string pathDirectoryXMLFiles;
        private APIEF apiEF;
        private string sRutaArchivosCFDI;
        private string sRutaArchivosRespuestaCFDI;
        private static Int32 intContadorAceptados;     //contadores para registrar movs validos o inválidos
        private static Int32 intContadorRechazados;
        private static Int32 intContadorCancelados;

        //objeto que almacena los movs del Encabezado de la Nomina a Cancelar
        List<NominaCancelacion> objNominaList = null;

        #endregion

        #region "Métodos Propios"

        /// <summary>
        /// Método para inicializar controles en pantalla
        /// </summary>
        private void InicializarControles()
        {
            //bloqueo de boton Cerrar Nomina
            //*** COMENTADO TEMPORALMENTE ***
            //btnCancelarXML.Enabled = false;

            //inicializar labels Resumen Nomina Vs Timbrados
            lblNoEmpleadosNomina.Text = "0";
            lblNoEmpleadosTimbrados.Text = "0";
            lblNoEmpleadosCancelados.Text = "0";
            lblPctEmpleadosTimbrados.Text = "0.00";
            lblPctEmpleadosPorTimbrar.Text = "0.00";
            lblLeyendaEstatusNominaSueldosVsTimbrados.Text = String.Empty;
        }


        /// <summary>
        /// Método que despliega la Informacion Detallada
        /// del Lote Carga Nomina seleccionado
        /// </summary>
        private void MostrarInfoDetalleLoteCargaNomina(long pIdLoteCargaNomina)
        {
            //cargar informacion detalle LoteCargaNomina
            DataTable dt = this.stpSelInfoDetalleLoteCargaNominaTableAdapter1.GetData(pIdLoteCargaNomina);

            //crear objeto y pasar el DataTable para asignar los valores
            objInfoDetalle = InfoDetalleLoteCargaNominaBD.ObtenerInfoDetalleLoteCargaNomina(dt);

            //si existe el objeto entonces mostrar los valores
            if (objInfoDetalle != null)
            {
                txtNombreComercialTenedora.Text = objInfoDetalle.NombreComercialTenedora;
                txtNombreComercialCliente.Text = objInfoDetalle.NombreComercialCliente;
                txtNombreOperador.Text = objInfoDetalle.Operador;
                txtTipoNomina.Text = objInfoDetalle.TipoNomina;
                txtPeriodoPago.Text = objInfoDetalle.PeriodoPago;
                chkEstatusNominaContabilizada.Checked = objInfoDetalle.EstatusNominaContabilizada;
                if (objInfoDetalle.AnoPago > 0)
                    txtFechaPago.Text = String.Format("{0} {1}", objInfoDetalle.MesPago, objInfoDetalle.AnoPago);
                else
                    txtFechaPago.Text = "";     //inicializar textbox

                //desbloqueo de boton Cerrar Nomina
                //si el valor es true => convertir a false y viceversa
                //***COMENTADA TEMPORALMENTE ***
                //btnCancelarXML.Enabled = !objInfoDetalle.EstatusNominaContabilizada;
            }
        }


        /// <summary>
        /// Método para crear archivo de Solicitud Cancelación XML 
        /// </summary>
        /// <param name="objDetalleCancelacion">Objeto con información del Recibo CFDI a cancelar</param>
        /// <param name="objInfoLoteCargaNomina">Objeto con información del LoteCargaNomina</param>
        /// <param name="pIdTipoMovimiento">Tipo de Movimiento D(Asimilados) o Sueldos</param>
        /// <param name="pRutaArchivosCFDI">Ruta en dónde se guardarán los archivos a enviar al PAC</param>
        private void GenerarArchivoCancelacionXML2PAC(Estructuras.InformacionLoteCargaNomina objInfoLoteCargaNomina, Int64 pIdPDOHeaderCFDI, string pIdTipoMovimiento, string pRutaArchivosCFDI)
        {
            const string sNamespaceXSD = @"https://esquemas.enlacefiscal.com/EF/API_Nomina/Solicitudes";
            const string sNamespaceXSI = @"http://www.w3.org/2001/XMLSchema-instance";
            const string sNamespaceSchemaLocation = @"https://esquemas.enlacefiscal.com/EF/API_Nomina/Solicitudes https://esquemas.enlacefiscal.com/EF/API_Nomina/Solicitud.xsd";
            string path = pRutaArchivosCFDI + "\\";

            XmlWriterSettings settings = new XmlWriterSettings() { Indent = true, IndentChars = ("     ") };

            try
            {
                //obtiene informacion de la version del Archivo AssemblyInfo.cs, seccion [assembly: AssemblyFileVersion("1.1.0.105")]
                Version ver = new Version(System.Windows.Forms.Application.ProductVersion);

                XmlWriter xmlOut = null;

                //filtrar el detalle de Nominas Cancelacion por IdPDOHeaderCFDI
                var nominas = from row in objNominaList.Where(row => row.IdPDOHeaderCFDI == pIdPDOHeaderCFDI)
                              select row;

                foreach (var item in nominas)
                {
                    //crear objeto XMLWriter
                    pathXmlFiles = String.Format(@"{0}L{1}-{2}{3}.xml", path, objInfoLoteCargaNomina.idLoteCargaNomina, item.serieRecibo, item.folioRecibo);
                    xmlOut = XmlWriter.Create(String.Format(@"{0}L{1}-{2}{3}.xml", path, objInfoLoteCargaNomina.idLoteCargaNomina, item.serieRecibo, item.folioRecibo), settings);
                    //escribir en cabezado
                    xmlOut.WriteStartDocument();
                    xmlOut.WriteStartElement("Solicitud", sNamespaceXSD);
                    xmlOut.WriteAttributeString("xmlns", "xsi", null, sNamespaceXSI);
                    xmlOut.WriteAttributeString("xsi", "schemaLocation", null, sNamespaceSchemaLocation);

                    xmlOut.WriteElementString("rfc", item.rfcTenedora);
                    xmlOut.WriteElementString("accion", item.accion);
                    xmlOut.WriteElementString("modo", item.modo);
                    xmlOut.WriteStartElement("CFDi");
                    xmlOut.WriteElementString("serie", item.serieRecibo);
                    xmlOut.WriteElementString("folio", item.folioRecibo);
                    xmlOut.WriteElementString("UUID", item.folioFiscalUUID);
                    xmlOut.WriteElementString("justificacion", item.justificacion);
                    xmlOut.WriteEndElement();       //CFDi

                    //obtener informacion para almacenar en tabla de ErrorCancelacionCFDI
                    objNominaControlCancelacionCFDI = new NominaControlCancelacionCFDI();

                    objNominaControlCancelacionCFDI.idLoteCargaNomina = objInfoLoteCargaNomina.idLoteCargaNomina;
                    objNominaControlCancelacionCFDI.folioLoteCargaNomina = objInfoLoteCargaNomina.folioLoteCargaNomina;
                    objNominaControlCancelacionCFDI.idPDOHeaderCFDI = item.IdPDOHeaderCFDI;
                    objNominaControlCancelacionCFDI.idPDOHeader = item.IdPDOHeader;
                    objNominaControlCancelacionCFDI.softwareNombre = "SAIC Windows";
                    objNominaControlCancelacionCFDI.softwareVersion = ver.ToString();

                    objNominaControlCancelacionCFDI.accion = item.accion;
                    objNominaControlCancelacionCFDI.modo = item.modo;
                    objNominaControlCancelacionCFDI.justificacion = item.justificacion;
                    objNominaControlCancelacionCFDI.serieRecibo = item.serieRecibo;
                    objNominaControlCancelacionCFDI.folioRecibo = item.folioRecibo;
                    objNominaControlCancelacionCFDI.fechaEmision = String.Format("{0:yyyy-MM-dd}T{1:HH:mm:ss}", item.fechaEmision, item.fechaEmision);
                    objNominaControlCancelacionCFDI.registroPatronal = item.registroPatronal;
                    objNominaControlCancelacionCFDI.rfcTenedora = item.rfcTenedora;
                    objNominaControlCancelacionCFDI.nombre = item.nombre;
                    objNominaControlCancelacionCFDI.apellidoPaterno = item.apellidoPaterno;
                    objNominaControlCancelacionCFDI.apellidoMaterno = item.apellidoMaterno;
                    objNominaControlCancelacionCFDI.rfc = item.rfc;
                    objNominaControlCancelacionCFDI.curp = item.curp;
                    objNominaControlCancelacionCFDI.numSeguridadSocial = item.numSeguridadSocial;
                    objNominaControlCancelacionCFDI.numEmpleado = item.numEmpleado;
                    objNominaControlCancelacionCFDI.departamento = item.departamento;
                    objNominaControlCancelacionCFDI.puesto = item.puesto;
                    objNominaControlCancelacionCFDI.riesgoPuesto = item.riesgoPuesto;
                    objNominaControlCancelacionCFDI.fechaInicioRelLaboral = String.Format("{0:yyyy-MM-dd}", item.fechaInicioRelLaboral);
                    objNominaControlCancelacionCFDI.antiguedad = item.antiguedad;
                    objNominaControlCancelacionCFDI.tipoRegimen = item.tipoRegimen;
                    objNominaControlCancelacionCFDI.tipoContrato = item.tipoContrato;
                    objNominaControlCancelacionCFDI.tipoJornada = item.tipoJornada;
                    objNominaControlCancelacionCFDI.periodicidadPago = item.periodicidadPago;
                    objNominaControlCancelacionCFDI.salarioBaseCotApor = item.salarioBaseCotApor;
                    objNominaControlCancelacionCFDI.salarioDiarioIntegrado = item.salarioDiarioIntegrado;
                    objNominaControlCancelacionCFDI.fechaPago = String.Format("{0:yyyy-MM-dd}", item.fechaPago);
                    objNominaControlCancelacionCFDI.fechaInicialPago = String.Format("{0:yyyy-MM-dd}", item.fechaInicialPago);
                    objNominaControlCancelacionCFDI.fechaFinalPago = String.Format("{0:yyyy-MM-dd}", item.fechaFinalPago);
                    objNominaControlCancelacionCFDI.numDiasPagados = item.numDiasPagados;
                    objNominaControlCancelacionCFDI.montoPagado = item.montoPagado;
                    objNominaControlCancelacionCFDI.importeConLetra = item.importeConLetra;
                    objNominaControlCancelacionCFDI.tipoMoneda = item.tipoMoneda;
                    objNominaControlCancelacionCFDI.tipoCambio = item.tipoCambio;
                    objNominaControlCancelacionCFDI.CLABE = "";
                    objNominaControlCancelacionCFDI.banco = "";
                    objNominaControlCancelacionCFDI.estatusDocumento = item.estatusDocumento;
                    objNominaControlCancelacionCFDI.folioFiscalUUID = item.folioFiscalUUID;
                    objNominaControlCancelacionCFDI.fechaGeneracionCFDI = String.Format("{0:yyyy-MM-dd}", item.fechaGeneracionCFDI);
                    objNominaControlCancelacionCFDI.fechaTFD = String.Format("{0:yyyy-MM-dd}", item.fechaTFD);
                    objNominaControlCancelacionCFDI.estadoCFDI = item.estadoCFDI;
                    objNominaControlCancelacionCFDI.Motivo = item.Motivo;
                }

                xmlOut.WriteEndDocument();
                xmlOut.Close();

                //enviar la información del XML generado al servicio web del PAC
                EnviarXML2wsPAC(pIdTipoMovimiento, objNominaControlCancelacionCFDI);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// Método para enviar la información del XML generado
        /// al servicio web del PAC
        /// </summary>
        /// <param name="pIdTipoMovimiento">Valor S(Sueldos), M(Sueldos-Alimentos), D(Asimilados)</param>
        private void EnviarXML2wsPAC(string pIdTipoMovimiento, NominaControlCancelacionCFDI objNominaControlCancelacionCFDI)
        {
            //Prueba de envío XML SAIC
            string documentType = "";
            if (!pIdTipoMovimiento.Equals("D"))
                documentType = "Asalariado";
            else
                documentType = "Asimilable";

            string operationType = "cancelar" + documentType;
            string xmlRequestString = File.ReadAllText(pathXmlFiles);

            //string response = apiEF.executeOperation(xmlRequestString, operationType);
            //string strXMLResponse = apiEF.FormatXml(response);           
            //ObtenerValoresXMLRespuestaCancelacionCFDIEn(objNominaControlCancelacionCFDI, strXMLResponse);

            ObtenerValoresXMLRespuestaCancelacionCFDI(objNominaControlCancelacionCFDI, objInfoLoteCargaNomina, sRutaArchivosCFDI);
        }

        private void ObtenerValoresXMLRespuestaCancelacionCFDIEn(NominaControlCancelacionCFDI objNominaControlCancelacionCFDI, string strXMLResponse)
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
                                                descripcionError = v.Element("mensajeError").Element("descripcionError").Element("texto").Value,
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

                        intContadorRechazados++;    //incrementar contador rechazados

                        //Metodo que almacenara la informacion que fue enviada a Cancelar
                        Int64 IdLoteCargaNominaCFDI = InsertarBitacoraErrorCancelacionXMLCFDI(objNominaControlCancelacionCFDI, objErrorTimbrado);
                    }
                    else if (itemValida.estatusDocumento.Equals("ACEPTADO"))
                    {
                        NominaNotificacionCancelacionTimbradoCFDI objTimbrado = new NominaNotificacionCancelacionTimbradoCFDI();

                        //Obtener informacion XML Timbrado
                        var objXMLAceptado = from c in xmlDoc.Descendants("AckEnlaceFiscal")
                                             select new
                                             {
                                                 numeroReferencia = c.Attribute("numeroReferencia").Value,
                                                 estatusDocumento = c.Attribute("estatusDocumento").Value,
                                                 fechaMensaje = c.Attribute("fechaMensaje").Value,
                                                 estatusCancelacion = c.Element("estatusCancelacion").Value,
                                                 fechaCancelacion = c.Element("fechaCancelacion").Value,
                                                 folioFiscalUUID = c.Element("uuid").Value,
                                                 folioInterno = c.Element("folio").Value,
                                                 serie = c.Element("serie").Value,
                                             };

                        //Mostrar valores XML Timbrado
                        foreach (var itemAceptado in objXMLAceptado)
                        {
                            objTimbrado.NumeroReferencia = itemAceptado.numeroReferencia;
                            objTimbrado.EstatusDocumento = itemAceptado.estatusDocumento.ToUpper();
                            objTimbrado.FechaMensaje = itemAceptado.fechaMensaje;
                            objTimbrado.EstatusCancelacion = itemAceptado.estatusCancelacion;
                            objTimbrado.FechaCancelacion = itemAceptado.fechaCancelacion;
                            objTimbrado.FolioInterno = itemAceptado.folioInterno;
                            objTimbrado.FolioFiscalUUID = itemAceptado.folioFiscalUUID;
                            objTimbrado.Serie = itemAceptado.serie;

                            //asignar Contenido XML de Respuesta
                            objTimbrado.XmlCFDI = strXMLResponse;

                            //Insertar XML Cancelación de respuesta
                            //this.seguridadTableAdapter1.stpInsPDOHeaderDocumentoSACancelacionCFDI(objNominaControlCancelacionCFDI.idPDOHeaderCFDI, objTimbrado.XmlCFDI);

                            //Actualizar Estatus XML CFDI en tablas trn.PDOHeaderSACFDI y trn.PDOHeaderSA
                            Int32? pErrorCancelacion = 0;

                            this.seguridadTableAdapter1.stpUpdCancelacionNominaCFDI(objNominaControlCancelacionCFDI.idLoteCargaNomina,
                                objNominaControlCancelacionCFDI.idPDOHeader, objNominaControlCancelacionCFDI.idPDOHeaderCFDI,
                                Convert.ToInt32(objNominaControlCancelacionCFDI.numEmpleado), objTimbrado.Serie, objTimbrado.FolioInterno,
                                "CANCELADO", objTimbrado.NumeroReferencia, objTimbrado.FechaMensaje,
                                objTimbrado.FolioFiscalUUID, objTimbrado.FechaCancelacion, OperadorBD.OperadorGlobal.NombreUsuario,
                                ref pErrorCancelacion);

                            //TODO: Instrucciones para crear Archivo XML CFDI
                            //Crear archivo XML desde un string
                            XmlDocument xdoc = new XmlDocument();
                            xdoc.LoadXml(objTimbrado.XmlCFDI);
                            //xdoc.Save(String.Format(@"{0}\{1}_{2}{3}_{4}.xml", sRutaArchivosRespuestaCFDI, sRFCTenedora, itemAceptado.serie, itemAceptado.folioInterno, itemAceptado.folioFiscalUUID));
                            xdoc.Save(String.Format(@"{0}\CANCELACION_E{1}_{2}{3}_{4}_{5}.xml", sRutaArchivosRespuestaCFDI, objNominaControlCancelacionCFDI.numEmpleado, itemAceptado.serie, itemAceptado.folioInterno, objInfoLoteCargaNomina.folioLoteCargaNomina, objInfoLoteCargaNomina.rfcTenedora));
                        }
                        intContadorAceptados++;    //incrementar contador aceptados
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }



        }


        /// <summary>
        /// Método para crear archivo de Solicitud Cancelación XML 
        /// </summary>
        /// <param name="objDetalleCancelacion">Objeto con información del Recibo CFDI a cancelar</param>
        /// <param name="objInfoLoteCargaNomina">Objeto con información del LoteCargaNomina</param>
        /// <param name="pIdTipoMovimiento">Tipo de Movimiento D(Asimilados) o Sueldos</param>
        /// <param name="pRutaArchivosCFDI">Ruta en dónde se guardarán los archivos a enviar al PAC</param>
        private void ObtenerValoresXMLRespuestaCancelacionCFDI(NominaControlCancelacionCFDI objNominaControlCancelacionCFDI, Estructuras.InformacionLoteCargaNomina objInfoLoteCargaNomina, string pRutaArchivosCFDI)
        {
            File.WriteAllBytes("C:\\SAIC\\cer.pem", objInfoLoteCargaNomina.CertificadoPen);
            File.WriteAllBytes("C:\\SAIC\\key.pem", objInfoLoteCargaNomina.KeyPen);
            String DireccionCer = "C:\\SAIC\\cer.pem";
            String DireccionKey = "C:\\SAIC\\key.pem";
            //File.WriteAllBytes("C:\\SAIC\\cer.cer", objInfoLoteCargaNomina.Certificado);
            //File.WriteAllBytes("C:\\SAIC\\key.key", objInfoLoteCargaNomina.Key);
            //String DireccionCer = "C:\\SAIC\\cer.cer";
            //String DireccionKey = "C:\\SAIC\\key.key";
            String PasswordFinkok = objInfoLoteCargaNomina.Password;
            String PasswordCer = objInfoLoteCargaNomina.ContrasenaKey;
            String username = objInfoLoteCargaNomina.Usuario;
            string Motivo = objNominaControlCancelacionCFDI.Motivo;
            String cer;
            String key;

            try
            {
                compNominaCFDI.AccesoIO.ValidarCrearDirectorioRespuestaCFDI(@"C:\SAIC");

                using (TextFieldParser fileReader = new TextFieldParser(DireccionCer))
                    cer = fileReader.ReadToEnd();

                using (TextFieldParser fileReader = new TextFieldParser(DireccionKey))
                    key = fileReader.ReadToEnd();

                //Byte[] bytesCer = File.ReadAllBytes(DireccionCer);
                ////Conviertes el byte resultado en base64
                //cer = Convert.ToBase64String(bytesCer);

                //Byte[] bytesKey = File.ReadAllBytes(DireccionKey);
                ////Conviertes el byte resultado en base64
                //key = Convert.ToBase64String(bytesKey);

                key = key.Trim();
                cer = cer.Trim();

                Facturacion40ServiceClient Fact = new Facturacion40ServiceClient();
                objEstadoSAT ObjEstado = new objEstadoSAT();
                ObjEstado = Fact.FacturacionConsultarEstadoSAT("E0CE8BC6-63DD-4B03-8299-3EE6CA3A25DC", objInfoLoteCargaNomina.rfcTenedora, objNominaControlCancelacionCFDI.folioFiscalUUID,objNominaControlCancelacionCFDI.rfc,objNominaControlCancelacionCFDI.montoPagado);

                if (ObjEstado.cEstatusCancelacion == null || ObjEstado.cEstatusCancelacion == "")
                {
                    objCancelar ObjCancelar = new objCancelar();
                    ObjCancelar = Fact.FacturacionCancelar40("E0CE8BC6-63DD-4B03-8299-3EE6CA3A25DC", objInfoLoteCargaNomina.rfcTenedora, objNominaControlCancelacionCFDI.folioFiscalUUID, objNominaControlCancelacionCFDI.rfc,+ objNominaControlCancelacionCFDI.montoPagado, cer, key, objNominaControlCancelacionCFDI.Motivo, "");

                    if (ObjCancelar.cMessage != "Autenticación fallida")
                        ObjEstado = Fact.FacturacionConsultarEstadoSAT("E0CE8BC6-63DD-4B03-8299-3EE6CA3A25DC", objInfoLoteCargaNomina.rfcTenedora, objNominaControlCancelacionCFDI.folioFiscalUUID, objNominaControlCancelacionCFDI.rfc, objNominaControlCancelacionCFDI.montoPagado);
                    else
                    {
                        ObjEstado.cEstado = "ERROR";
                        ObjEstado.cDescripcionEstatus = ObjCancelar.cMessage;
                    }

                    
                }

                Fact.Close();
                
                if (ObjEstado.cEstado != "Cancelado")
                {
                    NominaTimbradoErrorCFDI objErrorTimbrado = new NominaTimbradoErrorCFDI();

                    objErrorTimbrado.NumeroReferencia = objNominaControlCancelacionCFDI.folioFiscalUUID;
                    objErrorTimbrado.codigoError = ObjEstado.cCodigoEstatus;
                    objErrorTimbrado.descripcionError = ObjEstado.cDescripcionEstatus;
                    objErrorTimbrado.EstatusDocumento = ObjEstado.cEstado;
                    objErrorTimbrado.FechaMensaje = objNominaControlCancelacionCFDI.fechaEmision;
                    objErrorTimbrado.cEsCancelable = (ObjEstado.cEsCancelable==null ? "":ObjEstado.cEsCancelable);
                    objErrorTimbrado.cEstatusCancelacion = (ObjEstado.cEstatusCancelacion == null ? "" : ObjEstado.cEstatusCancelacion);

                    intContadorRechazados++;    //incrementar contador rechazados

                    //Metodo que almacenara la informacion que fue enviada a Cancelar
                    Int64 IdLoteCargaNominaCFDI = InsertarBitacoraErrorCancelacionXMLCFDI(objNominaControlCancelacionCFDI, objErrorTimbrado);

                    splashScreenManager2.CloseWaitForm();
                    XtraMessageBox.Show(objErrorTimbrado.EstatusDocumento.ToString() + " Folio: " + objNominaControlCancelacionCFDI.folioRecibo + " -" + objErrorTimbrado.descripcionError, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    splashScreenManager2.ShowWaitForm();
                }
                else 
                {

                    NominaNotificacionCancelacionTimbradoCFDI objTimbrado = new NominaNotificacionCancelacionTimbradoCFDI();
                    objTimbrado.NumeroReferencia = objNominaControlCancelacionCFDI.folioFiscalUUID;
                    objTimbrado.EstatusDocumento = "ACEPTADO";
                    objTimbrado.EstatusCancelacion = "ACEPTADO";
                    objTimbrado.FechaMensaje = objNominaControlCancelacionCFDI.fechaEmision; 
                    objTimbrado.FolioInterno = objNominaControlCancelacionCFDI.folioRecibo;
                    objTimbrado.FolioFiscalUUID = objNominaControlCancelacionCFDI.folioFiscalUUID;
                    objTimbrado.FechaCancelacion = objNominaControlCancelacionCFDI.fechaEmision;
                    objTimbrado.Serie = objNominaControlCancelacionCFDI.serieRecibo;

                    //Actualizar Estatus XML CFDI en tablas trn.PDOHeaderSACFDI y trn.PDOHeaderSA
                    Int32? pErrorCancelacion = 0;

                    this.seguridadTableAdapter1.stpUpdCancelacionNominaCFDI(objNominaControlCancelacionCFDI.idLoteCargaNomina,
                        objNominaControlCancelacionCFDI.idPDOHeader, objNominaControlCancelacionCFDI.idPDOHeaderCFDI,
                        Convert.ToInt32(objNominaControlCancelacionCFDI.numEmpleado), objTimbrado.Serie, objTimbrado.FolioInterno,
                        "CANCELADO", objTimbrado.NumeroReferencia, objTimbrado.FechaMensaje,
                        objTimbrado.FolioFiscalUUID, objTimbrado.FechaCancelacion, OperadorBD.OperadorGlobal.NombreUsuario,
                        ref pErrorCancelacion);

                    intContadorAceptados++;    //incrementar contador aceptados

                }

                File.Delete(DireccionCer);
                File.Delete(DireccionKey);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
        /// <summary>
        /// Método que inserta la información del recibo CFDI que NO fue cancelado por algún error
        /// </summary>
        /// <param name="objNominaControlCancelacionCFDI">Objeto que almecena la información del recibo CFDI</param>
        /// <param name="objErrorTimbrado">Objeto que almacena la información del error emitido por el PAC/SAT</param>
        /// <returns></returns>
        private long InsertarBitacoraErrorCancelacionXMLCFDI(NominaControlCancelacionCFDI objNominaControlCancelacionCFDI, NominaTimbradoErrorCFDI objErrorTimbrado)
        {
            long? IdPDOHeaderErroresCancelacionCFDI = 0;
            try
            {
                this.seguridadTableAdapter1.stpInsPDOHeaderSAErrorCancelacionCFDI(objNominaControlCancelacionCFDI.idLoteCargaNomina,
                    objNominaControlCancelacionCFDI.folioLoteCargaNomina, objNominaControlCancelacionCFDI.idPDOHeaderCFDI, objNominaControlCancelacionCFDI.idPDOHeader, 
                    objNominaControlCancelacionCFDI.accion, objNominaControlCancelacionCFDI.modo, objNominaControlCancelacionCFDI.justificacion,
                    objNominaControlCancelacionCFDI.softwareNombre, objNominaControlCancelacionCFDI.softwareVersion, objNominaControlCancelacionCFDI.registroPatronal,
                    objNominaControlCancelacionCFDI.rfcTenedora, objNominaControlCancelacionCFDI.serieRecibo, objNominaControlCancelacionCFDI.folioRecibo,
                    objNominaControlCancelacionCFDI.apellidoPaterno, objNominaControlCancelacionCFDI.apellidoMaterno,
                    objNominaControlCancelacionCFDI.nombre, objNominaControlCancelacionCFDI.numSeguridadSocial,
                    objNominaControlCancelacionCFDI.rfc, objNominaControlCancelacionCFDI.curp,
                    Convert.ToInt32(objNominaControlCancelacionCFDI.numEmpleado), objNominaControlCancelacionCFDI.departamento,
                    objNominaControlCancelacionCFDI.puesto, objNominaControlCancelacionCFDI.riesgoPuesto,
                    objNominaControlCancelacionCFDI.fechaInicioRelLaboral, Convert.ToInt16(objNominaControlCancelacionCFDI.antiguedad),
                    objNominaControlCancelacionCFDI.tipoRegimen.ToString(), objNominaControlCancelacionCFDI.tipoContrato,
                    objNominaControlCancelacionCFDI.tipoJornada, objNominaControlCancelacionCFDI.periodicidadPago,
                    objNominaControlCancelacionCFDI.salarioBaseCotApor, objNominaControlCancelacionCFDI.salarioDiarioIntegrado,
                    objNominaControlCancelacionCFDI.fechaEmision, objNominaControlCancelacionCFDI.fechaPago,
                    objNominaControlCancelacionCFDI.fechaInicialPago, objNominaControlCancelacionCFDI.fechaFinalPago,
                    objNominaControlCancelacionCFDI.numDiasPagados, objNominaControlCancelacionCFDI.montoPagado,
                    objNominaControlCancelacionCFDI.tipoMoneda, objNominaControlCancelacionCFDI.tipoCambio,
                    objNominaControlCancelacionCFDI.CLABE, objNominaControlCancelacionCFDI.banco,
                    objNominaControlCancelacionCFDI.estatusDocumento, objNominaControlCancelacionCFDI.folioFiscalUUID,
                    objNominaControlCancelacionCFDI.fechaGeneracionCFDI, objNominaControlCancelacionCFDI.fechaTFD,
                    objNominaControlCancelacionCFDI.estadoCFDI, objErrorTimbrado.codigoError,
                    objErrorTimbrado.descripcionError,objErrorTimbrado.cEsCancelable,objErrorTimbrado.cEstatusCancelacion,  OperadorBD.OperadorGlobal.NombreUsuario, ref IdPDOHeaderErroresCancelacionCFDI);

                return (long)IdPDOHeaderErroresCancelacionCFDI;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        /// <summary>
        /// Método para mostrar Resumen de la Nómina Vs Timbrados, de un Lote de Nomina seleccionado
        /// </summary>
        /// <param name="pIdLoteCargaNomina">No. Lote de Nómina</param>
        private void MostrarResumenNominaSueldosVsTimbrados(long pIdLoteCargaNomina)
        {
            //obtener información Nómina Vs Timbrados
            DataTable objTable = this.stpSelObtenerEstatusNominaSueldosVsTimbradoTableAdapter1.GetData(pIdLoteCargaNomina);

            //Si existe registro entonces visualizar información
            if (objTable.Rows.Count > 0)
            {
                //asignar valores de la nomina
                objNomina = NominaBD.ObtenerEstatusNominaSueldosVsTimbrado(objTable);

                lblNoEmpleadosNomina.Text = objNomina.noEmpleadosNomina.ToString("N0");
                lblNoEmpleadosTimbrados.Text = objNomina.noEmpleadosTimbrados.ToString("N0");
                lblNoEmpleadosCancelados.Text = objNomina.noEmpleadosCancelados.ToString("N0");
                lblPctEmpleadosTimbrados.Text = (objNomina.pctEmpleadosTimbrados / 100).ToString("P2");
                lblPctEmpleadosPorTimbrar.Text = (objNomina.pctEmpleadosPorTimbrar / 100).ToString("P2");
                lblLeyendaEstatusNominaSueldosVsTimbrados.Text = objNomina.leyendaEstatusNominaSueldosVsTimbrado;
            }
        }

        #endregion

        private void frmxCancelarXMLCFDI_Load(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();

                dtFechaIni.Value = DateTime.Now.AddDays(-31);
                dtFechaFin.Value = DateTime.Now;

                string FIni = Convert.ToDateTime(dtFechaIni.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Day.ToString();
                string FFin = Convert.ToDateTime(dtFechaFin.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Day.ToString();

                //splashSMCargando.ShowWaitForm();
                this.stpSelFolioLoteCargaNominaTimbradosCFDIv2TableAdapter.Fill(this.dbSAICBPONominaCFDIDataSet.stpSelFolioLoteCargaNominaTimbradosCFDIv2, OperadorBD.OperadorGlobal.Confidencial, FIni, FFin);
                // Set column widths according to their contents. 
                cboFolioLoteCargaNomina.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cboFolioLoteCargaNomina.Properties.PopupFormWidth = 900;

                //Inicializar controles en pantalla
                InicializarControles();

                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboFolioLoteCargaNomina_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //obtener el renglon completo del Combobox
                DataRow row = gridLookUpEdit1View.GetDataRow(gridLookUpEdit1View.FocusedRowHandle);
                //asignar valores extraidos del Combobox a Objeto Struct
                objInfoLoteCargaNomina.idLoteCargaNomina = (long)cboFolioLoteCargaNomina.EditValue;
                objInfoLoteCargaNomina.folioLoteCargaNomina = row[1].ToString();
                objInfoLoteCargaNomina.tipoNomina = row[1].ToString().Substring(2, 3);    //obtener Tipo Nomina (SEM, QUI, ASI, etc)
                objInfoLoteCargaNomina.idTenedora = Convert.ToInt32(row[2]);     //obtener IdTenedora
                objInfoLoteCargaNomina.rfcTenedora = row[4].ToString();       //obtener RFCTenedora
                objInfoLoteCargaNomina.CertificadoPen =(byte[]) row[11];
                objInfoLoteCargaNomina.KeyPen = (byte[])row[12];
                objInfoLoteCargaNomina.KeyEnc = (byte[])row[13];
                objInfoLoteCargaNomina.ContrasenaKey = row[16].ToString();
                objInfoLoteCargaNomina.Usuario = row[14].ToString();
                objInfoLoteCargaNomina.Password = row[15].ToString();
                objInfoLoteCargaNomina.Certificado = (byte[])row[18];
                objInfoLoteCargaNomina.Key = (byte[])row[19];
                //llenar Gridview
                this.stpSelInfoCancelacionDetalleLoteCargaNominaTimbradosCFDITableAdapter.Fill(this.dbSAICBPONominaCFDIDataSet.stpSelInfoCancelacionDetalleLoteCargaNominaTimbradosCFDI, (long)cboFolioLoteCargaNomina.EditValue);

                //cargar informacion detallada LoteCargaNomina
                MostrarInfoDetalleLoteCargaNomina((long)cboFolioLoteCargaNomina.EditValue);

                //Obtener Informacion del Estatus Nomina Vs Timbrados
                MostrarResumenNominaSueldosVsTimbrados((long)cboFolioLoteCargaNomina.EditValue);

                if (this.dbSAICBPONominaCFDIDataSet.stpSelInfoCancelacionDetalleLoteCargaNominaTimbradosCFDI.Count > 0)
                {
                    //almacenar los Encabezados Nómina en objeto Lista
                    objNominaList = NominaBD.ObtenerEncabezadoNominasCancelacion2XML(this.dbSAICBPONominaCFDIDataSet.stpSelInfoCancelacionDetalleLoteCargaNominaTimbradosCFDI);

                    //if (chkListNominas.ItemCount > 0)
                    //    chkListNominas.CheckAll();
                }
                else
                {
                    XtraMessageBox.Show("¡El Lote de Nómina NO tiene registros para cancelar!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();        //cerrar pantalla
        }

        private void chkListNominas_DrawItem(object sender, ListBoxDrawItemEventArgs e)
        {
            //e.Appearance.ForeColor = Color.Red;       //cambiar texto a Rojo
            if ((e.State & DrawItemState.Selected) == 0)
                e.Appearance.BackColor = Color.LightSteelBlue;
        }

        private void btnSeleccionarTodos_Click(object sender, EventArgs e)
        {
            chkListNominas.CheckAll();    //seleccionar todos
        }

        private void btnDeseleccionarTodo_Click(object sender, EventArgs e)
        {
            chkListNominas.UnCheckAll();    //deseleccionar todos
        }

        void FabricaPEM(String ArchivoCer, String ArchivoKey, String pass, String passCSDoFIEL, string url)
        {
            Dictionary<String, String> DicArchivos = new Dictionary<String, String>();
            String ConvierteCerAPem;
            String ConvierteKeyAPem;
            String EncriptaKey;
            String NombreArchivoCertificado = Path.GetFileName(ArchivoCer);
            String NombreArchivoLlave = Path.GetFileName(ArchivoKey);
            
            //ruta = "C:\\OpenSSL-Win32\\bin\\";//Esta ruta es donde tiene ubicado el .exe del OpenSSL
            ConvierteCerAPem = url + "openssl.exe x509 -inform DER -outform PEM -in " + ArchivoCer + " -pubkey -out " + url + NombreArchivoCertificado + ".pem";
            ConvierteKeyAPem = url + "openssl.exe pkcs8 -inform DER -in " + ArchivoKey + " -passin pass:" + passCSDoFIEL + " -out " + url + NombreArchivoLlave + ".pem";
            EncriptaKey = url + "openssl.exe rsa -in " + url + NombreArchivoLlave + ".pem" + " -des3 -out " + url + NombreArchivoLlave + ".enc -passout pass:" + pass;

            //Crea el archivo Certificado.BAT
            System.IO.StreamWriter oSW = new System.IO.StreamWriter(url + "CERyKEY.bat");
            oSW.WriteLine(ConvierteCerAPem);
            oSW.WriteLine(ConvierteKeyAPem);
            oSW.WriteLine(EncriptaKey);
            oSW.Flush();
            oSW.Close();

            Process.Start(url + "CERyKEY.bat").WaitForExit();


        }

        public byte[] stringToBase64ByteArray(String input)
        {
            Byte[] ret = Encoding.UTF8.GetBytes(input);
            String s = Convert.ToBase64String(ret);
            ret = Convert.FromBase64String(s);
            return ret;
        }


        private void btnCancelarXML_Click(object sender, EventArgs e)
        {
            string pUsuarioCFDI = "";
            string pContrasenaCFDI = "";
            string dtHoraInicial = DateTime.Now.ToLongTimeString();
            string dtHoraFinal = "";

            try
            {
                //inicializar Contadores
                intContadorAceptados = 0;
                intContadorRechazados = 0;
                intContadorCancelados = 0;

                //Obtener el Usuario y Contraseña de la Tenedora activa en el Lote
                this.seguridadTableAdapter1.stpSelSeguridadCFDI(objInfoLoteCargaNomina.idTenedora, ref pUsuarioCFDI, ref pContrasenaCFDI);

                //Se especifican las credenciales de acceso creando una instancia a la clase APIEF
                apiEF = new APIEF(pUsuarioCFDI, pContrasenaCFDI);
                //obtener el No. de Items seleccionados
                Int32 intNoRecibosActivos = chkListNominas.CheckedItems.Count;

                //validar que exista al menos 1 movimiento activos para procesar
                if (intNoRecibosActivos > 0)
                {
                    splashScreenManager2.ShowWaitForm();        //mostrar pantalla de espera
                    this.Cursor = Cursors.AppStarting;      //cambiar cursor del mouse

                    //Generar carpeta para colocar archivos XML Cancelados
                    sRutaArchivosCFDI = compNominaCFDI.AccesoIO.ValidarCrearDirectorioCFDI(@"C:\BPOCFDI", "CANCELACION_" + objInfoLoteCargaNomina.rfcTenedora, (long)cboFolioLoteCargaNomina.EditValue, compNominaCFDI.AccesoIO.ISO_Date());
                    sRutaArchivosRespuestaCFDI = compNominaCFDI.AccesoIO.ValidarCrearDirectorioRespuestaCFDI(sRutaArchivosCFDI + @"\XMLCancelados\");

                    for (int i = 0; i < chkListNominas.ItemCount; i++)
                    {
                        if (chkListNominas.GetItemCheckState(i) == CheckState.Checked)
                        {
                            //obtener el FolioRecibo seleccionado
                            Int64 intPDOHeaderCFDI = Convert.ToInt64(chkListNominas.GetItemValue(i));

                            if (objInfoLoteCargaNomina.tipoNomina.Equals("ASI"))
                            {
                                //generar archivo XML en base al Lote Nomina Carga y FolioRecibo ASIMILADOS
                                GenerarArchivoCancelacionXML2PAC(objInfoLoteCargaNomina, intPDOHeaderCFDI, "D", sRutaArchivosCFDI);
                            }
                            else
                            {
                                //generar archivo XML en base al Lote Nomina Carga y FolioRecibo SUELDOS
                                GenerarArchivoCancelacionXML2PAC(objInfoLoteCargaNomina, intPDOHeaderCFDI, objInfoLoteCargaNomina.folioLoteCargaNomina.Substring(0, 1), sRutaArchivosCFDI);

                            }
                        }
                    }  //for

                    this.Cursor = Cursors.Default;      //cambiar cursor del mouse
                    splashScreenManager2.CloseWaitForm();   //quitar pantalla de espera

                    dtHoraFinal = DateTime.Now.ToLongTimeString();
                    XtraMessageBox.Show(String.Format("¡La cancelación de recibos XML CFDI se ha realizado!\n\nTotal Documentos procesados={0}\n\nDocumentos Aceptados= {1}\nDocumentos Rechazados={2}\n\nHora Inicio envío={3}\nHora Fin envío={4}", intNoRecibosActivos, intContadorAceptados, intContadorRechazados, dtHoraInicial, dtHoraFinal), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboFolioLoteCargaNomina_EditValueChanged(sender, e);     //recargar gridview
                }
                else
                    XtraMessageBox.Show("¡No existen Movimientos activos para la Cancelación XML CFDI!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                if (splashScreenManager2.IsSplashFormVisible)
                {
                    splashScreenManager2.CloseWaitForm();
                }
                //quitar pantalla de espera
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;      //cambiar cursor del mouse
            }
        }

        private void btnExportarXLS_Click(object sender, EventArgs e)
        {
            try
            {
                if (sfdRutaArchivo.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    stpSelFolioLoteCargaNominaTimbradosCFDIGridControl.ExportToXls(sfdRutaArchivo.FileName);

                    //Solicitar la visualización del nuevo archivo en Excel
                    if (XtraMessageBox.Show("¿Desea abrir el archivo en Excel?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        // Mostrar resultado en Excel.
                        Utilerias.StartProcess(sfdRutaArchivo.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            chkListNominas.SelectedValue = gridView1.FocusedValue;
            chkListNominas.SelectedItem = gridView1.FocusedValue;
            chkListNominas.Focus();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                string FIni = Convert.ToDateTime(dtFechaIni.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Day.ToString();
                string FFin = Convert.ToDateTime(dtFechaFin.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Day.ToString();

                this.stpSelFolioLoteCargaNominaTimbradosCFDIv2TableAdapter.Fill(this.dbSAICBPONominaCFDIDataSet.stpSelFolioLoteCargaNominaTimbradosCFDIv2, OperadorBD.OperadorGlobal.Confidencial, FIni, FFin);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnEliminarFiltro_Click(object sender, EventArgs e)
        {
            try
            {
                dtFechaIni.Value = DateTime.Now.AddDays(-31);
                dtFechaFin.Value = DateTime.Now;

                string FIni = Convert.ToDateTime(dtFechaIni.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Day.ToString();
                string FFin = Convert.ToDateTime(dtFechaFin.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Day.ToString();

                this.stpSelFolioLoteCargaNominaTimbradosCFDIv2TableAdapter.Fill(this.dbSAICBPONominaCFDIDataSet.stpSelFolioLoteCargaNominaTimbradosCFDIv2, OperadorBD.OperadorGlobal.Confidencial, FIni, FFin);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}