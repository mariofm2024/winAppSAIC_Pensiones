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
using System.Data.SqlClient;

namespace winAppSAIC.OperadoresM
{
    public partial class frmxMonitoreoSolicitudesAreas : DevExpress.XtraEditors.XtraForm
    {
        String stArea = String.Empty;
        int iArea = 0;
        DevExpress.XtraEditors.PanelControl panelControlMenu;
        DataTable stSolciitudes;
        tools.dsc dsc = new tools.dsc();
        int iTipoTesoreria = 0;

        public frmxMonitoreoSolicitudesAreas(String stArea, DevExpress.XtraEditors.PanelControl panelControlMenu, int iArea)
        {
            InitializeComponent();
            this.stArea = stArea;
            this.iArea = iArea;
            this.panelControlMenu = panelControlMenu;
        }

        private void checkTodas_CheckedChanged(object sender, EventArgs e)
        {
            checkProceso.Checked = false;
            checkSolicitadas.Checked = false;
            checkAtendidas.Checked = false;
        }

        private void checkAtendidas_CheckedChanged(object sender, EventArgs e)
        {
            filtroSolicitudes();
        }

        private void checkSolicitadas_CheckedChanged(object sender, EventArgs e)
        {
            filtroSolicitudes();
        }

        private void checkProceso_CheckedChanged(object sender, EventArgs e)
        {
            filtroSolicitudes();
        }

        private void checkRechazadas_CheckedChanged(object sender, EventArgs e)
        {
            filtroSolicitudes();
        }

        private void checkCanceladas_CheckedChanged(object sender, EventArgs e)
        {
            filtroSolicitudes();
        }

        private void frmxMonitoreoSolicitudesAreas_Load(object sender, EventArgs e)
        {
            simpleButton1.Text = simpleButton1.Text + " " + stArea;
            ObtenerInformacion();
        }

        private void ObtenerInformacion()
        {
            try
            {
                splashScreenManager3.ShowWaitForm();
                DataTable dtEmpleados;
                if (stArea == "TESORERIA")
                {
                    iTipoTesoreria = rdTesoreriaSA.Checked ? 0 : 1;

                    stpSelObtenerSolicitudesAltaTesoreriaTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelObtenerSolicitudesAltaTesoreria, OperadorBD.OperadorGlobal.IdOperador, OperadorBD.OperadorGlobal.IdAreaOperativa, iTipoTesoreria);
                    dtEmpleados = dbSAICBPOCatalogosDataSet.stpSelObtenerSolicitudesAltaTesoreria;
                }
                else if (stArea == "IMSS")
                {
                    stpSelObtenerSolicitudesAltaIMSSTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelObtenerSolicitudesAltaIMSS, OperadorBD.OperadorGlobal.IdOperador, OperadorBD.OperadorGlobal.IdAreaOperativa);
                    dtEmpleados = dbSAICBPOCatalogosDataSet.stpSelObtenerSolicitudesAltaIMSS;
                }
                else
                {
                    stpSelObtenerSolicitudesAltaJuridicoTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelObtenerSolicitudesAltaJuridico, OperadorBD.OperadorGlobal.IdOperador, OperadorBD.OperadorGlobal.IdAreaOperativa);
                    dtEmpleados = dbSAICBPOCatalogosDataSet.stpSelObtenerSolicitudesAltaJuridico;
                }

