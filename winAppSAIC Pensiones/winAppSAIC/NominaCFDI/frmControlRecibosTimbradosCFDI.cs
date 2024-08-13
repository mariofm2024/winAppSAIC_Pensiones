using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;        //namespace a partir version 12.2.4
using compLibreriaSAIC;
using winAppSAIC.UtileriasLocal;
using System.IO;

namespace winAppSAIC.NominaCFDI
{
    public partial class frmControlRecibosTimbradosCFDI : DevExpress.XtraEditors.XtraForm
    {
        public frmControlRecibosTimbradosCFDI()
        {
            InitializeComponent();
        }

        #region "Propiedades"

        /// <summary>
        /// Propiedad para indicar el tipo de Perfil de Acceso para el Usuario
        /// </summary>
        public Constantes.TipoPerfil tipoPerfil { get; set; }

        #endregion

        #region "Variables Globales"
        Estructuras.InformacionLoteCargaNomina objInfoLoteCargaNomina;
        InfoDetalleLoteCargaNomina objInfoDetalle;      //declarar objeto InfoDetalleLoteCargaNomina
        string strRutaArchivosXML = string.Empty;   //ruta en dónde se guardaran los archivos XML
        private string sRutaArchivosCFDI;
        private string sRutaArchivosRespuestaCFDI;
        #endregion

