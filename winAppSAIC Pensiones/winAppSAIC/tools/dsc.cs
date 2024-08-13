using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace winAppSAIC.tools
{
    class dsc
    {
        #region Rutas
        //public String stRutaSAICOperaciones = @"C:\SAIC\Operaciones\";
        //public String stRutaSAICJURIDICO = @"C:\SAIC\Juridico\";
        //public String stRutaSAICIMSS = @"C:\SAIC\IMSS\";
        public String stRutaSAICSeguros = @"C:\SAIC\Seguros\";
        //public String stRutaSAICContabilidad = @"C:\SAIC\Contabilidad\";
        //public String stRutaTesoreria = @"C:\SAIC\Tesoreria\";
        public String stRutaTemp = @"C:\SAIC\temp\";
        public String stRutaSAIC = @"C:\SAIC\";
        public String stRutaSAICActualizacionDeLote = @"C:\SAIC\Actualizacion de Lote\";
        String StRutaConfig = @"C:\SAIC\Config.ini";
        #endregion

        //public String stRutaAltaSolicitudEmpelados_1 = @"C:\SAIC\Alta Empleados Solicitudes\";
        public String stRutaSAICPF = @"C:\SAIC\ADNA PF\";
        public String stRutaSAICOperaciones = ObtenerRutaSolicitudSAIC("Operaciones").ToString();
        public String stRutaSAICTesoreria = ObtenerRutaSolicitudSAIC("Tesoreria").ToString();
        public String stRutaSAICIMSS = ObtenerRutaSolicitudSAIC("IMSS").ToString();
        public String stRutaSAICJuridico = ObtenerRutaSolicitudSAIC("Juridico").ToString();
        public String stRutaSAICContabilidad = ObtenerRutaSolicitudSAIC("Contabilidad").ToString();


        //public String stRutaAltaSolicitudEmpleados = ObtenerRutaSolicitudEmpleados("Alta de Empleados").ToString();
        //public String stRutaBajaSolicitudEmpleados = ObtenerRutaSolicitudEmpleados("Baja de Empleados").ToString();
        //public String stRutaActualizacionSolicitudEmpleados = ObtenerRutaSolicitudEmpleados("Actualizacion de Cuenta").ToString();
        //public String stRutaSolicitudSalarios = ObtenerRutaSolicitudEmpleados("Solicitud de Salarios").ToString();
        //public String stRutaSolicitudAniversarios = ObtenerRutaSolicitudEmpleados("Solicitud de Aniversarios").ToString();
        //public String stRutaSolicitudVariables = ObtenerRutaSolicitudEmpleados("Solicitud de Variables").ToString();
        //public String stRutaSAIC_layOutsFondeo = ObtenerRutaSolicitudEmpleados("Fondeos LayOuts").ToString();
        //static public String stRutaSAIC_1 = ObtenerRutaSolicitudEmpleados("PF").ToString();

        public String stRutaEmpleados = ObtenerRutaEmpleados();

        public const String stRutaPlantillas = @"C:\SAIC\Plantillas\";
        public String stCaracteresEspeciales = ObtenerCadenaCaracteresEspeciales().ToString();
        public String stCaracteresEspeciales_1 = ObtenerCadenaCaracteresEspeciales_1().ToString();

        //public String stCaracteresEspeciales = @"!@#$%&/()?'¿¡*+;:[]=^`{|}~?çÇüãâäàåêëèìïîìÄÅæÆðõôöòüûùýÿÖÜ÷ø¦§©ª""®¯°±²³´µ·,¹°""¼½¾"".??^?<'´"".ÀÂÃÄÅÈÊËÌÎÏÐÒÔÕÖ×ØÙÛÜÝÞßþÁÉÍÓÚ";
        //public String stCaracteresEspeciales_1 = @"!@#$%&/()?'¿¡*+;:[]=^`{|}~?çÇüãâäàåêëèìïîìÄÅæÆðõôöòüûùýÿÖÜ÷ø¦§©ª""®¯°±²³´µ·¹°""¼½¾""??^?<'´""ÀÂÃÄÅÈÊËÌÎÏÐÒÔÕÖ×ØÙÛÜÝÞßþÁÉÍÓÚ";

        String[] ArrayCaracteres = null;
        public const String stRutaConexion = @"C:\SAIC\temp\ConfigSAIC.ini";

        #region Excel

        /// <summary>
        /// Retorna en una Lista los nombres de las Hojas de Un Libro de Excel.
        /// </summary>
        /// <param name="bookExcel">Libro de Excel que se quiere recuperar el Nombre de la Hojas.</param>
        /// <returns>Lista con los nombres de las Hojas en el Libro.</returns>
        public List<String> NombreHojas(Excel.Workbook bookExcel)
        {
            List<String> lsHojasExcel = new List<String>();
            foreach (Excel.Worksheet hojas in bookExcel.Sheets)
            {
                lsHojasExcel.Add(hojas.Name.ToString());
            }
            return lsHojasExcel;
        }

        private String[] StringArray(String CadenaCaracteresEspeciales)
        {
            String[] arrayst = new String[CadenaCaracteresEspeciales.Length];
            for (int i = 0; i < arrayst.Length; i++)
            {
                arrayst[i] = CadenaCaracteresEspeciales[i].ToString();
            }

            return arrayst;
        }

        public Excel.Range UltimoCelda(Excel.Worksheet SheetExcel)
        {
            Excel.Range unRango;

            try
            {
                unRango = SheetExcel.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Hay celdas activas, por favor presione Enter en la Hoja de Excel y despues de Click en continuar.", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                unRango = SheetExcel.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
            }

            return SheetExcel.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
        }

        public DataTable ConvertToDataTable(String datos, DataTable dtLosDatos)
        {
            datos = datos.Replace("\r", "");
            String[] registros = datos.Split('\n');
            String[] registrosTemp = registros;

            //Validacion por si no hay Registros en el Excel.
            registrosTemp = registrosTemp.Select(x => x.ToString().Replace("\t", "").Replace("\n", "")).ToArray();
            registrosTemp = registrosTemp.Where(x => !String.IsNullOrEmpty(x.ToString())).ToArray();

            if (registrosTemp.Length > 0)
            {
                for (int i = 0; i < registros.Length; i++)
                {
                    String[] celdas = registros[i].Split('\t');
                    if (celdas.Length >= dtLosDatos.Columns.Count)
                    {
                        DataRow valores = dtLosDatos.NewRow();
                        for (int j = 0; j < valores.ItemArray.Count(); j++)
                            valores[j] = celdas[j];

                        dtLosDatos.Rows.Add(valores);
                    }
                }
            }

            return dtLosDatos;
        }


        public DataTable ConvertToDataTableContitulos(String stLosDatos)
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
                        for (int col = 0; col < rows.Length; col++) { valores.Columns.Add(rows[col]); }
                        iContaColumnas++;
                    }
                    else
                    {
                        for (int cel = 0; cel < rows.Length; cel++)
                        {
                            unData[cel] = rows[cel].Trim();
                        }
                        valores.Rows.Add(unData);
                    }
                }
            }

            return valores;
        }

        public DataTable ConvertToDataTable(String stLosDatos)
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

        public DataTable ConvertToDataTable(String datos, int iCOlumnasVacias)
        {
            DataTable valores = new DataTable();
            try
            {
                datos = datos.Replace("\r", "");
                String[] registros = datos.Split('\n');
                int iContaColumnas = 0;

                for (int i = 0; i < registros.Length; i++)
                {
                    if (!String.IsNullOrEmpty(registros[i]))
                    {
                        DataRow unData = valores.NewRow();
                        String[] rows = registros[i].Split('\t');

                        if (rows.Where(x => String.IsNullOrEmpty(x)).ToList().Count != iCOlumnasVacias)
                        {
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
                }
            }
            catch (Exception ex)
            {

            }

            return valores;
        }

        public String ConvertToString(DataTable dtDatos, Boolean conColumnas)
        {
            String paraClip = String.Empty;

            if (conColumnas)
            {
                foreach (DataColumn dtItem in dtDatos.Columns)
                {
                    paraClip += dtItem.ColumnName + "\t";
                }
                paraClip += Environment.NewLine;
            }

            foreach (DataRow UnRow in dtDatos.Rows)
            {
                for (int i = 0; i < UnRow.ItemArray.Length; i++)
                {
                    paraClip += UnRow[i].ToString() + "\t";
                }

                paraClip += Environment.NewLine;
            }

            return paraClip;
        }
        public String ConvertToStringTransponer(DataTable dtDatos)
        {
            String paraClip = String.Empty;

            for (int j = 0; j < dtDatos.Columns.Count; j++)
            {
                for (int i = 0; i < dtDatos.Rows.Count; i++)
                {
                    paraClip += dtDatos.Rows[i][j].ToString() + "\t";
                }
                paraClip += Environment.NewLine;
            }

            return paraClip;
        }
        public String ConvertToStringTransponer(DataTable dtDatos, int columnaIni, int columnaFin)
        {
            String paraClip = String.Empty;

            if (columnaFin > dtDatos.Columns.Count)
            {
                columnaFin = dtDatos.Columns.Count;
            }

            for (int j = columnaIni; j < columnaFin; j++)
            {
                for (int i = 0; i < dtDatos.Rows.Count; i++)
                {
                    paraClip += dtDatos.Rows[i][j].ToString() + "\t";
                }
                paraClip += Environment.NewLine;
            }

            return paraClip;
        }

        /// <summary>
        /// Convierte una letra en Numero correspondiente a una columna en Excel.
        /// </summary>
        /// <param name="Columna">Letra de la columna a comvertir.</param>
        /// <returns></returns>
        public int ColumnaCorrespondiente(String Columna)
        {
            String letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int numColumna = 0;

            if (Columna.Length == 1)
            {
                if (letras.Contains(Columna))
                    numColumna = letras.IndexOf(Columna) + 1;
            }
            else if (Columna.Length == 2)
            {
                String pLetra = Columna[0].ToString();
                String sLetra = Columna[1].ToString();

                int posPLetra = 0;
                int posSLetra = 0;

                if (letras.Contains(pLetra))
                {
                    posPLetra = letras.IndexOf(pLetra) + 1;
                    posPLetra = posPLetra * 26;
                    posSLetra = letras.IndexOf(sLetra) + 1;
                    numColumna = posPLetra + posSLetra;
                }
            }

            return numColumna;
        }


        public String NumToLetterColumnExcel(int iNumeroColumna)
        {
            String letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            String stResut = "A";

            int pValor = iNumeroColumna / 26;
            int spValor = iNumeroColumna % 26;

            if (pValor > 0)
            {
                stResut = letras[pValor - 1].ToString();
            }

            if (spValor > 0)
            {
                stResut += letras[spValor - 1].ToString();
            }

            return stResut;

        }
        #endregion

        #region FOX

        public string StrExtract(string cSearchExpression, string cBeginDelim)
        {
            return StrExtract(cSearchExpression + "FoXPro", cBeginDelim, "FoXPro", 1, 0);
        }

        public string StrExtract(string cSearchExpression, string cBeginDelim, string cEndDelim)
        {
            return StrExtract(cSearchExpression, cBeginDelim, cEndDelim, 1, 0);
        }
        public string StrExtract(string[] cSearchExpression1, string cBeginDelim, string cEndDelim)
        {
            string cSearchExpression = String.Join("", cSearchExpression1);
            return StrExtract(cSearchExpression, cBeginDelim, cEndDelim, 1, 0);
        }

        public String StrExtract(string cSearchExpression, string cBeginDelim, string cEndDelim, int nBeginOccurence, int nFlags)
        {
            string cstring = cSearchExpression; string cb = cBeginDelim; string ce = cEndDelim; string lcRetVal = "";

            try
            {
                if (nFlags == 1) { cstring = cstring.ToLower(); cb = cb.ToLower(); ce = ce.ToLower(); }

                int nbpos = At(cb, cstring, nBeginOccurence) + cb.Length - 1;
                int nepos = cstring.IndexOf(ce, nbpos + 1);

                if (nepos > nbpos)
                {
                    lcRetVal = cSearchExpression.Substring(nbpos, nepos - nbpos);
                }
            }
            catch (Exception) { }

            return lcRetVal;
        }

        public String StrExtract(string[] cSearchExpression1, string cBeginDelim, string cEndDelim, int nBeginOccurence, int nFlags)
        {
            string cSearchExpression = cSearchExpression1.Select(x => x.ToString().Replace("\r\n", Environment.NewLine)).ToString();
            string cstring = cSearchExpression; string cb = cBeginDelim; string ce = cEndDelim; string lcRetVal = "";

            if (nFlags == 1) { cstring = cstring.ToLower(); cb = cb.ToLower(); ce = ce.ToLower(); }

            int nbpos = At(cb, cstring, nBeginOccurence) + cb.Length - 1;
            int nepos = cstring.IndexOf(ce, nbpos + 1);

            if (nepos > nbpos)
            {
                lcRetVal = cSearchExpression.Substring(nbpos, nepos - nbpos);
            }
            return lcRetVal;
        }

        private int At(string cSearchFor, string cSearchIn, int nOccurence) { return __at(cSearchFor, cSearchIn, nOccurence, 1); }
        private int __at(string cSearchFor, string cSearchIn, int nOccurence, int nMode)
        {   //In this case we actually have to locate the occurence	
            int i = 0; int nOccured = 0; int nPos = 0; if (nMode == 1) { nPos = 0; } else { nPos = cSearchIn.Length; }
            //Loop through the string and get the position of the requiref occurence	
            for (i = 1; i <= nOccurence; i++)
            {
                if (nMode == 1) { nPos = cSearchIn.IndexOf(cSearchFor, nPos); }
                else { nPos = cSearchIn.LastIndexOf(cSearchFor, nPos); }
                if (nPos < 0)
                {
                    //This means that we did not find the item			
                    break;
                }
                else
                {
                    //Increment the occured counter based on the current mode we are in			
                    nOccured++;         //Check if this is the occurence we are looking for
                    if (nOccured == nOccurence)
                    {
                        return nPos + 1;
                    }
                    else { if (nMode == 1) { nPos++; } else { nPos--; } }
                }
            }
            //We never found our guy if we reached here
            return 0;
        }
        #endregion FOX

        #region Validaciones
        public const String nssPattern = "\\d{11}";
        public const String rfcPattern = "[\a-zA-Z]{4}[\0-9]{6}[\a-zA-Z0-9]{2}[\aA0-9]{1}";
        public const String curpPattern = "[A-Z]{1}[AEIOUX]{1}[A-Z]{2}[0-9]{2}" +
                                                       "(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[0-1])" +
                                                       "[HM]{1}" +
                                                       "(AS|BC|BS|CC|CS|CH|CL|CM|DF|DG|GT|GR|HG|JC|MC|MN|MS|NT|NL|OC|PL|QT|QR|SP|SL|SR|TC|TS|TL|VZ|YN|ZS|NE)" +
                                                       "[B-DF-HJ-NP-TV-Z]{3}" +
                                                       "[0-9A-Z]{1}[0-9]{1}$";

        public const String emailPattern = "^([a-zA-Z0-9_\\-\\.]+)@[a-z0-9-]+(\\.[a-z0-9-]+)*(\\.[a-z]{2,3})$";

        public Boolean validarCURP(String stCurp)
        {
            Regex regex = new Regex(curpPattern);
            return regex.IsMatch(stCurp);
        }
        public Boolean validarCURP(String stCurp, String stRegExCURP)
        {
            Regex regex = new Regex(stRegExCURP);
            return regex.IsMatch(stCurp);
        }
        public Boolean validarNSS(String stNSS)
        {
            Regex regex = new Regex(nssPattern);
            return regex.IsMatch(stNSS);
        }
        public Boolean validarNSS(String stNSS, String stRegExNSS)
        {
            Regex regex = new Regex(stRegExNSS);
            return regex.IsMatch(stNSS);
        }
        public Boolean validarRFC(String stRFC)
        {
            Regex regex = new Regex(rfcPattern);
            return regex.IsMatch(stRFC);
        }
        public Boolean validarRFC(String stRFC, String stRegExRFC)
        {
            Regex regex = new Regex(stRegExRFC);
            return regex.IsMatch(stRFC);
        }

        public Boolean validarEmail(String stEmail)
        {
            try
            {
                System.Net.Mail.MailAddress m = new System.Net.Mail.MailAddress(stEmail);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

            //Regex regex = new Regex(emailPattern);
            //return regex.IsMatch(stEmail);
        }

        /// <summary>
        /// Sabes si una Cadena contieene caracteres especiales
        /// </summary>
        /// <param name="stValor"></param>
        /// <returns></returns>
        public String contieneCaracteresEspeciales(String stValor, String cadenaCaracteresValidar)
        {
            String stCualesCaracteres = String.Empty;
            String[] array = StringArray(cadenaCaracteresValidar);

            for (int i = 0; i < array.Length; i++)
            {
                if (stValor.Contains(array[i]))
                {
                    stCualesCaracteres += array[i] + " - ";
                }
            }

            if (!String.IsNullOrEmpty(stCualesCaracteres))
            {
                stCualesCaracteres = stCualesCaracteres.Trim();
                stCualesCaracteres = stCualesCaracteres.TrimEnd('-');
                stCualesCaracteres = stCualesCaracteres.Trim();
            }

            return stCualesCaracteres;
        }

        public String PrimeraVocal(String stValor)
        {
            String[] arrayVocales = new String[] {
            "A", "E", "I", "O", "U"};

            String stVocal = String.Empty;
            for (int i = 0; i < stValor.Length; i++)
            {
                if (Array.IndexOf(arrayVocales, stValor[i].ToString()) != -1)
                {
                    stVocal = stValor[i].ToString();
                    break;
                }
            }
            return stVocal;
        }

        public String LetraNombre(String stNombre)
        {
            String stLetraNombre = String.Empty;
            String stNombreTemp = String.Empty;

            if (stNombre.StartsWith("MARIA"))
            {
                stNombreTemp = stNombre.Replace("MARIA", "").Trim();
            }
            else if (stNombre.StartsWith("JOSE"))
            {
                stNombreTemp = stNombre.Replace("JOSE", "").Trim();
            }

            stNombreTemp = String.IsNullOrEmpty(stNombre) ? String.Empty : eliminarArticulos(stNombre).Split(' ')[0][0].ToString();

            return stNombreTemp;
        }

        public String eliminarArticulos(String stValor)
        {
            String stletra = String.Empty;
            if (stValor.Split(' ').Length > 1)
            {
                String[] arrayListaArticulos = new String[] {
                "DE ",
                "LOS ",
                "DEL ",
                "LAS ",
                "LA "
            };

                for (int i = 0; i < arrayListaArticulos.Length; i++)
                {
                    if (stValor.Contains(arrayListaArticulos[i]))
                    {
                        stValor = stValor.Replace(arrayListaArticulos[i], "").Trim();
                    }
                }
            }
            else
            {
                stletra = stValor;
            }
            return stValor;
        }

        #endregion
        static public Dictionary<int, String> dicPlantilla = new Dictionary<int, String>();
        private DataTable iniDataTableEmpleados()
        {
            dicPlantilla.Clear();
            String[] nombres = new String[] {
            "Apellido Paterno", //1
            "Apellido Materno", //2
            "Nombres",  //3
            "Fecha de Ingreso Cliente", //4
            "Salario Real", //5
            "NSS",  //6
            "RFC",  //7
            "CURP", //8
            "Nacionalidad", //9
            "Estado Civil", //10
            "Sexo", //11
            "Puesto Real",  //12
            "Departamento o Area Real", //13
            "Tipo de nómina", //14
            "Funciones a desempeñar", //15
            "Turno", //16
            "Días de Jornada", //17
            "Horario Jornada", //18
            "Jornada de Servicio", //19
            "Tiempo de comida o descanso", //20
            "Tipo de contrato", //21
            "Tiempo de contrato", //22
            "Calle Centro de Trabajo", //23
            "No.Exterior Centro de Trabajo", //24
            "No.Interior Centro de Trabajo", //25
            "Colonia Centro de Trabajo", //26
            "Código Postal Centro de Trabajo", //27
            "Delegación o Municipio Centro de Trabajo", //28
            "Estado Centro de Trabajo", //29
            "Calle Domicilio Empleado", //30
            "No.Exterior Domicilio Empleado", //31
            "No.Interior Domicilio Empleado", //32
            "Colonia Domicilio Empleado", //33
            "Código Postal Domicilio Empleado", //34
            "Delegación o Municipio Domicilio Empleado", //35
            "Estado Domicilio Empleado", //36
            "Unidad Médica Familiar", //37
            "Requiere autorización permanente IMSS", //38
            "No.de credito INFONAVIT", //39
            "Banco de deposito nómina", //40
            "Cuenta Banco", //41
            "No.Empleado Banco", //42
            "CLABE", //43
            "Observaciones", //44
            "Puesto Contrato", //45
            "Departamento o Area Contrato", //46
            "Fecha de Ingreso BPO", //47
            "Salario Diario IMSS", //48
            "Salario Base de Cotización", //49
            "Correo Electrónico", //50
            "Estatus Empleado", //51
            "Esquema", //52
            "No.Empleado Asignado", //53
            "Cliente", //54
            "SA", //55
            "SC", //56
            "Errores" //57
        };

            DataTable dtDatos = new DataTable();
            for (int i = 0; i < nombres.Length; i++)
            {
                dicPlantilla.Add(i + 1, nombres[i]);
                dtDatos.Columns.Add(nombres[i]);
            }

            return dtDatos;
        }
        public Boolean esNumero(String stValorNumero)
        {
            long valorNumero;
            Boolean taBien = false;

            try { taBien = Int64.TryParse(stValorNumero, out valorNumero); }
            catch (Exception) { taBien = false; }

            return taBien;
        }
        public String ColumnaExcel(int columnaNumero)
        {
            String abecedario = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            String letraColumna = String.Empty;

            if (columnaNumero <= abecedario.Length)
            {
                letraColumna = abecedario[columnaNumero - 1].ToString();
            }
            else
            {
                int valorPrimeraLetra = columnaNumero / abecedario.Length;

                if (columnaNumero % abecedario.Length == 0)
                    valorPrimeraLetra--;

                String PrimeraLetra = ColumnaExcel(valorPrimeraLetra);

                int valorSegundaLetra = columnaNumero - (abecedario.Length * valorPrimeraLetra);
                String segundaLetra = ColumnaExcel(valorSegundaLetra);
                letraColumna = PrimeraLetra + segundaLetra;
            }

            return letraColumna;
        }
        public void quitarFormatoHoja(Excel.Worksheet SheetExcelFormato, String iniColumna)
        {
            Excel.Range unRango;
            unRango = UltimoCelda(SheetExcelFormato);
            String ultimaCelda = unRango.get_AddressLocal(false, false, Excel.XlReferenceStyle.xlA1, false, false);
            unRango = SheetExcelFormato.get_Range(iniColumna, ultimaCelda);
            unRango.Select();
            unRango.Interior.Pattern = Excel.XlPattern.xlPatternNone;
            unRango.Interior.TintAndShade = 0;
            unRango.Interior.PatternTintAndShade = 0;
            unRango.Font.ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic;
            unRango.Font.TintAndShade = 0;
            unRango.Font.Bold = false;

            //unRango = SheetExcelFormato.get_Range("BD4", ultimaCelda);
            //unRango.Select();
            //unRango.Clear();
        }

        public void quitarFormatoHoja_1(Excel.Worksheet SheetExcelFormato, String iniColumna)
        {
            Excel.Range unRango;
            unRango = UltimoCelda(SheetExcelFormato);
            String ultimaCelda = unRango.get_AddressLocal(false, false, Excel.XlReferenceStyle.xlA1, false, false);
            unRango = SheetExcelFormato.get_Range(iniColumna, ultimaCelda);
            unRango.Select();
            unRango.Interior.Pattern = Excel.XlPattern.xlPatternNone;
            unRango.Interior.TintAndShade = 0;
            unRango.Interior.PatternTintAndShade = 0;
            unRango.Font.ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic;
            unRango.Font.TintAndShade = 0;
            unRango.Font.Bold = false;
        }

        public void CheckandCreateFolder(String pathFolder)
        {
            if (!Directory.Exists(pathFolder)) { Directory.CreateDirectory(pathFolder); }
        }
        public String nombreAleatorio()
        {
            String nombre = Convert.ToString(DateTime.Now.Year) +
                Convert.ToString(DateTime.Now.Month.ToString("00")) +
                Convert.ToString(DateTime.Now.Day.ToString("00")) +
                Convert.ToString(DateTime.Now.Hour.ToString("00")) +
                Convert.ToString(DateTime.Now.Minute.ToString("00")) +
                Convert.ToString(DateTime.Now.Second.ToString("00"));
            return nombre;
        }
        public String soloNumeros(String valor)
        {
            Regex regex = new Regex("[A-Z]");
            return regex.Replace(valor, "");
        }

        public Boolean contieneLetras(String stCadena)
        {
            stCadena = stCadena.ToUpper();
            Regex regex = new Regex("[A-Z]");
            return regex.IsMatch(stCadena);
        }
        public Boolean contieneNumeros(String stCadena)
        {
            stCadena = stCadena.ToUpper();
            Regex regex = new Regex("[0-9]");
            return regex.IsMatch(stCadena);
        }
        public String soloLetras(String valor)
        {
            Regex regex = new Regex("[0-9]");
            return regex.Replace(valor, "");
        }
        public void Log(String nombreProceso, String textoLog)
        {
            String stRutaLog = @"C:\SAIC\Log\";
            String stNombreProceso = "SAIC - " + nombreProceso + " - " + nombreAleatorio() + ".log";
            CheckandCreateFolder(stRutaLog);
            File.WriteAllText(stRutaLog + stNombreProceso, textoLog);
        }

        public DataTable deGridViewaDataTable(DevExpress.XtraGrid.Views.Grid.GridView unGridView)
        {
            DataTable dtDatos = new DataTable();

            for (int i = 0; i < unGridView.Columns.Count; i++)
            {
                dtDatos.Columns.Add(unGridView.Columns[i].FieldName);
            }

            for (int i = 0; i < unGridView.RowCount; i++)
            {
                DataRow unRow = dtDatos.NewRow();

                for (int x = 0; x < unGridView.GetDataRow(i).ItemArray.Count(); x++)
                {
                    unRow[x] = unGridView.GetDataRow(i).ItemArray[x];
                }
                dtDatos.Rows.Add(unRow);
            }

            return dtDatos;
        }

        public DataTable deGridViewaDataTable(DevExpress.XtraGrid.Views.Grid.GridView unGridView, int ColInicial, int colFinal)
        {
            DataTable dtDatos = new DataTable();

            for (int i = ColInicial; i < colFinal; i++)
            {
                dtDatos.Columns.Add(unGridView.Columns[i].FieldName);
            }

            for (int i = 0; i < unGridView.RowCount; i++)
            {
                DataRow unRow = dtDatos.NewRow();

                for (int x = ColInicial; x < unGridView.GetDataRow(i).ItemArray.Count(); x++)
                {
                    unRow[x] = unGridView.GetDataRow(i).ItemArray[x];
                }
                dtDatos.Rows.Add(unRow);
            }

            return dtDatos;
        }


        public DataTable deGridViewaDataTableColumn(DevExpress.XtraGrid.Views.Grid.GridView unGridView, int iColIni, int iColFin)
        {
            DataTable dtDatos = new DataTable();

            for (int i = iColIni; i < iColFin; i++)
            {
                dtDatos.Columns.Add(unGridView.Columns[i].FieldName);
            }

            for (int i = 0; i < unGridView.RowCount; i++)
            {
                DataRow unRow = dtDatos.NewRow();

                for (int x = 0; x < iColFin; x++)
                {
                    unRow[x] = unGridView.GetDataRow(i).ItemArray[x];
                }
                dtDatos.Rows.Add(unRow);
            }

            return dtDatos;
        }

        public String ConvertDataRowToString(DataRow unRow)
        {
            String stDatos = String.Empty;
            foreach (var item in unRow.ItemArray)
            {
                stDatos += item.ToString() + "\t";
            }

            stDatos += "\n";
            return stDatos;
        }

        public String ConvertDataTableToString(DataTable dtDatos, Boolean conTitulos)
        {
            String texto = String.Empty;
            String titles = String.Empty;

            int filas = dtDatos.Rows.Count, column = dtDatos.Columns.Count, conta = 0;
            String[] aux = new String[filas], aux2 = new String[column];

            if (conTitulos)
            {
                foreach (DataColumn item in dtDatos.Columns)
                {
                    titles += item.ColumnName + "\t";
                }

                titles = titles + Environment.NewLine;
            }

            foreach (DataRow i in dtDatos.Rows)
            {
                for (int e = 0; e < column; e++)
                {
                    if (i[e].GetType() == typeof(String))
                    {
                        if (i.Field<String>(e) != null)
                        {
                            if (String.IsNullOrEmpty(i.Field<String>(e).ToString()))
                            {
                                aux2[e] = "";
                            }
                            else
                            {
                                aux2[e] = i.Field<string>(e);
                                aux2[e] = aux2[e].Replace("\r", "").Replace("\n", "");
                            }
                        }
                        else
                        {
                            aux2[e] = "";
                        }
                    }
                    else if (i[e].GetType() == typeof(int))
                    {
                        if (i.Field<int>(e) != null)
                        {
                            if (String.IsNullOrEmpty(i.Field<int>(e).ToString()))
                            {
                                aux2[e] = "";
                            }
                            else
                            {
                                aux2[e] = i.Field<int>(e).ToString();
                                aux2[e] = aux2[e].Replace("\r", "").Replace("\n", "");
                            }
                        }
                        else
                        {
                            aux2[e] = "";
                        }
                    }
                    else if (i[e].GetType() == typeof(DateTime))
                    {
                        if (i.Field<DateTime>(e) != null)
                        {
                            if (String.IsNullOrEmpty(i.Field<DateTime>(e).ToString()))
                            {
                                aux2[e] = "";
                            }
                            else
                            {
                                aux2[e] = i.Field<DateTime>(e).Date.ToString().Replace("12:00:00 a. m.", "").Trim();
                                aux2[e] = aux2[e].Replace("\r", "").Replace("\n", "");
                            }
                        }
                        else
                        {
                            aux2[e] = "";
                        }
                    }
                    else if (i[e].GetType() == typeof(Decimal))
                    {
                        if (i.Field<Decimal>(e) != null)
                        {
                            if (String.IsNullOrEmpty(i.Field<Decimal>(e).ToString()))
                            {
                                aux2[e] = "";
                            }
                            else
                            {
                                aux2[e] = Math.Round(i.Field<Decimal>(e), 2).ToString();
                                aux2[e] = aux2[e].Replace("\r", "").Replace("\n", "");
                            }
                        }
                        else
                        {
                            aux2[e] = "";
                        }
                    }
                    else
                    {

                    }
                }
                aux[conta] = String.Join("\t", aux2); conta++;
            }
            texto = String.Join(Environment.NewLine, aux);
            texto = titles + texto;
            return texto;
        }
        public DataTable deGridViewSelectedToDataTable(DevExpress.XtraGrid.Views.Grid.GridView unGridView)
        {
            DataTable dtDatos = new DataTable();

            foreach (DevExpress.XtraGrid.Columns.GridColumn item in unGridView.Columns)
            {
                if (item.ColumnType.Name.Contains("Int32"))
                {
                    dtDatos.Columns.Add(item.FieldName, typeof(Int32));
                }
                else if (item.ColumnType.Name.Contains("Int64"))
                {
                    dtDatos.Columns.Add(item.FieldName, typeof(Int64));
                }
                else if (item.ColumnType.Name.Contains("String"))
                {
                    dtDatos.Columns.Add(item.FieldName, typeof(String));
                }
                else if (item.ColumnType.Name.Contains("DateTime"))
                {
                    dtDatos.Columns.Add(item.FieldName, typeof(DateTime));
                }
                else if (item.ColumnType.Name.Contains("Decimal"))
                {
                    dtDatos.Columns.Add(item.FieldName, typeof(Decimal));
                }
                else if (item.ColumnType.Name.Contains("Boolean"))
                {
                    dtDatos.Columns.Add(item.FieldName, typeof(Boolean));
                }
            }

            for (int i = 0; i < unGridView.SelectedRowsCount; i++)
            {
                DataRow unRow = unGridView.GetDataRow(unGridView.GetSelectedRows()[i]);
                dtDatos.ImportRow(unRow);
            }

            return dtDatos;
        }

        public DataTable deGridViewUnSelectedToDataTable(DevExpress.XtraGrid.Views.Grid.GridView unGridView)
        {
            DataTable dtDatos = new DataTable();

            foreach (DevExpress.XtraGrid.Columns.GridColumn item in unGridView.Columns)
            {
                if (item.ColumnType.Name.Contains("Int32"))
                {
                    dtDatos.Columns.Add(item.FieldName, typeof(Int32));
                }
                else if (item.ColumnType.Name.Contains("String"))
                {
                    dtDatos.Columns.Add(item.FieldName, typeof(String));
                }
                else if (item.ColumnType.Name.Contains("DateTime"))
                {
                    dtDatos.Columns.Add(item.FieldName, typeof(DateTime));
                }
                else if (item.ColumnType.Name.Contains("Decimal"))
                {
                    dtDatos.Columns.Add(item.FieldName, typeof(Decimal));
                }
            }

            //for (int i = 0; i < unGridView.SelectedRowsCount; i++)
            //{
            //    DataRow unRow = unGridView.GetDataRow(unGridView.GetSelectedRows()[i]);
            //    dtDatos.ImportRow(unRow);
            //}

            for (int i = 0; i < unGridView.RowCount; i++)
            {
                //if (unGridView.GetDataRow(unGridView.GetSelectedRows()[i]))
                //{
                //    gridViewEmpleados.UnselectRow(i);
                //}
            }

            return dtDatos;
        }

        public DateTime ObtenerFechaNacimiento(String stCURP)
        {
            DateTime dtFechaNacimiento = new DateTime();

            try
            {
                String stAnio = String.Empty;
                String stMes = String.Empty;
                String stdia = String.Empty;

                int iAnio = 0;
                int iMes = 0;
                int idia = 0;

                stAnio = stCURP.Substring(4, 2);
                stMes = stCURP.Substring(6, 2);
                stdia = stCURP.Substring(8, 2);

                int.TryParse(stAnio, out iAnio);
                int.TryParse(stMes, out iMes);
                int.TryParse(stdia, out idia);

                iAnio += stAnio == "00" ? 2000 : 1900;

                dtFechaNacimiento = new DateTime(iAnio, iMes, idia);
            }
            catch (Exception)
            {
                dtFechaNacimiento = new DateTime(1900, 01, 01);
            }

            return dtFechaNacimiento;
        }

        public int contarDiasSemana(String stDiaInicial, String stDiaFinal)
        {
            Dictionary<String, String> diaSemana = iniDiccionario();
            DateTime dtHoy = DateTime.Now;

            String stDayInicial = diaSemana[stDiaInicial];
            String stDayFin = diaSemana[stDiaFinal];

            int numDia = 0;

            //>Encontramos el primer dia de la semana
            for (int i = 0; i < 8; i++)
            {
                if (dtHoy.DayOfWeek.ToString().ToUpper() != stDayInicial)
                {
                    dtHoy = dtHoy.AddDays(1);
                }
                else
                {
                    break;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (dtHoy.DayOfWeek.ToString().ToUpper() != stDayFin)
                {
                    dtHoy = dtHoy.AddDays(1);
                    numDia++;
                }
                else
                {
                    numDia++;
                    break;
                }
            }
            diaSemana.Clear();
            return numDia;
        }

        private Dictionary<String, String> iniDiccionario()
        {
            Dictionary<String, String> diaSemana = new Dictionary<String, String>();
            diaSemana.Add("LUNES", "MONDAY");
            diaSemana.Add("MARTES", "TUESDAY");
            diaSemana.Add("MIERCOLES", "WEDNESDAY");
            diaSemana.Add("JUEVES", "THURSDAY");
            diaSemana.Add("VIERNES", "FRIDAY");
            diaSemana.Add("SABADO", "SATURDAY");
            diaSemana.Add("DOMINGO", "SUNDAY");
            return diaSemana;
        }

        /// <summary>
        /// Obtener el id de una tabla, el valor por buscar en la tabla debe de estar en la columna = 2 
        /// y el valor devuelto es el que esta en la columna = 1.
        /// </summary>
        /// <returns></returns>
        public int ObtenerIDofTable(DataTable dtDatos, String datoBuscar)
        {
            String stColumnaID = String.Empty;
            int iID = 0;

            if (dtDatos.Columns.Count > 0)
            {
                stColumnaID = dtDatos.Columns[1].ColumnName;
                DataRow[] dtRow = dtDatos.Select(stColumnaID + "='" + datoBuscar + "'");
                if (dtRow.Length > 0)
                {
                    int.TryParse(dtRow[0].ItemArray[0].ToString(), out iID);
                }
            }

            return iID;
        }

        public int ObtenerIDofTable(DataTable dtDatos, String datoBuscar, int iColumnaBuscar)
        {
            String stColumnaID = String.Empty;
            int iID = 0;

            if (dtDatos.Columns.Count > 0)
            {
                stColumnaID = dtDatos.Columns[iColumnaBuscar].ColumnName;
                DataRow[] dtRow = dtDatos.Select(stColumnaID + "='" + datoBuscar + "'");
                if (dtRow.Length > 0)
                {
                    int.TryParse(dtRow[0].ItemArray[0].ToString(), out iID);
                }
            }

            return iID;
        }

        public String obtenerTema()
        {
            String sttema = String.Empty;
            if (File.Exists(stRutaSAIC + "tema.ini"))
            {
                sttema = File.ReadAllText(stRutaSAIC + "tema.ini");
                sttema = StrExtract(sttema, "<Tema>", "</Tema>");
            }
            return sttema;
        }

        public Boolean fonetica(String Primera_palabra, String Segunda_palabra)
        {
            String miPalabra = "";
            String datoPalabra = "";
            Boolean relacion = false;

            Primera_palabra = Primera_palabra.ToUpper();
            Segunda_palabra = Segunda_palabra.ToUpper();

            StringBuilder P_palabra = new StringBuilder(Primera_palabra);
            StringBuilder S_palabra = new StringBuilder(Segunda_palabra);
            StringBuilder p = new StringBuilder(Segunda_palabra);

            for (int i = 1; i <= 2; i++)
            {

                if (i == 1)
                {
                    p = P_palabra;
                }
                else
                {
                    p = S_palabra;
                }

                p.Replace("*", "").ToString();
                p.Replace("-", "").ToString();
                p.Replace("_", "").ToString();
                p.Replace(".", "").ToString();
                p.Replace("/", "").ToString();
                p.Replace("#", "").ToString();
                p.Replace(":", "").ToString();
                p.Replace(",", "").ToString();
                p.Replace("  ", "").ToString();
                p.Replace(" ", "").ToString();
                p.Replace("´", "").ToString();

                p.Replace("Á", "A");
                p.Replace("É", "E");
                p.Replace("Í", "I");
                p.Replace("Ó", "O");
                p.Replace("Ú", "U");

                p.Replace("V", "B");
                p.Replace("C", "S");
                p.Replace("K", "S");
                p.Replace("Z", "S");
                p.Replace("H", "");
                p.Replace("Y", "I");
                p.Replace("j", "G");
                p.Replace("M", "N");
                p.Replace("W", "U");
                p.Replace("Ñ", "N");

                p.Replace("0", "");
                p.Replace("1", "");
                p.Replace("2", "");
                p.Replace("3", "");
                p.Replace("4", "");
                p.Replace("5", "");
                p.Replace("6", "");
                p.Replace("7", "");
                p.Replace("8", "");
                p.Replace("9", "");

                if (i == 1)
                {
                    miPalabra = p.ToString();
                }
                else
                {
                    datoPalabra = p.ToString();
                }
            }

            if (miPalabra == datoPalabra)
            {
                relacion = true;
            }

            return relacion;
        }

        /// <summary>
        /// Convierte un archivo en Byte 
        /// </summary>
        /// <param name="stRutaArchivo">Ruta de archivo</param>
        /// <returns></returns>
        public String ConvertToBytes(String stRutaArchivo)
        {
            String stFile = String.Empty;

            try
            {
                Byte[] bytes = File.ReadAllBytes(stRutaArchivo);
                stFile = Convert.ToBase64String(bytes);
            }
            catch (Exception) { }

            return stFile;
        }

        public Boolean ConvertToFile(String stValorBytes, String StRuta)
        {
            Boolean bandera = false;

            try
            {
                Byte[] bytes = Convert.FromBase64String(stValorBytes);
                File.WriteAllBytes(StRuta, bytes);
                System.Threading.Thread.Sleep(2000);
                bandera = true;
            }
            catch (Exception) { }
            return bandera;
        }


        public String Encriptado(String stValor)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(stValor);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        public String DesEncriptado(String stValor)
        {
            String result = String.Empty;

            try
            {
                byte[] decryted = Convert.FromBase64String(stValor);
                result = System.Text.Encoding.Unicode.GetString(decryted);
            }
            catch (Exception) { }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stRutaArchivo">Ruta del Archivo de Excel a Leer</param>
        /// <param name="stUltimaColumna">Ultima columna del Rango para Obtener los Datos Ejemplo: "B", "Z", "AX"</param>
        /// <returns></returns>
        public DataTable ConvertExcelToDataTable(String stRutaArchivo, String stUltimaColumna)
        {
            DataTable dtDatos = new DataTable();

            String ultimaCelda = String.Empty;
            String losDatos = String.Empty;

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
                unRango = UltimoCelda(SheetExcel);

                unRango = SheetExcel.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);

                ultimaCelda = unRango.get_AddressLocal(false, false, Excel.XlReferenceStyle.xlA1, false, false);
                unRango = SheetExcel.get_Range("A1", stUltimaColumna + soloNumeros(ultimaCelda));
                unRango.Select();
                unRango.Copy();
                System.Threading.Thread.Sleep(2000);
                losDatos = Clipboard.GetText();
                losDatos = losDatos.ToUpper();
                dtDatos = ConvertToDataTableContitulos(losDatos);
                System.Threading.Thread.Sleep(2000);
                appExcel.DisplayAlerts = true;
            }

            bookExcel.Save();
            bookExcel.Close();
            booksExcel.Close();
            appExcel.Quit();

            return dtDatos;

        }

        public DatosDeExcel obtenerDatosExcel(String stUltColumna)
        {
            DatosDeExcel oDatosDeExcel = new DatosDeExcel();
            DataTable dtDatosExcel = new DataTable();
            String ultimaCelda = String.Empty;
            String losDatos = String.Empty;
            String stHojaSeleccionada = String.Empty;

            OpenFileDialog ofdSelecFile = new OpenFileDialog();
            ofdSelecFile.Filter = "Excel Files (*.xls;*.xlsm;*.xlsb;*.xlsx)|*.xls;*.xlsm;*.xlsb;*.xlsx";
            ofdSelecFile.ShowDialog();

            if (!String.IsNullOrEmpty(ofdSelecFile.FileName))
            {
                oDatosDeExcel.stRutaArchivo = ofdSelecFile.FileName.Replace(ofdSelecFile.SafeFileName, "");
                oDatosDeExcel.stExcelNombreArchivo = ofdSelecFile.SafeFileName;

                Excel.Application appExcel;
                Excel.Workbooks booksExcel;
                Excel.Workbook bookExcel = null;
                Excel.Worksheet SheetExcel;
                Excel.Range unRango;

                appExcel = new Excel.Application();
                booksExcel = appExcel.Workbooks;

                try
                {
                    List<String> lsHojasExcel = new List<String>();
                    appExcel.Visible = true;
                    appExcel.DisplayAlerts = false;
                    bookExcel = booksExcel.Open(ofdSelecFile.FileName);

                    foreach (Excel.Worksheet hojas in bookExcel.Sheets)
                    {
                        lsHojasExcel.Add(hojas.Name.ToString());
                    }

                    if (lsHojasExcel.Count > 1)
                    {
                        using (var form = new tools.xtFormSelectItem("Seleccione la Hoja", lsHojasExcel))
                        {
                            var result = form.ShowDialog();
                            if (result == DialogResult.OK)
                            {
                                if (!String.IsNullOrEmpty(form.stValorSeleccioando))
                                {
                                    stHojaSeleccionada = form.stValorSeleccioando;
                                    ((Excel.Worksheet)appExcel.Sheets[stHojaSeleccionada]).Select();
                                }
                            }
                        }
                    }
                    else
                    {
                        stHojaSeleccionada = lsHojasExcel[0];
                        ((Excel.Worksheet)appExcel.Sheets[stHojaSeleccionada]).Select();
                    }

                    SheetExcel = (Excel.Worksheet)bookExcel.ActiveSheet;
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Asegúrese de Cerrar la ventana de Validacion de Office y despues de Click en Aceptar de este mensaje."
                              , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    if (!String.IsNullOrEmpty(stHojaSeleccionada))
                    {
                        oDatosDeExcel.stExcelNombreHoja = stHojaSeleccionada;
                        ((Excel.Worksheet)appExcel.Sheets[stHojaSeleccionada]).Select();
                        SheetExcel = (Excel.Worksheet)bookExcel.ActiveSheet;
                        unRango = UltimoCelda(SheetExcel);

                        unRango = SheetExcel.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);

                        ultimaCelda = unRango.get_AddressLocal(false, false, Excel.XlReferenceStyle.xlA1, false, false);
                        unRango = SheetExcel.get_Range("A1", stUltColumna + soloNumeros(ultimaCelda));
                        unRango.Select();
                        unRango.Copy();
                        System.Threading.Thread.Sleep(2000);
                        losDatos = Clipboard.GetText();
                        losDatos = losDatos.ToUpper();
                        dtDatosExcel = ConvertToDataTableContitulos(losDatos);
                        System.Threading.Thread.Sleep(2000);
                        appExcel.DisplayAlerts = true;
                    }
                }

                bookExcel.Save();
                bookExcel.Close();
                booksExcel.Close();
                appExcel.Quit();
            }

            oDatosDeExcel.dtDatos = dtDatosExcel;
            oDatosDeExcel.iNumRegistros = dtDatosExcel.Rows.Count;

            return oDatosDeExcel;
        }



        static private String ObtenerRutaEmpleados()
        {
            String StRutaEmpleados = String.Empty;
            try
            {
                string sConexionBD = winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString;
                using (SqlConnection Cnn = new SqlConnection(sConexionBD))
                {
                    SqlCommand cmd = new SqlCommand("dbo.stpSelParametro", Cnn)
                    { CommandType = CommandType.StoredProcedure };

                    cmd.Parameters.AddWithValue("@pDescParametro", "RUTA_EMPLEADOS");

                    Cnn.Open(); //abrir conexion
                    cmd.ExecuteNonQuery();  //ejecutar stored procedure
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            StRutaEmpleados = reader.GetString(0);
                        }
                    }

                    Cnn.Close();    //cerrar conexion
                }  //using


                if (String.IsNullOrEmpty(StRutaEmpleados))
                {
                    StRutaEmpleados = @"C:\SAIC\ADNA PF\Empleados\";
                }
            }
            catch (Exception)
            {
                StRutaEmpleados = @"C:\SAIC\ADNA PF\Empleados\";
            }

            return StRutaEmpleados;
        }


        static private String ObtenerRutaSolicitudSAIC(String stParametroRuta)
        {
            String StRutaSolicitud = String.Empty;
            try
            {
                string sConexionBD = winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString;
                using (SqlConnection Cnn = new SqlConnection(sConexionBD))
                {
                    SqlCommand cmd = new SqlCommand("dbo.stpSelParametro", Cnn)
                    { CommandType = CommandType.StoredProcedure };

                    cmd.Parameters.AddWithValue("@pDescParametro", stParametroRuta);

                    Cnn.Open(); //abrir conexion
                    cmd.ExecuteNonQuery();  //ejecutar stored procedure
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            StRutaSolicitud = reader.GetString(0);
                        }
                    }

                    Cnn.Close();    //cerrar conexion
                }  //using


                if (String.IsNullOrEmpty(StRutaSolicitud))
                {
                    StRutaSolicitud = @"C:\SAIC\ADNA PF\" + stParametroRuta + @"\";
                }
            }
            catch (Exception)
            {
                StRutaSolicitud = @"C:\SAIC\ADNA PF\" + stParametroRuta + @"\";
            }

            return StRutaSolicitud;
        }

        /// <summary>      
        /// </summary>
        /// <param name="idTipoSolicitud">  
        /// /// 1 = Solicitudes de Alta,
        /// 2 = Solicitudes de Baja,
        /// 3 = Solicitudes de Cuenta,
        /// 4 = Solicitudes de Salario
        /// 5 = Aniversarios
        /// 6 = Variables
        /// </param>
        /// 
        /// <param name="iArea">
        /// 1 = Operaciones,
        /// 2 = IMSS,
        /// 3  Juridico,
        /// 4 = tesoreria,
        /// 5 = Contabilidad</param>
        /// <returns></returns>
        public String ObtenerRutaSolicitud(int idTipoSolicitud, int iArea)
        {
            String sRuta = stRutaSAICPF;
            String sArea = String.Empty;

            if (iArea == 1)
            {
                sArea = "Operaciones";
            }
            else if (iArea == 2)
            {
                sArea = "IMSS";
            }
            else if (iArea == 3)
            {
                sArea = "Juridico";
            }
            else if (iArea == 4)
            {
                sArea = "Tesoreria";
            }
            else if (iArea == 5)
            {
                sArea = "Contabilidad";
            }

            if (idTipoSolicitud == 1)
            {
                sRuta += sArea + @"\Solicitudes de Alta\";
            }
            else if (idTipoSolicitud == 2)
            {
                sRuta += sArea + @"\Solicitudes de Bajas\";
            }
            else if (idTipoSolicitud == 3)
            {
                sRuta += sArea + @"\Solicitudes de Cuentas\";
            }
            else if (idTipoSolicitud == 4)
            {
                sRuta += sArea + @"\Solicitudes de Salario\";
            }
            else if (idTipoSolicitud == 5)
            {
                sRuta += sArea + @"\Aniversario\";
            }
            else if (idTipoSolicitud == 6)
            {
                sRuta += sArea + @"\Variables\";
            }

            return sRuta;
        }




        static private String ObtenerCadenaCaracteresEspeciales()
        {
            String stCadenaCaracteres = String.Empty;
            try
            {
                string sConexionBD = winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString;
                using (SqlConnection Cnn = new SqlConnection(sConexionBD))
                {
                    SqlCommand cmd = new SqlCommand("dbo.stpSelParametro", Cnn)
                    { CommandType = CommandType.StoredProcedure };

                    cmd.Parameters.AddWithValue("@pDescParametro", "CaracteresEspeciales");

                    Cnn.Open(); //abrir conexion
                    cmd.ExecuteNonQuery();  //ejecutar stored procedure
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            stCadenaCaracteres = reader.GetString(0);
                        }
                    }

                    Cnn.Close();    //cerrar conexion
                }  //using

                if (String.IsNullOrEmpty(stCadenaCaracteres))
                {
                    stCadenaCaracteres = @"!@#$%&/()?'¿¡*+;:[]=^`{|}~?çÇüãâäàåêëèìïîìÄÅæÆðõôöòüûùýÿÖÜ÷ø¦§©ª""®¯°±²³´µ·,¹°""¼½¾"".??^?<'´"".ÀÂÃÄÅÈÊËÌÎÏÐÒÔÕÖ×ØÙÛÜÝÞßþÁÉÍÓÚ";
                }
            }
            catch (Exception)
            {
                stCadenaCaracteres = @"!@#$%&/()?'¿¡*+;:[]=^`{|}~?çÇüãâäàåêëèìïîìÄÅæÆðõôöòüûùýÿÖÜ÷ø¦§©ª""®¯°±²³´µ·,¹°""¼½¾"".??^?<'´"".ÀÂÃÄÅÈÊËÌÎÏÐÒÔÕÖ×ØÙÛÜÝÞßþÁÉÍÓÚ";
            }

            return stCadenaCaracteres;
        }
        static private String ObtenerCadenaCaracteresEspeciales_1()
        {
            String stCadenaCaracteres = String.Empty;
            try
            {
                string sConexionBD = winAppSAIC.Properties.Settings.Default.dbSAICBPOConnectionString;
                using (SqlConnection Cnn = new SqlConnection(sConexionBD))
                {
                    SqlCommand cmd = new SqlCommand("dbo.stpSelParametro", Cnn)
                    { CommandType = CommandType.StoredProcedure };

                    cmd.Parameters.AddWithValue("@pDescParametro", "CaracteresEspeciales_1");

                    Cnn.Open(); //abrir conexion
                    cmd.ExecuteNonQuery();  //ejecutar stored procedure
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            stCadenaCaracteres = reader.GetString(0);
                        }
                    }

                    Cnn.Close();    //cerrar conexion
                }  //using

                if (String.IsNullOrEmpty(stCadenaCaracteres))
                {
                    stCadenaCaracteres = @"!@#$%&/()?'¿¡*+;:[]=^`{|}~?çÇüãâäàåêëèìïîìÄÅæÆðõôöòüûùýÿÖÜ÷ø¦§©ª""®¯°±²³´µ·¹°""¼½¾""??^?<'´""ÀÂÃÄÅÈÊËÌÎÏÐÒÔÕÖ×ØÙÛÜÝÞßþÁÉÍÓÚ";
                }
            }
            catch (Exception)
            {
                stCadenaCaracteres = @"!@#$%&/()?'¿¡*+;:[]=^`{|}~?çÇüãâäàåêëèìïîìÄÅæÆðõôöòüûùýÿÖÜ÷ø¦§©ª""®¯°±²³´µ·¹°""¼½¾""??^?<'´""ÀÂÃÄÅÈÊËÌÎÏÐÒÔÕÖ×ØÙÛÜÝÞßþÁÉÍÓÚ";
            }

            return stCadenaCaracteres;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stDatosAExportar">la informacion de los datos debe estar separada por Tab y Saltos de Linea</param>
        public void ExportarDatosExcel(DataTable dtDatosaExportar, String stNombreHoja)
        {
            String stInformacionEmpleados = ConvertDataTableToString(dtDatosaExportar, true);
            String sUltimaColumnaExcel = ColumnaExcel(dtDatosaExportar.Columns.Count);
            Excel.Application appExcel;
            Excel.Workbooks booksExcel;
            Excel.Workbook bookExcel;
            Excel.Worksheet SheetExcel;
            Excel.Range Rango;

            appExcel = new Excel.Application();
            booksExcel = appExcel.Workbooks;
            bookExcel = booksExcel.Add();
            appExcel.Visible = true;
            appExcel.DisplayAlerts = false;

            System.Threading.Thread.Sleep(1000);
            Clipboard.Clear();
            System.Threading.Thread.Sleep(1000);
            Clipboard.SetText(stInformacionEmpleados);

            SheetExcel = (Excel.Worksheet)bookExcel.ActiveSheet;
            SheetExcel.Name = stNombreHoja;
            Rango = SheetExcel.get_Range("A1:" + sUltimaColumnaExcel + (dtDatosaExportar.Rows.Count + 2));
            Rango.Select();
            Rango.NumberFormat = "@";

            Rango = SheetExcel.get_Range("A1");
            Rango.Select();
            System.Threading.Thread.Sleep(1000);
            Rango.PasteSpecial();
            System.Threading.Thread.Sleep(1000);

            Rango = SheetExcel.get_Range("A1:" + sUltimaColumnaExcel + "1");
            Rango.Select();
            Rango.Interior.Pattern = Excel.XlPattern.xlPatternSolid;
            Rango.Interior.PatternColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic;
            Rango.Interior.ThemeColor = Excel.XlThemeColor.xlThemeColorAccent1;
            Rango.Interior.TintAndShade = -0.499984740745262;
            Rango.Interior.PatternTintAndShade = 0;

            Rango.Font.ThemeColor = Excel.XlThemeColor.xlThemeColorDark1;
            Rango.Font.TintAndShade = 0;
            Rango.Font.Bold = true;
            Rango.Font.Size = 14;

            SheetExcel.Cells.Select();
            SheetExcel.Cells.EntireColumn.AutoFit();
            appExcel.DisplayAlerts = true;
        }

        public DateTime solicitarFechaForm(String srTituloVentana, String stTitulo, String stDescripcion)
        {
            DateTime dtFechaSeleccionada;
            using (var form = new tools.xFormsSolicitarFecha(srTituloVentana, stTitulo, stDescripcion))
            {
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    dtFechaSeleccionada = form.dtFechaSeleccionada;
                }
                else
                {
                    dtFechaSeleccionada = new DateTime(1900, 01, 01);
                }
            }
            return dtFechaSeleccionada;
        }

        public String iniLog(String stNombreProceso, String stOperador)
        {
            String stLogIni = String.Empty;

            stLogIni = "******************************************************************" + Environment.NewLine +
                "Proceso: " + stNombreProceso + Environment.NewLine + "Nombre Operador: " + stOperador + Environment.NewLine + "Fecha: " + DateTime.Now + Environment.NewLine +
                "******************************************************************" + Environment.NewLine;
            return stLogIni;
        }

        public String addLog(String stLog, String stMensajeLog)
        {
            stLog += "-> " + DateTime.Now.ToString("HH:mm:ss") + " - " + stMensajeLog + Environment.NewLine;
            return stLog;
        }

        public String finLog(String stLog)
        {
            return stLog +=
                "******************************************************************" + Environment.NewLine +
             "**************************Fin de Proceso**************************" + Environment.NewLine +
            "*****************************" + DateTime.Now.ToString("HH:mm:ss") + "*****************************" + Environment.NewLine +
            "******************************************************************";
        }

        public void guardarLog(String stLog)
        {
            String stRutaLog = String.Empty;
            String stNombreArchivoLog = "SAIC Log " + nombreAleatorio() + ".log";
            stRutaLog = stRutaTemp + @"Log\";
            CheckandCreateFolder(stRutaLog);
            File.WriteAllText(stRutaLog + stNombreArchivoLog, stLog);
        }


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
    }

    public class DatosDeExcel
    {
        public DataTable dtDatos { get; set; }
        public String stRutaArchivo { get; set; }
        public String stExcelNombreArchivo { get; set; }
        public String stExcelNombreHoja { get; set; }
        public int iNumRegistros { get; set; }

        public DatosDeExcel()
        {
            dtDatos = new DataTable();
            stRutaArchivo = String.Empty;
            stExcelNombreArchivo = String.Empty;
            stExcelNombreHoja = String.Empty;
            iNumRegistros = 0;
        }
    }
}
