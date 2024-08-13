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
using winAppSAIC.UtileriasLocal;

namespace winAppSAIC.Tesoreria
{
    public partial class XtraReporteLibroDiario : DevExpress.XtraEditors.XtraForm
    {
        tools.dsc dsc = new tools.dsc();
        String sRutaReporte = String.Empty;
        public XtraReporteLibroDiario()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XtraReporteLibroDiario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbSAICBPOTesoreriaDataSet.stpSelLibroDiarioTenedoras' Puede moverla o quitarla según sea necesario.
            this.stpSelLibroDiarioTenedorasTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.stpSelLibroDiarioTenedoras);

            DateTime dFechaHoy = new DateTime();
            DateTime.TryParse(stpSelEstatusNominaContabilizadaTableAdapter1.ObtenerFechaServidor().ToString(), out dFechaHoy);
            dateEFechaInicial.DateTime = dFechaHoy.Date;
            dateEFechaFin.DateTime = dFechaHoy.Date;

            gridTenedorasBancos.Properties.PopupFormWidth = 300;
            gridTenedora.Properties.PopupFormWidth = 700;

            sRutaReporte = dsc.stRutaSAICTesoreria + @"Libro Diario\";
        }

        private void btnAbrirCarpeta_Click(object sender, EventArgs e)
        {
            dsc.CheckandCreateFolder(sRutaReporte);
            Process.Start(sRutaReporte);
        }

        private void gridTenedora_EditValueChanged(object sender, EventArgs e)
        {
            int idMatrizTenedora = 0;
            int.TryParse(gridTenedora.EditValue.ToString(), out idMatrizTenedora);
            stpSelLibroDiarioBancosTenedorasTableAdapter.Fill(dbSAICBPOTesoreriaDataSet.stpSelLibroDiarioBancosTenedoras, idMatrizTenedora);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validator.IsPresent(gridTenedora) && Validator.IsPresent(gridTenedorasBancos))
                {
                    if (!splashScreenManager1.IsSplashFormVisible)
                    {
                        splashScreenManager1.ShowWaitForm();
                    }

                    int idMatrizTenedora = 0;
                    int.TryParse(gridTenedora.EditValue.ToString(), out idMatrizTenedora);

                    Decimal dSaldoInicialPeriodo = 0;
                    Decimal.TryParse(spinESaldoInicialPeriodo.Value.ToString(), out dSaldoInicialPeriodo);

                    stpSelLibroDiarioTableAdapter.Fill(dbSAICBPOTesoreriaDataSet.stpSelLibroDiario, idMatrizTenedora, gridTenedorasBancos.Text, dateEFechaInicial.DateTime.Date, dateEFechaFin.DateTime.Date, dSaldoInicialPeriodo);

                    DataTable dtLibroDiario = dbSAICBPOTesoreriaDataSet.stpSelLibroDiario;

                    if (!dtLibroDiario.Columns.Contains("Saldo"))
                    {
                        dtLibroDiario.Columns.Add("Saldo", typeof(Decimal));
                    }

                    for (int i = 0; i < dtLibroDiario.Rows.Count; i++)
                    {
                        Decimal dSaldo;
                        Decimal dRes_Saldo;
                        Decimal dIngreso;
                        Decimal dEgreso;

                        decimal.TryParse(dtLibroDiario.Rows[i]["Ingreso"].ToString(), out dIngreso);
                        decimal.TryParse(dtLibroDiario.Rows[i]["Egreso"].ToString(), out dEgreso);

                        if (i == 0)
                        {
                            dRes_Saldo = spinESaldoInicialPeriodo.Value + dIngreso - dEgreso;
                            dtLibroDiario.Rows[i]["Saldo"] = dRes_Saldo.ToString("N2");

                        }
                        else
                        {
                            decimal.TryParse(dtLibroDiario.Rows[i - 1]["Saldo"].ToString(), out dSaldo);

                            dRes_Saldo = dSaldo + dIngreso - dEgreso;
                            dtLibroDiario.Rows[i]["Saldo"] = dRes_Saldo.ToString("N2");
                        }
                    }
                    gridControl1.DataSource = dtLibroDiario;
                    gridView2.Columns["Ingreso"].DisplayFormat.FormatString = "N2";
                    gridView2.Columns["Egreso"].DisplayFormat.FormatString = "N2";
                    gridView2.Columns["Saldo"].DisplayFormat.FormatString = "N2";

                    lblResultado.Text = "Resultado: " + dtLibroDiario.Rows.Count.ToString();

                    if (splashScreenManager1.IsSplashFormVisible)
                    {
                        splashScreenManager1.CloseWaitForm();
                    }

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error al consultar el Reporte: " + ex.Message, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDescargarExcel_Click(object sender, EventArgs e)
        {
            try
            {
                String stNombreArchivo = "Reporte Libro Diario " + gridTenedora.Text + "_" + gridTenedorasBancos.Text + "_" +
                       dateEFechaInicial.DateTime.Year.ToString() + dateEFechaInicial.DateTime.Month.ToString("00") + dateEFechaInicial.DateTime.Day.ToString("00") + "_"
                       + dateEFechaFin.DateTime.Year.ToString() + dateEFechaFin.DateTime.Month.ToString("00") + dateEFechaFin.DateTime.Day.ToString("00") + ".xlsx";
                if (gridView2.RowCount > 0)
                {
                    dsc.CheckandCreateFolder(sRutaReporte);
                    gridView2.ExportToXlsx(sRutaReporte + stNombreArchivo);
                    XtraMessageBox.Show("Reporte " + stNombreArchivo + " descargado." + Environment.NewLine
                        + "Ruta: " + sRutaReporte, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error en la descarga del Reporte: " + ex.Message, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}