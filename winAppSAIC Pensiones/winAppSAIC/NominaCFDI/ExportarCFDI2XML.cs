using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using winAppSAIC.UtileriasLocal;
using compNominaCFDI;

namespace winAppSAIC.NominaCFDI
{
    public static class ExportarCFDI2XML
    {
        /// <summary>
        /// Método para generar el Archivo XML CFDI del recibo seleccionado
        /// </summary>
        /// <param name="objTable">Objeto DataTable</param>
        public static Estructuras.InformacionError GenerarTimbradosXMLIndividual(string strNombreArchivo, string pXmlCFDI)
        {
            //inicializar valores de objError
            Estructuras.InformacionError objError = new Estructuras.InformacionError { existeError = false, noError = 0, mensajeError = String.Empty };

            try
            {
                //decodificar Contenido XML
                string decodedXmlCFDI = pXmlCFDI; //Encoding.UTF8.GetString(data);

                //Crear archivo XML desde un string
                XmlDocument xdoc = new XmlDocument();
                xdoc.LoadXml(decodedXmlCFDI);
                //xdoc.Save(String.Format(@"{0}\{1}_E{2}_{3}{4}.xml", pRutaArchivosCFDI, pObjNomina.rfcTenedora, pObjNomina.numEmpleado, pObjNomina.serieRecibo, pObjNomina.folioRecibo));
                xdoc.Save(strNombreArchivo);
            }
            catch (Exception ex)
            {
                objError.existeError = true;
                objError.noError = -99;
                objError.mensajeError = ex.Message;
            }
            return objError;        //regresar estatus OK o ERROR
        }

    }
}
