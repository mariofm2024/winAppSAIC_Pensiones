using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using compCatalogosSAIC;

namespace winAppSAIC.Tesoreria
{
    public partial class frmxMonitoreoSolicitudChequesMasivos : DevExpress.XtraEditors.XtraForm
    {
        public frmxMonitoreoSolicitudChequesMasivos()
        {
            InitializeComponent();
        }

        #region "Variables Globales"
        InfoSolicitudChequeHeader objInfoDetalleSolicitudChequeMasivo = null;
        #endregion

        #region "Metodos Propios"
        private InfoSolicitudChequeHeader ObtenerInfoSolicitudChequeMasivo()
        {
            //si el usuario seleccionó un renglon, entonces regresar el valor IdTransaccionBanco
            if (gridView1.FocusedRowHandle >= 0)
            {
                //obtener la información del renglon completo
                DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                //asignar InfoDetalle Solicitud Cheque Masivo
                return InfoSolicitudChequeHeaderBD.ObtenerInfoDetalleSolicitudChequeMasivo(row);
            }
            else
                return null;       //si no se ha seleccionado un renglon válido, entonces regresar 0
        }

        #endregion


        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();    //cerrar pantalla
        }

        private void frmxVisualizarSolicitudChequesMasivos_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dbSAICBPOTesoreriaDataSet.stpSelSolicitudesChequesMasivos' table. You can move, or remove it, as needed.
                this.stpSelSolicitudesChequesMasivosTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.stpSelSolicitudesChequesMasivos);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvSolicitudChequesMasivos_DoubleClick(object sender, EventArgs e)
        {
            bool? bFlagBloqueado = false;
            string sUsuario = "";

            objInfoDetalleSolicitudChequeMasivo = ObtenerInfoSolicitudChequeMasivo();
            try
            {
                if (objInfoDetalleSolicitudChequeMasivo != null)
                {
                    //OBTENER ESTATUS BLOQUEADO
                    this.actualizacionesTesoreriaTableAdapter1.stpSelEstatusBloqueado(objInfoDetalleSolicitudChequeMasivo.IdSolicitudChequeHeader, ref bFlagBloqueado, ref sUsuario);

                    //SI EL ESTATUS BLOQUEADO = FALSE
                    if (bFlagBloqueado.Equals(false))
                    {
                        //BLOQUEAR REGISTRO EN CASO DE NO ESTAR SELECCIONADO POR TESORERO
                        this.actualizacionesTesoreriaTableAdapter1.stpUpdEstatusBloqueado(objInfoDetalleSolicitudChequeMasivo.IdSolicitudChequeHeader, OperadorBD.OperadorGlobal.NombreUsuario, true, 16);
                        Tesoreria.frmxGenerarChequesMasivos2Tesoreria objForm = new frmxGenerarChequesMasivos2Tesoreria() { objInfoDetalle = objInfoDetalleSolicitudChequeMasivo };
                        objForm.ShowDialog();       //mostrar pantalla

                        // Cargar nuevamente el Gridview
                        this.stpSelSolicitudesChequesMasivosTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.stpSelSolicitudesChequesMasivos);
                    }
                    else
                        XtraMessageBox.Show(string.Format("La solicitud No. {0} está siendo procesada por el usuario {1}", objInfoDetalleSolicitudChequeMasivo.IdSolicitudChequeHeader, sUsuario), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarSolicitud_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool? bFlagBloqueado = false;
            string sUsuario = "";

            try
            {
                objInfoDetalleSolicitudChequeMasivo = ObtenerInfoSolicitudChequeMasivo();       //obtener informacion de la Solicitud Cheque Masivo

                if (objInfoDetalleSolicitudChequeMasivo != null)
                {
                    //OBTENER ESTATUS BLOQUEADO
                    this.actualizacionesTesoreriaTableAdapter1.stpSelEstatusBloqueado(objInfoDetalleSolicitudChequeMasivo.IdSolicitudChequeHeader, ref bFlagBloqueado, ref sUsuario);

                    //SI EL ESTATUS BLOQUEADO = FALSE
                    if (bFlagBloqueado.Equals(false))
                    {
                        DialogResult objFormConfirm = XtraMessageBox.Show(string.Format("¿Desea cancelar la Solicitud No. {0}?", objInfoDetalleSolicitudChequeMasivo.IdSolicitudChequeHeader), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                        if (objFormConfirm == DialogResult.Yes)
                        {
                            //borrar solicitud de Cheques Masivos
                            this.actualizacionesTesoreriaTableAdapter1.stpDelSolicitudChequeHeader(objInfoDetalleSolicitudChequeMasivo.IdSolicitudChequeHeader);

                            // Cargar nuevamente el Gridview
                            this.stpSelSolicitudesChequesMasivosTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.stpSelSolicitudesChequesMasivos);

                            XtraMessageBox.Show(string.Format("La Solicitud No. {0} ha sido eliminada.", objInfoDetalleSolicitudChequeMasivo.IdSolicitudChequeHeader), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show(string.Format("La Solicitud No. {0} está siendo procesada por el usuario {1}.\n¡No puede eliminarla!", objInfoDetalleSolicitudChequeMasivo.IdSolicitudChequeHeader, sUsuario), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }

                }
                else
                    XtraMessageBox.Show("¡Para cancelar debe seleccionar un No. de Solicitud!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}