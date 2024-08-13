using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraReports.UI;        //namespace a partir version 12.2.4
using DevExpress.XtraPrinting;
using winAppSAIC.UtileriasLocal;
using compNominaCFDI;
using compCatalogosSAIC;

namespace winAppSAIC.NominaCFDI
{
    public static class ExportarCFDI2PDF
    {
        #region "Métodos Propios"

        public static Estructuras.InformacionError GenerarTimbradosPDFIndividualSueldos(string strNombreArchivoPDF, NominaControlCFDI objNominaControlCFDI)
        {
            //inicializar valores de objError
            Estructuras.InformacionError objError = new Estructuras.InformacionError { existeError = false, noError = 0, mensajeError = String.Empty };

            // Create a report instance.
            ReportesCFDI.RecibosEmpleadosSueldosCFDI report = new ReportesCFDI.RecibosEmpleadosSueldosCFDI();
            try
            {
                //asignar parametros del reporte
                report.Parameters["pIdLoteCargaNomina"].Value = objNominaControlCFDI.IdLoteCargaNomina;
                report.Parameters["pIdPDOHeader"].Value = objNominaControlCFDI.IdPDOHeader;
                report.Parameters["pTipoMovimientoNomina"].Value = objNominaControlCFDI.FolioLoteCargaNomina.Substring(2, 3);    //obtener Tipo Nomina (SEM, QUI, ASI, etc)

                report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes
                // Asignar opciones de Exportacion
                PdfExportOptions pdfOptions = report.ExportOptions.Pdf;
                pdfOptions.Compressed = true;
                pdfOptions.ImageQuality = PdfJpegImageQuality.Highest;
                pdfOptions.NeverEmbeddedFonts = "Tahoma;Courier New";
                pdfOptions.DocumentOptions.Application = String.Format("{0} {1}", objNominaControlCFDI.SoftwareNombre, objNominaControlCFDI.SoftwareVersion);
                pdfOptions.DocumentOptions.Author = "Oliver Blanco D.";
                pdfOptions.DocumentOptions.Keywords = "Recibo, Nómina, CFDI";
                pdfOptions.DocumentOptions.Title = "Recibo Nómina CFDI";

                // Exportar reporte a PDF
                report.ExportToPdf(strNombreArchivoPDF);
            }
            catch (Exception ex)
            {
                objError.existeError = true;
                objError.noError = -99;
                objError.mensajeError = ex.Message;
            }

            return objError;        //regresar estatus OK o ERROR
        }

        public static Estructuras.InformacionError GenerarTimbradosPDFIndividualSueldosv4(string strNombreArchivoPDF, NominaControlCFDI objNominaControlCFDI)
        {
            //inicializar valores de objError
            Estructuras.InformacionError objError = new Estructuras.InformacionError { existeError = false, noError = 0, mensajeError = String.Empty };

            // Create a report instance.
            ReportesCFDI.RecibosEmpleadosSueldosCFDIv4 report = new ReportesCFDI.RecibosEmpleadosSueldosCFDIv4();
            try
            {
                //asignar parametros del reporte
                report.Parameters["pIdLoteCargaNomina"].Value = objNominaControlCFDI.IdLoteCargaNomina;
                report.Parameters["pIdPDOHeader"].Value = objNominaControlCFDI.IdPDOHeader;
                report.Parameters["pTipoMovimientoNomina"].Value = objNominaControlCFDI.FolioLoteCargaNomina.Substring(2, 3);    //obtener Tipo Nomina (SEM, QUI, ASI, etc)

                report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes
                // Asignar opciones de Exportacion
                PdfExportOptions pdfOptions = report.ExportOptions.Pdf;
                pdfOptions.Compressed = true;
                pdfOptions.ImageQuality = PdfJpegImageQuality.Highest;
                pdfOptions.NeverEmbeddedFonts = "Tahoma;Courier New";
                pdfOptions.DocumentOptions.Application = String.Format("{0} {1}", objNominaControlCFDI.SoftwareNombre, objNominaControlCFDI.SoftwareVersion);
                pdfOptions.DocumentOptions.Author = "Grabrizz.";
                pdfOptions.DocumentOptions.Keywords = "Recibo, Nómina, CFDI";
                pdfOptions.DocumentOptions.Title = "Recibo Nómina CFDI";

                // Exportar reporte a PDF
                report.ExportToPdf(strNombreArchivoPDF);
            }
            catch (Exception ex)
            {
                objError.existeError = true;
                objError.noError = -99;
                objError.mensajeError = ex.Message;
            }

            return objError;        //regresar estatus OK o ERROR
        }

