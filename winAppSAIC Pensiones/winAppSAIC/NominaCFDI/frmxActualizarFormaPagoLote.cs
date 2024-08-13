using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using winAppSAIC.NominaCFDI.Clases;
using System.Diagnostics;

namespace winAppSAIC.NominaCFDI
{
    public partial class frmxActualizarFormaPagoLote : DevExpress.XtraEditors.XtraForm
    {
        Lote miLote;
        Boolean flagTaMuyBien = true;

        public frmxActualizarFormaPagoLote(Lote miLote)
        {
            InitializeComponent();
            this.miLote = miLote;
        }

        private void frmxActualizarFormaPagoLote_Load(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                System.Threading.Thread.Sleep(1000);
                stpSelObtenerInfoEmpleadosLoteCargaNominaTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoEmpleadosLoteCargaNomina, miLote.idLote);
                stpSelObtenerInfoBancosLoteTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoBancosLote, miLote.idTenedora);
                stpSelFormaPagoLoteTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelFormaPagoLote);
                txtLote.Text = miLote.idLote.ToString();
                txtFolio.Text = miLote.FolioLoteCargaNomina;
                txtTenedora.Text = miLote.Tenedora_NombreComercial;
                txtObra.Text = miLote.Cliente_NombreComercial;
                txtOperador.Text = miLote.Operador;
                lnlLote.Text += miLote.idLote.ToString();
                labelControl6.Text += dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoEmpleadosLoteCargaNomina.Rows.Count.ToString();
                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception ex)
            {
                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }

                XtraMessageBox.Show("No se puede cargar información." + Environment.NewLine + ex.Message
                            , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ItemGridLookUpEditFormaPago_EditValueChanged(object sender, EventArgs e)
        {
            DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);
        }


        private void ItemGridLookUpEditFormaPago_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            flagTaMuyBien = true;

            if (e.NewValue.ToString() == "CHEQUE")
            {
                gridView2.GetDataRow(gridView2.FocusedRowHandle)["CLABECFDI"] = string.Empty;
                gridView2.GetDataRow(gridView2.FocusedRowHandle)["NoCuentaBanco"] = string.Empty;
                gridView2.GetDataRow(gridView2.FocusedRowHandle)["DescBanco"] = string.Empty;
            }
            else if (e.NewValue.ToString() == "TRANSFERENCIA")
            {
                //Clabe_CuentaEmpleado(e, gridView2.GetDataRow(gridView2.FocusedRowHandle)["BancoOrigen"].ToString());

                int idHeader = 0;
                int idLote = 0;
                int idEmpleado = 0;

                int.TryParse(gridView2.GetDataRow(gridView2.FocusedRowHandle)["IdPDOHeader"].ToString(), out idHeader);

                int.TryParse(gridView2.GetDataRow(gridView2.FocusedRowHandle)["IdEmpleadoInterno"].ToString(), out idEmpleado);

                stpSelObtenerInfoEmpleadosDatosBancariosTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoEmpleadosDatosBancarios, idHeader, miLote.idLote, idEmpleado);
                if (dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoEmpleadosDatosBancarios.Rows.Count > 0)
                {
                    if (!String.IsNullOrEmpty(dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoEmpleadosDatosBancarios.Rows[0]["CLABE"].ToString()))
                    {
                        Clave_Cuenta(gridView2.GetDataRow(gridView2.FocusedRowHandle)["BancoOrigen"].ToString()
                            , dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoEmpleadosDatosBancarios.Rows[0]["CLABE"].ToString()
                            , dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoEmpleadosDatosBancarios.Rows[0]["NoCuentaBanco"].ToString()
                            , dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoEmpleadosDatosBancarios.Rows[0]["BancoDepositoNomina"].ToString());

                        //gridView2.GetDataRow(gridView2.FocusedRowHandle)["CLABECFDI"] = dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoEmpleadosDatosBancarios.Rows[0]["CLABE"].ToString();
                        //gridView2.GetDataRow(gridView2.FocusedRowHandle)["NoCuentaBanco"] = dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoEmpleadosDatosBancarios.Rows[0]["NoCuentaBanco"].ToString();
                        //gridView2.GetDataRow(gridView2.FocusedRowHandle)["DescBanco"] = dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoEmpleadosDatosBancarios.Rows[0]["BancoDepositoNomina"].ToString();

                    }
                    else
                    {
                        XtraMessageBox.Show("No se cuenta con informacion Bancaria en el Catalogo de Empleados" + Environment.NewLine + "Debe solicitar la Actualización de Clabe del Empleado para cambiar el tipo de Pago a Transferencia."
                             , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        gridView2.GetDataRow(gridView2.FocusedRowHandle)["CLABECFDI"] = string.Empty;
                        gridView2.GetDataRow(gridView2.FocusedRowHandle)["NoCuentaBanco"] = string.Empty;
                        gridView2.GetDataRow(gridView2.FocusedRowHandle)["DescBanco"] = string.Empty;
                        e.NewValue = "CHEQUE";
                    }
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                gridView2.Focus();
                DataRow unRow = gridView2.GetDataRow(gridView2.FocusedRowHandle);

                if (String.IsNullOrEmpty(unRow["Estatus Empleado"].ToString()))
                {
                    DialogResult resultado = XtraMessageBox.Show("¿Esta seguro de de actualizar la Forma de pago de " + unRow["NombreEmpleado"] + " ?"
                                         , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (DialogResult.Yes == resultado)
                    {
                        splashScreenManager1.ShowWaitForm();
                        System.Threading.Thread.Sleep(1000);

                        int idHeader;
                        int idEmpleado;

                        int.TryParse(unRow["IdPDOHeader"].ToString(), out idHeader);
                        int.TryParse(unRow["IdEmpleadoInterno"].ToString(), out idEmpleado);

                        queriesTableAdapter1.stpUpdInfoEmpleadosDatosBancarios(idHeader, idEmpleado, miLote.idLote, unRow["TipoPago"].ToString(), unRow["CLABECFDI"].ToString(), unRow["NoCuentaBanco"].ToString(), unRow["DescBanco"].ToString(), unRow["BancoOrigen"].ToString(), compCatalogosSAIC.OperadorBD.OperadorGlobal.NombreUsuario);
                        splashScreenManager1.CloseWaitForm();
                    }
                }
                else
                {
                    XtraMessageBox.Show("No se puedo guardar la informacion. " + unRow["Estatus Empleado"].ToString()
                                         , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }

                XtraMessageBox.Show("No se puede actualizar la Forma de Pago." + Environment.NewLine + ex.Message
                               , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView2_ShowingEditor(object sender, CancelEventArgs e)
        {

        }

        private void gridView2_RowLoaded(object sender, DevExpress.XtraGrid.Views.Base.RowEventArgs e)
        {

        }

        private void gridView2_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                if (e.RowHandle >= 0)
                {
                    gridView2.OptionsSelection.EnableAppearanceFocusedRow = false;

                    if (gridView2.GetDataRow(e.RowHandle)["Estatus Empleado"].ToString() != "")
                    {
                        e.Appearance.BackColor = Color.LightGoldenrodYellow;
                        e.HighPriority = true;
                    }
                }
            }
            catch (Exception) { }
        }

        private void frmxActualizarFormaPagoLote_SizeChanged(object sender, EventArgs e)
        {
        }

        private void Clabe_CuentaEmpleado(DevExpress.XtraEditors.Controls.ChangingEventArgs e, String stBancoOrigen)
        {
            String stBanco = String.Empty;
            int idEmpleado = 0;
            int idHeader = 0;

            int.TryParse(gridView2.GetDataRow(gridView2.FocusedRowHandle)["IdPDOHeader"].ToString(), out idHeader);
            int.TryParse(gridView2.GetDataRow(gridView2.FocusedRowHandle)["IdEmpleadoInterno"].ToString(), out idEmpleado);

            stpSelObtenerInfoEmpleadosDatosBancariosTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoEmpleadosDatosBancarios, idHeader, miLote.idLote, idEmpleado);

            stpSelObtenerBancoDeClabeTableAdapter.Fill(dbSAICBPOCatalogosDataSet1.stpSelObtenerBancoDeClabe, gridView2.GetDataRow(gridView2.FocusedRowHandle)["CLABECFDI"].ToString(), ref stBanco);


            Clave_Cuenta(stBancoOrigen
                , dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoEmpleadosDatosBancarios.Rows[0]["CLABE"].ToString()
                , dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoEmpleadosDatosBancarios.Rows[0]["NoCuentaBanco"].ToString()
                , dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoEmpleadosDatosBancarios.Rows[0]["BancoDepositoNomina"].ToString());


            //if (!String.IsNullOrEmpty(dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoEmpleadosDatosBancarios.Rows[0]["CLABE"].ToString()))
            //{
            //    if (stBancoOrigen == stBanco)
            //    {
            //        gridView2.GetDataRow(gridView2.FocusedRowHandle)["CLABECFDI"] = dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoEmpleadosDatosBancarios.Rows[0]["CLABE"].ToString();
            //        gridView2.GetDataRow(gridView2.FocusedRowHandle)["NoCuentaBanco"] = dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoEmpleadosDatosBancarios.Rows[0]["NoCuentaBanco"].ToString();
            //        gridView2.GetDataRow(gridView2.FocusedRowHandle)["DescBanco"] = dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoEmpleadosDatosBancarios.Rows[0]["BancoDepositoNomina"].ToString();
            //    }
            //    else
            //    {
            //        gridView2.GetDataRow(gridView2.FocusedRowHandle)["CLABECFDI"] = dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoEmpleadosDatosBancarios.Rows[0]["CLABE"].ToString();
            //        gridView2.GetDataRow(gridView2.FocusedRowHandle)["NoCuentaBanco"] = dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoEmpleadosDatosBancarios.Rows[0]["CLABE"].ToString();
            //        gridView2.GetDataRow(gridView2.FocusedRowHandle)["DescBanco"] = dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoEmpleadosDatosBancarios.Rows[0]["BancoDepositoNomina"].ToString();
            //    }
            //}
            //else
            //{
            //    XtraMessageBox.Show("No se cuenta con informacion Bancaria en el Catalogo de Empleados" + Environment.NewLine + "Debe solicitar la Actualización de Clabe del Empleado para cambiar el tipo de Pago a Transferencia."
            //            , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    gridView2.GetDataRow(gridView2.FocusedRowHandle)["CLABECFDI"] = string.Empty;
            //    gridView2.GetDataRow(gridView2.FocusedRowHandle)["NoCuentaBanco"] = string.Empty;
            //    gridView2.GetDataRow(gridView2.FocusedRowHandle)["DescBanco"] = string.Empty;
            //    e.NewValue = "CHEQUE";
            //}
        }

        private void Clave_Cuenta(String stBancoOrigen, String stClabe, String stCuenta, String stBancoDestino)
        {
            String stBanco = String.Empty;
            stpSelObtenerBancoDeClabeTableAdapter.Fill(dbSAICBPOCatalogosDataSet1.stpSelObtenerBancoDeClabe, stClabe, ref stBanco);

            if (stBancoOrigen == stBanco)
            {
                gridView2.GetDataRow(gridView2.FocusedRowHandle)["CLABECFDI"] = stClabe;
                gridView2.GetDataRow(gridView2.FocusedRowHandle)["NoCuentaBanco"] = stCuenta;
                gridView2.GetDataRow(gridView2.FocusedRowHandle)["DescBanco"] = stBancoDestino;
            }
            else
            {
                gridView2.GetDataRow(gridView2.FocusedRowHandle)["CLABECFDI"] = stClabe;
                gridView2.GetDataRow(gridView2.FocusedRowHandle)["NoCuentaBanco"] = stClabe;
                gridView2.GetDataRow(gridView2.FocusedRowHandle)["DescBanco"] = stBancoDestino;
            }
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            try
            {
                tools.dsc dsc = new tools.dsc();
                String stRutaSaic = dsc.stRutaSAICActualizacionDeLote;
                dsc.CheckandCreateFolder(stRutaSaic);
                stRutaSaic += "Lote " + miLote.idLote + " - " + dsc.nombreAleatorio() + ".xlsx";
                gridControl2.ExportToXlsx(stRutaSaic);

                XtraMessageBox.Show("descarga con exito." + Environment.NewLine + "Ruta: " + stRutaSaic, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("No se puede descargar la Información" + ex.Message, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAbrirCarpeta_Click(object sender, EventArgs e)
        {
            tools.dsc dsc = new tools.dsc();
            String stRutaSaic = dsc.stRutaSAICActualizacionDeLote;
            dsc.CheckandCreateFolder(stRutaSaic);
            Process.Start(stRutaSaic);
        }

        private void ItemGridLookUpEditBancoOrigen_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ItemGridLookUpEditBancoOrigen_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (gridView2.GetDataRow(gridView2.FocusedRowHandle)["TipoPago"].ToString() == "TRANSFERENCIA")
            {
                Clabe_CuentaEmpleado(e, e.NewValue.ToString());
            }
        }
    }
}
