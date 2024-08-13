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
using Excel = Microsoft.Office.Interop.Excel;
using compCatalogosSAIC;

namespace winAppSAIC.IMSS
{
    public partial class XtraCreditosInfonavitMasivos : DevExpress.XtraEditors.XtraForm
    {
        tools.dsc dsc = new tools.dsc();

        DataTable dtEmpleadsoInfonavit = new DataTable();
        List<empleadoInfonavit> lstEmpleadoInfonavit = new List<empleadoInfonavit>();
        public XtraCreditosInfonavitMasivos()
        {
            InitializeComponent();
        }

        private void btnSeleccionarExcel_Click(object sender, EventArgs e)
        {
            String stRutaArchivo = String.Empty;
            OpenFileDialog ofdSelecFile = new OpenFileDialog();
            ofdSelecFile.Filter = "Excel Files (*.xls;*.xlsm;*.xlsb;*.xlsx)|*.xls;*.xlsm;*.xlsb;*.xlsx";
            ofdSelecFile.ShowDialog();
            stRutaArchivo = ofdSelecFile.FileName;

            if (File.Exists(stRutaArchivo))
            {
                splashScreenManager1.ShowWaitForm();
                splashScreenManager1.SetWaitFormCaption("Obteniendo Empleados");
                txtNombreArchivo.Text = ofdSelecFile.SafeFileName;

                DataTable dtDatosEmpleados = new DataTable();
                //dtDatosEmpleados = ObtenerDatosExcel(stRutaArchivo);
                dtDatosEmpleados = dsc.ConvertExcelToDataTable(stRutaArchivo, "E");

                lstEmpleadoInfonavit.Clear();
                lstEmpleadoInfonavit = convertirEmpleados(dtDatosEmpleados);
                dtEmpleadsoInfonavit = EmpleadosADatatable(lstEmpleadoInfonavit);

                //gridControlEmpleados.DataSource = dtDatosEmpleados;
                gridControlEmpleados.DataSource = dtEmpleadsoInfonavit;
                txtNumEmpleados.Text = dtEmpleadsoInfonavit.Rows.Count.ToString();

                tctEmpleadoConError.Text = (from x in dtEmpleadsoInfonavit.AsEnumerable()
                                            where !String.IsNullOrEmpty(x.Field<String>("Observaciones SAIC"))
                                            select x).ToList().Count.ToString();

                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
            }
        }

        private DataTable EmpleadosADatatable(List<empleadoInfonavit> lstEmpleadoInfonavit)
        {
            DataTable dtDatos = ObtenerColumnas();

            foreach (empleadoInfonavit oEmpleadoInfonavit in lstEmpleadoInfonavit)
            {
                DataRow unRow = dtDatos.NewRow();
                unRow["idCreditoINFONAVIT"] = oEmpleadoInfonavit.IdCreditoINFONAVIT;
                unRow["IdEmpleado"] = oEmpleadoInfonavit.idEmpleado;
                unRow["Nombre Completo Empleado"] = oEmpleadoInfonavit.sNombreCompletoEmpleado;
                unRow["NSS"] = oEmpleadoInfonavit.sNSS;
                unRow["idTenedora"] = oEmpleadoInfonavit.idTenedora;
                unRow["Registro Patronal"] = oEmpleadoInfonavit.sRegistroPatronal;
                unRow["Razon Social Tenedora"] = oEmpleadoInfonavit.sRazonSocial;
                unRow["Nombre Comercial Tenedora"] = oEmpleadoInfonavit.sNombreComercial;
                unRow["Tipo Descuento"] = oEmpleadoInfonavit.sTipoDescuento;
                unRow["Valor Descuento"] = oEmpleadoInfonavit.dmalValorDescuento;
                unRow["Fecha Inicio Descuento"] = oEmpleadoInfonavit.dtFechaInicioDescuento;
                unRow["Numero de Credito"] = oEmpleadoInfonavit.sNumeroCreditoInfonavit;
                unRow["Observaciones SAIC"] = oEmpleadoInfonavit.sObservacionesSAIC;

                int resul = (from x in lstEmpleadoInfonavit
                             where x.sNSS.Equals(oEmpleadoInfonavit.sNSS)
                             select x).ToList().Count;

                if (resul > 1)
                {
                    unRow["Observaciones SAIC"] += "; Empleado repetido en Archivo";
                }

                dtDatos.Rows.Add(unRow);
            }


            return dtDatos;

        }

