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
using System.IO;

namespace winAppSAIC.IMSS
{
    public partial class XtraModuloModificacionEmpleados : DevExpress.XtraEditors.XtraForm
    {
        tools.dsc dsc = new tools.dsc();
        ErrorProvider[] erroProviderCampos;
        String[] arrayCampos = new String[] {
            "eNombre",
            "ePaterno",
            "eMaterno",
            "eCURP",
            "eRFC",
            "eNSS",
            "eFunciones"
        };

        int idSolicitud;
        int idEmpleado;
        String stNombre;
        String stPaterno;
        String stMaterno;
        String stCURP;
        String stRFC;
        String stNSS;
        String stSD;
        String stSDI;
        String stFunciones;
        String stTipoContrato;

        public XtraModuloModificacionEmpleados(int idSolicitud, int idEmpleado, String stNombre, String stPaterno, String stMaterno, String stCURP, String stRFC, String stNSS, String stSD, String stSDI, String stFunciones, String stTipoContrato)
        {
            InitializeComponent();
            this.idSolicitud = idSolicitud;
            this.idEmpleado = idEmpleado;
            this.stNombre = stNombre;
            this.stPaterno = stPaterno;
            this.stMaterno = stMaterno;
            this.stCURP = stCURP;
            this.stRFC = stRFC;
            this.stNSS = stNSS;
            this.stSD = stSD;
            this.stSDI = stSDI;
            this.stFunciones = stFunciones;
            this.stTipoContrato = stTipoContrato;
            erroProviderCampos = new ErrorProvider[arrayCampos.Length];
            for (int i = 0; i < arrayCampos.Length; i++) { erroProviderCampos[i] = new ErrorProvider(); }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XtraModuloModificacionEmpleados_Load(object sender, EventArgs e)
        {
            txtidEmpleado.Text = idEmpleado.ToString();
            txtNombre.Text = stNombre;
            txtPaterno.Text = stPaterno;
            txtMaterno.Text = stMaterno;
            txtCURP.Text = stCURP;
            txtRFC.Text = stRFC;
            txtNSS.Text = stNSS;
            txtSD.Text = stSD;
            txtSDI.Text = stSDI;
            mmFunciones.Text = stFunciones;
            txtTipoContrato.Text = stTipoContrato;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                splashScreenManager1.SetWaitFormCaption("Guardando Información");
                splashScreenManager1.SetWaitFormDescription("Espere Por favor...");
                queriesTableAdapter1.stpUpEmpleadoInformacionIMSS(
                     idSolicitud,
                      idEmpleado,
                      txtPaterno.Text.ToUpper().Trim(),
                      txtMaterno.Text.ToUpper().Trim(),
                      txtNombre.Text.ToUpper().Trim(),
                      txtNSS.Text.ToUpper().Trim(),
                      txtRFC.Text.ToUpper().Trim(),
                      txtCURP.Text.ToUpper().Trim(),
                      false,
                      mmFunciones.Text.ToUpper().Trim(),
                      OperadorBD.OperadorGlobal.NombreUsuario,
                      OperadorBD.OperadorGlobal.NombreOperador
                      );

                splashScreenManager1.CloseWaitForm();
                XtraMessageBox.Show("Información del Empleado guardada con Exito."
                      , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                splashScreenManager1.CloseWaitForm();
                XtraMessageBox.Show("No se puede actualizar al Empleado." + Environment.NewLine + ex.Message
                   , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNombre_EditValueChanged(object sender, EventArgs e)
        {
            String stCaracEspeNombre = dsc.contieneCaracteresEspeciales(txtNombre.Text.ToUpper().Trim(), dsc.stCaracteresEspeciales);
            if (!String.IsNullOrEmpty(stCaracEspeNombre))
            {
                erroProviderCampos[0].Icon = Properties.Resources.warning1;
                erroProviderCampos[0].SetError(txtNombre, "Nombre Contiene Caracteres Especiales: " + stCaracEspeNombre);
                btnActualizar.Enabled = false;
            }
            else
            {
                if (!String.IsNullOrEmpty(txtNombre.Text))
                {
                    btnActualizar.Enabled = true;
                }
                else
                {
                    erroProviderCampos[0].Icon = Properties.Resources.warning1;
                    erroProviderCampos[0].SetError(txtNombre, "Nombre No puede ir Vacio" + stCaracEspeNombre);
                    btnActualizar.Enabled = false;
                }
            }
        }

        private void txtPaterno_EditValueChanged(object sender, EventArgs e)
        {
            String stCaracEspePaterno = dsc.contieneCaracteresEspeciales(txtPaterno.Text.ToUpper().Trim(), dsc.stCaracteresEspeciales);
            if (!String.IsNullOrEmpty(stCaracEspePaterno))
            {
                erroProviderCampos[1].Icon = Properties.Resources.warning1;
                erroProviderCampos[1].SetError(txtPaterno, "Apellido Paterno Contiene Caracteres Especiales: " + stCaracEspePaterno);
                btnActualizar.Enabled = false;
            }
            else
            {
                btnActualizar.Enabled = true;
            }
        }

        private void txtMaterno_EditValueChanged(object sender, EventArgs e)
        {
            String stCaracEspeMaterno = dsc.contieneCaracteresEspeciales(txtMaterno.Text.ToUpper().Trim(), dsc.stCaracteresEspeciales);
            if (!String.IsNullOrEmpty(stCaracEspeMaterno))
            {
                erroProviderCampos[2].Icon = Properties.Resources.warning1;
                erroProviderCampos[2].SetError(txtMaterno, "Apellido Materno Contiene Caracteres Especiales: " + stCaracEspeMaterno);
                btnActualizar.Enabled = false;
            }
            else
            {
                btnActualizar.Enabled = true;
            }
        }

        private void txtCURP_EditValueChanged(object sender, EventArgs e)
        {
            String stCaracEspeCURP = dsc.contieneCaracteresEspeciales(txtCURP.Text.ToUpper().Trim(), dsc.stCaracteresEspeciales);
            if (!String.IsNullOrEmpty(stCaracEspeCURP))
            {
                erroProviderCampos[3].Icon = Properties.Resources.warning1;
                erroProviderCampos[3].SetError(txtCURP, "CURP Contiene Caracteres Especiales: " + stCaracEspeCURP);
                btnActualizar.Enabled = false;
            }
            else
            {
                if (!String.IsNullOrEmpty(txtCURP.Text))
                {
                    btnActualizar.Enabled = true;
                }
                else
                {
                    erroProviderCampos[3].Icon = Properties.Resources.warning1;
                    erroProviderCampos[3].SetError(txtCURP, "CURP No puede ir Vacio");
                    btnActualizar.Enabled = false;
                }
            }
        }

        private void txtRFC_EditValueChanged(object sender, EventArgs e)
        {
            String stCaracEspeRFC = dsc.contieneCaracteresEspeciales(txtRFC.Text.ToUpper().Trim(), dsc.stCaracteresEspeciales);
            if (!String.IsNullOrEmpty(stCaracEspeRFC))
            {
                erroProviderCampos[5].Icon = Properties.Resources.warning1;
                erroProviderCampos[5].SetError(txtRFC, "RFC Contiene Caracteres Especiales: " + stCaracEspeRFC);
                btnActualizar.Enabled = false;
            }
            else
            {
                btnActualizar.Enabled = true;
            }
        }

        private void txtNSS_EditValueChanged(object sender, EventArgs e)
        {
            String stCaracEspeNSS = dsc.contieneCaracteresEspeciales(txtNSS.Text.ToUpper().Trim(), dsc.stCaracteresEspeciales);
            if (!String.IsNullOrEmpty(stCaracEspeNSS))
            {
                erroProviderCampos[4].Icon = Properties.Resources.warning1;
                erroProviderCampos[4].SetError(txtNSS, "NSS Contiene Caracteres Especiales: " + stCaracEspeNSS);
                btnActualizar.Enabled = false;
            }
            else
            {
                btnActualizar.Enabled = true;
            }
        }

        private void mmFunciones_EditValueChanged(object sender, EventArgs e)
        {
            String stCaracEspeFuncionnes = dsc.contieneCaracteresEspeciales(mmFunciones.Text.ToUpper().Trim(), dsc.stCaracteresEspeciales);
            if (!String.IsNullOrEmpty(stCaracEspeFuncionnes))
            {
                erroProviderCampos[6].Icon = Properties.Resources.warning1;
                erroProviderCampos[6].SetError(mmFunciones, "Nombre Contiene Caracteres Especiales: " + stCaracEspeFuncionnes);
                btnActualizar.Enabled = false;
            }
            else
            {
                btnActualizar.Enabled = true;
            }
        }

        private void toolSubirAfil_Click(object sender, EventArgs e)
        {
            String stRutaContrato = String.Empty;
            String stValorDocumento = String.Empty;

            XtraMessageBox.Show("Por favor seleccione el Contrato del Empleado."
           , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

            OpenFileDialog ofdSelecFile = new OpenFileDialog();
            ofdSelecFile.Filter = "Pdf Files| *.pdf";
            ofdSelecFile.Title = "SAIC | Seleccione Contrato";
            ofdSelecFile.Multiselect = false;
            ofdSelecFile.ShowDialog();

            stRutaContrato = ofdSelecFile.FileName;

            if (!String.IsNullOrEmpty(stRutaContrato))
            {
                splashScreenManager1.ShowWaitForm();
                splashScreenManager1.SetWaitFormCaption("Cargando AFIL");

                stValorDocumento = dsc.ConvertToBytes(stRutaContrato);
                if (!String.IsNullOrEmpty(stValorDocumento))
                {
                    FileInfo miArchivo = new FileInfo(stRutaContrato);
                    if (miArchivo.Length <= 1000000)
                    {

                        try
                        {
                            queriesTableAdapter1.stpInsDocumentoEmpleados(
                                                    idEmpleado,
                                                    stValorDocumento,
                                                   "pdf",
                                                   3,
                                                   OperadorBD.OperadorGlobal.NombreUsuario
                                                   );
                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show("No se puede guardar en el archivo en el servidor." + Environment.NewLine + ex.Message
                            , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        XtraMessageBox.Show("Archivo guardado con Exito"
                           , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        splashScreenManager1.CloseWaitForm();
                    }
                    else
                    {
                        XtraMessageBox.Show("El Archivo no debe exceder de 1,000 KB"
                         , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    XtraMessageBox.Show("No se puede convertir el Archivo para Subir."
                    , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