        //public static Estructuras.InformacionError GenerarTimbradosPDFIndividualSueldos(string strNombreArchivoPDF, Int64 pIdPDOHeader, Int64 pIdLoteCargaNomina = -1, string pIdTipoMovimiento = "SEM", bool pEnvioCorreo = false)
        public static Estructuras.InformacionError GenerarTimbradosPDFIndividualSueldos(string strNombreArchivoPDF, Int64 pIdPDOHeader, Int64 pIdLoteCargaNomina , string pIdTipoMovimiento = "SEM", bool pEnvioCorreo = false)
        {
            //inicializar valores de objError
            Estructuras.InformacionError objError = new Estructuras.InformacionError { existeError = false, noError = 0, mensajeError = String.Empty };

            // Create a report instance.
            ReportesCFDI.RecibosEmpleadosSueldosCFDI report = new ReportesCFDI.RecibosEmpleadosSueldosCFDI();
            try
            {
                //asignar parametros del reporte
                report.Parameters["pIdLoteCargaNomina"].Value = pIdLoteCargaNomina;
                report.Parameters["pIdPDOHeader"].Value = pIdPDOHeader;
                report.Parameters["pTipoMovimientoNomina"].Value = pIdTipoMovimiento;    //obtener Tipo Nomina (SEM, QUI, ASI, etc)

                report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes
                // Asignar opciones de Exportacion
                PdfExportOptions pdfOptions = report.ExportOptions.Pdf;
                pdfOptions.Compressed = true;
                pdfOptions.ImageQuality = PdfJpegImageQuality.Highest;
                pdfOptions.NeverEmbeddedFonts = "Tahoma;Courier New";
                //pdfOptions.DocumentOptions.Application = String.Format("{0} {1}", objNominaControlCFDI.SoftwareNombre, objNominaControlCFDI.SoftwareVersion);
                pdfOptions.DocumentOptions.Author = "Oliver Blanco D.";
                pdfOptions.DocumentOptions.Keywords = "Recibo, Nómina, CFDI";
                pdfOptions.DocumentOptions.Title = "Recibo Nómina CFDI";

                // Exportar reporte a PDF
                report.ExportToPdf(strNombreArchivoPDF);
            }
            catch (Exception ex)
            {
                objError.existeError = true;
                objError.noError = -99;
                objError.mensajeError = ex.Message;
            }

            return objError;        //regresar estatus OK o ERROR
        }

        public static Estructuras.InformacionError GenerarTimbradosPDFIndividualSueldosv4(string strNombreArchivoPDF, Int64 pIdPDOHeader, Int64 pIdLoteCargaNomina, string pIdTipoMovimiento = "SEM", bool pEnvioCorreo = false)
        {
            //inicializar valores de objError
            Estructuras.InformacionError objError = new Estructuras.InformacionError { existeError = false, noError = 0, mensajeError = String.Empty };

            // Create a report instance.
            ReportesCFDI.RecibosEmpleadosSueldosCFDIv4 report = new ReportesCFDI.RecibosEmpleadosSueldosCFDIv4();
            try
            {
                //asignar parametros del reporte
                report.Parameters["pIdLoteCargaNomina"].Value = pIdLoteCargaNomina;
                report.Parameters["pIdPDOHeader"].Value = pIdPDOHeader;
                report.Parameters["pTipoMovimientoNomina"].Value = pIdTipoMovimiento;    //obtener Tipo Nomina (SEM, QUI, ASI, etc)

                report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes
                // Asignar opciones de Exportacion
                PdfExportOptions pdfOptions = report.ExportOptions.Pdf;
                pdfOptions.Compressed = true;
                pdfOptions.ImageQuality = PdfJpegImageQuality.Highest;
                pdfOptions.NeverEmbeddedFonts = "Tahoma;Courier New";
                //pdfOptions.DocumentOptions.Application = String.Format("{0} {1}", objNominaControlCFDI.SoftwareNombre, objNominaControlCFDI.SoftwareVersion);
                pdfOptions.DocumentOptions.Author = "Oliver Blanco D.";
                pdfOptions.DocumentOptions.Keywords = "Recibo, Nómina, CFDI";
                pdfOptions.DocumentOptions.Title = "Recibo Nómina CFDI";

                // Exportar reporte a PDF
                report.ExportToPdf(strNombreArchivoPDF);
            }
            catch (Exception ex)
            {
                objError.existeError = true;
                objError.noError = -99;
                objError.mensajeError = ex.Message;
            }

            return objError;        //regresar estatus OK o ERROR
        }


