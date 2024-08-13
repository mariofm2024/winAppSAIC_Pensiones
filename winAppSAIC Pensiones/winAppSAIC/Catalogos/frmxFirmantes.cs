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
    public partial class frmxFirmantes : DevExpress.XtraEditors.XtraForm
    {
        Boolean flagActualizar = false;
        Boolean flagGuardar = false;
        public frmxFirmantes()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void frmxFirmantes_Load(object sender, EventArgs e)
        {
            cargarInformacion();

            limpiarObjetos();
        }





        private void cargarInformacion()
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet1.Estatus' table. You can move, or remove it, as needed.
                this.estatusTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet1.Estatus);
                stpSelMatrizTenedoraTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelMatrizTenedora);
                //activarObejetos(false);
                gridLookCliente.Properties.PopupFormWidth = 700;
                gridLookUpEdit1.Properties.PopupFormWidth = 700;

                gridLookCliente.Enabled = true;
                gridLookUpEdit1.Enabled = true;

                flagActualizar = true;
                flagGuardar = false;








                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("No se puede cargar la informacion." + Environment.NewLine + ex, "SAIC"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void activarObejetos(Boolean flatActivar)
        {
            txtNombre.Enabled = flatActivar;
            txtPaterno.Enabled = flatActivar;
            txtMaterno.Enabled = flatActivar;
            //txtRFC.Enabled = flatActivar;
            //txtCURP.Enabled = flatActivar;
            //chBoxAutorizadoFirmaContrato.Enabled = flatActivar;
            rdFirmante.Enabled = flatActivar;
            rdRepresentanteLegal.Enabled = flatActivar;

            if (flatActivar)
            {
                txtNombre.BackColor = Color.White;
                txtPaterno.BackColor = Color.White;
                txtMaterno.BackColor = Color.White;
                //txtRFC.BackColor = Color.White;
                //txtCURP.BackColor = Color.White;
            }
            else
            {
                txtNombre.BackColor = Color.LightGoldenrodYellow;
                txtPaterno.BackColor = Color.LightGoldenrodYellow;
                txtMaterno.BackColor = Color.LightGoldenrodYellow;
                //txtRFC.BackColor = Color.LightGoldenrodYellow;
                //txtCURP.BackColor = Color.LightGoldenrodYellow;
            }
        }

        private void limpiarObejetos()
        {
            txtNombre.Text = String.Empty;
            txtPaterno.Text = String.Empty;
            txtMaterno.Text = String.Empty;
            //txtRFC.Text = String.Empty;
            //txtCURP.Text = String.Empty;
        }

        private void gridLookCliente_EditValueChanged(object sender, EventArgs e)
        {
            actualizarFirmantes();
        }


        private void actualizarFirmantes()
        {
            int idMatrizTenedora;
            int.TryParse(gridLookCliente.EditValue.ToString(), out idMatrizTenedora);
            stpSelInfoRepresentanteLegalTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelInfoRepresentanteLegal, idMatrizTenedora);

            txtIdFirmante.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtPaterno.Text = String.Empty;
            txtMaterno.Text = String.Empty;
            txtRFC.Text = String.Empty;
            txtCurp.Text = String.Empty;
            txtActa.Text = String.Empty;
            txtIdActaConstitutiva.Text = String.Empty;

            this.Refresh();
        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            DataRow unRow = gridView2.GetDataRow(gridView2.FocusedRowHandle);

            //unRow.Table.Rows.Count > 0
            if (unRow != null)
            {
                btnGuardar.Text = "Actualizar";
                objFirmante oFirmante = new objFirmante(unRow);

                txtIdFirmante.Text = oFirmante.idFirmante.ToString();
                txtNombre.Text = oFirmante.sNombre;
                txtPaterno.Text = oFirmante.sAPaterno;
                txtMaterno.Text = oFirmante.sAMaterno;
                txtRFC.Text = oFirmante.sRFC;
                txtCurp.Text = oFirmante.sCURP;
                rdRepresentanteLegal.Checked = oFirmante.flagRepresentanteLegal;
                rdFirmante.Checked = oFirmante.flagFirmante;
                gridLoolEstatus.EditValue = oFirmante.idEstatus;
                txtActa.Text = oFirmante.sActaConstitutiva.Replace("<li>", "").Replace("</li>", "").Replace("<b>", "").Replace("</b>", "");
                oFirmante.flagActualizar = flagActualizar;
                oFirmante.flagAgregar = flagGuardar;

            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnGuardar.Text = "Actualizar";
            gridLoolEstatus.Enabled = true;
            gridLookUpEdit1.Enabled = false;
            btnGuardar.Enabled = true;
            flagActualizar = true;
            flagGuardar = false;
            //btnCancelar.Enabled = true;
            //activarObejetos(true);
        }

        private void toolAgregarFirmante_Click(object sender, EventArgs e)
        {
            btnGuardar.Text = "Guardar";
            flagGuardar = true;
            flagActualizar = false;
            toolAgregarFirmante.Enabled = false;
            gridLookUpEdit1.Enabled = false;
            limpiarObjetos();
        }

        private void limpiarObjetos()
        {
            gridLookUpEdit1.Text = String.Empty;
            gridLookUpEdit1.EditValue = -1;
            txtIdFirmante.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtPaterno.Text = String.Empty;
            txtMaterno.Text = String.Empty;
            txtRFC.Text = String.Empty;
            txtCurp.Text = String.Empty;
            txtActa.Text = String.Empty;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gridLookUpEdit1.Enabled = true;
            btnGuardar.Enabled = false;
            //btnCancelar.Enabled = false;
            gridLoolEstatus.Enabled = false;
            //activarObejetos(false);
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                objFirmante oFirmante = new objFirmante();

                if (flagGuardar)
                {
                    if (Validator.IsPresent(txtNombre) && Validator.IsPositiveOrZeroNumberGrid(gridLookCliente) && Validator.IsPositiveOrZeroNumberGrid(gridLoolEstatus))
                    {
                        oFirmante = ObtenerValores();
                        agregarActualizarFirmante(oFirmante);
                    }
                }
                else if (flagActualizar)
                {
                    if (Validator.IsPresent(txtNombre) && Validator.IsPositiveOrZeroNumberGrid(gridLookCliente) && Validator.IsPositiveOrZeroNumberGrid(gridLookUpEdit1) && Validator.IsPositiveOrZeroNumberGrid(gridLoolEstatus))
                    {
                        oFirmante = ObtenerValores();
                        agregarActualizarFirmante(oFirmante);
                    }
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("No se puede cargar la informacion." + Environment.NewLine + ex, "SAIC"
                   , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void agregarActualizarFirmante(objFirmante oFirmante)
        {
            String sRespuesta = string.Empty;
            oFirmante.sActaConstitutiva = revisarActa(oFirmante.sActaConstitutiva);
            queriesTableAdapter1. stpUpdFirmantes(
                oFirmante.idMatrizTenedora,
                oFirmante.idFirmante,
                oFirmante.sNombre,
                oFirmante.sAPaterno,
                oFirmante.sAMaterno,
                oFirmante.sRFC,
                oFirmante.sCURP,
                oFirmante.idEstatus,
                oFirmante.flagRepresentanteLegal,
                oFirmante.flagFirmante,
                oFirmante.flagAgregar,
                oFirmante.flagActualizar,
                oFirmante.sActaConstitutiva,
                OperadorBD.OperadorGlobal.NombreUsuario,
                ref sRespuesta);

            if (String.IsNullOrEmpty(sRespuesta))
            {
                XtraMessageBox.Show("Informacion guardada con exito", "SAIC"
                                   , MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarInformacion();
                actualizarFirmantes();
                limpiarObjetos();
                toolAgregarFirmante.Enabled = true;
            }
            else
            {
                XtraMessageBox.Show("Error al registrar Firmante, " + sRespuesta, "SAIC"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private String revisarActa(String sActa)
        {
            String sNuevaActa = String.Empty;
            String[] aParraos;
            aParraos = sActa.Split('\n');

            for (int i = 0; i < aParraos.Length; i++)
            {
                if (!String.IsNullOrEmpty(aParraos[i]))
                {
                    if (i == 0)
                    {
                        sNuevaActa = aParraos[i] + Environment.NewLine + Environment.NewLine;
                    }
                    else
                    {
                        sNuevaActa += "<li>" + aParraos[i] + "</li>" + Environment.NewLine + Environment.NewLine;
                    }
                }
            }

            return sNuevaActa;
        }


        private objFirmante ObtenerValores()
        {
            objFirmante oFirmante = new objFirmante();
            oFirmante.idMatrizTenedora = (int)gridLookCliente.EditValue;
            oFirmante.idFirmante = (int)gridLookUpEdit1.EditValue;
            oFirmante.sNombre = txtNombre.Text.Trim();
            oFirmante.sAPaterno = txtPaterno.Text.Trim();
            oFirmante.sAMaterno = txtMaterno.Text.Trim();
            oFirmante.sRFC = txtRFC.Text.Trim();
            oFirmante.sCURP = txtCurp.Text.Trim();
            oFirmante.idEstatus = Convert.ToInt32(gridLoolEstatus.EditValue.ToString());
            oFirmante.flagRepresentanteLegal = rdRepresentanteLegal.Checked;
            oFirmante.flagFirmante = rdFirmante.Checked;
            oFirmante.flagAgregar = flagGuardar;
            oFirmante.flagActualizar = flagActualizar;
            oFirmante.sActaConstitutiva = txtActa.Text.Trim();
            return oFirmante;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            cargarInformacion();
            limpiarObjetos();
            toolAgregarFirmante.Enabled = true;
        }
    }



    public class objFirmante
    {

        public objFirmante()
        {
            idMatrizTenedora = -1;
            idFirmante = -1;
            sNombre = String.Empty;
            sAPaterno = String.Empty;
            sAMaterno = String.Empty;
            sRFC = String.Empty;
            sCURP = String.Empty;
            idEstatus = -1;
            flagRepresentanteLegal = false;
            flagFirmante = false;
            flagAgregar = false;
            flagActualizar = false;
            sActaConstitutiva = String.Empty;
        }

        public objFirmante(DataRow row)
        {
            idMatrizTenedora = Convert.ToInt32(row["idMatrizTenedora"].ToString());
            idFirmante = Convert.ToInt32(row["idRepresentanteLegal"].ToString());
            sNombre = row["Nombre"].ToString();
            sAPaterno = row["Apaterno"].ToString();
            sAMaterno = row["Amaterno"].ToString();
            sRFC = row["RFC"].ToString();
            sCURP = row["CURP"].ToString();
            idEstatus = Convert.ToInt32(row["IdEstatus"].ToString());
            flagRepresentanteLegal = Convert.ToInt32(row["idTipoRepresentanteLegal"].ToString()) == 2 ? true : false;
            flagFirmante = Convert.ToInt32(row["idTipoRepresentanteLegal"].ToString()) == 3 ? true : false;
            flagAgregar = false;
            flagActualizar = false;
            sActaConstitutiva = row["ActaConstitutiva"].ToString();
        }


        public int idMatrizTenedora { get; set; }
        public int idFirmante { get; set; }
        public String sNombre { get; set; }
        public String sAPaterno { get; set; }
        public String sAMaterno { get; set; }
        public String sRFC { get; set; }
        public String sCURP { get; set; }
        public int idEstatus { get; set; }
        public Boolean flagRepresentanteLegal { get; set; }
        public Boolean flagFirmante { get; set; }
        public Boolean flagAgregar { get; set; }
        public Boolean flagActualizar { get; set; }
        public String sActaConstitutiva { get; set; }
    }


}