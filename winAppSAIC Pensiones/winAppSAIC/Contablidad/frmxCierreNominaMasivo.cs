using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Diagnostics;
using compCatalogosSAIC;

namespace winAppSAIC.Contablidad
{
    public partial class frmxCierreNominaMasivo : DevExpress.XtraEditors.XtraForm
    {
        tools.dsc DSC = new tools.dsc();
        String stTitulos = String.Empty;
        List<String> stListMeses = new List<string>();

        DataTable losDatos;
        DataTable dtCloned = new DataTable();
        DataTable dtLotesContabilizados = new DataTable();
        DataTable dtLotesContabilizadosSASC = new DataTable();
        DataTable dtLotesContabilizadosCierre = new DataTable();
        DataTable dtTipoPoliza = new DataTable();

        int ilotesSeleccionados = 0;

        Dictionary<String, String> Calendario = new Dictionary<String, String>();

        public frmxCierreNominaMasivo()
        {
            InitializeComponent();
            inicializarVariables();
            gridView1.OptionsBehavior.ReadOnly = true;

            Calendario.Add("ENERO", "1");
            Calendario.Add("FEBRERO", "2");
            Calendario.Add("MARZO", "3");
            Calendario.Add("ABRIL", "4");
            Calendario.Add("MAYO", "5");
            Calendario.Add("JUNIO", "6");
            Calendario.Add("JULIO", "7");
            Calendario.Add("AGOSTO", "8");
            Calendario.Add("SEPTIEMBRE", "9");
            Calendario.Add("OCTUBRE", "10");
            Calendario.Add("NOVIEMBRE", "11");
            Calendario.Add("DICIEMBRE", "12");
        }

