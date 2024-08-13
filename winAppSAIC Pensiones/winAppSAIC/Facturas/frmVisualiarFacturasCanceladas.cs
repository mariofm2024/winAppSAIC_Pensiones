using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;        //namespace a partir version 12.2.4
using DevExpress.XtraPrinting;
using compCatalogosSAIC;
using winAppSAIC.UtileriasLocal;
using System.IO;
using winAppSAIC.ReportesCFDI;

namespace winAppSAIC.Facturas
{
    public partial class frmVisualiarFacturasCanceladas : DevExpress.XtraEditors.XtraForm
    {
        private string FIni, FFin, sUUID = "";
        private int iEstatus = 1;

        private bool PTimbrar = false; //Habilitar
        private bool PContabilizar = false; //Actualizar
        public frmVisualiarFacturasCanceladas()
        {
            InitializeComponent();
        }
        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close(); //SALIR
        }

        public void ObtenerFechas ()
        {
            if (cbEstatus.EditValue.ToString() == "Proceso")
                iEstatus = 1;
            else
                iEstatus = 0;

            FIni = Convert.ToDateTime(dtFechaIni.EditValue).Year.ToString() + "-" + Convert.ToDateTime(dtFechaIni.EditValue).Month.ToString() + "-" + Convert.ToDateTime(dtFechaIni.EditValue).Day.ToString();
            FFin = Convert.ToDateTime(dtFechaFin.EditValue).Year.ToString() + "-" + Convert.ToDateTime(dtFechaFin.EditValue).Month.ToString() + "-" + Convert.ToDateTime(dtFechaFin.EditValue).Day.ToString();
            sUUID = txtUUIDs.EditValue.ToString();
        }

        private void frmVisualiarFacturasCanceladas_Load(object sender, EventArgs e)
        {
            try
            {
                splashSMCargando.ShowWaitForm();

                dtFechaIni.EditValue = DateTime.Now.AddDays(-30);
                dtFechaFin.EditValue = DateTime.Now;

                ObtenerFechas();

                ///Activar Botones 
                this.stpFactSelHeaderFacturasCancelarTableAdapter.Fill(dbSAICBPOFactura.stpFactSelHeaderFacturasCancelar, 1, FIni, FFin, sUUID, OperadorBD.OperadorGlobal.IdOperador);

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
                ObtenerFechas();
                this.stpFactSelHeaderFacturasCancelarTableAdapter.Fill(dbSAICBPOFactura.stpFactSelHeaderFacturasCancelar, iEstatus, FIni, FFin, sUUID, OperadorBD.OperadorGlobal.IdOperador);
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
                //cbEstatus.EditValue = -1;
                dtFechaIni.EditValue = DateTime.Now.AddDays(-30);
                dtFechaFin.EditValue = DateTime.Now;
                cbEstatus.EditValue = "Proceso";
                ObtenerFechas();
                this.stpFactSelHeaderFacturasCancelarTableAdapter.Fill(dbSAICBPOFactura.stpFactSelHeaderFacturasCancelar, iEstatus, FIni, FFin, "", OperadorBD.OperadorGlobal.IdOperador);
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
                    Facturas.frmRechazarSolicitud objAsignarXML = new Facturas.frmRechazarSolicitud()
                    {
                        pIdSolicitud = Id
                    };
                    objAsignarXML.ShowDialog();     //mostrar pantalla

                    //cbEstatus.EditValue = -1;
                    dtFechaIni.EditValue = DateTime.Now.AddDays(-30);
                    dtFechaIni.EditValue = DateTime.Now;
                    ObtenerFechas();
                    this.stpFactSelHeaderFacturasCancelarTableAdapter.Fill(dbSAICBPOFactura.stpFactSelHeaderFacturasCancelar, 28, FIni, FFin, sUUID, OperadorBD.OperadorGlobal.IdOperador);

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
                    Facturas.frmCancelarSolicitud objAsignarXML = new Facturas.frmCancelarSolicitud()
                    {
                        pIdSolicitud = Id
                    };
                    objAsignarXML.ShowDialog();     //mostrar pantalla

                    //cbEstatus.EditValue = -1;
                    dtFechaIni.EditValue = DateTime.Now.AddDays(-30);
                    dtFechaIni.EditValue = DateTime.Now;
                    ObtenerFechas();
                    this.stpFactSelHeaderFacturasCancelarTableAdapter.Fill(dbSAICBPOFactura.stpFactSelHeaderFacturasCancelar, 28, FIni, FFin, sUUID, OperadorBD.OperadorGlobal.IdOperador);

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
                    pIdSolicitud = Convert.ToInt64(row[1].ToString());
                    pIdFactura = Convert.ToInt64(row[0].ToString());

                    if (iEstatus == 0)
                    {
                        Facturas.frmAdmonFacturasFCV objAsignarXML = new Facturas.frmAdmonFacturasFCV()
                        {
                            IdSolicitudFactura = pIdSolicitud,
                            IdFactura = pIdFactura
                        };
                        objAsignarXML.ShowDialog();     //mostrar pantalla
                    }
                    else
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
                    }
                
                    dtFechaIni.EditValue = DateTime.Now.AddDays(-30);
                    dtFechaFin.EditValue = DateTime.Now;

                    ObtenerFechas();
                    this.stpFactSelHeaderFacturasCancelarTableAdapter.Fill(dbSAICBPOFactura.stpFactSelHeaderFacturasCancelar, 28, FIni, FFin, sUUID, OperadorBD.OperadorGlobal.IdOperador);
                }
                else
                    XtraMessageBox.Show("¡Debe de Seleccionar una Factura!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}