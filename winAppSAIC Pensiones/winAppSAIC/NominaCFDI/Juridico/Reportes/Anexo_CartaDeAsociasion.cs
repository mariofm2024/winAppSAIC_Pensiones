using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using compCatalogosSAIC;

namespace winAppSAIC.Juridico.Reportes
{
    public partial class Anexo_CartaDeAsociasion : DevExpress.XtraReports.UI.XtraReport
    {
        String stTitulo = String.Empty;
        String stContenido1 = String.Empty;
        String stContenido2 = String.Empty;
        String stContenido3 = String.Empty;
        String VersionACG = String.Empty;

        Empleado miEmpleado;
        public Anexo_CartaDeAsociasion(Empleado miEmpleado)
        {
            InitializeComponent();
            this.miEmpleado = miEmpleado;
        }

        private void Anexo_CartaDeAsociasion_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrCellPaterno.Text = miEmpleado.APaternoEmpleado;
            xrCellMaterno.Text = miEmpleado.AMaternoEmpleado;
            xrCellNombre.Text = miEmpleado.NombreEmpleado;
            xrCellNacionalidad.Text = miEmpleado.Nacionalidad;
            xrCellEstadoCivil.Text = miEmpleado.EstadoCivil;
            xrCellSexo.Text = miEmpleado.Sexo;
            xrCellRFC.Text = miEmpleado.RFC;
            xrCellCURP.Text = miEmpleado.CURP;
            xrCellCalleYNumero.Text = miEmpleado.Calle_DP + ", " + miEmpleado.NoExterior_DP + (miEmpleado.NoInterior_DP == String.Empty ? "" : ", " + miEmpleado.NoInterior_DP);
            Colonia.Text = miEmpleado.Colonia_DP;
            xrCellDelegacion.Text = miEmpleado.NombreDelegacionMunicipio_DP;
            xrCellPoblacionCiudad.Text = miEmpleado.NombrePoblacionCiudad_DP;
            xrCellProfesion.Text = miEmpleado.Profesion;
            xrCellLugarYFechaDeNacimiento.Text = miEmpleado.LugarNacimiento + " " + miEmpleado.FechaNacimiento.ToShortDateString().Replace("01/01/1900", "");
            xrCellActividad.Text = String.Empty;

            xrCellCP.Text = miEmpleado.CodigoPostal_DP;
            xrCellTelefono.Text = miEmpleado.Telefono1_DP;
            xrCellCelular.Text = miEmpleado.Telefono2_DP;
            xrCellEmail.Text = miEmpleado.CorreoElectronico;

            rtTitulo.Html = stTitulo;
            rtContenido1.Html = stContenido1;
            rtContenido2.Html = stContenido2;
            rtContenido3.Html = stContenido3;
            rtVersion.Html = VersionACG;
        }

        private void Anexo_CartaDeAsociasion_DataSourceDemanded(object sender, EventArgs e)
        {
            Boolean PorSolicitud = Convert.ToBoolean(porSolicitud.Value.ToString());
            int miSolicitud = Convert.ToInt32(idSolicitud.Value.ToString());
            int miEmpleado = Convert.ToInt32(idEmpleado.Value.ToString());
            stpSelInfoAnexoActadeAsociacionTableAdapter.Fill(dbSAICBPOCatalogosDataSet1.stpSelInfoAnexoActadeAsociacion, PorSolicitud, miSolicitud, miEmpleado);

            if (dbSAICBPOCatalogosDataSet1.stpSelInfoAnexoActadeAsociacion.Rows.Count > 0)
            {
                stTitulo = dbSAICBPOCatalogosDataSet1.stpSelInfoAnexoActadeAsociacion.Rows[0]["Titulo"].ToString();
                stContenido1 = dbSAICBPOCatalogosDataSet1.stpSelInfoAnexoActadeAsociacion.Rows[0]["Contenido1"].ToString();
                stContenido2 = dbSAICBPOCatalogosDataSet1.stpSelInfoAnexoActadeAsociacion.Rows[0]["Contenido2"].ToString();
                stContenido3 = dbSAICBPOCatalogosDataSet1.stpSelInfoAnexoActadeAsociacion.Rows[0]["Contenido3"].ToString();
                VersionACG = dbSAICBPOCatalogosDataSet1.stpSelInfoAnexoActadeAsociacion.Rows[0]["VersionACG"].ToString();
            }
        }
    }
}
