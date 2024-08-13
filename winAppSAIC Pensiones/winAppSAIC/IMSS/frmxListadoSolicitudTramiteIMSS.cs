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
using compIMSS;

namespace winAppSAIC.IMSS
{
    public partial class frmxListadoSolicitudTramiteIMSS : DevExpress.XtraEditors.XtraForm
    {
        public frmxListadoSolicitudTramiteIMSS()
        {
            InitializeComponent();
        }

        #region "Variables Globales"

        private SolicitudTramite objInfoDetalleSolicitudTramiteIMSS;

        #endregion

        #region "Metodos Propios"

        private SolicitudTramite ObtenerIdSolicitudTramiteIMSS()
        {
            //si el usuario seleccionó un renglon, entonces regresar el valor IdTransaccionBanco
            if (gridView1.FocusedRowHandle >= 0)
            {
                //obtener la información del renglon completo
                DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                //asignar el IdTransaccionBanco
                return InfoDetalleSolicitudTramiteBD.ObtenerInfoDetalleSolicitudTramiteIMSS(row);
            }
            else
                return null;       //si no se ha seleccionado un renglon válido, entonces regresar 0
        }
        #endregion

        private void frmxListadoSolicitudTramiteIMSS_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dbSAICBPODataSet.vwListadoSolicitudTramiteIMSS' table. You can move, or remove it, as needed.
                this.vwListadoSolicitudTramiteIMSSTableAdapter.Fill(this.dbSAICBPODataSet.vwListadoSolicitudTramiteIMSS);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();        //cerrar pantalla
        }

        private void vwListadoSolicitudTramiteIMSSGridControl_DoubleClick(object sender, EventArgs e)
        {
            //crear objeto con detalle de la Solicitud Tramite del renglon seleccionado
            objInfoDetalleSolicitudTramiteIMSS = ObtenerIdSolicitudTramiteIMSS();

            if (objInfoDetalleSolicitudTramiteIMSS != null)     //validar que exista informacion Solicitud Tramite IMSS
            {
                IMSS.frmxControlSolicitudTramiteIMSS objControlSolicitudTramiteIMSS = new IMSS.frmxControlSolicitudTramiteIMSS();
                //trasladar Detalle Solicitud Tramite IMSS a la pantalla
                objControlSolicitudTramiteIMSS.objSolicitudTramiteIMSS = objInfoDetalleSolicitudTramiteIMSS;
                if (objControlSolicitudTramiteIMSS.ShowDialog() == System.Windows.Forms.DialogResult.OK)   //mostrar pantalla
                    this.vwListadoSolicitudTramiteIMSSTableAdapter.Fill(this.dbSAICBPODataSet.vwListadoSolicitudTramiteIMSS);
            }
        }
    }
}