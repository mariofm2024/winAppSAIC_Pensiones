using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

namespace winAppSAIC.Juridico.Reportes
{
    public partial class CIT_PPP : DevExpress.XtraReports.UI.XtraReport
    {
        String stContratos = String.Empty;
        int itipoConsulta = 0;

        //Boolean flagContratoGenerico;
        public CIT_PPP()
        {
            InitializeComponent();
            //flagContratoGenerico = (Boolean)flagConGenerico.Value;

        }

        private void CIT_PPP_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if ((Boolean)flagConGenerico.Value)
            {
                RichTextParrafo1.Html = stContratos;
            }
            else
            {
                RichTextParrafo1.Rtf = stContratos;
            }
        }

        private void CIT_PPP_DataSourceDemanded(object sender, EventArgs e)
        {
            if ((Boolean)flagConGenerico.Value)
            {
                int MiSolicitud = Convert.ToInt32(Solicitud.Value.ToString());
                int Empleado = Convert.ToInt32(IdEmpleado.Value.ToString());
                int MiMatriztendora = Convert.ToInt32(idMatrizTenedora.Value.ToString());
                int iTipoConsulta = Convert.ToInt32(tipoConsulta.Value.ToString());
                int idFirmante = Convert.ToInt32(IdFirmante.Value.ToString());
                // 0 = La opcion viene de Juridico - Se consultara la base de datos para obtener el resultado del contrato
                // 1 = Se envia el resultado para mostrar y/o guardar el contrato. 
                int unEmpleado = 0;
                if (iTipoConsulta == 0)
                {
                    String stlosEmpleados = stEmpleados.Value.ToString();
                    //Separando
                    String[] idEmpleados = stlosEmpleados.Split('|');
                    List<int> listaEmpleados = new List<int>();

                    for (int i = 0; i < idEmpleados.Length; i++)
                    {
                        int.TryParse(idEmpleados[i], out unEmpleado);
                        if (unEmpleado > 0)
                        {
                            stpSelCITTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelCIT, unEmpleado, idFirmante);
                            stContratos += dbSAICBPOCatalogosDataSet1.stpSelCIT.Rows[0][0].ToString();
                        }
                    }
                }
                else
                {
                    stContratos = ResultadoHTML.Value.ToString();
                }
            }
            else
            {



                stContratos = ResultadoHTML.Value.ToString();
            }
        }
    }
}
