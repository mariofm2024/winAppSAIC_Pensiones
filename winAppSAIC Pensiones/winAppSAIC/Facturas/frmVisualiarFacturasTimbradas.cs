using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;        //namespace a partir version 12.2.4
using DevExpress.XtraPrinting;
using compCatalogosSAIC;
using winAppSAIC.UtileriasLocal;
using System.IO;
using winAppSAIC.ReportesCFDI;

namespace winAppSAIC.Facturas
{
    public partial class frmVisualiarFacturasTimbradas : DevExpress.XtraEditors.XtraForm
    {
        private string FIni, FFin, pUUID;

        private bool PTimbrar = false; //Habilitar
        private bool PContabilizar = false; //Actualizar
        public frmVisualiarFacturasTimbradas()
        {
            InitializeComponent();
        }
        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close(); //SALIR
        }

        public void ObtenerFechas()
        {
            FIni = Convert.ToDateTime(dtFechaIni.EditValue).Year.ToString() + "-" + Convert.ToDateTime(dtFechaIni.EditValue).Month.ToString() + "-" + Convert.ToDateTime(dtFechaIni.EditValue).Day.ToString();
            FFin = Convert.ToDateTime(dtFechaFin.EditValue).Year.ToString() + "-" + Convert.ToDateTime(dtFechaFin.EditValue).Month.ToString() + "-" + Convert.ToDateTime(dtFechaFin.EditValue).Day.ToString();
            pUUID = txtUUID.EditValue.ToString();
        }

