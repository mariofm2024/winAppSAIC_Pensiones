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

namespace winAppSAIC.Contablidad
{
    public partial class frmxConciliacionUUID : DevExpress.XtraEditors.XtraForm
    {
        public frmxConciliacionUUID()
        {
            InitializeComponent();
        }

        private void toolBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubirArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSelecFile = new OpenFileDialog();
            ofdSelecFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            ofdSelecFile.Multiselect = true;
            ofdSelecFile.ShowDialog();
            txtRutaArchivo.Text = ofdSelecFile.FileName;

            DataTable dtRegistrosUUID = new DataTable();
            String sMensaje = String.Empty;
            Boolean flagTitulos = true;


            if (ofdSelecFile.FileNames.Count() == 1)
            {
                lblNombreArchivo.Text = ofdSelecFile.SafeFileNames[0];
            }
            else
            {
                lblNombreArchivo.Text = "Numero de Archivos: " + ofdSelecFile.FileNames.Count();
            }


            splashScreenManager1.ShowWaitForm();

            for (int i = 0; i < ofdSelecFile.FileNames.Count(); i++)
            {
                splashScreenManager1.SetWaitFormDescription("Leyendo " + (i + 1) + " de " + ofdSelecFile.FileNames.Count());

                String[] sLineas = File.ReadAllLines(ofdSelecFile.FileNames[i]);

                for (int x = 0; x < sLineas.Length; x++)
                {
                    splashScreenManager1.SetWaitFormDescription("Archivo " + (i + 1) + " Registros " + (x + 1) + " de " + sLineas.Length);
                    String[] sRow = sLineas[x].Split(new[] { txtSeparador.Text }, StringSplitOptions.None);
                    //Obteniendo Titulos
                    if (flagTitulos && x == 0)
                    {
                        dtRegistrosUUID = formatoDatatableArchivoUUID(sRow);
                        gridControl1.DataSource = dtRegistrosUUID;
                        flagTitulos = false;
                    }

                    if (x > 0)
                    {

                        //-1 por la columna de Observaciones SAIC, Nombre Archivo
                        if (sRow.Count() <= (dtRegistrosUUID.Columns.Count - 13))
                        {
                            DataRow unRow = dtRegistrosUUID.NewRow();
                            for (int j = 0; j < sRow.Count(); j++)
                            {
                                unRow[j] = sRow[j];
                            }

                            unRow["Nombre Archivo"] = ofdSelecFile.SafeFileNames[i];
                            unRow = ValidarRegistroConciliacion(unRow);
                            dtRegistrosUUID.Rows.Add(unRow);
                        }
                        else
                        {
                            DataRow unRow = dtRegistrosUUID.NewRow();
                            for (int j = 0; j < dtRegistrosUUID.Columns.Count; j++)
                            {
                                unRow[j] = sRow[j];
                            }
                            unRow["Nombre Archivo"] = ofdSelecFile.SafeFileNames[i];
                            unRow["Observaciones SAIC"] = "El Numero de Registros(row) no es igual al Numero de Columnas.";
                            dtRegistrosUUID.Rows.Add(unRow);
                        }

                    }
                }
            }

            txtNumRegistros.Text = dtRegistrosUUID.Rows.Count.ToString();

            txtRegistrosEnSAIC.Text = (from x in dtRegistrosUUID.AsEnumerable()
                                       where x.Field<String>("Observaciones SAIC").Equals("OK")
                                       select x).ToList().Count.ToString();

