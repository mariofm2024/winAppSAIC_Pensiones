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
    public partial class frmxImpresionChequesMasivos : DevExpress.XtraEditors.XtraForm
    {
        public frmxImpresionChequesMasivos()
        {
            InitializeComponent();
        }

        #region "Propiedades"
        public string TipoImpresora { get; set; }
        public Int32 IdCuentaBanco { get; set; }
        public string NombreCuentaBanco { get; set; }
        public Int64 IdTransaccionBancoInicial { get; set; }
        public Int64 IdTransaccionBancoFinal { get; set; }
        public string NoChequeInicial { get; set; }
        public string NoChequeFinal { get; set; }

        #endregion

        #region "Metodos Propios"
        /// <summary>
        /// Método para Obtener las impresoras instaladas en el equipo actual
        /// y llenar combobox con modelos HP y EPSON
        /// </summary>
        private void CargarImpresorasAutorizadas()
        {
            int intNoImpresoras = System.Drawing.Printing.PrinterSettings.InstalledPrinters.Count;
            string[] strImpresorasInstaladas = new string[intNoImpresoras];
            int i = 0;

            //agregar impresoras a un arreglo
            foreach (string strImpresora in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                strImpresorasInstaladas[i] = strImpresora;
                i++;
            }

            //filtrar impresoras HP o EPSON
            var objImpresoras = from indice in strImpresorasInstaladas
                                where indice.Contains("HP") || indice.Contains("EPSON")
                                orderby indice
                                select indice;

            //llenar combobox con valores filtrados
            foreach (var posicion in objImpresoras)
            {
                cboTipoImpresora.Items.Add(posicion);
            }

            if (cboTipoImpresora.Items.Count > 0)   //validar si existen impresoras
                cboTipoImpresora.SelectedIndex = 0;     //seleccionar primera impresora
        }

        #endregion

        private void frmxImpresionChequesMasivos_Load(object sender, EventArgs e)
        {
            CargarImpresorasAutorizadas();  //cargar impresoras autorizadas para impresion

            lblIdCuentabanco.Text = IdCuentaBanco.ToString();
            txtCuentaBanco.Text = NombreCuentaBanco;            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (UtileriasLocal.Validator.IsPresent(txtNoChequeInicial) && UtileriasLocal.Validator.IsPresent(txtNoChequeFinal))
            {
                //asignar valores
                this.TipoImpresora = cboTipoImpresora.Text;
                this.IdTransaccionBancoInicial = Convert.ToInt64(lblIdTransaccionBancoInicial.Text);
                this.IdTransaccionBancoFinal = Convert.ToInt64(lblIdTransaccionBancoFinal.Text);
                this.NoChequeInicial = txtNoChequeInicial.Text;
                this.NoChequeFinal = txtNoChequeFinal.Text;

                if (this.IdTransaccionBancoInicial > this.IdTransaccionBancoFinal)
                {
                    XtraMessageBox.Show("El Folio Cheque Inicial NO puede ser mayor al Folio Cheque Final", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNoChequeInicial.Focus();
                }
                else
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;   //cerrar pantalla
            }
        }

        private void btnBuscarChequeInicial_Click(object sender, EventArgs e)
        {
            //crear pantalla y asignar los valores para la consulta
            frmxBuscarCheque objBuscarCheque = new frmxBuscarCheque() { IdCuentaBanco = Convert.ToInt32(lblIdCuentabanco.Text), AnoTransaccion = DateTime.Now.Year };

            if (objBuscarCheque.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                InfoDetalleTransaccionBanco objInfoDetalleChequeEmitido = objBuscarCheque.InfoDetalleChequeEmitido;
                if (objInfoDetalleChequeEmitido != null)
                {
                    txtNoChequeInicial.Text = objInfoDetalleChequeEmitido.NoTransaccion;
                    lblIdTransaccionBancoInicial.Text = objInfoDetalleChequeEmitido.IdTransaccionBanco.ToString();
                }
                else
                    XtraMessageBox.Show("No ha seleccionado el No. Cheque Inicial", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarChequeFinal_Click(object sender, EventArgs e)
        {
            //crear pantalla y asignar los valores para la consulta
            frmxBuscarCheque objBuscarCheque = new frmxBuscarCheque() { IdCuentaBanco = Convert.ToInt32(lblIdCuentabanco.Text), AnoTransaccion = DateTime.Now.Year };

            if (objBuscarCheque.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                InfoDetalleTransaccionBanco objInfoDetalleChequeEmitido = objBuscarCheque.InfoDetalleChequeEmitido;
                if (objInfoDetalleChequeEmitido != null)
                {
                    txtNoChequeFinal.Text = objInfoDetalleChequeEmitido.NoTransaccion;
                    lblIdTransaccionBancoFinal.Text = objInfoDetalleChequeEmitido.IdTransaccionBanco.ToString();
                }
                else
                    XtraMessageBox.Show("No ha seleccionado el No. Cheque Final", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}