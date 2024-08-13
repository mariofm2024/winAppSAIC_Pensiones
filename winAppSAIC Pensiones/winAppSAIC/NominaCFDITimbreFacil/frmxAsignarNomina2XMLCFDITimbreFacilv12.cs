using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using compNominaCFDI;
using compLibreriaSAIC;
using compExport;
using winAppSAIC.UtileriasLocal;
using compCatalogosSAIC;
using compNominaCFDI;


namespace winAppSAIC.NominaCFDITimbreFacil
{
    public partial class frmxAsignarNomina2XMLCFDITimbreFacilv12 : DevExpress.XtraEditors.XtraForm
    {
        #region "Variables Globales"
            private Int32 IdTenedora;
            private string sRFCTenedora;
            private string sTipoNomina;
            private string sTipoMovimiento;
            private string sFolioLoteCargaNomina;
        
            //Estructuras.InformacionLoteCargaNomina objInfoLoteCargaNomina;
            InfoDetalleLoteCargaNomina objInfoDetalle;      //declarar objeto InfoDetalleLoteCargaNomina
            string strRutaArchivosXLSX = string.Empty;   //ruta en dónde se guardaran los archivos XML
            private string sRutaArchivosCFDI;
            //private string sRutaArchivosRespuestaCFDI;

            HeaderNominaTimbreFacil objInfoEncabezadoTimbreFacil;        //objeto que almacenara el encabezado Timbre Facil
            NominaTimbreFacilComplementoV12 objComplementoV12;  //objeto para integrar Informacion Complemento CFDI 1.2   
       #endregion



        #region "Metodo Propios"
            /// <summary>
            /// Método que despliega la Informacion Detallada
            /// del Lote Carga Nomina seleccionado
            /// </summary>
            private void MostrarInfoDetalleLoteCargaNomina(long pIdLoteCargaNomina)
            {
                //cargar informacion detalla LoteCargaNomina
                DataTable dt = this.stpSelInfoDetalleLoteCargaNominaTableAdapter1.GetData(pIdLoteCargaNomina);

                //crear objeto y pasar el DataTable para asignar los valores
                objInfoDetalle = InfoDetalleLoteCargaNominaBD.ObtenerInfoDetalleLoteCargaNominaCFDI(dt);

                //si existe el objeto entonces mostrar los valores
                if (objInfoDetalle != null)
                {
                    txtNombreComercialTenedora.Text = objInfoDetalle.NombreComercialTenedora;
                    txtNombreComercialCliente.Text = objInfoDetalle.NombreComercialCliente;
                    txtNombreOperador.Text = objInfoDetalle.Operador;
                    txtTipoNomina.Text = objInfoDetalle.TipoNomina;
                    txtPeriodoPago.Text = objInfoDetalle.PeriodoPago;
                    chkEstatusNominaContabilizada.Checked = objInfoDetalle.EstatusNominaContabilizada;
                    if (objInfoDetalle.AnoPago > 0)
                        txtFechaPago.Text = String.Format("{0} {1}", objInfoDetalle.MesPago, objInfoDetalle.AnoPago);
                    else
                        txtFechaPago.Text = "";     //inicializar textbox

                }
            }

            /// <summary>
            /// Método que obtiene la Informacion Detallada
            /// del Lote Carga Nomina para el encabezado Timbre Facil
            /// </summary>
            private void ObtenerInfoEncabezadoTimbreFacil(long pIdLoteCargaNomina, string pTipoMovimiento)
            {
                //cargar informacion detalla LoteCargaNomina
                DataTable dt = this.stpSelHeaderTimbreFacilv12TableAdapter1.GetData(pIdLoteCargaNomina, pTipoMovimiento);

                //crear objeto y pasar el DataTable para asignar los valores
                objInfoEncabezadoTimbreFacil = NominaTimbreFacilBD.ObtenerEncabezadoNominas2XLS(dt);
            }



            /// <summary>
            /// Limpiar Controles para desplegar Informacion Detalle Lote Carga Nomina
            /// </summary>
            private void InicializarInfoDetalleLoteCargaNomina()
            {
                txtNombreComercialTenedora.Text = "";
                txtNombreComercialCliente.Text = "";
                txtNombreOperador.Text = "";
                txtTipoNomina.Text = "";
                txtPeriodoPago.Text = "";
                chkEstatusNominaContabilizada.Checked = false;
                txtFechaPago.Text = "";
            }

        #endregion

            public frmxAsignarNomina2XMLCFDITimbreFacilv12()
        {
            InitializeComponent();
        }

