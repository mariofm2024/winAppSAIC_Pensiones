using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using compCatalogosSAIC;
using System.IO;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;
using DevExpress.Pdf;
using DevExpress.XtraPrinting.Export.Pdf;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
using winAppSAIC.OperadoresM;

namespace winAppSAIC.Juridico
{
    public partial class XtraEmpleadosXSolicitudJuridico : DevExpress.XtraEditors.XtraForm
    {
        tools.dsc dsc = new tools.dsc();
        OperadoresM.Solicitud miSolicitud;
        int iTotalEmpleados;
        const int JURIDICO = 4;
        OperadoresM.ColorSolicitud miColorSolicitud;
        Empleado objEmp;
        public XtraEmpleadosXSolicitudJuridico(OperadoresM.Solicitud miSolicitud)
        {
            InitializeComponent();
            this.miSolicitud = miSolicitud;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XtraEmpleadosXSolicitudJuridico_Load(object sender, EventArgs e)
        {
            miColorSolicitud = new ColorSolicitud();
            miColorSolicitud = miColorSolicitud.obtenerColor();
            MostrarDetalleSolicitud(miSolicitud);
            CargarInformacion();
        }

        private void CargarInformacion()
        {
            splashScreenManager1.ShowWaitForm();

            //Cargar tipo de Documentacion
            stpSelTipoDocumentacionTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelTipoDocumentacion);

            stpSelSolicitudAltaEmpleadosJuridicoTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelSolicitudAltaEmpleadosJuridico, miSolicitud.idSolicitud);
            if (dbSAICBPOCatalogosDataSet1.stpSelSolicitudAltaEmpleadosJuridico.Rows.Count > 0)
            {
                btnExportar.Enabled = true;
                documentosToolStripMenuItem.Enabled = true;

                if (miSolicitud.idTipoSolicitud == 1) { toolStripDropDownButtonContrato.Enabled = true; }

                imprimirToolStripMenuItem.Enabled = true;

                btnAbrirCarpeta.Enabled = true;
                int iEmpleadosSolicitados = dbSAICBPOCatalogosDataSet1.stpSelSolicitudAltaEmpleadosJuridico.AsEnumerable().Where(x => x["Estatus"].ToString() == "SOLICITUD EMITIDA" || x["Estatus"].ToString() == "SOLICITUD EN PROCESO" || x["Estatus"].ToString() == "SOLICITUD RESPONDIDA" || x["Estatus"].ToString() == "SOLICITUD RECHAZADA").ToList().Count;
                iTotalEmpleados = dbSAICBPOCatalogosDataSet1.stpSelSolicitudAltaEmpleadosJuridico.Rows.Count;
                lblTotalEmpleadosSolicitud.Text = "Total Empleados: " + dbSAICBPOCatalogosDataSet1.stpSelSolicitudAltaEmpleadosJuridico.Rows.Count;
                lblEmpleadosSolicitados.Text = "Empleados Solicitados: " + iEmpleadosSolicitados;
                lblEmpleadosAtendidos.Text = "Empleados Atendidos: " + dbSAICBPOCatalogosDataSet1.stpSelSolicitudAltaEmpleadosJuridico.AsEnumerable().Where(x => x["Estatus"].ToString() == "SOLICITUD ATENDIDA AL 100%").ToList().Count;

                if (iEmpleadosSolicitados > 0)
                {
                    btnEstatusSolicitud.Enabled = true;
                }
                else
                {
                    btnEstatusSolicitud.Enabled = false;
                }
            }

            splashScreenManager1.CloseWaitForm();
        }

