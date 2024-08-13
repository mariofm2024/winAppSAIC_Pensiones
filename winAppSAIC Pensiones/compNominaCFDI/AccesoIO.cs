using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using compCatalogosSAIC;


namespace compNominaCFDI
{
    public static class AccesoIO
    {
        // Methods
        public static string ISO_Date()
        {
            return DateTime.Now.ToString("yyyyMMdd_HHmmss");
        }

        public static string ValidarCrearDirectorioCFDI(string pNombreDirectorio, EmpleadoGenerico pObjEmpleado, string pFechaHora)
        {
            try
            {
                if (!Directory.Exists(pNombreDirectorio))
                {
                    Directory.CreateDirectory(pNombreDirectorio);
                }
                if (!Directory.Exists(string.Format(@"{0}\E{1}_{2}", pNombreDirectorio, pObjEmpleado.IdEmpleado.ToString(), pFechaHora)))
                {
                    Directory.CreateDirectory(string.Format(@"{0}\E{1}_{2}", pNombreDirectorio, pObjEmpleado.IdEmpleado.ToString(), pFechaHora));
                }
                return string.Format(@"{0}\E{1}_{2}", pNombreDirectorio, pObjEmpleado.IdEmpleado.ToString(), pFechaHora);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return "";
            }
        }

        public static string ValidarCrearDirectorioCFDI(string pNombreDirectorio, string pRFCTenedora, string pFechaHora)
        {
            try
            {
                if (!Directory.Exists(pNombreDirectorio))
                {
                    Directory.CreateDirectory(pNombreDirectorio);
                }
                if (!Directory.Exists(string.Format(@"{0}\{1}_{2}", pNombreDirectorio, pRFCTenedora, pFechaHora)))
                {
                    Directory.CreateDirectory(string.Format(@"{0}\{1}_{2}", pNombreDirectorio, pRFCTenedora, pFechaHora));
                }
                return string.Format(@"{0}\{1}_{2}", pNombreDirectorio, pRFCTenedora, pFechaHora);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return "";
            }
        }

        public static string ValidarCrearDirectorioCFDI(string pNombreDirectorio, string pRFCTenedora, long pIdLoteCargaNomina, string pFechaHora)
        {
            try
            {
                if (!Directory.Exists(pNombreDirectorio))
                {
                    Directory.CreateDirectory(pNombreDirectorio);
                }
                if (!Directory.Exists(string.Format(@"{0}\{1}_L{2}_{3}", new object[] { pNombreDirectorio, pRFCTenedora, pIdLoteCargaNomina.ToString(), pFechaHora })))
                {
                    Directory.CreateDirectory(string.Format(@"{0}\{1}_L{2}_{3}", new object[] { pNombreDirectorio, pRFCTenedora, pIdLoteCargaNomina.ToString(), pFechaHora }));
                }
                return string.Format(@"{0}\{1}_L{2}_{3}", new object[] { pNombreDirectorio, pRFCTenedora, pIdLoteCargaNomina.ToString(), pFechaHora });
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return "";
            }
        }

