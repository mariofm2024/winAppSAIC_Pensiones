using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using compCatalogosSAIC;
using compNominaCFDI;
using compLibreriaSAIC;
using winAppSAIC.UtileriasLocal;
using compEmail;
using DevExpress.XtraReports.UI;        //namespace a partir version 12.2.4

namespace winAppSAIC.NominaCFDI.uc
{
    public partial class ucEmisionCFDIsGenerico : UserControl
    {
        int iDelay_EnvioRecibos = 0;

        tools.dsc dsc = new tools.dsc();
        //propiedad que indicará el tipo de Emision CFDIs
        //Empleado = 1, Cliente = 2, Pagadora = 3
        public byte TipoEmisionCFDIs
        { get; set; }

        int iComienzo = -1;
        int iFin = 0;

        #region "Variables Globales"
        //variable para obtener configuracion Cuenta de Correo Notificaciones
        private ConfiguracionNotificacion objConfigCorreo;

        private Int32 IdTenedora;
        private string sIdLoteCargaNomina;
        private string sRFCTenedora;
        private string sRazonSocialTenedora;
        private string sNombreComercialTenedora;
        private string sRutaArchivosCFDI;
        private string strRutaArchivosXML;
        private EmpleadoGenerico objEmpleadoGenerico;
        private DataTable dtInfoEmpleado;
        InfoDetalleLoteCargaNomina objInfoDetalle;      //declarar objeto InfoDetalleLoteCargaNomina

        #endregion

        #region "Metodos Propios"

        /// <summary>
        /// Método para habilitar o deshabilitar controles de filtrado
        /// </summary>
        /// <param name="bFlag">TRUE o FALSE</param>
        private void HabilitarFiltro(bool bFlag)
        {
            btnFiltrarRecibos.Enabled = bFlag;
            txtAnoPago.Enabled = bFlag;
        }

        /// <summary>
        /// Método que selecciona los registros de empleados
        /// que tienen correo electronico en el objeto CheckList
        /// </summary>
        private void SeleccionarRegistrosCorreoElectronico()
        {
            GridView grid = gridView1 as GridView;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                int currentRowHandle = gridView1.GetVisibleRowHandle(i);
                //Int64 intIdPDOHeader = Convert.ToInt64(grid.GetRowCellDisplayText(currentRowHandle, grid.Columns["IdPDOHeader"]));
                string strCorreo = grid.GetRowCellDisplayText(currentRowHandle, grid.Columns["CorreoElectronico"]);
                if (strCorreo.Length > 0)
                    chkListNominas.SetItemChecked(i, true);
            }   //for
        }