        private List<empleadoInfonavit> convertirEmpleados(DataTable dtEmpleados)
        {
            List<empleadoInfonavit> lstEmpleadoInfonavit = new List<empleadoInfonavit>();

            int iConta = 0;
            foreach (DataRow unRow in dtEmpleados.Rows)
            {
                iConta++;
                splashScreenManager1.SetWaitFormDescription(iConta + " de " + dtEmpleados.Rows.Count);
                empleadoInfonavit oempleadoInfonavit = new empleadoInfonavit();

                decimal dmalValor = 0;
                decimal.TryParse(unRow[3].ToString(), out dmalValor);

                //oempleadoInfonavit.sRegistroPatronal = unRow[0].ToString().Trim();
                oempleadoInfonavit.sNSS = unRow[0].ToString().Trim();

                //DateTime dtFecha;
                //DateTime.TryParse(unRow[3].ToString().Trim(), out dtFecha);
                //oempleadoInfonavit.dtFechaInicioDescuento = dtFecha;

                oempleadoInfonavit.sTipoDescuento = unRow[2].ToString().Trim();
                oempleadoInfonavit.dmalValorDescuento = dmalValor;
                oempleadoInfonavit.sNumeroCreditoInfonavit = unRow[4].ToString().Trim();


                stpSelValidarEmpleadosInfonatitTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelValidarEmpleadosInfonatit, 1,
                    oempleadoInfonavit.sRegistroPatronal,
                    oempleadoInfonavit.sNSS,
                    oempleadoInfonavit.sTipoDescuento,
                    oempleadoInfonavit.dmalValorDescuento,
                    oempleadoInfonavit.sNumeroCreditoInfonavit,
                     oempleadoInfonavit.dtFechaInicioDescuento
                    );

                if (dbSAICBPOCatalogosDataSet1.stpSelValidarEmpleadosInfonatit.Rows.Count > 0)
                {
                    int idCreditoINFONAVIT = 0;
                    int idEmpleado = 0;
                    int idTenedora = 0;

                    int.TryParse(dbSAICBPOCatalogosDataSet1.stpSelValidarEmpleadosInfonatit.Rows[0]["IdCreditoINFONAVIT"].ToString(), out idCreditoINFONAVIT);
                    oempleadoInfonavit.IdCreditoINFONAVIT = idCreditoINFONAVIT;

                    int.TryParse(dbSAICBPOCatalogosDataSet1.stpSelValidarEmpleadosInfonatit.Rows[0]["IdEmpleado"].ToString(), out idEmpleado);
                    oempleadoInfonavit.idEmpleado = idEmpleado;

                    int.TryParse(dbSAICBPOCatalogosDataSet1.stpSelValidarEmpleadosInfonatit.Rows[0]["IdTenedora"].ToString(), out idTenedora);
                    oempleadoInfonavit.idTenedora = idTenedora;

                    oempleadoInfonavit.sNombreCompletoEmpleado = dbSAICBPOCatalogosDataSet1.stpSelValidarEmpleadosInfonatit.Rows[0]["NombreEmpleadoCompleto"].ToString();
                    oempleadoInfonavit.sRazonSocial = dbSAICBPOCatalogosDataSet1.stpSelValidarEmpleadosInfonatit.Rows[0]["RazonSocial"].ToString();
                    oempleadoInfonavit.sNombreComercial = dbSAICBPOCatalogosDataSet1.stpSelValidarEmpleadosInfonatit.Rows[0]["NombreComercial"].ToString();
                    oempleadoInfonavit.sObservacionesSAIC = dbSAICBPOCatalogosDataSet1.stpSelValidarEmpleadosInfonatit.Rows[0]["ObservacionesSAIC"].ToString();
                    oempleadoInfonavit.sRegistroPatronal = dbSAICBPOCatalogosDataSet1.stpSelValidarEmpleadosInfonatit.Rows[0]["RegistroPatronalIMSS"].ToString();
                }
                else
                {
                    oempleadoInfonavit.sObservacionesSAIC = "Empleados no Existe en SAIC";
                }

                lstEmpleadoInfonavit.Add(oempleadoInfonavit);
            }

            return lstEmpleadoInfonavit;
        }

        private void XtraCreditosInfonavitMasivos_Load(object sender, EventArgs e)
        {
            dtEmpleadsoInfonavit = ObtenerColumnas();
            lblEmpleadosSeleccionados.Text = "0";
        }

