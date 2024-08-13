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

namespace winAppSAIC.OperadoresM
{
    public partial class XtraEmpleadoExcepcionAcumulado : DevExpress.XtraEditors.XtraForm
    {
        EmpleadoExcepcionAcumulado oEmpleadoExcepcionAcumulado = new EmpleadoExcepcionAcumulado();
        ErrorProvider errorLimiteAcumulado = new ErrorProvider();
        ErrorProvider errorLimiteMensual = new ErrorProvider();
        ErrorProvider errorLimiteRegistro = new ErrorProvider();

        public XtraEmpleadoExcepcionAcumulado()
        {
            InitializeComponent();
        }

        private void toolBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XtraEmpleadoExcepcionAcumulado_Load(object sender, EventArgs e)
        {
            try
            {
                inicializarDatos();
            }
            catch (Exception ex)
            {
                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                XtraMessageBox.Show("Error: " + ex.Message, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void inicializarDatos()
        {
            splashScreenManager1.ShowWaitForm();

            btnGuardar.Enabled = false;
            this.stpSelEmpleadosEnAltaoBajaTableAdapter1.Fill(this.dbSAICBPOCatalogosDataSet1.stpSelEmpleadosEnAltaoBaja, 1);
            obtenerDatosParametros();
            borrarDatos();

            cboIdEmpleado.Properties.View.BestFitColumns();
            cboIdEmpleado.Properties.PopupFormWidth = 700;
            habilitarElementos(false);
            if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
        }

        //Obtener 
        private void obtenerDatosParametros()
        {
            stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "LIMITE_ACUMULADO");
            if (dbSAICBPOValidacionDataSet1.stpSelParametro.Count > 0)
            {
                decimal dcLimiteAcumuladoParametro = 0;
                decimal.TryParse(dbSAICBPOValidacionDataSet1.stpSelParametro.Rows[0]["ValorParametro"].ToString(), out dcLimiteAcumuladoParametro);
                oEmpleadoExcepcionAcumulado.dcLimiteAcumuladoParametro = dcLimiteAcumuladoParametro;
            }
            else
            {
                oEmpleadoExcepcionAcumulado.dcLimiteAcumuladoParametro = 10000.00m;
            }

            stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "LIMITE_MENSUAL");
            if (dbSAICBPOValidacionDataSet1.stpSelParametro.Count > 0)
            {
                decimal dcLimiteMensualParametro = 0;
                decimal.TryParse(dbSAICBPOValidacionDataSet1.stpSelParametro.Rows[0]["ValorParametro"].ToString(), out dcLimiteMensualParametro);
                oEmpleadoExcepcionAcumulado.dcLimiteMensualParametro = dcLimiteMensualParametro;
            }
            else
            {
                oEmpleadoExcepcionAcumulado.dcLimiteMensualParametro = 210000.00m;
            }


            stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "LIMITE_REGISTRO");
            if (dbSAICBPOValidacionDataSet1.stpSelParametro.Count > 0)
            {
                decimal dcLimiteRegistroParametro = 0;
                decimal.TryParse(dbSAICBPOValidacionDataSet1.stpSelParametro.Rows[0]["ValorParametro"].ToString(), out dcLimiteRegistroParametro);
                oEmpleadoExcepcionAcumulado.dcLimiteRegistroParametro = dcLimiteRegistroParametro;
            }
            else
            {
                oEmpleadoExcepcionAcumulado.dcLimiteRegistroParametro = 210000.00m;
            }


        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            borrarDatos();
            habilitarElementos(false);
        }

        private void borrarDatos()
        {
            txtLimiteAcumulado.Text = "0";
            txtLimiteMensual.Text = "0";
            txtLimiteRegistro.Text = "0";
        }
        private void habilitarElementos(Boolean flagActivar)
        {
            txtLimiteAcumulado.Enabled = flagActivar;
            txtLimiteMensual.Enabled = false;
            txtLimiteRegistro.Enabled = false;
        }

        private void cboIdEmpleado_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtLimiteAcumulado_EditValueChanged(object sender, EventArgs e)
        {

            if (txtLimiteAcumulado.Enabled)
            {
                decimal dcLimiteAcumulado = 0;
                decimal.TryParse(txtLimiteAcumulado.Text.Replace("$", ""), out dcLimiteAcumulado);

                if (dcLimiteAcumulado < oEmpleadoExcepcionAcumulado.dcLimiteAcumuladoParametro)
                {
                    errorLimiteAcumulado.Icon = Properties.Resources.warning1;
                    errorLimiteAcumulado.SetError(txtLimiteAcumulado, "Importe no puede ser menor a " + oEmpleadoExcepcionAcumulado.dcLimiteAcumuladoParametro.ToString("$#,###.00"));
                    oEmpleadoExcepcionAcumulado.flagLimiteAcumulado = false;
                }
                else
                {
                    errorLimiteAcumulado.Clear();
                    oEmpleadoExcepcionAcumulado.flagLimiteAcumulado = true;
                    oEmpleadoExcepcionAcumulado.dcLimiteAcumulado = dcLimiteAcumulado;

                }

                if (oEmpleadoExcepcionAcumulado.flagLimiteAcumulado)
                {
                    btnGuardar.Enabled = true;
                }
                else
                {
                    btnGuardar.Enabled = false;
                }
            }
        }

