using compCatalogosSAIC;
using compLibreriaSAIC;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace winAppSAIC.IMSS
{
    public partial class frmActualizarMontosRecup : DevExpress.XtraEditors.XtraForm
    {
        public frmActualizarMontosRecup()
        {
            InitializeComponent();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show(String.Format("¿Está seguro que desea Eliminar las Recuperaciones?"), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    // TODO: This line of code loads data into the 'dbSAICBPODataSet.stpSelMes' table. You can move, or remove it, as needed.
                    this.actualizacionesIMSSTableAdapter1.stpUpdEliminarRecuperacion(OperadorBD.OperadorGlobal.NombreUsuario);
                }
                this.stpSelObtenerCreditosIMSSTableAdapter.Fill(this.dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerCreditosIMSS, 0);
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
                if (sfdRutaArchivo.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    gvdInfonavit.ExportToXls(sfdRutaArchivo.FileName);

                    //Solicitar la visualización del nuevo archivo en Excel
                    if (XtraMessageBox.Show("¿Desea abrir el archivo en Excel?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        // Mostrar resultado en Excel.
                        Utilerias.StartProcess(sfdRutaArchivo.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmActualizarMontosRecup_Load(object sender, EventArgs e)
        {
            try
            {
                this.stpSelObtenerCreditosIMSSTableAdapter.Fill(this.dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerCreditosIMSS,0);
                txtLiga.Text = "";
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
                if (txtLiga.Text.Trim().Length > 0)
                {
                    dtDatos = ConvertExcelToDataTable(txtLiga.Text.Trim());
                    if (dtDatos.Rows.Count > 0)
                    {
                        for(int i=0; i < dtDatos.Rows.Count; i++)
                        {
                            row = dtDatos.Rows[i];
                            if (Convert.ToDecimal(row[6].ToString().Replace(",","").Replace("$","")) > 0)
                            {
                                pOk = 0;
                                actualizacionesIMSSTableAdapter1.stpUpdActualizarRecuperacion(Convert.ToInt32(row[0].ToString()), Math.Round(Convert.ToDecimal(row[6].ToString().Replace(",", "").Replace("$", "")),2), OperadorBD.OperadorGlobal.NombreUsuario, ref pOk);
                                if (pOk == 1)
                                    pErrores = pErrores + row[0].ToString() + ", ";
                            }
                        }
                        if (pErrores != "Los empleados que no se Actualizaron Son:")
                            XtraMessageBox.Show( pErrores, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        XtraMessageBox.Show(String.Format("!El Archivo no cumple con las columnas requeridas!."), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.stpSelObtenerCreditosIMSSTableAdapter.Fill(this.dbSAICBPOActualizacionesIMSSDataSet.stpSelObtenerCreditosIMSS, 0);
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


    }
}