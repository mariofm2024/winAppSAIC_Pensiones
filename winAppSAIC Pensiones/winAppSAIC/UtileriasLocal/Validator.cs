using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Text.RegularExpressions;
using System.Data;

namespace winAppSAIC.UtileriasLocal
{
    public static class Validator
    {
        #region "Constantes para REGEX"

        //[A-Z][A,E,I,O,U,X][A-Z]{2}[0-9]{2}[0-1][0-9][0-3][0-9][M,H][A-Z]{2}[B,C,D,F,G,H,J,K,L,M,N,Ñ,P,Q,R,S,T,V,W,X,Y,Z]{3}[0-9,A-Z][0-9]
        public const string PatternRFC = @"^([A-ZÑ]{4})\d{6}([A-Z0-9]{2}[A0-9]{1})$";
        public const string PatternRFC_COMODIN = @"^([X]{4})[0]{6}([Y]{3})$";
        public const string PatternCURP = @"^([A-ZÑ][A,E,I,O,U,X][A-Z]{2})([0-9]{2}[0-1][0-9][0-3][0-9])([M,H][A-Z]{2}[B,C,D,F,G,H,J,K,L,M,N,Ñ,P,Q,R,S,T,V,W,X,Y,Z]{3}[0-9A-Z][0-9])$";
        public const string PatternCURP_COMODIN = @"^([X]{4})[0]{6}([Y]{8})$";
        public const string PatternNNS = @"^\d{11}$";
        #endregion

        private static string m_titulo = "Error de captura";

        public static string Titulo
        {
            get { return m_titulo; }
            set { m_titulo = value; }
        }


