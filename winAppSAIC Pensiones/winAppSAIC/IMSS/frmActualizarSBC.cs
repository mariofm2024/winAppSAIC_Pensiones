using compCatalogosSAIC;
using compLibreriaSAIC;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace winAppSAIC.IMSS
{
    public partial class frmActualizarSBC : DevExpress.XtraEditors.XtraForm
    {

        DataTable dtEmpleadosArchivo;
        String[] StTitulos_IMSS;
        String[] StTitulos_JURIDICO;
        String stAreaOperativa = String.Empty;
        String stLog;
        tools.dsc dsc = new tools.dsc();

        public frmActualizarSBC(String stAreaOperativa)
        {
            InitializeComponent();
            this.stAreaOperativa = stAreaOperativa;
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dbSAICBPODataSet.stpSelMes' table. You can move, or remove it, as needed.
                this.stpSelObtenerEmpleadoSDITableAdapter.Fill(this.dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerEmpleadoSDI, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            try
            {
                groupControl1.Visible = true;

                String stRutaSaic = String.Empty;
                stRutaSaic = stAreaOperativa == "IMSS" ? dsc.stRutaSAICIMSS : dsc.stRutaSAICJuridico;

                dsc.CheckandCreateFolder(stRutaSaic);
                stRutaSaic += stAreaOperativa + " Empleados - " + dsc.nombreAleatorio() + ".xlsx";
                gvdInfonavit.ExportToXlsx(stRutaSaic);
                groupControl1.Visible = false;
                XtraMessageBox.Show("Descarga con exito." + Environment.NewLine + "Ruta: " + stRutaSaic, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("No se puede descargar la Información" + ex.Message, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmActualizarMontosRecup_Load(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();

                this.Text = stAreaOperativa == "IMSS" ? "Actualizar de S.D.I." : "Actualizar de S.D. y S.D.I.";

                this.stpSelObtenerEmpleadoSDITableAdapter.Fill(this.dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerEmpleadoSDI, 0);
                txtLiga.Text = "";
                InicializarTitulos();
                InicilizarDtEmpleados();
                gridView1.Columns[5].Visible = stAreaOperativa == "IMSS" ? false : true;
                dtFechaCaculoSD.DateTime = ObtenerFechaServidor();
                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            ObtenerArchivo.Filter = "Excel Files (*.xls;*.xlsm;*.xlsb;*.xlsx)|*.xls;*.xlsm;*.xlsb;*.xlsx";
            ObtenerArchivo.ShowDialog();
            txtLiga.Text = ObtenerArchivo.FileName;
        }

        private void btnCargarRecupe_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtDatos = new DataTable();
                DataRow row = null;
                int? pOk;
                string pErrores = "Los empleados que no se Actualizaron Son:";
                string pErroUMA = "El S.D.I. > 25 UMAs, Los Empleados son:";
                if (txtLiga.Text.Trim().Length > 0)
                {
                    dtDatos = ConvertExcelToDataTable(txtLiga.Text.Trim());
                    if (dtDatos.Rows.Count > 0)
                    {
                        for (int i = 0; i < dtDatos.Rows.Count; i++)
                        {
                            row = dtDatos.Rows[i];
                            if (Convert.ToDecimal(row[6].ToString().Replace(",", "").Replace("$", "")) > 0)
                            {
                                pOk = 0;
                                actualizacionesIMSSTableAdapter1.stpUpdActualizarSDI(Convert.ToInt32(row[0].ToString()), Math.Round(Convert.ToDecimal(row[6].ToString().Replace(",", "").Replace("$", "")), 2), OperadorBD.OperadorGlobal.NombreUsuario, ref pOk);
                                if (pOk == 1)
                                    pErrores = pErrores + row[0].ToString() + ", ";
                                else if (pOk == 2)
                                    pErroUMA = pErroUMA + row[0].ToString() + ", ";
                            }
                        }
                        if (pErrores != "Los empleados que no se Actualizaron Son:")
                            XtraMessageBox.Show(pErrores, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (pErroUMA != "El S.D.I. > 25 UMAs, Los Empleados son:")
                            XtraMessageBox.Show(pErrores, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        XtraMessageBox.Show(String.Format("!El Archivo no cumple con las columnas requeridas!."), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.stpSelObtenerEmpleadoSDITableAdapter.Fill(this.dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerEmpleadoSDI, 0);
                }
                else
                    XtraMessageBox.Show(String.Format("!Debes de Cargar el Archivo de Actualización!."), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stRutaArchivo">Ruta del Archivo de Excel a Leer</param>
        /// <param name="stUltimaColumna">Ultima columna del Rango para Obtener los Datos Ejemplo: "B", "Z", "AX"</param>
        /// <returns></returns>
        private DataTable ConvertExcelToDataTable(String stRutaArchivo)
        {
            DataTable dtDatos = new DataTable();

            String ultimaCelda = String.Empty;
            String losDatos = String.Empty;
            String stUltimaColumna = "G";
            Excel.Application appExcel;
            Excel.Workbooks booksExcel;
            Excel.Workbook bookExcel = null;
            Excel.Worksheet SheetExcel;
            Excel.Range unRango;

            appExcel = new Excel.Application();
            booksExcel = appExcel.Workbooks;

            try
            {
                appExcel.Visible = true;
                appExcel.DisplayAlerts = false;
                bookExcel = booksExcel.Open(stRutaArchivo);
                ((Excel.Worksheet)appExcel.Sheets[1]).Select();
                SheetExcel = (Excel.Worksheet)bookExcel.ActiveSheet;
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Por favor asegúrese de Cerrar la ventana de Validacion de Office y despues de Click en Aceptar de este mensaje."
                          , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                ((Excel.Worksheet)appExcel.Sheets[1]).Select();
                SheetExcel = (Excel.Worksheet)bookExcel.ActiveSheet;
                unRango = SheetExcel.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
                ultimaCelda = unRango.get_AddressLocal(false, false, Excel.XlReferenceStyle.xlA1, false, false);
                unRango = SheetExcel.get_Range("A2", stUltimaColumna + soloNumeros(ultimaCelda));
                unRango.Select();
                unRango.Copy();
                System.Threading.Thread.Sleep(2000);
                losDatos = Clipboard.GetText();
                losDatos = losDatos.ToUpper();
                dtDatos = ConvertToDataTable(losDatos);
                appExcel.Quit();
            }

            return dtDatos;

        }

        private String soloNumeros(String valor)
        {
            Regex regex = new Regex("[A-Z]");
            return regex.Replace(valor, "");
        }

        private DataTable ConvertToDataTable(String stLosDatos)
        {
            stLosDatos = stLosDatos.Replace("\r", "");
            DataTable valores = new DataTable();
            String[] registros = stLosDatos.Split('\n');
            int iContaColumnas = 0;

            for (int i = 0; i < registros.Length; i++)
            {
                if (!String.IsNullOrEmpty(registros[i]))
                {
                    DataRow unData = valores.NewRow();
                    String[] rows = registros[i].Split('\t');

                    if (iContaColumnas == 0)
                    {
                        for (int col = 0; col < rows.Length; col++) { valores.Columns.Add(); }
                        iContaColumnas++;
                    }

                    for (int cel = 0; cel < rows.Length; cel++)
                    {
                        unData[cel] = rows[cel].Trim();
                    }

                    valores.Rows.Add(unData);
                }
            }

            return valores;
        }

        private void btnValidarInformacion_Click(object sender, EventArgs e)
        {
            try
            {
                stLog = dsc.iniLog("Validacion Actualizacion Masiva " + this.Text + " " + stAreaOperativa, OperadorBD.OperadorGlobal.NombreUsuario);
                if (String.IsNullOrEmpty(txtRutaArchivo.Text))
                {
                    stLog = dsc.addLog(stLog, "Obteniendo Excel");
                    ObtenerArchivo.Filter = "Excel Files (*.xls;*.xlsm;*.xlsb;*.xlsx)|*.xls;*.xlsm;*.xlsb;*.xlsx";
                    ObtenerArchivo.ShowDialog();
                    txtRutaArchivo.Text = ObtenerArchivo.FileName;
                    stLog = dsc.addLog(stLog, "Excel: " + ObtenerArchivo.FileName);
                }

                if (!String.IsNullOrEmpty(ObtenerArchivo.FileName))
                {
                    if (File.Exists(txtRutaArchivo.Text))
                    {
                        splashScreenManager1.ShowWaitForm();

                        String stUltimaColumna = String.Empty;
                        String stLasColumnas = String.Empty;

                        stUltimaColumna = stAreaOperativa == "IMSS" ? "F" : "G";

                        stLog = dsc.addLog(stLog, "Obteniendo Columnas");
                        if (stAreaOperativa == "IMSS")
                        {
                            stUltimaColumna = "F";
                            stLasColumnas = String.Join("", StTitulos_IMSS).ToUpper().Replace(" ", "");
                        }
                        else
                        {
                            stUltimaColumna = "G";
                            stLasColumnas = String.Join("", StTitulos_JURIDICO).ToUpper().Replace(" ", "");
                        }

                        splashScreenManager1.SetWaitFormDescription("Obteniendo Informacion");
                        stLog = dsc.addLog(stLog, "Obteniendo Informacion");

                        DataTable dtArchivoEmpleado = dsc.ConvertExcelToDataTable(txtRutaArchivo.Text, stUltimaColumna);

                        if (dtArchivoEmpleado.Rows.Count > 1)
                        {
                            //Validar titulos
                            String stLasColumnasArchivo = String.Empty;

                            foreach (DataColumn item in dtArchivoEmpleado.Columns) { stLasColumnasArchivo += item.ColumnName; }

                            splashScreenManager1.SetWaitFormDescription("Validando Columnas");
                            stLog = dsc.addLog(stLog, "Validando Columnas");

                            if (dsc.fonetica(stLasColumnas, stLasColumnasArchivo))
                            {
                                //Validar Informacion
                                validarInformacionLayOut(dtArchivoEmpleado);
                                txtRutaArchivo.Text = String.Empty;
                                dtFechaCaculoSD.Enabled = false;

                                stLog = dsc.addLog(stLog, "Proceso de Validacion Terminado");
                                splashScreenManager1.SetWaitFormDescription("Proceso Terminado");
                                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                            }
                            else
                            {
                                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                                XtraMessageBox.Show("El LayOut que se selecciono no contiene la estructura correcta, por favor seleccione unLayOut valido."
                             , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                            XtraMessageBox.Show("El Archivo seleccionado no cuenta con informacion."
                              , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }
                        XtraMessageBox.Show("No existe el Archivo seleccionado: " + txtRutaArchivo.Text
                              , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }

                stLog = dsc.addLog(stLog, "Error en proceso: " + ex.Message);
                stLog = dsc.finLog(stLog);
                dsc.guardarLog(stLog);

                XtraMessageBox.Show("Error al cargar información de Actualizacion de Salario."
                              , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InicializarTitulos()
        {
            StTitulos_IMSS = new String[]
            {
                "Id Empleado",
                "Nombre Empleado Completo",
                "NSS",
                "RFC",
                "CURP",
                "S.D.I."
            };

            StTitulos_JURIDICO = new String[]
           {
                "Id Empleado",
                "Nombre Empleado Completo",
                "NSS",
                "RFC",
                "CURP",
                "S.D.",
                "S.D.I."
           };
        }

        private void validarInformacionLayOut(DataTable dtEmpleadoLayOut)
        {
            groupControl1.Visible = true;
            int iConta = 1;

            stLog = dsc.addLog(stLog, "Obteniendo empleados de la base");

            DataTable stEmpleadosHR = dsc.deGridViewaDataTable(gridView1);
            groupControl1.Visible = false;
            foreach (DataRow drEmpleado in dtEmpleadoLayOut.Rows)
            {
                String stError = String.Empty;
                int idEmpleado = 0;
                Decimal dSD = 0.00m;
                Decimal dSDI = 0.00m;

                DataRow drEmpleadosArchivo = dtEmpleadosArchivo.NewRow();

                try
                {
                    splashScreenManager1.SetWaitFormDescription("Validando:" + iConta + " de " + dtEmpleadoLayOut.Rows.Count);
                    stLog = dsc.addLog(stLog, "Validando:" + iConta + " de " + dtEmpleadoLayOut.Rows.Count);

                    int.TryParse(drEmpleado["Id Empleado"].ToString(), out idEmpleado);

                    if (stAreaOperativa == "JURIDICO")
                        decimal.TryParse(drEmpleado["S.D."].ToString().Replace("$", ""), out dSD);

                    decimal.TryParse(drEmpleado["S.D.I."].ToString().Replace("$", ""), out dSDI);

                    //Validar si el empleado existe
                    DataRow[] existeEmpleado = stEmpleadosHR.Select("IdEmpleado = " + "'" + drEmpleado[0] + "'");
                    if (existeEmpleado.Length > 0)
                    {
                        if (existeEmpleado[0].ItemArray[2].ToString() + existeEmpleado[0].ItemArray[3].ToString() + existeEmpleado[0].ItemArray[4].ToString() ==
                            drEmpleado["NSS"].ToString() + drEmpleado["RFC"].ToString() + drEmpleado["CURP"].ToString())
                        {
                            if (stAreaOperativa == "IMSS")
                                decimal.TryParse(existeEmpleado[0].ItemArray[5].ToString(), out dSD);

                            stpSelValidacionActualizacionEmpleadosMasiva_SD_SDITableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelValidacionActualizacionEmpleadosMasiva_SD_SDI,
                                stAreaOperativa,
                                idEmpleado,
                                dSD,
                                dSDI,
                                dtFechaCaculoSD.DateTime,
                                ref stError
                                );
                        }
                        else
                        {
                            //Los datos del empleado NSS, RFC o CURP con coinciden con los de SAIC.
                            stError = "Los datos del empleado NSS, RFC o CURP con coinciden con los de SAIC";
                        }
                    }
                    else
                    {
                        //No existe el empleado en SAIC
                        stError = "No existe el empleado en SAIC";
                    }

                }
                catch (Exception ex)
                {
                    stError = "Error: " + ex.Message;
                }

                drEmpleadosArchivo["Id Empleado"] = idEmpleado;
                drEmpleadosArchivo["Nombre Empleado Completo"] = drEmpleado["Nombre Empleado Completo"];
                drEmpleadosArchivo["NSS"] = drEmpleado["NSS"];
                drEmpleadosArchivo["RFC"] = drEmpleado["RFC"];
                drEmpleadosArchivo["CURP"] = drEmpleado["CURP"];
                drEmpleadosArchivo["SD"] = dSD;
                drEmpleadosArchivo["SDI"] = dSDI;
                drEmpleadosArchivo["Errores"] = stError;

                dtEmpleadosArchivo.Rows.Add(drEmpleadosArchivo);
                iConta++;
            }

            stLog = dsc.addLog(stLog, "Mostrando Informacion");
            splashScreenManager1.SetWaitFormDescription("Mostrando Información");
            gCtrlEmpleados.DataSource = dtEmpleadosArchivo;

            lblTotaldeEmpleados.Text = dtEmpleadosArchivo.Rows.Count.ToString();
            lblEmpleadosConError.Text = dtEmpleadosArchivo.Select("Errores <> ''").Count().ToString();
            gridViewEmpleados.OptionsSelection.EnableAppearanceFocusedRow = true;
        }

        private void InicilizarDtEmpleados()
        {
            dtEmpleadosArchivo = new DataTable();

            dtEmpleadosArchivo.Columns.Add("Id Empleado", typeof(int));
            dtEmpleadosArchivo.Columns.Add("Nombre Empleado Completo", typeof(String));
            dtEmpleadosArchivo.Columns.Add("NSS", typeof(String));
            dtEmpleadosArchivo.Columns.Add("RFC", typeof(String));
            dtEmpleadosArchivo.Columns.Add("CURP", typeof(String));
            dtEmpleadosArchivo.Columns.Add("SD", typeof(decimal));
            dtEmpleadosArchivo.Columns.Add("SDI", typeof(decimal));
            dtEmpleadosArchivo.Columns.Add("Errores", typeof(String));
        }

        private DateTime ObtenerFechaServidor()
        {
            // Obtener la fecha del servidor
            DateTime dtFechaServidor = new DateTime();
            String stfechaServidor = String.Empty;
            stfechaServidor = stpSelEstatusNominaContabilizadaTableAdapter1.ObtenerFechaServidor().ToString();
            DateTime.TryParse(stfechaServidor, out dtFechaServidor);
            return dtFechaServidor;
        }

        private void gridViewEmpleados_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            for (int i = 0; i < gridViewEmpleados.RowCount; i++)
            {
                if (gridViewEmpleados.GetDataRow(i)["Errores"].ToString() != String.Empty)
                {
                    gridViewEmpleados.UnselectRow(i);
                }
            }
        }

        private void gCtrlEmpleados_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            gridViewEmpleados.SelectAll();
        }

        private void btnDesSelectAll_Click(object sender, EventArgs e)
        {
            DeseleccionarTodo();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                stLog = dsc.iniLog("Actualizacion Informacion " + this.Text + " " + stAreaOperativa, OperadorBD.OperadorGlobal.NombreUsuario);
                stLog = dsc.addLog(stLog, "Proceso de Actualizacion");
                int iConta = 0;
                int? iOk = 0;
                for (int i = 0; i < gridViewEmpleados.SelectedRowsCount; i++)
                {
                    try
                    {
                        splashScreenManager1.SetWaitFormDescription("Actualizando: " + iConta + " de " + gridViewEmpleados.SelectedRowsCount);
                        stLog = dsc.addLog(stLog, "Actualizando: " + iConta + " de " + gridViewEmpleados.SelectedRowsCount);

                        actualizacionesIMSSTableAdapter1.stpUpdActualizacionMasiva_SD_SDI(
                            stAreaOperativa,
                             Convert.ToInt32(gridViewEmpleados.GetDataRow(gridViewEmpleados.GetSelectedRows()[i])["Id Empleado"]),
                             Convert.ToDecimal(gridViewEmpleados.GetDataRow(gridViewEmpleados.GetSelectedRows()[i])["SD"]),
                             Convert.ToDecimal(gridViewEmpleados.GetDataRow(gridViewEmpleados.GetSelectedRows()[i])["SDI"]),
                             OperadorBD.OperadorGlobal.NombreUsuario,
                             ref iOk
                            );

                        if (iOk == 1)
                        {
                            gridViewEmpleados.GetDataRow(gridViewEmpleados.GetSelectedRows()[i])["Errores"] = "Actualizado";
                        }

                        iConta++;
                    }
                    catch (Exception ex)
                    {
                        gridViewEmpleados.GetDataRow(gridViewEmpleados.GetSelectedRows()[i])["Errores"] = "Error: " + ex.Message;
                    }
                }

                DeseleccionarTodo();

                if (splashScreenManager1.IsSplashFormVisible) { splashScreenManager1.CloseWaitForm(); }

                stLog = dsc.addLog(stLog, "Proceso de Actualización Terminado");
                MessageBox.Show("Empleados Actualizados: " + iConta, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                stLog = dsc.addLog(stLog, "Error en Proceso: " + ex.Message);
                stLog = dsc.finLog(stLog);
                dsc.guardarLog(stLog);
            }
        }

        private void DeseleccionarTodo()
        {
            for (int i = 0; i < gridViewEmpleados.RowCount; i++)
                gridViewEmpleados.UnselectRow(i);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dtFechaCaculoSD.Enabled = true;
            gCtrlEmpleados.DataSource = null;
            lblEmpleadosConError.Text = "0";
            lblRegistrosSeleccionados.Text = "0";
            lblTotaldeEmpleados.Text = "0";

        }

        private void dtFechaCaculoSD_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}


