using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;
using compCatalogosSAIC;

namespace winAppSAIC.IMSS
{
    public partial class XtraAsignarVariablesEmpleado : DevExpress.XtraEditors.XtraForm
    {
        int idEmpleado = 0;
        String stNombreCompletoEmpleado = String.Empty;
        tools.dsc dsc = new tools.dsc();
        VariableEmpleado oVariableEmpleado;
        public XtraAsignarVariablesEmpleado(int idEmpleado, String stNombreCompletoEmpleado)
        {
            InitializeComponent();
            this.idEmpleado = idEmpleado;
            this.stNombreCompletoEmpleado = stNombreCompletoEmpleado;
        }


        private void limpiar()
        {
            txtidAplicacionVariablesIMSS.Text = String.Empty;
            txtMeses.Text = String.Empty;
            txtFechaAplicacion.Text = String.Empty;
            txtFechaVigenciaInicio.Text = String.Empty;
            txtFechaVigenciaFin.Text = String.Empty;
            txtVariable.Text = "0.00";
            txtVariable.Value = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XtraAsignarVariablesEmpleado_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'dbSAICBPOActualizacionesIMSSDataSet.stpSelEstatusVariables' Puede moverla o quitarla según sea necesario.
                this.stpSelEstatusVariablesTableAdapter.Fill(this.dbSAICBPOActualizacionesIMSSDataSet.stpSelEstatusVariables);
                // TODO: esta línea de código carga datos en la tabla 'dbSAICBPOActualizacionesIMSSDataSet.stpSelAnioSolicitudVariablesIMSS' Puede moverla o quitarla según sea necesario.
                this.stpSelAnioSolicitudVariablesIMSSTableAdapter.Fill(this.dbSAICBPOActualizacionesIMSSDataSet.stpSelAnioSolicitudVariablesIMSS);
                limpiar();
                txtidEmpleado.Text = idEmpleado.ToString();
                txtNombreEmpleado.Text = stNombreCompletoEmpleado;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error al cargar: " + ex.Message, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridLookUpEditAnio_EditValueChanged(object sender, EventArgs e)
        {
            int iAnio = 0;
            int.TryParse(gridLookUpEditAnio.EditValue.ToString(), out iAnio);
            stpSelBimestreSolicitudVariablesIMSSTableAdapter.Fill(dbSAICBPOActualizacionesIMSSDataSet.stpSelBimestreSolicitudVariablesIMSS, iAnio);
        }

        private void gridLookUpEditBimestre_EditValueChanged(object sender, EventArgs e)
        {
            limpiar();
            consultarVariables();
        }

        private void consultarVariables()
        {
            int iAnio = 0;
            int iBimestre = 0;

            int.TryParse(gridLookUpEditAnio.EditValue.ToString(), out iAnio);
            int.TryParse(gridLookUpEditBimestre.EditValue.ToString(), out iBimestre);
            if (iAnio > 0 && iBimestre > 0)
            {
                stpSelObtenerVariableAplicadaEmpleadoTableAdapter1.Fill(dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerVariableAplicadaEmpleado, true, idEmpleado, iAnio, iBimestre);
                if (dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerVariableAplicadaEmpleado.Rows.Count > 0)
                {
                    oVariableEmpleado = new VariableEmpleado(dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerVariableAplicadaEmpleado.Rows[0]);
                    mostrarDatos(oVariableEmpleado);
                }
                else //Si el empleado no tiene variable
                {
                    mostrarDatosSinVariable(iBimestre);
                }
            }
        }

        public void mostrarDatosSinVariable(int iBimestre)
        {
            stpSelDetalleBimestreSolicitudVariablesIMSSTableAdapter1.Fill(dbSAICBPOActualizacionesIMSSDataSet.stpSelDetalleBimestreSolicitudVariablesIMSS, iBimestre);
            if (dbSAICBPOActualizacionesIMSSDataSet.stpSelDetalleBimestreSolicitudVariablesIMSS.Rows.Count > 1)
            {

                oVariableEmpleado = new VariableEmpleado();

                DateTime dtFechaVigenciaFin;

                oVariableEmpleado.iBimestre = iBimestre;

                int iMes = 0;
                int.TryParse(dbSAICBPOActualizacionesIMSSDataSet.stpSelDetalleBimestreSolicitudVariablesIMSS.Rows[1]["IdMes"].ToString(), out iMes);

                int iAnio;
                int.TryParse(gridLookUpEditAnio.EditValue.ToString(), out iAnio);
                oVariableEmpleado.iAnio = iAnio;

                DateTime dtFechaDeAplicacion = new DateTime(iAnio, iMes, 01);
                dtFechaVigenciaFin = dtFechaDeAplicacion;
                dtFechaVigenciaFin = dtFechaVigenciaFin.AddMonths(3);
                dtFechaVigenciaFin = dtFechaVigenciaFin.AddDays(-1);

                //txtFechaAplicacion.Text = dtFechaDeAplicacion.AddMonths(1).ToShortDateString();
                //txtFechaVigenciaInicio.Text = dtFechaDeAplicacion.AddMonths(1).ToShortDateString();
                //txtFechaVigenciaFin.Text = dtFechaVigenciaFin.ToShortDateString();

                oVariableEmpleado.dtFechaVigenciainicio = dtFechaDeAplicacion.AddMonths(1);
                oVariableEmpleado.dtFechaVigenciaFin = dtFechaVigenciaFin;
                mostrarDatos(oVariableEmpleado);
            }
        }



        private void btnDescargarExcel_Click(object sender, EventArgs e)
        {
            stpSelObtenerVariableAplicadaEmpleadoTableAdapter1.Fill(dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerVariableAplicadaEmpleado, false, idEmpleado, 0, 0);
            String stRutavariables = dsc.stRutaSAICIMSS + @"Variables\" + idEmpleado + @"\";
            dsc.CheckandCreateFolder(stRutavariables);
            String stNombreArchivo = stRutavariables + "Variables_" + idEmpleado + "_" + stNombreCompletoEmpleado + dsc.nombreAleatorio() + ".xlsx";

            gridControl1.ExportToXlsx(stNombreArchivo);

            DialogResult oDialogResult = XtraMessageBox.Show("Documento Descargado. Ruta: " + stRutavariables + Environment.NewLine +
                "¿Desea Abrir el archivo?", "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes == oDialogResult)
            {
                Process.Start(stNombreArchivo);
            }
        }


        public void mostrarDatos(VariableEmpleado oVariableEmpleado)
        {
            txtidAplicacionVariablesIMSS.Text = oVariableEmpleado.idAplicacionVariablesIMSS.ToString();
            txtMeses.Text = oVariableEmpleado.iBimestre.ToString();
            txtFechaAplicacion.Text = oVariableEmpleado.dtFechaVigenciainicio.ToString("dd/MM/yyyy");
            txtFechaVigenciaInicio.Text = oVariableEmpleado.dtFechaVigenciainicio.ToString("dd/MM/yyyy");
            txtFechaVigenciaFin.Text = oVariableEmpleado.dtFechaVigenciaFin.ToString("dd/MM/yyyy");
            txtVariable.Text = oVariableEmpleado.dcMontoVarible.ToString();
            txtVariable.Value = oVariableEmpleado.dcMontoVarible;
            gridLookUpEditEstatus.EditValue = oVariableEmpleado.iEstatus;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            DialogResult oDialogResult = XtraMessageBox.Show("¿Desea guardar la informacion del empleado?", "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes == oDialogResult)
            {
                try
                {
                    actualizacionesIMSSTableAdapter1.stpUpdObtenerVariableAplicadaEmpleado(
                                   oVariableEmpleado.idAplicacionVariablesIMSS
                                   , idEmpleado
                                   , oVariableEmpleado.iAnio
                                   , oVariableEmpleado.iBimestre
                                   , oVariableEmpleado.dtFechaVigenciainicio
                                   , oVariableEmpleado.dtFechaVigenciaFin
                                   , oVariableEmpleado.dcMontoVarible
                                   , 2
                                   , OperadorBD.OperadorGlobal.NombreUsuario);

                    XtraMessageBox.Show("Informacion guardada con exito.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Error al guardar variable: " + ex.Message, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
        }

        private void gridLookUpEditEstatus_EditValueChanged(object sender, EventArgs e)
        {
            int idEstatus = 0;
            int.TryParse(gridLookUpEditEstatus.EditValue.ToString(), out idEstatus);
            oVariableEmpleado.iEstatus = idEstatus;
        }

        private void txtVariable_EditValueChanged(object sender, EventArgs e)
        {
            oVariableEmpleado.dcMontoVarible = txtVariable.Value;
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }


    public class VariableEmpleado
    {
        public int idAplicacionVariablesIMSS { get; set; }
        public int idEmpleado { get; set; }
        public int iAnio { get; set; }
        public int iBimestre { get; set; }
        public decimal dcMontoVarible { get; set; }
        public String sDescEstatus { get; set; }
        public DateTime dtFechaVigenciainicio { get; set; }
        public DateTime dtFechaVigenciaFin { get; set; }
        public int iEstatus { get; set; }

        public VariableEmpleado()
        {
            idAplicacionVariablesIMSS = 0;
            idEmpleado = 0;
            iAnio = 0;
            iBimestre = 0;
            dcMontoVarible = 0;
            sDescEstatus = String.Empty;
            DateTime dtFechaVigenciainicio = new DateTime(1900, 01, 01);
            DateTime dtFechaVigenciaFin = new DateTime(1900, 01, 01);
            iEstatus = 0;
        }

        public VariableEmpleado(DataRow unRow)
        {
            int iDetail = 0;
            int.TryParse(unRow["idAplicacionVariablesIMSS"].ToString(), out iDetail);
            idAplicacionVariablesIMSS = iDetail;

            int iEmpleado = 0;
            int.TryParse(unRow["idEmpleado"].ToString(), out iEmpleado);
            idEmpleado = iEmpleado;

            int iAnio = 0;
            int.TryParse(unRow["Anio"].ToString(), out iAnio);
            this.iAnio = iAnio;

            int iBimestre = 0;
            int.TryParse(unRow["Bimestre"].ToString(), out iBimestre);
            this.iBimestre = iBimestre;

            decimal dcMontoVarible = 0;
            decimal.TryParse(unRow["Variable"].ToString(), out dcMontoVarible);
            this.dcMontoVarible = dcMontoVarible;

            sDescEstatus = unRow["Estatus"].ToString();

            DateTime dtFechaVigenciainicio = new DateTime(1900, 01, 01);
            DateTime dtFechaVigenciaFin = new DateTime(1900, 01, 01);

            DateTime.TryParse(unRow["FechaVigenciaInicio"].ToString(), out dtFechaVigenciainicio);
            this.dtFechaVigenciainicio = dtFechaVigenciainicio;

            DateTime.TryParse(unRow["FechaVigenciaFin"].ToString(), out dtFechaVigenciaFin);
            this.dtFechaVigenciaFin = dtFechaVigenciaFin;

            int iEstatus = 0;
            int.TryParse(unRow["idEstatus"].ToString(), out iEstatus);
            this.iEstatus = iEstatus;
        }


    }




}