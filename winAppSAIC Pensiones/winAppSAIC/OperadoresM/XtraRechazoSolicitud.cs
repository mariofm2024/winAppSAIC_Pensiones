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
    public partial class XtraRechazoSolicitud : DevExpress.XtraEditors.XtraForm
    {
        int iIdEmpleado;
        int idSolicitud;
        String stNombreCompletoEmpleado;
        String stRechazo;
        String stArea;
        DataTable dtEmpleadosPorAtender;
        ErrorProvider erroProviderCampos = new ErrorProvider();
        tools.dsc dsc = new tools.dsc();

        public XtraRechazoSolicitud(DataTable dtEmpleadosPorAtender, int idSolicitud, int iIdEmpleado, String stArea, String stNombreCompletoEmpleado, String stRechazo)
        {
            InitializeComponent();
            this.iIdEmpleado = iIdEmpleado;
            this.stNombreCompletoEmpleado = stNombreCompletoEmpleado;
            this.stRechazo = stRechazo;
            this.idSolicitud = idSolicitud;
            this.stArea = stArea;
            this.dtEmpleadosPorAtender = dtEmpleadosPorAtender;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = XtraMessageBox.Show("¿Seguro que quiere Rechazar toda la Solicitud " + idSolicitud + "?" + Environment.NewLine +
                "Todos los registros se actualizaran con el mismo comentario de Rechazo."
                , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                int iConta = 0;
                int iContaNoSubidos = 0;
                if (!String.IsNullOrEmpty(memoRechazo.Text))
                {
                    foreach (DataRow unRow in dtEmpleadosPorAtender.Rows)
                    {
                        int idEmpleado;
                        String stRechazo = String.Empty;
                        stRechazo = memoRechazo.Text.ToUpper().Trim();

                        int.TryParse(unRow["IdEmpleado"].ToString(), out idEmpleado);

                        queriesTableAdapter1.stpUpdAltaEmpleadosGenerarRechazo(
                            stArea, 
                            idSolicitud, 
                            idEmpleado, 
                            stRechazo, 
                            OperadorBD.OperadorGlobal.NombreUsuario,
                            OperadorBD.OperadorGlobal.NombreOperador);
                        iConta++;

                    }
                    XtraMessageBox.Show("Solicitud Rechazada:" + Environment.NewLine +
                    "Empleados Rechazados: " + iConta + Environment.NewLine
                    , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("El comentario de Rechazo NO puede estar Vacio."
              , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
        }

        private void XtraRechazoSolicitud_Load(object sender, EventArgs e)
        {
            txtidEmpleado.Text = iIdEmpleado.ToString();
            txtNombreCompletoEmpleado.Text = stNombreCompletoEmpleado;
            memoRechazo.Text = stRechazo;
        }

        private void btnSolicitudRechazada_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(memoRechazo.Text))
            {
                try
                {
                    stRechazo = memoRechazo.Text.ToUpper().Trim();
                    queriesTableAdapter1.stpUpdAltaEmpleadosGenerarRechazo(
                              stArea,
                              idSolicitud,
                              iIdEmpleado,
                              stRechazo,
                              OperadorBD.OperadorGlobal.NombreUsuario,
                              OperadorBD.OperadorGlobal.NombreOperador);

                    XtraMessageBox.Show("Empleado rechazado."
               , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("No se puede rechazar al Empleado. " + Environment.NewLine + ex.Message
                    , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                XtraMessageBox.Show("El comentario de Rechazo NO puede estar Vacio."
            , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void memoRechazo_EditValueChanged(object sender, EventArgs e)
        {
            String stCaracEspeNombre = dsc.contieneCaracteresEspeciales(memoRechazo.Text.ToUpper().Trim(), dsc.stCaracteresEspeciales);
            if (!String.IsNullOrEmpty(stCaracEspeNombre))
            {
                erroProviderCampos.Icon = Properties.Resources.warning1;
                erroProviderCampos.SetError(memoRechazo, "Rechazo Contiene Caracteres Especiales: " + stCaracEspeNombre);
                btnRechazar.Enabled = false;
            }
            else
            {
                erroProviderCampos.Clear();
                btnRechazar.Enabled = true;
            }
        }
    }
}