        public static string ValidarCrearDirectorioRespuestaCFDI(string pNombreDirectorio)
        {
            try
            {
                if (!Directory.Exists(pNombreDirectorio))
                {
                    Directory.CreateDirectory(pNombreDirectorio);
                }
                if (!Directory.Exists(string.Format(@"{0}\", pNombreDirectorio)))
                {
                    Directory.CreateDirectory(string.Format(@"{0}\", pNombreDirectorio));
                }
                return string.Format("{0}", pNombreDirectorio);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return "";
            }
        }

        public static string ValidarCrearDirectorioXMLCFDI(string pNombreDirectorio, string pRFCTenedora)
        {
            try
            {
                if (!Directory.Exists(string.Format(@"{0}\{1}", pNombreDirectorio, pRFCTenedora)))
                {
                    Directory.CreateDirectory(string.Format(@"{0}\{1}", pNombreDirectorio, pRFCTenedora));
                }
                return string.Format(@"{0}\{1}", pNombreDirectorio, pRFCTenedora);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return "";
            }
        }
        /// <summary>
        /// Validar y crear el directorio de salida, sino existe, 
        /// para los Layouts CFDI. 
        /// <param name="pNombreDirectorio">Directorio Raiz</param>
        /// <param name="pRFCTenedora">RFC Tenedora</param>
        /// <param name="pFechaHora">Fecha y Hora de creacion</param>
        /// </summary>
        public static string ValidarCrearDirectorioCPago(string pNombreDirectorio, string pIdSolicitud, string pFechaHora)
        {
            try
            {
                if (!Directory.Exists(@pNombreDirectorio))       //si no existe el directorio
                {
                    Directory.CreateDirectory(@pNombreDirectorio);       //crear directorio
                }

                if (!Directory.Exists(String.Format(@"{0}\S{1}_{2}", pNombreDirectorio, pIdSolicitud, pFechaHora)))       //si no existe el directorio
                {
                    Directory.CreateDirectory(String.Format(@"{0}\S{1}_{2}", pNombreDirectorio, pIdSolicitud, pFechaHora));       //crear directorio
                }

                //regresar Directorio destino de los archivos
                return String.Format(@"{0}\S{1}_{2}", pNombreDirectorio, pIdSolicitud, pFechaHora);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";      //vacio
            }
        }

        public static string ValidarCrearDirectorioControlP(string pNombreDirectorio, string pIdSolicitud, string pFechaHora)
        {
            try
            {
                if (!Directory.Exists(@pNombreDirectorio))       //si no existe el directorio
                {
                    Directory.CreateDirectory(@pNombreDirectorio);       //crear directorio
                }

                if (!Directory.Exists(String.Format(@"{0}\C{1}_{2}", pNombreDirectorio, pIdSolicitud, pFechaHora)))       //si no existe el directorio
                {
                    Directory.CreateDirectory(String.Format(@"{0}\C{1}_{2}", pNombreDirectorio, pIdSolicitud, pFechaHora));       //crear directorio
                }
                else
                {
                    Directory.Delete(String.Format(@"{0}\C{1}_{2}", pNombreDirectorio, pIdSolicitud, pFechaHora),true);       //crear directorio
                    Directory.CreateDirectory(String.Format(@"{0}\C{1}_{2}", pNombreDirectorio, pIdSolicitud, pFechaHora));       //crear directorio
                }

                //regresar Directorio destino de los archivos
                return String.Format(@"{0}\C{1}_{2}", pNombreDirectorio, pIdSolicitud, pFechaHora);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";      //vacio
            }
        }
        /// <summary>
        /// Validar y crear el directorio de salida, sino existe, 
        /// para los Layouts CFDI. 
        /// <param name="pNombreDirectorio">Directorio Raiz</param>
        /// <param name="pRFCTenedora">RFC Tenedora</param>
        /// <param name="pFechaHora">Fecha y Hora de creacion</param>
        /// </summary>
        public static string ValidarCrearDirectorioCFactura(string pNombreDirectorio, string pIdFactura, string Serie, string pFechaHora)
        {
            try
            {
                if (!Directory.Exists(@pNombreDirectorio))       //si no existe el directorio
                {
                    Directory.CreateDirectory(@pNombreDirectorio);       //crear directorio
                }

                if (!Directory.Exists(String.Format(@"{0}\F{1}_{2}_{3}", pNombreDirectorio, pIdFactura, Serie, pFechaHora)))       //si no existe el directorio
                {
                    Directory.CreateDirectory(String.Format(@"{0}\F{1}_{2}_{3}", pNombreDirectorio, pIdFactura, Serie, pFechaHora));       //crear directorio
                }

                //regresar Directorio destino de los archivos
                return String.Format(@"{0}\F{1}_{2}_{3}", pNombreDirectorio, pIdFactura, Serie, pFechaHora);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";      //vacio
            }
        }
        public static string ValidarCrearDirectorioCFactura(string pNombreDirectorio, string pFechaHora)
        {
            try
            {
                if (!Directory.Exists(@pNombreDirectorio))       //si no existe el directorio
                {
                    Directory.CreateDirectory(@pNombreDirectorio);       //crear directorio
                }

                if (!Directory.Exists(String.Format(@"{0}\Facturas{1}", pNombreDirectorio, pFechaHora)))       //si no existe el directorio
                {
                    Directory.CreateDirectory(String.Format(@"{0}\Facturas{1}", pNombreDirectorio, pFechaHora));       //crear directorio
                }

                //regresar Directorio destino de los archivos
                return String.Format(@"{0}\Facturas{1}", pNombreDirectorio, pFechaHora);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";      //vacio
            }
        }

    }
}