        public static Estructuras.InformacionError GenerarTimbradosPDFIndividualAsimilados(string strNombreArchivoPDF, NominaControlCFDI objNominaControlCFDI)
        {
            //inicializar valores de objError
            Estructuras.InformacionError objError = new Estructuras.InformacionError { existeError = false, noError = 0, mensajeError = String.Empty };

            // Create a report instance.
            ReportesCFDI.RecibosAsimiladosSalariosCFDI report = new ReportesCFDI.RecibosAsimiladosSalariosCFDI();
            try
            {
                //asignar parametros del reporte
                report.Parameters["pIdLoteCargaNomina"].Value = objNominaControlCFDI.IdLoteCargaNomina;
                report.Parameters["pIdPDOHeader"].Value = objNominaControlCFDI.IdPDOHeader;
                report.Parameters["pTipoMovimientoNomina"].Value = objNominaControlCFDI.FolioLoteCargaNomina.Substring(2, 3);    //obtener Tipo Nomina (SEM, QUI, ASI, etc)

                report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes
                // Asignar opciones de Exportacion
                PdfExportOptions pdfOptions = report.ExportOptions.Pdf;
                pdfOptions.Compressed = true;
                pdfOptions.ImageQuality = PdfJpegImageQuality.Highest;
                pdfOptions.NeverEmbeddedFonts = "Tahoma;Courier New";
                pdfOptions.DocumentOptions.Application = String.Format("{0} {1}", objNominaControlCFDI.SoftwareNombre, objNominaControlCFDI.SoftwareVersion);
                pdfOptions.DocumentOptions.Author = "Oliver Blanco D.";
                pdfOptions.DocumentOptions.Keywords = "Recibo, Nómina, CFDI";
                pdfOptions.DocumentOptions.Title = "Recibo Nómina CFDI";

                // Exportar reporte a PDF
                report.ExportToPdf(strNombreArchivoPDF);
            }
            catch (Exception ex)
            {
                objError.existeError = true;
                objError.noError = -99;
                objError.mensajeError = ex.Message;
            }

            return objError;        //regresar estatus OK o ERROR
        }


