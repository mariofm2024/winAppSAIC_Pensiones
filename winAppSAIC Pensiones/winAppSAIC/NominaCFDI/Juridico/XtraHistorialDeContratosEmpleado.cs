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
using System.Diagnostics;

namespace winAppSAIC.Juridico
{
    public partial class XtraHistorialDeContratosEmpleado : DevExpress.XtraEditors.XtraForm
    {
        Empleado objEmp;
        tools.dsc dsc = new tools.dsc();
        public XtraHistorialDeContratosEmpleado(Empleado objEmp)
        {
            InitializeComponent();
            this.objEmp = objEmp;
        }

        private void toolBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbrirCarpeta_Click(object sender, EventArgs e)
        {
            String stRutaEmpleado = dsc.stRutaEmpleados + @"\" + objEmp.IdEmpleado.ToString() + @"\";
            dsc.CheckandCreateFolder(stRutaEmpleado);
            Process.Start(stRutaEmpleado);
        }

        private void XtraHistorialDeContratosEmpleado_Load(object sender, EventArgs e)
        {
            txtNoEmpleado.Text = objEmp.IdEmpleado.ToString();
            txtNombreEmpleado.Text = objEmp.NombreEmpleado;
            txtAPaternoEmpleado.Text = objEmp.APaternoEmpleado;
            txtAMaternoEmpleado.Text = objEmp.AMaternoEmpleado;
            stpSelConsultaHisotrialContratoEmpleadoTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelConsultaHisotrialContratoEmpleado, objEmp.IdEmpleado);
        }

        private void repositoryItemButtonEditDescargar_Click(object sender, EventArgs e)
        {
            DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (row != null)
            {
                int idContratosEmpleado = 0;
                int idEmpleado = 0;

                String stNombreEmpleado = objEmp.APaternoEmpleado + " " + objEmp.AMaternoEmpleado + " " + objEmp.NombreEmpleado;
                int.TryParse(row["idContratosEmpleado"].ToString(), out idContratosEmpleado);
                int.TryParse(row["idEmpleado"].ToString(), out idEmpleado);

                Catalogos.frmxModificacionEmpleados ofrmxModificacionEmpleados = new Catalogos.frmxModificacionEmpleados(0,false,false,false,false,false,0);
                ofrmxModificacionEmpleados.descargarContratoActivo(stNombreEmpleado, idEmpleado, idContratosEmpleado);
            }
        }

        private void repositoryItemCheckEditActivadoOperaciones_CheckedChanged(object sender, EventArgs e)
        {
            DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (row != null)
            {
                CheckEdit oCheckEdit = new CheckEdit();
                oCheckEdit = (CheckEdit)sender;

                int idContratosEmpleado = 0;
                int idEmpleado = 0;

                int.TryParse(row["idContratosEmpleado"].ToString(), out idContratosEmpleado);
                int.TryParse(row["idEmpleado"].ToString(), out idEmpleado);

                queriesJuridico1.stpUpdActivarDesactivarContratoEmpleado(idContratosEmpleado, idEmpleado, oCheckEdit.Checked, OperadorBD.OperadorGlobal.NombreUsuario);

                //queriesJuridico1.stpUpdActivarDesactivarContratoEmpleado(0, 0, false, "");

                XtraMessageBox.Show("Contrato " + (oCheckEdit.Checked == true ? "Activado" : "Desactivado")
                              , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}