using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;
using compCatalogosSAIC;

namespace winAppSAIC.IMSS
{
    public partial class XtraSolicitudDeAniversarios : DevExpress.XtraEditors.XtraForm
    {

        tools.dsc dsc = new tools.dsc();
        DataTable dtObtenerEmpleados = new DataTable();

        public XtraSolicitudDeAniversarios()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbrirCarpeta_Click(object sender, EventArgs e)
        {
            dsc.CheckandCreateFolder(dsc.ObtenerRutaSolicitud(5, 2));
            Process.Start(dsc.ObtenerRutaSolicitud(5, 2));
        }

        private void XtraSolicitudDeAniversarios_Load(object sender, EventArgs e)
        {
            DateTime dFechaHoy = new DateTime();
            DateTime.TryParse(stpSelEstatusNominaContabilizadaTableAdapter1.ObtenerFechaServidor().ToString(), out dFechaHoy);
            dEditFechaAniversario.DateTime = dFechaHoy.Date;
            obtenerEmpleados();
        }

        private String TitulosExcelParaValidacion()
        {
            String[] lstTitulos = new String[] {
                "Id Empleado",
                "Nombre Empleado Completo",
                "NSS",
                "RFC",
                "CURP",
                "Id Tenedora",
                "Tenedora",
                "Registro Patronal IMSS",
                "Fecha Aniversario",
                "Fecha Ingreso Contrato",
                "Salario Diario Contrato",
                "Salario Base Cotizacion Contrato",
                "Salario Diario Integrado Contrato",
                "Anios Laborados",
                "Vacaciones",
                "Prima Vacional",
                "Aguinaldo",
                "UMA",
                "Factor De Integracion",
                "Parte Variable",
                "Nuevo Salario Base Cotizacion",
                "Nuevo Salario Diario Integrado",
                "Errores"
           };

            return String.Join("", lstTitulos).ToUpper().Replace(" ", "");
        }


        private void obtenerEmpleados()
        {
            splashScreenManager1.ShowWaitForm();

            DataTable dtEmpleado = new DataTable();
            dtEmpleado.Columns.Add("IdEmpleado", typeof(int));
            dtEmpleado.Columns.Add("NuevoSalarioBaseCotizacion", typeof(decimal));

            String sRespuesta = String.Empty;

            txtEmpleadosSeleccionados.Text = "0";
            gControlEmpleadosAniversario.Visible = true;
            gControlEmpleadosAniversario.Dock = DockStyle.Fill;

            gridControlPlantilla.Visible = false;
            gridControlPlantilla.Dock = DockStyle.None;

            stpSelObtenerInfoEmpleadosAniversariosTableAdapter.Fill(dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerInfoEmpleadosAniversarios
                , dEditFechaAniversario.DateTime
                , 0
                , String.Empty
                , String.Empty
                , String.Empty
                , false
                , 0
                , 0
                , 0
                , ref sRespuesta);

            var resultado = from x in dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerInfoEmpleadosAniversarios.AsEnumerable()
                            select new
                            {
                                idEmpleado = x.Field<int>("IdEmpleado"),
                                SBC = x.Field<Decimal>("NuevoSalarioBaseCotizacion")
                            };

            foreach (var item in resultado)
            {
                DataRow unRow = dtEmpleado.NewRow();
                unRow["IdEmpleado"] = item.idEmpleado;
                unRow["NuevoSalarioBaseCotizacion"] = item.SBC;
                dtEmpleado.Rows.Add(unRow);
            }

            dtObtenerEmpleados = dtEmpleado;

            //gControlEmpleadosAniversario.DataSource = dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerInfoEmpleadosAniversarios;

            txtTotalEmpleados.Text = dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerInfoEmpleadosAniversarios.Rows.Count.ToString();
            txtRegistrosPatronales.Text = (from r in dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerInfoEmpleadosAniversarios.AsEnumerable()
                                           select r["RegistroPatronalIMSS"]).Distinct().ToList().Count.ToString();

            if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
        }

        private void btnObtenerEmpleados_Click(object sender, EventArgs e)
        {
            obtenerEmpleados();
            btnDescargarExcelRP.Enabled = true;
        }