        private void btnEstatusSolicitud_Click(object sender, EventArgs e)
        {
            if (gridViewEmpleados.SelectedRowsCount > 0)
            {
                DialogResult resultado = XtraMessageBox.Show("¿Desea Atender a los empleados Seleccionados?"
                      , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == resultado)
                {
                    int iEmpleadosAtendidos = uncheckedGridEmpleado();

                    String stEmpleadosNoIngresados = String.Empty;
                    int iAtendidos = 0;
                    int iConError = 0;
                    int ipendientes = iTotalEmpleados;
                    DataTable dtEmpleadosSeleccionados = dsc.deGridViewSelectedToDataTable(gridViewEmpleados);
                    foreach (DataRow unRow in dtEmpleadosSeleccionados.Rows)
                    {
                        int iIDempleado;
                        int.TryParse(unRow["IdEmpleado"].ToString(), out iIDempleado);

                        if (iIDempleado != 0 && unRow["DescEstatus"].ToString() == "ACTIVO")
                        {
                            try
                            {
                                queriesTableAdapter1.stpUpdEstatusSolicitudAlta(JURIDICO,
                                                  miSolicitud.idSolicitud,
                                                  iIDempleado,
                                                   OperadorBD.OperadorGlobal.NombreOperador,
                                                   OperadorBD.OperadorGlobal.NombreUsuario,
                                                    DateTime.Now
                                                  );
                                iAtendidos++;
                                ipendientes--;
                            }
                            catch (Exception exp)
                            {
                                stEmpleadosNoIngresados += unRow["idEmpleado"].ToString() + " " + exp.Message + Environment.NewLine;
                                iConError++;
                            }
                        }
                    }

                    XtraMessageBox.Show(
                        "Total de Empleados: " + gridViewEmpleados.RowCount + Environment.NewLine +
                        "Total de Empleados Atendidos: " + (iAtendidos + iEmpleadosAtendidos) + Environment.NewLine +
                        "Empleados Atendidos: " + iAtendidos + Environment.NewLine +
                        "Empleados por Atender: " + (ipendientes - iEmpleadosAtendidos) + Environment.NewLine +
                        "Empleados no Actualizados (Error): " + iConError + Environment.NewLine
                        , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    miSolicitud = miSolicitud.ObtenerSolcitud(miSolicitud.idSolicitud, 3);
                    MostrarDetalleSolicitud(miSolicitud);
                    CargarInformacion();
                }
            }
            else
            {
                XtraMessageBox.Show("Seleccione un Empleado"
                    , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int uncheckedGridEmpleado()
        {
            int iConta = 0;

            for (int i = 0; i < gridViewEmpleados.RowCount; i++)
            {
                if (gridViewEmpleados.GetDataRow(i)["Estatus"].ToString() == "SOLICITUD ATENDIDA AL 100%" || gridViewEmpleados.GetDataRow(i)["Estatus"].ToString() == "SOLICITUD RECHAZADA")
                {
                    gridViewEmpleados.UnselectRow(i);
                    iConta++;
                }
            }

            return iConta;
        }

        private int uncheckedGridEmpleadoContrato()
        {
            int iConta = 0;

            for (int i = 0; i < gridViewEmpleados.RowCount; i++)
            {
                if (gridViewEmpleados.GetDataRow(i)["Contrato"].ToString() == "SI")
                {
                    gridViewEmpleados.UnselectRow(i);
                    iConta++;
                }
            }
            return iConta;
        }

        private void btnDescargarDocumentacion_Click(object sender, EventArgs e)
        {
            if (gridViewEmpleados.SelectedRowsCount > 0)
            {
                DataTable dtEmpleados = dsc.deGridViewSelectedToDataTable(gridViewEmpleados);
                //DataTable dtEmpleados = dsc.deGridViewaDataTable(gridViewEmpleados);
                OperadoresM.XtraMonitoreoSolicitudesOperaciones Operaciones = new OperadoresM.XtraMonitoreoSolicitudesOperaciones(0);
                Operaciones.descargarArchivoEmpleados(dtEmpleados, miSolicitud, 1);
            }
            else
            {
                XtraMessageBox.Show("Seleccione a un Empleado."
                    , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridViewEmpleados.Focus();
            }
            //DataTable dtEmpleados = dsc.deGridViewaDataTable(gridViewEmpleados);
            //OperadoresM.XtraMonitoreoSolicitudesOperaciones Operaciones = new OperadoresM.XtraMonitoreoSolicitudesOperaciones();
            //Operaciones.descargarArchivoEmpleados(dtEmpleados, miSolicitud, 1);
        }

        private void gridViewEmpleados_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                if (e.RowHandle >= 0)
                {
                    gridViewEmpleados.OptionsSelection.EnableAppearanceFocusedRow = false;

                    if (gridViewEmpleados.GetDataRow(e.RowHandle)["Tipo de Alta"].ToString() == "REINGRESO")
                    {
                        e.Appearance.BackColor = Color.FromArgb(miColorSolicitud.idColorReingreso[0], miColorSolicitud.idColorReingreso[1], miColorSolicitud.idColorReingreso[2]);
                        e.HighPriority = true;
                    }

                    if (gridViewEmpleados.GetDataRow(e.RowHandle)["Estatus Empleado"].ToString() == "BAJA")
                    {
                        e.Appearance.BackColor = Color.FromArgb(miColorSolicitud.idColorBaja[0], miColorSolicitud.idColorBaja[1], miColorSolicitud.idColorBaja[2]);
                        e.HighPriority = true;
                    }

                    if (gridViewEmpleados.GetDataRow(e.RowHandle)["Estatus"].ToString() == "SOLICITUD ATENDIDA AL 100%")
                    {
                        e.Appearance.BackColor = Color.FromArgb(miColorSolicitud.idColorAtendida[0], miColorSolicitud.idColorAtendida[1], miColorSolicitud.idColorAtendida[2]);
                        e.HighPriority = true;
                    }
                    else if (gridViewEmpleados.GetDataRow(e.RowHandle)["Estatus"].ToString() == "SOLICITUD RECHAZADA")
                    {
                        e.Appearance.BackColor = Color.FromArgb(miColorSolicitud.idColorRechazada[0], miColorSolicitud.idColorRechazada[1], miColorSolicitud.idColorRechazada[2]);
                        e.HighPriority = true;
                    }

                }
            }
            catch (Exception ex) { }
        }

        private void gridViewEmpleados_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            //for (int i = 0; i < gridViewEmpleados.RowCount; i++)
            //{
            //    if (gridViewEmpleados.GetDataRow(i)["Estatus"].ToString() == "SOLICITUD ATENDIDA AL 100%" || gridViewEmpleados.GetDataRow(i)["Estatus"].ToString() == "SOLICITUD RECHAZADA") // CLABEIncorrecta
            //        gridViewEmpleados.UnselectRow(i);
            //}
        }

        private void gridViewEmpleados_DoubleClick(object sender, EventArgs e)
        {

        }

        //Editar
        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            gridViewEmpleados.Focus();
            DataRow unRow = gridViewEmpleados.GetDataRow(gridViewEmpleados.FocusedRowHandle);

            if (unRow != null)
            {
                if (unRow["DescEstatus"].ToString() == "ACTIVO")
                {
                    if (unRow["Estatus"].ToString() == "SOLICITUD ATENDIDA AL 100%")
                    {
                        XtraMessageBox.Show("El Empleado: " +
                            unRow["Nombre"].ToString() + " " +
                            unRow["Apellido Paterno"].ToString() + " " +
                            unRow["Apellido Materno"].ToString() + ", ya se encuentra Atendido al 100%."
                       , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (unRow["Estatus"].ToString() == "SOLICITUD RECHAZADA")
                    {
                        XtraMessageBox.Show("El Empleado: " +
                         unRow["Nombre"].ToString() + " " +
                         unRow["Apellido Paterno"].ToString() + " " +
                         unRow["Apellido Materno"].ToString() + ", NO se puede editar al Empleado, se requiere Respuesta por parte de Operaciones."
                    , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int idEmpleado = Convert.ToInt32(unRow["idEmpleado"].ToString());

                        if (miSolicitud.idTipoSolicitud == 1)//Solicitud tipo Alta/Reingreso
                        {
                            Catalogos.frmxModificacionEmpleados modulosEdicionEmpleados = new Catalogos.frmxModificacionEmpleados(idEmpleado, false, true, false, true, false, miSolicitud.idSolicitud);
                            modulosEdicionEmpleados.ShowDialog();
                        }
                        else if (miSolicitud.idTipoSolicitud == 2)
                        {
                            DataTable dt = this.stpSelObtenerInfoEmpleadoModificacionCFDITableAdapter1.GetData(Convert.ToInt32(idEmpleado));
                            objEmp = EmpleadoBD.ObtenerInfoEmpleadoModificacionCFDI(dt);
                            XtraMotivoBajaEmpleado bajaEmpleado = new XtraMotivoBajaEmpleado(objEmp, 2, miSolicitud.FechaCreacion);
                            bajaEmpleado.ShowDialog();
                        }

                        miSolicitud = miSolicitud.ObtenerSolcitud(miSolicitud.idSolicitud, 3);
                        MostrarDetalleSolicitud(miSolicitud);
                        CargarInformacion();
                    }
                }
                else
                {
                    XtraMessageBox.Show("No se puede Editar, la Solicitud no esta Activada", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                XtraMessageBox.Show("No se puede abrir el modulo de Edicion.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Atender
        private void repositoryItemButtonEdit2_Click(object sender, EventArgs e)
        {
            gridViewEmpleados.Focus();
            DataRow unRow = gridViewEmpleados.GetDataRow(gridViewEmpleados.FocusedRowHandle);

            if (unRow != null)
            {
                if (unRow["DescEstatus"].ToString() == "ACTIVO")
                {
                    if (unRow["Estatus"].ToString() == "SOLICITUD ATENDIDA AL 100%")
                    {
                        XtraMessageBox.Show("El Empleado: " +
                              unRow["Nombre"].ToString() + " " +
                              unRow["Apellido Paterno"].ToString() + " " +
                              unRow["Apellido Materno"].ToString() + ", ya se encuentra Atendido al 100%."
                         , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (unRow["Estatus"].ToString() == "SOLICITUD RECHAZADA")
                    {
                        XtraMessageBox.Show("El Empleado: " +
                            unRow["Nombre"].ToString() + " " +
                            unRow["Apellido Paterno"].ToString() + " " +
                            unRow["Apellido Materno"].ToString() + ", NO se puede Atender al Empleado. Se requiere Respuesta por parte de Operaciones."
                       , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DialogResult resultado = XtraMessageBox.Show("¿Desea Atender al Empleado: " +
                                unRow["Nombre"].ToString() + " " +
                                unRow["Apellido Paterno"].ToString() + " " +
                                unRow["Apellido Materno"].ToString() + "?", "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (DialogResult.Yes == resultado)
                        {
                            int iIDempleado;
                            int.TryParse(unRow["IdEmpleado"].ToString(), out iIDempleado);

                            if (iIDempleado != 0)
                            {
                                try
                                {
                                    queriesTableAdapter1.stpUpdEstatusSolicitudAlta(JURIDICO,
                                                      miSolicitud.idSolicitud,
                                                      iIDempleado,
                                                       OperadorBD.OperadorGlobal.NombreOperador,
                                                       OperadorBD.OperadorGlobal.NombreUsuario,
                                                        DateTime.Now
                                                      );
                                }
                                catch (Exception exp)
                                {
                                    XtraMessageBox.Show("No se pudo actualizar al Empleado", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }

                                miSolicitud = miSolicitud.ObtenerSolcitud(miSolicitud.idSolicitud, 3);
                                MostrarDetalleSolicitud(miSolicitud);
                                CargarInformacion();
                            }
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show("No se puede Atender, la Solicitud no esta Activada", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                XtraMessageBox.Show("No se puede Atender el empleado.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Rechazar
        private void repositoryItemButtonEdit3_Click(object sender, EventArgs e)
        {
            gridViewEmpleados.Focus();
            DataRow unRow = gridViewEmpleados.GetDataRow(gridViewEmpleados.FocusedRowHandle);

            if (unRow != null)
            {
                if (unRow["DescEstatus"].ToString() == "ACTIVO")
                {
                    if (unRow["Estatus"].ToString() == "SOLICITUD ATENDIDA AL 100%")
                    {
                        XtraMessageBox.Show("El Empleado: " +
                            unRow["Nombre"].ToString() + " " +
                            unRow["Apellido Paterno"].ToString() + " " +
                            unRow["Apellido Materno"].ToString() + ", ya se encuentra Atendido al 100%."

                   , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (unRow["Estatus"].ToString() == "SOLICITUD RECHAZADA")
                    {
                        XtraMessageBox.Show("El Empleado: " +
                         unRow["Nombre"].ToString() + " " +
                         unRow["Apellido Paterno"].ToString() + " " +
                         unRow["Apellido Materno"].ToString() + ", NO se puede rechazar dos veces al empleado."

                        , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int idEmpleado;
                        int.TryParse(unRow["IdEmpleado"].ToString(), out idEmpleado);

                        DataTable dtEmpleadosporAtender = miSolicitud.obtenerRegistros_Emitidos_Proceso_Respondidos(dbSAICBPOCatalogosDataSet1.stpSelSolicitudAltaEmpleadosJuridico, "Estatus");
                        OperadoresM.XtraRechazoSolicitud rechazarSolicitud = new OperadoresM.XtraRechazoSolicitud(
                            dtEmpleadosporAtender,
                            miSolicitud.idSolicitud,
                            idEmpleado,
                            "JURIDICO",
                            unRow["Nombre"].ToString() + " " +
                            unRow["Apellido Paterno"].ToString() + " " +
                            unRow["Apellido Materno"].ToString(),
                             unRow["Rechazo"].ToString()
                            );
                        rechazarSolicitud.ShowDialog();
                        miSolicitud = miSolicitud.ObtenerSolcitud(miSolicitud.idSolicitud, 3);
                        MostrarDetalleSolicitud(miSolicitud);
                        CargarInformacion();
                    }
                }
                else
                {
                    XtraMessageBox.Show("No se puede rechazar, la Solicitud no esta Activada", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                XtraMessageBox.Show("No se puede abrir el modulo de Rechazo.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            String stRutaSolicitud = miSolicitud.sRutaSolicitud + miSolicitud.idSolicitud;
            dsc.CheckandCreateFolder(stRutaSolicitud);
            Process.Start(stRutaSolicitud);
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridViewEmpleados.SelectedRowsCount > 0)
            {
                DataTable dtEmpleasosSeleccionados = dsc.deGridViewSelectedToDataTable(gridViewEmpleados);
                XtraDatosContrato datosContrato = new XtraDatosContrato(miSolicitud, dtEmpleasosSeleccionados, 1);
                datosContrato.ShowDialog();

                //String stEmpleados = String.Empty;
                //DataTable dtEmpleasosSeleccionados = dsc.deGridViewSelectedToDataTable(gridViewEmpleados);
                //foreach (DataRow item in dtEmpleasosSeleccionados.Rows)
                //{
                //    stEmpleados += item["idEmpleado"].ToString() + "|";
                //}

                //Reportes.CIT_PPP myReport = new Reportes.CIT_PPP();
                //// Reportes.ContratoEmpleadosPPP myReport = new Reportes.ContratoEmpleadosPPP();

                //try
                //{
                //    myReport.Parameters["stEmpleados"].Value = stEmpleados;
                //    myReport.Parameters["tipoConsulta"].Value = 0;
                //    myReport.ShowPrintMarginsWarning = false;
                //    myReport.ShowPreview();
                //}
                //catch (Exception ex) { }

            }
            else
            {
                XtraMessageBox.Show("Seleccione un Empleado"
                  , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void validarContratoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ReportPrintTool tool = new ReportPrintTool(report);
            //tool.PreviewForm.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.File, DevExpress.XtraPrinting.CommandVisibility.None);
            //tool.ShowPreview();



            if (gridViewEmpleados.SelectedRowsCount > 0)
            {
                String stEmpleados = String.Empty;
                DataTable dtEmpleasosSeleccionados = dsc.deGridViewSelectedToDataTable(gridViewEmpleados);
                foreach (DataRow item in dtEmpleasosSeleccionados.Rows)
                {
                    stEmpleados += item["idEmpleado"].ToString() + "|";
                }

                Reportes.CIT_PPP myReport = new Reportes.CIT_PPP();
                //Reportes.ContratoEmpleadosPPP myReport = new Reportes.ContratoEmpleadosPPP();

                try
                {
                    myReport.Parameters["flagConGenerico"].Value = true;
                    myReport.Parameters["stEmpleados"].Value = stEmpleados;
                    myReport.ShowPrintMarginsWarning = false;
                    ReportPrintTool tool = new ReportPrintTool(myReport);
                    tool.PreviewForm.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.File, DevExpress.XtraPrinting.CommandVisibility.None);
                    tool.PreviewForm.PrintBarManager.MainMenu.Visible = false;
                    tool.PreviewForm.PrintBarManager.DockManager.ToolTipController.Active = false;
                    //tool.PreviewForm.PrintBarManager.ToolTipController.Visible = false;
                    tool.ShowPreview();
                    //myReport.ShowPreview();
                }
                catch (Exception ex) { }

            }
            else
            {
                XtraMessageBox.Show("Seleccione un Empleado"
                  , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void individualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CITDescargaIndividual(false, 2);
        }

        private List<String> CITDescargaIndividual(Boolean flagPorSolicitud, int iTipoConsulta)
        {
            splashScreenManager1.ShowWaitForm();
            splashScreenManager1.SetWaitFormCaption("Contratos");
            splashScreenManager1.SetWaitFormDescription("Descargando...");

            List<String> lstRutaArchivos = new List<String>();
            if (gridViewEmpleados.SelectedRowsCount > 0)
            {
                DataTable dtEmpleadosSeleccionados = dsc.deGridViewSelectedToDataTable(gridViewEmpleados);

                //Obteniendo los empleados seleccionados por tipo de contrato
                var result = (from r in dtEmpleadosSeleccionados.AsEnumerable()
                              select r["IdTipoContrato"]).Distinct().ToList();

                List<int> sTipoContratos = result.Select(s => (int)s).ToList();

                DataTable dtDatosContratos = new DataTable();
                dtDatosContratos.Columns.Add("idTipoContrato", typeof(int));
                dtDatosContratos.Columns.Add("ContratoGenerico", typeof(Boolean));
                dtDatosContratos.Columns.Add("ContratoNuevoCIT", typeof(Boolean));

                foreach (int item in sTipoContratos)
                {
                    stpSelObtenerInfoContratosTenedorasTableAdapter1.Fill(dataSetJuridico1.stpSelObtenerInfoContratosTenedoras, 0, miSolicitud.idTenedoraSA, item);
                    Boolean flagGenerico = true;
                    Boolean flagNuevoCIT = false;

                    if (dataSetJuridico1.stpSelObtenerInfoContratosTenedoras.Rows.Count > 0)
                    {
                        Boolean.TryParse(dataSetJuridico1.stpSelObtenerInfoContratosTenedoras.Rows[0]["ContratoGenerico"].ToString(), out flagGenerico);
                        Boolean.TryParse(dataSetJuridico1.stpSelObtenerInfoContratosTenedoras.Rows[0]["ContratoActivado"].ToString(), out flagNuevoCIT);
                    }

                    DataRow unRow = dtDatosContratos.NewRow();
                    unRow["idTipoContrato"] = item;
                    unRow["ContratoGenerico"] = flagGenerico;
                    unRow["ContratoNuevoCIT"] = flagNuevoCIT;
                    dtDatosContratos.Rows.Add(unRow);
                }

                DataTable dtEmpleadosCITGenerico = dtEmpleadosSeleccionados.Clone();
                DataTable dtEmpleadosCITNuevo = dtEmpleadosSeleccionados.Clone();

                //juntando Empleados seleccionados con contrato Generico para solicitar solo una vez el firmante para los contratos genericos
                foreach (DataRow item in dtDatosContratos.Rows)
                {
                    DataTable dtResultado = dtEmpleadosSeleccionados.Clone();
                    if ((Boolean)item["ContratoNuevoCIT"] == true)
                    {
                        dtResultado = (from x in dtEmpleadosSeleccionados.AsEnumerable()
                                       where x.Field<int>("IdTipoContrato").Equals((int)item["idTipoContrato"])
                                       select x).CopyToDataTable();

                        dtEmpleadosCITNuevo.Merge(dtResultado);

                    }
                    else
                    {
                        dtResultado = (from x in dtEmpleadosSeleccionados.AsEnumerable()
                                       where x.Field<int>("IdTipoContrato").Equals((int)item["idTipoContrato"])
                                       select x).CopyToDataTable();

                        dtEmpleadosCITGenerico.Merge(dtResultado);
                    }

                }

                if (dtEmpleadosCITGenerico.Rows.Count > 0)
                {
                    stpSelCITFirmantesTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelCITFirmantes, miSolicitud.idMatrizTenedora);
                    if (dbSAICBPOCatalogosDataSet1.stpSelCITFirmantes.Rows.Count > 0)
                    {
                        if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                        //DataTable dtEmpleasosSeleccionados = dsc.deGridViewSelectedToDataTable(gridViewEmpleados);
                        //int iTipoConsulta = flagPorSolicitud ? 3 : 2;

                        XtraDatosContrato datosContrato = new XtraDatosContrato(miSolicitud, dtEmpleadosCITGenerico, iTipoConsulta);

                        datosContrato.ShowDialog();
                        lstRutaArchivos = datosContrato.lstRutaAarchivos;
                    }
                    else
                    {
                        if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                        XtraMessageBox.Show("La Empresa: " + miSolicitud.TenedoraSA + ", No tiene Firmante. Por favor Agrege un Firmante a la Empresa para Continuar."
                             , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (!splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.ShowWaitForm(); }
                    }
                }

                if (!splashScreenManager1.IsSplashFormVisible)
                {
                    splashScreenManager1.ShowWaitForm();
                    splashScreenManager1.SetWaitFormCaption("Contratos");
                    splashScreenManager1.SetWaitFormDescription("Descargando...");
                }

                if (dtEmpleadosCITNuevo.Rows.Count > 0)
                {
                    foreach (DataRow item in dtEmpleadosCITNuevo.Rows)
                    {
                        int idEmpleado = 0;
                        int.TryParse(item["IdEmpleado"].ToString(), out idEmpleado);
                        String stRutaContratoEmpleado = miSolicitud.sRutaSolicitud + miSolicitud.idSolicitud + @"\" + item["idEmpleado"] + @"\";
                        dsc.CheckandCreateFolder(stRutaContratoEmpleado);
                        stRutaContratoEmpleado += "CIT " + item["Apellido Paterno"] + " " + item["Apellido Materno"] + " " + item["Nombre"] + " - " + dsc.nombreAleatorio() + ".pdf";
                        Juridico.XtraContratos oXtraContratos = new Juridico.XtraContratos();

                        if (iTipoConsulta == 4)
                        {
                            oXtraContratos.VisualizarContrato(0, idEmpleado, 2, String.Empty);
                        }
                        else
                        {
                            oXtraContratos.VisualizarContrato(0, idEmpleado, 3, stRutaContratoEmpleado);
                        }

                        lstRutaArchivos.Add(stRutaContratoEmpleado);
                    }
                }

                if (flagPorSolicitud)//Para Consolidar
                {
                    XtraEmpleadosXSolicitudJuridico juridico = new XtraEmpleadosXSolicitudJuridico(miSolicitud);
                    String stNombreCIT = miSolicitud.sRutaSolicitud + miSolicitud.idSolicitud + @"\Contratos - S" + miSolicitud.idSolicitud + " " + dsc.nombreAleatorio() + ".pdf";
                    juridico.CosolidarArcchivos(stNombreCIT, lstRutaArchivos);
                }

                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                XtraMessageBox.Show("Proceso Terminado"
                     , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                XtraMessageBox.Show("Seleccione un Empleado."
                     , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return lstRutaArchivos;
        }



        private void autorizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CITDescargaIndividual(false, 4);
            CargarInformacion();

            //if (gridViewEmpleados.SelectedRowsCount > 0)
            //{
            //    stpSelCITFirmantesTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelCITFirmantes, miSolicitud.idMatrizTenedora);
            //    if (dbSAICBPOCatalogosDataSet1.stpSelCITFirmantes.Rows.Count > 0)
            //    {
            //        DataTable dtEmpleasosSeleccionados = dsc.deGridViewSelectedToDataTable(gridViewEmpleados);
            //        XtraDatosContrato datosContrato = new XtraDatosContrato(miSolicitud, dtEmpleasosSeleccionados, 4);
            //        datosContrato.ShowDialog();
            //        CargarInformacion();
            //    }
            //    else
            //    {
            //        XtraMessageBox.Show("La Empresa: " + miSolicitud.TenedoraSA + ", No tiene Firmante. Por favor Agrege un Firmante a la Empresa para Continuar."
            //             , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
            //else
            //{
            //    XtraMessageBox.Show("Por favor seeleccione a un Empleado."
            //         , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

        }


        private List<String> descargarContratoEmpleado()
        {
            List<String> listRutaContratos = new List<String>();
            List<String> listRutaAnexos = new List<String>();
            int iConta = 1;

            Boolean flatContinuar = true;

            String stRutaSolicitud = miSolicitud.sRutaSolicitud + miSolicitud.idSolicitud + @"\Juridico\Contratos\";
            dsc.CheckandCreateFolder(stRutaSolicitud);

            listRutaAnexos = DescargarAnexos(stRutaSolicitud, miSolicitud.idMatrizTenedora);

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
                DataTable dtEmpleasosSeleccionados = dsc.deGridViewSelectedToDataTable(gridViewEmpleados);
                splashScreenManager1.ShowWaitForm();
                splashScreenManager1.SetWaitFormCaption("Descargando Contrato");

                foreach (DataRow item in dtEmpleasosSeleccionados.Rows)
                {
                    splashScreenManager1.SetWaitFormDescription(iConta + " de " + dtEmpleasosSeleccionados.Rows.Count);

                    Reportes.CIT_PPP myReport = new Reportes.CIT_PPP();
                    myReport.Parameters["flagConGenerico"].Value = true;
                    myReport.Parameters["stEmpleados"].Value = item["idEmpleado"].ToString() + "|";
                    myReport.Parameters["tipoConsulta"].Value = 0;

                    myReport.ExportToPdf(stRutaSolicitud +
                        item["idEmpleado"].ToString() + " - " +
                        item["Apellido Paterno"].ToString() + " " +
                        item["Apellido Materno"].ToString() + " " +
                        item["Nombre"].ToString() + " temp" +
                        ".pdf");

                    agregarAnexosVScontrato(stRutaSolicitud +
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
                        listRutaAnexos);

                    //Agregar Ruta de Contratos
                    listRutaContratos.Add(stRutaSolicitud + item["idEmpleado"].ToString() + " - " +
                        item["Apellido Paterno"].ToString() + " " +
                        item["Apellido Materno"].ToString() + " " +
                        item["Nombre"].ToString() +
                        ".pdf");

                    iConta++;

                }

                splashScreenManager1.CloseWaitForm();

                XtraMessageBox.Show("Contratos Descargados con Exito." + Environment.NewLine + "Ruta: " + stRutaSolicitud
                           , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            return listRutaContratos;
        }

        private void porSolicitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CITDescargaIndividual(true, 3);


            //if (gridViewEmpleados.SelectedRowsCount > 0)
            //{
            //    stpSelCITFirmantesTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelCITFirmantes, miSolicitud.idMatrizTenedora);
            //    if (dbSAICBPOCatalogosDataSet1.stpSelCITFirmantes.Rows.Count > 0)
            //    {
            //        DataTable dtEmpleasosSeleccionados = dsc.deGridViewSelectedToDataTable(gridViewEmpleados);
            //        XtraDatosContrato datosContrato = new XtraDatosContrato(miSolicitud, dtEmpleasosSeleccionados, 3);                    
            //        datosContrato.ShowDialog();
            //    }
            //    else
            //    {
            //        XtraMessageBox.Show("La Empresa: " + miSolicitud.TenedoraSA + ", No tiene Firmante. Por favor Agrege un Firmante a la Empresa para Continuar."
            //             , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //    //descargarContratoEmpleado();
            //}
            //else
            //{
            //    XtraMessageBox.Show("Por favor seeleccione a un Empleado."
            //         , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        public List<String> DescargarAnexos(String stRuta, int idMatrizTendora)
        {
            List<String> listRutaAnexos = new List<String>();

            String rutaTemp = stRuta + @"Anexos\";
            dsc.CheckandCreateFolder(rutaTemp);

            int idTenedora = idMatrizTendora;
            stpSelDocumentosVersionTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelDocumentosVersion, idTenedora, 0);

            if (dbSAICBPOCatalogosDataSet1.stpSelDocumentosVersion.Rows.Count > 0)
            {
                try
                {
                    foreach (DataRow item in dbSAICBPOCatalogosDataSet1.stpSelDocumentosVersion.Rows)
                    {
                        dsc.ConvertToFile(item["Valor"].ToString(),
                              rutaTemp + item["NombreArchivo"].ToString() +
                              item["Extencion"].ToString());
                        listRutaAnexos.Add(rutaTemp + item["NombreArchivo"].ToString() + item["Extencion"].ToString());
                    }
                }
                catch (Exception) { }
            }

            return listRutaAnexos;
        }

        /// <summary>
        /// Descarga de Documentos para el Contrato 20211012
        /// </summary>
        /// <param name="stRutaSolicitud"></param>
        /// <param name="idFirmante"></param>
        /// <param name="idEmpleado"></param>
        /// <returns></returns>
        public List<String> DescargarDocumentosContrato(String sArea, String stRutaSolicitud, String stNombreEmpleado, int idSolicitud, int idFirmante, int idEmpleado)
        {
            List<String> lstRutaDocumentos = new List<String>();

            //quitar comentario
            //obtener Documentos activados
            stpSelDocumentosContratoActivosTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelDocumentosContratoActivos);
            String sRutaArchivo = String.Empty;
            for (int i = 0; i < dbSAICBPOCatalogosDataSet1.stpSelDocumentosContratoActivos.Rows.Count; i++)
            {
                int idDocumentosContrato = 0;
                int.TryParse(dbSAICBPOCatalogosDataSet1.stpSelDocumentosContratoActivos.Rows[i]["idDocumentosContrato"].ToString(), out idDocumentosContrato);
                sRutaArchivo = stRutaSolicitud + dbSAICBPOCatalogosDataSet1.stpSelDocumentosContratoActivos.Rows[i]["DescTipoDocumento"].ToString() + " " + stNombreEmpleado + " " + dsc.nombreAleatorio() + ".pdf";

                Juridico.Reportes.DocumentosContrato oDocumentosContrato = new Reportes.DocumentosContrato();
                oDocumentosContrato.Parameters["sArea"].Value = sArea;
                oDocumentosContrato.Parameters["idDocumentosContrato"].Value = idDocumentosContrato;
                oDocumentosContrato.Parameters["IdSolicitud"].Value = idSolicitud;
                oDocumentosContrato.Parameters["IdFirmante"].Value = idFirmante;
                oDocumentosContrato.Parameters["IdEmpleado"].Value = idEmpleado;
                oDocumentosContrato.ExportToPdf(sRutaArchivo);
                lstRutaDocumentos.Add(sRutaArchivo);
            }

            return lstRutaDocumentos;
        }


        /// <summary>
        /// Descargar contratos de Confidencialidad 
        /// </summary>
        /// <param name="stRuta"></param>
        /// <param name="idEmpleado"></param>
        public void DescargarContratoConficialidad(String stRuta, int idEmpleado, String stNombreEmpleados)
        {
            List<String> listContatosDeConficialidad = new List<String>();
            Boolean estaMuyBien = true;
            stpSelTipoContratoDeConfidencialidadTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelTipoContratoDeConfidencialidad);

            foreach (DataRow unRow in dbSAICBPOCatalogosDataSet1.stpSelTipoContratoDeConfidencialidad.Rows)
            {
                int idTipoContratoDeConfidencialidad;
                int.TryParse(unRow["idTipoContratoConfidencialidad"].ToString(), out idTipoContratoDeConfidencialidad);

                stpSelContratoDeConfidencialidadTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelContratoDeConfidencialidad, idTipoContratoDeConfidencialidad, idEmpleado);

                if (dbSAICBPOCatalogosDataSet1.stpSelContratoDeConfidencialidad.Rows.Count > 0)
                {
                    if (estaMuyBien)
                    {
                        stRuta += @"Contrato de Confidencialidad\";
                        dsc.CheckandCreateFolder(stRuta);
                        estaMuyBien = false;
                    }

                    Cartas.ContratoDeConficialidad myReport = new Cartas.ContratoDeConficialidad();
                    myReport.Parameters["stContrato"].Value = dbSAICBPOCatalogosDataSet1.stpSelContratoDeConfidencialidad.Rows[0]["Contrato"].ToString();
                    myReport.ExportToPdf(stRuta + idEmpleado + " - " + stNombreEmpleados + " " +
                        dbSAICBPOCatalogosDataSet1.stpSelContratoDeConfidencialidad.Rows[0]["NombreArchvio"].ToString() + ".pdf");
                }
            }
        }

        private void toolStripDropDownButtonContrato_Click(object sender, EventArgs e)
        {

        }

        public void agregarAnexosVScontrato(String stRutaaContratoEmpleado, String stNombreArchivo, List<String> listRutaAenexos)
        {
            using (PdfDocumentProcessor pdfDocumentProcessor = new PdfDocumentProcessor())
            {
                pdfDocumentProcessor.CreateEmptyDocument(stNombreArchivo);
                pdfDocumentProcessor.AppendDocument(stRutaaContratoEmpleado);
                foreach (String StAnexo in listRutaAenexos)
                {
                    pdfDocumentProcessor.AppendDocument(StAnexo);
                }
            }

            File.Delete(stRutaaContratoEmpleado);
        }

        public void agregarAnexosVScontrato(String stRutaaContratoEmpleado, String stNombreArchivo, List<String> listRutaAenexos, List<String> listRutaDocumentoContrato)
        {
            using (PdfDocumentProcessor pdfDocumentProcessor = new PdfDocumentProcessor())
            {
                pdfDocumentProcessor.CreateEmptyDocument(stNombreArchivo);
                pdfDocumentProcessor.AppendDocument(stRutaaContratoEmpleado);
                foreach (String StAnexo in listRutaAenexos)
                {
                    pdfDocumentProcessor.AppendDocument(StAnexo);
                }

                foreach (String StAnexo in listRutaDocumentoContrato)
                {
                    pdfDocumentProcessor.AppendDocument(StAnexo);
                }
            }

            File.Delete(stRutaaContratoEmpleado);
        }





        /// <summary>
        /// 
        /// </summary>
        /// <param name="stRutaNombreArchivo">Ruta de Archivo a quien se le van a agregar los Archivos.</param>
        /// <param name="listRutaArchivos">Lista de Ruta de archivos que se van agregar.</param>
        public void CosolidarArcchivos(String stRutaNombreArchivo, List<String> listRutaArchivos)
        {
            using (PdfDocumentProcessor pdfDocumentProcessor = new PdfDocumentProcessor())
            {
                pdfDocumentProcessor.CreateEmptyDocument(stRutaNombreArchivo);
                foreach (String StAnexo in listRutaArchivos)
                {
                    pdfDocumentProcessor.AppendDocument(StAnexo);
                }
            }

            foreach (String item in listRutaArchivos) { File.Delete(item); }
        }


        private void GuardarXSolicitud(DataTable dtEmpleasosSeleccionados, int idFirmante)
        {
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
                splashScreenManager1.ShowWaitForm();
                splashScreenManager1.SetWaitFormCaption("Descargando Anexos");
                splashScreenManager1.SetWaitFormDescription("Espere Por favor...");
                listRutaAnexos = DescargarAnexos(stRutaSolicitud, miSolicitud.idMatrizTenedora);

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
                    splashScreenManager1.SetWaitFormDescription("Descargando Contratos");

                    foreach (DataRow item in dtEmpleasosSeleccionados.Rows)
                    {
                        splashScreenManager1.SetWaitFormDescription("Contratos " + iConta + " de " + dtEmpleasosSeleccionados.Rows.Count);
                        Reportes.CIT_PPP myReport = new Reportes.CIT_PPP();
                        myReport.Parameters["flagConGenerico"].Value = true;
                        myReport.Parameters["stEmpleados"].Value = item["idEmpleado"].ToString() + "|";
                        myReport.Parameters["tipoConsulta"].Value = 0;
                        //myReport.Parameters["IdFirmante"].Value = gridLookFirmantes.EditValue;
                        myReport.Parameters["IdFirmante"].Value = idFirmante;

                        if (item["idTipoMovimiento"].ToString() != "A")
                        {
                            myReport.ExportToPdf(stRutaSolicitud +
                                      item["idEmpleado"].ToString() + " - " +
                                      item["Apellido Paterno"].ToString() + " " +
                                      item["Apellido Materno"].ToString() + " " +
                                      item["Nombre"].ToString() + " temp" +
                                      ".pdf");

                            agregarAnexosVScontrato(stRutaSolicitud +
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
                                        listRutaAnexos);

                            RutaContratos.Add(stRutaSolicitud + item["idEmpleado"].ToString() + " - " +
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

                        iConta++;
                    }

                    splashScreenManager1.SetWaitFormDescription("Consolidando Contratos");
                    //Consolidar Archivos
                    CosolidarArcchivos(stRutaSolicitud + "Contratos.pdf", RutaContratos);

                    splashScreenManager1.CloseWaitForm();

                    XtraMessageBox.Show("Contratos Descargados con Exito." + Environment.NewLine + "Ruta: " + stRutaSolicitud
                         , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    splashScreenManager1.CloseWaitForm();
                }
            }
            else
            {
                XtraMessageBox.Show("Por favor seeleccione a un Empleado."
                      , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GuardarIndividual(DataTable dtEmpleasosSeleccionados, int idFirmante)
        {
            List<String> listRutaContratos = new List<String>();
            List<String> listRutaAnexos = new List<String>();
            int iConta = 1;

            Boolean flatContinuar = true;

            //String stRutaSolicitud = dsc.stRutaAltaSolicitudEmpelados + miSolicitud.idSolicitud + @"\Juridico\Contratos\";
            String stRutaSolicitud = miSolicitud.sRutaSolicitud + miSolicitud.idSolicitud + @"\";
            dsc.CheckandCreateFolder(stRutaSolicitud);

            String stRutaAnexos = miSolicitud.sRutaSolicitud + miSolicitud.idSolicitud + @"\Anexos\";
            listRutaAnexos = DescargarAnexos(stRutaAnexos, miSolicitud.idMatrizTenedora);

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

                    Reportes.CIT_PPP myReport = new Reportes.CIT_PPP();
                    myReport.Parameters["flagConGenerico"].Value = true;
                    myReport.Parameters["stEmpleados"].Value = item["idEmpleado"].ToString() + "|";
                    //myReport.Parameters["stEmpleados"].Value = item["idEmpleado"].ToString();
                    //myReport.Parameters["IdFirmante"].Value = gridLookFirmantes.EditValue;
                    myReport.Parameters["IdFirmante"].Value = idFirmante;
                    myReport.Parameters["tipoConsulta"].Value = 0;

                    if (item["idTipoMovimiento"].ToString() != "A")
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
                            item["Nombre"].ToString() + " temp" +
                            ".pdf");

                        agregarAnexosVScontrato(stRutaDescargar +
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
                            listRutaAnexos);

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
                            miFile.CopyTo(stRutaDescargar +
                            item["idEmpleado"].ToString() + " - " +
                            item["Apellido Paterno"].ToString() + " " +
                            item["Apellido Materno"].ToString() + " " +
                            item["Nombre"].ToString() + miFile.Name);
                        }
                    }

                    iConta++;

                }

                splashScreenManager1.CloseWaitForm();

                XtraMessageBox.Show("Contratos Descargados con Exito." + Environment.NewLine + "Ruta: " + stRutaSolicitud
                           , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void documentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridViewEmpleados.SelectedRowsCount > 0)
            {
                OperadoresM.XtraMonitoreoSolicitudesOperaciones Operaciones = new OperadoresM.XtraMonitoreoSolicitudesOperaciones(0);
                DataTable dtEmpleados = dsc.deGridViewSelectedToDataTable(gridViewEmpleados);
                Operaciones.descargarDocumentacionEmpleado(dtEmpleados, miSolicitud);
            }
            else
            {
                XtraMessageBox.Show("Seleccione un Empleado."
             , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //splashScreenManager1.ShowWaitForm();
            //int iArchivosEstan = 0;
            //int iArchivosNOEstan = 0;
            //int iArchivosNoDescargados = 0;
            //String stRutaSolicitud = dsc.stRutaSAIC + @"Alta Empleados Solicitudes\" + miSolicitud.idSolicitud + @"\";
            //dsc.CheckandCreateFolder(stRutaSolicitud);
            //DataTable dtEmpleados = dsc.deGridViewaDataTable(gridViewEmpleados);
            //foreach (DataRow unRow in dtEmpleados.Rows)
            //{
            //    int idEmpleado = Convert.ToInt32(unRow["IdEmpleado"].ToString());
            //    try
            //    {
            //        stpSelDocumentoEmpleadoTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelDocumentoEmpleado, idEmpleado);
            //        if (dbSAICBPOCatalogosDataSet1.stpSelDocumentoEmpleado.Rows.Count > 0)
            //        {

            //            foreach (DataRow item in dbSAICBPOCatalogosDataSet1.stpSelDocumentoEmpleado.Rows)
            //            {
            //                //Creando Carpeta por Empleado
            //                String stRutaEmpleado = stRutaSolicitud + idEmpleado + @"\" + item["DesTipoDocumento"].ToString() + @"\";
            //                dsc.CheckandCreateFolder(stRutaEmpleado);

            //                String stNombreEmpleado = item["NombreEmpleadoCompleto"].ToString();
            //                stNombreEmpleado = stNombreEmpleado.Replace("\\", "").Replace("/", "").Replace(":", "").Replace("+", "").Replace("?", "").Replace("\"", "").Replace("<", "").Replace(">", "").Replace("|", "");
            //                dsc.ConvertToFile(item["DesDocumento"].ToString(), stRutaEmpleado + stNombreEmpleado + ".pdf");
            //            }

            //            iArchivosEstan++;
            //        }
            //        else
            //        {
            //            iArchivosNOEstan++;
            //        }
            //    }
            //    catch (Exception)
            //    {
            //        iArchivosNoDescargados++;
            //    }
            //}
            //splashScreenManager1.CloseWaitForm();
            //XtraMessageBox.Show("Documentos Empleados." + Environment.NewLine +
            //      "Documentos Generados: " + iArchivosEstan + Environment.NewLine +
            //      "Documentos no Encontrados: " + iArchivosNOEstan + Environment.NewLine +
            //      "Documentos no Descargados: " + iArchivosNoDescargados + Environment.NewLine +
            //      "Los Documentos los podra revisar en la Ruta: " + stRutaSolicitud + Environment.NewLine + " De su computadora."
            //      , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void fielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            splashScreenManager1.SetWaitFormCaption("Descargando Afil");
            splashScreenManager1.SetWaitFormDescription("Espere Por favor...");

            try
            {
                OperadoresM.XtraMonitoreoSolicitudesOperaciones objMonitoreo = new OperadoresM.XtraMonitoreoSolicitudesOperaciones(0);
                String stRuta = miSolicitud.sRutaSolicitud + miSolicitud.idSolicitud + @"\";
                int iConta = objMonitoreo.DescargsarFiel(miSolicitud.idSolicitud, stRuta, miSolicitud.idTipoSolicitud);
                splashScreenManager1.CloseWaitForm();
                XtraMessageBox.Show("Documentos Afil Descargados: " + iConta
                   , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                splashScreenManager1.CloseWaitForm();
                XtraMessageBox.Show("Error al descargar Documentos." + Environment.NewLine + ex.Message
                   , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MostrarDetalleSolicitud(Solicitud miSolicitud)
        {
            btnAbrirCarpeta.Enabled = false;
            toolStripDropDownButtonContrato.Enabled = false;
            btnExportar.Enabled = false;
            documentosToolStripMenuItem.Enabled = false;
            btnEstatusSolicitud.Enabled = false;

            txtbxSolicitud.Text = miSolicitud.idSolicitud.ToString();
            txtbxfechaAlta.Text = miSolicitud.FechaCreacion.ToShortDateString();
            txtbxOperador.Text = miSolicitud.NombreOperador;
            txtbxTenedoraSA.Text = miSolicitud.TenedoraSA;
            txtEstatus.Text = miSolicitud.EstatusJuridico;
            txtCliente.Text = miSolicitud.Cliente;
            txtExcedente.Text = miSolicitud.TenedoraSC;
            txtTipoSolicitud.Text = miSolicitud.DescTipoSolicitud;
        }

    }
}
