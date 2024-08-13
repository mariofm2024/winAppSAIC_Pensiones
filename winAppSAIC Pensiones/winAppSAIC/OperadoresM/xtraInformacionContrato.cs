using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace winAppSAIC.OperadoresM
{
    public partial class xtraInformacionContrato : DevExpress.XtraEditors.XtraForm
    {
        OperadoresM.XtraAltaEmpleados altaEmpleados = new XtraAltaEmpleados("Operaciones");

        public decimal dc_Vacaciones { get; set; }
        public decimal dc_PrimaVacacional { get; set; }
        public decimal dc_Aguinaldo { get; set; }

        tools.dsc dsc = new tools.dsc();

        decimal dcVacaciones = 6.00M;
        decimal dcPVacaciones = 25.00M;
        decimal dcAguinaldo = 15.00M;

        public xtraInformacionContrato(decimal dcEmpVacaciones, decimal dcEmpPrimaVacacional, decimal dcEmpAguinaldo)
        {
            InitializeComponent();
            seVacaciones.Value = dcEmpVacaciones;
            sePrimaVacacional.Value = dcEmpPrimaVacacional;
            seAguinaldo.Value = dcEmpAguinaldo;
            
            txtUMA.Text = altaEmpleados.obtenerUMA(DateTime.Now).ToString("#.##");
            txtSDGV.Text = altaEmpleados.obtenerSMGV(DateTime.Now).ToString("#.##");
        }

        private void xtraInformacionContrato_Load(object sender, EventArgs e)
        {
            //txtbxVacaciones.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            //txtbxVacaciones.Properties.Mask.EditMask = "###.00";
            //txtbxVacaciones.Properties.Mask.UseMaskAsDisplayFormat = true;

            //txtbxPVacacional.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            //txtbxPVacacional.Properties.Mask.EditMask = "###.00";
            //txtbxPVacacional.Properties.Mask.UseMaskAsDisplayFormat = true;

            //txtbxAguinaldo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            //txtbxAguinaldo.Properties.Mask.EditMask = "###.00";
            //txtbxAguinaldo.Properties.Mask.UseMaskAsDisplayFormat = true;
        }

        private void btnAgregarInformacionContrato_Click(object sender, EventArgs e)
        {
            if (seVacaciones.Text.Trim() != "." && sePrimaVacacional.Text.Trim() != "." && seAguinaldo.Text.Trim() != ".")
            {
                decimal iVacaciones = 0;
                decimal iPVacaciones = 0;
                decimal iAguinaldo = 0;

                decimal.TryParse(seVacaciones.Text, out iVacaciones);
                decimal.TryParse(sePrimaVacacional.Text, out iPVacaciones);
                decimal.TryParse(seAguinaldo.Text, out iAguinaldo);

                if (iVacaciones >= dcVacaciones && iPVacaciones >= dcPVacaciones && iAguinaldo >= dcAguinaldo)
                {
                    dc_Vacaciones = seVacaciones.Value;
                    dc_PrimaVacacional = sePrimaVacacional.Value;
                    dc_Aguinaldo = seAguinaldo.Value;
                    DialogResult = DialogResult.OK;
                    XtraMessageBox.Show("Informacion Guardada con Exito. " + Environment.NewLine
                     , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    String mensaje = (iVacaciones < dcVacaciones ? "Vacaciones no puede ser menor a: " + dcVacaciones.ToString() + Environment.NewLine : String.Empty) +
                        (iPVacaciones < dcPVacaciones ? "Prima Vacacional no puede ser menor a: " + dcPVacaciones.ToString() + Environment.NewLine : String.Empty) +
                        (iAguinaldo < dcAguinaldo ? "Aguinaldo no puede ser menor a:" + dcAguinaldo.ToString() + Environment.NewLine : String.Empty);

                    XtraMessageBox.Show("Los valores no pueden ser Menores a:" + Environment.NewLine + mensaje
              , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                XtraMessageBox.Show(Environment.NewLine + "Algunos de los valores no puede estar Vacio." + Environment.NewLine
             , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            seVacaciones.Value = 6.00M;
            sePrimaVacacional.Value = 25.00M;
            seAguinaldo.Value = 15.00M;
        }

        private void obtenerFactorIntegracion()
        {
            txtFactorIntegracion.Text = altaEmpleados.obtenerFactorIntegracion(seVacaciones.Value.ToString(), sePrimaVacacional.Value.ToString(), seAguinaldo.Value.ToString()).ToString();
        }

        private void seVacaciones_EditValueChanged(object sender, EventArgs e)
        {
            obtenerFactorIntegracion();
        }

        private void sePrimaVacacional_EditValueChanged(object sender, EventArgs e)
        {
            obtenerFactorIntegracion();
        }

        private void seAguinaldo_EditValueChanged(object sender, EventArgs e)
        {
            obtenerFactorIntegracion();
        }
    }
}