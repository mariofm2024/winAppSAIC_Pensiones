using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Diagnostics;

namespace winAppSAIC.IMSS
{
    public partial class frmxSolicitudAltaEmpleados : DevExpress.XtraEditors.XtraForm
    {
        DataTable dbEmpleados = new DataTable();
        tools.dsc dsc = new tools.dsc();
        public frmxSolicitudAltaEmpleados()
        {
            InitializeComponent();
        }

        private void frmxSolicitudAltaEmpleados_Load(object sender, EventArgs e)
        {
            stpSelSolicitudAltaEmpleadosIMSSTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelSolicitudAltaEmpleadosIMSS, 54);
            dbEmpleados = dbSAICBPOCatalogosDataSet1.stpSelSolicitudAltaEmpleadosIMSS;
            GridEmpleados.DataSource = dbEmpleados;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            btnEstatusSolicitud.Enabled = true;
            XtraMessageBox.Show("Columna: " + stColumna + Environment.NewLine + "Valor Nuevo: " + stValue, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGenerarLayOut_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                String stLayOut = String.Empty;
                DataTable dtEmpleadosSeleccionados = dsc.deGridViewSelectedToDataTable(gridView1);
                stLayOut = generarLayOutIMSS(dtEmpleadosSeleccionados);

                if (!String.IsNullOrEmpty(stLayOut))
                {
                    String stRuta = dsc.stRutaTemp;
                    dsc.CheckandCreateFolder(stRuta);
                    String stNombre = "IMSS_LayOut " + dsc.nombreAleatorio() + ".txt";
                    File.WriteAllText(stRuta + stNombre, stLayOut);
                    System.Threading.Thread.Sleep(2000);
                    Process.Start(stRuta + stNombre);
                }
                else
                {
                    XtraMessageBox.Show("No hay datos en la base de los empleados.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private String generarLayOutIMSS(DataTable dtEmpleadosSeleccionados)
        {
            String stLayOut = String.Empty;

            foreach (DataRow unRow in dtEmpleadosSeleccionados.Rows)
            {
                DataTable dtDatos = new DataTable();
                int iNumeroEmpleado = 0;
                int iTipoTrabajador = 0;
                int iTipoSalaraio = 0;
                int iSemanaJornada = 0;

                int.TryParse(unRow[0].ToString(), out iNumeroEmpleado);
                int.TryParse(unRow[7].ToString(), out iTipoTrabajador);
                int.TryParse(unRow[8].ToString(), out iTipoSalaraio);
                int.TryParse(unRow[9].ToString(), out iSemanaJornada);

                try
                {
                    stpSelAltaEmpleadoLayOutIMSSTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSS, iNumeroEmpleado, iTipoTrabajador, iTipoSalaraio, iSemanaJornada);
                }
                catch (Exception) { }
                dtDatos = dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSS;
                if (dtDatos.Rows.Count > 0)
                {
                    stLayOut += dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSS.Rows[0]["RegistroPatronalIMSS"].ToString() +
                        dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSS.Rows[0]["NSS"].ToString() +
                        dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSS.Rows[0]["APaternoEmpleado"].ToString() +
                        dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSS.Rows[0]["AMaternoEmpleado"].ToString() +
                        dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSS.Rows[0]["NombreEmpleado"].ToString() +
                        dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSS.Rows[0]["SDI"].ToString() +
                        dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSS.Rows[0]["TipoTrabajador"].ToString() +
                        dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSS.Rows[0]["TipoSalario"].ToString() +
                        dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSS.Rows[0]["SemanaJornada"].ToString() +
                        dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSS.Rows[0]["Fecha"].ToString() +
                        dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSS.Rows[0]["UMF"].ToString() +
                        dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSS.Rows[0]["TipoMovimiento"].ToString() +
                        dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSS.Rows[0]["Guia"].ToString() +
                        dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSS.Rows[0]["Clabe"].ToString() +
                        dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSS.Rows[0]["CURP"].ToString() +
                        dbSAICBPOCatalogosDataSet1.stpSelAltaEmpleadoLayOutIMSS.Rows[0]["Identificador"].ToString() + Environment.NewLine;
                }
            }

            return stLayOut;
        }

        String stColumna = String.Empty;
        String stValue = String.Empty;

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            stColumna = e.Column.ToString();
            stValue = e.Value.ToString().ToUpper();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEstatusSolicitud_Click(object sender, EventArgs e)
        {
            //XtraEmpleadosXSolicitudIMSS EmpleadosxSolicitud = new XtraEmpleadosXSolicitudIMSS();
            //EmpleadosxSolicitud.ShowDialog();
        }

        private void checkTodas_CheckedChanged(object sender, EventArgs e)
        {
            checkProceso.Checked = false;
            checkSolicitadas.Checked = false;
            checkAtendidas.Checked = false;
        }

        private void checkProceso_CheckedChanged(object sender, EventArgs e)
        {
            checkTodas.Checked = false;
        }

        private void checkSolicitadas_CheckedChanged(object sender, EventArgs e)
        {
            checkTodas.Checked = false;
        }

        private void checkAtendidas_CheckedChanged(object sender, EventArgs e)
        {
            checkTodas.Checked = false;
        }
    }
}