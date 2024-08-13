using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using compCatalogosSAIC;

namespace winAppSAIC.Versiones
{
    public partial class frmxControlVersionesAltaEmpleados : DevExpress.XtraEditors.XtraForm
    {
        public frmxControlVersionesAltaEmpleados()
        {
            InitializeComponent();
        }

        private void btnSubirPlantilla_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(gridLookTipoDocumento.Text))
            {               
                String stFiltro = String.Empty;
                String stTipoArchivo = String.Empty;
                String stExtencion = String.Empty;
                int idTendora = 0;
                int iTipoDocumento = Convert.ToInt32(gridLookTipoDocumento.EditValue);
                
                if (gridLookTipoDocumento.Text.Contains("PLANTILLA"))
                {
                    stFiltro = "Excel Files (*.xls;*.xlsm;*.xlsb;*.xlsx)|*.xls;*.xlsm;*.xlsb;*.xlsx";
                    stTipoArchivo = "Excel";
                }
                else
                {
                    idTendora = Convert.ToInt32(gridLookTenedora.EditValue.ToString());
                    stFiltro = "Pdf Files| *.pdf";
                    stTipoArchivo = "PDF";
                }

                try
                {
                    String stRutaArchivo = String.Empty;
                    XtraMessageBox.Show("Seleccione " + gridLookTipoDocumento.Text + " que desea guardar.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OpenFileDialog openDiag = new OpenFileDialog();
                    openDiag.Filter = stFiltro;
                    openDiag.ShowDialog();
                    stRutaArchivo = openDiag.FileName;

                    if (!String.IsNullOrEmpty(stRutaArchivo))
                    {
                        FileInfo Archivo = new FileInfo(stRutaArchivo);
                        stExtencion = Archivo.Extension;
                        
                        lblNombreArchivo.Text = Path.GetFileName(stRutaArchivo);
                        Byte[] bytes = File.ReadAllBytes(stRutaArchivo);
                        String file = Convert.ToBase64String(bytes);

                        try
                        {
                            queriesTableAdapter1.stpInsDocumentosVersion(idTendora, lblNombreArchivo.Text.ToUpper(), stTipoArchivo, iTipoDocumento, stExtencion, file, OperadorBD.OperadorGlobal.NombreUsuario);

                            XtraMessageBox.Show("Archivo: " + Environment.NewLine + lblNombreArchivo.Text + "." + Environment.NewLine + "Actualizado con Exito."
                            , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show("Archivo: " + Environment.NewLine + lblNombreArchivo.Text + "." + Environment.NewLine + "No se pudo actualizar." + Environment.NewLine + ex.Message
                        , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("No se puede subir el Archivo: " + Environment.NewLine + ex.Message, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                XtraMessageBox.Show("Seleccione un tipo de Documento."
                        , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmxControlVersionesAltaEmpleados_Load(object sender, EventArgs e)
        {
            stpSelTipoDocumentacionTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelTipoDocumentacion);
            stpSelObtenerInfoGenericaMatrizTenedora_1TableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoGenericaMatrizTenedora_1, true);
            //stpSelObtenerInfoGenericaTenedoraSATableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoGenericaTenedoraSA);
        }

        private void gridLookTipoDocumento_EditValueChanged(object sender, EventArgs e)
        {
            if (gridLookTipoDocumento.Text.Contains("ANEXO"))
            {
                gridLookTenedora.Enabled = true;
            }
            else
            {
                gridLookTenedora.Enabled = false;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (gridLookTenedora.EditValue.ToString() != "vacio")
            {
                int idMatrizTendora;
                int.TryParse(gridLookTenedora.EditValue.ToString(), out idMatrizTendora);

                if (idMatrizTendora > 0)
                {
                    OperadoresM.Solicitud miSolicitud = new OperadoresM.Solicitud();
                    Juridico.XtraEmpleadosXSolicitudJuridico miJuridico = new Juridico.XtraEmpleadosXSolicitudJuridico(miSolicitud);

                    String stRuta = tools.dsc.stRutaPlantillas;
                    miJuridico.DescargarAnexos(stRuta, idMatrizTendora);
                }
                else
                {
                    XtraMessageBox.Show("No se puede obtener el valor de la tenedora", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                XtraMessageBox.Show("Seleccione una Tendora para descargar ANEXOS.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}