        public static Estructuras.InformacionError GenerarTimbradosPDFIndividualAsimilados(string strNombreArchivoPDF, Int64 pIdPDOHeader, Int64 pIdLoteCargaNomina = -1, string pIdTipoMovimiento = "SEM", bool pEnvioCorreo = false)
        {
            //inicializar valores de objError
            Estructuras.InformacionError objError = new Estructuras.InformacionError { existeError = false, noError = 0, mensajeError = String.Empty };

            // Create a report instance.
            ReportesCFDI.RecibosAsimiladosSalariosCFDI report = new ReportesCFDI.RecibosAsimiladosSalariosCFDI();
            try
            {
                //asignar parametros del reporte
                report.Parameters["pIdLoteCargaNomina"].Value = pIdLoteCargaNomina;
                report.Parameters["pIdPDOHeader"].Value = pIdPDOHeader;
                report.Parameters["pTipoMovimientoNomina"].Value = pIdTipoMovimiento;    //obtener Tipo Nomina (SEM, QUI, ASI, etc)

                report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes
                // Asignar opciones de Exportacion
                PdfExportOptions pdfOptions = report.ExportOptions.Pdf;
                pdfOptions.Compressed = true;
                pdfOptions.ImageQuality = PdfJpegImageQuality.Highest;
                pdfOptions.NeverEmbeddedFonts = "Tahoma;Courier New";
                //pdfOptions.DocumentOptions.Application = String.Format("{0} {1}", objNominaControlCFDI.SoftwareNombre, objNominaControlCFDI.SoftwareVersion);
                pdfOptions.DocumentOptions.Author = "Oliver Blanco D.";
                pdfOptions.DocumentOptions.Keywords = "Recibo, Asimilados, CFDI";
                pdfOptions.DocumentOptions.Title = "Recibo Asimilados CFDI";

                // Exportar reporte a PDF
                report.ExportToPdf(strNombreArchivoPDF);
            }
            catch (Exception ex)
            {
                objError.existeError = true;
                objError.noError = -99;
                objError.mensajeError = ex.Message;
            }

            return objError;        //regresar estatus OK o ERROR
        }

        public static Estructuras.InformacionError GenerarTimbradosPDFactura(string strNombreArchivoPDF, Int64 IdFactura, string SoftwareVersion)
        {
            //inicializar valores de objError
            Estructuras.InformacionError objError = new Estructuras.InformacionError { existeError = false, noError = 0, mensajeError = String.Empty };

            // Create a report instance.
            ReportesCFDI.ReciboFacturacion report = new ReportesCFDI.ReciboFacturacion();
            try
            {
                //asignar parametros del reporte
                report.Parameters["pIdFactura"].Value = IdFactura;

                report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes
                // Asignar opciones de Exportacion
                PdfExportOptions pdfOptions = report.ExportOptions.Pdf;
                pdfOptions.Compressed = true;
                pdfOptions.ImageQuality = PdfJpegImageQuality.Highest;
                pdfOptions.NeverEmbeddedFonts = "Tahoma;Courier New";
                pdfOptions.DocumentOptions.Application = String.Format("{0} {1}", "SAIC Windows", SoftwareVersion);
                pdfOptions.DocumentOptions.Author = "Gabriela Rdz. Clemente";
                pdfOptions.DocumentOptions.Keywords = "Recibo, Factura, CFDI";
                pdfOptions.DocumentOptions.Title = "Recibo de Factura CFDI";

                // Exportar reporte a PDF
                report.ExportToPdf(strNombreArchivoPDF);
            }
            catch (Exception ex)
            {
                objError.existeError = true;
                objError.noError = -99;
                objError.mensajeError = ex.Message;
            }

            return objError;        //regresar estatus OK o ERROR
        }

        public static Estructuras.InformacionError GenerarTimbradosPDFacturaRecibo(string strNombreArchivoPDF, Int64 IdFactura, string SoftwareVersion)
        {
            //inicializar valores de objError
            Estructuras.InformacionError objError = new Estructuras.InformacionError { existeError = false, noError = 0, mensajeError = String.Empty };

            // Create a report instance.
            ReportesCFDI.ReciboFacturacionRecibo report = new ReportesCFDI.ReciboFacturacionRecibo();
            try
            {
                //asignar parametros del reporte
                report.Parameters["pIdFactura"].Value = IdFactura;

                report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes
                // Asignar opciones de Exportacion
                PdfExportOptions pdfOptions = report.ExportOptions.Pdf;
                pdfOptions.Compressed = true;
                pdfOptions.ImageQuality = PdfJpegImageQuality.Highest;
                pdfOptions.NeverEmbeddedFonts = "Tahoma;Courier New";
                pdfOptions.DocumentOptions.Application = String.Format("{0} {1}", "SAIC Windows", SoftwareVersion);
                pdfOptions.DocumentOptions.Author = "Gabriela Rdz. Clemente";
                pdfOptions.DocumentOptions.Keywords = "Recibo, Factura, REP";
                pdfOptions.DocumentOptions.Title = "Recibo de Factura REP";

                // Exportar reporte a PDF
                report.ExportToPdf(strNombreArchivoPDF);
            }
            catch (Exception ex)
            {
                objError.existeError = true;
                objError.noError = -99;
                objError.mensajeError = ex.Message;
            }

            return objError;        //regresar estatus OK o ERROR
        }