            gridControl1.DataSource = dtRegistrosUUID;
            if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }

        }

        private void frmxConciliacionUUID_Load(object sender, EventArgs e)
        {
            lblNombreArchivo.Text = String.Empty;
        }

        private DataTable formatoDatatableArchivoUUID(String[] stTitulos)
        {
            DataTable dt = new DataTable();

            foreach (String item in stTitulos)
            {
                dt.Columns.Add(item, typeof(String));
            }

            dt.Columns.Add("IdPDOHeaderCFDI", typeof(int));
            dt.Columns.Add("IdPDOHeader", typeof(int));
            dt.Columns.Add("IdLoteCargaNomina", typeof(int));
            dt.Columns.Add("FolioFiscalUUID", typeof(String));
            dt.Columns.Add("RFC", typeof(String));
            dt.Columns.Add("MontoPagado", typeof(Decimal));
            dt.Columns.Add("DifereniciaArchivoSAIC", typeof(Decimal));
            dt.Columns.Add("EstadoCFDI", typeof(String));
            dt.Columns.Add("EstatusDocumento", typeof(String));
            dt.Columns.Add("FechaCancelacionSAIC", typeof(DateTime));
            dt.Columns.Add("Fecha Pago", typeof(DateTime));
            dt.Columns.Add("Nombre Archivo", typeof(String));
            dt.Columns.Add("Observaciones SAIC", typeof(String));

            return dt;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                tools.dsc dsc = new tools.dsc();
                String stRutaSaic = dsc.stRutaSAICContabilidad;
                dsc.CheckandCreateFolder(stRutaSaic);
                stRutaSaic += "Conciliacion UUID - " + dsc.nombreAleatorio() + ".xlsx";
                gridControl1.ExportToXlsx(stRutaSaic);

                XtraMessageBox.Show("descarga con exito." + Environment.NewLine + "Ruta: " + stRutaSaic, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("No se puede descargar la Información" + ex.Message, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private DataRow ValidarRegistroConciliacion(DataRow unRow)
        {
            try
            {
                String stMensaje = String.Empty;
                ConciliacionUUID oConciliacionUUID = new ConciliacionUUID();

                DateTime tmpdtFechaEmision;
                DateTime tmpdtFechaCertificacionSAT;
                DateTime tmpdtFechaFechaCancelacion;

                oConciliacionUUID.sUUID = unRow[0].ToString();
                oConciliacionUUID.sRFCEmisor = unRow[1].ToString();
                oConciliacionUUID.sNomreEmisor = unRow[2].ToString();
                oConciliacionUUID.sRFCReceptor = unRow[3].ToString();
                oConciliacionUUID.sNombreReceptor = unRow[4].ToString();
                oConciliacionUUID.sRFCPAC = unRow[5].ToString();

                DateTime.TryParse(unRow[6].ToString(), out tmpdtFechaEmision);
                oConciliacionUUID.dtFechaEmision = tmpdtFechaEmision;

                DateTime.TryParse(unRow[7].ToString(), out tmpdtFechaCertificacionSAT);
                oConciliacionUUID.dtFechaCertificacionSAT = tmpdtFechaCertificacionSAT;

                oConciliacionUUID.dcMonto = Convert.ToDecimal(unRow[8].ToString());
                oConciliacionUUID.sEfectoComprobante = unRow[9].ToString();
                oConciliacionUUID.iEstatus = Convert.ToInt32(unRow[10].ToString());

                DateTime.TryParse(unRow[11].ToString(), out tmpdtFechaFechaCancelacion);
                oConciliacionUUID.dtFechaFechaCancelacion = tmpdtFechaFechaCancelacion;

                oConciliacionUUID.dtFechaFechaCancelacion = oConciliacionUUID.dtFechaFechaCancelacion == new DateTime(0001, 01, 01) ? new DateTime(1900, 01, 01) : oConciliacionUUID.dtFechaFechaCancelacion;

                oConciliacionUUID.sNombreArchivo = unRow[12].ToString();
                oConciliacionUUID.sObservacionesSAIC = unRow[13].ToString();

                stpSelValidacionConciliacionUUIDTableAdapter1.Fill(dbSAICBPOContabilidad1.stpSelValidacionConciliacionUUID,
                    oConciliacionUUID.sUUID,
                    oConciliacionUUID.sRFCEmisor,
                    oConciliacionUUID.sNomreEmisor,
                    oConciliacionUUID.sRFCReceptor,
                    oConciliacionUUID.sNombreReceptor,
                    oConciliacionUUID.sRFCPAC,
                    oConciliacionUUID.dtFechaEmision,
                    oConciliacionUUID.dtFechaCertificacionSAT,
                    oConciliacionUUID.dcMonto,
                    oConciliacionUUID.sEfectoComprobante,
                    oConciliacionUUID.iEstatus,
                    oConciliacionUUID.dtFechaFechaCancelacion);


                if (dbSAICBPOContabilidad1.stpSelValidacionConciliacionUUID.Rows.Count > 0)
                {
                    unRow["IdPDOHeaderCFDI"] = dbSAICBPOContabilidad1.stpSelValidacionConciliacionUUID.Rows[0]["IdPDOHeaderCFDI"];
                    unRow["IdPDOHeader"] = dbSAICBPOContabilidad1.stpSelValidacionConciliacionUUID.Rows[0]["IdPDOHeader"];
                    unRow["IdLoteCargaNomina"] = dbSAICBPOContabilidad1.stpSelValidacionConciliacionUUID.Rows[0]["IdLoteCargaNomina"];
                    unRow["FolioFiscalUUID"] = dbSAICBPOContabilidad1.stpSelValidacionConciliacionUUID.Rows[0]["FolioFiscalUUID"];
                    unRow["RFC"] = dbSAICBPOContabilidad1.stpSelValidacionConciliacionUUID.Rows[0]["RFC"];
                    unRow["MontoPagado"] = dbSAICBPOContabilidad1.stpSelValidacionConciliacionUUID.Rows[0]["MontoPagado"];
                    unRow["DifereniciaArchivoSAIC"] = dbSAICBPOContabilidad1.stpSelValidacionConciliacionUUID.Rows[0]["DifereniciaArchivoSAIC"];
                    unRow["EstadoCFDI"] = dbSAICBPOContabilidad1.stpSelValidacionConciliacionUUID.Rows[0]["EstadoCFDI"];
                    unRow["EstatusDocumento"] = dbSAICBPOContabilidad1.stpSelValidacionConciliacionUUID.Rows[0]["EstatusDocumento"];
                    unRow["Fecha Pago"] = dbSAICBPOContabilidad1.stpSelValidacionConciliacionUUID.Rows[0]["FechaPago"];
                    unRow["FechaCancelacionSAIC"] = dbSAICBPOContabilidad1.stpSelValidacionConciliacionUUID.Rows[0]["FechaCancelacion"];
                    unRow["Observaciones SAIC"] = dbSAICBPOContabilidad1.stpSelValidacionConciliacionUUID.Rows[0]["ObservacionesSAIC"];
                }
                else
                {
                    unRow["Observaciones SAIC"] = "UUID NO SE ENCUENTRA EN SAIC";
                }

            }
            catch (Exception ex)
            {
                unRow["Observaciones SAIC"] = "Error - " + ex.Message;
            }

            return unRow;
        }
    }
    class ConciliacionUUID
    {
        public ConciliacionUUID()
        {
            sUUID = String.Empty;
            sRFCEmisor = String.Empty;
            sNomreEmisor = String.Empty;
            sRFCReceptor = String.Empty;
            sNombreReceptor = String.Empty;
            sRFCPAC = String.Empty;
            dtFechaEmision = new DateTime(1900, 01, 01);
            dtFechaCertificacionSAT = new DateTime(1900, 01, 01);
            dcMonto = 0;
            sEfectoComprobante = String.Empty;
            iEstatus = 0;
            dtFechaFechaCancelacion = new DateTime(1900, 01, 01);
            sNombreArchivo = String.Empty;
            sObservacionesSAIC = String.Empty;
        }

        public String sUUID { get; set; }
        public String sRFCEmisor { get; set; }
        public String sNomreEmisor { get; set; }
        public String sRFCReceptor { get; set; }
        public String sNombreReceptor { get; set; }
        public String sRFCPAC { get; set; }
        public DateTime dtFechaEmision { get; set; }
        public DateTime dtFechaCertificacionSAT { get; set; }
        public decimal dcMonto { get; set; }

        public String sEfectoComprobante { get; set; }
        public int iEstatus { get; set; }
        public DateTime dtFechaFechaCancelacion { get; set; }

        public String sNombreArchivo { get; set; }
        public String sObservacionesSAIC { get; set; }


        public int IdPDOHeaderCFDI { get; set; }
        public int IdPDOHeader { get; set; }
        public int IdLoteCargaNomina { get; set; }
        public String FolioFiscalUUID { get; set; }
        public String RFC { get; set; }
        public decimal MontoPagado { get; set; }
        public decimal DifereniciaArchivoSAIC { get; set; }
        public String EstadoCFDI { get; set; }
        public String EstatusDocumento { get; set; }
        public DateTime FechaCancelacion { get; set; }

    }
}