        private void frmxAsignarNomina2XMLCFDITimbreFacil_Load(object sender, EventArgs e)
        {
            try
            {
                //desplegar la version CFDI en titulo
                this.Text = "Generar archivo XLS para Timbre Fácil CFDI " + this.Tag;

                splashSMCargando.ShowWaitForm();
                // TODO: This line of code loads data into the 'dbSAICBPONominaCFDIv12DataSet.stpSelFolioLoteCargaNominaTimbreFacilCFDIv12' table. You can move, or remove it, as needed.
                this.stpSelFolioLoteCargaNominaTimbreFacilCFDIv12TableAdapter.Fill(this.dbSAICBPONominaCFDIv12DataSet.stpSelFolioLoteCargaNominaTimbreFacilCFDIv12);
                // Set column widths according to their contents. 
                cboFolioLoteCargaNomina.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cboFolioLoteCargaNomina.Properties.PopupFormWidth = 900;

                dtFechaPago.EditValue = DateTime.Today;     //asignar fecha de pago
                spPeriodo.EditValue = DateTime.Today.Month;     //asignar mes del periodo
                spParcial.EditValue = 1;                //asignar parcialidad
                splashSMCargando.CloseWaitForm();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboFolioLoteCargaNomina_EditValueChanged(object sender, EventArgs e)
        {
            Int32 intError = 0;
            string sFechaPagoAutomatica;

            try
            {
                //obtener el renglon completo del Combobox
                DataRow row = gridLookUpEdit1View.GetDataRow(gridLookUpEdit1View.FocusedRowHandle);
                //asignar valores extraidos del Combobox
                IdTenedora = Convert.ToInt32(row[2]);     //obtener IdTenedora
                sFolioLoteCargaNomina = row[1].ToString();
                sTipoNomina = row[1].ToString().Substring(2, 3);    //obtener Tipo Nomina (SEM, QUI, ASI, etc)
                sTipoMovimiento = row[1].ToString().Substring(0, 1);    //obtener Tipo Movimiento (S o A)
                sRFCTenedora = row[4].ToString();       //obtener RFCTenedora
                sFechaPagoAutomatica = String.Format("{0}/{1}/{2}", row[1].ToString().Substring(15, 2), row[1].ToString().Substring(17, 2), row[1].ToString().Substring(19, 4));
                
                //***CFDI 1.2***
                objComplementoV12 = new compNominaCFDI.NominaTimbreFacilComplementoV12();

                objComplementoV12.tipoNominaSAT = row[9].ToString();
                objComplementoV12.origenRecursoSAT = row[10].ToString();
                objComplementoV12.montoRecursoPropioSAT = (decimal) row[11];
                objComplementoV12.idRegimenFiscalSAT= row[12].ToString();
                
                dtFechaPago.EditValue = sFechaPagoAutomatica;   //asignar fecha de pago a la fecha final de la nómina

                //cargar informacion detallada LoteCargaNomina
                MostrarInfoDetalleLoteCargaNomina((long)cboFolioLoteCargaNomina.EditValue);
                //obtener informacion detallada encabezado Timbre Facil
                ObtenerInfoEncabezadoTimbreFacil((long)cboFolioLoteCargaNomina.EditValue, sTipoMovimiento);

                //mostrar datos en base al IdLoteCargaNomina e IdTipoMovimiento
                this.stpSelNominaTimbreFacilCFDIv12TableAdapter.Fill(this.dbSAICBPONominaCFDIv12DataSet.stpSelNominaTimbreFacilCFDIv12, (long)cboFolioLoteCargaNomina.EditValue, sTipoMovimiento);
                //si existen registros
                if (this.dbSAICBPONominaCFDIv12DataSet.stpSelNominaTimbreFacilCFDIv12.Count > 0)
                {
                    //Actualizar Estatus Timbrado CFDI = 2
                    intError = this.seguridadTableAdapter1.stpUpdEstatusTimbradoCFDI((long)cboFolioLoteCargaNomina.EditValue, 2, OperadorBD.OperadorGlobal.NombreUsuario);

                    if (chkListNominas.ItemCount > 0)
                        chkListNominas.CheckAll();
                }
                else
                {
                    //Actualizar Estatus Timbrado CFDI = 3
                    intError = this.seguridadTableAdapter1.stpUpdEstatusTimbradoCFDI((long)cboFolioLoteCargaNomina.EditValue, 3, OperadorBD.OperadorGlobal.NombreUsuario);
                    XtraMessageBox.Show("¡El Lote de Nómina NO tiene registros para LAYOUT!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();        //cerrar pantalla
        }

        private void btnSeleccionarTodos_Click(object sender, EventArgs e)
        {
            chkListNominas.CheckAll();    //seleccionar todos
        }

        private void btnDeseleccionarTodo_Click(object sender, EventArgs e)
        {
            chkListNominas.UnCheckAll();    //deseleccionar todos
        }

        private void chkListNominas_DrawItem(object sender, ListBoxDrawItemEventArgs e)
        {
            //e.Appearance.ForeColor = Color.Red;       //cambiar texto a Rojo
            if ((e.State & DrawItemState.Selected) == 0)
                e.Appearance.BackColor = Color.LightSteelBlue;
         }

        private void btnGenerarXLS_Click(object sender, EventArgs e)
        {
            long? pNoFolioSiguiente = 0;
            Int32 intNoRenglonExcel = 3;        //contador del renglon en donde sera colocada la informacion de la nomina del empleado
            //obtener el No. de Items seleccionados
            Int32 intNoRecibosActivos = chkListNominas.CheckedItems.Count;
            string sNombreEmpleado = String.Empty;

            //crear objeto excel
            CreateExcelDoc excell_app = null;

            //validar que exista al menos 1 movimiento activos para procesar
            if (intNoRecibosActivos > 0)
            {
                //obtener la ruta RAIZ en dónde se almacenarán los archivos XLSX
                strRutaArchivosXLSX = this.validacionesGeneralTableAdapter1.ObtenerValorParametro("FOLDER_XLSX_TIMBREFACIL").ToString();
                //Generar carpeta para colocar archivos XLSX
                sRutaArchivosCFDI = compNominaCFDI.AccesoIO.ValidarCrearDirectorioCFDI(strRutaArchivosXLSX, sRFCTenedora, (long)cboFolioLoteCargaNomina.EditValue, compNominaCFDI.AccesoIO.ISO_Date());

                //Obtener el No. Folio Siguiente
                this.seguridadTableAdapter1.stpUpdControlSerieFolioCFDI(IdTenedora, intNoRecibosActivos, ref pNoFolioSiguiente);

                splashSMProcesando.ShowWaitForm();        //mostrar pantalla de espera
                this.Cursor = Cursors.AppStarting;      //cambiar cursor del mouse

                try
                {
                    excell_app = new CreateExcelDoc(sRutaArchivosCFDI + "\\", String.Format("{0}_{1}", sRFCTenedora, sFolioLoteCargaNomina));  //crear objeto excel con nombre

                    //HEADER
                    excell_app.addData(1, 1, objInfoEncabezadoTimbreFacil.IdentificadorNomina.ToString(), "");
                    excell_app.addData(1, 2, objInfoEncabezadoTimbreFacil.Ano.ToString(), "");
                    excell_app.addData(1, 3, spPeriodo.EditValue.ToString(), "");
                    excell_app.addData(1, 4, spParcial.EditValue.ToString(), "");
                    //DATOS EMISOR
                    excell_app.addData(1, 5, objInfoEncabezadoTimbreFacil.RFC.ToString(), "");
                    //EXPEDIDO
                    excell_app.addData(1, 6, objInfoEncabezadoTimbreFacil.Calle.ToString(), "");
                    excell_app.addData(1, 7, objInfoEncabezadoTimbreFacil.NoExterior.ToString(), "");
                    excell_app.addData(1, 8, objInfoEncabezadoTimbreFacil.NoInterior.ToString(), "");
                    excell_app.addData(1, 9, objInfoEncabezadoTimbreFacil.Colonia.ToString(), "");
                    excell_app.addData(1, 10, objInfoEncabezadoTimbreFacil.PoblacionCiudad.ToString(), "");
                    excell_app.addData(1, 11, "", "");
                    excell_app.addData(1, 12, objInfoEncabezadoTimbreFacil.DelegacionMunicipio.ToString(), "");
                    excell_app.addData(1, 13, objInfoEncabezadoTimbreFacil.Estado.ToString(), "");
                    excell_app.addData(1, 14, objInfoEncabezadoTimbreFacil.Pais.ToString(), "");
                    excell_app.addData(1, 15, "\'" + objInfoEncabezadoTimbreFacil.CodigoPostal.ToString().PadLeft(5, '0'), "");
                    //PDF
                    excell_app.addData(1, 19, objInfoEncabezadoTimbreFacil.LeyendaIDCONSAR.ToString(), "");
                    //COMPROBANTE
                    excell_app.addData(1, 20, objInfoEncabezadoTimbreFacil.CondicionesPago.ToString(), "");
                    excell_app.addData(1, 21, objInfoEncabezadoTimbreFacil.DescConcepto.ToString(), "");
                    excell_app.addData(1, 22, objInfoEncabezadoTimbreFacil.UnidadConcepto.ToString(), "");
                    //***CFDI 1.2***
                    excell_app.addData(2, 1, this.Tag.ToString(), "");
                    excell_app.addData(2, 2, objComplementoV12.tipoNominaSAT, "");
                    excell_app.addData(2, 3, objInfoEncabezadoTimbreFacil.RFC.ToString(), "");
                    excell_app.addData(2, 4, objComplementoV12.origenRecursoSAT, "");
                    if (objComplementoV12.montoRecursoPropioSAT > 0)
                        excell_app.addData(2, 5, objComplementoV12.montoRecursoPropioSAT.ToString("0.00"), "");
                    else
                        excell_app.addData(2, 5, "", "");

                    excell_app.addData(2, 6, objComplementoV12.idRegimenFiscalSAT, "");

                    //CONCEPTOS PAGO
                    //***PERCEPCIONES***
                    excell_app.addData(1, 109, "P", "");
                    excell_app.addData(1, 110, "\'001", "");
                    excell_app.addData(2, 109, "\'001", "");
                    excell_app.addData(2, 110, "Sueldo Ordinario", "");

                    excell_app.addData(1, 111, "P", "");
                    excell_app.addData(1, 112, "\'002", "");
                    excell_app.addData(2, 111, "\'002", "");
                    excell_app.addData(2, 112, "Gratificacion Anual", "");

                    excell_app.addData(1, 113, "O", "");
                    excell_app.addData(1, 114, "\'002", "");
                    excell_app.addData(2, 113, "\'002", "");
                    excell_app.addData(2, 114, "Subsidio al Empleo", "");

                    excell_app.addData(1, 115, "P", "");
                    excell_app.addData(1, 116, "\'003", "");
                    excell_app.addData(2, 115, "\'003", "");
                    excell_app.addData(2, 116, "PTU", "");

                    excell_app.addData(1, 117, "P", "");
                    excell_app.addData(1, 118, "\'004", "");
                    excell_app.addData(2, 117, "\'004", "");
                    excell_app.addData(2, 118, "Reembolso de Gastos Medicos Dentales y Hospitalarios", "");

                    excell_app.addData(1, 119, "P", "");
                    excell_app.addData(1, 120, "\'005", "");
                    excell_app.addData(2, 119, "\'005", "");
                    excell_app.addData(2, 120, "Fondo de Ahorro", "");

                    excell_app.addData(1, 121, "P", "");
                    excell_app.addData(1, 122, "\'006", "");
                    excell_app.addData(2, 121, "\'006", "");
                    excell_app.addData(2, 122, "Caja de Ahorro", "");

                    excell_app.addData(1, 123, "P", "");
                    excell_app.addData(1, 124, "\'009", "");
                    excell_app.addData(2, 123, "\'009", "");
                    excell_app.addData(2, 124, "Contribuciones a Cargo del Trabajador Pagadas por el Patrón", "");

                    excell_app.addData(1, 125, "P", "");
                    excell_app.addData(1, 126, "\'010", "");
                    excell_app.addData(2, 125, "\'010", "");
                    excell_app.addData(2, 126, "Premios por puntualidad", "");

                    excell_app.addData(1, 127, "P", "");
                    excell_app.addData(1, 128, "\'011", "");
                    excell_app.addData(2, 127, "\'011", "");
                    excell_app.addData(2, 128, "Prima de Seguro de vida", "");

                    excell_app.addData(1, 129, "P", "");
                    excell_app.addData(1, 130, "\'012", "");
                    excell_app.addData(2, 129, "\'012", "");
                    excell_app.addData(2, 130, "Seguro de Gastos Médicos Mayores", "");

                    excell_app.addData(1, 131, "P", "");
                    excell_app.addData(1, 132, "\'013", "");
                    excell_app.addData(2, 131, "\'013", "");
                    excell_app.addData(2, 132, "Cuotas Sindicales Pagadas por el Patrón", "");

                    excell_app.addData(1, 133, "P", "");
                    excell_app.addData(1, 134, "\'014", "");
                    excell_app.addData(2, 133, "\'014", "");
                    excell_app.addData(2, 134, "Subsidios por incapacidad", "");

                    excell_app.addData(1, 135, "P", "");
                    excell_app.addData(1, 136, "\'015", "");
                    excell_app.addData(2, 135, "\'015", "");
                    excell_app.addData(2, 136, "Becas para trabajadores o hijos", "");

                    excell_app.addData(1, 137, "P", "");
                    excell_app.addData(1, 138, "\'019", "");
                    excell_app.addData(2, 137, "\'019", "");
                    excell_app.addData(2, 138, "Horas extras dobles", "");

                    excell_app.addData(1, 139, "P", "");
                    excell_app.addData(1, 140, "\'020", "");
                    excell_app.addData(2, 139, "\'020", "");
                    excell_app.addData(2, 140, "Prima dominical", "");

                    excell_app.addData(1, 141, "P", "");
                    excell_app.addData(1, 142, "\'021", "");
                    excell_app.addData(2, 141, "\'021", "");
                    excell_app.addData(2, 142, "Prima vacacional", "");

                    excell_app.addData(1, 143, "P", "");
                    excell_app.addData(1, 144, "\'022", "");
                    excell_app.addData(2, 143, "\'022", "");
                    excell_app.addData(2, 144, "Prima por antigüedad", "");

                    excell_app.addData(1, 145, "P", "");
                    excell_app.addData(1, 146, "\'023", "");
                    excell_app.addData(2, 145, "\'023", "");
                    excell_app.addData(2, 146, "Pagos por separación", "");

                    excell_app.addData(1, 147, "P", "");
                    excell_app.addData(1, 148, "\'024", "");
                    excell_app.addData(2, 147, "\'024", "");
                    excell_app.addData(2, 148, "Seguro de retiro", "");

                    excell_app.addData(1, 149, "P", "");
                    excell_app.addData(1, 150, "\'025", "");
                    excell_app.addData(2, 149, "\'025", "");
                    excell_app.addData(2, 150, "Indemnizaciones", "");

                    excell_app.addData(1, 151, "P", "");
                    excell_app.addData(1, 152, "\'026", "");
                    excell_app.addData(2, 151, "\'026", "");
                    excell_app.addData(2, 152, "Reembolso por funeral", "");

                    excell_app.addData(1, 153, "P", "");
                    excell_app.addData(1, 154, "\'027", "");
                    excell_app.addData(2, 153, "\'027", "");
                    excell_app.addData(2, 154, "Cuotas de seguridad social pagadas por el patrón", "");

                    excell_app.addData(1, 155, "P", "");
                    excell_app.addData(1, 156, "\'028", "");
                    excell_app.addData(2, 155, "\'028", "");
                    excell_app.addData(2, 156, "Comisiones", "");

                    excell_app.addData(1, 157, "P", "");
                    excell_app.addData(1, 158, "\'029", "");
                    excell_app.addData(2, 157, "\'029", "");
                    excell_app.addData(2, 158, "Vales de despensa", "");

                    excell_app.addData(1, 159, "P", "");
                    excell_app.addData(1, 160, "\'030", "");
                    excell_app.addData(2, 159, "\'030", "");
                    excell_app.addData(2, 160, "Vales de restaurante", "");

                    excell_app.addData(1, 161, "P", "");
                    excell_app.addData(1, 162, "\'031", "");
                    excell_app.addData(2, 161, "\'031", "");
                    excell_app.addData(2, 162, "Vales de gasolina", "");

                    excell_app.addData(1, 163, "P", "");
                    excell_app.addData(1, 164, "\'032", "");
                    excell_app.addData(2, 163, "\'032", "");
                    excell_app.addData(2, 164, "Vales de ropa", "");

                    excell_app.addData(1, 165, "P", "");
                    excell_app.addData(1, 166, "\'033", "");
                    excell_app.addData(2, 165, "\'033", "");
                    excell_app.addData(2, 166, "Ayuda para renta", "");

                    excell_app.addData(1, 167, "P", "");
                    excell_app.addData(1, 168, "\'034", "");
                    excell_app.addData(2, 167, "\'034", "");
                    excell_app.addData(2, 168, "Ayuda para artículos escolares", "");

                    excell_app.addData(1, 169, "P", "");
                    excell_app.addData(1, 170, "\'019", "");
                    excell_app.addData(2, 169, "\'019", "");
                    //excell_app.addData(2, 170, "Ayuda para anteojos", "");
                    excell_app.addData(2, 170, "Horas extras triples", "");

                    excell_app.addData(1, 171, "P", "");
                    excell_app.addData(1, 172, "\'036", "");
                    excell_app.addData(2, 171, "\'036", "");
                    excell_app.addData(2, 172, "Ayuda para transporte", "");

                    excell_app.addData(1, 173, "P", "");
                    excell_app.addData(1, 174, "\'037", "");
                    excell_app.addData(2, 173, "\'037", "");
                    excell_app.addData(2, 174, "Ayuda para gastos de funeral", "");

                    excell_app.addData(1, 175, "P", "");
                    excell_app.addData(1, 176, "\'038", "");
                    excell_app.addData(2, 175, "\'038", "");
                    excell_app.addData(2, 176, "Otros ingresos por salarios", "");

                    excell_app.addData(1, 177, "P", "");
                    excell_app.addData(1, 178, "\'039", "");
                    excell_app.addData(2, 177, "\'039", "");
                    excell_app.addData(2, 178, "Jubilaciones pensiones o haberes de retiro", "");

                    excell_app.addData(1, 179, "P", "");
                    excell_app.addData(1, 180, "\'044", "");
                    excell_app.addData(2, 179, "\'044", "");
                    excell_app.addData(2, 180, "Jubilaciones pensiones o haberes de retiro en parcialidades", "");

                    excell_app.addData(1, 181, "P", "");
                    excell_app.addData(1, 182, "\'045", "");
                    excell_app.addData(2, 181, "\'045", "");
                    excell_app.addData(2, 182, "Ingresos en acciones o títulos valor que representan bienes", "");

                    excell_app.addData(1, 183, "P", "");
                    excell_app.addData(1, 184, "\'047", "");
                    excell_app.addData(2, 183, "\'047", "");
                    excell_app.addData(2, 184, "Alimentación", "");

                    excell_app.addData(1, 185, "P", "");
                    excell_app.addData(1, 186, "\'048", "");
                    excell_app.addData(2, 185, "\'048", "");
                    excell_app.addData(2, 186, "Habitación", "");

                    excell_app.addData(1, 187, "P", "");
                    excell_app.addData(1, 188, "\'049", "");
                    excell_app.addData(2, 187, "\'049", "");
                    excell_app.addData(2, 188, "Premios por asistencia", "");

                    excell_app.addData(1, 189, "O", "");
                    excell_app.addData(1, 190, "\'999", "");
                    excell_app.addData(2, 189, "\'999", "");
                    excell_app.addData(2, 190, "Otros", "");

                    //***DEDUCCIONES***
                    excell_app.addData(1, 191, "D", "");
                    excell_app.addData(1, 192, "\'001", "");
                    excell_app.addData(2, 191, "\'001", "");
                    excell_app.addData(2, 192, "Seguridad social", "");
                    //excell_app.addData(2, 192, "IMSS", "");

                    excell_app.addData(1, 193, "D", "");
                    excell_app.addData(1, 194, "\'002", "");
                    excell_app.addData(2, 193, "\'002", "");
                    excell_app.addData(2, 194, "ISR", "");

                    excell_app.addData(1, 195, "D", "");
                    excell_app.addData(1, 196, "\'003", "");
                    excell_app.addData(2, 195, "\'003", "");
                    //excell_app.addData(2, 162, "Aportacion a retiro, cesantia en edad avanzada y vejez", "");
                    excell_app.addData(2, 196, "RCV", "");

                    excell_app.addData(1, 197, "D", "");
                    excell_app.addData(1, 198, "\'004", "");
                    excell_app.addData(2, 197, "\'004", "");
                    excell_app.addData(2, 198, "Otros", "");

                    excell_app.addData(1, 199, "D", "");
                    excell_app.addData(1, 200, "\'005", "");
                    excell_app.addData(2, 199, "\'005", "");
                    excell_app.addData(2, 200, "Aportaciones a fondo de vivienda", "");

                    excell_app.addData(1, 201, "D", "");
                    excell_app.addData(1, 202, "\'006", "");
                    excell_app.addData(2, 201, "\'006", "");
                    excell_app.addData(2, 202, "Descuento por incapacidad", "");

                    excell_app.addData(1, 203, "D", "");
                    excell_app.addData(1, 204, "\'007", "");
                    excell_app.addData(2, 203, "\'007", "");
                    excell_app.addData(2, 204, "Pension Alimenticia", "");

                    excell_app.addData(1, 205, "D", "");
                    excell_app.addData(1, 206, "\'008", "");
                    excell_app.addData(2, 205, "\'008", "");
                    excell_app.addData(2, 206, "Renta", "");

                    excell_app.addData(1, 207, "D", "");
                    excell_app.addData(1, 208, "\'009", "");
                    excell_app.addData(2, 207, "\'009", "");
                    excell_app.addData(2, 208, "Prestamos provenientes del Fondo Nacional de la vivienda para los trabajadores", "");

                    excell_app.addData(1, 209, "D", "");
                    excell_app.addData(1, 210, "\'010", "");
                    excell_app.addData(2, 209, "\'010", "");
                    //excell_app.addData(2, 210, "Pago por credito de vivienda", "");
                    excell_app.addData(2, 210, "Infonavit", "");

                    excell_app.addData(1, 211, "D", "");
                    excell_app.addData(1, 212, "\'011", "");
                    excell_app.addData(2, 211, "\'011", "");
                    //excell_app.addData(2, 212, "Pago de abonos de Infonacot", "");
                    excell_app.addData(2, 212, "Préstamo Fonacot", "");

                    excell_app.addData(1, 213, "D", "");
                    excell_app.addData(1, 214, "\'012", "");
                    excell_app.addData(2, 213, "\'012", "");
                    excell_app.addData(2, 214, "Anticipo de Salarios", "");


                    excell_app.addData(1, 215, "D", "");
                    excell_app.addData(1, 216, "\'013", "");
                    excell_app.addData(2, 215, "\'013", "");
                    excell_app.addData(2, 216, "Pagos Excedentes", "");

                    excell_app.addData(1, 217, "D", "");
                    excell_app.addData(1, 218, "\'019", "");
                    excell_app.addData(2, 217, "\'019", "");
                    excell_app.addData(2, 218, "Cuotas sindicales", "");

                    excell_app.addData(1, 219, "D", "");
                    excell_app.addData(1, 220, "\'020", "");
                    excell_app.addData(2, 219, "\'020", "");
                    excell_app.addData(2, 220, "Ausentismo", "");

                    excell_app.addData(1, 221, "D", "");
                    excell_app.addData(1, 222, "\'021", "");
                    excell_app.addData(2, 221, "\'021", "");
                    //excell_app.addData(2, 198, "Cuotas obrero Patronales", "");
                    excell_app.addData(2, 222, "IMSS", "");

                    excell_app.addData(1, 223, "D", "");
                    excell_app.addData(1, 224, "\'018", "");
                    excell_app.addData(2, 223, "\'018", "");
                    excell_app.addData(2, 224, "Caja de Ahorro o Fondo de Ahorro Deducción", "");

                    Int32 intNoRegistro = 0;
                    decimal decMontoTotalPercepciones = 0, decMontoTotalDeducciones = 0;

                    dbSAICBPO_PENSION_MX2017Entities db = new dbSAICBPO_PENSION_MX2017Entities();

                    for (int i = 0; i < chkListNominas.ItemCount; i++)
                    {
                        if (chkListNominas.GetItemCheckState(i) == CheckState.Checked)
                        {
                            //obtener el FolioRecibo seleccionado
                            Int64 intPDOHeader = Convert.ToInt64(chkListNominas.GetItemValue(i));

                            //obtener detalle de la nomina en base el IdLoteCargaNomina y TipoMovimiento
                            //usando Entity Framework
                            using (dbSAICBPO_PENSION_MX2017Entities context = new dbSAICBPO_PENSION_MX2017Entities())
                            {
                                foreach (stpSelDetalleNominaTimbreFacilCFDIv12_Result objDetalleNomina in context.stpSelDetalleNominaTimbreFacilCFDIv12((long)cboFolioLoteCargaNomina.EditValue, intPDOHeader, sTipoMovimiento))
                                {
                                    //variables para acumular percepciones y deducciones y eliminar diferencia en centavos
                                    decimal totalPercepcionesEmpleado = 0M, totalDeduccionesEmpleado = 0M;
                                    
                                    sNombreEmpleado = objDetalleNomina.NombreEmpleado;  //almacenar nombre empleado para errores

                                    excell_app.addData(intNoRenglonExcel, 1, pNoFolioSiguiente.ToString(), "");
                                    //excell_app.addData(intNoRenglonExcel, 2, objDetalleNomina.Subtotal.ToString(), "");
                                    //excell_app.addData(intNoRenglonExcel, 3, objDetalleNomina.Descuento.ToString(), "");
                                    //excell_app.addData(intNoRenglonExcel, 4, objDetalleNomina.Total.ToString(), "");
                                    excell_app.addData(intNoRenglonExcel, 5, objDetalleNomina.MetodoDePago, "");
                                    excell_app.addData(intNoRenglonExcel, 6, "\'" + objInfoEncabezadoTimbreFacil.CodigoPostal.ToString().PadLeft(5, '0'), "");
                                    excell_app.addData(intNoRenglonExcel, 7, objDetalleNomina.NoCuentaPagoTenedora, "");
                                    excell_app.addData(intNoRenglonExcel, 8, objDetalleNomina.RFC, "");
                                    excell_app.addData(intNoRenglonExcel, 9, objDetalleNomina.NombreEmpleado, "");
                                    excell_app.addData(intNoRenglonExcel, 10, objDetalleNomina.Calle, "");
                                    excell_app.addData(intNoRenglonExcel, 11, objDetalleNomina.NoExterior, "");
                                    excell_app.addData(intNoRenglonExcel, 12, objDetalleNomina.NoInterior, "");
                                    excell_app.addData(intNoRenglonExcel, 13, objDetalleNomina.Colonia, "");
                                    excell_app.addData(intNoRenglonExcel, 14, objDetalleNomina.Localidad, "");
                                    excell_app.addData(intNoRenglonExcel, 15, objDetalleNomina.Referencia, "");
                                    excell_app.addData(intNoRenglonExcel, 16, objDetalleNomina.DelegacionMunicipio, "");
                                    excell_app.addData(intNoRenglonExcel, 17, objDetalleNomina.Estado, "");
                                    excell_app.addData(intNoRenglonExcel, 18, objDetalleNomina.Pais, "");
                                    excell_app.addData(intNoRenglonExcel, 19, "\'" + objDetalleNomina.CodigoPostal.PadLeft(5, '0'), "");
                                    excell_app.addData(intNoRenglonExcel, 20, objDetalleNomina.RegistroPatronal, "");
                                    excell_app.addData(intNoRenglonExcel, 21, objDetalleNomina.NoEmpleado.ToString(), "");
                                    excell_app.addData(intNoRenglonExcel, 22, objDetalleNomina.CURP, "");
                                    excell_app.addData(intNoRenglonExcel, 23, "\'" + objDetalleNomina.IdRegimenFiscalEmpleadoSAT.ToString(), "");
                                    excell_app.addData(intNoRenglonExcel, 24, "\'" + objDetalleNomina.NSS.PadLeft(11, '0'), "");
                                    excell_app.addData(intNoRenglonExcel, 25, "!" + Conversiones.AgregarGuiones2Fecha(Conversiones.ConvertirFechaAAAAMMDD(dtFechaPago.EditValue.ToString())), "");
                                    excell_app.addData(intNoRenglonExcel, 26, "!" + Conversiones.AgregarGuiones2Fecha(Conversiones.ConvertirFechaAAAAMMDD(objDetalleNomina.FechaInicialPago.ToString())), "");
                                    excell_app.addData(intNoRenglonExcel, 27, "!" + Conversiones.AgregarGuiones2Fecha(Conversiones.ConvertirFechaAAAAMMDD(objDetalleNomina.FechaFinalPago.ToString())), "");
                                    excell_app.addData(intNoRenglonExcel, 28, objDetalleNomina.NoDiasPagados.ToString(), "");
                                    excell_app.addData(intNoRenglonExcel, 29, objDetalleNomina.Departamento, "");

                                    //si existe CLABE concatenar apostrofo
                                    if (objDetalleNomina.CLABE.Length > 0)
                                        excell_app.addData(intNoRenglonExcel, 30, "\'" + objDetalleNomina.CLABE, "");
                                    else
                                        excell_app.addData(intNoRenglonExcel, 30, objDetalleNomina.CLABE, "");

                                    //si existe banco concatenar apostrofo
                                    if (objDetalleNomina.Banco.Length > 0)
                                        excell_app.addData(intNoRenglonExcel, 31, "\'" + objDetalleNomina.Banco, "");
                                    else
                                        excell_app.addData(intNoRenglonExcel, 31, objDetalleNomina.Banco, "");

                                    excell_app.addData(intNoRenglonExcel, 32, "!" + Conversiones.AgregarGuiones2Fecha(Conversiones.ConvertirFechaAAAAMMDD(objDetalleNomina.FechaIngreso.ToString())), "");
                                    excell_app.addData(intNoRenglonExcel, 33, objDetalleNomina.Antiguedad.ToString(), "");
                                    excell_app.addData(intNoRenglonExcel, 34, objDetalleNomina.Puesto, "");
                                    excell_app.addData(intNoRenglonExcel, 35, "\'" + objDetalleNomina.IdTipoContratoSAT, "");
                                    excell_app.addData(intNoRenglonExcel, 36, "\'" + objDetalleNomina.IdTipoJornadaSAT, "");
                                    excell_app.addData(intNoRenglonExcel, 37, "\'" + objDetalleNomina.IdPeriodicidadPagoSAT, "");
                                    excell_app.addData(intNoRenglonExcel, 38, objDetalleNomina.SBC.ToString(), "");
                                    excell_app.addData(intNoRenglonExcel, 39, objDetalleNomina.RiesgoPuesto.ToString(), "");
                                    excell_app.addData(intNoRenglonExcel, 40, objDetalleNomina.SDI.ToString(), "");

                                    //INCAPACIDADES
                                    excell_app.addData(intNoRenglonExcel, 41, objDetalleNomina.DiasIncapacidad.ToString(), "");
                                    excell_app.addData(intNoRenglonExcel, 42, objDetalleNomina.TipoIncapacidad.ToString(), "");
                                    excell_app.addData(intNoRenglonExcel, 43, objDetalleNomina.DescuentoIncapacidad.ToString(), "");
                                    excell_app.addData(intNoRenglonExcel, 44, objDetalleNomina.DiasIncapacidad.ToString(), "");
                                    excell_app.addData(intNoRenglonExcel, 45, objDetalleNomina.TipoIncapacidad.ToString(), "");
                                    excell_app.addData(intNoRenglonExcel, 46, objDetalleNomina.DescuentoIncapacidad.ToString(), "");
                                    excell_app.addData(intNoRenglonExcel, 47, objDetalleNomina.DiasIncapacidad.ToString(), "");
                                    excell_app.addData(intNoRenglonExcel, 48, objDetalleNomina.TipoIncapacidad.ToString(), "");
                                    excell_app.addData(intNoRenglonExcel, 49, objDetalleNomina.DescuentoIncapacidad.ToString(), "");
                                    excell_app.addData(intNoRenglonExcel, 50, objDetalleNomina.DiasIncapacidad.ToString(), "");
                                    excell_app.addData(intNoRenglonExcel, 51, objDetalleNomina.TipoIncapacidad.ToString(), "");
                                    excell_app.addData(intNoRenglonExcel, 52, objDetalleNomina.DescuentoIncapacidad.ToString(), "");
                                    
                                    //HORAS EXTRAS
                                    excell_app.addData(intNoRenglonExcel, 53, objDetalleNomina.DiasHorasExtrasDobles.ToString(), "");   //BLOQ1     NoDiasHorasExtrasDobles
                                    excell_app.addData(intNoRenglonExcel, 54, objDetalleNomina.TipoHorasExtrasDobles, "");      //TipoHoras
                                    excell_app.addData(intNoRenglonExcel, 55, objDetalleNomina.NoHorasExtrasDobles.ToString(), "");    //NoHorasExtra  
                                    excell_app.addData(intNoRenglonExcel, 56, 0.ToString(), "");    //ImportePagado  ==se muestra en ciclo foreach==
                                    excell_app.addData(intNoRenglonExcel, 57, objDetalleNomina.DiasHorasExtrasDobles.ToString(), "");   //BLOQ2     NoDiasHorasExtrasTriples
                                    excell_app.addData(intNoRenglonExcel, 58, objDetalleNomina.TipoHorasExtrasTriples, "");     //TipoHoras
                                    excell_app.addData(intNoRenglonExcel, 59, objDetalleNomina.NoHorasExtrasTriples.ToString(), "");    //NoHorasExtra  
                                    excell_app.addData(intNoRenglonExcel, 60, 0.ToString(), "");    //ImportePagado  ==se muestra en ciclo foreach==
                                    excell_app.addData(intNoRenglonExcel, 61, 0.ToString(), "");    //BLOQ3
                                    excell_app.addData(intNoRenglonExcel, 62, "", "");
                                    excell_app.addData(intNoRenglonExcel, 63, 0.ToString(), "");       
                                    excell_app.addData(intNoRenglonExcel, 64, 0.ToString(), "");
                                    excell_app.addData(intNoRenglonExcel, 65, 0.ToString(), "");    //BLOQ4
                                    excell_app.addData(intNoRenglonExcel, 66, "", "");
                                    excell_app.addData(intNoRenglonExcel, 67, 0.ToString(), "");       
                                    excell_app.addData(intNoRenglonExcel, 68, 0.ToString(), "");
                                    excell_app.addData(intNoRenglonExcel, 69, 0.ToString(), "");    //BLOQ5
                                    excell_app.addData(intNoRenglonExcel, 70, "", "");
                                    excell_app.addData(intNoRenglonExcel, 71, 0.ToString(), "");       
                                    excell_app.addData(intNoRenglonExcel, 72, 0.ToString(), "");
                                    //excell_app.addData(intNoRenglonExcel, 73, 0.ToString(), "");    //ISR ==se ubica en ciclo foreach==
                                    excell_app.addData(intNoRenglonExcel, 74, objDetalleNomina.CorreoElectronico, "");
                                    //***CFDI1.2***
                                    excell_app.addData(intNoRenglonExcel, 75, objDetalleNomina.SindicalizadoSAT, "");   //Separaciones_Sindicalizado
                                    excell_app.addData(intNoRenglonExcel, 76, objDetalleNomina.IdEstadoSAT, "");    //Separaciones_ClaveEntFed
                                    excell_app.addData(intNoRenglonExcel, 77, "", "");  //Separaciones_RfcLabora
                                    excell_app.addData(intNoRenglonExcel, 78, "", "");  //Separaciones_PorcentajeTiempo
                                    
                                    if (sTipoMovimiento.Equals("S"))
                                    {   //sueldos
                                        excell_app.addData(intNoRenglonExcel, 79, 0.ToString(), "");    //Jubilaciones_TotalUnaExhibicion
                                        excell_app.addData(intNoRenglonExcel, 80, 0.ToString(), "");    //Jubilaciones_TotalParcialidad
                                        excell_app.addData(intNoRenglonExcel, 81, 0.ToString(), "");    //Jubilaciones_MontoDiario
                                        excell_app.addData(intNoRenglonExcel, 82, 0.ToString(), "");    //Jubilaciones_IngresoAcumulable
                                        excell_app.addData(intNoRenglonExcel, 83, 0.ToString(), "");    //Jubilaciones_IngresoNoAcumulable

                                        //separacion finiquito-liquidacion
                                        if (objDetalleNomina.PeriodicidadPago.Equals("FINIQUITO") || objDetalleNomina.PeriodicidadPago.Equals("LIQUIDACION"))
                                        {
                                            //si importe en Conceptos de Separacion > 0 entonces mostrar valores
                                            if (objDetalleNomina.ImporteSeparacion > 0) 
                                            {
                                                excell_app.addData(intNoRenglonExcel, 84, objDetalleNomina.ImporteSeparacion.ToString(), "");   //Separaciones_TotalPagado
                                                excell_app.addData(intNoRenglonExcel, 85, objDetalleNomina.anosServicio.ToString(), "");    //Separaciones_NumAñosServicio
                                                excell_app.addData(intNoRenglonExcel, 86, objDetalleNomina.ultimoSueldoMensOrd.ToString(), "");     //Separaciones_UltimoSueldoMensOrd
                                                
                                                if (objDetalleNomina.ImporteSeparacionGravado > 0)
                                                    excell_app.addData(intNoRenglonExcel, 87, objDetalleNomina.ImporteSeparacionGravado.ToString(), "");    //Separaciones_IngresoAcumulable
                                                else
                                                    excell_app.addData(intNoRenglonExcel, 87, "0.01", "");    //Separaciones_IngresoAcumulable

                                                if (objDetalleNomina.ImporteSeparacionExento > 0)
                                                    excell_app.addData(intNoRenglonExcel, 88, objDetalleNomina.ImporteSeparacionExento.ToString(), "");    //Separaciones_IngresoNoAcumulable
                                                else
                                                    excell_app.addData(intNoRenglonExcel, 88, "0.01", "");    //Separaciones_IngresoNoAcumulable
                                            }
                                            else
                                            {
                                                excell_app.addData(intNoRenglonExcel, 84, 0.ToString(), "");   //Separaciones_TotalPagado
                                                excell_app.addData(intNoRenglonExcel, 85, 0.ToString(), "");    //Separaciones_NumAñosServicio
                                                excell_app.addData(intNoRenglonExcel, 86, 0.ToString(), "");     //Separaciones_UltimoSueldoMensOrd
                                                excell_app.addData(intNoRenglonExcel, 87, 0.ToString(), "");    //Separaciones_IngresoAcumulable
                                                excell_app.addData(intNoRenglonExcel, 88, 0.ToString(), "");    //Separaciones_IngresoNoAcumulable
                                            }
                                        }

                                        if (objDetalleNomina.DiasHorasExtrasDobles > 0)
                                            excell_app.addData(intNoRenglonExcel, 105, "Horas extras dobles", "");     //Concepto Nómina para Horas Extras
                                        else
                                            excell_app.addData(intNoRenglonExcel, 105, "", "");     //Concepto Nómina para Horas Extras

                                        if (objDetalleNomina.DiasHorasExtrasTriples > 0)
                                            excell_app.addData(intNoRenglonExcel, 106, "Horas extras triples", "");     //Concepto Nómina para Horas Extras
                                        else
                                            excell_app.addData(intNoRenglonExcel, 106, "", "");     //Concepto Nómina para Horas Extras

                                        //total percepcion-deducciones-otros pagos-otras deducciones
                                        excell_app.addData(intNoRenglonExcel, 89, objDetalleNomina.ColumnaLayout_CK.ToString(), "");    //Nomina_TotalPercepciones
                                        excell_app.addData(intNoRenglonExcel, 90, objDetalleNomina.Descuento.ToString(), "");   //Nomina_TotalDeducciones
                                        excell_app.addData(intNoRenglonExcel, 91, objDetalleNomina.ImporteOtrosPagos.ToString(), "");    //Nomina_TotalOtrosPagos
                                        excell_app.addData(intNoRenglonExcel, 92, objDetalleNomina.DescuentoSinISR.ToString(), "");    //Deducciones_TotalOtrasDeducciones
                                        excell_app.addData(intNoRenglonExcel, 93, objDetalleNomina.ColumnaLayout_CO.ToString(), "");    //Percepciones_TotalSueldos
                                        excell_app.addData(intNoRenglonExcel, 94, objDetalleNomina.ImporteSeparacion.ToString(), "");    //Percepciones_TotalSeparacionIndemnizacion
                                        excell_app.addData(intNoRenglonExcel, 95, objDetalleNomina.ImportePensionJubilacion.ToString(), "");    //Percepciones_TotalJubilacionPensionRetiro
                                        excell_app.addData(intNoRenglonExcel, 96, (objDetalleNomina.IngresosBrutosGravados + objDetalleNomina.IngresosGravadosPrevisionSocial).ToString(), "");    //Percepciones_TotalGravado
                                        excell_app.addData(intNoRenglonExcel, 97, (objDetalleNomina.IngresosBrutosExentos + objDetalleNomina.IngresosExentosPrevisionSocial).ToString(), "");    //Percepciones_TotalExento
                                        excell_app.addData(intNoRenglonExcel, 98, objDetalleNomina.SubsidioCausadoSAT.ToString(), "");    //Subsidioalempleo_SubsidioCausado
                                        excell_app.addData(intNoRenglonExcel, 99, 0.ToString(), "");    //SaldoAFavor
                                        excell_app.addData(intNoRenglonExcel, 100, "", "");     //AñoCompensacion
                                        excell_app.addData(intNoRenglonExcel, 101, "", "");     //RemanenteSalFav
                                        excell_app.addData(intNoRenglonExcel, 102, "", "");     //ValorMercado
                                        excell_app.addData(intNoRenglonExcel, 103, "", "");     //PrecioAlOtorgarse
                                        excell_app.addData(intNoRenglonExcel, 104, 0.ToString(), "");   //Deducciones_TotalImpuestosRetenidos 

                                        excell_app.addData(intNoRenglonExcel, 107, "", "");     //Concepto Nómina para Horas Extras
                                        excell_app.addData(intNoRenglonExcel, 108, "", "");     //Concepto Nómina para Horas Extras

                                        //inicializar columnas de importes gravados y exentos
                                        excell_app.assignInitialValue("0", "DE" + intNoRenglonExcel.ToString(), "HP" + intNoRenglonExcel.ToString());        //asignar valores iniciales en celdas

                                        //detalle Percepciones y Deducciones
                                        var DetallePercepcionesDeducciones = from row in db.stpSelPercepcionesDeduccionesGravadoExentoTimbreFacilv12((long)cboFolioLoteCargaNomina.EditValue, sTipoMovimiento).Where(row => row.IdPDOHeader == intPDOHeader)
                                                                             select row;

                                        foreach (var item in DetallePercepcionesDeducciones)
                                        {
                                            excell_app.addData(intNoRenglonExcel, item.NoColumnaGravadaLayoutTimbreFacil, item.MontoPDOGravado.ToString(), "");
                                            excell_app.addData(intNoRenglonExcel, item.NoColumnaExentaLayoutTimbreFacil, item.MontoPDOExento.ToString(), "");

                                            //acumular importes por empleado
                                            if (item.ClasifConceptoCFDI.Equals("P"))
                                                totalPercepcionesEmpleado += (decimal)item.MontoPDO;
                                            else
                                                totalDeduccionesEmpleado += (decimal)item.MontoPDO;

                                            //subsidio
                                            if (item.ClasifConceptoCFDI.Equals("P") && item.DescConceptoTimbreFacil.Equals("SUBSIDIO PARA EL EMPLEO"))
                                            {
                                                if (item.MontoPDOGravado > 0)
                                                {   //intercambiar valores SUBSIDIO Gravado => Exento, Exento => Gravado
                                                    excell_app.addData(intNoRenglonExcel, item.NoColumnaGravadaLayoutTimbreFacil, item.MontoPDOExento.ToString(), "");
                                                    excell_app.addData(intNoRenglonExcel, item.NoColumnaExentaLayoutTimbreFacil, item.MontoPDOGravado.ToString(), "");
                                                }
                                                else
                                                {
                                                    excell_app.addData(intNoRenglonExcel, item.NoColumnaGravadaLayoutTimbreFacil, 0.ToString(), "");
                                                    excell_app.addData(intNoRenglonExcel, item.NoColumnaExentaLayoutTimbreFacil, 0.ToString(), "");
                                                }
                                            } else if (item.ClasifConceptoCFDI.Equals("D") && item.ClaveConceptoCFDI.Equals("002"))
                                            {
                                                //registrar importe de ISR total
                                                if (item.MontoPDOGravado > 0)
                                                    excell_app.addData(intNoRenglonExcel, 104, item.MontoPDOGravado.ToString(), "");
                                                else
                                                    excell_app.addData(intNoRenglonExcel, 104, 0.ToString(), "");

                                            } else if (item.ClasifConceptoCFDI.Equals("P") && item.DescConceptoTimbreFacil.Equals("HORAS EXTRA DOBLES"))
                                            {
                                                //Importe pagao Horas Dobles
                                                excell_app.addData(intNoRenglonExcel, 56, (item.MontoPDOGravado + item.MontoPDOExento).ToString(), "");
                                            }
                                            else if (item.ClasifConceptoCFDI.Equals("P") && item.DescConceptoTimbreFacil.Equals("HORAS EXTRA TRIPLES"))
                                            {
                                                //Importe pagao Horas Dobles
                                                excell_app.addData(intNoRenglonExcel, 60, (item.MontoPDOGravado + item.MontoPDOExento).ToString(), "");
                                            }
                                        }   //foreach

                                        //asignar valores percepciones y deducciones por empleado
                                        excell_app.addData(intNoRenglonExcel, 2, totalPercepcionesEmpleado.ToString(), "");
                                        excell_app.addData(intNoRenglonExcel, 3, totalDeduccionesEmpleado.ToString(), "");
                                        excell_app.addData(intNoRenglonExcel, 4, (totalPercepcionesEmpleado - totalDeduccionesEmpleado).ToString(), "");

                                        //acumuladores de Percepciones y Deducciones
                                        decMontoTotalPercepciones += totalPercepcionesEmpleado;
                                        decMontoTotalDeducciones += totalDeduccionesEmpleado;
                                    }
                                    else
                                    {   //pension
                                        excell_app.addData(intNoRenglonExcel, 79, objDetalleNomina.Subtotal.ToString(), "");    //Jubilaciones_TotalUnaExhibicion
                                        excell_app.addData(intNoRenglonExcel, 80, 0.ToString(), "");    //Jubilaciones_TotalParcialidad
                                        excell_app.addData(intNoRenglonExcel, 81, 0.ToString(), "");    //Jubilaciones_MontoDiario
                                        excell_app.addData(intNoRenglonExcel, 82, "0.01", "");    //Jubilaciones_IngresoAcumulable
                                        excell_app.addData(intNoRenglonExcel, 83, objDetalleNomina.Subtotal.ToString(), "");    //Jubilaciones_IngresoNoAcumulable
                                        excell_app.addData(intNoRenglonExcel, 84, 0.ToString(), "");    //Separaciones_TotalPagado
                                        excell_app.addData(intNoRenglonExcel, 85, 0.ToString(), "");    //Separaciones_NumAñosServicio
                                        excell_app.addData(intNoRenglonExcel, 86, 0.ToString(), "");    //Separaciones_UltimoSueldoMensOrd
                                        excell_app.addData(intNoRenglonExcel, 87, 0.ToString(), "");    //Separaciones_IngresoAcumulable
                                        excell_app.addData(intNoRenglonExcel, 88, 0.ToString(), "");     //Separaciones_IngresoNoAcumulable
                                        //total percepcion-deducciones-otros pagos-otras deducciones
                                        excell_app.addData(intNoRenglonExcel, 89, objDetalleNomina.ColumnaLayout_CK.ToString(), "");    //Nomina_TotalPercepciones
                                        excell_app.addData(intNoRenglonExcel, 90, objDetalleNomina.Descuento.ToString(), "");   //Nomina_TotalDeducciones
                                        excell_app.addData(intNoRenglonExcel, 91, objDetalleNomina.ImporteOtrosPagos.ToString(), "");    //Nomina_TotalOtrosPagos
                                        excell_app.addData(intNoRenglonExcel, 92, objDetalleNomina.Descuento.ToString(), "");    //Deducciones_TotalOtrasDeducciones
                                        excell_app.addData(intNoRenglonExcel, 93, objDetalleNomina.ColumnaLayout_CO.ToString(), "");    //Percepciones_TotalSueldos
                                        excell_app.addData(intNoRenglonExcel, 94, objDetalleNomina.ImporteSeparacion.ToString(), "");    //Percepciones_TotalSeparacionIndemnizacion
                                        excell_app.addData(intNoRenglonExcel, 95, objDetalleNomina.ImportePensionJubilacion.ToString(), "");    //Percepciones_TotalJubilacionPensionRetiro
                                        excell_app.addData(intNoRenglonExcel, 96, (objDetalleNomina.IngresosBrutosGravados + objDetalleNomina.IngresosGravadosPrevisionSocial).ToString(), "");    //Percepciones_TotalGravado
                                        excell_app.addData(intNoRenglonExcel, 97, objDetalleNomina.ImportePensionJubilacion.ToString(), "");    //Percepciones_TotalExento
                                        excell_app.addData(intNoRenglonExcel, 98, objDetalleNomina.SubsidioCausadoSAT.ToString(), "");    //Subsidioalempleo_SubsidioCausado
                                        excell_app.addData(intNoRenglonExcel, 99, 0.ToString(), "");    //SaldoAFavor
                                        excell_app.addData(intNoRenglonExcel, 100, "", "");     //AñoCompensacion
                                        excell_app.addData(intNoRenglonExcel, 101, "", "");     //RemanenteSalFav
                                        excell_app.addData(intNoRenglonExcel, 102, "", "");     //ValorMercado
                                        excell_app.addData(intNoRenglonExcel, 103, "", "");     //PrecioAlOtorgarse
                                        excell_app.addData(intNoRenglonExcel, 104, 0.ToString(), "");   //Deducciones_TotalImpuestosRetenidos 
                                        excell_app.addData(intNoRenglonExcel, 105, "", "");     //Concepto Nómina para Horas Extras
                                        excell_app.addData(intNoRenglonExcel, 106, "", "");     //Concepto Nómina para Horas Extras
                                        excell_app.addData(intNoRenglonExcel, 107, "", "");     //Concepto Nómina para Horas Extras
                                        excell_app.addData(intNoRenglonExcel, 108, "", "");     //Concepto Nómina para Horas Extras

                                        //inicializar columnas de importes gravados y exentos
                                        excell_app.assignInitialValue("0", "DE" + intNoRenglonExcel.ToString(), "HP" + intNoRenglonExcel.ToString());        //asignar valores iniciales en celdas

                                        //detalle Percepciones y Deducciones
                                        var DetallePercepcionesDeducciones = from row in db.stpSelPercepcionesDeduccionesGravadoExentoTimbreFacilv12((long)cboFolioLoteCargaNomina.EditValue, sTipoMovimiento).Where(row => row.IdPDOHeader == intPDOHeader)
                                                                             select row;

                                        foreach (var item in DetallePercepcionesDeducciones)
                                        {
                                            excell_app.addData(intNoRenglonExcel, item.NoColumnaGravadaLayoutTimbreFacil, item.MontoPDOGravado.ToString(), "");
                                            excell_app.addData(intNoRenglonExcel, item.NoColumnaExentaLayoutTimbreFacil, item.MontoPDOExento.ToString(), "");

                                            //acumular importes por empleado
                                            if (item.ClasifConceptoCFDI.Equals("P"))
                                                totalPercepcionesEmpleado += (decimal)item.MontoPDO;
                                            else
                                                totalDeduccionesEmpleado += (decimal)item.MontoPDO;

                                            //registrar importe de ISR total
                                            if (item.ClasifConceptoCFDI.Equals("D") && item.ClaveConceptoCFDI.Equals("002"))
                                            {
                                                //excell_app.addData(intNoRenglonExcel, 104, item.MontoPDOGravado.ToString(), "");
                                                if (item.MontoPDOGravado > 0)
                                                    excell_app.addData(intNoRenglonExcel, 104, item.MontoPDOGravado.ToString(), "");
                                                else
                                                    excell_app.addData(intNoRenglonExcel, 104, 0.ToString(), "");
                                            }

                                        }   //foreach

                                        //asignar valores percepciones y deducciones por empleado
                                        excell_app.addData(intNoRenglonExcel, 2, totalPercepcionesEmpleado.ToString(), "");
                                        excell_app.addData(intNoRenglonExcel, 3, totalDeduccionesEmpleado.ToString(), "");
                                        excell_app.addData(intNoRenglonExcel, 4, (totalPercepcionesEmpleado - totalDeduccionesEmpleado).ToString(), "");

                                        //acumuladores de Percepciones y Deducciones
                                        decMontoTotalPercepciones += totalPercepcionesEmpleado;
                                        decMontoTotalDeducciones += totalDeduccionesEmpleado;
                                    }   //else if (sTipoMovimiento.Equals("S"))

                                }   //foreach (stpSelDetalleNominaTimbreFacilCFDIv12_Result
                            }   //using (dbSAICBPO_PENSION_MX2017Entities
                            intNoRegistro++;    //incrementar contador registro
                            intNoRenglonExcel++;    //incrementar contador de renglon
                            pNoFolioSiguiente++;        //incrementar el Folio Siguiente

                        }   //if  chkListNominas.GetItemCheckState(i)
                    }  //for (int i = 0; i < chkListNominas.ItemCount; i++)

                    //CONTROL TOTALES => NO. REGISTROS, PERCEPCIONES Y DEDUCCIONES
                    //agregar numero de registros a procesar
                    excell_app.addData(1, 16, intNoRegistro.ToString(), "");
                    excell_app.addData(1, 17, decMontoTotalPercepciones.ToString(), "");
                    excell_app.addData(1, 18, decMontoTotalDeducciones.ToString(), "");

                    splashSMProcesando.CloseWaitForm();   //quitar pantalla de espera
                    XtraMessageBox.Show("¡La generación del archivo XLS ha concluido!", "Proceso Terminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }       //try
                catch (NullReferenceException ex)
                {
                    splashSMProcesando.CloseWaitForm();   //quitar pantalla de espera
                    XtraMessageBox.Show(string.Format("El empleado {0} tiene errores en su información:\n\t -> NSS, RFC, CURP o Domicilio Particular\n\nLa generación del archivo no puede continuar,¡Valide con Jurídico!", sNombreEmpleado), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    splashSMProcesando.CloseWaitForm();   //quitar pantalla de espera
                    XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally {
                    this.Cursor = Cursors.Default;      //cambiar cursor del mouse
                }
            }   //if (intNoRecibosActivos > 0)
            else
                XtraMessageBox.Show("¡No existen Movimientos activos para el archivo XLSX-Timbre Fácil!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}