        private void txtLimiteMensual_EditValueChanged(object sender, EventArgs e)
        {
            if (txtLimiteMensual.Enabled)
            {
                if (oEmpleadoExcepcionAcumulado.flagLimiteAcumulado)
                {
                    btnGuardar.Enabled = true;
                }
                else
                {
                    btnGuardar.Enabled = false;
                }
            }
        }

        private void txtLimiteRegistro_EditValueChanged(object sender, EventArgs e)
        {
            if (txtLimiteRegistro.Enabled)
            {
                if (oEmpleadoExcepcionAcumulado.flagLimiteAcumulado)
                {
                    btnGuardar.Enabled = true;
                }
                else
                {
                    btnGuardar.Enabled = false;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            DialogResult oDialogResult = XtraMessageBox.Show("¿Esta seguro de guardar la informacion del empleado " + oEmpleadoExcepcionAcumulado.idEmpleado + " - " + cboIdEmpleado.Text + "?", "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (DialogResult.Yes == oDialogResult)
            {
                splashScreenManager1.ShowWaitForm();
                String stRespuesta = String.Empty;

                queriesTableAdapter1.stpupdEmpleadoExcepcionAcumulado(
                   oEmpleadoExcepcionAcumulado.idEmpleado,
                   oEmpleadoExcepcionAcumulado.dcLimiteAcumulado,
                   oEmpleadoExcepcionAcumulado.flagGuardar,
                   OperadorBD.OperadorGlobal.NombreUsuario,
                   ref stRespuesta
                   );

                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }

                XtraMessageBox.Show(stRespuesta, "SAIC", MessageBoxButtons.OK,
                    stRespuesta.Contains("Error") ? MessageBoxIcon.Error : MessageBoxIcon.Information);

                if (!stRespuesta.Contains("Error")) // Si es Ok el cambio
                {
                    inicializarDatos();
                }

            }
        }

        private void cboIdEmpleado_EditValueChanged_1(object sender, EventArgs e)
        {
            habilitarElementos(true);
            borrarDatos();
            oEmpleadoExcepcionAcumulado.idEmpleado = (int)cboIdEmpleado.EditValue;
            stpSelEmpleadoExcepcionAcumuladoTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelEmpleadoExcepcionAcumulado, oEmpleadoExcepcionAcumulado.idEmpleado);
            if (dbSAICBPOCatalogosDataSet1.stpSelEmpleadoExcepcionAcumulado.Rows.Count > 0)
            {
                decimal dcImorteAcumulado = 0;
                btnGuardar.Text = "Actualizar";
                oEmpleadoExcepcionAcumulado.flagActualizar = true;
                oEmpleadoExcepcionAcumulado.flagGuardar = false;
                decimal.TryParse(dbSAICBPOCatalogosDataSet1.stpSelEmpleadoExcepcionAcumulado.Rows[0]["ImporteLimiteAcumuladoAlimentos"].ToString(), out dcImorteAcumulado);
                txtLimiteAcumulado.Text = dcImorteAcumulado.ToString("$#,##0.00");
            }
            else
            {
                btnGuardar.Text = "Guardar";
                oEmpleadoExcepcionAcumulado.flagGuardar = true;
                oEmpleadoExcepcionAcumulado.flagActualizar = false;
                txtLimiteAcumulado.Text = oEmpleadoExcepcionAcumulado.dcLimiteAcumuladoParametro.ToString("$#,##0.00");
                txtLimiteMensual.Text = oEmpleadoExcepcionAcumulado.dcLimiteMensualParametro.ToString("$#,##0.00");
                txtLimiteRegistro.Text = oEmpleadoExcepcionAcumulado.dcLimiteRegistroParametro.ToString("$#,##0.00");
            }

            btnGuardar.Enabled = true;
        }
    }


    public class EmpleadoExcepcionAcumulado
    {
        public EmpleadoExcepcionAcumulado()
        {
            idEmpleado = 0;
            dcLimiteAcumuladoParametro = 0;
            dcLimiteMensualParametro = 0;
            dcLimiteRegistroParametro = 0;
            dcLimiteAcumulado = 0;
            flagGuardar = false;
            flagActualizar = false;
            flagLimiteAcumulado = false;
            flagLimiteMensual = false;
            flagLimiteRegistro = false;
        }

        public int idEmpleado { get; set; }

        public decimal dcLimiteAcumuladoParametro { get; set; }
        public decimal dcLimiteMensualParametro { get; set; }
        public decimal dcLimiteRegistroParametro { get; set; }

        public decimal dcLimiteAcumulado { get; set; }

        public Boolean flagLimiteAcumulado { get; set; }
        public Boolean flagLimiteMensual { get; set; }
        public Boolean flagLimiteRegistro { get; set; }


        public Boolean flagGuardar { get; set; }
        public Boolean flagActualizar { get; set; }

    }
}