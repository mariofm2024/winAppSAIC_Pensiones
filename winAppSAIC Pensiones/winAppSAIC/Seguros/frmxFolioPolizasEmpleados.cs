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

namespace winAppSAIC.Seguros
{
    public partial class frmxFolioPolizasEmpleados : DevExpress.XtraEditors.XtraForm
    {
        public frmxFolioPolizasEmpleados()
        {
            InitializeComponent();
        }

        private void toolBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmxFolioPolizasEmpleados_Load(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            splashScreenManager1.SetWaitFormCaption("Cargando Información");
            splashScreenManager1.SetWaitFormDescription("");

            ActulizarTabla();

            if (splashScreenManager1.IsSplashFormVisible){ splashScreenManager1.CloseWaitForm(); }

        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            try
            {
                tools.dsc dsc = new tools.dsc();
                String stRutaSeguros = dsc.stRutaSAICSeguros;
                dsc.CheckandCreateFolder(stRutaSeguros);
                stRutaSeguros += "Poliza Empleados - " + dsc.nombreAleatorio() + ".xlsx";
                ctrPolizaEmpleados.ExportToXlsx(stRutaSeguros);

                XtraMessageBox.Show("descarga con exito." + Environment.NewLine + "Ruta: " + stRutaSeguros, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("No se puede descargar la Información" + ex.Message, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImportarExcel_Click(object sender, EventArgs e)
        {
            try
            {
                tools.dsc dsc = new tools.dsc();
                String stArchivoSeleccionado = String.Empty;
                String stLetraColumna = String.Empty;
                OpenFileDialog ofdSelecFile = new OpenFileDialog();
                DataTable dtPolizaEmpleado_temp;
                DataTable dtPolizaEmpleado;

                String stLog = String.Empty;
                String stRespuesta = String.Empty;

                int iContador = 1;
                int iMuyBien = 0;
                int iMuyMal = 0;

                ofdSelecFile.Filter = "Excel Files (*.xls;*.xlsm;*.xlsb;*.xlsx)|*.xls;*.xlsm;*.xlsb;*.xlsx";
                ofdSelecFile.ShowDialog();
                stArchivoSeleccionado = ofdSelecFile.FileName;
                txtRutaExcel.Text = stArchivoSeleccionado;

                stLetraColumna = dsc.ColumnaExcel(dbSAICBPOCatalogosDataSet1.stpSelInfoEmpleadosPoliza.Columns.Count);
                dtPolizaEmpleado = dsc.ConvertExcelToDataTable(stArchivoSeleccionado, stLetraColumna);

                var query = from x in dtPolizaEmpleado.AsEnumerable()
                            where !x.Field<String>("ID EMPLEADO POLIZA").Equals("")
                            select x;

                if (query.Count() > 0)
                {
                    dtPolizaEmpleado = query.CopyToDataTable();
                }

                if (dtPolizaEmpleado.Rows.Count > 0)
                {
                    stLog = "Detalle de Actualizacion de Folio" + Environment.NewLine;

                    splashScreenManager1.ShowWaitForm();
                    splashScreenManager1.SetWaitFormCaption("Actualizando Folios");

                    foreach (DataRow UnRow in dtPolizaEmpleado.Rows)
                    {
                        stRespuesta = String.Empty;
                        splashScreenManager1.SetWaitFormDescription(iContador + " de " + dtPolizaEmpleado.Rows.Count);
                        int idPoliza;
                        int idEmpleado;

                        int.TryParse(UnRow["ID EMPLEADO POLIZA"].ToString(), out idPoliza);
                        int.TryParse(UnRow["ID EMPLEADO"].ToString(), out idEmpleado);

                        if (idPoliza > 0 && idEmpleado > 0)
                        {
                            queriesTableAdapter1.stpUpdFolioPolizaEmpleado(idPoliza, idEmpleado, UnRow["FOLIO"].ToString(), OperadorBD.OperadorGlobal.NombreUsuario, ref stRespuesta);
                        }
                        else
                        {
                            stRespuesta = "Id Empleado Póliza(" + idPoliza + ") o idEmpleado(" + idEmpleado + ") no Validos";
                        }

                        if (String.IsNullOrEmpty(stRespuesta))
                        {
                            iMuyBien++;
                        }
                        else
                        {
                            iMuyMal++;
                            stLog = stRespuesta + Environment.NewLine;
                        }

                        iContador++;
                    }


                    if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }

                    XtraMessageBox.Show("Actualizacion de Folios" + Environment.NewLine + Environment.NewLine +
                         "Numero de Empleados: " + dtPolizaEmpleado.Rows.Count + Environment.NewLine +
                         "Empleados Actualizados: " + iMuyBien + Environment.NewLine +
                         "Empleados NO Actualizados: " + iMuyMal
                        , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ActulizarTabla();

                    if (!String.IsNullOrEmpty(stRespuesta))
                    {
                        dsc.guardarLog(stRespuesta);
                    }
                }
                else
                {
                    XtraMessageBox.Show("El Archivo no contiene información", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //var query = from x in dtPolizaEmpleado_temp.AsEnumerable()
                //            select new
                //            {
                //                idPoliza = x.Field<int>("IdPoliza"),
                //               idEmpleado = x.Field<int>("IdEmpleado"),
                //               stFolio = x.Field<String>("Folio")
                //            };
            }
            catch (Exception ex)
            {
                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                XtraMessageBox.Show("No se puede cargar la información" + ex.Message, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tools.dsc dsc = new tools.dsc();
            String stRutaSeguros = dsc.stRutaSAICSeguros;
            dsc.CheckandCreateFolder(stRutaSeguros);
            Process.Start(stRutaSeguros);
        }


        private void ActulizarTabla()
        {
            stpSelInfoEmpleadosPolizaTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelInfoEmpleadosPoliza);
        }
    }
}