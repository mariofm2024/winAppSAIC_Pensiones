using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Xml.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Xml;
using System.Xml.Xsl;
using System.IO;
using System.Net;
using compCatalogosSAIC;
using compLibreriaSAIC;
using compNominaCFDI;
using winAppSAIC.UtileriasLocal;
using System.Security.Cryptography.X509Certificates;
using DevExpress.XtraReports.UI;
using System.Security.Cryptography;
using XMLDLL;

using winAppSAIC.ThreeBits;
using winAppSAIC.LucasServ;
using winAppSAIC.LucasServ4;
using System.Security;
using winAppSAIC.NominaCFDI.uc;

namespace winAppSAIC.NominaCFDI
{
    public partial class frmxAsignarNomina2XMLCFDI : DevExpress.XtraEditors.XtraForm
    {
        #region "Variables Globales"
        private string pathXmlFiles;
        private string pathXmlFilesRespuesta;
        private APIEF apiEF;
        private Int32 IdTenedora;
        private string sRFCTenedora;
        private string sTipoNomina;
        private string sFolioLoteCargaNomina;
        private string sRutaArchivosCFDI;
        private string sFechaPagoAutomatica;
        private bool PTimbrar = false;
        private string sRutaArchivosRespuestaCFDI;
        private static Int32 intContadorAceptados;     //contadores para registrar movs validos o inválidos
        private static Int32 intContadorRechazados;
        private static Int32 intContadorCancelados;
        private static Int32 intContadorMenoresde0;
        private string bTipoCFDI = "";
        private static Int16 APPJ;

        EstatusNominaOperador objNomina;

        InfoDetalleLoteCargaNomina objInfoDetalle;      //declarar objeto InfoDetalleLoteCargaNomina
                                                        //objeto tipo Lista de Nominas. Almacena los movs del Encabezado de la Nomina seleccionada
        List<Nomina> objNominaList = null;
        List<PercepcionDeduccion> objDetalleNominaList = null;
        #endregion

        #region Propiedades Globales
        public Constantes.FiltraPorIdLoteCargaNomina filtraIdLoteCargaNomina { get; set; }
        public long pIdLoteCargaNomina { get; set; }
        #endregion

        Boolean flagBloquearBusquedaLotes;
        List<long> lstIdPODHeaderParaEnvioDeRecibos;
        Boolean flagEnvioDesdeTimbrado = false;
        public frmxAsignarNomina2XMLCFDI(Boolean flagBloquearBusquedaLotes)
        {
            InitializeComponent();
            this.flagBloquearBusquedaLotes = flagBloquearBusquedaLotes;

        }

        #region "Metodos Propios"
        /// <summary>
        /// Método para inicializar controles en pantalla
        /// </summary>
        private void InicializarControles()
        {
            //inicializar labels Resumen Nomina Vs Timbrados
            lblNoEmpleadosNomina.Text = "0";
            lblNoEmpleadosTimbrados.Text = "0";
            lblNoEmpleadosATimbrados.Text = "0";
            lblPctEmpleadosPorTimbrar.Text = "0";
            lblPorEmpleadosTimbrados.Text = "0.00";
        }

        /// <summary>
        /// Método para mostrar Resumen de la Nómina Vs Timbrados, de un Lote de Nomina seleccionado
        /// </summary>
        /// <param name="pIdLoteCargaNomina">No. Lote de Nómina</param>
        private void MostrarResumenNominaSueldosVsTimbrados(long pIdLoteCargaNomina)
        {
            //obtener información Nómina Vs Timbrados
            DataTable objTable = this.stpSelObtenerEstatusNominaSueldosVsTimbradoOperadorTableAdapter1.GetData(pIdLoteCargaNomina);

            //Si existe registro entonces visualizar información
            if (objTable.Rows.Count > 0)
            {
                //asignar valores de la nomina
                objNomina = NominaBD.ObtenerEstatusNominaSueldosVsTimbradoOperador(objTable);

                lblNoEmpleadosNomina.Text = objNomina.NoEmpleadosNomina.ToString("N0");
                lblNoEmpleadosATimbrados.Text = objNomina.NoEmpleadosATimbrar.ToString("N0");
                lblNoEmpleadosTimbrados.Text = objNomina.NoEmpleadosTimbrados.ToString("N0");
                lblPctEmpleadosPorTimbrar.Text = objNomina.NoEmpleadosXTimbrar.ToString("N0");
                lblPorEmpleadosTimbrados.Text = (objNomina.pctEmpleadosTimbrar / 100).ToString("P2");
            }
        }

