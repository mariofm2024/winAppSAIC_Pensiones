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
using System.Text.RegularExpressions;
using compCatalogosSAIC;
using System.Diagnostics;
using DevExpress.Utils;
using System.Net;
using winAppSAIC.tools;

namespace winAppSAIC.OperadoresM
{
    public partial class XtraAltaEmpleados : DevExpress.XtraEditors.XtraForm
    {
        String stLog;
        #region Variables
        tools.dsc DSC = new tools.dsc();
        String sRuta_Ope_Altas = String.Empty;
        String sRuta_Ope_Bajas = String.Empty;
        String sRuta_Ope_Salario = String.Empty;
        String sRuta_Ope_Cuentas = String.Empty;
        String sRutaCarpeta = String.Empty;

        ToolTipController defController = ToolTipController.DefaultController;
        String stRutaArchivoDescargado = String.Empty;

        int? idmiSolciitud = 0;
        int stFilaInicial = 3;

        decimal dcVacaciones = 6.00M;
        decimal dcPrimaVacacional = 25.00M;
        decimal dcAguinaldo = 15.00M;

        String stColumnaFinal = "AY";
        String stColumnaObservacionesSAIC = "AZ";

        String[] arrayNombreColumnas;

        DataTable dtColumnasPlantilla = new DataTable();
        DataTable lsErrores = new DataTable();

        Excel.Application appExcel;
        Excel.Application appExcelAltaArchivo;
        Excel.Worksheet SheetExcelEmpleados;
        Excel.Workbook bookExcelAlta;

        DataTable dtEmpleados;
        Boolean banEsPlantilla = false;
        String stRutaDocumentosExcel = String.Empty;

        String[] arrayDiasSemana = new String[] {
            "LUNES",
            "MARTES",
            "MIERCOLES",
            "JUEVES",
            "VIERNES",
            "SABADO",
            "DOMINGO"
        };
        DateTime dtFechaServidor = new DateTime();

        //********************Variables para las bajas********************//
        preSolicitud miPreSolicitud;
        String[] arrayNombreColumnasBajas; //para validar los titulos del archivo de excel.
        DateTime dTimeFechaServidor = new DateTime(); //para obtener la fecha del servidor
        DateTime dtFechaLimitebaja = new DateTime();
        DateTime dtFechaLimiteFuturaBaja = new DateTime();
        Boolean banEsPlantillaBajas = false;
        Boolean banEsPlantillaDeSalario = false;
        String stColumnaFinalBajas = "J";
        String stColumnaObservacionesSAICBajas = "K";
        Empleado objEmp;
        XtraMotivoBajaEmpleado Bajas;
        //********************Variables para las bajas********************//


        //********************Variables Solicitud de Salarios********************//
        String[] arrayNombreColumnasSalarios;
        String stColumnaFinalSalarios = "S";
        String stColumnaObservacionesSAICSalarios = "T";
        //********************Variables Solicitud de Salarios********************//

        String AreaDeApertura;

        Boolean flagMensajeDeFechasExtemporaneas = false;

        #endregion Variables
        public XtraAltaEmpleados(String AreaDeApertura)
        {
            InitializeComponent();
            inicializarvariables();
            inicializarvariablesColumnasBajas();
            inicializarVariablesColumnasSalarios();
            iniDTErrores();
            Bajas = new XtraMotivoBajaEmpleado(objEmp, 0, DateTime.Now);
            this.AreaDeApertura = AreaDeApertura;
            habiltarBotones();
        }

        private void inicializarvariables()
        {
            stLog = String.Empty;
            arrayNombreColumnas = new String[]
            {
"Apellido Paterno",//Ya
"Apellido Materno",//Ya
"Nombres",//Ya
"Fecha de Ingreso Cliente",//Ya
"Salario Diario Cliente",//Ya
"NSS",//Ya
"RFC",//Ya
"CURP",//Ya
"Nacionalidad",//Ya
"Estado Civil",//Ya
"Tipo Identificacion",//Ya
"Numero de Identificacion", //Ya
"Puesto Real",
"Departamento o Area Real",
"Herramientas de Trabajo",//Ya
"Tipo de nomina",
"Funciones a Desempeñar", //Ya
"Dias de Jornada",//YA
"Horario Jornada", //YA
"Jornada de Servicio",//YA
"Tiempo de comida o descanso",//YA
"Tipo de contrato", //YA
"Tiempo de contrato",//YA
"Concepto Contratacion", //Ya
"Calle Centro de Trabajo",
"No Exterior Centro de Trabajo",
"No Interior Centro de Trabajo",
"Colonia Centro de Trabajo",
"Codigo Postal Centro de Trabajo",
"Delegacion o Municipio Centro de Trabajo",
"Estado Centro Trabajo",
"Calle Domicilio Empleado",
"No Exterior Domicilio Empleado",
"No Interior Domicilio Empleado",
"Colonia Domicilio Empleado",
"Codigo Postal Domicilio Empleado",
"Delegacion o Municipio Domicilio Empleado",
"Estado Centro Empleado",
"Codigo Postal Domicilio Fiscal",
"Centro de Costo",
"No de credito INFONAVIT",
"Tipo Pago",
"CLABE",
"Puesto Contrato",
"Fecha de Ingreso Contrato",
"Salario Diario Contrato",
"Salario Diario Integrado",
"Correo Electronico",
"Esquema",
"Informacion Confidencial",
"Claves"
            };
        }

        private void inicializarvariablesColumnasBajas()
        {
            arrayNombreColumnasBajas = new String[]
            {
                "IdEmpleado",
                "Apellido Paterno",
                "Apellido Materno",
                "Nombres",
                "NSS",
                "RFC",
                "CURP",
                "Motivo de Baja",
                "Fecha de Baja",
                "Observaciones Baja"
            };
        }


        private void inicializarVariablesColumnasSalarios()
        {
            arrayNombreColumnasSalarios = new String[]
            {
                "IdEmpleado",
                "Apellido Paterno",
                "Apellido Materno",
                "Nombres",
                "NSS",
                "RFC",
                "CURP",

                "Salario Diario Nuevo",
                "Fecha de Aplicacion",
                "Parte Variable",

                "Salario Base de Cotizacion",
                "Salario Diario Integrado",
                "Vacaciones",
                "Prima Vacacional",
                "Aguinaldo",
                "Años Laborados",
                "Factor de Integracion",
                "UMA",
                "Salario Diario Actual"
            };
        }

        /// <summary>
        /// Inicializar el Datatable de los errores
        /// </summary>
        private void iniDTErrores()
        {
            lsErrores.Columns.Add("Columna");
            lsErrores.Columns.Add("Fila");
            lsErrores.Columns.Add("Error");
            lsErrores.Columns.Add("Error Acumulado");
            lsErrores.Columns.Add("Tipo Error", typeof(int));
        }

        private void CargarInformacionVentanaBajas()
        {
            String stFechaincial = String.Empty;
            stpSelDiasFestivosTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelDiasFestivos);
            stpSelObtenerConceptosBajaTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelObtenerConceptosBaja, true);