        public static bool IsValidNSS(TextEdit objVisual, string sMensaje, string sRegexPattern)
        {
            //validar que existe valor en control
            if (!Regex.IsMatch(objVisual.Text, sRegexPattern))
            {
                XtraMessageBox.Show(String.Format("{0} NO es válido", sMensaje), Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                objVisual.Focus();    //colocar cursor en Control
                objVisual.SelectAll();  //seleccionar todo el texto
                return false;   //no tiene valor
            }
            return true;        //tiene valor
        }

        /// <summary>
        /// Metodo para Validar la existencia del NSS antes de aplicar una modificación
        /// </summary>
        /// <param name="objDT">Objeto DataTable</param>
        /// <param name="objVisual">Nombre del Control</param>
        /// <param name="pNSSOriginal">NSS Original previo a modificación</param>
        /// <param name="pNSSNuevo">NSS Nuevo que se aplicará en la modificación</param>
        /// <returns></returns>
        public static bool NotExistNSS(DataTable objDT, TextEdit objVisual, string pNSSOriginal, string pNSSNuevo)
        {
            if (objDT.Rows.Count == 0)      //si no existen registros
                return true;
            else
            {
                //Si el NSS no tuvo cambio
                if (pNSSOriginal.Equals(pNSSNuevo))
                    return true;
                else  //Si el NSS si tuvo cambio
                {
                    DataRow row = objDT.Rows[0];    //asignar la información del registro activo

                    XtraMessageBox.Show(String.Format("El NSS {0} ya lo tiene asignado el empleado No. {1}\n{2}.\n\n " +
                                                    "¡NO se puede actualizar la información!",
                                                    row["NSS"].ToString(),
                                                    row["IdEmpleado"].ToString(),
                                                    row["NombreEmpleadoCompleto"].ToString()),
                                                    Titulo, MessageBoxButtons.OK,
                                                    MessageBoxIcon.Error);
                    objVisual.Focus();    //colocar cursor en Control
                    objVisual.SelectAll();  //seleccionar todo el texto
                    return false;   //no tiene valor
                }
            }
        }

        public static bool NotExistRFC(DataTable objDT, TextEdit objVisual, string pRFCOriginal, string pRFCNuevo)
        {
            if (objDT.Rows.Count == 0)      //si no existen registros
                return true;
            else
            {
                //Si el NSS no tuvo cambio
                if (pRFCOriginal.Equals(pRFCNuevo))
                    return true;
                else  //Si el NSS si tuvo cambio
                {
                    DataRow row = objDT.Rows[0];    //asignar la información del registro activo

                    XtraMessageBox.Show(String.Format("El RFC {0} ya lo tiene asignado el empleado No. {1}\n{2}.\n\n " +
                                                    "¡NO se puede actualizar la información!",
                                                    row["RFC"].ToString(),
                                                    row["IdEmpleado"].ToString(),
                                                    row["NombreEmpleadoCompleto"].ToString()),
                                                    Titulo, MessageBoxButtons.OK,
                                                    MessageBoxIcon.Error);
                    objVisual.Focus();    //colocar cursor en Control
                    objVisual.SelectAll();  //seleccionar todo el texto
                    return false;   //no tiene valor
                }
            }
        }

        public static bool NotExistCURP(DataTable objDT, TextEdit objVisual, string pCURPOriginal, string pCURPNuevo)
        {
            if (objDT.Rows.Count == 0)      //si no existen registros
                return true;
            else
            {
                //Si el NSS no tuvo cambio
                if (pCURPOriginal.Equals(pCURPNuevo))
                    return true;
                else  //Si el NSS si tuvo cambio
                {
                    DataRow row = objDT.Rows[0];    //asignar la información del registro activo

                    XtraMessageBox.Show(String.Format("El CURP {0} ya lo tiene asignado el empleado No. {1}\n{2}.\n\n " +
                                                    "¡NO se puede actualizar la información!",
                                                    row["CURP"].ToString(),
                                                    row["IdEmpleado"].ToString(),
                                                    row["NombreEmpleadoCompleto"].ToString()),
                                                    Titulo, MessageBoxButtons.OK,
                                                    MessageBoxIcon.Error);
                    objVisual.Focus();    //colocar cursor en Control
                    objVisual.SelectAll();  //seleccionar todo el texto
                    return false;   //no tiene valor
                }
            }
        }

        public static bool IsValidRFC(TextEdit objVisual, string sMensaje, string sRegexPatternGENERICO, string sRegexPattern)
        {
            //validar que existe valor en control
            if (!Regex.IsMatch(objVisual.Text, sRegexPattern))
            {
                if (!Regex.IsMatch(objVisual.Text, sRegexPatternGENERICO))
                {
                    XtraMessageBox.Show(String.Format("{0} NO es válido", sMensaje), Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    objVisual.Focus();    //colocar cursor en Control
                    objVisual.SelectAll();  //seleccionar todo el texto
                    return false;   //no tiene valor
                }
            }
            return true;        //tiene valor
        }


        public static bool IsValidCURP(TextEdit objVisual, string sMensaje, string sRegexPattern)
        {
            //validar que existe valor en control
            if (!Regex.IsMatch(objVisual.Text, sRegexPattern))
            {
                XtraMessageBox.Show(String.Format("{0} NO es válido", sMensaje), Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                objVisual.Focus();    //colocar cursor en Control
                objVisual.SelectAll();  //seleccionar todo el texto
                return false;   //no tiene valor
            }
            return true;        //tiene valor
        }

        public static bool IsValidCURP(TextEdit objVisual, string sMensaje, string sRegexPatternGENERICO, string sRegexPattern)
        {
            //validar que existe valor en control
            if (!Regex.IsMatch(objVisual.Text, sRegexPattern))
            {
                if (!Regex.IsMatch(objVisual.Text, sRegexPatternGENERICO))
                {
                    XtraMessageBox.Show(String.Format("{0} NO es válido", sMensaje), Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    objVisual.Focus();    //colocar cursor en Control
                    objVisual.SelectAll();  //seleccionar todo el texto
                    return false;   //no tiene valor
                }
            }
            return true;        //tiene valor
        }

        public static bool IsValidIMSS(TextEdit objVisual, string sMensaje, string sRegexPattern)
        {
            //validar que existe valor en control
            if (!Regex.IsMatch(objVisual.Text, sRegexPattern))
            {
                XtraMessageBox.Show(String.Format("{0} NO es válido", sMensaje), Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                objVisual.Focus();    //colocar cursor en Control
                objVisual.SelectAll();  //seleccionar todo el texto
                return false;   //no tiene valor
            }
            return true;        //tiene valor
        }


        /// <summary>
        /// Método que valida la existencia de un valor en el control LookUpEdit
        /// </summary>
        /// <param name="objVisual">Nombre del Control</param>
        /// <returns>Regresa Verdadero o Falso</returns>
        public static bool IsPresent(LookUpEdit objVisual)
        {
            //validar que existe valor en control
            if (objVisual.Text.Equals(""))
            {
                XtraMessageBox.Show(String.Format("{0} es requerido", objVisual.Tag), Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                objVisual.Focus();    //colocar cursor en Control
                return false;   //no tiene valor
            }
            return true;        //tiene valor
        }

        /// <summary>
        /// Método que valida la existencia de un valor en el control LookUpEdit
        /// </summary>
        /// <param name="objVisual">Nombre del Control</param>
        /// <returns>Regresa Verdadero o Falso</returns>
        public static bool IsPresent(TextBox objVisual)
        {
            //validar que existe valor en control
            if (objVisual.Text.Equals(""))
            {
                XtraMessageBox.Show(String.Format("{0} es requerido", objVisual.Tag), Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                objVisual.Focus();    //colocar cursor en Control
                return false;   //no tiene valor
            }
            return true;        //tiene valor
        }

        /// <summary>
        /// Método que valida la existencia de un valor en el control GridLookUpEdit
        /// </summary>
        /// <param name="objVisual">Nombre del Control</param>
        /// <returns>Regresa Verdadero o Falso</returns>
        public static bool IsPresent(GridLookUpEdit objVisual)
        {
            //validar que existe valor en control
            if (objVisual.Text.Equals(""))
            {
                XtraMessageBox.Show(String.Format("{0} es requerido", objVisual.Tag), Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                objVisual.Focus();    //colocar cursor en Control
                return false;   //no tiene valor
            }
            return true;        //tiene valor
        }

        /// <summary>
        ///  Método que valida la existencia de un valor en el control Combobox
        /// </summary>
        /// <param name="objVisual">Nombre del Control</param>
        /// <returns>Regresa Verdadero o Falso</returns>
        public static bool IsPresent(System.Windows.Forms.ComboBox objVisual)
        {
            //validar que existe valor en control
            if (objVisual.Text.Equals(""))
            {
                XtraMessageBox.Show(String.Format("{0} es requerido", objVisual.Tag), Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                objVisual.Focus();    //colocar cursor en Control
                return false;   //no tiene valor
            }
            return true;        //tiene valor

        }

        /// Método que valida la existencia de un valor en el control SpinEdit
        /// </summary>
        /// <param name="objVisual">Nombre del Control</param>
        /// <returns>Regresa Verdadero o Falso</returns>
        public static bool IsPresent(SpinEdit objVisual)
        {
            //validar que existe valor en control
            if (objVisual.EditValue.Equals(""))
            {
                XtraMessageBox.Show(String.Format("{0} es requerido", objVisual.Tag), Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                objVisual.Focus();    //colocar cursor en Control
                return false;   //no tiene valor
            }
            return true;        //tiene valor
        }


        /// Método que valida la existencia de un valor en el control TextEdit
        /// </summary>
        /// <param name="objVisual">Nombre del Control</param>
        /// <returns>Regresa Verdadero o Falso</returns>
        public static bool IsPresent(TextEdit objVisual)
        {
            if (objVisual.EditValue != null)
            {
                //validar que existe valor en control
                if (objVisual.EditValue.Equals(""))
                {
                    XtraMessageBox.Show(String.Format("{0} es requerido", objVisual.Tag), Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    objVisual.Focus();    //colocar cursor en Control
                    return false;   //no tiene valor
                }
                else if (objVisual.EditValue.ToString().Trim().Length == 0)
                {
                    XtraMessageBox.Show(String.Format("{0} es requerido", objVisual.Tag), Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    objVisual.Focus();    //colocar cursor en Control
                    return false;   //no tiene valor
                }
            }
            else
            {
                XtraMessageBox.Show(String.Format("{0} es requerido", objVisual.Tag), Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                objVisual.Focus();    //colocar cursor en Control
                return false;   //no tiene valor
            }

            return true;        //tiene valor
        }

        public static bool IsPositiveOrZeroNumberGrid(GridLookUpEdit objVisual)
        {
            int ivalor = 0;
            int.TryParse(objVisual.EditValue.ToString(), out ivalor);

            //validar que existe valor en control
            if (ivalor <= 0)
            {
                XtraMessageBox.Show(String.Format("{0} Es requerido.", objVisual.Tag), Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                objVisual.Focus();    //colocar cursor en Control
                return false;   //no tiene valor
            }
            return true;        //tiene valor
        }

        /// <summary>
        /// Método que valida la existencia de un valor en el control DateEdit
        /// </summary>
        /// <param name="objVisual">Nombre del Control</param>
        /// <returns>Regresa Verdadero o Falso</returns>
        public static bool IsPresent(DateEdit objVisual)
        {
            //validar que existe valor en control
            if (objVisual.Text.Equals(""))
            {
                XtraMessageBox.Show(String.Format("{0} es requerido", objVisual.Tag), Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                objVisual.Focus();    //colocar cursor en Control
                return false;   //no tiene valor
            }
            return true;        //tiene valor
        }

        /// <summary>
        /// Método que valida la existencia de un valor en el control SpinEdit
        /// </summary>
        /// <param name="objVisual">Nombre del Control</param>
        /// <returns>Regresa Verdadero o Falso</returns>
        public static bool IsPositiveNumber(SpinEdit objVisual)
        {
            //validar que existe valor en control
            if (Convert.ToDecimal(objVisual.Text) <= 0)
            {
                XtraMessageBox.Show(String.Format("{0} debe ser mayor a CERO.", objVisual.Tag), Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                objVisual.Focus();    //colocar cursor en Control
                return false;   //no tiene valor
            }
            return true;        //tiene valor
        }


        /// <summary>
        /// Método que valida la existencia de un valor en el control LookUpEdit
        /// </summary>
        /// <param name="objVisual">Nombre del Control</param>
        /// <returns>Regresa Verdadero o Falso</returns>
        public static bool IsPositiveNumber(LookUpEdit objVisual)
        {
            //validar que existe valor en control
            if (Convert.ToInt64(objVisual.EditValue) <= 0)
            {
                XtraMessageBox.Show(String.Format("{0} debe ser asignada.", objVisual.Tag), Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                objVisual.Focus();    //colocar cursor en Control
                return false;   //no tiene valor
            }
            return true;        //tiene valor
        }

        /// <summary>
        /// Método que valida la existencia de un valor en el control SpinEdit
        /// </summary>
        /// <param name="objVisual">Nombre del Control</param>
        /// <returns>Regresa Verdadero o Falso</returns>
        public static bool IsPositiveOrZeroNumber(SpinEdit objVisual)
        {
            //validar que existe valor en control
            if (Convert.ToDecimal(objVisual.Text) < 0)
            {
                XtraMessageBox.Show(String.Format("{0} debe ser mayor o igual a CERO.", objVisual.Tag), Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                objVisual.Focus();    //colocar cursor en Control
                return false;   //no tiene valor
            }
            return true;        //tiene valor
        }

        /// <summary>
        /// Método que valida la existencia de un valor en el control SpinEdit
        /// </summary>
        /// <param name="objVisual">Nombre del Control</param>
        /// <returns>Regresa Verdadero o Falso</returns>
        public static bool IsPositiveOrZeroNumber(TextBox objVisual)
        {
            //validar que existe valor en control
            if (Convert.ToDecimal(objVisual.Text) < 0)
            {
                XtraMessageBox.Show(String.Format("{0} debe ser mayor o igual a CERO.", objVisual.Tag), Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                objVisual.Focus();    //colocar cursor en Control
                return false;   //no tiene valor
            }
            return true;        //tiene valor
        }

        /// <summary>
        /// Método que valida la existencia de un valor en el control SpinEdit
        /// </summary>
        /// <param name="objVisual">Nombre del Control</param>
        /// <returns>Regresa Verdadero o Falso</returns>
        public static bool IsPositiveOrZeroNumber(TextEdit objVisual)
        {
            //validar que existe valor en control
            if (Convert.ToDecimal(objVisual.Text) < 0)
            {
                XtraMessageBox.Show(String.Format("{0} debe ser mayor o igual a CERO.", objVisual.Tag), Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                objVisual.Focus();    //colocar cursor en Control
                return false;   //no tiene valor
            }
            return true;        //tiene valor
        }

        /// <summary>
        /// Método que valida la existencia de un valor en el control TextEdit
        /// </summary>
        /// <param name="objVisual">Nombre del Control</param>
        /// <returns>Regresa Verdadero o Falso</returns>
        public static bool IsPositiveNumber(TextEdit objVisual)
        {
            //validar que existe valor en control
            if (Convert.ToDecimal(objVisual.Text.Replace("$", string.Empty).Replace(",",string.Empty)) <= 0)
            {
                XtraMessageBox.Show(String.Format("{0} debe ser mayor a CERO.", objVisual.Tag), Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                objVisual.Focus();    //colocar cursor en Control
                return false;   //no tiene valor
            }
            return true;        //tiene valor
        }

        /// <summary>
        /// Método que valida un valor numérico al realizar la conversión
        /// en Decimal
        /// </summary>
        /// <param name="objTextBox">Objeto Textbox</param>
        /// <returns>Valor TRUE o FALSE</returns>
        public static bool IsDecimal(TextBox objVisual)
        {
            try
            {
                Convert.ToDecimal(objVisual.Text);
                return true;
            }
            catch (FormatException)
            {
                XtraMessageBox.Show(String.Format("{0} debe ser mayor o igual a CERO.", objVisual.Tag), Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                objVisual.Focus();    //colocar cursor en Control
                return false;   //no tiene valor
            }
        }

        /// <summary>
        /// Método que valida un valor numérico al realizar la conversión
        /// en Decimal
        /// </summary>
        /// <param name="objTextBox">Objeto Textbox DevExpress</param>
        /// <returns>Valor TRUE o FALSE</returns>
        public static bool IsDecimal(TextEdit objVisual)
        {
            try
            {
                Convert.ToDecimal(objVisual.Text);
                return true;
            }
            catch (FormatException)
            {
                XtraMessageBox.Show(String.Format("{0} debe ser mayor o igual a CERO.", objVisual.Tag), Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                objVisual.Focus();    //colocar cursor en Control
                return false;   //no tiene valor
            }
        }

        public static bool IsWithinRange(TextEdit objVisual, string msj, byte max)
        {
            if (objVisual.Text.Trim().Length < max)
            {
                XtraMessageBox.Show(String.Format("{0}", msj), Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                objVisual.Focus();    //colocar cursor en Control
                objVisual.SelectAll();  //seleccionar todo el texto
                return false;   //no tiene valor
            }
            return true;
        }

        /// <summary>
        /// Método para validar fecha
        /// </summary>
        /// <param name="objFecha">Objeto Calendario Date Edit DevExpress</param>
        /// <returns>Valor VERDADERO o FALSO</returns>
        public static bool IsDate(DateEdit objVisual)
        {
            try
            {
                if (objVisual.EditValue == null)
                    return false;
                else
                {
                    Convert.ToDateTime(objVisual.EditValue);
                    return true;
                }
            }
            catch
            {
                XtraMessageBox.Show(String.Format("{0} inválida.", objVisual.Tag), Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                objVisual.Focus();    //colocar cursor en Control
                return false;   //no tiene valor
            }
        }


        public static bool IsValidDataCombobox(LookUpEdit objVisual)
        {
            if ((objVisual.EditValue != null) && !objVisual.EditValue.Equals(""))
                return true;
            else
            {
                XtraMessageBox.Show(String.Format("{0} inválido", objVisual.Tag), Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                objVisual.Focus();    //colocar cursor en Control
                return false;   //no tiene valor
            }
        }

        public static bool IsValidDataCombobox(GridLookUpEdit objVisual)
        {
            if ((objVisual.EditValue != null) && !objVisual.EditValue.Equals(""))
                return true;
            else
            {
                XtraMessageBox.Show(String.Format("{0} inválido", objVisual.Tag), Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                objVisual.Focus();    //colocar cursor en Control
                return false;   //no tiene valor
            }
        }

        /// <summary>
        /// Método que valida la existencia de un valor en el control GridLookUpEdit
        /// </summary>
        /// <param name="objVisual">Nombre del Control</param>
        /// <returns>Regresa Verdadero o Falso</returns>
        public static bool IsPresentOtroConceptoSubClasificacion(GridLookUpEdit objVisual, MemoEdit objMemoVisual)
        {
            //validar que existe valor en control
            if (objVisual.Text.Equals("OTRO"))
            {
                if (objMemoVisual.Text.Trim().Length == 0)
                {
                    XtraMessageBox.Show(String.Format("{0} es requerido", objMemoVisual.Tag), Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    objMemoVisual.Focus();    //colocar cursor en Control
                    return false;   //no tiene valor
                }
            }
            return true;        //tiene valor
        }

    }
}
