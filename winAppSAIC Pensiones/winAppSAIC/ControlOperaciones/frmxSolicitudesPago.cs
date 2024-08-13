using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using winAppSAIC.UtileriasLocal;
using compCatalogosSAIC;
using DevExpress.XtraGrid.Views.Grid;
using compLibreriaSAIC;
using winAppSAIC.Reportes;
using DevExpress.XtraReports.UI;        //namespace a partir version 12.2.4
using winAppSAIC.ReportesCFDI;
using DevExpress.XtraPrinting;
using System.IO;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;

namespace winAppSAIC.ControlOperaciones
{
    public partial class frmxSolicitudesPago : DevExpress.XtraEditors.XtraForm
    {
        public frmxSolicitudesPago()
        {
            InitializeComponent();
        }

        string FIni = "";
        string FFin = "";
        bool Autorizacion = false;
        string pTope1 = "60";
        string pTope2 = "120";

        private void Filtro(int IdEstatus,Int64 IdSolicitud)
        {
            this.stpTesSelSolicitudPagoTableAdapter.Fill(this.dbSAICBPOFactura.stpTesSelSolicitudPago, IdEstatus, FIni, FFin, IdSolicitud, OperadorBD.OperadorGlobal.IdOperador);
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void ActivarBotones()
        {
            if(!Autorizacion)
            {
                btnConfirmar.Visibility =DevExpress.XtraBars.BarItemVisibility.Never;
                btnCancelar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
        }
        private void frmxSolicitudesPago_Load(object sender, EventArgs e)
        {
           
            try
            {
                splashSMCargando.ShowWaitForm();

                this.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1.Fill(this.dbSAICBPOFactura.stpFactSelDerechosAccesoOperadorFacturacion, OperadorBD.OperadorGlobal.IdOperador, "ControlOperaciones.frmxSolicitudesPago", "rbiSolicitudPago");

                if (this.dbSAICBPOFactura.stpFactSelDerechosAccesoOperadorFacturacion.Count > 0)
                {
                    DataRow row = this.dbSAICBPOFactura.stpFactSelDerechosAccesoOperadorFacturacion.Rows[0];
                    Autorizacion = (bool)row[15];
                    row = null;
                }
                else
                {
                    Autorizacion = false;
                }

                pTope1 = this.validacionesGeneralTableAdapter1.ObtenerValorParametro("TOPE1").ToString();
                pTope2 = this.validacionesGeneralTableAdapter1.ObtenerValorParametro("TOPE2").ToString();

                ActivarBotones();

                // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwTesCatEstatusSolicitudGlobal' table. You can move, or remove it, as needed.
                this.vwTesCatEstatusSolicitudGlobalTableAdapter.Fill(this.dbSAICBPOFactura.vwTesCatEstatusSolicitudGlobal);

                dtFechaIni.Value = DateTime.Now;
                dtFechaFin.Value = DateTime.Now;

                FIni = Convert.ToDateTime(dtFechaIni.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Day.ToString();
                FFin = Convert.ToDateTime(dtFechaFin.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Day.ToString();

                Filtro(-1,-1);

                splashSMCargando.CloseWaitForm();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                splashSMCargando.CloseWaitForm();
            }

        }

        private void btnCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Int64 Id = 0;
            string pIdOk = "";
            try
            {
                if (dgvSolicitudes.SelectedRowsCount > 0)
                {
                    DataRow Row = dgvSolicitudes.GetDataRow(dgvSolicitudes.FocusedRowHandle);
                    Id = Convert.ToInt64(Row[0]);
                    if (Row[8].ToString() != "SOLICITUD CANCELADA")
                    {
                        ControlOperaciones.frmxCancelarSolicitud objAsignarXML = new ControlOperaciones.frmxCancelarSolicitud();
                        objAsignarXML.ShowDialog();     //mostrar pantalla

                        if (objAsignarXML.bFlag)
                        {
                            spSoloRespuesta1.stpTesUpdSolicitudPago(Id, 23, objAsignarXML.pRespuesta, OperadorBD.OperadorGlobal.NombreUsuario, ref pIdOk);

                            if (pIdOk != "")
                                queriesAsimilados1.stpTesUpdSolicitudPago(Id, 23, objAsignarXML.pRespuesta, OperadorBD.OperadorGlobal.NombreUsuario, ref pIdOk);

                            if (pIdOk != "")
                                XtraMessageBox.Show(pIdOk, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            FIni = Convert.ToDateTime(dtFechaIni.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Day.ToString();
                            FFin = Convert.ToDateTime(dtFechaFin.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Day.ToString();

                            Filtro(-1, -1);
                        }
                    }
                    else
                        XtraMessageBox.Show("¡La solicitud ya esta en un estatus de Cancelado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    XtraMessageBox.Show("¡Debe de Seleccionar una solicitud!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFiltrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                    FIni = Convert.ToDateTime(dtFechaIni.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Day.ToString();
                    FFin = Convert.ToDateTime(dtFechaFin.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Day.ToString();
                    
                    Filtro(-1,-1);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnEFiltro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                dtFechaIni.Value = DateTime.Now;
                dtFechaFin.Value = DateTime.Now;

                FIni = Convert.ToDateTime(dtFechaIni.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Day.ToString();
                FFin = Convert.ToDateTime(dtFechaFin.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Day.ToString();

                Filtro(-1, -1);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSolicitudes_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Int64 pIdSolicitud= 0;
                Int64 pIdControl = 0;
                Int64 pIdPago = 0;
                string pFechaPago = "";
                string pCliente = "";
                string pOperador = "";

                bool? pOk = false;
                DataRow row = null;
                row = dgvSolicitudes.GetDataRow(dgvSolicitudes.FocusedRowHandle);
                if (row != null)
                {
                    pIdSolicitud = Convert.ToInt64(row[0].ToString());
                    pIdControl = Convert.ToInt64(row[1].ToString());
                    pFechaPago = Convert.ToDateTime(row[4].ToString()).Date.ToString("yyyyMMdd"); 
                    pCliente = row[14].ToString();
                    pOperador = row[3].ToString();

                    ControlOperaciones.frmxSolicitudesPagoDetail objPantalla = new ControlOperaciones.frmxSolicitudesPagoDetail()
                    {
                        IdSolicitud = pIdSolicitud,
                        IdControl= pIdControl,
                        FechaPago=pFechaPago,
                        Cliente=pCliente,
                        Operador=pOperador
                    };
                    objPantalla.ShowDialog();

                    string FIni = Convert.ToDateTime(dtFechaIni.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Day.ToString();
                    string FFin = Convert.ToDateTime(dtFechaFin.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Day.ToString();

                    Filtro(-1, -1);

                }
                else
                    XtraMessageBox.Show("Debe seleccionar una Solicitud", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSolicitudes_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {

            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string category = View.GetRowCellDisplayText(e.RowHandle, View.Columns[4]);
                string IdEstatus = View.GetRowCellDisplayText(e.RowHandle, View.Columns[7]);
                DateTime FechaC = Convert.ToDateTime(category);
                DateTime FechaH = DateTime.Now;
                var Horas = (FechaH - FechaC).TotalMinutes;

                if (IdEstatus == "23")
                {
                    e.Appearance.BackColor = Color.Orange;
                    e.Appearance.BackColor2 = Color.Orange;
                }
                else
                {
                    if (IdEstatus != "16" && IdEstatus != "15")
                    {
                        e.Appearance.BackColor = Color.White;
                        //e.Appearance.BackColor2 = Color.White;
                    }
                    else
                    {
                        if (Horas <= Convert.ToInt32(pTope1))
                        {
                            e.Appearance.BackColor = Color.White;
                            //e.Appearance.BackColor2 = Color.White;
                        }
                        else if (Horas <= Convert.ToInt32(pTope2))
                        {
                            e.Appearance.BackColor = Color.Yellow;
                            //e.Appearance.BackColor2 = Color.LightYellow;
                        }
                        else
                        {
                            e.Appearance.BackColor = Color.Salmon;
                            //e.Appearance.BackColor2 = Color.SeaShell;
                        }
                    }
                }
            }
        }

        private void btnExportar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                savedescarga.Filter = "Excel Files(.xls)|*.xls|Excel Files(.xlsx) | *.xlsx | Excel Files(*.xlsm) | *.xlsm";
                if (savedescarga.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    gridSolicitudes.ExportToXls(savedescarga.FileName);

                    //Solicitar la visualización del nuevo archivo en Excel
                    if (XtraMessageBox.Show("¿Desea abrir el archivo en Excel?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        // Mostrar resultado en Excel.
                        Utilerias.StartProcess(savedescarga.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}