        #region "Metodos Propios"
        /// <summary>
        /// Método para Generar los Recibos de Nómina Timbrados en un PDF Global
        /// </summary>
        /// <param name="pIdLoteCargaNomina">IdLoteCargaNomina</param>
        /// <param name="pTipoNomina">Tipo de Nómina (SEM, QUI, ASI, etc)</param>
        /// <param name="pIdPDOHeader">IdPDOHeader detalle del empleado OPCIONAL</param>
        private void GenerarTimbradosPDFGlobal(long pIdLoteCargaNomina, string pTipoNomina, string pTipoTimbre, long pIdPDOHeader= -1)
        {
            try
            {
                if (!pTipoNomina.Equals("ASI"))     //No es ASIMILADO
                {
                    if (pTipoTimbre != "4.0")
                    {
                        //crear reporte
                        ReportesCFDI.RecibosEmpleadosSueldosCFDI report = new ReportesCFDI.RecibosEmpleadosSueldosCFDI();

                        //asignar parametros del reporte
                        report.Parameters["pIdLoteCargaNomina"].Value = pIdLoteCargaNomina;
                        report.Parameters["pIdPDOHeader"].Value = pIdPDOHeader;
                        report.Parameters["pTipoMovimientoNomina"].Value = pTipoNomina;

                        report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes

                        //mostrar reporte
                        report.ShowPreview();
                    }
                    else
                    {
                        //crear reporte
                        ReportesCFDI.RecibosEmpleadosSueldosCFDIv4 report = new ReportesCFDI.RecibosEmpleadosSueldosCFDIv4();

                        //asignar parametros del reporte
                        report.Parameters["pIdLoteCargaNomina"].Value = pIdLoteCargaNomina;
                        report.Parameters["pIdPDOHeader"].Value = pIdPDOHeader;
                        report.Parameters["pTipoMovimientoNomina"].Value = pTipoNomina;

                        report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes

                        //mostrar reporte
                        report.ShowPreview();
                    }
                }
                else   //Asimilados
                {
                    //crear reporte
                    ReportesCFDI.RecibosAsimiladosSalariosCFDI report = new ReportesCFDI.RecibosAsimiladosSalariosCFDI();

                    //asignar parametros del reporte
                    report.Parameters["pIdLoteCargaNomina"].Value = pIdLoteCargaNomina;
                    report.Parameters["pIdPDOHeader"].Value = pIdPDOHeader;

                    report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes

                    //mostrar reporte
                    report.ShowPreview();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método para Generar los Recibos de Nómina Timbrados en un PDF Global
        /// </summary>
        /// <param name="pIdLoteCargaNomina">IdLoteCargaNomina</param>
        /// <param name="pTipoNomina">Tipo de Nómina (SEM, QUI, ASI, etc)</param>
        /// <param name="pIdPDOHeader">IdPDOHeader detalle del empleado OPCIONAL</param>
        private void GenerarTimbradosPDFGlobalFactura(long pIdLoteCargaNomina, string pTipoNomina, long pIdPDOHeader = -1)
        {
            try
            {
                //crear reporte
                ReportesCFDI.ReciboFacturacionEmpleado report = new ReportesCFDI.ReciboFacturacionEmpleado();

                //asignar parametros del reporte
                report.Parameters["pIdLoteCargaNomina"].Value = pIdLoteCargaNomina;
                report.Parameters["pIdPDOHeader"].Value = pIdPDOHeader;

                report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes

                //mostrar reporte
                report.ShowPreview();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método para mostrar los recibos Timbrados CFDI
        /// en base al IdLoteCargaNomina seleccionado
        /// </summary>
        /// <param name="pIdLoteCargaNomina">Valor del IdLoteCargaNomina</param>
        private void MostrarRecibosTimbradosCFDI(long pIdLoteCargaNomina)
        {
            //crear reporte
            ReportesCFDI.ReporteNominaSueldosTimbradosCFDI report = new ReportesCFDI.ReporteNominaSueldosTimbradosCFDI();
            try
            {
                //asignar parametros del reporte
                report.Parameters["pIdLoteCargaNomina"].Value = pIdLoteCargaNomina;

                //asigna tamaño de papel
                report.PaperKind = System.Drawing.Printing.PaperKind.Letter;
                report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes
                report.Landscape = true;

                //mostrar reporte
                report.ShowPreview();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                txtIdControl.Text = objInfoDetalle.IdControl.ToString();
            }
        }


        /// <summary>
        /// Método para generar los Archivos XML CFDI de un Lote de Nómina
        /// </summary>
        /// <param name="objTable">Objeto DataTable</param>
        private void GenerarArchivosXMLCFDI(DataTable objTable)
        {
            //para cada registro generar su archivo XML
            foreach (DataRow row in objTable.Rows)
            {
              
                //decodificar Contenido XML
                //string decodedXmlCFDI = row["xmlCFDI"].ToString(); //Encoding.UTF8.GetString(data);
                Byte[] bytes = Convert.FromBase64String(row["xmlCFDI"].ToString());

                //Crear archivo XML desde un string
                //XmlDocument xdoc = new XmlDocument();
                //xdoc.LoadXml(decodedXmlCFDI);
                //xdoc.Save(String.Format(@"{0}\E{1}_{2}{3}_{4}_{5}.xml", sRutaArchivosRespuestaCFDI, Convert.ToInt64(row["IdEmpleado"]), row["Serie"].ToString(), row["FolioInterno"].ToString(), objInfoLoteCargaNomina.folioLoteCargaNomina, objInfoLoteCargaNomina.rfcTenedora));

                //Generar carpeta para colocar archivos XML
                File.WriteAllBytes(String.Format(@"{0}\E{1}_{2}{3}_{4}_{5}.xml", sRutaArchivosRespuestaCFDI, Convert.ToInt64(row["IdEmpleado"]), row["Serie"].ToString(), row["FolioInterno"].ToString(), objInfoLoteCargaNomina.folioLoteCargaNomina, objInfoLoteCargaNomina.rfcTenedora), bytes);
            }
        }

        #endregion

        private void frmControlRecibosTimbradosCFDI_Load(object sender, EventArgs e)
        {
            try
            {
                splashSMProcesando.ShowWaitForm();
                this.stpSelFolioLoteCargaNominaTimbradosCFDITableAdapter.Fill(this.dbSAICBPONominaCFDIDataSet.stpSelFolioLoteCargaNominaTimbradosCFDI);

                // Set column widths according to their contents. 
                cboFolioLoteCargaNomina.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cboFolioLoteCargaNomina.Properties.PopupFormWidth = 900;
                splashSMProcesando.CloseWaitForm();
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
                //llenar Gridview
                this.stpSelInfoDetalleLoteCargaNominaTimbradosCFDITableAdapter.Fill(this.dbSAICBPONominaCFDIDataSet.stpSelInfoDetalleLoteCargaNominaTimbradosCFDI, (long)cboFolioLoteCargaNomina.EditValue);

                DataRow row1 = this.dbSAICBPONominaCFDIDataSet.stpSelInfoDetalleLoteCargaNominaTimbradosCFDI.Rows[0];
                objInfoLoteCargaNomina.TipoVersion = row1[41].ToString();

                //cargar informacion detallada LoteCargaNomina
                MostrarInfoDetalleLoteCargaNomina((long)cboFolioLoteCargaNomina.EditValue);

                //obtener el renglon completo del Combobox
                DataRow row = gridLookUpEdit1View.GetDataRow(gridLookUpEdit1View.FocusedRowHandle);
                //asignar valores extraidos del Combobox a Objeto Struct
                objInfoLoteCargaNomina.idLoteCargaNomina = (long)cboFolioLoteCargaNomina.EditValue;
                objInfoLoteCargaNomina.folioLoteCargaNomina = row[1].ToString();
                objInfoLoteCargaNomina.tipoNomina = row[1].ToString().Substring(2, 3);    //obtener Tipo Nomina (SEM, QUI, ASI, etc)
                objInfoLoteCargaNomina.rfcTenedora = row[4].ToString();    //obtener RFC Tenedora
                objInfoLoteCargaNomina.rfcTenedora = row[4].ToString();    //obtener RFC Tenedora
                objInfoLoteCargaNomina.iAPPJ = Convert.ToInt16(row[17]);    //obtener RFC Tenedora
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();        //cerrar pantalla
        }

        private void btnGenerarPDFGlobal_Click(object sender, EventArgs e)
        {
            try
            {
                //si existe lote de nómna valido
                if (!cboFolioLoteCargaNomina.EditValue.Equals(""))
                {
                    //Generar recibos timbrados en PDF Global
                    //Parámetro pIdPDOHeader es OPCIONAL con valor default -1
                    if (objInfoLoteCargaNomina.iAPPJ == 1)
                        GenerarTimbradosPDFGlobalFactura(objInfoLoteCargaNomina.idLoteCargaNomina, objInfoLoteCargaNomina.tipoNomina);
                    else
                        GenerarTimbradosPDFGlobal(objInfoLoteCargaNomina.idLoteCargaNomina, objInfoLoteCargaNomina.tipoNomina, objInfoLoteCargaNomina.TipoVersion);
                }
                else
                    XtraMessageBox.Show("¡Para Generar Timbrados en PDF Global \ndebe seleccionar un Lote de Nómina!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnImprimirReporteTimbrados_Click(object sender, EventArgs e)
        {
            try
            {
                //si existe lote de nómna valido
                if (!cboFolioLoteCargaNomina.EditValue.Equals(""))
                    MostrarRecibosTimbradosCFDI((long)cboFolioLoteCargaNomina.EditValue);
                else
                    XtraMessageBox.Show("¡Para imprimir el Reporte debe seleccionar un Lote de Nómina!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAcuseRecibosXMLCFDI_Click(object sender, EventArgs e)
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

        private void btnGenerarArchivosXML_Click(object sender, EventArgs e)
        {
            try
            {
                //si existe lote de nómna valido
                if (!cboFolioLoteCargaNomina.EditValue.Equals(""))
                {
                    splashSMProcesando.ShowWaitForm();        //mostrar pantalla de espera
                    this.Cursor = Cursors.AppStarting;      //cambiar cursor del mouse

                    //en base al perfil obtener la Ruta RAIZ en dónde se colocarán los archivos XML
                    if (tipoPerfil == Constantes.TipoPerfil.Operacion)
                    {
                        //obtener la ruta RAIZ en dónde se almacenarán los archivos XML
                        strRutaArchivosXML = this.validacionesGeneralTableAdapter1.ObtenerValorParametro("FOLDER_XMLCFDI_OPERACIONES").ToString();
                    }
                    else if (tipoPerfil == Constantes.TipoPerfil.Contabilidad)
                    {
                        //obtener la ruta RAIZ en dónde se almacenarán los archivos XML
                        strRutaArchivosXML = this.validacionesGeneralTableAdapter1.ObtenerValorParametro("FOLDER_XMLCFDI_CONTABILIDAD").ToString();
                    }

                    //Generar carpeta para colocar archivos XML
                    sRutaArchivosCFDI = compNominaCFDI.AccesoIO.ValidarCrearDirectorioXMLCFDI(strRutaArchivosXML, objInfoLoteCargaNomina.rfcTenedora);
                    sRutaArchivosRespuestaCFDI = compNominaCFDI.AccesoIO.ValidarCrearDirectorioRespuestaCFDI(String.Format(@"{0}\L{1}", sRutaArchivosCFDI, objInfoLoteCargaNomina.idLoteCargaNomina));

                    //obtener información XML del Lote de Nómina
                    DataTable objTable = this.stpSelXMLCFDITimbradosPorLoteCargaNominaTableAdapter1.GetData(objInfoLoteCargaNomina.idLoteCargaNomina, "TODOS");

                    //Método para generar Archivos XML CFDI
                    GenerarArchivosXMLCFDI(objTable);

                    this.Cursor = Cursors.Default;      //cambiar cursor del mouse
                    splashSMProcesando.CloseWaitForm();   //quitar pantalla de espera

                    XtraMessageBox.Show("¡La generación de Archivos XML CFDI se ha realizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    XtraMessageBox.Show("¡Para generar los Archivos XML CFDI\ndebe seleccionar un Lote de Nómina!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}