            stFechaincial = stpSelEstatusNominaContabilizadaTableAdapter1.ObtenerFechaServidor().ToString();
            DateTime.TryParse(stFechaincial, out dTimeFechaServidor);
        }

        private void CargarInformacionVentana()
        {
            try
            {
                splashScreenManager3.ShowWaitForm();

                stpSelObtenerConceptosBajaTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelObtenerConceptosBaja, true);
                stpSelDiasFestivosTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelDiasFestivos);

                stpSelObtenerInfoGenericaTenedoraSA_1TableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoGenericaTenedoraSA_1, false);
                stpSelObtenerInfoGenericaTenedoraSC_1TableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoGenericaTenedoraSC_1, 1, false);
                stpSelClientesConfidencialTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelClientesConfidencial, OperadorBD.OperadorGlobal.Confidencial);

                stpSelColumnasSubirEmpleadosTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelColumnasSubirEmpleados);
                dtColumnasPlantilla = dbSAICBPOCatalogosDataSet1.stpSelColumnasSubirEmpleados;
                stpSelNacionalidadTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelNacionalidad);
                stpSelTipoIdentificacionTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelTipoIdentificacion);
                stpSelEstadoCivilTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelEstadoCivil);
                stpSelTipoPeriodoNominaTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelTipoPeriodoNomina);
                stpSelJornadaServicioTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelJornadaServicio);
                stpSelTipoContratoTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelTipoContrato);
                stpSelEstatusTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelEstatus);
                stpSelCodigoPostalTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelCodigoPostal);
                stpSelFormaPagoTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelFormaPago);
                stpSelTurnoTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelTurno);

                gridLookCliente.Properties.PopupFormWidth = 400;
                gridLookTenedoraSA.Properties.PopupFormWidth = 400;
                gridLookTenedoraSC.Properties.PopupFormWidth = 400;

                splashScreenManager3.CloseWaitForm();

                defController.Appearance.BackColor = Color.AntiqueWhite;
                defController.ShowBeak = true;
                mensajeRadioInfoContrato();
                habilitarBotones(true);

                try { SheetExcelEmpleados.Activate(); }
                catch
                {
                    btnAgregarPlantilla.Text = "Agregar";
                    lblTipoPlantilla.Text = String.Empty;
                }
                //gridLookTenedoraSA.Enabled = false;
                //gridLookTenedoraSC.Enabled = false;

                btnSolicitarEmpleados.Enabled = false;
                btnAbrirCarpeta.Enabled = false;
                GridEmpleados.DataSource = null;

                dtFechaServidor = ObtenerFechaServidor();//Obteniendo la fecha del servidor

                dtFechaLimitebaja = Bajas.ObtenerFechaLimiteBajaIMSS(dtFechaServidor, dbSAICBPOCatalogosDataSet1.stpSelDiasFestivos);
                dtFechaLimiteFuturaBaja = Bajas.ObtenerFechaLimiteBajaIMSSFutura(dtFechaServidor);

                labelTipoPlantilla.Text = "Tipo Plantilla:";

                obtenerValoresPrestacionesMayoresALALey();

                sRuta_Ope_Altas = DSC.ObtenerRutaSolicitud(1, 1);
                sRuta_Ope_Bajas = DSC.ObtenerRutaSolicitud(2, 1);
                sRuta_Ope_Cuentas = DSC.ObtenerRutaSolicitud(3, 1);
                sRuta_Ope_Salario = DSC.ObtenerRutaSolicitud(4, 1);
            }
            catch (Exception ex)
            {
                if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                XtraMessageBox.Show("Error al cargar la información de Alta." + Environment.NewLine + ex.Message
                           , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void obtenerValoresPrestacionesMayoresALALey()
        {

            //afdlkajdflkja

            //decimal dcVacaciones = 6.00M;
            //decimal dcPrimaVacacional = 25.00M;
            //decimal dcAguinaldo = 15.00M;

            stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "VACACIONES");
            if (dbSAICBPOValidacionDataSet1.stpSelParametro.Rows.Count > 0)
            {
                decimal.TryParse(dbSAICBPOValidacionDataSet1.stpSelParametro[0]["ValorParametro"].ToString(), out dcVacaciones);
            }
            else
            {
                dcVacaciones = 6.00M;
            }

            stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "PRIMAVACACIONAL");
            if (dbSAICBPOValidacionDataSet1.stpSelParametro.Rows.Count > 0)
            {
                decimal.TryParse(dbSAICBPOValidacionDataSet1.stpSelParametro[0]["ValorParametro"].ToString(), out dcPrimaVacacional);
            }
            else
            {
                dcPrimaVacacional = 25.00M;
            }


            stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "AGUINALDO");
            if (dbSAICBPOValidacionDataSet1.stpSelParametro.Rows.Count > 0)
            {
                decimal.TryParse(dbSAICBPOValidacionDataSet1.stpSelParametro[0]["ValorParametro"].ToString(), out dcAguinaldo);
            }
            else
            {
                dcAguinaldo = 15.00M;
            }
        }


        private void XtraAltaEmpleados_Load(object sender, EventArgs e)
        {
            CargarInformacionVentana();
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

        private void habilitarBotones(Boolean habilitar)
        {
            rdContratoNormal.Enabled = habilitar;
            rdPrestacionesAlaLey.Enabled = habilitar;
        }

        private void btnAgregarPlantilla_Click(object sender, EventArgs e)
        {

            try
            {
                splashScreenManager3.ShowWaitForm();
                splashScreenManager3.SetWaitFormCaption("Cargando Informacion");
                splashScreenManager3.SetWaitFormDescription("Por favor Espere...");
                stLog = String.Empty;
                stLog = DSC.iniLog("Alta de Empleados", OperadorBD.OperadorGlobal.NombreUsuario);
                flagMensajeDeFechasExtemporaneas = false;


                gridLookTenedoraSA.Enabled = false;
                gridLookTenedoraSC.Enabled = false;
                gridLookCliente.Enabled = false;
                miPreSolicitud = new preSolicitud();

                //gridLookTenedoraSA.EditValue = -1;
                //gridLookTenedoraSC.EditValue = -1;

                gridViewEmpleados.Columns.Clear();
                lsErrores.Clear();
                btnSolicitarEmpleados.Enabled = false;

                dtEmpleados = new DataTable();
                dtEmpleados.Clear();
                //DataTable dtEmpleadosCFDI = new DataTable();
                //Boolean banderaAvisos = false;
                lsErrores.Clear();

                if (SheetExcelEmpleados == null)
                {
                    SheetExcelEmpleados = abrirArchivo();
                    banEsPlantilla = false;
                    banEsPlantillaBajas = false;
                }

                if (SheetExcelEmpleados != null)
                {
                    try { SheetExcelEmpleados.Activate(); }
                    catch (Exception)
                    {
                        SheetExcelEmpleados = abrirArchivo();
                        stLog = DSC.addLog(stLog, "Activando Hoja");
                        SheetExcelEmpleados.Activate();
                        banEsPlantilla = false;
                        banEsPlantillaBajas = false;
                    }

                    stLog = DSC.addLog(stLog, "Quitando Formato de Hoja");
                    DSC.quitarFormatoHoja(SheetExcelEmpleados, "A" + stFilaInicial);

                    stLog = DSC.addLog(stLog, "Validando encabezados de la Plantilla");
                    if (!banEsPlantilla) { banEsPlantilla = validarPlantillla(SheetExcelEmpleados); }

                    if (!banEsPlantilla)
                    {
                        if (!banEsPlantillaBajas) { banEsPlantillaBajas = validarPlantilllaBajas(SheetExcelEmpleados); }
                    }

                    //Revisando si la plantilla seleccionada es de solicitud de salarios
                    if (!banEsPlantilla && !banEsPlantillaBajas)
                    {
                        banEsPlantillaDeSalario = validarPlantilllaSalario(SheetExcelEmpleados);
                    }

                    if (banEsPlantilla || banEsPlantillaBajas || banEsPlantillaDeSalario)
                    {

                        if (banEsPlantilla)
                        {
                            #region Altas
                            stLog = DSC.addLog(stLog, "Tipo Plantilla: Alta");

                            labelTipoPlantilla.Text = "Tipo Plantilla: Alta";
                            miPreSolicitud.iTipoSolicitud = 1;
                            SolicitarAltaDeEmpleados();
                            #endregion
                        }
                        else if (banEsPlantillaBajas)
                        {
                            #region Bajas
                            stLog = DSC.addLog(stLog, "Tipo Plantilla: Baja");
                            labelTipoPlantilla.Text = "Tipo Plantilla: Baja";
                            miPreSolicitud.iTipoSolicitud = 2;

                            stLog = DSC.addLog(stLog, "Obteniendo datos para la Solicitud");
                            miPreSolicitud = ObtenerTeneodraSolicitud(miPreSolicitud);
                            miPreSolicitud = ObtenerClienteSolicitud(miPreSolicitud);

                            if (miPreSolicitud.idTenedora > 0)//validar para la baja si se selecciono una tenedora SA
                            {
                                if (miPreSolicitud.idCliente > 0)//validar para la baja si se selecciono un Cliente/Obra 
                                {
                                    SolicitarBajaDeEmpleados(miPreSolicitud);
                                }
                                else
                                {
                                    if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                                    XtraMessageBox.Show("Para Solicitar Bajas " + Environment.NewLine + "Seleccione un Cliente para continuar ."
                                    , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    gridLookCliente.Focus();
                                    gridLookTenedoraSA.Enabled = true;
                                    gridLookCliente.Enabled = true;
                                }
                            }
                            else
                            {
                                if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                                XtraMessageBox.Show("Para Solicitar Bajas " + Environment.NewLine + "Seleccione una Tenedora SA, para continuar ."
                                 , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                gridLookTenedoraSA.Focus();
                                gridLookTenedoraSA.Enabled = true;
                                gridLookCliente.Enabled = true;
                            }
                            #endregion
                        }
                        else if (banEsPlantillaDeSalario)
                        {
                            #region Salarios
                            Boolean flagTaMuyBien = false;
                            stLog = DSC.addLog(stLog, "Tipo Plantilla: Salarios");

                            labelTipoPlantilla.Text = "Tipo Plantilla: Salarios";
                            miPreSolicitud.iTipoSolicitud = 4;

                            //***************************************************************
                            flagTaMuyBien = SolicitarActualizacionDeSalarios();
                            //***************************************************************

                            //deshabilitando opciones no necesarias para este tipo de solicitud
                            if (flagTaMuyBien) { btnSolicitarEmpleados.Enabled = true; }
                            else { btnSolicitarEmpleados.Enabled = false; }

                            rdContratoNormal.Enabled = false;
                            rdPrestacionesAlaLey.Enabled = false;
                            gridLookTenedoraSA.Enabled = false;
                            gridLookTenedoraSC.Enabled = false;
                            gridLookCliente.Enabled = false;
                            #endregion
                        }

                    }
                    else
                    {
                        stLog = DSC.addLog(stLog, "La plantilla que se selecciono no contiene la estructura correcta, por favor seleccione una plantilla valida.");
                        if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                        XtraMessageBox.Show("La plantilla que se selecciono no contiene la estructura correcta, por favor seleccione una plantilla valida."
                            , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnAgregarPlantilla.Text = "Agregar";
                    }
                }

                if (appExcel != null)
                {
                    appExcel.DisplayAlerts = true;
                }

            }
            catch (Exception ex)
            {
                stLog = DSC.addLog(stLog, "Error en el proceso de Altas:" + ex);
                stLog = DSC.finLog(stLog);
                DSC.guardarLog(stLog);

                if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                XtraMessageBox.Show("Error en el Proceso de Alta de Empleados." + Environment.NewLine + ex.Message
                           , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnAgregarPlantilla.Text = "Agregar";
            }
            finally
            {
                if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
            }

            if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }

            habiltarBotones();
        }

        private preSolicitud ObtenerClienteSolicitud(preSolicitud miPre)
        {
            int.TryParse(gridLookCliente.EditValue.ToString(), out miPre.idCliente);
            miPre.ClienteNombreComercial = gridLookCliente.Text;
            return miPre;
        }

        private preSolicitud ObtenerTeneodraSolicitud(preSolicitud miPre)
        {
            int.TryParse(gridLookTenedoraSA.EditValue.ToString(), out miPre.idTenedora);
            miPre.TenedoraNombreComercial = gridLookTenedoraSA.Text;
            return miPre;
        }


        /// <summary>
        /// Solicitar el alta de empleados
        /// </summary>
        private void SolicitarAltaDeEmpleados()
        {
            DataTable dtEmpleadosCFDI = new DataTable();
            Boolean banderaAvisos = false;
            dtEmpleados = obtenerDatosHoja(SheetExcelEmpleados);
            dtEmpleados = agregarColumnas(dtEmpleados);

            if (dtEmpleados.Rows.Count > 0)
            {
                splashScreenManager3.SetWaitFormCaption("Validando Empleados");

                //dtEmpleadosCFDI = iniDTEmpleadosCFDI();

                //**********************************************************************
                validarEmpleados(dtEmpleados, dtEmpleadosCFDI);
                //**********************************************************************

                System.Threading.Thread.Sleep(500);

                splashScreenManager3.SetWaitFormDescription("Validando Registros...");
                validarEmpleadosRepetidos(dtEmpleados, 1);
                dtEmpleados = quitarBlancos(dtEmpleados);

                //ObtenerTenedorasPorEsquema(dtEmpleados);

                System.Threading.Thread.Sleep(500);
                splashScreenManager3.SetWaitFormDescription("Enviando Resultado a Excel...");
                if (lsErrores.Rows.Count > 0)
                {
                    pintarErrores(lsErrores, SheetExcelEmpleados, stColumnaObservacionesSAIC);
                    banderaAvisos = soloAvisos(lsErrores);

                    if (banderaAvisos)
                    {
                        if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                        XtraMessageBox.Show("Hay Avisos en la información de la Plantilla."
                    , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        pintarGrid(dtEmpleados);
                    }
                    else
                    {
                        if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                        XtraMessageBox.Show("Hay Excepciones en la información de la Plantilla."
                      , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    pintarGrid(dtEmpleados);
                }


                if (flagMensajeDeFechasExtemporaneas)
                {
                    if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                    DialogResult oDialogResult = XtraMessageBox.Show("Se identificaron empleados con fechas extemporáneas en la Solicitud, ¿Desea continuar?"
                  , "SAIC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (DialogResult.No == oDialogResult)
                    {
                        GridEmpleados.DataSource = dtEmpleados.Clone();
                        btnSolicitarEmpleados.Enabled = false;
                    }
                }

            }
            else
            {
                if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                XtraMessageBox.Show("No se cuenta con informacion  en el archivo."
                  , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnAgregarPlantilla.Text = "Actualizar";
        }



        private Boolean SolicitarActualizacionDeSalarios()
        {
            Boolean flagTaMuyBien = false;
            Boolean banderaAvisos = false;
            DataTable dtEmpleadosCFDI = new DataTable();
            dtEmpleados = obtenerDatosSalariosExcel(SheetExcelEmpleados);

            if (dtEmpleados.Rows.Count > 0)
            {
                splashScreenManager3.SetWaitFormCaption("Validando Empleados");

                //**********************************************************************
                validarEmpleadosSalarios(dtEmpleados, dtEmpleadosCFDI);
                //**********************************************************************

                System.Threading.Thread.Sleep(500);
                splashScreenManager3.SetWaitFormDescription("Validando Registros...");

                validarEmpleadosRepetidos(dtEmpleados, 4);
                dtEmpleados = quitarBlancos(dtEmpleados);

                System.Threading.Thread.Sleep(500);
                splashScreenManager3.SetWaitFormDescription("Enviando Resultado a Excel...");
                if (lsErrores.Rows.Count > 0)
                {
                    pintarErrores(lsErrores, SheetExcelEmpleados, stColumnaObservacionesSAICSalarios);
                    banderaAvisos = soloAvisos(lsErrores);

                    if (banderaAvisos)
                    {
                        if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                        XtraMessageBox.Show("Hay Avisos en la información de la Plantilla."
                    , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        pintarGridSalarios(dtEmpleados);
                        flagTaMuyBien = true;
                    }
                    else
                    {
                        if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                        XtraMessageBox.Show("Hay Errores por corregir en la información de la Plantilla."
                      , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    pintarGridSalarios(dtEmpleados);
                    flagTaMuyBien = true;
                }
            }


            return flagTaMuyBien;
        }

        private DataTable obtenerDatosSalariosExcel(Excel.Worksheet SheetExcel)
        {
            Excel.Range unRango;
            unRango = DSC.UltimoCelda(SheetExcel);
            String ultimaCelda = unRango.get_AddressLocal(false, false, Excel.XlReferenceStyle.xlA1, false, false);

            unRango = SheetExcel.get_Range(stColumnaObservacionesSAICSalarios + "3", stColumnaObservacionesSAICSalarios + DSC.soloNumeros(ultimaCelda));
            unRango.Select();
            unRango.Clear();

            unRango = SheetExcel.get_Range("J3", "T" + DSC.soloNumeros(ultimaCelda));
            unRango.Select();
            unRango.Clear();

            unRango = SheetExcel.get_Range("A" + stFilaInicial, stColumnaFinalSalarios + DSC.soloNumeros(ultimaCelda));
            unRango.Select();
            unRango.Copy();
            System.Threading.Thread.Sleep(2000);
            String losDatos = Clipboard.GetText();
            losDatos = losDatos.ToUpper();

            //DataTable dtEmpleados_1 = DSC.ConvertToDataTable(losDatos);
            DataTable dtEmpleados_1 = DSC.ConvertToDataTable(losDatos, 19);
            dtEmpleados_1 = ingresarNombreColumnasSalarios(dtEmpleados_1);
            return dtEmpleados_1;
        }

        /// <summary>
        /// Validar si la plnatilla contiene los titulos correspondiente y en el lugar que corresponte
        /// </summary>
        /// <returns></returns>
        private Boolean validarPlantillla(Excel.Worksheet SheetExcel)
        {
            Boolean tamuyBien = false;
            String stLasColumnas = String.Empty;
            String losDatos = String.Empty;
            stLasColumnas = String.Join("", arrayNombreColumnas).ToUpper().Replace(" ", "");

            Excel.Range unRango;
            unRango = DSC.UltimoCelda(SheetExcel);
            unRango = SheetExcel.get_Range("A2", stColumnaFinal + "2");
            unRango.Select();
            unRango.Copy();
            System.Threading.Thread.Sleep(2000);
            losDatos = Clipboard.GetText();
            losDatos = losDatos.ToUpper().Replace("\t", "").Replace("\r", "").Replace("\n", "").Replace(" ", "");

            if (DSC.fonetica(losDatos, stLasColumnas))
            {
                tamuyBien = true;
            }

            return tamuyBien;

        }

        private Boolean validarPlantilllaBajas(Excel.Worksheet SheetExcel)
        {
            Boolean tamuyBien = false;
            String stLasColumnas = String.Empty;
            String losDatos = String.Empty;
            stLasColumnas = String.Join("", arrayNombreColumnasBajas).ToUpper().Replace(" ", "");

            Excel.Range unRango;
            unRango = DSC.UltimoCelda(SheetExcel);
            unRango = SheetExcel.get_Range("A2", stColumnaFinalBajas + "2");
            unRango.Select();
            unRango.Copy();
            System.Threading.Thread.Sleep(2000);
            losDatos = Clipboard.GetText();
            losDatos = losDatos.ToUpper().Replace("\t", "").Replace("\r", "").Replace("\n", "").Replace(" ", "");

            if (DSC.fonetica(losDatos, stLasColumnas))
            {
                tamuyBien = true;
            }

            return tamuyBien;
        }

        private Boolean validarPlantilllaSalario(Excel.Worksheet SheetExcel)
        {
            Boolean tamuyBien = false;
            String stLasColumnas = String.Empty;
            String losDatos = String.Empty;
            stLasColumnas = String.Join("", arrayNombreColumnasSalarios).ToUpper().Replace(" ", "");

            Excel.Range unRango;
            unRango = DSC.UltimoCelda(SheetExcel);
            unRango = SheetExcel.get_Range("A2", stColumnaFinalSalarios + "2");
            unRango.Select();
            unRango.Copy();
            System.Threading.Thread.Sleep(2000);
            losDatos = Clipboard.GetText();
            losDatos = losDatos.ToUpper().Replace("\t", "").Replace("\r", "").Replace("\n", "").Replace(" ", "");

            if (DSC.fonetica(losDatos, stLasColumnas))
            {
                tamuyBien = true;
            }

            return tamuyBien;
        }

        /// <summary>
        /// Validaciuon de los datos por celda de los empleados
        /// </summary>
        /// <param name="dtEmpleados"></param>
        /// <param name="dtEmpleadosCFDI"></param>
        private void validarEmpleados(DataTable dtEmpleados, DataTable dtEmpleadosCFDI)
        {
            try
            {
                splashScreenManager3.SetWaitFormCaption("Validando Empleados");
                splashScreenManager3.ShowWaitForm();
            }
            catch (Exception) { }

            int iConta = 1;
            //dtEmpleados.Columns.Add("Turno", typeof(String));
            //dtEmpleados.Columns.Add("Vigencia Contrato", typeof(DateTime));

            int iRow = stFilaInicial;
            foreach (DataRow unRow in dtEmpleados.Rows)
            {
                stLog = DSC.addLog(stLog, "Validando Empleado: " + unRow[6].ToString() + " " + (iConta + 2));
                DSC = new tools.dsc();
                System.Threading.Thread.Sleep(400);
                splashScreenManager3.SetWaitFormDescription(iConta + " de " + dtEmpleados.Rows.Count);

                #region Validacion Tipo Esquema A
                if (unRow[48].ToString() == "A")
                {
                    if (!String.IsNullOrEmpty(unRow[6].ToString()) && !String.IsNullOrEmpty(unRow[7].ToString()))
                    {
                        int iTípoIngreso = 0;
                        Boolean noExisteEmpleado = false;

                        if (String.IsNullOrEmpty(unRow[5].ToString()))
                        {
                            iTípoIngreso = valNSSRFCCURP(unRow[6].ToString(), unRow[7].ToString(), iRow, unRow[0].ToString(), unRow[1].ToString(), unRow[2].ToString(), unRow);
                        }
                        else
                        {
                            //noExisteEmpleado = valNSSRFCCURP(unRow[5].ToString(), unRow[6].ToString(), unRow[7].ToString(), iRow, unRow[0].ToString(), unRow[1].ToString(), unRow[2].ToString());
                            iTípoIngreso = valNSSRFCCURP(unRow[5].ToString(), unRow[6].ToString(), unRow[7].ToString(), iRow, unRow[0].ToString(), unRow[1].ToString(), unRow[2].ToString(), unRow);
                        }

                        // 1 - Nuevo Ingreso, 2 - Reingreso
                        if (iTípoIngreso == 1 || iTípoIngreso == 2)
                        {
                            Boolean flagAutorizarTipoAlta = false;
                            Boolean flagSinSolicitudes = true;

                            flagAutorizarTipoAlta = AutorizarTipoAlta(iTípoIngreso, iRow, unRow);

                            //revisar si el empleado tiene Solicitudes activas
                            if (iTípoIngreso == 2)
                            {
                                int idEmpleado = 0;
                                int.TryParse(unRow["idEmpleado"].ToString(), out idEmpleado);
                                flagSinSolicitudes = RevisarSolicitudesActivasEmpleados(idEmpleado, iRow);
                            }

                            if (flagAutorizarTipoAlta)
                            {
                                if (valEsquema(unRow[48].ToString(), iRow))
                                {
                                    valNombreEmpleado(unRow[0].ToString(), unRow[1].ToString(), unRow[2].ToString(), iRow);
                                    valFechaIngreso(unRow[3].ToString(), iRow);
                                    valSalarioReal(unRow[4].ToString(), iRow, unRow);

                                    //unRow[5] = String.Empty;

                                    valNacionalidad(unRow[8].ToString(), iRow);
                                    valEstadoCivil(unRow[9].ToString(), iRow, unRow[48].ToString(), unRow);

                                    valTipoIndentificacion(unRow[10].ToString(), unRow[11].ToString(), iRow, unRow[48].ToString());
                                    valPuestoReal(unRow[12].ToString(), iRow);

                                    if (String.IsNullOrEmpty(unRow[13].ToString())) { unRow[13] = String.Empty; }
                                    else { valDepartamento(unRow[13].ToString(), iRow); }

                                    if (String.IsNullOrEmpty(unRow[14].ToString())) { unRow[14] = String.Empty; }
                                    else { valHerramientasTrabajo(unRow[14].ToString(), iRow); }

                                    valTipoNomina(unRow[15].ToString(), iRow);

                                    if (String.IsNullOrEmpty(unRow[16].ToString())) { unRow[16] = String.Empty; }
                                    else { valFuncionDesempeñar(unRow[16].ToString(), iRow); }

                                    if (String.IsNullOrEmpty(unRow[17].ToString())) { unRow[17] = String.Empty; }
                                    else { valDiasJornada(unRow[17].ToString(), iRow); }

                                    if (String.IsNullOrEmpty(unRow[18].ToString())) { unRow[18] = String.Empty; unRow["Turno"] = "N/D"; }
                                    else { valHorarioJornada(unRow[18].ToString(), iRow, unRow); }

                                    //Jornada de Servicio
                                    if (String.IsNullOrEmpty(unRow[19].ToString())) { unRow[19] = "N/D"; }
                                    else { valJornadaServicio(unRow[19].ToString(), iRow); }

                                    //Tiempo de Descanso
                                    if (String.IsNullOrEmpty(unRow[20].ToString())) { unRow[20] = String.Empty; }
                                    else { valTiempoDescanso(unRow[20].ToString(), iRow); }

                                    //Tipo de Contrato
                                    if (String.IsNullOrEmpty(unRow[21].ToString())) { unRow[21] = "N/D"; unRow[22] = String.Empty; }
                                    else { valContratacion(unRow[21].ToString(), unRow[22].ToString(), unRow[44].ToString(), iRow, unRow); }

                                    //Concepto de Contratacion
                                    if (String.IsNullOrEmpty(unRow[23].ToString())) { unRow[23] = String.Empty; }
                                    else { valConceptoContratacion(unRow[23].ToString(), iRow); }

                                    valCalleTrabajo(unRow[24].ToString(), iRow);
                                    valNoExteriorCentroTrabajo(unRow[25].ToString(), iRow);
                                    valNoInteriorCentroTrabajo(unRow[26].ToString(), iRow, unRow);
                                    valColoniaCentroTrabajo(unRow[27].ToString(), iRow);
                                    valCPCentroTrabajo(unRow[28].ToString(), unRow[30].ToString(), iRow);
                                    valDelegacionMunicio(unRow[29].ToString(), iRow);

                                    valCalleParticular(unRow[31].ToString(), iRow);
                                    valNoExteriorParticular(unRow[32].ToString(), iRow);
                                    valNoInteriorParticular(unRow[33].ToString(), iRow, unRow);
                                    valColoniaParticular(unRow[34].ToString(), iRow);
                                    valCPParticular(unRow[35].ToString(), unRow[37].ToString(), iRow);
                                    valDelegacionParticular(unRow[36].ToString(), iRow);

                                    valCodigoPostal_DomicilioFiscal(unRow[38].ToString(), iRow, "39", unRow["Esquema"].ToString()); //Codigo Postal Domicilio Fiscal

                                    valCentroCosto(unRow[39].ToString(), iRow, "40"); //Centro de Costo
                                    valCreditoInfonavit(unRow[40].ToString(), iRow, "41"); //No de credito INFONAVIT

                                    //Tipo Pago || CLABE || Esquema
                                    valTipoPago(unRow[41].ToString(), unRow[42].ToString(), unRow[48].ToString(), iRow, unRow);
                                    valPuestoContrato(unRow[43].ToString(), iRow);

                                    //unRow[43] = String.Empty;
                                    DateTime dateContrato = valFechaIngresoContrato(unRow[44].ToString(), iRow); //Fecha de Ingreso Contrato
                                    //DateTime dateContrato = new DateTime(1900, 01, 01);

                                    unRow[44] = dateContrato.ToShortDateString(); //Fecha de Ingreso Contrato

                                    //Salario Diario Contrato || Esquema || Jornada de Servicio
                                    valSalarioDiarioContrato(unRow["Salario Diario Contrato"].ToString(), unRow[48].ToString(), dateContrato, iRow, unRow[19].ToString(), unRow);

                                    //Salario Diario Integrado || Esquema || Salario Diario Contrato
                                    valSalarioDiarioIntegrado(unRow[46].ToString(), unRow[48].ToString(), dateContrato, unRow[45].ToString(), iRow, unRow[19].ToString());
                                    valCorreoElectronico(unRow[47].ToString(), iRow);//Correo Electronico
                                    valInformacionConfidencial(unRow[49].ToString(), iRow); //Informacion Confidencial
                                    valTipoIngresoEmpleado(iTípoIngreso, unRow);

                                    valClaves(unRow["Claves"].ToString(), iRow);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(unRow["NSS"].ToString()))
                        {
                            addErrores("6", iRow.ToString(), "NSS: No puede estar Vacio.", 1);
                        }
                        if (String.IsNullOrEmpty(unRow["RFC"].ToString()))
                        {
                            addErrores("7", iRow.ToString(), "RFC: No puede estar Vacio.", 1);
                        }
                        if (String.IsNullOrEmpty(unRow["CURP"].ToString()))
                        {
                            addErrores("8", iRow.ToString(), "CURP: No puede estar Vacio.", 1);
                        }
                    }
                }
                #endregion
                else
                {
                    if (!String.IsNullOrEmpty(unRow[5].ToString()) && !String.IsNullOrEmpty(unRow[6].ToString()) && !String.IsNullOrEmpty(unRow[7].ToString()))
                    {
                        //Boolean noExisteEmpleado = false;
                        //noExisteEmpleado = valNSSRFCCURP(unRow[5].ToString(), unRow[6].ToString(), unRow[7].ToString(), iRow, unRow[0].ToString(), unRow[1].ToString(), unRow[2].ToString(), unRow);

                        int iTípoIngreso = 0;
                        iTípoIngreso = valNSSRFCCURP(unRow[5].ToString(), unRow[6].ToString(), unRow[7].ToString(), iRow, unRow[0].ToString(), unRow[1].ToString(), unRow[2].ToString(), unRow);

                        if (iTípoIngreso == 1 || iTípoIngreso == 2)
                        {
                            Boolean flagAutorizarTipoAlta = false;
                            Boolean flagSinSolicitudes = true;
                            flagAutorizarTipoAlta = AutorizarTipoAlta(iTípoIngreso, iRow, unRow);

                            if (flagAutorizarTipoAlta)
                            {
                                //revisar si el empleado tiene Solicitudes activas
                                if (iTípoIngreso == 2)
                                {
                                    int idEmpleado = 0;
                                    int.TryParse(unRow["idEmpleado"].ToString(), out idEmpleado);
                                    flagSinSolicitudes = RevisarSolicitudesActivasEmpleados(idEmpleado, iRow);
                                }

                                if (flagSinSolicitudes)
                                {
                                    if (valEsquema(unRow[48].ToString(), iRow))
                                    {
                                        valNombreEmpleado(unRow[0].ToString(), unRow[1].ToString(), unRow[2].ToString(), iRow);
                                        valFechaIngreso(unRow[3].ToString(), iRow);

                                        valSalarioReal(unRow[4].ToString(), iRow, unRow);

                                        valNacionalidad(unRow[8].ToString(), iRow);
                                        valEstadoCivil(unRow[9].ToString(), iRow, unRow[48].ToString(), unRow);

                                        //Validar Tipo Indentificacion y Numero de Identificacion
                                        valTipoIndentificacion(unRow[10].ToString(), unRow[11].ToString(), iRow, unRow[48].ToString());

                                        valPuestoReal(unRow[12].ToString(), iRow);
                                        valDepartamento(unRow[13].ToString(), iRow);
                                        valHerramientasTrabajo(unRow[14].ToString(), iRow);
                                        valTipoNomina(unRow[15].ToString(), iRow);
                                        valFuncionDesempeñar(unRow[16].ToString(), iRow);

                                        valDiasJornada(unRow[17].ToString(), iRow);
                                        //Calcula HOrario de Jornada y Turno
                                        valHorarioJornada(unRow[18].ToString(), iRow, unRow);
                                        valJornadaServicio(unRow[19].ToString(), iRow);
                                        valTiempoDescanso(unRow[20].ToString(), iRow);
                                        //Validacion de tipo de contrato, fecha de contrato y tiempo de contrato
                                        valContratacion(unRow[21].ToString(), unRow[22].ToString(), unRow[44].ToString(), iRow, unRow);
                                        valConceptoContratacion(unRow[23].ToString(), iRow);

                                        valCalleTrabajo(unRow[24].ToString(), iRow);
                                        valNoExteriorCentroTrabajo(unRow[25].ToString(), iRow);
                                        valNoInteriorCentroTrabajo(unRow[26].ToString(), iRow, unRow);
                                        valColoniaCentroTrabajo(unRow[27].ToString(), iRow);
                                        valCPCentroTrabajo(unRow[28].ToString(), unRow[30].ToString(), iRow);
                                        valDelegacionMunicio(unRow[29].ToString(), iRow);

                                        valCalleParticular(unRow[31].ToString(), iRow);
                                        valNoExteriorParticular(unRow[32].ToString(), iRow);
                                        valNoInteriorParticular(unRow[33].ToString(), iRow, unRow);
                                        valColoniaParticular(unRow[34].ToString(), iRow);
                                        valCPParticular(unRow[35].ToString(), unRow[37].ToString(), iRow);
                                        valDelegacionParticular(unRow[36].ToString(), iRow);

                                        valCodigoPostal_DomicilioFiscal(unRow[38].ToString(), iRow, "39", unRow["Esquema"].ToString()); //Codigo Postal Domicilio Fiscal
                                        valCentroCosto(unRow[39].ToString(), iRow, "40");

                                        valCreditoInfonavit(unRow[40].ToString(), iRow, "41");

                                        valTipoPago(unRow[41].ToString(), unRow[42].ToString(), unRow[48].ToString(), iRow, unRow);
                                        valPuestoContrato(unRow[43].ToString(), iRow);
                                        DateTime dateContrato = valFechaIngresoContrato(unRow[44].ToString(), iRow);

                                        //valFechaIncioContratoVigente(unRow[44].ToString(), iRow);

                                        valSalarioDiarioContrato(unRow["Salario Diario Contrato"].ToString(), unRow[48].ToString(), dateContrato, iRow, unRow[19].ToString(), unRow);
                                        valSalarioDiarioIntegrado(unRow[46].ToString(), unRow[48].ToString(), dateContrato, unRow[45].ToString(), iRow, unRow[19].ToString());

                                        valCorreoElectronico(unRow[47].ToString(), iRow);
                                        valInformacionConfidencial(unRow[49].ToString(), iRow);

                                        valTipoIngresoEmpleado(iTípoIngreso, unRow);

                                        valClaves(unRow["Claves"].ToString(), iRow);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(unRow["NSS"].ToString()))
                        {
                            addErrores("6", iRow.ToString(), "NSS: No puede estar Vacio.", 1);
                        }
                        if (String.IsNullOrEmpty(unRow["RFC"].ToString()))
                        {
                            addErrores("7", iRow.ToString(), "RFC: No puede estar Vacio.", 1);
                        }
                        if (String.IsNullOrEmpty(unRow["CURP"].ToString()))
                        {
                            addErrores("8", iRow.ToString(), "CURP: No puede estar Vacio.", 1);
                        }
                    }
                }

                iRow++;
                iConta++;
                //dtEmpleadosCFDI.ImportRow(unRow);
            }
        }



        private void validarEmpleadosSalarios(DataTable dtEmpleados, DataTable dtEmpleadosCFDI)
        {
            int iFila = stFilaInicial;
            int iConta = 0;
            splashScreenManager3.SetWaitFormCaption("Validando");

            foreach (DataRow unRow in dtEmpleados.Rows)
            {
                SolicitudSalarios oSolicitudSalarios = new SolicitudSalarios(unRow, true);

                if (oSolicitudSalarios.IdEmpleado > 0)
                {
                    String DescError = String.Empty;

                    decimal? dcVacacionesEmpleado = 0;
                    decimal? dcPrimaVacacional = 0;
                    decimal? dcAguinaldo = 0;
                    decimal? dcSalarioDiarioContrato_Empleado = 0;
                    int? iAniosLaborados_Empleado = 0;
                    decimal? dcUMA = 0;
                    String sRespuesta = String.Empty;

                    iConta++;
                    splashScreenManager3.SetWaitFormDescription(iConta + " de " + dtEmpleados.Rows.Count);

                    stpSelObtenerInfoEmpleadoParaSolicitudDeSalariosTableAdapter1.Fill(dsOperaciones1.stpSelObtenerInfoEmpleadoParaSolicitudDeSalarios,
                        true
                      , oSolicitudSalarios.IdEmpleado
                      , oSolicitudSalarios.NSS
                      , oSolicitudSalarios.RFC
                      , oSolicitudSalarios.CURP
                      , oSolicitudSalarios.stFechaDeAplicacion
                      , ref dcVacacionesEmpleado
                      , ref dcPrimaVacacional
                      , ref dcAguinaldo
                      , ref dcSalarioDiarioContrato_Empleado
                      , ref iAniosLaborados_Empleado
                      , ref dcUMA
                      , ref sRespuesta);

                    if (String.IsNullOrEmpty(sRespuesta))
                    {
                        oSolicitudSalarios.Vacaciones = (decimal)dcVacacionesEmpleado;
                        oSolicitudSalarios.PrimaVacacional = (decimal)dcPrimaVacacional;
                        oSolicitudSalarios.Aguinaldo = (decimal)dcAguinaldo;
                        oSolicitudSalarios.SDCEmpleado = (decimal)dcSalarioDiarioContrato_Empleado;
                        oSolicitudSalarios.AniosLaboradosEmpleado = iAniosLaborados_Empleado;
                        oSolicitudSalarios.UMA = (decimal)dcUMA;

                        XtrasSolicitudSalariosEmpleado oXtrasSolicitudSalariosEmpleado = new XtrasSolicitudSalariosEmpleado(false, 0, new Empleado(), 0, 0, new DateTime());

                        //Obtener Fechas para la solicitud
                        DateTime dtUltimaFechaPasada = new DateTime();
                        DateTime dtUltimaFechaFutura = new DateTime();
                        String sValidacionSalarios = String.Empty;

                        dtUltimaFechaPasada = oXtrasSolicitudSalariosEmpleado.obtenerFechaAplicacionPasada(oSolicitudSalarios.SDCEmpleado, oSolicitudSalarios.SalarioDiarioContrato);
                        dtUltimaFechaFutura = oXtrasSolicitudSalariosEmpleado.obtenerFechaAplicacionFutura();

                        //Validacion de Salario
                        sValidacionSalarios = oXtrasSolicitudSalariosEmpleado.validarSalarios(oSolicitudSalarios.IdEmpleado, oSolicitudSalarios.SalarioDiarioContrato, oSolicitudSalarios.stFechaDeAplicacion);
                        if (String.IsNullOrEmpty(sValidacionSalarios))
                        {
                            //Obtener Factor de Integracion
                            oSolicitudSalarios.FactorDeIntegracion = oXtrasSolicitudSalariosEmpleado.obtenerFactorDeIntegracion(oSolicitudSalarios.Vacaciones, oSolicitudSalarios.PrimaVacacional, oSolicitudSalarios.Aguinaldo);

                            //Obtener Salario base de cotizacaion y salarios diario integrado
                            oSolicitudSalarios.SalarioBaseDeCotizacion = oXtrasSolicitudSalariosEmpleado.obtenerSBCSDI(oSolicitudSalarios.SalarioDiarioContrato, oSolicitudSalarios.FactorDeIntegracion, oSolicitudSalarios.UMA, oSolicitudSalarios.ParteVariable);
                            oSolicitudSalarios.SalarioDiarioIntegrado = oSolicitudSalarios.SalarioBaseDeCotizacion;

                            String sValidacionDeFechas = String.Empty;
                            sValidacionDeFechas = oXtrasSolicitudSalariosEmpleado.validarFechaDeAplicacion(oSolicitudSalarios.stFechaDeAplicacion, dtUltimaFechaPasada, dtUltimaFechaFutura);

                            if (String.IsNullOrEmpty(sValidacionDeFechas))
                            {
                                //validacion de parte variable
                                variableIMSSEmpleado ovariableIMSSEmpleado = new variableIMSSEmpleado(oSolicitudSalarios.IdEmpleado, oSolicitudSalarios.stFechaDeAplicacion);

                                if (ovariableIMSSEmpleado.flagTaMuyBien)
                                {
                                    SheetExcelEmpleados.get_Range("J" + iFila.ToString()).Value = ovariableIMSSEmpleado.ParteVariable.ToString("N2");
                                    unRow["Parte Variable"] = ovariableIMSSEmpleado.ParteVariable.ToString("N2");

                                    decimal dcSBCParteVariable = 0;
                                    decimal dcSDIParteVariable = 0;
                                    dcSBCParteVariable = oSolicitudSalarios.SalarioBaseDeCotizacion + ovariableIMSSEmpleado.ParteVariable;
                                    dcSDIParteVariable = oSolicitudSalarios.SalarioDiarioIntegrado + ovariableIMSSEmpleado.ParteVariable;

                                    SheetExcelEmpleados.get_Range("K" + iFila.ToString()).Value = dcSBCParteVariable.ToString("N2");
                                    unRow["Salario Base de Cotizacion"] = dcSBCParteVariable.ToString("N2");

                                    SheetExcelEmpleados.get_Range("L" + iFila.ToString()).Value = dcSDIParteVariable.ToString("N2");
                                    unRow["Salario Diario Integrado"] = dcSDIParteVariable.ToString("N2");

                                    SheetExcelEmpleados.get_Range("M" + iFila.ToString()).Value = oSolicitudSalarios.Vacaciones.ToString("N2");
                                    unRow["Vacaciones"] = oSolicitudSalarios.Vacaciones.ToString("N2");

                                    SheetExcelEmpleados.get_Range("N" + iFila.ToString()).Value = oSolicitudSalarios.PrimaVacacional.ToString("N2");
                                    unRow["Prima Vacacional"] = oSolicitudSalarios.PrimaVacacional.ToString("N2");

                                    SheetExcelEmpleados.get_Range("O" + iFila.ToString()).Value = oSolicitudSalarios.Aguinaldo.ToString("N2");
                                    unRow["Aguinaldo"] = oSolicitudSalarios.Aguinaldo.ToString("N2");

                                    SheetExcelEmpleados.get_Range("P" + iFila.ToString()).Value = oSolicitudSalarios.AniosLaboradosEmpleado.ToString();
                                    unRow["Años Laborados"] = oSolicitudSalarios.AniosLaboradosEmpleado.ToString();

                                    SheetExcelEmpleados.get_Range("Q" + iFila.ToString()).Value = oSolicitudSalarios.FactorDeIntegracion.ToString("N4");
                                    unRow["Factor de Integracion"] = oSolicitudSalarios.FactorDeIntegracion.ToString("N4");

                                    SheetExcelEmpleados.get_Range("R" + iFila.ToString()).Value = oSolicitudSalarios.UMA.ToString("N2");
                                    unRow["UMA"] = oSolicitudSalarios.UMA.ToString("N4");

                                    SheetExcelEmpleados.get_Range("S" + iFila.ToString()).Value = oSolicitudSalarios.SDCEmpleado.ToString("N2");
                                    unRow["Salario Diario Actual"] = oSolicitudSalarios.SDCEmpleado.ToString("N2");
                                }
                                else
                                {
                                    addErrores("10", iFila.ToString(), ovariableIMSSEmpleado.sMensajeDeError, 1);
                                }
                            }
                            else
                            {
                                addErrores("9", iFila.ToString(), sValidacionDeFechas, 1);
                            }
                        }
                        else
                        {
                            addErrores("8", iFila.ToString(), sValidacionSalarios, 1);
                        }
                    }
                    else
                    {
                        addErrores("1", iFila.ToString(), sRespuesta, 1);
                    }
                }

                iFila++;
            }
        }


        /// <summary>
        /// Validar si un empleado esta mas de dos veces repetido en la plantilla.
        /// </summary>
        /// <param name="dtEmpleados"></param>
        private void validarEmpleadosRepetidos(DataTable dtEmpleados, int iTipoSolicitud)
        {
            int iRow = stFilaInicial;
            String stNSS = String.Empty;
            String stRFC = String.Empty;
            String stCURP = String.Empty;


            foreach (DataRow unRow in dtEmpleados.Rows)
            {
                if (iTipoSolicitud == 1) // Para Altas
                {
                    stNSS = unRow[5].ToString();
                    stRFC = unRow[6].ToString();
                    stCURP = unRow[7].ToString();
                }
                else if (iTipoSolicitud == 4) // Para Salarios
                {
                    stNSS = unRow[4].ToString();
                    stRFC = unRow[5].ToString();
                    stCURP = unRow[6].ToString();
                }

                if (!String.IsNullOrEmpty(stRFC) && !String.IsNullOrEmpty(stCURP))
                {
                    if (!String.IsNullOrEmpty(stNSS))
                    {
                        DataRow[] unDataRowNSS = dtEmpleados.Select("NSS = '" + stNSS + "'");
                        if (unDataRowNSS.Count() > 1)
                        {
                            addErrores("6", iRow.ToString(), "NSS: Esta Repetido en la plantilla.", 4);
                        }

                    }

                    DataRow[] unDataRowRFC = dtEmpleados.Select("RFC = '" + stRFC + "'");
                    DataRow[] unDataRowCURP = dtEmpleados.Select("CURP = '" + stCURP + "'");

                    if (unDataRowRFC.Count() > 1)
                    {
                        addErrores("7", iRow.ToString(), "RFC: Esta Repetido en la plantilla.", 4);
                    }
                    else if (unDataRowCURP.Count() > 1)
                    {
                        addErrores("8", iRow.ToString(), "CURP: Esta Repetido en la plantilla.", 4);
                    }
                }
                iRow++;
            }
        }

        private DataTable quitarBlancos(DataTable dtEmpleados)
        {
            var miquery = (from x in dtEmpleados.AsEnumerable()
                           where
                           //x.Field<String>("Apellido Paterno") != String.Empty &&
                           //x.Field<String>("Apellido Materno") != String.Empty &&
                           x.Field<String>("Nombres") != String.Empty &&

                           //x.Field<String>("NSS") != String.Empty &&
                           x.Field<String>("RFC") != String.Empty &&
                           x.Field<String>("CURP") != String.Empty
                           select x);

            if (miquery.Count() > 0)
            {
                dtEmpleados = miquery.CopyToDataTable();
            }
            else
            {
                dtEmpleados = dtEmpleados.Clone();
            }

            return dtEmpleados;
        }

        private Excel.Worksheet abrirArchivo()
        {
            String nombreArchivo = String.Empty;
            String nombreHoja = String.Empty;
            Excel.Workbooks booksExcel;
            Excel.Workbook bookExcel;
            Excel.Worksheet SheetExcel = null;

            if (bookExcelAlta == null)
            {
                String stArchivoSeleccionado = String.Empty;

                OpenFileDialog ofdSelecFile = new OpenFileDialog();
                ofdSelecFile.Filter = "Excel Files (*.xls;*.xlsm;*.xlsb;*.xlsx)|*.xls;*.xlsm;*.xlsb;*.xlsx";
                ofdSelecFile.ShowDialog();
                stArchivoSeleccionado = ofdSelecFile.FileName;
                stRutaDocumentosExcel = ofdSelecFile.FileName;

                if (!String.IsNullOrEmpty(stArchivoSeleccionado))
                {
                    appExcel = new Excel.Application();
                    booksExcel = appExcel.Workbooks;

                    appExcel.Visible = true;
                    appExcel.DisplayAlerts = false;
                    bookExcel = booksExcel.Open(stArchivoSeleccionado);
                    nombreArchivo = stArchivoSeleccionado;
                    lblTipoPlantilla.Text = Path.GetFileNameWithoutExtension(nombreArchivo);
                }
                else
                {
                    appExcel = null;
                    bookExcel = null;
                }
            }
            else
            {
                appExcel = appExcelAltaArchivo;
                bookExcel = bookExcelAlta;
            }

            if (appExcel != null && bookExcel != null)
            {
                if (bookExcel.Worksheets.Count > 1)
                {
                    List<String> lsHojasExcel = new List<String>();
                    foreach (Excel.Worksheet hojas in bookExcel.Sheets)
                    {
                        lsHojasExcel.Add(hojas.Name.ToString());
                    }

                    using (var form = new tools.xtFormSelectItem("Seleccione la Hoja", lsHojasExcel))
                    {
                        var result = form.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            nombreHoja = form.stValorSeleccioando;
                            ((Excel.Worksheet)appExcel.Sheets[nombreHoja]).Select();
                        }
                    }
                }
                else
                {
                    SheetExcel = (Excel.Worksheet)bookExcel.ActiveSheet;
                    nombreHoja = SheetExcel.Name;
                }

                SheetExcel = (Excel.Worksheet)bookExcel.ActiveSheet;
            }

            return SheetExcel;
        }

        /// <summary>
        /// Obtener los datos de Excel a un datatable
        /// </summary>
        /// <param name="SheetExcel"></param>
        /// <returns></returns>
        private DataTable obtenerDatosHoja(Excel.Worksheet SheetExcel)
        {
            Excel.Range unRango;
            unRango = DSC.UltimoCelda(SheetExcel);
            String ultimaCelda = unRango.get_AddressLocal(false, false, Excel.XlReferenceStyle.xlA1, false, false);

            unRango = SheetExcel.get_Range(stColumnaObservacionesSAIC + "3", stColumnaObservacionesSAIC + DSC.soloNumeros(ultimaCelda));
            unRango.Select();
            unRango.Clear();

            unRango = SheetExcel.get_Range("A" + stFilaInicial, stColumnaFinal + DSC.soloNumeros(ultimaCelda));
            unRango.Select();
            unRango.Copy();
            System.Threading.Thread.Sleep(2000);
            String losDatos = Clipboard.GetText();
            losDatos = losDatos.ToUpper();

            //DataTable dtEmpleados_1 = DSC.ConvertToDataTable(losDatos);
            DataTable dtEmpleados_1 = DSC.ConvertToDataTable(losDatos, 50);
            dtEmpleados_1 = ingresarNombreColumnas(dtEmpleados_1);
            return dtEmpleados_1;
        }

        /// <summary>
        /// Filtrando los datos de los empleados para eliminar vacios
        /// </summary>
        /// <param name="dtEmpleados">DataTable con la informacion de los empleados.</param>
        /// <returns>DataTable con la informacion filtrada</returns>
        private DataTable filtarDataTable(DataTable dtEmpleados)
        {
            var query = from x in dtEmpleados.AsEnumerable()
                        where !x.Field<String>("Apellido Paterno").Equals("") &&
                        !x.Field<String>("Apellido Materno").Equals("") &&
                        !x.Field<String>("Nombres").Equals("")
                        select x;

            return dtEmpleados = query.CopyToDataTable();
        }

        /// <summary>
        /// Validar la informacion de los empleados con la Base de Datos para saber si existen
        /// </summary>
        /// <param name="dtEmpleados">Tabla de empleados a Subir a la Base de Datos</param>
        private void validarEmpleadosVsBase(DataTable dtEmpleados)
        {
            int ifilaInicial = stFilaInicial;
            //Validar la Informacion antes de insertarla en la Tabla
            foreach (DataRow unRow in dtEmpleados.Rows)
            {
                String stError = String.Empty;

                //stpUpdAutorizacionNominaTableAdapter1.stpValidacionEmpleados(
                //unRow["Apellido Paterno"].ToString(),
                //unRow["Apellido Materno"].ToString(),
                //unRow["Nombres"].ToString(),
                //unRow["NSS"].ToString(),
                //unRow["RFC"].ToString(),
                //unRow["CURP"].ToString(),
                //ref stError);
                //unRow["Errores"] = stError;

                //if (stError != "")
                //{
                //    agregarErrores(ifilaInicial + ",57", stError);
                //}

                ifilaInicial++;
            }
        }

        private int LoteCargaEmpleados(int iTenedora)
        {
            int? obtenerLoteEmpleados = 0;
            int iLoteEmpleados = 0;
            String stFolio = "S-" + OperadorBD.OperadorGlobal.IdOperador + "-" + DSC.nombreAleatorio();
            //stpUpdAutorizacionNominaTableAdapter1.stpObtenerLoteEmpleados(OperadorBD.OperadorGlobal.IdOperador, iTenedora, OperadorBD.OperadorGlobal.NombreUsuario, stFolio, ref obtenerLoteEmpleados);
            Int32.TryParse(obtenerLoteEmpleados.ToString(), out iLoteEmpleados);
            return iLoteEmpleados;
        }

        private void insertandoEmpleados(DataTable dtTodosEmpleados)
        {
            try
            {
                System.Threading.Thread.Sleep(500);
                splashScreenManager3.SetWaitFormCaption("Guardando Solicitud");
                int? iSolicitud = 0;
                int iContaEmpleados = 0;
                String stNSSEmpleado = String.Empty;
                List<String> listEmpleadosIngresados = new List<string>();

                String rutaCarpetaSolicitud = sRuta_Ope_Altas;
                //String rutaCarpetaEmpleados = DSC.stRutaSAIC;

                queriesTableAdapter1.stpInsSolicitudAltaEmpleadosHeader(
                        Convert.ToInt32(gridLookTenedoraSA.EditValue),
                        Convert.ToInt32(gridLookTenedoraSC.EditValue),
                        Convert.ToInt32(gridLookCliente.EditValue),
                        OperadorBD.OperadorGlobal.IdOperador,
                        OperadorBD.OperadorGlobal.NombreUsuario,
                        1, //Tipo de Alta 1 = ALTA
                        ref iSolicitud
                       );

                if (iSolicitud != 0 && iSolicitud != 99)
                {
                    idmiSolciitud = iSolicitud;
                    int iConta = 1;
                    rutaCarpetaSolicitud += iSolicitud;
                    DSC.CheckandCreateFolder(rutaCarpetaSolicitud);

                    foreach (DataRow empleado in dtTodosEmpleados.Rows)
                    {
                        System.Threading.Thread.Sleep(500);
                        splashScreenManager3.SetWaitFormDescription("Solicitud " + iSolicitud + " Insertando Empleados: " + iConta + " de " + dtTodosEmpleados.Rows.Count);

                        if (empleado["Tipo de Ingreso"].ToString() == "ALTA")
                        {
                            stNSSEmpleado = insertarEmpleados_1(empleado, idmiSolciitud);
                        }
                        else if (empleado["Tipo de Ingreso"].ToString() == "REINGRESO")
                        {
                            stNSSEmpleado = actualizarEmpleados(empleado, idmiSolciitud);
                        }

                        listEmpleadosIngresados.Add(stNSSEmpleado);
                        iContaEmpleados++;
                        iConta++;
                    }

                    String stDatos = DSC.ConvertDataTableToString(dtTodosEmpleados, true);
                    DSC.CheckandCreateFolder(sRuta_Ope_Altas + iSolicitud + @"\");
                    File.WriteAllText(sRuta_Ope_Altas + @"\" + iSolicitud + @"\" + iSolicitud + ".txt", stDatos);

                    System.Threading.Thread.Sleep(500);
                    splashScreenManager3.SetWaitFormDescription("Solicitud Generada");

                    //Copiando el archivo de alta a la carpeta de Solicitud
                    if (File.Exists(stRutaDocumentosExcel))
                    {
                        FileInfo unFile = new FileInfo(stRutaDocumentosExcel);
                        DSC.CheckandCreateFolder(sRuta_Ope_Altas + iSolicitud + @"\");
                        unFile.CopyTo(sRuta_Ope_Altas + iSolicitud + @"\Solcitud " + iSolicitud + " " + DSC.nombreAleatorio() + unFile.Extension);
                    }

                    if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                    XtraMessageBox.Show(Environment.NewLine + "Solicitud Generada con Exito" + Environment.NewLine + Environment.NewLine +
                        "Numero de Solicitud: " + iSolicitud + Environment.NewLine +
                        "Empleados Ingresados:" + iContaEmpleados + Environment.NewLine +
                        "Carpeta para Documentación: " + Environment.NewLine + sRuta_Ope_Altas
                    , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnAbrirCarpeta.Enabled = true;
                    //Actualizar grid con empleados no subidos
                    actulizarEmpleado(listEmpleadosIngresados, dtTodosEmpleados);

                    sRutaCarpeta = sRuta_Ope_Altas + iSolicitud + @"\";
                }
                else
                {
                    if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                    XtraMessageBox.Show("No se puede generar Numero de Solicitud" + Environment.NewLine + "Exp-" + iSolicitud
                     , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                XtraMessageBox.Show("No se subir a los empleados:" + Environment.NewLine + ex
                    , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private String actualizarEmpleados(DataRow empleado, int? iSolicitud)
        {

            int? numEmpleado = 0;
            int? numSolicitud = 0;
            int? existeEmpleado = 0;
            short? codigoError_1 = 0;
            String stDesError = String.Empty;

            String stError = String.Empty;

            DateTime dtimeVigenciaContrato;
            DateTime.TryParse(empleado["Vigencia Contrato"].ToString(), out dtimeVigenciaContrato);
            dtimeVigenciaContrato = dtimeVigenciaContrato.ToShortDateString().Contains("01/01/0001") ? dtimeVigenciaContrato = new DateTime(1900, 01, 01) : dtimeVigenciaContrato;

            queriesTableAdapter1.stpUpdEmpleados(
                iSolicitud,
                Convert.ToInt32(empleado["idEmpleado"]),
                Convert.ToDateTime(empleado["Fecha de Ingreso Cliente"].ToString()),
                Convert.ToDecimal(empleado["Salario Diario Cliente"].ToString()),
                DSC.ObtenerIDofTable(dbSAICBPOCatalogosDataSet1.stpSelNacionalidad, empleado["Nacionalidad"].ToString()),
                DSC.ObtenerIDofTable(dbSAICBPOCatalogosDataSet1.stpSelEstadoCivil, empleado["Estado Civil"].ToString()),
                DSC.ObtenerIDofTable(dbSAICBPOCatalogosDataSet1.stpSelTurno, empleado["Turno"].ToString()),

                //Contrato
                DSC.ObtenerIDofTable(dbSAICBPOCatalogosDataSet1.stpSelTipoIdentificacion, empleado["Tipo Identificacion"].ToString()),
                empleado["Numero de Identificacion"].ToString(),
                dcVacaciones,
                dcPrimaVacacional,
                dcAguinaldo,
                empleado["Concepto Contratacion"].ToString(),
                empleado["Herramientas de Trabajo"].ToString(),
                empleado["Funciones a Desempeñar"].ToString(),
                empleado["Informacion Confidencial"].ToString(),
                //Contrato

                empleado["Puesto Real"].ToString(),
                empleado["Departamento o Area Real"].ToString(), //Departamento
                DSC.ObtenerIDofTable(dbSAICBPOCatalogosDataSet1.stpSelTipoPeriodoNomina, empleado["Tipo de Nomina"].ToString()), //Tipo periodo
                empleado["Dias de Jornada"].ToString(), //DesJornada
                empleado["Horario Jornada"].ToString(), //Horario jornada
                DSC.ObtenerIDofTable(dbSAICBPOCatalogosDataSet1.stpSelJornadaServicio, empleado["Jornada de Servicio"].ToString()),//IdJornadaServicio
                empleado["Tiempo de comida o descanso"].ToString(), //Tiempo descanso comida
                DSC.ObtenerIDofTable(dbSAICBPOCatalogosDataSet1.stpSelTipoContrato, empleado["Tipo de contrato"].ToString()), //TipoContrato
                empleado["Tiempo de contrato"].ToString(), //TiempoContrato

                //Domicilio
                empleado["Calle Centro de Trabajo"].ToString(),
                empleado["No Exterior Centro de Trabajo"].ToString(),
                empleado["No Interior Centro de Trabajo"].ToString(),
                empleado["Colonia Centro de Trabajo"].ToString(),
                empleado["Codigo Postal Centro de Trabajo"].ToString(),
                empleado["Delegacion o Municipio Centro de Trabajo"].ToString(),
                empleado["Estado Centro Trabajo"].ToString(),

                empleado["Calle Domicilio Empleado"].ToString(),
                empleado["No Exterior Domicilio Empleado"].ToString(),
                empleado["No Interior Domicilio Empleado"].ToString(),
                empleado["Colonia Domicilio Empleado"].ToString(),
                empleado["Codigo Postal Domicilio Empleado"].ToString(),
                empleado["Delegacion o Municipio Domicilio Empleado"].ToString(),
                empleado["Estado Centro Empleado"].ToString(),
                //Domicilio

                empleado["Centro de Costo"].ToString(),
                empleado["No de credito INFONAVIT"].ToString(),
                DSC.ObtenerIDofTable(dbSAICBPOCatalogosDataSet1.stpSelFormaPago, empleado["Tipo Pago"].ToString(), 1),
                empleado["CLABE"].ToString(),

                empleado["Puesto Contrato"].ToString(),
                Convert.ToDateTime(empleado["Fecha de Ingreso Contrato"].ToString()),
                Convert.ToDecimal(empleado["Salario Diario Contrato"].ToString()),
                Convert.ToDecimal(empleado["Salario Diario Integrado"].ToString()),
                empleado["Correo Electronico"].ToString(),
                empleado["Esquema"].ToString(),

                dtimeVigenciaContrato,

                gridLookCliente.Text,
                gridLookTenedoraSA.Text,
                gridLookTenedoraSC.Text.Trim(),

                Convert.ToInt32(gridLookTenedoraSA.EditValue),
                OperadorBD.OperadorGlobal.IdOperador,
                empleado["Codigo Postal Domicilio Fiscal"].ToString(),
                empleado["Claves"].ToString().ToUpper()
                );

            return empleado["NSS"].ToString();
        }

        private String insertarEmpleados_1(DataRow empleado, int? iSolicitud)
        {
            int? numEmpleado = 0;
            int? numSolicitud = 0;
            int? existeEmpleado = 0;
            short? codigoError_1 = 0;
            String stDesError = String.Empty;

            String stError = String.Empty;

            DateTime dtimeVigenciaContrato;
            DateTime.TryParse(empleado["Vigencia Contrato"].ToString(), out dtimeVigenciaContrato);
            dtimeVigenciaContrato = dtimeVigenciaContrato.ToShortDateString().Contains("01/01/0001") ? dtimeVigenciaContrato = new DateTime(1900, 01, 01) : dtimeVigenciaContrato;
            queriesTableAdapter1.stpInsAltaEmpleados(
                iSolicitud,
                empleado["Apellido Paterno"].ToString().Trim(),
                empleado["Apellido Materno"].ToString().Trim(),
                empleado["Nombres"].ToString().Trim(),
                Convert.ToDateTime(empleado["Fecha de Ingreso Cliente"].ToString()),
                Convert.ToDecimal(empleado["Salario Diario Cliente"].ToString()),
                empleado["NSS"].ToString(),
                empleado["RFC"].ToString(),
                empleado["CURP"].ToString(),
                DSC.ObtenerIDofTable(dbSAICBPOCatalogosDataSet1.stpSelNacionalidad, empleado["Nacionalidad"].ToString()),
                DSC.ObtenerIDofTable(dbSAICBPOCatalogosDataSet1.stpSelEstadoCivil, empleado["Estado Civil"].ToString()),

               DSC.ObtenerIDofTable(dbSAICBPOCatalogosDataSet1.stpSelTurno, empleado["Turno"].ToString()),

                //Contrato
                DSC.ObtenerIDofTable(dbSAICBPOCatalogosDataSet1.stpSelTipoIdentificacion, empleado["Tipo Identificacion"].ToString()),
                empleado["Numero de Identificacion"].ToString(),
                dcVacaciones,
                dcPrimaVacacional,
                dcAguinaldo,
                empleado["Concepto Contratacion"].ToString(),
                empleado["Herramientas de Trabajo"].ToString(),
                empleado["Funciones a Desempeñar"].ToString(),
                empleado["Informacion Confidencial"].ToString(),
                //Contrato

                empleado["Puesto Real"].ToString(),
                empleado["Departamento o Area Real"].ToString(), //Departamento
                DSC.ObtenerIDofTable(dbSAICBPOCatalogosDataSet1.stpSelTipoPeriodoNomina, empleado["Tipo de Nomina"].ToString()), //Tipo periodo
                empleado["Dias de Jornada"].ToString(), //DesJornada
                empleado["Horario Jornada"].ToString(), //Horario jornada
                DSC.ObtenerIDofTable(dbSAICBPOCatalogosDataSet1.stpSelJornadaServicio, empleado["Jornada de Servicio"].ToString()),//IdJornadaServicio
                empleado["Tiempo de comida o descanso"].ToString(), //Tiempo descanso comida
                DSC.ObtenerIDofTable(dbSAICBPOCatalogosDataSet1.stpSelTipoContrato, empleado["Tipo de contrato"].ToString()), //TipoContrato
                empleado["Tiempo de contrato"].ToString(), //TiempoContrato

                //Domicilio
                empleado["Calle Centro de Trabajo"].ToString(),
                empleado["No Exterior Centro de Trabajo"].ToString(),
                empleado["No Interior Centro de Trabajo"].ToString(),
                empleado["Colonia Centro de Trabajo"].ToString(),
                empleado["Codigo Postal Centro de Trabajo"].ToString(),
                empleado["Delegacion o Municipio Centro de Trabajo"].ToString(),
                empleado["Estado Centro Trabajo"].ToString(),

                empleado["Calle Domicilio Empleado"].ToString(),
                empleado["No Exterior Domicilio Empleado"].ToString(),
                empleado["No Interior Domicilio Empleado"].ToString(),
                empleado["Colonia Domicilio Empleado"].ToString(),
                empleado["Codigo Postal Domicilio Empleado"].ToString(),
                empleado["Delegacion o Municipio Domicilio Empleado"].ToString(),
                empleado["Estado Centro Empleado"].ToString(),
                //Domicilio

                empleado["Centro de Costo"].ToString(),
                empleado["No de credito INFONAVIT"].ToString(),
                DSC.ObtenerIDofTable(dbSAICBPOCatalogosDataSet1.stpSelFormaPago, empleado["Tipo Pago"].ToString(), 1),
                empleado["CLABE"].ToString(),

                empleado["Puesto Contrato"].ToString(),
                Convert.ToDateTime(empleado["Fecha de Ingreso Contrato"].ToString()),
                Convert.ToDecimal(empleado["Salario Diario Contrato"].ToString()),
                Convert.ToDecimal(empleado["Salario Diario Integrado"].ToString()),
                empleado["Correo Electronico"].ToString(),
                empleado["Esquema"].ToString(),

               dtimeVigenciaContrato,

                gridLookCliente.Text,
                gridLookTenedoraSA.Text,
                gridLookTenedoraSC.Text.Trim(),

                Convert.ToInt32(gridLookTenedoraSA.EditValue),
                OperadorBD.OperadorGlobal.NombreUsuario,
                empleado["Codigo Postal Domicilio Fiscal"].ToString(),
                empleado["Claves"].ToString().ToUpper(),

                ref numEmpleado,
                ref existeEmpleado,
                ref codigoError_1,
                ref stDesError
                );

            return empleado["NSS"].ToString();
        }

        private void actulizarEmpleado(List<String> listEmpleadosIngresados, DataTable dtEmpleados)
        {
            DataTable dtRes = dtEmpleados.Clone();
            try
            {
                var query = dtEmpleados.AsEnumerable()
                    .Where(r =>
                        !listEmpleadosIngresados.AsEnumerable().Any(w =>
                            w == r.Field<String>("NSS")));

                if (query.Count() > 0)
                {
                    dtRes = query.CopyToDataTable();
                }
            }
            catch (Exception ex)
            {
                if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                XtraMessageBox.Show("No se puede actualizar a los empleados, por favor suba nuevamente la plantilla." + Environment.NewLine + "Exp-" + ex.Message
                , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            pintarGrid(dtRes);
        }


        //Funcion para insertar la direccion Laboral y Personal
        //[dbo].[stpInsDireccionEmpleadoCFDI] 

        #region LLenado de datos a los ComboBox
        //Llenado de Combobox con las tenedoradas SA de la base
        private void llenarComboTenedoraSA(DataTable dtTenedorasSA)
        {
            foreach (DataRow unRow in dtTenedorasSA.Rows)
            {
                cBoxTenedoraSA.Properties.Items.Add("[" + unRow[0] + "] - " + unRow[2]);
            }
        }

        //Llenado de Combobox con las Cliente de la base
        private void llenarComboCliente(DataTable dtClientes)
        {
            foreach (DataRow unRow in dtClientes.Rows)
            {
                cBoxClientes.Properties.Items.Add("[" + unRow[0] + "] - " + unRow[2]);
            }
        }
        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Cambiar de nombre a las columnas como se tienen en la plantilla
        /// </summary>
        /// <param name="dtDatos"></param>
        /// <returns></returns>
        private DataTable ingresarNombreColumnas(DataTable dtDatos)
        {
            int valorColumnas = arrayNombreColumnas.Count();
            if (dtDatos.Columns.Count >= valorColumnas)
            {
                int conta = 0;
                foreach (DataColumn item in dtDatos.Columns)
                {
                    item.ColumnName = arrayNombreColumnas[conta];
                    conta++;
                }
            }

            return dtDatos;
        }


        private DataTable ingresarNombreColumnasSalarios(DataTable dtDatos)
        {
            int valorColumnas = arrayNombreColumnasSalarios.Count();
            if (dtDatos.Columns.Count >= valorColumnas)
            {
                int conta = 0;
                foreach (DataColumn item in dtDatos.Columns)
                {
                    item.ColumnName = arrayNombreColumnasSalarios[conta];
                    conta++;
                }
            }

            return dtDatos;
        }

        /// <summary>
        /// Solicitar la baja de los empleados
        /// </summary>
        private void SolicitarBajaDeEmpleados(preSolicitud miPreSolicitud)
        {
            DataTable dtEmpleadosCFDI = new DataTable();
            Boolean banderaAvisos = false;

            stLog = DSC.addLog(stLog, "Obteniendo datos de Excel");
            dtEmpleados = obtenerDatosHojaBaja(SheetExcelEmpleados);
            //dtEmpleados = agregarColumnasBaja(dtEmpleados);

            if (dtEmpleados.Rows.Count > 0)
            {
                splashScreenManager3.SetWaitFormCaption("Validando Empleados");

                //dtEmpleadosCFDI = iniDTEmpleadosCFDI();

                stLog = DSC.addLog(stLog, "Validando Informacion");
                //**********************************************************************
                validarEmpleadosBaja(dtEmpleados, dtEmpleadosCFDI, miPreSolicitud);
                //**********************************************************************

                System.Threading.Thread.Sleep(500);

                splashScreenManager3.SetWaitFormDescription("Validando Registros...");
                stLog = DSC.addLog(stLog, "Validando registros repetidos");
                validarEmpleadosRepetidosBajas(dtEmpleados);

                stLog = DSC.addLog(stLog, "Quitar registros en blanco");
                dtEmpleados = quitarBlancosBajas(dtEmpleados);

                //ObtenerTenedorasPorEsquema(dtEmpleados);

                System.Threading.Thread.Sleep(500);
                splashScreenManager3.SetWaitFormDescription("Enviando Resultado a Excel...");
                if (lsErrores.Rows.Count > 0)
                {
                    stLog = DSC.addLog(stLog, "Enviando observaciones a Excel");
                    pintarErrores(lsErrores, SheetExcelEmpleados, stColumnaObservacionesSAICBajas);
                    banderaAvisos = soloAvisos(lsErrores);

                    if (banderaAvisos)
                    {
                        stLog = DSC.addLog(stLog, "Observaciones con Avisos");
                        if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                        XtraMessageBox.Show("Hay Avisos en la información de la Plantilla."
                    , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        stLog = DSC.addLog(stLog, "Enviar datos a Grid");
                        pintarGridBajas(dtEmpleados);
                    }
                    else
                    {
                        stLog = DSC.addLog(stLog, "Observaciones con Errores");
                        if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                        XtraMessageBox.Show("Hay Excepciones en la información de la Plantilla."
                      , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        if (miPreSolicitud.iTipoSolicitud == 2)//si es tipo baja la solicitud se habilitan tenedoraSA y Cliente
                        {
                            gridLookTenedoraSA.Enabled = true;
                            gridLookCliente.Enabled = true;
                        }
                    }
                }
                else
                {
                    stLog = DSC.addLog(stLog, "Enviar datos a Grid");
                    pintarGridBajas(dtEmpleados);
                }
            }
            else
            {
                stLog = DSC.addLog(stLog, "No se cuenta con informacion  en el archivo");
                if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                XtraMessageBox.Show("No se cuenta con informacion  en el archivo."
                  , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnAgregarPlantilla.Text = "Actualizar";
        }

        private DataTable quitarBlancosBajas(DataTable dtEmpleados)
        {
            var miquery = (from x in dtEmpleados.AsEnumerable()
                           where
                           x.Field<String>("IdEmpleado") != String.Empty
                           select x);

            dtEmpleados = miquery.CopyToDataTable();

            return dtEmpleados;

        }

        private void validarEmpleadosRepetidosBajas(DataTable dtEmpleados)
        {
            int iRow = stFilaInicial;
            int idEmpleado = 0;

            foreach (DataRow unRow in dtEmpleados.Rows)
            {
                int.TryParse(unRow["IdEmpleado"].ToString(), out idEmpleado);

                if (idEmpleado > 0)
                {
                    DataRow[] unDataRowEmpleado = dtEmpleados.Select("IdEmpleado = '" + idEmpleado + "'");

                    if (unDataRowEmpleado.Count() > 1)
                    {
                        addErrores("1", iRow.ToString(), "IdEmpleado: Esta Repetido en la plantilla.", 4);
                    }
                }
                iRow++;
            }
        }

        private DataTable obtenerDatosHojaBaja(Excel.Worksheet SheetExcel)
        {
            Excel.Range unRango;
            unRango = DSC.UltimoCelda(SheetExcel);
            String ultimaCelda = unRango.get_AddressLocal(false, false, Excel.XlReferenceStyle.xlA1, false, false);

            unRango = SheetExcel.get_Range(stColumnaObservacionesSAICBajas + "3", stColumnaObservacionesSAICBajas + DSC.soloNumeros(ultimaCelda));
            unRango.Select();
            unRango.Clear();

            unRango = SheetExcel.get_Range("A" + stFilaInicial, stColumnaFinalBajas + DSC.soloNumeros(ultimaCelda));
            unRango.Select();
            unRango.Copy();
            System.Threading.Thread.Sleep(2000);
            String losDatos = Clipboard.GetText();
            losDatos = losDatos.ToUpper();

            //DataTable dtEmpleados_1 = DSC.ConvertToDataTable(losDatos);
            DataTable dtEmpleados_1 = DSC.ConvertToDataTable(losDatos, 10);
            dtEmpleados_1 = ingresarNombreColumnasBajas(dtEmpleados_1);

            return dtEmpleados_1;
        }

        private DataTable ingresarNombreColumnasBajas(DataTable dtDatos)
        {
            int valorColumnas = arrayNombreColumnasBajas.Count();
            if (dtDatos.Columns.Count >= valorColumnas)
            {
                int conta = 0;
                foreach (DataColumn item in dtDatos.Columns)
                {
                    item.ColumnName = arrayNombreColumnasBajas[conta];
                    conta++;
                }
            }

            return dtDatos;
        }

        private void pintarGridBajas(DataTable dtEmpleados)
        {
            GridEmpleados.DataSource = dtEmpleados;
            lblRegistrosLeidos.Text = "Registros Leidos: " + dtEmpleados.Rows.Count;

            if (dtEmpleados.Rows.Count > 0)
            {
                btnSolicitarEmpleados.Enabled = true;
                habilitarBotones(false);
            }
            else
            {
                btnSolicitarEmpleados.Enabled = false;
                habilitarBotones(true);
            }
        }

        private void validarEmpleadosBaja(DataTable dtEmpleados, DataTable dtEmpleadosCFDI, preSolicitud miPreSolicitud)
        {
            try
            {
                splashScreenManager3.SetWaitFormCaption("Validando Empleados");
                splashScreenManager3.ShowWaitForm();
            }
            catch (Exception) { }

            int iConta = 1;

            int iRow = stFilaInicial;
            foreach (DataRow unRowEmpleado in dtEmpleados.Rows)
            {
                stLog = DSC.addLog(stLog, "Validando: " + iConta + " de " + dtEmpleados.Rows.Count);
                DSC = new tools.dsc();
                System.Threading.Thread.Sleep(400);
                splashScreenManager3.SetWaitFormDescription(iConta + " de " + dtEmpleados.Rows.Count);

                //Validando a los empleados
                if (valExisteEmpleadoBajas(iRow, unRowEmpleado, miPreSolicitud))
                {
                    //Validacion de Motivos de Baja
                    valMotivosBajaEmpleado(unRowEmpleado["Motivo de Baja"].ToString(), iRow);
                    valFechabajaEmpleado(unRowEmpleado["Fecha de Baja"].ToString(), iRow, dtFechaLimitebaja, objEmp, dtFechaLimiteFuturaBaja);
                }
                iRow++;
                iConta++;
            }
        }

        private void valFechabajaEmpleado(String stFechaBajaEmpleado, int indice, DateTime dtFechaLimiteBaja, Empleado objEmpleado, DateTime dtFechaLimiteFuturaBaja)
        {
            DateTime dtFechabajaEmpleado = new DateTime();
            if (!String.IsNullOrEmpty(stFechaBajaEmpleado))
            {
                if (DateTime.TryParse(stFechaBajaEmpleado, out dtFechabajaEmpleado))
                {
                    if (dtFechabajaEmpleado >= objEmpleado.FechaIngresoContrato)
                    {
                        if (dtFechabajaEmpleado.Date < dtFechaLimiteBaja.Date)
                        //if (dtFechaLimiteBaja < dtFechabajaEmpleado)
                        {
                            addErrores("9", indice.ToString(), "Fecha Baja: No se puede ser menor a 5 días. (" + dtFechaLimiteBaja.ToShortDateString() + ")", 1);
                        }
                        else if (dtFechabajaEmpleado.Date > dtFechaLimiteFuturaBaja.Date)
                        {
                            addErrores("9", indice.ToString(), "Fecha Baja: No se puede ser Mayor a (" + dtFechaLimiteFuturaBaja.ToShortDateString() + ")", 1);
                        }
                    }
                    else
                    {
                        addErrores("9", indice.ToString(), "Fecha Baja: No puede ser menor a la Fecha de Ingreso del Empleado.", 1);
                    }
                }
                else
                {
                    addErrores("9", indice.ToString(), "Fecha Baja: Es Invalida.", 1);
                }
            }
            else
            {
                addErrores("9", indice.ToString(), "Fecha Baja: No puede estar Vacio.", 1);
            }
        }

        private void valMotivosBajaEmpleado(String stMotivobajaEmpleado, int indice)
        {
            if (!String.IsNullOrEmpty(stMotivobajaEmpleado))
            {
                DataRow[] unRow = dbSAICBPOCatalogosDataSet1.stpSelObtenerConceptosBaja.Select("Descripcion = '" + stMotivobajaEmpleado + "'");
                if (unRow.Count() == 0)
                {
                    addErrores("8", indice.ToString(), "Motivo de Baja: No es Valido (Exp 1).", 1);
                }
            }
            else
            {
                addErrores("8", indice.ToString(), "Motivo de Baja: No puede estar Vacio.", 1);
            }
        }

        private Boolean valExisteEmpleadoBajas(int Indice, DataRow unRow, preSolicitud miPreSolicitud)
        {
            Boolean flagtaMuyBien = true;
            int idEmpleado = 0;

            // Validar Numero de empleado sea Valido
            if (int.TryParse(unRow.ItemArray[0].ToString(), out idEmpleado))
            {
                DataTable dt = this.stpSelObtenerInfoEmpleadoModificacionCFDITableAdapter1.GetData(idEmpleado);
                objEmp = EmpleadoBD.ObtenerInfoEmpleadoModificacionCFDI(dt);

                //Validando que el empleado exista en SAIC
                if (objEmp != null)
                {
                    //Validar paterno, materno y nombre sean iguales SAIC VS Plantilla
                    if ((unRow.ItemArray[1].ToString() + unRow.ItemArray[2].ToString() + unRow.ItemArray[3].ToString()) == objEmp.APaternoEmpleado + objEmp.AMaternoEmpleado + objEmp.NombreEmpleado)
                    {
                        //Validar NSS, RFC, CURP sean iguales SAIC VS Plantilla
                        if ((unRow.ItemArray[4].ToString() + unRow.ItemArray[5].ToString() + unRow.ItemArray[6].ToString()) == objEmp.NSS + objEmp.RFC + objEmp.CURP)
                        {
                            if (objEmp.IdEstatus != 7 && objEmp.IdEstatus != 9)
                            {
                                addErrores("1", Indice.ToString(), "El Empleado " + idEmpleado + ", no esta en Estatus Alta o Reingreso.", 1);
                                flagtaMuyBien = false;
                            }

                            //Validar que los empleados sean de la misma tenedora y cliente
                            if (objEmp.IdTenedoraSA != miPreSolicitud.idTenedora)
                            {
                                addErrores("1", Indice.ToString(), "El Empleado " + idEmpleado + ", no Corrende a la Tenedora:" + miPreSolicitud.TenedoraNombreComercial + ".", 4);
                                flagtaMuyBien = false;
                            }

                            if (objEmp.IdCliente != miPreSolicitud.idCliente)
                            {
                                addErrores("1", Indice.ToString(), "El Empleado " + idEmpleado + ", no Corrende al Cliente:" + miPreSolicitud.ClienteNombreComercial + ".", 4);
                                flagtaMuyBien = false;
                            }

                        }
                        else
                        {
                            addErrores("5", Indice.ToString(), "NSS, RFC o CURP, no corresponden al Empleado Registrado en SAIC.", 1);
                            addErrores("6", Indice.ToString(), "", 1);
                            addErrores("7", Indice.ToString(), "", 1);
                            flagtaMuyBien = false;
                        }
                    }
                    else
                    {
                        addErrores("2", Indice.ToString(), "Nombre y/o Apellidos, no corresponden al Empleado Registrado en SAIC.", 1);
                        addErrores("3", Indice.ToString(), "", 1);
                        addErrores("4", Indice.ToString(), "", 1);
                        flagtaMuyBien = false;
                    }
                }
                else
                {
                    addErrores("1", Indice.ToString(), "No existe el Empleado en SAIC.", 1);
                    flagtaMuyBien = false;
                }
            }
            else
            {
                addErrores("1", Indice.ToString(), "Número de Empleado Invalido.", 1);
                flagtaMuyBien = false;
            }

            return flagtaMuyBien;
        }

        /// <summary>
        /// Inicializar datatable de empleados con su respetivo tipo de dato.
        /// </summary>
        /// <param name="dtEmpleados"></param>
        /// <returns></returns>
        private DataTable iniDTEmpleadosCFDI()
        {
            DataTable dtEmpleados_CFDI = new DataTable();
            foreach (DataRow item in dtColumnasPlantilla.Rows)
            {
                if (item[2].ToString() == "String")
                {
                    dtEmpleados_CFDI.Columns.Add(item[1].ToString()).DataType = typeof(String);
                }
                else if (item[2].ToString() == "DateTime")
                {
                    dtEmpleados_CFDI.Columns.Add(item[1].ToString()).DataType = typeof(DateTime);
                }
                else if (item[2].ToString() == "Decimal")
                {
                    dtEmpleados_CFDI.Columns.Add(item[1].ToString()).DataType = typeof(Decimal);
                }
                else if (item[2].ToString() == "Int")
                {
                    dtEmpleados_CFDI.Columns.Add(item[1].ToString()).DataType = typeof(int);
                }
            }

            dtEmpleados_CFDI.Columns.Add("Errores").DataType = typeof(String);

            return dtEmpleados_CFDI;
        }

        private void btnDescPlantilla_Click(object sender, EventArgs e)
        {
            String stRutaArchivo = DSC.stRutaSAIC + @"Plantillas\";
            descargarPlantillaAltaEmpleados(4, stRutaArchivo);
        }

        public void descargarPlantillaAltaEmpleados(int TipoDocumento, String stRutaArchivo)
        {
            String stValor = String.Empty;

            stpSelDocumentosVersionTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelDocumentosVersion, 0, TipoDocumento);

            if (dbSAICBPOCatalogosDataSet1.stpSelDocumentosVersion.Rows.Count > 0)
            {
                stValor = dbSAICBPOCatalogosDataSet1.stpSelDocumentosVersion.Rows[0]["Valor"].ToString();

                if (!String.IsNullOrEmpty(stValor))
                {
                    splashScreenManager3.ShowWaitForm();
                    splashScreenManager3.SetWaitFormCaption("Plantilla");
                    splashScreenManager3.SetWaitFormDescription("Descargando...");

                    //String stRutaArchivo = DSC.stRutaSAIC + @"Plantillas\";
                    String stNombreArchivo = dbSAICBPOCatalogosDataSet1.stpSelDocumentosVersion.Rows[0]["NombreArchivo"].ToString();
                    stNombreArchivo = Path.GetFileNameWithoutExtension(stNombreArchivo) + " " + DSC.nombreAleatorio() + dbSAICBPOCatalogosDataSet1.stpSelDocumentosVersion.Rows[0]["Extencion"].ToString();

                    DSC.CheckandCreateFolder(stRutaArchivo);

                    Byte[] bytes = Convert.FromBase64String(stValor);
                    File.WriteAllBytes(stRutaArchivo + stNombreArchivo, bytes);
                    System.Threading.Thread.Sleep(2000);

                    stRutaArchivoDescargado = stRutaArchivo + stNombreArchivo;
                    //Process.Start(stRutaArchivo + stNombreArchivo);

                    splashScreenManager3.CloseWaitForm();

                    XtraMessageBox.Show("Plantilla Descargada." + "Ruta de Descarga: " + stRutaArchivo
                        , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("No se encuentra el archivo en el Servidor", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                XtraMessageBox.Show("No se encuentra la plantilla.", "SAIC",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region Los Errores


        /// <summary>
        /// Agregar los errores al DataTable.
        /// </summary>
        /// <param name="stColumna"></param>
        /// <param name="stFila"></param>
        /// <param name="error"></param>
        /// <param name="iTipoError"></param>
        private void addErrores(String stColumna, String stFila, String error, int? iTipoError)
        {
            DataRow[] iEsta = lsErrores.Select("Fila = '" + stFila + "'");
            String stErrorAcumulado = String.Empty;
            stErrorAcumulado = error;

            if (iEsta.Count() > 0)
            {

                if (String.IsNullOrEmpty(error)) { stErrorAcumulado = error + iEsta[0].ItemArray[3]; }
                else { stErrorAcumulado = error + "; " + iEsta[0].ItemArray[3]; }

                for (int i = 0; i < lsErrores.Rows.Count; i++)
                {
                    if (lsErrores.Rows[i]["Fila"].ToString() == stFila)
                        lsErrores.Rows[i]["Error Acumulado"] = stErrorAcumulado;
                }
            }

            lsErrores.Rows.Add(stColumna, stFila, error, stErrorAcumulado, iTipoError);
        }
        /// <summary>
        /// Agrega los errores en la hoja de Excel
        /// </summary>
        /// <param name="losErrores">DataTable con la lista de errores.</param>
        /// <param name="SheetExcel">Hoja de Excel donde se mostraran los errores</param>
        private void pintarErrores(DataTable losErrores, Excel.Worksheet SheetExcel, String stColumnaObservacionesSAIC)
        {
            Excel.Range unRango = SheetExcel.Cells;
            foreach (DataRow unRow in losErrores.Rows)
            {
                String stColumna = unRow["Columna"].ToString();
                String stFila = unRow["Fila"].ToString();

                if (!String.IsNullOrEmpty(stColumna) && !String.IsNullOrEmpty(stFila))
                {
                    stColumna = DSC.ColumnaExcel(Convert.ToInt32(stColumna));

                    if (unRow["Tipo Error"].ToString() == "1")
                    {
                        pintarRojo(stColumna, unRow["Fila"].ToString(), SheetExcel);
                    }
                    else if (unRow["Tipo Error"].ToString() == "2")
                    {
                        pintarVerde(stColumna, unRow["Fila"].ToString(), SheetExcel);
                    }
                    else if (unRow["Tipo Error"].ToString() == "3")
                    {
                        pintarAmarillo(stColumna, unRow["Fila"].ToString(), SheetExcel);
                    }
                    else if (unRow["Tipo Error"].ToString() == "4")
                    {
                        pintarRenglon(stColumnaObservacionesSAIC, unRow["Fila"].ToString(), SheetExcel);
                    }
                    else if (unRow["Tipo Error"].ToString() == "5") // Para Reingresos
                    {
                        pintarReingreso(stColumna, unRow["Fila"].ToString(), SheetExcel);
                    }
                    else if (unRow["Tipo Error"].ToString() == "6") // 
                    {
                        pintarRenglonAmarillo(stColumnaObservacionesSAIC, unRow["Fila"].ToString(), SheetExcel);
                    }

                    if (unRow["Error"].ToString().Contains("Vacio") || unRow["Error"].ToString().Contains("ResBase"))
                    {
                        SheetExcel.get_Range(stColumna + stFila).Value = unRow["Error"].ToString().Replace("ResBase", "");
                    }

                    SheetExcel.get_Range(stColumnaObservacionesSAIC + stFila).Value = unRow["Error Acumulado"].ToString();
                }
            }
        }

        private void pintarRojo(String stColumna, String stFila, Excel.Worksheet SheetExcel)
        {
            Excel.Range unRango = SheetExcel.Cells;
            //stColumna = DSC.ColumnaExcel(Convert.ToInt32(stColumna));

            unRango = SheetExcel.get_Range(stColumna + stFila);

            unRango.Interior.Pattern = Excel.XlPattern.xlPatternSolid;
            unRango.Interior.PatternColorIndex = Excel.XlPattern.xlPatternAutomatic;
            unRango.Interior.Color = 255;
            unRango.Interior.TintAndShade = 0;
            unRango.Interior.PatternTintAndShade = 0;

            unRango.Font.ThemeColor = Excel.XlThemeColor.xlThemeColorDark1;
            unRango.Font.TintAndShade = 0;
            unRango.Font.Bold = true;
        }

        private void pintarVerde(String stColumna, String stFila, Excel.Worksheet SheetExcel)
        {
            Excel.Range unRango = SheetExcel.Cells;

            unRango = SheetExcel.get_Range(stColumna + stFila);

            unRango.Interior.Pattern = Excel.XlPattern.xlPatternSolid;
            unRango.Interior.PatternColorIndex = Excel.XlPattern.xlPatternAutomatic;
            unRango.Interior.Color = 5287936;
            unRango.Interior.TintAndShade = 0;
            unRango.Interior.PatternTintAndShade = 0;

            unRango.Font.ThemeColor = Excel.XlThemeColor.xlThemeColorDark1;
            unRango.Font.TintAndShade = 0;
            unRango.Font.Bold = true;
        }

        private void pintarAmarillo(String stColumna, String stFila, Excel.Worksheet SheetExcel)
        {
            Excel.Range unRango = SheetExcel.Cells;

            unRango = SheetExcel.get_Range(stColumna + stFila);

            unRango.Interior.Pattern = Excel.XlPattern.xlPatternSolid;
            unRango.Interior.PatternColorIndex = Excel.XlPattern.xlPatternAutomatic;
            unRango.Interior.Color = 65535;
            unRango.Interior.TintAndShade = 0;
            unRango.Interior.PatternTintAndShade = 0;

            unRango.Font.TintAndShade = 0;
            unRango.Font.Bold = true;
        }

        private void pintarReingreso(String stColumna, String stFila, Excel.Worksheet SheetExcel)
        {
            Excel.Range unRango = SheetExcel.Cells;

            unRango = SheetExcel.get_Range(stColumna + stFila);

            unRango.Interior.Pattern = Excel.XlPattern.xlPatternSolid;
            unRango.Interior.PatternColorIndex = Excel.XlPattern.xlPatternAutomatic;
            unRango.Interior.Color = 10079487;
            unRango.Interior.TintAndShade = 0;
            unRango.Interior.PatternTintAndShade = 0;

            unRango.Font.TintAndShade = 0;
            unRango.Font.Bold = true;
        }

        private void pintarRenglon(String stColumnaFinal, String stFila, Excel.Worksheet SheetExcel)
        {
            Excel.Range unRango = SheetExcel.Cells;

            unRango = SheetExcel.get_Range("A" + stFila + ":" + stColumnaFinal + stFila);

            unRango.Interior.Pattern = Excel.XlPattern.xlPatternSolid;
            unRango.Interior.PatternColorIndex = Excel.XlPattern.xlPatternAutomatic;
            unRango.Interior.Color = 255;
            unRango.Interior.TintAndShade = 0;
            unRango.Interior.PatternTintAndShade = 0;

            unRango.Font.ThemeColor = Excel.XlThemeColor.xlThemeColorDark1;
            unRango.Font.TintAndShade = 0;
            unRango.Font.Bold = true;

        }

        private void pintarRenglonAmarillo(String stColumnaFinal, String stFila, Excel.Worksheet SheetExcel)
        {
            Excel.Range unRango = SheetExcel.Cells;

            unRango = SheetExcel.get_Range("A" + stFila + ":" + stColumnaFinal + stFila);

            unRango.Interior.Pattern = Excel.XlPattern.xlPatternSolid;
            unRango.Interior.PatternColorIndex = Excel.XlPattern.xlPatternAutomatic;
            unRango.Interior.Color = 65535;
            unRango.Interior.TintAndShade = 0;
            unRango.Interior.PatternTintAndShade = 0;

            unRango.Font.TintAndShade = 0;
            unRango.Font.Bold = true;
        }

        private Boolean soloAvisos(DataTable dbErrores)
        {
            var query = from x in dbErrores.AsEnumerable()
                        where x.Field<int>("Tipo Error") == 1 || x.Field<int>("Tipo Error") == 2 || x.Field<int>("Tipo Error") == 4
                        select x;

            if (query.Count() > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        #endregion Los Errores

        private void pintarGrid(DataTable dtEmpleados)
        {
            GridEmpleados.DataSource = dtEmpleados;
            //gridViewEmpleados.Columns[0].Fixed;
            lblRegistrosLeidos.Text = "Registros Leidos: " + dtEmpleados.Rows.Count;

            if (dtEmpleados.Rows.Count > 0)
            {
                btnSolicitarEmpleados.Enabled = true;
                habilitarBotones(false);

                //validar fechas extemporaneas IMSS
                IMSS.XtraEmpleadosXSolicitudIMSS oXtraEmpleadosXSolicitudIMSS = new IMSS.XtraEmpleadosXSolicitudIMSS(new Solicitud());
                DateTime dFechaAltaLimite = oXtraEmpleadosXSolicitudIMSS.obtenerFechaAltaLimite();
                foreach (DataRow item in dtEmpleados.Rows)
                {
                    DateTime dFechaIngresoContrato;
                    DateTime.TryParse(item["Fecha de Ingreso Contrato"].ToString(), out dFechaIngresoContrato);

                    if (dFechaIngresoContrato < dFechaAltaLimite.AddDays(-1))
                    {
                        flagMensajeDeFechasExtemporaneas = true;
                        break;
                    }
                }
            }
            else
            {
                btnSolicitarEmpleados.Enabled = false;
                habilitarBotones(true);
            }

            ObtenerTenedorasPorEsquema(dtEmpleados);
        }
        private void pintarGridSalarios(DataTable dtEmpleados)
        {
            GridEmpleados.DataSource = dtEmpleados;
            lblRegistrosLeidos.Text = "Registros Leidos: " + dtEmpleados.Rows.Count;
        }

        #region Validaciones
        /// <summary>
        /// Validar Apellido Paterno, Apellido Materno y Nombre.
        /// </summary>
        /// <param name="stpaterno">Apellido Paterno del Empleado</param>
        /// <param name="stmaterno">Apelliodo Materno del Empleado</param>
        /// <param name="stNombre">Nombre o Nombres de del Empleado</param>
        private void valNombreEmpleado(String stpaterno, String stmaterno, String stNombre, int indice)
        {
            String stCaracteresEspecialesPaterno = String.Empty;
            String stCaracteresEspecialesMaterno = String.Empty;
            String stCaracteresEspecialesNombre = String.Empty;

            if (!String.IsNullOrEmpty(stpaterno))
            {
                stCaracteresEspecialesPaterno = DSC.contieneCaracteresEspeciales(stpaterno, DSC.stCaracteresEspeciales);
                if (!String.IsNullOrEmpty(stCaracteresEspecialesPaterno))
                    addErrores("1", indice.ToString(), "Apellido Paterno: Contiene Caracterres Invalidos " + stCaracteresEspecialesPaterno + " .", 1);
            }

            if (!String.IsNullOrEmpty(stmaterno))
            {
                stCaracteresEspecialesMaterno = DSC.contieneCaracteresEspeciales(stmaterno, DSC.stCaracteresEspeciales);
                if (!String.IsNullOrEmpty(stCaracteresEspecialesMaterno))
                    addErrores("2", indice.ToString(), "Apellido Materno: Contiene Caracterres Invalidos." + stCaracteresEspecialesMaterno + " .", 1);
            }

            if (!String.IsNullOrEmpty(stNombre))
            {
                stCaracteresEspecialesNombre = DSC.contieneCaracteresEspeciales(stNombre, DSC.stCaracteresEspeciales);
                if (!String.IsNullOrEmpty(stCaracteresEspecialesNombre))
                    addErrores("3", indice.ToString(), "Nombre: Contiene Caracterres Invalidos." + stCaracteresEspecialesNombre + " .", 1);
            }
            else
            {
                addErrores("3", indice.ToString(), "Nombre: No puede estar Vacio.", 1);
            }
        }
        /// <summary>
        /// Validar NSS, RFC y CURP.
        /// </summary>
        /// <param name="stNSS">Numero de Seguridad Social del Empleado.</param>
        /// <param name="stRFC">Numero RFC del Empleado.</param>
        /// <param name="stCurp">Numero CURP del Empleado</param>
        /// <param name="indice"></param>
        private int valNSSRFCCURP(String stNSS, String stRFC, String stCurp, int indice, String stAPaterno, String stAMaterno, String stNombre, DataRow drEmpleadoPlantilla)
        {
            Boolean bandera = true;
            int iTipoIngreso = 1; // 1 - Nuevo Ingreso, 2 - Reingreso
            //Boolean estaMuyBien = true;

            #region validando que no esten vacios.
            if (String.IsNullOrEmpty(stRFC))
            {
                addErrores("7", indice.ToString(), "RFC: No pueden estar Vacio.", 1);
                bandera = false;
                iTipoIngreso = 0;
            }
            if (String.IsNullOrEmpty(stCurp))
            {
                addErrores("8", indice.ToString(), "CURP: No pueden estar Vacio.", 1);
                bandera = false;
                iTipoIngreso = 0;
            }
            if (String.IsNullOrEmpty(stNSS))
            {
                addErrores("6", indice.ToString(), "NSS: No pueden estar Vacio.", 1);
                bandera = false;
                iTipoIngreso = 0;
            }


            #endregion

            if (bandera)
            {
                #region validando que respenten la nomblegatura de RFC, NSS, CURP
                Boolean bandera1 = true;

                //Obtener valores de RegEx de la tabla

                String stRegExNSS = String.Empty;
                String stRegExRFC = String.Empty;
                String stRegExCURP = String.Empty;


                stpSelParametroRegExTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelParametroRegEx, "NSS");
                if (dbSAICBPOCatalogosDataSet1.stpSelParametroRegEx.Rows.Count > 0)
                {
                    stRegExNSS = dbSAICBPOCatalogosDataSet1.stpSelParametroRegEx.Rows[0]["ValorParametro"].ToString();
                }
                else
                {
                    stRegExNSS = dsc.nssPattern;
                }

                stpSelParametroRegExTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelParametroRegEx, "RFC");
                if (dbSAICBPOCatalogosDataSet1.stpSelParametroRegEx.Rows.Count > 0)
                {
                    stRegExRFC = dbSAICBPOCatalogosDataSet1.stpSelParametroRegEx.Rows[0]["ValorParametro"].ToString();
                }
                else
                {
                    stRegExRFC = dsc.rfcPattern;
                }

                stpSelParametroRegExTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelParametroRegEx, "CURP");
                if (dbSAICBPOCatalogosDataSet1.stpSelParametroRegEx.Rows.Count > 0)
                {
                    stRegExCURP = dbSAICBPOCatalogosDataSet1.stpSelParametroRegEx.Rows[0]["ValorParametro"].ToString();
                }
                else
                {
                    stRegExCURP = dsc.curpPattern;
                }

                if (!DSC.validarRFC(stRFC, stRegExRFC))
                {
                    addErrores("7", indice.ToString(), "RFC: No tiene la estructura correcta.", 1);
                    bandera1 = false;
                    iTipoIngreso = 0;
                }
                else
                {
                    //Validar RFC con el Nombre Ingresado
                    String stIndiceNombre = String.Empty;
                    String stPrimerApellidoPaterno = String.IsNullOrEmpty(stAPaterno) ? String.Empty : stAPaterno.Split(' ')[stAPaterno.Split(' ').Length - 1][0].ToString();
                    String stSegundoVocalPaterno = String.IsNullOrEmpty(stAPaterno) ? String.Empty : DSC.PrimeraVocal(stAPaterno.Split(' ')[stAPaterno.Split(' ').Length - 1]);
                    String stPrimerApellidoMaterno = String.IsNullOrEmpty(stAMaterno) ? String.Empty : stAMaterno.Split(' ')[stAMaterno.Split(' ').Length - 1][0].ToString();
                    String stPrimerLetraNombre = DSC.LetraNombre(stNombre);

                    stIndiceNombre = stPrimerApellidoPaterno + stSegundoVocalPaterno + stPrimerApellidoMaterno + stPrimerLetraNombre;

                    if (!stCurp.StartsWith(stIndiceNombre))
                    {
                        addErrores("7", indice.ToString(), "RFC: El RFC no conindice con el nombre ingresado.", 3);
                    }
                }

                if (!DSC.validarCURP(stCurp, stRegExCURP))
                {
                    addErrores("8", indice.ToString(), "CURP: No tiene la estructura correcta.", 1);
                    bandera1 = false;
                    iTipoIngreso = 0;
                }
                else
                {
                    //Validar CURp con el Nombre Ingresado
                    String stIndiceNombre = String.Empty;
                    String stPrimerApellidoPaterno = String.IsNullOrEmpty(stAPaterno) ? String.Empty : stAPaterno.Split(' ')[stAPaterno.Split(' ').Length - 1][0].ToString();
                    String stSegundoVocalPaterno = String.IsNullOrEmpty(stAPaterno) ? String.Empty : DSC.PrimeraVocal(stAPaterno.Split(' ')[stAPaterno.Split(' ').Length - 1]);
                    String stPrimerApellidoMaterno = String.IsNullOrEmpty(stAMaterno) ? String.Empty : stAMaterno.Split(' ')[stAMaterno.Split(' ').Length - 1][0].ToString();
                    String stPrimerLetraNombre = DSC.LetraNombre(stNombre);

                    stIndiceNombre = stPrimerApellidoPaterno + stSegundoVocalPaterno + stPrimerApellidoMaterno + stPrimerLetraNombre;

                    if (!stCurp.StartsWith(stIndiceNombre))
                    {
                        addErrores("8", indice.ToString(), "CURP: El CURP no conindice con el nombre ingresado.", 3);
                    }
                }
                if (!DSC.validarNSS(stNSS, stRegExNSS))
                {
                    addErrores("6", indice.ToString(), "NSS: No tiene la estructura correcta.", 1);
                    bandera1 = false;
                    iTipoIngreso = 0;
                }

                #endregion

                if (bandera1)
                {
                    String stRespuesta = String.Empty;
                    #region Validando si existe RFC, NSS, CURP
                    stpValidacionEmpleadosTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpValidacionEmpleados, stNSS, stRFC, stCurp, ref stRespuesta);
                    if (!String.IsNullOrEmpty(stRespuesta))
                    {
                        if (stRespuesta.Contains("DIFERENCIA"))
                        {
                            iTipoIngreso = 0;
                            String stColumna = String.Empty;

                            if (stRespuesta.Contains("NSS"))
                            {
                                addErrores("6", indice.ToString(), "", 1);
                                stColumna = "6";
                            }
                            if (stRespuesta.Contains("RFC"))
                            {
                                addErrores("7", indice.ToString(), "", 1);
                                stColumna = "7";

                            }
                            if (stRespuesta.Contains("CURP"))
                            {
                                addErrores("8", indice.ToString(), "", 1);
                                stColumna = "8";
                            }

                            addErrores(stColumna, indice.ToString(), stRespuesta, 1);
                        }
                        else
                        {
                            if (stRespuesta.Contains("RFC"))
                            {
                                addErrores("7", indice.ToString(), stRespuesta, 2);
                                iTipoIngreso = 0;
                            }
                            else if (stRespuesta.Contains("CURP"))
                            {
                                addErrores("8", indice.ToString(), stRespuesta, 2);
                                iTipoIngreso = 0;
                            }
                            else if (stRespuesta.Contains("NSS"))
                            {
                                addErrores("6", indice.ToString(), stRespuesta, 2);
                                iTipoIngreso = 0;
                            }
                            else if (stRespuesta.Contains("Reingreso"))
                            {
                                int idEmpleado = 0;
                                int.TryParse(stRespuesta.Replace("Reingreso N.", ""), out idEmpleado);
                                drEmpleadoPlantilla["idEmpleado"] = idEmpleado;

                                addErrores("1", indice.ToString(), stRespuesta, 5);
                                addErrores("2", indice.ToString(), "", 5);
                                addErrores("3", indice.ToString(), "", 5);
                                iTipoIngreso = 2;
                            }
                        }
                    }
                    #endregion
                }
            }

            return iTipoIngreso;
        }

        /// <summary>
        /// Validar RFC y CURP.
        /// </summary>
        /// <param name="stRFC"></param>
        /// <param name="stCurp"></param>
        /// <param name="indice"></param>
        /// <param name="stAPaterno"></param>
        /// <param name="stAMaterno"></param>
        /// <param name="stNombre"></param>
        /// <returns></returns>
        private int valNSSRFCCURP(String stRFC, String stCurp, int indice, String stAPaterno, String stAMaterno, String stNombre, DataRow drEmpleadoPlantilla)
        {
            Boolean bandera = true;
            //Boolean estaMuyBien = true;
            int iTipoIngreso = 1; // 1 - Nuevo Ingreso, 2 - Reingreso

            #region validando que no esten vacios.
            if (String.IsNullOrEmpty(stRFC))
            {
                addErrores("7", indice.ToString(), "RFC: No pueden estar Vacio.", 1);
                bandera = false;
                iTipoIngreso = 0;
            }
            if (String.IsNullOrEmpty(stCurp))
            {
                addErrores("8", indice.ToString(), "CURP: No pueden estar Vacio.", 1);
                bandera = false;
                iTipoIngreso = 0;
            }
            #endregion

            if (bandera)
            {
                #region validando que respenten la nomblegatura de RFC, NSS, CURP
                Boolean bandera1 = true;

                if (!DSC.validarRFC(stRFC))
                {
                    addErrores("7", indice.ToString(), "RFC: No tiene la estructura correcta.", 1);
                    bandera1 = false;
                    iTipoIngreso = 0;
                }
                else
                {
                    //Validar RFC con el Nombre Ingresado
                    String stIndiceNombre = String.Empty;
                    String stPrimerApellidoPaterno = String.IsNullOrEmpty(stAPaterno) ? String.Empty : stAPaterno.Split(' ')[stAPaterno.Split(' ').Length - 1][0].ToString();
                    String stSegundoVocalPaterno = String.IsNullOrEmpty(stAPaterno) ? String.Empty : DSC.PrimeraVocal(stAPaterno.Split(' ')[stAPaterno.Split(' ').Length - 1]);
                    String stPrimerApellidoMaterno = String.IsNullOrEmpty(stAMaterno) ? String.Empty : stAMaterno.Split(' ')[stAMaterno.Split(' ').Length - 1][0].ToString();
                    String stPrimerLetraNombre = DSC.LetraNombre(stNombre);

                    stIndiceNombre = stPrimerApellidoPaterno + stSegundoVocalPaterno + stPrimerApellidoMaterno + stPrimerLetraNombre;

                    if (!stCurp.StartsWith(stIndiceNombre))
                    {
                        addErrores("7", indice.ToString(), "RFC: El RFC no coincide con el nombre ingresado.", 3);
                    }
                }

                if (!DSC.validarCURP(stCurp))
                {
                    addErrores("8", indice.ToString(), "CURP: No tiene la estructura correcta.", 1);
                    bandera1 = false;
                    iTipoIngreso = 0;
                }
                else
                {
                    //Validar CURp con el Nombre Ingresado
                    String stIndiceNombre = String.Empty;
                    String stPrimerApellidoPaterno = String.IsNullOrEmpty(stAPaterno) ? String.Empty : stAPaterno.Split(' ')[stAPaterno.Split(' ').Length - 1][0].ToString();
                    String stSegundoVocalPaterno = String.IsNullOrEmpty(stAPaterno) ? String.Empty : DSC.PrimeraVocal(stAPaterno.Split(' ')[stAPaterno.Split(' ').Length - 1]);
                    String stPrimerApellidoMaterno = String.IsNullOrEmpty(stAMaterno) ? String.Empty : stAMaterno.Split(' ')[stAMaterno.Split(' ').Length - 1][0].ToString();
                    String stPrimerLetraNombre = DSC.LetraNombre(stNombre);

                    stIndiceNombre = stPrimerApellidoPaterno + stSegundoVocalPaterno + stPrimerApellidoMaterno + stPrimerLetraNombre;

                    if (!stCurp.StartsWith(stIndiceNombre))
                    {
                        addErrores("8", indice.ToString(), "CURP: El CURP no coincide con el nombre ingresado.", 3);
                    }
                }
                #endregion

                if (bandera1)
                {
                    String stRespuesta = String.Empty;
                    #region Validando si existe RFC, CURP
                    stpValidacionEmpleadosEsquemaATableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpValidacionEmpleadosEsquemaA, stRFC, stCurp, ref stRespuesta);
                    if (!String.IsNullOrEmpty(stRespuesta))
                    {
                        if (stRespuesta.Contains("DIFERENCIA"))
                        {
                            iTipoIngreso = 0;
                            String stColumna = String.Empty;

                            if (stRespuesta.Contains("RFC"))
                            {
                                addErrores("7", indice.ToString(), "", 1);
                                stColumna = "7";

                            }
                            if (stRespuesta.Contains("CURP"))
                            {
                                addErrores("8", indice.ToString(), "", 1);
                                stColumna = "8";
                            }

                            addErrores(stColumna, indice.ToString(), stRespuesta, 1);
                        }
                        else
                        {
                            if (stRespuesta.Contains("RFC"))
                            {
                                addErrores("7", indice.ToString(), stRespuesta, 2);
                                iTipoIngreso = 0;
                            }
                            else if (stRespuesta.Contains("CURP"))
                            {
                                addErrores("8", indice.ToString(), stRespuesta, 2);
                                iTipoIngreso = 0;
                            }
                            else if (stRespuesta.Contains("Reingreso"))
                            {
                                int idEmpleado = 0;
                                int.TryParse(stRespuesta.Replace("Reingreso N.", ""), out idEmpleado);
                                drEmpleadoPlantilla["idEmpleado"] = idEmpleado;

                                addErrores("1", indice.ToString(), stRespuesta, 5);
                                addErrores("2", indice.ToString(), "", 5);
                                addErrores("3", indice.ToString(), "", 5);
                                iTipoIngreso = 2;
                            }
                        }
                    }
                    #endregion
                }
            }

            return iTipoIngreso;
        }



        /// <summary>
        /// Validar la Fecha de Contrato de Empleado
        /// </summary>
        /// <param name="stFechaIngreso">Fecha de ingreso del empleado</param>
        /// <param name="indice"></param>
        private void valFechaIngreso(String stFechaIngreso, int indice)
        {
            if (!String.IsNullOrEmpty(stFechaIngreso))
            {
                DateTime dtFechaIngreso;

                if (DateTime.TryParse(stFechaIngreso, out dtFechaIngreso))
                {
                    DateTime.TryParse(stFechaIngreso, out dtFechaIngreso);
                    if (dtFechaIngreso > DateTime.Now.AddDays(15))
                    {
                        addErrores("4", indice.ToString(), "Fecha De Ingreso Cliente: No puede ser mayor a la Fecha Actual", 1);
                    }
                }
                else
                {
                    addErrores("4", indice.ToString(), "Fecha De Ingreso Cliente: No es una Fecha Valida.", 1);
                }
            }
            else
            {
                addErrores("4", indice.ToString(), "Fecha De Ingreso Cliente: No puede estar Vacio.", 1);
            }
        }
        /// <summary>
        /// Validar el Salario Diario con el cual el empleado esta contratado con el cliente.
        /// </summary>
        /// <param name="stSalarioReal">Salario real diario del cliente</param>
        /// <param name="indice"></param>
        private void valSalarioReal(String stSalarioReal, int indice, DataRow unRow)
        {
            if (!String.IsNullOrEmpty(stSalarioReal))
            {
                Decimal dcmSalarioReal = 0;
                if (!Decimal.TryParse(stSalarioReal, out dcmSalarioReal))
                {
                    addErrores("5", indice.ToString(), "Salario Diario Cliente: No es Valido", 1);
                }
                else
                {
                    dcmSalarioReal = decimal.Round(dcmSalarioReal, 2);
                    unRow[4] = dcmSalarioReal.ToString();
                }
            }
            else
            {
                addErrores("5", indice.ToString(), "Salario Diario Cliente: No puede estar Vacio.", 1);
            }
        }
        /// <summary>
        /// Validar la nacionalidad del empleado vs el catalogo de nacionalidad.
        /// </summary>
        /// <param name="stnacionalidad">nacionalidad del empleado</param>
        /// <param name="indice"></param>
        private void valNacionalidad(String stnacionalidad, int indice)
        {
            if (!String.IsNullOrEmpty(stnacionalidad))
            {
                DataRow[] unRow = dbSAICBPOCatalogosDataSet1.stpSelNacionalidad.Select("DescNacionalidad = '" + stnacionalidad + "'");
                if (unRow.Count() == 0)
                {
                    addErrores("9", indice.ToString(), "Nacionalidad: No es Valida (Exp 1).", 1);
                }
            }
            else
            {
                addErrores("9", indice.ToString(), "Nacionalidad: No puede estar Vacio.", 1);
            }
        }
        /// <summary>
        /// Validar el Estado Civil del empleado VS el catalo de EstadoCivil.
        /// </summary>
        /// <param name="stSexo"></param>
        /// <param name="indice"></param>
        private void valEstadoCivil(String stEstadoCivil, int indice, String stEsquema, DataRow unDataRow)
        {
            if (stEsquema == "A")
            {
                if (!String.IsNullOrEmpty(stEstadoCivil))
                {
                    DataRow[] unRow = dbSAICBPOCatalogosDataSet1.stpSelEstadoCivil.Select("DescEstadoCivil = '" + stEstadoCivil + "'");
                    if (unRow.Count() == 0)
                    {
                        addErrores("10", indice.ToString(), "Estado Civil: No es Valido (Exp 1).", 1);
                    }
                }
                else
                {
                    unDataRow[8] = "N/D";
                }
            }
            else
            {
                if (!String.IsNullOrEmpty(stEstadoCivil))
                {
                    DataRow[] unRow = dbSAICBPOCatalogosDataSet1.stpSelEstadoCivil.Select("DescEstadoCivil = '" + stEstadoCivil + "'");
                    if (unRow.Count() == 0)
                    {
                        addErrores("10", indice.ToString(), "Estado Civil: No es Valido (Exp 1).", 1);
                    }
                }
                else
                {
                    addErrores("10", indice.ToString(), "Estado Civil: No puede estar Vacio.", 1);
                }
            }
        }
        /// <summary>
        /// Validaar
        /// </summary>
        /// <param name="stTipoIdenficicacion"></param>
        /// <param name="stNumeroIndentificacion"></param>
        /// <param name="iIndice"></param>
        private void valTipoIndentificacion(String stTipoIdenficicacion, String stNumeroIndentificacion, int iIndice, String stTipoEsquema)
        {
            if (!String.IsNullOrEmpty(stTipoIdenficicacion))
            {
                DataRow[] unRow = dbSAICBPOCatalogosDataSet1.stpSelTipoIdentificacion.Select("TipoIdentificacionNombre = '" + stTipoIdenficicacion + "'");
                if (unRow.Count() == 0)
                {
                    addErrores("11", iIndice.ToString(), "Tipo Indentificación: No es Valido (Exp 1).", 1);
                }
                else
                {
                    if (stTipoEsquema != "A")
                    {
                        if (!stTipoIdenficicacion.Contains("NINGUNA"))
                        {
                            if (!String.IsNullOrEmpty(stNumeroIndentificacion))
                            {
                                if (stNumeroIndentificacion.Contains("+") || stNumeroIndentificacion.Contains("."))
                                {
                                    addErrores("12", iIndice.ToString(), "Número Identificación: Contiene Caracterres Invalidos.", 1);
                                }
                            }
                            else
                            {
                                addErrores("12", iIndice.ToString(), "Número Identificación: No puede estar Vacio.", 1);
                            }
                        }
                    }
                }
            }
            else
            {
                addErrores("11", iIndice.ToString(), "Tipo Indentificación: No puede estar Vacio.", 1);
            }
        }
        /// <summary>
        /// Validar el puesto real del empleado
        /// </summary>
        /// <param name="stPuestoReal"></param>
        /// <param name="iIndice"></param>
        private void valPuestoReal(String stPuestoReal, int iIndice)
        {
            if (!String.IsNullOrEmpty(stPuestoReal))
            {
                String stContieneCaracteresEspeciales = String.Empty;
                stContieneCaracteresEspeciales = DSC.contieneCaracteresEspeciales(stPuestoReal, DSC.stCaracteresEspeciales);
                if (!String.IsNullOrEmpty(stContieneCaracteresEspeciales))
                {
                    addErrores("13", iIndice.ToString(), "Puesto Real: Contiene Caracterres Invalidos " + stContieneCaracteresEspeciales + ".", 1);
                }
            }
            else
            {
                addErrores("13", iIndice.ToString(), "Puesto Real: No puede estar Vacio.", 1);
            }
        }
        /// <summary>
        /// Validar Departamento Real
        /// </summary>
        /// <param name="stDepartamentoReal"></param>
        /// <param name="iIndice"></param>
        private void valDepartamento(String stDepartamentoReal, int iIndice)
        {
            if (!String.IsNullOrEmpty(stDepartamentoReal))
            {
                String stContieneCaracteresEspeciales = String.Empty;
                stContieneCaracteresEspeciales = DSC.contieneCaracteresEspeciales(stDepartamentoReal, DSC.stCaracteresEspeciales);
                if (!String.IsNullOrEmpty(stContieneCaracteresEspeciales))
                {
                    addErrores("14", iIndice.ToString(), "Departamento Real: Contiene Caracterres Invalidos " + stContieneCaracteresEspeciales + ".", 1);
                }
            }
            else
            {
                addErrores("14", iIndice.ToString(), "Departamento Real: No puede estar Vacio.", 1);
            }
        }
        /// <summary>
        /// 15 - Validar Herramientas de trabajo 
        /// </summary>
        private void valHerramientasTrabajo(String stHerramientastrabajo, int iIndice)
        {
            String stContiene = String.Empty;
            stContiene = DSC.contieneCaracteresEspeciales(stHerramientastrabajo, DSC.stCaracteresEspeciales_1);

            if (!String.IsNullOrEmpty(stContiene))
            {
                addErrores("15", iIndice.ToString(), "Herramientas de Trabajo: Contiene cacteres especiales: " + stContiene, 1);
            }
        }
        /// <summary>
        /// Validar el tipo de nomina VS el catalogo cat.TipoPeriodoNomina
        /// </summary>
        /// <param name="stTipoNomina"></param>
        /// <param name="iIndice"></param>
        private void valTipoNomina(String stTipoNomina, int iIndice)
        {
            if (!String.IsNullOrEmpty(stTipoNomina))
            {
                DataRow[] unRow = dbSAICBPOCatalogosDataSet1.stpSelTipoPeriodoNomina.Select("DescTipoPeriodoNomina = '" + stTipoNomina + "'");
                if (unRow.Count() == 0)
                {
                    addErrores("16", iIndice.ToString(), "Tipo Nomina: No es Valido (Exp 1).", 1);
                }
            }
            else
            {
                addErrores("16", iIndice.ToString(), "Tipo de Nomina: No puede estar Vacio.", 1);
            }
        }
        /// <summary>
        /// 17 - validar las Funciones a desempeñar.
        /// </summary>
        /// <param name="stFuncionDesempeñar"></param>
        /// <param name="iIndice"></param>
        private void valFuncionDesempeñar(String stFuncionDesempeñar, int iIndice)
        {
            String stContiene = String.Empty;
            int iNumeroCaracteres = 0;

            stContiene = DSC.contieneCaracteresEspeciales(stFuncionDesempeñar, DSC.stCaracteresEspeciales_1);
            stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "NUMCARACTERES");

            if (dbSAICBPOValidacionDataSet1.stpSelParametro.Rows.Count > 0)
            {
                int.TryParse(dbSAICBPOValidacionDataSet1.stpSelParametro[0]["ValorParametro"].ToString(), out iNumeroCaracteres);
            }
            else
            {
                //Numero por Defalul
                iNumeroCaracteres = 500;
            }

            if (!String.IsNullOrEmpty(stContiene))
            {
                addErrores("17", iIndice.ToString(), "Funcion a Desempeñar: Contiene cacteres especiales: " + stContiene, 1);
            }
            if (stFuncionDesempeñar.Length > iNumeroCaracteres)
            {
                addErrores("17", iIndice.ToString(), "Funcion a Desempeñar: No debe Exceder los " + iNumeroCaracteres + " Caracteres. (" + stFuncionDesempeñar.Length + ").", 1);
            }
        }
        /// <summary>
        /// Validar dias de jornada
        /// </summary>
        /// <param name="stFuncionDesempeñar"></param>
        /// <param name="iIndice"></param>
        private void valDiasJornada(String stDesJornada, int iIndice)
        {
            Boolean flagTaMuyBien = true;
            //validar que no este vacio el campo
            if (!String.IsNullOrEmpty(stDesJornada))
            {
                stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "DesJornadaTipo");
                String[] arrayDiasSemanas = stDesJornada.Split(new[] { " A " }, StringSplitOptions.None);

                if (dbSAICBPOValidacionDataSet1.stpSelParametro.Rows.Count > 0)
                {
                    flagTaMuyBien = false;
                    String stDesJornadaTipo = dbSAICBPOValidacionDataSet1.stpSelParametro.Rows[0]["ValorParametro"].ToString();

                    if (!String.IsNullOrEmpty(stDesJornadaTipo))
                    {
                        if (stDesJornada == stDesJornadaTipo)
                        {
                            flagTaMuyBien = false;
                        }
                        else
                        {
                            flagTaMuyBien = true;
                        }
                    }
                    else
                    {
                        flagTaMuyBien = true;
                    }
                }

                if (flagTaMuyBien)
                {

                    if (arrayDiasSemanas.Length == 2)
                    {
                        if (Array.IndexOf(arrayDiasSemana, arrayDiasSemanas[0]) != -1)
                        {
                            if (Array.IndexOf(arrayDiasSemana, arrayDiasSemanas[1]) != -1)
                            {
                                //int iDias = 0;
                                //iDias = DSC.contarDiasSemana(arrayDiasSemanas[0], arrayDiasSemanas[1]);
                                //if (iDias < 5)
                                //{
                                //    addErrores("18", iIndice.ToString(), "Días de Jornada: Dias menores a los establecidos (" + iDias + " días).", 1);
                                //}
                                //else if (iDias > 7)
                                //{
                                //    addErrores("18", iIndice.ToString(), "Días de Jornada: Dias mayores a los establecidos (" + iDias + " días).", 1);
                                //}
                            }
                            else
                            {
                                addErrores("18", iIndice.ToString(), "Días de Jornada: Día fin de semana Invalido (" + arrayDiasSemanas[1] + ").", 1);
                            }
                        }
                        else
                        {
                            addErrores("18", iIndice.ToString(), "Días de Jornada: Día inicial de semana Invalido (" + arrayDiasSemanas[0] + ").", 1);
                        }
                    }
                    else
                    {
                        addErrores("18", iIndice.ToString(), "Días de Jornada: No es Valido(Exp 2).", 1);
                    }
                }
            }
            else
            {
                addErrores("18", iIndice.ToString(), "Días de Jornada: No puede estar Vacio.", 1);
            }
        }
        /// <summary>
        /// Validar el Horario de Jornada del empleado
        /// </summary>
        /// <param name="stHorarioJornada"></param>
        /// <param name="iIndice"></param>
        private void valHorarioJornada(String stHorarioJornada, int iIndice, DataRow unRow)
        {
            if (!String.IsNullOrEmpty(stHorarioJornada))
            {
                String[] arrayDiasSemanas = stHorarioJornada.Split(new[] { " A " }, StringSplitOptions.None);

                if (arrayDiasSemanas.Length == 2)
                {
                    TimeSpan TSPrimeraHora;
                    TimeSpan TSSegundaHora;

                    TimeSpan.TryParse(arrayDiasSemanas[0], out TSPrimeraHora);
                    TimeSpan.TryParse(arrayDiasSemanas[1], out TSSegundaHora);

                    if (TimeSpan.TryParse(arrayDiasSemanas[0], out TSPrimeraHora))
                    {
                        if (TimeSpan.TryParse(arrayDiasSemanas[1], out TSSegundaHora))
                        {

                            //if (unRow["Esquema"].ToString() != "A")
                            //{
                            //int[] horaIni = arrayDiasSemanas[0].Split(':').Select(x => Convert.ToInt32(x)).ToArray();
                            //int[] horaFin = arrayDiasSemanas[1].Split(':').Select(x => Convert.ToInt32(x)).ToArray();

                            //TimeSpan TSHoraInicio = new TimeSpan(horaIni[0], horaIni[1], 00);
                            //TimeSpan TSHoraFin = new TimeSpan(horaFin[0], horaFin[1], 00);
                            unRow[18] = TSPrimeraHora.Hours.ToString("00") + ":" + TSPrimeraHora.Minutes.ToString("00") + " A " +
                                TSSegundaHora.Hours.ToString("00") + ":" + TSSegundaHora.Minutes.ToString("00");
                            unRow["Turno"] = ObtenerTurno(TSPrimeraHora, TSSegundaHora);
                            //}
                            //else
                            //{
                            //    unRow["Turno"] = "N/D";
                            //}

                        }
                        else
                        {
                            addErrores("19", iIndice.ToString(), "Horario Jornada: Hora Fin no es Valida.(Exp 2).", 1);
                        }
                    }
                    else
                    {
                        addErrores("19", iIndice.ToString(), "Horario Jornada: Hora Inicial no es Valida.(Exp 2).", 1);
                    }

                    //if (!DSC.contieneLetras(arrayDiasSemanas[0]) && !DSC.contieneLetras(arrayDiasSemanas[1]))
                    //{
                    //    if (arrayDiasSemanas[0].Contains(":"))
                    //    {
                    //        if (arrayDiasSemanas[1].Contains(":"))
                    //        {
                    //            if (unRow["Esquema"].ToString() != "A")
                    //            {
                    //                int[] horaIni = arrayDiasSemanas[0].Split(':').Select(x => Convert.ToInt32(x)).ToArray();
                    //                int[] horaFin = arrayDiasSemanas[1].Split(':').Select(x => Convert.ToInt32(x)).ToArray();

                    //                TimeSpan TSHoraInicio = new TimeSpan(horaIni[0], horaIni[1], 00);
                    //                TimeSpan TSHoraFin = new TimeSpan(horaFin[0], horaFin[1], 00);
                    //                unRow["Turno"] = ObtenerTurno(TSHoraInicio, TSHoraFin);
                    //            }
                    //            else
                    //            {
                    //                unRow["Turno"] = "N/D";
                    //            }
                    //        }
                    //        else
                    //        {
                    //            addErrores("19", iIndice.ToString(), "Horario Jornada: Hora Fin no es Valida.(Exp 2).", 1);
                    //        }
                    //    }
                    //    else
                    //    {
                    //        addErrores("19", iIndice.ToString(), "Horario Jornada: Hora Inicial no es Valida.(Exp 2).", 1);
                    //    }
                    //}
                    //else
                    //{
                    //    addErrores("19", iIndice.ToString(), "Horario Jornada: El formato de las horas es invalido.(Exp 2).", 1);
                    //}
                }
                else
                {
                    addErrores("19", iIndice.ToString(), "Horario Jornada: No es Valido(Exp 2).", 1);
                }
            }
            else
            {
                addErrores("19", iIndice.ToString(), "Horario Jornada: No puede estar Vacio.", 1);
            }
        }
        /// <summary>
        /// Valida el tipo de servicio VS el catalogo [cat].[JornadaServicio]
        /// </summary>
        /// <param name="stJornadaServicio"></param>
        /// <param name="iIndice"></param>
        private void valJornadaServicio(String stJornadaServicio, int iIndice)
        {
            if (!String.IsNullOrEmpty(stJornadaServicio))
            {
                DataRow[] unRow = dbSAICBPOCatalogosDataSet1.stpSelJornadaServicio.Select("DescJornadaServicio = '" + stJornadaServicio + "'");
                if (unRow.Count() == 0)
                {
                    addErrores("20", iIndice.ToString(), "Jornada Servicio: No es Valido (Exp 1).", 1);
                }
            }
            else
            {
                addErrores("20", iIndice.ToString(), "Jornada Servicio: No puede estar Vacio.", 1);
            }
        }
        /// <summary>
        /// Validar el tiempo de descanso o comida del trabajor
        /// </summary>
        /// <param name="stTiempoDescanso"></param>
        /// <param name="iIndice"></param>
        private void valTiempoDescanso(String stTiempoDescanso, int iIndice)
        {
            if (!String.IsNullOrEmpty(stTiempoDescanso))
            {
                String[] arrayDiasSemanas = stTiempoDescanso.Split(new[] { " A " }, StringSplitOptions.None);
                if (arrayDiasSemanas.Length == 2)
                {
                    TimeSpan tsIni, tsFin;
                    if (TimeSpan.TryParse(arrayDiasSemanas[0], out tsIni) && TimeSpan.TryParse(arrayDiasSemanas[1], out tsFin))
                    {
                        TimeSpan tsMinimoDescanso = new TimeSpan(0, 29, 0);
                        TimeSpan tsResultado = tsFin - tsIni;
                        if (tsResultado < tsMinimoDescanso)
                        {
                            addErrores("21", iIndice.ToString(), "Tiempo Comida/Descanso: Debe ser mayor a 30 Min.", 1);
                        }
                    }
                    else
                    {
                        addErrores("21", iIndice.ToString(), "Tiempo Comida/Descanso: El formato de las horas es invalido.(Exp 2).", 1);
                    }
                }
                else
                {
                    addErrores("21", iIndice.ToString(), "Tiempo Comida/Descanso: No es Valido(Exp 2).", 1);
                }
            }
            else
            {
                addErrores("21", iIndice.ToString(), "Tiempo Comida/Descanso: No puede estar Vacio.", 1);
            }
        }
        /// <summary>
        /// Validar el Tipo de contratacion, fecha de contratacion y tiempo de contratacion
        /// </summary>
        /// <param name="stTipoContratacion"></param>
        /// <param name="stTiempoContratacion"></param>
        /// <param name="stFechaContratacion"></param>
        private void valContratacion(String stTipoContratacion, String stTiempoContratacion, String stFechaContratacion, int iIndice, DataRow drEmpleado)
        {
            if (!String.IsNullOrEmpty(stTipoContratacion))
            {
                DataRow[] unRow = dbSAICBPOCatalogosDataSet1.stpSelTipoContrato.Select("DescTipoContrato = '" + stTipoContratacion + "'");
                if (unRow.Count() > 0)
                {
                    if (stTipoContratacion != "INDETERMINADO")
                    {
                        drEmpleado["Vigencia Contrato"] = valTiempoContrato(stTiempoContratacion, stFechaContratacion, iIndice);
                    }
                    else
                    {
                        drEmpleado[22] = String.Empty;
                        drEmpleado["Vigencia Contrato"] = "1900/01/01";
                    }
                }
                else
                {
                    addErrores("22", iIndice.ToString(), "Tipo Contrato: No es Valido (Exp 1).", 1);
                }
            }
            else
            {
                addErrores("22", iIndice.ToString(), "Tipo Contrato: No puede estar Vacio.", 1);
            }
        }
        /// <summary>
        /// Validar el tipo de contrato VS el catalogo cat.TipoContrato
        /// </summary>
        /// <param name="stTipoContrato"></param>
        /// <param name="iIndice"></param>
        private void valTipoContrato(String stTipoContrato, int iIndice)
        {
            if (!String.IsNullOrEmpty(stTipoContrato))
            {
                DataRow[] unRow = dbSAICBPOCatalogosDataSet1.stpSelTipoContrato.Select("DescTipoContrato = '" + stTipoContrato + "'");
                if (unRow.Count() == 0)
                {
                    addErrores("22", iIndice.ToString(), "Tipo Contrato: No es Valido (Exp 1).", 1);
                }
            }
            else
            {
                addErrores("22", iIndice.ToString(), "Tipo Contrato: No puede estar Vacio.", 1);
            }
        }
        /// <summary>
        /// Validar el tiempo de contrato del empleado.
        /// </summary>
        /// <param name="stTiempoContrato"></param>
        /// <param name="stFechaIngresoContrato"></param>
        /// <param name="iIndice"></param>
        private DateTime valTiempoContrato(String stTiempoContrato, String stFechaIngresoContrato, int iIndice)
        {
            DateTime dtimeFechaContrato = new DateTime(); ;
            if (!String.IsNullOrEmpty(stFechaIngresoContrato))
            {
                if (DateTime.TryParse(stFechaIngresoContrato, out dtimeFechaContrato))
                {
                    if (!String.IsNullOrEmpty(stTiempoContrato))
                    {
                        int iNumeroDias;
                        if (int.TryParse(stTiempoContrato, out iNumeroDias))
                        {
                            if (iNumeroDias > 0)
                            {
                                dtimeFechaContrato = dtimeFechaContrato.AddDays(iNumeroDias - 1);
                                dtimeFechaContrato = valFechaIngresoContrato(dtimeFechaContrato);
                                //String stFechaVigenciaContrato = dtimeFechaContrato.ToShortDateString();
                            }
                            else
                            {
                                addErrores("23", iIndice.ToString(), "Tiempo Contrato: Debe ser mayor a 0.", 1);
                            }
                        }
                        else
                        {
                            addErrores("23", iIndice.ToString(), "Tiempo Contrato: No es Valido (Exp 2).", 1);
                        }
                    }
                    else
                    {
                        addErrores("23", iIndice.ToString(), "Tiempo Contrato: No puede estar Vacio.", 1);
                    }
                }
                else
                {
                    addErrores("44", iIndice.ToString(), "Fecha Ingreso Contrato: No es Valido.  (Exp 2)", 1);
                }
            }
            else
            {
                addErrores("44", iIndice.ToString(), "Fecha Ingreso Contrato: No puede estar Vacio.", 1);
            }

            return dtimeFechaContrato;
        }

        /// <summary>
        /// Validar la fecha contrato
        /// </summary>
        /// <returns></returns>
        public DateTime valFechaIngresoContrato(DateTime dtFechaVigenciaContrato)
        {
            if (dtFechaVigenciaContrato.DayOfWeek.ToString() == "Saturday")
            {
                dtFechaVigenciaContrato = dtFechaVigenciaContrato.AddDays(-1);
            }
            else if (dtFechaVigenciaContrato.DayOfWeek.ToString() == "Sunday")
            {
                dtFechaVigenciaContrato = dtFechaVigenciaContrato.AddDays(-2);
            }

            return dtFechaVigenciaContrato;
        }

        /// <summary>
        /// 24 - Validacion del Concepto de contratacion del empleado.
        /// </summary>
        /// <param name="stConceptoContratacion"></param>
        /// <param name="iIndice"></param>
        private void valConceptoContratacion(String stConceptoContratacion, int iIndice)
        {
            String stContiene = String.Empty;
            stContiene = DSC.contieneCaracteresEspeciales(stConceptoContratacion, DSC.stCaracteresEspeciales_1);

            if (!String.IsNullOrEmpty(stContiene))
            {
                addErrores("24", iIndice.ToString(), "Concepto Contratación: Contiene cacteres especiales: " + stContiene, 1);
            }
        }
        /// <summary>
        /// Validar la calle centro de trabajo del trabajador.
        /// </summary>
        /// <param name="stCalleTrabajo"></param>
        /// <param name="iIndice"></param>
        private void valCalleTrabajo(String stCalleTrabajo, int iIndice)
        {
            if (!String.IsNullOrEmpty(stCalleTrabajo))
            {
                String stContienCaracteres = String.Empty;
                stContienCaracteres = DSC.contieneCaracteresEspeciales(stCalleTrabajo, DSC.stCaracteresEspeciales);
                if (!String.IsNullOrEmpty(stContienCaracteres))
                {
                    addErrores("25", iIndice.ToString(), "Calle Centro de Trabajo: Contiene Caracteres Especiales " + stContienCaracteres + ".", 1);
                }
            }
            else
            {
                addErrores("25", iIndice.ToString(), "Calle Centro de Trabajo: No puede estar Vacio.", 1);
            }
        }
        /// <summary>
        /// 26 - Validar el numero exterior del domicilio del trabajo.
        /// </summary>
        /// <param name="stNoExteriorCentroTrabajo"></param>
        /// <param name="iIndice"></param>
        private void valNoExteriorCentroTrabajo(String stNoExteriorCentroTrabajo, int iIndice)
        {
            if (!String.IsNullOrEmpty(stNoExteriorCentroTrabajo))
            {
                String stContienCaracteres = String.Empty;
                stContienCaracteres = DSC.contieneCaracteresEspeciales(stNoExteriorCentroTrabajo, DSC.stCaracteresEspeciales);
                if (!String.IsNullOrEmpty(stContienCaracteres))
                {
                    addErrores("26", iIndice.ToString(), "No Exterior de Trabajo: Contiene Caracteres Especiales " + stContienCaracteres + ".", 1);
                }
            }
            else
            {
                addErrores("26", iIndice.ToString(), "No Exterior de Trabajo: No puede estar Vacio.", 1);
            }
        }
        /// <summary>
        /// Validar numero interior del domicilio de trabajo.
        /// </summary>
        /// <param name="stNoInteriorCentroTrabajo"></param>
        /// <param name="iIndice"></param>
        private void valNoInteriorCentroTrabajo(String stNoInteriorCentroTrabajo, int iIndice, DataRow drEmpleado)
        {
            if (!String.IsNullOrEmpty(stNoInteriorCentroTrabajo))
            {
                String stContienCaracteres = String.Empty;
                stContienCaracteres = DSC.contieneCaracteresEspeciales(stNoInteriorCentroTrabajo, DSC.stCaracteresEspeciales);
                if (!String.IsNullOrEmpty(stContienCaracteres))
                {
                    addErrores("27", iIndice.ToString(), "No Interior de Trabajo: Contiene Caracteres Especiales " + stContienCaracteres + ".", 1);
                }
            }
            else
            {
                drEmpleado[26] = String.Empty;
                //addErrores("27", iIndice.ToString(), "No Interior de Trabajo: No puede estar Vacio.", 1);
            }
        }
        /// <summary>
        /// Validar colonia del domicilio de trabajo.
        /// </summary>
        /// <param name="stColoniaCentroTrabajo"></param>
        /// <param name="iIndice"></param>
        private void valColoniaCentroTrabajo(String stColoniaCentroTrabajo, int iIndice)
        {
            if (!String.IsNullOrEmpty(stColoniaCentroTrabajo))
            {
                String stContienCaracteres = String.Empty;
                stContienCaracteres = DSC.contieneCaracteresEspeciales(stColoniaCentroTrabajo, DSC.stCaracteresEspeciales);
                if (!String.IsNullOrEmpty(stContienCaracteres))
                {
                    addErrores("28", iIndice.ToString(), "Colonia de Trabajo: Contiene Caracteres Especiales " + stContienCaracteres + ".", 1);
                }
            }
            else
            {
                addErrores("28", iIndice.ToString(), "Colonia de Trabajo: No puede estar Vacio.", 1);
            }
        }
        /// <summary>
        /// Validacion del codigo postal VS el catalog de CodigoPostales [cat].[FactCodigoPostal] y validacion del estado con el codigo postal.
        /// </summary>
        /// <param name="stCPCentroTrabajo"></param>
        /// <param name="stEstadoCentroTrabajo"></param>
        /// <param name="iIndice"></param>
        private void valCPCentroTrabajo(String stCPCentroTrabajo, String stEstadoCentroTrabajo, int iIndice)
        {
            if (!String.IsNullOrEmpty(stCPCentroTrabajo))
            {
                if (stCPCentroTrabajo.Length == 5 && !DSC.contieneLetras(stCPCentroTrabajo))
                {
                    if (!String.IsNullOrEmpty(stEstadoCentroTrabajo))
                    {
                        DataRow[] unRow = dbSAICBPOCatalogosDataSet1.stpSelCodigoPostal.Select("ClaveCodigoPostal = '" + stCPCentroTrabajo + "'");
                        if (unRow.Count() > 0)
                        {
                            if (stEstadoCentroTrabajo != unRow[0].ItemArray[2].ToString())
                            {
                                addErrores("31", iIndice.ToString(), "Estado Centro Trabajo: No corresponde al Codigo Postal (Exp 1).", 1);
                            }
                        }
                        else
                        {
                            addErrores("29", iIndice.ToString(), "Codigo Postal Centro de Trabajo: No es Valido (Exp 1).", 1);
                        }
                    }
                    else
                    {
                        addErrores("31", iIndice.ToString(), "Estado Centro Trabajo: No puede estar Vacio.", 1);
                    }
                }
                else
                {
                    addErrores("29", iIndice.ToString(), "Codigo Postal Centro de Trabajo:  No es Valido(Exp 2)", 1);
                }
            }
            else
            {
                addErrores("29", iIndice.ToString(), "Codigo Postal Centro de Trabajo: No puede estar Vacio.", 1);
            }
        }
        /// <summary>
        /// validacion de la delegacion del domicilio de trabajo
        /// </summary>
        /// <param name="stDelegacionMunicio"></param>
        /// <param name="iIndice"></param>
        private void valDelegacionMunicio(String stDelegacionMunicio, int iIndice)
        {
            if (!String.IsNullOrEmpty(stDelegacionMunicio))
            {
                String stContienCaracteres = String.Empty;
                stContienCaracteres = DSC.contieneCaracteresEspeciales(stDelegacionMunicio, DSC.stCaracteresEspeciales);
                if (!String.IsNullOrEmpty(stContienCaracteres))
                {
                    addErrores("30", iIndice.ToString(), "Delegacion Centro Trabajo: Contiene Caracteres Especiales " + stContienCaracteres + ".", 1);
                }
            }
            else
            {
                addErrores("30", iIndice.ToString(), "Delegacion Centro Trabajo: No puede estar Vacio.", 1);

            }
        }
        /// <summary>
        /// Validar la calle de domicilio particular del empleado.
        /// </summary>
        /// <param name="stCalleParticular"></param>
        /// <param name="iIndice"></param>
        private void valCalleParticular(String stCalleParticular, int iIndice)
        {
            if (!String.IsNullOrEmpty(stCalleParticular))
            {
                String stContienCaracteres = String.Empty;
                stContienCaracteres = DSC.contieneCaracteresEspeciales(stCalleParticular, DSC.stCaracteresEspeciales);
                if (!String.IsNullOrEmpty(stContienCaracteres))
                {
                    addErrores("32", iIndice.ToString(), "Calle Domicilio Empleado: Contiene Caracteres Especiales " + stContienCaracteres + ".", 1);
                }
            }
            else
            {
                addErrores("32", iIndice.ToString(), "Calle Domicilio Empleado: No puede estar Vacio.", 1);
            }
        }
        /// <summary>
        /// Validar el numero exterior del domicilio particular del empleado.
        /// </summary>
        /// <param name="stNoExteriorParticular"></param>
        /// <param name="iIndice"></param>
        private void valNoExteriorParticular(String stNoExteriorParticular, int iIndice)
        {
            if (!String.IsNullOrEmpty(stNoExteriorParticular))
            {
                String stContienCaracteres = String.Empty;
                stContienCaracteres = DSC.contieneCaracteresEspeciales(stNoExteriorParticular, DSC.stCaracteresEspeciales);
                if (!String.IsNullOrEmpty(stContienCaracteres))
                {
                    addErrores("33", iIndice.ToString(), "No Exterior Empleado: Contiene Caracteres Especiales " + stContienCaracteres + ".", 1);
                }
            }
            else
            {
                addErrores("33", iIndice.ToString(), "No Exterior Empleado: No puede estar Vacio.", 1);
            }
        }
        /// <summary>
        /// Validar el numero interior del domicilio del empleado.
        /// </summary>
        /// <param name="stNoInteriorParticular"></param>
        /// <param name="iIndice"></param>
        private void valNoInteriorParticular(String stNoInteriorParticular, int iIndice, DataRow unDataRow)
        {
            if (!String.IsNullOrEmpty(stNoInteriorParticular))
            {
                String stContienCaracteres = String.Empty;
                stContienCaracteres = DSC.contieneCaracteresEspeciales(stNoInteriorParticular, DSC.stCaracteresEspeciales);
                if (!String.IsNullOrEmpty(stContienCaracteres))
                {
                    addErrores("34", iIndice.ToString(), "No Interior Empleado: Contiene Caracteres Especiales " + stContienCaracteres + ".", 1);
                }
            }
            else
            {
                unDataRow[33] = String.Empty;
                //addErrores("34", iIndice.ToString(), "No Interior Empleado: No puede estar Vacio.", 1);
            }
        }
        /// <summary>
        /// Validar la colonia del domicilio del empleado.
        /// </summary>
        /// <param name="stColiniaParticular"></param>
        /// <param name="iIndice"></param>
        private void valColoniaParticular(String stColiniaParticular, int iIndice)
        {
            if (!String.IsNullOrEmpty(stColiniaParticular))
            {
                String stContienCaracteres = String.Empty;
                stContienCaracteres = DSC.contieneCaracteresEspeciales(stColiniaParticular, DSC.stCaracteresEspeciales);
                if (!String.IsNullOrEmpty(stContienCaracteres))
                {
                    addErrores("35", iIndice.ToString(), "Colonia Empleado: Contiene Caracteres Especiales " + stContienCaracteres + ".", 1);
                }
            }
            else
            {
                addErrores("35", iIndice.ToString(), "Colonia Empleado: No puede estar Vacio.", 1);
            }
        }
        /// <summary>
        /// Validar el codigo postal del domicilio particular VS el catalogo de codigo postal cat.FactCodigoPostal y el Estado del domicilio particular.
        /// </summary>
        /// <param name="stCPParticular"></param>
        /// <param name="stEstadoEmpleado"></param>
        /// <param name="iIndice"></param>
        private void valCPParticular(String stCPParticular, String stEstadoEmpleado, int iIndice)
        {
            if (!String.IsNullOrEmpty(stCPParticular))
            {
                if (stCPParticular.Length == 5 && !DSC.contieneLetras(stCPParticular))
                {
                    if (!String.IsNullOrEmpty(stEstadoEmpleado))
                    {
                        DataRow[] unRow = dbSAICBPOCatalogosDataSet1.stpSelCodigoPostal.Select("ClaveCodigoPostal = '" + stCPParticular + "'");
                        if (unRow.Count() > 0)
                        {
                            if (stEstadoEmpleado != unRow[0].ItemArray[2].ToString())
                            {
                                addErrores("38", iIndice.ToString(), "Estado Empleado: No corresponde al Codigo Postal (Exp 1).", 1);
                            }
                        }
                        else
                        {
                            addErrores("36", iIndice.ToString(), "Codigo Postal Empleado : No es Valido (Exp 1).", 1);
                        }
                    }
                    else
                    {
                        addErrores("38", iIndice.ToString(), "Estado Empleado: No puede estar Vacio.", 1);
                    }
                }
                else
                {
                    addErrores("36", iIndice.ToString(), "Codigo Postal Empleado:  No es Valido(Exp 2)", 1);
                }
            }
            else
            {
                addErrores("36", iIndice.ToString(), "Codigo Postal Empleado: No puede estar Vacio.", 1);
            }
        }
        /// <summary>
        /// Validar delegacion del domicilio particular.
        /// </summary>
        /// <param name="stCPParticular"></param>
        /// <param name="iIndice"></param>
        private void valDelegacionParticular(String stCPParticular, int iIndice)
        {
            if (!String.IsNullOrEmpty(stCPParticular))
            {
                String stContienCaracteres = String.Empty;
                stContienCaracteres = DSC.contieneCaracteresEspeciales(stCPParticular, DSC.stCaracteresEspeciales);
                if (!String.IsNullOrEmpty(stContienCaracteres))
                {
                    addErrores("37", iIndice.ToString(), "Delegacion Empleado: Contiene Caracteres Especiales " + stContienCaracteres + ".", 1);
                }
            }
            else
            {
                addErrores("37", iIndice.ToString(), "Delegacion Empleado: No puede estar Vacio.", 1);
            }
        }
        /// <summary>
        /// Validar el Centro de Costo del empleado
        /// </summary>
        /// <param name="stCentroCosto"></param>
        /// <param name="iIndice"></param>
        private void valCentroCosto(String stCentroCosto, int iIndice, String sNumColumnaEnPlantilla)
        {

            if (stCentroCosto.Length > 30)
            {
                addErrores(sNumColumnaEnPlantilla, iIndice.ToString(), "Centro de Costo: No puede ser mayor a 30 caracteres ", 1);
            }
            else
            {
                String stCaracteresEspeciales = String.Empty;
                stCaracteresEspeciales = DSC.contieneCaracteresEspeciales(stCentroCosto, DSC.stCaracteresEspeciales);
                if (!String.IsNullOrEmpty(stCaracteresEspeciales))
                {
                    addErrores(sNumColumnaEnPlantilla, iIndice.ToString(), "Centro de Costo: Contiene caracteres especiales. " + stCaracteresEspeciales, 1);
                }
            }
        }
        /// <summary>
        /// Validar el credito infonavit del empleado
        /// </summary>
        /// <param name="stCreditoInfonavit"></param>
        /// <param name="iIndice"></param>
        private void valCreditoInfonavit(String stCreditoInfonavit, int iIndice, String sNumColumnaEnPlantilla)
        {
            if (!String.IsNullOrEmpty(stCreditoInfonavit))
            {
                if (!DSC.contieneNumeros(stCreditoInfonavit))
                {
                    addErrores(sNumColumnaEnPlantilla, iIndice.ToString(), "Credtio Infonavit: Contiene caracteres especiales. (A-Z)", 1);
                }
            }
        }
        /// <summary>
        /// Validar el tipo de pago, y la Clabe interbancaria
        /// </summary>
        /// <param name="stTipoPago"></param>
        /// <param name="stClabe"></param>
        /// /// <param name="stEsquema"></param>
        /// <param name="iIndice"></param>
        private void valTipoPago(String stTipoPago, String stClabe, String stEsquema, int iIndice, DataRow unDataRow)
        {
            if (!String.IsNullOrEmpty(stTipoPago))
            {
                DataRow[] unRow = dbSAICBPOCatalogosDataSet1.stpSelFormaPago.Select("DescFormaPago = '" + stTipoPago + "'");
                if (unRow.Count() > 0)
                {
                    if (stTipoPago == "TRANSFERENCIA")
                    {
                        //vALIDAR CLABE
                        if (!String.IsNullOrEmpty(stClabe))
                        {
                            if (stClabe.Length == 18 && DSC.contieneNumeros(stClabe))
                            {
                                Boolean? esClabe = false;
                                esClabe = queriesTableAdapter1.ValidarClabe(stClabe);
                                if (esClabe == false)
                                {
                                    addErrores("43", iIndice.ToString(), "CLABE: No es una Clabe Valida. (Exp 2)", 1);
                                }
                            }
                            else
                            {
                                addErrores("43", iIndice.ToString(), "CLABE: No contiene el formato correcto. (Exp 2)", 1);
                            }
                        }
                        else
                        {
                            addErrores("43", iIndice.ToString(), "CLABE: No puede estar Vacio.", 1);
                        }
                    }
                    else if (stTipoPago == "TARJETA")
                    {
                        if (stEsquema != "A")
                        {
                            if (!String.IsNullOrEmpty(stClabe))
                            {
                                int ivalTarjeta;
                                decimal idecimal;
                                decimal.TryParse(stClabe, out idecimal);
                                if (idecimal != 0)
                                {
                                    //if (idecimal.ToString().Length != 16)
                                    if (stClabe.ToString().Length != 16)
                                    {
                                        addErrores("43", iIndice.ToString(), "Numero de Tarjeta: No contiene 16 Caracteres.", 1);
                                    }
                                }
                                else
                                {
                                    addErrores("43", iIndice.ToString(), "Numero de Tarjeta: No es Numerico.", 1);
                                }
                            }
                            else
                            {
                                // Clabe
                                unDataRow[42] = String.Empty;
                            }
                        }
                        else
                        {
                            addErrores("42", iIndice.ToString(), "No se puede Solicitar Tarjeta con tipo de Esquema = A", 1);
                        }
                    }
                    else if (stTipoPago == "CHEQUE")
                    {
                        // Clabe
                        unDataRow[42] = String.Empty;
                    }
                    else
                    {
                        addErrores("42", iIndice.ToString(), "Tipo Pago: No es valido(Exp 1).", 1);
                    }
                }
                else
                {
                    addErrores("42", iIndice.ToString(), "Tipo Pago: No es valido(Exp 1).", 1);
                }
            }
            else
            {
                addErrores("42", iIndice.ToString(), "Tipo de Pago: No puede estar Vacio.", 1);
            }
        }
        /// <summary>
        /// Validar el puesto contrato del empleado
        /// </summary>
        /// <param name="stPuestoContrato"></param>
        /// <param name="iIndice"></param>
        private void valPuestoContrato(String stPuestoContrato, int iIndice)
        {
            String stCaracteresEspeciales = String.Empty;
            stCaracteresEspeciales = DSC.contieneCaracteresEspeciales(stPuestoContrato, DSC.stCaracteresEspeciales);
            if (!String.IsNullOrEmpty(stCaracteresEspeciales))
            {
                addErrores("44", iIndice.ToString(), "Puesto Contrato: Contiene caracteres especiales. " + stCaracteresEspeciales, 1);
            }
        }
        /// <summary>
        /// Validar la fecha de ingreso de contrato del empleado.
        /// </summary>
        /// <param name="stFechaContrato"></param>
        /// <param name="iIndice"></param>
        private DateTime valFechaIngresoContrato(String stFechaContrato, int iIndice)
        {
            DateTime dtFechaContrato = new DateTime();
            if (!String.IsNullOrEmpty(stFechaContrato))
            {
                DateTime.TryParse(stFechaContrato, out dtFechaContrato);
                if (!DateTime.TryParse(stFechaContrato, out dtFechaContrato))
                {
                    addErrores("45", iIndice.ToString(), "Fecha de Ingreso Contrato: No es valida (Exp 2).", 1);
                }
            }
            else
            {
                addErrores("44", iIndice.ToString(), "Fecha de Ingreso Contrato: No puede estar Vacio.", 1);
            }
            return dtFechaContrato;
        }

        /// <summary>
        /// Validarcion de fecha inicio contrato vigente del empleado
        /// </summary>
        /// <param name="stFechaContratoVigente"></param>
        /// <param name="iIndice"></param>
        private void valFechaIncioContratoVigente(String stFechaContratoVigente, int iIndice)
        {
            if (!String.IsNullOrEmpty(stFechaContratoVigente))
            {
                DateTime dtFechaContrato;
                if (!DateTime.TryParse(stFechaContratoVigente, out dtFechaContrato))
                {
                    addErrores("45", iIndice.ToString(), "Fecha Inicio Contrato Vigente: No es valida (Exp 2).", 1);
                }
            }
            else
            {
                addErrores("45", iIndice.ToString(), "Fecha Inicio Contrato Vigente: No puede estar Vacio.", 1);
            }
        }

        /// <summary>
        /// Validacion Salario diario contrato del empleado
        /// </summary>
        /// <param name="stSalarioDiarioContrato"></param>
        /// <param name="iIndice"></param>
        private void valSalarioDiarioContrato(String stSalarioDiarioContrato, String stEsquema, DateTime dtFechaContrato, int iIndice, String stJornadaDeServicio, DataRow drEmpleado)
        {
            if (!String.IsNullOrEmpty(stSalarioDiarioContrato))
            {
                Decimal dcmSalarioContrato;
                if (!Decimal.TryParse(stSalarioDiarioContrato, out dcmSalarioContrato))
                {
                    addErrores("46", iIndice.ToString(), "Salario Diario Contrato: No es valido (Exp 2).", 1);
                }
                else
                {
                    if (stEsquema == "A" && dcmSalarioContrato > 0)
                    {
                        addErrores("46", iIndice.ToString(), "Tipo de Esquema = A, NO permite Salario Diario Contrato.", 1);
                    }
                    else if (stEsquema == "M" || stEsquema == "S")
                    {
                        decimal smgv = 0;
                        if (!dtFechaContrato.ToShortDateString().Contains("01/01/0001"))
                        {
                            stpSelSMGVTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelSMGV, dtFechaContrato);
                            if (dbSAICBPOCatalogosDataSet1.stpSelSMGV.Rows.Count > 0)
                            {
                                decimal.TryParse(dbSAICBPOCatalogosDataSet1.stpSelSMGV.Rows[0]["Monto"].ToString(), out smgv);
                                smgv = decimal.Round(smgv, 2);

                                if (stJornadaDeServicio.Contains("HORAS"))
                                {
                                    //if (dcmSalarioContrato <= 0 || dcmSalarioContrato > smgv)
                                    if (dcmSalarioContrato <= 0)
                                    {
                                        addErrores("46", iIndice.ToString(), "Salario Diario Contrato: Debe ser Mayor a 0 (Cero).", 1);
                                    }
                                }
                                else
                                {
                                    if (dcmSalarioContrato < smgv)
                                    {
                                        addErrores("46", iIndice.ToString(), "Salario Diario Contrato: No puede se menor al SMGV (" + smgv.ToString("#.##") + ")", 1);
                                    }
                                }
                            }
                            else
                            {
                                addErrores("45", iIndice.ToString(), "Fecha Contrato: No se tiene valor SMGV con la fecha contrato.", 1);
                            }
                        }
                        else
                        {
                            addErrores("45", iIndice.ToString(), "Fecha Contrato: Fecha Invalida para Obtener SMGV.", 1);
                        }
                    }
                }
            }
            else
            {
                addErrores("46", iIndice.ToString(), "Salario Diario Contrato: No puede estar Vacio.", 1);
            }
        }
        /// <summary>
        /// Validar el salario diariao integrado
        /// </summary>
        /// <param name="stSalarioDiarioIntegrado"></param>
        /// <param name="iIndice"></param>
        private void valSalarioDiarioIntegrado(String stSalarioDiarioIntegrado, String stEsquema, DateTime dtFechaContrato, String stSalarioDiarioContrato, int iIndice, String stJornadaDeServicio)
        {
            if (!String.IsNullOrEmpty(stSalarioDiarioIntegrado))
            {
                Decimal SDI;
                Decimal.TryParse(stSalarioDiarioIntegrado, out SDI);
                if (!Decimal.TryParse(stSalarioDiarioIntegrado, out SDI))
                {
                    addErrores("47", iIndice.ToString(), "Salario Diario Integrado: No es valido (Exp 2).", 1);
                }
                else
                {
                    if (stEsquema == "A" && SDI > 0)
                    {
                        addErrores("47", iIndice.ToString(), "Tipo de Esquema = A, NO permite Salario Diario Integrado.", 1);
                    }
                    else if (stEsquema == "S" || stEsquema == "M")
                    {
                        decimal SDFI = 0;
                        decimal SD = 0;
                        decimal dcmFactorIntegracion = 0;
                        decimal dcmUMA = 0;
                        decimal dcmUMA25 = 0;

                        if (stJornadaDeServicio.Contains("HORAS"))
                        {
                            SD = obtenerSMGV(dtFechaContrato);
                        }
                        else
                        {
                            decimal.TryParse(stSalarioDiarioContrato, out SD);
                        }

                        SDI = Decimal.Round(SDI, 2);
                        decimal.TryParse(stSalarioDiarioContrato, out SD);

                        dcmFactorIntegracion = obtenerFactorIntegracion(dcVacaciones.ToString(), dcPrimaVacacional.ToString(), dcAguinaldo.ToString());

                        SDFI = SD * dcmFactorIntegracion;
                        SDFI = decimal.Round(SDFI, 2);

                        dcmUMA = obtenerUMA(dtFechaContrato);
                        dcmUMA = decimal.Round(dcmUMA, 2);
                        dcmUMA25 = dcmUMA * 25;

                        if (SDFI > dcmUMA25)
                        {
                            if (SDI != dcmUMA25)
                            {
                                addErrores("47", iIndice.ToString(), "Salario Diario Integrado: Supera el calculo de 25 UMA's. (" + dcmUMA + ")", 1);
                            }
                        }
                        else
                        {
                            if (SDFI != SDI)
                            {
                                addErrores("47", iIndice.ToString(), "Salario Diario Integrado: Es diferente al SD * Factor de Integracion.(" + SDFI + ")", 1);
                            }
                        }

                        //SUMA = Decimal.Round(SUMA, 2);
                        //if (SDI != SUMA)
                        //{
                        //    addErrores("46", iIndice.ToString(), "Salario Diario Integrado: Es diferente al SD * Factor de Integracion.(" + SUMA + ")", 1);
                        //}
                        //else
                        //{
                        //    dcmUMA = obtenerUMA(dtFechaContrato);
                        //    dcmUMA = decimal.Round(dcmUMA, 2);
                        //    dcmUMA = dcmUMA * 25;
                        //    if (SDI > dcmUMA)
                        //    {
                        //        addErrores("46", iIndice.ToString(), "Salario Diario Integrado: Supera el calculo de 25 UMA's. (" + dcmUMA + ")", 1);
                        //    }
                        //}
                    }
                }
            }
            else
            {
                addErrores("47", iIndice.ToString(), "Salario Diario Integrado: No puede estar Vacio.", 1);
            }
        }
        /// <summary>
        /// validar COrreo Electronico del empleado
        /// </summary>
        /// <param name="stCorreo"></param>
        /// <param name="iIndice"></param>
        private void valCorreoElectronico(String stCorreo, int iIndice)
        {
            if (!String.IsNullOrEmpty(stCorreo))
            {
                if (!DSC.validarEmail(stCorreo))
                {
                    addErrores("48", iIndice.ToString(), "Correo Electronico: No es valido (Exp 2).", 1);
                }
            }
        }
        /// <summary>
        /// validar el tipo de esquema que tiene el emppleado.
        /// </summary>
        /// <param name="stEsquema"></param>
        /// <param name="iIndice"></param>
        /// <returns></returns>
        private Boolean valEsquema(String stEsquema, int iIndice)
        {
            Boolean baderaTipoEsquema = false;
            if (!String.IsNullOrEmpty(stEsquema))
            {
                if (stEsquema == "M" || stEsquema == "S" || stEsquema == "A")
                {
                    baderaTipoEsquema = true;
                }
                else
                {
                    addErrores("49", iIndice.ToString(), "Esquema: No es valido (Exp 1).", 1);
                }
            }
            else
            {
                addErrores("49", iIndice.ToString(), "Esquema: No puede estar Vacio.", 1);
            }

            return baderaTipoEsquema;
        }
        /// <summary>
        /// Validar la informacion confidencial del empleado.
        /// </summary>
        /// <param name="stInformacionConfidencial"></param>
        /// <param name="iIndice"></param>
        private void valInformacionConfidencial(String stInformacionConfidencial, int iIndice)
        {
            if (!String.IsNullOrEmpty(stInformacionConfidencial))
            {
                String stCaracteresEspecailes = String.Empty;
                stCaracteresEspecailes = DSC.contieneCaracteresEspeciales(stInformacionConfidencial, DSC.stCaracteresEspeciales_1);
                if (!String.IsNullOrEmpty(stCaracteresEspecailes))
                {
                    addErrores("50", iIndice.ToString(), "Informacion Cofidencial: Contiene caracteres especiales " + stCaracteresEspecailes, 1);
                }
            }
        }

        private void valCodigoPostal_DomicilioFiscal(String sCodigoPostal, int iIndice, String sNumColumnaEnPlantilla, String sTipoEsquema)
        {
            Boolean flagtaMuyBien = false;
            if (sTipoEsquema == "S" || sTipoEsquema == "M")
            {
                if (!String.IsNullOrEmpty(sCodigoPostal))
                {
                    flagtaMuyBien = true;
                }
                else
                {
                    addErrores(sNumColumnaEnPlantilla, iIndice.ToString(), "Codigo Postal Fiscal: Es Obligatorio", 1);
                }
            }
            else
            {
                if (!String.IsNullOrEmpty(sCodigoPostal))
                {
                    flagtaMuyBien = true;
                }
            }

            if (flagtaMuyBien)
            {
                String sResultado = String.Empty;
                String sDescEstado = String.Empty;
                int? idEstado = 0;

                stpSelValidarCodigoPostalTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelValidarCodigoPostal,
                    sCodigoPostal, ref idEstado,
                    ref sDescEstado,
                    ref sResultado);

                if (!String.IsNullOrEmpty(sResultado))
                {
                    addErrores(sNumColumnaEnPlantilla, iIndice.ToString(), sResultado, 1);
                }
            }
        }

        #endregion

        private void btnSolicitarEmpleados_Click(object sender, EventArgs e)
        {
            Boolean taMuyBien = false;
            int iCuantos = 0;
            splashScreenManager3.ShowWaitForm();

            if (miPreSolicitud.iTipoSolicitud == 1)
            {
                if (gridLookTenedoraSA.EditValue.ToString() != "vacio" && gridLookTenedoraSA.EditValue.ToString() != "-1")
                {
                    if (gridLookTenedoraSC.EditValue.ToString() != "vacio" && gridLookTenedoraSC.EditValue.ToString() != "-1")
                    {
                        if (gridLookCliente.EditValue.ToString() != "vacio" && gridLookCliente.EditValue.ToString() != "-1")
                        {
                            //DataTable dtempleados = DSC.deGridViewSelectedToDataTable(gridViewEmpleados);
                            DataTable dtTodosEmpleados = DSC.deGridViewaDataTable(gridViewEmpleados);

                            iCuantos = ContarEsquemas(dtTodosEmpleados);

                            if (iCuantos > 0 && gridLookTenedoraSA.Text.Contains("NO APLICA TENEDORA SA"))
                            {
                                if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                                XtraMessageBox.Show("El tipo de Empresa no permite empleados con Esquema tipo S y M."
                          , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                insertandoEmpleados(dtTodosEmpleados);
                            }
                        }
                        else
                        {
                            if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                            XtraMessageBox.Show("Seleccione un Cliente para Continuar."
                            , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            gridLookCliente.Focus();
                        }
                    }
                    else
                    {
                        if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                        XtraMessageBox.Show("Seleccione una Tenedora Excedente para continuar."
                       , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridLookTenedoraSC.Focus();
                    }
                }
                else
                {
                    if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                    XtraMessageBox.Show("Seleccione una Tenedora Sueldos para continuar."
                         , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridLookTenedoraSA.Focus();
                }

            }
            else if (miPreSolicitud.iTipoSolicitud == 2)
            {
                DataTable dtTodosEmpleados = DSC.deGridViewaDataTable(gridViewEmpleados);
                insertandoEmpleadosBaja(dtTodosEmpleados);
            }
            else if (miPreSolicitud.iTipoSolicitud == 4)
            {
                DataTable dtTodosEmpleados = DSC.deGridViewaDataTable(gridViewEmpleados);
                insertandoEmpleadosSalarios(dtTodosEmpleados);
            }

            if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
        }

        private void insertandoEmpleadosBaja(DataTable dtTodosEmpleados)
        {
            try
            {
                System.Threading.Thread.Sleep(500);
                splashScreenManager3.SetWaitFormCaption("Guardando Solicitud");
                int? iSolicitud = 0;
                int iContaEmpleados = 0;

                List<String> listEmpleadosIngresados = new List<string>();
                String rutaCarpetaSolicitud = sRuta_Ope_Bajas;

                queriesTableAdapter1.stpInsSolicitudAltaEmpleadosHeader(
                       Convert.ToInt32(gridLookTenedoraSA.EditValue),
                       Convert.ToInt32(2),
                       Convert.ToInt32(gridLookCliente.EditValue),
                       OperadorBD.OperadorGlobal.IdOperador,
                       OperadorBD.OperadorGlobal.NombreUsuario,
                       2, //Tipo de Alta 1 = ALTA 2 = BAJA
                       ref iSolicitud
                      );

                if (iSolicitud != 0 && iSolicitud != 99)
                {
                    idmiSolciitud = iSolicitud;
                    int iConta = 1;
                    rutaCarpetaSolicitud += iSolicitud;
                    DSC.CheckandCreateFolder(rutaCarpetaSolicitud);
                    foreach (DataRow empleado in dtTodosEmpleados.Rows)
                    {
                        System.Threading.Thread.Sleep(500);
                        String stmensaje = String.Empty;
                        splashScreenManager3.SetWaitFormDescription("Solicitud " + iSolicitud + " Insertando: " + iConta + " de " + dtTodosEmpleados.Rows.Count);
                        //
                        queriesTableAdapter1.stpInsBajaEmpleados(
                            iSolicitud,
                            Convert.ToInt32(empleado["IdEmpleado"].ToString()),
                            OperadorBD.OperadorGlobal.IdOperador,
                            Convert.ToDateTime(empleado["Fecha de Baja"].ToString()),
                            DSC.ObtenerIDofTable(dbSAICBPOCatalogosDataSet1.stpSelObtenerConceptosBaja, empleado["Motivo de Baja"].ToString(), 2),
                            empleado["Observaciones Baja"].ToString(),
                            stmensaje);
                        //
                        listEmpleadosIngresados.Add(empleado["IdEmpleado"].ToString());
                        iContaEmpleados++;
                        iConta++;
                    }

                    String stDatos = DSC.ConvertDataTableToString(dtTodosEmpleados, true);
                    DSC.CheckandCreateFolder(sRuta_Ope_Bajas + iSolicitud + @"\");
                    File.WriteAllText(sRuta_Ope_Bajas + @"\" + iSolicitud + @"\" + iSolicitud + ".txt", stDatos);

                    System.Threading.Thread.Sleep(500);
                    splashScreenManager3.SetWaitFormDescription("Solicitud Generada");

                    if (File.Exists(stRutaDocumentosExcel))
                    {
                        FileInfo unFile = new FileInfo(stRutaDocumentosExcel);
                        DSC.CheckandCreateFolder(sRuta_Ope_Bajas + iSolicitud + @"\");
                        unFile.CopyTo(sRuta_Ope_Bajas + iSolicitud + @"\Solcitud " + iSolicitud + " " + DSC.nombreAleatorio() + unFile.Extension);
                    }

                    if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                    XtraMessageBox.Show(Environment.NewLine + "Solicitud Generada con Exito" + Environment.NewLine + Environment.NewLine +
                      "Numero de Solicitud: " + iSolicitud + Environment.NewLine +
                      "Empleados Ingresados:" + iContaEmpleados + Environment.NewLine +
                      "Carpeta para Documentación: " + Environment.NewLine + sRuta_Ope_Bajas
                  , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnAbrirCarpeta.Enabled = true;
                    actulizarEmpleadoBajas(listEmpleadosIngresados, dtTodosEmpleados);

                    sRutaCarpeta = sRuta_Ope_Bajas + iSolicitud + @"\";
                }
                else
                {
                    if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                    XtraMessageBox.Show("No se puede generar Numero de Solicitud" + Environment.NewLine + "Exp-" + iSolicitud
                   , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                XtraMessageBox.Show("No se subir a los empleados:" + Environment.NewLine + ex
                    , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void insertandoEmpleadosSalarios(DataTable dtTodosEmpleados)
        {
            System.Threading.Thread.Sleep(500);
            splashScreenManager3.SetWaitFormCaption("Guardando Solicitud");
            int? iSolicitud = 0;
            int iContaEmpleados = 0;

            List<String> listEmpleadosSalarios = new List<String>();
            List<String> listEmpleadosConError = new List<String>();
            String rutaCarpetaSolicitudSalarios = sRuta_Ope_Salario;

            queriesTableAdapter1.stpInsSolicitudAltaEmpleadosHeader(
                   0,
                   0,
                   0,
                   OperadorBD.OperadorGlobal.IdOperador,
                   OperadorBD.OperadorGlobal.NombreUsuario,
                   4, //Salarios
                   ref iSolicitud
                  );


            if (iSolicitud != 0 && iSolicitud != 99)
            {
                idmiSolciitud = iSolicitud;
                int iConta = 1;
                rutaCarpetaSolicitudSalarios += iSolicitud + @"\";
                DSC.CheckandCreateFolder(rutaCarpetaSolicitudSalarios);

                foreach (DataRow empleado in dtTodosEmpleados.Rows)
                {
                    System.Threading.Thread.Sleep(500);
                    String stMensajeError = String.Empty;
                    splashScreenManager3.SetWaitFormDescription("Solicitud " + iSolicitud + " Insertando: " + iConta + " de " + dtTodosEmpleados.Rows.Count);

                    SolicitudSalarios oSolicitudSalarios = new SolicitudSalarios(empleado, true);

                    try
                    {
                        queriesTableAdapter1.stpInsSolicitudSalariosEmpleados_1(
                                       iSolicitud
                                       , oSolicitudSalarios.IdEmpleado
                                       , oSolicitudSalarios.SalarioDiarioContrato
                                       , oSolicitudSalarios.SalarioBaseDeCotizacion
                                       , oSolicitudSalarios.SalarioDiarioIntegrado
                                       , oSolicitudSalarios.ParteVariable
                                       , oSolicitudSalarios.FactorDeIntegracion
                                       , oSolicitudSalarios.stFechaDeAplicacion
                                       , oSolicitudSalarios.Vacaciones
                                       , oSolicitudSalarios.PrimaVacacional
                                       , oSolicitudSalarios.Aguinaldo
                                       , OperadorBD.OperadorGlobal.NombreUsuario
                                       , oSolicitudSalarios.UMA
                                       , ref stMensajeError);
                    }
                    catch (Exception ex)
                    {
                        stMensajeError = ex.Message;
                    }

                    if (!String.IsNullOrEmpty(stMensajeError))
                    {
                        listEmpleadosConError.Add("Error: " + iSolicitud + " en el empleado " + oSolicitudSalarios.IdEmpleado + " " + stMensajeError);
                    }

                    listEmpleadosSalarios.Add(oSolicitudSalarios.IdEmpleado.ToString());
                    iContaEmpleados++;
                    iConta++;
                }

                String stDatos = DSC.ConvertDataTableToString(dtTodosEmpleados, true);
                DSC.CheckandCreateFolder(sRuta_Ope_Salario + iSolicitud + @"\");
                File.WriteAllText(sRuta_Ope_Salario + @"\" + iSolicitud + @"\" + iSolicitud + ".txt", stDatos);

                System.Threading.Thread.Sleep(500);
                splashScreenManager3.SetWaitFormDescription("Solicitud Generada");

                if (File.Exists(stRutaDocumentosExcel))
                {
                    FileInfo unFile = new FileInfo(stRutaDocumentosExcel);
                    DSC.CheckandCreateFolder(sRuta_Ope_Salario + iSolicitud + @"\");
                    unFile.CopyTo(sRuta_Ope_Salario + iSolicitud + @"\Solcitud " + iSolicitud + " " + DSC.nombreAleatorio() + unFile.Extension);
                }

                if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                XtraMessageBox.Show(Environment.NewLine + "Solicitud Generada con Exito" + Environment.NewLine + Environment.NewLine +
                  "Numero de Solicitud: " + iSolicitud + Environment.NewLine +
                  "Empleados Ingresados:" + iContaEmpleados + Environment.NewLine +
                  "Carpeta para Documentación: " + Environment.NewLine + sRuta_Ope_Salario
              , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnAbrirCarpeta.Enabled = true;

                actulizarEmpleadoBajas(listEmpleadosSalarios, dtTodosEmpleados);
            }
        }

        private void actulizarEmpleadoBajas(List<String> listEmpleadosIngresados, DataTable dtEmpleados)
        {
            DataTable dtRes = dtEmpleados.Clone();
            try
            {
                var query = dtEmpleados.AsEnumerable()
                    .Where(r =>
                        !listEmpleadosIngresados.AsEnumerable().Any(w =>
                            w == r.Field<String>("IdEmpleado")));

                if (query.Count() > 0)
                {
                    dtRes = query.CopyToDataTable();
                }
            }
            catch (Exception ex)
            {
                if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                XtraMessageBox.Show("No se puede actualizar a los empleados, por favor suba nuevamente la plantilla." + Environment.NewLine + "Exp-" + ex.Message
                , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            pintarGridBajas(dtRes);
        }

        private String ObtenerTurno(TimeSpan horaIni, TimeSpan horaFin)
        {
            int iTurno = 1;
            String stTurno = string.Empty;
            TimeSpan horaIniTurno = new TimeSpan(06, 00, 00);
            TimeSpan horaFinTurno = new TimeSpan(19, 59, 00);

            TimeSpan horaIniTurnoNoc = new TimeSpan(20, 00, 00);
            TimeSpan horaFinTurnoNoc = new TimeSpan(5, 59, 00);

            if (horaIni >= horaIniTurno && horaFin <= horaFinTurno)
            {
                stTurno = "DIURNO";
            }
            else if (horaIni >= horaIniTurnoNoc && horaFin <= horaFinTurnoNoc)
            {
                stTurno = "NOCTURNO";
            }
            else
            {
                stTurno = "MIXTA";
            }

            iTurno = DSC.ObtenerIDofTable(dbSAICBPOCatalogosDataSet1.stpSelTurno, stTurno);
            if (iTurno != 2 && iTurno != 3 && iTurno != 4)
            {
                iTurno = 1;
                stTurno = "N/D";
            }

            return stTurno;
            //return iTurno;
        }

        /// <summary>
        /// Seleccionar todos los empleados del GridView
        /// </summar>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridViewEmpleados.SelectAll();
            lblRegistrosSeleccionados.Text = "Registros a Solicitar: " + gridViewEmpleados.SelectedRowsCount;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridViewEmpleados.RowCount; i++)
            {
                gridViewEmpleados.UnselectRow(i);
            }

            lblRegistrosSeleccionados.Text = "Registros a Solicitar: " + gridViewEmpleados.SelectedRowsCount;
        }

        private void GridEmpleados_Click(object sender, EventArgs e)
        {
            lblRegistrosSeleccionados.Text = "Registros a Solicitar: " + gridViewEmpleados.SelectedRowsCount;
        }

        private void rdPrestacionesAlaLey_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdPrestacionesAlaLey_Click(object sender, EventArgs e)
        {
            xtraInformacionContrato infoContrato = new xtraInformacionContrato(dcVacaciones, dcPrimaVacacional, dcAguinaldo);
            if (infoContrato.ShowDialog() == DialogResult.OK)
            {
                dcVacaciones = infoContrato.dc_Vacaciones;
                dcPrimaVacacional = infoContrato.dc_PrimaVacacional;
                dcAguinaldo = infoContrato.dc_Aguinaldo;
            }
            mensajeRadioInfoContrato();
        }

        private void rdContratoNormal_Click(object sender, EventArgs e)
        {
            dcVacaciones = 6.00M;
            dcPrimaVacacional = 25.00M;
            dcAguinaldo = 15.00M;
            mensajeRadioInfoContrato();
        }

        private void mensajeRadioInfoContrato()
        {
            defController.SetToolTip(rdPrestacionesAlaLey, "Vacaciones: " + dcVacaciones + " Días" + Environment.NewLine +
              "Prima Vacacional: " + dcPrimaVacacional + "%" + Environment.NewLine +
              "Aguinaldo: " + dcAguinaldo + " Días");
        }

        private void rdContratoNormal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gridLookTenedoraSA_EditValueChanged(object sender, EventArgs e)
        {

            this.Refresh();

            //if (gridLookTenedoraSC.Enabled == false)
            //{
            String stMatrizTendora;
            int idMatrizTendora;

            if (gridLookTenedoraSA.EditValue.ToString() != "vacio")
            {
                DataRow[] unrow = dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoGenericaTenedoraSA_1.Select("IdTenedora = '" + gridLookTenedoraSA.EditValue + "'");

                if (unrow.Count() > 0)
                {
                    int.TryParse(unrow[0].ItemArray[0].ToString(), out idMatrizTendora);

                    stpSelObtenerInfoGenericaTenedoraSC_1TableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoGenericaTenedoraSC_1, idMatrizTendora, true);

                    if (dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoGenericaTenedoraSC_1.Rows.Count > 0)
                    {
                        gridLookTenedoraSC.EditValue = dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoGenericaTenedoraSC_1.Rows[0]["IdTenedora"];
                    }
                }
            }
            //}
        }

        private void gridLookCliente_EditValueChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
            //DSC.ConvertExcelToDataTable(@"c:\Users\desarrollo03\Documents\SAIC\Alta de Usuario\Plantilla\Nueva Plantilla de Alta.xlsx", "Z");
        }

        private void tSBtnActualizar_Click(object sender, EventArgs e)
        {
            CargarInformacionVentana();
            CargarInformacionVentanaBajas();
        }



        private void btnAbrirCarpeta_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(sRutaCarpeta))
            {
                DSC.CheckandCreateFolder(sRutaCarpeta);
                Process.Start(sRutaCarpeta);
            }
        }

        /// <summary>
        /// Filtra la lista de tenedoras cuando todos los empleados con de tipo A (Alimentos)
        /// </summary>
        /// <param name="dtEmpleados"></param>
        private void ObtenerTenedorasPorEsquema(DataTable dtEmpleados)
        {
            int iCuantos = 0;
            iCuantos = ContarEsquemas(dtEmpleados);
            if (iCuantos == 0)
            {
                gridLookTenedoraSA.Enabled = false;
                gridLookTenedoraSC.Enabled = true;
                stpSelObtenerInfoGenericaTenedoraSC_1TableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoGenericaTenedoraSC_1, 1, false);
                stpSelObtenerInfoGenericaTenedoraSA_1TableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoGenericaTenedoraSA_1, false);
                System.Threading.Thread.Sleep(500);
                gridLookTenedoraSA.EditValue = 1;
            }
            else
            {
                gridLookTenedoraSA.Enabled = true;
                stpSelObtenerInfoGenericaTenedoraSA_1TableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelObtenerInfoGenericaTenedoraSA_1, true);
            }

            gridLookCliente.Enabled = true;
        }

        /// <summary>
        /// Cuenta el numero de empleados que contiene el esquema S y M
        /// </summary>
        /// <param name="dtEmpleados"></param>
        /// <returns></returns>
        private int ContarEsquemas(DataTable dtEmpleados)
        {
            int iCuantos = 0;

            iCuantos = dtEmpleados.Select("Esquema = 'M' OR Esquema = 'S'").Count();

            return iCuantos;
        }

        public decimal obtenerFactorIntegracion(String stVacaciones, String stPrimaVacacional, String stAguinaldo)
        {
            decimal dcmfIntegracion = 0;
            int iDiasAnio = 365;

            decimal dcmVacaciones;
            decimal dcmPrimaVacacional;
            decimal dcmDiasAguinaldo;
            decimal dscVacaPrima;
            decimal dscSuma;
            decimal dcmFactor;

            decimal.TryParse(stVacaciones, out dcmVacaciones);
            decimal.TryParse(stPrimaVacacional, out dcmPrimaVacacional);
            decimal.TryParse(stAguinaldo, out dcmDiasAguinaldo);

            dscVacaPrima = (dcmVacaciones * dcmPrimaVacacional) / 100;
            dscSuma = iDiasAnio + dcmDiasAguinaldo + dscVacaPrima;
            dcmFactor = dscSuma / iDiasAnio;
            dcmfIntegracion = Decimal.Round(dcmFactor, 4);

            return dcmfIntegracion;
        }

        public decimal obtenerUMA(DateTime dtFechaContrato)
        {
            decimal uma = 0;
            stpSelUMATableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelUMA, dtFechaContrato);
            if (dbSAICBPOCatalogosDataSet1.stpSelUMA.Rows.Count > 0)
            {
                decimal.TryParse(dbSAICBPOCatalogosDataSet1.stpSelUMA.Rows[0]["Monto"].ToString(), out uma);
                uma = decimal.Round(uma, 4);
            }
            return uma;
        }

        public decimal obtenerParteVariable(int idEmpleado, DateTime dtFechaAplicaion)
        {
            var result = actualizacionesIMSSTableAdapter1.fnObtenerParteVariableEmpleado(idEmpleado, dtFechaAplicaion, false, 0, 0);
            decimal dsParteVaribleEmpleado = 0;
            decimal.TryParse(result.ToString(), out dsParteVaribleEmpleado);

            return dsParteVaribleEmpleado;
        }

        public decimal obtenerSMGV(DateTime dtFechaContrato)
        {
            decimal sdgv = 0;
            stpSelSMGVTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelSMGV, dtFechaContrato);
            if (dbSAICBPOCatalogosDataSet1.stpSelSMGV.Rows.Count > 0)
            {
                decimal.TryParse(dbSAICBPOCatalogosDataSet1.stpSelSMGV.Rows[0]["Monto"].ToString(), out sdgv);
                sdgv = decimal.Round(sdgv, 2);
            }
            return sdgv;
        }

        /// <summary>
        /// Agregar Columna Tipo de ingreso para saber si es Nueva alta o Reingreso
        /// </summary>
        /// <param name="dtEmpleados"></param>
        /// <returns></returns>
        private DataTable agregarColumnas(DataTable dtEmpleados)
        {
            String stColumna1 = "Turno";
            String stColumna2 = "Vigencia Contrato";
            String stColumna3 = "Tipo de Ingreso";
            String stColumna4 = "idEmpleado";

            dtEmpleados.Columns.IndexOf(stColumna1);
            if (dtEmpleados.Columns.IndexOf(stColumna1) == -1)
            {
                dtEmpleados.Columns.Add(stColumna1, typeof(String));
            }
            if (dtEmpleados.Columns.IndexOf(stColumna2) == -1)
            {
                dtEmpleados.Columns.Add(stColumna2, typeof(DateTime));
            }
            if (dtEmpleados.Columns.IndexOf(stColumna3) == -1)
            {
                dtEmpleados.Columns.Add(stColumna3, typeof(String));
            }
            if (dtEmpleados.Columns.IndexOf(stColumna4) == -1)
            {
                dtEmpleados.Columns.Add(stColumna4, typeof(int));
            }

            return dtEmpleados;
        }

        private void valTipoIngresoEmpleado(int iTipoIngreso, DataRow drEmpleado)
        {
            if (iTipoIngreso == 1)
            {
                drEmpleado["Tipo de Ingreso"] = "ALTA";
            }
            else if (iTipoIngreso == 2)
            {
                drEmpleado["Tipo de Ingreso"] = "REINGRESO";
            }
            else if (iTipoIngreso != 1 || iTipoIngreso != 2)
            {
                drEmpleado["Tipo de Ingreso"] = "ERROR";
            }
        }

        private void valClaves(String stClaves, int iIndice)
        {
            stpSelClavesSolicitedesTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelClavesSolicitedes);

            String[] arrayClaves = stClaves.ToString().Split(',');

            arrayClaves = arrayClaves.Select(x => x.Trim().ToUpper()).ToArray();
            arrayClaves = arrayClaves.Distinct().ToArray();

            foreach (String item in arrayClaves)
            {
                if (!String.IsNullOrEmpty(item))
                {

                    int iExisteClave = (from x in dbSAICBPOCatalogosDataSet1.stpSelClavesSolicitedes.AsEnumerable()
                                        where x.Field<String>("Clave") == item
                                        select x).ToList().Count;

                    if (iExisteClave == 0)
                    {
                        addErrores("51", iIndice.ToString(), "Clave (" + item + "): " + "No existe o es Incorrecta, ", 1);
                    }
                }
            }

        }


        /// <summary>
        /// Autorizar el tipo de Alta del empleado.
        /// </summary>
        /// <param name="iTipoAlta"></param>
        /// <param name="iRow"></param>
        /// <param name="unRow"></param>
        /// <returns></returns>
        private Boolean AutorizarTipoAlta(int iTipoAlta, int iRow, DataRow unRow)
        {
            Boolean flagEstaMuybien = true;

            String[] arrayClaves = unRow["Claves"].ToString().Split(',');

            arrayClaves = arrayClaves.Select(x => x.Trim().ToUpper()).ToArray();
            arrayClaves = arrayClaves.Distinct().ToArray();

            if (iTipoAlta == 1)
            {
                if (arrayClaves.Where(x => x == "R").Count() == 1)
                {
                    addErrores("51", iRow.ToString(), "Tipo de Alta: No Requiere Autorización.", 1);
                    flagEstaMuybien = false;
                }
            }
            else if (iTipoAlta == 2)
            {
                if (arrayClaves.Where(x => x == "R").Count() == 0)
                {
                    addErrores("51", iRow.ToString(), "Tipo de Alta Reingreso: Requiere Autorizacion (R).", 1);
                    flagEstaMuybien = false;
                }
            }

            return flagEstaMuybien;
        }



        private void habiltarBotones()
        {
            if (AreaDeApertura.Contains("Catalogos"))
            {
                gridLookTenedoraSA.Enabled = false;
                gridLookTenedoraSC.Enabled = false;
                gridLookCliente.Enabled = false;
                btnSolicitarEmpleados.Enabled = false;
            }
            //OperadorBD.OperadorGlobal.AreaOperativa;
        }

        /// <summary>
        /// revisar si el empleado tiene solicitudes activas
        /// </summary>
        /// <param name="idEmpleado"></param>
        /// <param name="iRow"></param>
        /// <returns></returns>
        private Boolean RevisarSolicitudesActivasEmpleados(int idEmpleado, int iRow)
        {
            Boolean flagTaMuyBien = false;
            String stSolicitudes = String.Empty;

            stpSelObtenerSolicitudesDeEmpleadosActivasTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelObtenerSolicitudesDeEmpleadosActivas, idEmpleado);


            if (dbSAICBPOCatalogosDataSet1.stpSelObtenerSolicitudesDeEmpleadosActivas.Rows.Count == 0)
            {
                flagTaMuyBien = true;
            }
            else
            {
                foreach (DataRow unRow in dbSAICBPOCatalogosDataSet1.stpSelObtenerSolicitudesDeEmpleadosActivas.Rows)
                {
                    stSolicitudes += unRow["idSolicitud"].ToString() + ", ";
                }

                addErrores("1", iRow.ToString(), "Solicitud Activa: " + stSolicitudes, 1);
            }

            return flagTaMuyBien;
        }

    }
    public class preSolicitud
    {
        public int iTipoSolicitud = 0;
        public int idTenedora = 0;
        public String TenedoraNombreComercial = String.Empty;
        public int idCliente = 0;
        public String ClienteNombreComercial = String.Empty;
    }

    public class SolicitudSalarios
    {

        public SolicitudSalarios()
        {
            IdEmpleado = 0;
            ApellidoPaterno = String.Empty;
            ApellidoMaterno = String.Empty;
            Nombres = String.Empty;
            NSS = String.Empty;
            RFC = String.Empty;
            CURP = String.Empty;
            SalarioDiarioContrato = 0;
            SalarioBaseDeCotizacion = 0;
            SalarioDiarioIntegrado = 0;
            NombreCompletoEmpleado = String.Empty;
        }

        public SolicitudSalarios(DataRow unRow, Boolean flagpParaAltas)
        {
            //SolicitudSalarios oSolicitudSalarios = new SolicitudSalarios();
            if (flagpParaAltas)
            {
                int idEmpleado_ = 0;
                decimal SalarioDiarioContrato_ = 0;
                decimal SalarioBaseDeCotizacion_ = 0;
                decimal SalarioDiarioIntegrado_ = 0;
                decimal ParteVariable_ = 0;
                decimal Vacaciones_ = 0;
                decimal PrimaVacacional_ = 0;
                decimal Aguinaldo_ = 0;
                int AniosLaboradosEmpleado_ = 0;
                decimal FactorDeIntegracion_ = 0;
                decimal UMA_ = 0;

                DateTime dtFechaM = new DateTime();

                int.TryParse(unRow["IdEmpleado"].ToString(), out idEmpleado_);
                IdEmpleado = idEmpleado_;

                ApellidoPaterno = unRow["Apellido Paterno"].ToString();
                ApellidoMaterno = unRow["Apellido Materno"].ToString();
                Nombres = unRow["Nombres"].ToString();

                NombreCompletoEmpleado = ApellidoPaterno + " " + ApellidoMaterno + " " + Nombres;

                NSS = unRow["NSS"].ToString();
                RFC = unRow["RFC"].ToString();
                CURP = unRow["CURP"].ToString();

                decimal.TryParse(unRow["Salario Diario Nuevo"].ToString(), out SalarioDiarioContrato_);
                SalarioDiarioContrato = SalarioDiarioContrato_;

                decimal.TryParse(unRow["Salario Base de Cotizacion"].ToString(), out SalarioBaseDeCotizacion_);
                SalarioBaseDeCotizacion = SalarioBaseDeCotizacion_;

                decimal.TryParse(unRow["Salario Diario Integrado"].ToString(), out SalarioDiarioIntegrado_);
                SalarioDiarioIntegrado = SalarioDiarioIntegrado_;

                decimal.TryParse(unRow["Parte Variable"].ToString(), out ParteVariable_);
                ParteVariable = ParteVariable_;

                decimal.TryParse(unRow["UMA"].ToString(), out UMA_);
                UMA = UMA_;

                DateTime.TryParse(unRow["Fecha de Aplicacion"].ToString(), out dtFechaM);
                stFechaDeAplicacion = dtFechaM;

                decimal.TryParse(unRow["Vacaciones"].ToString(), out Vacaciones_);
                Vacaciones = Vacaciones_;

                decimal.TryParse(unRow["Prima Vacacional"].ToString(), out PrimaVacacional_);
                PrimaVacacional = PrimaVacacional_;

                decimal.TryParse(unRow["Aguinaldo"].ToString(), out Aguinaldo_);
                Aguinaldo = Aguinaldo_;

                int.TryParse(unRow["Años Laborados"].ToString(), out AniosLaboradosEmpleado_);
                AniosLaboradosEmpleado = AniosLaboradosEmpleado_;

                decimal.TryParse(unRow["Factor de Integracion"].ToString(), out FactorDeIntegracion_);
                FactorDeIntegracion = FactorDeIntegracion_;
            }
            else
            {
                int idEmpleado_ = 0;
                decimal SalarioDiarioContrato_ = 0;
                decimal SalarioDiarioBasedeCotizacion_ = 0;
                decimal SalarioDiarioIntegrado_ = 0;
                DateTime dtFechaM = new DateTime();

                int.TryParse(unRow["IdEmpleado"].ToString(), out idEmpleado_);
                IdEmpleado = idEmpleado_;

                NombreCompletoEmpleado = unRow["NombreEmpleadoCompleto"].ToString();

                NSS = unRow["NSS"].ToString();
                RFC = unRow["RFC"].ToString();
                CURP = unRow["CURP"].ToString();

                decimal.TryParse(unRow["SD"].ToString(), out SalarioDiarioContrato_);
                SalarioDiarioContrato = SalarioDiarioContrato_;
            }


            //return oSolicitudSalarios;
        }


        public int IdEmpleado { get; set; }
        public String ApellidoPaterno { get; set; }
        public String ApellidoMaterno { get; set; }
        public String Nombres { get; set; }
        public String NombreCompletoEmpleado { get; set; }
        public String NSS { get; set; }
        public String RFC { get; set; }
        public String CURP { get; set; }
        public decimal SDCEmpleado { get; set; }
        public decimal SalarioDiarioContrato { get; set; }
        public decimal SalarioBaseDeCotizacion { get; set; }
        public decimal SalarioDiarioIntegrado { get; set; }
        public decimal ParteVariable { get; set; }
        public DateTime stFechaDeAplicacion { get; set; }


        public decimal Vacaciones { get; set; }
        public decimal PrimaVacacional { get; set; }
        public decimal Aguinaldo { get; set; }
        public int? AniosLaboradosEmpleado { get; set; }
        public decimal FactorDeIntegracion { get; set; }
        public decimal UMA { get; set; }

    }
}