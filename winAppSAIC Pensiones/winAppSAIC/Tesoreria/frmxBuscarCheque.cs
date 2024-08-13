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

namespace winAppSAIC.Tesoreria
{
    public partial class frmxBuscarCheque : DevExpress.XtraEditors.XtraForm
    {
        #region "Propiedades propias"
        //propiedad que se utiliza para obtener el IdCuentaBanco de la pantalla frmxBuscarCheque
        public Int32 IdCuentaBanco
        {
            get;
            set;
        }

        //propiedad que se utiliza para obtener el Año de Transaccion de la pantalla frmxBuscarCheque
        public Int32 AnoTransaccion
        {
            get;
            set;
        }

        //propiedad que almacena el IdTransaccionBanco == Folio Movimiento seleccionado del GridView
        public InfoDetalleTransaccionBanco InfoDetalleChequeEmitido
        {
            get;
            set;
        }
        #endregion

        private InfoDetalleTransaccionBanco ObtenerIdTransaccionBanco()
        {
            //si el usuario seleccionó un renglon, entonces regresar el valor IdTransaccionBanco
            if (gridView1.FocusedRowHandle >= 0)
            {
                //obtener la información del renglon completo
                DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                //asignar el IdTransaccionBanco
                return InfoDetalleTransaccionBancoBD.ObtenerInfoDetalleCheque(row);
            }
            else
                return null;       //si no se ha seleccionado un renglon válido, entonces regresar 0
        }

        public frmxBuscarCheque()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;        //cancelar pantalla
            //this.Close();       //cerrar pantalla
        }

        private void frmxBuscarCheque_Load(object sender, EventArgs e)
        {
            try
            {
                this.stpSelRelacionChequesTableAdapter.Fill(this.dbSAICBPOTesoreriaDataSet.stpSelRelacionCheques,IdCuentaBanco, AnoTransaccion);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvFoliosCheques_DoubleClick(object sender, EventArgs e)
        {
            //crear objeto con detalle de cheque del renglon seleccionado
            InfoDetalleChequeEmitido = ObtenerIdTransaccionBanco();     
            //cerrar pantalla con estatus OK
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}