        /// <summary>
        /// Método para insertar la Informacion que es enviada a Timbrar CFDI
        /// </summary>
        /// <param name="objNominaControlCFDI">Objeto con información de la Nomina enviada a CFDI</param>
        /// <param name="objTimbrado">Objeto con información del XML CFDI de respuesta</param>
        /// <returns></returns>
        private long InsertarBitacoraXMLCFDI(NominaControlCFDI objNominaControlCFDI, NominaTimbradoCFDI objTimbrado)
        {
            long? IdPDOHeaderCFDI = 0;
            try
            {
                this.seguridadTableAdapter1.stpInsPDOHeaderSACFDIv4(objNominaControlCFDI.IdLoteCargaNomina,
                    objNominaControlCFDI.FolioLoteCargaNomina, objNominaControlCFDI.IdPDOHeader, objNominaControlCFDI.modo, objNominaControlCFDI.versionEFNomina, objNominaControlCFDI.textoInformativo,
                    objNominaControlCFDI.SoftwareNombre, objNominaControlCFDI.SoftwareVersion, objNominaControlCFDI.registroPatronal,
                    objNominaControlCFDI.rfcTenedora, objNominaControlCFDI.apellidoPaterno, objNominaControlCFDI.apellidoMaterno,
                    objNominaControlCFDI.nombre, objNominaControlCFDI.numSeguridadSocial, objNominaControlCFDI.rfc, objNominaControlCFDI.curp,
                    Convert.ToInt32(objNominaControlCFDI.numEmpleado), objNominaControlCFDI.departamento, objNominaControlCFDI.puesto, objNominaControlCFDI.riesgoPuesto,
                    objNominaControlCFDI.fechaInicioRelLaboral, Convert.ToInt16(objNominaControlCFDI.antiguedad), objNominaControlCFDI.tipoRegimen.ToString(),
                    objNominaControlCFDI.tipoContrato, objNominaControlCFDI.tipoJornada, objNominaControlCFDI.periodicidadPago,
                    objNominaControlCFDI.salarioBaseCotApor, objNominaControlCFDI.salarioDiarioIntegrado,
                    objNominaControlCFDI.fechaEmision, objNominaControlCFDI.fechaPago,
                    objNominaControlCFDI.fechaInicialPago, objNominaControlCFDI.fechaFinalPago, objNominaControlCFDI.numDiasPagados,
                    objNominaControlCFDI.montoPagado, objNominaControlCFDI.importeConLetra, objNominaControlCFDI.tipoMoneda, objNominaControlCFDI.tipoCambio, objNominaControlCFDI.CLABE,
                    objNominaControlCFDI.banco, Convert.ToInt16(objNominaControlCFDI.diasIncapacidad), objNominaControlCFDI.tipoIncapacidad, objNominaControlCFDI.descuento,
                    objNominaControlCFDI.diasHrsDobles, objNominaControlCFDI.horasDoblesExtra, objNominaControlCFDI.importeHrsDoblesPagado,
                    objNominaControlCFDI.diasHrsTriples, objNominaControlCFDI.horasTriplesExtra, objNominaControlCFDI.importeHrsTriplesPagado,
                    objTimbrado.NumeroReferencia, objTimbrado.EstatusDocumento, objTimbrado.FechaMensaje,
                    objTimbrado.FolioInterno, objTimbrado.FolioFiscalUUID, objTimbrado.Serie, objTimbrado.NoSerieCertificado,
                    objTimbrado.NoSerieCertificadoSAT, objTimbrado.SelloCFDI, objTimbrado.SelloSAT,
                    objTimbrado.CadenaTFD, objTimbrado.FechaGeneracionCFDI, objTimbrado.FechaTFD,
                    objTimbrado.EstadoCFDI, "", objTimbrado.UrlDescargaArchivoQR, objTimbrado.XmlCFDI, objTimbrado.UrlDescargaXmlCFDI,
                    objTimbrado.FechaCancelacion, OperadorBD.OperadorGlobal.NombreUsuario,
                    objNominaControlCFDI.numDiasFaltasJus, objNominaControlCFDI.numDiasFaltasInJus, objTimbrado.RfcProvCertif, objNominaControlCFDI.versionCFDI, ref IdPDOHeaderCFDI

                    );


                return (long)IdPDOHeaderCFDI;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// Método para insertar la información que es enviada a Timbrar CFDI
        /// con el código y descripcion de error, por el cual fue rechazado
        /// </summary>
        /// <param name="objNominaControlCFDI">Objeto con información de la Nomina enviada a CFDI</param>
        /// <param name="objErrorTimbrado">Objeto con información del XML de Rechazo</param>
        /// <returns></returns>
        private Int64 InsertarBitacoraErrorXMLCFDI(NominaControlCFDI objNominaControlCFDI, NominaTimbradoErrorCFDI objErrorTimbrado)
        {
            long? IdPDOHeaderCFDI = 0;
            try
            {
                this.seguridadTableAdapter1.stpInsPDOHeaderSAErrorCFDI(objNominaControlCFDI.IdLoteCargaNomina,
                    objNominaControlCFDI.FolioLoteCargaNomina, objNominaControlCFDI.IdPDOHeader, objNominaControlCFDI.modo, objNominaControlCFDI.versionEFNomina, objNominaControlCFDI.textoInformativo,
                    objNominaControlCFDI.SoftwareNombre, objNominaControlCFDI.SoftwareVersion, objNominaControlCFDI.registroPatronal,
                    objNominaControlCFDI.rfcTenedora, objNominaControlCFDI.apellidoPaterno, objNominaControlCFDI.apellidoMaterno,
                    objNominaControlCFDI.nombre, objNominaControlCFDI.numSeguridadSocial, objNominaControlCFDI.rfc, objNominaControlCFDI.curp,
                    Convert.ToInt32(objNominaControlCFDI.numEmpleado), objNominaControlCFDI.departamento, objNominaControlCFDI.puesto, objNominaControlCFDI.riesgoPuesto,
                    objNominaControlCFDI.fechaInicioRelLaboral, Convert.ToInt16(objNominaControlCFDI.antiguedad), objNominaControlCFDI.tipoRegimen.ToString(),
                    objNominaControlCFDI.tipoContrato, objNominaControlCFDI.tipoJornada, objNominaControlCFDI.periodicidadPago,
                    objNominaControlCFDI.salarioBaseCotApor, objNominaControlCFDI.salarioDiarioIntegrado,
                    objNominaControlCFDI.fechaEmision, objNominaControlCFDI.fechaPago,
                    objNominaControlCFDI.fechaInicialPago, objNominaControlCFDI.fechaFinalPago, objNominaControlCFDI.numDiasPagados,
                    objNominaControlCFDI.montoPagado, objNominaControlCFDI.tipoMoneda, objNominaControlCFDI.tipoCambio, objNominaControlCFDI.CLABE,
                    objNominaControlCFDI.banco, Convert.ToInt16(objNominaControlCFDI.diasIncapacidad), objNominaControlCFDI.tipoIncapacidad, objNominaControlCFDI.descuento,
                    objNominaControlCFDI.diasHrsDobles, objNominaControlCFDI.horasDoblesExtra, objNominaControlCFDI.importeHrsDoblesPagado,
                    objNominaControlCFDI.diasHrsTriples, objNominaControlCFDI.horasTriplesExtra, objNominaControlCFDI.importeHrsTriplesPagado,
                    objErrorTimbrado.NumeroReferencia, objErrorTimbrado.EstatusDocumento, objErrorTimbrado.FechaMensaje,
                    objNominaControlCFDI.folioRecibo, objNominaControlCFDI.serieRecibo,
                    objErrorTimbrado.codigoError, objErrorTimbrado.descripcionError, OperadorBD.OperadorGlobal.NombreUsuario, ref IdPDOHeaderCFDI);

                return (long)IdPDOHeaderCFDI;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Método que genera los archivos XML que se generan del IdLoteCargaNomina
        /// y los Recibos de Nómina seleccionados
        /// </summary>
        /// <param name="pIdLoteCargaNomina">Lote Carga Nómina</param>
        /// <param name="pIdPDOHeader">IdPDOHeader = FolioRecibo</param>
        private void GenerarArchivoXML2PAC_Sueldos(Int64 pIdLoteCargaNomina, string pFolioLoteCargaNomina, Int64 pIdPDOHeader, long pNoFolioSiguiente, string pIdTipoMovimiento, string pRutaArchivosCFDI, DateTime pFechaPago)
        {
            const string sLeyendaRecibo = @"EL PAGO DE SUELDO INTEGRADO COMO ANTECEDE, CORRESPONDIENTE AL PERIODO QUE EN ÉSTE SE INDICA Y POR LA CANTIDAD IMPRESA EN EL IMPORTE, POR LO QUE NO ME ADEUDA SALARIOS, HORAS EXTRAS, DÍAS DE DESCANSO, PRIMA DOMINICAL, PORCENTAJES POR VENTAS O EN SU CASO COMISIONES, POR LO QUE EN ESTE MOMENTO OTORGO A SU FAVOR EL MÁS AMPLIO FINIQUITO QUE EN DERECHO PROCEDA";
            const string sNamespaceXSD = @"https://esquemas.enlacefiscal.com/EF/EFv1_0_nomina_asalariados.xsd";
            const string sNamespaceXSI = @"http://www.w3.org/2001/XMLSchema-instance";
            const string sNamespaceSchemaLocation = @"https://esquemas.enlacefiscal.com/EF/ https://esquemas.enlacefiscal.com/EF/EFv1_0_nomina_asalariados.xsd";
            //const string path = @"c:\BPOCFDI\";
            string path = pRutaArchivosCFDI + "\\";
            decimal decImporteHorasExtrasDobles = 0.0M;
            decimal decImporteHorasExtrasTriples = 0.0M;
            NominaControlCFDI objNominaControlCFDI = null;

            XmlWriterSettings settings = new XmlWriterSettings() { Indent = true, IndentChars = ("     ") };

            string sFolioReciboPDOHeader = pIdPDOHeader.ToString();
            try
            {
                //obtiene informacion de la version del Archivo AssemblyInfo.cs, seccion [assembly: AssemblyFileVersion("1.1.0.105")]
                Version ver = new Version(System.Windows.Forms.Application.ProductVersion);

                //filtrar el detalle de Nominas por IdPDOHeader = FolioRecibo
                var nominas = from row in objNominaList.Where(row => row.folioRecibo == sFolioReciboPDOHeader)
                              select row;

                //filtrar por Percepciones
                var detallePercepcion = from rowPercepcion in objDetalleNominaList
                                        where rowPercepcion.ClasifConcepto == "P"
                                        orderby rowPercepcion.IdPDOHeader
                                        select rowPercepcion;

                var contarRegistrosPercepcion = detallePercepcion.Count();      //obtener No. de registros

                //filtrar por Deducciones
                var detalleDeduccion = from rowDeduccion in objDetalleNominaList
                                       where rowDeduccion.ClasifConcepto == "D"
                                       orderby rowDeduccion.IdPDOHeader
                                       select rowDeduccion;

                var contarRegistrosDeduccion = detalleDeduccion.Count();        //obtener No. de registros

                //crear objeto XMLWriter
                pathXmlFiles = string.Format(@"{0}L{1}-{2}.xml", path, pIdLoteCargaNomina, pNoFolioSiguiente);
                XmlWriter xmlOut = XmlWriter.Create(string.Format(@"{0}L{1}-{2}.xml", path, pIdLoteCargaNomina, pNoFolioSiguiente), settings);
                //escribir en cabezado
                xmlOut.WriteStartDocument();
                xmlOut.WriteStartElement("Nomina", sNamespaceXSD);
                xmlOut.WriteAttributeString("xmlns", "xsi", null, sNamespaceXSI);
                xmlOut.WriteAttributeString("xsi", "schemaLocation", null, sNamespaceSchemaLocation);

                foreach (var item in nominas)
                {
                    xmlOut.WriteElementString("modo", item.modo);
                    xmlOut.WriteElementString("versionEFNomina", item.versionEFNomina);
                    xmlOut.WriteElementString("serieRecibo", item.serieRecibo);
                    xmlOut.WriteElementString("folioRecibo", pNoFolioSiguiente.ToString());
                    xmlOut.WriteElementString("fechaEmision", string.Format("{0:yyyy-MM-dd}T{1:HH:mm:ss}", item.fechaEmision, item.fechaEmision));
                    xmlOut.WriteElementString("nombreDisenio", "PRINCIPAL");

                    xmlOut.WriteStartElement("BloqueInformacion");
                    xmlOut.WriteElementString("titulo", "CONFORMIDAD");
                    xmlOut.WriteElementString("texto", item.leyendaRecibo);

                    xmlOut.WriteStartElement("TextoRenglones");
                    xmlOut.WriteElementString("renglon", string.Format("L{0}_PDOH{1}", pIdLoteCargaNomina, pIdPDOHeader));
                    xmlOut.WriteEndElement();       //TextoRenglones
                    xmlOut.WriteEndElement();       //BloqueInformacion

                    xmlOut.WriteStartElement("SoftwareIntegrador");
                    xmlOut.WriteElementString("nombre", "SAIC Windows");
                    xmlOut.WriteElementString("version", ver.ToString());
                    xmlOut.WriteEndElement();       //SoftwareIntegrador

                    xmlOut.WriteStartElement("Patron");
                    xmlOut.WriteElementString("registroPatronal", item.registroPatronal);
                    xmlOut.WriteElementString("rfc", item.rfcTenedora); // "URE180429TM6"); //
                    xmlOut.WriteEndElement();       //Patron

                    xmlOut.WriteStartElement("GrupoCorporativo");
                    xmlOut.WriteElementString("empresa", item.empresa);
                    xmlOut.WriteEndElement();       //GrupoCorporativo

                    xmlOut.WriteStartElement("Empleado");
                    xmlOut.WriteElementString("nombre", item.nombre);

                    if (item.apellidoPaterno.Length > 0)
                        xmlOut.WriteElementString("apellidoPaterno", item.apellidoPaterno);

                    if (item.apellidoMaterno.Length > 0)
                        xmlOut.WriteElementString("apellidoMaterno", item.apellidoMaterno);

                    xmlOut.WriteElementString("rfc", item.rfc);
                    xmlOut.WriteElementString("curp", item.curp);
                    xmlOut.WriteElementString("numSeguridadSocial", item.numSeguridadSocial);
                    xmlOut.WriteEndElement();       //Empleado

                    xmlOut.WriteStartElement("Empleo");
                    xmlOut.WriteElementString("numEmpleado", item.numEmpleado);
                    xmlOut.WriteElementString("departamento", item.departamento);
                    xmlOut.WriteElementString("puesto", item.puesto);
                    xmlOut.WriteElementString("riesgoPuesto", item.riesgoPuesto);
                    xmlOut.WriteElementString("fechaInicioRelLaboral", string.Format("{0:yyyy-MM-dd}", item.fechaInicioRelLaboral));
                    xmlOut.WriteElementString("antiguedad", item.antiguedad.ToString());
                    xmlOut.WriteElementString("tipoRegimen", item.tipoRegimen.ToString());
                    xmlOut.WriteElementString("tipoContrato", item.tipoContrato);
                    xmlOut.WriteElementString("tipoJornada", item.tipoJornada);
                    xmlOut.WriteElementString("periodicidadPago", item.periodicidadPago);
                    xmlOut.WriteElementString("salarioBaseCotApor", item.salarioBaseCotApor.ToString("0.00"));
                    xmlOut.WriteElementString("salarioDiarioIntegrado", item.salarioDiarioIntegrado.ToString("0.00"));
                    xmlOut.WriteEndElement();       //Empleo

                    xmlOut.WriteStartElement("Pago");
                    xmlOut.WriteElementString("fechaPago", string.Format("{0:yyyy-MM-dd}", pFechaPago));
                    xmlOut.WriteElementString("fechaInicialPago", string.Format("{0:yyyy-MM-dd}", item.fechaInicialPago));
                    xmlOut.WriteElementString("fechaFinalPago", string.Format("{0:yyyy-MM-dd}", item.fechaFinalPago));
                    xmlOut.WriteElementString("numDiasPagados", item.numDiasPagados.ToString());
                    xmlOut.WriteElementString("montoPagado", item.montoPagado.ToString("0.00"));
                    xmlOut.WriteElementString("tipoMoneda", item.tipoMoneda);
                    if (!item.tipoMoneda.Equals("MXN"))
                        xmlOut.WriteElementString("tipoCambio", item.tipoCambio.ToString());

                    //if (item.CLABE.Length == 18) //si tiene cuenta CLABE de 18 dígitos, mostrar CLABE y BANCO
                    //{
                    //    xmlOut.WriteElementString("CLABE", item.CLABE);
                    //    xmlOut.WriteElementString("banco", item.banco);
                    //}

                    xmlOut.WriteEndElement();       //Pago

                    if (contarRegistrosPercepcion > 0)
                    {
                        xmlOut.WriteStartElement("Percepciones");
                        xmlOut.WriteElementString("totalGravado", NominaBD.ImporteDetalleGravadoPercepcion.ToString("0.00"));
                        xmlOut.WriteElementString("totalExento", NominaBD.ImporteDetalleExentoPercepcion.ToString("0.00"));

                        foreach (var itemPercepcion in detallePercepcion)
                        {
                            xmlOut.WriteStartElement("Percepcion");
                            xmlOut.WriteElementString("clavePercepcion", itemPercepcion.tipoPercepcionDeduccion);
                            xmlOut.WriteElementString("claveContable", itemPercepcion.clave);
                            xmlOut.WriteElementString("concepto", itemPercepcion.concepto);
                            xmlOut.WriteElementString("importeGravado", itemPercepcion.importeGravado.ToString("0.00"));
                            xmlOut.WriteElementString("importeExento", itemPercepcion.importeExento.ToString("0.00"));
                            xmlOut.WriteEndElement();       //Percepcion

                            //Importe Horas Extras Dobles
                            if (itemPercepcion.IdConcepto.Equals(38))
                                decImporteHorasExtrasDobles = itemPercepcion.importePDO;

                            //Importe Horas Extras Triples
                            if (itemPercepcion.IdConcepto.Equals(55))
                                decImporteHorasExtrasTriples = itemPercepcion.importePDO;
                        }

                        xmlOut.WriteEndElement();       //Percepciones
                    }

                    if (contarRegistrosDeduccion > 0)
                    {
                        xmlOut.WriteStartElement("Deducciones");
                        xmlOut.WriteElementString("totalGravado", NominaBD.ImporteDetalleGravadoDeduccion.ToString());
                        xmlOut.WriteElementString("totalExento", NominaBD.ImporteDetalleExentoDeduccion.ToString());

                        foreach (var itemDeduccion in detalleDeduccion)
                        {
                            xmlOut.WriteStartElement("Deduccion");
                            xmlOut.WriteElementString("claveDeduccion", itemDeduccion.tipoPercepcionDeduccion);
                            xmlOut.WriteElementString("claveContable", itemDeduccion.clave);
                            xmlOut.WriteElementString("concepto", itemDeduccion.concepto);
                            xmlOut.WriteElementString("importeGravado", itemDeduccion.importeGravado.ToString("0.00"));
                            xmlOut.WriteElementString("importeExento", itemDeduccion.importeExento.ToString("0.00"));
                            xmlOut.WriteEndElement();       //Deduccion
                        }
                        xmlOut.WriteEndElement();       //Deducciones
                    }

                    //si existe una incapacidad entonces agregar el ELEMENT
                    if ((Convert.ToInt32(item.diasIncapacidad) > 0) && (Convert.ToInt32(item.tipoIncapacidad) > 0) && (item.descuento > 0))
                    {
                        xmlOut.WriteStartElement("Incapacidades");
                        xmlOut.WriteStartElement("Incapacidad");
                        xmlOut.WriteElementString("diasIncapacidad", item.diasIncapacidad);
                        xmlOut.WriteElementString("claveIncapacidad", item.tipoIncapacidad);
                        xmlOut.WriteElementString("descuento", item.descuento.ToString("0.00"));
                        xmlOut.WriteEndElement();       //Incapacidad
                        xmlOut.WriteEndElement();       //Incapacidades
                    }

                    //si existe Importe Horas Extras Dobles/Triples entonces agregar el ELEMENT
                    if ((decImporteHorasExtrasDobles > 0) || (decImporteHorasExtrasTriples > 0))
                    {
                        xmlOut.WriteStartElement("HorasExtras");

                        if (decImporteHorasExtrasDobles > 0)
                        {
                            xmlOut.WriteStartElement("Dobles");
                            xmlOut.WriteElementString("dias", item.diasHrsDobles.ToString("N0"));
                            xmlOut.WriteElementString("horasExtra", item.horasDoblesExtra.ToString("N0"));
                            xmlOut.WriteElementString("importePagado", decImporteHorasExtrasDobles.ToString("0.00"));
                            xmlOut.WriteEndElement();       //Dobles
                        }

                        if (decImporteHorasExtrasTriples > 0)
                        {
                            xmlOut.WriteStartElement("Triples");
                            xmlOut.WriteElementString("dias", item.diasHrsTriples.ToString("N0"));
                            xmlOut.WriteElementString("horasExtra", item.horasTriplesExtra.ToString("N0"));
                            xmlOut.WriteElementString("importePagado", decImporteHorasExtrasTriples.ToString("0.00"));
                            xmlOut.WriteEndElement();       //Triples
                        }
                        xmlOut.WriteEndElement();       //HorasExtras
                    }  //element Horas Extras

                    //asignar valores enviados a Timbrar
                    objNominaControlCFDI = new NominaControlCFDI();
                    objNominaControlCFDI.IdLoteCargaNomina = pIdLoteCargaNomina;
                    objNominaControlCFDI.IdPDOHeader = pIdPDOHeader;
                    objNominaControlCFDI.FolioLoteCargaNomina = pFolioLoteCargaNomina;
                    objNominaControlCFDI.modo = item.modo;
                    objNominaControlCFDI.versionEFNomina = item.versionEFNomina;
                    objNominaControlCFDI.serieRecibo = item.serieRecibo;
                    objNominaControlCFDI.folioRecibo = pNoFolioSiguiente.ToString();
                    objNominaControlCFDI.fechaEmision = string.Format("{0:yyyy-MM-dd}T{1:HH:mm:ss}", item.fechaEmision, item.fechaEmision);
                    objNominaControlCFDI.tituloInformativo = "CONFORMIDAD";
                    objNominaControlCFDI.textoInformativo = item.leyendaRecibo;
                    objNominaControlCFDI.renglon1Informativo = string.Format("L{0}_PDOH{1}", pIdLoteCargaNomina, pIdPDOHeader);
                    objNominaControlCFDI.SoftwareNombre = "SAIC Windows";
                    objNominaControlCFDI.SoftwareVersion = ver.ToString();
                    objNominaControlCFDI.registroPatronal = item.registroPatronal;
                    objNominaControlCFDI.rfcTenedora = item.rfcTenedora;
                    objNominaControlCFDI.empresa = item.empresa;
                    objNominaControlCFDI.nombre = item.nombre;
                    objNominaControlCFDI.apellidoPaterno = item.apellidoPaterno;
                    objNominaControlCFDI.apellidoMaterno = item.apellidoMaterno;
                    objNominaControlCFDI.rfc = item.rfc;
                    objNominaControlCFDI.curp = item.curp;
                    objNominaControlCFDI.numSeguridadSocial = item.numSeguridadSocial;
                    objNominaControlCFDI.numEmpleado = item.numEmpleado;
                    objNominaControlCFDI.departamento = item.departamento;
                    objNominaControlCFDI.puesto = item.puesto;
                    objNominaControlCFDI.riesgoPuesto = item.riesgoPuesto;
                    objNominaControlCFDI.fechaInicioRelLaboral = string.Format("{0:yyyy-MM-dd}", item.fechaInicioRelLaboral);
                    objNominaControlCFDI.antiguedad = item.antiguedad;
                    objNominaControlCFDI.tipoRegimen = item.tipoRegimen;
                    objNominaControlCFDI.tipoContrato = item.tipoContrato;
                    objNominaControlCFDI.tipoJornada = item.tipoJornada;
                    objNominaControlCFDI.periodicidadPago = item.periodicidadPago;
                    objNominaControlCFDI.salarioBaseCotApor = item.salarioBaseCotApor;
                    objNominaControlCFDI.salarioDiarioIntegrado = item.salarioDiarioIntegrado;
                    objNominaControlCFDI.fechaPago = string.Format("{0:yyyy-MM-dd}", pFechaPago);
                    objNominaControlCFDI.fechaInicialPago = string.Format("{0:yyyy-MM-dd}", item.fechaInicialPago);
                    objNominaControlCFDI.fechaFinalPago = string.Format("{0:yyyy-MM-dd}", item.fechaFinalPago);
                    objNominaControlCFDI.numDiasPagados = item.numDiasPagados;
                    objNominaControlCFDI.montoPagado = item.montoPagado;
                    objNominaControlCFDI.importeConLetra = item.importeConLetra;
                    objNominaControlCFDI.tipoMoneda = item.tipoMoneda;
                    objNominaControlCFDI.tipoCambio = item.tipoCambio;
                    objNominaControlCFDI.CLABE = "";
                    objNominaControlCFDI.banco = "";
                    objNominaControlCFDI.diasIncapacidad = item.diasIncapacidad;
                    objNominaControlCFDI.tipoIncapacidad = item.tipoIncapacidad;
                    objNominaControlCFDI.descuento = item.descuento;
                    objNominaControlCFDI.diasHrsDobles = item.diasHrsDobles;
                    objNominaControlCFDI.horasDoblesExtra = item.horasDoblesExtra;
                    objNominaControlCFDI.importeHrsDoblesPagado = decImporteHorasExtrasDobles;
                    objNominaControlCFDI.diasHrsTriples = item.diasHrsTriples;
                    objNominaControlCFDI.horasTriplesExtra = item.horasTriplesExtra;
                    objNominaControlCFDI.importeHrsTriplesPagado = decImporteHorasExtrasTriples;
                }

                xmlOut.WriteEndDocument();
                xmlOut.Close();

                //enviar la información del XML generado al servicio web del PAC
                EnviarXML2wsPAC(pIdTipoMovimiento, objNominaControlCFDI);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        ///Generar Cadena 
        ///  
        private string GetCadenaOriginal(XDocument XMLstring, string fileXSL)
        {
            string CadenaOriginalSTR = "";
            try
            {
                XElement xComprobante = XMLstring.Root;
                string XMLfile = Path.GetTempFileName();
                var newFile = Path.GetTempFileName();
                xComprobante.Save(XMLfile);
                XslCompiledTransform Xsl = new XslCompiledTransform();
                Xsl.Load(fileXSL);
                Xsl.Transform(XMLfile, newFile);
                Xsl = null;
                StreamReader Stre = new StreamReader(newFile);
                CadenaOriginalSTR = Stre.ReadToEnd();
                Stre.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return CadenaOriginalSTR;
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strCertFile"></param>
        /// <returns></returns>
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

        private string Sello(string CadenaOriginal, string pass, byte[] Key)
        {
            string sello = "";
            try
            {

                //byte[] llave2 =  File.ReadAllBytes("C:\\Users\\desarrollo02\\Downloads\\CertificadoPruebas\\CSD010_AAA010101AAA.key"); // Convertimos el archivo anterior a byte

                //1) Desencriptar la llave privada, el primer parámetro es la contraseña de llave privada y el segundo es la llave privada en formato binario.
                Org.BouncyCastle.Crypto.AsymmetricKeyParameter asp = Org.BouncyCastle.Security.PrivateKeyFactory.DecryptKey(pass.ToCharArray(), Key);

                //2) Convertir a parámetros de RSA
                Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters key = (Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters)asp;

                ////3) Crear el firmador con SHA1  CAMBIO DE LA VERSIÓN 3.2
                //Org.BouncyCastle.Crypto.ISigner sig = Org.BouncyCastle.Security.SignerUtilities.GetSigner("SHA1withRSA");

                //3) Crear el firmador con SHA256
                Org.BouncyCastle.Crypto.ISigner sig = Org.BouncyCastle.Security.SignerUtilities.GetSigner("SHA-256withRSA");

                //4) Inicializar el firmador con la llave privada
                sig.Init(true, key);

                // 5) Pasar la cadena original a formato binario
                byte[] bytes = Encoding.UTF8.GetBytes(CadenaOriginal);

                // 6) Encriptar
                sig.BlockUpdate(bytes, 0, bytes.Length);
                byte[] bytesFirmados = sig.GenerateSignature();

                // 7) Finalmente obtenemos el sello
                sello = Convert.ToBase64String(bytesFirmados);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sello;

        }


        /// <summary>
        /// Método que genera los archivos XML que se generan del IdLoteCargaNomina
        /// y los Recibos de Nómina seleccionados Pensiones
        /// </summary>
        /// <param name="pIdLoteCargaNomina">Lote Carga Nómina</param>
        /// <param name="pIdPDOHeader">IdPDOHeader = FolioRecibo</param>
        private void GenerarArchivoXML2PAC_Pensiones(Int64 pIdLoteCargaNomina, string pFolioLoteCargaNomina, Int64 pIdPDOHeader, long pNoFolioSiguiente, string pIdTipoMovimiento, string pRutaArchivosCFDI, DateTime pFechaPago)
        {

            string sNamespaceSchemaLocation;
            string sNamespaceXSI;
            string sNamespaceCFDI;
            string sNamespaceXSD;

            if (bTipoCFDI != "4.0")
            {
                sNamespaceSchemaLocation = @"http://www.sat.gob.mx/cfd/3 http://www.sat.gob.mx/sitio_internet/cfd/3/cfdv33.xsd http://www.sat.gob.mx/nomina12 http://www.sat.gob.mx/sitio_internet/cfd/nomina/nomina12.xsd";     //xmlns:cfdi=
                sNamespaceXSI = @"http://www.w3.org/2001/XMLSchema-instance";
                sNamespaceCFDI = @"http://www.sat.gob.mx/cfd/3";
                sNamespaceXSD = @"http://www.sat.gob.mx/nomina12";
            }
            else
            {
                sNamespaceSchemaLocation = @"http://www.sat.gob.mx/cfd/4 http://www.sat.gob.mx/sitio_internet/cfd/4/cfdv40.xsd http://www.sat.gob.mx/nomina12 http://www.sat.gob.mx/sitio_internet/cfd/nomina/nomina12.xsd";     //xmlns:cfdi=
                sNamespaceXSI = @"http://www.w3.org/2001/XMLSchema-instance";
                sNamespaceCFDI = @"http://www.sat.gob.mx/cfd/4";
                sNamespaceXSD = @"http://www.sat.gob.mx/nomina12";
            }

            bool bFlagIndem = false;

            //const string path = @"c:\BPOCFDI\";
            string path = pRutaArchivosCFDI + "\\";
            string pathCadena = @"C:/SAT/";
            decimal decImporteHorasExtrasDobles = 0.0M;
            decimal decImporteHorasExtrasTriples = 0.0M;
            NominaControlCFDI objNominaControlCFDI = null;
            string NombreEmpleadoCompleto = "";
            string cadenaoriginal = "";
            string Serie = "";
            string sello = "";
            string Certificado = "";
            string Password = "";
            string Usuario = "";
            decimal indemi = 0;

            if ((NominaBD.ImporteDetalleGravadoPercepcion + NominaBD.ImporteDetalleExentoPercepcion + NominaBD.ImporteDetalleGravadoOtro + NominaBD.ImporteDetalleExentoOtro + NominaBD.ImporteDetalleExentoJubil + NominaBD.ImporteDetalleGravadoJubil + NominaBD.ImporteDetalleGravadoSeparacionIn + NominaBD.ImporteDetalleExentoSeparacionIn) > 0)
            {
                XmlWriterSettings settings = new XmlWriterSettings() { Encoding = new UTF8Encoding(false), Indent = true, IndentChars = ("     ") };

                string sFolioReciboPDOHeader = pIdPDOHeader.ToString();
                try
                {

                    //obtiene informacion de la version del Archivo AssemblyInfo.cs, seccion [assembly: AssemblyFileVersion("1.1.0.105")]
                    Version ver = new Version(System.Windows.Forms.Application.ProductVersion);

                    //filtrar el detalle de Nominas por IdPDOHeader = FolioRecibo
                    var nominas = from row in objNominaList.Where(row => row.folioRecibo == sFolioReciboPDOHeader)
                                  select row;

                    //filtrar por Percepciones
                    var detallePercepcion = from rowPercepcion in objDetalleNominaList
                                            where (rowPercepcion.ClasifConcepto == "P" && rowPercepcion.AplicaOtrosPagosSAT == 0 && (rowPercepcion.ClasifConcepto != "022" || rowPercepcion.ClasifConcepto != "023" || rowPercepcion.ClasifConcepto != "025"))
                                            orderby rowPercepcion.IdPDOHeader
                                            select rowPercepcion;

                    var contarRegistrosPercepcion = detallePercepcion.Count();      //obtener No. de registros

                    //filtrar por Pensiones
                    var detallePensiones = from rowPension in objDetalleNominaList
                                           where rowPension.ClasifConcepto == "AP" && (rowPension.tipoPercepcionDeduccion == "039" || rowPension.tipoPercepcionDeduccion == "016")
                                           orderby rowPension.IdPDOHeader
                                           select rowPension;

                    var contarRegistrosPensiones = detallePensiones.Count();      //obtener No. de registros

                    //filtrar por Pensiones ADNA
                    var detallePensionesADNA = from rowPension in objDetalleNominaList
                                               where rowPension.ClasifConcepto == "AP" && (rowPension.tipoPercepcionDeduccion == "044" || rowPension.tipoPercepcionDeduccion == "016")
                                               orderby rowPension.IdPDOHeader
                                               select rowPension;

                    var contarRegistrosPensionesADNA = detallePensionesADNA.Count();      //obtener No. de registros

                    //filtrar por Indemnizacion
                    var detalleIndemnizacion = from rowIndemnizacion in objDetalleNominaList
                                               where (rowIndemnizacion.ClasifConcepto == "P" && (rowIndemnizacion.tipoPercepcionDeduccion.Equals("022") || rowIndemnizacion.tipoPercepcionDeduccion.Equals("023") || rowIndemnizacion.tipoPercepcionDeduccion.Equals("025")))
                                               orderby rowIndemnizacion.IdPDOHeader
                                               select rowIndemnizacion;

                    var contarRegistrosIndemnizacion = detalleIndemnizacion.Count();      //obtener No. de registros

                    //filtrar por Deducciones
                    var detalleDeduccion = from rowDeduccion in objDetalleNominaList
                                           where rowDeduccion.ClasifConcepto == "D"
                                           orderby rowDeduccion.IdPDOHeader
                                           select rowDeduccion;
                    var contarRegistrosDeduccion = detalleDeduccion.Count();        //obtener No. de registros

                    //filtrar por Deducciones
                    var detalleOtros = from rowOtrosPagos in objDetalleNominaList
                                       where rowOtrosPagos.ClasifConcepto == "P" && rowOtrosPagos.AplicaOtrosPagosSAT == 1
                                       orderby rowOtrosPagos.IdPDOHeader
                                       select rowOtrosPagos;

                    var contarRegistrosOtros = detalleOtros.Count();        //obtener No. de registros


                    XDocument doc = new XDocument();
                    //crear objeto XMLWriter
                    pathXmlFiles = string.Format(@"{0}L{1}-{2}.xml", path, pIdLoteCargaNomina, pNoFolioSiguiente);
                    string ns1;
                    string prefix = "cfdi";

                    if (bTipoCFDI != "4.0")
                    {
                        ns1 = "http://www.sat.gob.mx/cfd/3";
                    }
                    else
                    {
                        ns1 = "http://www.sat.gob.mx/cfd/4";
                    }

                    using (XmlWriter xmlOut = doc.CreateWriter())
                    {
                        xmlOut.WriteStartDocument();
                        xmlOut.WriteStartElement(prefix, "Comprobante", ns1);
                        xmlOut.WriteAttributeString("xmlns", "nomina12", null, sNamespaceXSD);
                        xmlOut.WriteAttributeString("xmlns", "xsi", null, sNamespaceXSI);
                        xmlOut.WriteAttributeString("xmlns", "cfdi", null, sNamespaceCFDI);
                        xmlOut.WriteAttributeString("xsi", "schemaLocation", null, sNamespaceSchemaLocation);


                        foreach (var item in nominas)
                        {
                            if (bTipoCFDI != "4.0")
                                xmlOut.WriteAttributeString("Version", "3.3");
                            else
                                xmlOut.WriteAttributeString("Version", "4.0");

                            xmlOut.WriteAttributeString("Folio", pNoFolioSiguiente.ToString());
                            xmlOut.WriteAttributeString("Serie", item.serieRecibo.ToString());
                            xmlOut.WriteAttributeString("Fecha", string.Format("{0:yyyy-MM-dd}T{1:HH:mm:ss}", item.fechaEmision, item.fechaEmision));
                            xmlOut.WriteAttributeString("Sello", "");

                            if (bTipoCFDI != "4.0")
                                xmlOut.WriteAttributeString("FormaPago", "99");

                            xmlOut.WriteAttributeString("NoCertificado", item.NoCertificado);

                            if (bTipoCFDI != "4.0")
                                xmlOut.WriteAttributeString("Certificado", item.versionEFNomina);
                            else
                                xmlOut.WriteAttributeString("Certificado", item.CertificadoCadena);

                            if (bTipoCFDI == "4.0")
                                xmlOut.WriteAttributeString("Exportacion", item.Exportacion);

                            if (pFolioLoteCargaNomina.Substring(0, 1) == "S")
                                xmlOut.WriteAttributeString("SubTotal", (NominaBD.ImporteDetalleGravadoPercepcion + NominaBD.ImporteDetalleExentoPercepcion + NominaBD.ImporteDetalleGravadoOtro + NominaBD.ImporteDetalleExentoOtro + NominaBD.ImporteDetalleExentoSeparacionIn + NominaBD.ImporteDetalleGravadoSeparacionIn).ToString("0.00"));
                            else
                                xmlOut.WriteAttributeString("SubTotal", (NominaBD.ImporteDetalleGravadoJubil + NominaBD.ImporteDetalleExentoJubil + NominaBD.ImporteDetalleGravadoOtro + NominaBD.ImporteDetalleExentoOtro + NominaBD.ImporteDetalleExentoSeparacionIn + NominaBD.ImporteDetalleGravadoSeparacionIn).ToString("0.00"));


                            if (bTipoCFDI != "4.0")
                            {
                                if (!item.tipoMoneda.Equals("MXN"))
                                    xmlOut.WriteElementString("TipoCambio", item.tipoCambio.ToString());
                                else
                                    xmlOut.WriteAttributeString("TipoCambio", "1");
                            }

                            xmlOut.WriteAttributeString("Moneda", item.tipoMoneda);
                            if (contarRegistrosDeduccion > 0 && contarRegistrosPercepcion > 0)
                                xmlOut.WriteAttributeString("Descuento", (NominaBD.ImporteDetalleGravadoDeduccion + NominaBD.ImporteDetalleExentoDeduccion + NominaBD.ImporteDetalleGravadoDeduccionSAT + NominaBD.ImporteDetalleExentoDeduccionSAT).ToString("0.00"));
                            if (pFolioLoteCargaNomina.Substring(0, 1) == "S")
                                xmlOut.WriteAttributeString("Total", (NominaBD.ImporteDetalleGravadoPercepcion + NominaBD.ImporteDetalleExentoPercepcion + NominaBD.ImporteDetalleGravadoOtro + NominaBD.ImporteDetalleExentoOtro + NominaBD.ImporteDetalleExentoSeparacionIn + NominaBD.ImporteDetalleGravadoSeparacionIn - NominaBD.ImporteDetalleGravadoDeduccion - NominaBD.ImporteDetalleExentoDeduccion - NominaBD.ImporteDetalleGravadoDeduccionSAT - NominaBD.ImporteDetalleExentoDeduccionSAT).ToString("0.00"));
                            else
                                xmlOut.WriteAttributeString("Total", (NominaBD.ImporteDetalleGravadoJubil + NominaBD.ImporteDetalleExentoJubil + NominaBD.ImporteDetalleGravadoOtro + NominaBD.ImporteDetalleExentoOtro + NominaBD.ImporteDetalleExentoSeparacionIn + NominaBD.ImporteDetalleGravadoSeparacionIn).ToString("0.00")); //- NominaBD.ImporteDetalleGravadoDeduccion - NominaBD.ImporteDetalleExentoDeduccion
                            xmlOut.WriteAttributeString("MetodoPago", "PUE");
                            xmlOut.WriteAttributeString("TipoDeComprobante", "N");
                            xmlOut.WriteAttributeString("LugarExpedicion", item.CodigoPostalTenedora);

                            xmlOut.WriteStartElement(prefix, "Emisor", ns1);
                            xmlOut.WriteAttributeString("Nombre", item.razonSocialTenedora);
                            xmlOut.WriteAttributeString("RegimenFiscal", item.RegimenFiscalSAT); //Modifica "601" 15/01/2022 "601"
                            xmlOut.WriteAttributeString("Rfc", item.RFCEmisor); //Modificar para Lucas "URE180429TM6"); "URE180429TM6"); //
                            xmlOut.WriteFullEndElement();       //Patron

                            xmlOut.WriteStartElement(prefix, "Receptor", ns1);
                            NombreEmpleadoCompleto = item.nombre.ToString();
                            if (item.apellidoPaterno.Length > 0)
                                NombreEmpleadoCompleto = NombreEmpleadoCompleto + " " + item.apellidoPaterno.ToString();
                            if (item.apellidoMaterno.Length > 0)
                                NombreEmpleadoCompleto = NombreEmpleadoCompleto + " " + item.apellidoMaterno.ToString();
                            xmlOut.WriteAttributeString("Nombre", NombreEmpleadoCompleto);
                            xmlOut.WriteAttributeString("Rfc", item.rfc.ToString());

                            if (bTipoCFDI != "4.0")
                            {
                                xmlOut.WriteAttributeString("UsoCFDI", "P01");
                            }
                            else
                            {
                                xmlOut.WriteAttributeString("UsoCFDI", item.UsoCFDI.ToString()); //Sustitulle "P01" por version 4.0
                                xmlOut.WriteAttributeString("DomicilioFiscalReceptor", item.CodigoPostalCliente.ToString());
                                xmlOut.WriteAttributeString("RegimenFiscalReceptor", item.RegimenFiscalSATCliente);
                            }
                            xmlOut.WriteFullEndElement();       //Empleado

                            xmlOut.WriteStartElement(prefix, "Conceptos", ns1);
                            xmlOut.WriteStartElement(prefix, "Concepto", ns1);

                            if (contarRegistrosDeduccion > 0 && contarRegistrosPercepcion > 0)
                                xmlOut.WriteAttributeString("Descuento", (NominaBD.ImporteDetalleGravadoDeduccion + NominaBD.ImporteDetalleExentoDeduccion + NominaBD.ImporteDetalleGravadoDeduccionSAT + NominaBD.ImporteDetalleExentoDeduccionSAT).ToString("0.00"));

                            if (contarRegistrosPercepcion > 0 && pFolioLoteCargaNomina.Substring(0, 1) == "S")
                            {
                                xmlOut.WriteAttributeString("Importe", (NominaBD.ImporteDetalleGravadoPercepcion + NominaBD.ImporteDetalleExentoPercepcion + NominaBD.ImporteDetalleGravadoOtro + NominaBD.ImporteDetalleExentoOtro + NominaBD.ImporteDetalleExentoSeparacionIn + NominaBD.ImporteDetalleGravadoSeparacionIn).ToString("0.00"));
                                xmlOut.WriteAttributeString("ValorUnitario", (NominaBD.ImporteDetalleGravadoPercepcion + NominaBD.ImporteDetalleExentoPercepcion + NominaBD.ImporteDetalleGravadoOtro + NominaBD.ImporteDetalleExentoOtro + NominaBD.ImporteDetalleExentoSeparacionIn + NominaBD.ImporteDetalleGravadoSeparacionIn).ToString("0.00"));
                            }
                            else
                            {
                                xmlOut.WriteAttributeString("Importe", (item.montoPagado).ToString("0.00"));
                                xmlOut.WriteAttributeString("ValorUnitario", (item.montoPagado).ToString("0.00"));
                            }
                            xmlOut.WriteAttributeString("Descripcion", "Pago de nómina");
                            xmlOut.WriteAttributeString("ClaveUnidad", "ACT");
                            xmlOut.WriteAttributeString("Cantidad", "1");
                            xmlOut.WriteAttributeString("ClaveProdServ", "84111505");

                            if (bTipoCFDI == "4.0")
                            {
                                xmlOut.WriteAttributeString("ObjetoImp", item.ObjetiImp.ToString());
                            }

                            xmlOut.WriteFullEndElement();
                            xmlOut.WriteEndElement();       //Conceptos

                            //xmlOut.WriteStartElement(prefix, "Impuestos", ns1);
                            //xmlOut.WriteEndElement();       //Impuestos

                            xmlOut.WriteStartElement(prefix, "Complemento", ns1);

                            xmlOut.WriteStartElement("nomina12", "Nomina", null);

                            if (contarRegistrosDeduccion > 0 && (contarRegistrosPercepcion > 0 || pFolioLoteCargaNomina.Substring(0, 1) == "S"))
                                xmlOut.WriteAttributeString("TotalDeducciones", (NominaBD.ImporteDetalleGravadoDeduccion + NominaBD.ImporteDetalleExentoDeduccion + NominaBD.ImporteDetalleGravadoDeduccionSAT + NominaBD.ImporteDetalleExentoDeduccionSAT).ToString("0.00"));

                            if (contarRegistrosOtros > 0)
                                xmlOut.WriteAttributeString("TotalOtrosPagos", (NominaBD.ImporteDetalleGravadoOtro + NominaBD.ImporteDetalleExentoOtro).ToString("0.00"));


                            if (contarRegistrosPercepcion > 0 || pFolioLoteCargaNomina.Substring(0, 1) == "S")
                                xmlOut.WriteAttributeString("TotalPercepciones", (NominaBD.ImporteDetalleGravadoPercepcion + NominaBD.ImporteDetalleExentoPercepcion + NominaBD.ImporteDetalleExentoSeparacionIn + NominaBD.ImporteDetalleGravadoSeparacionIn).ToString("0.00"));
                            else
                                xmlOut.WriteAttributeString("TotalPercepciones", item.montoPagado.ToString("0.00"));

                            if (item.numDiasPagados <= 0)
                                xmlOut.WriteAttributeString("NumDiasPagados", "0.001");
                            else
                                xmlOut.WriteAttributeString("NumDiasPagados", item.numDiasPagados.ToString("0.000"));
                            xmlOut.WriteAttributeString("FechaFinalPago", string.Format("{0:yyyy-MM-dd}", item.fechaFinalPago, item.fechaFinalPago));
                            xmlOut.WriteAttributeString("FechaInicialPago", string.Format("{0:yyyy-MM-dd}", item.fechaInicialPago, item.fechaInicialPago));
                            xmlOut.WriteAttributeString("FechaPago", string.Format("{0:yyyy-MM-dd}", pFechaPago));// item.fechaPago, item.fechaPago));
                            if (item.TipoNominaSAT.ToString() == "ordinaria")
                                xmlOut.WriteAttributeString("TipoNomina", "O");
                            else
                                xmlOut.WriteAttributeString("TipoNomina", "E");  //Agregar tipo fr nomina 
                            xmlOut.WriteAttributeString("Version", item.versionEFNomina); //Modificar a 3.2

                            if (contarRegistrosIndemnizacion == 0)
                            {
                                xmlOut.WriteStartElement("nomina12", "Emisor", null);
                                xmlOut.WriteAttributeString("RegistroPatronal", item.registroPatronal); //Modificar para Finkok "BBBB020202BB0");// 
                                xmlOut.WriteFullEndElement();
                            }

                            xmlOut.WriteStartElement("nomina12", "Receptor", null);
                            xmlOut.WriteAttributeString("TipoRegimen", item.IdRegimenFiscalEmpleadoSAT.ToString());
                            xmlOut.WriteAttributeString("TipoJornada", item.IdTipoJornadaSAT.ToString());
                            xmlOut.WriteAttributeString("TipoContrato", item.IdTipoContratoSAT.ToString());
                            xmlOut.WriteAttributeString("Sindicalizado", item.SindicalizadoSAT.ToString());  //Agregar
                            if (pFolioLoteCargaNomina.Substring(0, 1) != "S")//contarRegistrosPensiones > 0 && contarRegistrosPercepcion<=0)
                            {
                                if (contarRegistrosIndemnizacion == 0)
                                {
                                    xmlOut.WriteAttributeString("SalarioDiarioIntegrado", "0.00");
                                }
                                xmlOut.WriteAttributeString("SalarioBaseCotApor", "0.00");
                            }
                            else
                            {
                                if (contarRegistrosIndemnizacion == 0)
                                {
                                    xmlOut.WriteAttributeString("SalarioDiarioIntegrado", item.salarioDiarioIntegrado.ToString("0.00"));
                                }
                                xmlOut.WriteAttributeString("SalarioBaseCotApor", item.salarioBaseCotApor.ToString("0.00"));
                            }

                            if (contarRegistrosIndemnizacion == 0)
                            {
                                xmlOut.WriteAttributeString("RiesgoPuesto", item.riesgoPuesto.ToString());
                            }
                            xmlOut.WriteAttributeString("Puesto", item.puesto.ToString());
                            xmlOut.WriteAttributeString("PeriodicidadPago", item.IdPeriodicidadPagoSAT.ToString());

                            if (contarRegistrosIndemnizacion == 0)
                            {
                                xmlOut.WriteAttributeString("NumSeguridadSocial", item.numSeguridadSocial.ToString());
                            }
                            xmlOut.WriteAttributeString("NumEmpleado", item.numEmpleado.ToString());

                            if (contarRegistrosIndemnizacion == 0)
                            {
                                xmlOut.WriteAttributeString("FechaInicioRelLaboral", string.Format("{0:yyyy-MM-dd}", item.fechaInicioRelLaboral, item.fechaInicioRelLaboral));
                            }
                            xmlOut.WriteAttributeString("Departamento", item.departamento.ToString());
                            xmlOut.WriteAttributeString("Curp", item.curp.ToString());
                            //xmlOut.WriteAttributeString("CuentaBancaria", item.CLABE.ToString());
                            xmlOut.WriteAttributeString("ClaveEntFed", item.EntidadFederativaTrabajo.ToString()); //Agregar

                            if (contarRegistrosIndemnizacion == 0)
                            {                                                                                   //xmlOut.WriteAttributeString("Banco", item.banco.ToString());
                                xmlOut.WriteAttributeString("Antigüedad", "P" + (Decimal.Round(item.antiguedad / 7)).ToString() + "W");
                            }
                            xmlOut.WriteFullEndElement();

                            if (contarRegistrosPercepcion > 0 && pFolioLoteCargaNomina.Substring(0, 1) == "S")
                            {
                                xmlOut.WriteStartElement("nomina12", "Percepciones", null);
                                xmlOut.WriteAttributeString("TotalSueldos", (NominaBD.ImporteDetalleGravadoPercepcion + NominaBD.ImporteDetalleExentoPercepcion).ToString("0.00"));
                                if (contarRegistrosIndemnizacion > 0)
                                    xmlOut.WriteAttributeString("TotalSeparacionIndemnizacion", (NominaBD.ImporteDetalleExentoSeparacionIn + NominaBD.ImporteDetalleGravadoSeparacionIn).ToString("0.00"));
                                xmlOut.WriteAttributeString("TotalGravado", (NominaBD.ImporteDetalleGravadoPercepcion + NominaBD.ImporteDetalleGravadoSeparacionIn).ToString("0.00"));
                                xmlOut.WriteAttributeString("TotalExento", (NominaBD.ImporteDetalleExentoPercepcion + NominaBD.ImporteDetalleExentoSeparacionIn).ToString("0.00"));

                                foreach (var itemPercepcion in detallePercepcion)
                                {
                                    xmlOut.WriteStartElement("nomina12", "Percepcion", null);
                                    xmlOut.WriteAttributeString("TipoPercepcion", itemPercepcion.tipoPercepcionDeduccion);
                                    xmlOut.WriteAttributeString("Clave", itemPercepcion.tipoPercepcionDeduccion);
                                    xmlOut.WriteAttributeString("Concepto", itemPercepcion.concepto);
                                    xmlOut.WriteAttributeString("ImporteGravado", itemPercepcion.importeGravado.ToString("0.00"));
                                    xmlOut.WriteAttributeString("ImporteExento", itemPercepcion.importeExento.ToString("0.00"));

                                    //Importe Horas Extras Dobles
                                    if (itemPercepcion.IdConcepto.Equals(38))
                                    {
                                        decImporteHorasExtrasDobles = itemPercepcion.importePDO;
                                        xmlOut.WriteStartElement("nomina12", "HorasExtra", null);//HorasExtras
                                        xmlOut.WriteAttributeString("Dias", item.diasHrsDobles.ToString("N0"));
                                        xmlOut.WriteAttributeString("TipoHoras", "01");
                                        xmlOut.WriteAttributeString("HorasExtra", item.horasDoblesExtra.ToString("N0"));
                                        xmlOut.WriteAttributeString("ImportePagado", decImporteHorasExtrasDobles.ToString("0.00"));
                                        xmlOut.WriteEndElement();       //Dobles
                                    }
                                    //Importe Horas Extras Triples
                                    if (itemPercepcion.IdConcepto.Equals(55))
                                    {
                                        decImporteHorasExtrasTriples = itemPercepcion.importePDO;
                                        xmlOut.WriteStartElement("nomina12", "HorasExtra", null);//HorasExtras
                                        xmlOut.WriteAttributeString("Dias", item.diasHrsTriples.ToString("N0"));
                                        xmlOut.WriteAttributeString("TipoHoras", "02");
                                        xmlOut.WriteAttributeString("HorasExtra", item.horasTriplesExtra.ToString("N0"));
                                        xmlOut.WriteAttributeString("ImportePagado", decImporteHorasExtrasTriples.ToString("0.00"));
                                        xmlOut.WriteEndElement();       //Triples
                                    }
                                    //si existe una incapacidad entonces agregar el ELEMENT
                                    if (itemPercepcion.tipoPercepcionDeduccion == "014")
                                    {
                                        indemi = (itemPercepcion.importeExento + itemPercepcion.importeGravado);
                                    }

                                    xmlOut.WriteFullEndElement();       //Percepcion

                                    if ((item.periodicidadPago.Equals("FINIQUITO")) || (item.periodicidadPago.Equals("LIQUIDACION")))
                                        if (itemPercepcion.concepto.Contains("Indemniz"))
                                            bFlagIndem = true;

                                }

                                if (contarRegistrosIndemnizacion > 0 && bFlagIndem)
                                {
                                    xmlOut.WriteStartElement("nomina12", "SeparacionIndemnizacion", null);
                                    xmlOut.WriteAttributeString("TotalPagado", (NominaBD.ImporteDetalleExentoSeparacionIn + NominaBD.ImporteDetalleGravadoSeparacionIn).ToString("0.00"));
                                    xmlOut.WriteAttributeString("NumAñosServicio", (decimal.Round(((TimeSpan)(item.fechaFinalPago - item.fechaInicioRelLaboral)).Days / 365)).ToString());
                                    xmlOut.WriteAttributeString("UltimoSueldoMensOrd", (item.salarioDiarioIntegrado * 30).ToString("0.00"));
                                    xmlOut.WriteAttributeString("IngresoAcumulable", NominaBD.ImporteDetalleGravadoSeparacionIn.ToString("0.00"));
                                    xmlOut.WriteAttributeString("IngresoNoAcumulable", NominaBD.ImporteDetalleExentoSeparacionIn.ToString("0.00"));
                                    xmlOut.WriteEndElement();

                                }
                                xmlOut.WriteFullEndElement();       //Percepciones

                            }
                            else if (contarRegistrosPensiones > 0 && pFolioLoteCargaNomina.Substring(0, 1) != "S")
                            {
                                xmlOut.WriteStartElement("nomina12", "Percepciones", null);
                                xmlOut.WriteAttributeString("TotalJubilacionPensionRetiro", item.montoPagado.ToString("0.00"));
                                xmlOut.WriteAttributeString("TotalGravado", "0.00");// NominaBD.ImporteDetalleGravadoPercepcion.ToString("0.00"));
                                xmlOut.WriteAttributeString("TotalExento", item.montoPagado.ToString("0.00"));

                                decimal importeExento = 0;
                                decimal importeGravado = 0;
                                foreach (var itemPercepcion in detallePensiones)
                                {
                                    xmlOut.WriteStartElement("nomina12", "Percepcion", null);
                                    if (itemPercepcion.tipoPercepcionDeduccion == "016")
                                        xmlOut.WriteAttributeString("TipoPercepcion", "039");
                                    else
                                        xmlOut.WriteAttributeString("TipoPercepcion", itemPercepcion.tipoPercepcionDeduccion);

                                    xmlOut.WriteAttributeString("ImporteGravado", "0.00");// itemPercepcion.importeGravado.ToString("0.00"));
                                    xmlOut.WriteAttributeString("ImporteExento", (itemPercepcion.importeExento + itemPercepcion.importeGravado).ToString("0.00"));
                                    xmlOut.WriteAttributeString("Concepto", itemPercepcion.concepto);
                                    if (itemPercepcion.tipoPercepcionDeduccion == "016")
                                        xmlOut.WriteAttributeString("Clave", "039");
                                    else
                                        xmlOut.WriteAttributeString("Clave", itemPercepcion.tipoPercepcionDeduccion);
                                    xmlOut.WriteEndElement();       //Percepcion
                                    importeExento = importeExento + (itemPercepcion.importeExento + itemPercepcion.importeGravado);

                                }
                                xmlOut.WriteStartElement("nomina12", "JubilacionPensionRetiro", null);
                                xmlOut.WriteAttributeString("IngresoNoAcumulable", (importeExento + importeGravado).ToString("0.00"));
                                xmlOut.WriteAttributeString("IngresoAcumulable", "0.00");// importeGravado.ToString("0.00"));
                                xmlOut.WriteAttributeString("TotalUnaExhibicion", (importeExento + importeGravado).ToString("0.00"));
                                xmlOut.WriteEndElement();

                                xmlOut.WriteEndElement();       //Pensiones
                            }
                            else if (contarRegistrosPensionesADNA > 0 && pFolioLoteCargaNomina.Substring(0, 1) != "S")
                            {
                                xmlOut.WriteStartElement("nomina12", "Percepciones", null);
                                xmlOut.WriteAttributeString("TotalJubilacionPensionRetiro", item.montoPagado.ToString("0.00"));
                                xmlOut.WriteAttributeString("TotalGravado", "0.00");// NominaBD.ImporteDetalleGravadoPercepcion.ToString("0.00"));
                                xmlOut.WriteAttributeString("TotalExento", item.montoPagado.ToString("0.00"));

                                decimal importeExento = 0;
                                decimal importeGravado = 0;
                                foreach (var itemPercepcion in detallePensionesADNA)
                                {
                                    xmlOut.WriteStartElement("nomina12", "Percepcion", null);
                                    if (itemPercepcion.tipoPercepcionDeduccion == "016")
                                        xmlOut.WriteAttributeString("TipoPercepcion", "044");
                                    else
                                        xmlOut.WriteAttributeString("TipoPercepcion", itemPercepcion.tipoPercepcionDeduccion);

                                    xmlOut.WriteAttributeString("ImporteGravado", "0.00");// itemPercepcion.importeGravado.ToString("0.00"));
                                    xmlOut.WriteAttributeString("ImporteExento", (itemPercepcion.importeExento + itemPercepcion.importeGravado).ToString("0.00"));
                                    xmlOut.WriteAttributeString("Concepto", itemPercepcion.concepto);

                                    if (itemPercepcion.tipoPercepcionDeduccion == "016")
                                        xmlOut.WriteAttributeString("Clave", "044");
                                    else
                                        xmlOut.WriteAttributeString("Clave", itemPercepcion.tipoPercepcionDeduccion);
                                    xmlOut.WriteEndElement();       //Percepcion
                                    importeExento = importeExento + (itemPercepcion.importeExento + itemPercepcion.importeGravado);

                                }
                                xmlOut.WriteStartElement("nomina12", "JubilacionPensionRetiro", null);
                                xmlOut.WriteAttributeString("IngresoNoAcumulable", (importeExento + importeGravado).ToString("0.00"));
                                xmlOut.WriteAttributeString("IngresoAcumulable", "0.00");// importeGravado.ToString("0.00"));
                                xmlOut.WriteAttributeString("MontoDiario", (Math.Round((importeExento + importeGravado) / item.numDiasPagados, 2)).ToString("0.00"));
                                xmlOut.WriteAttributeString("TotalParcialidad", (importeExento + importeGravado).ToString("0.00"));
                                xmlOut.WriteEndElement();

                                xmlOut.WriteEndElement();       //Pensiones
                            }

                            if (contarRegistrosDeduccion > 0 && contarRegistrosPercepcion > 0)
                            {
                                xmlOut.WriteStartElement("nomina12", "Deducciones", null);

                                xmlOut.WriteAttributeString("TotalOtrasDeducciones", (NominaBD.ImporteDetalleGravadoDeduccion + NominaBD.ImporteDetalleExentoDeduccion).ToString("0.00"));
                                if ((NominaBD.ImporteDetalleGravadoDeduccionSAT + NominaBD.ImporteDetalleExentoDeduccionSAT) > 0)
                                    xmlOut.WriteAttributeString("TotalImpuestosRetenidos", (NominaBD.ImporteDetalleGravadoDeduccionSAT + NominaBD.ImporteDetalleExentoDeduccionSAT).ToString("0.00"));

                                foreach (var itemDeduccion in detalleDeduccion)
                                {
                                    xmlOut.WriteStartElement("nomina12", "Deduccion", null);
                                    xmlOut.WriteAttributeString("TipoDeduccion", itemDeduccion.tipoPercepcionDeduccion);
                                    xmlOut.WriteAttributeString("Clave", itemDeduccion.tipoPercepcionDeduccion);
                                    xmlOut.WriteAttributeString("Concepto", itemDeduccion.concepto);
                                    xmlOut.WriteAttributeString("Importe", itemDeduccion.importeGravado.ToString("0.00"));
                                    xmlOut.WriteFullEndElement();       //Deduccion
                                }
                                xmlOut.WriteEndElement();       //Deducciones
                            }

                            if (contarRegistrosOtros > 0)
                            {
                                xmlOut.WriteStartElement("nomina12", "OtrosPagos", null);
                                foreach (var itemOtros in detalleOtros)
                                {
                                    xmlOut.WriteStartElement("nomina12", "OtroPago", null);
                                    xmlOut.WriteAttributeString("TipoOtroPago", itemOtros.tipoPercepcionDeduccion);
                                    xmlOut.WriteAttributeString("Clave", itemOtros.tipoPercepcionDeduccion);
                                    xmlOut.WriteAttributeString("Concepto", itemOtros.concepto);
                                    xmlOut.WriteAttributeString("Importe", (itemOtros.importeGravado + itemOtros.importeExento).ToString("0.00"));

                                    if (itemOtros.tipoPercepcionDeduccion == "002")
                                    {
                                        xmlOut.WriteStartElement("nomina12", "SubsidioAlEmpleo", null);
                                        xmlOut.WriteAttributeString("SubsidioCausado", (item.SubsidioCausadoSAT).ToString("0.00"));
                                        xmlOut.WriteFullEndElement();
                                    }
                                    xmlOut.WriteEndElement();       //OtrosPago
                                }
                                xmlOut.WriteEndElement();       //OtrosPagos
                            }

                            if (indemi > 0)
                            {
                                xmlOut.WriteStartElement("nomina12", "Incapacidades", null);
                                xmlOut.WriteStartElement("nomina12", "Incapacidad", null);
                                xmlOut.WriteAttributeString("DiasIncapacidad", item.diasIncapacidad);
                                if (item.tipoIncapacidad.Length < 2)
                                    xmlOut.WriteAttributeString("TipoIncapacidad", "0" + item.tipoIncapacidad);
                                else
                                    xmlOut.WriteAttributeString("TipoIncapacidad", item.tipoIncapacidad);
                                xmlOut.WriteAttributeString("ImporteMonetario", (indemi).ToString("0.00"));
                                xmlOut.WriteEndElement();       //Incapacidad
                                xmlOut.WriteEndElement();       //Incapacidades
                            }

                            //asignar valores enviados a Timbrar
                            objNominaControlCFDI = new NominaControlCFDI();
                            objNominaControlCFDI.IdLoteCargaNomina = pIdLoteCargaNomina;
                            objNominaControlCFDI.IdPDOHeader = pIdPDOHeader;
                            objNominaControlCFDI.leyendaRecibo = item.leyendaRecibo;
                            objNominaControlCFDI.FolioLoteCargaNomina = pFolioLoteCargaNomina;
                            objNominaControlCFDI.modo = item.modo;
                            objNominaControlCFDI.versionEFNomina = item.versionEFNomina;
                            objNominaControlCFDI.serieRecibo = item.serieRecibo;
                            objNominaControlCFDI.folioRecibo = pNoFolioSiguiente.ToString();
                            objNominaControlCFDI.fechaEmision = string.Format("{0:yyyy-MM-dd}T{1:HH:mm:ss}", item.fechaEmision, item.fechaEmision);
                            objNominaControlCFDI.tituloInformativo = "CONFORMIDAD";
                            objNominaControlCFDI.textoInformativo = item.leyendaRecibo;
                            objNominaControlCFDI.renglon1Informativo = string.Format("L{0}_PDOH{1}", pIdLoteCargaNomina, pIdPDOHeader);
                            objNominaControlCFDI.SoftwareNombre = "SAIC Windows";
                            objNominaControlCFDI.SoftwareVersion = ver.ToString();
                            objNominaControlCFDI.versionCFDI = bTipoCFDI;
                            objNominaControlCFDI.registroPatronal = item.registroPatronal;
                            objNominaControlCFDI.rfcTenedora = item.rfcTenedora;
                            objNominaControlCFDI.empresa = item.empresa;
                            objNominaControlCFDI.nombre = item.nombre;
                            objNominaControlCFDI.apellidoPaterno = item.apellidoPaterno;
                            objNominaControlCFDI.apellidoMaterno = item.apellidoMaterno;
                            objNominaControlCFDI.rfc = item.rfc;
                            objNominaControlCFDI.curp = item.curp;
                            objNominaControlCFDI.numSeguridadSocial = item.numSeguridadSocial;
                            objNominaControlCFDI.numEmpleado = item.numEmpleado;
                            objNominaControlCFDI.departamento = item.departamento;
                            objNominaControlCFDI.puesto = item.puesto;
                            objNominaControlCFDI.riesgoPuesto = item.riesgoPuesto;
                            objNominaControlCFDI.fechaInicioRelLaboral = string.Format("{0:yyyy-MM-dd}", item.fechaInicioRelLaboral);
                            objNominaControlCFDI.antiguedad = item.antiguedad;
                            objNominaControlCFDI.tipoRegimen = item.tipoRegimen;
                            objNominaControlCFDI.tipoContrato = item.tipoContrato;
                            objNominaControlCFDI.tipoJornada = item.tipoJornada;
                            objNominaControlCFDI.periodicidadPago = item.periodicidadPago;
                            if (contarRegistrosPercepcion > 0)
                            {
                                objNominaControlCFDI.salarioBaseCotApor = item.salarioBaseCotApor;
                                objNominaControlCFDI.salarioDiarioIntegrado = item.salarioDiarioIntegrado;
                            }
                            else
                            {
                                objNominaControlCFDI.salarioBaseCotApor = 0;
                                objNominaControlCFDI.salarioDiarioIntegrado = 0;
                            }

                            objNominaControlCFDI.fechaPago = string.Format("{0:yyyy-MM-dd}", pFechaPago);
                            objNominaControlCFDI.fechaInicialPago = string.Format("{0:yyyy-MM-dd}", item.fechaInicialPago);
                            objNominaControlCFDI.fechaFinalPago = string.Format("{0:yyyy-MM-dd}", item.fechaFinalPago);
                            objNominaControlCFDI.numDiasPagados = item.numDiasPagados;
                            objNominaControlCFDI.numDiasFaltasJus = item.numDiasFaltasJus;
                            objNominaControlCFDI.numDiasFaltasInJus = item.numDiasFaltasInJus;
                            objNominaControlCFDI.montoPagado = item.montoPagado;
                            objNominaControlCFDI.importeConLetra = item.importeConLetra;
                            objNominaControlCFDI.tipoMoneda = item.tipoMoneda;
                            objNominaControlCFDI.tipoCambio = item.tipoCambio;
                            objNominaControlCFDI.CLABE = "";
                            objNominaControlCFDI.banco = "";
                            objNominaControlCFDI.diasIncapacidad = item.diasIncapacidad;
                            objNominaControlCFDI.tipoIncapacidad = item.tipoIncapacidad;
                            objNominaControlCFDI.descuento = item.descuento;
                            objNominaControlCFDI.diasHrsDobles = item.diasHrsDobles;
                            objNominaControlCFDI.horasDoblesExtra = item.horasDoblesExtra;
                            objNominaControlCFDI.importeHrsDoblesPagado = decImporteHorasExtrasDobles;
                            objNominaControlCFDI.diasHrsTriples = item.diasHrsTriples;
                            objNominaControlCFDI.horasTriplesExtra = item.horasTriplesExtra;
                            objNominaControlCFDI.importeHrsTriplesPagado = decImporteHorasExtrasTriples;


                            xmlOut.WriteEndElement(); //Complemento
                            xmlOut.WriteEndDocument();
                            xmlOut.Close();


                            doc.Save(string.Format(@"{0}L{1}-{2}.xml", path, pIdLoteCargaNomina, pNoFolioSiguiente));
                            Usuario = item.Usuario;
                            Password = item.Password;

                            string cadenaOriginal_ = "";
                            if (bTipoCFDI != "4.0")
                            {
                                cadenaoriginal = GetCadenaOriginal(doc, string.Format(@"{0}cadenaoriginal_3_3.xslt", pathCadena));
                            }
                            else
                            {
                                //Creación Lucas 06/04/2023
                                //System.Xml.Xsl.XslCompiledTransform xslCTransform = new System.Xml.Xsl.XslCompiledTransform(false);
                                //xslCTransform.Load(string.Format(@"{0}cadenaoriginal_4.xslt", pathCadena));
                                //using (StringWriter sw = new StringWriter())
                                //{
                                //    using (XmlWriter xwo = XmlWriter.Create(sw, xslCTransform.OutputSettings))
                                //    {
                                //        XmlDocument xmlDocument = new XmlDocument();
                                //        xmlDocument.Load(string.Format(@"{0}L{1}-{2}.xml", path, pIdLoteCargaNomina, pNoFolioSiguiente));
                                //        xslCTransform.Transform(xmlDocument, xwo);
                                //        cadenaOriginal_ = sw.ToString();
                                //    }
                                //}

                                cadenaoriginal = GetCadenaOriginal(doc, string.Format(@"{0}cadenaoriginal_4.xslt", pathCadena));
                            }
                            Serie = item.NoCertificado;
                            Certificado = item.CertificadoCadena;
                            sello = Sello(cadenaoriginal.Replace("\r\n", string.Empty), item.ContrasenaKey, item.Key);

                            //Creación Lucas 06/04/2023
                            //sello = Sellar(cadenaOriginal_, item.Key, item.ContrasenaKey);

                        }//Fin Item Nomina
                    }
                    // Modify one of the name/value pairs.
                    if (bTipoCFDI != "4.0")
                    {
                        doc.Root.SetAttributeValue("Sello", sello);
                        doc.Root.SetAttributeValue("NoCertificado", Serie);
                        doc.Root.SetAttributeValue("Certificado", Certificado);
                    }
                    else
                    {
                        doc.Root.SetAttributeValue("Sello", sello);
                    }

                    doc.Save(string.Format(@"{0}L{1}-{2}.xml", path, pIdLoteCargaNomina, pNoFolioSiguiente));

                    //enviar la información del XML generado al servicio web del PAC
                    if (bTipoCFDI != "4.0")
                    {
                        ObtenerValoresXMLRespuestaSueldosLucas(string.Format(@"{0}L{1}-{2}.xml", path, pIdLoteCargaNomina, pNoFolioSiguiente), path, objNominaControlCFDI, Usuario, Password, cadenaoriginal);
                    }

                    else
                    {
                        ObtenerValoresXMLRespuestaSueldosLucasv4(string.Format(@"{0}L{1}-{2}.xml", path, pIdLoteCargaNomina, pNoFolioSiguiente), path, objNominaControlCFDI, Usuario, Password, cadenaoriginal, doc.ToString());
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                intContadorMenoresde0++;

            }
        }

        public string Sellar(string CadenaOriginal, byte[] ArchivoClavePrivada, string lPassword)

        {

            byte[] ClavePrivada = ArchivoClavePrivada; // File.ReadAllBytes(ArchivoClavePrivada);

            byte[] bytesFirmados = null;

            byte[] bCadenaOriginal = null;

            SecureString lSecStr = new SecureString();

            SHA256Managed sham = new SHA256Managed();

            // SHA1Managed sham = new SHA1Managed(); version 3.2

            lSecStr.Clear();

            foreach (char c in lPassword.ToCharArray())

                lSecStr.AppendChar(c);

            RSACryptoServiceProvider lrsa = JavaScience.opensslkey.DecodeEncryptedPrivateKeyInfo(ClavePrivada, lSecStr);

            bCadenaOriginal = Encoding.UTF8.GetBytes(CadenaOriginal);

            try

            {
                bytesFirmados = lrsa.SignData(Encoding.UTF8.GetBytes(CadenaOriginal), sham);
            }

            catch (NullReferenceException ex)
            {
                throw new NullReferenceException("Clave privada incorrecta, revisa que la clave que escribes corresponde a los sellos digitales cargados");
            }

            string sellodigital = Convert.ToBase64String(bytesFirmados);

            return sellodigital;
        }


        /// <summary>
        /// Método que obtienes la información del XML de respuesta
        /// del WS Enlace Fiscal
        /// </summary>
        /// <param name="strXMLResponse">Valor string del XML</param>
        /// <param name="sRutaArchivosRespuestaCFDI"></param>
        /// <param name="sRFCTenedora"></param>
        private void ObtenerValoresXMLRespuestaSueldosLucas(string strXMLResponse, string path, NominaControlCFDI objNominaControlCFDI, string username, string password, string cadenaoriginal)
        {
            try
            {
                string QR = "";
                String pURL = "";

                //Cargas tu archivo xml
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(strXMLResponse);

                string XML = File.ReadAllText(strXMLResponse);

                //Instancias del timbrado
                Facturacion33ServiceClient dd = new Facturacion33ServiceClient();
                objComprobante33 selloResponse = new objComprobante33();
                selloResponse = dd.GenerarComprobanteSellado("E0CE8BC6-63DD-4B03-8299-3EE6CA3A25DC", xmlDocument.OuterXml.ToString()); // Password
                dd.Close();

                //Facturacion40ServiceClient Timb4 = new Facturacion40ServiceClient();
                //objComprobante40 selloResponse = new objComprobante40();
                //selloResponse = Timb4.GenerarComprobante("E0CE8BC6-63DD-4B03-8299-3EE6CA3A25DC", xmlDocument.OuterXml.ToString()); // Password

                if (selloResponse.bGenerado)
                {
                    string sDireccion = string.Format(@"{0}\E{1}_{2}{3}_{4}_{5}.xml", sRutaArchivosRespuestaCFDI, objNominaControlCFDI.numEmpleado, objNominaControlCFDI.serieRecibo, objNominaControlCFDI.folioRecibo, objNominaControlCFDI.FolioLoteCargaNomina, sRFCTenedora);
                    //TODO: Instrucciones para crear Archivo XML CFDI
                    StreamWriter DocXML = new StreamWriter(sDireccion);

                    DocXML.Write(selloResponse.strComprobante);
                    DocXML.Close();

                    //Crear archivo XML desde un s
                    DataSet ds = new DataSet();//Se crea un dataset
                    ds.ReadXml(sDireccion);//Dirección del archivo xml


                    ////Conviertes el archivo en byte
                    byte[] byteXmlDocument = Encoding.UTF8.GetBytes(File.ReadAllText(sDireccion));
                    string stringByteXmlDocument = Convert.ToBase64String(byteXmlDocument);

                    //decodificar Contenido XML  Validar
                    byte[] data = Convert.FromBase64String(stringByteXmlDocument);
                    string decodedXmlCFDI = Encoding.UTF8.GetString(data);


                    NominaTimbradoCFDI objTimbrado = new NominaTimbradoCFDI();

                    objTimbrado.NumeroReferencia = ds.Tables["TimbreFiscalDigital"].Rows[0]["FechaTimbrado"].ToString();
                    objTimbrado.EstatusDocumento = "ACEPTADO";
                    objTimbrado.FechaMensaje = ds.Tables["Comprobante"].Rows[0]["Fecha"].ToString();
                    objTimbrado.FolioInterno = objNominaControlCFDI.folioRecibo;
                    //Buscar ASignacion
                    objTimbrado.FolioFiscalUUID = ds.Tables["TimbreFiscalDigital"].Rows[0]["UUID"].ToString(); ///L
                    objTimbrado.Serie = objNominaControlCFDI.serieRecibo;
                    objTimbrado.NoSerieCertificado = ds.Tables["Comprobante"].Rows[0]["noCertificado"].ToString();              ///L
                    objTimbrado.NoSerieCertificadoSAT = ds.Tables["TimbreFiscalDigital"].Rows[0]["noCertificadoSAT"].ToString();///L
                    objTimbrado.SelloCFDI = ds.Tables["TimbreFiscalDigital"].Rows[0]["selloCFD"].ToString();                    ///L
                    objTimbrado.SelloSAT = ds.Tables["TimbreFiscalDigital"].Rows[0]["selloSAT"].ToString();                     ///L 
                    objTimbrado.RfcProvCertif = ds.Tables["TimbreFiscalDigital"].Rows[0]["RfcProvCertif"].ToString();///L
                    objTimbrado.CadenaTFD = cadenaoriginal;
                    objTimbrado.FechaGeneracionCFDI = ds.Tables["TimbreFiscalDigital"].Rows[0]["FechaTimbrado"].ToString();     ///L
                    objTimbrado.FechaTFD = ds.Tables["Comprobante"].Rows[0]["Fecha"].ToString();
                    objTimbrado.EstadoCFDI = "OK";
                    objTimbrado.XmlCFDI = ""; // Revisar en BD DS selloSOAP.Url;

                    QR = "re=" + objNominaControlCFDI.rfcTenedora + "&rr=" + objNominaControlCFDI.rfc + "&tt=" + ds.Tables["Comprobante"].Rows[0]["subTotal"].ToString() + "&id=" + objTimbrado.FolioFiscalUUID;

                    byte[] dataQRCode = Encoding.UTF8.GetBytes(QR);
                    string decodedQRCode = Encoding.UTF8.GetString(dataQRCode);
                    long LongitudQRCode = objTimbrado.SelloSAT.Length;

                    objTimbrado.ArchivoQR = decodedQRCode;
                    objTimbrado.UrlDescargaArchivoQR = QR;
                    objTimbrado.UrlDescargaXmlCFDI = selloResponse.strComprobante;

                    //Metodo que almacenara la informacion que fue enviada a Timbrar
                    Int64 IdLoteCargaNominaCFDI = InsertarBitacoraXMLCFDI(objNominaControlCFDI, objTimbrado);
                    //Insertar Imagen y XML de respuesta
                    this.seguridadTableAdapter1.stpInsPDOHeaderDocumentoSACFDI(IdLoteCargaNominaCFDI, objNominaControlCFDI.IdLoteCargaNomina, dataQRCode, stringByteXmlDocument);

                    //TODO: Instrucciones para generar Archivo PDF                    
                    string strNombreArchivoPDF = string.Format(@"{0}\E{1}_{2}{3}_{4}_{5}.pdf", sRutaArchivosRespuestaCFDI, objNominaControlCFDI.numEmpleado, objNominaControlCFDI.serieRecibo, objNominaControlCFDI.folioRecibo, objNominaControlCFDI.FolioLoteCargaNomina, sRFCTenedora);

                    Estructuras.InformacionError objError;      //variable que recibe comportamiento del reporte
                    if (!objNominaControlCFDI.FolioLoteCargaNomina.Substring(2, 3).Equals("ASI"))
                        objError = ExportarCFDI2PDF.GenerarTimbradosPDFIndividualSueldos(strNombreArchivoPDF, objNominaControlCFDI);
                    else
                        objError = ExportarCFDI2PDF.GenerarTimbradosPDFIndividualAsimilados(strNombreArchivoPDF, objNominaControlCFDI);
                    intContadorAceptados++;

                    //agregando el idPDOHeader de los recobos timbrados para enviar los recibos por correo
                    lstIdPODHeaderParaEnvioDeRecibos.Add(objNominaControlCFDI.IdPDOHeader);
                    //agregando el idPDOHeader de los recobos timbrados para enviar los recibos por correo

                }
                else
                {
                    NominaTimbradoErrorCFDI objErrorTimbrado = new NominaTimbradoErrorCFDI();
                    objErrorTimbrado.NumeroReferencia = selloResponse.CodigoError.ToString();
                    objErrorTimbrado.EstatusDocumento = "RECHAZADO";//validar
                    objErrorTimbrado.FechaMensaje = objNominaControlCFDI.fechaEmision;
                    objErrorTimbrado.codigoError = selloResponse.CodigoError.ToString();
                    objErrorTimbrado.descripcionError = selloResponse.ExtraInfo;
                    //Metodo que almacenara la informacion que fue enviada a Timbrar
                    Int64 IdLoteCargaNominaCFDI = InsertarBitacoraErrorXMLCFDI(objNominaControlCFDI, objErrorTimbrado);
                    intContadorRechazados++;
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
        /// <param name="strXMLResponse">Valor string del XML</param>
        /// <param name="sRutaArchivosRespuestaCFDI"></param>
        /// <param name="sRFCTenedora"></param>
        private void ObtenerValoresXMLRespuestaSueldosLucasv4(string strXMLResponse, string path, NominaControlCFDI objNominaControlCFDI, string username, string password, string cadenaoriginal, string str)
        {
            try
            {
                string QR = "";
                String pURL = "";

                //Cargas tu archivo xml
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(strXMLResponse);
                string XML = File.ReadAllText(strXMLResponse);

                //Instancias del timbrado
                Facturacion40ServiceClient Timb4 = new Facturacion40ServiceClient();
                objComprobante40 selloResponse = new objComprobante40();
                selloResponse = Timb4.GenerarComprobanteSellado("E0CE8BC6-63DD-4B03-8299-3EE6CA3A25DC", XML.Replace("\r\n", string.Empty)); // Password
                //selloResponse = Timb4.GenerarComprobanteSellado("E0CE8BC6-63DD-4B03-8299-3EE6CA3A25DC", xmlDocument.OuterXml.ToString()); // Password
                //selloResponse = Timb4.GenerarComprobante("A5FDED41-8169-4CEF-B72B-88F0B11BDC04", XML.Replace("\r\n", string.Empty)); // Password Linea de Pruebas

                if (selloResponse.bGenerado)
                {
                    string sDireccion = string.Format(@"{0}\E{1}_{2}{3}_{4}_{5}.xml", sRutaArchivosRespuestaCFDI, objNominaControlCFDI.numEmpleado, objNominaControlCFDI.serieRecibo, objNominaControlCFDI.folioRecibo, objNominaControlCFDI.FolioLoteCargaNomina, sRFCTenedora);
                    //TODO: Instrucciones para crear Archivo XML CFDI
                    StreamWriter DocXML = new StreamWriter(sDireccion);

                    DocXML.Write(selloResponse.strComprobante);
                    DocXML.Close();

                    //Crear archivo XML desde un s
                    DataSet ds = new DataSet();//Se crea un dataset
                    ds.ReadXml(sDireccion);//Dirección del archivo xml


                    ////Conviertes el archivo en byte
                    byte[] byteXmlDocument = Encoding.UTF8.GetBytes(File.ReadAllText(sDireccion));
                    string stringByteXmlDocument = Convert.ToBase64String(byteXmlDocument);

                    //decodificar Contenido XML  Validar
                    byte[] data = Convert.FromBase64String(stringByteXmlDocument);
                    string decodedXmlCFDI = Encoding.UTF8.GetString(data);


                    NominaTimbradoCFDI objTimbrado = new NominaTimbradoCFDI();

                    objTimbrado.NumeroReferencia = ds.Tables["TimbreFiscalDigital"].Rows[0]["FechaTimbrado"].ToString();
                    objTimbrado.EstatusDocumento = "ACEPTADO";
                    objTimbrado.FechaMensaje = ds.Tables["Comprobante"].Rows[0]["Fecha"].ToString();
                    objTimbrado.FolioInterno = objNominaControlCFDI.folioRecibo;
                    //Buscar ASignacion
                    objTimbrado.FolioFiscalUUID = ds.Tables["TimbreFiscalDigital"].Rows[0]["UUID"].ToString(); ///L
                    objTimbrado.Serie = objNominaControlCFDI.serieRecibo;
                    objTimbrado.NoSerieCertificado = ds.Tables["Comprobante"].Rows[0]["noCertificado"].ToString();              ///L
                    objTimbrado.NoSerieCertificadoSAT = ds.Tables["TimbreFiscalDigital"].Rows[0]["noCertificadoSAT"].ToString();///L
                    objTimbrado.SelloCFDI = ds.Tables["TimbreFiscalDigital"].Rows[0]["selloCFD"].ToString();                    ///L
                    objTimbrado.SelloSAT = ds.Tables["TimbreFiscalDigital"].Rows[0]["selloSAT"].ToString();
                    objTimbrado.RfcProvCertif = ds.Tables["TimbreFiscalDigital"].Rows[0]["RfcProvCertif"].ToString();///L                   
                    objTimbrado.CadenaTFD = cadenaoriginal;
                    objTimbrado.FechaGeneracionCFDI = ds.Tables["TimbreFiscalDigital"].Rows[0]["FechaTimbrado"].ToString();     ///L
                    objTimbrado.FechaTFD = ds.Tables["Comprobante"].Rows[0]["Fecha"].ToString();
                    objTimbrado.EstadoCFDI = "OK";
                    objTimbrado.XmlCFDI = ""; // Revisar en BD DS selloSOAP.Url;

                    QR = "re=" + objNominaControlCFDI.rfcTenedora + "&rr=" + objNominaControlCFDI.rfc + "&tt=" + ds.Tables["Comprobante"].Rows[0]["subTotal"].ToString() + "&id=" + objTimbrado.FolioFiscalUUID;

                    byte[] dataQRCode = Encoding.UTF8.GetBytes(QR);
                    string decodedQRCode = Encoding.UTF8.GetString(dataQRCode);
                    long LongitudQRCode = objTimbrado.SelloSAT.Length;

                    objTimbrado.ArchivoQR = decodedQRCode;
                    objTimbrado.UrlDescargaArchivoQR = QR;
                    objTimbrado.UrlDescargaXmlCFDI = selloResponse.strComprobante;

                    //Metodo que almacenara la informacion que fue enviada a Timbrar
                    Int64 IdLoteCargaNominaCFDI = InsertarBitacoraXMLCFDI(objNominaControlCFDI, objTimbrado);
                    //Insertar Imagen y XML de respuesta
                    this.seguridadTableAdapter1.stpInsPDOHeaderDocumentoSACFDI(IdLoteCargaNominaCFDI, objNominaControlCFDI.IdLoteCargaNomina, dataQRCode, stringByteXmlDocument);

                    //TODO: Instrucciones para generar Archivo PDF                    
                    string strNombreArchivoPDF = string.Format(@"{0}\E{1}_{2}{3}_{4}_{5}.pdf", sRutaArchivosRespuestaCFDI, objNominaControlCFDI.numEmpleado, objNominaControlCFDI.serieRecibo, objNominaControlCFDI.folioRecibo, objNominaControlCFDI.FolioLoteCargaNomina, sRFCTenedora);

                    Estructuras.InformacionError objError;      //variable que recibe comportamiento del reporte
                    if (!objNominaControlCFDI.FolioLoteCargaNomina.Substring(2, 3).Equals("ASI"))
                        objError = ExportarCFDI2PDF.GenerarTimbradosPDFIndividualSueldosv4(strNombreArchivoPDF, objNominaControlCFDI);
                    else
                        objError = ExportarCFDI2PDF.GenerarTimbradosPDFIndividualAsimilados(strNombreArchivoPDF, objNominaControlCFDI);
                    intContadorAceptados++;

                    //agregando el idPDOHeader de los recobos timbrados para enviar los recibos por correo
                    lstIdPODHeaderParaEnvioDeRecibos.Add(objNominaControlCFDI.IdPDOHeader);
                    //agregando el idPDOHeader de los recobos timbrados para enviar los recibos por correo
                }
                else
                {
                    NominaTimbradoErrorCFDI objErrorTimbrado = new NominaTimbradoErrorCFDI();
                    objErrorTimbrado.NumeroReferencia = selloResponse.CodigoError.ToString();
                    objErrorTimbrado.EstatusDocumento = "RECHAZADO";//validar
                    objErrorTimbrado.FechaMensaje = objNominaControlCFDI.fechaEmision;
                    objErrorTimbrado.codigoError = selloResponse.CodigoError.ToString();
                    objErrorTimbrado.descripcionError = selloResponse.ExtraInfo;
                    //Metodo que almacenara la informacion que fue enviada a Timbrar
                    Int64 IdLoteCargaNominaCFDI = InsertarBitacoraErrorXMLCFDI(objNominaControlCFDI, objErrorTimbrado);
                    intContadorRechazados++;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// Método que genera los archivos XML que se generan del IdLoteCargaNomina
        /// y los Recibos de Nómina seleccionados ASIMILADOS
        /// </summary>
        /// <param name="pIdLoteCargaNomina">Lote Carga Nómina</param>
        /// <param name="pIdPDOHeader">IdPDOHeader = FolioRecibo</param>
        private void GenerarArchivoXML2PAC_Asimilados(Int64 pIdLoteCargaNomina, string pFolioLoteCargaNomina, Int64 pIdPDOHeader, long pNoFolioSiguiente, string pIdTipoMovimiento, string pRutaArchivosCFDI, DateTime pFechaPago)
        {
            const string sLeyendaRecibo = @"EL PAGO DE HONORARIOS EN FORMA DE ASIMILADO AL SALARIO COMO ANTECEDE, CORRESPONDIENTE AL SERVICIO PRESTADO Y POR LA CANTIDAD IMPRESA EN EL IMPORTE.";
            const string sNamespaceXSD = @"https://esquemas.enlacefiscal.com/EF/EFv1_0_nomina_asimilables.xsd";
            const string sNamespaceXSI = @"http://www.w3.org/2001/XMLSchema-instance";
            const string sNamespaceSchemaLocation = @"https://esquemas.enlacefiscal.com/EF/ https://esquemas.enlacefiscal.com/EF/EFv1_0_nomina_asimilables.xsd";
            //const string path = @"c:\BPOCFDI\";
            string path = pRutaArchivosCFDI + "\\";
            NominaControlCFDI objNominaControlCFDI = null;

            XmlWriterSettings settings = new XmlWriterSettings() { Indent = true, IndentChars = ("     ") };

            string sFolioReciboPDOHeader = pIdPDOHeader.ToString();
            try
            {
                //obtiene informacion de la version del Archivo AssemblyInfo.cs, seccion [assembly: AssemblyFileVersion("1.1.0.105")]
                Version ver = new Version(System.Windows.Forms.Application.ProductVersion);

                //filtrar el detalle de Nominas por IdPDOHeader = FolioRecibo
                var nominas = from row in objNominaList.Where(row => row.folioRecibo == sFolioReciboPDOHeader)
                              select row;

                //filtrar por Percepciones
                var detallePercepcion = from rowPercepcion in objDetalleNominaList
                                        where rowPercepcion.ClasifConcepto == "P"
                                        orderby rowPercepcion.IdPDOHeader
                                        select rowPercepcion;

                var contarRegistrosPercepcion = detallePercepcion.Count();      //obtener No. de registros

                //filtrar por Deducciones
                var detalleDeduccion = from rowDeduccion in objDetalleNominaList
                                       where rowDeduccion.ClasifConcepto == "D"
                                       orderby rowDeduccion.IdPDOHeader
                                       select rowDeduccion;

                var contarRegistrosDeduccion = detalleDeduccion.Count();        //obtener No. de registros

                //crear objeto XMLWriter
                pathXmlFiles = string.Format(@"{0}L{1}-{2}.xml", path, pIdLoteCargaNomina, pNoFolioSiguiente);
                XmlWriter xmlOut = XmlWriter.Create(string.Format(@"{0}L{1}-{2}.xml", path, pIdLoteCargaNomina, pNoFolioSiguiente), settings);
                //escribir en cabezado
                xmlOut.WriteStartDocument();
                xmlOut.WriteStartElement("Nomina", sNamespaceXSD);
                xmlOut.WriteAttributeString("xmlns", "xsi", null, sNamespaceXSI);
                xmlOut.WriteAttributeString("xsi", "schemaLocation", null, sNamespaceSchemaLocation);

                foreach (var item in nominas)
                {
                    xmlOut.WriteElementString("modo", item.modo);
                    xmlOut.WriteElementString("versionEFNomina", item.versionEFNomina);
                    xmlOut.WriteElementString("serieRecibo", item.serieRecibo);
                    xmlOut.WriteElementString("folioRecibo", pNoFolioSiguiente.ToString());
                    xmlOut.WriteElementString("fechaEmision", string.Format("{0:yyyy-MM-dd}T{1:HH:mm:ss}", item.fechaEmision, item.fechaEmision));
                    xmlOut.WriteElementString("nombreDisenio", "PRINCIPAL");

                    xmlOut.WriteStartElement("BloqueInformacion");
                    xmlOut.WriteElementString("titulo", "CONFORMIDAD");
                    xmlOut.WriteElementString("texto", item.leyendaRecibo);

                    xmlOut.WriteStartElement("TextoRenglones");
                    xmlOut.WriteElementString("renglon", string.Format("L{0}_PDOH{1}", pIdLoteCargaNomina, pIdPDOHeader));
                    xmlOut.WriteEndElement();       //TextoRenglones
                    xmlOut.WriteEndElement();       //BloqueInformacion

                    xmlOut.WriteStartElement("SoftwareIntegrador");
                    xmlOut.WriteElementString("nombre", "SAIC Windows");
                    xmlOut.WriteElementString("version", ver.ToString());
                    xmlOut.WriteEndElement();       //SoftwareIntegrador

                    xmlOut.WriteStartElement("Emisor");
                    //xmlOut.WriteElementString("registroPatronal", item.registroPatronal);
                    xmlOut.WriteElementString("rfc", item.rfcTenedora);
                    xmlOut.WriteFullEndElement();       //Patron

                    xmlOut.WriteStartElement("GrupoCorporativo");
                    xmlOut.WriteElementString("empresa", item.empresa);
                    xmlOut.WriteEndElement();       //GrupoCorporativo

                    xmlOut.WriteStartElement("Empleado");
                    xmlOut.WriteElementString("nombre", item.nombre);

                    if (item.apellidoPaterno.Length > 0)
                        xmlOut.WriteElementString("apellidoPaterno", item.apellidoPaterno);

                    if (item.apellidoMaterno.Length > 0)
                        xmlOut.WriteElementString("apellidoMaterno", item.apellidoMaterno);

                    xmlOut.WriteElementString("rfc", item.rfc);
                    xmlOut.WriteElementString("curp", item.curp);
                    //xmlOut.WriteElementString("numSeguridadSocial", item.numSeguridadSocial);
                    xmlOut.WriteEndElement();       //Empleado

                    xmlOut.WriteStartElement("Empleo");
                    xmlOut.WriteElementString("numEmpleado", item.numEmpleado);
                    //xmlOut.WriteElementString("departamento", item.departamento);
                    //xmlOut.WriteElementString("puesto", item.puesto);
                    //xmlOut.WriteElementString("riesgoPuesto", item.riesgoPuesto);
                    //xmlOut.WriteElementString("fechaInicioRelLaboral", string.Format("{0:yyyy-MM-dd}", item.fechaInicioRelLaboral));
                    //xmlOut.WriteElementString("antiguedad", item.antiguedad.ToString());
                    xmlOut.WriteElementString("tipoRegimen", item.tipoRegimen.ToString());
                    //xmlOut.WriteElementString("tipoContrato", item.tipoContrato);
                    //xmlOut.WriteElementString("tipoJornada", item.tipoJornada);
                    xmlOut.WriteElementString("periodicidadPago", item.periodicidadPago);
                    //xmlOut.WriteElementString("salarioBaseCotApor", item.salarioBaseCotApor.ToString("0.00"));
                    //xmlOut.WriteElementString("salarioDiarioIntegrado", item.salarioDiarioIntegrado.ToString("0.00"));
                    xmlOut.WriteEndElement();       //Empleo

                    xmlOut.WriteStartElement("Pago");
                    xmlOut.WriteElementString("fechaPago", string.Format("{0:yyyy-MM-dd}", item.fechaPago));
                    xmlOut.WriteElementString("fechaInicialPago", string.Format("{0:yyyy-MM-dd}", item.fechaInicialPago));
                    xmlOut.WriteElementString("fechaFinalPago", string.Format("{0:yyyy-MM-dd}", item.fechaFinalPago));
                    xmlOut.WriteElementString("numDiasPagados", item.numDiasPagados.ToString());
                    xmlOut.WriteElementString("montoPagado", item.montoPagado.ToString("0.00"));
                    xmlOut.WriteElementString("tipoMoneda", item.tipoMoneda);
                    if (!item.tipoMoneda.Equals("MXN"))
                        xmlOut.WriteElementString("tipoCambio", item.tipoCambio.ToString());

                    //if (item.CLABE.Length == 18) //si tiene cuenta CLABE de 18 dígitos, mostrar CLABE y BANCO
                    //{
                    //    xmlOut.WriteElementString("CLABE", item.CLABE);
                    //    xmlOut.WriteElementString("banco", item.banco);
                    //}

                    xmlOut.WriteEndElement();       //Pago

                    if (contarRegistrosPercepcion > 0)
                    {
                        xmlOut.WriteStartElement("Percepciones");
                        xmlOut.WriteElementString("TotalGravado", NominaBD.ImporteDetalleGravadoPercepcion.ToString("0.00"));
                        //xmlOut.WriteElementString("totalExento", NominaBD.ImporteDetalleExentoPercepcion.ToString("0.00"));

                        foreach (var itemPercepcion in detallePercepcion)
                        {
                            xmlOut.WriteStartElement("Percepcion");
                            xmlOut.WriteElementString("ClavePercepcion", itemPercepcion.tipoPercepcionDeduccion);
                            xmlOut.WriteElementString("ClaveContable", itemPercepcion.clave);
                            if (itemPercepcion.tipoPercepcionDeduccion.Equals("001"))     //Sueldo = 001
                                xmlOut.WriteElementString("concepto", "Asimilados");
                            else
                                xmlOut.WriteElementString("concepto", itemPercepcion.concepto);

                            xmlOut.WriteElementString("importeGravado", itemPercepcion.importeGravado.ToString("0.00"));
                            //xmlOut.WriteElementString("importeExento", itemPercepcion.importeExento.ToString("0.00"));
                            xmlOut.WriteEndElement();       //Percepcion
                        }

                        xmlOut.WriteEndElement();       //Percepciones
                    }

                    if (contarRegistrosDeduccion > 0)
                    {
                        xmlOut.WriteStartElement("Deducciones");
                        xmlOut.WriteElementString("TotalGravado", NominaBD.ImporteDetalleGravadoDeduccion.ToString());
                        //xmlOut.WriteElementString("totalExento", NominaBD.ImporteDetalleExentoDeduccion.ToString());

                        foreach (var itemDeduccion in detalleDeduccion)
                        {
                            xmlOut.WriteStartElement("Deduccion");
                            xmlOut.WriteElementString("ClaveDeduccion", itemDeduccion.tipoPercepcionDeduccion);
                            xmlOut.WriteElementString("ClaveContable", itemDeduccion.clave);
                            xmlOut.WriteElementString("Concepto", itemDeduccion.concepto);
                            xmlOut.WriteElementString("ImporteGravado", itemDeduccion.importeGravado.ToString("0.00"));
                            //xmlOut.WriteElementString("importeExento", itemDeduccion.importeExento.ToString("0.00"));
                            xmlOut.WriteEndElement();       //Deduccion
                        }
                        xmlOut.WriteEndElement();       //Deducciones
                    }
                    //asignar valores enviados a Timbrar
                    objNominaControlCFDI = new NominaControlCFDI();
                    objNominaControlCFDI.IdLoteCargaNomina = pIdLoteCargaNomina;
                    objNominaControlCFDI.IdPDOHeader = pIdPDOHeader;
                    objNominaControlCFDI.FolioLoteCargaNomina = pFolioLoteCargaNomina;
                    objNominaControlCFDI.modo = item.modo;
                    objNominaControlCFDI.versionEFNomina = item.versionEFNomina;
                    objNominaControlCFDI.serieRecibo = item.serieRecibo;
                    objNominaControlCFDI.folioRecibo = pNoFolioSiguiente.ToString();
                    objNominaControlCFDI.fechaEmision = string.Format("{0:yyyy-MM-dd}T{1:HH:mm:ss}", item.fechaEmision, item.fechaEmision);
                    objNominaControlCFDI.tituloInformativo = "CONFORMIDAD";
                    objNominaControlCFDI.textoInformativo = item.leyendaRecibo;
                    objNominaControlCFDI.renglon1Informativo = string.Format("L{0}_PDOH{1}", pIdLoteCargaNomina, pIdPDOHeader);
                    objNominaControlCFDI.SoftwareNombre = "SAIC Windows";
                    objNominaControlCFDI.SoftwareVersion = ver.ToString();
                    objNominaControlCFDI.registroPatronal = item.registroPatronal;
                    objNominaControlCFDI.rfcTenedora = item.rfcTenedora;
                    objNominaControlCFDI.empresa = item.empresa;
                    objNominaControlCFDI.nombre = item.nombre;
                    objNominaControlCFDI.apellidoPaterno = item.apellidoPaterno;
                    objNominaControlCFDI.apellidoMaterno = item.apellidoMaterno;
                    objNominaControlCFDI.rfc = item.rfc;
                    objNominaControlCFDI.curp = item.curp;
                    objNominaControlCFDI.numSeguridadSocial = item.numSeguridadSocial;
                    objNominaControlCFDI.numEmpleado = item.numEmpleado;
                    objNominaControlCFDI.departamento = item.departamento;
                    objNominaControlCFDI.puesto = item.puesto;
                    objNominaControlCFDI.riesgoPuesto = item.riesgoPuesto;
                    objNominaControlCFDI.fechaInicioRelLaboral = string.Format("{0:yyyy-MM-dd}", item.fechaInicioRelLaboral);
                    objNominaControlCFDI.antiguedad = item.antiguedad;
                    objNominaControlCFDI.tipoRegimen = item.tipoRegimen;
                    objNominaControlCFDI.tipoContrato = item.tipoContrato;
                    objNominaControlCFDI.tipoJornada = item.tipoJornada;
                    objNominaControlCFDI.periodicidadPago = item.periodicidadPago;
                    objNominaControlCFDI.salarioBaseCotApor = item.salarioBaseCotApor;
                    objNominaControlCFDI.salarioDiarioIntegrado = item.salarioDiarioIntegrado;
                    objNominaControlCFDI.fechaPago = string.Format("{0:yyyy-MM-dd}", item.fechaPago);
                    objNominaControlCFDI.fechaInicialPago = string.Format("{0:yyyy-MM-dd}", item.fechaInicialPago);
                    objNominaControlCFDI.fechaFinalPago = string.Format("{0:yyyy-MM-dd}", item.fechaFinalPago);
                    objNominaControlCFDI.numDiasPagados = item.numDiasPagados;
                    objNominaControlCFDI.montoPagado = item.montoPagado;
                    objNominaControlCFDI.importeConLetra = item.importeConLetra;
                    objNominaControlCFDI.tipoMoneda = item.tipoMoneda;
                    objNominaControlCFDI.tipoCambio = item.tipoCambio;
                    objNominaControlCFDI.CLABE = "";        //no se informacion bancaria al SAT
                    objNominaControlCFDI.banco = "";
                    objNominaControlCFDI.diasIncapacidad = item.diasIncapacidad;
                    objNominaControlCFDI.tipoIncapacidad = item.tipoIncapacidad;
                    objNominaControlCFDI.descuento = item.descuento;
                    objNominaControlCFDI.diasHrsDobles = item.diasHrsDobles;
                    objNominaControlCFDI.horasDoblesExtra = item.horasDoblesExtra;
                    objNominaControlCFDI.importeHrsDoblesPagado = 0;
                    objNominaControlCFDI.diasHrsTriples = item.diasHrsTriples;
                    objNominaControlCFDI.horasTriplesExtra = item.horasTriplesExtra;
                    objNominaControlCFDI.importeHrsTriplesPagado = 0;
                }

                xmlOut.WriteEndDocument();
                xmlOut.Close();

                //enviar la información del XML generado al servicio web del PAC
                //fijamos el tipo movimiento = D
                //EnviarXML2wsPAC("D", objNominaControlCFDI);


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// Método que genera los archivos XML que se generan del IdLoteCargaNomina
        /// y los Recibos de Nómina seleccionados APPJ
        /// </summary>
        /// <param name="pIdLoteCargaNomina">Lote Carga Nómina</param>
        /// <param name="pIdPDOHeader">IdPDOHeader = FolioRecibo</param>
        private void GenerarArchivoFacturaAPPJ(Int64 pIdLoteCargaNomina, string pFolioLoteCargaNomina, Int64 pIdPDOHeader, long pNoFolioSiguiente, string pIdTipoMovimiento, string pRutaArchivosCFDI, DateTime pFechaPago)
        {
            string pUsuarioCFDI = "";
            string pContrasenaCFDI = "";
            string pAPIKEY = "";
            pNoFolioSiguiente = 0;
            string dtHoraInicial = DateTime.Now.ToLongTimeString();
            int ptipoRela = 0;
            string sArchivo = "";
            Int64 pIDPDOHeaderCFDI = 0;


            string path = pRutaArchivosCFDI + "\\";
            decimal decImporteHorasExtrasDobles = 0.0M;
            decimal decImporteHorasExtrasTriples = 0.0M;
            NominaControlCFDI objNominaControlCFDI = null;

            if ((NominaBD.ImporteDetalleGravadoPercepcion + NominaBD.ImporteDetalleExentoPercepcion + NominaBD.ImporteDetalleGravadoOtro + NominaBD.ImporteDetalleExentoOtro + NominaBD.ImporteDetalleExentoJubil + NominaBD.ImporteDetalleGravadoJubil) > 0)
            {

                string sFolioReciboPDOHeader = pIdPDOHeader.ToString();
                try
                {

                    //obtiene informacion de la version del Archivo AssemblyInfo.cs, seccion [assembly: AssemblyFileVersion("1.1.0.105")]
                    Version ver = new Version(System.Windows.Forms.Application.ProductVersion);


                    //Obtener el Usuario y Contraseña de la Tenedora activa en el Lote
                    this.spSoloRespuestaCFDIEmpleado1.stpFactSelSeguridadCFDIFacturasAPIv2(IdTenedora, "Tenedora", ref pUsuarioCFDI, ref pContrasenaCFDI, ref pAPIKEY);

                    //filtrar el detalle de Nominas por IdPDOHeader = FolioRecibo
                    var nominas = from row in objNominaList.Where(row => row.folioRecibo == sFolioReciboPDOHeader)
                                  select row;

                    //filtrar por Percepciones
                    var detallePercepcion = from rowPercepcion in objDetalleNominaList
                                            where (rowPercepcion.ClasifConcepto == "P" && rowPercepcion.AplicaOtrosPagosSAT == 0 && (rowPercepcion.ClasifConcepto != "022" || rowPercepcion.ClasifConcepto != "023" || rowPercepcion.ClasifConcepto != "025"))
                                            orderby rowPercepcion.IdPDOHeader
                                            select rowPercepcion;

                    var contarRegistrosPercepcion = detallePercepcion.Count();      //obtener No. de registros


                    //obtener Factra = FolioRecibo
                    this.stpFactSelGenerarFacturaEmpleadosTableAdapter1.Fill(dbSAICBPONominaCFDIv12DataSet1.stpFactSelGenerarFacturaEmpleados, pIdPDOHeader, ver.ToString(), OperadorBD.OperadorGlobal.IdOperador, OperadorBD.OperadorGlobal.NombreUsuario);

                    if (dbSAICBPONominaCFDIv12DataSet1.stpFactSelGenerarFacturaEmpleados.Count > 0)
                    {
                        foreach (var item in nominas)
                        {

                            //asignar valores enviados a Timbrar
                            objNominaControlCFDI = new NominaControlCFDI();
                            objNominaControlCFDI.IdLoteCargaNomina = pIdLoteCargaNomina;
                            objNominaControlCFDI.IdPDOHeader = pIdPDOHeader;
                            objNominaControlCFDI.leyendaRecibo = item.leyendaRecibo;
                            objNominaControlCFDI.FolioLoteCargaNomina = pFolioLoteCargaNomina;
                            objNominaControlCFDI.modo = item.modo;
                            objNominaControlCFDI.versionEFNomina = item.versionEFNomina;
                            objNominaControlCFDI.serieRecibo = item.serieRecibo;
                            objNominaControlCFDI.folioRecibo = pNoFolioSiguiente.ToString();
                            objNominaControlCFDI.fechaEmision = string.Format("{0:yyyy-MM-dd}T{1:HH:mm:ss}", item.fechaEmision, item.fechaEmision);
                            objNominaControlCFDI.tituloInformativo = "CONFORMIDAD";
                            objNominaControlCFDI.textoInformativo = item.leyendaRecibo;
                            objNominaControlCFDI.renglon1Informativo = string.Format("L{0}_PDOH{1}", pIdLoteCargaNomina, pIdPDOHeader);
                            objNominaControlCFDI.SoftwareNombre = "SAIC Windows";
                            objNominaControlCFDI.SoftwareVersion = ver.ToString();
                            objNominaControlCFDI.versionCFDI = bTipoCFDI;
                            objNominaControlCFDI.registroPatronal = item.registroPatronal;
                            objNominaControlCFDI.rfcTenedora = item.rfcTenedora;
                            objNominaControlCFDI.empresa = item.empresa;
                            objNominaControlCFDI.nombre = item.nombre;
                            objNominaControlCFDI.apellidoPaterno = item.apellidoPaterno;
                            objNominaControlCFDI.apellidoMaterno = item.apellidoMaterno;
                            objNominaControlCFDI.rfc = item.rfc;
                            objNominaControlCFDI.curp = item.curp;
                            objNominaControlCFDI.numSeguridadSocial = item.numSeguridadSocial;
                            objNominaControlCFDI.numEmpleado = item.numEmpleado;
                            objNominaControlCFDI.departamento = item.departamento;
                            objNominaControlCFDI.puesto = item.puesto;
                            objNominaControlCFDI.riesgoPuesto = item.riesgoPuesto;
                            objNominaControlCFDI.fechaInicioRelLaboral = string.Format("{0:yyyy-MM-dd}", item.fechaInicioRelLaboral);
                            objNominaControlCFDI.antiguedad = item.antiguedad;
                            objNominaControlCFDI.tipoRegimen = item.tipoRegimen;
                            objNominaControlCFDI.tipoContrato = item.tipoContrato;
                            objNominaControlCFDI.tipoJornada = item.tipoJornada;
                            objNominaControlCFDI.periodicidadPago = item.periodicidadPago;
                            if (contarRegistrosPercepcion > 0)
                            {
                                objNominaControlCFDI.salarioBaseCotApor = item.salarioBaseCotApor;
                                objNominaControlCFDI.salarioDiarioIntegrado = item.salarioDiarioIntegrado;
                            }
                            else
                            {
                                objNominaControlCFDI.salarioBaseCotApor = 0;
                                objNominaControlCFDI.salarioDiarioIntegrado = 0;
                            }

                            objNominaControlCFDI.fechaPago = string.Format("{0:yyyy-MM-dd}", pFechaPago);
                            objNominaControlCFDI.fechaInicialPago = string.Format("{0:yyyy-MM-dd}", item.fechaInicialPago);
                            objNominaControlCFDI.fechaFinalPago = string.Format("{0:yyyy-MM-dd}", item.fechaFinalPago);
                            objNominaControlCFDI.numDiasPagados = item.numDiasPagados;
                            objNominaControlCFDI.numDiasFaltasJus = item.numDiasFaltasJus;
                            objNominaControlCFDI.numDiasFaltasInJus = item.numDiasFaltasInJus;
                            objNominaControlCFDI.montoPagado = item.montoPagado;
                            objNominaControlCFDI.importeConLetra = item.importeConLetra;
                            objNominaControlCFDI.tipoMoneda = item.tipoMoneda;
                            objNominaControlCFDI.tipoCambio = item.tipoCambio;
                            objNominaControlCFDI.CLABE = "";
                            objNominaControlCFDI.banco = "";
                            objNominaControlCFDI.diasIncapacidad = item.diasIncapacidad;
                            objNominaControlCFDI.tipoIncapacidad = item.tipoIncapacidad;
                            objNominaControlCFDI.descuento = item.descuento;
                            objNominaControlCFDI.diasHrsDobles = item.diasHrsDobles;
                            objNominaControlCFDI.horasDoblesExtra = item.horasDoblesExtra;
                            objNominaControlCFDI.importeHrsDoblesPagado = decImporteHorasExtrasDobles;
                            objNominaControlCFDI.diasHrsTriples = item.diasHrsTriples;
                            objNominaControlCFDI.horasTriplesExtra = item.horasTriplesExtra;
                            objNominaControlCFDI.importeHrsTriplesPagado = decImporteHorasExtrasTriples;



                            DataRow Row = dbSAICBPONominaCFDIv12DataSet1.stpFactSelGenerarFacturaEmpleados.Rows[0];
                            //Asignar Valores
                            sArchivo = Row[0].ToString();
                            pNoFolioSiguiente = Convert.ToInt64(Row[2].ToString() == string.Empty ? "0" : Row[2].ToString());
                            pIDPDOHeaderCFDI = Convert.ToInt64(Row[3].ToString() == string.Empty ? "0" : Row[3].ToString());
                            XmlWriterSettings settings = new XmlWriterSettings() { Indent = true, IndentChars = ("     ") };

                            pathXmlFiles = string.Format(@"{0}L{1}-{2}.json", path, pIdLoteCargaNomina, pNoFolioSiguiente);
                            pathXmlFilesRespuesta = string.Format(@"{0}Res{1}-{2}.json", sRutaArchivosCFDI + "\\", pIdLoteCargaNomina, pNoFolioSiguiente);
                            File.WriteAllText(pathXmlFiles, sArchivo, Encoding.UTF8);

                            EnviarXML2wsPACv12(pIdLoteCargaNomina, pIdPDOHeader, pIDPDOHeaderCFDI, pUsuarioCFDI, pContrasenaCFDI, pAPIKEY, pNoFolioSiguiente.ToString(), sArchivo, ptipoRela, pFechaPago.ToString());
                            this.Cursor = Cursors.Default;      //cambiar cursor del mouse

                        }//Fin Item Nomina
                    }

                    else
                    {
                        this.Cursor = Cursors.Default;      //cambiar cursor del mouse
                        if (splashSMProcesando.IsSplashFormVisible) { splashSMProcesando.CloseWaitForm(); }
                        XtraMessageBox.Show("¡Error al Generar Factura, Contacte a Sistemas!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                //NominaTimbradoErrorCFDI objErrorTimbrado = new NominaTimbradoErrorCFDI();
                //objErrorTimbrado.NumeroReferencia = "";
                //objErrorTimbrado.EstatusDocumento = "RECHAZADO";//validar
                //objErrorTimbrado.FechaMensaje = string.Format("{0:yyyy-MM-dd}T{1:HH:mm:ss}", DateTime.Now, DateTime.Now);
                //objErrorTimbrado.codigoError = "TotalPercepcion";
                //objErrorTimbrado.descripcionError = "El Total de Percepción no debe de ser menor de 0";
                ////Metodo que almacenara la informacion que fue enviada a Timbrar
                //Int64 IdLoteCargaNominaCFDI = InsertarBitacoraErrorXMLCFDI(objNominaControlCFDI, objErrorTimbrado);
                intContadorMenoresde0++;

            }
        }

        private void EnviarXML2wsPACv12(Int64 pIdLoteCargaNomina, Int64 pIDPDOHeader, Int64 pIDPDOHeaderCFDI, string pUsuarioCFDI, string pContrasenaCFDI, string pAPIKEY, string pNoFolioSiguiente, string sArchivo, int ptipoRelacion, string pFechaPago)
        {
            //string URL = "https://api.enlacefiscal.com/v6/probarConexion?";

            string URL = "https://api.enlacefiscal.com/v6/generarCfdi";

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
                ObtenerValoresXMLRespuesta(pIdLoteCargaNomina, pIDPDOHeader, pIDPDOHeaderCFDI, response, sRutaArchivosRespuestaCFDI, pNoFolioSiguiente, ptipoRelacion, pFechaPago);
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
        private void ObtenerValoresXMLRespuesta(Int64 pIdLoteCargaNomina, Int64 pIDPDOHeader, Int64 pIDPDOHeaderCFDI, string strXMLResponse, string sRutaArchivosRespuestaCFDI, string pNoFolioSiguiente, int ptipoRelacion, string pFechaPago)
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
                        string pxml = "";
                        //Metodo que almacenara la informacion que fue enviada a Timbrar
                        spSoloRespuestaCFDIEmpleado1.stpFactInsFacturaCFDIErroresEmpleados(pIdLoteCargaNomina, pIDPDOHeader, pIDPDOHeaderCFDI, strXMLResponse, "SAIC Windows", ver.ToString(), "Timbrar", pFechaPago, OperadorBD.OperadorGlobal.NombreUsuario, ref pidRespuesta, ref pxml);
                        intContadorRechazados++;
                    }
                    else if (strXMLResponse.Contains(@"""estatusDocumento"":""aceptado"""))
                    {

                        //Metodo que almacenara la informacion que fue enviada a Timbrar
                        string pXML = "", pQR = "", Serie = "";
                        spSoloRespuestaCFDIEmpleado1.stpFactUpdFacturaCFDIEmpleado(pIdLoteCargaNomina, pIDPDOHeader, pIDPDOHeaderCFDI, strXMLResponse, "SAIC Windows", ver.ToString(), OperadorBD.OperadorGlobal.NombreUsuario, pFechaPago, ref pQR, ref pXML, ref Serie);

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
                        spSoloRespuestaCFDIEmpleado1.stpFactInsDocumentoFacturaCFDIEmpleado(pIDPDOHeaderCFDI, dataQRCode, decodedXmlCFDI, ref pOk);

                        //TODO: Instrucciones para crear Archivo XML CFDI
                        //Crear archivo XML desde un string
                        XmlDocument xdoc = new XmlDocument();
                        xdoc.LoadXml(decodedXmlCFDI);
                        xdoc.Save(string.Format(@"{0}\F{1}_{2}_{3}.xml", sRutaArchivosRespuestaCFDI, pIdLoteCargaNomina, Serie, pNoFolioSiguiente));

                        //TODO: Instrucciones para generar Archivo PDF
                        string strNombreArchivoPDF = string.Format(@"{0}\F{1}_{2}_{3}.pdf", sRutaArchivosRespuestaCFDI, pIdLoteCargaNomina, Serie, pNoFolioSiguiente);

                        Estructuras.InformacionError objError;      //variable que recibe comportamiento del reporte
                        objError = ExportarCFDI2PDF.GenerarTimbradosPDFacturaEmpleado(strNombreArchivoPDF, pIDPDOHeader, ver.ToString());
                        intContadorAceptados++;
                    }
                }
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
        private void EnviarXML2wsPAC(string pIdTipoMovimiento, NominaControlCFDI objNominaControlCFDI)
        {
            //Prueba de envío XML SAIC
            string documentType = "";
            if (!pIdTipoMovimiento.Equals("D"))
                documentType = "Asalariado";
            else
                documentType = "Asimilable";

            string operationType = "generar" + documentType;
            string xmlRequestString = File.ReadAllText(pathXmlFiles);
            string response = apiEF.executeOperation(xmlRequestString, operationType);

            string strXMLResponse = apiEF.FormatXml(response);

            //Método que recibe el XML de respuesta del WSEnlaceFiscal
            ObtenerValoresXMLRespuestaSueldos(objNominaControlCFDI, strXMLResponse, sRutaArchivosRespuestaCFDI, sRFCTenedora);
        }

        /// <summary>
        /// Método que obtienes la información del XML de respuesta
        /// del WS Enlace Fiscal
        /// </summary>
        /// <param name="strXMLResponse">Valor string del XML</param>
        /// <param name="sRutaArchivosRespuestaCFDI"></param>
        /// <param name="sRFCTenedora"></param>
        private void ObtenerValoresXMLRespuestaSueldos(NominaControlCFDI objNominaControlCFDI, string strXMLResponse, string sRutaArchivosRespuestaCFDI, string sRFCTenedora)
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

                        intContadorRechazados++;    //incrementar contador rechazados

                        //Metodo que almacenara la informacion que fue enviada a Timbrar
                        Int64 IdLoteCargaNominaCFDI = InsertarBitacoraErrorXMLCFDI(objNominaControlCFDI, objErrorTimbrado);

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
                            Int64 IdLoteCargaNominaCFDI = InsertarBitacoraXMLCFDI(objNominaControlCFDI, objTimbrado);
                            //Insertar Imagen y XML de respuesta
                            this.seguridadTableAdapter1.stpInsPDOHeaderDocumentoSACFDI(IdLoteCargaNominaCFDI, objNominaControlCFDI.IdPDOHeader, dataQRCode, decodedXmlCFDI);

                            //TODO: Instrucciones para crear Archivo XML CFDI
                            //Crear archivo XML desde un string
                            XmlDocument xdoc = new XmlDocument();
                            xdoc.LoadXml(decodedXmlCFDI);
                            //xdoc.Save(string.Format(@"{0}\{1}_{2}{3}_{4}.xml", sRutaArchivosRespuestaCFDI, sRFCTenedora, itemAceptado.serie, itemAceptado.folioInterno, itemAceptado.folioFiscalUUID));
                            xdoc.Save(string.Format(@"{0}\E{1}_{2}{3}_{4}_{5}.xml", sRutaArchivosRespuestaCFDI, objNominaControlCFDI.numEmpleado, itemAceptado.serie, itemAceptado.folioInterno, objNominaControlCFDI.FolioLoteCargaNomina, sRFCTenedora));

                            //TODO: Instrucciones para generar Archivo PDF
                            //string strNombreArchivoPDF = string.Format(@"{0}\{1}_{2}{3}_{4}.pdf", sRutaArchivosRespuestaCFDI, sRFCTenedora, itemAceptado.serie, itemAceptado.folioInterno, itemAceptado.folioFiscalUUID);
                            string strNombreArchivoPDF = string.Format(@"{0}\E{1}_{2}{3}_{4}_{5}.pdf", sRutaArchivosRespuestaCFDI, objNominaControlCFDI.numEmpleado, itemAceptado.serie, itemAceptado.folioInterno, objNominaControlCFDI.FolioLoteCargaNomina, sRFCTenedora);

                            Estructuras.InformacionError objError;      //variable que recibe comportamiento del reporte
                            if (!objNominaControlCFDI.FolioLoteCargaNomina.Substring(2, 3).Equals("ASI"))
                                objError = ExportarCFDI2PDF.GenerarTimbradosPDFIndividualSueldos(strNombreArchivoPDF, objNominaControlCFDI);
                            else
                                objError = ExportarCFDI2PDF.GenerarTimbradosPDFIndividualAsimilados(strNombreArchivoPDF, objNominaControlCFDI);
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
        /// Método que despliega la Informacion Detallada
        /// del Lote Carga Nomina seleccionado
        /// </summary>
        private void MostrarInfoDetalleLoteCargaNomina(long pIdLoteCargaNomina)
        {
            //cargar informacion detalla LoteCargaNomina
            DataTable dt = this.stpSelInfoDetalleLoteCargaNominaTableAdapter1.GetData(pIdLoteCargaNomina);

            //crear objeto y pasar el DataTable para asignar los valores
            objInfoDetalle = InfoDetalleLoteCargaNominaBD.ObtenerInfoDetalleLoteCargaNominaCFDI(dt);

            //si existe el objeto entonces mostrar los valores
            if (objInfoDetalle != null)
            {
                txtNombreComercialTenedora.Text = objInfoDetalle.NombreComercialTenedora;
                txtNombreComercialCliente.Text = objInfoDetalle.NombreComercialCliente;
                txtNombreOperador.Text = objInfoDetalle.Operador;
                txtTipoNomina.Text = objInfoDetalle.TipoNomina;
                txtPeriodoPago.Text = objInfoDetalle.PeriodoPago;
                chkEstatusNominaContabilizada.Checked = objInfoDetalle.EstatusNominaContabilizada;
                //if (objInfoDetalle.AnoPago > 0)
                //    txtFechaPago.Text = string.Format("{0} {1}", objInfoDetalle.MesPago, objInfoDetalle.AnoPago);
                //else
                //    txtFechaPago.Text = "";     //inicializar textbox

                lblIdEstatusCFDI.Text = objInfoDetalle.IdEstatusCFDI.ToString();
                lblDescEstatusCFDI.Text = objInfoDetalle.DescEstatusCFDI;
                txtIdControl.Text = objInfoDetalle.IdControl.ToString();
            }
        }


        /// <summary>
        /// Limpiar Controles para desplegar Informacion Detalle Lote Carga Nomina
        /// </summary>
        private void InicializarInfoDetalleLoteCargaNomina()
        {
            txtNombreComercialTenedora.Text = "";
            txtNombreComercialCliente.Text = "";
            txtNombreOperador.Text = "";
            txtTipoNomina.Text = "";
            txtPeriodoPago.Text = "";
            chkEstatusNominaContabilizada.Checked = false;
            txtFechaPago.Text = "";
            lblIdEstatusCFDI.Text = "";
            lblDescEstatusCFDI.Text = "";
        }

        #endregion

        private void frmxAsignarNomina2XMLCFDI_Load(object sender, EventArgs e)
        {
            Int32 intError = 0;
            try
            {
                //Bloquear la busqueda de Lotes cuando se llama la ventana desde el boton de "Administrador"
                cboFolioLoteCargaNomina.Enabled = flagBloquearBusquedaLotes;

                //splashSMCargando.ShowWaitForm();
                //cargar todos los lotes
                this.stpSelFolioLoteCargaNominaSACFDITableAdapter.Fill(this.dbSAICBPONominaCFDIDataSet.stpSelFolioLoteCargaNominaSACFDI); // grabrizz, OperadorBD.OperadorGlobal.Confidencial

                // Set column widths according to their contents. 
                cboFolioLoteCargaNomina.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cboFolioLoteCargaNomina.Properties.PopupFormWidth = 900;

                dtFechaPago.EditValue = DateTime.Today;     //asignar fecha de pago
                //splashSMCargando.CloseWaitForm();

                APPJ = 0;

                if (filtraIdLoteCargaNomina == Constantes.FiltraPorIdLoteCargaNomina.Si)
                {
                    //asignar un lote en particular 
                    Int32 selectedRowCount = this.dbSAICBPONominaCFDIDataSet.stpSelFolioLoteCargaNominaSACFDI.Rows.Count;
                    if (selectedRowCount > 0)
                    {
                        for (int i = 0; i < selectedRowCount; i++)
                        {
                            if (this.dbSAICBPONominaCFDIDataSet.stpSelFolioLoteCargaNominaSACFDI.Rows[i][0].Equals(pIdLoteCargaNomina))
                            {
                                DataRow row = dbSAICBPONominaCFDIDataSet.stpSelFolioLoteCargaNominaSACFDI.Rows[i];
                                cboFolioLoteCargaNomina.EditValue = pIdLoteCargaNomina;
                                ObtenerEmpleadosLote(row);
                            }
                        }
                    }

                }

                this.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1.Fill(this.dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion, OperadorBD.OperadorGlobal.IdOperador, "Timbre", "TimbreEmpleado");
                if (this.dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion.Count > 0)
                {
                    DataRow row = this.dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion.Rows[0];
                    PTimbrar = (bool)row[15];
                }
                else
                {
                    PTimbrar = false;

                }
                ObtenerArchivosCadena();

                //grabrizz
                ////mostrar al operador el lote que desea timbrar
                //if (filtraIdLoteCargaNomina == Constantes.FiltraPorIdLoteCargaNomina.Si)
                //    //asignar un lote en particular
                //    //cboFolioLoteCargaNomina.EditValue = pIdLoteCargaNomina;
                //    lblIdLoteCargaNomina.Text = "Lote a Timbrar: " + pIdLoteCargaNomina.ToString();
                //else
                //    lblIdLoteCargaNomina.Text = "";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ObtenerArchivosCadena()
        {
            // Generar Archivo de Cadena Original
            string path = @"C:/SAT/";
            string CadenaOriginal = "";
            string Nombre = "";

            Directory.CreateDirectory(path);       //crear directorio
            this.stpSelObtenerDocCadenaOriginalTableAdapter1.Fill(dbSAIC_Seguridad1.stpSelObtenerDocCadenaOriginal, 2);

            for (int i = 0; i < dbSAIC_Seguridad1.stpSelObtenerDocCadenaOriginal.Count; i++)
            {
                CadenaOriginal = dbSAIC_Seguridad1.stpSelObtenerDocCadenaOriginal.Rows[i][1].ToString();
                Nombre = dbSAIC_Seguridad1.stpSelObtenerDocCadenaOriginal.Rows[i][3].ToString();
                Byte[] bytes = Convert.FromBase64String(CadenaOriginal);
                File.WriteAllBytes(string.Format(@"{0}{1}", path, Nombre), bytes);
            }

        }
        private void cboFolioLoteCargaNomina_EditValueChanged(object sender, EventArgs e)
        {
            DataRow row = gridLookUpEdit1View.GetDataRow(gridLookUpEdit1View.FocusedRowHandle);
            ObtenerEmpleadosLote(row);
        }

        private void ObtenerEmpleadosLote(DataRow row)
        {
            Int32 intError = 0;

            try
            {
                //obtener el renglon completo del Combobox
                // DataRow row = gridLookUpEdit1View.GetDataRow(gridLookUpEdit1View.FocusedRowHandle);
                //asignar valores extraidos del Combobox
                IdTenedora = Convert.ToInt32(row[2]);     //obtener IdTenedora
                sFolioLoteCargaNomina = row[1].ToString();
                pIdLoteCargaNomina = Convert.ToInt64(row[0]);
                sTipoNomina = row[1].ToString().Substring(2, 3);    //obtener Tipo Nomina (SEM, QUI, ASI, etc)
                sRFCTenedora = row[4].ToString();       //obtener RFCTenedora
                sFechaPagoAutomatica = string.Format("{0}/{1}/{2}", row[10].ToString().Substring(0, 2), row[10].ToString().Substring(3, 2), row[10].ToString().Substring(6, 4));
                APPJ = Convert.ToInt16(row[9]);

                //obtener la ruta RAIZ en dónde se almacenarán los archivos PDF y XML
                this.seguridadTableAdapter1.stpSelVersionTimbre(IdTenedora, pIdLoteCargaNomina, ref bTipoCFDI);

                txtFechaPago.Text = sFechaPagoAutomatica;
                dtFechaPago.EditValue = sFechaPagoAutomatica;   //asignar fecha de pago a la fecha final de la nómina

                //cargar informacion detallada LoteCargaNomina
                MostrarInfoDetalleLoteCargaNomina((long)cboFolioLoteCargaNomina.EditValue);

                //mostrar datos en base al IdLoteCargaNomina

                this.stpSelNominaCFDITableAdapter.Fill(this.dbSAICBPONominaCFDIDataSet.stpSelNominaCFDI, (long)cboFolioLoteCargaNomina.EditValue);

                //si existen registros
                if (this.dbSAICBPONominaCFDIDataSet.stpSelNominaCFDI.Count > 0)
                {
                    //Actualizar Estatus Timbrado CFDI = 2
                    intError = this.seguridadTableAdapter1.stpUpdEstatusTimbradoCFDI((long)cboFolioLoteCargaNomina.EditValue, 2, OperadorBD.OperadorGlobal.NombreUsuario);

                    //almacenar los Encabezados Nómina en objeto Lista
                    objNominaList = NominaBD.ObtenerEncabezadoNominas2XML(this.dbSAICBPONominaCFDIDataSet.stpSelNominaCFDI);

                    //Obtener Informacion del Estatus Nomina Vs Timbrados
                    MostrarResumenNominaSueldosVsTimbrados((long)cboFolioLoteCargaNomina.EditValue);

                    if (chkListNominas.ItemCount > 0)
                        chkListNominas.CheckAll();      //seleccionar todos los elementos
                }
                else
                {
                    //Actualizar Estatus Timbrado CFDI = 3
                    intError = this.seguridadTableAdapter1.stpUpdEstatusTimbradoCFDI((long)cboFolioLoteCargaNomina.EditValue, 3, OperadorBD.OperadorGlobal.NombreUsuario);
                    XtraMessageBox.Show("¡El Lote de Nómina NO tiene registros para timbrar!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //inicializar el no. de elementos seleccionados
                    //Grabrzz    
                    lblNoFoliosSeleccionados.Text = "0";

                    //InicializarInfoDetalleLoteCargaNomina();        //inicializar controles
                    //Actualizar Combobox Lote Carga Nomina
                    //this.stpSelFolioLoteCargaNominaSACFDITableAdapter.Fill(this.dbSAICBPONominaCFDIDataSet.stpSelFolioLoteCargaNominaSACFDI);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerarXML_Click(object sender, EventArgs e)
        {
            string pUsuarioCFDI = "";
            string pContrasenaCFDI = "";
            long? pNoFolioSiguiente = 0;
            string dtHoraInicial = DateTime.Now.ToLongTimeString();
            string dtHoraFinal = "";
            long? pIdLoteCargaNominaCFDI = 0;
            string pFechaPagoPlantilla = "";

            DateTime dtFechaDePago;

            lstIdPODHeaderParaEnvioDeRecibos = new List<long>();

            try
            {
                //obtiene informacion de la version del Archivo AssemblyInfo.cs, seccion [assembly: AssemblyFileVersion("1.1.0.105")]
                Version ver = new Version(System.Windows.Forms.Application.ProductVersion);

                //inicializar Contadores
                intContadorAceptados = 0;
                intContadorRechazados = 0;
                intContadorCancelados = 0;
                intContadorMenoresde0 = 0;

                //Obtener el Usuario y Contraseña de la Tenedora activa en el Lote
                this.seguridadTableAdapter1.stpSelSeguridadCFDI(IdTenedora, ref pUsuarioCFDI, ref pContrasenaCFDI);

                //Se especifican las credenciales de acceso creando una instancia a la clase APIEF
                apiEF = new APIEF(pUsuarioCFDI, pContrasenaCFDI);
                //obtener el No. de Items seleccionados
                Int32 intNoRecibosActivos = chkListNominas.CheckedItems.Count;

                //validar que exista al menos 1 movimiento activos para procesar
                if (intNoRecibosActivos > 0)
                {
                    //Obtener el No. Folio Siguiente
                    //this.seguridadTableAdapter1.stpUpdControlSerieFolioCFDI(IdTenedora, intNoRecibosActivos, ref pNoFolioSiguiente);

                    this.Cursor = Cursors.AppStarting;      //cambiar cursor del mouse

                    //Generar carpeta para colocar archivos XML
                    sRutaArchivosCFDI = compNominaCFDI.AccesoIO.ValidarCrearDirectorioCFDI(@"C:\BPOCFDI", sRFCTenedora, (long)cboFolioLoteCargaNomina.EditValue, compNominaCFDI.AccesoIO.ISO_Date());
                    sRutaArchivosRespuestaCFDI = compNominaCFDI.AccesoIO.ValidarCrearDirectorioRespuestaCFDI(sRutaArchivosCFDI + @"\XMLTimbrados\");

                    // Generar Archivo de Cadena Original
                    string path = sRutaArchivosCFDI + "\\";
                    //string CadenaOriginal = "";
                    //seguridadTableAdapter1.stpSelObtenerCadenaOriginal(ref CadenaOriginal);

                    //Byte[] bytes = Convert.FromBase64String(CadenaOriginal);
                    //File.WriteAllBytes(string.Format(@"{0}cadenaoriginal_3_3.xslt", path), bytes);

                    Int64 intPDOHeader = 0;

                    //Solicitar Fecha de Pago
                    dtFechaDePago = solicitarFechaDePago();

                    if (dtFechaDePago.ToShortDateString().ToString() != "01/01/1900")
                    {
                        dtFechaPago.EditValue = dtFechaDePago.ToShortDateString();
                        pFechaPagoPlantilla = sFechaPagoAutomatica.Substring(3, 7);

                        if (pFechaPagoPlantilla == string.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(dtFechaPago.EditValue)).Substring(3, 7) || pFechaPagoPlantilla == "01/1900")
                        {
                            splashSMProcesando.ShowWaitForm();        //mostrar pantalla de espera

                            for (int i = 0; i < chkListNominas.ItemCount; i++)
                            {
                                if (chkListNominas.GetItemCheckState(i) == CheckState.Checked)
                                {
                                    //obtener el FolioRecibo seleccionado
                                    intPDOHeader = Convert.ToInt64(chkListNominas.GetItemValue(i));

                                    //Obtener el No. Folio Siguiente
                                    this.seguridadTableAdapter1.stpUpdControlSerieFolioCFDIv2018(IdTenedora, sFolioLoteCargaNomina, (long)cboFolioLoteCargaNomina.EditValue, intPDOHeader, OperadorBD.OperadorGlobal.NombreUsuario, "SAIC Windows", ver.ToString(), ref pNoFolioSiguiente);

                                    //obtener datos en base al IdPDOHeader = FolioRecibo
                                    this.stpSelNominaDetalleCFDITableAdapter1.Fill(this.dbSAICBPONominaCFDIDataSet.stpSelNominaDetalleCFDI, intPDOHeader, Convert.ToInt64(cboFolioLoteCargaNomina.EditValue));
                                    //si existen registros
                                    if (this.dbSAICBPONominaCFDIDataSet.stpSelNominaDetalleCFDI.Count > 0)
                                    {
                                        if (sTipoNomina.Equals("ASI"))
                                        {
                                            //almacenar el detalle de la Nomina Percepciones/Deducciones
                                            objDetalleNominaList = NominaBD.ObtenerDetallePercepciones2XML(this.dbSAICBPONominaCFDIDataSet.stpSelNominaDetalleCFDI, "D");

                                            //generar archivo XML en base al Lote Nomina Carga y FolioRecibo ASIMILADOS
                                            GenerarArchivoXML2PAC_Asimilados((long)cboFolioLoteCargaNomina.EditValue, sFolioLoteCargaNomina, intPDOHeader, (long)pNoFolioSiguiente, "D", sRutaArchivosCFDI, Convert.ToDateTime(dtFechaPago.EditValue));
                                        }
                                        else
                                        {
                                            //almacenar el detalle de la Nomina Percepciones/Deducciones
                                            objDetalleNominaList = NominaBD.ObtenerDetallePercepciones2XML(this.dbSAICBPONominaCFDIDataSet.stpSelNominaDetalleCFDI, "D"); // cboFolioLoteCargaNomina.Text.Substring(0, 1));
                                                                                                                                                                          //generar archivo XML en base al Lote Nomina Carga y FolioRecibo SUELDOS
                                                                                                                                                                          //GenerarArchivoXML2PAC_Sueldos((long)cboFolioLoteCargaNomina.EditValue, sFolioLoteCargaNomina, intPDOHeader, (long)pNoFolioSiguiente, cboFolioLoteCargaNomina.Text.Substring(0, 1), sRutaArchivosCFDI, Convert.ToDateTime(dtFechaPago.EditValue));

                                            if (APPJ == 1 && cboFolioLoteCargaNomina.Text.Substring(0, 1) == "A")
                                                GenerarArchivoFacturaAPPJ((long)cboFolioLoteCargaNomina.EditValue, sFolioLoteCargaNomina, intPDOHeader, (long)pNoFolioSiguiente, cboFolioLoteCargaNomina.Text.Substring(0, 1), sRutaArchivosCFDI, Convert.ToDateTime(dtFechaPago.EditValue));

                                            else
                                                GenerarArchivoXML2PAC_Pensiones((long)cboFolioLoteCargaNomina.EditValue, sFolioLoteCargaNomina, intPDOHeader, (long)pNoFolioSiguiente, cboFolioLoteCargaNomina.Text.Substring(0, 1), sRutaArchivosCFDI, Convert.ToDateTime(dtFechaPago.EditValue));

                                        }

                                        pNoFolioSiguiente++;        //incrementar el Folio Siguiente
                                    }
                                    else
                                    {
                                        intContadorMenoresde0++;
                                        //XtraMessageBox.Show(string.Format("¡El Folio {0} no puede ser timbrado ya que no cuenta con Persepciones y Deducciones", Convert.ToString(intPDOHeader)), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    }
                                }

                            }  //for
                        }
                        else
                        {
                            if (PTimbrar && (XtraMessageBox.Show(String.Format("La fecha de pago es diferente a la fecha de calculo,\n¿Esta seguro de continuar?."), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes))
                            {

                                splashSMProcesando.ShowWaitForm();        //mostrar pantalla de espera

                                for (int i = 0; i < chkListNominas.ItemCount; i++)
                                {
                                    if (chkListNominas.GetItemCheckState(i) == CheckState.Checked)
                                    {
                                        //obtener el FolioRecibo seleccionado
                                        intPDOHeader = Convert.ToInt64(chkListNominas.GetItemValue(i));

                                        //Obtener el No. Folio Siguiente
                                        this.seguridadTableAdapter1.stpUpdControlSerieFolioCFDIv2018(IdTenedora, sFolioLoteCargaNomina, (long)cboFolioLoteCargaNomina.EditValue, intPDOHeader, OperadorBD.OperadorGlobal.NombreUsuario, "SAIC Windows", ver.ToString(), ref pNoFolioSiguiente);

                                        //obtener datos en base al IdPDOHeader = FolioRecibo
                                        this.stpSelNominaDetalleCFDITableAdapter1.Fill(this.dbSAICBPONominaCFDIDataSet.stpSelNominaDetalleCFDI, intPDOHeader, Convert.ToInt64(cboFolioLoteCargaNomina.EditValue));
                                        //si existen registros
                                        if (this.dbSAICBPONominaCFDIDataSet.stpSelNominaDetalleCFDI.Count > 0)
                                        {
                                            if (sTipoNomina.Equals("ASI"))
                                            {
                                                //almacenar el detalle de la Nomina Percepciones/Deducciones
                                                objDetalleNominaList = NominaBD.ObtenerDetallePercepciones2XML(this.dbSAICBPONominaCFDIDataSet.stpSelNominaDetalleCFDI, "D");

                                                //generar archivo XML en base al Lote Nomina Carga y FolioRecibo ASIMILADOS
                                                GenerarArchivoXML2PAC_Asimilados((long)cboFolioLoteCargaNomina.EditValue, sFolioLoteCargaNomina, intPDOHeader, (long)pNoFolioSiguiente, "D", sRutaArchivosCFDI, Convert.ToDateTime(dtFechaPago.EditValue));
                                            }
                                            else
                                            {
                                                //almacenar el detalle de la Nomina Percepciones/Deducciones
                                                objDetalleNominaList = NominaBD.ObtenerDetallePercepciones2XML(this.dbSAICBPONominaCFDIDataSet.stpSelNominaDetalleCFDI, "D"); // cboFolioLoteCargaNomina.Text.Substring(0, 1));
                                                                                                                                                                              //generar archivo XML en base al Lote Nomina Carga y FolioRecibo SUELDOS
                                                                                                                                                                              //GenerarArchivoXML2PAC_Sueldos((long)cboFolioLoteCargaNomina.EditValue, sFolioLoteCargaNomina, intPDOHeader, (long)pNoFolioSiguiente, cboFolioLoteCargaNomina.Text.Substring(0, 1), sRutaArchivosCFDI, Convert.ToDateTime(dtFechaPago.EditValue));

                                                if (APPJ == 1 && cboFolioLoteCargaNomina.Text.Substring(0, 1) == "A")
                                                    GenerarArchivoFacturaAPPJ((long)cboFolioLoteCargaNomina.EditValue, sFolioLoteCargaNomina, intPDOHeader, (long)pNoFolioSiguiente, cboFolioLoteCargaNomina.Text.Substring(0, 1), sRutaArchivosCFDI, Convert.ToDateTime(dtFechaPago.EditValue));

                                                else
                                                    GenerarArchivoXML2PAC_Pensiones((long)cboFolioLoteCargaNomina.EditValue, sFolioLoteCargaNomina, intPDOHeader, (long)pNoFolioSiguiente, cboFolioLoteCargaNomina.Text.Substring(0, 1), sRutaArchivosCFDI, Convert.ToDateTime(dtFechaPago.EditValue));

                                            }

                                            pNoFolioSiguiente++;        //incrementar el Folio Siguiente
                                        }
                                        else
                                        {
                                            intContadorMenoresde0++;
                                            //XtraMessageBox.Show(string.Format("¡El Folio {0} no puede ser timbrado ya que no cuenta con Persepciones y Deducciones", Convert.ToString(intPDOHeader)), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);                                        
                                        }
                                    }

                                }  //for
                            }
                            else
                                XtraMessageBox.Show("¡La Fecha de Pago asignada no corresponde, \n con el Mes Pago con que fue calculada la nómina!\nsi es el caso deberá consolidar un nuevo lote.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //Eliminar Archivo CadenaOriginal 
                        File.Delete(string.Format(@"{0}cadenaoriginal_3_3.xslt", path));
                        File.Delete(string.Format(@"{0}cadenaoriginal_4.xslt", path));

                        this.Cursor = Cursors.Default;      //cambiar cursor del mouse
                                                            //splashSMProcesando.CloseWaitForm();   //quitar pantalla de espera

                        pIdLoteCargaNominaCFDI = this.seguridadTableAdapter1.stpInsLoteCargaNominaCFDI((long)cboFolioLoteCargaNomina.EditValue, sFolioLoteCargaNomina, intNoRecibosActivos, intContadorAceptados,
                                                            intContadorRechazados, intContadorCancelados, Convert.ToDateTime(dtFechaPago.EditValue), sRutaArchivosRespuestaCFDI,
                                                            OperadorBD.OperadorGlobal.NombreUsuario, Dns.GetHostName(),
                                                            OperadorBD.OperadorGlobal.NombreUsuario, ref pIdLoteCargaNominaCFDI);

                        dtHoraFinal = DateTime.Now.ToLongTimeString();
                        if (splashSMProcesando.IsSplashFormVisible) { splashSMProcesando.CloseWaitForm(); }
                        XtraMessageBox.Show(string.Format("¡El timbrado de archivos XML CFDI se ha realizado!\n\nTotal Documentos procesados={0}\n\nDocumentos Aceptados= {1}\nDocumentos Rechazados={2}\nDocumentos Cancelados={3}\nDocumentos (Percepciones <=0) ={6}\n\nHora Inicio envío={4}\nHora Fin envío={5}", intNoRecibosActivos, intContadorAceptados, intContadorRechazados, intContadorCancelados, dtHoraInicial, dtHoraFinal, intContadorMenoresde0), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "RECIBOS DESDE TIMBRADO");
                        if (dbSAICBPOValidacionDataSet1.stpSelParametro.Rows.Count > 0)
                        {
                            flagEnvioDesdeTimbrado = dbSAICBPOValidacionDataSet1.stpSelParametro.Rows[0]["ValorParametro"].ToString() == "SI" ? true : false;
                        }
                        else
                        {
                            flagEnvioDesdeTimbrado = false;
                        }

                        if (flagEnvioDesdeTimbrado)
                        {
                            if (lstIdPODHeaderParaEnvioDeRecibos.Count > 0)
                            {
                                DialogResult oDialogResult = XtraMessageBox.Show("Recibos Timbrados." + Environment.NewLine +
                                     (lstIdPODHeaderParaEnvioDeRecibos.Count > 1 ? " ¿Desea enviar los recibos por correo?" : "¿Desea enviar el recibo por correo?")
                                     , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                if (oDialogResult == DialogResult.Yes)
                                {
                                    NominaCFDI.uc.ucEmisionCFDIsGenerico oucEmisionCFDIsGenerico = new uc.ucEmisionCFDIsGenerico();

                                    envioDeCorreos oenvioDeCorreos = new envioDeCorreos();
                                    oenvioDeCorreos = oucEmisionCFDIsGenerico.enviarRecibos((long)cboFolioLoteCargaNomina.EditValue, lstIdPODHeaderParaEnvioDeRecibos);

                                    XtraMessageBox.Show("Recibos Enviados:" + Environment.NewLine +
                                        "Enviados con Exito: " + oenvioDeCorreos.iCuantosEnviados + Environment.NewLine +
                                        "No Enviados: " + oenvioDeCorreos.iCuantosNOEnviados + Environment.NewLine +
                                        "Error: " + oenvioDeCorreos.sError, "SAIC L_" + cboFolioLoteCargaNomina.EditValue.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }

                        }
                        cboFolioLoteCargaNomina_EditValueChanged(sender, e);     //recargar gridview 
                    }
                    else
                    {
                        if (splashSMProcesando.IsSplashFormVisible) { splashSMProcesando.CloseWaitForm(); }
                        XtraMessageBox.Show("Lote sin Timbrar" + Environment.NewLine + Environment.NewLine + "No se selecciono una Fecha de Pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (splashSMProcesando.IsSplashFormVisible) { splashSMProcesando.CloseWaitForm(); }
                    XtraMessageBox.Show("¡No existen Movimientos activos para el timbrado XML CFDI!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                if (splashSMProcesando.IsSplashFormVisible) { splashSMProcesando.CloseWaitForm(); }
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboFolioLoteCargaNomina_EditValueChanged(sender, e);     //recargar gridview aunque haya falla
            }
            finally
            {
                if (splashSMProcesando.IsSplashFormVisible) { splashSMProcesando.CloseWaitForm(); }
                this.Cursor = Cursors.Default;      //cambiar cursor del mouse
            }

            if (splashSMProcesando.IsSplashFormVisible) { splashSMProcesando.CloseWaitForm(); }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();        //cerrar pantalla
        }

        private void btnSeleccionarTodos_Click(object sender, EventArgs e)
        {
            chkListNominas.CheckAll();    //seleccionar todos
        }

        private void btnDeseleccionarTodo_Click(object sender, EventArgs e)
        {
            chkListNominas.UnCheckAll();    //deseleccionar todos
        }

        private void chkListNominas_DrawItem(object sender, ListBoxDrawItemEventArgs e)
        {
            //e.Appearance.ForeColor = Color.Red;       //cambiar texto a Rojo
            if ((e.State & DrawItemState.Selected) == 0)
                e.Appearance.BackColor = Color.LightSteelBlue;
        }

        private void btnAcuseRecibosNominaSueldosAsimiladosXML_Click(object sender, EventArgs e)
        {
            try
            {
                //si existe lote de nómna valido
                if (!cboFolioLoteCargaNomina.EditValue.Equals(""))
                {
                    //crear reporte
                    ReportesCFDI.AcuseRecibosNominaSueldosAsimiladosXML report = new ReportesCFDI.AcuseRecibosNominaSueldosAsimiladosXML();

                    //asignar parametros del reporte
                    report.Parameters["pIdLoteCargaNomina"].Value = (long)cboFolioLoteCargaNomina.EditValue;
                    report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes

                    //mostrar reporte
                    report.ShowPreview();
                }
                else
                    XtraMessageBox.Show("¡Para generar el Acuse de Recibos XML CFDI\ndebe seleccionar un Lote de Nómina!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVisualizarErroresTimbrado_Click(object sender, EventArgs e)
        {
            //si existe lote de nómna valido
            if (!cboFolioLoteCargaNomina.EditValue.Equals(""))
            {
                //crear objeto y pasar el valor de la propiedad pIdLoteCargaNomina
                frmxErroresTimbradoCFDI objFrmErroresTimbrado = new frmxErroresTimbradoCFDI() { pIdLoteCargaNomina = (long)cboFolioLoteCargaNomina.EditValue, pIdTipoError = 1 };

                objFrmErroresTimbrado.ShowDialog();     //mostrar pantalla
            }
            else
                XtraMessageBox.Show("¡Para visualizar los errores de timbrado, debe seleccionar un Lote de Nómina!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            //chkListNominas.SelectedValue = e.ControllerRow.GetHashCode.colFolioRecibo;
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            chkListNominas.SelectedValue = gridView1.FocusedValue;
            chkListNominas.SelectedItem = gridView1.FocusedValue;
            chkListNominas.Focus();
        }

        /// <summary>
        /// Seleccion de fecha de pago para el Lote
        /// </summary>
        /// <returns></returns>
        private DateTime solicitarFechaDePago()
        {
            DateTime dtFechaSeleccionada;
            using (var form = new tools.xFormsSolicitarFecha("Fecha de Pago", "Confirmar Fecha de Pago", "Seleccione Fecha de Pago:"))
            {
                //Point temp = new Point();
                //Point location = new Point(temp.Y + this.Width / 2,
                //                           temp.X + this.Height / 2);
                //form.Location = location;
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    dtFechaSeleccionada = form.dtFechaSeleccionada;
                }
                else
                {
                    dtFechaSeleccionada = new DateTime(1900, 01, 01);
                }
            }
            return dtFechaSeleccionada;
        }

        private void pcFolioLoteCargaNomina_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkListNominas_ItemCheck_1(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            //Grabrizz
            //mostrar el no. de elementos seleccionados
            lblNoFoliosSeleccionados.Text = chkListNominas.CheckedItems.Count.ToString();
        }
    }
}