        private void frmMonitoreoFacturas_Load(object sender, EventArgs e)
        {
            try
            {
                splashSMCargando.ShowWaitForm();

                dtFechaIni.EditValue = DateTime.Now.AddDays(-30);
                dtFechaFin.EditValue = DateTime.Now;

                ObtenerFechas();
                ///Activar Botones 
                this.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1.Fill(this.dbSAICBPOFactura.stpFactSelDerechosAccesoOperadorFacturacion, OperadorBD.OperadorGlobal.IdOperador, "Facturas.frmMonitoreoFacturas", "btnEliminarSolicitud");

                if (this.dbSAICBPOFactura.stpFactSelDerechosAccesoOperadorFacturacion.Count > 0)
                {
                    DataRow row = this.dbSAICBPOFactura.stpFactSelDerechosAccesoOperadorFacturacion.Rows[0];
                    btnRechazarSolicitud.Visibility = ((bool)row[14] == true ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never);
                    btnEliminarSolicitud.Visibility = ((bool)row[14] == true ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never);
                }

                ///Activar Botones 
                this.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1.Fill(this.dbSAICBPOFactura.stpFactSelDerechosAccesoOperadorFacturacion, OperadorBD.OperadorGlobal.IdOperador, "Facturas.frmAdmonFacturas", "btnCancelarFactura");
                if (this.dbSAICBPOFactura.stpFactSelDerechosAccesoOperadorFacturacion.Count > 0)
                {
                    DataRow row = this.dbSAICBPOFactura.stpFactSelDerechosAccesoOperadorFacturacion.Rows[0];
                    PTimbrar = (bool)row[15];
                    PContabilizar = (bool)row[12];
                    btnContabilizar.Visibility = (PContabilizar == true ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never);
                    btnDescontabilizar.Visibility = (PContabilizar == true ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never);
                }
                else
                {
                    btnContabilizar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnDescontabilizar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }

                // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwCatEstatusSolicitudGlobal' table. You can move, or remove it, as needed.
                this.vwFactCatEstatusSolicitudGlobalTableAdapter.Fill(this.dbSAICBPOFactura.vwFactCatEstatusSolicitudGlobal);
                this.stpFactSelHeaderFacturasTimbradasTableAdapter.Fill(dbSAICBPOFactura.stpFactSelHeaderFacturasTimbradas, 27, FIni, FFin, "", OperadorBD.OperadorGlobal.IdOperador);

                splashSMCargando.CloseWaitForm();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                splashSMCargando.CloseWaitForm();
            }
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ObtenerFechas();
                this.stpFactSelHeaderFacturasTimbradasTableAdapter.Fill(dbSAICBPOFactura.stpFactSelHeaderFacturasTimbradas, 27, FIni, FFin, pUUID, OperadorBD.OperadorGlobal.IdOperador);
                txtUUID.EditValue = "";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //cbEstatus.EditValue = -1;
                dtFechaIni.EditValue = DateTime.Now.AddDays(-30);
                dtFechaFin.EditValue = DateTime.Now;

                ObtenerFechas();
                this.stpFactSelHeaderFacturasTimbradasTableAdapter.Fill(dbSAICBPOFactura.stpFactSelHeaderFacturasTimbradas, 27, FIni, FFin, "", OperadorBD.OperadorGlobal.IdOperador);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRechazarSolicitud_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Int64 Id = 0;
            try
            {
                if (gridView2.SelectedRowsCount > 0)
                {
                    DataRow Row = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                    Id = Convert.ToInt64(Row[0]);
                    Facturas.frmRechazarSolicitud objAsignarXML = new Facturas.frmRechazarSolicitud()
                    {
                        pIdSolicitud = Id
                    };
                    objAsignarXML.ShowDialog();     //mostrar pantalla

                    //cbEstatus.EditValue = -1;
                    dtFechaIni.EditValue = DateTime.Now.AddDays(-30);
                    dtFechaIni.EditValue = DateTime.Now;
                    ObtenerFechas();
                    this.stpFactSelHeaderFacturasTimbradasTableAdapter.Fill(dbSAICBPOFactura.stpFactSelHeaderFacturasTimbradas, 27, FIni, FFin, pUUID, OperadorBD.OperadorGlobal.IdOperador);
                    txtUUID.EditValue = "";

                }
                else
                    XtraMessageBox.Show("¡Debe de Seleccionar una solicitud!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarSolicitud_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Int64 Id = 0;
            try
            {
                if (gridView2.SelectedRowsCount > 0)
                {
                    DataRow Row = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                    Id = Convert.ToInt64(Row[0]);
                    Facturas.frmCancelarSolicitud objAsignarXML = new Facturas.frmCancelarSolicitud()
                    {
                        pIdSolicitud = Id
                    };
                    objAsignarXML.ShowDialog();     //mostrar pantalla

                    //cbEstatus.EditValue = -1;
                    dtFechaIni.EditValue = DateTime.Now.AddDays(-30);
                    dtFechaIni.EditValue = DateTime.Now;
                    ObtenerFechas();
                    this.stpFactSelHeaderFacturasTimbradasTableAdapter.Fill(dbSAICBPOFactura.stpFactSelHeaderFacturasTimbradas, 27, FIni, FFin, "", OperadorBD.OperadorGlobal.IdOperador);

                }
                else
                    XtraMessageBox.Show("¡Debe de Seleccionar una solicitud!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {

            Int64 pIdSolicitud = 0; Int64 pIdFactura = 0; string Sistema = "";
            try
            {
                //Crear archivo Comprobante
                DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                if (row != null)
                {
                    pIdSolicitud = Convert.ToInt64(row[1].ToString());
                    pIdFactura = Convert.ToInt64(row[0].ToString());
                    Sistema = row[52].ToString();
                    if (Sistema == "SAIC")
                    {
                        Facturas.frmAdmonFacturasFCV objAsignarXML = new Facturas.frmAdmonFacturasFCV()
                        {
                            IdSolicitudFactura = pIdSolicitud,
                            IdFactura = pIdFactura
                        };
                        objAsignarXML.ShowDialog();     //mostrar pantalla
                    }
                    else
                    {
                        //Facturas.frmAdmonFacturasCompaq objAsignarXML = new Facturas.frmAdmonFacturasCompaq()
                        //{
                        //    IdSolicitudFactura = pIdSolicitud,
                        //    IdFactura = pIdFactura
                        //};
                        //objAsignarXML.ShowDialog();     //mostrar pantalla
                    }
                    dtFechaIni.EditValue = DateTime.Now.AddDays(-30);
                    dtFechaFin.EditValue = DateTime.Now;

                    ObtenerFechas();
                    this.stpFactSelHeaderFacturasTimbradasTableAdapter.Fill(dbSAICBPOFactura.stpFactSelHeaderFacturasTimbradas, 27, FIni, FFin, "", OperadorBD.OperadorGlobal.IdOperador);
                }
                else
                    XtraMessageBox.Show("¡Debe de Seleccionar una Factura!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDescargarComprobante_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string sRutaArchivosCFDI = "";
                string sRutaArchivosXML = "";
                string sRutaArchivosPDF = "";
                string sRutaArchivosPAGO = "";
                int ptipoRelacion = 0;
                string sArchivo = "";
                string pIdTipoFactura = "N";
                string sRFC = "";
                Estructuras.InformacionError objError;      //variable que recibe comportamiento de la exportacion

                //obtener el renglon completo del Combobox
                if (gridView2.GetSelectedRows().Count() > 0)
                {
                    //obtener la ruta RAIZ en dónde se almacenarán los archivos PDF y XML
                    string strRutaArchivosXML = this.validacionesGeneralTableAdapter1.ObtenerValorParametro("FOLDER_XML_FACTURA_CFDI").ToString();
                    sRutaArchivosCFDI = compNominaCFDI.AccesoIO.ValidarCrearDirectorioCFactura(strRutaArchivosXML, compNominaCFDI.AccesoIO.ISO_Date());
                    foreach (var item in gridView2.GetSelectedRows())
                    {
                        DataRow row = gridView2.GetDataRow(item);
                        this.stpFactSelComprobantesFacturaTableAdapter1.Fill(this.dbSAICBPOFactura.stpFactSelComprobantesFactura, Convert.ToInt64(row[0].ToString()), Convert.ToInt64(row[36].ToString()));
                        ptipoRelacion = Convert.ToInt32(row[22].ToString());
                        pIdTipoFactura = row[42].ToString();
                        //Crear archivo Comprobante
                        row = this.dbSAICBPOFactura.stpFactSelComprobantesFactura.Rows[0];
                        if (row != null)
                        {
                            Byte[] bytes = Convert.FromBase64String(row[2].ToString());
                            //Generar carpeta para colocar archivos XML
                            sRutaArchivosPDF = string.Format(@"{0}\FACTURA{1}.pdf", sRutaArchivosCFDI, row[1].ToString());
                            sRutaArchivosXML = string.Format(@"{0}\FACTURA{1}.xml", sRutaArchivosCFDI, row[1].ToString());
                            sRFC = row[3].ToString();
                            File.WriteAllBytes(sRutaArchivosXML, bytes);

                            if (ptipoRelacion == 11 || pIdTipoFactura == "R")
                                objError = GenerarReporteRecibo(Convert.ToInt64(row[0].ToString()), sRutaArchivosPDF);
                            else
                                objError = GenerarReporte(Convert.ToInt64(row[0].ToString()), sRutaArchivosPDF);
                        }

                        this.spSoloRespuesta1.stpFactSelComprobantePago(Convert.ToInt64(row[0].ToString()), ref sArchivo);

                        if (sArchivo.Length > 2)
                        {
                            Byte[] bytes = Convert.FromBase64String(sArchivo);

                            sRutaArchivosPAGO = string.Format(@"{0}\{1}_COMPROBANTE_PAGO_{2}.pdf", sRutaArchivosCFDI, sRFC, row[1].ToString());
                            File.WriteAllBytes(sRutaArchivosPAGO, bytes);
                        }
                    }
                    XtraMessageBox.Show("¡Los Archivos se descargaron Correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnContabilizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string Idfacturas = "";
                //obtener el renglon completo del Combobox
                if (gridView2.GetSelectedRows().Count() > 0)
                {
                    //obtener la ruta RAIZ en dónde se almacenarán los archivos PDF y XML
                    foreach (var item in gridView2.GetSelectedRows())
                    {
                        DataRow row = gridView2.GetDataRow(item);
                        if (row != null)
                        {
                            //Obtener Facturas
                            if (row[37].ToString() == "0")
                                Idfacturas = Idfacturas + row[0].ToString() + ",";
                            else
                            {
                                Idfacturas = "";
                                break;
                            }
                        }
                    }

                    if (Idfacturas != "")
                    {
                        Facturas.frmContabilizarFactura objAsignarXML = new Facturas.frmContabilizarFactura()
                        {
                            pIdFacturaS = Idfacturas
                        };

                        objAsignarXML.ShowDialog();     //mostrar pantalla     
                        this.stpFactSelHeaderFacturasTimbradasTableAdapter.Fill(dbSAICBPOFactura.stpFactSelHeaderFacturasTimbradas, 27, FIni, FFin, "", OperadorBD.OperadorGlobal.IdOperador);
                    }
                    else
                        XtraMessageBox.Show("¡Seleccionó una o varias Facturas Contabilizadas!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    XtraMessageBox.Show("¡Debe de Seleccionar una Factura!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDescontabilizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string Idfacturas = "";
                //obtener el renglon completo del Combobox
                if (gridView2.GetSelectedRows().Count() > 0)
                {
                    //obtener la ruta RAIZ en dónde se almacenarán los archivos PDF y XML
                    foreach (var item in gridView2.GetSelectedRows())
                    {
                        DataRow row = gridView2.GetDataRow(item);
                        if (row != null)
                        {
                            //Obtener Facturas 
                            if (row[37].ToString() != "0")
                                Idfacturas = Idfacturas + row[0].ToString() + ",";
                            else
                            {
                                Idfacturas = "";
                                break;
                            }
                        }
                    }

                    int? pOk = 0;

                    if (Idfacturas != "")
                    {
                        Idfacturas = Idfacturas.Substring(0, Idfacturas.Length - 1);
                        if (XtraMessageBox.Show(String.Format("¿Está seguro que desea Descontabilizar la(s) Factura(s) {0}?", Idfacturas), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                        {
                            this.spSoloRespuesta1.stpFactDelContabilizarFacturas(Idfacturas, OperadorBD.OperadorGlobal.NombreUsuario, ref pOk);
                            if (pOk == 1)
                            {
                                XtraMessageBox.Show("¡La(s) Factura(s) fueron Descontabilizadas!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                XtraMessageBox.Show("¡Error al Descontabilización la Factura, intentelo mas tarde!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        this.stpFactSelHeaderFacturasTimbradasTableAdapter.Fill(dbSAICBPOFactura.stpFactSelHeaderFacturasTimbradas, 27, FIni, FFin, "", OperadorBD.OperadorGlobal.IdOperador);
                    }
                    else
                        XtraMessageBox.Show("¡Seleccionó una o varias Facturas Contabilizadas!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    }
}