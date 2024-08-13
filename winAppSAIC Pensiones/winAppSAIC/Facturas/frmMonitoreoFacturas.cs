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
using winAppSAIC.UtileriasLocal;
using System.IO;
using DevExpress.XtraGrid.Views.Grid;

namespace winAppSAIC.Facturas
{
    public partial class frmMonitoreoFacturas : DevExpress.XtraEditors.XtraForm
    {
        public frmMonitoreoFacturas()
        {
            InitializeComponent();
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close(); //SALIR
        }


        private bool PTimbrar = false; //Habilitar
        private void frmMonitoreoFacturas_Load(object sender, EventArgs e)
        {
            try
            {
                splashSMCargando.ShowWaitForm();

                dtFechaIni.Value = DateTime.Now.AddDays(-30);
                dtFechaFin.Value = DateTime.Now;

                string FIni = Convert.ToDateTime(dtFechaIni.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Day.ToString();
                string FFin = Convert.ToDateTime(dtFechaFin.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Day.ToString();

                ///Activar Botones 
                this.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1.Fill(this.dbSAICBPOFactura.stpFactSelDerechosAccesoOperadorFacturacion, OperadorBD.OperadorGlobal.IdOperador, "Facturas.frmMonitoreoFacturas", "btnEliminarSolicitud");

                if (this.dbSAICBPOFactura.stpFactSelDerechosAccesoOperadorFacturacion.Count > 0)
                {
                    DataRow row = this.dbSAICBPOFactura.stpFactSelDerechosAccesoOperadorFacturacion.Rows[0];
                    btnRechazarSolicitud.Visibility = ((bool)row[14] == true ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never);
                    btnEliminarSolicitud.Visibility = ((bool)row[14] == true ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never);
                }
                else
                {
                    btnRechazarSolicitud.Visibility =  DevExpress.XtraBars.BarItemVisibility.Never;
                    btnEliminarSolicitud.Visibility =  DevExpress.XtraBars.BarItemVisibility.Never;
                }

                this.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1.Fill(this.dbSAICBPOFactura.stpFactSelDerechosAccesoOperadorFacturacion, OperadorBD.OperadorGlobal.IdOperador, "Facturas.frmAdmonFacturas", "btnCancelarFactura");
                if (this.dbSAICBPOFactura.stpFactSelDerechosAccesoOperadorFacturacion.Count > 0)
                {
                    DataRow row = this.dbSAICBPOFactura.stpFactSelDerechosAccesoOperadorFacturacion.Rows[0];
                    PTimbrar = (bool)row[15];
                }
                else
                {
                    PTimbrar = false;
                }

                // TODO: This line of code loads data into the 'dbSAICBPOFactura.vwCatEstatusSolicitudGlobal' table. You can move, or remove it, as needed.
                this.vwFactCatEstatusSolicitudGlobalTableAdapter.Fill(this.dbSAICBPOFactura.vwFactCatEstatusSolicitudGlobal);
                this.stpFactSelSolicitudFacturasTableAdapter.Fill(dbSAICBPOFactura.stpFactSelSolicitudFacturas, -1, FIni, FFin, OperadorBD.OperadorGlobal.IdOperador);
               
                splashSMCargando.CloseWaitForm();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                splashSMCargando.CloseWaitForm();
            }
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                
                if (Validator.IsPresent(cbEstatus))
                {
                    string FIni = Convert.ToDateTime(dtFechaIni.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Day.ToString();
                    string FFin = Convert.ToDateTime(dtFechaFin.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Day.ToString();

                    this.stpFactSelSolicitudFacturasTableAdapter.Fill(dbSAICBPOFactura.stpFactSelSolicitudFacturas, Convert.ToInt32(cbEstatus.EditValue), FIni, FFin, OperadorBD.OperadorGlobal.IdOperador);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
              
                cbEstatus.EditValue = -1;
                dtFechaIni.Value = DateTime.Now.AddDays(-30);
                dtFechaFin.Value = DateTime.Now;

                string FIni = Convert.ToDateTime(dtFechaIni.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Day.ToString();
                string FFin = Convert.ToDateTime(dtFechaFin.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Day.ToString();

                this.stpFactSelSolicitudFacturasTableAdapter.Fill(dbSAICBPOFactura.stpFactSelSolicitudFacturas, -1, FIni, FFin, OperadorBD.OperadorGlobal.IdOperador);
                
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRechazarSolicitud_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Int64 Id = 0;
            try
            {
                if (gridView2.SelectedRowsCount > 0)
                {
                    DataRow Row = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                    Id = Convert.ToInt64(Row[0]);
                    if (Row[26].ToString() != "SOLICITUD RECHAZADA" && Row[26].ToString() != "SOLICITUD CANCELADA")
                    {
                        Facturas.frmRechazarSolicitud objAsignarXML = new Facturas.frmRechazarSolicitud()
                        {
                            pIdSolicitud = Id
                        };
                        objAsignarXML.ShowDialog();     //mostrar pantalla

                        cbEstatus.EditValue = -1;
                        dtFechaIni.Value = DateTime.Now.AddDays(-30);
                        string FIni = Convert.ToDateTime(dtFechaIni.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Day.ToString();
                        string FFin = Convert.ToDateTime(dtFechaFin.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Day.ToString();
                        this.stpFactSelSolicitudFacturasTableAdapter.Fill(dbSAICBPOFactura.stpFactSelSolicitudFacturas, -1, FIni, FFin, OperadorBD.OperadorGlobal.IdOperador);
                    }
                    else
                        XtraMessageBox.Show("¡La solicitud ya esta en un estatus de Rechazo o Cancelado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    XtraMessageBox.Show("¡Debe de Seleccionar una solicitud!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarSolicitud_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Int64 Id = 0;
            try
            {
                if (gridView2.SelectedRowsCount > 0)
                {
                    DataRow Row = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                    Id = Convert.ToInt64(Row[0]);
                    if (Row[26].ToString() != "SOLICITUD CANCELADA" && !(Row[26].ToString().Contains("100%")))
                    {
                        Facturas.frmCancelarSolicitud objAsignarXML = new Facturas.frmCancelarSolicitud()
                        {
                            pIdSolicitud = Id
                        };
                        objAsignarXML.ShowDialog();     //mostrar pantalla

                        cbEstatus.EditValue = -1;
                        dtFechaIni.Value = DateTime.Now.AddDays(-30);
                        string FIni = Convert.ToDateTime(dtFechaIni.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Day.ToString();
                        string FFin = Convert.ToDateTime(dtFechaFin.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Day.ToString();
                        this.stpFactSelSolicitudFacturasTableAdapter.Fill(dbSAICBPOFactura.stpFactSelSolicitudFacturas, -1, FIni, FFin, OperadorBD.OperadorGlobal.IdOperador);
                    }
                    else
                        XtraMessageBox.Show("¡La solicitud esta en un estatus Cancelado ó Atendida al 100%!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                     XtraMessageBox.Show("¡Debe de Seleccionar una solicitud!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {

            Int64 pIdSolicitud = 0; Int64 pIdFactura = 0;
            try
            {
                //Crear archivo Comprobante
                DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                if (row != null)
                {
                    pIdSolicitud = Convert.ToInt64(row[0].ToString());
                    pIdFactura = Convert.ToInt64(row[2].ToString());
                    if (row[26].ToString() == "SOLICITUD RECHAZADA")
                    {
                        Facturas.frmSolicitudFactura objAsignarXML = new Facturas.frmSolicitudFactura();
                        objAsignarXML.ShowDialog();     //mostrar pantalla

                        dtFechaIni.Value = DateTime.Now.AddDays(-30);
                        dtFechaFin.Value = DateTime.Now;

                        string FIni = Convert.ToDateTime(dtFechaIni.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Day.ToString();
                        string FFin = Convert.ToDateTime(dtFechaFin.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Day.ToString();
                        this.stpFactSelSolicitudFacturasTableAdapter.Fill(dbSAICBPOFactura.stpFactSelSolicitudFacturas, -1, FIni, FFin, OperadorBD.OperadorGlobal.IdOperador);
                    }
                    else if (row[26].ToString() != "SOLICITUD CANCELADA")
                    {
                        if (PTimbrar)
                        {
                            Facturas.frmAdmonFacturasFC objAsignarXML = new Facturas.frmAdmonFacturasFC()
                            {
                                IdSolicitudFactura = pIdSolicitud,
                                IdFactura = pIdFactura
                            };
                            objAsignarXML.ShowDialog();     //mostrar pantalla
                        }
                        else
                        {
                            Facturas.frmAdmonFacturasFCV objAsignarXML = new Facturas.frmAdmonFacturasFCV()
                            {
                                IdSolicitudFactura = pIdSolicitud,
                                IdFactura = pIdFactura
                            };
                            objAsignarXML.ShowDialog();     //mostrar pantalla
                        }

                        dtFechaIni.Value = DateTime.Now.AddDays(-30);
                        dtFechaFin.Value = DateTime.Now;

                        string FIni = Convert.ToDateTime(dtFechaIni.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Day.ToString();
                        string FFin = Convert.ToDateTime(dtFechaFin.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Day.ToString();
                        this.stpFactSelSolicitudFacturasTableAdapter.Fill(dbSAICBPOFactura.stpFactSelSolicitudFacturas, -1, FIni, FFin, OperadorBD.OperadorGlobal.IdOperador);
                    }
                    else
                        XtraMessageBox.Show("¡La solicitud esta en un estatus Cancelado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    XtraMessageBox.Show("¡Debe de Seleccionar una Factura!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDescargarComprobante_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string sRutaArchivosCFDI = "";
                DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                //obtener el renglon completo del Combobox
                if (row != null)
                {
                    //obtener la ruta RAIZ en dónde se almacenarán los archivos PDF y XML
                    string strRutaArchivosXML = this.validacionesGeneralTableAdapter1.ObtenerValorParametro("FOLDER_RECIBOS_PAGOS").ToString();

                    this.stpFactSelComprobantePagoFacturaTableAdapter1.Fill(this.dbSAICBPOFactura.stpFactSelComprobantePagoFactura, Convert.ToInt64(row[0].ToString()));
                    //Crear archivo Comprobante
                    row = this.dbSAICBPOFactura.stpFactSelComprobantePagoFactura.Rows[0];
                    if (row != null)
                    {
                        if (row[2].ToString().Length > 3)
                        {
                            Byte[] bytes = Convert.FromBase64String(row[2].ToString());
                            //Generar carpeta para colocar archivos XML
                            sRutaArchivosCFDI = compNominaCFDI.AccesoIO.ValidarCrearDirectorioCPago(strRutaArchivosXML, row[0].ToString(), compNominaCFDI.AccesoIO.ISO_Date());
                            sRutaArchivosCFDI = string.Format(@"{0}\COMPROBANTE_PAGO.pdf", sRutaArchivosCFDI);
                            File.WriteAllBytes(sRutaArchivosCFDI, bytes);
                            XtraMessageBox.Show("¡El Archivo se descargo Correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            XtraMessageBox.Show("¡La Solicitud no tiene un Comprobante de pago!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        XtraMessageBox.Show("¡La Solicitud no tiene un Comprobante de pago!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("¡Debe de Seleccionar una Factura!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView2_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string category = View.GetRowCellDisplayText(e.RowHandle, View.Columns[30]);
                string IdEstatus = View.GetRowCellDisplayText(e.RowHandle, View.Columns[25]);
                DateTime FechaC = Convert.ToDateTime(category);
                DateTime FechaH = DateTime.Now;
                var Horas = (FechaH - FechaC).TotalMinutes;
                if (IdEstatus != "16" && IdEstatus != "15")
                {
                    e.Appearance.BackColor = Color.White;
                    //e.Appearance.BackColor2 = Color.White;
                }
                else
                {
                    if (Horas <= 24)
                    {
                        e.Appearance.BackColor = Color.White;
                        //e.Appearance.BackColor2 = Color.White;
                    }
                    else if (Horas <= 50)
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
}