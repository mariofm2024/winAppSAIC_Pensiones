using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace winAppSAIC.Catalogos.uc
{
    public partial class ucCatalogosGenerales : UserControl
    {
        public ucCatalogosGenerales()
        {
            InitializeComponent();
        }

        //propiedad que indicará el tipo de Menú
        //Estatus = 1, Regimen Fiscal SAT = 2, Periodicidad Pago = 3
        //Tipo Contrato = 4, Tipo Jornada = 5, Tipo Nomina = 6
        public byte OpcionMenu { get; set; }

        private void estatusBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.estatusBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbSAIC_Catalogos);
        }

        private void ucCatalogosGenerales_Load(object sender, EventArgs e)
        {
            try
            {
                splashSMCargando.ShowWaitForm();

                if (OpcionMenu.Equals(1)) //Estatus
                {
                    xtpEstatus.PageVisible = true;
                    xtpRegimenFiscal.PageVisible = false;
                    xtpPeriodicidadPago.PageVisible = false;
                    xtpTipoContrato.PageVisible = false;
                    xtpTipoJornada.PageVisible = false;
                    xtpTipoNomina.PageVisible = false;
                    this.estatusTableAdapter.Fill(this.dbSAIC_Catalogos.Estatus);
                }
                else if (OpcionMenu.Equals(2)) //Regimen Fiscal SAT
                {
                    xtpEstatus.PageVisible = false;
                    xtpRegimenFiscal.PageVisible = true;
                    xtpPeriodicidadPago.PageVisible = false;
                    xtpTipoContrato.PageVisible = false;
                    xtpTipoJornada.PageVisible = false;
                    xtpTipoNomina.PageVisible = false;
                    this.regimenFiscalSATTableAdapter.Fill(this.dbSAIC_CatalogosSAT.RegimenFiscalSAT);
                }
                else if (OpcionMenu.Equals(3)) //Periodicidad Pago SAT
                {
                    xtpEstatus.PageVisible = false;
                    xtpRegimenFiscal.PageVisible = false;
                    xtpPeriodicidadPago.PageVisible = true;
                    xtpTipoContrato.PageVisible = false;
                    xtpTipoJornada.PageVisible = false;
                    xtpTipoNomina.PageVisible = false;
                    this.periodicidadPagoSATTableAdapter.Fill(this.dbSAIC_CatalogosSAT.PeriodicidadPagoSAT);
                }
                else if (OpcionMenu.Equals(4)) //Tipo Contrato SAT
                {
                    xtpEstatus.PageVisible = false;
                    xtpRegimenFiscal.PageVisible = false;
                    xtpPeriodicidadPago.PageVisible = false;
                    xtpTipoContrato.PageVisible = true;
                    xtpTipoJornada.PageVisible = false;
                    xtpTipoNomina.PageVisible = false;
                    this.tipoContratoSATTableAdapter.Fill(this.dbSAIC_CatalogosSAT.TipoContratoSAT);
                }
                else if (OpcionMenu.Equals(5)) //Tipo Jornada SAT
                {
                    xtpEstatus.PageVisible = false;
                    xtpRegimenFiscal.PageVisible = false;
                    xtpPeriodicidadPago.PageVisible = false;
                    xtpTipoContrato.PageVisible = false;
                    xtpTipoJornada.PageVisible = true;
                    xtpTipoNomina.PageVisible = false;
                    this.tipoJornadaSATTableAdapter.Fill(this.dbSAIC_CatalogosSAT.TipoJornadaSAT);
                }
                else if (OpcionMenu.Equals(6)) //Tipo Nomina SAT
                {
                    xtpEstatus.PageVisible = false;
                    xtpRegimenFiscal.PageVisible = false;
                    xtpPeriodicidadPago.PageVisible = false;
                    xtpTipoContrato.PageVisible = false;
                    xtpTipoJornada.PageVisible = false;
                    xtpTipoNomina.PageVisible = true;
                    this.tipoNominaSATTableAdapter.Fill(this.dbSAIC_CatalogosSAT.TipoNominaSAT);
                }

                splashSMCargando.CloseWaitForm();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void regimenFiscalSATBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.regimenFiscalSATBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.dbSAIC_CatalogosSAT);
        }

        private void periodicidadPagoSATBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.periodicidadPagoSATBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.dbSAIC_CatalogosSAT);
        }

        private void tipoContratoSATBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tipoContratoSATBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.dbSAIC_CatalogosSAT);
        }

        private void tipoJornadaSATBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tipoJornadaSATBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.dbSAIC_CatalogosSAT);
        }

        private void tipoNominaSATBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tipoNominaSATBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.dbSAIC_CatalogosSAT);
        }
    }
}