        private DataTable ObtenerColumnas()
        {
            DataTable dtColumnas = new DataTable();
            dtColumnas.Columns.Add("idCreditoINFONAVIT", typeof(int));
            dtColumnas.Columns.Add("IdEmpleado", typeof(int));
            dtColumnas.Columns.Add("Nombre Completo Empleado", typeof(String));
            dtColumnas.Columns.Add("NSS", typeof(String));
            dtColumnas.Columns.Add("idTenedora", typeof(int));
            dtColumnas.Columns.Add("Registro Patronal", typeof(String));
            dtColumnas.Columns.Add("Razon Social Tenedora", typeof(String));
            dtColumnas.Columns.Add("Nombre Comercial Tenedora", typeof(String));
            dtColumnas.Columns.Add("Fecha Inicio Descuento", typeof(DateTime));
            dtColumnas.Columns.Add("Tipo Descuento", typeof(String));
            dtColumnas.Columns.Add("Valor Descuento", typeof(decimal));
            dtColumnas.Columns.Add("Numero de Credito", typeof(String));
            dtColumnas.Columns.Add("Observaciones SAIC", typeof(String));
            return dtColumnas;
        }

        private DataTable ObtenerDatosExcel(String stRuta)
        {

            Excel.Application appExcel;
            Excel.Workbooks booksExcel;
            Excel.Workbook bookExcel;
            Excel.Worksheet SheetExcel;
            Excel.Range miRango;

            String nombreHoja = String.Empty;
            DataTable dt = new DataTable();

            appExcel = new Excel.Application();
            booksExcel = appExcel.Workbooks;
            appExcel.Visible = true;
            appExcel.DisplayAlerts = false;

            bookExcel = booksExcel.Open(stRuta);

            List<String> lsHojasExcel = new List<String>();
            foreach (Excel.Worksheet hojas in bookExcel.Sheets)
            {
                lsHojasExcel.Add(hojas.Name.ToString());
            }
            nombreHoja = hojaSeleccionada(lsHojasExcel);

            if (!String.IsNullOrEmpty(nombreHoja))
            {
                ((Excel.Worksheet)appExcel.Sheets[nombreHoja]).Select();
                SheetExcel = (Excel.Worksheet)bookExcel.ActiveSheet;
                //dsc.quitarFormatoHoja(SheetExcel, "A2");
                miRango = dsc.UltimoCelda(SheetExcel);
                String ultimaCelda = miRango.get_AddressLocal(false, false, Excel.XlReferenceStyle.xlA1, false, false);
                miRango = SheetExcel.get_Range("A2", ultimaCelda);
                miRango.Select();
                miRango.Copy();
                String losDatos = Clipboard.GetText();
                System.Threading.Thread.Sleep(2000);
                dt = dsc.ConvertToDataTable(losDatos);
                appExcel.DisplayAlerts = true;
            }

            bookExcel.Save();
            bookExcel.Close();
            booksExcel.Close();
            appExcel.Quit();

            return dt;
        }