                if (stArea == "TESORERIA")
                {
                    stpSelParametroTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelParametro, "btnReporteSolTarjetas");
                    if (dbSAICBPOCatalogosDataSet.stpSelParametro.Rows.Count > 0)
                    {
                        String stVisibleBoton = dbSAICBPOCatalogosDataSet.stpSelParametro.Rows[0][0].ToString();
                        if (!String.IsNullOrEmpty(stVisibleBoton))
                        {
                            btnReporteSolTarjetas.Visible = true;
                        }
                        else
                        {
                            btnReporteSolTarjetas.Visible = false;
                        }
                    }
                    else
                    {
                        btnReporteSolTarjetas.Visible = false;
                    }
                }

                if (stArea == "JURIDICO" || stArea == "IMSS")
                {
                    btnReporteSolTarjetas.Visible = false;
                    rdTesoreriaSA.Visible = false;
                    rdTesoreriaSC.Visible = false;
                    rdTesoreriaSA.Checked = false;
                    rdTesoreriaSC.Checked = false;
                }

                //stpSelObtenerSolicitudesAltaOperacionesTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelObtenerSolicitudesAltaOperaciones, OperadorBD.OperadorGlobal.IdOperador, OperadorBD.OperadorGlobal.IdAreaOperativa);
                stSolciitudes = obtenerColumnasxArea(dtEmpleados, stArea);
                filtroSolicitudes();
                splashScreenManager3.CloseWaitForm();
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("No se puede cargar las Solicitudes." + Environment.NewLine + ex.Message, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Obtiene un DataTable solo con las columnas del area que se este consultando
        /// </summary>
        /// <param name="dtSolicitudes"></param>
        /// <param name="stArea"></param>
        private DataTable obtenerColumnasxArea(DataTable dtSolicitudes, String stArea)
        {
            String stColumnaEstatus = String.Empty;

            DataTable dtDetalleSolicitud = new DataTable();
            dtDetalleSolicitud.Columns.Add("idSolicitud", typeof(int));
            dtDetalleSolicitud.Columns.Add("Tipo de Solicitud", typeof(String));
            dtDetalleSolicitud.Columns.Add("Registro Patronal", typeof(String));
            dtDetalleSolicitud.Columns.Add("TenedoraSA", typeof(String));
            dtDetalleSolicitud.Columns.Add("Haberes", typeof(String));
            dtDetalleSolicitud.Columns.Add("Cliente", typeof(String));
            dtDetalleSolicitud.Columns.Add("NombreCompletoOperador", typeof(String));
            dtDetalleSolicitud.Columns.Add("Estatus", typeof(String));
            dtDetalleSolicitud.Columns.Add("Fecha Solicitud", typeof(DateTime));
            dtDetalleSolicitud.Columns.Add("Hora Solicitud", typeof(TimeSpan));
            dtDetalleSolicitud.Columns.Add("idEstatus", typeof(int));
            dtDetalleSolicitud.Columns.Add("DescEstatus", typeof(String));

            if (stArea == "IMSS")
            {
                stColumnaEstatus = "EstatusIMSS";
                dtDetalleSolicitud.Columns.Add("SalariosRegistrosVencidos", typeof(int));
                dtDetalleSolicitud.Columns.Add("SalariosRegistrosDeHoy", typeof(int));
            }
            else if (stArea == "JURIDICO")
            {
                stColumnaEstatus = "EstatusJuridico";
            }
            else if (stArea == "TESORERIA")
            {
                stColumnaEstatus = "EstatusTesoreria";
            }

            if (stArea == "IMSS")
            {
                var query = from x in dtSolicitudes.AsEnumerable()
                            select new
                            {
                                idSolicitud = x.Field<int>("idSolicitud"),
                                stTipoSolicitud = x.Field<String>("TipoSolicitud"),
                                rPatronal = x.Field<String>("Registro Patronal"),
                                TenedoraSA = x.Field<String>("TenedoraSA"),
                                TenedoraSC = x.Field<String>("Haberes"),
                                Cliente = x.Field<String>("Cliente"),
                                NombreCompletoOperador = x.Field<String>("NombreCompletoOperador"),
                                Estatus = x.Field<String>(stColumnaEstatus),
                                FechaCreacion = x.Field<DateTime>("FechaCreacion"),
                                HoraCreacion = x.Field<DateTime>("FechaCreacion"),
                                SalariosRegistrosVencidos = x.Field<int>("SalariosRegistrosVencidos"),
                                SalariosRegistrosDeHoy = x.Field<int>("SalariosRegistrosDeHoy"),
                                idEstatus = x.Field<int>("IdEstatus"), // Estatus del Registro
                                DescEstatus = x.Field<String>("DescEstatus") // Estatus del Registro
                            };

                if (query.Count() > 0)
                {
                    foreach (var item in query)
                    {
                        DataRow unRow = dtDetalleSolicitud.NewRow();
                        unRow["idSolicitud"] = item.idSolicitud;
                        unRow["Tipo de Solicitud"] = item.stTipoSolicitud;
                        unRow["Registro Patronal"] = item.rPatronal;
                        unRow["TenedoraSA"] = item.TenedoraSA;
                        unRow["Haberes"] = item.TenedoraSC;
                        unRow["Cliente"] = item.Cliente;
                        unRow["NombreCompletoOperador"] = item.NombreCompletoOperador;
                        unRow["Estatus"] = item.Estatus;
                        unRow["Fecha Solicitud"] = item.FechaCreacion;
                        unRow["Hora Solicitud"] = item.HoraCreacion.Hour + ":" + item.HoraCreacion.Minute + ":" + item.HoraCreacion.Second;
                        unRow["SalariosRegistrosVencidos"] = item.SalariosRegistrosVencidos;
                        unRow["SalariosRegistrosDeHoy"] = item.SalariosRegistrosDeHoy;
                        unRow["IdEstatus"] = item.idEstatus;
                        unRow["DescEstatus"] = item.DescEstatus;
                        dtDetalleSolicitud.Rows.Add(unRow);
                    }
                }
            }
            else
            {
                var query = from x in dtSolicitudes.AsEnumerable()
                            select new
                            {
                                idSolicitud = x.Field<int>("idSolicitud"),
                                stTipoSolicitud = x.Field<String>("TipoSolicitud"),
                                rPatronal = x.Field<String>("Registro Patronal"),
                                TenedoraSA = x.Field<String>("TenedoraSA"),
                                TenedoraSC = x.Field<String>("Haberes"),
                                Cliente = x.Field<String>("Cliente"),
                                NombreCompletoOperador = x.Field<String>("NombreCompletoOperador"),
                                Estatus = x.Field<String>(stColumnaEstatus),
                                FechaCreacion = x.Field<DateTime>("FechaCreacion"),
                                HoraCreacion = x.Field<DateTime>("FechaCreacion"),
                                idEstatus = x.Field<int>("IdEstatus"), // Estatus del Registro
                                DescEstatus = x.Field<String>("DescEstatus") // Estatus del Registro

                            };

                if (query.Count() > 0)
                {
                    foreach (var item in query)
                    {
                        DataRow unRow = dtDetalleSolicitud.NewRow();
                        unRow["idSolicitud"] = item.idSolicitud;
                        unRow["Tipo de Solicitud"] = item.stTipoSolicitud;
                        unRow["Registro Patronal"] = item.rPatronal;
                        unRow["TenedoraSA"] = item.TenedoraSA;
                        unRow["Haberes"] = item.TenedoraSC;
                        unRow["Cliente"] = item.Cliente;
                        unRow["NombreCompletoOperador"] = item.NombreCompletoOperador;
                        unRow["Estatus"] = item.Estatus;
                        unRow["Fecha Solicitud"] = item.FechaCreacion;
                        unRow["Hora Solicitud"] = item.HoraCreacion.Hour + ":" + item.HoraCreacion.Minute + ":" + item.HoraCreacion.Second;
                        unRow["IdEstatus"] = item.idEstatus;
                        unRow["DescEstatus"] = item.DescEstatus;
                        dtDetalleSolicitud.Rows.Add(unRow);
                    }
                }
            }

            try
            {
                DataView losDatos = new DataView(dtDetalleSolicitud);
                losDatos.Sort = "idSolicitud";
                GridControlSolicitudes_2.DataSource = losDatos;
            }
            catch (Exception)
            {
                GridControlSolicitudes_2.DataSource = dtDetalleSolicitud;
            }

            gridVSolicitudes.BestFitColumns();

            return dtDetalleSolicitud;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //if (stArea == "IMSS")
            //{
            //    IMSS.XtraEmpleadosXSolicitudIMSS EmpleadosSolicitud = new IMSS.XtraEmpleadosXSolicitudIMSS();
            //    EmpleadosSolicitud.ShowDialog();
            //}
            //else if (stArea == "Tesoreria")
            //{
            //    Tesoreria.XtraSolicitudesxEmpleadoTesoreria EmpleadosSolicitud = new Tesoreria.XtraSolicitudesxEmpleadoTesoreria();
            //    EmpleadosSolicitud.ShowDialog();
            //}
            //else if (stArea == "Juridico")
            //{
            //    Juridico.XtraEmpleadosXSolicitudJuridico EmpleadosSolicitud = new Juridico.XtraEmpleadosXSolicitudJuridico();
            //    EmpleadosSolicitud.ShowDialog();
            //}
        }
        private void filtroSolicitudes()
        {
            String stProceso = "SOLICITUD EN PROCESO";
            String stEmitida = "SOLICITUD EMITIDA";
            String stAtendida = "SOLICITUD ATENDIDA AL 100%";
            String stRechazada = "SOLICITUD RECHAZADA";
            String stRespondida = "SOLICITUD RESPONDIDA";
            String stCancelada = "SOLICITUD CANCELADA";

            DataTable dtSolicitudes = stSolciitudes.Clone();
            DataTable dtProceso = stSolciitudes.Clone();
            DataTable dtEmitida = stSolciitudes.Clone();
            DataTable dtAtendida = stSolciitudes.Clone();
            DataTable dtRechazada = stSolciitudes.Clone();

            if (checkProceso.Checked)
            {
                var query = (from x in stSolciitudes.AsEnumerable()
                             where x.Field<String>("Estatus").Equals(stProceso) && x.Field<int>("IdEstatus").Equals(2)
                             select x);

                if (query.Count() > 0)
                {
                    dtProceso = query.CopyToDataTable();
                    dtSolicitudes.Merge(dtProceso);
                }
            }
            if (checkSolicitadas.Checked)
            {
                var query = (from x in stSolciitudes.AsEnumerable()
                             where x.Field<String>("Estatus").Equals(stEmitida) && x.Field<int>("IdEstatus").Equals(2)
                             select x);

                if (query.Count() > 0)
                {
                    dtEmitida = query.CopyToDataTable();
                    dtSolicitudes.Merge(dtEmitida);
                }
            }
            if (checkAtendidas.Checked)
            {
                var query = (from x in stSolciitudes.AsEnumerable()
                             where x.Field<String>("Estatus").Equals(stAtendida) && x.Field<int>("IdEstatus").Equals(2)
                             select x);

                if (query.Count() > 0)
                {
                    dtAtendida = query.CopyToDataTable();
                    dtSolicitudes.Merge(dtAtendida);
                }
            }
            if (checkRechazadas.Checked)
            {
                var query = (from x in stSolciitudes.AsEnumerable()
                             where (x.Field<String>("Estatus").Equals(stRechazada) || x.Field<String>("Estatus").Equals(stRespondida))
                              && x.Field<int>("IdEstatus").Equals(2)
                             select x);

                if (query.Count() > 0)
                {
                    dtRechazada = query.CopyToDataTable();
                    dtSolicitudes.Merge(dtRechazada);
                }
            }
            if (checkCanceladas.Checked)
            {
                var query = (from x in stSolciitudes.AsEnumerable()
                             where x.Field<int>("IdEstatus").Equals(23)
                             select x);

                if (query.Count() > 0)
                {
                    dtRechazada = query.CopyToDataTable();
                    dtSolicitudes.Merge(dtRechazada);
                }
            }

            try
            {
                DataView losDatos = new DataView(dtSolicitudes);
                losDatos.Sort = "idSolicitud";
                GridControlSolicitudes_2.DataSource = losDatos;
            }
            catch (Exception)
            {
                GridControlSolicitudes_2.DataSource = dtSolicitudes;
            }


            gridVSolicitudes.BestFitColumns();
            lblNumSoliciutd.Text = "Numero de Solicitudes: " + dtSolicitudes.Rows.Count;
        }

        private void gridVSolicitudes_DoubleClick(object sender, EventArgs e)
        {
            AbrirSolicitud(iArea);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ObtenerInformacion();
        }

        private void btnReporteSolTarjetas_Click(object sender, EventArgs e)
        {
            Solicitud miSolicitud = new Solicitud();
            try
            {
                stpSelInfoEmpleadosSolTarjetasTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelInfoEmpleadosSolTarjetas);
            }
            catch (Exception) { }

            Tesoreria.XtraSolicitudesxEmpleadoTesoreria Tesoreria = new Tesoreria.XtraSolicitudesxEmpleadoTesoreria(miSolicitud, 0);
            Tesoreria.descargarArchivoEmpleadosTarjeta(dbSAICBPOCatalogosDataSet.stpSelInfoEmpleadosSolTarjetas);
        }

        private void rdTesoreriaSA_Click(object sender, EventArgs e)
        {
            ObtenerInformacion();
        }

        private void rdTesoreriaSC_Click(object sender, EventArgs e)
        {
            ObtenerInformacion();
        }

        private void btnReporteSolTarjetas_Click_1(object sender, EventArgs e)
        {
            Solicitud miSolicitud = new Solicitud();
            stpSelInfoEmpleadosSolTarjetasTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelInfoEmpleadosSolTarjetas);
            Tesoreria.XtraSolicitudesxEmpleadoTesoreria Tesoreria = new Tesoreria.XtraSolicitudesxEmpleadoTesoreria(miSolicitud, 0);
            Tesoreria.descargarArchivoEmpleadosTarjeta(dbSAICBPOCatalogosDataSet.stpSelInfoEmpleadosSolTarjetas);
        }

        private void rdTesoreriaSA_Click_2(object sender, EventArgs e)
        {
            ObtenerInformacion();
        }

        private void rdTesoreriaSC_Click_1(object sender, EventArgs e)
        {
            ObtenerInformacion();
        }

        private void gridVSolicitudes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                AbrirSolicitud(iArea);
            }
        }

        /// <summary>
        /// Abrir Solicitud seleccionada
        /// </summary>
        private void AbrirSolicitud(int iArea)
        {
            GridControlSolicitudes_2.Focus();
            DataRow unRow = gridVSolicitudes.GetDataRow(gridVSolicitudes.FocusedRowHandle);
            if (unRow != null)
            {
                int iSolicitud;
                int.TryParse(unRow["idSolicitud"].ToString(), out iSolicitud);

                Solicitud miSolicitud = new Solicitud();
                miSolicitud = miSolicitud.ObtenerSolcitud(iSolicitud, iArea);

                DateTime dtFechaCreacion;

                DateTime.TryParse(unRow["Fecha Solicitud"].ToString(), out dtFechaCreacion);
                String stOperacion = unRow["NombreCompletoOperador"].ToString();
                String stTenedoraSA = unRow["TenedoraSA"].ToString();
                String stRPatronal = unRow["Registro Patronal"].ToString();

                if (iSolicitud > 0)
                {
                    String stAreaSeleccionada = String.Empty;
                    if (stArea.Contains("TESORERIA"))
                    {
                        if (rdTesoreriaSA.Checked) { stAreaSeleccionada = "TESORERIASA"; }
                        else { stAreaSeleccionada = "TESORERIASC"; }
                    }
                    else
                    {
                        stAreaSeleccionada = stArea;
                    }

                    //Actualizar Solicitud y empleados como "En Proceso"
                    queriesTableAdapter1.stpUpdSolicitudEmpleadosEnProceso(iSolicitud, stAreaSeleccionada, OperadorBD.OperadorGlobal.NombreUsuario, DateTime.Now);

                    if (stArea == "IMSS")
                    {
                        if (miSolicitud.idTipoSolicitud == 1 || miSolicitud.idTipoSolicitud == 2)
                        {
                            IMSS.XtraEmpleadosXSolicitudIMSS EmpleadosSolicitud = new IMSS.XtraEmpleadosXSolicitudIMSS(miSolicitud);
                            EmpleadosSolicitud.ShowDialog();
                        }
                        else if (miSolicitud.idTipoSolicitud == 4)
                        {
                            XtraSolicitudesSalarioAreas oXtraSolicitudesSalarioAreas = new XtraSolicitudesSalarioAreas("IMSS", miSolicitud.idSolicitud);
                            oXtraSolicitudesSalarioAreas.ShowDialog();
                        }

                    }
                    else if (stArea == "TESORERIA")
                    {
                        iTipoTesoreria = rdTesoreriaSA.Checked ? 0 : 1;
                        if (unRow["Tipo de Solicitud"].ToString() == "ACTUALIZACIÓN DE CUENTA")
                        {
                            Tesoreria.XtraSolicitudAltaCuentaEmpleados SolicitudesCuentaDeEmpleados = new Tesoreria.XtraSolicitudAltaCuentaEmpleados(miSolicitud.idSolicitud, iTipoTesoreria);
                            SolicitudesCuentaDeEmpleados.ShowDialog();
                        }
                        else
                        {
                            Tesoreria.XtraSolicitudesxEmpleadoTesoreria EmpleadosSolicitud = new Tesoreria.XtraSolicitudesxEmpleadoTesoreria(miSolicitud, iTipoTesoreria);
                            EmpleadosSolicitud.ShowDialog();
                        }
                    }
                    else if (stArea == "JURIDICO")
                    {
                        if (miSolicitud.idTipoSolicitud == 1 || miSolicitud.idTipoSolicitud == 2)
                        {
                            Juridico.XtraEmpleadosXSolicitudJuridico EmpleadosSolicitud = new Juridico.XtraEmpleadosXSolicitudJuridico(miSolicitud);
                            EmpleadosSolicitud.ShowDialog();
                        }
                        else if (miSolicitud.idTipoSolicitud == 4)
                        {
                            XtraSolicitudesSalarioAreas oXtraSolicitudesSalarioAreas = new XtraSolicitudesSalarioAreas("JURIDICO", miSolicitud.idSolicitud);
                            oXtraSolicitudesSalarioAreas.ShowDialog();
                        }
                    }

                    ObtenerInformacion();
                }
            }
        }

        private void gridVSolicitudes_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {

            try
            {
                if (stArea == "IMSS")
                {
                    if (e.RowHandle >= 0)
                    {
                        gridVSolicitudes.OptionsSelection.EnableAppearanceFocusedRow = false;

                        if (gridVSolicitudes.GetDataRow(e.RowHandle)["Tipo de Solicitud"].ToString() == "SALARIOS")
                        {
                            int iSalariosRegistrosVencidos = 0;
                            int iSalariosRegistrosDeHoy = 0;

                            int.TryParse(gridVSolicitudes.GetDataRow(e.RowHandle)["SalariosRegistrosVencidos"].ToString(), out iSalariosRegistrosVencidos);
                            int.TryParse(gridVSolicitudes.GetDataRow(e.RowHandle)["SalariosRegistrosDeHoy"].ToString(), out iSalariosRegistrosDeHoy);

                            if (iSalariosRegistrosVencidos > 0)
                            {
                                e.Appearance.BackColor = Color.LightCoral;
                                e.Appearance.BackColor2 = Color.White;
                                e.HighPriority = true;
                            }
                            else
                            {
                                if (iSalariosRegistrosDeHoy > 0)
                                {
                                    e.Appearance.BackColor = Color.Khaki;
                                    e.Appearance.BackColor2 = Color.White;
                                    e.HighPriority = true;
                                }
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {

            }

        }
    }

    public class Solicitud
    {

        public Solicitud()
        {
            idSolicitud = 0;
            idMatrizTenedora = 0;
            NombreRepresentanteLegal = String.Empty;
            idTenedoraSA = 0;
            TenedoraSC = String.Empty;
            RegistroPatronal = String.Empty;
            Cliente = String.Empty;
            EstatusJuridico = String.Empty;
            EstatusTesoreria = String.Empty;
            EstatusIMSS = String.Empty;
            EstatusSolicitud = String.Empty;
            JuridicoFechaFin = new DateTime(1900, 01, 01);
            IMSSFechaFin = new DateTime(1900, 01, 01);
            TesoreriaFechaFin = new DateTime(1900, 01, 01);
            Operador = String.Empty;
            NombreOperador = String.Empty; ;
            FechaCreacion = new DateTime(1900, 01, 01);
            FechaModificacion = new DateTime(1900, 01, 01);
            UsuarioCreacion = String.Empty;
            UsuarioModificacion = String.Empty;
            idPlan = String.Empty;
            idTenedoraSC = 0;
            idCliente = 0;            
            idTipoSolicitud = 0;
            DescTipoSolicitud = String.Empty;
            flagContratoActivadoDeterminado = false;
            flagContratoGenericoDeterminado = false;
            flagContratoActivadoIndeterminado = false;
            flagContratoGenericoIndeterminado = false;
            sRutaSolicitud = String.Empty;
        }

        public int idSolicitud { get; set; }
        public int idMatrizTenedora { get; set; }
        public String NombreRepresentanteLegal { get; set; }
        public int idTenedoraSA { get; set; }
        public String TenedoraSA { get; set; }
        public String TenedoraSC { get; set; }
        public String RegistroPatronal { get; set; }
        public String Cliente { get; set; }
        public String EstatusJuridico { get; set; }
        public String EstatusTesoreria { get; set; }
        public String EstatusIMSS { get; set; }
        public String EstatusSolicitud { get; set; }
        public DateTime JuridicoFechaFin { get; set; }
        public DateTime IMSSFechaFin { get; set; }
        public DateTime TesoreriaFechaFin { get; set; }
        public String Operador { get; set; }
        public String NombreOperador { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public String UsuarioCreacion { get; set; }
        public String UsuarioModificacion { get; set; }
        public String idPlan { get; set; }
        public int idTenedoraSC { get; set; }
        public int idCliente { get; set; }        
        public int idTipoSolicitud { get; set; }
        public String DescTipoSolicitud { get; set; }
        public Boolean flagContratoActivadoDeterminado { get; set; }
        public Boolean flagContratoGenericoDeterminado { get; set; }
        public Boolean flagContratoActivadoIndeterminado { get; set; }
        public Boolean flagContratoGenericoIndeterminado { get; set; }
        public String sRutaSolicitud { get; set; }

        public int iTotalDeEmpleados { get; set; }
        public int iTotalEmpleadosAtendidos { get; set; }
        public int iTotalEmpleadosRechazados { get; set; }
        public int iTotalEmpleadosCancelados { get; set; }

        //public const String stRutaSolicitudes = @"C:\SAIC\Alta Empleados Solicitudes\";




        /// <summary>
        /// 
        /// </summary>
        /// <param name="numSolicitud"></param>
        /// <param name="iArea">
        /// 1 = Operaciones,
        /// 2 = IMSS,
        /// 3  Juridico,
        /// 4 = tesoreria,
        /// 5 = Contabilidad</param>
        /// <returns></returns>
        public Solicitud ObtenerSolcitud(int numSolicitud, int iArea)
        {
            Solicitud miSolicitud = new Solicitud();
            tools.dsc dsc = new tools.dsc();
            string sConexionBD = winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString;
            try
            {
                using (SqlConnection Cnn = new SqlConnection(sConexionBD))
                {
                    SqlCommand cmd = new SqlCommand("dbo.stpSelSolicitudAltaEmpleados", Cnn)
                    { CommandType = CommandType.StoredProcedure };

                    cmd.Parameters.AddWithValue("@pNumSolicitud", numSolicitud);

                    Cnn.Open(); //abrir conexion
                    cmd.ExecuteNonQuery();  //ejecutar stored procedure
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            miSolicitud.idSolicitud = numSolicitud;
                            miSolicitud.TenedoraSA = reader.GetString(1);
                            miSolicitud.TenedoraSC = reader.GetString(2);
                            miSolicitud.RegistroPatronal = reader.GetString(3);
                            miSolicitud.Cliente = reader.GetString(4);
                            miSolicitud.EstatusJuridico = reader.GetString(5);
                            miSolicitud.EstatusTesoreria = reader.GetString(6);
                            miSolicitud.EstatusIMSS = reader.GetString(7);
                            miSolicitud.EstatusSolicitud = reader.GetString(8);

                            miSolicitud.JuridicoFechaFin = Convert.ToDateTime(reader.GetValue(9).ToString());
                            miSolicitud.IMSSFechaFin = Convert.ToDateTime(reader.GetValue(10).ToString());
                            miSolicitud.TesoreriaFechaFin = Convert.ToDateTime(reader.GetValue(11).ToString());

                            miSolicitud.Operador = reader.GetString(12);
                            miSolicitud.NombreOperador = reader.GetString(13);

                            miSolicitud.FechaCreacion = Convert.ToDateTime(reader.GetValue(14).ToString());
                            miSolicitud.FechaModificacion = Convert.ToDateTime(reader.GetValue(15).ToString());
                            miSolicitud.UsuarioCreacion = reader.GetString(16);
                            miSolicitud.UsuarioModificacion = reader.GetString(17);
                            miSolicitud.idMatrizTenedora = Convert.ToInt32(reader.GetValue(18).ToString());
                            miSolicitud.NombreRepresentanteLegal = reader.GetString(19);
                            miSolicitud.idPlan = reader.GetString(20);
                            miSolicitud.idTenedoraSA = Convert.ToInt32(reader.GetValue(21).ToString());
                            miSolicitud.idTenedoraSC = Convert.ToInt32(reader.GetValue(22).ToString());
                            miSolicitud.idCliente = Convert.ToInt32(reader.GetValue(23).ToString());
                            miSolicitud.idTipoSolicitud = Convert.ToInt32(reader.GetValue(24).ToString());
                            miSolicitud.sRutaSolicitud = dsc.ObtenerRutaSolicitud(Convert.ToInt32(reader.GetValue(24).ToString()), iArea);
                            miSolicitud.DescTipoSolicitud = reader.GetValue(25).ToString();

                            miSolicitud.flagContratoActivadoDeterminado = (reader.GetValue(26).ToString() == "0" ? false : true);
                            miSolicitud.flagContratoGenericoDeterminado = (reader.GetValue(27).ToString() == "0" ? false : true);
                            miSolicitud.flagContratoActivadoIndeterminado = (reader.GetValue(28).ToString() == "0" ? false : true);
                            miSolicitud.flagContratoGenericoIndeterminado = (reader.GetValue(29).ToString() == "0" ? false : true);

                            miSolicitud.iTotalDeEmpleados = Convert.ToInt32(reader.GetValue(30).ToString());
                            miSolicitud.iTotalEmpleadosAtendidos = Convert.ToInt32(reader.GetValue(31).ToString());
                            miSolicitud.iTotalEmpleadosRechazados = Convert.ToInt32(reader.GetValue(32).ToString());
                            miSolicitud.iTotalEmpleadosCancelados = Convert.ToInt32(reader.GetValue(33).ToString());

                        }
                    }

                    Cnn.Close();    //cerrar conexion
                }  //using
            }
            catch (SqlException ex) { }
            catch (Exception ex) { }

            return miSolicitud;
        }

        /// <summary>
        /// Se obtiene este filtro para obtener todas los empleados emitidos o en proceso o respondios por si el usuario quiere rechazar todos los empleados de la solicutd
        /// </summary>
        /// <param name="unGridView"></param>
        /// <param name="stColumnaEstatus"></param>
        /// <returns></returns>
        public DataTable obtenerRegistros_Emitidos_Proceso_Respondidos(DevExpress.XtraGrid.Views.Grid.GridView unGridView, String stColumnaEstatus)
        {
            DataTable dtDatos = new DataTable();

            for (int i = 0; i < unGridView.Columns.Count; i++)
            {
                dtDatos.Columns.Add(unGridView.Columns[i].FieldName);
            }

            for (int i = 0; i < unGridView.RowCount; i++)
            {
                DataRow unRow = dtDatos.NewRow();

                for (int x = 0; x < unGridView.GetDataRow(i).ItemArray.Count(); x++)
                {
                    unRow[x] = unGridView.GetDataRow(i).ItemArray[x];
                }
                dtDatos.Rows.Add(unRow);
            }

            var query = from x in dtDatos.AsEnumerable()
                        where x.Field<String>(stColumnaEstatus).Equals("SOLICITUD EMITIDA") ||
                        x.Field<String>(stColumnaEstatus).Equals("SOLICITUD EN PROCESO") ||
                        x.Field<String>(stColumnaEstatus).Equals("SOLICITUD RESPONDIDA")
                        select x;

            if (query.Count() > 0)
            {
                dtDatos = query.CopyToDataTable();
            }
            else
            {
                dtDatos = new DataTable();
            }

            return dtDatos;
        }
        public DataTable obtenerRegistros_Emitidos_Proceso_Respondidos(DataTable dtLosDatos, String stColumnaEstatus)
        {

            var query = from x in dtLosDatos.AsEnumerable()
                        where x.Field<String>(stColumnaEstatus).Equals("SOLICITUD EMITIDA") ||
                        x.Field<String>(stColumnaEstatus).Equals("SOLICITUD EN PROCESO") ||
                        x.Field<String>(stColumnaEstatus).Equals("SOLICITUD RESPONDIDA")
                        select x;

            if (query.Count() > 0)
            {
                dtLosDatos = query.CopyToDataTable();
            }
            else
            {
                dtLosDatos = new DataTable();
            }

            return dtLosDatos;
        }

    }

    public class ColorSolicitud
    {
        public int[] idColorReingreso = new int[3] { 255, 255, 255 };
        public int[] idColorAtendida = new int[3] { 255, 255, 255 };
        public int[] idColorRechazada = new int[3] { 255, 255, 255 };
        public int[] idColorBaja = new int[3] { 255, 255, 255 };
        public int[] idColorProceso = new int[3] { 255, 255, 255 };
        public int[] idColorInactivo = new int[3] { 255, 255, 255 };

        public ColorSolicitud obtenerColor()
        {
            ColorSolicitud miColoSolicitud = new ColorSolicitud();

            miColoSolicitud = obtenerColorReingreso(miColoSolicitud);
            miColoSolicitud = obtenerColorAtendida(miColoSolicitud);
            miColoSolicitud = obtenerColorRechazada(miColoSolicitud);
            miColoSolicitud = obtenerColorBaja(miColoSolicitud);
            miColoSolicitud = obtenerColorProceso(miColoSolicitud);
            miColoSolicitud = obtenerColorInactivo(miColoSolicitud);

            return miColoSolicitud;
        }

        private ColorSolicitud obtenerColorReingreso(ColorSolicitud miColoSolicitud)
        {
            string sConexionBD = winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString;
            try
            {
                using (SqlConnection Cnn = new SqlConnection(sConexionBD))
                {
                    SqlCommand cmd = new SqlCommand("dbo.stpSelParametro", Cnn)
                    { CommandType = CommandType.StoredProcedure };

                    cmd.Parameters.AddWithValue("@pDescParametro", "COLORREINGRESO");

                    Cnn.Open(); //abrir conexion
                    cmd.ExecuteNonQuery();  //ejecutar stored procedure
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int[] arrayColor;
                            arrayColor = obtenerColor(reader.GetString(0));

                            miColoSolicitud.idColorReingreso[0] = arrayColor[0];
                            miColoSolicitud.idColorReingreso[1] = arrayColor[1];
                            miColoSolicitud.idColorReingreso[2] = arrayColor[2];
                        }
                    }

                    Cnn.Close();    //cerrar conexion
                }  //using
            }
            catch (SqlException ex)
            {
                miColoSolicitud.idColorReingreso[0] = 255;
                miColoSolicitud.idColorReingreso[1] = 255;
                miColoSolicitud.idColorReingreso[2] = 255;
            }
            catch (Exception ex)
            {
                miColoSolicitud.idColorReingreso[0] = 255;
                miColoSolicitud.idColorReingreso[1] = 255;
                miColoSolicitud.idColorReingreso[2] = 255;
            }
            return miColoSolicitud;
        }

        private ColorSolicitud obtenerColorAtendida(ColorSolicitud miColoSolicitud)
        {
            string sConexionBD = winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString;
            try
            {
                using (SqlConnection Cnn = new SqlConnection(sConexionBD))
                {
                    SqlCommand cmd = new SqlCommand("dbo.stpSelParametro", Cnn)
                    { CommandType = CommandType.StoredProcedure };

                    cmd.Parameters.AddWithValue("@pDescParametro", "COLORATENDIDA");

                    Cnn.Open(); //abrir conexion
                    cmd.ExecuteNonQuery();  //ejecutar stored procedure
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int[] arrayColor;
                            arrayColor = obtenerColor(reader.GetString(0));
                            miColoSolicitud.idColorAtendida[0] = arrayColor[0];
                            miColoSolicitud.idColorAtendida[1] = arrayColor[1];
                            miColoSolicitud.idColorAtendida[2] = arrayColor[2];
                        }
                    }

                    Cnn.Close();    //cerrar conexion
                }  //using
            }
            catch (SqlException ex)
            {
                miColoSolicitud.idColorAtendida[0] = 255;
                miColoSolicitud.idColorAtendida[1] = 255;
                miColoSolicitud.idColorAtendida[2] = 255;
            }
            catch (Exception ex)
            {
                miColoSolicitud.idColorAtendida[0] = 255;
                miColoSolicitud.idColorAtendida[1] = 255;
                miColoSolicitud.idColorAtendida[2] = 255;
            }
            return miColoSolicitud;
        }

        private ColorSolicitud obtenerColorRechazada(ColorSolicitud miColoSolicitud)
        {
            string sConexionBD = winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString;
            try
            {
                using (SqlConnection Cnn = new SqlConnection(sConexionBD))
                {
                    SqlCommand cmd = new SqlCommand("dbo.stpSelParametro", Cnn)
                    { CommandType = CommandType.StoredProcedure };

                    cmd.Parameters.AddWithValue("@pDescParametro", "COLORRECHAZADA");

                    Cnn.Open(); //abrir conexion
                    cmd.ExecuteNonQuery();  //ejecutar stored procedure
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int[] arrayColor;
                            arrayColor = obtenerColor(reader.GetString(0));
                            miColoSolicitud.idColorRechazada[0] = arrayColor[0];
                            miColoSolicitud.idColorRechazada[1] = arrayColor[1];
                            miColoSolicitud.idColorRechazada[2] = arrayColor[2];
                        }
                    }

                    Cnn.Close();    //cerrar conexion
                }  //using
            }
            catch (SqlException ex)
            {
                miColoSolicitud.idColorRechazada[0] = 255;
                miColoSolicitud.idColorRechazada[1] = 255;
                miColoSolicitud.idColorRechazada[2] = 255;
            }
            catch (Exception ex)
            {
                miColoSolicitud.idColorRechazada[0] = 255;
                miColoSolicitud.idColorRechazada[1] = 255;
                miColoSolicitud.idColorRechazada[2] = 255;
            }
            return miColoSolicitud;
        }

        private ColorSolicitud obtenerColorBaja(ColorSolicitud miColoSolicitud)
        {
            string sConexionBD = winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString;
            try
            {
                using (SqlConnection Cnn = new SqlConnection(sConexionBD))
                {
                    SqlCommand cmd = new SqlCommand("dbo.stpSelParametro", Cnn)
                    { CommandType = CommandType.StoredProcedure };

                    cmd.Parameters.AddWithValue("@pDescParametro", "COLORBAJA");

                    Cnn.Open(); //abrir conexion
                    cmd.ExecuteNonQuery();  //ejecutar stored procedure
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int[] arrayColor;
                            arrayColor = obtenerColor(reader.GetString(0));
                            miColoSolicitud.idColorBaja[0] = arrayColor[0];
                            miColoSolicitud.idColorBaja[1] = arrayColor[1];
                            miColoSolicitud.idColorBaja[2] = arrayColor[2];
                        }
                    }

                    Cnn.Close();    //cerrar conexion
                }  //using
            }
            catch (SqlException ex)
            {
                miColoSolicitud.idColorBaja[0] = 255;
                miColoSolicitud.idColorBaja[1] = 255;
                miColoSolicitud.idColorBaja[2] = 255;
            }
            catch (Exception ex)
            {
                miColoSolicitud.idColorBaja[0] = 255;
                miColoSolicitud.idColorBaja[1] = 255;
                miColoSolicitud.idColorBaja[2] = 255;
            }
            return miColoSolicitud;
        }

        private ColorSolicitud obtenerColorProceso(ColorSolicitud miColoSolicitud)
        {
            string sConexionBD = winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString;
            try
            {
                using (SqlConnection Cnn = new SqlConnection(sConexionBD))
                {
                    SqlCommand cmd = new SqlCommand("dbo.stpSelParametro", Cnn)
                    { CommandType = CommandType.StoredProcedure };

                    cmd.Parameters.AddWithValue("@pDescParametro", "COLORPROCESO");

                    Cnn.Open(); //abrir conexion
                    cmd.ExecuteNonQuery();  //ejecutar stored procedure
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int[] arrayColor;
                            arrayColor = obtenerColor(reader.GetString(0));
                            miColoSolicitud.idColorProceso[0] = arrayColor[0];
                            miColoSolicitud.idColorProceso[1] = arrayColor[1];
                            miColoSolicitud.idColorProceso[2] = arrayColor[2];
                        }
                    }

                    Cnn.Close();    //cerrar conexion
                }  //using
            }
            catch (SqlException ex)
            {
                miColoSolicitud.idColorProceso[0] = 255;
                miColoSolicitud.idColorProceso[1] = 255;
                miColoSolicitud.idColorProceso[2] = 255;
            }
            catch (Exception ex)
            {
                miColoSolicitud.idColorProceso[0] = 255;
                miColoSolicitud.idColorProceso[1] = 255;
                miColoSolicitud.idColorProceso[2] = 255;
            }
            return miColoSolicitud;
        }

        private ColorSolicitud obtenerColorInactivo(ColorSolicitud miColoSolicitud)
        {
            string sConexionBD = winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString;
            try
            {
                using (SqlConnection Cnn = new SqlConnection(sConexionBD))
                {
                    SqlCommand cmd = new SqlCommand("dbo.stpSelParametro", Cnn)
                    { CommandType = CommandType.StoredProcedure };

                    cmd.Parameters.AddWithValue("@pDescParametro", "COLORINACTIVO");

                    Cnn.Open(); //abrir conexion
                    cmd.ExecuteNonQuery();  //ejecutar stored procedure
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int[] arrayColor;
                            arrayColor = obtenerColor(reader.GetString(0));
                            miColoSolicitud.idColorInactivo[0] = arrayColor[0];
                            miColoSolicitud.idColorInactivo[1] = arrayColor[1];
                            miColoSolicitud.idColorInactivo[2] = arrayColor[2];
                        }
                    }

                    Cnn.Close();    //cerrar conexion
                }  //using
            }
            catch (SqlException ex)
            {
                miColoSolicitud.idColorInactivo[0] = 255;
                miColoSolicitud.idColorInactivo[1] = 255;
                miColoSolicitud.idColorInactivo[2] = 255;
            }
            catch (Exception ex)
            {
                miColoSolicitud.idColorInactivo[0] = 255;
                miColoSolicitud.idColorInactivo[1] = 255;
                miColoSolicitud.idColorInactivo[2] = 255;
            }
            return miColoSolicitud;
        }

        private int[] obtenerColor(String stColor)
        {
            int[] arrayColor = new int[3];
            try
            {
                String[] arrayStColor = stColor.Split(',');
                if (arrayStColor.Length == 3)
                {
                    arrayColor[0] = Convert.ToInt32(arrayStColor[0]);
                    arrayColor[1] = Convert.ToInt32(arrayStColor[1]);
                    arrayColor[2] = Convert.ToInt32(arrayStColor[2]);
                }
                else
                {
                    arrayColor[0] = 255;
                    arrayColor[1] = 255;
                    arrayColor[2] = 255;
                }
            }
            catch (Exception)
            {
                arrayColor[0] = 255;
                arrayColor[1] = 255;
                arrayColor[2] = 255;
            }

            return arrayColor;
        }


    }
}