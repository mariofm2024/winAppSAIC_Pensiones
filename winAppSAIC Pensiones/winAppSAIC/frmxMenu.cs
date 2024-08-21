using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Security.Principal;
using compCatalogosSAIC;
using winAppSAIC.UtileriasLocal;
using System.Reflection;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using compSysAccesos;
using DevExpress.XtraBars.Helpers;
using System.Threading;

namespace winAppSAIC
{
    public partial class frmxMenu : DevExpress.XtraEditors.XtraForm
    {
        tools.dsc dsc = new tools.dsc();
        public frmxMenu()
        {
            InitializeComponent();
        }

        #region "Variables Globales"
        //variable globa que obtiene la informacion del Assembly
        private UtileriasLocal.AssemblyInfo entryAssemblyInfo = new UtileriasLocal.AssemblyInfo(Assembly.GetEntryAssembly());
        #endregion


        #region "Métodos Propios"
        /// <summary>
        /// Método ESTATICO que obtiene los valores de los botones con Derecho de Acceso para el Usuario
        /// </summary>
        /// <param name="mCurrentItem">Objeto Boton</param>
        /// <param name="dt">Datatable para realizar consultas con LINQ</param>
        /// <param name="objDAcceso">Objeto del tipo DerechosAcceso en dónde se almacena la información</param>
        private static void ObtenerInfoBotonMenu(BarItem mCurrentItem, DataTable dt, DerechosAcceso objDAcceso)
        {
            try
            {
                var query = from o in dt.AsEnumerable()
                            where o.Field<string>("ObjetoControl") == mCurrentItem.Name
                            select new
                            {
                                IdDerechosAcceso = o.Field<Int32>("IdDerechosAcceso"),
                                IdGrupo = o.Field<Int16>("IdGrupo"),
                                CveGrupo = o.Field<string>("CveGrupo"),
                                DescGrupo = o.Field<string>("DescGrupo"),
                                IdPantalla = o.Field<Int32>("IdPantalla"),
                                CvePantalla = o.Field<string>("CvePantalla"),
                                DescPantalla = o.Field<string>("DescPantalla"),
                                IdModuloApp = o.Field<Int16>("IdModuloApp"),
                                TipoPantalla = o.Field<string>("TipoPantalla"),
                                NameSpacePantalla = o.Field<string>("NameSpacePantalla"),
                                ObjetoControl = o.Field<string>("ObjetoControl"),
                                Consultar = o.Field<bool>("Consultar"),
                                Actualizar = o.Field<bool>("Actualizar"),
                                Insertar = o.Field<bool>("Insertar"),
                                Eliminar = o.Field<bool>("Eliminar"),
                                Habilitar = o.Field<bool>("Habilitar"),
                                IdOperador = o.Field<Int16>("IdOperador")
                            };

                //asignar los valores obtenidos en la consulta LINQ al objeto DerechosAcceso
                foreach (var od in query)
                {
                    objDAcceso.IdDerechosAcceso = od.IdDerechosAcceso;
                    objDAcceso.IdGrupo = od.IdGrupo;
                    objDAcceso.CveGrupo = od.CveGrupo;
                    objDAcceso.DescGrupo = od.DescGrupo;
                    objDAcceso.IdPantalla = od.IdPantalla;
                    objDAcceso.CvePantalla = od.CvePantalla;
                    objDAcceso.DescPantalla = od.DescPantalla;
                    objDAcceso.IdModuloApp = od.IdModuloApp;
                    objDAcceso.TipoPantalla = od.TipoPantalla;
                    objDAcceso.NameSpacePantalla = od.NameSpacePantalla;
                    objDAcceso.ObjetoControl = od.ObjetoControl;
                    objDAcceso.Consultar = od.Consultar;
                    objDAcceso.Actualizar = od.Actualizar;
                    objDAcceso.Insertar = od.Insertar;
                    objDAcceso.Eliminar = od.Eliminar;
                    objDAcceso.Habilitar = od.Habilitar;
                    objDAcceso.IdOperador = od.IdOperador;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Método que recorre todas las pestañas, grupo y botones del RibbonControl.
        /// Utilizado para habilitar o deshabilitar botones en base a los Derechos de Acceso.
        /// </summary>
        private void HabilitarBotonesOperador(Int16 pIdOperador)
        {
            BarItem mCurrentItem;
            BarSubItem mBarSubItem;
            DataTable dt;
            DerechosAcceso objDAcceso = new DerechosAcceso();
            try
            {
                //crear DataTable con los Derechos de Acceso por Operador
                dt = this.stpSelDerechosAccesoOperadorTableAdapter1.GetData(pIdOperador);

                //recorrer cada pestaña
                foreach (RibbonPage currentPage in this.rbcMenu.Pages)
                {
                    //recorrer cada grupo de botones de cada pestaña
                    foreach (RibbonPageGroup currentGroup in currentPage.Groups)
                    {
                        //recorrer cada boton de cada grupo
                        foreach (BarItemLink currentButton in currentGroup.ItemLinks)
                        {
                            mCurrentItem = currentButton.Item;  //asignar el boton actual
                            //Console.WriteLine(string.Format("{0} - {1} - {2} - {3} - {4}", currentPage.Text, currentGroup.Text, mCurrentItem.Caption, mCurrentItem.Name, mCurrentItem.GetType().FullName));

                            ObtenerInfoBotonMenu(mCurrentItem, dt, objDAcceso);

                            if (mCurrentItem.Name.Equals(objDAcceso.ObjetoControl))
                                mCurrentItem.Enabled = objDAcceso.Habilitar;
                            else
                            {
                                if (mCurrentItem.Name == "rbiSalir")
                                    mCurrentItem.Enabled = true;
                                else
                                    mCurrentItem.Enabled = false;
                            }
                            //if (mCurrentItem.GetType().FullName == "DevExpress.XtraBars.BarSubItem")
                            //{
                            //    mBarSubItem = (BarSubItem)mCurrentItem;
                            //    foreach (BarItemLink mSubLink in mBarSubItem.ItemLinks)
                            //    {
                            //        Console.WriteLine(string.Format("{0} - {1} - {2} - {3} - {4}", currentPage.Text, currentGroup.Text, mSubLink.Item.Caption, mSubLink.Item.Name, mSubLink.Item.GetType().FullName));
                            //    }
                            //}
                        }
                    }
                }
            }   //catch
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



        /// <summary>
        /// Método que muestra el Nombre del Servidor
        /// SQL Server activo
        /// </summary>
        /// <returns>Valor TRUE o FALSE</returns>
        private bool ActualizarInfoNombreServidor()
        {
            try
            {
                // Obtener el nombre del Servidor SQL Server activo
                this.stpSelNombreSQLServerConectadoTableAdapter.Fill(this.dbSAICBPOReportesDataSet.stpSelNombreSQLServerConectado);

                DataRow row = this.dbSAICBPOReportesDataSet.stpSelNombreSQLServerConectado.Rows[0];
                rbsbSQLServer.Caption = row[0].ToString();      //mostrar nombre del servidor SQL
                rbsbNombreBD.Caption = row[1].ToString();       //mostrar nombre BD
            }
            catch
            {
                return false;       //no se mostro correctamente la informacion porque no se tiene acceso a la BD
            }
            return true;        //si se mostro correctamente la informacion
        }

        /// <summary>
        /// Método que reinicia la aplicacion cuando se han modificado
        /// valores internos que afectan la información que se manipula
        /// </summary>
        private void ReiniciarAplicacion()
        {
            // Get the parameters/arguments passed to program if any 
            string arguments = string.Empty;
            string[] args = Environment.GetCommandLineArgs();
            for (int i = 1; i < args.Length; i++) // args[0] is always exe path/filename 
                arguments += args[i] + " ";

            // Restart current application, with same arguments/parameters 
            Application.Exit();
            System.Diagnostics.Process.Start(Application.ExecutablePath, arguments);
        }

        /// <summary>
        /// Validar y crear el directorio de salida, sino existe, 
        /// para los Layouts Bancarios. 
        /// </summary>
        private void ValidarCrearDirectoryLayout()
        {
            try
            {
                if (!Directory.Exists(@"C:\LAYOUTS"))       //si no existe el directorio
                {
                    Directory.CreateDirectory(@"C:\LAYOUTS");       //crear directorio
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método que muestra la pantalla de configuración de la conexion a BD
        /// </summary>
        private void MostrarPantallaConfiguracion()
        {
            frmConfiguracion objConfig = new frmConfiguracion("");
            objConfig.ShowDialog();     //mostrar pantalla
            objConfig.TopMost = true;       //mostrar al frente

            bool bFlag = objConfig.bFlagModificacionBD;     //obtener bandera cambios en BD

            if (bFlag)          //si se modificó la configuración de la BD entonces reiniciar aplicación
            {
                try
                {
                    ReiniciarAplicacion();      //reiniciar aplicacion
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion


        private void rbiEliminarMovsNomina_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cancelaciones.frmxEliminarNominas objEliminarRecibos = new Cancelaciones.frmxEliminarNominas();
            objEliminarRecibos.ShowDialog();    //mostrar pantalla Eliminar Nóminas
        }

        private void rbiControlRecibosFirmadosSueldos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmxControlRecibosFirmados objControlReciboFirmado = new frmxControlRecibosFirmados();
            objControlReciboFirmado.ShowDialog();       //mostrar pantalla
        }

        private void rbiControlRecibosFirmadosAlimentos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmxControlRecibosFirmadosAlimentos objControlReciboFirmadoAlimentos = new frmxControlRecibosFirmadosAlimentos();
            objControlReciboFirmadoAlimentos.ShowDialog();      //mostrar pantalla
        }

        private void rbiDetalleReporteNominaSA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Contablidad.frmxDesgloseReporteNominasSueldos objDesgloseReporteNominasSueldos = new Contablidad.frmxDesgloseReporteNominasSueldos();
            objDesgloseReporteNominasSueldos.ShowDialog();      //mostrar pantalla
        }

        private void rbiSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Application.Exit();     //terminar aplicación
            this.Close();
        }

        Thread demoThread;
        int iNumeroDeNotificaciones = 0;

        private void frmxMenu_Load(object sender, EventArgs e)
        {
            try
            {
                String stTema = String.Empty;
                stTema = dsc.obtenerTema();
                if (!String.IsNullOrEmpty(stTema))
                {
                    DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(stTema);
                }

                //rbiAdmonNominas.SuperTip = new DevExpress.Utils.SuperToolTip();
                //rbiAdmonNominas.SuperTip.Items.Add("Test");

                //asignar la pestaña default
                //rbcMenu.SelectedPage = rbpProcesosOperaciones;
                //rbcMenu.SelectedPage = rbpIMSS;
                rbcMenu.SelectedPage = rbpArchivo;

                //mostrar usuario que está usando la aplicacion
                //rbsbUsuario.Caption = WindowsIdentity.GetCurrent().Name;
                DevExpress.Utils.SuperToolTip SToolTipUsuario1 = new DevExpress.Utils.SuperToolTip();
                DevExpress.Utils.SuperToolTip SToolTipUsuario = new DevExpress.Utils.SuperToolTip();
                SToolTipUsuario.Items.Add("Nombre: " + OperadorBD.OperadorGlobal.NombreOperador + Environment.NewLine +
                    "Usuario: " + OperadorBD.OperadorGlobal.NombreUsuario + Environment.NewLine +
                    "Area: " + OperadorBD.OperadorGlobal.AreaOperativa + Environment.NewLine +
                    "Grupo:" + OperadorBD.OperadorGlobal.Grupo);

                SToolTipUsuario1.Items.Add(OperadorBD.OperadorGlobal.Grupo);

                rbsbUsuario.Caption = OperadorBD.OperadorGlobal.NombreUsuario;
                rbsbUsuario.SuperTip = SToolTipUsuario;

                rbsbGrupo.Caption = " | " + OperadorBD.OperadorGlobal.Grupo;
                rbsbGrupo.SuperTip = SToolTipUsuario1;

                //habilitar o deshabilitar botones por Operador
                HabilitarBotonesOperador(OperadorBD.OperadorGlobal.IdOperador);

                //obtiene informacion de la version del Archivo AssemblyInfo.cs, seccion [assembly: AssemblyFileVersion("1.1.0.105")]
                //Version ver = new Version(System.Windows.Forms.Application.ProductVersion);
                //modificar titulo pantalla
                this.Text = entryAssemblyInfo.Product;
                rbsbAppVersion.Caption = string.Format("{0}, Versión {1}", entryAssemblyInfo.ProductTitle, entryAssemblyInfo.Version);    //mostrar version de la aplicacion

                ValidarCrearDirectoryLayout();      //validar y crear directorio de salida Layouts Bancarios

                bool bFlagAccesoSQL = ActualizarInfoNombreServidor();     //Mostrar nombre Servidor SQL Server

                if (!bFlagAccesoSQL)        //si no se puede conectar
                    MostrarPantallaConfiguracion();     //Mostrar pantalla de configuracion BD

                this.stpSelTipoDocumentacionXOperadorTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelTipoDocumentacionXOperador, OperadorBD.OperadorGlobal.IdOperador);
                DataRow row = null;
                if (dbSAICBPOCatalogosDataSet.stpSelTipoDocumentacionXOperador.Count > 0)
                {
                    for (int I = 0; I < dbSAICBPOCatalogosDataSet.stpSelTipoDocumentacionXOperador.Count; I++)
                    {
                        BarButtonItem but = new BarButtonItem();
                        row = dbSAICBPOCatalogosDataSet.stpSelTipoDocumentacionXOperador.Rows[I];
                        but.Caption = row[1].ToString();
                        but.Name = "btn" + row[0].ToString();
                        but.ItemClick += barButtonItem12_ItemClick;
                        rbiDocumentos1.AddItem(but);
                    }
                }


                //iNumeroDeNotificaciones = ObtenerCuentasNotificaciones();
                //ObtenerNotificacionesOperador();

                //stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "NOTIFICACIONES");

                //if (dbSAICBPOValidacionDataSet1.stpSelParametro.Rows.Count > 0)
                //{
                //    int iValorDeEspera;
                //    int.TryParse(dbSAICBPOValidacionDataSet1.stpSelParametro.Rows[0]["ValorParametro"].ToString(), out iValorDeEspera);

                //    if (iValorDeEspera > 0)
                //    {
                //        demoThread = new Thread(new ThreadStart(() => ObtenerRevisarNotificaciones(iValorDeEspera)));
                //        demoThread.IsBackground = true;
                //        demoThread.Start();
                //    }
                //}
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbiOpcionesConfiguracion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MostrarPantallaConfiguracion();     //Mostrar pantalla de configuracion BD
        }

        private void rbiAcercaSistema_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAcercaSistema objAcerca = new frmAcercaSistema();
            objAcerca.ShowDialog();     //mostrar acerca del sistema
        }

        private void rbiDetalleReporteNominaSC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Contablidad.frmxDesgloseReporteNominasAlimentos objDesgloseReporteNominasAlimentos = new Contablidad.frmxDesgloseReporteNominasAlimentos();
            objDesgloseReporteNominasAlimentos.ShowDialog();      //mostrar pantalla
        }

        private void rbiAdmonNominas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmxImprimirRecibos objImprimirRecibos = new frmxImprimirRecibos();
            objImprimirRecibos.ShowDialog();        //mostrar pantalla
        }

        private void rbiConsultaNominasCanceladas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmxDesgloseNominasCanceladas objVisualizarNominasCanceladas = new frmxDesgloseNominasCanceladas();
            objVisualizarNominasCanceladas.ShowDialog();    //mostrar pantalla
        }

        private void rbiCancelacionCierreNominaContabilizada_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Contablidad.frmxCancelarCierreNominaContable objCancelacionCierre = new Contablidad.frmxCancelarCierreNominaContable();

            objCancelacionCierre.ShowDialog();      //mostrar pantalla
        }

