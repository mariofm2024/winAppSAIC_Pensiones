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
using System.Diagnostics;
using winAppSAIC.OperadoresM;
using System.IO;
using DevExpress.XtraGrid.Columns;
using Excel = Microsoft.Office.Interop.Excel;

namespace winAppSAIC.Tesoreria
{
    public partial class XtraSolicitudAltaCuentaEmpleados : DevExpress.XtraEditors.XtraForm
    {

        DataTable stSolicitudesCuentas;
        tools.dsc dsc = new tools.dsc();
        OperadoresM.ColorSolicitud miColorSolicitud;
        DataTable dtTiposlayout;
        int idTenedoraSC = 0;
        int idSolicitud;
        int iTipoTesoreria;
        int iTipoTesoreriaConsulta;
        String stTipoEstatusTesoreria;

        public XtraSolicitudAltaCuentaEmpleados(int idSolicitud, int iTipoTesoreriaConsulta)
        {
            InitializeComponent();
            this.idSolicitud = idSolicitud;
            this.iTipoTesoreriaConsulta = iTipoTesoreriaConsulta;
            string filterString = "[IdSolicitud] = " + idSolicitud.ToString();
            gridVSolicitudes.Columns["IdSolicitud"].FilterInfo = new ColumnFilterInfo(filterString);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XtraSolicitudAltaCuentaEmpleados_Load(object sender, EventArgs e)
        {
            CargarInformacion();
        }


        private void CargarInformacion()
        {

            // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoGenericaTenedoraSC1' table. You can move, or remove it, as needed.
            //this.stpSelObtenerInfoGenericaTenedoraSCTableAdapter1.Fill(this.dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoGenericaTenedoraSC1);
            try
            {
                splashScreenManager3.ShowWaitForm();

                miColorSolicitud = new ColorSolicitud();
                miColorSolicitud = miColorSolicitud.obtenerColor();

                gridLookUpTenedoraSC.Enabled = false;
                chckConTenedoraSC.Enabled = true;
                chckConTenedoraSC.Checked = false;

                if (iTipoTesoreriaConsulta == 1) { iTipoTesoreria = 2; stTipoEstatusTesoreria = "Estatus Tesoreria SC"; }
                else { iTipoTesoreria = 1; stTipoEstatusTesoreria = "Estatus Tesoreria SA"; }

                stpSelObtenerInfoGenericaTenedoraSCTableAdapter1.Fill(this.dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoGenericaTenedoraSC);
                stpSelObtenerEmpleadosSolicitudCuentasOperacionesTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelObtenerEmpleadosSolicitudCuentasOperaciones, 0, OperadorBD.OperadorGlobal.IdOperador, true, iTipoTesoreria);
                stSolicitudesCuentas = dbSAICBPOCatalogosDataSet1.stpSelObtenerEmpleadosSolicitudCuentasOperaciones;
                this.stpSelBancoAltaEmpleadosTableAdapter1.Fill(this.dbSAICBPOCatalogosDataSet1.stpSelBancoAltaEmpleados, 0, "", 0, true);
                obtenerInformacionSolicitudes(stSolicitudesCuentas);

                if (iTipoTesoreriaConsulta == 1 || !rdTenedoraSA.Checked) { rdTenedorSC.Checked = true; }
                if (rdTenedorSC.Checked)
                {
                    iTipoTesoreriaConsulta = 1;
                    stTipoTenedora = "SC";
                    obtenerInfoTenedoraSC();
                }
                else
                {
                    stTipoTenedora = "SA";
                    iTipoTesoreriaConsulta = 0;
                }
                //validar el tipo de Tesorero que esta Consultando la solicitud
                ingresarFiltro();
                filtroSolicitudes();
                filtroEmpleadosEsquema();
            }
            catch (Exception ex)
            {
                if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                XtraMessageBox.Show("No se puede cargar las Solicitudes." + Environment.NewLine + ex.Message, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
        }

        private void ingresarFiltro()
        {
            DataRow[] unRow = dbSAICBPOCatalogosDataSet1.stpSelObtenerEmpleadosSolicitudCuentasOperaciones.Select("idSolicitud = '" + idSolicitud.ToString() + "'");
            if (unRow.Count() > 0)
            {
                //if (conFiltroSolicitud)
                //{
                //    string filterString = "[IdSolicitud] = " + idSolicitud.ToString();
                //    gridVSolicitudes.Columns["IdSolicitud"].FilterInfo = new ColumnFilterInfo(filterString);
                //}

                if (unRow[0][stTipoEstatusTesoreria].ToString() == "SOLICITUD EN PROCESO" || unRow[0][stTipoEstatusTesoreria].ToString() == "SOLICITUD EMITIDA")
                {
                    chckSolicitudesEmitidas.Checked = true;
                    chckSolicitudesProcesadas.Checked = true;
                }
                else if (unRow[0][stTipoEstatusTesoreria].ToString() == "SOLICITUD RECHAZADA")
                {
                    chckSolicitudesRechazadas.Checked = true;
                }
                else if (unRow[0][stTipoEstatusTesoreria].ToString() == "SOLICITUD ATENDIDA AL 100%")
                {
                    chckSolicitudesAtendidas.Checked = true;
                }
                else
                {
                    chckSolicitudesEmitidas.Checked = true;
                    chckSolicitudesProcesadas.Checked = true;
                }
            }
        }

        private void chckSolicitudesEmitidas_CheckedChanged(object sender, EventArgs e)
        {
            filtroSolicitudes();
            filtroEmpleadosEsquema();
        }

        private void chckSolicitudesProcesadas_CheckedChanged(object sender, EventArgs e)
        {
            filtroSolicitudes();
            filtroEmpleadosEsquema();
        }

        private void chckSolicitudesRechazadas_CheckedChanged(object sender, EventArgs e)
        {
            filtroSolicitudes();
            filtroEmpleadosEsquema();
        }

        private void chckSolicitudesAtendidas_CheckedChanged(object sender, EventArgs e)
        {
            filtroSolicitudes();
            filtroEmpleadosEsquema();
        }

        String stEmitida = "SOLICITUD EMITIDA";
        String stProceso = "SOLICITUD EN PROCESO";
        String stAtendida = "SOLICITUD ATENDIDA AL 100%";
        String stRechazada = "SOLICITUD RECHAZADA";
        String stRespondidas = "SOLICITUD RESPONDIDA";
        private void filtroSolicitudes()
        {
            DataTable dtSolicitudes = stSolicitudesCuentas.Clone();
            DataTable dtEmitidas = stSolicitudesCuentas.Clone();
            DataTable dtProceso = stSolicitudesCuentas.Clone();
            DataTable dtAtendida = stSolicitudesCuentas.Clone();
            DataTable dtRechazada = stSolicitudesCuentas.Clone();

            if (chckSolicitudesEmitidas.Checked)
            {
                var query = (from x in stSolicitudesCuentas.AsEnumerable()
                             where x.Field<String>(stTipoEstatusTesoreria).Equals(stEmitida) || x.Field<String>(stTipoEstatusTesoreria).Equals(stRespondidas)
                             select x);

                if (query.Count() > 0)
                {
                    dtEmitidas = query.CopyToDataTable();
                    dtSolicitudes.Merge(dtEmitidas);
                }
            }

            if (chckSolicitudesProcesadas.Checked)
            {
                var query = (from x in stSolicitudesCuentas.AsEnumerable()
                             where x.Field<String>(stTipoEstatusTesoreria).Equals(stProceso)
                             select x);

                if (query.Count() > 0)
                {
                    dtProceso = query.CopyToDataTable();
                    dtSolicitudes.Merge(dtProceso);
                }
            }

            if (chckSolicitudesAtendidas.Checked)
            {
                var query = (from x in stSolicitudesCuentas.AsEnumerable()
                             where x.Field<String>(stTipoEstatusTesoreria).Equals(stAtendida)
                             select x);

                if (query.Count() > 0)
                {
                    dtAtendida = query.CopyToDataTable();
                    dtSolicitudes.Merge(dtAtendida);
                }
            }

            if (chckSolicitudesRechazadas.Checked)
            {
                var query = (from x in stSolicitudesCuentas.AsEnumerable()
                             where x.Field<String>(stTipoEstatusTesoreria).Equals(stRechazada)
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
                gridAltaCuentas.DataSource = losDatos;
            }
            catch (Exception)
            {
                gridAltaCuentas.DataSource = dtSolicitudes;
            }

            gridVSolicitudes.BestFitColumns();
            lblNumSoliciutd.Text = "Numero de Solicitudes: " + dtSolicitudes.Rows.Count;

        }

        private void btnAbrirCarpeta_Click(object sender, EventArgs e)
        {
            dsc.CheckandCreateFolder(dsc.stRutaSAICTesoreria + @"\LayOuts");
            Process.Start(dsc.stRutaSAICTesoreria);
        }

        public void ObtenerInfEmpleadosSolActualizacionTesoreia(DataTable stEmpleados)
        {
            stpSelInformacionAltaEmpleadosTesoreriaTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelInformacionAltaEmpleadosTesoreria, 0, 0);
            DataTable dtDatosEmpleados = dbSAICBPOCatalogosDataSet1.stpSelInformacionAltaEmpleadosTesoreria.Clone();

            foreach (DataRow item in stEmpleados.Rows)
            {
                int idEmpleado = 0;
                int idSolicitud = 0;

                int.TryParse(item["IdEmpleado"].ToString(), out idEmpleado);
                int.TryParse(item["IdSolicitud"].ToString(), out idSolicitud);

                stpSelInformacionAltaEmpleadosTesoreriaTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelInformacionAltaEmpleadosTesoreria, idSolicitud, idEmpleado);

                if (dbSAICBPOCatalogosDataSet1.stpSelInformacionAltaEmpleadosTesoreria.Rows.Count > 0)
                {
                    DataRow dtrow = dbSAICBPOCatalogosDataSet1.stpSelInformacionAltaEmpleadosTesoreria.Rows[0];
                    dtDatosEmpleados.ImportRow(dtrow);
                }
            }

            if (dtDatosEmpleados.Rows.Count > 0)
            {
                OperadoresM.XtraMonitoreoSolicitudesOperaciones SolicitudOperaciones = new OperadoresM.XtraMonitoreoSolicitudesOperaciones(0);
                Solicitud miSolicitud = new Solicitud();
                miSolicitud.idSolicitud = 0;
                miSolicitud.idTenedoraSA = 0;
                SolicitudOperaciones.descargarArchivoEmpleadosCuentas(dtDatosEmpleados, miSolicitud, 0);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (gridVSolicitudes.SelectedRowsCount > 0)
            {
                DataTable dtEmpleadosSeleccionados = dsc.deGridViewSelectedToDataTable(gridVSolicitudes);

                stpSelInformacionAltaEmpleadosTesoreriaTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelInformacionAltaEmpleadosTesoreria, 0, 0);
                DataTable dtDatosEmpleados = dbSAICBPOCatalogosDataSet1.stpSelInformacionAltaEmpleadosTesoreria.Clone();

                foreach (DataRow item in dtEmpleadosSeleccionados.Rows)
                {
                    int idEmpleado = 0;
                    int idSolicitud = 0;

                    int.TryParse(item["IdEmpleado"].ToString(), out idEmpleado);
                    int.TryParse(item["IdSolicitud"].ToString(), out idSolicitud);

                    stpSelInformacionAltaEmpleadosTesoreriaTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelInformacionAltaEmpleadosTesoreria, idSolicitud, idEmpleado);

                    if (dbSAICBPOCatalogosDataSet1.stpSelInformacionAltaEmpleadosTesoreria.Rows.Count > 0)
                    {
                        DataRow dtrow = dbSAICBPOCatalogosDataSet1.stpSelInformacionAltaEmpleadosTesoreria.Rows[0];
                        try { dtDatosEmpleados.ImportRow(dtrow); }
                        catch (Exception) { }
                    }
                }

                if (dtDatosEmpleados.Rows.Count > 0)
                {
                    OperadoresM.XtraMonitoreoSolicitudesOperaciones SolicitudOperaciones = new OperadoresM.XtraMonitoreoSolicitudesOperaciones(0);
                    Solicitud miSolicitud = new Solicitud();
                    miSolicitud.idSolicitud = 0;
                    miSolicitud.idTenedoraSA = 0;
                    SolicitudOperaciones.descargarArchivoEmpleadosCuentas(dtDatosEmpleados, miSolicitud, 0);
                }
            }
            else
            {
                XtraMessageBox.Show("Seleccione un Empleado."
           , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void obtenerInformacionSolicitudes(DataTable stSolicitudesCuentaEmpleados)
        {
            lblSolicitudes.Text = "Solicitudes: " + stSolicitudesCuentaEmpleados.Rows.Count.ToString();

            lblSolicitudesEmitidas.Text = stSolicitudesCuentaEmpleados.Select("[" + stTipoEstatusTesoreria + "] = '" + stEmitida + "'").Count().ToString();
            lblSolicitudesAtendidas.Text = stSolicitudesCuentaEmpleados.Select("[" + stTipoEstatusTesoreria + "] = '" + stAtendida + "'").Count().ToString();
            lblSolicitudesEnProceso.Text = stSolicitudesCuentaEmpleados.Select("[" + stTipoEstatusTesoreria + "] = '" + stProceso + "'").Count().ToString();
            lblSolicitudesRechazadas.Text = stSolicitudesCuentaEmpleados.Select("[" + stTipoEstatusTesoreria + "] = '" + stRechazada + "'").Count().ToString();
        }

        private void chckConTenedoraSC_CheckedChanged(object sender, EventArgs e)
        {
            if (chckConTenedoraSC.Checked)
            {
                gridLookUpTenedoraSC.Enabled = true;
                //Obtener bancos cuando es por SC
                bancosTenedoraSC();
                stTipoTenedora = "SC";
            }
            else
            {
                stTipoTenedora = "SA";
                gridLookUpTenedoraSC.Enabled = false;
            }
        }


        private void bancosTenedoraSC()
        {
            int.TryParse(gridLookUpTenedoraSC.EditValue.ToString(), out idTenedoraSC);
            this.stpSelBancoAltaEmpleadosTableAdapter1.Fill(this.dbSAICBPOCatalogosDataSet1.stpSelBancoAltaEmpleados, 0, stTipoTenedora, idTenedoraSC, true);
            gridLookBancos.Properties.DataSource = dbSAICBPOCatalogosDataSet1.stpSelBancoAltaEmpleados;
            dtTiposlayout = dbSAICBPOCatalogosDataSet1.stpSelBancoAltaEmpleados;
        }

        private void btnFormatoLayOut_Click(object sender, EventArgs e)
        {
            Boolean taMuyBien = true;
            if (gridVSolicitudes.SelectedRowsCount > 0)//validar que el usuario halla seleccionado un empleado
            {
                if (gridLookBancos.EditValue.ToString() != "")//Validar que el usuario halla seleccionado un banco
                {
                    if (rdTenedoraSA.Checked && chckConTenedoraSC.Checked)
                    {
                        if (gridLookUpTenedoraSC.EditValue.ToString() == "vacio")
                        {
                            taMuyBien = false;
                            gridLookUpTenedoraSC.Focus();
                            XtraMessageBox.Show("Seleccione una Tenedora para continuar.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    if (rdTenedorSC.Checked)
                    {
                        if (gridLookUpTenedoraSC.EditValue.ToString() == "vacio")
                        {
                            taMuyBien = false;
                            gridLookUpTenedoraSC.Focus();
                            XtraMessageBox.Show("Seleccione una Tenedora para continuar.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    taMuyBien = false;
                    gridLookBancos.Focus();
                    XtraMessageBox.Show("Seleccione un tipo de Layout para continuar.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (taMuyBien)
                {
                    DataTable dtEmpleado = dsc.deGridViewSelectedToDataTable(gridVSolicitudes);
                    ObtenerLayOuts(dtEmpleado);
                }
            }
            else
            {
                XtraMessageBox.Show("Seleccione un Empleado.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Obtener LayOut
        /// </summary>
        private void ObtenerLayOuts(DataTable dtEmpleados)
        {
            try
            {

                Boolean flagConRechazoAtendidas = false;
                Boolean flagConClabeGenerica = false;

                int iEmpleadoRechazadosAtendidos = 0;
                int iEmpleadoConClabeGenerica = 0;

                iEmpleadoRechazadosAtendidos = dtEmpleados.Select("[" + stTipoEstatusTesoreria + "] = 'SOLICITUD ATENDIDA AL 100%' OR [" + stTipoEstatusTesoreria + "] = 'SOLICITUD RECHAZADA'").Count();

                try { iEmpleadoConClabeGenerica = dtEmpleados.Select("SubString(Clabe,4,3) = '000' and SubString(Clabe,18,1) = '0'").Count(); }
                catch (Exception) { }

                if (iEmpleadoConClabeGenerica > 0)
                {
                    DialogResult resultado = XtraMessageBox.Show("Hay Empleados seleccionados con Clabe Generica. Es posible que el LayOut que seleccione no contenga informacion. ¿Desea continuar?"
                             , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (DialogResult.Yes == resultado) { flagConClabeGenerica = true; }
                }
                else { flagConClabeGenerica = true; }

                if (flagConClabeGenerica)
                {
                    if (iEmpleadoRechazadosAtendidos > 0)
                    {
                        DialogResult resultado = XtraMessageBox.Show("Hay Empleados seleccionados con Estatus ATENDIDO o RECHAZADO. ¿Desea continuar?"
                                  , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (DialogResult.Yes == resultado) { flagConRechazoAtendidas = true; }
                    }
                    else { flagConRechazoAtendidas = true; }

                    if (flagConRechazoAtendidas)
                    {
                        splashScreenManager3.ShowWaitForm();

                        Solicitud miSolicitud = null;
                        XtraSolicitudesxEmpleadoTesoreria Tesoreria = new XtraSolicitudesxEmpleadoTesoreria(miSolicitud, 0);
                        DataTable dtbancos = dbSAICBPOCatalogosDataSet1.stpSelBancoAltaEmpleados.Clone();

                        int tipoDelayOut = Convert.ToInt32(gridLookBancos.EditValue);

                        if (gridLookBancos.Text == "TODOS")
                        {
                            dtbancos = dtTiposlayout;
                        }
                        else
                        {
                            dtbancos = Tesoreria.filtarBancoSeleccionado(dtTiposlayout, tipoDelayOut);
                        }

                        if (rdPorTenedora.Checked)
                        {
                            generarlayOutPorTenedora(dtEmpleados, dtbancos, tipoDelayOut, idTenedoraSC);
                        }
                        else if (rdPorSolicitud.Checked)
                        {
                            generarlayOutPorSolicitud(dtEmpleados, dtbancos, tipoDelayOut, idTenedoraSC);
                        }
                    }

                }

                if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
            }
            catch (Exception ex)
            {
                if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                XtraMessageBox.Show("No se puede generar los LayOut." + Environment.NewLine + ex.Message
                               , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
        }


        private void generarlayOutPorTenedora(DataTable dtEmpleados, DataTable dtbancos, int tipoDelayOut, int idTenedoraSC)
        {
            String stEsquema = chckConTenedoraSC.Checked ? "A" : "S";
            List<int> EmpresasEmpleados = new List<int>();

            int idTenedoraSC_1 = 0;
            if (rdTenedoraSA.Checked)
            {
                EmpresasEmpleados = ObtenerTenedorasDeEmpleados(dtEmpleados);
            }
            else
            {
                int.TryParse(gridLookUpTenedoraSC.EditValue.ToString(), out idTenedoraSC_1);
                EmpresasEmpleados.Add(idTenedoraSC_1);
            }

            //Recorrer Las tenedoras unicas de los empleados seleccionados
            foreach (int idTenedora in EmpresasEmpleados)
            {
                if (rdTenedorSC.Checked)
                {
                    dtEmpleados = AsignarTenedoraSC(dtEmpleados, gridLookUpTenedoraSC.EditValue.ToString(), gridLookUpTenedoraSC.Text);
                }

                DataTable dtEmpleadosTenedora = ObtenerEmpleadosPorTenedora(dtEmpleados, idTenedora, true);

                String stCabecera = String.Empty;

                //Recorrer los Tipos de layOut
                //foreach (DataRow item in dtbancos.Rows)
                for (int i = 0; i < dtbancos.Rows.Count; i++)
                {
                    int iConsecutivo = 1;
                    String stNombreArchivo = String.Empty;
                    String stTenedoraRazonSocial = String.Empty;

                    //VALIDAR QUE LA TENEDORA TENGA EL TIPO DE LAYOUT PARA CUANDO SE SELECCIONA MAS DE UN EMPLEADO CON DIFERENTES TENEDORAS
                    this.stpSelBancoAltaEmpleadosTableAdapter1.Fill(this.dbSAICBPOCatalogosDataSet1.stpSelBancoAltaEmpleados, idTenedora, stTipoTenedora, idTenedoraSC, true);
                    DataTable stBancosTenedora = dbSAICBPOCatalogosDataSet1.stpSelBancoAltaEmpleados;
                    int.TryParse(dtbancos.Rows[i]["idBancoAltaEmpleados"].ToString(), out tipoDelayOut);
                    DataRow[] dtRow = dbSAICBPOCatalogosDataSet1.stpSelBancoAltaEmpleados.Select("idBancoAltaEmpleados = '" + tipoDelayOut + "'");

                    if (dtRow.Count() > 0)
                    {
                        if (dtbancos.Rows[i]["BancoNombreDesc"].ToString() != "TODOS")
                        {
                            List<String> layOutEmpleados = new List<String>();

                            //Recorrer Empleados
                            foreach (DataRow unRow in dtEmpleadosTenedora.Rows)
                            {
                                int idEmpleado;
                                int idSolicitud;
                                int idHeader;
                                int.TryParse(unRow["IdEmpleado"].ToString(), out idEmpleado);
                                int.TryParse(unRow["idSolicitud"].ToString(), out idSolicitud);
                                int.TryParse(unRow["Num"].ToString(), out idHeader);

                                stpSelObtenerLayOutAltaEmpleadosBancosTableAdapter1.Fill(this.dbSAICBPOCatalogosDataSet1.stpSelObtenerLayOutAltaEmpleadosBancos, idSolicitud, idEmpleado, tipoDelayOut, stEsquema, idTenedoraSC, dtEmpleadosTenedora.Rows.Count, rdTenedoraSA.Checked);
                                stCabecera = dbSAICBPOCatalogosDataSet1.stpSelObtenerLayOutAltaEmpleadosBancos[0][1].ToString();

                                if (!String.IsNullOrEmpty(dbSAICBPOCatalogosDataSet1.stpSelObtenerLayOutAltaEmpleadosBancos[0][0].ToString()))
                                {
                                    layOutEmpleados.Add(dbSAICBPOCatalogosDataSet1.stpSelObtenerLayOutAltaEmpleadosBancos[0][0].ToString());
                                }

                                stTenedoraRazonSocial = unRow["Tenedora SA"].ToString();

                                //Poner en proceso al Empleado
                                estatusProcesoEmpleado(idHeader, idSolicitud, idEmpleado, rdTenedoraSA.Checked);
                            }

                            if (!String.IsNullOrEmpty(stCabecera))
                            {
                                List<String> listaTemp = new List<string>();
                                listaTemp.Add(stCabecera);
                                foreach (String layoutEmpleados in layOutEmpleados) { listaTemp.Add(layoutEmpleados); }
                                layOutEmpleados = listaTemp;
                            }

                            stpSelBancoAltaEmpleadosNombreArchivoTableAdapter1.Fill(this.dbSAICBPOCatalogosDataSet1.stpSelBancoAltaEmpleadosNombreArchivo, tipoDelayOut, idTenedora, idTenedoraSC, stEsquema, iConsecutivo.ToString("00"));
                            stNombreArchivo = dbSAICBPOCatalogosDataSet1.stpSelBancoAltaEmpleadosNombreArchivo[0][0].ToString();

                            if (!String.IsNullOrEmpty(stNombreArchivo))
                            {
                                generarLayOut(layOutEmpleados, stNombreArchivo, stTenedoraRazonSocial);
                            }
                            else
                            {
                                if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                                XtraMessageBox.Show("No se puede generar el archivo." + Environment.NewLine + Environment.NewLine + "No se tiene nombre para el LayOut."
                                 , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }

            if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
            XtraMessageBox.Show("LayOut creado con Exito: " + Environment.NewLine + "Los LayOut los podra encontrar en la Ruta: " + dsc.stRutaSAICTesoreria + @"\LayOuts\"
                            , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void generarlayOutPorSolicitud(DataTable dtEmpleados, DataTable dtbancos, int tipoDelayOut, int idTenedoraSC)
        {
            String stEsquema = chckConTenedoraSC.Checked ? "A" : "S";

            List<int> idSolicitudes = ObtenerNumSolicitudes(dtEmpleados);

            foreach (int idSolicitud in idSolicitudes)
            {
                DataTable dtEmpleadosSolicitudes = ObtenerEmpleadosPorTenedora(dtEmpleados, idSolicitud, false);
                String stCabecera = String.Empty;

                //foreach (DataRow item in dtbancos.Rows)
                for (int i = 0; i < dtbancos.Rows.Count; i++)
                {
                    int iConsecutivo = 1;

                    String stNombreArchivo = String.Empty;
                    String stTenedoraRazonSocial = String.Empty;

                    if (dtbancos.Rows[i]["BancoNombreDesc"].ToString() != "TODOS")
                    {
                        List<String> layOutEmpleados = new List<String>();
                        int idTenedora = 0;
                        foreach (DataRow unRow in dtEmpleadosSolicitudes.Rows)
                        {
                            int.TryParse(unRow["idTenedoraSA"].ToString(), out idTenedora);

                            //VALIDAR QUE LA TENEDORA TENGA EL TIPO DE LAYOUT PARA CUANDO SE SELECCIONA MAS DE UN EMPLEADO CON DIFERENTES TENEDORAS
                            this.stpSelBancoAltaEmpleadosTableAdapter1.Fill(this.dbSAICBPOCatalogosDataSet1.stpSelBancoAltaEmpleados, idTenedora, stTipoTenedora, idTenedoraSC, true);
                            DataTable stBancosTenedora = dbSAICBPOCatalogosDataSet1.stpSelBancoAltaEmpleados;
                            int.TryParse(dtbancos.Rows[i]["idBancoAltaEmpleados"].ToString(), out tipoDelayOut);
                            DataRow[] dtRow = dbSAICBPOCatalogosDataSet1.stpSelBancoAltaEmpleados.Select("idBancoAltaEmpleados = '" + tipoDelayOut + "'");
                            // QUE LA TENEDORA TENGA EL TIPO DE LAYOUT PARA CUANDO SE SELECCIONA MAS DE UN EMPLEADO CON DIFERENTES TENEDORAS

                            if (dtRow.Count() > 0)
                            {
                                int idEmpleado;
                                int idHeader;
                                int.TryParse(unRow["IdEmpleado"].ToString(), out idEmpleado);
                                int.TryParse(unRow["Num"].ToString(), out idHeader);

                                stpSelObtenerLayOutAltaEmpleadosBancosTableAdapter1.Fill(this.dbSAICBPOCatalogosDataSet1.stpSelObtenerLayOutAltaEmpleadosBancos, idSolicitud, idEmpleado, tipoDelayOut, stEsquema, idTenedoraSC, dtEmpleadosSolicitudes.Rows.Count, rdTenedoraSA.Checked);
                                stCabecera = dbSAICBPOCatalogosDataSet1.stpSelObtenerLayOutAltaEmpleadosBancos[0][1].ToString();
                                layOutEmpleados.Add(dbSAICBPOCatalogosDataSet1.stpSelObtenerLayOutAltaEmpleadosBancos[0][0].ToString());
                                stTenedoraRazonSocial = unRow["Tenedora SA"].ToString();

                                //Poner en proceso al Empleado
                                estatusProcesoEmpleado(idHeader, idSolicitud, idEmpleado, rdTenedoraSA.Checked);
                            }
                        }

                        if (!String.IsNullOrEmpty(stCabecera))
                        {
                            List<String> listaTemp = new List<string>();
                            listaTemp.Add(stCabecera);
                            foreach (String layoutEmpleados in layOutEmpleados) { listaTemp.Add(layoutEmpleados); }
                            layOutEmpleados = listaTemp;
                        }

                        if (layOutEmpleados.Count > 0)
                        {
                            stpSelBancoAltaEmpleadosNombreArchivoTableAdapter1.Fill(this.dbSAICBPOCatalogosDataSet1.stpSelBancoAltaEmpleadosNombreArchivo, tipoDelayOut, idTenedora, idTenedoraSC, stEsquema, iConsecutivo.ToString("00"));
                            stNombreArchivo = dbSAICBPOCatalogosDataSet1.stpSelBancoAltaEmpleadosNombreArchivo[0][0].ToString();

                            if (!String.IsNullOrEmpty(stNombreArchivo))
                            {
                                generarLayOut(layOutEmpleados, stNombreArchivo, idSolicitud.ToString());
                            }
                            else
                            {
                                if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                                XtraMessageBox.Show("No se puede generar el archivo." + Environment.NewLine + Environment.NewLine + "No se tiene nombre para el LayOut."
                                 , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }

            if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
            XtraMessageBox.Show("LayOut creado con Exito: " + Environment.NewLine + "Los LayOut los podra encontrar en la Ruta: " + dsc.stRutaSAICTesoreria + @"\LayOuts\"
                            , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void generarLayOut(List<String> layOutEmpleados, String stNombreArchivo, String TenedorarazonSocial)
        {
            String stRutaLayOut = dsc.stRutaSAICTesoreria + @"\LayOuts\" + TenedorarazonSocial + @"\" + gridLookBancos.Text + @"\";
            dsc.CheckandCreateFolder(stRutaLayOut);
            String stNOmbreArchivo = String.Empty;

            File.WriteAllLines(stRutaLayOut + stNombreArchivo, layOutEmpleados);
        }

        /// <summary>
        /// Obtener la lista de Tenedoras unicas de los empleados seleccionados
        /// </summary>
        /// <param name="dtEmpleados"></param>
        /// <returns></returns>
        private List<int> ObtenerTenedorasDeEmpleados(DataTable dtEmpleados)
        {
            List<int> idTenedoras = new List<int>();
            var iQuery = dtEmpleados.AsEnumerable()
                .Select(s => new
                {
                    idTenedora = s.Field<String>("IdTenedoraSA"),
                }).Distinct().ToList();

            if (iQuery.Count() > 0)
            {
                foreach (var item in iQuery)
                {
                    int idSol;
                    int.TryParse(item.idTenedora.ToString(), out idSol);
                    idTenedoras.Add(idSol);

                }
            }

            return idTenedoras;
        }

        private List<int> ObtenerNumSolicitudes(DataTable dtEmpleados)
        {
            List<int> idTenedoras = new List<int>();
            var iQuery = dtEmpleados.AsEnumerable()
                .Select(s => new
                {
                    idSolicitudes = s.Field<String>("idSolicitud"),
                }).Distinct().ToList();

            if (iQuery.Count() > 0)
            {
                foreach (var item in iQuery)
                {
                    int idSol;
                    int.TryParse(item.idSolicitudes.ToString(), out idSol);
                    idTenedoras.Add(idSol);
                }
            }

            return idTenedoras;
        }

        /// <summary>
        /// Obtener a los empleados por Tenedora
        /// </summary>
        /// <param name="dtEmpleados"></param>
        /// <param name="idTenedora"></param>
        /// <returns></returns>
        private DataTable ObtenerEmpleadosPorTenedora(DataTable dtEmpleados, int idTenedora, Boolean porTenedora)
        {
            DataTable dtEmpleadosTenedora = dtEmpleados.Clone();

            if (porTenedora)
            {
                var iQuery = from x in dtEmpleados.AsEnumerable()
                             where x.Field<String>("IdTenedoraSA").Equals(idTenedora.ToString())
                             select x;

                if (iQuery.Count() > 0)
                {
                    dtEmpleadosTenedora = iQuery.CopyToDataTable();
                }
            }
            else
            {
                var iQuery = from x in dtEmpleados.AsEnumerable()
                             where x.Field<String>("IdSolicitud").Equals(idTenedora.ToString())
                             select x;

                if (iQuery.Count() > 0)
                {
                    dtEmpleadosTenedora = iQuery.CopyToDataTable();
                }
            }

            return dtEmpleadosTenedora;
        }

        String stTipoTenedora = String.Empty;

        private void gridVSolicitudes_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            try
            {
                splashScreenManager3.ShowWaitForm();

                if (!chckConTenedoraSC.Checked)
                {
                    if (gridVSolicitudes.SelectedRowsCount == 1)
                    {
                        int idTenedoraSA = 0;
                        int idTenedoraSC = 0;
                        stTipoTenedora = "SA";

                        //DataRow row = gridVSolicitudes.GetDataRow(gridVSolicitudes.FocusedRowHandle);

                        DataRow row = dsc.deGridViewSelectedToDataTable(gridVSolicitudes).Rows[0];
                        int.TryParse(row["IdTenedoraSA"].ToString(), out idTenedoraSA);
                        this.stpSelBancoAltaEmpleadosTableAdapter1.Fill(this.dbSAICBPOCatalogosDataSet1.stpSelBancoAltaEmpleados, idTenedoraSA, stTipoTenedora, idTenedoraSC, true);
                        gridLookBancos.Properties.DataSource = dbSAICBPOCatalogosDataSet1.stpSelBancoAltaEmpleados;
                        dtTiposlayout = dbSAICBPOCatalogosDataSet1.stpSelBancoAltaEmpleados;
                    }
                    else if (gridVSolicitudes.SelectedRowsCount > 1)
                    {

                        DataTable dtEmpleadosSeleccionados = dsc.deGridViewSelectedToDataTable(gridVSolicitudes);
                        String stTipoTenedora = "SA";
                        dtTiposlayout = dbSAICBPOCatalogosDataSet1.stpSelBancoAltaEmpleados.Clone();
                        foreach (DataRow unRow in dtEmpleadosSeleccionados.Rows)
                        {
                            int idTenedoraSA = 0;
                            int.TryParse(unRow["IdTenedoraSA"].ToString(), out idTenedoraSA);
                            this.stpSelBancoAltaEmpleadosTableAdapter1.Fill(this.dbSAICBPOCatalogosDataSet1.stpSelBancoAltaEmpleados, idTenedoraSA, stTipoTenedora, idTenedoraSC, true);
                            dtTiposlayout.Merge(dbSAICBPOCatalogosDataSet1.stpSelBancoAltaEmpleados);
                        }

                        gridLookBancos.Properties.DataSource = dtTiposlayout;
                    }
                    else
                    {
                        this.stpSelBancoAltaEmpleadosTableAdapter1.Fill(this.dbSAICBPOCatalogosDataSet1.stpSelBancoAltaEmpleados, 0, "", 0, true);
                        gridLookBancos.Properties.DataSource = dbSAICBPOCatalogosDataSet1.stpSelBancoAltaEmpleados;
                        dtTiposlayout = dbSAICBPOCatalogosDataSet1.stpSelBancoAltaEmpleados;
                    }
                }
            }
            catch (Exception ex)
            {
                if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                XtraMessageBox.Show("No se puede cargar los LayOut." + Environment.NewLine + ex.Message, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
        }

        private void repositoryItemButtonEditAtendida_Click(object sender, EventArgs e)
        {
            gridVSolicitudes.Focus();
            DataRow unRow = gridVSolicitudes.GetDataRow(gridVSolicitudes.FocusedRowHandle);
            if (unRow != null)
            {
                if (unRow[stTipoEstatusTesoreria].ToString() == "SOLICITUD ATENDIDA AL 100%")
                {
                    XtraMessageBox.Show("Solicitud no se puede atender dos veces.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (unRow[stTipoEstatusTesoreria].ToString() == "SOLICITUD RECHAZADA")
                {
                    XtraMessageBox.Show("Solicitud Rechazada, espere a que Operaciones responda la solicitud para Atenderla.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //Actualizar Solicitud
                    DialogResult resultado = XtraMessageBox.Show("¿Desea Atender al Empleado: " +
                      unRow["NombreEmpleado"].ToString() + " " +
                      unRow["APaternoEmpleado"].ToString() + " " +
                      unRow["AMaternoEmpleado"].ToString() + "?", "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (DialogResult.Yes == resultado)
                    {
                        int iTipoTesoreria;
                        int iIDempleado;
                        int iDSolicitud;
                        int.TryParse(unRow["IdEmpleado"].ToString(), out iIDempleado);
                        int.TryParse(unRow["IdSolicitud"].ToString(), out iDSolicitud);

                        iTipoTesoreria = rdTenedoraSA.Checked ? 5 : 6;

                        if (iIDempleado != 0)
                        {
                            try
                            {
                                queriesTableAdapter1.stpUpdEstatusSolicitudAlta(iTipoTesoreria,
                                                                  iDSolicitud,
                                                                  iIDempleado,
                                                                   OperadorBD.OperadorGlobal.NombreOperador,
                                                                   OperadorBD.OperadorGlobal.NombreUsuario,
                                                                    DateTime.Now
                                                                  );

                                XtraMessageBox.Show("Empleado Atendido con Exito.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            catch (Exception ex)
                            {
                                XtraMessageBox.Show("no se puede atender al Empleado." + Environment.NewLine + ex.Message, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            CargarInformacion();
                        }
                    }
                }
            }
        }

        private void repositoryItemButtonEditRechazada_Click(object sender, EventArgs e)
        {
            gridVSolicitudes.Focus();
            DataRow unRow = gridVSolicitudes.GetDataRow(gridVSolicitudes.FocusedRowHandle);
            if (unRow != null)
            {
                if (unRow[stTipoEstatusTesoreria].ToString() == "SOLICITUD ATENDIDA AL 100%")
                {
                    XtraMessageBox.Show("Solicitud ya se encuentra Atendida", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (unRow[stTipoEstatusTesoreria].ToString() == "SOLICITUD RECHAZADA")
                {
                    XtraMessageBox.Show("La Solicitud no se puede Rechazar dos veces", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int iIDempleado;
                    int iDSolicitud;
                    int.TryParse(unRow["IdEmpleado"].ToString(), out iIDempleado);
                    int.TryParse(unRow["IdSolicitud"].ToString(), out iDSolicitud);

                    String stArea;
                    String stTipoObservaciones;

                    if (rdTenedoraSA.Checked)
                    {
                        stArea = "TESOSA";
                        stTipoObservaciones = "Observaciones Rechazo SA";
                    }
                    else
                    {
                        stArea = "TESOSC";
                        stTipoObservaciones = "Observaciones Rechazo SC";
                    }

                    DataTable dtEmpleadosporAtender = new DataTable();
                    dtEmpleadosporAtender.ImportRow(unRow);

                    OperadoresM.XtraRechazoSolicitud rechazarSolicitud = new OperadoresM.XtraRechazoSolicitud(
                        dtEmpleadosporAtender,
                        iDSolicitud,
                        iIDempleado,
                        stArea,
                        unRow["NombreEmpleado"].ToString() + " " +
                        unRow["APaternoEmpleado"].ToString() + " " +
                        unRow["AMaternoEmpleado"].ToString(),
                         unRow[stTipoObservaciones].ToString()
                        );
                    rechazarSolicitud.ShowDialog();
                    CargarInformacion();
                }
            }
        }

        private void gridVSolicitudes_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                if (e.RowHandle >= 0)
                {
                    gridVSolicitudes.OptionsSelection.EnableAppearanceFocusedRow = false;
                    String stValorColumnaClabe = String.Empty;
                    stValorColumnaClabe = gridVSolicitudes.GetDataRow(e.RowHandle)["Clabe"].ToString();

                    if (gridVSolicitudes.GetDataRow(e.RowHandle)["Clabe"].ToString().Substring(3, 3) == "000" && gridVSolicitudes.GetDataRow(e.RowHandle)["Clabe"].ToString().Substring(17, 1) == "0")
                    {
                        e.Appearance.BackColor = Color.FromArgb(255, 248, 108);
                        e.HighPriority = true;
                    }

                    if (gridVSolicitudes.GetDataRow(e.RowHandle)[stTipoEstatusTesoreria].ToString() == "SOLICITUD ATENDIDA AL 100%")
                    {
                        e.Appearance.BackColor = Color.FromArgb(miColorSolicitud.idColorAtendida[0], miColorSolicitud.idColorAtendida[1], miColorSolicitud.idColorAtendida[2]);
                        e.HighPriority = true;
                    }
                    else if (gridVSolicitudes.GetDataRow(e.RowHandle)[stTipoEstatusTesoreria].ToString() == "SOLICITUD RECHAZADA")
                    {
                        e.Appearance.BackColor = Color.FromArgb(miColorSolicitud.idColorRechazada[0], miColorSolicitud.idColorRechazada[1], miColorSolicitud.idColorRechazada[2]);
                        e.HighPriority = true;
                    }
                    else if (gridVSolicitudes.GetDataRow(e.RowHandle)[stTipoEstatusTesoreria].ToString() == "SOLICITUD EN PROCESO")
                    {
                        e.Appearance.BackColor = Color.FromArgb(miColorSolicitud.idColorProceso[0], miColorSolicitud.idColorProceso[1], miColorSolicitud.idColorProceso[2]);
                        e.HighPriority = true;
                    }
                }
            }
            catch (Exception) { }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idHeader"></param>
        /// <param name="idSolicitud"></param>
        /// <param name="idEmpleado"></param>
        /// <param name="flagTipoTesoreria">true = SA, false = SC</param>
        private void estatusProcesoEmpleado(int idHeader, int idSolicitud, int idEmpleado, Boolean flagTipoTesoreria)
        {
            try
            {
                queriesTableAdapter1.stpUpdSolicitudEmpleadosEnProcesoAltaCuentas(idHeader, idSolicitud, idEmpleado, OperadorBD.OperadorGlobal.IdOperador, flagTipoTesoreria);
            }
            catch (Exception) { }
        }

        private void rdTenedorSC_CheckedChanged(object sender, EventArgs e)
        {
            obtenerInfoTenedoraSC();
        }

        /// <summary>
        /// Obtener la informacion de la tendora SC, y bancos
        /// </summary>
        private void obtenerInfoTenedoraSC()
        {
            stTipoEstatusTesoreria = "Estatus Tesoreria SC";
            if (rdTenedorSC.Checked)
            {
                stpSelObtenerEmpleadosSolicitudCuentasOperacionesTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelObtenerEmpleadosSolicitudCuentasOperaciones, 0, OperadorBD.OperadorGlobal.IdOperador, true, 2);
                chckConTenedoraSC.Checked = true;
                chckConTenedoraSC.Enabled = false;
                filtroSolicitudes();
                filtroEmpleadosEsquema();
                gridLookUpTenedoraSC.Enabled = true;
            }
            else
            {
                chckConTenedoraSC.Checked = false;
                gridLookUpTenedoraSC.Enabled = false;
            }

            obtenerInformacionSolicitudes(dbSAICBPOCatalogosDataSet1.stpSelObtenerEmpleadosSolicitudCuentasOperaciones);
        }

        private void rdTenedoraSA_CheckedChanged(object sender, EventArgs e)
        {
            stTipoEstatusTesoreria = "Estatus Tesoreria SA";
            stpSelObtenerEmpleadosSolicitudCuentasOperacionesTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelObtenerEmpleadosSolicitudCuentasOperaciones, 0, OperadorBD.OperadorGlobal.IdOperador, true, 1);
            filtroSolicitudes();
            filtroEmpleadosEsquema();

            if (rdTenedoraSA.Checked)
            {
                chckConTenedoraSC.Enabled = true;
                gridLookUpTenedoraSC.Enabled = false;
                stpSelBancoAltaEmpleadosTableAdapter1.Fill(this.dbSAICBPOCatalogosDataSet1.stpSelBancoAltaEmpleados, 0, "", 0, true);
                gridLookBancos.Properties.DataSource = dbSAICBPOCatalogosDataSet1.stpSelBancoAltaEmpleados;
            }

            obtenerInformacionSolicitudes(dbSAICBPOCatalogosDataSet1.stpSelObtenerEmpleadosSolicitudCuentasOperaciones);
        }

        private void filtroEmpleadosEsquema()
        {
            DataTable dtEmpleadosGrid = dsc.deGridViewaDataTable(gridVSolicitudes);
            if (rdTenedoraSA.Checked)
            {
                var query = (from x in dtEmpleadosGrid.AsEnumerable()
                             where x.Field<String>("Esquema").Equals("S") || x.Field<String>("Esquema").Equals("M")
                             select x);

                if (query.Count() > 0)
                {
                    dtEmpleadosGrid = query.CopyToDataTable();
                    gridAltaCuentas.DataSource = dtEmpleadosGrid;
                }
                else
                {
                    gridAltaCuentas.DataSource = dtEmpleadosGrid.Clone();
                }
            }
            else
            {
                var query = (from x in dtEmpleadosGrid.AsEnumerable()
                             where x.Field<String>("Esquema").Equals("A") || x.Field<String>("Esquema").Equals("M")
                             select x);

                if (query.Count() > 0)
                {
                    dtEmpleadosGrid = query.CopyToDataTable();
                    gridAltaCuentas.DataSource = dtEmpleadosGrid;
                }
                else
                {
                    gridAltaCuentas.DataSource = dtEmpleadosGrid.Clone();
                }
            }
        }

        private void gridLookUpTenedoraSC_EditValueChanged(object sender, EventArgs e)
        {
            bancosTenedoraSC();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CargarInformacion();
        }


        private DataTable AsignarTenedoraSC(DataTable dtEmpleado, String stidTenedoraSC, String RazonSolicalTenedoraSC)
        {
            foreach (DataRow item in dtEmpleado.Rows)
            {
                item["idTenedoraSA"] = stidTenedoraSC;
                item["Tenedora SA"] = RazonSolicalTenedoraSC;
            }

            return dtEmpleado;
        }

        private void gridVSolicitudes_ColumnFilterChanged(object sender, EventArgs e)
        {
            //CargarInformacion();
        }
    }
}