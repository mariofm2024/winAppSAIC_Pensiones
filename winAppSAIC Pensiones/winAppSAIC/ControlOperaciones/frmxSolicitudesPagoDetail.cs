using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using winAppSAIC.UtileriasLocal;
using System.Diagnostics;
using compCatalogosSAIC;
using compLibreriaSAIC;
using winAppSAIC.Reportes;
using DevExpress.XtraReports.UI;        //namespace a partir version 12.2.4
using winAppSAIC.ReportesCFDI;
using DevExpress.XtraPrinting;
using compLayoutBancos;


namespace winAppSAIC.ControlOperaciones
{
    public partial class frmxSolicitudesPagoDetail : DevExpress.XtraEditors.XtraForm
    {
        List<String> lstErroresLayOuts = new List<String>();

        public Int64 IdSolicitud;
        public Int64 IdControl;
        public string FechaPago;
        public string Cliente;
        public string Operador;

        tools.dsc dsc = new tools.dsc();
        short shNoSecuencialArchivo;
        short shNoSecuencialArchivo_IAS;
        string RespuestaLeyout = "";
        bool Autorizacion = false;
        string pTope1 = "60";
        string pTope2 = "120";
        string strRutaArchivosXML = "";
        decimal ? pSaldo = 0;

        public frmxSolicitudesPagoDetail()
        {
            InitializeComponent();
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void ActivarBotones()
        {
            if (!Autorizacion)
            {
                btnConfirmar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnCargar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnAnularPago.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
        }

        private void btnConfirmar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Int64 Id = 0;
            string pIdOk = "";
            string pErrores = "";
            try
            {
                if (dgvSolicitudDetail.SelectedRowsCount > 0)
                {
                    foreach (var item in dgvSolicitudDetail.GetSelectedRows())
                    {
                        DataRow Row = dgvSolicitudDetail.GetDataRow(item);
                        Id = Convert.ToInt64(Row[0]);

                        spSoloRespuesta1.stpTesUpdSolicitudPagoDetail(IdSolicitud, Id, 34, "", OperadorBD.OperadorGlobal.NombreUsuario, ref pIdOk);

                        if (pIdOk.Contains("Cerrar:"))
                        {
                            Facturas.frmCierreControl objAsignarXML = new Facturas.frmCierreControl()
                            {
                                pIdControl = Convert.ToInt64(pIdOk.Replace("Cerrar:", "")),
                                pFLAG = true,
                                pBoton = false
                            };
                            objAsignarXML.ShowDialog();     //mostrar pantalla
                        }
                        else if (pIdOk == "")
                            pErrores = pErrores + "El Detalle No. " + Id + "\r\n";
                    }
                    if (pErrores == "")
                        XtraMessageBox.Show("¡El(Los) detalle(s) se Actualizo(aron) Correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("¡Error en el(los) detalle(s)\n" + pErrores + "No se Actualizo(ron), intentelo mas tarde!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.stpTesSelSolicitudPagoDetailTableAdapter.Fill(this.dbSAICBPOFactura.stpTesSelSolicitudPagoDetail, IdSolicitud, OperadorBD.OperadorGlobal.IdOperador);
                }
                else
                    XtraMessageBox.Show("¡Debe de Seleccionar por lo menos una solicitud!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Int64 Id = 0;
            string pIdOk = "";
            string pError = "Cancelar";
            try
            {
                if (dgvSolicitudDetail.SelectedRowsCount == 1)
                {
                    foreach (var item in dgvSolicitudDetail.GetSelectedRows())
                    {
                        DataRow Row = dgvSolicitudDetail.GetDataRow(item);
                        Id = Convert.ToInt64(Row[0]);


                        if (Row[7].ToString().Contains("PAGO") || Row[7].ToString().Contains("PAGADA"))
                        {
                            String stRutaContrato = String.Empty;
                            String stValorDocumento = String.Empty;

                            OpenFileDialog ofdSelecFile = new OpenFileDialog();
                            ofdSelecFile.Filter = "Pdf Files| *.pdf";
                            ofdSelecFile.Title = "SAIC | Seleccione Comprobante";
                            ofdSelecFile.Multiselect = true;

                            ofdSelecFile.ShowDialog();

                            foreach (string str3 in ofdSelecFile.FileNames)
                            {
                                pError = "";
                                stRutaContrato = str3;
                                if (!String.IsNullOrEmpty(stRutaContrato))
                                {
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
                                                spSoloRespuesta1.stpTesInsSolicitudPagoDetailRecibo(Id, stValorDocumento, OperadorBD.OperadorGlobal.NombreUsuario, OperadorBD.OperadorGlobal.IdOperador, ref pIdOk);

                                                if (pIdOk == "")
                                                {
                                                    pError = pError + "Archivo: " + str3 + "\r\n";
                                                }
                                            }
                                            else
                                            {
                                                XtraMessageBox.Show("El Archivo no debe exceder de " + dbSAICBPOValidacionDataSet1.stpSelParametro.Rows[0]["ValorParametro"].ToString() + " KB"
                                                  , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                        }
                                        else
                                        {
                                            DialogResult resultado = XtraMessageBox.Show("No se tiene valor de limite para archivos."
                                             , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                    else
                                    {
                                        XtraMessageBox.Show("No se puede convertir el Archivo para Subir.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }

                            if (pError != "Cancelar")
                            {
                                if (pError != "")
                                {
                                    XtraMessageBox.Show("¡Error los archivos que marcaron error son: \r\n " + pError + " Intente mas tarde!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                    XtraMessageBox.Show("!Los archivos se subieron Correctamente!", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.stpTesSelSolicitudPagoDetailTableAdapter.Fill(this.dbSAICBPOFactura.stpTesSelSolicitudPagoDetail, IdSolicitud, OperadorBD.OperadorGlobal.IdOperador);
                            }

                        }
                        else
                            XtraMessageBox.Show("El Detalle debe de estar en Estatus Pagado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    XtraMessageBox.Show("¡Debe de Seleccionar una solicitud!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmxSolicitudesPagoDetail_Load(object sender, EventArgs e)
        {
            try
            {
                splashSMCargando.ShowWaitForm();
                this.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1.Fill(this.dbSAICBPOFactura.stpFactSelDerechosAccesoOperadorFacturacion, OperadorBD.OperadorGlobal.IdOperador, "ControlOperaciones.frmxSolicitudesPago", "rbiSolicitudPago");

                if (this.dbSAICBPOFactura.stpFactSelDerechosAccesoOperadorFacturacion.Count > 0)
                {
                    DataRow row = this.dbSAICBPOFactura.stpFactSelDerechosAccesoOperadorFacturacion.Rows[0];
                    Autorizacion = (bool)row[15];
                    row = null;
                }
                else
                {
                    Autorizacion = false;
                }

                pTope1 = this.validacionesGeneralTableAdapter1.ObtenerValorParametro("TOPE1").ToString();
                pTope2 = this.validacionesGeneralTableAdapter1.ObtenerValorParametro("TOPE2").ToString();


                ActivarBotones();

                this.stpTesSelSolicitudPagoDetailTableAdapter.Fill(this.dbSAICBPOFactura.stpTesSelSolicitudPagoDetail, IdSolicitud, OperadorBD.OperadorGlobal.IdOperador);

                splashSMCargando.CloseWaitForm();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                splashSMCargando.CloseWaitForm();
            }

        }

        private void btnDescargar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string sRutaArchivos = "";
                string sRutaArchivosCFDI = "";
                Int64 Id = 0;
                Int32 pTotal = 0;
                bool bFlag = true;

                //obtener la ruta RAIZ en dónde se almacenarán los archivos PDF y XML
                string strRutaArchivosXML = this.validacionesGeneralTableAdapter1.ObtenerValorParametro("FOLDER_COMPROBANTES").ToString();

                //obtener el renglon completo del Combobox
                if (dgvSolicitudDetail.SelectedRowsCount > 0)
                {
                    foreach (var item in dgvSolicitudDetail.GetSelectedRows())
                    {
                        DataRow row = dgvSolicitudDetail.GetDataRow(item);
                        Id = Convert.ToInt64(row[0]);

                        this.stpFactSelComprobanteSolicitudesTableAdapter.Fill(this.dbSAICBPOFactura.stpFactSelComprobanteSolicitudes, Convert.ToInt64(row[0].ToString()));

                        for (int i = 0; i < this.dbSAICBPOFactura.stpFactSelComprobanteSolicitudes.Rows.Count; i++)
                        {
                            if (bFlag)
                            {
                                sRutaArchivos = compNominaCFDI.AccesoIO.ValidarCrearDirectorioCPago(strRutaArchivosXML, IdSolicitud.ToString(), compNominaCFDI.AccesoIO.ISO_Date());
                                bFlag = false;
                            }

                            DataRow Row1 = this.dbSAICBPOFactura.stpFactSelComprobanteSolicitudes.Rows[i];
                            Id = Convert.ToInt64(Row1[0]);

                            if (Row1 != null)
                            {
                                if (Row1[1].ToString().Length > 3)
                                {
                                    Byte[] bytes = Convert.FromBase64String(Row1[1].ToString());
                                    //Generar carpeta para colocar archivos XML
                                    sRutaArchivosCFDI = string.Format(@"{0}\COMPROBANTE_PAGO_{1}.pdf", sRutaArchivos, Row1[2].ToString());
                                    File.WriteAllBytes(sRutaArchivosCFDI, bytes);
                                }
                            }
                            pTotal = pTotal + 1;
                        }
                    }
                    if (pTotal > 0)
                        XtraMessageBox.Show("¡El proceso ha terminado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("¡El(los) detalle(s) no cuentan con Comprobantes!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    XtraMessageBox.Show("¡Debe de Seleccionar una Solicitud!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCarpeta_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ProcessStartInfo StartInformation = new ProcessStartInfo();
            StartInformation.FileName = @"C:\Comprobantes\";
            Process process = Process.Start(StartInformation);
        }


        private void btnAnularPago_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Int64 Id = 0;
            string pIdOk = "";
            string pErrores = "";
            try
            {
                if (dgvSolicitudDetail.SelectedRowsCount > 0)
                {
                    foreach (var item in dgvSolicitudDetail.GetSelectedRows())
                    {
                        DataRow Row = dgvSolicitudDetail.GetDataRow(item);
                        Id = Convert.ToInt64(Row[0]);

                        spSoloRespuesta1.stpTesUpdSolicitudPagoDetail(IdSolicitud, Id, 15, "", OperadorBD.OperadorGlobal.NombreUsuario, ref pIdOk);

                        if (pIdOk == "")
                            pErrores = pErrores + "El Detalle No. " + Id + "\r\n";
                    }
                    if (pErrores == "")
                        XtraMessageBox.Show("¡El(Los) detalle(s) se Actualizo(aron) Correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("¡Error en el(los) detalle(s)\n" + pErrores + "No se Actualizo(ron), intentelo mas tarde!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.stpTesSelSolicitudPagoDetailTableAdapter.Fill(this.dbSAICBPOFactura.stpTesSelSolicitudPagoDetail, IdSolicitud, OperadorBD.OperadorGlobal.IdOperador);
                }
                else
                    XtraMessageBox.Show("¡Debe de Seleccionar por lo menos una solicitud!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDescargarC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Estructuras.InformacionError objError;      //variable que recibe comportamiento de la exportacion
            try
            {
                lstErroresLayOuts.Clear();
                Int64 pIdPago = 0;
                Int64 IdLoteCargaNomina = 0;
                string SpNombre = "";
                string SpNomina = "";
                string SpTipo = "";
                bool? pOk = false;
                Int32 pIdLey = 0;

                DataRow row = null;

                splashSMCargando.ShowWaitForm();

                //obtener la ruta RAIZ en dónde se almacenarán los archivos PDF y XML
                strRutaArchivosXML = this.validacionesGeneralTableAdapter1.ObtenerValorParametro("FOLDER_SOLICITUD_PAGO").ToString();

                //strRutaArchivosXML = compNominaCFDI.AccesoIO.ValidarCrearDirectorioCPago(strRutaArchivosXML, IdSolicitud.ToString(), compNominaCFDI.AccesoIO.ISO_Date());
                strRutaArchivosXML = compNominaCFDI.AccesoIO.ValidarCrearDirectorioControlP(strRutaArchivosXML, IdControl.ToString() + "_" + FechaPago + "_" + Cliente ,Operador);

                this.spSoloRespuesta1.stpFactSelDetailCOSaldo(IdControl, ref pSaldo);

                SpNombre = string.Format(@"{0}\CONTROL_OPERACIONES_{1}.pdf", strRutaArchivosXML, IdControl.ToString());
                objError = MostrarReporte(IdControl, SpNombre);

                this.stpTesSelSolicitudPagoDetailLayoutTableAdapter.Fill(dbSAICBPOTesoreriaDataSet.stpTesSelSolicitudPagoDetailLayout, IdSolicitud, OperadorBD.OperadorGlobal.IdOperador);
                this.stpTesSelSolicitudPagoDetailLayoutTableAdapter1.Fill(dbSAICAsimilados.stpTesSelSolicitudPagoDetailLayout, IdSolicitud, OperadorBD.OperadorGlobal.IdOperador);
                this.stpTesSelFacturasControlTableAdapter.Fill(dbSAICBPOFactura.stpTesSelFacturasControl, IdControl, OperadorBD.OperadorGlobal.IdOperador);

                if (objError.existeError == false)
                {
                    for (int i = 0; i < dgvSolicitudDetail.RowCount; i++)
                    {
                        row = dgvSolicitudDetail.GetDataRow(i);
                        if (row != null)
                        {
                            pIdPago = Convert.ToInt64(row[0].ToString());
                            IdLoteCargaNomina = Convert.ToInt64(row[17].ToString());
                            SpNomina = row[18].ToString();
                            SpTipo = row[2].ToString();

                            this.Cursor = Cursors.AppStarting;      //cambiar cursor del mouse
                            if (SpNomina == "S")
                            {
                                SpNombre = string.Format(@"{0}\LOTE_SA_{1}.pdf", strRutaArchivosXML, IdLoteCargaNomina.ToString());
                                objError = MostrarReporteNominaSA(IdLoteCargaNomina, SpNombre);
                                pIdLey = pIdLey + 1;
                            }
                            else if (SpNomina == "A")
                            {
                                SpNombre = string.Format(@"{0}\LOTE_SC_{1}.pdf", strRutaArchivosXML, IdLoteCargaNomina.ToString());
                                objError = MostrarReporteAlimentosSC(IdLoteCargaNomina, SpNombre);
                                pIdLey = pIdLey + 1;
                            }

                            if (SpTipo == "ASIMILADOS")
                            {
                                this.stpTesSelLotesControlTableAdapter.Fill(this.dbSAICAsimilados.stpTesSelLotesControl, IdControl, OperadorBD.OperadorGlobal.IdOperador);
                                for (int i1 = 0; i1 < this.dbSAICAsimilados.stpTesSelLotesControl.Rows.Count; i1++)
                                {
                                    row = this.dbSAICAsimilados.stpTesSelLotesControl.Rows[i1];
                                    if (row != null)
                                    {
                                        SpNombre = string.Format(@"{0}\LOTE_ASIMILADOS_{1}.pdf", strRutaArchivosXML, row[0].ToString());
                                        objError = MostrarReporteAsimilados(Convert.ToInt64(row[0].ToString()), SpNombre);
                                    }
                                }
                            }
                            this.Cursor = Cursors.Default;      //cambiar cursor del mouse
                        }
                    }

                    //generar Layouts de Sueldos y Alimentos
                    DescargaLayout(IdSolicitud, 0, dbSAICBPOTesoreriaDataSet.stpTesSelSolicitudPagoDetailLayout);

                    //generar Layouts de Asimilados
                    DescargaLayoutAsimilados(IdSolicitud, 0, dbSAICAsimilados.stpTesSelSolicitudPagoDetailLayout);


                    for (int i1 = 0; i1 < this.dbSAICBPOFactura.stpTesSelFacturasControl.Rows.Count; i1++)
                    {
                        row = this.dbSAICBPOFactura.stpTesSelFacturasControl.Rows[i1];
                        if (row != null)
                        {
                            MostrarFacturas(Convert.ToInt64(row[0].ToString()), strRutaArchivosXML, row[1].ToString(), Convert.ToInt16(row[2].ToString()));
                        }
                    }

                    splashSMCargando.CloseWaitForm();

                    if (lstErroresLayOuts.Count > 0)
                    {
                        DialogResult oDialogResult = XtraMessageBox.Show("¡Proceso Terminado con incidencias. Los Archivos se encuentran en: " + strRutaArchivosXML + Environment.NewLine + "¿Desea abrir las indicendias?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (oDialogResult == DialogResult.Yes)
                        {
                            String sNombreErroresLayOut = strRutaArchivosXML + @"\C" + IdSolicitud + "_incidencias " + dsc.nombreAleatorio() + ".txt";
                            File.WriteAllLines(sNombreErroresLayOut, lstErroresLayOuts);
                            Process.Start(sNombreErroresLayOut);
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("¡Proceso Terminado, los Archivos se encuentran en: " + strRutaArchivosXML + '!', "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    XtraMessageBox.Show(objError.mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                splashSMCargando.CloseWaitForm();
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DescargaLayout(Int64 IdSolicitud, Int32 IdTabla, DataTable stLotesControl)
        {
           
            RespuestaLeyout = "";
            //string sRutaArchivosCFDI = "";
            bool? pId = false;
            int bFlag = 0;
            int bFlagDescar = 0;
            int bCosse = 0;

            //obtener el No. de Items seleccionadosdel Combobox
            if (stLotesControl.Rows.Count > 0)
            {
                try
                {
                    for (int i = 0; i < stLotesControl.Rows.Count; i++)
                    {
                        DataRow row = stLotesControl.Rows[i];
                        if (row[8].ToString() == "HSBC")
                            bFlag = 1;

                        if (row[8].ToString().Contains("BANORTE") && row[10].ToString().Contains("PAG") && row[11].ToString().Length != 5 && Convert.ToInt64(row[1].ToString()) <= 0)
                            bFlag = 2;
                    }

                    if (bFlag == 0)
                        bFlag = 0;

                    if (bFlag == 0)
                    {
                        for (int i = 0; i < stLotesControl.Rows.Count; i++)
                        {
                            String sErroresLayout = String.Empty;
                            bCosse = bCosse + 1;
                            DataRow row = stLotesControl.Rows[i];
                            if (Convert.ToInt64(row[3].ToString()) > 0)
                            {
                                DateTime dtFechaPago = Convert.ToDateTime(row[13].ToString());
                                string sTipoLote = row["FolioLoteCargaNomina"].ToString().Substring(2, 3) == "ASI" ? "IAS" : row[14].ToString();

                                sErroresLayout = LAYOUT(IdSolicitud, sTipoLote, Convert.ToInt32(row[5].ToString()), row[8].ToString(), Convert.ToInt64(row[3].ToString()), row[10].ToString(), row[11].ToString(), row[22].ToString(), bCosse.ToString(), row["RazonSocial"].ToString(), dtFechaPago);
                                if (!String.IsNullOrEmpty(sErroresLayout)) { lstErroresLayOuts.Add(sErroresLayout); }
                            }
                            else
                            {
                                bFlag = 3;
                            }
                        }
                        this.dbSAICBPOTesoreriaDataSet.stpTesSelSolicitudPagoDetailLayout.Clear();
                        this.stpTesSelSolicitudPagoDetailLayoutTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.stpTesSelSolicitudPagoDetailLayout, IdSolicitud, OperadorBD.OperadorGlobal.IdOperador);
                    }
                }
                catch (Exception ex)
                {

                    XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //else
            //{
            //    XtraMessageBox.Show("¡Debe de Seleccionar por lo menos un Leyout!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }
        private void DescargaLayoutAsimilados(Int64 IdSolicitud, Int32 IdTabla, DataTable stLotesControl)
        {
            RespuestaLeyout = "";
            try
            {
                //string sRutaArchivosCFDI = "";
                bool? pId = false;
                int bFlag = 0;
                int bFlagDescar = 0;
                int bCosse = 0;


                //obtener el No. de Items seleccionadosdel Combobox
                if (stLotesControl.Rows.Count > 0)
                {
                    for (int i = 0; i < stLotesControl.Rows.Count; i++)
                    {
                        DataRow row = stLotesControl.Rows[i];
                        if (row[8].ToString() == "HSBC")
                            bFlag = 1;

                        if (row[8].ToString().Contains("BANORTE") && row[10].ToString().Contains("PAG") && row[11].ToString().Length != 5 && Convert.ToInt64(row[1].ToString()) <= 0)
                            bFlag = 2;
                    }

                    if (bFlag == 0)
                        bFlag = 0;

                    if (bFlag == 0)
                    {
                        for (int i = 0; i < stLotesControl.Rows.Count; i++)
                        {
                            String sErroresLayout = String.Empty;
                            bCosse = bCosse + 1;
                            DataRow row = stLotesControl.Rows[i];
                            if (Convert.ToInt64(row[3].ToString()) > 0)
                            {
                                DateTime dtFechaPago = Convert.ToDateTime(row[13].ToString());
                                sErroresLayout = LAYOUTAsimilados(IdSolicitud, "IAS", Convert.ToInt32(row[5].ToString()), row[8].ToString(), Convert.ToInt64(row[3].ToString()), row[10].ToString(), row[11].ToString(), row[22].ToString(), bCosse.ToString(), row["RazonSocial"].ToString(), dtFechaPago);
                                if (!String.IsNullOrEmpty(sErroresLayout)) { lstErroresLayOuts.Add(sErroresLayout); }
                            }
                            else
                            {
                                bFlag = 3;
                            }
                        }
                    }

                    this.dbSAICAsimilados.stpTesSelSolicitudPagoDetailLayout.Clear();
                    this.stpTesSelSolicitudPagoDetailLayoutTableAdapter1.Fill(this.dbSAICAsimilados.stpTesSelSolicitudPagoDetailLayout, IdSolicitud, OperadorBD.OperadorGlobal.IdOperador);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private String LAYOUT(Int64 idControl, string strIdTipoMovimiento, Int32 intIdTenedora, string sBanco, Int64 intIdLoteCargaNomina, string pFormato, string pEmisora, string pLeyenda, string pConsecutivo, String sTenedoraRazonSocial, DateTime dtFechaPago)
        {
            String sErroresLayout = String.Empty;
            try
            {
                //Obtener registro de la Informacion Bancaria de la Tenedora seleccionada
                this.stpSelInfoBancoCuentasLayoutTableAdapter1.Fill(this.dbSAICBPOValidacionDataSet1.stpSelInfoBancoCuentasLayout, intIdTenedora, sBanco);

                //si existen registros
                if (this.dbSAICBPOValidacionDataSet1.stpSelInfoBancoCuentasLayout.Count > 0)
                {
                    Int32 intNoRegistrosPagos = 0;
                    decimal decImportePagos = 0M;
                    Int32 intNoRegistros05 = 0;
                    Int32 intNoRegistros12 = 0;
                    Int32 intNoRegistros98 = 0;
                    Int32 intNoRegistros99 = 0;

                    //asignar el renglon a variable DataRow
                    DataRow row = this.dbSAICBPOValidacionDataSet1.stpSelInfoBancoCuentasLayout.Rows[0];
                    //asignar la informacion bancaria en un objeto List<InfoBancariaTenedora>
                    List<InfoBancariaTenedora> objInfoBancariaList = InfoBancariaTenedoraBD.ObtenerInfoBancaria(row, pFormato);
                    //asignar valores de la Informacion Bancaria Tenedora
                    InfoBancariaTenedora objInfoBanco = objInfoBancariaList[0];

                    if (pFormato.Equals("TEF C-BILLETE"))
                    {
                        //*******Obtener la Naturaleza del Archivo********
                        String stNArchivo05 = "05";
                        String stNArchivo12 = "12";

                        if (validacionesGeneralTableAdapter1.ObtenerValorParametro("BANAMEX_NARCHIVO05") != null)
                        {
                            stNArchivo05 = validacionesGeneralTableAdapter1.ObtenerValorParametro("BANAMEX_NARCHIVO05").ToString();
                        }

                        if (validacionesGeneralTableAdapter1.ObtenerValorParametro("BANAMEX_NARCHIVO12") != null)
                        {
                            stNArchivo12 = validacionesGeneralTableAdapter1.ObtenerValorParametro("BANAMEX_NARCHIVO12").ToString();
                        }
                        //*******Obtener la Naturaleza del Archivo********

                        //*** Tipo Movimiento 05 = Nomina ***
                        //Obtener registros de la Informacion Bancaria de los Empleados. 
                        this.stpSelLayoutBanamexTEFC05TableAdapter1.Fill(this.dbSAICBPOReportesDataSet1.stpSelLayoutBanamexTEFC05, strIdTipoMovimiento, stNArchivo05, intIdLoteCargaNomina);
                        //asignar el No. de registros procesados para Tipo de Nomina 05
                        intNoRegistros05 = this.dbSAICBPOReportesDataSet1.stpSelLayoutBanamexTEFC05.Count;
                        if (this.dbSAICBPOReportesDataSet1.stpSelLayoutBanamexTEFC05.Count > 0)
                        {
                            shNoSecuencialArchivo += 1;        //incrementar secuencia archivo
                            List<BanamexDetalleTefC> objInfoBancariaEmpleadoList05 = BanamexDetalleTefCBD.ObtenerInformacionBancariaEmpleado(this.dbSAICBPOReportesDataSet1.stpSelLayoutBanamexTEFC05);
                            intNoRegistrosPagos = objInfoBancariaEmpleadoList05.Count;    //No. Registros de Empleados/Asociados 
                            decImportePagos = BanamexDetalleTefCBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                                      //Generar Layout Bancario Banamex TEF C
                            GenerarLayoutBancarioBanamexTEFC(objInfoBanco, objInfoBancariaEmpleadoList05, intIdLoteCargaNomina.ToString(), stNArchivo05, intNoRegistrosPagos, decImportePagos, shNoSecuencialArchivo, strIdTipoMovimiento, strRutaArchivosXML, dtFechaPago);
                        }

                        //*** Tipo Movimiento 12 = Cheques/Interbancarios ***
                        //Obtener registros de la Informacion Bancaria de los Empleados. 
                        this.stpSelLayoutBanamexTEFC12TableAdapter1.Fill(this.dbSAICBPOReportesDataSet1.stpSelLayoutBanamexTEFC12, strIdTipoMovimiento, stNArchivo12, intIdLoteCargaNomina);
                        //asignar el No. de registros procesados para Tipo de Nomina 12
                        intNoRegistros12 = this.dbSAICBPOReportesDataSet1.stpSelLayoutBanamexTEFC12.Count;
                        if (this.dbSAICBPOReportesDataSet1.stpSelLayoutBanamexTEFC12.Count > 0)
                        {
                            shNoSecuencialArchivo += 1;        //incrementar secuencia archivo
                            List<BanamexDetalleTefC> objInfoBancariaEmpleadoList12 = BanamexDetalleTefCBD.ObtenerInformacionBancariaEmpleado(this.dbSAICBPOReportesDataSet1.stpSelLayoutBanamexTEFC12);
                            intNoRegistrosPagos = objInfoBancariaEmpleadoList12.Count;    //No. Registros de Empleados/Asociados 
                            decImportePagos = BanamexDetalleTefCBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                                      //Generar Layout Bancario Banamex TEF C
                            GenerarLayoutBancarioBanamexTEFC(objInfoBanco, objInfoBancariaEmpleadoList12, intIdLoteCargaNomina.ToString(), stNArchivo12, intNoRegistrosPagos, decImportePagos, shNoSecuencialArchivo, strIdTipoMovimiento, strRutaArchivosXML, dtFechaPago);
                        }
                        RespuestaLeyout = string.Format(Environment.NewLine + @"LOTE:{2}, Registros procesados: \n\t Tipo Nómina " + stNArchivo05 + " (Tarjetas)= {0} \n\t Tipo Nómina " + stNArchivo12 + " (Cheques/Interbancarios)= {1}", intNoRegistros05, intNoRegistros12, intIdLoteCargaNomina);
                    }   //if TEF C-BILLETE
                    else if (pFormato.Equals("TEF D-TRADICIONAL"))
                    {
                        //*** Tipo Movimiento 05 = Nomina ***
                        //Obtener registros de la Informacion Bancaria de los Empleados. 
                        this.stpSelLayoutBanamexTEFD05TableAdapter1.Fill(this.dbSAICBPOReportesDataSet1.stpSelLayoutBanamexTEFD05, strIdTipoMovimiento, "05", intIdLoteCargaNomina);
                        //asignar el No. de registros procesados para Tipo de Nomina 05
                        intNoRegistros05 = this.dbSAICBPOReportesDataSet1.stpSelLayoutBanamexTEFD05.Count;
                        if (this.dbSAICBPOReportesDataSet1.stpSelLayoutBanamexTEFD05.Count > 0)
                        {
                            shNoSecuencialArchivo += 1;        //incrementar secuencia archivo
                            List<BanamexDetalleTefD> objInfoBancariaEmpleadoList05 = BanamexDetalleTefDBD.ObtenerInformacionBancariaEmpleado(this.dbSAICBPOReportesDataSet1.stpSelLayoutBanamexTEFD05);
                            intNoRegistrosPagos = objInfoBancariaEmpleadoList05.Count;    //No. Registros de Empleados/Asociados 
                            decImportePagos = BanamexDetalleTefDBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                                      //Generar Layout Bancario Banamex TEF D
                            GenerarLayoutBancarioBanamexTEFD(objInfoBanco, objInfoBancariaEmpleadoList05, intIdLoteCargaNomina.ToString(), "05", intNoRegistrosPagos, decImportePagos, shNoSecuencialArchivo, strIdTipoMovimiento, strRutaArchivosXML, dtFechaPago);
                        }

                        //*** Tipo Movimiento 12 = Cheques/Interbancarios ***
                        //Obtener registros de la Informacion Bancaria de los Empleados. 
                        this.stpSelLayoutBanamexTEFD12TableAdapter1.Fill(this.dbSAICBPOReportesDataSet1.stpSelLayoutBanamexTEFD12, strIdTipoMovimiento, "12", intIdLoteCargaNomina);
                        //asignar el No. de registros procesados para Tipo de Nomina 12
                        intNoRegistros12 = this.dbSAICBPOReportesDataSet1.stpSelLayoutBanamexTEFD12.Count;
                        if (this.dbSAICBPOReportesDataSet1.stpSelLayoutBanamexTEFD12.Count > 0)
                        {
                            shNoSecuencialArchivo += 1;        //incrementar secuencia archivo
                            List<BanamexDetalleTefD> objInfoBancariaEmpleadoList12 = BanamexDetalleTefDBD.ObtenerInformacionBancariaEmpleado(this.dbSAICBPOReportesDataSet1.stpSelLayoutBanamexTEFD12);
                            intNoRegistrosPagos = objInfoBancariaEmpleadoList12.Count;    //No. Registros de Empleados/Asociados 
                            decImportePagos = BanamexDetalleTefDBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                                      //Generar Layout Bancario Banamex TEF D
                            GenerarLayoutBancarioBanamexTEFD(objInfoBanco, objInfoBancariaEmpleadoList12, intIdLoteCargaNomina.ToString(), "12", intNoRegistrosPagos, decImportePagos, shNoSecuencialArchivo, strIdTipoMovimiento, strRutaArchivosXML, dtFechaPago);
                        }

                        RespuestaLeyout = string.Format(Environment.NewLine + @"LOTE:{2}, Registros procesados: \n\t Tipo Nómina 05(Tarjetas)= {0} \n\t Tipo Nómina 12(Cheques/Interbancarios)= {1}", intNoRegistros05, intNoRegistros12, intIdLoteCargaNomina);
                    }   //if TEF D-TRADICIONAL
                    else if (pFormato.Equals("BANCOMER-XLS"))
                    {
                        //*** Tipo Movimiento 99 = Nomina ***
                        //Obtener registros de la Informacion Bancaria de los Empleados. 
                        this.stpSelLayoutBancomer99TableAdapter1.Fill(this.dbSAICBPOReportesDataSet1.stpSelLayoutBancomer99, strIdTipoMovimiento, "99", intIdLoteCargaNomina);
                        //asignar el No. de registros procesados para Tipo de Nomina 99
                        intNoRegistros99 = this.dbSAICBPOReportesDataSet1.stpSelLayoutBancomer99.Count;
                        if (this.dbSAICBPOReportesDataSet1.stpSelLayoutBancomer99.Count > 0)
                        {
                            List<Bancomer> objInfoBancariaEmpleadoList99 = BancomerDetalleBD.ObtenerInformacionBancariaEmpleado(this.dbSAICBPOReportesDataSet1.stpSelLayoutBancomer99);
                            intNoRegistrosPagos = objInfoBancariaEmpleadoList99.Count;    //No. Registros de Empleados/Asociados 
                            decImportePagos = BancomerDetalleBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                                   //Generar Layout Bancario Bancomer 99-NOMINA
                            GenerarLayoutBancarioBancomer(objInfoBanco, objInfoBancariaEmpleadoList99, intIdLoteCargaNomina.ToString(), "99", intNoRegistrosPagos, decImportePagos, shNoSecuencialArchivo, strIdTipoMovimiento, strRutaArchivosXML);
                        }

                        //*** Tipo Movimiento 98 = TDP (Tarjeta de Pagos) ***
                        //Obtener registros de la Informacion Bancaria de los Empleados. 
                        this.stpSelLayoutBancomer98TableAdapter1.Fill(this.dbSAICBPOReportesDataSet1.stpSelLayoutBancomer98, strIdTipoMovimiento, "98", intIdLoteCargaNomina);
                        //asignar el No. de registros procesados para Tipo de Nomina 98-TDP
                        intNoRegistros98 = this.dbSAICBPOReportesDataSet1.stpSelLayoutBancomer98.Count;
                        if (this.dbSAICBPOReportesDataSet1.stpSelLayoutBancomer98.Count > 0)
                        {
                            List<Bancomer> objInfoBancariaEmpleadoList98 = BancomerDetalleBD.ObtenerInformacionBancariaEmpleado(this.dbSAICBPOReportesDataSet1.stpSelLayoutBancomer98);
                            intNoRegistrosPagos = objInfoBancariaEmpleadoList98.Count;    //No. Registros de Empleados/Asociados 
                            decImportePagos = BanamexDetalleTefDBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                                      //Generar Layout Bancario Bancomer 98-TDP
                            GenerarLayoutBancarioBancomer(objInfoBanco, objInfoBancariaEmpleadoList98, intIdLoteCargaNomina.ToString(), "98", intNoRegistrosPagos, decImportePagos, shNoSecuencialArchivo, strIdTipoMovimiento, strRutaArchivosXML);
                        }

                        RespuestaLeyout = string.Format(Environment.NewLine + @"LOTE:{2}, Registros procesados: \n\t Tipo Nómina 99(Cuentas)= {0} \n\t Tipo Nómina 98(TDP)= {1}",
                                            intNoRegistros99, intNoRegistros98, intIdLoteCargaNomina);
                    } //if BANCOMER-XLS
                    else if (pFormato.Equals("BANORTE-BANORTE PAG"))
                    {
                        int intNoEmisora = 0;
                        bool bEsNumerico = int.TryParse(pEmisora, out intNoEmisora);

                        if ((pEmisora.Length == 5) && (intNoEmisora > 0))        //que tenga valor y sea > 0
                        {
                            if (shNoSecuencialArchivo == -1)     //si es -1 entonces incrementar en 2 para convertir a 1
                                shNoSecuencialArchivo += 2;
                            else
                                shNoSecuencialArchivo += 1;        //incrementar secuencia archivo

                            //Obtener registros de la Informacion Bancaria de los Empleados. 
                            this.stpSelLayoutBanorteTableAdapter1.Fill(this.dbSAICBPOReportesDataSet1.stpSelLayoutBanorte, strIdTipoMovimiento, intIdLoteCargaNomina);
                            //asignar el No. de registros procesados
                            intNoRegistrosPagos = this.dbSAICBPOReportesDataSet1.stpSelLayoutBanorte.Count;
                            if (this.dbSAICBPOReportesDataSet1.stpSelLayoutBanorte.Count > 0)
                            {
                                //generar fecha aplicacion pago
                                string strFechaAplicacion = dtFechaPago.Year.ToString() + dtFechaPago.Month.ToString().PadLeft(2, '0') + dtFechaPago.Day.ToString().PadLeft(2, '0');

                                List<BanorteDetalle> objInfoBancariaEmpleadoList = BanorteDetalleBD.ObtenerInformacionBancariaEmpleado(this.dbSAICBPOReportesDataSet1.stpSelLayoutBanorte, strFechaAplicacion);
                                intNoRegistrosPagos = objInfoBancariaEmpleadoList.Count;    //No. Registros de Empleados/Asociados 
                                decImportePagos = BanorteDetalleBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                                      //Generar Layout Bancario Banorte
                                GenerarLayoutBancarioBanorte(objInfoBanco, objInfoBancariaEmpleadoList, intIdLoteCargaNomina.ToString(), intNoRegistrosPagos, decImportePagos, strIdTipoMovimiento, strFechaAplicacion, pEmisora, shNoSecuencialArchivo, strRutaArchivosXML);
                            }

                            RespuestaLeyout = string.Format(Environment.NewLine + @"LOTE:{1}, Registros procesados: {0}", intNoRegistrosPagos, intIdLoteCargaNomina);
                        }
                        else
                        {
                            sErroresLayout = "Error: C" + idControl + " - L" + intIdLoteCargaNomina.ToString() + " - Tenedora(" + intIdTenedora + ") " + sTenedoraRazonSocial + " - LayOut " + sBanco + " - " + pFormato + " - " + "¡Debe escribir el No. de Emisora para generar el Layout BANORTE!";
                            //XtraMessageBox.Show(string.Format(@"¡Debe escribir el No. de Emisora para generar el Layout BANORTE!"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } //if BANORTE-BANORTE PAG
                    else if (pFormato.Equals("BANORTE-INTERBANCARIOS PAG"))
                    {
                        int intNoEmisora = 0;
                        bool bEsNumerico = int.TryParse(pEmisora, out intNoEmisora);

                        if ((pEmisora.Length == 5) && (intNoEmisora > 0))        //que tenga valor y sea > 0
                        {
                            if (shNoSecuencialArchivo == -1)     //si es -1 entonces incrementar en 2 para convertir a 1
                                shNoSecuencialArchivo += 2;
                            else
                                shNoSecuencialArchivo += 1;        //incrementar secuencia archivo

                            //Obtener registros de la Informacion Bancaria de los Empleados. 
                            this.stpSelLayoutBanorteInterbancarioTableAdapter1.Fill(this.dbSAICBPOReportesDataSet1.stpSelLayoutBanorteInterbancario, strIdTipoMovimiento, intIdLoteCargaNomina);
                            //asignar el No. de registros procesados
                            intNoRegistrosPagos = this.dbSAICBPOReportesDataSet1.stpSelLayoutBanorteInterbancario.Count;
                            if (this.dbSAICBPOReportesDataSet1.stpSelLayoutBanorteInterbancario.Count > 0)
                            {
                                //generar fecha aplicacion pago
                                string strFechaAplicacion = dtFechaPago.Year.ToString() + dtFechaPago.Month.ToString().PadLeft(2, '0') + dtFechaPago.Day.ToString().PadLeft(2, '0');

                                List<BanorteDetalle> objInfoBancariaEmpleadoList = BanorteDetalleBD.ObtenerInformacionBancariaEmpleado(this.dbSAICBPOReportesDataSet1.stpSelLayoutBanorteInterbancario, strFechaAplicacion);
                                intNoRegistrosPagos = objInfoBancariaEmpleadoList.Count;    //No. Registros de Empleados/Asociados 
                                decImportePagos = BanorteDetalleBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                                      //Generar Layout Bancario Banorte
                                GenerarLayoutBancarioBanorte(objInfoBanco, objInfoBancariaEmpleadoList, intIdLoteCargaNomina.ToString(), intNoRegistrosPagos, decImportePagos, strIdTipoMovimiento, strFechaAplicacion, pEmisora, shNoSecuencialArchivo, strRutaArchivosXML);
                            }

                            RespuestaLeyout = string.Format(Environment.NewLine + @"LOTE:{1}, Registros procesados: {0}", intNoRegistrosPagos, intIdLoteCargaNomina);
                        }
                        else
                        {
                            sErroresLayout = "Error: C" + idControl + " - L" + intIdLoteCargaNomina.ToString() + " - Tenedora(" + intIdTenedora + ") " + sTenedoraRazonSocial + " - LayOut " + sBanco + " - " + pFormato + " - " + "¡Debe escribir el No. de Emisora para generar el Layout BANORTE!";
                            //XtraMessageBox.Show(string.Format(@"¡Debe escribir el No. de Emisora para generar el Layout BANORTE!"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } //if BANORTE-INTERBANCARIOS PAG
                    else if (pFormato.Equals("SANTANDER-NOMINAS PAG"))
                    {
                        shNoSecuencialArchivo += 1;        //incrementar secuencia archivo
                                                           //Obtener registros de la Informacion Bancaria de los Empleados. 
                        this.stpSelLayoutSantanderTableAdapter1.Fill(this.dbSAICBPOReportesDataSet1.stpSelLayoutSantander, strIdTipoMovimiento, intIdLoteCargaNomina);
                        //asignar el No. de registros procesados
                        intNoRegistrosPagos = this.dbSAICBPOReportesDataSet1.stpSelLayoutSantander.Count;
                        if (this.dbSAICBPOReportesDataSet1.stpSelLayoutSantander.Count > 0)
                        {
                            //generar fecha aplicacion pago
                            string strFechaAplicacion = dtFechaPago.Month.ToString().PadLeft(2, '0') + dtFechaPago.Day.ToString().PadLeft(2, '0') + dtFechaPago.Year.ToString();

                            List<SantanderDetalle> objInfoBancariaEmpleadoList = SantanderDetalleBD.ObtenerInformacionBancariaNominasEmpleado(this.dbSAICBPOReportesDataSet1.stpSelLayoutSantander);
                            intNoRegistrosPagos = objInfoBancariaEmpleadoList.Count;    //No. Registros de Empleados/Asociados 
                            decImportePagos = SantanderDetalleBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                                    //Generar Layout Bancario Santander
                            GenerarLayoutBancarioSantander(objInfoBanco, objInfoBancariaEmpleadoList, intIdLoteCargaNomina.ToString(), intNoRegistrosPagos, decImportePagos, strIdTipoMovimiento, strFechaAplicacion, shNoSecuencialArchivo, strRutaArchivosXML);
                        }

                        RespuestaLeyout = string.Format(Environment.NewLine + @"LOTE:{1}, Registros procesados: {0}", intNoRegistrosPagos, intIdLoteCargaNomina);
                    } //if SANTANDER-NOMINAS PAG                                                               
                    else if (pFormato.Equals("CI BANCO-XLS"))
                    {
                        //Obtener registros de la Informacion Bancaria de los Empleados. 
                        this.stpSelLayoutCIBancoTableAdapter1.Fill(this.dbSAICBPOReportesDataSet1.stpSelLayoutCIBanco, strIdTipoMovimiento, intIdLoteCargaNomina);
                        //asignar el No. de registros procesados
                        //intNoRegistrosPagos = this.dbSAICBPOReportesDataSet.stpSelLayoutCIBanco.Count;
                        if (this.dbSAICBPOReportesDataSet1.stpSelLayoutCIBanco.Count > 0)
                        {
                            List<CIBanco> objInfoBancariaEmpleadoList = CIBancoDetalleBD.ObtenerInformacionBancariaEmpleado(this.dbSAICBPOReportesDataSet1.stpSelLayoutCIBanco);
                            intNoRegistrosPagos = objInfoBancariaEmpleadoList.Count;    //No. Registros de Empleados/Asociados 
                            decImportePagos = CIBancoDetalleBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                                  //Generar Layout CI Banco
                            GenerarLayoutBancarioCIBanco(objInfoBanco, objInfoBancariaEmpleadoList, intNoRegistrosPagos, decImportePagos, pEmisora, strRutaArchivosXML);
                        }

                        RespuestaLeyout = string.Format(Environment.NewLine + @"LOTE:{1}, Registros procesados = {0}", intNoRegistrosPagos, intIdLoteCargaNomina);
                    } //if CI BANCO-XLS
                    else if (pFormato.Equals("HSBC-OTRAS CUENTAS HSBC"))
                    {
                        //validar leyenda dispersion
                        if (pLeyenda.Length > 0)
                        {
                            //Obtener registros de la Informacion Bancaria de los Empleados. 
                            this.stpSelLayoutHSBCOtrasCuentasTableAdapter1.Fill(this.dbSAICBPOReportesDataSet1.stpSelLayoutHSBCOtrasCuentas, strIdTipoMovimiento, intIdLoteCargaNomina, pLeyenda);
                            //asignar el No. de registros procesados
                            if (this.dbSAICBPOReportesDataSet1.stpSelLayoutHSBCOtrasCuentas.Count > 0)
                            {
                                List<HSBCOtrasCuentas> objInfoBancariaEmpleadoList = HSBCBD.ObtenerInformacionBancariaEmpleadoOtrasCuentas(this.dbSAICBPOReportesDataSet1.stpSelLayoutHSBCOtrasCuentas);
                                intNoRegistrosPagos = objInfoBancariaEmpleadoList.Count;    //No. Registros de Empleados/Asociados 
                                decImportePagos = HSBCBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                            //Generar Layout HSBC
                                GenerarLayoutBancarioHSBCOtrasCuentas(objInfoBanco, objInfoBancariaEmpleadoList, intIdLoteCargaNomina.ToString(), intNoRegistrosPagos, decImportePagos, pConsecutivo, pLeyenda, strRutaArchivosXML);
                            }

                            RespuestaLeyout = string.Format(Environment.NewLine + @"LOTE:{1}, Registros procesados = {0}", intNoRegistrosPagos, intIdLoteCargaNomina);
                        }
                        else
                        {
                            sErroresLayout = "Error: C" + idControl + " - L" + intIdLoteCargaNomina.ToString() + " - Tenedora(" + intIdTenedora + ") " + sTenedoraRazonSocial + " - LayOut " + sBanco + " - " + pFormato + " - " + "¡Para generar el Layout Bancario HSBC debe \n seleccionar la Leyenda de Dispersión!";
                            //XtraMessageBox.Show("¡Para generar el Layout Bancario HSBC debe \n seleccionar la Leyenda de Dispersión!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    } //if HSBC-OTRAS CUENTAS HSBC
                    else if (pFormato.Equals("HSBC-INTERBANCARIO SPEI"))
                    {
                        //validar leyenda dispersion
                        if (pLeyenda.Length > 0)
                        {
                            //Obtener registros de la Informacion Bancaria de los Empleados. 
                            this.stpSelLayoutHSBCSPEITableAdapter1.Fill(this.dbSAICBPOReportesDataSet1.stpSelLayoutHSBCSPEI, strIdTipoMovimiento, intIdLoteCargaNomina, pLeyenda);
                            //asignar el No. de registros procesados
                            if (this.dbSAICBPOReportesDataSet1.stpSelLayoutHSBCSPEI.Count > 0)
                            {
                                List<HSBCSPEI> objInfoBancariaEmpleadoList = HSBCBD.ObtenerInformacionBancariaEmpleadoSPEI(this.dbSAICBPOReportesDataSet1.stpSelLayoutHSBCSPEI);
                                intNoRegistrosPagos = objInfoBancariaEmpleadoList.Count;    //No. Registros de Empleados/Asociados 
                                decImportePagos = HSBCBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                            //Generar Layout HSBC
                                GenerarLayoutBancarioHSBCSPEI(objInfoBanco, objInfoBancariaEmpleadoList, strIdTipoMovimiento, intIdLoteCargaNomina.ToString(), strRutaArchivosXML);
                            }

                            RespuestaLeyout = string.Format(Environment.NewLine + @"LOTE:{1}, Registros procesados = {0}", intNoRegistrosPagos, intIdLoteCargaNomina);
                        }
                        else
                        {
                            sErroresLayout = "Error: C" + idControl + " - L" + intIdLoteCargaNomina.ToString() + " - Tenedora(" + intIdTenedora + ") " + sTenedoraRazonSocial + " - LayOut " + sBanco + " - " + pFormato + " - " + "¡Para generar el Layout Bancario HSBC debe \n seleccionar la Leyenda de Dispersión!";
                            //XtraMessageBox.Show("¡Para generar el Layout Bancario HSBC debe \n seleccionar la Leyenda de Dispersión!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    } //if HSBC-INTERBANCARIO SPEI
                    else if (pFormato.Equals("HSBC-NOMINAS"))
                    {
                        //validar leyenda dispersion
                        if (pLeyenda.Length > 0)
                        {
                            //Obtener registros de la Informacion Bancaria de los Empleados. 
                            this.stpSelLayoutHSBCNominasTableAdapter1.Fill(this.dbSAICBPOReportesDataSet1.stpSelLayoutHSBCNominas, intIdLoteCargaNomina, pLeyenda);
                            //asignar el No. de registros procesados
                            if (this.dbSAICBPOReportesDataSet1.stpSelLayoutHSBCNominas.Count > 0)
                            {
                                List<HSBCNominas> objInfoBancariaEmpleadoList = HSBCBD.ObtenerInformacionBancariaEmpleadoNominas(this.dbSAICBPOReportesDataSet1.stpSelLayoutHSBCNominas);
                                intNoRegistrosPagos = objInfoBancariaEmpleadoList.Count;    //No. Registros de Empleados/Asociados 
                                decImportePagos = HSBCBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                            //Generar Layout HSBC
                                GenerarLayoutBancarioHSBCNominas(objInfoBanco, objInfoBancariaEmpleadoList, strIdTipoMovimiento, intIdLoteCargaNomina.ToString(), strRutaArchivosXML);
                            }

                            RespuestaLeyout = string.Format(Environment.NewLine + @"LOTE:{1}, Registros procesados = {0}", intNoRegistrosPagos, intIdLoteCargaNomina);
                        }
                        else
                        {
                            sErroresLayout = "Error: C" + idControl + " - L" + intIdLoteCargaNomina.ToString() + " - Tenedora(" + intIdTenedora + ") " + sTenedoraRazonSocial + " - LayOut " + sBanco + " - " + pFormato + " - " + "¡Para generar el Layout Bancario HSBC debe seleccionar la Leyenda de Dispersión!";
                            //XtraMessageBox.Show("¡Para generar el Layout Bancario HSBC debe \n seleccionar la Leyenda de Dispersión!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    } //if HSBC-NOMINAS
                    else if (pFormato.Equals("HSBCNET-NOMINAS"))
                    {
                        //validar leyenda dispersion
                        if (pLeyenda.Length > 0)
                        {
                            //Obtener registros de la Informacion Bancaria de los Empleados. 
                            this.stpSelLayoutHSBCNETNominasTableAdapter1.Fill(this.dbSAICBPOReportesDataSet1.stpSelLayoutHSBCNETNominas, strIdTipoMovimiento, intIdLoteCargaNomina, pLeyenda);
                            //asignar el No. de registros procesados
                            if (this.dbSAICBPOReportesDataSet1.stpSelLayoutHSBCNETNominas.Count > 0)
                            {
                                //generar fecha aplicacion pago
                                string strFechaAplicacion = dtFechaPago.Day.ToString().PadLeft(2, '0') + dtFechaPago.Month.ToString().PadLeft(2, '0') + dtFechaPago.Year.ToString();

                                List<HSBCNominas> objInfoBancariaEmpleadoList = HSBCBD.ObtenerInformacionBancariaEmpleadoNominas(this.dbSAICBPOReportesDataSet1.stpSelLayoutHSBCNETNominas);
                                intNoRegistrosPagos = objInfoBancariaEmpleadoList.Count;    //No. Registros de Empleados/Asociados 
                                decImportePagos = HSBCBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                            //Generar Layout HSBC
                                GenerarLayoutBancarioHSBCNETNominas(objInfoBanco, objInfoBancariaEmpleadoList, intIdLoteCargaNomina.ToString(), intNoRegistrosPagos, decImportePagos, strFechaAplicacion, pLeyenda, strIdTipoMovimiento, strRutaArchivosXML);
                            }

                            RespuestaLeyout = string.Format(Environment.NewLine + @"LOTE:{1}, Registros procesados = {0}", intNoRegistrosPagos, intIdLoteCargaNomina);
                        }
                        else
                        {
                            sErroresLayout = "Error: C" + idControl + " - L" + intIdLoteCargaNomina.ToString() + " - Tenedora(" + intIdTenedora + ") " + sTenedoraRazonSocial + " - LayOut " + sBanco + " - " + pFormato + " - " + "Para generar el Layout Bancario HSBC debe seleccionar la Leyenda de Dispersión!";
                            //XtraMessageBox.Show("¡Para generar el Layout Bancario HSBC debe \n seleccionar la Leyenda de Dispersión!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }  //HSBCNET-NOMINAS
                    else if (pFormato.Equals("INBURSA-INTERBANCARIO SPEI"))
                    {
                        //Obtener registros de la Informacion Bancaria de los Empleados. 
                        this.stpSelLayoutInbursaSPEITableAdapter1.Fill(this.dbSAICBPOReportesDataSet1.stpSelLayoutInbursaSPEI, intIdLoteCargaNomina, strIdTipoMovimiento);
                        //asignar el No. de registros procesados
                        if (this.dbSAICBPOReportesDataSet1.stpSelLayoutInbursaSPEI.Count > 0)
                        {
                            //generar fecha aplicacion pago
                            string strFechaAplicacion = dtFechaPago.Year.ToString() + dtFechaPago.Month.ToString().PadLeft(2, '0') + dtFechaPago.Day.ToString().PadLeft(2, '0');

                            List<InbursaSPEI> objInfoBancariaEmpleadoList = InbursaBD.ObtenerInformacionBancariaEmpleadoSPEI(this.dbSAICBPOReportesDataSet1.stpSelLayoutInbursaSPEI);
                            intNoRegistrosPagos = objInfoBancariaEmpleadoList.Count;    //No. Registros de Empleados/Asociados 
                            decImportePagos = InbursaBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                           //Generar Layout Inbursa SPEI
                            GenerarLayoutBancarioInbursaSPEI(objInfoBanco, objInfoBancariaEmpleadoList, strIdTipoMovimiento, intIdLoteCargaNomina.ToString(), intNoRegistrosPagos, decImportePagos, strFechaAplicacion, strRutaArchivosXML);
                        }

                        RespuestaLeyout = string.Format(Environment.NewLine + @"LOTE:{1}, Registros procesados = {0}", intNoRegistrosPagos, intIdLoteCargaNomina);
                    }  //INBURSA-INTERBANCARIO SPEI
                    else if (pFormato.Equals("BANORTE-BANORTE PROV"))
                    {
                        if (shNoSecuencialArchivo == -1)     //si es -1 entonces incrementar en 2 para convertir a 1
                            shNoSecuencialArchivo += 2;
                        else
                            shNoSecuencialArchivo += 1;        //incrementar secuencia archivo

                        //Obtener registros de la Informacion Bancaria de los Empleados. 
                        this.stpSelLayoutBanorte2016TableAdapter1.Fill(this.dbSAICBPOReportesDataSet1.stpSelLayoutBanorte2016, strIdTipoMovimiento, intIdLoteCargaNomina);
                        //asignar el No. de registros procesados
                        intNoRegistrosPagos = this.dbSAICBPOReportesDataSet1.stpSelLayoutBanorte2016.Count;
                        if (this.dbSAICBPOReportesDataSet1.stpSelLayoutBanorte2016.Count > 0)
                        {
                            //generar fecha aplicacion pago
                            string strFechaAplicacion = dtFechaPago.Day.ToString().PadLeft(2, '0') + dtFechaPago.Month.ToString().PadLeft(2, '0') + dtFechaPago.Year.ToString();

                            List<Banorte2016> objInfoBancariaEmpleadoList = BanorteDetalleBD.ObtenerInformacionBancariaEmpleado2016(this.dbSAICBPOReportesDataSet1.stpSelLayoutBanorte2016, strFechaAplicacion);
                            //Generar Layout Bancario Banorte
                            GenerarLayoutBancarioBanorte2016(objInfoBanco, objInfoBancariaEmpleadoList, intIdLoteCargaNomina.ToString(), strIdTipoMovimiento, strFechaAplicacion, pEmisora, shNoSecuencialArchivo, "BAN2BAN", strRutaArchivosXML);
                        }

                        RespuestaLeyout = string.Format(Environment.NewLine + @"LOTE:{1}, Registros procesados: {0}", intNoRegistrosPagos, intIdLoteCargaNomina);
                    } //BANORTE-BANORTE PROVEEDOR
                    else if (pFormato.Equals("BANORTE-INTERBANCARIOS PROV"))
                    {
                        if (shNoSecuencialArchivo == -1)     //si es -1 entonces incrementar en 2 para convertir a 1
                            shNoSecuencialArchivo += 2;
                        else
                            shNoSecuencialArchivo += 1;        //incrementar secuencia archivo

                        //Obtener registros de la Informacion Bancaria de los Empleados. 
                        this.stpSelLayoutBanorteInterbancario2016TableAdapter1.Fill(this.dbSAICBPOReportesDataSet1.stpSelLayoutBanorteInterbancario2016, strIdTipoMovimiento, intIdLoteCargaNomina);
                        //asignar el No. de registros procesados
                        intNoRegistrosPagos = this.dbSAICBPOReportesDataSet1.stpSelLayoutBanorteInterbancario2016.Count;
                        if (this.dbSAICBPOReportesDataSet1.stpSelLayoutBanorteInterbancario2016.Count > 0)
                        {
                            //generar fecha aplicacion pago
                            string strFechaAplicacion = dtFechaPago.Day.ToString().PadLeft(2, '0') + dtFechaPago.Month.ToString().PadLeft(2, '0') + dtFechaPago.Year.ToString();

                            List<Banorte2016> objInfoBancariaEmpleadoList = BanorteDetalleBD.ObtenerInformacionBancariaEmpleado2016(this.dbSAICBPOReportesDataSet1.stpSelLayoutBanorteInterbancario2016, strFechaAplicacion);
                            //Generar Layout Bancario Banorte
                            GenerarLayoutBancarioBanorte2016(objInfoBanco, objInfoBancariaEmpleadoList, intIdLoteCargaNomina.ToString(), strIdTipoMovimiento, strFechaAplicacion, pEmisora, shNoSecuencialArchivo, "BAN2INT", strRutaArchivosXML);
                        }

                        RespuestaLeyout = string.Format(Environment.NewLine + @"LOTE:{1}, Registros procesados: {0}", intNoRegistrosPagos, intIdLoteCargaNomina);
                    } //BANORTE-INTERBANCARIOS PROVEEDOR

                    else if (pFormato.Equals("SANTANDER-SANTANDER PROV"))
                    {
                        int idLote;

                        int.TryParse(intIdLoteCargaNomina.ToString(), out idLote);

                        if (idLote > 0)
                        {
                            stpSelLayOutBancariosTableAdapter1.Fill(dbSAICBPOReportesDataSet1.stpSelLayOutBancarios, pFormato, idLote);
                            if (dbSAICBPOReportesDataSet1.stpSelLayOutBancarios.Rows.Count > 0)
                            {
                                String stNombreArchivos = dbSAICBPOReportesDataSet1.stpSelLayOutBancarios.Rows[0]["NombreArchivo"].ToString();
                                stNombreArchivos = stNombreArchivos == String.Empty ? pFormato + ".txt" : stNombreArchivos;

                                String stFormatoFecha = dbSAICBPOReportesDataSet1.stpSelLayOutBancarios.Rows[0]["FechaPagoFormato"].ToString();

                                intNoRegistrosPagos = GenerarLayoutBancarioSantander_1(dbSAICBPOReportesDataSet1.stpSelLayOutBancarios, stNombreArchivos, stFormatoFecha, pEmisora);
                            }
                        }

                        RespuestaLeyout = string.Format(Environment.NewLine + @"LOTE:{1}, Registros procesados: {0}", intNoRegistrosPagos, intIdLoteCargaNomina);
                    }

                    else if (pFormato.Equals("SANTANDER-INTERBANCARIOS PROV"))
                    {
                        int idLote;
                        int.TryParse(intIdLoteCargaNomina.ToString(), out idLote);

                        if (idLote > 0)
                        {
                            stpSelLayOutBancariosTableAdapter1.Fill(dbSAICBPOReportesDataSet1.stpSelLayOutBancarios, pFormato, idLote);
                            if (dbSAICBPOReportesDataSet1.stpSelLayOutBancarios.Rows.Count > 0)
                            {
                                String stNombreArchivos = dbSAICBPOReportesDataSet1.stpSelLayOutBancarios.Rows[0]["NombreArchivo"].ToString();
                                stNombreArchivos = stNombreArchivos == String.Empty ? pFormato + ".txt" : stNombreArchivos;

                                String stFormatoFecha = dbSAICBPOReportesDataSet1.stpSelLayOutBancarios.Rows[0]["FechaPagoFormato"].ToString();

                                intNoRegistrosPagos = GenerarLayoutBancarioSantander_1(dbSAICBPOReportesDataSet1.stpSelLayOutBancarios, stNombreArchivos, stFormatoFecha, pEmisora);
                            }
                        }

                        RespuestaLeyout = string.Format(Environment.NewLine + @"LOTE:{1}, Registros procesados: {0}", intNoRegistrosPagos, intIdLoteCargaNomina);
                    }
                    else//Todos los demas layOuts
                    {
                        int idLote;
                        int.TryParse(intIdLoteCargaNomina.ToString(), out idLote);

                        if (idLote > 0)
                        {
                            Boolean flagEstaMuyBien = true;

                            if (pFormato.Contains("SCOTIABANK PAG"))
                            {
                                int intNoEmisora = 0;
                                bool bEsNumerico = int.TryParse(pEmisora, out intNoEmisora);

                                if ((pEmisora.Length != 5) || (intNoEmisora == 0))
                                {
                                    sErroresLayout = "Error: C" + idControl + " - L" + intIdLoteCargaNomina.ToString() + " - Tenedora(" + intIdTenedora + ") " + sTenedoraRazonSocial + " - LayOut " + sBanco + " - " + pFormato + " - " + "¡Debe escribir el No. de Emisora para generar el Layout SCOTIABANK!";
                                    //XtraMessageBox.Show(string.Format(@"¡Debe escribir el No. de Emisora para generar el Layout SCOTIABANK!"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    flagEstaMuyBien = false;
                                }
                            }

                            if (flagEstaMuyBien)
                            {
                                try { stpSelLayOutBancariosTableAdapter1.Fill(dbSAICBPOReportesDataSet1.stpSelLayOutBancarios, pFormato, idLote); } catch (Exception ex) { }
                                if (dbSAICBPOReportesDataSet1.stpSelLayOutBancarios.Rows.Count > 0)
                                {
                                    String stNombreArchivos = dbSAICBPOReportesDataSet1.stpSelLayOutBancarios.Rows[0]["NombreArchivo"].ToString();

                                    if (stNombreArchivos.Contains(".csv"))//validacion del tipo de archivo
                                    {

                                        gridControl3.Visible = true;
                                        shNoSecuencialArchivo += 1;
                                        stpSelLayoutKuspitBanPay_InterbancariosProvTableAdapter1.Fill(dbSAICBPOFactura.stpSelLayoutKuspitBanPay_InterbancariosProv, idLote, dtFechaPago.Date, shNoSecuencialArchivo);

                                        String stRutaLayOut = strRutaArchivosXML + @"\";
                                        String stNombreArchivo = String.Empty;
                                        tools.dsc dsc = new tools.dsc();

                                        stNombreArchivo = stRutaLayOut + stNombreArchivos.Replace(".csv", "") + "_L" + idLote + "-" + dsc.nombreAleatorio() + ".csv";

                                        dsc.CheckandCreateFolder(stRutaLayOut);

                                        String stRutaSaic = dsc.stRutaSAICActualizacionDeLote;
                                        dsc.CheckandCreateFolder(stRutaSaic);
                                        gridControl3.ExportToCsv(stNombreArchivo);
                                        intNoRegistrosPagos = dbSAICBPOFactura.stpSelLayoutKuspitBanPay_InterbancariosProv.Rows.Count > 0 ? dbSAICBPOFactura.stpSelLayoutKuspitBanPay_InterbancariosProv.Rows.Count - 1 : 0;
                                        gridControl3.Visible = false;
                                    }
                                    else
                                    {
                                        stNombreArchivos = stNombreArchivos == String.Empty ? pFormato + ".txt" : stNombreArchivos;
                                        String stFormatoFecha = dbSAICBPOReportesDataSet1.stpSelLayOutBancarios.Rows[0]["FechaPagoFormato"].ToString();
                                        intNoRegistrosPagos = GenerarLayoutBancarioSantander_1(dbSAICBPOReportesDataSet1.stpSelLayOutBancarios, stNombreArchivos, stFormatoFecha, pEmisora);
                                    }
                                }
                            }
                        }

                        RespuestaLeyout = string.Format(Environment.NewLine + @"LOTE:{1}, Registros procesados: {0}", intNoRegistrosPagos, intIdLoteCargaNomina);
                    }
                }   //this.dbSAICBPOValidacionDataSet.stpSelInfoBancoCuentasLayout.Count 
                else
                {
                    sErroresLayout = "Error: C" + idControl + " - L" + intIdLoteCargaNomina.ToString() + " - Tenedora(" + intIdTenedora + ") " + sTenedoraRazonSocial + " - LayOut " + sBanco + " - " + pFormato + " - " + "La Tenedora seleccionada no tiene asociada Información Bancaria para realizar el Layout";
                }
            } //try
            catch (SqlException ex)
            {
                sErroresLayout = "Error: C" + idControl + " - L" + intIdLoteCargaNomina.ToString() + " - Tenedora(" + intIdTenedora + ") " + sTenedoraRazonSocial + " - LayOut " + sBanco + " - " + pFormato + " - " + ex.Message;
                //XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                //XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sErroresLayout = "Error: " + idControl + " - L" + intIdLoteCargaNomina.ToString() + " - Tenedora(" + intIdTenedora + ") " + sTenedoraRazonSocial + " - LayOut " + sBanco + " - " + pFormato + " - " + ex.Message;
            }

            return sErroresLayout;
        }
        private String LAYOUTAsimilados(Int64 idControl, string strIdTipoMovimiento, Int32 intIdTenedora, string sBanco, Int64 intIdLoteCargaNomina, string sFormatoLayOut, string sEmisora, string sLeyendaDeDisperson, string pConsecutivo, String sTenedoraRazonSocial, DateTime dtFechaPago)
        {
            String sErroresLayout = String.Empty;
            try
            {
                //dbSAICAsimilados

                //Obtener registro de la Informacion Bancaria de la Tenedora seleccionada
                this.stpSelInfoBancoCuentasLayout_IASTableAdapter1.Fill(this.dbSAICAsimilados.stpSelInfoBancoCuentasLayout, intIdTenedora, sBanco);

                //si existen registros
                if (this.dbSAICAsimilados.stpSelInfoBancoCuentasLayout.Count > 0)
                {
                    Int32 intNoRegistrosPagos = 0;
                    decimal decImportePagos = 0M;
                    Int32 intNoRegistros05 = 0;
                    Int32 intNoRegistros12 = 0;
                    Int32 intNoRegistros98 = 0;
                    Int32 intNoRegistros99 = 0;

                    //asignar el renglon a variable DataRow
                    DataRow row = this.dbSAICAsimilados.stpSelInfoBancoCuentasLayout.Rows[0];
                    //asignar la informacion bancaria en un objeto List<InfoBancariaTenedora>
                    List<InfoBancariaTenedora> objInfoBancariaList = InfoBancariaTenedoraBD.ObtenerInfoBancaria(row, sFormatoLayOut);

                    //asignar valores de la Informacion Bancaria Tenedora
                    InfoBancariaTenedora objInfoBanco = objInfoBancariaList[0];

                    if (sFormatoLayOut.Equals("TEF C-BILLETE"))
                    {
                        //*** Tipo Movimiento 05 = Nomina ***
                        //Obtener registros de la Informacion Bancaria de los Empleados. 
                        this.stpSelLayoutBanamexTEFC05_IASTableAdapter1.Fill(this.dbSAICAsimilados.stpSelLayoutBanamexTEFC05, strIdTipoMovimiento, "05", intIdLoteCargaNomina);
                        //asignar el No. de registros procesados para Tipo de Nomina 05
                        intNoRegistros05 = this.dbSAICAsimilados.stpSelLayoutBanamexTEFC05.Count;
                        if (this.dbSAICAsimilados.stpSelLayoutBanamexTEFC05.Count > 0)
                        {
                            shNoSecuencialArchivo_IAS += 1;        //incrementar secuencia archivo
                            List<BanamexDetalleTefC> objInfoBancariaEmpleadoList05 = BanamexDetalleTefCBD.ObtenerInformacionBancariaEmpleado(this.dbSAICAsimilados.stpSelLayoutBanamexTEFC05);
                            intNoRegistrosPagos = objInfoBancariaEmpleadoList05.Count;    //No. Registros de Empleados/Asociados 
                            decImportePagos = BanamexDetalleTefCBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                                      //Generar Layout Bancario Banamex TEF C
                            GenerarLayoutBancarioBanamexTEFC(objInfoBanco, objInfoBancariaEmpleadoList05, intIdLoteCargaNomina.ToString(), "05", intNoRegistrosPagos, decImportePagos, shNoSecuencialArchivo_IAS, strIdTipoMovimiento, strRutaArchivosXML, dtFechaPago);
                        }
                        else
                        {
                            sErroresLayout = "Error: C" + idControl + " - L" + intIdLoteCargaNomina.ToString() + " - Tenedora(" + intIdTenedora + ") " + sTenedoraRazonSocial + " - LayOut " + sBanco + " - " + sFormatoLayOut + " - " + "LayOuts sin empleados por generar.";
                        }

                        //*** Tipo Movimiento 12 = Cheques/Interbancarios ***
                        //Obtener registros de la Informacion Bancaria de los Empleados. 
                        this.stpSelLayoutBanamexTEFC12_IASTableAdapter1.Fill(this.dbSAICAsimilados.stpSelLayoutBanamexTEFC12, strIdTipoMovimiento, "12", intIdLoteCargaNomina);
                        //asignar el No. de registros procesados para Tipo de Nomina 12
                        intNoRegistros12 = this.dbSAICAsimilados.stpSelLayoutBanamexTEFC12.Count;
                        if (this.dbSAICAsimilados.stpSelLayoutBanamexTEFC12.Count > 0)
                        {
                            shNoSecuencialArchivo_IAS += 1;        //incrementar secuencia archivo
                            List<BanamexDetalleTefC> objInfoBancariaEmpleadoList12 = BanamexDetalleTefCBD.ObtenerInformacionBancariaEmpleado(this.dbSAICAsimilados.stpSelLayoutBanamexTEFC12);
                            intNoRegistrosPagos = objInfoBancariaEmpleadoList12.Count;    //No. Registros de Empleados/Asociados 
                            decImportePagos = BanamexDetalleTefCBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                                      //Generar Layout Bancario Banamex TEF C
                            GenerarLayoutBancarioBanamexTEFC(objInfoBanco, objInfoBancariaEmpleadoList12, intIdLoteCargaNomina.ToString(), "12", intNoRegistrosPagos, decImportePagos, shNoSecuencialArchivo_IAS, strIdTipoMovimiento, strRutaArchivosXML, dtFechaPago);
                        }
                        else
                        {
                            sErroresLayout = "Error: C" + idControl + " - L" + intIdLoteCargaNomina.ToString() + " - Tenedora(" + intIdTenedora + ") " + sTenedoraRazonSocial + " - LayOut " + sBanco + " - " + sFormatoLayOut + " - " + "LayOuts sin empleados por generar.";
                        }

                        //XtraMessageBox.Show(string.Format(@"Se han generado los Layout Bancarios correctamente. Busque los archivos en la carpeta C:\LAYOUTS." +
                        //        "\n\n Registros procesados: \n\t Tipo Nómina 05(Tarjetas)= {0} \n\t Tipo Nómina 12(Cheques/Interbancarios)= {1}",
                        //                    intNoRegistros05, intNoRegistros12), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }   //if TEF C-BILLETE
                    else if (sFormatoLayOut.Equals("TEF D-TRADICIONAL"))
                    {
                        //*** Tipo Movimiento 05 = Nomina ***
                        //Obtener registros de la Informacion Bancaria de los Empleados. 
                        this.stpSelLayoutBanamexTEFD05_IASTableAdapter1.Fill(this.dbSAICAsimilados.stpSelLayoutBanamexTEFD05, strIdTipoMovimiento, "05", intIdLoteCargaNomina);
                        //asignar el No. de registros procesados para Tipo de Nomina 05
                        intNoRegistros05 = this.dbSAICAsimilados.stpSelLayoutBanamexTEFD05.Count;
                        if (this.dbSAICAsimilados.stpSelLayoutBanamexTEFD05.Count > 0)
                        {
                            shNoSecuencialArchivo_IAS += 1;        //incrementar secuencia archivo
                            List<BanamexDetalleTefD> objInfoBancariaEmpleadoList05 = BanamexDetalleTefDBD.ObtenerInformacionBancariaEmpleado(this.dbSAICAsimilados.stpSelLayoutBanamexTEFD05);
                            intNoRegistrosPagos = objInfoBancariaEmpleadoList05.Count;    //No. Registros de Empleados/Asociados 
                            decImportePagos = BanamexDetalleTefDBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                                      //Generar Layout Bancario Banamex TEF D
                            GenerarLayoutBancarioBanamexTEFD(objInfoBanco, objInfoBancariaEmpleadoList05, intIdLoteCargaNomina.ToString(), "05", intNoRegistrosPagos, decImportePagos, shNoSecuencialArchivo_IAS, strIdTipoMovimiento, strRutaArchivosXML, dtFechaPago);
                        }
                        else
                        {
                            sErroresLayout = "Error: C" + idControl + " - L" + intIdLoteCargaNomina.ToString() + " - Tenedora(" + intIdTenedora + ") " + sTenedoraRazonSocial + " - LayOut " + sBanco + " - " + sFormatoLayOut + " - " + "LayOuts sin empleados por generar.";
                        }

                        //*** Tipo Movimiento 12 = Cheques/Interbancarios ***
                        //Obtener registros de la Informacion Bancaria de los Empleados. 
                        this.stpSelLayoutBanamexTEFD12_IASTableAdapter1.Fill(this.dbSAICAsimilados.stpSelLayoutBanamexTEFD12, strIdTipoMovimiento, "12", intIdLoteCargaNomina);
                        //asignar el No. de registros procesados para Tipo de Nomina 12
                        intNoRegistros12 = this.dbSAICAsimilados.stpSelLayoutBanamexTEFD12.Count;
                        if (this.dbSAICAsimilados.stpSelLayoutBanamexTEFD12.Count > 0)
                        {
                            shNoSecuencialArchivo_IAS += 1;        //incrementar secuencia archivo
                            List<BanamexDetalleTefD> objInfoBancariaEmpleadoList12 = BanamexDetalleTefDBD.ObtenerInformacionBancariaEmpleado(this.dbSAICAsimilados.stpSelLayoutBanamexTEFD12);
                            intNoRegistrosPagos = objInfoBancariaEmpleadoList12.Count;    //No. Registros de Empleados/Asociados 
                            decImportePagos = BanamexDetalleTefDBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                                      //Generar Layout Bancario Banamex TEF D
                            GenerarLayoutBancarioBanamexTEFD(objInfoBanco, objInfoBancariaEmpleadoList12, intIdLoteCargaNomina.ToString(), "12", intNoRegistrosPagos, decImportePagos, shNoSecuencialArchivo_IAS, strIdTipoMovimiento, strRutaArchivosXML, dtFechaPago);
                        }
                        else
                        {
                            sErroresLayout = "Error: C" + idControl + " - L" + intIdLoteCargaNomina.ToString() + " - Tenedora(" + intIdTenedora + ") " + sTenedoraRazonSocial + " - LayOut " + sBanco + " - " + sFormatoLayOut + " - " + "LayOuts sin empleados por generar.";
                        }

                        //XtraMessageBox.Show(string.Format(@"Se han generado los Layout Bancarios correctamente. Busque los archivos en la carpeta C:\LAYOUTS." +
                        //        "\n\n Registros procesados: \n\t Tipo Nómina 05(Tarjetas)= {0} \n\t Tipo Nómina 12(Cheques/Interbancarios)= {1}",
                        //                    intNoRegistros05, intNoRegistros12), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }   //if TEF D-TRADICIONAL
                    else if (sFormatoLayOut.Equals("BANCOMER-XLS"))
                    {
                        //*** Tipo Movimiento 99 = Nomina ***
                        //Obtener registros de la Informacion Bancaria de los Empleados. 
                        this.stpSelLayoutBancomer99_IASTableAdapter1.Fill(this.dbSAICAsimilados.stpSelLayoutBancomer99, strIdTipoMovimiento, "99", intIdLoteCargaNomina);
                        //asignar el No. de registros procesados para Tipo de Nomina 99
                        intNoRegistros99 = this.dbSAICAsimilados.stpSelLayoutBancomer99.Count;
                        if (this.dbSAICAsimilados.stpSelLayoutBancomer99.Count > 0)
                        {
                            List<Bancomer> objInfoBancariaEmpleadoList99 = BancomerDetalleBD.ObtenerInformacionBancariaEmpleado(this.dbSAICAsimilados.stpSelLayoutBancomer99);
                            intNoRegistrosPagos = objInfoBancariaEmpleadoList99.Count;    //No. Registros de Empleados/Asociados 
                            decImportePagos = BancomerDetalleBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                                   //Generar Layout Bancario Bancomer 99-NOMINA
                            GenerarLayoutBancarioBancomer(objInfoBanco, objInfoBancariaEmpleadoList99, intIdLoteCargaNomina.ToString(), "99", intNoRegistrosPagos, decImportePagos, shNoSecuencialArchivo_IAS, strIdTipoMovimiento, strRutaArchivosXML);
                        }
                        else
                        {
                            sErroresLayout = "Error: C" + idControl + " - L" + intIdLoteCargaNomina.ToString() + " - Tenedora(" + intIdTenedora + ") " + sTenedoraRazonSocial + " - LayOut " + sBanco + " - " + sFormatoLayOut + " - " + "LayOuts sin empleados por generar.";
                        }

                        //*** Tipo Movimiento 98 = TDP (Tarjeta de Pagos) ***
                        //Obtener registros de la Informacion Bancaria de los Empleados. 
                        this.stpSelLayoutBancomer98_IASTableAdapter1.Fill(this.dbSAICAsimilados.stpSelLayoutBancomer98, strIdTipoMovimiento, "98", intIdLoteCargaNomina);
                        //asignar el No. de registros procesados para Tipo de Nomina 98-TDP
                        intNoRegistros98 = this.dbSAICAsimilados.stpSelLayoutBancomer98.Count;
                        if (this.dbSAICAsimilados.stpSelLayoutBancomer98.Count > 0)
                        {
                            List<Bancomer> objInfoBancariaEmpleadoList98 = BancomerDetalleBD.ObtenerInformacionBancariaEmpleado(this.dbSAICAsimilados.stpSelLayoutBancomer98);
                            intNoRegistrosPagos = objInfoBancariaEmpleadoList98.Count;    //No. Registros de Empleados/Asociados 
                            decImportePagos = BanamexDetalleTefDBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                                      //Generar Layout Bancario Bancomer 98-TDP
                            GenerarLayoutBancarioBancomer(objInfoBanco, objInfoBancariaEmpleadoList98, intIdLoteCargaNomina.ToString(), "98", intNoRegistrosPagos, decImportePagos, shNoSecuencialArchivo_IAS, strIdTipoMovimiento, strRutaArchivosXML);
                        }
                        else
                        {
                            sErroresLayout = "Error: C" + idControl + " - L" + intIdLoteCargaNomina.ToString() + " - Tenedora(" + intIdTenedora + ") " + sTenedoraRazonSocial + " - LayOut " + sBanco + " - " + sFormatoLayOut + " - " + "LayOuts sin empleados por generar.";
                        }

                        //XtraMessageBox.Show(string.Format(@"Se han generado los Layout Bancarios correctamente. Busque los archivos en la carpeta C:\LAYOUTS." +
                        //        "\n\n Registros procesados: \n\t Tipo Nómina 99(Cuentas)= {0} \n\t Tipo Nómina 98(TDP)= {1}",
                        //                    intNoRegistros99, intNoRegistros98), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } //if BANCOMER-XLS
                    else if (sFormatoLayOut.Equals("BANORTE-BANORTE PAG"))
                    {
                        int intNoEmisora = 0;
                        bool bEsNumerico = int.TryParse(sEmisora, out intNoEmisora);

                        if ((sEmisora.Length == 5) && (intNoEmisora > 0))        //que tenga valor y sea > 0
                        {
                            if (shNoSecuencialArchivo_IAS == -1)     //si es -1 entonces incrementar en 2 para convertir a 1
                                shNoSecuencialArchivo_IAS += 2;
                            else
                                shNoSecuencialArchivo_IAS += 1;        //incrementar secuencia archivo

                            //Obtener registros de la Informacion Bancaria de los Empleados. 
                            this.stpSelLayoutBanorte_IASTableAdapter1.Fill(this.dbSAICAsimilados.stpSelLayoutBanorte, strIdTipoMovimiento, intIdLoteCargaNomina);
                            //asignar el No. de registros procesados
                            intNoRegistrosPagos = this.dbSAICAsimilados.stpSelLayoutBanorte.Count;
                            if (this.dbSAICAsimilados.stpSelLayoutBanorte.Count > 0)
                            {
                                //generar fecha aplicacion pago
                                string strFechaAplicacion = dtFechaPago.Year.ToString() + dtFechaPago.Month.ToString().PadLeft(2, '0') + dtFechaPago.Day.ToString().PadLeft(2, '0');

                                List<BanorteDetalle> objInfoBancariaEmpleadoList = BanorteDetalleBD.ObtenerInformacionBancariaEmpleado(this.dbSAICAsimilados.stpSelLayoutBanorte, strFechaAplicacion);
                                intNoRegistrosPagos = objInfoBancariaEmpleadoList.Count;    //No. Registros de Empleados/Asociados 
                                decImportePagos = BanorteDetalleBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                                      //Generar Layout Bancario Banorte
                                GenerarLayoutBancarioBanorte(objInfoBanco, objInfoBancariaEmpleadoList, intIdLoteCargaNomina.ToString(), intNoRegistrosPagos, decImportePagos, strIdTipoMovimiento, strFechaAplicacion, sEmisora, shNoSecuencialArchivo_IAS, strFechaAplicacion);
                            }
                            else
                            {
                                sErroresLayout = "Error: C" + idControl + " - L" + intIdLoteCargaNomina.ToString() + " - Tenedora(" + intIdTenedora + ") " + sTenedoraRazonSocial + " - LayOut " + sBanco + " - " + sFormatoLayOut + " - " + "LayOuts sin empleados por generar.";
                            }

                            //XtraMessageBox.Show(string.Format(@"Se han generado los Layout Bancarios correctamente. Busque los archivos en la carpeta C:\LAYOUTS." +
                            //        "\n\n Registros procesados: {0}", intNoRegistrosPagos), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            XtraMessageBox.Show(string.Format(@"¡Debe escribir el No. de Emisora para generar el Layout BANORTE!"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //txtEmisora.Focus();     //colocar cursor en Emisora
                        }
                    } //if BANORTE-BANORTE PAG
                    else if (sFormatoLayOut.Equals("BANORTE-INTERBANCARIOS PAG"))
                    {
                        int intNoEmisora = 0;
                        bool bEsNumerico = int.TryParse(sEmisora, out intNoEmisora);

                        if ((sEmisora.Length == 5) && (intNoEmisora > 0))        //que tenga valor y sea > 0
                        {
                            if (shNoSecuencialArchivo_IAS == -1)     //si es -1 entonces incrementar en 2 para convertir a 1
                                shNoSecuencialArchivo_IAS += 2;
                            else
                                shNoSecuencialArchivo_IAS += 1;        //incrementar secuencia archivo

                            //Obtener registros de la Informacion Bancaria de los Empleados. 
                            this.stpSelLayoutBanorteInterbancario_IASTableAdapter1.Fill(this.dbSAICAsimilados.stpSelLayoutBanorteInterbancario, strIdTipoMovimiento, intIdLoteCargaNomina);
                            //asignar el No. de registros procesados
                            intNoRegistrosPagos = this.dbSAICAsimilados.stpSelLayoutBanorteInterbancario.Count;
                            if (this.dbSAICAsimilados.stpSelLayoutBanorteInterbancario.Count > 0)
                            {
                                //generar fecha aplicacion pago
                                string strFechaAplicacion = dtFechaPago.Year.ToString() + dtFechaPago.Month.ToString().PadLeft(2, '0') + dtFechaPago.Day.ToString().PadLeft(2, '0');

                                List<BanorteDetalle> objInfoBancariaEmpleadoList = BanorteDetalleBD.ObtenerInformacionBancariaEmpleado(this.dbSAICAsimilados.stpSelLayoutBanorteInterbancario, strFechaAplicacion);
                                intNoRegistrosPagos = objInfoBancariaEmpleadoList.Count;    //No. Registros de Empleados/Asociados 
                                decImportePagos = BanorteDetalleBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                                      //Generar Layout Bancario Banorte
                                GenerarLayoutBancarioBanorte(objInfoBanco, objInfoBancariaEmpleadoList, intIdLoteCargaNomina.ToString(), intNoRegistrosPagos, decImportePagos, strIdTipoMovimiento, strFechaAplicacion, sEmisora, shNoSecuencialArchivo_IAS, strRutaArchivosXML);
                            }
                            else
                            {
                                sErroresLayout = "Error: C" + idControl + " - L" + intIdLoteCargaNomina.ToString() + " - Tenedora(" + intIdTenedora + ") " + sTenedoraRazonSocial + " - LayOut " + sBanco + " - " + sFormatoLayOut + " - " + "LayOuts sin empleados por generar.";
                            }

                            //XtraMessageBox.Show(string.Format(@"Se han generado los Layout Bancarios correctamente. Busque los archivos en la carpeta C:\LAYOUTS." +
                            //        "\n\n Registros procesados: {0}", intNoRegistrosPagos), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            //XtraMessageBox.Show(string.Format(@"¡Debe escribir el No. de Emisora para generar el Layout BANORTE!"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //txtEmisora.Focus();     //colocar cursor en Emisora

                            sErroresLayout = "Error: C" + idControl + " - L" + intIdLoteCargaNomina.ToString() + " - Tenedora(" + intIdTenedora + ") " + sTenedoraRazonSocial + " - LayOut " + sBanco + " - " + sFormatoLayOut + " - " + "¡Debe escribir el No. de Emisora para generar el Layout BANORTE!";
                        }
                    } //if BANORTE-INTERBANCARIOS PAG
                    else if (sFormatoLayOut.Equals("SANTANDER-NOMINAS PAG"))
                    {
                        shNoSecuencialArchivo_IAS += 1;        //incrementar secuencia archivo
                                                               //Obtener registros de la Informacion Bancaria de los Empleados. 
                        this.stpSelLayoutSantander_IASTableAdapter1.Fill(this.dbSAICAsimilados.stpSelLayoutSantander, strIdTipoMovimiento, intIdLoteCargaNomina);
                        //asignar el No. de registros procesados
                        intNoRegistrosPagos = this.dbSAICAsimilados.stpSelLayoutSantander.Count;
                        if (this.dbSAICAsimilados.stpSelLayoutSantander.Count > 0)
                        {
                            //generar fecha aplicacion pago
                            string strFechaAplicacion = dtFechaPago.Month.ToString().PadLeft(2, '0') + dtFechaPago.Day.ToString().PadLeft(2, '0') + dtFechaPago.Year.ToString();

                            List<SantanderDetalle> objInfoBancariaEmpleadoList = SantanderDetalleBD.ObtenerInformacionBancariaNominasEmpleado(this.dbSAICAsimilados.stpSelLayoutSantander);
                            intNoRegistrosPagos = objInfoBancariaEmpleadoList.Count;    //No. Registros de Empleados/Asociados 
                            decImportePagos = SantanderDetalleBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                                    //Generar Layout Bancario Santander
                            GenerarLayoutBancarioSantander(objInfoBanco, objInfoBancariaEmpleadoList, intIdLoteCargaNomina.ToString(), intNoRegistrosPagos, decImportePagos, strIdTipoMovimiento, strFechaAplicacion, shNoSecuencialArchivo_IAS, strRutaArchivosXML);
                        }
                        else
                        {
                            sErroresLayout = "Error: C" + idControl + " - L" + intIdLoteCargaNomina.ToString() + " - Tenedora(" + intIdTenedora + ") " + sTenedoraRazonSocial + " - LayOut " + sBanco + " - " + sFormatoLayOut + " - " + "LayOuts sin empleados por generar.";
                        }

                        //XtraMessageBox.Show(string.Format(@"Se han generado los Layout Bancarios correctamente. Busque los archivos en la carpeta C:\LAYOUTS." +
                        //        "\n\n Registros procesados: {0}", intNoRegistrosPagos), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } //if SANTANDER-NOMINAS PAG                                                               
                    else if (sFormatoLayOut.Equals("CI BANCO-XLS"))
                    {
                        //Obtener registros de la Informacion Bancaria de los Empleados. 
                        this.stpSelLayoutCIBanco_IASTableAdapter1.Fill(this.dbSAICAsimilados.stpSelLayoutCIBanco, strIdTipoMovimiento, intIdLoteCargaNomina);
                        //asignar el No. de registros procesados
                        //intNoRegistrosPagos = this.dbSAICBPOReportesDataSet.stpSelLayoutCIBanco.Count;
                        if (this.dbSAICAsimilados.stpSelLayoutCIBanco.Count > 0)
                        {
                            List<CIBanco> objInfoBancariaEmpleadoList = CIBancoDetalleBD.ObtenerInformacionBancariaEmpleado(this.dbSAICAsimilados.stpSelLayoutCIBanco);
                            intNoRegistrosPagos = objInfoBancariaEmpleadoList.Count;    //No. Registros de Empleados/Asociados 
                            decImportePagos = CIBancoDetalleBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                                  //Generar Layout CI Banco
                            GenerarLayoutBancarioCIBanco(objInfoBanco, objInfoBancariaEmpleadoList, intNoRegistrosPagos, decImportePagos, sEmisora, strRutaArchivosXML);
                        }
                        else
                        {
                            sErroresLayout = "Error: C" + idControl + " - L" + intIdLoteCargaNomina.ToString() + " - Tenedora(" + intIdTenedora + ") " + sTenedoraRazonSocial + " - LayOut " + sBanco + " - " + sFormatoLayOut + " - " + "LayOuts sin empleados por generar.";
                        }

                        //XtraMessageBox.Show(string.Format(@"Se ha generado el Layout Bancario correctamente. Busque los archivos en la carpeta C:\LAYOUTS." +
                        //        "\n\n Registros procesados = {0}",
                        //                    intNoRegistrosPagos), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } //if CI BANCO-XLS
                    else if (sFormatoLayOut.Equals("HSBC-OTRAS CUENTAS HSBC"))
                    {
                        //validar leyenda dispersion
                        if (sLeyendaDeDisperson.Length > 0)
                        {
                            //Obtener registros de la Informacion Bancaria de los Empleados. 
                            this.stpSelLayoutHSBCOtrasCuentas_IASTableAdapter1.Fill(this.dbSAICAsimilados.stpSelLayoutHSBCOtrasCuentas, strIdTipoMovimiento, intIdLoteCargaNomina, sLeyendaDeDisperson);
                            //asignar el No. de registros procesados
                            if (this.dbSAICAsimilados.stpSelLayoutHSBCOtrasCuentas.Count > 0)
                            {
                                List<HSBCOtrasCuentas> objInfoBancariaEmpleadoList = HSBCBD.ObtenerInformacionBancariaEmpleadoOtrasCuentas(this.dbSAICAsimilados.stpSelLayoutHSBCOtrasCuentas);
                                intNoRegistrosPagos = objInfoBancariaEmpleadoList.Count;    //No. Registros de Empleados/Asociados 
                                decImportePagos = HSBCBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                            //Generar Layout HSBC
                                GenerarLayoutBancarioHSBCOtrasCuentas(objInfoBanco, objInfoBancariaEmpleadoList, intIdLoteCargaNomina.ToString(), intNoRegistrosPagos, decImportePagos, shNoSecuencialArchivo_IAS.ToString(), sLeyendaDeDisperson, strRutaArchivosXML);
                            }
                            else
                            {
                                sErroresLayout = "Error: C" + idControl + " - L" + intIdLoteCargaNomina.ToString() + " - Tenedora(" + intIdTenedora + ") " + sTenedoraRazonSocial + " - LayOut " + sBanco + " - " + sFormatoLayOut + " - " + "LayOuts sin empleados por generar.";
                            }

                            //XtraMessageBox.Show(string.Format(@"Se ha generado el Layout Bancario correctamente. Busque los archivos en la carpeta C:\LAYOUTS." +
                            //        "\n\n Registros procesados = {0}",
                            //                    intNoRegistrosPagos), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {

                            //XtraMessageBox.Show("¡Para generar el Layout Bancario HSBC debe \n seleccionar la Leyenda de Dispersión!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            //cboLeyendaDispersion.Focus();       //colocar curso en control
                            sErroresLayout = "Error: C" + idControl + " - L" + intIdLoteCargaNomina.ToString() + " - Tenedora(" + intIdTenedora + ") " + sTenedoraRazonSocial + " - LayOut " + sBanco + " - " + sFormatoLayOut + " - " + "¡Para generar el Layout Bancario HSBC debe \n seleccionar la Leyenda de Dispersión!";
                        }
                    } //if HSBC-OTRAS CUENTAS HSBC
                    else if (sFormatoLayOut.Equals("HSBC-INTERBANCARIO SPEI"))
                    {
                        //validar leyenda dispersion
                        if (sLeyendaDeDisperson.Length > 0)
                        {
                            //Obtener registros de la Informacion Bancaria de los Empleados. 
                            this.stpSelLayoutHSBCSPEI_IASTableAdapter1.Fill(this.dbSAICAsimilados.stpSelLayoutHSBCSPEI, strIdTipoMovimiento, intIdLoteCargaNomina, sLeyendaDeDisperson);
                            //asignar el No. de registros procesados
                            if (this.dbSAICAsimilados.stpSelLayoutHSBCSPEI.Count > 0)
                            {
                                List<HSBCSPEI> objInfoBancariaEmpleadoList = HSBCBD.ObtenerInformacionBancariaEmpleadoSPEI(this.dbSAICAsimilados.stpSelLayoutHSBCSPEI);
                                intNoRegistrosPagos = objInfoBancariaEmpleadoList.Count;    //No. Registros de Empleados/Asociados 
                                decImportePagos = HSBCBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                            //Generar Layout HSBC
                                GenerarLayoutBancarioHSBCSPEI(objInfoBanco, objInfoBancariaEmpleadoList, strIdTipoMovimiento, intIdLoteCargaNomina.ToString(), strRutaArchivosXML);
                            }
                            else
                            {
                                sErroresLayout = "Error: C" + idControl + " - L" + intIdLoteCargaNomina.ToString() + " - Tenedora(" + intIdTenedora + ") " + sTenedoraRazonSocial + " - LayOut " + sBanco + " - " + sFormatoLayOut + " - " + "LayOuts sin empleados por generar.";
                            }

                            //XtraMessageBox.Show(string.Format(@"Se ha generado el Layout Bancario correctamente. Busque los archivos en la carpeta C:\LAYOUTS." +
                            //        "\n\n Registros procesados = {0}",
                            //                    intNoRegistrosPagos), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            //XtraMessageBox.Show("¡Para generar el Layout Bancario HSBC debe \n seleccionar la Leyenda de Dispersión!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            //cboLeyendaDispersion.Focus();       //colocar curso en control
                            sErroresLayout = "Error: C" + idControl + " - L" + intIdLoteCargaNomina.ToString() + " - Tenedora(" + intIdTenedora + ") " + sTenedoraRazonSocial + " - LayOut " + sBanco + " - " + sFormatoLayOut + " - " + "¡Para generar el Layout Bancario HSBC debe \n seleccionar la Leyenda de Dispersión!";
                        }
                    } //if HSBC-INTERBANCARIO SPEI
                    else if (sFormatoLayOut.Equals("HSBC-NOMINAS"))
                    {
                        //validar leyenda dispersion
                        if (sLeyendaDeDisperson.Length > 0)
                        {
                            //Obtener registros de la Informacion Bancaria de los Empleados. 
                            this.stpSelLayoutHSBCNominas_IASTableAdapter1.Fill(this.dbSAICAsimilados.stpSelLayoutHSBCNominas, intIdLoteCargaNomina, sLeyendaDeDisperson);
                            //asignar el No. de registros procesados
                            if (this.dbSAICAsimilados.stpSelLayoutHSBCNominas.Count > 0)
                            {
                                List<HSBCNominas> objInfoBancariaEmpleadoList = HSBCBD.ObtenerInformacionBancariaEmpleadoNominas(this.dbSAICAsimilados.stpSelLayoutHSBCNominas);
                                intNoRegistrosPagos = objInfoBancariaEmpleadoList.Count;    //No. Registros de Empleados/Asociados 
                                decImportePagos = HSBCBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                            //Generar Layout HSBC
                                GenerarLayoutBancarioHSBCNominas(objInfoBanco, objInfoBancariaEmpleadoList, strIdTipoMovimiento, intIdLoteCargaNomina.ToString(), strRutaArchivosXML);
                            }
                            else
                            {
                                sErroresLayout = "Error: C" + idControl + " - L" + intIdLoteCargaNomina.ToString() + " - Tenedora(" + intIdTenedora + ") " + sTenedoraRazonSocial + " - LayOut " + sBanco + " - " + sFormatoLayOut + " - " + "LayOuts sin empleados por generar.";
                            }

                            //XtraMessageBox.Show(string.Format(@"Se ha generado el Layout Bancario correctamente. Busque los archivos en la carpeta C:\LAYOUTS." +
                            //        "\n\n Registros procesados = {0}",
                            //                    intNoRegistrosPagos), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            //XtraMessageBox.Show("¡Para generar el Layout Bancario HSBC debe \n seleccionar la Leyenda de Dispersión!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            //cboLeyendaDispersion.Focus();       //colocar curso en control
                            sErroresLayout = "Error: C" + idControl + " - L" + intIdLoteCargaNomina.ToString() + " - Tenedora(" + intIdTenedora + ") " + sTenedoraRazonSocial + " - LayOut " + sBanco + " - " + sFormatoLayOut + " - " + "¡Para generar el Layout Bancario HSBC debe \n seleccionar la Leyenda de Dispersión!";
                        }
                    } //if HSBC-NOMINAS
                    else if (sFormatoLayOut.Equals("HSBCNET-NOMINAS"))
                    {
                        //validar leyenda dispersion
                        if (sLeyendaDeDisperson.Length > 0)
                        {
                            //Obtener registros de la Informacion Bancaria de los Empleados. 
                            this.stpSelLayoutHSBCNETNominas_IASTableAdapter1.Fill(this.dbSAICAsimilados.stpSelLayoutHSBCNETNominas, strIdTipoMovimiento, intIdLoteCargaNomina, sLeyendaDeDisperson);
                            //asignar el No. de registros procesados
                            if (this.dbSAICAsimilados.stpSelLayoutHSBCNETNominas.Count > 0)
                            {
                                //generar fecha aplicacion pago
                                string strFechaAplicacion = dtFechaPago.Day.ToString().PadLeft(2, '0') + dtFechaPago.Month.ToString().PadLeft(2, '0') + dtFechaPago.Year.ToString();

                                List<HSBCNominas> objInfoBancariaEmpleadoList = HSBCBD.ObtenerInformacionBancariaEmpleadoNominas(this.dbSAICAsimilados.stpSelLayoutHSBCNETNominas);
                                intNoRegistrosPagos = objInfoBancariaEmpleadoList.Count;    //No. Registros de Empleados/Asociados 
                                decImportePagos = HSBCBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                            //Generar Layout HSBC
                                GenerarLayoutBancarioHSBCNETNominas(objInfoBanco, objInfoBancariaEmpleadoList, intIdLoteCargaNomina.ToString(), intNoRegistrosPagos, decImportePagos, strFechaAplicacion, sLeyendaDeDisperson, strIdTipoMovimiento, strRutaArchivosXML);
                            }
                            else
                            {
                                sErroresLayout = "Error: C" + idControl + " - L" + intIdLoteCargaNomina.ToString() + " - Tenedora(" + intIdTenedora + ") " + sTenedoraRazonSocial + " - LayOut " + sBanco + " - " + sFormatoLayOut + " - " + "LayOuts sin empleados por generar.";
                            }

                            //XtraMessageBox.Show(string.Format(@"Se ha generado el Layout Bancario correctamente. Busque los archivos en la carpeta C:\LAYOUTS." +
                            //        "\n\n Registros procesados = {0}",
                            //                    intNoRegistrosPagos), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            //XtraMessageBox.Show("¡Para generar el Layout Bancario HSBC debe \n seleccionar la Leyenda de Dispersión!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            //cboLeyendaDispersion.Focus();       //colocar curso en control
                            sErroresLayout = "Error: C" + idControl + " - L" + intIdLoteCargaNomina.ToString() + " - Tenedora(" + intIdTenedora + ") " + sTenedoraRazonSocial + " - LayOut " + sBanco + " - " + sFormatoLayOut + " - " + "¡Para generar el Layout Bancario HSBC debe \n seleccionar la Leyenda de Dispersión!";
                        }
                    }  //HSBCNET-NOMINAS
                    else if (sFormatoLayOut.Equals("INBURSA-INTERBANCARIO SPEI"))
                    {
                        //Obtener registros de la Informacion Bancaria de los Empleados. 
                        this.stpSelLayoutInbursaSPEI_IASTableAdapter1.Fill(this.dbSAICAsimilados.stpSelLayoutInbursaSPEI, intIdLoteCargaNomina, strIdTipoMovimiento);
                        //asignar el No. de registros procesados
                        if (this.dbSAICAsimilados.stpSelLayoutInbursaSPEI.Count > 0)
                        {
                            //generar fecha aplicacion pago
                            string strFechaAplicacion = dtFechaPago.Year.ToString() + dtFechaPago.Month.ToString().PadLeft(2, '0') + dtFechaPago.Day.ToString().PadLeft(2, '0');

                            List<InbursaSPEI> objInfoBancariaEmpleadoList = InbursaBD.ObtenerInformacionBancariaEmpleadoSPEI(this.dbSAICAsimilados.stpSelLayoutInbursaSPEI);
                            intNoRegistrosPagos = objInfoBancariaEmpleadoList.Count;    //No. Registros de Empleados/Asociados 
                            decImportePagos = InbursaBD.ImporteDetalle;    //Importe Total del Pago Nomina
                                                                           //Generar Layout Inbursa SPEI
                            GenerarLayoutBancarioInbursaSPEI(objInfoBanco, objInfoBancariaEmpleadoList, strIdTipoMovimiento, intIdLoteCargaNomina.ToString(), intNoRegistrosPagos, decImportePagos, strFechaAplicacion, strRutaArchivosXML);
                        }
                        else
                        {
                            sErroresLayout = "Error: C" + idControl + " - L" + intIdLoteCargaNomina.ToString() + " - Tenedora(" + intIdTenedora + ") " + sTenedoraRazonSocial + " - LayOut " + sBanco + " - " + sFormatoLayOut + " - " + "LayOuts sin empleados por generar.";
                        }

                        //XtraMessageBox.Show(string.Format(@"Se ha generado el Layout Bancario correctamente. Busque los archivos en la carpeta C:\LAYOUTS." +
                        //        "\n\n Registros procesados = {0}",
                        //                    intNoRegistrosPagos), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }  //INBURSA-INTERBANCARIO SPEI
                    else if (sFormatoLayOut.Equals("BANORTE-BANORTE PROV"))
                    {
                        if (shNoSecuencialArchivo_IAS == -1)     //si es -1 entonces incrementar en 2 para convertir a 1
                            shNoSecuencialArchivo_IAS += 2;
                        else
                            shNoSecuencialArchivo_IAS += 1;        //incrementar secuencia archivo

                        //Obtener registros de la Informacion Bancaria de los Empleados. 
                        this.stpSelLayoutBanorte2016_IASTableAdapter1.Fill(this.dbSAICAsimilados.stpSelLayoutBanorte2016, strIdTipoMovimiento, intIdLoteCargaNomina);
                        //asignar el No. de registros procesados
                        intNoRegistrosPagos = this.dbSAICAsimilados.stpSelLayoutBanorte2016.Count;
                        if (this.dbSAICAsimilados.stpSelLayoutBanorte2016.Count > 0)
                        {
                            //generar fecha aplicacion pago
                            string strFechaAplicacion = dtFechaPago.Day.ToString().PadLeft(2, '0') + dtFechaPago.Month.ToString().PadLeft(2, '0') + dtFechaPago.Year.ToString();

                            List<Banorte2016> objInfoBancariaEmpleadoList = BanorteDetalleBD.ObtenerInformacionBancariaEmpleado2016(this.dbSAICAsimilados.stpSelLayoutBanorte2016, strFechaAplicacion);
                            //Generar Layout Bancario Banorte
                            GenerarLayoutBancarioBanorte2016(objInfoBanco, objInfoBancariaEmpleadoList, intIdLoteCargaNomina.ToString(), strIdTipoMovimiento, strFechaAplicacion, sEmisora, shNoSecuencialArchivo_IAS, "BAN2BAN", strRutaArchivosXML);
                        }
                        else
                        {
                            sErroresLayout = "Error: C" + idControl + " - L" + intIdLoteCargaNomina.ToString() + " - Tenedora(" + intIdTenedora + ") " + sTenedoraRazonSocial + " - LayOut " + sBanco + " - " + sFormatoLayOut + " - " + "LayOuts sin empleados por generar.";
                        }

                        //XtraMessageBox.Show(string.Format(@"Se han generado los Layout Bancarios correctamente. Busque los archivos en la carpeta C:\LAYOUTS." +
                        //        "\n\n Registros procesados: {0}", intNoRegistrosPagos), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } //BANORTE-BANORTE PROVEEDOR
                    else if (sFormatoLayOut.Equals("BANORTE-INTERBANCARIOS PROV"))
                    {
                        if (shNoSecuencialArchivo_IAS == -1)     //si es -1 entonces incrementar en 2 para convertir a 1
                            shNoSecuencialArchivo_IAS += 2;
                        else
                            shNoSecuencialArchivo_IAS += 1;        //incrementar secuencia archivo

                        //Obtener registros de la Informacion Bancaria de los Empleados. 
                        this.stpSelLayoutBanorteInterbancario2016_IASTableAdapter1.Fill(this.dbSAICAsimilados.stpSelLayoutBanorteInterbancario2016, strIdTipoMovimiento, intIdLoteCargaNomina);
                        //asignar el No. de registros procesados
                        intNoRegistrosPagos = this.dbSAICAsimilados.stpSelLayoutBanorteInterbancario2016.Count;
                        if (this.dbSAICAsimilados.stpSelLayoutBanorteInterbancario2016.Count > 0)
                        {
                            //generar fecha aplicacion pago
                            string strFechaAplicacion = dtFechaPago.Day.ToString().PadLeft(2, '0') + dtFechaPago.Month.ToString().PadLeft(2, '0') + dtFechaPago.Year.ToString();

                            List<Banorte2016> objInfoBancariaEmpleadoList = BanorteDetalleBD.ObtenerInformacionBancariaEmpleado2016(this.dbSAICAsimilados.stpSelLayoutBanorteInterbancario2016, strFechaAplicacion);
                            //Generar Layout Bancario Banorte
                            GenerarLayoutBancarioBanorte2016(objInfoBanco, objInfoBancariaEmpleadoList, intIdLoteCargaNomina.ToString(), strIdTipoMovimiento, strFechaAplicacion, sEmisora, shNoSecuencialArchivo_IAS, "BAN2INT", strRutaArchivosXML);
                        }
                        else
                        {
                            sErroresLayout = "Error: C" + idControl + " - L" + intIdLoteCargaNomina.ToString() + " - Tenedora(" + intIdTenedora + ") " + sTenedoraRazonSocial + " - LayOut " + sBanco + " - " + sFormatoLayOut + " - " + "LayOuts sin empleados por generar.";
                        }

                        //XtraMessageBox.Show(string.Format(@"Se han generado los Layout Bancarios correctamente. Busque los archivos en la carpeta C:\LAYOUTS." +
                        //        "\n\n Registros procesados: {0}", intNoRegistrosPagos), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    } //BANORTE-INTERBANCARIOS PROVEEDOR

                    else if (sFormatoLayOut.Equals("SANTANDER-SANTANDER PROV"))
                    {
                        int idLote;

                        int.TryParse(intIdLoteCargaNomina.ToString(), out idLote);

                        if (idLote > 0)
                        {
                            try { stpSelLayOutBancarios_IASTableAdapter1.Fill(dbSAICAsimilados.stpSelLayOutBancarios, sFormatoLayOut, idLote); } catch (Exception) { }
                            if (dbSAICAsimilados.stpSelLayOutBancarios.Rows.Count > 0)
                            {
                                String stNombreArchivos = dbSAICAsimilados.stpSelLayOutBancarios.Rows[0]["NombreArchivo"].ToString();
                                stNombreArchivos = stNombreArchivos == String.Empty ? sFormatoLayOut + ".txt" : stNombreArchivos;

                                String stFormatoFecha = dbSAICAsimilados.stpSelLayOutBancarios.Rows[0]["FechaPagoFormato"].ToString();

                                intNoRegistrosPagos = GenerarLayoutBancarioSantander_1(dbSAICAsimilados.stpSelLayOutBancarios, stNombreArchivos, stFormatoFecha, sEmisora);
                            }
                            else
                            {
                                sErroresLayout = "Error: C" + idControl + " - L" + intIdLoteCargaNomina.ToString() + " - Tenedora(" + intIdTenedora + ") " + sTenedoraRazonSocial + " - LayOut " + sBanco + " - " + sFormatoLayOut + " - " + "LayOuts sin empleados por generar.";
                            }
                        }

                        //XtraMessageBox.Show(string.Format(@"Se han generado los Layout Bancarios correctamente. Busque los archivos en la carpeta C:\LAYOUTS." +
                        //   "\n\n Registros procesados: {0}", intNoRegistrosPagos), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (sFormatoLayOut.Equals("SANTANDER-INTERBANCARIOS PROV"))
                    {
                        int idLote;
                        int.TryParse(intIdLoteCargaNomina.ToString(), out idLote);

                        if (idLote > 0)
                        {
                            try { stpSelLayOutBancarios_IASTableAdapter1.Fill(dbSAICAsimilados.stpSelLayOutBancarios, sFormatoLayOut, idLote); } catch (Exception) { }
                            if (dbSAICAsimilados.stpSelLayOutBancarios.Rows.Count > 0)
                            {
                                String stNombreArchivos = dbSAICAsimilados.stpSelLayOutBancarios.Rows[0]["NombreArchivo"].ToString();
                                stNombreArchivos = stNombreArchivos == String.Empty ? sFormatoLayOut + ".txt" : stNombreArchivos;

                                String stFormatoFecha = dbSAICAsimilados.stpSelLayOutBancarios.Rows[0]["FechaPagoFormato"].ToString();

                                intNoRegistrosPagos = GenerarLayoutBancarioSantander_1(dbSAICAsimilados.stpSelLayOutBancarios, stNombreArchivos, stFormatoFecha, sEmisora);
                            }
                            else
                            {
                                sErroresLayout = "Error: C" + idControl + " - L" + intIdLoteCargaNomina.ToString() + " - Tenedora(" + intIdTenedora + ") " + sTenedoraRazonSocial + " - LayOut " + sBanco + " - " + sFormatoLayOut + " - " + "LayOuts sin empleados por generar.";
                            }
                        }

                        //XtraMessageBox.Show(string.Format(@"Se han generado los Layout Bancarios correctamente. Busque los archivos en la carpeta C:\LAYOUTS." +
                        //   "\n\n Registros procesados: {0}", intNoRegistrosPagos), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else//Todos los demas layOuts
                    {
                        int idLote;
                        int.TryParse(intIdLoteCargaNomina.ToString(), out idLote);

                        if (idLote > 0)
                        {
                            Boolean flagEstaMuyBien = true;

                            if (sFormatoLayOut.Contains("SCOTIABANK PAG"))
                            {
                                int intNoEmisora = 0;
                                bool bEsNumerico = int.TryParse(sEmisora, out intNoEmisora);

                                if ((sEmisora.Length != 5) || (intNoEmisora == 0))
                                {

                                    //XtraMessageBox.Show(string.Format(@"¡Debe escribir el No. de Emisora para generar el Layout SCOTIABANK!"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    sErroresLayout = "Error: C" + idControl + " - L" + intIdLoteCargaNomina.ToString() + " - Tenedora(" + intIdTenedora + ") " + sTenedoraRazonSocial + " - LayOut " + sBanco + " - " + sFormatoLayOut + " - " + "¡Debe escribir el No. de Emisora para generar el Layout SCOTIABANK!";
                                    //txtEmisora.Focus();     //colocar cursor en Emisora
                                    flagEstaMuyBien = false;
                                }
                            }

                            if (flagEstaMuyBien)
                            {
                                try { stpSelLayOutBancarios_IASTableAdapter1.Fill(dbSAICAsimilados.stpSelLayOutBancarios, sFormatoLayOut, idLote); } catch (Exception ex) { }
                                if (dbSAICAsimilados.stpSelLayOutBancarios.Rows.Count > 0)
                                {

                                    String stNombreArchivos = dbSAICAsimilados.stpSelLayOutBancarios.Rows[0]["NombreArchivo"].ToString();

                                    if (stNombreArchivos.Contains(".csv"))//validacion del tipo de archivo
                                    {
                                        stpSelLayoutKuspitBanPay_InterbancariosProv_IASTableAdapter1.Fill(dbSAICAsimilados.stpSelLayoutKuspitBanPay_InterbancariosProv, idLote, dtFechaPago.Date, (int)shNoSecuencialArchivo_IAS);
                                        String stRutaLayOut = strRutaArchivosXML;
                                        String stNombreArchivo = String.Empty;
                                        tools.dsc dsc = new tools.dsc();

                                        stNombreArchivo = stRutaLayOut + stNombreArchivos.Replace(".csv", "") + "_L" + idLote + "-" + dsc.nombreAleatorio() + ".csv";

                                        dsc.CheckandCreateFolder(stRutaLayOut);

                                        String stRutaSaic = dsc.stRutaSAICActualizacionDeLote;
                                        dsc.CheckandCreateFolder(stRutaSaic);
                                        gridControl1.ExportToCsv(stNombreArchivo);
                                        intNoRegistrosPagos = dbSAICAsimilados.stpSelLayoutKuspitBanPay_InterbancariosProv.Rows.Count > 0 ? dbSAICAsimilados.stpSelLayoutKuspitBanPay_InterbancariosProv.Rows.Count - 1 : 0;

                                    }
                                    else
                                    {
                                        stNombreArchivos = stNombreArchivos == String.Empty ? sFormatoLayOut + ".txt" : stNombreArchivos;

                                        String stFormatoFecha = dbSAICAsimilados.stpSelLayOutBancarios.Rows[0]["FechaPagoFormato"].ToString();

                                        intNoRegistrosPagos = GenerarLayoutBancarioSantander_1(dbSAICAsimilados.stpSelLayOutBancarios, stNombreArchivos, stFormatoFecha, sEmisora);
                                    }
                                }
                            }
                        }

                        //XtraMessageBox.Show(string.Format(@"Se han generado los Layout Bancarios correctamente. Busque los archivos en la carpeta C:\LAYOUTS." +
                        //   "\n\n Registros procesados: {0}", intNoRegistrosPagos), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    shNoSecuencialArchivo_IAS++;       //reasignar nuevo valor al NoSecuencial
                }   //this.dbSAICBPOValidacionDataSet.stpSelInfoBancoCuentasLayout.Count 
                else
                {
                    //XtraMessageBox.Show("¡La Tenedora seleccionada no tiene asociada \n Información Bancaria para realizar el Layout. \n Contacte a Aplicaciones de Negocio y Tesorería!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sErroresLayout = "Error: C" + idControl + " - L" + intIdLoteCargaNomina.ToString() + " - Tenedora(" + intIdTenedora + ") " + sTenedoraRazonSocial + " - LayOut " + sBanco + " - " + sFormatoLayOut + " - " + "¡La Tenedora seleccionada no tiene asociada, Información Bancaria para realizar el Layout. Contacte a Aplicaciones de Negocio y Tesorería!";
                }
            } //try
            catch (SqlException ex)
            {
                //XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sErroresLayout = "Error: C" + idControl + " - L" + intIdLoteCargaNomina.ToString() + " - Tenedora(" + intIdTenedora + ") " + sTenedoraRazonSocial + " - LayOut " + sBanco + " - " + sFormatoLayOut + " - " + ex.Message;
            }
            catch (Exception ex)
            {
                //XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sErroresLayout = "Error: C" + idControl + " - L" + intIdLoteCargaNomina.ToString() + " - Tenedora(" + intIdTenedora + ") " + sTenedoraRazonSocial + " - LayOut " + sBanco + " - " + sFormatoLayOut + " - " + ex.Message;
            }

            return sErroresLayout;
        }









        #region "Métodos Layouts"

        /// <summary>
        /// Seleccion de fecha de pago para el Lote
        /// </summary>
        /// <returns></returns>
        private DateTime solicitarFechaDePago()
        {
            DateTime dtFechaSeleccionada;
            using (var form = new tools.xFormsSolicitarFecha("Fecha de Pago", "Confirmar Fecha de Pago", "Seleccione Fecha de Pago:"))
            {
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

        /// <summary>
        /// Método para activar o desactivar combobox Leyenda Dispersion
        /// </summary>
        //private void MostrarLeyendaDispersion()
        //{
        //    if (cbBanco.Text.Equals("HSBC"))   //HSBC
        //    {
        //        lblLeyendaDispersion.Visible = true;
        //        cboLeyendaDispersion.Visible = true;
        //    }
        //    else
        //    {
        //        lblLeyendaDispersion.Visible = false;
        //        cboLeyendaDispersion.Visible = false;
        //    }

        //    cboLeyendaDispersion.SelectedIndex = -1;       //inicializar control
        //}

        /// <summary>
        /// Método para generar Layout Banamex TEF C
        /// </summary>
        /// <param name="objInfoBanco">Objeto con los Valores del Encabezado
        /// y Pie de Archivo de la Informacion Bancaria Tenedora</param>
        /// <param name="objInfoBancariaList">Objeto tipo Lista con los valores de los movimientos
        /// de cada pago por Empleado/Asociado</param>
        /// <param name="pFolioLoteCargaNomina">Clave Folio Lote de Carga</param>
        /// <param name="pIdTipoMovimientoBanco">Clave que otorga el Banco para clasificar el movimiento</param>
        /// <param name="pNoRegistrosPagos">No. total de movimientos de Empleados/Asociados procesados</param>
        /// <param name="pImportePagos">Importe total del pago de todos los movimientos individuales de
        /// Empleados/Asociados</param>
        /// <param name="pNoSecuenciaArchivo">No. de Archivo generado</param>
        /// <param name="pIdTipoMovimientoNomina">S=SUELDOS, A=ALIMENTOS</param>
        private void GenerarLayoutBancarioBanamexTEFC(InfoBancariaTenedora objInfoBanco, List<BanamexDetalleTefC> objInfoBancariaList, string pFolioLoteCargaNomina, string pIdTipoMovimientoBanco, Int32 pNoRegistrosPagos, decimal pImportePagos, short pNoSecuenciaArchivo, string pIdTipoMovimientoNomina, String sRuta, DateTime dtFechaPago)
        {
            BanamexTefC objTEFC = new BanamexTefC();
            string strLeyendaTipoMovimientoNomina = "SUELDOS";
            try
            {
                //informacion para asignar descripcion del archivo el Layout
                if (pIdTipoMovimientoNomina == "S")
                {
                    strLeyendaTipoMovimientoNomina = "SUELDOS";
                }
                else if (pIdTipoMovimientoNomina == "A")
                {
                    strLeyendaTipoMovimientoNomina = "ALIMENTOS";
                }
                else
                {
                    strLeyendaTipoMovimientoNomina = "ASIMILADOS";
                }

                //Control
                objTEFC.TipoRegistroControl = "1";      //constante
                objTEFC.NoIdentificacionCliente = objInfoBanco.NoCliente;
                objTEFC.FechaPago = dtFechaPago.Day.ToString().PadLeft(2, '0') + dtFechaPago.Month.ToString().PadLeft(2, '0') + dtFechaPago.Year.ToString().Substring(2, 2);
                objTEFC.SecuencialArchivo = pNoSecuenciaArchivo.ToString().PadLeft(4, '0');
                objTEFC.NombreEmpresa = objInfoBanco.RazonSocial;
                objTEFC.DescArchivo = strLeyendaTipoMovimientoNomina.PadRight(20, ' ');
                objTEFC.NaturalezaArchivo = pIdTipoMovimientoBanco;     //05=Tarjetas Banames ó 12= Cheques o Interbancarios
                objTEFC.InstruccionesOrdenesPago = ' '.ToString().PadRight(40, ' ');
                objTEFC.VersionLayout = "C";        //constante
                objTEFC.Volumen = "0";
                objTEFC.CaracteristicaArchivo = "0";
                //Global
                objTEFC.TipoRegistroGlobal = "2";       //constante
                objTEFC.TipoOperacionGlobal = "1";
                objTEFC.ClaveMonedaGlobal = "001";      //constante

                //generar formato del importe total sin PUNTO decimal
                string strImporte = FormatoNumeros.ObtenerNumeroSinDecimal(pImportePagos);
                objTEFC.ImporteAbonarPagar = strImporte.PadLeft(18, '0');
                objTEFC.TipoCuentaGlobal = "01";
                objTEFC.NoSucursalGlobal = objInfoBanco.NoSucursal;
                objTEFC.NoCuentaGlobal = objInfoBanco.NoCuenta;
                objTEFC.EspacioBlanco = ' '.ToString().PadLeft(20, ' ');
                //Total
                objTEFC.TipoRegistroTotal = "4";    //constante
                objTEFC.ClaveMonedaTotal = "001";
                objTEFC.NoAbonos = pNoRegistrosPagos.ToString().PadLeft(6, '0');
                objTEFC.ImporteTotalAbonos = strImporte.PadLeft(18, '0');
                objTEFC.NoCargos = "000001";
                objTEFC.ImporteTotalCargos = strImporte.PadLeft(18, '0');


                //Escribir archivo Layout TEF C
                FileInfo f = new FileInfo(string.Format(@"" + sRuta + @"\{0}L{1}-BXC{2}.{3}", pIdTipoMovimientoNomina, pFolioLoteCargaNomina, pIdTipoMovimientoBanco, "TXT"));
                StreamWriter w = f.CreateText();
                //Seccion Control
                w.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}", objTEFC.TipoRegistroControl, objTEFC.NoIdentificacionCliente,
                                                        objTEFC.FechaPago, objTEFC.SecuencialArchivo, objTEFC.NombreEmpresa,
                                                        objTEFC.DescArchivo, objTEFC.NaturalezaArchivo, objTEFC.InstruccionesOrdenesPago,
                                                        objTEFC.VersionLayout, objTEFC.Volumen, objTEFC.CaracteristicaArchivo);
                //Seccion Global
                w.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}", objTEFC.TipoRegistroGlobal, objTEFC.TipoOperacionGlobal,
                                                                        objTEFC.ClaveMonedaGlobal, objTEFC.ImporteAbonarPagar,
                                                                        objTEFC.TipoCuentaGlobal, objTEFC.NoSucursalGlobal,
                                                                        objTEFC.NoCuentaGlobal, objTEFC.EspacioBlanco);


                //Seccion Individual
                if (objInfoBancariaList.Count > 0)      //valido si existen valores en la lista
                {
                    for (int i = 0; i < objInfoBancariaList.Count; i++)     //recorrer cada uno de los elementos de la lista
                    {
                        BanamexDetalleTefC objTEFCDetalle = objInfoBancariaList[i];        //asignar los valores
                        string strRefAlfanumerica = "";
                        string strRefNumerica = "";

                        //si el tipo de movimiento Bancario es 05 => mantener las referencias originales
                        if (pIdTipoMovimientoBanco.Equals("05") || pIdTipoMovimientoBanco.Equals("07"))
                        {
                            strRefAlfanumerica = objTEFCDetalle.RefAlfanumerica.PadLeft(10, '0') + ' '.ToString().PadLeft(30, ' ');
                            strRefNumerica = objTEFCDetalle.RefNum.PadLeft(7, '0');
                        }
                        //si el tipo de movimiento Bancario es 12 => modificar las referencias originales
                        else if (pIdTipoMovimientoBanco.Equals("12"))
                        {
                            strRefAlfanumerica = objTEFCDetalle.RefAlfanumerica.PadRight(40, ' ');
                            strRefNumerica = objTEFCDetalle.RefNum.PadLeft(7, '0');
                        }

                        //enviar datos al archivo de texto
                        w.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}", objTEFCDetalle.TipoRegistro, objTEFCDetalle.TipoOperacion,
                                                                                objTEFCDetalle.ClaveMoneda,
                                                                                FormatoNumeros.ObtenerNumeroSinDecimal(objTEFCDetalle.Importe).PadLeft(18, '0'),
                                                                                objTEFCDetalle.TipoCuenta, objTEFCDetalle.NoCuentaBanco.PadLeft(20, '0'),
                                                                                strRefAlfanumerica,
                                                                                objTEFCDetalle.Beneficiario.PadRight(55, ' '), objTEFCDetalle.Instrucciones.PadRight(40, ' '),
                                                                                objTEFCDetalle.DescTEF.PadRight(24, ' '), objTEFCDetalle.ClaveBanco.PadLeft(4, '0'),
                                                                                strRefNumerica, objTEFCDetalle.Plazo.PadLeft(2, '0'));
                    }
                }


                //Seccion Total
                w.WriteLine("{0}{1}{2}{3}{4}{5}", objTEFC.TipoRegistroTotal, objTEFC.ClaveMonedaTotal,
                                                                objTEFC.NoAbonos, objTEFC.ImporteTotalAbonos,
                                                                objTEFC.NoCargos, objTEFC.ImporteTotalCargos);
                w.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("¡Error al generar Layout Bancario. \n{0} Contacte a Aplicaciones de Negocio!", ex.Message), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método para generar Layout Banamex TEF D
        /// </summary>
        /// <param name="objInfoBanco">Objeto con los Valores del Encabezado
        /// y Pie de Archivo de la Informacion Bancaria Tenedora</param>
        /// <param name="objInfoBancariaList">Objeto tipo Lista con los valores de los movimientos
        /// de cada pago por Empleado/Asociado</param>
        /// <param name="pFolioLoteCargaNomina">Clave Folio Lote de Carga</param>
        /// <param name="pIdTipoMovimientoBanco">Clave que otorga el Banco para clasificar el movimiento</param>
        /// <param name="pNoRegistrosPagos">No. total de movimientos de Empleados/Asociados procesados</param>
        /// <param name="pImportePagos">Importe total del pago de todos los movimientos individuales de
        /// Empleados/Asociados</param>
        /// <param name="pNoSecuenciaArchivo">No. de Archivo generado</param>
        /// <param name="pIdTipoMovimientoNomina">S=SUELDOS, A=ALIMENTOS</param>
        private void GenerarLayoutBancarioBanamexTEFD(InfoBancariaTenedora objInfoBanco, List<BanamexDetalleTefD> objInfoBancariaList, string pFolioLoteCargaNomina, string pIdTipoMovimientoBanco, Int32 pNoRegistrosPagos, decimal pImportePagos, short pNoSecuenciaArchivo, string pIdTipoMovimientoNomina, String sRuta, DateTime dtFechaPago)
        {
            BanamexTefD objTEFD = new BanamexTefD();
            string strLeyendaTipoMovimientoNomina = "SUELDOS";

            try
            {
                //informacion para asignar descripcion del archivo el Layout
                if (pIdTipoMovimientoNomina == "S")
                {
                    strLeyendaTipoMovimientoNomina = "SUELDOS";
                }
                else if (pIdTipoMovimientoNomina == "A")
                {
                    strLeyendaTipoMovimientoNomina = "ALIMENTOS";
                }
                else
                {
                    strLeyendaTipoMovimientoNomina = "ASIMILADOS";
                }

                //Control
                objTEFD.TipoRegistroControl = "1";      //constante
                objTEFD.NoIdentificacionCliente = objInfoBanco.NoCliente;
                objTEFD.FechaPago = dtFechaPago.Year.ToString().Substring(2, 2) + dtFechaPago.Month.ToString().PadLeft(2, '0') + dtFechaPago.Day.ToString().PadLeft(2, '0');
                objTEFD.SecuencialArchivo = pNoSecuenciaArchivo.ToString().PadLeft(4, '0');
                objTEFD.NombreEmpresa = objInfoBanco.RazonSocial;
                objTEFD.DescArchivo = strLeyendaTipoMovimientoNomina.PadRight(20, ' ');
                objTEFD.NaturalezaArchivo = "15";     //15=Constante
                objTEFD.VersionLayout = "D";        //constante
                objTEFD.TipoCargo = "01";           //constante
                //Global
                objTEFD.TipoRegistroGlobal = "2";       //constante
                objTEFD.TipoOperacionGlobal = "1";
                objTEFD.ClaveMonedaGlobal = "001";      //constante

                //generar formato del importe total sin PUNTO decimal
                string strImporte = FormatoNumeros.ObtenerNumeroSinDecimal(pImportePagos);
                objTEFD.ImporteAbonarPagar = strImporte.PadLeft(18, '0');
                objTEFD.TipoCuentaGlobal = "01";
                objTEFD.NoCuentaGlobal = (objInfoBanco.NoSucursal + objInfoBanco.NoCuenta.Substring(13, 7)).PadLeft(20, '0');
                objTEFD.TotalAbonos = pNoRegistrosPagos.ToString().PadLeft(6, '0');
                //Total
                objTEFD.TipoRegistroTotal = "4";    //constante
                objTEFD.ClaveMonedaTotal = "001";
                objTEFD.NoAbonos = pNoRegistrosPagos.ToString().PadLeft(6, '0');
                objTEFD.ImporteTotalAbonos = strImporte.PadLeft(18, '0');
                objTEFD.NoCargos = "000001";
                objTEFD.ImporteTotalCargos = strImporte.PadLeft(18, '0');


                //Escribir archivo Layout TEF C
                FileInfo f = new FileInfo(string.Format(@"" + sRuta + @"\{0}L{1}-BXD{2}.{3}", pIdTipoMovimientoNomina, pFolioLoteCargaNomina, pIdTipoMovimientoBanco, "TXT"));
                StreamWriter w = f.CreateText();
                //Seccion Control
                w.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}", objTEFD.TipoRegistroControl, objTEFD.NoIdentificacionCliente,
                                                        objTEFD.FechaPago, objTEFD.SecuencialArchivo, objTEFD.NombreEmpresa,
                                                        objTEFD.DescArchivo, objTEFD.NaturalezaArchivo,
                                                        objTEFD.VersionLayout, objTEFD.TipoCargo);
                //Seccion Global
                w.WriteLine("{0}{1}{2}{3}{4}{5}{6}", objTEFD.TipoRegistroGlobal, objTEFD.TipoOperacionGlobal,
                                                                        objTEFD.ClaveMonedaGlobal, objTEFD.ImporteAbonarPagar,
                                                                        objTEFD.TipoCuentaGlobal, objTEFD.NoCuentaGlobal,
                                                                        objTEFD.TotalAbonos);


                //Seccion Individual
                if (objInfoBancariaList.Count > 0)      //valido si existen valores en la lista
                {
                    for (int i = 0; i < objInfoBancariaList.Count; i++)     //recorrer cada uno de los elementos de la lista
                    {
                        BanamexDetalleTefD objTEFDDetalle = objInfoBancariaList[i];        //asignar los valores
                        //enviar datos al archivo de texto
                        w.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}",
                                                                                objTEFDDetalle.TipoRegistro, objTEFDDetalle.TipoOperacion,
                                                                                objTEFDDetalle.MetodoPago, objTEFDDetalle.TipoPago, objTEFDDetalle.ClaveMoneda,
                                                                                FormatoNumeros.ObtenerNumeroSinDecimal(objTEFDDetalle.Importe).PadLeft(18, '0'),
                                                                                objTEFDDetalle.TipoCuenta, objTEFDDetalle.NoCuentaBanco.PadLeft(20, '0'),
                                                                                objTEFDDetalle.RefAlfanumerica.PadRight(16, ' '),
                                                                                objTEFDDetalle.Beneficiario.PadRight(55, ' '), objTEFDDetalle.Referencia1.PadRight(35, ' '),
                                                                                objTEFDDetalle.Referencia2.PadRight(35, ' '), objTEFDDetalle.Referencia3.PadRight(35, ' '),
                                                                                objTEFDDetalle.Referencia4.PadRight(35, ' '), objTEFDDetalle.ClaveBanco.PadLeft(4, '0'),
                                                                                objTEFDDetalle.Plazo.PadLeft(2, '0'), objTEFDDetalle.RFC.PadRight(14, ' '),
                                                                                objTEFDDetalle.IVA.PadRight(8, ' '), objTEFDDetalle.UsoFuturo1.PadRight(80, ' '),
                                                                                objTEFDDetalle.UsoFuturo2.PadRight(50, ' '));
                    }
                }


                //Seccion Total
                w.WriteLine("{0}{1}{2}{3}{4}{5}", objTEFD.TipoRegistroTotal, objTEFD.ClaveMonedaTotal,
                                                                objTEFD.NoAbonos, objTEFD.ImporteTotalAbonos,
                                                                objTEFD.NoCargos, objTEFD.ImporteTotalCargos);
                w.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("¡Error al generar Layout Bancario. \n{0} Contacte a Aplicaciones de Negocio!", ex.Message), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Método para generar Layout Bancomer Nomina-TDP
        /// </summary>
        /// <param name="objInfoBanco">Objeto con los Valores del Encabezado
        /// y Pie de Archivo de la Informacion Bancaria Tenedora</param>
        /// <param name="objInfoBancariaList">Objeto tipo Lista con los valores de los movimientos
        /// de cada pago por Empleado/Asociado</param>
        /// <param name="pFolioLoteCargaNomina">Clave Folio Lote de Carga</param>
        /// <param name="pIdTipoMovimientoBanco">Clave que otorga el Banco para clasificar el movimiento</param>
        /// <param name="pNoRegistrosPagos">No. total de movimientos de Empleados/Asociados procesados</param>
        /// <param name="pImportePagos">Importe total del pago de todos los movimientos individuales de
        /// Empleados/Asociados</param>
        /// <param name="pNoSecuenciaArchivo">No. de Archivo generado</param>
        /// <param name="pIdTipoMovimientoNomina">S=SUELDOS, A=ALIMENTOS</param>
        private void GenerarLayoutBancarioBancomer(InfoBancariaTenedora objInfoBanco, List<Bancomer> objInfoBancariaList, string pFolioLoteCargaNomina, string pIdTipoMovimientoBanco, Int32 pNoRegistrosPagos, decimal pImportePagos, short pNoSecuenciaArchivo, string pIdTipoMovimientoNomina, String sRuta)
        {
            Bancomer objBBVA = new Bancomer();

            try
            {
                //Escribir archivo Layout Bancomer
                FileInfo f = new FileInfo(string.Format(sRuta + @"\{0}L{1}-BBVA{2}.{3}", pIdTipoMovimientoNomina, pFolioLoteCargaNomina, pIdTipoMovimientoBanco, "TXT"));
                StreamWriter w = f.CreateText();

                //Seccion Detalle
                if (objInfoBancariaList.Count > 0)      //valido si existen valores en la lista
                {
                    for (int i = 0; i < objInfoBancariaList.Count; i++)     //recorrer cada uno de los elementos de la lista
                    {
                        Bancomer objBBVADetalle = objInfoBancariaList[i];        //asignar los valores
                        //enviar datos al archivo de texto
                        w.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}",
                                                                                objBBVADetalle.NoRenglon.PadLeft(9, '0'),
                                                                                objBBVADetalle.RFC.PadRight(16, ' '),
                                                                                objBBVADetalle.TipoCuenta,
                                                                                objBBVADetalle.NoCuenta.PadRight(20, ' '),
                                                                                FormatoNumeros.ObtenerNumeroSinDecimal(objBBVADetalle.Importe).PadLeft(15, '0'),
                                                                                objBBVADetalle.Beneficiario.PadRight(40, ' '),
                                                                                objBBVADetalle.BancoDestino,
                                                                                objBBVADetalle.PlazaDestino);
                    }
                }
                w.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("¡Error al generar Layout Bancario. \n{0} Contacte a Aplicaciones de Negocio!", ex.Message), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Método para generar Layout Banorte 
        /// </summary>
        /// <param name="objInfoBanco">Objeto con los Valores del Encabezado
        /// y Pie de Archivo de la Informacion Bancaria Tenedora</param>
        /// <param name="objInfoBancariaList">Objeto tipo Lista con los valores de los movimientos
        /// de cada pago por Empleado/Asociado</param>
        /// <param name="pEmisora">Clave de Emisora</param>
        /// <param name="pFechaProceso">Fecha del Proceso de la Nomina</param>
        /// <param name="pFolioLoteCargaNomina">Clave Folio Lote de Carga</param>
        /// <param name="pIdTipoMovimientoBanco">Clave que otorga el Banco para clasificar el movimiento</param>
        /// <param name="pNoRegistrosPagos">No. total de movimientos de Empleados/Asociados procesados</param>
        /// <param name="pImportePagos">Importe total del pago de todos los movimientos individuales de
        /// Empleados/Asociados</param>
        /// <param name="pNoSecuenciaArchivo">No. de Archivo generado</param>
        /// <param name="pIdTipoMovimientoNomina">S=SUELDOS, A=ALIMENTOS</param>
        private void GenerarLayoutBancarioBanorte(InfoBancariaTenedora objInfoBanco, List<BanorteDetalle> objInfoBancariaList, string pFolioLoteCargaNomina, Int32 pNoRegistrosPagos, decimal pImportePagos, string pIdTipoMovimientoNomina, string pFechaProceso, string pEmisora, short pNoSecuenciaArchivo, String sRuta)
        {
            Banorte objBanorte = new Banorte();
            try
            {
                //Encabezado
                objBanorte.TipoRegistro = "H";      //constante
                objBanorte.ClaveServicio = "NE";    //constante
                objBanorte.Emisora = pEmisora.PadLeft(5, '0');
                objBanorte.FechaProceso = dtFechaPago.Value.Year.ToString() + dtFechaPago.Value.Month.ToString().PadLeft(2, '0') + dtFechaPago.Value.Day.ToString().PadLeft(2, '0');
                objBanorte.SecuencialArchivoConsecutivo = pNoSecuenciaArchivo.ToString().PadLeft(2, '0');
                objBanorte.NoTotalRegistrosEnviados = pNoRegistrosPagos.ToString().PadLeft(6, '0');

                string strImporte = FormatoNumeros.ObtenerNumeroSinDecimal(pImportePagos);
                objBanorte.ImporteTotalRegistrosEnviados = strImporte.PadLeft(15, '0');

                objBanorte.NoTotalAltasEnviados = "0".PadRight(6, '0');
                objBanorte.ImporteTotalAltasEnviados = "0".PadRight(15, '0');

                objBanorte.NoTotalBajasEnviados = "0".PadRight(6, '0');
                objBanorte.ImporteTotalBajasEnviados = "0".PadRight(15, '0');

                objBanorte.NoTotalCuentasVerificar = "0".PadLeft(6, '0');
                if (pIdTipoMovimientoNomina == "A")
                    objBanorte.Accion = "8";
                else
                    objBanorte.Accion = "0";
                objBanorte.Filler = ' '.ToString().PadRight(77, ' ');

                //Escribir archivo Layout Banorte
                //se modificó 11/04/2013 porque banorte no acepta nombres Personalizados
                //la sintaxis del archivo es: NI + No. Emisora + Consecutivo + .pag
                //FileInfo f = new FileInfo(string.Format(@"C:\LAYOUTS\{0}L{1}-BAN{2}{3}.{4}", pIdTipoMovimientoNomina, pFolioLoteCargaNomina, objBanorte.Emisora, objBanorte.SecuencialArchivoConsecutivo, "pag"));
                FileInfo f = new FileInfo(string.Format(sRuta + @"\NI{2}{3}L{1}.{4}", pIdTipoMovimientoNomina, pFolioLoteCargaNomina, objBanorte.Emisora, objBanorte.SecuencialArchivoConsecutivo, "pag"));
                StreamWriter w = f.CreateText();
                //Seccion Encabezado
                w.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}", objBanorte.TipoRegistro, objBanorte.ClaveServicio, objBanorte.Emisora,
                                                        objBanorte.FechaProceso, objBanorte.SecuencialArchivoConsecutivo, objBanorte.NoTotalRegistrosEnviados,
                                                        objBanorte.ImporteTotalRegistrosEnviados, objBanorte.NoTotalAltasEnviados, objBanorte.ImporteTotalAltasEnviados,
                                                        objBanorte.NoTotalBajasEnviados, objBanorte.ImporteTotalBajasEnviados, objBanorte.NoTotalCuentasVerificar,
                                                        objBanorte.Accion, objBanorte.Filler);

                //Seccion Individual
                if (objInfoBancariaList.Count > 0)      //valido si existen valores en la lista
                {
                    for (int i = 0; i < objInfoBancariaList.Count; i++)     //recorrer cada uno de los elementos de la lista
                    {
                        BanorteDetalle objBanorteDetalle = objInfoBancariaList[i];        //asignar los valores

                        //enviar datos al archivo de texto
                        w.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}", objBanorteDetalle.TipoRegistro, objBanorteDetalle.FechaAplicacion,
                                                                                objBanorteDetalle.NoEmpleado, objBanorteDetalle.ReferenciaServicio,
                                                                                objBanorteDetalle.ReferenciaLeyenda,
                                                                                FormatoNumeros.ObtenerNumeroSinDecimal(objBanorteDetalle.Importe).PadLeft(15, '0'),
                                                                                objBanorteDetalle.NoBancoReceptor, objBanorteDetalle.TipoCuenta,
                                                                                objBanorteDetalle.NoCuenta, objBanorteDetalle.TipoMovimiento,
                                                                                objBanorteDetalle.Accion, objBanorteDetalle.ImporteIVAOperacion,
                                                                                objBanorteDetalle.Filler);
                    }
                }

                w.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("¡Error al generar Layout Bancario. \n{0} Contacte a Aplicaciones de Negocio!", ex.Message), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método para generar Layout Santander 
        /// </summary>
        /// <param name="objInfoBanco">Objeto con los Valores del Encabezado
        /// y Pie de Archivo de la Informacion Bancaria Tenedora</param>
        /// <param name="objInfoBancariaList">Objeto tipo Lista con los valores de los movimientos
        /// de cada pago por Empleado/Asociado</param>
        /// <param name="pEmisora">Clave de Emisora</param>
        /// <param name="pFechaProceso">Fecha del Proceso de la Nomina</param>
        /// <param name="pFolioLoteCargaNomina">Clave Folio Lote de Carga</param>
        /// <param name="pIdTipoMovimientoBanco">Clave que otorga el Banco para clasificar el movimiento</param>
        /// <param name="pNoRegistrosPagos">No. total de movimientos de Empleados/Asociados procesados</param>
        /// <param name="pImportePagos">Importe total del pago de todos los movimientos individuales de
        /// Empleados/Asociados</param>
        /// <param name="pNoSecuenciaArchivo">No. de Archivo generado</param>
        /// <param name="pIdTipoMovimientoNomina">S=SUELDOS, A=ALIMENTOS</param>
        private void GenerarLayoutBancarioSantander(InfoBancariaTenedora objInfoBanco, List<SantanderDetalle> objInfoBancariaList, string pFolioLoteCargaNomina, Int32 pNoRegistrosPagos, decimal pImportePagos, string pIdTipoMovimientoNomina, string pFechaProceso, short pNoSecuenciaArchivo, String sRutaLayOut)
        {
            Santander objSantander = new Santander();
            Int32 intConsecutivoRenglon = 1;
            string sDesconocido = "     ";
            try
            {
                //Encabezado
                objSantander.TipoRegistroEncabezado = "1";      //constante
                objSantander.SecuencialArchivoConsecutivo = pNoSecuenciaArchivo.ToString().PadLeft(5, '0');
                objSantander.Sentido = "E";    //constante
                objSantander.FechaGeneracion = pFechaProceso;
                objSantander.NoCuentaCargo = objInfoBanco.NoCuenta.PadLeft(16, ' ');
                objSantander.FechaAplicacion = pFechaProceso;

                //Total
                objSantander.TipoRegistroTotal = "3";       //constante
                objSantander.NoTotalRegistrosEnviados = pNoRegistrosPagos.ToString().PadLeft(5, '0');

                string strImporte = FormatoNumeros.ObtenerNumeroSinDecimal(pImportePagos);
                objSantander.ImporteTotalRegistrosEnviados = strImporte.PadLeft(18, '0');

                //Escribir archivo Layout Banorte
                FileInfo f = new FileInfo(string.Format(sRutaLayOut + @"\{0}L{1}-SAN_{2}.{3}", pIdTipoMovimientoNomina, pFolioLoteCargaNomina, objSantander.SecuencialArchivoConsecutivo, "TXT"));
                StreamWriter w = f.CreateText();

                //Seccion Encabezado
                w.WriteLine("{0}{1}{2}{3}{4}{5}", objSantander.TipoRegistroEncabezado, intConsecutivoRenglon.ToString().PadLeft(5, '0'),
                                                        objSantander.Sentido, objSantander.FechaGeneracion, objSantander.NoCuentaCargo, objSantander.FechaAplicacion);

                //Seccion Individual
                if (objInfoBancariaList.Count > 0)      //valido si existen valores en la lista
                {
                    for (int i = 0; i < objInfoBancariaList.Count; i++)     //recorrer cada uno de los elementos de la lista
                    {
                        SantanderDetalle objSantanderDetalle = objInfoBancariaList[i];        //asignar los valores
                        intConsecutivoRenglon++;    //incrementa en 1 el contador de renglones

                        //enviar datos al archivo de texto
                        w.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}", objSantanderDetalle.TipoRegistro, intConsecutivoRenglon.ToString().PadLeft(5, '0'),
                                                                                objSantanderDetalle.NoEmpleado,
                                                                                objSantanderDetalle.ApellidoPaterno,
                                                                                objSantanderDetalle.ApellidoMaterno, objSantanderDetalle.Nombre,
                                                                                objSantanderDetalle.NoCuenta,
                                                                                sDesconocido,
                                                                                FormatoNumeros.ObtenerNumeroSinDecimal(objSantanderDetalle.Importe).PadLeft(18, '0'));
                    }
                }
                intConsecutivoRenglon++;    //incrementa en 1 el contador de renglones
                //Seccion Total
                w.WriteLine("{0}{1}{2}{3}", objSantander.TipoRegistroTotal, intConsecutivoRenglon.ToString().PadLeft(5, '0'),
                                                        objSantander.NoTotalRegistrosEnviados, objSantander.ImporteTotalRegistrosEnviados);

                w.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("¡Error al generar Layout Bancario. \n{0} Contacte a Aplicaciones de Negocio!", ex.Message), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método para generar Layout CIBanco 
        /// </summary>
        /// <param name="objInfoBanco">Objeto con los Valores del Encabezado
        /// y Pie de Archivo de la Informacion Bancaria Tenedora</param>
        /// <param name="objInfoBancariaList">Objeto tipo Lista con los valores de los movimientos
        /// de cada pago por Empleado/Asociado</param>
        /// <param name="pFechaProceso">Fecha del Proceso de la Nomina</param>
        /// <param name="pCuentaCargo">Cuenta de Cargo de la empresa pagadora</param>
        /// <param name="pNoRegistrosPagos">No. total de movimientos de Empleados/Asociados procesados</param>
        /// <param name="pImportePagos">Importe total del pago de todos los movimientos individuales de
        /// Empleados/Asociados</param>
        /// <param name="pEmisora">Clave de Emisora (Empresa Pagadora)</param>
        private void GenerarLayoutBancarioCIBanco(InfoBancariaTenedora objInfoBanco, List<CIBanco> objInfoBancariaList, Int32 pNoRegistrosPagos, decimal pImportePagos, string pEmisora, String sRuta)
        {
            try
            {
                //Escribir archivo Layout CIBanco
                FileInfo f = new FileInfo(string.Format(sRuta + @"\O_{0}.{1}", objInfoBanco.NoCliente, "TXT"));
                StreamWriter w = f.CreateText();

                //Seccion Detalle
                if (objInfoBancariaList.Count > 0)      //valido si existen valores en la lista
                {
                    for (int i = 0; i < objInfoBancariaList.Count; i++)     //recorrer cada uno de los elementos de la lista
                    {
                        CIBanco objCIBancoDetalle = objInfoBancariaList[i];        //asignar los valores
                        //enviar datos al archivo de texto
                        w.WriteLine("{0},{1},{2},{3},{4},{5},{6}",
                                                                                objCIBancoDetalle.TipoPago,
                                                                                objInfoBanco.NoCuenta,
                                                                                string.Format("{0:0.00}", objCIBancoDetalle.Importe),    //formateo a 2 decimales
                                                                                objCIBancoDetalle.NoCuentaBanco,
                                                                                objCIBancoDetalle.Beneficiario, //.PadRight(35, ' '),
                                                                                objCIBancoDetalle.RFC.PadRight(13, ' '),
                                                                                objCIBancoDetalle.DescPago);
                    }
                    //anexar última línea al archivo
                    w.WriteLine("{0},{1},{2}", "T", pNoRegistrosPagos, string.Format("{0:0.00}", pImportePagos));
                }
                w.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("¡Error al generar Layout Bancario. \n{0} Contacte a Aplicaciones de Negocio!", ex.Message), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método para generar Layout HSBC Otras Cuentas HSBC 
        /// </summary>
        /// <param name="objInfoBanco">Objeto con los Valores del Encabezado
        /// y Pie de Archivo de la Informacion Bancaria Tenedora</param>
        /// <param name="objInfoBancariaList">Objeto tipo Lista con los valores de los movimientos
        /// de cada pago por Empleado/Asociado</param>
        ///<param name="pFolioLoteCargaNomina">No. Folio Lote carga Nomina</param>
        /// <param name="pNoRegistrosPagos">No. total de movimientos de Empleados/Asociados procesados</param>
        /// <param name="pImportePagos">Importe total del pago de todos los movimientos individuales de
        /// Empleados/Asociados</param>
        /// <param name="pConsecutivo">No. Consecutivo</param>
        private void GenerarLayoutBancarioHSBCOtrasCuentas(InfoBancariaTenedora objInfoBanco, List<HSBCOtrasCuentas> objInfoBancariaList, string pFolioLoteCargaNomina, Int32 pNoRegistrosPagos, decimal pImportePagos, string pConsecutivo, string pLeyendaDispersion, String sRuta)
        {
            Int32 intConsecutivoRenglon = 1;
            string strLeyendaConceptoFinArchivo = pLeyendaDispersion.PadRight(40, ' ');

            try
            {
                //Escribir archivo Layout HSBC
                FileInfo f = new FileInfo(string.Format(sRuta + @"\HSBC_OCT_L{0}.{1}", pFolioLoteCargaNomina, "TXT"));
                StreamWriter w = f.CreateText();

                //Seccion Detalle
                if (objInfoBancariaList.Count > 0)      //valido si existen valores en la lista
                {
                    for (int i = 0; i < objInfoBancariaList.Count; i++)     //recorrer cada uno de los elementos de la lista
                    {
                        HSBCOtrasCuentas objHSBCBancoDetalle = objInfoBancariaList[i];        //asignar los valores
                        //enviar datos al archivo de texto
                        w.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}",
                                                            intConsecutivoRenglon.ToString().PadLeft(6, '0'),
                                                            objInfoBanco.NoCuenta,
                                                            objHSBCBancoDetalle.NoCuentaBanco,
                                                            FormatoNumeros.ObtenerNumeroSinDecimal(objHSBCBancoDetalle.Importe).PadLeft(13, '0'),
                                                            objHSBCBancoDetalle.ClaveMoneda,
                                                            objHSBCBancoDetalle.DescPago,
                                                            objHSBCBancoDetalle.Beneficiario,
                                                            objHSBCBancoDetalle.ComprobanteFiscal,
                                                            objHSBCBancoDetalle.RFCBeneficiario,
                                                            objHSBCBancoDetalle.IVA,
                                                            objHSBCBancoDetalle.Email);
                        intConsecutivoRenglon++;
                    }
                    //anexar última línea al archivo
                    w.WriteLine("{0}{1}{2}", pConsecutivo.PadLeft(6, '0'), pNoRegistrosPagos.ToString().PadLeft(6, '0'), strLeyendaConceptoFinArchivo);
                }
                w.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("¡Error al generar Layout Bancario. \n{0} Contacte a Aplicaciones de Negocio!", ex.Message), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Método para generar Layout HSBC Interbancarios SPEI
        /// </summary>
        /// <param name="objInfoBanco">Objeto con los Valores del Encabezado
        /// y Pie de Archivo de la Informacion Bancaria Tenedora</param>
        /// <param name="objInfoBancariaList">Objeto tipo Lista con los valores de los movimientos
        /// de cada pago por Empleado/Asociado</param>
        ///<param name="pFolioLoteCargaNomina">No. Folio Lote carga Nomina</param>
        private void GenerarLayoutBancarioHSBCSPEI(InfoBancariaTenedora objInfoBanco, List<HSBCSPEI> objInfoBancariaList, string pIdTipoMovimientoNomina, string pFolioLoteCargaNomina, String sRuta)
        {
            try
            {
                //Escribir archivo Layout HSBC
                FileInfo f = new FileInfo(string.Format(sRuta + @"\{0}L{1}-HSBC_SPEI.{2}", pIdTipoMovimientoNomina, pFolioLoteCargaNomina, "TXT"));
                StreamWriter w = f.CreateText();

                //Seccion Detalle
                if (objInfoBancariaList.Count > 0)      //valido si existen valores en la lista
                {
                    for (int i = 0; i < objInfoBancariaList.Count; i++)     //recorrer cada uno de los elementos de la lista
                    {
                        HSBCSPEI objHSBCBancoDetalle = objInfoBancariaList[i];        //asignar los valores
                        //enviar datos al archivo de texto
                        w.WriteLine("{0}{1}{2}{3}{4}{5}{6}",
                                                objInfoBanco.NoCuenta,
                                                objInfoBanco.RefAlfanumerica.PadRight(18, ' '),
                                                objHSBCBancoDetalle.NoCuentaBanco,
                                                FormatoNumeros.ObtenerNumeroSinDecimal(objHSBCBancoDetalle.Importe).PadLeft(18, '0'),
                                                objHSBCBancoDetalle.ReferenciaNumerica,
                                                objHSBCBancoDetalle.DescPago,
                                                objHSBCBancoDetalle.DescPagoOrdenante);
                    }
                }
                w.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("¡Error al generar Layout Bancario. \n{0} Contacte a Aplicaciones de Negocio!", ex.Message), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Método para generar Layout HSBC Nomina
        /// </summary>
        /// <param name="objInfoBanco">Objeto con los Valores del Encabezado
        /// y Pie de Archivo de la Informacion Bancaria Tenedora</param>
        /// <param name="objInfoBancariaList">Objeto tipo Lista con los valores de los movimientos
        /// de cada pago por Empleado/Asociado</param>
        ///<param name="pFolioLoteCargaNomina">No. Folio Lote carga Nomina</param>
        private void GenerarLayoutBancarioHSBCNominas(InfoBancariaTenedora objInfoBanco, List<HSBCNominas> objInfoBancariaList, string pIdTipoMovimientoNomina, string pFolioLoteCargaNomina, String sRuta)
        {
            try
            {
                //Escribir archivo Layout HSBC
                FileInfo f = new FileInfo(string.Format(sRuta + @"\{0}L{1}-HSBC_NOM.{2}", pIdTipoMovimientoNomina, pFolioLoteCargaNomina, "TXT"));
                StreamWriter w = f.CreateText();

                //Seccion Detalle
                if (objInfoBancariaList.Count > 0)      //valido si existen valores en la lista
                {
                    for (int i = 0; i < objInfoBancariaList.Count; i++)     //recorrer cada uno de los elementos de la lista
                    {
                        HSBCNominas objHSBCBancoDetalle = objInfoBancariaList[i];        //asignar los valores
                        //enviar datos al archivo de texto
                        w.WriteLine("{0}{1}{2}{3}",
                                                objHSBCBancoDetalle.NoCuentaBanco,
                                                FormatoNumeros.ObtenerNumeroSinDecimal(objHSBCBancoDetalle.Importe).PadLeft(13, '0'),
                                                objHSBCBancoDetalle.DescPago,
                                                objHSBCBancoDetalle.Beneficiario.PadRight(40, ' '));
                    }
                }
                w.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("¡Error al generar Layout Bancario. \n{0} Contacte a Aplicaciones de Negocio!", ex.Message), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Método para generar Layout HSBC Nomina
        /// </summary>
        /// <param name="objInfoBanco">Objeto con los Valores del Encabezado
        /// y Pie de Archivo de la Informacion Bancaria Tenedora</param>
        /// <param name="objInfoBancariaList">Objeto tipo Lista con los valores de los movimientos
        /// de cada pago por Empleado/Asociado</param>
        ///<param name="pFolioLoteCargaNomina">No. Folio Lote carga Nomina</param>
        private void GenerarLayoutBancarioHSBCNETNominas(InfoBancariaTenedora objInfoBanco, List<HSBCNominas> objInfoBancariaList, string pFolioLoteCargaNomina, Int32 pNoRegistrosPagos, decimal pImportePagos, string pFechaProceso, string pReferenciaLote, string pIdTipoMovimientoNomina, String sRuta)
        {
            HSBCNET objHSBCNet = new HSBCNET();

            try
            {
                objHSBCNet.IndicadorFormatoArchivo = "MXPRLF";
                objHSBCNet.NivelAutorizacion = "F";     //constante
                objHSBCNet.NoCuentaCargo = objInfoBanco.NoCuenta.PadLeft(10, '0');

                string strImporte = FormatoNumeros.ObtenerNumeroSinDecimal(pImportePagos);
                objHSBCNet.ImporteTotalRegistrosEnviados = strImporte.PadLeft(14, '0');
                objHSBCNet.NoTotalRegistrosEnviados = pNoRegistrosPagos.ToString().PadLeft(7, '0');
                objHSBCNet.FechaAplicacion = pFechaProceso;
                objHSBCNet.HoraAplicacion = "".PadRight(5, ' ');
                objHSBCNet.ReferenciaLote = pReferenciaLote.PadRight(34, ' ');

                //Escribir archivo Layout HSBCNET
                FileInfo f = new FileInfo(string.Format(sRuta + @"\{0}L{1}-HSBCNET_NOM.{2}", pIdTipoMovimientoNomina, pFolioLoteCargaNomina, "TXT"));
                StreamWriter w = f.CreateText();

                //Seccion Encabezado
                w.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}", objHSBCNet.IndicadorFormatoArchivo, objHSBCNet.NivelAutorizacion,
                        objHSBCNet.NoCuentaCargo, objHSBCNet.ImporteTotalRegistrosEnviados,
                        objHSBCNet.NoTotalRegistrosEnviados, objHSBCNet.FechaAplicacion,
                        objHSBCNet.HoraAplicacion, objHSBCNet.ReferenciaLote);


                //Seccion Detalle
                if (objInfoBancariaList.Count > 0)      //valido si existen valores en la lista
                {
                    for (int i = 0; i < objInfoBancariaList.Count; i++)     //recorrer cada uno de los elementos de la lista
                    {
                        HSBCNominas objHSBCBancoDetalle = objInfoBancariaList[i];        //asignar los valores
                        //enviar datos al archivo de texto
                        w.WriteLine("{0}{1}{2}{3}",
                                                objHSBCBancoDetalle.NoCuentaBanco,
                                                FormatoNumeros.ObtenerNumeroSinDecimal(objHSBCBancoDetalle.Importe).PadLeft(14, '0'),
                                                objHSBCBancoDetalle.DescPago,
                                                objHSBCBancoDetalle.Beneficiario.PadRight(35, ' '));
                    }
                }
                w.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("¡Error al generar Layout Bancario. \n{0} Contacte a Aplicaciones de Negocio!", ex.Message), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Método para generar Layout Inbursa SPEI
        /// </summary>
        /// <param name="objInfoBanco">Objeto con los Valores del Encabezado
        /// y Pie de Archivo de la Informacion Bancaria Tenedora</param>
        /// <param name="objInfoBancariaList">Objeto tipo Lista con los valores de los movimientos
        /// de cada pago por Empleado/Asociado</param>
        ///<param name="pFolioLoteCargaNomina">No. Folio Lote carga Nomina</param>
        private void GenerarLayoutBancarioInbursaSPEI(InfoBancariaTenedora objInfoBanco, List<InbursaSPEI> objInfoBancariaList, string pIdTipoMovimiento, string pFolioLoteCargaNomina, Int32 pNoRegistrosPagos, decimal pImportePagos, string pFechaProceso, String sRuta)
        {
            Inbursa objInbursa = new Inbursa();     //objeto para informacion Encabezado Layout Inbursa

            try
            {
                objInbursa.FechaAplicacion = pFechaProceso;
                objInbursa.NoSucursal = objInfoBanco.NoSucursal;
                objInbursa.NoCuentaCargo = objInfoBanco.NoCuenta;
                objInbursa.NoTotalRegistrosEnviados = pNoRegistrosPagos.ToString().PadLeft(5, '0');

                string strImporte = pImportePagos.ToString("N2");
                objInbursa.ImporteTotalRegistrosEnviados = strImporte.Replace(",", "").PadLeft(15, '0');

                //Escribir archivo Layout Inbursa SPEI
                FileInfo f = new FileInfo(string.Format(sRuta + @"\{0}L{1}-INBUR_SPEI.{2}", pIdTipoMovimiento, pFolioLoteCargaNomina, "TXT"));
                StreamWriter w = f.CreateText();

                //Seccion Encabezado
                w.WriteLine("{0}\t{1}", objInbursa.NoTotalRegistrosEnviados, objInbursa.ImporteTotalRegistrosEnviados);


                //Seccion Detalle
                if (objInfoBancariaList.Count > 0)      //valido si existen valores en la lista
                {
                    for (int i = 0; i < objInfoBancariaList.Count; i++)     //recorrer cada uno de los elementos de la lista
                    {
                        InbursaSPEI objInbursaBancoDetalle = objInfoBancariaList[i];        //asignar los valores
                        //enviar datos al archivo de texto
                        w.WriteLine("{0}\t{1}{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}",
                                                objInbursa.FechaAplicacion,
                                                objInbursa.NoSucursal,
                                                objInbursa.NoCuentaCargo,
                                                objInbursaBancoDetalle.NoCuentaBanco,
                                                objInbursaBancoDetalle.Importe.ToString("N2").Replace(",", "").PadLeft(15, '0'),
                                                objInbursaBancoDetalle.ReferenciaLeyenda,
                                                objInbursaBancoDetalle.ReferenciaExt,
                                                objInbursaBancoDetalle.ReferenciaNumerica,
                                                objInbursaBancoDetalle.RFC,
                                                objInbursaBancoDetalle.Identificador);
                    }
                }
                w.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("¡Error al generar Layout Bancario. \n{0} Contacte a Aplicaciones de Negocio!", ex.Message), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método para generar Layout Banorte Proveedores
        /// </summary>
        /// <param name="objInfoBanco">Objeto con información del Banco</param>
        /// <param name="objInfoBancariaEmpleadoList">Objeto tipo Lista con los valores de los movimientos
        /// de cada pago por Empleado/Asociado</param>
        /// <param name="pFolioLoteCargaNomina">No. Lote Nómina</param>
        /// <param name="pIdTipoMovimientoNomina">Tipo de Movimiento</param>
        /// <param name="pFechaProceso">Fecha de la Operación</param>
        /// <param name="pEmisora">No. Emisora (NO SE UTILIZA)</param>
        /// <param name="pNoSecuenciaArchivo">No. Consecutivo Archivo</param>
        /// <param name="pTipoLayout">Clave para identificar Banorte-Banorte y Banorte-Interbancario</param>
        private void GenerarLayoutBancarioBanorte2016(InfoBancariaTenedora objInfoBanco, List<Banorte2016> objInfoBancariaEmpleadoList, string pFolioLoteCargaNomina, string pIdTipoMovimientoNomina, string pFechaProceso, string pEmisora, short pNoSecuenciaArchivo, string pTipoLayout, String sRuta)
        {
            Banorte2016 objBanorte = new Banorte2016();
            try
            {
                FileInfo f = null;

                if (pTipoLayout.Equals("BAN2BAN"))
                {
                    //la sintaxis del archivo es: BAN2BANPROV_ + TIPO NOMINA + L + LOTE NOMINA + .TXT
                    f = new FileInfo(string.Format(sRuta + @"\BAN2BANPROV_{0}L{1}.{2}", pIdTipoMovimientoNomina, pFolioLoteCargaNomina, "txt"));
                }
                else if (pTipoLayout.Equals("BAN2INT"))
                {
                    //la sintaxis del archivo es: BAN2INTPROV_ + TIPO NOMINA + L + LOTE NOMINA + .TXT
                    f = new FileInfo(string.Format(sRuta + @"\BAN2INTPROV_{0}L{1}.{2}", pIdTipoMovimientoNomina, pFolioLoteCargaNomina, "txt"));
                }
                StreamWriter w = f.CreateText();

                //Seccion Detalle
                if (objInfoBancariaEmpleadoList.Count > 0)      //valido si existen valores en la lista
                {
                    for (int i = 0; i < objInfoBancariaEmpleadoList.Count; i++)     //recorrer cada uno de los elementos de la lista
                    {
                        Banorte2016 objBanorteDetalle = objInfoBancariaEmpleadoList[i];        //asignar los valores

                        //enviar datos al archivo de texto
                        w.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}\t{10}", objBanorteDetalle.Operacion, objBanorteDetalle.ClaveID,
                                                                                objInfoBanco.NoCuenta.Substring(10, objInfoBanco.NoCuenta.Length - 10), objBanorteDetalle.NoCuentaBanco,
                                                                                string.Format("{0:0.00}", objBanorteDetalle.Importe),
                                                                                objBanorteDetalle.Referencia, objBanorteDetalle.Descripcion,
                                                                                objBanorteDetalle.RFCOrdenante, objBanorteDetalle.IVA,
                                                                                "", objBanorteDetalle.InstruccionPago);
                    }
                }

                w.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("¡Error al generar Layout Bancario. \n{0} Contacte a Aplicaciones de Negocio!", ex.Message), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método que genera la visualización de los registros procesados
        /// en el Layout Bancario Banamex
        /// </summary>
        /// <param name="objTarjetasCheques">DataTable con Tarjetas y Cheques</param>
        /// <param name="objInterbancarios">DataTable con Interbancarios</param>
        private void VisualizarRelacionMovimientosBancariosLayout(DataTable objTarjetasCheques, DataTable objInterbancarios)
        {
            try
            {
                /*                frmxVisualizarRelacionMovimientos objVisualizarRelacionMovimientos = new frmxVisualizarRelacionMovimientos();
                                //asignar DataTable
                                objVisualizarRelacionMovimientos.dtMovsTarjetasCheques = objTarjetasCheques;
                                objVisualizarRelacionMovimientos.dtMovsInterbancarios = objInterbancarios;
                                objVisualizarRelacionMovimientos.ShowDialog();      //mostrar pantalla
                 */
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("¡Error al Visualizar la Relación de Movimientos \n {0}. Contacte a Aplicaciones de Negocio!", ex.Message), "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GenerarLayoutBancarioSantander_1(DataTable dtstpSelLayOutBancarios, String stNombreLayOut, String stFormatoFecha, string pEmisora)
        {
            int intNoRegistrosPagos = 0;
            String stRutaLayOut = string.Format(@"{0}\", strRutaArchivosXML);   // @"C:\LAYOUTS\";

            try
            {
                if (dtstpSelLayOutBancarios.Rows.Count > 0)
                {
                    dsc.CheckandCreateFolder(stRutaLayOut);
                    List<String> ListaEmpleados = new List<String>();

                    foreach (DataRow item in dtstpSelLayOutBancarios.Rows)
                    {
                        if (!String.IsNullOrEmpty(item["LayOut"].ToString()))
                        {
                            ListaEmpleados.Add(item["LayOut"].ToString());
                        }
                    }

                    //Agregando la fecha de Pago en el Layout
                    for (int i = 0; i < ListaEmpleados.Count; i++)
                    {
                        if (ListaEmpleados[i].Contains("@pFechaPago")) // Actualizando fecha de Pago en el LayOut
                        {
                            ListaEmpleados[i] = ListaEmpleados[i].Replace("@pFechaPago", dtFechaPago.Value.Date.ToString(stFormatoFecha));
                        }
                        if (ListaEmpleados[i].Contains("@pEmisora"))// Actualizando la Emisora en el LayOUt
                        {
                            ListaEmpleados[i] = ListaEmpleados[i].Replace("@pEmisora", pEmisora);
                        }
                    }

                    File.WriteAllLines(stRutaLayOut + stNombreLayOut, ListaEmpleados);
                    int.TryParse(dtstpSelLayOutBancarios.Rows[0]["NumeroDeRegistros"].ToString(), out intNoRegistrosPagos);
                }
            }
            catch (Exception)
            {
                intNoRegistrosPagos = 0;
            }

            return intNoRegistrosPagos;
        }


        #endregion

        private Estructuras.InformacionError MostrarReporte(Int64 pIdControl, string sRutaArchivosPDF)
        {
            //inicializar valores de objError
            Estructuras.InformacionError objError = new Estructuras.InformacionError { existeError = false, noError = 0, mensajeError = String.Empty };

            //crear reporte
            ReporteControlOperaciones report = new ReporteControlOperaciones();
            try
            {
                //asignar parametros del reporte
                report.Parameters["pIdControlOperaciones"].Value = pIdControl;
                report.Parameters["pSaldo"].Value = pSaldo;
                report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes
                // Asignar opciones de Exportacion
                PdfExportOptions pdfOptions = report.ExportOptions.Pdf;
                pdfOptions.Compressed = true;
                pdfOptions.ImageQuality = PdfJpegImageQuality.Highest;
                pdfOptions.NeverEmbeddedFonts = "Tahoma;Courier New";
                pdfOptions.DocumentOptions.Author = "Gabriela Rodriguez C.";
                pdfOptions.DocumentOptions.Keywords = "Reporte, Control, Operaciones";
                pdfOptions.DocumentOptions.Title = "Reporte del Control de Operaciones";

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

        private Estructuras.InformacionError MostrarReporteNominaSA(Int64 pIdLoteCargaNomina, string sRutaArchivosPDF)
        {
            //inicializar valores de objError
            Estructuras.InformacionError objError = new Estructuras.InformacionError { existeError = false, noError = 0, mensajeError = String.Empty };

            ReporteNominaSueldos report = new ReporteNominaSueldos();

            try
            {
                //asignar parametros del reporte
                report.Parameters["pIdLoteCargaNomina"].Value = pIdLoteCargaNomina;
                report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes
                // Asignar opciones de Exportacion
                PdfExportOptions pdfOptions = report.ExportOptions.Pdf;
                pdfOptions.Compressed = true;
                pdfOptions.ImageQuality = PdfJpegImageQuality.Highest;
                pdfOptions.NeverEmbeddedFonts = "Tahoma;Courier New";
                pdfOptions.DocumentOptions.Author = "Gabriela Rodriguez C.";
                pdfOptions.DocumentOptions.Keywords = "Reporte, Nomina, SA";
                pdfOptions.DocumentOptions.Title = "Reporte de Nomina SA";

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

        private Estructuras.InformacionError MostrarReporteAlimentosSC(Int64 pIdLoteCargaNomina, string sRutaArchivosPDF)
        {
            //inicializar valores de objError
            Estructuras.InformacionError objError = new Estructuras.InformacionError { existeError = false, noError = 0, mensajeError = String.Empty };

            ReporteNominaAlimentos report = new ReporteNominaAlimentos();

            try
            {
                //asignar parametros del reporte
                report.Parameters["pIdLoteCargaNomina"].Value = pIdLoteCargaNomina;
                report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes
                // Asignar opciones de Exportacion
                PdfExportOptions pdfOptions = report.ExportOptions.Pdf;
                pdfOptions.Compressed = true;
                pdfOptions.ImageQuality = PdfJpegImageQuality.Highest;
                pdfOptions.NeverEmbeddedFonts = "Tahoma;Courier New";
                pdfOptions.DocumentOptions.Author = "Gabriela Rodriguez C.";
                pdfOptions.DocumentOptions.Keywords = "Reporte, Alimentos, SC";
                pdfOptions.DocumentOptions.Title = "Reporte de Alimentos SC";

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

        /// <summary>
        /// Método que procesa el Reporte de NóminaTenedora SA
        /// </summary>
        public Estructuras.InformacionError MostrarReporteAsimilados(Int64 pIdLoteCargaNomina, string sRutaArchivosPDF)
        {
            //inicializar valores de objError
            Estructuras.InformacionError objError = new Estructuras.InformacionError { existeError = false, noError = 0, mensajeError = String.Empty };

            winAppSAIC.Asimilados.Reporte.ReporteNominaSueldos report = new winAppSAIC.Asimilados.Reporte.ReporteNominaSueldos();

            try
            {
                //asignar parametros del reporte
                report.Parameters["pIdLoteCargaNomina"].Value = pIdLoteCargaNomina;
                report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes
                // Asignar opciones de Exportacion
                PdfExportOptions pdfOptions = report.ExportOptions.Pdf;
                pdfOptions.Compressed = true;
                pdfOptions.ImageQuality = PdfJpegImageQuality.Highest;
                pdfOptions.NeverEmbeddedFonts = "Tahoma;Courier New";
                pdfOptions.DocumentOptions.Author = "Gabriela Rodriguez C.";
                pdfOptions.DocumentOptions.Keywords = "Reporte, Nomina, Asimilados";
                pdfOptions.DocumentOptions.Title = "Reporte de Nomina Asimilados";

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

        private void MostrarFacturas(Int64 pIdFacturas, string strRutaArchivosXML, string pIdTipoFactura, int ptipoRelacion)
        {

            string sRutaArchivosCFDI = "";
            string sRutaArchivosPDF = "";
            string sArchivo = "";
            Estructuras.InformacionError objError;      //variable que recibe comportamiento de la exportacion

            this.stpFactSelComprobantesFacturaTableAdapter1.Fill(this.dbSAICBPOFactura.stpFactSelComprobantesFactura, pIdFacturas, 0);

            DataRow row = null;

            if (this.dbSAICBPOFactura.stpFactSelComprobantesFactura.Count > 0)
                row = this.dbSAICBPOFactura.stpFactSelComprobantesFactura.Rows[0];
            if (row != null)
            {
                Byte[] bytes = Convert.FromBase64String(row[2].ToString());

                sRutaArchivosPDF = string.Format(@"{0}\FACTURA{1}.pdf", strRutaArchivosXML, row[1].ToString());
                sRutaArchivosCFDI = string.Format(@"{0}\FACTURA{1}.xml", strRutaArchivosXML, row[1].ToString());
                File.WriteAllBytes(sRutaArchivosCFDI, bytes);

                if (ptipoRelacion == 11 || pIdTipoFactura == "R")
                    objError = GenerarReporteRecibo(Convert.ToInt64(row[0].ToString()), sRutaArchivosPDF);
                else
                    objError = GenerarReporte(Convert.ToInt64(row[0].ToString()), sRutaArchivosPDF);
            }

            this.spSoloRespuesta1.stpFactSelComprobantePago(pIdFacturas, ref sArchivo);

            if (sArchivo != "" && sArchivo != "0")
            {
                Byte[] bytes = Convert.FromBase64String(sArchivo);

                sRutaArchivosCFDI = string.Format(@"{0}\COMPROBANTE_PAGO_{1}.pdf", strRutaArchivosXML, row[1].ToString());
                File.WriteAllBytes(sRutaArchivosCFDI, bytes);
            }

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

        private void btnActualiza_Click(object sender, EventArgs e)
        {
            try
            {
                bool? pOk = false;
                dgvSolicitudDetail.Focus();
                DataRow row = dgvSolicitudDetail.GetDataRow(dgvSolicitudDetail.FocusedRowHandle);
                if (row != null)
                {
                    if (Convert.ToInt64(row[17].ToString()) > 0)
                    {
                        ControlOperaciones.frmxSolicitudesPagoDetailBOrigen objPantalla = new ControlOperaciones.frmxSolicitudesPagoDetailBOrigen()
                        {
                            IdSolicitud = Convert.ToInt64(row[0].ToString()),
                            IdTenedora = Convert.ToInt32(row[3].ToString()),
                            sTenedora = row[4].ToString(),
                            sBanco = row[20].ToString(),
                            sCuenta = row[22].ToString(),
                            dTotal = Convert.ToDouble(row[5].ToString())
                        };
                        objPantalla.ShowDialog();     //mostrar pantalla
                    }
                    else
                        XtraMessageBox.Show("El Detalle no cuenta con layout", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}