        private void gViewEmpleadosAniversario_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            for (int i = 0; i < gViewEmpleadosAniversario.RowCount; i++)
            {
                if (gViewEmpleadosAniversario.GetDataRow(i)["Errores"].ToString() != String.Empty)
                {
                    gViewEmpleadosAniversario.UnselectRow(i);
                }
            }

            txtEmpleadosSeleccionados.Text = gViewEmpleadosAniversario.SelectedRowsCount.ToString();
        }

        private void btnDescargarExcel_Click(object sender, EventArgs e)
        {
            if (dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerInfoEmpleadosAniversarios.Rows.Count > 0)
            {

                DialogResult oDialogResult = XtraMessageBox.Show("¿Desea descargar " + txtRegistrosPatronales.Text + "?"
                    , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult.Yes == oDialogResult)
                {
                    List<String> lstRegistrosPatronales = new List<String>();

                    var result = (from r in dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerInfoEmpleadosAniversarios.AsEnumerable()
                                  select r["RegistroPatronalIMSS"]).Distinct().ToList();

                    if (result.Count() > 0)
                    {
                        lstRegistrosPatronales = result.Select(s => (String)s).ToList();
                        dsc.CheckandCreateFolder(dsc.ObtenerRutaSolicitud(5, 2));
                        foreach (String sRegistroPatronal in lstRegistrosPatronales)
                        {
                            String stRutaDocumento = dsc.ObtenerRutaSolicitud(5, 2) + "Aniversarios " + sRegistroPatronal + " " + dEditFechaAniversario.DateTime.ToString("yyyyMMdd") + ".xlsx";
                            DataTable dtDatosregistroPatronal = (from x in dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerInfoEmpleadosAniversarios.AsEnumerable()
                                                                 where x.Field<String>("RegistroPatronalIMSS").Equals(sRegistroPatronal)
                                                                 select x).CopyToDataTable();

                            gridControlFiltro.Visible = true;
                            gridControlFiltro.DataSource = dtDatosregistroPatronal;
                            gridControlFiltro.ExportToXlsx(stRutaDocumento);
                            gridControlFiltro.Visible = false;
                        }

                        XtraMessageBox.Show(lstRegistrosPatronales.Count + " Archivos Descargados en la ruta: " + dsc.ObtenerRutaSolicitud(5, 2), "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnValidarArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSelecFile = new OpenFileDialog();
            ofdSelecFile.Filter = "Excel Files (*.xls;*.xlsm;*.xlsb;*.xlsx)|*.xls;*.xlsm;*.xlsb;*.xlsx";
            ofdSelecFile.ShowDialog();

            if (!String.IsNullOrEmpty(ofdSelecFile.FileName))
            {
                splashScreenManager1.ShowWaitForm();

                DataTable dtArchivoEmpleado = dsc.ConvertExcelToDataTable(ofdSelecFile.FileName, "W");
                dtArchivoEmpleado = quitarVacios(dtArchivoEmpleado);

                if (dtArchivoEmpleado.Rows.Count > 0)
                {
                    String stLasColumnasArchivo = String.Empty;

                    foreach (DataColumn item in dtArchivoEmpleado.Columns) { stLasColumnasArchivo += item.ColumnName; }

                    if (dsc.fonetica(TitulosExcelParaValidacion(), stLasColumnasArchivo))
                    {
                        validarInformacionLayOut(dtArchivoEmpleado);
                    }
                    else
                    {
                        if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                        XtraMessageBox.Show("El Archivo No cuenta con la estructura correcta."
                          , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                    XtraMessageBox.Show("El Archivo No cuenta con informacion."
                      , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }

            btnDescargarExcelRP.Enabled = false;
            if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }

        }

        private DataTable quitarVacios(DataTable dtArchivoEmpleado)
        {
            DataTable dtResutado = new DataTable();
            dtResutado = dtArchivoEmpleado.Clone();

            var res = from x in dtArchivoEmpleado.AsEnumerable()
                      where x.Field<String>("Id Empleado") != ""
                      select x;

            if (res.Count() > 0)
            {
                dtResutado = res.CopyToDataTable();
            }

            return dtResutado;
        }

        private void validarInformacionLayOut(DataTable dtArchivoEmpleado)
        {
            DataTable dtEmpleadosAniversario = dtArchivoEmpleado.Clone();

            foreach (DataRow unRowEmpleado in dtArchivoEmpleado.Rows)
            {
                int idEmpleado = 0;
                String sNombreCompletoEmpleado = String.Empty;
                String sNSS = String.Empty;
                String sRFC = String.Empty;
                String SCURP = String.Empty;
                int idTenedora = 0;
                String sTenedora = String.Empty;
                String sRegistroPatronal = String.Empty;
                DateTime dtFechaAniversario = new DateTime();
                DateTime dtFechaIngresoContrato = new DateTime();
                decimal dcSalarioDiarioContrato = 0;
                decimal dcSalarioBaseDeCotizacion = 0;
                decimal dcSalarioDiarioIntegrado = 0;
                int iAniosLaborados = 0;

                decimal dcVacaciones = 0;
                decimal dcPrimaVacacional = 0;
                decimal dcAguinaldo = 0;
                decimal dcUMA = 0;
                decimal dcFactorDeIntegracion = 0;
                decimal dcParteVariable = 0;
                decimal dcNuevoSalarioBaseDeCotizacion = 0;
                decimal dcNuevoSalarioDiarioIntegrado = 0;
                String sErrores = String.Empty;

                String sRespuesta = String.Empty;
                decimal dcparteVaribledelLayout = 0;

                int.TryParse(unRowEmpleado["Id Empleado"].ToString(), out idEmpleado);
                decimal.TryParse(unRowEmpleado["Parte Variable"].ToString(), out dcparteVaribledelLayout);

                stpSelObtenerInfoEmpleadosAniversariosTableAdapter.Fill(dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerInfoEmpleadosAniversarios,
                    dEditFechaAniversario.DateTime
                    , idEmpleado
                    , unRowEmpleado["NSS"].ToString()
                    , unRowEmpleado["RFC"].ToString()
                    , unRowEmpleado["CURP"].ToString()
                    , false
                    , 0
                    , 0
                    , dcparteVaribledelLayout
                    , ref sRespuesta);

                if (String.IsNullOrEmpty(sRespuesta))
                {
                    unRowEmpleado["Id Tenedora"] = (int)dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerInfoEmpleadosAniversarios[0]["IdTenedora"];
                    unRowEmpleado["Tenedora"] = dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerInfoEmpleadosAniversarios[0]["Tenedora"].ToString();
                    unRowEmpleado["Registro Patronal IMSS"] = dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerInfoEmpleadosAniversarios[0]["RegistroPatronalIMSS"].ToString();

                    unRowEmpleado["Fecha Aniversario"] = dEditFechaAniversario.DateTime.ToShortDateString();
                    unRowEmpleado["Fecha Ingreso Contrato"] = (DateTime)dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerInfoEmpleadosAniversarios[0]["FechaIngresoContrato"];
                    unRowEmpleado["Salario Diario Contrato"] = (decimal)dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerInfoEmpleadosAniversarios[0]["SalarioDiarioContrato"];
                    unRowEmpleado["Salario Base Cotizacion Contrato"] = (decimal)dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerInfoEmpleadosAniversarios[0]["SalarioBaseCotizacionContrato"];
                    unRowEmpleado["Salario Diario Integrado Contrato"] = (decimal)dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerInfoEmpleadosAniversarios[0]["SalarioDiarioIntegradoContrato"];

                    unRowEmpleado["Anios Laborados"] = (int)dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerInfoEmpleadosAniversarios[0]["AniosLaborados"];

                    decimal.TryParse(dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerInfoEmpleadosAniversarios[0]["Vacaciones"].ToString(), out dcVacaciones);
                    unRowEmpleado["Vacaciones"] = dcVacaciones;

                    unRowEmpleado["Prima Vacional"] = (decimal)dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerInfoEmpleadosAniversarios[0]["PrimaVacional"];
                    unRowEmpleado["Aguinaldo"] = (decimal)dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerInfoEmpleadosAniversarios[0]["Aguinaldo"];
                    unRowEmpleado["UMA"] = (decimal)dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerInfoEmpleadosAniversarios[0]["UMA"];

                    unRowEmpleado["Factor De Integracion"] = (decimal)dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerInfoEmpleadosAniversarios[0]["FactorDeIntegracion"];

                    decimal.TryParse(unRowEmpleado["Parte Variable"].ToString(), out dcParteVariable);
                    unRowEmpleado["Parte Variable"] = dcParteVariable;

                    decimal.TryParse(dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerInfoEmpleadosAniversarios[0]["NuevoSalarioBaseCotizacion"].ToString(), out dcNuevoSalarioBaseDeCotizacion);

                    unRowEmpleado["Nuevo Salario Base Cotizacion"] = dcNuevoSalarioBaseDeCotizacion;
                    unRowEmpleado["Nuevo Salario Diario Integrado"] = dcNuevoSalarioBaseDeCotizacion;

                    unRowEmpleado["Errores"] = sRespuesta;
                }
                else
                {
                    unRowEmpleado["Errores"] = sRespuesta;
                }
            }


            txtEmpleadosSeleccionados.Text = "0";
            gControlEmpleadosAniversario.Visible = false;
            gControlEmpleadosAniversario.Dock = DockStyle.None;

            gridControlPlantilla.Visible = true;
            gridControlPlantilla.Dock = DockStyle.Fill;

            gridControlPlantilla.DataSource = dtArchivoEmpleado;

            gridViewPlantilla.Columns[10].DisplayFormat.FormatType = FormatType.Numeric;
            gridViewPlantilla.Columns[10].DisplayFormat.FormatString = "N2";

        }

        private void gridViewPlantilla_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            for (int i = 0; i < gridViewPlantilla.RowCount; i++)
            {
                if (gridViewPlantilla.GetDataRow(i)["Errores"].ToString() != String.Empty)
                {
                    gridViewPlantilla.UnselectRow(i);
                }
            }

            txtEmpleadosSeleccionados.Text = gViewEmpleadosAniversario.SelectedRowsCount.ToString();
        }

        private void gViewEmpleadosAniversario_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.Name == "colParteVariable")
            {
                int idEmpleado = 0;
                int.TryParse(gViewEmpleadosAniversario.GetDataRow(gViewEmpleadosAniversario.FocusedRowHandle)["IdEmpleado"].ToString(), out idEmpleado);

                DataTable dtSBCEmpleado = (from x in dtObtenerEmpleados.AsEnumerable()
                                           where x.Field<int>("IdEmpleado").Equals(idEmpleado)
                                           select x).CopyToDataTable();

                decimal dcSBC = 0;
                decimal.TryParse(dtSBCEmpleado.Rows[0]["NuevoSalarioBaseCotizacion"].ToString(), out dcSBC);

                decimal dcParteVariable = 0;
                decimal.TryParse(e.Value.ToString(), out dcParteVariable);

                decimal dcNuevoSBC = (dcSBC + dcParteVariable);

                decimal dcUMA = 0;
                decimal.TryParse(gViewEmpleadosAniversario.GetDataRow(gViewEmpleadosAniversario.FocusedRowHandle)["UMA"].ToString(), out dcUMA);

                decimal dcUMAx25 = dcUMA * 25;

                if (dcNuevoSBC > dcUMAx25)
                {
                    dcNuevoSBC = dcUMAx25;
                }

                //decimal dcSBC = 0;
                //decimal.TryParse(gViewEmpleadosAniversario.GetDataRow(gViewEmpleadosAniversario.FocusedRowHandle)["NuevoSalarioBaseCotizacion"].ToString(), out dcSBC);

                //DataRow unRow = gViewEmpleadosAniversario.GetDataRow(gViewEmpleadosAniversario.FocusedRowHandle);

                gViewEmpleadosAniversario.GetDataRow(gViewEmpleadosAniversario.FocusedRowHandle)["NuevoSalarioBaseCotizacion"] = dcNuevoSBC.ToString("N2");
                gViewEmpleadosAniversario.GetDataRow(gViewEmpleadosAniversario.FocusedRowHandle)["NuevoSalarioDiarioIntegrado"] = dcNuevoSBC.ToString("N2");

            }




        }

        private void gridControlPlantilla_Click(object sender, EventArgs e)
        {

        }

        private void txtRegistrosPatronales_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtEmpleadosSeleccionados_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            String stRutaDocumento = dsc.ObtenerRutaSolicitud(5, 2) + "Aniversarios " + dEditFechaAniversario.DateTime.ToString("yyyyMMdd") + " " + dsc.nombreAleatorio() + ".xlsx";

            if (gControlEmpleadosAniversario.Visible)
            {
                gControlEmpleadosAniversario.ExportToXlsx(stRutaDocumento);
            }
            else if (gridControlPlantilla.Visible)
            {
                gridControlPlantilla.ExportToXlsx(stRutaDocumento);
            }

            XtraMessageBox.Show("Ruta de dDescarga: " + stRutaDocumento, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btnSubirSolicitud_Click(object sender, EventArgs e)
        {
            if (gControlEmpleadosAniversario.Visible)
            {
                if (gViewEmpleadosAniversario.SelectedRowsCount > 0)
                {
                    DataTable dtEmpleadosAniversario = dsc.deGridViewSelectedToDataTable(gViewEmpleadosAniversario);
                    solicitarEmpleadosAniversario(dtEmpleadosAniversario);
                    obtenerEmpleados();
                }
                else
                {
                    XtraMessageBox.Show("Seleccione un empleado para continuar.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (gridControlPlantilla.Visible)
            {
                if (gridViewPlantilla.SelectedRowsCount > 0)
                {
                    DataTable dtEmpleadosAniversario = dsc.deGridViewSelectedToDataTable(gridViewPlantilla);
                    solicitarEmpleadosAniversario(dtEmpleadosAniversario);
                    gridControlPlantilla.DataSource = null;
                    gridViewPlantilla.Columns.Clear();
                }
                else
                {
                    XtraMessageBox.Show("Seleccione un empleado para continuar.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void solicitarEmpleadosAniversario(DataTable dtEmpleadosAniversario)
        {

            DialogResult oDialogResult = XtraMessageBox.Show("¿Esta seguro de Solicitar Aniversario de los empleados seleccionados?", "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes == oDialogResult)
            {
                String stNombreSolciitud = String.Empty;
                using (var form = new tools.XtraTextBox("Solicitud de Aniversario", "Nombre de la Solicitud", 50))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        splashScreenManager1.ShowWaitForm();

                        stNombreSolciitud = form.sTextBox;

                        int? idSolicitudAniverdario = 0;

                        actualizacionesIMSSTableAdapter1.stpInsSolicitudAniversariosHeader(stNombreSolciitud
                            , OperadorBD.OperadorGlobal.IdOperador
                            , ref idSolicitudAniverdario);

                        if (idSolicitudAniverdario > 0)
                        {
                            int iConta = 0;
                            foreach (DataRow item in dtEmpleadosAniversario.Rows)
                            {
                                iConta++;
                                splashScreenManager1.SetWaitFormDescription(iConta + " de " + dtEmpleadosAniversario.Rows.Count);
                                SolicitudAniversario oSolicitudAniversario = new SolicitudAniversario(item, gControlEmpleadosAniversario.Visible);
                                actualizacionesIMSSTableAdapter1.stpInsSolicitudAniversariosDetail(
                                    idSolicitudAniverdario
                                    , oSolicitudAniversario.idEmpleado
                                    , oSolicitudAniversario.dtFechaAniversario
                                    , oSolicitudAniversario.iAniosLaborados
                                    , oSolicitudAniversario.dcVacaciones
                                    , oSolicitudAniversario.dcPrimaVacacional
                                    , oSolicitudAniversario.dcAguinaldo
                                    , oSolicitudAniversario.dcUMA
                                    , oSolicitudAniversario.dcFactorIntegracion
                                    , oSolicitudAniversario.dcParteVariable
                                    , oSolicitudAniversario.dcSBC
                                    , oSolicitudAniversario.dcSDI
                                    , OperadorBD.OperadorGlobal.NombreUsuario
                                    , 0
                                    );
                            }

                            if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }

                            XtraMessageBox.Show("Aniversario Solicitado con exito." + Environment.NewLine +
                                "Solicitud: " + idSolicitudAniverdario, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                            XtraMessageBox.Show("No se puede solicitar el Aniversario.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }


        }

        private void gridViewPlantilla_RowStyle(object sender, RowStyleEventArgs e)
        {
            try
            {
                if (e.RowHandle >= 0)
                {
                    gridViewPlantilla.OptionsSelection.EnableAppearanceFocusedRow = false;

                    if (!String.IsNullOrEmpty(gridViewPlantilla.GetDataRow(e.RowHandle)["Errores"].ToString()))
                    {
                        e.Appearance.BackColor = Color.LightCoral;
                        e.Appearance.BackColor2 = Color.White;
                        e.HighPriority = true;
                    }
                }
            }
            catch (Exception) { }
        }

        private void gViewEmpleadosAniversario_RowStyle(object sender, RowStyleEventArgs e)
        {
            try
            {
                if (e.RowHandle >= 0)
                {
                    gridViewPlantilla.OptionsSelection.EnableAppearanceFocusedRow = false;

                    if (!String.IsNullOrEmpty(gridViewPlantilla.GetDataRow(e.RowHandle)["Errores"].ToString()))
                    {
                        e.Appearance.BackColor = Color.LightCoral;
                        e.Appearance.BackColor2 = Color.White;
                        e.HighPriority = true;
                    }
                }
            }
            catch (Exception) { }
        }

        private void dEditFechaAniversario_EditValueChanged(object sender, EventArgs e)
        {
            Boolean flagtaMuyBien = true;
            //validar que la fecha sea primero de mes del bimestre 
            if (dEditFechaAniversario.DateTime.Day == 1 && dEditFechaAniversario.DateTime.Month == 1) // inicio del primer Bimestre
            {
                flagtaMuyBien = false;

            }
            else if (dEditFechaAniversario.DateTime.Day == 1 && dEditFechaAniversario.DateTime.Month == 3) // inicio del segundo Bimestre
            {
                flagtaMuyBien = false;

            }
            else if (dEditFechaAniversario.DateTime.Day == 1 && dEditFechaAniversario.DateTime.Month == 5) // inicio del segundo Bimestre
            {
                flagtaMuyBien = false;

            }
            else if (dEditFechaAniversario.DateTime.Day == 1 && dEditFechaAniversario.DateTime.Month == 7) // inicio del segundo Bimestre
            {
                flagtaMuyBien = false;

            }
            else if (dEditFechaAniversario.DateTime.Day == 1 && dEditFechaAniversario.DateTime.Month == 9) // inicio del segundo Bimestre
            {
                flagtaMuyBien = false;

            }
            else if (dEditFechaAniversario.DateTime.Day == 1 && dEditFechaAniversario.DateTime.Month == 11) // inicio del segundo Bimestre
            {
                flagtaMuyBien = false;
            }

            if (!flagtaMuyBien)
            {
                XtraMessageBox.Show("No se puede solicitar aniversacio con la fecha " + dEditFechaAniversario.DateTime.ToShortDateString() + ".", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSubirSolicitud.Enabled = false;
            }
            else
            {
                btnSubirSolicitud.Enabled = true;
            }
        }
    }

    public class SolicitudAniversario
    {
        public int idEmpleado { get; set; }
        public DateTime dtFechaAniversario { get; set; }
        public int iAniosLaborados { get; set; }
        public decimal dcVacaciones { get; set; }
        public decimal dcPrimaVacacional { get; set; }
        public decimal dcAguinaldo { get; set; }
        public decimal dcUMA { get; set; }
        public decimal dcFactorIntegracion { get; set; }
        public decimal dcSBC { get; set; }
        public decimal dcSDI { get; set; }
        public decimal dcParteVariable { get; set; }


        public SolicitudAniversario()
        {
            idEmpleado = 0;
            dtFechaAniversario = new DateTime(1900, 01, 01);
            iAniosLaborados = 0;
            dcVacaciones = 0;
            dcPrimaVacacional = 0;
            dcAguinaldo = 0;
            dcUMA = 0;
            dcFactorIntegracion = 0;
            dcSBC = 0;
            dcSDI = 0;
            dcParteVariable = 0;
        }

        public SolicitudAniversario(DataRow unRow, Boolean flagSinPlantilla)
        {
            //SolicitudAniversario oSolicitudAniversario = new SolicitudAniversario();

            DateTime dtFAniversario = new DateTime();
            decimal dcVacaciones_ = 0;
            decimal dcPrimaVacacional_ = 0;
            decimal dcAguinaldo_ = 0;
            decimal dcParteVariable_ = 0;
            int idEmpleado_ = 0;
            int iAniosLaborados_ = 0;

            decimal dcUMA_ = 0;
            decimal dcFactorIntegracion_ = 0;
            decimal dcSBC_ = 0;
            decimal dcSDI_ = 0;


            if (flagSinPlantilla)
            {
                int.TryParse(unRow["IdEmpleado"].ToString(), out idEmpleado_);
                idEmpleado = idEmpleado_;

                DateTime.TryParse(unRow["FechaAniversario"].ToString(), out dtFAniversario);
                dtFechaAniversario = dtFAniversario;

                int.TryParse(unRow["AniosLaborados"].ToString(), out iAniosLaborados_);
                iAniosLaborados = iAniosLaborados_;

                decimal.TryParse(unRow["Vacaciones"].ToString(), out dcVacaciones_);
                decimal.TryParse(unRow["PrimaVacional"].ToString(), out dcPrimaVacacional_);
                decimal.TryParse(unRow["Aguinaldo"].ToString(), out dcAguinaldo_);

                dcVacaciones = dcVacaciones_;
                dcPrimaVacacional = dcPrimaVacacional_;
                dcAguinaldo = dcAguinaldo_;

                decimal.TryParse(unRow["UMA"].ToString(), out dcUMA_);
                decimal.TryParse(unRow["FactorDeIntegracion"].ToString(), out dcFactorIntegracion_);
                decimal.TryParse(unRow["NuevoSalarioBaseCotizacion"].ToString(), out dcSBC_);
                decimal.TryParse(unRow["NuevoSalarioDiarioIntegrado"].ToString(), out dcSDI_);

                dcUMA = dcUMA_;
                dcFactorIntegracion = dcFactorIntegracion_;
                dcSBC = dcSBC_;
                dcSDI = dcSDI_;

                decimal.TryParse(unRow["ParteVariable"].ToString(), out dcParteVariable_);
                dcParteVariable = dcParteVariable_;
            }
            else
            {
                int.TryParse(unRow["Id Empleado"].ToString(), out idEmpleado_);
                idEmpleado = idEmpleado_;

                DateTime.TryParse(unRow["Fecha Aniversario"].ToString(), out dtFAniversario);
                dtFechaAniversario = dtFAniversario;

                int.TryParse(unRow["Anios Laborados"].ToString(), out iAniosLaborados_);
                iAniosLaborados = iAniosLaborados_;

                decimal.TryParse(unRow["Vacaciones"].ToString(), out dcVacaciones_);
                decimal.TryParse(unRow["Prima Vacional"].ToString(), out dcPrimaVacacional_);
                decimal.TryParse(unRow["Aguinaldo"].ToString(), out dcAguinaldo_);

                dcVacaciones = dcVacaciones_;
                dcPrimaVacacional = dcPrimaVacacional_;
                dcAguinaldo = dcAguinaldo_;

                decimal.TryParse(unRow["UMA"].ToString(), out dcUMA_);
                decimal.TryParse(unRow["Factor De Integracion"].ToString(), out dcFactorIntegracion_);
                decimal.TryParse(unRow["Nuevo Salario Base Cotizacion"].ToString(), out dcSBC_);
                decimal.TryParse(unRow["Nuevo Salario Diario Integrado"].ToString(), out dcSDI_);


                dcUMA = dcUMA_;
                dcFactorIntegracion = dcFactorIntegracion_;
                dcSBC = dcSBC_;
                dcSDI = dcSDI_;

                decimal.TryParse(unRow["Parte Variable"].ToString(), out dcParteVariable_);
                dcParteVariable = dcParteVariable_;
            }


        }

    }


}