        private void btnDescargarFormato_Click(object sender, EventArgs e)
        {
            try
            {
                descargarFormatoCierreNomina();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("No se puede descargar el formato para cierre de nominas masivo." + Environment.NewLine + Environment.NewLine + ex.Message,
                  "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblLotesValidos_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                splashScreenManager1.SetWaitFormCaption("Cargando");
                splashScreenManager1.SetWaitFormCaption("Iniciando Varibales");
                inicializarVariables();
                String stPathFile = selectArchivo();
                losDatos = new DataTable();
                if (!String.IsNullOrEmpty(stPathFile))
                {
                    int iLotesValidos;
                    lblNombreArchivo.Text = Path.GetFileName(stPathFile);
                    splashScreenManager1.SetWaitFormCaption("Obteniendo Excel");
                    losDatos = abrirArchivo(stPathFile);
                    splashScreenManager1.SetWaitFormCaption("Validando Lotes");
                    iLotesValidos = validacionesDatos();
                    if (iLotesValidos > 0)
                    {
                        splashScreenManager1.SetWaitFormCaption("Proceso Terminado");
                        if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                        btnDescargarLotesInvalidos.Enabled = true;
                        XtraMessageBox.Show("Plantilla Cargada con Exito. Por favor revise la informacion.",
                            "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
            }
            catch (Exception ex)
            {
                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                XtraMessageBox.Show("No se puede cargar la informacion de la plantilla." + Environment.NewLine + ex.Message,
                           "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private String selectArchivo()
        {
            OpenFileDialog ofdSelecFile = new OpenFileDialog();
            ofdSelecFile.Filter = "Excel Files|*.xlsx;*.xlsm;*.xlsb;*.xltx;*.xltm;*.xls;*.xlt;*.xls;*‌​.xml;*.xml;*.xlam";
            ofdSelecFile.Multiselect = true;
            ofdSelecFile.Title = "Seleccione Archivo SUA";
            ofdSelecFile.ShowDialog();
            return ofdSelecFile.FileName;
        }

        private DataTable abrirArchivo(String stPathArchivo)
        {
            Excel.Application appExcel;
            Excel.Workbooks booksExcel;
            Excel.Workbook bookExcel;
            Excel.Worksheet SheetExcel;
            Excel.Range miRango;

            String nombreHoja = String.Empty;
            DataTable dtLotes = new DataTable();

            appExcel = new Excel.Application();
            booksExcel = appExcel.Workbooks;
            appExcel.Visible = true;
            appExcel.DisplayAlerts = false;

            bookExcel = booksExcel.Open(stPathArchivo);

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
                DSC.quitarFormatoHoja(SheetExcel, "A2");
                miRango = DSC.UltimoCelda(SheetExcel);
                String ultimaCelda = miRango.get_AddressLocal(false, false, Excel.XlReferenceStyle.xlA1, false, false);
                miRango = SheetExcel.get_Range("A2", "H" + DSC.soloNumeros(ultimaCelda));
                miRango.Select();
                miRango.Copy();
                String losDatos = Clipboard.GetText();
                System.Threading.Thread.Sleep(2000);
                dtLotes = DSC.ConvertToDataTable(losDatos);
                if (dtLotes.Columns.Count == 8)
                {
                    dtLotes.Columns[0].ColumnName = "Lote";
                    dtLotes.Columns[1].ColumnName = "Tipo Poliza";
                    dtLotes.Columns[2].ColumnName = "Folio Poliza";
                    dtLotes.Columns[3].ColumnName = "Fecha Poliza";
                    dtLotes.Columns[4].ColumnName = "Importe Poliza";
                    dtLotes.Columns[5].ColumnName = "Mes Pago";
                    dtLotes.Columns[6].ColumnName = "Año Pago";
                    dtLotes.Columns[7].ColumnName = "Observaciones";
                    dtLotes.Columns.Add("Folio Lote Carga Nomina");
                    dtLotes.Columns.Add("Estatus");

                    dtLotes.Columns["Folio Lote Carga Nomina"].SetOrdinal(1);
                    //dtLotes = limpiarTable(dtLotes);
                }

                appExcel.DisplayAlerts = true;
                bookExcel.Save();
                bookExcel.Close();
                booksExcel.Close();
                appExcel.Quit();
            }
            return dtLotes;
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

        private int validacionesDatos()
        {
            int iLotesInvalidos = 0;
            if (losDatos.Rows.Count > 0 && losDatos.Columns.Count == 10)
            {
                losDatos = quitarFilasEnBlanco(losDatos);
                losDatos = limpiarColumnaEstatus(losDatos);
                losDatos = validaciones(losDatos);
                losDatos = obtenerDatosColumnas(losDatos);
                losDatos = revisarDatosRepetidos(losDatos);
                lblTotalRegistros.Text = "Total de Lotes en Documento: " + losDatos.Rows.Count;
                GridControlContabilizarLotes.DataSource = losDatos;
                convertirImportes(losDatos);
                lblLotesValid.Text = "Lotes Validos: " + totalLotesValidos(losDatos);
                iLotesInvalidos = totalLotesInValidos(losDatos);
                lblLotesInvalidos.Text = "Lotes Invalidos: " + iLotesInvalidos;
            }
            else
            {
                XtraMessageBox.Show("No hay informacion en el archivo o las columnas no son correctas.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return iLotesInvalidos;
        }

        private void descargarFormatoCierreNomina()
        {
            Excel.Application appExcel;
            Excel.Workbooks booksExcel;
            Excel.Workbook bookExcel;
            Excel.Worksheet SheetExcel;
            Excel.Range Rango;

            appExcel = new Excel.Application();
            booksExcel = appExcel.Workbooks;
            bookExcel = booksExcel.Add();
            appExcel.Visible = true;

            try
            {
                appExcel.DisplayAlerts = false;
                appExcel.WindowState = Excel.XlWindowState.xlMaximized;
                System.Threading.Thread.Sleep(1000);
                Clipboard.SetText(stTitulos);

                SheetExcel = (Excel.Worksheet)bookExcel.ActiveSheet;
                SheetExcel.Name = "Cierre de Nomina";

                Rango = SheetExcel.get_Range("A1");
                Rango.Select();
                Rango.PasteSpecial();
                System.Threading.Thread.Sleep(1000);

                Rango = SheetExcel.get_Range("A1:H1");
                Rango.Select();
                Rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                Rango.VerticalAlignment = Excel.XlVAlign.xlVAlignBottom;

                Rango.Interior.Pattern = Excel.XlPattern.xlPatternSolid;
                Rango.Interior.ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic;
                Rango.Interior.ThemeColor = Excel.XlThemeColor.xlThemeColorAccent6;
                Rango.Interior.TintAndShade = -0.499984740745262;
                Rango.Interior.PatternTintAndShade = 0;

                Rango.Font.Bold = true;
                Rango.Font.ThemeColor = Excel.XlThemeColor.xlThemeColorDark1;
                Rango.Font.TintAndShade = 0;
                Rango.Font.Size = 12;
                Rango.Cells.Select();
                Rango.EntireColumn.AutoFit();

                Excel.Borders border = Rango.Borders;
                border.LineStyle = Excel.XlLineStyle.xlContinuous;
                border.Weight = 2d;

                Rango = SheetExcel.get_Range("A1");
                Rango.Select();

                appExcel.DisplayAlerts = true;

                XtraMessageBox.Show("Formato descargado con Exito",
                  "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception Ex)
            {
                XtraMessageBox.Show("Si se abrio la ventana de Validacion de Office por favor cierrela y despues de Click en aceptar en este mensaje para continuar.",
                    "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                appExcel.DisplayAlerts = false;
                appExcel.WindowState = Excel.XlWindowState.xlMaximized;
                System.Threading.Thread.Sleep(1000);
                Clipboard.SetText(stTitulos);

                SheetExcel = (Excel.Worksheet)bookExcel.ActiveSheet;
                SheetExcel.Name = "Cierre de Nomina";

                Rango = SheetExcel.get_Range("A1");
                Rango.Select();
                Rango.PasteSpecial();

                System.Threading.Thread.Sleep(1000);

                Rango = SheetExcel.get_Range("A1:H1");
                Rango.Select();
                Rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                Rango.VerticalAlignment = Excel.XlVAlign.xlVAlignBottom;

                Rango.Interior.Pattern = Excel.XlPattern.xlPatternSolid;
                Rango.Interior.ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic;
                Rango.Interior.ThemeColor = Excel.XlThemeColor.xlThemeColorAccent6;
                Rango.Interior.TintAndShade = -0.499984740745262;
                Rango.Interior.PatternTintAndShade = 0;

                Rango.Font.Bold = true;
                Rango.Font.ThemeColor = Excel.XlThemeColor.xlThemeColorDark1;
                Rango.Font.TintAndShade = 0;
                Rango.Font.Size = 12;
                Rango.Cells.Select();
                Rango.EntireColumn.AutoFit();

                Rango = SheetExcel.get_Range("A1:H5");
                Rango.Select();

                Excel.Borders border = Rango.Borders;
                border.LineStyle = Excel.XlLineStyle.xlContinuous;
                border.Weight = 2d;

                Rango = SheetExcel.get_Range("A1");
                Rango.Select();

                appExcel.DisplayAlerts = true;

                XtraMessageBox.Show("Formato descargado con Exito",
                  "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void inicializarVariables()
        {
            stTitulos = "Lote" + "\t" +
                "Tipo Poliza" + "\t" +
                "Folio Poliza" + "\t" +
                "Fecha Poliza" + "\t" +
                "Importe Poliza" + "\t" +
                "Mes Pago" + "\t" +
                "Año" + "\t" +
                "Observaciones";

            lblLotesValid.Text = "Lotes Validos: " + totalLotesValidos(losDatos);
            lblLotesInvalidos.Text = "Lotes Invalidos: " + totalLotesInValidos(losDatos);
            lblTotalRegistros.Text = "Total de Registros: ";

            stListMeses.Add("ENERO");
            stListMeses.Add("FEBRERO");
            stListMeses.Add("MARZO");
            stListMeses.Add("ABRIL");
            stListMeses.Add("MAYO");
            stListMeses.Add("JUNIO");
            stListMeses.Add("JULIO");
            stListMeses.Add("AGOSTO");
            stListMeses.Add("SEPTIEMBRE");
            stListMeses.Add("OCTUBRE");
            stListMeses.Add("NOVIEMBRE");
            stListMeses.Add("DICIEMBRE");

        }

        private int totalLotesValidos(DataTable dtDatos)
        {
            int itotalLotesValidos = 0;
            decimal dcmImportePoliza = 0;

            if (dtDatos != null)
            {
                try
                {
                    itotalLotesValidos = (from x in dtDatos.AsEnumerable()
                                          where x.Field<String>("Estatus").Equals(String.Empty)
                                          select x).CopyToDataTable().Rows.Count;

                    dcmImportePoliza = (from x in dtCloned.AsEnumerable()
                                        where x.Field<String>("Estatus").Equals(String.Empty)
                                        select x).CopyToDataTable().AsEnumerable().Sum(y => y.Field<Decimal>("Importe Poliza"));

                    lblImportesValidos.Text = "Importe Lotes Validos: " + dcmImportePoliza.ToString("C");
                }
                catch (Exception) { }
            }

            return itotalLotesValidos;
        }

        private int totalLotesInValidos(DataTable dtDatos)
        {
            //dtDatos = quitarFilasEnBlanco(dtDatos);
            int itotalLotesInValidos = 0;
            decimal dcmImportePoliza = 0;

            if (dtDatos != null)
            {
                try
                {
                    itotalLotesInValidos = (from x in dtDatos.AsEnumerable()
                                            where !x.Field<String>("Estatus").Equals(String.Empty)
                                            select x).CopyToDataTable().Rows.Count;

                    dcmImportePoliza = (from x in dtCloned.AsEnumerable()
                                        where !x.Field<String>("Estatus").Equals(String.Empty)
                                        select x).CopyToDataTable().AsEnumerable().Sum(y => y.Field<Decimal>("Importe Poliza"));

                    lblImportesInvalidos.Text = "Importe Lotes Invalidos: " + dcmImportePoliza.ToString("C");
                }
                catch (Exception) { }
            }
            return itotalLotesInValidos;
        }

        private DataTable limpiarColumnaEstatus(DataTable dtDatos)
        {
            foreach (DataRow item in dtDatos.Rows)
            {
                item["Estatus"] = String.Empty;
            }
            return dtDatos;
        }

        private DataTable validaciones(DataTable dtDatos)
        {
            foreach (DataRow unRow in dtDatos.Rows)
            {
                unRow["Estatus"] += validarImporte(unRow["Importe Poliza"].ToString(), unRow);
                //unRow["Lote"] = DSC.StrExtract(unRow["Folio Lote Carga Nomina"].ToString(), "-L").Trim();

                DataRow[] resultado = dtLotesContabilizados.Select("idLoteCargaNomina = '" + unRow["Lote"] + "'");

                DataRow[] resultadoSASC = dtLotesContabilizadosSASC.Select("idLoteCargaNomina = '" + unRow["Lote"] + "'");

                DataRow[] resultadoCierre = dtLotesContabilizadosCierre.Select("idLoteCargaNomina = '" + unRow["Lote"] + "'");

                if (resultado.Length > 0)
                {
                    if (resultadoSASC.Length > 0)
                    {
                        unRow["Folio Lote Carga Nomina"] = resultado[0].ItemArray[1].ToString();
                        //if (resultado[0].ItemArray[4].ToString().ToUpper() == "TRUE" && resultadoSASC[0].ItemArray[2].ToString().ToUpper() == "TRUE")
                        if (resultado[0].ItemArray[4].ToString().ToUpper() == "TRUE")
                        {
                            unRow["Estatus"] += "Folio: " + resultado[0].ItemArray[0] + ": Cerrado (2)";
                        }
                        else if (resultado[0].ItemArray[3].ToString() == "True")
                        {
                            unRow["Estatus"] += "Folio: " + resultado[0].ItemArray[0] + ": No esta Activo.";
                        }
                    }
                    else
                    {
                        unRow["Estatus"] += "Folio: " + resultado[0].ItemArray[0] + ": No Existe (SASC). ";
                    }
                }
                else
                {
                    unRow["Estatus"] += "Folio: " + unRow["Lote"] + ": No Existe (Lote). ";
                }
            }
            return dtDatos;
        }

        private DataTable obtenerDatosColumnas(DataTable dtDatos)
        {
            foreach (DataRow unRow in dtDatos.Rows)
            {
                if (!unRow["Estatus"].ToString().Contains("No Existe"))
                {
                    unRow["Estatus"] += validarTipoPoliza(unRow["Tipo Poliza"].ToString());
                    unRow["Estatus"] += validarFechaPoliza(unRow["Fecha Poliza"].ToString());
                    unRow["Estatus"] += validarImporte(unRow["Importe Poliza"].ToString(), unRow);
                    unRow["Estatus"] += validarMesPago(unRow["Mes Pago"].ToString(), unRow);
                    unRow["Estatus"] += validarAnioPago(unRow["Año Pago"].ToString());
                }
            }
            return dtDatos;
        }

        private DataTable revisarDatosRepetidos(DataTable dtDatos)
        {
            foreach (DataRow item in dtDatos.Rows)
            {
                DataRow[] unRow = dtDatos.Select("[Lote] ='" + item["Lote"] + "'");
                if (unRow.Count() > 1)
                {
                    item["Estatus"] += "Folio Repetido en el Documento. ";
                }
            }

            return dtDatos;
        }

        private void convertirImportes(DataTable dtDatos)
        {
            Decimal dcmImportePoliza = 0;
            dtCloned = dtDatos.Clone();
            dtCloned.Columns["Importe Poliza"].DataType = typeof(Decimal);
            foreach (DataRow row in dtDatos.Rows)
            {
                try
                {
                    dtCloned.ImportRow(row);
                }
                catch (Exception) { }
            }

            dcmImportePoliza = dtCloned.AsEnumerable().Sum(x => x.Field<Decimal>("Importe Poliza"));
            lblImporteTotalPoliza.Text = "Importe Poliza Documento: " + dcmImportePoliza.ToString("C");
        }

        private String validarImporte(String stImportePoliza, DataRow unRow)
        {
            String stValor = String.Empty;


            Decimal dcmImporte = -1;
            Decimal.TryParse(stImportePoliza, out dcmImporte);
            if (dcmImporte == 0)
            {
                unRow["Importe Poliza"] = "0";
                stValor = "Importe Invalido. ";
            }

            return stValor;
        }

        private String validarTipoPoliza(String stTipoPoliza)
        {
            String stValor = String.Empty;
            DataRow[] unRow = dtTipoPoliza.Select("DescTipoPoliza = '" + stTipoPoliza.ToUpper() + "'");
            if (unRow.Length == 0)
            {
                stValor = "Tipo de Poliza Invalida. ";
            }
            return stValor;
        }

        private String validarFechaPoliza(String stFechaPoliza)
        {
            String stValor = String.Empty;
            DateTime dtimeFechaPoliza = new DateTime();
            DateTime.TryParse(stFechaPoliza, out dtimeFechaPoliza);
            if (dtimeFechaPoliza.Date.ToString().Contains("01/01/0001"))
            {
                stValor = "Fecha Poliza: Invalida. ";
            }
            return stValor;
        }

        private String validarMesPago(String stMesPago, DataRow unRow)
        {
            String stValor = String.Empty;
            if (Calendario.ContainsKey(stMesPago.ToUpper()))
            {
                unRow["Mes Pago"] = Calendario[stMesPago.ToUpper()];
            }
            else if (Calendario.ContainsValue(stMesPago.ToString()))
            {
                unRow["Mes Pago"] = stMesPago;
            }
            else
            {
                stValor = "Mes Pago Incorrecto. ";
            }

            return stValor;
        }

        private String validarAnioPago(String stAnioPago)
        {
            String stValor = String.Empty;
            int ianio = 0;
            Int32.TryParse(stAnioPago, out ianio);

            if (ianio > 0)
            {
                DateTime dtimeAnioPago = new DateTime(ianio, 01, 01);
                if (dtimeAnioPago.Year < 2012)
                {
                    stValor = "Año de Poliza No puede ser Menor que al año 2012. ";
                }

                if (dtimeAnioPago.Year > DateTime.Now.Year + 1)
                {
                    stValor = "Año de Poliza No puede ser mayor al año " + (DateTime.Now.Year + 1) + ". ";
                }
            }
            else
            {
                stValor = "Año de Poliza Invalida. ";
            }
            return stValor;
        }

        private void btnCerrarNominas_Click(object sender, EventArgs e)
        {
            String stBitacora = String.Empty;
            int ilotesSeleccionados = gridView1.SelectedRowsCount;
            int iConta = 0;
            if (ilotesSeleccionados > 0)
            {
                splashScreenManager1.ShowWaitForm();
                DataTable dtDatosSelecionados = obtenerLotesSeleccionados();

                foreach (DataRow unRow in dtDatosSelecionados.Rows)
                {
                    DateTime? dFecha = new DateTime();
                    DateTime? dFechaInicio = new DateTime();
                    DateTime? dFechaFin = new DateTime();

                    dFecha = Convert.ToDateTime(unRow["Fecha Poliza"]);
                    dFechaInicio = Convert.ToDateTime(unRow["FechaInicio"]);
                    dFechaFin = Convert.ToDateTime(unRow["FechaFin"]);

                    try
                    {
                        queriesTableAdapter1.stpUpdCierreNomina(
                        Convert.ToInt32(unRow["Lote"]),
                        Convert.ToString(unRow["Folio Lote Carga Nomina"]),
                        Convert.ToString(unRow["Tipo Poliza"]),
                        Convert.ToInt32(unRow["Folio Poliza"]),
                        dFecha,
                        Convert.ToDecimal(unRow["Importe Poliza"].ToString()),
                        Convert.ToString(unRow["Observaciones"]),
                        Convert.ToInt32(unRow["Mes Pago"]),
                        Convert.ToInt32(unRow["Año Pago"]),

                        OperadorBD.OperadorGlobal.IdOperador,
                        OperadorBD.OperadorGlobal.NombreUsuario,
                        Convert.ToInt32(unRow["IdTenedora"]),
                        Convert.ToInt32(unRow["IdCliente"]),
                        Convert.ToInt32(unRow["IdTipoPeriodoNomina"]),
                        dFechaInicio,
                        dFechaFin
                            );
                        iConta++;
                    }
                    catch (Exception ex)
                    {
                        if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                        stBitacora += "Error al Actualizar Lote: " + unRow["Lote"] + " - " + ex.Message + Environment.NewLine;
                    }
                }

                //for (int i = 0; i < dtDatosSelecionados.Count; i++)
                //{
                //    try
                //    {
                //        queriesTableAdapter1.stpUpdCierreNomina(dtDatosSelecionados[i], );
                //    }
                //    catch (Exception ex)
                //    {
                //        stBitacora += "Error al Actualizar Lote: " + dtDatosSelecionados[i] + " - " + ex.Message + Environment.NewLine;
                //    }
                //}

                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }

                if (stBitacora == String.Empty)
                {
                    XtraMessageBox.Show("Nominas Cerradas con Exito: " + iConta, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargadeDatos();
                    losDatos = validaciones(losDatos);
                    GridControlContabilizarLotes.DataSource = losDatos;
                }
                else
                {
                    String stPath = @"C:\SAIC\temp\";
                    String stFile = stPath + "CierreNomina - " + DSC.nombreAleatorio() + ".log";
                    DSC.CheckandCreateFolder(stPath);
                    File.WriteAllText(stFile, stBitacora);
                    Process.Start(stFile);
                }
            }

            splashScreenManager1.ShowWaitForm();
            splashScreenManager1.SetWaitFormCaption("Cargando");
            splashScreenManager1.SetWaitFormDescription("Espere Por Favor...");
            cargadeDatos();
            validacionesDatos();
            if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
        }

        private void cargadeDatos()
        {
            stpSelLotesContabilizadosTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelLotesContabilizados);
            dtLotesContabilizados = dbSAICBPOCatalogosDataSet1.stpSelLotesContabilizados;

            stpSelLotesContabilizadosSASCTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelLotesContabilizadosSASC);
            dtLotesContabilizadosSASC = dbSAICBPOCatalogosDataSet1.stpSelLotesContabilizadosSASC;

            stpSelLotesContabilizadosCierreTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelLotesContabilizadosCierre);
            dtLotesContabilizadosCierre = dbSAICBPOCatalogosDataSet1.stpSelLotesContabilizadosCierre;

            stpSelTipoPolizaTableAdapter1.Fill(dbSAICBPODataSet1.stpSelTipoPoliza);
            dtTipoPoliza = dbSAICBPODataSet1.stpSelTipoPoliza;
        }

        private DataTable obtenerLotesSeleccionados()
        {
            DataTable dtLotesSeleccionados = losDatos.Clone();

            dtLotesSeleccionados.Columns.Add("IdTenedora").DataType = typeof(int);
            dtLotesSeleccionados.Columns.Add("IdCliente").DataType = typeof(int);
            dtLotesSeleccionados.Columns.Add("IdTipoPeriodoNomina").DataType = typeof(int);
            dtLotesSeleccionados.Columns.Add("FechaInicio").DataType = typeof(DateTime);
            dtLotesSeleccionados.Columns.Add("FechaFin").DataType = typeof(DateTime);

            //dtLotesContabilizados

            for (int i = 0; i < gridView1.SelectedRowsCount; i++)
            {
                int iLote = 0;
                Int32.TryParse(gridView1.GetDataRow(gridView1.GetSelectedRows()[i])["Lote"].ToString(), out iLote);

                DataRow unRow = dtLotesSeleccionados.NewRow();
                unRow["Lote"] = iLote;
                unRow["Folio Lote Carga Nomina"] = gridView1.GetDataRow(gridView1.GetSelectedRows()[i])["Folio Lote Carga Nomina"].ToString();
                unRow["Tipo Poliza"] = gridView1.GetDataRow(gridView1.GetSelectedRows()[i])["Tipo Poliza"].ToString();
                unRow["Folio Poliza"] = gridView1.GetDataRow(gridView1.GetSelectedRows()[i])["Folio Poliza"].ToString();
                unRow["Fecha Poliza"] = gridView1.GetDataRow(gridView1.GetSelectedRows()[i])["Fecha Poliza"].ToString();
                unRow["Importe Poliza"] = gridView1.GetDataRow(gridView1.GetSelectedRows()[i])["Importe Poliza"].ToString();
                unRow["Mes Pago"] = gridView1.GetDataRow(gridView1.GetSelectedRows()[i])["Mes Pago"].ToString();
                unRow["Año Pago"] = gridView1.GetDataRow(gridView1.GetSelectedRows()[i])["Año Pago"].ToString();
                unRow["Observaciones"] = gridView1.GetDataRow(gridView1.GetSelectedRows()[i])["Observaciones"].ToString();

                DataRow[] drRow = dtLotesContabilizados.Select("IdLoteCargaNomina = '" + iLote + "'");
                if (drRow.Count() > 0)
                {
                    unRow["IdTenedora"] = drRow[0].ItemArray[5];
                    unRow["IdCliente"] = drRow[0].ItemArray[6];
                    unRow["FechaInicio"] = drRow[0].ItemArray[7];
                    unRow["FechaFin"] = drRow[0].ItemArray[8];
                    unRow["IdTipoPeriodoNomina"] = drRow[0].ItemArray[9];
                }

                dtLotesSeleccionados.Rows.Add(unRow);

            }

            return dtLotesSeleccionados;
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            gridView1.SelectAll();
            obtenerImportesSeleccionados();
        }

        private void btnDesSelectAll_Click(object sender, EventArgs e)
        {
            btnCerrarNominas.Enabled = false;
            for (int i = 0; i < gridView1.RowCount; i++)
                gridView1.UnselectRow(i);
        }

        private void btnDescargarLotesInvalidos_Click(object sender, EventArgs e)
        {
            DataTable dtDatosInvalidos = new DataTable();
            String stDatos = String.Empty;
            String stPath = DSC.stRutaTemp;
            String stNombreArchivo = "SAIC Cierre de Nominas Lotes Invalidos " + DSC.nombreAleatorio() + ".txt";

            try
            {
                dtDatosInvalidos = (from x in losDatos.AsEnumerable()
                                    where !x.Field<String>("Estatus").Equals(String.Empty)
                                    select x).CopyToDataTable();

                stDatos = DSC.ConvertToString(dtDatosInvalidos, true);
            }
            catch (Exception) { }

            if (!String.IsNullOrEmpty(stDatos))
            {
                DSC.CheckandCreateFolder(stPath);
                File.WriteAllText(stPath + stNombreArchivo, stDatos);
                Process.Start(stPath + stNombreArchivo);
            }
            else
            {
                XtraMessageBox.Show("No hay datos para exportar", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void obtenerImportesSeleccionados()
        {
            ilotesSeleccionados = 0;
            Decimal dcmImporteSeleccionados = 0;
            Decimal dcmImporte = 0;

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (gridView1.GetDataRow(i)["Estatus"].ToString() != String.Empty) // CLABEIncorrecta
                {
                    gridView1.UnselectRow(i);
                }
                else
                {
                    ilotesSeleccionados++;
                    Decimal.TryParse(gridView1.GetDataRow(i)["Importe Poliza"].ToString(), out dcmImporte);
                    dcmImporteSeleccionados += dcmImporte;
                }
            }

            if (ilotesSeleccionados > 0)
            {
                btnCerrarNominas.Enabled = true;
            }
            else
            {
                btnCerrarNominas.Enabled = false;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargadeDatos();
            validacionesDatos();
        }

        private void frmxCierreNominaMasivo_Load(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                cargadeDatos();
                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("No puede cargar la información." + Environment.NewLine + ex.Message, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private DataTable quitarFilasEnBlanco(DataTable dtLotes)
        {
            if (dtLotes != null)
            {
                DataTable dtLotes_temp = dtLotes.Clone();
                var query = from x in dtLotes.AsEnumerable()
                            where x.Field<String>("Lote") != ""
                            select x;

                if (query.Count() > 0)
                {
                    dtLotes_temp = query.CopyToDataTable();
                }
                return dtLotes_temp;
            }
            else
            {
                return dtLotes;
            }
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            obtenerImportesSeleccionados();

            //if (e.Action == CollectionChangeAction.Add)
            //{
            //    if (gridView1.GetDataRow(e.ControllerRow)["Estatus"].ToString() != String.Empty)
            //    {
            //        gridView1.UnselectRow(e.ControllerRow);
            //    }
            //}

            habilidarCerraNomina();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void habilidarCerraNomina()
        {
            DataTable dtLotesValidos = DSC.deGridViewSelectedToDataTable(gridView1);
            int iLotesInvalidos = dtLotesValidos.Select("Estatus <> '" + String.Empty + "'").Count();
            if (iLotesInvalidos == 0)
            {
                if (gridView1.SelectedRowsCount > 0)
                {
                    btnCerrarNominas.Enabled = true;
                }
                else
                {
                    btnCerrarNominas.Enabled = false;
                }
            }
            else
            {
                btnCerrarNominas.Enabled = false;
            }
        }

    }
}