        private void rbiAltaCuenta_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Tesoreria.frmxAltaCuentaBanco objAltaCuentaBanco = new Tesoreria.frmxAltaCuentaBanco();

            objAltaCuentaBanco.ShowDialog();        //mostrar pantalla
        }

        private void rbiEmisionCheques_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Tesoreria.frmxEmisionCheques objEmisionCheques = new Tesoreria.frmxEmisionCheques() { ModuloOperativo = "OPER" /*usuario = operaciones*/ };
            objEmisionCheques.ShowDialog();     //mostrar pantalla
        }

        private void rbiControlIMSSOperaciones_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IMSS.frmxSolicitudTramiteIMSSOperaciones objControlIMSS = new IMSS.frmxSolicitudTramiteIMSSOperaciones();

            objControlIMSS.ShowDialog();
        }

        private void rbiDepositos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Tesoreria.frmxControlTransaccionBanco objControlBanco = new Tesoreria.frmxControlTransaccionBanco();

            objControlBanco.ModuloOperativo = "TESO";       //TESORERO
            objControlBanco.ShowDialog();   //mostrar pantalla
        }

        private void rbiConciliacion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Tesoreria.frmxConciliacionBanco objConciliacion = new Tesoreria.frmxConciliacionBanco();

            objConciliacion.ShowDialog();       //mostrar pantalla
        }

        private void rbiAsignarNomina2CFDI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NominaCFDI.frmxAsignarNomina2XMLCFDI objAsignarXML = new NominaCFDI.frmxAsignarNomina2XMLCFDI(true) { filtraIdLoteCargaNomina = UtileriasLocal.Constantes.FiltraPorIdLoteCargaNomina.No, pIdLoteCargaNomina = 0 /*pasar el No. version CFDI*/ };
            objAsignarXML.ShowDialog();     //mostrar pantalla
        }

        private void rbiReporteTimbradosCFDI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Mostrar pantalla en base al TipoPerfil que tiene el Usuario
            if (rbcMenu.SelectedPage == rbpProcesosOperaciones)       //pestaña Operaciones
            {
                NominaCFDI.frmControlRecibosTimbradosCFDI objRecibosTimbradosCFDI = new NominaCFDI.frmControlRecibosTimbradosCFDI() { tipoPerfil = Constantes.TipoPerfil.Operacion };
                objRecibosTimbradosCFDI.ShowDialog();       //mostrar pantalla
            }
            else if (rbcMenu.SelectedPage == rbpProcesosContabilidad)       //pestaña Contabilidad
            {
                NominaCFDI.frmControlRecibosTimbradosCFDI objRecibosTimbradosCFDI = new NominaCFDI.frmControlRecibosTimbradosCFDI() { tipoPerfil = Constantes.TipoPerfil.Contabilidad };
                objRecibosTimbradosCFDI.ShowDialog();       //mostrar pantalla
            }
        }

        private void rbiModificacionInfoEmpleado_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Mostrar pantalla en base al TipoPerfil que tiene el Usuario
            if (rbcMenu.SelectedPage == rbpCatalogos)       //pestaña Catalogos
            {
                Catalogos.frmxModificacionEmpleados objModificacionEmpleado = new Catalogos.frmxModificacionEmpleados(0, false, false, true, true, true, 0) { tipoOperacion = Constantes.TipoOperacion.ModificacionEmpleado, tipoPerfil = Constantes.TipoPerfil.Operacion };
                objModificacionEmpleado.ShowDialog();       //mostrar pantalla
            }
            else if (rbcMenu.SelectedPage == rbpJuridico)       //pestaña Juridico
            {
                Catalogos.frmxModificacionEmpleados objModificacionEmpleado = new Catalogos.frmxModificacionEmpleados(0, false, false, true, true, true, 0) { tipoOperacion = Constantes.TipoOperacion.ModificacionEmpleado, tipoPerfil = Constantes.TipoPerfil.Juridico };
                objModificacionEmpleado.ShowDialog();       //mostrar pantalla
            }
        }

        private void rbiCancelaTimbradoXMLCFDI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NominaCFDI.frmxCancelarXMLCFDI objCancelarCFDI = new NominaCFDI.frmxCancelarXMLCFDI();

            objCancelarCFDI.ShowDialog();       //mostrar pantalla
        }

        private void rbiListadoSolicitudesTramiteIMSS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IMSS.frmxListadoSolicitudTramiteIMSS objListadoSolicitudTramiteIMSS = new IMSS.frmxListadoSolicitudTramiteIMSS();
            objListadoSolicitudTramiteIMSS.ShowDialog();
        }

        private void rbiMonitoreoSolicitudCancelacionNominas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Contablidad.frmxMonitoreoSolicitudCancelacionNominas objMonitoreoCancelacion = new Contablidad.frmxMonitoreoSolicitudCancelacionNominas();

            objMonitoreoCancelacion.ShowDialog();   //mostrar pantalla
        }

        private void rbiGenerarXLSTimbreFacil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //obtener No. de Version CFDI
            string strVersionCFDI = this.validacionesGeneralTableAdapter1.ObtenerValorParametro("VERSION_CFDI").ToString();

            if (strVersionCFDI.Equals("1.0"))
            {
                NominaCFDITimbreFacil.frmxAsignarNomina2XMLCFDITimbreFacil objGenerarXLS = new NominaCFDITimbreFacil.frmxAsignarNomina2XMLCFDITimbreFacil();

                objGenerarXLS.ShowDialog();     //mostrar pantalla
            }
            else
            {
                NominaCFDITimbreFacil.frmxAsignarNomina2XMLCFDITimbreFacilv12 objGenerarXLS = new NominaCFDITimbreFacil.frmxAsignarNomina2XMLCFDITimbreFacilv12() { Tag = strVersionCFDI.ToString() };

                objGenerarXLS.ShowDialog();     //mostrar pantalla
            }
        }

        private void btnSolicitarCancelacionNomina_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cancelaciones.frmxSolicitudCancelacionNomina objSolicitudCancelacionNomina = new Cancelaciones.frmxSolicitudCancelacionNomina();

            objSolicitudCancelacionNomina.ShowDialog();     //mostrar pantalla
        }

        private void rbiCatActividadComercial_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Catalogos.frmxActividadComercial objActividadComercial = new Catalogos.frmxActividadComercial();
            objActividadComercial.ShowDialog();     //mostrar pantalla
        }

        private void rbiCatProductos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Catalogos.frmxProductos objProductos = new Catalogos.frmxProductos();
            objProductos.ShowDialog();      //mostrar pantalla
        }

        private void rbiCatPromotores_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Catalogos.frmxPromotores objPromotores = new Catalogos.frmxPromotores();
            objPromotores.ShowDialog();     //mostrar pantalla
        }

        private void rbiCatClientes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Catalogos.frmxClientes objClientes = new Catalogos.frmxClientes();
            objClientes.ShowDialog();       //mostrar pantalla
        }

        private void rbiCatSector_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Catalogos.frmxSectores objSectores = new Catalogos.frmxSectores();
            objSectores.ShowDialog();       //mostrar pantalla
        }

        private void rbiSolicitudChequesMasivos_ItemClick(object sender, ItemClickEventArgs e)
        {
            Tesoreria.frmxGenerarSolicitudChequesMasivos objForm = new Tesoreria.frmxGenerarSolicitudChequesMasivos();
            objForm.ShowDialog();       //mostrar pantalla
        }

        private void rbiMonitoreoSolicitudChequesMasivos_ItemClick(object sender, ItemClickEventArgs e)
        {
            Tesoreria.frmxMonitoreoSolicitudChequesMasivos objForm = new Tesoreria.frmxMonitoreoSolicitudChequesMasivos();
            objForm.ShowDialog();       //mostrar pantalla
        }

        private void rbiCatMatrizTenedora_ItemClick(object sender, ItemClickEventArgs e)
        {
            Catalogos.frmxMatrizTenedora objForm = new Catalogos.frmxMatrizTenedora();
            objForm.ShowDialog();   //mostrar pantalla
        }

        private void rbiCatTenedora_ItemClick(object sender, ItemClickEventArgs e)
        {
            Catalogos.frmxTenedora objForm = new Catalogos.frmxTenedora();
            objForm.ShowDialog();   //mostrar pantalla
        }

        private void rbiGenerales_ItemClick(object sender, ItemClickEventArgs e)
        {
            Catalogos.frmxCatalogosGenerales objForm = new Catalogos.frmxCatalogosGenerales();
            objForm.ShowDialog();   //mostrar pantalla
        }

        private void rbiSolicitudChequesEspeciales_ItemClick(object sender, ItemClickEventArgs e)
        {
            Tesoreria.frmxGenerarSolicitudChequesMasivosEspeciales objForm = new Tesoreria.frmxGenerarSolicitudChequesMasivosEspeciales();
            objForm.ShowDialog();       //mostrar pantalla
        }


        private void rbiControlEmisionRecibosCFDI_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            NominaCFDI.frmxControlEmisionRecibosCFDI objControlEmisionRecibosCFDI = new NominaCFDI.frmxControlEmisionRecibosCFDI();
            objControlEmisionRecibosCFDI.ShowDialog();
        }

        private void rbiControlSeguridad_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Seguridad.frmxControlSeguridad objForm = new Seguridad.frmxControlSeguridad();
                objForm.ShowDialog();       //mostrar pantalla
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbiModificacionInfoEmpleadoOperador_ItemClick(object sender, ItemClickEventArgs e)
        {
            OperadoresM.frmxModificacionEmpleadosOperador objForm = new OperadoresM.frmxModificacionEmpleadosOperador();
            objForm.ShowDialog();       //mostrar pantalla
        }

        private void rbiCancelarRegistroNomina_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cancelaciones.frmxEliminarRegistrosNomina objForm = new Cancelaciones.frmxEliminarRegistrosNomina();
            objForm.ShowDialog();       //mostrar pantalla
        }

        private void rbiMisSolicitudesCheque_ItemClick(object sender, ItemClickEventArgs e)
        {
            Tesoreria.frmxReporteCheques obj = new Tesoreria.frmxReporteCheques();
            obj.iTipoPantalla = 3;
            obj.ShowDialog();
        }

        private void rbiModificacionInfoEmpleadoINFO_ItemClick(object sender, ItemClickEventArgs e)
        {
            IMSS.frmxModificacionEmpleadosIMSSINFONAVIT objModificacionEmpleado = new IMSS.frmxModificacionEmpleadosIMSSINFONAVIT()
            {
                tipoOperacion = Constantes.TipoOperacion.ModificacionEmpleado,
                tipoPerfil = Constantes.TipoPerfil.IMSS
            };
            objModificacionEmpleado.ShowDialog();       //mostrar pantalla
        }

        private void rbiModificacionInfoEmpleadoSeguro_ItemClick(object sender, ItemClickEventArgs e)
        {
            Seguros.frmxModificacionEmpleadosSeguros objForm = new Seguros.frmxModificacionEmpleadosSeguros();
            objForm.ShowDialog();       //mostrar pantalla
        }

        private void rbiCatalogoPoliza_ItemClick(object sender, ItemClickEventArgs e)
        {
            Seguros.frmxPolizas objForm = new Seguros.frmxPolizas();
            objForm.ShowDialog();       //mostrar pantalla
        }

        private void rbiReporteCheque_ItemClick(object sender, ItemClickEventArgs e)
        {
            Tesoreria.frmxReporteCheques obj = new Tesoreria.frmxReporteCheques();
            obj.iTipoPantalla = 0;
            obj.ShowDialog();
        }

        private void btnAltaEmpleados_ItemClick(object sender, ItemClickEventArgs e)
        {
            OperadoresM.XtraAltaEmpleados fxAltaEmpleados = new OperadoresM.XtraAltaEmpleados("Operaciones");
            fxAltaEmpleados.ShowDialog();

            //Boolean bandera = false;
            ////fxAltaEmpleados.TopLevel = false;
            ////panelPrincipal.Controls.Clear();
            ////panelPrincipal.Controls.Add(fxAltaEmpleados);
            ////panelPrincipal.Tag = fxAltaEmpleados;
            ////fxAltaEmpleados.Location = new Point(this.Width / 2 - fxAltaEmpleados.Width / 2, 50);
            ////fxAltaEmpleados.Show();

            //if (panelControlMenu.Controls.Count > 0)
            //{
            //    foreach (Control item in panelControlMenu.Controls)
            //    {
            //        if (item.Name == fxAltaEmpleados.Name)
            //        {
            //            bandera = true;
            //            break;
            //        }
            //    }
            //}

            //if (!bandera)
            //{
            //    fxAltaEmpleados.TopLevel = false;
            //    fxAltaEmpleados.Refresh();
            //    panelControlMenu.Controls.Add(fxAltaEmpleados);
            //    fxAltaEmpleados.Tag = fxAltaEmpleados;
            //    fxAltaEmpleados.Location = new Point(this.Width / 2 - fxAltaEmpleados.Width / 2, 50);
            //    fxAltaEmpleados.Show();
            //}
        }

        private void btnControlVersionesAlta_ItemClick(object sender, ItemClickEventArgs e)
        {
            Versiones.frmxControlVersionesAltaEmpleados moduloVersion = new Versiones.frmxControlVersionesAltaEmpleados();
            moduloVersion.ShowDialog();
        }

        private void btnSolicitudAltaEmpleados_ItemClick(object sender, ItemClickEventArgs e)
        {
            OperadoresM.frmxMonitoreoSolicitudesAreas monitoreoSolicitudes = new OperadoresM.frmxMonitoreoSolicitudesAreas("IMSS", panelControlMenu, 2);
            //monitoreoSolicitudes.TopLevel = false;
            //panelControlMenu.Controls.Clear();
            //panelControlMenu.Controls.Add(monitoreoSolicitudes);
            //panelControlMenu.Tag = monitoreoSolicitudes;
            //monitoreoSolicitudes.Location = new Point(this.Width / 2 - monitoreoSolicitudes.Width / 2, 50);
            monitoreoSolicitudes.ShowDialog();
        }

        private void btnSolicitudAltaEmpleadosOperaciones_ItemClick(object sender, ItemClickEventArgs e)
        {
            OperadoresM.XtraMonitoreoSolicitudesOperaciones MonitoreoSolicitudes = new OperadoresM.XtraMonitoreoSolicitudesOperaciones(0);
            MonitoreoSolicitudes.ShowDialog();

            //Boolean bandera = false;
            //if (panelControlMenu.Controls.Count > 0)
            //{
            //    foreach (Control item in panelControlMenu.Controls)
            //    {
            //        if (item.Name == MonitoreoSolicitudes.Name)
            //        {
            //            bandera = true;
            //            break;
            //        }
            //    }
            //}

            //if (!bandera)
            //{
            //    MonitoreoSolicitudes.TopLevel = false;
            //    MonitoreoSolicitudes.Refresh();
            //    panelControlMenu.Controls.Add(MonitoreoSolicitudes);
            //    MonitoreoSolicitudes.Tag = MonitoreoSolicitudes;
            //    MonitoreoSolicitudes.Location = new Point(this.Width / 2 - MonitoreoSolicitudes.Width / 2, 50);
            //    MonitoreoSolicitudes.Show();
            //}
        }

        private void btnSolicitudAltaEmpleadosTersoreria_ItemClick(object sender, ItemClickEventArgs e)
        {
            OperadoresM.frmxMonitoreoSolicitudesAreas monitoreoSolicitudes = new OperadoresM.frmxMonitoreoSolicitudesAreas("TESORERIA", panelControlMenu, 4);
            monitoreoSolicitudes.ShowDialog();

            //monitoreoSolicitudes.TopLevel = false;
            //panelControlMenu.Controls.Clear();
            //panelControlMenu.Controls.Add(monitoreoSolicitudes);
            //panelControlMenu.Tag = monitoreoSolicitudes;
            //monitoreoSolicitudes.Location = new Point(this.Width / 2 - monitoreoSolicitudes.Width / 2, 50);
            //monitoreoSolicitudes.Show();
        }

        private void btnSolicitudeAltaEmpleadosJuridico_ItemClick(object sender, ItemClickEventArgs e)
        {
            OperadoresM.frmxMonitoreoSolicitudesAreas monitoreoSolicitudes = new OperadoresM.frmxMonitoreoSolicitudesAreas("JURIDICO", panelControlMenu, 3);
            monitoreoSolicitudes.ShowDialog();

            //monitoreoSolicitudes.TopLevel = false;
            //panelControlMenu.Controls.Clear();
            //panelControlMenu.Controls.Add(monitoreoSolicitudes);
            //panelControlMenu.Tag = monitoreoSolicitudes;
            //monitoreoSolicitudes.Location = new Point(this.Width / 2 - monitoreoSolicitudes.Width / 2, 50);
            //monitoreoSolicitudes.Show();
        }

        private void frmxMenu_ClientSizeChanged(object sender, EventArgs e)
        {
            int iAnchoFormulario = this.Width;
            int iLargoFormulario = this.Height;
            panelControlMenu.Width = iAnchoFormulario - 35;
            panelControlMenu.Height = iLargoFormulario - 200;
            Point p = new Point(70, 122);
            panelControlMenu.PointToScreen(p);
        }

        private void btnTemas_ItemClick(object sender, ItemClickEventArgs e)
        {
            Seguridad.frmxTemas formTemas = new Seguridad.frmxTemas();
            formTemas.ShowDialog();
            //formTemas.TopLevel = false;
            //panelControlMenu.Controls.Clear();
            //panelControlMenu.Controls.Add(formTemas);
            //panelControlMenu.Tag = formTemas;
        }

        private void toolboxControl1_Click(object sender, EventArgs e)
        {

        }

        private void toolboxControl1_ItemClick(object sender, DevExpress.XtraToolbox.ToolboxItemClickEventArgs e)
        {
            MessageBox.Show(String.Format("Click en: {0}", e.Item.Caption));
        }

        private void bButtonSolicitudesAlta_ItemClick(object sender, ItemClickEventArgs e)
        {
            Administracion.XtraMonitoreoAltas monitoreoAltas = new Administracion.XtraMonitoreoAltas();
            monitoreoAltas.ShowDialog();
        }

        private void rbiFirmantesContratos_ItemClick(object sender, ItemClickEventArgs e)
        {
            Catalogos.frmxFirmantes firmantes = new Catalogos.frmxFirmantes();
            firmantes.ShowDialog();

            //firmantes.TopLevel = false;
            //panelControlMenu.Controls.Clear();
            //panelControlMenu.Controls.Add(firmantes);
            //panelControlMenu.Tag = firmantes;
            //firmantes.Show();
        }

        private void btnCierreNomina1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Contablidad.frmxCierreNominaMasivo CerrarNominas = new Contablidad.frmxCierreNominaMasivo();
            CerrarNominas.ShowDialog();

            //CerrarNominas.TopLevel = false;
            //panelControlMenu.Controls.Clear();
            //panelControlMenu.Controls.Add(CerrarNominas);
            //panelControlMenu.Tag = CerrarNominas;
            //CerrarNominas.Show();
        }

        private void rbiCatMatrizClientes_ItemClick(object sender, ItemClickEventArgs e)
        {
            Catalogos.frmxClientesMatriz objMCliente = new Catalogos.frmxClientesMatriz();
            objMCliente.ShowDialog();
        }

        private void rbiCuentaBancoCliente_ItemClick(object sender, ItemClickEventArgs e)
        {
            Catalogos.frmxCuentaBanco objMCliente = new Catalogos.frmxCuentaBanco();
            objMCliente.ShowDialog();
        }

        private void rbiModificarRecuperacion_ItemClick(object sender, ItemClickEventArgs e)
        {
            IMSS.frmActualizarMontosRecup objMCliente = new IMSS.frmActualizarMontosRecup();
            objMCliente.ShowDialog();
        }

        private void rbiModificarSDI_ItemClick(object sender, ItemClickEventArgs e)
        {
            IMSS.frmActualizarSBC objMCliente = new IMSS.frmActualizarSBC("IMSS");
            objMCliente.ShowDialog();
        }

        private void rbiControlOperaciones_ItemClick(object sender, ItemClickEventArgs e)
        {
            ControlOperaciones.frmxAdmonControlOperaciones objMCliente = new ControlOperaciones.frmxAdmonControlOperaciones();
            objMCliente.ShowDialog();
        }

        private void rbiConceptoFronting_ItemClick(object sender, ItemClickEventArgs e)
        {
            Facturas.Catalogos.frmConceptoTenedora objConc = new Facturas.Catalogos.frmConceptoTenedora();
            objConc.ShowDialog();
        }

        private void rbiConceptoCliente_ItemClick(object sender, ItemClickEventArgs e)
        {
            Facturas.Catalogos.frmConceptoTenedoraBeneficiario objConcepto = new Facturas.Catalogos.frmConceptoTenedoraBeneficiario();
            objConcepto.ShowDialog();
        }

        private void rbiSolicitudFactura_ItemClick(object sender, ItemClickEventArgs e)
        {
            Facturas.frmSolicitudFactura objConcepto = new Facturas.frmSolicitudFactura();
            objConcepto.ShowDialog();
        }

        private void rbiSolicitudesFactura_ItemClick(object sender, ItemClickEventArgs e)
        {
            Facturas.frmMonitoreoFacturas objConcepto = new Facturas.frmMonitoreoFacturas();
            objConcepto.ShowDialog();
        }

        private void rbiAdministrarFacturas_ItemClick(object sender, ItemClickEventArgs e)
        {
            Facturas.frmAdmonFacturas objConcepto = new Facturas.frmAdmonFacturas();
            objConcepto.ShowDialog();
        }

        private void rbiTimbrarContabilizar_ItemClick(object sender, ItemClickEventArgs e)
        {
            Facturas.frmAdmonFacturasFC objMCliente = new Facturas.frmAdmonFacturasFC();
            objMCliente.ShowDialog();
        }

        private void btnFacturasCanceladas_ItemClick(object sender, ItemClickEventArgs e)
        {
            Facturas.frmVisualiarFacturasCanceladas objcli = new Facturas.frmVisualiarFacturasCanceladas();
            objcli.ShowDialog();
        }

        private void rbiVisualizarFacturasTimbradas_ItemClick(object sender, ItemClickEventArgs e)
        {
            Facturas.frmVisualiarFacturasTimbradas objMCliente = new Facturas.frmVisualiarFacturasTimbradas();
            objMCliente.ShowDialog();
        }

        private void rbiDocumentos_EditValueChanged(object sender, EventArgs e)
        {
            if (rbiDocumentos.EditValue != null && rbiDocumentos.EditValue.ToString() != "-1")
            {
                tools.dsc dsc = new tools.dsc();
                String stRutaArchivo = dsc.stRutaSAIC + @"Plantillas\";
                OperadoresM.XtraAltaEmpleados objAltaEmp = new OperadoresM.XtraAltaEmpleados("");
                objAltaEmp.descargarPlantillaAltaEmpleados(Convert.ToInt32(rbiDocumentos.EditValue), stRutaArchivo);
            }
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            string bt = e.Item.Name;
            if (bt != null)
            {
                tools.dsc dsc = new tools.dsc();
                String stRutaArchivo = dsc.stRutaSAIC + @"Plantillas\";
                OperadoresM.XtraAltaEmpleados objAltaEmp = new OperadoresM.XtraAltaEmpleados("");
                objAltaEmp.descargarPlantillaAltaEmpleados(Convert.ToInt32(bt.Replace("btn", "")), stRutaArchivo);
            }
        }

        private void btnActualizar_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                splashScreenManager4.ShowWaitForm();
                splashScreenManager4.SetWaitFormCaption("Espere");
                splashScreenManager4.SetWaitFormDescription("Cargando Perfil");
                System.Threading.Thread.Sleep(2000);
                HabilitarBotonesOperador(OperadorBD.OperadorGlobal.IdOperador);

                if (splashScreenManager4.IsSplashFormVisible) { splashScreenManager4.CloseWaitForm(); }
            }
            catch (Exception ex)
            {
                if (splashScreenManager4.IsSplashFormVisible) { splashScreenManager4.CloseWaitForm(); }
                XtraMessageBox.Show("Porvuelva a iniciar Sesion en SAIC."
                        , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barItemNotificaciones_ItemClick(object sender, ItemClickEventArgs e)
        {
            ObtenerNotificacionesOperador();
        }

        private void barItemNotificaciones_ListItemClick(object sender, ListItemClickEventArgs e)
        {
            if (barItemNotificaciones.ItemIndex != -1)
            {
                if (barItemNotificaciones.Strings[barItemNotificaciones.ItemIndex] != "Ver todas las Notificaciones")
                {
                    var query = from x in dtNotificaciones.AsEnumerable()
                                where x.Field<int>("Indice").Equals(barItemNotificaciones.ItemIndex)
                                select x;

                    DataTable dtResultado = query.CopyToDataTable();
                    if (dtResultado.Rows.Count > 0)
                    {
                        int idNotificacion = 0;

                        int.TryParse(dtResultado.Rows[0]["idNotificacion"].ToString(), out idNotificacion);

                        if (idNotificacion > 0)
                        {
                            tools.xFormsMensajeNotificacion Notificacion = new tools.xFormsMensajeNotificacion(idNotificacion, dtResultado.Rows[0]["Tema"].ToString(),
                                             dtResultado.Rows[0]["Subtema"].ToString()
                                             , dtResultado.Rows[0]["Descripcion"].ToString(),
                                             Convert.ToDateTime(dtResultado.Rows[0]["FechaCreacion"].ToString()));
                            Notificacion.ShowDialog();
                            //ObtenerNotificacionesOperador();
                        }
                    }
                }
                else
                {
                    //Mostar Modulo de todas las notificaciones
                }
            }
        }

        DataTable dtNotificaciones = new DataTable();

        private void ObtenerNotificacionesOperador()
        {

            dtNotificaciones.Clear();

            barItemNotificaciones.Strings.Clear();

            stpSelObtenerNotificacionesTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelObtenerNotificaciones, OperadorBD.OperadorGlobal.IdOperador);
            dtNotificaciones = dbSAICBPOCatalogosDataSet.stpSelObtenerNotificaciones;

            if (dtNotificaciones.Columns.IndexOf("Indice") == -1) { dtNotificaciones.Columns.Add("Indice", typeof(int)); }

            DevExpress.Utils.SuperToolTip SToolNotificacion = new DevExpress.Utils.SuperToolTip();
            String stMensaje = dtNotificaciones.Rows.Count.ToString() + ": ";
            stMensaje += dtNotificaciones.Rows.Count == 1 ? "Notificación" : "Notificaciones";

            SToolNotificacion.Items.Add(stMensaje);

            barItemNotificaciones.SuperTip = SToolNotificacion;

            if (dtNotificaciones.Rows.Count > 0)
            {
                barItemNotificaciones.ItemAppearance.Normal.BackColor = Color.FromArgb(0, 0, 255);

                for (int i = 0; i < dtNotificaciones.Rows.Count; i++)
                {
                    dtNotificaciones.Rows[i]["Indice"] = i;
                    barItemNotificaciones.Strings.Add(dtNotificaciones.Rows[i]["Subtema"].ToString());
                }
            }
            else
            {
                //barItemNotificaciones.ItemAppearance.Normal.BackColor = Color.FromArgb(0, 0, 0);
                barItemNotificaciones.ItemAppearance.Normal.BackColor = Color.Empty;
            }

            barItemNotificaciones.Strings.Add("Ver todas las Notificaciones");

        }

        private int ObtenerCuentasNotificaciones()
        {
            int iNumNotificaciones = 0;
            var valor = queriesTableAdapter1.ObtenerCuantasNotificaciones(OperadorBD.OperadorGlobal.IdOperador);
            int.TryParse(valor.ToString(), out iNumNotificaciones);

            //stpSelObtenerNumeroNotificacionesTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelObtenerNumeroNotificaciones, OperadorBD.OperadorGlobal.IdOperador);
            return iNumNotificaciones;
        }

        private void ObtenerRevisarNotificaciones(int valorEspera)
        {
            int iConta = 0;
            while (iConta < 500)
            {
                try
                {
                    System.Threading.Thread.Sleep(valorEspera);
                    int iCuentaNotificaciones = 0;
                    iCuentaNotificaciones = ObtenerCuentasNotificaciones();
                    if (iCuentaNotificaciones != iNumeroDeNotificaciones)
                    {
                        iNumeroDeNotificaciones = iCuentaNotificaciones;
                        //MessageBox.Show("Nueva Notificacion, usted tiene " + iNumeroDeNotificaciones + ", notificaciones.");
                    }
                    else
                    {
                        barItemNotificaciones.ItemAppearance.Normal.BackColor = Color.Empty;
                    }

                    if (iNumeroDeNotificaciones > 0)
                    {
                        barItemNotificaciones.ItemAppearance.Normal.BackColor = Color.FromArgb(0, 0, 255);
                    }
                    else
                    {
                        barItemNotificaciones.ItemAppearance.Normal.BackColor = Color.Empty;
                    }

                    iConta++;
                }
                catch (Exception) { }
            }
        }

        private void frmxMenu_Activated(object sender, EventArgs e)
        {
            try
            {
                stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "VALIDACION DE VERSION");

                if (dbSAICBPOValidacionDataSet1.stpSelParametro.Rows.Count > 0)
                {
                    if (dbSAICBPOValidacionDataSet1.stpSelParametro.Rows[0]["ValorParametro"].ToString() == "SI")
                    {
                        //Revisar Ultima Version de la Aplicacion ya Logueado el usuario
                        short? pIdVersionApp = 0;
                        string pNoVersionAppAutorizada = "";
                        string pIdTipoMovimiento = "";
                        this.stpSelVersionApp2014TableAdapter1.GetData(entryAssemblyInfo.Product, entryAssemblyInfo.Version, ref pIdVersionApp, ref pNoVersionAppAutorizada, ref pIdTipoMovimiento);
                        if (pIdVersionApp == 0)        //si no se puede conectar
                        {
                            XtraMessageBox.Show("Esta APP NO es la última versión., La versión autorizada es: " + pNoVersionAppAutorizada, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                    }
                }

                stpSelParametroTableAdapter1.Fill(dbSAICBPOValidacionDataSet1.stpSelParametro, "VALIDACION DE SESSION");
                if (dbSAICBPOValidacionDataSet1.stpSelParametro.Rows.Count > 0)
                {
                    if (dbSAICBPOValidacionDataSet1.stpSelParametro.Rows[0]["ValorParametro"].ToString() == "SI")
                    {
                        //Revisar Sesion de Usuario
                        int? idRespuesta = 0;
                        DateTime? dtVencimientoSesion = new DateTime(1900, 01, 01);
                        stpSelValidarSesionOperadorTableAdapter1.Fill(dbSAICBPOCatalogosDataSet.stpSelValidarSesionOperador, OperadorBD.OperadorGlobal.IdOperador, ref idRespuesta, ref dtVencimientoSesion);
                        if (idRespuesta == 1)
                        {
                            XtraMessageBox.Show("Su Session de Usuario a Vencido." + dtVencimientoSesion.Value.ToShortDateString() + " " + dtVencimientoSesion.Value.ToShortTimeString(), "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception) { }
        }

        private void frmxMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                queriesTableAdapter1.stpUpdRegistrarSesionOperador(OperadorBD.OperadorGlobal.IdOperador);
            }
            catch (Exception) { }
        }

        private void btnActualizarPolizaFoliosEmpleados_ItemClick(object sender, ItemClickEventArgs e)
        {
            Seguros.frmxFolioPolizasEmpleados actPolizas = new Seguros.frmxFolioPolizasEmpleados();
            actPolizas.ShowDialog();
        }

        private void rbiValidadorDeEmpleados_ItemClick(object sender, ItemClickEventArgs e)
        {
            OperadoresM.XtraAltaEmpleados fxAltaEmpleados = new OperadoresM.XtraAltaEmpleados("Catalogos");
            fxAltaEmpleados.ShowDialog();
        }

        private void rbiPeriodosCliente_ItemClick(object sender, ItemClickEventArgs e)
        {
            Catalogos.frmxPeriodosCliente objMCliente = new Catalogos.frmxPeriodosCliente();
            objMCliente.ShowDialog();
        }

        private void rbiActualizaReporteGerencia_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show(String.Format("¿Esta seguro de Actualizar el Reporte?,\nEsto provocará que el servidor, SAIC, plantillas \ny sus reportes sean mas lento en lo que dura el proceso"), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    queriesActualizaReportes1.spRefreshGerenciaOperacionesPF();
                    XtraMessageBox.Show("Su solicitud está siendo procesada, \npor favor espere para consultar de nuevo el reporte en el portal, \nesto puede tardar algunos minutos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbiActualizaReporteInfonavit_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show(String.Format("¿Esta seguro de Actualizar el Reporte?,\nEsto provocará que el servidor, SAIC, plantillas \ny sus reportes sean mas lento en lo que dura el proceso"), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    queriesActualizaReportes1.spRefreshinfonavitPF();
                    XtraMessageBox.Show("Su solicitud está siendo procesada, \npor favor espere para consultar de nuevo el reporte en el portal, \nesto puede tardar algunos minutos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbiActualizaReporteDIM_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show(String.Format("¿Esta seguro de Actualizar el Reporte?,\nEsto provocará que el servidor, SAIC, plantillas \ny sus reportes sean mas lento en lo que dura el proceso"), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    queriesActualizaReportes1.spRefreshDimPF();
                    XtraMessageBox.Show("Su solicitud está siendo procesada, \npor favor espere para consultar de nuevo el reporte en el portal, \nesto puede tardar algunos minutos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbiActualizaReporteLotesNomina_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show(String.Format("¿Esta seguro de Actualizar el Reporte?,\nEsto provocará que el servidor, SAIC, plantillas \ny sus reportes sean mas lento en lo que dura el proceso"), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    queriesActualizaReportes1.spRefreshLotesNominaPF();
                    XtraMessageBox.Show("Su solicitud está siendo procesada, \npor favor espere para consultar de nuevo el reporte en el portal, \nesto puede tardar algunos minutos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbiModificarSDSDI_ItemClick(object sender, ItemClickEventArgs e)
        {
            IMSS.frmActualizarSBC objMCliente = new IMSS.frmActualizarSBC("JURIDICO");
            objMCliente.ShowDialog();
        }

        private void rbiActualizacionMasivaEmpleados_ItemClick(object sender, ItemClickEventArgs e)
        {
            Juridico.XtraActualizacionMasivaEmpleados objActualizacionMasiva = new Juridico.XtraActualizacionMasivaEmpleados();
            objActualizacionMasiva.ShowDialog();
        }

        private void btnCrediotsInfonavitMasivos_ItemClick(object sender, ItemClickEventArgs e)
        {
            IMSS.XtraCreditosInfonavitMasivos oXtraCreditosInfonavitMasivos = new IMSS.XtraCreditosInfonavitMasivos();
            oXtraCreditosInfonavitMasivos.ShowDialog();
        }

        private void btnConciliacionUUIDSAT_ItemClick(object sender, ItemClickEventArgs e)
        {
            Contablidad.frmxConciliacionUUID ofrmxConciliacionUUID = new Contablidad.frmxConciliacionUUID();
            ofrmxConciliacionUUID.ShowDialog();
        }

        private void btnContratos1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Juridico.XtraContratos oXtraContratos = new Juridico.XtraContratos();
            oXtraContratos.ShowDialog();
        }

        private void rbiAfiles_ItemClick(object sender, ItemClickEventArgs e)
        {
            IMSS.XtraAfils oXtraAfils = new IMSS.XtraAfils();
            oXtraAfils.ShowDialog();
        }

        private void rbiDescuentosAhorros_ItemClick(object sender, ItemClickEventArgs e)
        {
            Catalogos.XtraDescuentosPPA objForm = new Catalogos.XtraDescuentosPPA();
            objForm.ShowDialog();       //mostrar pantalla
        }

        private void btnEmpleadoExcepcionAcumulado_ItemClick(object sender, ItemClickEventArgs e)
        {
            OperadoresM.XtraEmpleadoExcepcionAcumulado oXtraEmpleadoExcepcionAcumulado = new OperadoresM.XtraEmpleadoExcepcionAcumulado();
            oXtraEmpleadoExcepcionAcumulado.ShowDialog();
        }

        private void barSolicitudesDeVariables_ItemClick(object sender, ItemClickEventArgs e)
        {
            IMSS.XtraSolicitudVariables oXtraSolicitudVariables = new IMSS.XtraSolicitudVariables();
            oXtraSolicitudVariables.ShowDialog();
        }

        private void barSolicitudesDeAniversarios_ItemClick(object sender, ItemClickEventArgs e)
        {
            IMSS.XtraSolicitudDeAniversarios oXtraSolicitudDeAniversarios = new IMSS.XtraSolicitudDeAniversarios();
            oXtraSolicitudDeAniversarios.ShowDialog();
        }

        private void barMonitoreoDeAniversarios_ItemClick(object sender, ItemClickEventArgs e)
        {
            IMSS.XtraMonitoreoDeAniversarios oXtraMonitoreoDeAniversarios = new IMSS.XtraMonitoreoDeAniversarios();
            oXtraMonitoreoDeAniversarios.ShowDialog();
        }

        private void btnActualizarContrasenia_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Seguridad.ContraseniaUsuarios oContraseniaUsuarios = new Seguridad.ContraseniaUsuarios();
            //oContraseniaUsuarios.ShowDialog();

            using (var form = new Seguridad.ContraseniaUsuarios())
            {
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Boolean iResultado = form.flagTaMuyBien;
                    if (iResultado)
                    {
                        XtraMessageBox.Show("Cerrando Sesion en SAIC."
                            , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }

        private void rbiParametrosIMSS_ItemClick(object sender, ItemClickEventArgs e)
        {
            IMSS.XtraParametros oXtraParametros = new IMSS.XtraParametros("IMSS");
            oXtraParametros.ShowDialog();
        }

        private void btnReporteLibroDiario_ItemClick(object sender, ItemClickEventArgs e)
        {
            Tesoreria.XtraReporteLibroDiario oXtraReporteLibroDiario = new Tesoreria.XtraReporteLibroDiario();
            oXtraReporteLibroDiario.ShowDialog();
        }

        private void rbiSolicitudPago_ItemClick(object sender, ItemClickEventArgs e)
        {
            ControlOperaciones.frmxSolicitudesPago objPantalla = new ControlOperaciones.frmxSolicitudesPago();
            objPantalla.ShowDialog();
        }
        

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            ControlOperaciones.frmxSolicitudesPago objPantalla = new ControlOperaciones.frmxSolicitudesPago();
            objPantalla.ShowDialog();

        }

        private void barButtonItem13_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            ControlOperaciones.frmxSolicitudesPago objPantalla = new ControlOperaciones.frmxSolicitudesPago();
            objPantalla.ShowDialog();
        }

        private void rbiCatClientesSaldo_ItemClick(object sender, ItemClickEventArgs e)
        {
            ControlOperaciones.frmxSaldoCliente objPantalla = new ControlOperaciones.frmxSaldoCliente();
            objPantalla.ShowDialog();

        }

        private void btnSaldosTesoreria_ItemClick(object sender, ItemClickEventArgs e)
        {
            Tesoreria.frmxSaldosTesoreria objSaldosTesoreria = new Tesoreria.frmxSaldosTesoreria();
            objSaldosTesoreria.ShowDialog();
        }

        private void rbiSolPagosProv_ItemClick(object sender, ItemClickEventArgs e)
        {
            Catalogos.frmxSolicitudesPagoProveedores objSolPagProveedores = new Catalogos.frmxSolicitudesPagoProveedores();
            objSolPagProveedores.ShowDialog();
        }
    }
}