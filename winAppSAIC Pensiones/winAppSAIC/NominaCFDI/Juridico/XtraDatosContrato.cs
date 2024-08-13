using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System.IO;
using compCatalogosSAIC;

namespace winAppSAIC.Juridico
{
    public partial class XtraDatosContrato : DevExpress.XtraEditors.XtraForm
    {
        OperadoresM.Solicitud miSolicitud;
        DataTable dtEmpleasosSeleccionados;
        tools.dsc dsc = new tools.dsc();
        public List<String> lstRutaAarchivos = new List<String>();

        // 1 = Imprimir.
        // 2 = Guardar Individual.
        // 3 = Guardar X Solicitud.
        // 4 = Autorizar
        int idBoton;
        winAppSAIC.Juridico.XtraEmpleadosXSolicitudJuridico juridico;

        public XtraDatosContrato(OperadoresM.Solicitud miSolicitud, DataTable dtEmpleasosSeleccionados, int idBoton)
        {
            InitializeComponent();
            this.miSolicitud = miSolicitud;
            this.dtEmpleasosSeleccionados = dtEmpleasosSeleccionados;
            this.idBoton = idBoton;
            juridico = new XtraEmpleadosXSolicitudJuridico(miSolicitud);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XtraDatosContrato_Load(object sender, EventArgs e)
        {
            txtTenedora.Text = miSolicitud.TenedoraSA;
            stpSelCITFirmantesTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelCITFirmantes, miSolicitud.idMatrizTenedora);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(gridLookFirmantes.EditValue.ToString()))
            {
                int idFirmante;
                int.TryParse(gridLookFirmantes.EditValue.ToString(), out idFirmante);

                if (idBoton == 1)//imprimir
                {
                    Imprimir(dtEmpleasosSeleccionados);
                }
                else if (idBoton == 2)
                {
                    GuardarIndividual(dtEmpleasosSeleccionados, idFirmante);
                }
                else if (idBoton == 4)// Autorizar
                {
                    AutorizarContrato(dtEmpleasosSeleccionados, idFirmante);
                }
                else if (idBoton == 3)// por Solicitud
                {
                    GuardarXSolicitud(dtEmpleasosSeleccionados, idFirmante);
                }

                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Seleccione un Firmante para el Contrato."
                 , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //private void GuardarIndividual(DataTable dtEmpleasosSeleccionados, int idFirmante)
        //{
        //    List<String> listRutaContratos = new List<String>();
        //    List<String> listRutaAnexos = new List<String>();
        //    int iConta = 1;

        //    Boolean flatContinuar = true;

        //    String stRutaSolicitud = dsc.stRutaAltaSolicitudEmpelados + miSolicitud.idSolicitud + @"\Juridico\Contratos\";
        //    dsc.CheckandCreateFolder(stRutaSolicitud);

        //    listRutaAnexos = juridico.DescargarAnexos(stRutaSolicitud, miSolicitud.idMatrizTenedora);

        //    if (listRutaAnexos.Count == 0)
        //    {
        //        DialogResult resultado = XtraMessageBox.Show("No se tiene Anexos para la Solicitud " + miSolicitud.idSolicitud + ", de la tenedora: " + miSolicitud.TenedoraSA
        //            + Environment.NewLine + "¿Desea Continuar Sin Anexos?"
        //            , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //        if (resultado == DialogResult.Yes) { flatContinuar = true; }
        //        else { flatContinuar = false; }
        //    }

        //    if (flatContinuar)
        //    {
        //        String stEmpleados = String.Empty;
        //        splashScreenManager1.ShowWaitForm();
        //        splashScreenManager1.SetWaitFormCaption("Descargando Contrato");

        //        foreach (DataRow item in dtEmpleasosSeleccionados.Rows)
        //        {
        //            splashScreenManager1.SetWaitFormDescription(iConta + " de " + dtEmpleasosSeleccionados.Rows.Count);

        //            Reportes.CIT_PPP myReport = new Reportes.CIT_PPP();
        //            myReport.Parameters["stEmpleados"].Value = item["idEmpleado"].ToString() + "|";
        //            //myReport.Parameters["stEmpleados"].Value = item["idEmpleado"].ToString();
        //            //myReport.Parameters["IdFirmante"].Value = gridLookFirmantes.EditValue;
        //            myReport.Parameters["IdFirmante"].Value = idFirmante;
        //            myReport.Parameters["tipoConsulta"].Value = 0;

        //            myReport.ExportToPdf(stRutaSolicitud +
        //                item["idEmpleado"].ToString() + " - " +
        //                item["Apellido Paterno"].ToString() + " " +
        //                item["Apellido Materno"].ToString() + " " +
        //                item["Nombre"].ToString() + " temp" +
        //                ".pdf");

        //            juridico.agregarAnexosVScontrato(stRutaSolicitud +
        //                item["idEmpleado"].ToString() + " - " +
        //                item["Apellido Paterno"].ToString() + " " +
        //                item["Apellido Materno"].ToString() + " " +
        //                item["Nombre"].ToString() + " temp" +
        //                ".pdf",
        //                stRutaSolicitud + item["idEmpleado"].ToString() + " - " +
        //                item["Apellido Paterno"].ToString() + " " +
        //                item["Apellido Materno"].ToString() + " " +
        //                item["Nombre"].ToString() +
        //                ".pdf",
        //                listRutaAnexos);

        //            //Agregar Ruta de Contratos
        //            listRutaContratos.Add(stRutaSolicitud + item["idEmpleado"].ToString() + " - " +
        //                item["Apellido Paterno"].ToString() + " " +
        //                item["Apellido Materno"].ToString() + " " +
        //                item["Nombre"].ToString() +
        //                ".pdf");

        //            iConta++;

        //        }

        //        splashScreenManager1.CloseWaitForm();

        //        XtraMessageBox.Show("Contratos Descargados con Exito." + Environment.NewLine + "Ruta: " + stRutaSolicitud
        //                   , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        private void GuardarIndividual(DataTable dtEmpleasosSeleccionados, int idFirmante)
        {
            XtraEmpleadosXSolicitudJuridico juridico = new XtraEmpleadosXSolicitudJuridico(miSolicitud);
            List<String> listRutaContratos = new List<String>();
            List<String> listRutaAnexos = new List<String>();
            int iConta = 1;

            Boolean flatContinuar = true;

            //String stRutaSolicitud = dsc.stRutaAltaSolicitudEmpelados + miSolicitud.idSolicitud + @"\Juridico\Contratos\";
            String stRutaSolicitud = miSolicitud.sRutaSolicitud + miSolicitud.idSolicitud + @"\";
            dsc.CheckandCreateFolder(stRutaSolicitud);

            String stRutaAnexos = miSolicitud.sRutaSolicitud + miSolicitud.idSolicitud + @"\Anexos\";
            listRutaAnexos = juridico.DescargarAnexos(stRutaAnexos, miSolicitud.idMatrizTenedora);

            if (listRutaAnexos.Count == 0)
            {
                DialogResult resultado = XtraMessageBox.Show("No se tiene Anexos para la Solicitud " + miSolicitud.idSolicitud + ", de la tenedora: " + miSolicitud.TenedoraSA
                    + Environment.NewLine + "¿Desea Continuar Sin Anexos?"
                    , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes) { flatContinuar = true; }
                else { flatContinuar = false; }
            }

            if (flatContinuar)
            {
                String stEmpleados = String.Empty;
                String stRutaDescargar = String.Empty;
                splashScreenManager1.ShowWaitForm();
                splashScreenManager1.SetWaitFormCaption("Descargando Contrato");

                foreach (DataRow item in dtEmpleasosSeleccionados.Rows)
                {
                    splashScreenManager1.SetWaitFormDescription(iConta + " de " + dtEmpleasosSeleccionados.Rows.Count);

                    stRutaDescargar = String.Empty;
                    stRutaDescargar = stRutaSolicitud + item["idEmpleado"].ToString() + @"\";
                    dsc.CheckandCreateFolder(stRutaDescargar);

                    String stNombreCompletoEmpleado = item["Apellido Paterno"].ToString() + " " +
                                item["Apellido Materno"].ToString() + " " +
                                item["Nombre"].ToString();

                    Reportes.CIT_PPP myReport = new Reportes.CIT_PPP();
                    myReport.Parameters["flagConGenerico"].Value = true;
                    myReport.Parameters["stEmpleados"].Value = item["idEmpleado"].ToString() + "|";
                    //myReport.Parameters["stEmpleados"].Value = item["idEmpleado"].ToString();
                    //myReport.Parameters["IdFirmante"].Value = gridLookFirmantes.EditValue;
                    myReport.Parameters["IdFirmante"].Value = idFirmante;
                    myReport.Parameters["tipoConsulta"].Value = 0;

                    if (item["idTipoMovimiento"].ToString() != "A")
                    {
                        //descargar los documentos para el contrato 
                        List<String> lstRutaDocumentos = juridico.DescargarDocumentosContrato("JURIDICO", stRutaDescargar, stNombreCompletoEmpleado, miSolicitud.idSolicitud, idFirmante, Convert.ToInt32(item["idEmpleado"].ToString()));

                        stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "ANEXAR DOC-CIT");
                        Boolean flagAnexarDocumento = false;

                        if (dbSAICBPOValidacionDataSet1.stpSelParametro.Rows.Count > 0)
                        {
                            flagAnexarDocumento = dbSAICBPOValidacionDataSet1.stpSelParametro.Rows[0]["ValorParametro"].ToString() == "SI" ? true : false;
                        }

                        myReport.ExportToDocx(stRutaDescargar +
                            item["idEmpleado"].ToString() + " - " +
                            item["Apellido Paterno"].ToString() + " " +
                            item["Apellido Materno"].ToString() + " " +
                            item["Nombre"].ToString() +
                            ".docx");

                        myReport.ExportToPdf(stRutaDescargar +
                            item["idEmpleado"].ToString() + " - " +
                            item["Apellido Paterno"].ToString() + " " +
                            item["Apellido Materno"].ToString() + " " +
                            item["Nombre"].ToString() + " temp" +
                            ".pdf");

                        if (flagAnexarDocumento)
                        {
                            juridico.agregarAnexosVScontrato(stRutaDescargar +
                                           item["idEmpleado"].ToString() + " - " +
                                           item["Apellido Paterno"].ToString() + " " +
                                           item["Apellido Materno"].ToString() + " " +
                                           item["Nombre"].ToString() + " temp" +
                                           ".pdf",
                                           stRutaDescargar + item["idEmpleado"].ToString() + " - " +
                                           item["Apellido Paterno"].ToString() + " " +
                                           item["Apellido Materno"].ToString() + " " +
                                           item["Nombre"].ToString() +
                                           ".pdf",
                                           listRutaAnexos,
                                           lstRutaDocumentos);
                        }

                        //Agregar Ruta de Contratos
                        listRutaContratos.Add(stRutaSolicitud + item["idEmpleado"].ToString() + " - " +
                            item["Apellido Paterno"].ToString() + " " +
                            item["Apellido Materno"].ToString() + " " +
                            item["Nombre"].ToString() +
                            ".pdf");
                    }
                    else
                    {
                        foreach (String stAnexo in listRutaAnexos)
                        {
                            FileInfo miFile = new FileInfo(stAnexo);

                            if (!File.Exists(stRutaDescargar +
                            item["idEmpleado"].ToString() + " - " +
                            item["Apellido Paterno"].ToString() + " " +
                            item["Apellido Materno"].ToString() + " " +
                            item["Nombre"].ToString() + miFile.Name))
                            {
                                miFile.CopyTo(stRutaDescargar +
                                item["idEmpleado"].ToString() + " - " +
                                item["Apellido Paterno"].ToString() + " " +
                                item["Apellido Materno"].ToString() + " " +
                                item["Nombre"].ToString() + miFile.Name);
                            }
                        }
                    }


                    int idEmpleado;
                    int.TryParse(item["idEmpleado"].ToString(), out idEmpleado);
                    //descargar Contrato de Conficialidad
                    juridico.DescargarContratoConficialidad(stRutaDescargar, idEmpleado, stNombreCompletoEmpleado);

                    iConta++;

                }

                splashScreenManager1.CloseWaitForm();

                //XtraMessageBox.Show("Contratos Descargados con Exito." + Environment.NewLine + "Ruta: " + stRutaSolicitud
                //           , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //private void GuardarXSolicitud(DataTable dtEmpleasosSeleccionados, int idFirmante)
        //{
        //    List<String> listRutaAnexos = new List<String>();
        //    List<String> RutaContratos = new List<String>();
        //    Boolean flatContinuar = true;
        //    String stRutaSolicitud = dsc.stRutaAltaSolicitudEmpelados + miSolicitud.idSolicitud + @"\Juridico\Contratos\";
        //    int iConta = 1;
        //    dsc.CheckandCreateFolder(stRutaSolicitud);


        //    String stEmpleados = String.Empty;
        //    //DataTable dtEmpleasosSeleccionados = dsc.deGridViewSelectedToDataTable(gridViewEmpleados);

        //    if (dtEmpleasosSeleccionados.Rows.Count > 0)
        //    {
        //        splashScreenManager1.ShowWaitForm();
        //        splashScreenManager1.SetWaitFormCaption("Descargando Anexos");
        //        splashScreenManager1.SetWaitFormDescription("Espere Por favor...");
        //        listRutaAnexos = juridico.DescargarAnexos(stRutaSolicitud, miSolicitud.idMatrizTenedora);

        //        if (listRutaAnexos.Count == 0)
        //        {
        //            splashScreenManager1.CloseWaitForm();
        //            DialogResult resultado = XtraMessageBox.Show("No se tiene Anexos para la Solicitud " + miSolicitud.idSolicitud + ", de la tenedora: " + miSolicitud.TenedoraSA
        //                + Environment.NewLine + "¿Desea Continuar Sin Anexos?"
        //                , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //            if (resultado == DialogResult.Yes) { flatContinuar = true; }
        //            else { flatContinuar = false; }
        //            splashScreenManager1.ShowWaitForm();
        //        }

        //        if (flatContinuar)
        //        {
        //            splashScreenManager1.SetWaitFormDescription("Descargando Contratos");

        //            foreach (DataRow item in dtEmpleasosSeleccionados.Rows)
        //            {
        //                splashScreenManager1.SetWaitFormDescription("Contratos " + iConta + " de " + dtEmpleasosSeleccionados.Rows.Count);
        //                Reportes.CIT_PPP myReport = new Reportes.CIT_PPP();
        //                myReport.Parameters["stEmpleados"].Value = item["idEmpleado"].ToString() + "|";
        //                myReport.Parameters["tipoConsulta"].Value = 0;
        //                //myReport.Parameters["IdFirmante"].Value = gridLookFirmantes.EditValue;
        //                myReport.Parameters["IdFirmante"].Value = idFirmante;

        //                myReport.ExportToPdf(stRutaSolicitud +
        //                          item["idEmpleado"].ToString() + " - " +
        //                          item["Apellido Paterno"].ToString() + " " +
        //                          item["Apellido Materno"].ToString() + " " +
        //                          item["Nombre"].ToString() + " temp" +
        //                          ".pdf");

        //                juridico.agregarAnexosVScontrato(stRutaSolicitud +
        //                            item["idEmpleado"].ToString() + " - " +
        //                            item["Apellido Paterno"].ToString() + " " +
        //                            item["Apellido Materno"].ToString() + " " +
        //                            item["Nombre"].ToString() + " temp" +
        //                            ".pdf",
        //                            stRutaSolicitud + item["idEmpleado"].ToString() + " - " +
        //                            item["Apellido Paterno"].ToString() + " " +
        //                            item["Apellido Materno"].ToString() + " " +
        //                            item["Nombre"].ToString() +
        //                            ".pdf",
        //                            listRutaAnexos);

        //                RutaContratos.Add(stRutaSolicitud + item["idEmpleado"].ToString() + " - " +
        //                           item["Apellido Paterno"].ToString() + " " +
        //                           item["Apellido Materno"].ToString() + " " +
        //                           item["Nombre"].ToString() +
        //                           ".pdf");
        //                iConta++;
        //            }

        //            splashScreenManager1.SetWaitFormDescription("Consolidando Contratos");
        //            //Consolidar Archivos
        //            juridico.CosolidarArcchivos(stRutaSolicitud + "Contratos.pdf", RutaContratos);

        //            splashScreenManager1.CloseWaitForm();

        //            XtraMessageBox.Show("Contratos Descargados con Exito." + Environment.NewLine + "Ruta: " + stRutaSolicitud
        //                 , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else
        //        {
        //            splashScreenManager1.CloseWaitForm();
        //        }
        //    }
        //    else
        //    {
        //        XtraMessageBox.Show("Por favor seeleccione a un Empleado."
        //              , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        private void GuardarXSolicitud(DataTable dtEmpleasosSeleccionados, int idFirmante)
        {
            XtraEmpleadosXSolicitudJuridico juridico = new XtraEmpleadosXSolicitudJuridico(miSolicitud);
            List<String> listRutaAnexos = new List<String>();
            List<String> RutaContratos = new List<String>();
            Boolean flatContinuar = true;
            String stRutaSolicitud = miSolicitud.sRutaSolicitud + miSolicitud.idSolicitud + @"\";
            int iConta = 1;
            dsc.CheckandCreateFolder(stRutaSolicitud);


            String stEmpleados = String.Empty;
            //DataTable dtEmpleasosSeleccionados = dsc.deGridViewSelectedToDataTable(gridViewEmpleados);

            if (dtEmpleasosSeleccionados.Rows.Count > 0)
            {
                Boolean flatConWord = false;
                DialogResult ResultadoContratosWord = XtraMessageBox.Show("¿Desea descargar los contratos en formato Word?"
                        , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ResultadoContratosWord == DialogResult.Yes) { flatConWord = true; }

                splashScreenManager1.ShowWaitForm();
                splashScreenManager1.SetWaitFormCaption("Descargando Anexos");
                splashScreenManager1.SetWaitFormDescription("Espere Por favor...");
                listRutaAnexos = juridico.DescargarAnexos(stRutaSolicitud, miSolicitud.idMatrizTenedora);

                if (listRutaAnexos.Count == 0)
                {
                    splashScreenManager1.CloseWaitForm();
                    DialogResult resultado = XtraMessageBox.Show("No se tiene Anexos para la Solicitud " + miSolicitud.idSolicitud + ", de la tenedora: " + miSolicitud.TenedoraSA
                        + Environment.NewLine + "¿Desea Continuar Sin Anexos?"
                        , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes) { flatContinuar = true; }
                    else { flatContinuar = false; }
                    splashScreenManager1.ShowWaitForm();
                }

                if (flatContinuar)
                {
                    splashScreenManager1.SetWaitFormCaption("Descargando Contratos");

                    foreach (DataRow item in dtEmpleasosSeleccionados.Rows)
                    {
                        splashScreenManager1.SetWaitFormDescription("Contratos " + iConta + " de " + dtEmpleasosSeleccionados.Rows.Count);

                        String stNombreCompleatoEmpleados = item["Apellido Paterno"].ToString() + " " +
                                                item["Apellido Materno"].ToString() + " " +
                                                item["Nombre"].ToString();

                        Reportes.CIT_PPP myReport = new Reportes.CIT_PPP();
                        myReport.Parameters["flagConGenerico"].Value = true;
                        myReport.Parameters["stEmpleados"].Value = item["idEmpleado"].ToString() + "|";
                        myReport.Parameters["tipoConsulta"].Value = 0;
                        //myReport.Parameters["IdFirmante"].Value = gridLookFirmantes.EditValue;
                        myReport.Parameters["IdFirmante"].Value = idFirmante;

                        if (item["idTipoMovimiento"].ToString() != "A") // M y S
                        {
                            //descargar los documentos para el contrato 
                            List<String> lstRutaDocumentos = juridico.DescargarDocumentosContrato("JURIDICO", stRutaSolicitud, stNombreCompleatoEmpleados, miSolicitud.idSolicitud, idFirmante, Convert.ToInt32(item["idEmpleado"].ToString()));
                            stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "ANEXAR DOC-CIT");
                            Boolean flagAnexarDocumento = false;

                            if (dbSAICBPOValidacionDataSet1.stpSelParametro.Rows.Count > 0)
                            {
                                flagAnexarDocumento = dbSAICBPOValidacionDataSet1.stpSelParametro.Rows[0]["ValorParametro"].ToString() == "SI" ? true : false;
                            }

                            if (flatConWord)
                            {
                                myReport.ExportToDocx(stRutaSolicitud +
                                                item["idEmpleado"].ToString() + " - " +
                                                item["Apellido Paterno"].ToString() + " " +
                                                item["Apellido Materno"].ToString() + " " +
                                                item["Nombre"].ToString() +
                                                ".docx");
                            }

                            myReport.ExportToPdf(stRutaSolicitud +
                                      item["idEmpleado"].ToString() + " - " +
                                      item["Apellido Paterno"].ToString() + " " +
                                      item["Apellido Materno"].ToString() + " " +
                                      item["Nombre"].ToString() + " temp" +
                                      ".pdf");

                            if (flagAnexarDocumento)
                            {
                                juridico.agregarAnexosVScontrato(stRutaSolicitud +
                                                            item["idEmpleado"].ToString() + " - " +
                                                            item["Apellido Paterno"].ToString() + " " +
                                                            item["Apellido Materno"].ToString() + " " +
                                                            item["Nombre"].ToString() + " temp" +
                                                            ".pdf",
                                                            stRutaSolicitud + item["idEmpleado"].ToString() + " - " +
                                                            item["Apellido Paterno"].ToString() + " " +
                                                            item["Apellido Materno"].ToString() + " " +
                                                            item["Nombre"].ToString() +
                                                            ".pdf",
                                                            listRutaAnexos,
                                                            lstRutaDocumentos);

                                RutaContratos.Add(stRutaSolicitud + item["idEmpleado"].ToString() + " - " +
                                    item["Apellido Paterno"].ToString() + " " +
                                    item["Apellido Materno"].ToString() + " " +
                                    item["Nombre"].ToString() +
                                    ".pdf");
                            }
                            else
                            {
                                RutaContratos.Add(stRutaSolicitud + item["idEmpleado"].ToString() + " - " +
                                           item["Apellido Paterno"].ToString() + " " +
                                           item["Apellido Materno"].ToString() + " " +
                                           item["Nombre"].ToString() + " temp" +
                                           ".pdf");
                            }


                            //Eliminar os archivos Documentos Contrato
                            eliminarArchivos(lstRutaDocumentos);
                        }
                        else //A
                        {
                            foreach (String stAnexo in listRutaAnexos)
                            {
                                FileInfo miFile = new FileInfo(stAnexo);
                                miFile.CopyTo(stRutaSolicitud +
                                item["idEmpleado"].ToString() + " - " +
                                item["Apellido Paterno"].ToString() + " " +
                                item["Apellido Materno"].ToString() + " " +
                                item["Nombre"].ToString() + miFile.Name);

                                RutaContratos.Add(stRutaSolicitud +
                                item["idEmpleado"].ToString() + " - " +
                                item["Apellido Paterno"].ToString() + " " +
                                item["Apellido Materno"].ToString() + " " +
                                item["Nombre"].ToString() + miFile.Name);
                            }
                        }

                        int idEmpleado;
                        int.TryParse(item["idEmpleado"].ToString(), out idEmpleado);
                        //descargar Contrato de Conficialidad
                        juridico.DescargarContratoConficialidad(stRutaSolicitud, idEmpleado, stNombreCompleatoEmpleados);

                        iConta++;
                    }

                    splashScreenManager1.SetWaitFormDescription("Consolidando Contratos");

                    //Consolidar Archivos
                    String stNombreArchivoConsolidado = stRutaSolicitud + "Contratos - " + dsc.nombreAleatorio() + ".pdf";
                    juridico.CosolidarArcchivos(stNombreArchivoConsolidado, RutaContratos);


                    lstRutaAarchivos.Add(stNombreArchivoConsolidado);

                    splashScreenManager1.CloseWaitForm();

                    //XtraMessageBox.Show("Contratos Descargados con Exito." + Environment.NewLine + "Ruta: " + stRutaSolicitud
                    //     , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    splashScreenManager1.CloseWaitForm();
                }
            }
            else
            {
                XtraMessageBox.Show("Por favor seleccione a un Empleado."
                      , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Imprimir(DataTable dtEmpleasosSeleccionados)
        {
            String stEmpleados = String.Empty;

            foreach (DataRow item in dtEmpleasosSeleccionados.Rows)
            {
                stEmpleados += item["idEmpleado"].ToString() + "|";
            }

            Reportes.CIT_PPP myReport = new Reportes.CIT_PPP();
            myReport.Parameters["flagConGenerico"].Value = true;

            try
            {

                myReport.Parameters["flagConGenerico"].Value = true;
                myReport.Parameters["stEmpleados"].Value = stEmpleados;
                myReport.Parameters["tipoConsulta"].Value = 0;
                myReport.Parameters["IdFirmante"].Value = gridLookFirmantes.EditValue;
                myReport.ShowPrintMarginsWarning = false;
                myReport.CreateDocument();

                stpSelDocumentosContratoActivosTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelDocumentosContratoActivos);

                for (int i = 0; i < dbSAICBPOCatalogosDataSet1.stpSelDocumentosContratoActivos.Rows.Count; i++)
                {
                    int idDocumentosContrato = 0;
                    int.TryParse(dbSAICBPOCatalogosDataSet1.stpSelDocumentosContratoActivos.Rows[i]["idDocumentosContrato"].ToString(), out idDocumentosContrato);

                    Juridico.Reportes.DocumentosContrato oDocumentosContrato = new Reportes.DocumentosContrato();
                    oDocumentosContrato.Parameters["sArea"].Value = "JURIDICO";
                    oDocumentosContrato.Parameters["idDocumentosContrato"].Value = idDocumentosContrato;
                    oDocumentosContrato.Parameters["IdSolicitud"].Value = 0;
                    oDocumentosContrato.Parameters["IdFirmante"].Value = gridLookFirmantes.EditValue;
                    oDocumentosContrato.Parameters["IdEmpleado"].Value = stEmpleados.Replace("|", "");
                    oDocumentosContrato.CreateDocument();
                    myReport.Pages.AddRange(oDocumentosContrato.Pages);
                    myReport.PrintingSystem.ContinuousPageNumbering = true;
                }

                myReport.ShowPreview();
            }
            catch (Exception ex) { }
        }

        private void AutorizarContrato(DataTable dtEmpleasosSeleccionados, int idFirmante)
        {
            int iConta = 0;
            int iErrorConta = 0;
            foreach (DataRow unRow in dtEmpleasosSeleccionados.Rows)
            {
                try
                {
                    String stContrato = String.Empty;
                    int idEmpleado = 0;
                    int.TryParse(unRow["idEmpleado"].ToString(), out idEmpleado);

                    //Consultando Contrato
                    stpSelCITTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelCIT, idEmpleado, idFirmante);

                    stContrato = dbSAICBPOCatalogosDataSet1.stpSelCIT.Rows[0][0].ToString();

                    queriesTableAdapter1.stpInsAltaEmpleadosAutorizarContrato(idEmpleado, 1, compCatalogosSAIC.OperadorBD.OperadorGlobal.NombreUsuario, stContrato, idFirmante, "HTML");
                    iConta++;

                    //int iEstaArchivo = listRutaArchivos.Where(x => x.ToString().Contains(idEmpleado.ToString())).ToList().Count;
                    //if (iEstaArchivo > 0)
                    //{
                    //    String stRutaArchivo = listRutaArchivos.Where(x => x.ToString().Contains(idEmpleado.ToString())).ToList().ToList()[0];
                    //    int indice = listRutaArchivos.IndexOf(stRutaArchivo);
                    //    if (indice != -1)
                    //    {
                    //        String valorArchivo = dsc.ConvertToBytes(listRutaArchivos[indice]);
                    //        queriesTableAdapter1.stpInsAltaEmpleadosAutorizarContrato(idEmpleado, 1, compCatalogosSAIC.OperadorBD.OperadorGlobal.NombreOperador, valorArchivo);
                    //    }
                    //}
                }
                catch (Exception ex)
                {
                    iErrorConta++;
                }
            }
            XtraMessageBox.Show("Autorizar Contrato Empleados" + Environment.NewLine + "Contratos Autorizados: " + (/*iContratosYaAutorizados +*/ iConta) + Environment.NewLine +
                "Contratos con Error: " + iErrorConta
            , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GuardarContratos(DataTable dtEmpleasosSeleccionados, int idFirmante, int TipoDeGuardado)
        {
            XtraEmpleadosXSolicitudJuridico juridico = new XtraEmpleadosXSolicitudJuridico(miSolicitud);
            List<String> listRutaContratos = new List<String>();
            List<String> listRutaAnexos = new List<String>();
            List<String> RutaContratos = new List<String>();

            int iConta = 1;

            Boolean flatContinuar = true;

            String stRutaSolicitud = miSolicitud.sRutaSolicitud + miSolicitud.idSolicitud + @"\";
            dsc.CheckandCreateFolder(stRutaSolicitud);

            String stRutaAnexos = miSolicitud.sRutaSolicitud + miSolicitud.idSolicitud + @"\Carta de Asociacion Universal\";
            listRutaAnexos = juridico.DescargarAnexos(stRutaAnexos, miSolicitud.idMatrizTenedora);

            if (flatContinuar)
            {
                String stEmpleados = String.Empty;
                String stRutaDescargar = String.Empty;
                splashScreenManager1.ShowWaitForm();
                splashScreenManager1.SetWaitFormCaption("Descargando Contrato");

                foreach (DataRow item in dtEmpleasosSeleccionados.Rows)
                {
                    splashScreenManager1.SetWaitFormDescription(iConta + " de " + dtEmpleasosSeleccionados.Rows.Count);

                    stRutaDescargar = String.Empty;
                    stRutaDescargar = stRutaSolicitud + item["idEmpleado"].ToString() + @"\";
                    dsc.CheckandCreateFolder(stRutaDescargar);

                    String stRutaAnexos3 = miSolicitud.sRutaSolicitud + miSolicitud.idSolicitud + @"\" + item["idEmpleado"].ToString() + @"\Anexos\";
                    dsc.CheckandCreateFolder(stRutaAnexos3);

                    int idEmpleado = 0;
                    int.TryParse(item["idEmpleado"].ToString(), out idEmpleado);

                    Reportes.CIT_PPP myReport = new Reportes.CIT_PPP();
                    myReport.Parameters["flagConGenerico"].Value = true;
                    myReport.Parameters["stEmpleados"].Value = item["idEmpleado"].ToString() + "|";
                    myReport.Parameters["IdFirmante"].Value = idFirmante;
                    myReport.Parameters["tipoConsulta"].Value = 0;

                    if (item["idTipoMovimiento"].ToString() == "A")
                    {
                        String stRutaAnexos4;
                        String StRutaCarta;
                        stRutaAnexos4 = miSolicitud.sRutaSolicitud + miSolicitud.idSolicitud + @"\" + item["idEmpleado"].ToString() + @"\";
                        dsc.CheckandCreateFolder(stRutaAnexos4);
                        StRutaCarta = Anexo_CartaDeAsociacion(stRutaAnexos4, idEmpleado, miSolicitud.idSolicitud, true);
                        RutaContratos.Add(StRutaCarta);
                    }
                    else if (item["idTipoMovimiento"].ToString() == "S")
                    {
                        myReport.ExportToDocx(stRutaDescargar +
                          item["idEmpleado"].ToString() + " - " +
                          item["Apellido Paterno"].ToString() + " " +
                          item["Apellido Materno"].ToString() + " " +
                          item["Nombre"].ToString() +
                          ".docx");

                        myReport.ExportToPdf(stRutaDescargar +
                         item["idEmpleado"].ToString() + " - " +
                         item["Apellido Paterno"].ToString() + " " +
                         item["Apellido Materno"].ToString() + " " +
                         item["Nombre"].ToString() +
                         ".pdf");

                        //if (listRutaAnexos.Count > 0) //Agregar Anexos
                        //{
                        //    juridico.agregarAnexosVScontrato(stRutaDescargar +
                        //                   item["idEmpleado"].ToString() + " - " +
                        //                   item["Apellido Paterno"].ToString() + " " +
                        //                   item["Apellido Materno"].ToString() + " " +
                        //                   item["Nombre"].ToString() + " temp" +
                        //                   ".pdf",
                        //                   stRutaDescargar + item["idEmpleado"].ToString() + " - " +
                        //                   item["Apellido Paterno"].ToString() + " " +
                        //                   item["Apellido Materno"].ToString() + " " +
                        //                   item["Nombre"].ToString() +
                        //                   ".pdf",
                        //                   listRutaAnexos);
                        //}

                        //Agregar Ruta de Contratos
                        RutaContratos.Add(stRutaDescargar +
                         item["idEmpleado"].ToString() + " - " +
                         item["Apellido Paterno"].ToString() + " " +
                         item["Apellido Materno"].ToString() + " " +
                         item["Nombre"].ToString() +
                         ".pdf");

                    }
                    else if (item["idTipoMovimiento"].ToString() == "M")
                    {
                        List<String> listRutaAnexosCartaDeAsociacion = new List<String>();
                        listRutaAnexosCartaDeAsociacion.Add(Anexo_CartaDeAsociacion(stRutaAnexos3, idEmpleado, miSolicitud.idSolicitud, true));

                        myReport.ExportToDocx(stRutaDescargar +
                            item["idEmpleado"].ToString() + " - " +
                            item["Apellido Paterno"].ToString() + " " +
                            item["Apellido Materno"].ToString() + " " +
                            item["Nombre"].ToString() +
                            ".docx");

                        myReport.ExportToPdf(stRutaDescargar +
                            item["idEmpleado"].ToString() + " - " +
                            item["Apellido Paterno"].ToString() + " " +
                            item["Apellido Materno"].ToString() + " " +
                            item["Nombre"].ToString() + " temp" +
                            ".pdf");

                        if (listRutaAnexosCartaDeAsociacion.Count > 0) //Agregar Anexos
                        {
                            juridico.agregarAnexosVScontrato(stRutaDescargar +
                                           item["idEmpleado"].ToString() + " - " +
                                           item["Apellido Paterno"].ToString() + " " +
                                           item["Apellido Materno"].ToString() + " " +
                                           item["Nombre"].ToString() + " temp" +
                                           ".pdf",
                                           stRutaDescargar + item["idEmpleado"].ToString() + " - " +
                                           item["Apellido Paterno"].ToString() + " " +
                                           item["Apellido Materno"].ToString() + " " +
                                           item["Nombre"].ToString() +
                                           ".pdf",
                                           listRutaAnexosCartaDeAsociacion);
                        }

                        //Agregar Ruta de Contratos
                        RutaContratos.Add(stRutaDescargar + item["idEmpleado"].ToString() + " - " +
                                           item["Apellido Paterno"].ToString() + " " +
                                           item["Apellido Materno"].ToString() + " " +
                                           item["Nombre"].ToString() +
                                           ".pdf");
                    }

                    iConta++;
                }

                if (TipoDeGuardado == 3)
                {
                    juridico.CosolidarArcchivos(stRutaSolicitud + "Contratos " + dsc.nombreAleatorio() + ".pdf", RutaContratos);
                }

                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                XtraMessageBox.Show("Contratos Descargados con Exito." + Environment.NewLine + "Ruta: " + stRutaSolicitud
                           , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public String Anexo_CartaDeAsociacion(String stRutaAnexo, int idEmpleado, int idSolicitud, Boolean porSolicitud)
        {
            String stRuta = stRutaAnexo + idEmpleado.ToString() + "-Carta de Asociacion.pdf";

            Empleado MiEmpleado;
            Catalogos.frmxModificacionEmpleados Empleados = new Catalogos.frmxModificacionEmpleados(0, false, false, false, false, false, 0);
            MiEmpleado = Empleados.ObtenerInfoEmpleado(idEmpleado);

            Reportes.Anexo_CartaDeAsociasion myReport = new Reportes.Anexo_CartaDeAsociasion(MiEmpleado);

            try
            {
                myReport.Parameters["porSolicitud"].Value = porSolicitud;
                myReport.Parameters["idSolicitud"].Value = idSolicitud;
                myReport.Parameters["idEmpleado"].Value = idEmpleado;

                myReport.ExportToPdf(stRuta);
            }
            catch (Exception ex) { stRuta = String.Empty; }

            return stRuta;
        }

        public void eliminarArchivos(List<String> lstRutaArchvios)
        {
            foreach (String item in lstRutaArchvios) { File.Delete(item); }
        }

    }
}