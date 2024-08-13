using System;
using System.Collections.Generic;

namespace compExport
{
    public class CreateExcelDoc
    {
        private Microsoft.Office.Interop.Excel.Application app = null;
        private Microsoft.Office.Interop.Excel.Workbook workbook = null;
        private Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
        private Microsoft.Office.Interop.Excel.Range workSheet_range = null;
        
        public CreateExcelDoc(string pRuta, string pNombreArchivo)
        {
            //crear archivo con Ruta y Nombre Archivo XLSX
            createDoc(pRuta, pNombreArchivo);    //constructor
        }

        //inicializar objeto Excel
        public void createDoc(string pRuta, string pNombreArchivo)
        {
            try
            {
                app = new Microsoft.Office.Interop.Excel.Application() { Visible = true};
                workbook = app.Workbooks.Add(1);
                //asignar nombre al archivo XLSX
                workbook.SaveAs(pRuta + pNombreArchivo, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, 
                    Type.Missing, Type.Missing, false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
    
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
            }
            catch (Exception e)
            {
                Console.Write("Error");
            }
        }

        /// <summary>
        /// Método para crear los encabezados dentro de un archivo de excel
        /// </summary>
        /// <param name="pRow">No. Renglon</param>
        /// <param name="pCol">No. Columna</param>
        /// <param name="pHeaderText">Texto a deplegar</param>
        /// <param name="pCell1">Celda 1 para merge</param>
        /// <param name="pCell2">Celda 2 para merge</param>
        /// <param name="pMergeColumns">No. Columnas involucradas para merge</param>
        /// <param name="pBackground">Color Fondo</param>
        /// <param name="pFont">Tipo de letra</param>
        /// <param name="pSize">Tamaño tipo de letra</param>
        /// <param name="pForeColor">Color letra</param>
        public void createHeaders(int pRow, int pCol, string pHeaderText, string pCell1, string pCell2, string pBackground, int pMergeColumns, bool pFont, int pSize, string pForeColor)
        {
            worksheet.Cells[pRow, pCol] = pHeaderText;
            workSheet_range = worksheet.get_Range(pCell1, pCell2);
            workSheet_range.Merge(pMergeColumns);
            switch (pBackground)
            {
                case "YELLOW":
                    workSheet_range.Interior.Color = System.Drawing.Color.Yellow.ToArgb();
                    break;
                case "GRAY":
                    workSheet_range.Interior.Color = System.Drawing.Color.Gray.ToArgb();
                    break;
                case "GAINSBORO":
                    workSheet_range.Interior.Color = System.Drawing.Color.Gainsboro.ToArgb();
                    break;
                case "Turquoise":
                    workSheet_range.Interior.Color = System.Drawing.Color.Turquoise.ToArgb();
                    break;
                case "PeachPuff":
                    workSheet_range.Interior.Color = System.Drawing.Color.PeachPuff.ToArgb();
                    break;
                default:
                    //  workSheet_range.Interior.Color = System.Drawing.Color..ToArgb();
                    break;

            }

            //asignar borde a la celda en color negro
            workSheet_range.Borders.Color = System.Drawing.Color.Black.ToArgb();
            workSheet_range.Font.Bold = pFont;
            workSheet_range.ColumnWidth = pSize;
            if (pForeColor.Equals(""))
            {
                workSheet_range.Font.Color = System.Drawing.Color.White.ToArgb();
            }
            else
            {
                workSheet_range.Font.Color = System.Drawing.Color.Black.ToArgb();
            }

        }

        /// <summary>
        /// Método para agregar informacion en una hoja de Excel
        /// </summary>
        /// <param name="row">No. Renglon</param>
        /// <param name="col">No. Columna</param>
        /// <param name="pData">Dato a procesar</param>
        /// <param name="pFormat">Codigo Formato</param>
        public void addData(int row, int col, string pData, string pFormat)
        {
            worksheet.Cells[row, col] = pData;
        }

        /// <summary>
        /// Método para inicializar valores en celdas de un archivo de excel
        /// </summary>
        /// <param name="pValueText">Texto a deplegar</param>
        /// <param name="pCell1">Celda 1 para merge</param>
        /// <param name="pCell2">Celda 2 para merge</param>
        public void assignInitialValue(string pValueText, string pCell1, string pCell2)
        {
            workSheet_range = worksheet.get_Range(pCell1, pCell2);
            workSheet_range.Value = pValueText;
        }

    }
}