        /// <summary>
        /// Método que despliega la Informacion Detallada
        /// del Lote Carga Nomina seleccionado
        /// <param name="pIdLoteCargaNomina">IdLoteCargaNomina</param>
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
            }
            else
            {
                txtNombreComercialTenedora.Text = String.Empty;
                txtNombreComercialCliente.Text = String.Empty;
                txtNombreOperador.Text = String.Empty;
                txtTipoNomina.Text = String.Empty;
                txtPeriodoPago.Text = String.Empty;
                chkEstatusNominaContabilizada.Checked = false;
                txtFechaPago.Text = String.Empty;     //inicializar textbox
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


        #endregion

        public ucEmisionCFDIsGenerico()
        {
            InitializeComponent();
        }

        private void ucEmisionCFDIsGenerico_Load(object sender, EventArgs e)
        {
            try
            {
                HabilitarFiltro(false);     //deshabilitar filtro
                txtAnoPago.EditValue = DateTime.Now.Year;   //asignar año por default

                if (TipoEmisionCFDIs.Equals(1)) //empleado
                {
                    xtpCFDIsEmpleado.PageVisible = true;
                    xtpCFDIsCliente.PageVisible = false;
                    xtpReciboLote.PageVisible = false;
                    xtpEnvioCorreoElectronicoLoteNomina.PageVisible = false;
                    txtNoEmpleado.Focus();      //colocar cursor en control
                    gridView1.Columns["CorreoElectronico"].Visible = false; //ocultar columna
                    //ajustar propiedades del boton Seleccionar Todos
                    AjustarBotonSeleccionarTodos(424, 5, 106, 23, "Seleccionar Todo");
                }
                else if (TipoEmisionCFDIs.Equals(2))        //cliente
                {
                    xtpCFDIsEmpleado.PageVisible = false;
                    xtpCFDIsCliente.PageVisible = true;
                    xtpReciboLote.PageVisible = false;
                    xtpEnvioCorreoElectronicoLoteNomina.PageVisible = false;
                    gridView1.Columns["CorreoElectronico"].Visible = false; //ocultar columna
                    //ajustar propiedades del boton Seleccionar Todos
                    AjustarBotonSeleccionarTodos(424, 5, 106, 23, "Seleccionar Todo");

                    //cargar tenedoras
                    this.stpSelObtenerInfoGenericaTenedoraTableAdapter.Fill(this.dbSAIC_Catalogos.stpSelObtenerInfoGenericaTenedora);
                }
                else if (TipoEmisionCFDIs.Equals(3))        //pagadora
                {
                    xtpCFDIsEmpleado.PageVisible = false;
                    xtpCFDIsCliente.PageVisible = false;
                    xtpReciboLote.PageVisible = true;
                    xtpEnvioCorreoElectronicoLoteNomina.PageVisible = false;
                    gridView1.Columns["CorreoElectronico"].Visible = false; //ocultar columna
                    //ajustar propiedades del boton Seleccionar Todos
                    AjustarBotonSeleccionarTodos(424, 5, 106, 23, "Seleccionar Todo");
                }
                else if (TipoEmisionCFDIs.Equals(4))        //Correo Electrónico por Lote Nomina
                {
                    //ocultar sección Filtro
                    lblAnoPago.Visible = false;
                    txtAnoPago.Visible = false;
                    btnFiltrarRecibos.Visible = false;

                    //ocultar o mostrar pestañas
                    xtpCFDIsEmpleado.PageVisible = false;
                    xtpCFDIsCliente.PageVisible = false;
                    xtpReciboLote.PageVisible = false;
                    xtpEnvioCorreoElectronicoLoteNomina.PageVisible = true;

                    gridView1.Columns["CorreoElectronico"].Visible = true;  //mostrar columna
                    //ajustar propiedades del boton Seleccionar Todos
                    AjustarBotonSeleccionarTodos(309, 5, 221, 23, "Seleccionar Recibos con Correo Electrónico");
                    txtNoLoteCargaNomina.Focus();       //colocar cursor

                    try
                    {
                        splashScreenManager1.ShowWaitForm();
                        this.stpSelFolioLoteCargaNominaTimbradosGenericoCFDITableAdapter.Fill(this.dbSAICBPONominaCFDIDataSet.stpSelFolioLoteCargaNominaTimbradosGenericoCFDI);

                        //obtener informacion Cuenta de Correo
                        //DataTable dt = this.stpSelCorreosNotificacionTableAdapter1.GetData();
                        //objConfigCorreo = ConfiguracionNotificacionBD.ObtenerConfiguracionNotificacionCorreos(dt);
                        objConfigCorreo = obtenerDatosCorreoElectronico();

                        // Set column widths according to their contents. 
                        cboFolioLoteCargaNomina.Properties.View.BestFitColumns();
                        // Specify the total dropdown width. 
                        cboFolioLoteCargaNomina.Properties.PopupFormWidth = 900;

                        if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método para ajustar la posición, tamaño y texto del botón Seleccionar Todos
        /// </summary>
        /// <param name="x">Posicion X</param>
        /// <param name="y">Posicion Y</param>
        /// <param name="w">Ancho W</param>
        /// <param name="h">Alto H</param>
        /// <param name="texto">Texto que desplegará en el botón</param>
        private void AjustarBotonSeleccionarTodos(int x, int y, int w, int h, string texto)
        {
            Point xy = new Point(x, y);
            btnSeleccionarTodos.Location = xy;
            Size wh = new Size(w, h);
            btnSeleccionarTodos.Size = wh;
            btnSeleccionarTodos.Text = texto;
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                //si escribieron un valor
                if (txtNoEmpleado.Text.Trim().Length > 0)
                {
                    if (Validator.IsPositiveNumber(txtNoEmpleado))
                    {
                        DataTable dt = this.stpSelObtenerInfoGenericaEmpleadoTableAdapter1.GetData(Convert.ToInt32(txtNoEmpleado.Text));

                        objEmpleadoGenerico = EmpleadoBD.ObtenerInfoGenericaEmpleadoCFDI(dt);

                        if (objEmpleadoGenerico != null)
                        {
                            txtNombreEmpleado.Text = objEmpleadoGenerico.NombreEmpleadoCompleto;
                            txtRFC.Text = objEmpleadoGenerico.RFC;
                            txtCURP.Text = objEmpleadoGenerico.CURP;
                            txtNSS.Text = objEmpleadoGenerico.NSS;
                            txtEsquema.Text = objEmpleadoGenerico.IdTipoMovimiento;
                            txtTenedoraSA.Text = objEmpleadoGenerico.TenedoraSA;
                            txtEstatus.Text = objEmpleadoGenerico.DescEstatus;
                            txtCorreoElectronico.Text = objEmpleadoGenerico.CorreoElectronico;
                            HabilitarFiltro(true);  //habilitar filtro
                            txtAnoPago.Focus();     //colocar cursor en control
                        }
                        else
                        {
                            HabilitarFiltro(false);     //deshabilitar filtro
                            XtraMessageBox.Show(string.Format("No existe información del No. de Empleado {0}", txtNoEmpleado.Text), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                    XtraMessageBox.Show("Debe escribir el No. de Empleado para obtener la Información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnFiltrarRecibos_Click(object sender, EventArgs e)
        {
            Int32 intIdTenedora = 0;
            Int32 intIdCliente = 0;
            Int32 intIdEmpleado = 0;
            Int64 intIdLoteCargaNomina = 0;
            Int16 intAnoPago = 0;

            try
            {
                if (TipoEmisionCFDIs.Equals(1))     //Filtrar por No. Empleado
                {
                    intIdEmpleado = Convert.ToInt32(txtNoEmpleado.Text);
                    intIdTenedora = 0;
                    intIdCliente = 0;
                    intIdLoteCargaNomina = 0;
                }
                else if (TipoEmisionCFDIs.Equals(2))        //Filtrar por Tenedora-Cliente
                {
                    intIdEmpleado = 0;
                    intIdTenedora = Convert.ToInt32(cboIdTenedoraSA.EditValue);
                    intIdCliente = Convert.ToInt32(cboIdCliente.EditValue);
                    intIdLoteCargaNomina = 0;
                }
                else if (TipoEmisionCFDIs.Equals(3))    //Filtrar por Tenedora
                {
                    intIdEmpleado = 0;
                    intIdTenedora = Convert.ToInt32(cboIdTenedoraSA.EditValue);
                    intIdCliente = 0;
                    intIdLoteCargaNomina = 0;
                }
                //else if (TipoEmisionCFDIs.Equals(4))    //Filtrar por Lote
                //{
                //    intIdEmpleado = 0;
                //    intIdTenedora = 0;
                //    intIdCliente = 0;
                //    intIdLoteCargaNomina = (long)cboFolioLoteCargaNomina.EditValue;
                //}

                //asignar el año de pago
                intAnoPago = Convert.ToInt16(txtAnoPago.Text);
                //inicializar contador de registros seleccionados
                lblNoFoliosSeleccionados.Text = "0";

                splashScreenManager1.ShowWaitForm();      //mostrar mensaje procesando
                this.Cursor = Cursors.AppStarting;      //cambiar cursor del mouse

                //dtInfoEmpleado = null;      //inicializar;
                this.stpSelRecibosEmpleadosSueldosAsimiladosGenericoCFDITableAdapter.Fill(this.dbSAICBPONominaCFDIDataSet.stpSelRecibosEmpleadosSueldosAsimiladosGenericoCFDI, intIdTenedora, intIdCliente, intIdEmpleado, intIdLoteCargaNomina, intAnoPago, TipoEmisionCFDIs, OperadorBD.OperadorGlobal.IdOperador);

                this.Cursor = Cursors.Default;      //cambiar cursor del mouse
                splashScreenManager1.CloseWaitForm();   //quitar pantalla de espera

                if (this.dbSAICBPONominaCFDIDataSet.stpSelRecibosEmpleadosSueldosAsimiladosGenericoCFDI.Count > 0)
                    //asignar los registros a un DataTable que LINQ filtrara para la selecciona de registros
                    dtInfoEmpleado = this.dbSAICBPONominaCFDIDataSet.stpSelRecibosEmpleadosSueldosAsimiladosGenericoCFDI;
                else
                    XtraMessageBox.Show("¡No existen registros para este filtro!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;      //cambiar cursor del mouse
                splashScreenManager1.CloseWaitForm();   //quitar pantalla de espera
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSeleccionarTodos_Click(object sender, EventArgs e)
        {
            switch (TipoEmisionCFDIs)
            {
                case 1:
                case 2:
                case 3:
                    chkListNominas.CheckAll();    //seleccionar todos
                    break;
                case 4:
                    SeleccionarRegistrosCorreoElectronico();
                    break;
            }   //switch            
        }


        private void btnDeseleccionarTodo_Click(object sender, EventArgs e)
        {
            chkListNominas.UnCheckAll();    //deseleccionar todos
        }

        private void chklstRecibosEmitidos_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            //mostrar el no. de elementos seleccionados
            lblNoFoliosSeleccionados.Text = chkListNominas.CheckedItems.Count.ToString();
        }

        private void btnGenerarRecibosCFDI_Click(object sender, EventArgs e)
        {
            //obtener el No. de Items seleccionados
            Int32 intNoRecibosActivos = chkListNominas.CheckedItems.Count;

            //validar que exista al menos 1 movimiento activos para procesar
            if (intNoRecibosActivos > 0)
            {
                splashScreenManager1.ShowWaitForm();        //mostrar pantalla de espera
                this.Cursor = Cursors.AppStarting;      //cambiar cursor del mouse

                //evaluar qué opcion selecciono el usuario
                //y generar las carpetas destino para los archivos PDF y XML
                switch (TipoEmisionCFDIs)
                {
                    case 1:     //Empleado
                        //obtener la ruta RAIZ en dónde se almacenarán los archivos PDF y XML
                        strRutaArchivosXML = this.validacionesGeneralTableAdapter1.ObtenerValorParametro("FOLDER_XML_EMPLEADO").ToString();

                        //Generar carpeta para colocar archivos XML
                        sRutaArchivosCFDI = compNominaCFDI.AccesoIO.ValidarCrearDirectorioCFDI(strRutaArchivosXML, objEmpleadoGenerico, compNominaCFDI.AccesoIO.ISO_Date());
                        break;

                    case 2:     //Tenedora-Cliente
                        //obtener la ruta RAIZ en dónde se almacenarán los archivos PDF y XML
                        strRutaArchivosXML = this.validacionesGeneralTableAdapter1.ObtenerValorParametro("FOLDER_XML_CLIENTE").ToString();

                        //Generar carpeta para colocar archivos XML
                        sRutaArchivosCFDI = compNominaCFDI.AccesoIO.ValidarCrearDirectorioCFDI(strRutaArchivosXML, sRFCTenedora, compNominaCFDI.AccesoIO.ISO_Date());
                        break;
                    case 3:     //Tenedora-Cliente
                        //obtener la ruta RAIZ en dónde se almacenarán los archivos PDF y XML
                        strRutaArchivosXML = this.validacionesGeneralTableAdapter1.ObtenerValorParametro("FOLDER_XML_LOTE").ToString();

                        //Generar carpeta para colocar archivos XML
                        sRutaArchivosCFDI = compNominaCFDI.AccesoIO.ValidarCrearDirectorioCFDI(strRutaArchivosXML, sIdLoteCargaNomina, compNominaCFDI.AccesoIO.ISO_Date());
                        break;
                }   //switch

                for (int i = 0; i < chkListNominas.ItemCount; i++)
                {
                    if (chkListNominas.GetItemCheckState(i) == CheckState.Checked)
                    {
                        //obtener el FolioRecibo seleccionado
                        Int64 intPDOHeader = Convert.ToInt64(chkListNominas.GetItemValue(i));

                        dtInfoEmpleado = this.dbSAICBPONominaCFDIDataSet.stpSelRecibosEmpleadosSueldosAsimiladosGenericoCFDI;

                        //obtener informacion del recibo seleccionado
                        Nomina objInfoNomina = LayoutEmisionCFDIGenericoBD.ObtenerInfoReciboCFDI(dtInfoEmpleado, intPDOHeader);

                        Int64 intLote = objInfoNomina.IdLoteCargaNomina;
                        Estructuras.InformacionError objError;      //variable que recibe comportamiento de la exportacion
                        string strNombreArchivoPDF = "";
                        string strNombreArchivoXML = "";

                        switch (TipoEmisionCFDIs)
                        {
                            case 1:     //Empleado
                                //RFC Tenedora + Empleado + Serie + Folio Recibo CFDI
                                strNombreArchivoPDF = String.Format(@"{0}\{1}_E{2}_{3}{4}.pdf", sRutaArchivosCFDI, objInfoNomina.rfcTenedora, objInfoNomina.numEmpleado, objInfoNomina.serieRecibo, objInfoNomina.folioRecibo);
                                strNombreArchivoXML = String.Format(@"{0}\{1}_E{2}_{3}{4}.xml", sRutaArchivosCFDI, objInfoNomina.rfcTenedora, objInfoNomina.numEmpleado, objInfoNomina.serieRecibo, objInfoNomina.folioRecibo);

                                if (!objEmpleadoGenerico.IdTipoMovimiento.Equals("D"))
                                {
                                    if (objInfoNomina.iAPPJ == 1)
                                    {
                                        objError = ExportarCFDI2PDF.GenerarTimbradosPDFIndividualSueldosFactura(strNombreArchivoPDF, intPDOHeader, intLote);
                                        objError = ExportarCFDI2XML.GenerarTimbradosXMLIndividual(strNombreArchivoXML, objInfoNomina.xmlCFDI.ToString());
                                    }
                                    else
                                    {
                                        if (objInfoNomina.VersionCFDI != "4.0")
                                            objError = ExportarCFDI2PDF.GenerarTimbradosPDFIndividualSueldos(strNombreArchivoPDF, intPDOHeader, intLote);
                                        else
                                            objError = ExportarCFDI2PDF.GenerarTimbradosPDFIndividualSueldosv4(strNombreArchivoPDF, intPDOHeader, intLote);

                                        objError = ExportarCFDI2XML.GenerarTimbradosXMLIndividual(strNombreArchivoXML, objInfoNomina.xmlCFDI.ToString());
                                    }
                                }
                                else
                                {
                                    objError = ExportarCFDI2PDF.GenerarTimbradosPDFIndividualAsimilados(strNombreArchivoPDF, intPDOHeader);
                                    objError = ExportarCFDI2XML.GenerarTimbradosXMLIndividual(strNombreArchivoXML, objInfoNomina.xmlCFDI.ToString());
                                }

                                break;

                            case 2:     //Tenedora-Cliente

                                strNombreArchivoPDF = String.Format(@"{0}\E{1}_{2}{3}.pdf", sRutaArchivosCFDI, objInfoNomina.numEmpleado, objInfoNomina.serieRecibo, objInfoNomina.folioRecibo);
                                strNombreArchivoXML = String.Format(@"{0}\E{1}_{2}{3}.xml", sRutaArchivosCFDI, objInfoNomina.numEmpleado, objInfoNomina.serieRecibo, objInfoNomina.folioRecibo);

                                if (!objInfoNomina.folioLoteCargaNomina.Substring(2, 3).Equals("ASI"))
                                {
                                    if (objInfoNomina.iAPPJ == 1)
                                    {
                                        objError = ExportarCFDI2PDF.GenerarTimbradosPDFIndividualSueldosFactura(strNombreArchivoPDF, intPDOHeader, intLote);
                                        objError = ExportarCFDI2XML.GenerarTimbradosXMLIndividual(strNombreArchivoXML, objInfoNomina.xmlCFDI.ToString());
                                    }
                                    else
                                    {
                                        if (objInfoNomina.VersionCFDI != "4.0")
                                            objError = ExportarCFDI2PDF.GenerarTimbradosPDFIndividualSueldos(strNombreArchivoPDF, intPDOHeader, intLote);
                                        else
                                            objError = ExportarCFDI2PDF.GenerarTimbradosPDFIndividualSueldosv4(strNombreArchivoPDF, intPDOHeader, intLote);
                                        objError = ExportarCFDI2XML.GenerarTimbradosXMLIndividual(strNombreArchivoXML, objInfoNomina.xmlCFDI.ToString());
                                    }
                                }
                                else
                                {
                                    objError = ExportarCFDI2PDF.GenerarTimbradosPDFIndividualAsimilados(strNombreArchivoPDF, intPDOHeader);
                                    objError = ExportarCFDI2XML.GenerarTimbradosXMLIndividual(strNombreArchivoXML, objInfoNomina.xmlCFDI.ToString());
                                }

                                break;
                            case 3:     //LOTE

                                strNombreArchivoPDF = String.Format(@"{0}\E{1}_{2}{3}_{4}_{5}.pdf", sRutaArchivosCFDI, objInfoNomina.numEmpleado, objInfoNomina.serieRecibo, objInfoNomina.folioRecibo, objInfoNomina.folioLoteCargaNomina, objInfoNomina.rfcTenedora);
                                strNombreArchivoXML = String.Format(@"{0}\E{1}_{2}{3}_{4}_{5}.xml", sRutaArchivosCFDI, objInfoNomina.numEmpleado, objInfoNomina.serieRecibo, objInfoNomina.folioRecibo, objInfoNomina.folioLoteCargaNomina, objInfoNomina.rfcTenedora);

                                if (!objInfoNomina.folioLoteCargaNomina.Substring(2, 3).Equals("ASI"))
                                {
                                    if (objInfoNomina.iAPPJ == 1)
                                    {
                                        objError = ExportarCFDI2PDF.GenerarTimbradosPDFIndividualSueldosFactura(strNombreArchivoPDF, intPDOHeader, intLote);
                                        objError = ExportarCFDI2XML.GenerarTimbradosXMLIndividual(strNombreArchivoXML, objInfoNomina.xmlCFDI.ToString());
                                    }
                                    else
                                    {
                                        if (objInfoNomina.VersionCFDI != "4.0")
                                            objError = ExportarCFDI2PDF.GenerarTimbradosPDFIndividualSueldos(strNombreArchivoPDF, intPDOHeader, intLote);
                                        else
                                            objError = ExportarCFDI2PDF.GenerarTimbradosPDFIndividualSueldosv4(strNombreArchivoPDF, intPDOHeader, intLote);

                                        objError = ExportarCFDI2XML.GenerarTimbradosXMLIndividual(strNombreArchivoXML, objInfoNomina.xmlCFDI.ToString());
                                    }
                                }
                                else
                                {
                                    objError = ExportarCFDI2PDF.GenerarTimbradosPDFIndividualAsimilados(strNombreArchivoPDF, intPDOHeader);
                                    objError = ExportarCFDI2XML.GenerarTimbradosXMLIndividual(strNombreArchivoXML, objInfoNomina.xmlCFDI.ToString());
                                }

                                break;
                        }
                    }
                }  //for

                this.Cursor = Cursors.Default;      //cambiar cursor del mouse
                splashScreenManager1.CloseWaitForm();   //quitar pantalla de espera
                XtraMessageBox.Show("¡La generación de archivos del timbrado CFDI fue exitosa!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                XtraMessageBox.Show("¡No existen Movimientos seleccionados para generar archivos del timbrado CFDI!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtNoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnBuscarEmpleado_Click(sender, e);     //si existe ENTER entonces ejecutar metodo-evento click
        }

        private void txtAnoPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnFiltrarRecibos_Click(sender, e);     //si existe ENTER entonces ejecutar metodo-evento click
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (TipoEmisionCFDIs.Equals(4))
            {
                GridView View = sender as GridView;
                if (e.RowHandle >= 0)
                {
                    string strCorreo = View.GetRowCellDisplayText(e.RowHandle, View.Columns["CorreoElectronico"]);
                    if (strCorreo.Length == 0)
                    {
                        e.Appearance.BackColor = Color.Salmon;
                        e.Appearance.BackColor2 = Color.SeaShell;
                        //chkListNominas.SetItemChecked(e.RowHandle, true);
                    }

                    string stFechaDeEnvio = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Fecha de Envio Recibo"]);
                    DateTime dtFechaDeEnvio = new DateTime();
                    DateTime.TryParse(stFechaDeEnvio, out dtFechaDeEnvio);
                    if (dtFechaDeEnvio.Date > new DateTime(1900, 01, 01).Date)
                    {
                        e.Appearance.BackColor = Color.PaleGreen;
                        e.Appearance.BackColor2 = Color.White;
                    }
                }
            }
        }

        private void cboFolioLoteCargaNomina_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //cargar informacion detallada LoteCargaNomina
                MostrarInfoDetalleLoteCargaNomina((long)cboFolioLoteCargaNomina.EditValue);
                //inicializar contador de registros seleccionados
                lblNoFoliosSeleccionados.Text = "0";

                this.stpSelRecibosEmpleadosSueldosAsimiladosGenericoCFDITableAdapter.Fill(this.dbSAICBPONominaCFDIDataSet.stpSelRecibosEmpleadosSueldosAsimiladosGenericoCFDI, -1, -1, -1, (long)cboFolioLoteCargaNomina.EditValue, 0, 4, OperadorBD.OperadorGlobal.IdOperador);

                if (this.dbSAICBPONominaCFDIDataSet.stpSelRecibosEmpleadosSueldosAsimiladosGenericoCFDI.Count > 0)
                    //asignar los registros a un DataTable que LINQ filtrara para la selecciona de registros
                    dtInfoEmpleado = this.dbSAICBPONominaCFDIDataSet.stpSelRecibosEmpleadosSueldosAsimiladosGenericoCFDI;
                else
                    XtraMessageBox.Show("¡No existen registros para este filtro!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboIdTenedoraSA_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraEditors.LookUpEdit editor = (sender as DevExpress.XtraEditors.LookUpEdit);
                DataRowView row = editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue) as DataRowView;
                //asignar valores extraidos del Combobox
                IdTenedora = Convert.ToInt32(row["IdTenedora"]);     //obtener IdTenedora
                sRazonSocialTenedora = row["RazonSocial"].ToString();
                sNombreComercialTenedora = row["NombreComercial"].ToString();
                sRFCTenedora = row["RFC"].ToString();       //obtener RFCTenedora

                //cargar Clientes que pertenecen a la Tenedora
                this.stpSelObtenerInfoGenericaClientexTenedoraTableAdapter.Fill(this.dbSAIC_Catalogos.stpSelObtenerInfoGenericaClientexTenedora, Convert.ToInt32(cboIdTenedoraSA.EditValue));
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboIdCliente_EditValueChanged(object sender, EventArgs e)
        {
            //si fue seleccionado un cliente
            if (Convert.ToInt32(cboIdCliente.EditValue) > 0)
                HabilitarFiltro(true);      //habilitar filtro
            else
                HabilitarFiltro(false);     //deshabilitar filtro
        }

        private void cboIdCliente_Leave(object sender, EventArgs e)
        {
            txtAnoPago.Focus();     //colocar cursor en control
        }

        private void btnEnviarRecibosCorreo_Click(object sender, EventArgs e)
        {
            //obtener el No. de Items seleccionados
            Int32 intNoRecibosActivos = chkListNominas.CheckedItems.Count;

            //SI se tiene configuracion de Cuenta de Correo
            if (objConfigCorreo != null)
            {
                //validar que exista al menos 1 movimiento activos para procesar
                if (intNoRecibosActivos > 0)
                {
                    splashScreenManager1.ShowWaitForm();        //mostrar pantalla de espera
                    splashScreenManager1.SetWaitFormCaption("Enviando Recibos");
                    this.Cursor = Cursors.AppStarting;      //cambiar cursor del mouse
                    int iContador = 0;

                    for (int i = 0; i < chkListNominas.ItemCount; i++)
                    {
                        if (chkListNominas.GetItemCheckState(i) == CheckState.Checked)
                        {
                            iContador++;
                            splashScreenManager1.SetWaitFormDescription(iContador + " de " + chkListNominas.CheckedItems.Count);
                            //obtener el FolioRecibo seleccionado
                            Int64 intPDOHeader = Convert.ToInt64(chkListNominas.GetItemValue(i));

                            //obtener informacion del recibo seleccionado
                            Nomina objInfoNomina = LayoutEmisionCFDIGenericoBD.ObtenerInfoReciboCFDI(dtInfoEmpleado, intPDOHeader);
                            Estructuras.InformacionError objError;      //variable que recibe comportamiento de la exportacion
                            string strNombreArchivoPDF = "";
                            string strNombreArchivoXML = "";

                            //RFC Tenedora + Empleado + Serie + Folio Recibo CFDI
                            strNombreArchivoPDF = String.Format(@"{0}_E{1}_{2}{3}.pdf", objInfoNomina.rfcTenedora, objInfoNomina.numEmpleado, objInfoNomina.serieRecibo, objInfoNomina.folioRecibo);
                            strNombreArchivoXML = String.Format(@"{0}_E{1}_{2}{3}.xml", objInfoNomina.rfcTenedora, objInfoNomina.numEmpleado, objInfoNomina.serieRecibo, objInfoNomina.folioRecibo);

                            string sTipoNomina = objInfoNomina.folioLoteCargaNomina.Substring(2, 3);
                            string sPeriodoInicialNomina = objInfoNomina.folioLoteCargaNomina.Substring(6, 8);
                            string sPeriodoFinalNomina = objInfoNomina.folioLoteCargaNomina.Substring(15, 8); ;

                            MemoryStream memObjPDF = new MemoryStream();
                            MemoryStream memObjXML = new MemoryStream();
                            StringBuilder strBody = new StringBuilder();

                            //integrar Body del Correo Electrónico
                            strBody.Append("Buen día.\n\n");
                            strBody.Append("Servicio de entrega de CFDI de recibos electrónicos, emitido y enviado por:\n");
                            strBody.AppendFormat("RFC: {0}\n", objInfoNomina.rfcTenedora);
                            strBody.AppendFormat("Razón Social: {0}\n", objInfoNomina.razonSocialTenedora);
                            strBody.Append("\n");
                            strBody.Append("Datos CFDI del recibo electrónico:\n");
                            strBody.AppendFormat("Empleado: {0}-{1} \n", objInfoNomina.numEmpleado, objInfoNomina.nombre);
                            strBody.AppendFormat("Periodo: {0} al {1} \n", sPeriodoInicialNomina, sPeriodoFinalNomina);
                            strBody.AppendFormat("UUID: {0}\n", objInfoNomina.renglon5Informativo);       //renglon5Informativo = FolioFiscalUUID
                            strBody.Append("\n");
                            strBody.Append("Esta dirección de correo electrónico no admite respuestas. Para obtener más información contacte a su ejecutivo.");

                            //NOMINAS
                            if (!sTipoNomina.Equals("ASI"))
                            {
                                // Create a report instance.
                                if (objInfoNomina.iAPPJ == 1)
                                {
                                    ReportesCFDI.ReciboFacturacionEmpleado report = new ReportesCFDI.ReciboFacturacionEmpleado();
                                    try
                                    {
                                        //asignar parametros del reporte
                                        report.Parameters["pIdLoteCargaNomina"].Value = objInfoNomina.IdLoteCargaNomina;
                                        report.Parameters["pIdPDOHeader"].Value = intPDOHeader;

                                        report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes
                                                                                    // Asignar opciones de Exportacion
                                        PdfExportOptions pdfOptions = report.ExportOptions.Pdf;
                                        pdfOptions.Compressed = true;
                                        pdfOptions.ImageQuality = PdfJpegImageQuality.Highest;
                                        pdfOptions.NeverEmbeddedFonts = "Tahoma;Courier New";
                                        //pdfOptions.DocumentOptions.Application = String.Format("{0} {1}", objNominaControlCFDI.SoftwareNombre, objNominaControlCFDI.SoftwareVersion);
                                        pdfOptions.DocumentOptions.Author = "SAIC Nóminas";
                                        pdfOptions.DocumentOptions.Keywords = "Recibo, Nómina, CFDI";
                                        pdfOptions.DocumentOptions.Title = "Recibo Nómina CFDI";

                                        // Exportar reporte a PDF
                                        report.ExportToPdf(memObjPDF);

                                        // Create a new attachment and put the PDF report into it.
                                        memObjPDF.Seek(0, System.IO.SeekOrigin.Begin);
                                        Attachment attObjPDF = new Attachment(memObjPDF, strNombreArchivoPDF, "application/pdf");

                                        //decodificar Contenido XML
                                        string decodedXmlCFDI = objInfoNomina.xmlCFDI; //Encoding.UTF8.GetString(data);

                                        //Crear archivo XML desde un string
                                        XmlDocument xdoc = new XmlDocument();
                                        xdoc.LoadXml(decodedXmlCFDI);
                                        //xdoc.Save(String.Format(@"{0}\{1}_E{2}_{3}{4}.xml", pRutaArchivosCFDI, pObjNomina.rfcTenedora, pObjNomina.numEmpleado, pObjNomina.serieRecibo, pObjNomina.folioRecibo));
                                        xdoc.Save(memObjXML);

                                        memObjXML.Seek(0, System.IO.SeekOrigin.Begin);
                                        Attachment attObjXML = new Attachment(memObjXML, strNombreArchivoXML, "text/xml");

                                        // Create a new message and attach the PDF report to it.
                                        MailMessage mail = new MailMessage();
                                        mail.Attachments.Add(attObjPDF);
                                        mail.Attachments.Add(attObjXML);

                                        // Specify sender and recipient options for the e-mail message.
                                        mail.From = new MailAddress(objConfigCorreo.EmailUser, "Notificaciones Recibos Nomina");
                                        mail.To.Add(new MailAddress(objInfoNomina.correoElectronico));  //destinatario
                                        //mail.To.Add(new MailAddress("daniel.sanchez@napoles.mx"));  //destinatario

                                        //mail.To.Add(new MailAddress("jose.junco@bpo.mx"));
                                        //mail.To.Add(new MailAddress("lilia.avendano@bpo.mx"));
                                        //mail.To.Add(new MailAddress("contacto@oblanco.mx"));
                                        //mail.To.Add(new MailAddress("alfredo.villegas@bpo.mx"));

                                        // Specify other e-mail options.
                                        mail.Subject = "Recibo de Nomina de " + objInfoNomina.nombre;
                                        mail.Body = strBody.ToString();

                                        //configurar conexion SMTP Server
                                        var client = new SmtpClient(objConfigCorreo.SMTPServer, Int16.Parse(objConfigCorreo.Puerto))
                                        {
                                            Credentials = new NetworkCredential(objConfigCorreo.EmailUser, objConfigCorreo.EmailPassword),
                                            EnableSsl = objConfigCorreo.SSL
                                        };

                                        System.Threading.Thread.Sleep(2000);
                                        client.Send(mail);  //enviar correo electronico

                                        String sRespuesta = String.Empty;

                                        //query que almacena y si es el caso cambia el correo siguiente
                                        queriesTableAdapter1.stpUpdContadorCorreo(
                                            Convert.ToInt32(objInfoNomina.IdLoteCargaNomina),
                                            Convert.ToInt32(intPDOHeader),
                                            objConfigCorreo.IdConfiguracionNotificaciones,
                                            1,
                                            compCatalogosSAIC.OperadorBD.OperadorGlobal.NombreUsuario,
                                            ref sRespuesta);

                                        if (!String.IsNullOrEmpty(sRespuesta))
                                        {
                                            XtraMessageBox.Show(sRespuesta, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            break;
                                        }

                                        objConfigCorreo = obtenerDatosCorreoElectronico();

                                        // Close the memory stream.
                                        memObjPDF.Close();
                                        memObjXML.Close();
                                    }
                                    catch (Exception ex)
                                    {
                                        this.Cursor = Cursors.Default;      //cambiar cursor del mouse
                                                                            //splashScreenManager1.CloseWaitForm();   //quitar pantalla de espera
                                        XtraMessageBox.Show(string.Format("{0}.\n\n¡El envío de Recibos CFDI NO fue exitoso!", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        objError.existeError = true;
                                        objError.noError = -99;
                                        objError.mensajeError = ex.Message;
                                        return;     //terminar ejecucion
                                    }
                                }
                                else
                                {
                                    ReportesCFDI.RecibosEmpleadosSueldosCFDI report = new ReportesCFDI.RecibosEmpleadosSueldosCFDI();
                                    try
                                    {
                                        //asignar parametros del reporte
                                        report.Parameters["pIdLoteCargaNomina"].Value = objInfoNomina.IdLoteCargaNomina;
                                        report.Parameters["pIdPDOHeader"].Value = intPDOHeader;
                                        report.Parameters["pTipoMovimientoNomina"].Value = sTipoNomina;    //obtener Tipo Nomina (SEM, QUI, ASI, etc)

                                        report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes
                                                                                    // Asignar opciones de Exportacion
                                        PdfExportOptions pdfOptions = report.ExportOptions.Pdf;
                                        pdfOptions.Compressed = true;
                                        pdfOptions.ImageQuality = PdfJpegImageQuality.Highest;
                                        pdfOptions.NeverEmbeddedFonts = "Tahoma;Courier New";
                                        //pdfOptions.DocumentOptions.Application = String.Format("{0} {1}", objNominaControlCFDI.SoftwareNombre, objNominaControlCFDI.SoftwareVersion);
                                        pdfOptions.DocumentOptions.Author = "SAIC Nóminas";
                                        pdfOptions.DocumentOptions.Keywords = "Recibo, Nómina, CFDI";
                                        pdfOptions.DocumentOptions.Title = "Recibo Nómina CFDI";

                                        // Exportar reporte a PDF
                                        report.ExportToPdf(memObjPDF);

                                        // Create a new attachment and put the PDF report into it.
                                        memObjPDF.Seek(0, System.IO.SeekOrigin.Begin);
                                        Attachment attObjPDF = new Attachment(memObjPDF, strNombreArchivoPDF, "application/pdf");

                                        //decodificar Contenido XML
                                        string decodedXmlCFDI = objInfoNomina.xmlCFDI; //Encoding.UTF8.GetString(data);

                                        //Crear archivo XML desde un string
                                        XmlDocument xdoc = new XmlDocument();
                                        xdoc.LoadXml(decodedXmlCFDI);
                                        //xdoc.Save(String.Format(@"{0}\{1}_E{2}_{3}{4}.xml", pRutaArchivosCFDI, pObjNomina.rfcTenedora, pObjNomina.numEmpleado, pObjNomina.serieRecibo, pObjNomina.folioRecibo));
                                        xdoc.Save(memObjXML);

                                        memObjXML.Seek(0, System.IO.SeekOrigin.Begin);
                                        Attachment attObjXML = new Attachment(memObjXML, strNombreArchivoXML, "text/xml");

                                        // Create a new message and attach the PDF report to it.
                                        MailMessage mail = new MailMessage();
                                        mail.Attachments.Add(attObjPDF);
                                        mail.Attachments.Add(attObjXML);

                                        // Specify sender and recipient options for the e-mail message.
                                        mail.From = new MailAddress(objConfigCorreo.EmailUser, "Notificaciones Recibos Nomina");
                                        mail.To.Add(new MailAddress(objInfoNomina.correoElectronico));  //destinatario
                                        //mail.To.Add(new MailAddress("daniel.sanchez@napoles.mx"));  //destinatario

                                        //mail.To.Add(new MailAddress("jose.junco@bpo.mx"));
                                        //mail.To.Add(new MailAddress("lilia.avendano@bpo.mx"));
                                        //mail.To.Add(new MailAddress("contacto@oblanco.mx"));
                                        //mail.To.Add(new MailAddress("alfredo.villegas@bpo.mx"));

                                        // Specify other e-mail options.
                                        mail.Subject = "Recibo de Nomina de " + objInfoNomina.nombre;
                                        mail.Body = strBody.ToString();

                                        //configurar conexion SMTP Server
                                        var client = new SmtpClient(objConfigCorreo.SMTPServer, Int16.Parse(objConfigCorreo.Puerto))
                                        {
                                            Credentials = new NetworkCredential(objConfigCorreo.EmailUser, objConfigCorreo.EmailPassword),
                                            EnableSsl = objConfigCorreo.SSL
                                        };

                                        System.Threading.Thread.Sleep(2000);
                                        client.Send(mail);  //enviar correo electronico


                                        String sRespuesta = String.Empty;

                                        //query que almacena y si es el caso cambia el correo siguiente
                                        queriesTableAdapter1.stpUpdContadorCorreo(
                                            Convert.ToInt32(objInfoNomina.IdLoteCargaNomina),
                                            Convert.ToInt32(intPDOHeader),
                                            objConfigCorreo.IdConfiguracionNotificaciones,
                                            1,
                                            compCatalogosSAIC.OperadorBD.OperadorGlobal.NombreUsuario,
                                            ref sRespuesta);

                                        if (!String.IsNullOrEmpty(sRespuesta))
                                        {
                                            XtraMessageBox.Show(sRespuesta, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            break;
                                        }

                                        objConfigCorreo = obtenerDatosCorreoElectronico();



                                        // Close the memory stream.
                                        memObjPDF.Close();
                                        memObjXML.Close();
                                    }
                                    catch (Exception ex)
                                    {
                                        this.Cursor = Cursors.Default;      //cambiar cursor del mouse
                                        splashScreenManager1.CloseWaitForm();   //quitar pantalla de espera
                                        XtraMessageBox.Show(string.Format("{0}.\n\n¡El envío de Recibos CFDI NO fue exitoso!", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        objError.existeError = true;
                                        objError.noError = -99;
                                        objError.mensajeError = ex.Message;
                                        return;     //terminar ejecucion
                                    }
                                }
                            }
                            else    //ASIMILADOS
                            {
                                // Create a report instance.
                                ReportesCFDI.RecibosAsimiladosSalariosCFDI report = new ReportesCFDI.RecibosAsimiladosSalariosCFDI();
                                try
                                {
                                    //asignar parametros del reporte
                                    report.Parameters["pIdLoteCargaNomina"].Value = objInfoNomina.IdLoteCargaNomina;
                                    report.Parameters["pIdPDOHeader"].Value = intPDOHeader;
                                    report.Parameters["pTipoMovimientoNomina"].Value = sTipoNomina;    //obtener Tipo Nomina (SEM, QUI, ASI, etc)

                                    report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes
                                                                                // Asignar opciones de Exportacion
                                    PdfExportOptions pdfOptions = report.ExportOptions.Pdf;
                                    pdfOptions.Compressed = true;
                                    pdfOptions.ImageQuality = PdfJpegImageQuality.Highest;
                                    pdfOptions.NeverEmbeddedFonts = "Tahoma;Courier New";
                                    //pdfOptions.DocumentOptions.Application = String.Format("{0} {1}", objNominaControlCFDI.SoftwareNombre, objNominaControlCFDI.SoftwareVersion);
                                    pdfOptions.DocumentOptions.Author = "SAIC Asimilados";
                                    pdfOptions.DocumentOptions.Keywords = "Recibo, Asimilados, CFDI";
                                    pdfOptions.DocumentOptions.Title = "Recibo Asimilados CFDI";

                                    // Exportar reporte a PDF
                                    report.ExportToPdf(memObjPDF);

                                    // Create a new attachment and put the PDF report into it.
                                    memObjPDF.Seek(0, System.IO.SeekOrigin.Begin);
                                    Attachment attObjPDF = new Attachment(memObjPDF, strNombreArchivoPDF, "application/pdf");

                                    //decodificar Contenido XML
                                    string decodedXmlCFDI = objInfoNomina.xmlCFDI; //Encoding.UTF8.GetString(data);

                                    //Crear archivo XML desde un string
                                    XmlDocument xdoc = new XmlDocument();
                                    xdoc.LoadXml(decodedXmlCFDI);
                                    //xdoc.Save(String.Format(@"{0}\{1}_E{2}_{3}{4}.xml", pRutaArchivosCFDI, pObjNomina.rfcTenedora, pObjNomina.numEmpleado, pObjNomina.serieRecibo, pObjNomina.folioRecibo));
                                    xdoc.Save(memObjXML);

                                    memObjXML.Seek(0, System.IO.SeekOrigin.Begin);
                                    Attachment attObjXML = new Attachment(memObjXML, strNombreArchivoXML, "text/xml");

                                    // Create a new message and attach the PDF report to it.
                                    MailMessage mail = new MailMessage();
                                    mail.Attachments.Add(attObjPDF);
                                    mail.Attachments.Add(attObjXML);

                                    // Specify sender and recipient options for the e-mail message.
                                    mail.From = new MailAddress(objConfigCorreo.EmailUser, "Notificaciones Recibos Asimilados");
                                    mail.To.Add(new MailAddress(objInfoNomina.correoElectronico));  //destinatario
                                    //mail.To.Add(new MailAddress("daniel.sanchez@napoles.mx"));  //destinatario

                                    //mail.To.Add(new MailAddress("jose.junco@bpo.mx"));
                                    //mail.To.Add(new MailAddress("lilia.avendano@bpo.mx"));
                                    //mail.To.Add(new MailAddress("contacto@oblanco.mx"));
                                    //mail.To.Add(new MailAddress("alfredo.villegas@bpo.mx"));

                                    // Specify other e-mail options.
                                    mail.Subject = "Recibo de Asimilados de " + objInfoNomina.nombre;
                                    mail.Body = strBody.ToString();

                                    //configurar conexion SMTP Server
                                    var client = new SmtpClient(objConfigCorreo.SMTPServer, Int16.Parse(objConfigCorreo.Puerto))
                                    {
                                        Credentials = new NetworkCredential(objConfigCorreo.EmailUser, objConfigCorreo.EmailPassword),
                                        EnableSsl = objConfigCorreo.SSL
                                    };

                                    System.Threading.Thread.Sleep(2000);
                                    client.Send(mail);  //enviar correo electronico

                                    //**********************************************************
                                    String sRespuesta = String.Empty;

                                    //query que almacena y si es el caso cambia el correo siguiente
                                    queriesTableAdapter1.stpUpdContadorCorreo(
                                         Convert.ToInt32(objInfoNomina.IdLoteCargaNomina),
                                        Convert.ToInt32(intPDOHeader),
                                        objConfigCorreo.IdConfiguracionNotificaciones,
                                        1,
                                        compCatalogosSAIC.OperadorBD.OperadorGlobal.NombreUsuario,
                                        ref sRespuesta);

                                    if (!String.IsNullOrEmpty(sRespuesta))
                                    {
                                        XtraMessageBox.Show(sRespuesta, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        break;
                                    }

                                    objConfigCorreo = obtenerDatosCorreoElectronico();
                                    //**********************************************************

                                    // Close the memory stream.
                                    memObjPDF.Close();
                                    memObjXML.Close();

                                    if (objConfigCorreo == null)
                                    {
                                        break;
                                    }

                                }
                                catch (Exception ex)
                                {
                                    this.Cursor = Cursors.Default;      //cambiar cursor del mouse
                                    splashScreenManager1.CloseWaitForm();   //quitar pantalla de espera
                                    XtraMessageBox.Show(string.Format("El envío de Recibo CFDI NO fue exitoso para el Empleado # {0}-{1}.\n\n{2}", objInfoNomina.numEmpleado, objInfoNomina.nombre, ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    objError.existeError = true;
                                    objError.noError = -99;
                                    objError.mensajeError = ex.Message;
                                    return;     //terminar ejecucion
                                }
                            }
                        }   //if
                    }  //for

                    this.Cursor = Cursors.Default;      //cambiar cursor del mouse
                    if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }//quitar pantalla de espera
                    XtraMessageBox.Show("¡El envío de Recibos CFDI fue exitoso!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnBuscarNoLoteNomina_Click(sender, e);
                }
                else
                    XtraMessageBox.Show("¡No existen Movimientos seleccionados para enviar Recibos CFDI!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                XtraMessageBox.Show("¡No existe Cuenta de Correo configurada para las Notificaciones!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnBuscarNoLoteNomina_Click(object sender, EventArgs e)
        {
            try
            {
                //si escribieron un valor
                if (txtNoLoteCargaNomina.Text.Trim().Length > 0)
                {
                    if (Validator.IsPositiveNumber(txtNoLoteCargaNomina))
                    {
                        //cargar informacion detallada LoteCargaNomina
                        MostrarInfoDetalleLoteCargaNomina(Convert.ToInt64(txtNoLoteCargaNomina.EditValue));
                        //inicializar contador de registros seleccionados
                        lblNoFoliosSeleccionados.Text = "0";

                        //si existe el objeto InfoDetalle
                        if (objInfoDetalle != null)
                        {
                            splashScreenManager1.ShowWaitForm();

                            this.stpSelRecibosEmpleadosSueldosAsimiladosGenericoCFDITableAdapter.Fill(this.dbSAICBPONominaCFDIDataSet.stpSelRecibosEmpleadosSueldosAsimiladosGenericoCFDI, -1, -1, -1, Convert.ToInt64(txtNoLoteCargaNomina.EditValue), 0, 4, OperadorBD.OperadorGlobal.IdOperador);

                            //Saber cuantos recibos se han enviado
                            var query = from x in dbSAICBPONominaCFDIDataSet.stpSelRecibosEmpleadosSueldosAsimiladosGenericoCFDI.AsEnumerable()
                                        where x.Field<DateTime>("Fecha de Envio Recibo").Date != new DateTime(1900, 01, 01)
                                        select x;

                            txtTotalRecibosEnviados.Text = query.Count().ToString();

                            iComienzo = -1;
                            iFin = 0;

                            objConfigCorreo = obtenerDatosCorreoElectronico();

                            if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }

                            if (this.dbSAICBPONominaCFDIDataSet.stpSelRecibosEmpleadosSueldosAsimiladosGenericoCFDI.Count > 0)
                                //asignar los registros a un DataTable que LINQ filtrara para la selecciona de registros
                                dtInfoEmpleado = this.dbSAICBPONominaCFDIDataSet.stpSelRecibosEmpleadosSueldosAsimiladosGenericoCFDI;
                            else
                                XtraMessageBox.Show(string.Format("¡No existen registros para este No. Lote Nómina {0}!", txtNoLoteCargaNomina.EditValue), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            //mostrar registros del Lote Nomina = 0 para cuando el objeto InfoDetalle = null
                            this.stpSelRecibosEmpleadosSueldosAsimiladosGenericoCFDITableAdapter.Fill(this.dbSAICBPONominaCFDIDataSet.stpSelRecibosEmpleadosSueldosAsimiladosGenericoCFDI, -1, -1, -1, 0, 0, 4, OperadorBD.OperadorGlobal.IdOperador);

                            XtraMessageBox.Show(string.Format("¡No existen registros para este No. Lote Nómina {0}!", txtNoLoteCargaNomina.EditValue), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                    XtraMessageBox.Show("Debe escribir el No. de Lote Nómina para obtener la Información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNoLoteCargaNomina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnBuscarNoLoteNomina_Click(sender, e);     //si existe ENTER entonces ejecutar metodo-evento click
        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            chkListNominas.SelectedValue = gridView1.FocusedValue;
            chkListNominas.SelectedItem = gridView1.FocusedValue;
            chkListNominas.Focus();
        }

        private void btnBuscarLote_Click(object sender, EventArgs e)
        {
            Int32 intIdTenedora = 0;
            Int32 intIdCliente = 0;
            Int32 intIdEmpleado = 0;
            Int16 intAnoPago = 0;
            Int64 intIdLoteCargaNomina = 0;

            intIdLoteCargaNomina = Convert.ToInt64(txtNoLoteCFDIs.EditValue);
            sIdLoteCargaNomina = Convert.ToInt64(txtNoLoteCFDIs.EditValue).ToString();
            MostrarInfoDetalleLoteCargaNominaxLote(Convert.ToInt64(txtNoLoteCFDIs.EditValue));

            //splashScreenManager1.ShowWaitForm();      //mostrar mensaje procesando
            this.Cursor = Cursors.AppStarting;      //cambiar cursor del mouse

            //dtInfoEmpleado = null;      //inicializar;
            this.stpSelRecibosEmpleadosSueldosAsimiladosGenericoCFDITableAdapter.Fill(this.dbSAICBPONominaCFDIDataSet.stpSelRecibosEmpleadosSueldosAsimiladosGenericoCFDI, intIdTenedora, intIdCliente, intIdEmpleado, intIdLoteCargaNomina, intAnoPago, TipoEmisionCFDIs, OperadorBD.OperadorGlobal.IdOperador);

            this.Cursor = Cursors.Default;      //cambiar cursor del mouse
                                                //splashScreenManager1.CloseWaitForm();   //quitar pantalla de espera

            if (this.dbSAICBPONominaCFDIDataSet.stpSelRecibosEmpleadosSueldosAsimiladosGenericoCFDI.Count > 0)
                //asignar los registros a un DataTable que LINQ filtrara para la selecciona de registros
                dtInfoEmpleado = this.dbSAICBPONominaCFDIDataSet.stpSelRecibosEmpleadosSueldosAsimiladosGenericoCFDI;
            else
                XtraMessageBox.Show("¡No existen registros para este filtro!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MostrarInfoDetalleLoteCargaNominaxLote(long pIdLoteCargaNomina)
        {
            string VersionCFDI = "";
            //cargar informacion detalla LoteCargaNomina
            DataTable dt = this.stpSelInfoDetalleLoteCargaNominaTableAdapter1.GetData(pIdLoteCargaNomina);

            //crear objeto y pasar el DataTable para asignar los valores
            objInfoDetalle = InfoDetalleLoteCargaNominaBD.ObtenerInfoDetalleLoteCargaNomina(dt);

            //si existe el objeto entonces mostrar los valores
            if (objInfoDetalle != null)
            {
                seguridadTableAdapter1.stpSelVersionTimbre(objInfoDetalle.IdTenedora, objInfoDetalle.IdLoteCargaNomina, ref VersionCFDI);
                txtVersion.Text = VersionCFDI;
                txtTenedoraCFDIxLote.Text = objInfoDetalle.NombreComercialTenedora;
                txtClienteCFDIxLote.Text = objInfoDetalle.NombreComercialCliente;
                txtOperadorCFDIxLote.Text = objInfoDetalle.Operador;
                txtTipoNominaCFDIxLote.Text = objInfoDetalle.TipoNomina;
                txtPeriodoCFDIxLote.Text = objInfoDetalle.PeriodoPago;
                chkContabilizadaCFDIxLote.Checked = objInfoDetalle.EstatusNominaContabilizada;
                if (objInfoDetalle.AnoPago > 0)
                    txtFechaPagoCFDIxLote.Text = String.Format("{0} {1}", objInfoDetalle.MesPago, objInfoDetalle.AnoPago);
                else
                    txtFechaPagoCFDIxLote.Text = "";     //inicializar textbox
                sIdLoteCargaNomina = pIdLoteCargaNomina.ToString();
            }
            else
            {
                txtTenedoraCFDIxLote.Text = String.Empty;
                txtClienteCFDIxLote.Text = String.Empty;
                txtOperadorCFDIxLote.Text = String.Empty;
                txtTipoNominaCFDIxLote.Text = String.Empty;
                txtPeriodoCFDIxLote.Text = String.Empty;
                chkContabilizadaCFDIxLote.Checked = false;
                txtFechaPagoCFDIxLote.Text = String.Empty;     //inicializar textbox
                sIdLoteCargaNomina = String.Empty;
                txtVersion.Text = String.Empty;
            }
        }

        private void btnGenerarPDFGlobal_Click(object sender, EventArgs e)
        {
            try
            {
                //si existe lote de nómna valido
                if (!txtNoLoteCFDIs.Text.Equals(""))
                {
                    //Generar recibos timbrados en PDF Global
                    //Parámetro pIdPDOHeader es OPCIONAL con valor default -1
                    if (objInfoDetalle.APPJ == 1)
                        GenerarTimbradosPDFGlobalFactura(objInfoDetalle.IdLoteCargaNomina, objInfoDetalle.TipoNomina);
                    else
                        GenerarTimbradosPDFGlobal(objInfoDetalle.IdLoteCargaNomina, objInfoDetalle.TipoNomina, txtVersion.Text);
                }
                else
                    XtraMessageBox.Show("¡Para Generar Timbrados en PDF Global \ndebe seleccionar un Lote de Nómina!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GenerarTimbradosPDFGlobal(long pIdLoteCargaNomina, string pTipoNomina, string pVersionTimbrado, long pIdPDOHeader = -1)
        {
            try
            {
                if (!pTipoNomina.Equals("ASI"))     //No es ASIMILADO
                {
                    //crear reporte
                    if (pVersionTimbrado != "4.0")
                    {
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
                    report.Parameters["pTipoMovimientoNomina"].Value = pTipoNomina;

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

        private void txtRegistrosSeleccionados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SeleccionarSiguientes();
            }
        }


        private ConfiguracionNotificacion obtenerDatosCorreoElectronico()
        {
            ConfiguracionNotificacion oConfiguracionNotificacion = new ConfiguracionNotificacion();
            DataTable dt = this.stpSelCorreosNotificacionTableAdapter1.GetData();
            oConfiguracionNotificacion = ConfiguracionNotificacionBD.ObtenerConfiguracionNotificacionCorreos(dt);

            int IdConfiguracionNotificaciones = 0;

            if (oConfiguracionNotificacion != null)
            {
                IdConfiguracionNotificaciones = oConfiguracionNotificacion.IdConfiguracionNotificaciones;
                txtCorreo.Text = oConfiguracionNotificacion.EmailUser;
                btnEnviarRecibosCorreo.Enabled = true;
            }
            else
            {
                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                XtraMessageBox.Show("Se llego al limite de correos Diarios, intente nuevamente el día de mañana.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCorreo.Text = String.Empty;
                txtCorreosTotales.Text = String.Empty;
                txtLimiteCorreos.Text = String.Empty;
                btnEnviarRecibosCorreo.Enabled = false;
                IdConfiguracionNotificaciones = 0;
            }

            stpSelContadorCorreoTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelContadorCorreo, IdConfiguracionNotificaciones);

            if (dbSAICBPOCatalogosDataSet1.stpSelContadorCorreo.Rows.Count > 0)
            {
                txtCorreosTotales.Text = dbSAICBPOCatalogosDataSet1.stpSelContadorCorreo.Rows[0]["NumeroCorreo"].ToString();
                txtLimiteCorreos.Text = dbSAICBPOCatalogosDataSet1.stpSelContadorCorreo.Rows[0]["LimiteCorreosDiarios"].ToString();
            }

            return oConfiguracionNotificacion;
        }

        private void btnSeleccionarSiguientes_Click(object sender, EventArgs e)
        {
            SeleccionarSiguientes();
        }


        private void SeleccionarSiguientes()
        {
            int iRegistrosSeleccionados = 0;
            int.TryParse(txtRegistrosSeleccionados.Text, out iRegistrosSeleccionados);
            iFin += iRegistrosSeleccionados;

            if (chkListNominas.CheckedItemsCount == 1)
            {
                iComienzo = chkListNominas.SelectedIndex;
                iFin = chkListNominas.SelectedIndex + iRegistrosSeleccionados + 1;
            }

            for (int i = 0; i < chkListNominas.ItemCount; i++)
            {
                chkListNominas.SetItemChecked(i, false);
                if (i > iComienzo && i < iFin)
                {
                    chkListNominas.SetItemChecked(i, true);
                    iComienzo = i;
                }
            }

            if (iComienzo == (chkListNominas.ItemCount - 1))
            {
                iComienzo = -1;
                iFin = 0;
            }
        }

        private void btnExportarExcelEmpleado_Click(object sender, EventArgs e)
        {
            descargarAExcel("CFDI por Empleado E_" + txtNoEmpleado.Text + "_" + txtNombreEmpleado.Text + " " + dsc.nombreAleatorio() + ".xlsx");
        }

        private void descargarAExcel(String stNombreArchivo)
        {
            String stRuta = dsc.stRutaSAICOperaciones;
            dsc.CheckandCreateFolder(stRuta);

            stRuta += stNombreArchivo;

            if (gridView1.RowCount > 0)
            {
                gwcRecibosEmitidos.ExportToXlsx(stRuta);
                XtraMessageBox.Show("Archivo descargado con exito. Ruta: " + stRuta
                    , "SAIC"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Consulte un registro para continuar", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnExportarExcelTenedoraCliente_Click(object sender, EventArgs e)
        {
            descargarAExcel("CFDI por Teenora_Cliente T_" + cboIdTenedoraSA.Text + " C_" + cboIdCliente.Text + " " + dsc.nombreAleatorio() + ".xlsx");
        }

        private void btnExportarExcelLote_Click(object sender, EventArgs e)
        {
            descargarAExcel("CFDI por Lote L_" + txtNoLoteCFDIs.Text + " " + dsc.nombreAleatorio() + ".xlsx");
        }

        private void btnExportarExcelCorreo_Click(object sender, EventArgs e)
        {
            descargarAExcel("CFDI por Correo L_" + txtNoLoteCargaNomina.Text + " " + dsc.nombreAleatorio() + ".xlsx");
        }

        public envioDeCorreos enviarRecibos(long idLoteCargaNomina, List<long> lstIdPDOHeader)
        {
            envioDeCorreos oenvioDeCorreos = new envioDeCorreos();
            ConfiguracionNotificacion objConfigCorreoEnviarRecivos = obtenerDatosCorreoElectronico();

            //SI se tiene configuracion de Cuenta de Correo
            if (objConfigCorreoEnviarRecivos != null)
            {
                objConfigCorreo = objConfigCorreoEnviarRecivos;

                stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "DELAY_ENVIODERECIBOS");
                if (dbSAICBPOValidacionDataSet1.stpSelParametro.Rows.Count > 0)
                {
                    int iValor = 0;
                    int.TryParse(dbSAICBPOValidacionDataSet1.stpSelParametro.Rows[0]["ValorParametro"].ToString(), out iValor);
                    iDelay_EnvioRecibos = iValor;
                }
                else
                {
                    iDelay_EnvioRecibos = 2000;
                }



                splashScreenManager1.ShowWaitForm();        //mostrar pantalla de espera
                splashScreenManager1.SetWaitFormCaption("Enviando Recibos");
                this.Cursor = Cursors.AppStarting;      //cambiar cursor del mouse
                int iContador = 0;

                this.stpSelRecibosEmpleadosSueldosAsimiladosGenericoCFDITableAdapter.Fill(this.dbSAICBPONominaCFDIDataSet.stpSelRecibosEmpleadosSueldosAsimiladosGenericoCFDI, -1, -1, -1, idLoteCargaNomina, 0, 4, OperadorBD.OperadorGlobal.IdOperador);
                DataTable dtInfoEmpleado = dbSAICBPONominaCFDIDataSet.stpSelRecibosEmpleadosSueldosAsimiladosGenericoCFDI;

                //for (int i = 0; i < chkListNominas.ItemCount; i++)                    
                foreach (int intPDOHeader in lstIdPDOHeader)
                {

                    iContador++;
                    splashScreenManager1.SetWaitFormDescription(iContador + " de " + chkListNominas.CheckedItems.Count);

                    //obtener informacion del recibo seleccionado
                    Nomina objInfoNomina = LayoutEmisionCFDIGenericoBD.ObtenerInfoReciboCFDI(dtInfoEmpleado, intPDOHeader);
                    Estructuras.InformacionError objError;      //variable que recibe comportamiento de la exportacion
                    string strNombreArchivoPDF = "";
                    string strNombreArchivoXML = "";

                    //RFC Tenedora + Empleado + Serie + Folio Recibo CFDI
                    strNombreArchivoPDF = String.Format(@"{0}_E{1}_{2}{3}.pdf", objInfoNomina.rfcTenedora, objInfoNomina.numEmpleado, objInfoNomina.serieRecibo, objInfoNomina.folioRecibo);
                    strNombreArchivoXML = String.Format(@"{0}_E{1}_{2}{3}.xml", objInfoNomina.rfcTenedora, objInfoNomina.numEmpleado, objInfoNomina.serieRecibo, objInfoNomina.folioRecibo);

                    string sTipoNomina = objInfoNomina.folioLoteCargaNomina.Substring(2, 3);
                    string sPeriodoInicialNomina = objInfoNomina.folioLoteCargaNomina.Substring(6, 8);
                    string sPeriodoFinalNomina = objInfoNomina.folioLoteCargaNomina.Substring(15, 8); ;

                    MemoryStream memObjPDF = new MemoryStream();
                    MemoryStream memObjXML = new MemoryStream();
                    StringBuilder strBody = new StringBuilder();

                    //integrar Body del Correo Electrónico
                    strBody.Append("Buen día.\n\n");
                    strBody.Append("Servicio de entrega de CFDI de recibos electrónicos, emitido y enviado por:\n");
                    strBody.AppendFormat("RFC: {0}\n", objInfoNomina.rfcTenedora);
                    strBody.AppendFormat("Razón Social: {0}\n", objInfoNomina.razonSocialTenedora);
                    strBody.Append("\n");
                    strBody.Append("Datos CFDI del recibo electrónico:\n");
                    strBody.AppendFormat("Empleado: {0}-{1} \n", objInfoNomina.numEmpleado, objInfoNomina.nombre);
                    strBody.AppendFormat("Periodo: {0} al {1} \n", sPeriodoInicialNomina, sPeriodoFinalNomina);
                    strBody.AppendFormat("UUID: {0}\n", objInfoNomina.renglon5Informativo);       //renglon5Informativo = FolioFiscalUUID
                    strBody.Append("\n");
                    strBody.Append("Esta dirección de correo electrónico no admite respuestas. Para obtener más información contacte a su ejecutivo.");

                    //NOMINAS
                    if (!sTipoNomina.Equals("ASI"))
                    {
                        // Create a report instance.
                        if (objInfoNomina.iAPPJ == 1)
                        {
                            ReportesCFDI.ReciboFacturacionEmpleado report = new ReportesCFDI.ReciboFacturacionEmpleado();
                            try
                            {
                                //asignar parametros del reporte
                                report.Parameters["pIdLoteCargaNomina"].Value = objInfoNomina.IdLoteCargaNomina;
                                report.Parameters["pIdPDOHeader"].Value = intPDOHeader;

                                report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes
                                                                            // Asignar opciones de Exportacion
                                PdfExportOptions pdfOptions = report.ExportOptions.Pdf;
                                pdfOptions.Compressed = true;
                                pdfOptions.ImageQuality = PdfJpegImageQuality.Highest;
                                pdfOptions.NeverEmbeddedFonts = "Tahoma;Courier New";
                                //pdfOptions.DocumentOptions.Application = String.Format("{0} {1}", objNominaControlCFDI.SoftwareNombre, objNominaControlCFDI.SoftwareVersion);
                                pdfOptions.DocumentOptions.Author = "SAIC Nóminas";
                                pdfOptions.DocumentOptions.Keywords = "Recibo, Nómina, CFDI";
                                pdfOptions.DocumentOptions.Title = "Recibo Nómina CFDI";

                                // Exportar reporte a PDF
                                report.ExportToPdf(memObjPDF);

                                // Create a new attachment and put the PDF report into it.
                                memObjPDF.Seek(0, System.IO.SeekOrigin.Begin);
                                Attachment attObjPDF = new Attachment(memObjPDF, strNombreArchivoPDF, "application/pdf");

                                //decodificar Contenido XML
                                string decodedXmlCFDI = objInfoNomina.xmlCFDI; //Encoding.UTF8.GetString(data);

                                //Crear archivo XML desde un string
                                XmlDocument xdoc = new XmlDocument();
                                xdoc.LoadXml(decodedXmlCFDI);
                                //xdoc.Save(String.Format(@"{0}\{1}_E{2}_{3}{4}.xml", pRutaArchivosCFDI, pObjNomina.rfcTenedora, pObjNomina.numEmpleado, pObjNomina.serieRecibo, pObjNomina.folioRecibo));
                                xdoc.Save(memObjXML);

                                memObjXML.Seek(0, System.IO.SeekOrigin.Begin);
                                Attachment attObjXML = new Attachment(memObjXML, strNombreArchivoXML, "text/xml");

                                // Create a new message and attach the PDF report to it.
                                MailMessage mail = new MailMessage();
                                mail.Attachments.Add(attObjPDF);
                                mail.Attachments.Add(attObjXML);

                                // Specify sender and recipient options for the e-mail message.
                                mail.From = new MailAddress(objConfigCorreo.EmailUser, "Notificaciones Recibos Nomina");
                                mail.To.Add(new MailAddress(objInfoNomina.correoElectronico));  //destinatario
                                //mail.To.Add(new MailAddress("daniel.sanchez@napoles.mx"));  //destinatario

                                //mail.To.Add(new MailAddress("jose.junco@bpo.mx"));
                                //mail.To.Add(new MailAddress("lilia.avendano@bpo.mx"));
                                //mail.To.Add(new MailAddress("contacto@oblanco.mx"));
                                //mail.To.Add(new MailAddress("alfredo.villegas@bpo.mx"));

                                // Specify other e-mail options.
                                mail.Subject = "Recibo de Nomina de " + objInfoNomina.nombre;
                                mail.Body = strBody.ToString();

                                //configurar conexion SMTP Server
                                var client = new SmtpClient(objConfigCorreo.SMTPServer, Int16.Parse(objConfigCorreo.Puerto))
                                {
                                    Credentials = new NetworkCredential(objConfigCorreo.EmailUser, objConfigCorreo.EmailPassword),
                                    EnableSsl = objConfigCorreo.SSL
                                };

                                System.Threading.Thread.Sleep(iDelay_EnvioRecibos);
                                client.Send(mail);  //enviar correo electronico

                                String sRespuesta = String.Empty;

                                //query que almacena y si es el caso cambia el correo siguiente
                                queriesTableAdapter1.stpUpdContadorCorreo(
                                    Convert.ToInt32(objInfoNomina.IdLoteCargaNomina),
                                    Convert.ToInt32(intPDOHeader),
                                    objConfigCorreo.IdConfiguracionNotificaciones,
                                    1,
                                    compCatalogosSAIC.OperadorBD.OperadorGlobal.NombreUsuario,
                                    ref sRespuesta);

                                if (!String.IsNullOrEmpty(sRespuesta))
                                {
                                    oenvioDeCorreos.sError = sRespuesta;
                                    oenvioDeCorreos.iCuantosNOEnviados++;
                                    break;
                                }
                                else
                                {
                                    oenvioDeCorreos.iCuantosEnviados++;
                                }

                                objConfigCorreo = obtenerDatosCorreoElectronico();

                                // Close the memory stream.
                                memObjPDF.Close();
                                memObjXML.Close();
                            }
                            catch (Exception ex)
                            {
                                this.Cursor = Cursors.Default;      //cambiar cursor del mouse
                                                                    //splashScreenManager1.CloseWaitForm();   //quitar pantalla de espera
                                oenvioDeCorreos.sError = string.Format("{0}.\n\n¡El envío de Recibos CFDI NO fue exitoso!", ex.Message);
                                objError.existeError = true;
                                objError.noError = -99;
                                objError.mensajeError = ex.Message;
                                oenvioDeCorreos.iCuantosNOEnviados++;
                            }
                        }
                        else
                        {
                            ReportesCFDI.RecibosEmpleadosSueldosCFDI report = new ReportesCFDI.RecibosEmpleadosSueldosCFDI();
                            try
                            {
                                //asignar parametros del reporte
                                report.Parameters["pIdLoteCargaNomina"].Value = objInfoNomina.IdLoteCargaNomina;
                                report.Parameters["pIdPDOHeader"].Value = intPDOHeader;
                                report.Parameters["pTipoMovimientoNomina"].Value = sTipoNomina;    //obtener Tipo Nomina (SEM, QUI, ASI, etc)

                                report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes
                                                                            // Asignar opciones de Exportacion
                                PdfExportOptions pdfOptions = report.ExportOptions.Pdf;
                                pdfOptions.Compressed = true;
                                pdfOptions.ImageQuality = PdfJpegImageQuality.Highest;
                                pdfOptions.NeverEmbeddedFonts = "Tahoma;Courier New";
                                //pdfOptions.DocumentOptions.Application = String.Format("{0} {1}", objNominaControlCFDI.SoftwareNombre, objNominaControlCFDI.SoftwareVersion);
                                pdfOptions.DocumentOptions.Author = "SAIC Nóminas";
                                pdfOptions.DocumentOptions.Keywords = "Recibo, Nómina, CFDI";
                                pdfOptions.DocumentOptions.Title = "Recibo Nómina CFDI";

                                // Exportar reporte a PDF
                                report.ExportToPdf(memObjPDF);

                                // Create a new attachment and put the PDF report into it.
                                memObjPDF.Seek(0, System.IO.SeekOrigin.Begin);
                                Attachment attObjPDF = new Attachment(memObjPDF, strNombreArchivoPDF, "application/pdf");

                                //decodificar Contenido XML
                                string decodedXmlCFDI = objInfoNomina.xmlCFDI; //Encoding.UTF8.GetString(data);

                                //Crear archivo XML desde un string
                                XmlDocument xdoc = new XmlDocument();
                                xdoc.LoadXml(decodedXmlCFDI);
                                //xdoc.Save(String.Format(@"{0}\{1}_E{2}_{3}{4}.xml", pRutaArchivosCFDI, pObjNomina.rfcTenedora, pObjNomina.numEmpleado, pObjNomina.serieRecibo, pObjNomina.folioRecibo));
                                xdoc.Save(memObjXML);

                                memObjXML.Seek(0, System.IO.SeekOrigin.Begin);
                                Attachment attObjXML = new Attachment(memObjXML, strNombreArchivoXML, "text/xml");

                                // Create a new message and attach the PDF report to it.
                                MailMessage mail = new MailMessage();
                                mail.Attachments.Add(attObjPDF);
                                mail.Attachments.Add(attObjXML);

                                // Specify sender and recipient options for the e-mail message.
                                mail.From = new MailAddress(objConfigCorreo.EmailUser, "Notificaciones Recibos Nomina");
                                mail.To.Add(new MailAddress(objInfoNomina.correoElectronico));  //destinatario
                                //mail.To.Add(new MailAddress("daniel.sanchez@napoles.mx"));  //destinatario

                                //mail.To.Add(new MailAddress("jose.junco@bpo.mx"));
                                //mail.To.Add(new MailAddress("lilia.avendano@bpo.mx"));
                                //mail.To.Add(new MailAddress("contacto@oblanco.mx"));
                                //mail.To.Add(new MailAddress("alfredo.villegas@bpo.mx"));

                                // Specify other e-mail options.
                                mail.Subject = "Recibo de Nomina de " + objInfoNomina.nombre;
                                mail.Body = strBody.ToString();

                                //configurar conexion SMTP Server
                                var client = new SmtpClient(objConfigCorreo.SMTPServer, Int16.Parse(objConfigCorreo.Puerto))
                                {
                                    Credentials = new NetworkCredential(objConfigCorreo.EmailUser, objConfigCorreo.EmailPassword),
                                    EnableSsl = objConfigCorreo.SSL
                                };

                                System.Threading.Thread.Sleep(iDelay_EnvioRecibos);
                                client.Send(mail);  //enviar correo electronico


                                String sRespuesta = String.Empty;

                                //query que almacena y si es el caso cambia el correo siguiente
                                queriesTableAdapter1.stpUpdContadorCorreo(
                                    Convert.ToInt32(objInfoNomina.IdLoteCargaNomina),
                                    Convert.ToInt32(intPDOHeader),
                                    objConfigCorreo.IdConfiguracionNotificaciones,
                                    1,
                                    compCatalogosSAIC.OperadorBD.OperadorGlobal.NombreUsuario,
                                    ref sRespuesta);

                                if (!String.IsNullOrEmpty(sRespuesta))
                                {
                                    oenvioDeCorreos.sError = sRespuesta;
                                    oenvioDeCorreos.iCuantosNOEnviados++;
                                    break;
                                }
                                else
                                {
                                    oenvioDeCorreos.iCuantosEnviados++;
                                }

                                objConfigCorreo = obtenerDatosCorreoElectronico();

                                // Close the memory stream.
                                memObjPDF.Close();
                                memObjXML.Close();
                            }
                            catch (Exception ex)
                            {
                                this.Cursor = Cursors.Default;      //cambiar cursor del mouse
                                splashScreenManager1.CloseWaitForm();   //quitar pantalla de espera
                                oenvioDeCorreos.sError = string.Format("{0}.\n\n¡El envío de Recibos CFDI NO fue exitoso!", ex.Message);
                                objError.existeError = true;
                                objError.noError = -99;
                                objError.mensajeError = ex.Message;
                                oenvioDeCorreos.iCuantosNOEnviados++;
                            }
                        }
                    }
                    else    //ASIMILADOS
                    {
                        // Create a report instance.
                        ReportesCFDI.RecibosAsimiladosSalariosCFDI report = new ReportesCFDI.RecibosAsimiladosSalariosCFDI();
                        try
                        {
                            //asignar parametros del reporte
                            report.Parameters["pIdLoteCargaNomina"].Value = objInfoNomina.IdLoteCargaNomina;
                            report.Parameters["pIdPDOHeader"].Value = intPDOHeader;
                            report.Parameters["pTipoMovimientoNomina"].Value = sTipoNomina;    //obtener Tipo Nomina (SEM, QUI, ASI, etc)

                            report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes
                                                                        // Asignar opciones de Exportacion
                            PdfExportOptions pdfOptions = report.ExportOptions.Pdf;
                            pdfOptions.Compressed = true;
                            pdfOptions.ImageQuality = PdfJpegImageQuality.Highest;
                            pdfOptions.NeverEmbeddedFonts = "Tahoma;Courier New";
                            //pdfOptions.DocumentOptions.Application = String.Format("{0} {1}", objNominaControlCFDI.SoftwareNombre, objNominaControlCFDI.SoftwareVersion);
                            pdfOptions.DocumentOptions.Author = "SAIC Asimilados";
                            pdfOptions.DocumentOptions.Keywords = "Recibo, Asimilados, CFDI";
                            pdfOptions.DocumentOptions.Title = "Recibo Asimilados CFDI";

                            // Exportar reporte a PDF
                            report.ExportToPdf(memObjPDF);

                            // Create a new attachment and put the PDF report into it.
                            memObjPDF.Seek(0, System.IO.SeekOrigin.Begin);
                            Attachment attObjPDF = new Attachment(memObjPDF, strNombreArchivoPDF, "application/pdf");

                            //decodificar Contenido XML
                            string decodedXmlCFDI = objInfoNomina.xmlCFDI; //Encoding.UTF8.GetString(data);

                            //Crear archivo XML desde un string
                            XmlDocument xdoc = new XmlDocument();
                            xdoc.LoadXml(decodedXmlCFDI);
                            //xdoc.Save(String.Format(@"{0}\{1}_E{2}_{3}{4}.xml", pRutaArchivosCFDI, pObjNomina.rfcTenedora, pObjNomina.numEmpleado, pObjNomina.serieRecibo, pObjNomina.folioRecibo));
                            xdoc.Save(memObjXML);

                            memObjXML.Seek(0, System.IO.SeekOrigin.Begin);
                            Attachment attObjXML = new Attachment(memObjXML, strNombreArchivoXML, "text/xml");

                            // Create a new message and attach the PDF report to it.
                            MailMessage mail = new MailMessage();
                            mail.Attachments.Add(attObjPDF);
                            mail.Attachments.Add(attObjXML);

                            // Specify sender and recipient options for the e-mail message.
                            mail.From = new MailAddress(objConfigCorreo.EmailUser, "Notificaciones Recibos Asimilados");
                            mail.To.Add(new MailAddress(objInfoNomina.correoElectronico));  //destinatario
                            //mail.To.Add(new MailAddress("daniel.sanchez@napoles.mx"));  //destinatario

                            //mail.To.Add(new MailAddress("jose.junco@bpo.mx"));
                            //mail.To.Add(new MailAddress("lilia.avendano@bpo.mx"));
                            //mail.To.Add(new MailAddress("contacto@oblanco.mx"));
                            //mail.To.Add(new MailAddress("alfredo.villegas@bpo.mx"));

                            // Specify other e-mail options.
                            mail.Subject = "Recibo de Asimilados de " + objInfoNomina.nombre;
                            mail.Body = strBody.ToString();

                            //configurar conexion SMTP Server
                            var client = new SmtpClient(objConfigCorreo.SMTPServer, Int16.Parse(objConfigCorreo.Puerto))
                            {
                                Credentials = new NetworkCredential(objConfigCorreo.EmailUser, objConfigCorreo.EmailPassword),
                                EnableSsl = objConfigCorreo.SSL
                            };

                            System.Threading.Thread.Sleep(iDelay_EnvioRecibos);
                            client.Send(mail);  //enviar correo electronico

                            //**********************************************************
                            String sRespuesta = String.Empty;

                            //query que almacena y si es el caso cambia el correo siguiente
                            queriesTableAdapter1.stpUpdContadorCorreo(
                                 Convert.ToInt32(objInfoNomina.IdLoteCargaNomina),
                                Convert.ToInt32(intPDOHeader),
                                objConfigCorreo.IdConfiguracionNotificaciones,
                                1,
                                compCatalogosSAIC.OperadorBD.OperadorGlobal.NombreUsuario,
                                ref sRespuesta);

                            if (!String.IsNullOrEmpty(sRespuesta))
                            {
                                oenvioDeCorreos.sError = sRespuesta;
                                oenvioDeCorreos.iCuantosNOEnviados++;
                                break;
                            }
                            else
                            {
                                oenvioDeCorreos.iCuantosEnviados++;
                            }

                            objConfigCorreo = obtenerDatosCorreoElectronico();
                            //**********************************************************

                            // Close the memory stream.
                            memObjPDF.Close();
                            memObjXML.Close();

                            if (objConfigCorreo == null)
                            {
                                break;
                            }

                        }
                        catch (Exception ex)
                        {
                            this.Cursor = Cursors.Default;      //cambiar cursor del mouse
                            splashScreenManager1.CloseWaitForm();   //quitar pantalla de espera
                            oenvioDeCorreos.sError = string.Format("El envío de Recibo CFDI NO fue exitoso para el Empleado # {0}-{1}.\n\n{2}", objInfoNomina.numEmpleado, objInfoNomina.nombre, ex.Message);
                            objError.existeError = true;
                            objError.noError = -99;
                            objError.mensajeError = ex.Message;
                            oenvioDeCorreos.iCuantosNOEnviados++;
                        }
                    }

                }  //for    

                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }//quitar pantalla de espera                                    
            }

            return oenvioDeCorreos;
        }

        //public envioDeCorreos enviarRecibos(long idLoteCargaNomina, List<long> lstIdPDOHeader, String stPantalla)
        //{
        //    envioDeCorreos oenvioDeCorreos = new envioDeCorreos();
        //    ConfiguracionNotificacion objConfigCorreoEnviarRecivos = obtenerDatosCorreoElectronico(idLoteCargaNomina, stPantalla);
        //    int iConta = 0;

        //    if (objConfigCorreoEnviarRecivos != null)
        //    {
        //        objConfigCorreo = objConfigCorreoEnviarRecivos;

        //        DateTime dtInicioDeEnvios = DateTime.Now;

        //        int.TryParse(validacionesGeneralTableAdapter1.ObtenerValorParametro("DELAY_ENVIODERECIBOS").ToString(), out iDelay_EnvioRecibos);
        //        iDelay_EnvioRecibos = iDelay_EnvioRecibos <= 0 ? 2000 : iDelay_EnvioRecibos;

        //        string bTipoCFDI = "";

        //        int iconta = 0;
        //        Int64 intPDOHeaderMensaje = 0;

        //        splashScreenManager1.ShowWaitForm();        //mostrar pantalla de espera
        //        splashScreenManager1.SetWaitFormCaption("Enviando Recibos");
        //        this.Cursor = Cursors.AppStarting;      //cambiar cursor del mouse
        //        int iContador = 0;

        //        byte iTipoConsulta = 0;
        //        if (stPantalla == "SUELDOS")
        //        {
        //            iTipoConsulta = 7;
        //        }
        //        else if (stPantalla == "ALIMENTOS")
        //        {
        //            iTipoConsulta = 8;
        //        }

        //        this.stpSelRecibosEmpleadosSueldosAsimiladosGenericoCFDIv2TableAdapter.Fill(this.dbSAICBPONominaCFDIDataSet.stpSelRecibosEmpleadosSueldosAsimiladosGenericoCFDIv2, -1, -1, -1, idLoteCargaNomina, 0, iTipoConsulta, OperadorBD.OperadorGlobal.IdOperador);

        //        DataTable dtInfoEmpleado = dbSAICBPONominaCFDIDataSet.stpSelRecibosEmpleadosSueldosAsimiladosGenericoCFDIv2;

        //        foreach (int IdPDOHeader in lstIdPDOHeader)
        //        {
        //            iContador++;
        //            splashSMProcesando1.SetWaitFormDescription(iContador + " de " + lstIdPDOHeader.Count);
        //            //obtener el FolioRecibo seleccionado
        //            Int64 intPDOHeader = IdPDOHeader;
        //            intPDOHeaderMensaje = intPDOHeader;
        //            //obtener informacion del recibo seleccionado
        //            Nomina objInfoNomina = LayoutEmisionCFDIGenericoBD.ObtenerInfoReciboCFDI(dtInfoEmpleado, intPDOHeader);

        //            if (objInfoNomina.IdLoteCargaNomina > 0)
        //            {
        //                Estructuras.InformacionError objError;      //variable que recibe comportamiento de la exportacion
        //                string strNombreArchivoPDF = "";
        //                string strNombreArchivoXML = "";

        //                //RFC Tenedora + Empleado + Serie + Folio Recibo CFDI
        //                strNombreArchivoPDF = String.Format(@"{0}_E{1}_{2}{3}.pdf", objInfoNomina.rfcTenedora, objInfoNomina.numEmpleado, objInfoNomina.serieRecibo, objInfoNomina.folioRecibo);
        //                strNombreArchivoXML = String.Format(@"{0}_E{1}_{2}{3}.xml", objInfoNomina.rfcTenedora, objInfoNomina.numEmpleado, objInfoNomina.serieRecibo, objInfoNomina.folioRecibo);

        //                string sTipoNomina = objInfoNomina.folioLoteCargaNomina.Substring(2, 3);
        //                string sPeriodoInicialNomina = objInfoNomina.folioLoteCargaNomina.Substring(6, 8);
        //                string sPeriodoFinalNomina = objInfoNomina.folioLoteCargaNomina.Substring(15, 8);

        //                MemoryStream memObjPDF = new MemoryStream();
        //                MemoryStream memObjXML = new MemoryStream();
        //                StringBuilder strBody = new StringBuilder();

        //                //integrar Body del Correo Electrónico
        //                strBody.Append("Buen día.\n\n");
        //                strBody.Append("Servicio de entrega de CFDI de recibos electrónicos, emitido y enviado por:\n");
        //                strBody.AppendFormat("RFC: {0}\n", objInfoNomina.rfcTenedora);
        //                strBody.AppendFormat("Razón Social: {0}\n", objInfoNomina.razonSocialTenedora);
        //                strBody.Append("\n");
        //                strBody.Append("Datos CFDI del recibo electrónico:\n");
        //                strBody.AppendFormat("Empleado: {0}-{1} \n", objInfoNomina.numEmpleado, objInfoNomina.nombre);
        //                strBody.AppendFormat("Periodo: {0} al {1} \n", sPeriodoInicialNomina, sPeriodoFinalNomina);
        //                strBody.AppendFormat("UUID: {0}\n", objInfoNomina.renglon5Informativo);       //renglon5Informativo = FolioFiscalUUID
        //                strBody.Append("\n");
        //                strBody.Append("Esta dirección de correo electrónico no admite respuestas. Para obtener más información contacte a su ejecutivo.");

        //                this.seguridadTableAdapter1.stpSelVersionTimbre(objInfoNomina.idTenedora, objInfoNomina.IdLoteCargaNomina, ref bTipoCFDI);

        //                //NOMINAS
        //                if (!sTipoNomina.Equals("ASI"))
        //                {
        //                    if (bTipoCFDI != "4.0")
        //                    {
        //                        // Create a report instance.
        //                        ReportesCFDI.RecibosEmpleadosSueldosCFDI report = new ReportesCFDI.RecibosEmpleadosSueldosCFDI();
        //                        try
        //                        {
        //                            //asignar parametros del reporte
        //                            report.Parameters["pIdLoteCargaNomina"].Value = objInfoNomina.IdLoteCargaNomina;
        //                            report.Parameters["pIdPDOHeader"].Value = intPDOHeader;
        //                            report.Parameters["pTipoMovimientoNomina"].Value = sTipoNomina;    //obtener Tipo Nomina (SEM, QUI, ASI, etc)

        //                            report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes
        //                                                                        // Asignar opciones de Exportacion
        //                            PdfExportOptions pdfOptions = report.ExportOptions.Pdf;
        //                            pdfOptions.Compressed = true;
        //                            pdfOptions.ImageQuality = PdfJpegImageQuality.Highest;
        //                            pdfOptions.NeverEmbeddedFonts = "Tahoma;Courier New";
        //                            //pdfOptions.DocumentOptions.Application = String.Format("{0} {1}", objNominaControlCFDI.SoftwareNombre, objNominaControlCFDI.SoftwareVersion);
        //                            pdfOptions.DocumentOptions.Author = "SAIC Nóminas";
        //                            pdfOptions.DocumentOptions.Keywords = "Recibo, Nómina, CFDI";
        //                            pdfOptions.DocumentOptions.Title = "Recibo Nómina CFDI";

        //                            // Exportar reporte a PDF
        //                            report.ExportToPdf(memObjPDF);

        //                            // Create a new attachment and put the PDF report into it.
        //                            memObjPDF.Seek(0, System.IO.SeekOrigin.Begin);
        //                            Attachment attObjPDF = new Attachment(memObjPDF, strNombreArchivoPDF, "application/pdf");

        //                            //decodificar Contenido XML
        //                            string decodedXmlCFDI = objInfoNomina.xmlCFDI; //Encoding.UTF8.GetString(data);

        //                            //Crear archivo XML desde un string
        //                            XmlDocument xdoc = new XmlDocument();
        //                            xdoc.LoadXml(decodedXmlCFDI);
        //                            //xdoc.Save(String.Format(@"{0}\{1}_E{2}_{3}{4}.xml", pRutaArchivosCFDI, pObjNomina.rfcTenedora, pObjNomina.numEmpleado, pObjNomina.serieRecibo, pObjNomina.folioRecibo));
        //                            xdoc.Save(memObjXML);

        //                            memObjXML.Seek(0, System.IO.SeekOrigin.Begin);
        //                            Attachment attObjXML = new Attachment(memObjXML, strNombreArchivoXML, "text/xml");

        //                            // Create a new message and attach the PDF report to it.
        //                            MailMessage mail = new MailMessage();
        //                            mail.Attachments.Add(attObjPDF);
        //                            mail.Attachments.Add(attObjXML);

        //                            // Specify sender and recipient options for the e-mail message.
        //                            mail.From = new MailAddress(objConfigCorreo.EmailUser, "Notificaciones Recibos Nomina");
        //                            //mail.To.Add(new MailAddress(objInfoNomina.correoElectronico));  //destinatario
        //                            mail.To.Add(new MailAddress("daniel.sanchez@napoles.mx"));  //destinatario

        //                            //mail.To.Add(new MailAddress("daniel.sanchez@napoles.mx"));  //destinatario
        //                            //mail.To.Add(new MailAddress("jose.junco@bpo.mx"));
        //                            //mail.To.Add(new MailAddress("lilia.avendano@bpo.mx"));
        //                            //mail.To.Add(new MailAddress("contacto@oblanco.mx"));
        //                            //mail.To.Add(new MailAddress("alfredo.villegas@bpo.mx"));

        //                            // Specify other e-mail options.
        //                            mail.Subject = "Recibo de Nomina de " + objInfoNomina.nombre;
        //                            mail.Body = strBody.ToString();

        //                            //configurar conexion SMTP Server
        //                            var client = new SmtpClient(objConfigCorreo.SMTPServer, Int16.Parse(objConfigCorreo.Puerto))
        //                            {
        //                                Credentials = new NetworkCredential(objConfigCorreo.EmailUser, objConfigCorreo.EmailPassword),
        //                                EnableSsl = objConfigCorreo.SSL
        //                            };

        //                            //System.Threading.Thread.Sleep(1000);
        //                            //client.Send(mail);  //enviar correo electronico

        //                            String sRespuesta = String.Empty;

        //                            sRespuesta = EnviarCorreo(client, mail, Convert.ToInt32(objInfoNomina.IdLoteCargaNomina), Convert.ToInt32(intPDOHeader), objConfigCorreo.IdConfiguracionNotificaciones);

        //                            if (!String.IsNullOrEmpty(sRespuesta))
        //                            {
        //                                oenvioDeCorreos.sError = sRespuesta;
        //                                oenvioDeCorreos.iCuantosNOEnviados++;
        //                                break;
        //                            }
        //                            else
        //                            {
        //                                oenvioDeCorreos.iCuantosEnviados++;
        //                            }

        //                            objConfigCorreo = obtenerDatosCorreoElectronico(objInfoNomina.IdLoteCargaNomina, stPantalla);

        //                            // Close the memory stream.
        //                            memObjPDF.Close();
        //                            memObjXML.Close();

        //                            if (objConfigCorreo == null)
        //                            {
        //                                oenvioDeCorreos.iCuantosNOEnviados++;
        //                                break;
        //                            }
        //                            //System.Threading.Thread.Sleep(iDelay_EnvioRecibos);
        //                        }
        //                        catch (Exception ex)
        //                        {
        //                            this.Cursor = Cursors.Default;      //cambiar cursor del mouse
        //                            splashScreenManager1.CloseWaitForm();   //quitar pantalla de espera
        //                            oenvioDeCorreos.sError = string.Format("{0}.\n\n¡El envío de Recibos CFDI NO fue exitoso!", ex.Message);
        //                            objError.existeError = true;
        //                            objError.noError = -99;
        //                            objError.mensajeError = ex.Message;
        //                            oenvioDeCorreos.iCuantosNOEnviados++;
        //                            break;
        //                        }
        //                    }
        //                    else
        //                    {
        //                        // Create a report instance.
        //                        ReportesCFDI.RecibosEmpleadosSueldosCFDIv4 report = new ReportesCFDI.RecibosEmpleadosSueldosCFDIv4();
        //                        try
        //                        {
        //                            //asignar parametros del reporte
        //                            report.Parameters["pIdLoteCargaNomina"].Value = objInfoNomina.IdLoteCargaNomina;
        //                            report.Parameters["pIdPDOHeader"].Value = intPDOHeader;
        //                            report.Parameters["pTipoMovimientoNomina"].Value = sTipoNomina;    //obtener Tipo Nomina (SEM, QUI, ASI, etc)

        //                            report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes
        //                                                                        // Asignar opciones de Exportacion
        //                            PdfExportOptions pdfOptions = report.ExportOptions.Pdf;
        //                            pdfOptions.Compressed = true;
        //                            pdfOptions.ImageQuality = PdfJpegImageQuality.Highest;
        //                            pdfOptions.NeverEmbeddedFonts = "Tahoma;Courier New";
        //                            //pdfOptions.DocumentOptions.Application = String.Format("{0} {1}", objNominaControlCFDI.SoftwareNombre, objNominaControlCFDI.SoftwareVersion);
        //                            pdfOptions.DocumentOptions.Author = "SAIC Nóminas";
        //                            pdfOptions.DocumentOptions.Keywords = "Recibo, Nómina, CFDI";
        //                            pdfOptions.DocumentOptions.Title = "Recibo Nómina CFDI";

        //                            // Exportar reporte a PDF
        //                            report.ExportToPdf(memObjPDF);

        //                            // Create a new attachment and put the PDF report into it.
        //                            memObjPDF.Seek(0, System.IO.SeekOrigin.Begin);
        //                            Attachment attObjPDF = new Attachment(memObjPDF, strNombreArchivoPDF, "application/pdf");

        //                            //decodificar Contenido XML
        //                            string decodedXmlCFDI = objInfoNomina.xmlCFDI; //Encoding.UTF8.GetString(data);

        //                            //Crear archivo XML desde un string
        //                            XmlDocument xdoc = new XmlDocument();
        //                            xdoc.LoadXml(decodedXmlCFDI);
        //                            //xdoc.Save(String.Format(@"{0}\{1}_E{2}_{3}{4}.xml", pRutaArchivosCFDI, pObjNomina.rfcTenedora, pObjNomina.numEmpleado, pObjNomina.serieRecibo, pObjNomina.folioRecibo));
        //                            xdoc.Save(memObjXML);

        //                            memObjXML.Seek(0, System.IO.SeekOrigin.Begin);
        //                            Attachment attObjXML = new Attachment(memObjXML, strNombreArchivoXML, "text/xml");

        //                            // Create a new message and attach the PDF report to it.
        //                            MailMessage mail = new MailMessage();
        //                            mail.Attachments.Add(attObjPDF);
        //                            mail.Attachments.Add(attObjXML);

        //                            // Specify sender and recipient options for the e-mail message.
        //                            mail.From = new MailAddress(objConfigCorreo.EmailUser, "Notificaciones Recibos Nomina");
        //                            //mail.To.Add(new MailAddress(objInfoNomina.correoElectronico));  //destinatario
        //                            mail.To.Add(new MailAddress("daniel.sanchez@napoles.mx"));  //destinatario
        //                                                                                        //mail.To.Add(new MailAddress(objInfoNomina.correoElectronico));  //destinatario
        //                                                                                        //mail.To.Add(new MailAddress("daniel.sanchez@napoles.mx"));  //destinatario
        //                                                                                        //mail.To.Add(new MailAddress("jose.junco@bpo.mx"));
        //                                                                                        //mail.To.Add(new MailAddress("lilia.avendano@bpo.mx"));
        //                                                                                        //mail.To.Add(new MailAddress("contacto@oblanco.mx"));
        //                                                                                        //mail.To.Add(new MailAddress("alfredo.villegas@bpo.mx"));

        //                            // Specify other e-mail options.
        //                            mail.Subject = "Recibo de Nomina de " + objInfoNomina.nombre;
        //                            mail.Body = strBody.ToString();

        //                            //configurar conexion SMTP Server
        //                            var client = new SmtpClient(objConfigCorreo.SMTPServer, Int16.Parse(objConfigCorreo.Puerto))
        //                            {
        //                                Credentials = new NetworkCredential(objConfigCorreo.EmailUser, objConfigCorreo.EmailPassword),
        //                                EnableSsl = objConfigCorreo.SSL
        //                            };

        //                            //System.Threading.Thread.Sleep(1000);
        //                            //client.Send(mail);  //enviar correo electronico

        //                            String sRespuesta = String.Empty;

        //                            sRespuesta = EnviarCorreo(client, mail, Convert.ToInt32(objInfoNomina.IdLoteCargaNomina), Convert.ToInt32(intPDOHeader), objConfigCorreo.IdConfiguracionNotificaciones);

        //                            if (!String.IsNullOrEmpty(sRespuesta))
        //                            {
        //                                oenvioDeCorreos.sError = sRespuesta;
        //                                oenvioDeCorreos.iCuantosNOEnviados++;
        //                                break;
        //                            }
        //                            else
        //                            {
        //                                oenvioDeCorreos.iCuantosEnviados++;
        //                            }

        //                            objConfigCorreo = obtenerDatosCorreoElectronico(objInfoNomina.IdLoteCargaNomina, stPantalla);

        //                            // Close the memory stream.
        //                            memObjPDF.Close();
        //                            memObjXML.Close();

        //                            if (objConfigCorreo == null)
        //                            {
        //                                oenvioDeCorreos.iCuantosNOEnviados++;
        //                                break;
        //                            }

        //                        }
        //                        catch (Exception ex)
        //                        {
        //                            this.Cursor = Cursors.Default;      //cambiar cursor del mouse
        //                            splashScreenManager1.CloseWaitForm();   //quitar pantalla de espera
        //                            oenvioDeCorreos.sError = string.Format("{0}.\n\n¡El envío de Recibos CFDI NO fue exitoso!", ex.Message);
        //                            objError.existeError = true;
        //                            objError.noError = -99;
        //                            objError.mensajeError = ex.Message;
        //                            oenvioDeCorreos.iCuantosNOEnviados++;
        //                            break;
        //                        }
        //                    }
        //                }
        //                else    //ASIMILADOS
        //                {
        //                    if (bTipoCFDI != "4.0")
        //                    {
        //                        // Create a report instance.
        //                        ReportesCFDI.RecibosAsimiladosSalariosCFDI report = new ReportesCFDI.RecibosAsimiladosSalariosCFDI();
        //                        try
        //                        {
        //                            //asignar parametros del reporte
        //                            report.Parameters["pIdLoteCargaNomina"].Value = objInfoNomina.IdLoteCargaNomina;
        //                            report.Parameters["pIdPDOHeader"].Value = intPDOHeader;
        //                            report.Parameters["pTipoMovimientoNomina"].Value = sTipoNomina;    //obtener Tipo Nomina (SEM, QUI, ASI, etc)

        //                            report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes
        //                                                                        // Asignar opciones de Exportacion
        //                            PdfExportOptions pdfOptions = report.ExportOptions.Pdf;
        //                            pdfOptions.Compressed = true;
        //                            pdfOptions.ImageQuality = PdfJpegImageQuality.Highest;
        //                            pdfOptions.NeverEmbeddedFonts = "Tahoma;Courier New";
        //                            //pdfOptions.DocumentOptions.Application = String.Format("{0} {1}", objNominaControlCFDI.SoftwareNombre, objNominaControlCFDI.SoftwareVersion);
        //                            pdfOptions.DocumentOptions.Author = "SAIC Asimilados";
        //                            pdfOptions.DocumentOptions.Keywords = "Recibo, Asimilados, CFDI";
        //                            pdfOptions.DocumentOptions.Title = "Recibo Asimilados CFDI";

        //                            // Exportar reporte a PDF
        //                            report.ExportToPdf(memObjPDF);

        //                            // Create a new attachment and put the PDF report into it.
        //                            memObjPDF.Seek(0, System.IO.SeekOrigin.Begin);
        //                            Attachment attObjPDF = new Attachment(memObjPDF, strNombreArchivoPDF, "application/pdf");

        //                            //decodificar Contenido XML
        //                            string decodedXmlCFDI = objInfoNomina.xmlCFDI; //Encoding.UTF8.GetString(data);

        //                            //Crear archivo XML desde un string
        //                            XmlDocument xdoc = new XmlDocument();
        //                            xdoc.LoadXml(decodedXmlCFDI);
        //                            //xdoc.Save(String.Format(@"{0}\{1}_E{2}_{3}{4}.xml", pRutaArchivosCFDI, pObjNomina.rfcTenedora, pObjNomina.numEmpleado, pObjNomina.serieRecibo, pObjNomina.folioRecibo));
        //                            xdoc.Save(memObjXML);

        //                            memObjXML.Seek(0, System.IO.SeekOrigin.Begin);
        //                            Attachment attObjXML = new Attachment(memObjXML, strNombreArchivoXML, "text/xml");

        //                            // Create a new message and attach the PDF report to it.
        //                            MailMessage mail = new MailMessage();
        //                            mail.Attachments.Add(attObjPDF);
        //                            mail.Attachments.Add(attObjXML);

        //                            // Specify sender and recipient options for the e-mail message.
        //                            mail.From = new MailAddress(objConfigCorreo.EmailUser, "Notificaciones Recibos Asimilados");
        //                            //mail.To.Add(new MailAddress(objInfoNomina.correoElectronico));  //destinatario
        //                            mail.To.Add(new MailAddress("daniel.sanchez@napoles.mx"));  //destinatario

        //                            //mail.To.Add(new MailAddress("daniel.sanchez@napoles.mx"));  //destinatario
        //                            //mail.To.Add(new MailAddress("jose.junco@bpo.mx"));
        //                            //mail.To.Add(new MailAddress("lilia.avendano@bpo.mx"));
        //                            //mail.To.Add(new MailAddress("contacto@oblanco.mx"));
        //                            //mail.To.Add(new MailAddress("alfredo.villegas@bpo.mx"));

        //                            // Specify other e-mail options.
        //                            mail.Subject = "Recibo de Asimilados de " + objInfoNomina.nombre;
        //                            mail.Body = strBody.ToString();

        //                            //configurar conexion SMTP Server
        //                            var client = new SmtpClient(objConfigCorreo.SMTPServer, Int16.Parse(objConfigCorreo.Puerto))
        //                            {
        //                                Credentials = new NetworkCredential(objConfigCorreo.EmailUser, objConfigCorreo.EmailPassword),
        //                                EnableSsl = objConfigCorreo.SSL
        //                            };

        //                            //client.Send(mail);  //enviar correo electronico
        //                            //**********************************************************
        //                            String sRespuesta = String.Empty;

        //                            sRespuesta = EnviarCorreo(client, mail, Convert.ToInt32(objInfoNomina.IdLoteCargaNomina), Convert.ToInt32(intPDOHeader), objConfigCorreo.IdConfiguracionNotificaciones);

        //                            if (!String.IsNullOrEmpty(sRespuesta))
        //                            {
        //                                oenvioDeCorreos.sError = sRespuesta;
        //                                oenvioDeCorreos.iCuantosNOEnviados++;
        //                                break;
        //                            }
        //                            else
        //                            {
        //                                oenvioDeCorreos.iCuantosEnviados++;
        //                            }

        //                            objConfigCorreo = obtenerDatosCorreoElectronico(objInfoNomina.IdLoteCargaNomina, stPantalla);
        //                            //**********************************************************

        //                            // Close the memory stream.
        //                            memObjPDF.Close();
        //                            memObjXML.Close();

        //                            if (objConfigCorreo == null)
        //                            {
        //                                oenvioDeCorreos.iCuantosNOEnviados++;
        //                                break;
        //                            }

        //                        }
        //                        catch (Exception ex)
        //                        {
        //                            this.Cursor = Cursors.Default;      //cambiar cursor del mouse
        //                            splashScreenManager1.CloseWaitForm();   //quitar pantalla de espera
        //                            oenvioDeCorreos.sError = string.Format("El envío de Recibo CFDI NO fue exitoso para el Empleado # {0}-{1}.\n\n{2}", objInfoNomina.numEmpleado, objInfoNomina.nombre, ex.Message);
        //                            objError.existeError = true;
        //                            objError.noError = -99;
        //                            objError.mensajeError = ex.Message;
        //                            oenvioDeCorreos.iCuantosNOEnviados++;
        //                            break;
        //                        }
        //                    }// if
        //                    else
        //                    {
        //                        // Create a report instance.
        //                        ReportesCFDI.RecibosAsimiladosSalariosCFDIv4 report = new ReportesCFDI.RecibosAsimiladosSalariosCFDIv4();
        //                        try
        //                        {
        //                            //asignar parametros del reporte
        //                            report.Parameters["pIdLoteCargaNomina"].Value = objInfoNomina.IdLoteCargaNomina;
        //                            report.Parameters["pIdPDOHeader"].Value = intPDOHeader;
        //                            report.Parameters["pTipoMovimientoNomina"].Value = sTipoNomina;    //obtener Tipo Nomina (SEM, QUI, ASI, etc)

        //                            report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes
        //                                                                        // Asignar opciones de Exportacion
        //                            PdfExportOptions pdfOptions = report.ExportOptions.Pdf;
        //                            pdfOptions.Compressed = true;
        //                            pdfOptions.ImageQuality = PdfJpegImageQuality.Highest;
        //                            pdfOptions.NeverEmbeddedFonts = "Tahoma;Courier New";
        //                            //pdfOptions.DocumentOptions.Application = String.Format("{0} {1}", objNominaControlCFDI.SoftwareNombre, objNominaControlCFDI.SoftwareVersion);
        //                            pdfOptions.DocumentOptions.Author = "SAIC Asimilados";
        //                            pdfOptions.DocumentOptions.Keywords = "Recibo, Asimilados, CFDI";
        //                            pdfOptions.DocumentOptions.Title = "Recibo Asimilados CFDI";

        //                            // Exportar reporte a PDF
        //                            report.ExportToPdf(memObjPDF);

        //                            // Create a new attachment and put the PDF report into it.
        //                            memObjPDF.Seek(0, System.IO.SeekOrigin.Begin);
        //                            Attachment attObjPDF = new Attachment(memObjPDF, strNombreArchivoPDF, "application/pdf");

        //                            //decodificar Contenido XML
        //                            string decodedXmlCFDI = objInfoNomina.xmlCFDI; //Encoding.UTF8.GetString(data);

        //                            //Crear archivo XML desde un string
        //                            XmlDocument xdoc = new XmlDocument();
        //                            xdoc.LoadXml(decodedXmlCFDI);
        //                            //xdoc.Save(String.Format(@"{0}\{1}_E{2}_{3}{4}.xml", pRutaArchivosCFDI, pObjNomina.rfcTenedora, pObjNomina.numEmpleado, pObjNomina.serieRecibo, pObjNomina.folioRecibo));
        //                            xdoc.Save(memObjXML);

        //                            memObjXML.Seek(0, System.IO.SeekOrigin.Begin);
        //                            Attachment attObjXML = new Attachment(memObjXML, strNombreArchivoXML, "text/xml");

        //                            // Create a new message and attach the PDF report to it.
        //                            MailMessage mail = new MailMessage();
        //                            mail.Attachments.Add(attObjPDF);
        //                            mail.Attachments.Add(attObjXML);

        //                            // Specify sender and recipient options for the e-mail message.
        //                            mail.From = new MailAddress(objConfigCorreo.EmailUser, "Notificaciones Recibos Asimilados");
        //                            //mail.To.Add(new MailAddress(objInfoNomina.correoElectronico));  //destinatario
        //                            mail.To.Add(new MailAddress("daniel.sanchez@napoles.mx"));  //destinatario
        //                                                                                        //mail.To.Add(new MailAddress("daniel.sanchez@napoles.mx"));  //destinatario

        //                            //mail.To.Add(new MailAddress("jose.junco@bpo.mx"));
        //                            //mail.To.Add(new MailAddress("lilia.avendano@bpo.mx"));
        //                            //mail.To.Add(new MailAddress("contacto@oblanco.mx"));
        //                            //mail.To.Add(new MailAddress("alfredo.villegas@bpo.mx"));

        //                            // Specify other e-mail options.
        //                            mail.Subject = "Recibo de Asimilados de " + objInfoNomina.nombre;
        //                            mail.Body = strBody.ToString();

        //                            //configurar conexion SMTP Server
        //                            var client = new SmtpClient(objConfigCorreo.SMTPServer, Int16.Parse(objConfigCorreo.Puerto))
        //                            {
        //                                Credentials = new NetworkCredential(objConfigCorreo.EmailUser, objConfigCorreo.EmailPassword),
        //                                EnableSsl = objConfigCorreo.SSL
        //                            };

        //                            //client.Send(mail);  //enviar correo electronico
        //                            //**********************************************************
        //                            String sRespuesta = String.Empty;

        //                            sRespuesta = EnviarCorreo(client, mail, Convert.ToInt32(objInfoNomina.IdLoteCargaNomina), Convert.ToInt32(intPDOHeader), objConfigCorreo.IdConfiguracionNotificaciones);

        //                            if (!String.IsNullOrEmpty(sRespuesta))
        //                            {
        //                                oenvioDeCorreos.sError = sRespuesta;
        //                                oenvioDeCorreos.iCuantosNOEnviados++;
        //                                break;
        //                            }
        //                            else
        //                            {
        //                                oenvioDeCorreos.iCuantosEnviados++;
        //                            }

        //                            objConfigCorreo = obtenerDatosCorreoElectronico(objInfoNomina.IdLoteCargaNomina, stPantalla);
        //                            //**********************************************************

        //                            // Close the memory stream.
        //                            memObjPDF.Close();
        //                            memObjXML.Close();

        //                            if (objConfigCorreo == null)
        //                            {
        //                                oenvioDeCorreos.iCuantosNOEnviados++;
        //                                break;
        //                            }

        //                        }
        //                        catch (Exception ex)
        //                        {
        //                            this.Cursor = Cursors.Default;      //cambiar cursor del mouse
        //                            splashScreenManager1.CloseWaitForm();   //quitar pantalla de espera
        //                            oenvioDeCorreos.sError = string.Format("El envío de Recibo CFDI NO fue exitoso para el Empleado # {0}-{1}.\n\n{2}", objInfoNomina.numEmpleado, objInfoNomina.nombre, ex.Message);
        //                            objError.existeError = true;
        //                            objError.noError = -99;
        //                            objError.mensajeError = ex.Message;
        //                            oenvioDeCorreos.iCuantosNOEnviados++;
        //                        }
        //                    }
        //                }
        //            }
        //            else
        //            {
        //                oenvioDeCorreos.iCuantosNOEnviados++;
        //            }

        //        }  //for

        //        if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }//quitar pantalla de espera
        //    }
        //    return oenvioDeCorreos;
        //}


    }


    public class envioDeCorreos
    {
        public int iCuantosEnviados { get; set; }
        public int iCuantosNOEnviados { get; set; }
        public String sError { get; set; }

        public envioDeCorreos()
        {
            iCuantosEnviados = 0;
            iCuantosNOEnviados = 0;
            sError = String.Empty;
        }
    }


}