        public static Estructuras.InformacionError GenerarTimbradosPDFacturaEmpleado(string strNombreArchivoPDF, Int64 IdPDOHeader, string SoftwareVersion)
        {
            //inicializar valores de objError
            Estructuras.InformacionError objError = new Estructuras.InformacionError { existeError = false, noError = 0, mensajeError = String.Empty };

            // Create a report instance.
            ReportesCFDI.ReciboFacturacionEmpleado report = new ReportesCFDI.ReciboFacturacionEmpleado();
            try
            {
                //asignar parametros del reporte
                report.Parameters["pIdPDOHeader"].Value = IdPDOHeader;

                report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes
                // Asignar opciones de Exportacion
                PdfExportOptions pdfOptions = report.ExportOptions.Pdf;
                pdfOptions.Compressed = true;
                pdfOptions.ImageQuality = PdfJpegImageQuality.Highest;
                pdfOptions.NeverEmbeddedFonts = "Tahoma;Courier New";
                pdfOptions.DocumentOptions.Application = String.Format("{0} {1}", "SAIC Windows", SoftwareVersion);
                pdfOptions.DocumentOptions.Author = "Gabriela Rdz. Clemente";
                pdfOptions.DocumentOptions.Keywords = "Recibo, Factura, CFDI";
                pdfOptions.DocumentOptions.Title = "Recibo de Factura CFDI";

                // Exportar reporte a PDF
                report.ExportToPdf(strNombreArchivoPDF);
            }
            catch (Exception ex)
            {
                objError.existeError = true;
                objError.noError = -99;
                objError.mensajeError = ex.Message;
            }

            return objError;        //regresar estatus OK o ERROR
        }

        public static Estructuras.InformacionError GenerarTimbradosPDFIndividualSueldosFactura(string strNombreArchivoPDF, Int64 pIdPDOHeader, Int64 pIdLoteCargaNomina, string pIdTipoMovimiento = "SEM", bool pEnvioCorreo = false)
        {
            //inicializar valores de objError
            Estructuras.InformacionError objError = new Estructuras.InformacionError { existeError = false, noError = 0, mensajeError = String.Empty };

            // Create a report instance.
            ReportesCFDI.ReciboFacturacionEmpleado report = new ReportesCFDI.ReciboFacturacionEmpleado();
            try
            {
                //asignar parametros del reporte
                report.Parameters["pIdLoteCargaNomina"].Value = pIdLoteCargaNomina;
                report.Parameters["pIdPDOHeader"].Value = pIdPDOHeader;

                report.ShowPrintMarginsWarning = false;     //no mostrar mensaje de margenes
                // Asignar opciones de Exportacion
                PdfExportOptions pdfOptions = report.ExportOptions.Pdf;
                pdfOptions.Compressed = true;
                pdfOptions.ImageQuality = PdfJpegImageQuality.Highest;
                pdfOptions.NeverEmbeddedFonts = "Tahoma;Courier New";
                //pdfOptions.DocumentOptions.Application = String.Format("{0} {1}", objNominaControlCFDI.SoftwareNombre, objNominaControlCFDI.SoftwareVersion);
                pdfOptions.DocumentOptions.Author = "Gabriela Rdr. Clemente";
                pdfOptions.DocumentOptions.Keywords = "Recibo, Nómina, CFDI";
                pdfOptions.DocumentOptions.Title = "Recibo Nómina CFDI";

                // Exportar reporte a PDF
                report.ExportToPdf(strNombreArchivoPDF);
            }
            catch (Exception ex)
            {
                objError.existeError = true;
                objError.noError = -99;
                objError.mensajeError = ex.Message;
            }

            return objError;        //regresar estatus OK o ERROR
        }


        #endregion
    }
}
