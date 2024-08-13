﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace winAppSAIC.ReportesCFDI
{
    public partial class RecibosEmpleadosSueldosCFDI : DevExpress.XtraReports.UI.XtraReport
    {
        public RecibosEmpleadosSueldosCFDI()
        {
            InitializeComponent();
        }

        private void xrSubreport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((PercepcionesGravadoExento)((XRSubreport)sender).ReportSource).pIdPDOHeader.Value =
                                           Convert.ToInt64(GetCurrentColumnValue("IdPDOHeader"));
            ((PercepcionesGravadoExento)((XRSubreport)sender).ReportSource).pTipoMovimientoNomina.Value =
                                           pTipoMovimientoNomina.Value.ToString();
            ((PercepcionesGravadoExento)((XRSubreport)sender).ReportSource).pIdLoteCargaNomina.Value =
                                           Convert.ToInt64(pIdLoteCargaNomina.Value); 
        }

        private void xrSubreport2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((DeduccionesGravadoExento)((XRSubreport)sender).ReportSource).pIdPDOHeader.Value =
                               Convert.ToInt64(GetCurrentColumnValue("IdPDOHeader"));
            ((DeduccionesGravadoExento)((XRSubreport)sender).ReportSource).pTipoMovimientoNomina.Value =
                                           pTipoMovimientoNomina.Value.ToString();
            ((DeduccionesGravadoExento)((XRSubreport)sender).ReportSource).pIdLoteCargaNomina.Value =
                                          Convert.ToInt64(pIdLoteCargaNomina.Value);
        }

        private void RecibosEmpleadosSueldosAsimiladosCFDI_DataSourceDemanded(object sender, EventArgs e)
        {
            ////asignar el valor del parámetro y obtener registros
            this.stpSelRecibosEmpleadosSueldosAsimiladosCFDITableAdapter2.Fill(dbSAICBPONominaCFDIDataSet1.stpSelRecibosEmpleadosSueldosAsimiladosCFDI, Convert.ToInt64(pIdLoteCargaNomina.Value), Convert.ToInt64(pIdPDOHeader.Value));
        }

    }
}