        private String hojaSeleccionada(List<String> lsHojasExcel)
        {
            String hojaSeleccionada = String.Empty;

            if (lsHojasExcel.Count > 1)
            {
                using (var form = new tools.xtFormSelectItem("Seleccione la Hoja", lsHojasExcel))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        hojaSeleccionada = form.stValorSeleccioando;
                    }
                }
            }
            else
            {
                hojaSeleccionada = lsHojasExcel[0];
            }

            return hojaSeleccionada;
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            OperadoresM.XtraAltaEmpleados oXtraAltaEmpleados = new OperadoresM.XtraAltaEmpleados(String.Empty);
            String stRutaArchivo = dsc.stRutaSAICIMSS;
            oXtraAltaEmpleados.descargarPlantillaAltaEmpleados(11, stRutaArchivo);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridViewEmpleados_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            seleccionarEmpleados();
        }

        private void seleccionarEmpleados()
        {
            for (int i = 0; i < gridViewEmpleados.RowCount; i++)
            {
                if (gridViewEmpleados.GetDataRow(i)["Observaciones SAIC"].ToString() != String.Empty)
                {
                    gridViewEmpleados.UnselectRow(i);
                }
            }

            lblEmpleadosSeleccionados.Text = gridViewEmpleados.SelectedRowsCount.ToString();

            if (gridViewEmpleados.SelectedRowsCount > 0)
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dtEmpleadsoInfonavit.Clear();
            gridControlEmpleados.DataSource = dtEmpleadsoInfonavit;
            lstEmpleadoInfonavit.Clear();
            txtNumEmpleados.Text = "0";
            tctEmpleadoConError.Text = "0";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridViewEmpleados.SelectedRowsCount > 0)
                {

                    DialogResult oDialogResult = XtraMessageBox.Show("¿Esta seguro de subir " + gridViewEmpleados.SelectedRowsCount + " creditos de Infonavit?",
                                "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (DialogResult.Yes == oDialogResult)
                    {
                        splashScreenManager1.ShowWaitForm();

                        List<String> lstRespuesta = new List<String>();
                        String stmensaje = String.Empty;
                        int iConta = 0;
                        for (int i = 0; i < gridViewEmpleados.SelectedRowsCount; i++)
                        {
                            iConta++;
                            splashScreenManager1.SetWaitFormDescription(iConta + " de " + gridViewEmpleados.SelectedRowsCount);

                            var resul = (from x in lstEmpleadoInfonavit
                                         where x.sNSS.Equals(gridViewEmpleados.GetDataRow(gridViewEmpleados.GetSelectedRows()[i])["NSS"].ToString())
                                         select x);

                            if (resul.Count() > 0)
                            {
                                String stResultado = String.Empty;

                                queriesTableAdapter1.stpInsCreditoInfonavit(resul.ElementAt<empleadoInfonavit>(0).sNSS,
                                    resul.ElementAt<empleadoInfonavit>(0).sNumeroCreditoInfonavit,
                                    resul.ElementAt<empleadoInfonavit>(0).sTipoDescuento,
                                    resul.ElementAt<empleadoInfonavit>(0).dmalValorDescuento,
                                    resul.ElementAt<empleadoInfonavit>(0).dtFechaInicioDescuento,
                                    OperadorBD.OperadorGlobal.NombreUsuario,
                                    ref stResultado);

                                lstRespuesta.Add(stResultado);
                                gridViewEmpleados.GetDataRow(gridViewEmpleados.GetSelectedRows()[i])["Observaciones SAIC"] = stResultado;
                            }
                        }

                        var res = from x in lstRespuesta
                                  group lstRespuesta by x
                                  into resul
                                  select new
                                  {
                                      Resultado = resul.Key,
                                      Cuantos = resul.Count()
                                  };

                        foreach (var item in res)
                        {
                            stmensaje += item.Resultado + ": " + item.Cuantos + Environment.NewLine;
                        }

                        if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }

                        XtraMessageBox.Show("Proceso Terminado" + Environment.NewLine +
                            stmensaje, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Seleccione un registro para continuar", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                XtraMessageBox.Show("Error al guardar creditos" + Environment.NewLine +
                       ex.Message, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewEmpleados_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                if (e.RowHandle >= 0)
                {
                    gridViewEmpleados.OptionsSelection.EnableAppearanceFocusedRow = false;

                    if (gridViewEmpleados.GetDataRow(e.RowHandle)["Observaciones SAIC"].ToString().Contains("CORRECTAMENTE"))
                    {
                        e.Appearance.BackColor = Color.FromArgb(152, 255, 152);
                        e.Appearance.BackColor2 = Color.White;
                        e.HighPriority = true;
                    }
                }
            }
            catch (Exception) { }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            gridViewEmpleados.SelectAll();
        }

        private void btnDesSelectAll_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            for (int i = 0; i < gridViewEmpleados.RowCount; i++)
                gridViewEmpleados.UnselectRow(i);
        }
    }


    public class empleadoInfonavit
    {

        public empleadoInfonavit()
        {
            idEmpleado = 0;
            sNombreCompletoEmpleado = String.Empty;
            sNSS = String.Empty;
            idTenedora = 0;
            sNombreComercial = String.Empty;
            sRazonSocial = String.Empty;
            sRegistroPatronal = String.Empty;
            sTipoDescuento = String.Empty;
            dmalValorDescuento = 0;
            sObservacionesSAIC = String.Empty;
            sNumeroCreditoInfonavit = String.Empty;
            IdCreditoINFONAVIT = 0;
            dtFechaInicioDescuento = new DateTime(1900, 01, 01);
            idCreditoINFONAVIT = 0;
        }

        public int idEmpleado { get; set; }
        public String sNombreCompletoEmpleado { get; set; }
        public String sNSS { get; set; }
        public int idTenedora { get; set; }
        public String sNombreComercial { get; set; }
        public String sRazonSocial { get; set; }
        public String sRegistroPatronal { get; set; }
        public String sTipoDescuento { get; set; }
        public decimal dmalValorDescuento { get; set; }
        public String sNumeroCreditoInfonavit { get; set; }
        public String sObservacionesSAIC { get; set; }
        public int IdCreditoINFONAVIT { get; set; }
        public DateTime dtFechaInicioDescuento { get; set; }
        int idCreditoINFONAVIT { get; set; }
    }
}