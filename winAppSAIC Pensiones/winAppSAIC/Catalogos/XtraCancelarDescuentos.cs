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

namespace winAppSAIC.Catalogos
{
    public partial class XtraCancelarDescuentos : DevExpress.XtraEditors.XtraForm
    {

        private string FIni;
        private string FFin;

        public XtraCancelarDescuentos()
        {
            InitializeComponent();
        }

        private void XtraCancelarDescuentos_Load(object sender, EventArgs e)
        {
            try
            {
                splashSMCargando.ShowWaitForm();

                dtFechaIni.Value = DateTime.Now.AddDays(-30);
                dtFechaFin.Value = DateTime.Now;

                FIni = Convert.ToDateTime(dtFechaIni.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Day.ToString();
                FFin = Convert.ToDateTime(dtFechaFin.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Day.ToString();

                cargaBD();
                splashSMCargando.CloseWaitForm();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                splashSMCargando.CloseWaitForm();
            }

        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void cargaBD()
        {
            this.stpSelObtenerDescuentosFTableAdapter.Fill(dbSAICBPOFactura.stpSelObtenerDescuentosF, FIni, FFin, OperadorBD.OperadorGlobal.NombreUsuario);
        }

       private void btnFiltrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                    FIni = Convert.ToDateTime(dtFechaIni.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Day.ToString();
                    FFin = Convert.ToDateTime(dtFechaFin.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Day.ToString();

                    cargaBD();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnEfiltro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                dtFechaIni.Value = DateTime.Now.AddDays(-30);
                dtFechaFin.Value = DateTime.Now;

                FIni = Convert.ToDateTime(dtFechaIni.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaIni.Text).Day.ToString();
                FFin = Convert.ToDateTime(dtFechaFin.Text).Year.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Month.ToString() + "-" + Convert.ToDateTime(dtFechaFin.Text).Day.ToString();

                cargaBD();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCanDesc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Int64 Id = 0;
            string pResp = "";
            string pRespuesta = "";
            DataRow Row = null;
            try
            {
                if (gridView1.SelectedRowsCount > 0)
                {
                    foreach (int item in gridView1.GetSelectedRows())
                    {
                        Row = gridView1.GetDataRow(item);
                        Id = Convert.ToInt64(Row[0]);

                        this.spSoloRespuesta1.stpUpdDescuentoMasivo(Id,3,OperadorBD.OperadorGlobal.NombreUsuario, ref pResp);

                        if (pRespuesta != "")
                            pRespuesta = pRespuesta +  pResp + "\n";

                    }

                    if (pRespuesta != "")
                    {
                        XtraMessageBox.Show("¡Error!" + pRespuesta , "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        XtraMessageBox.Show("¡El(Los) Descuento(s) se Cancelo(aron) Correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }

                    cargaBD();

                }
                else
                    XtraMessageBox.Show("¡Debe de Seleccionar por lo menos un Descuento!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}