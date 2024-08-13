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

namespace winAppSAIC.NominaCFDITimbreFacil
{
    public partial class frmxAsignarNomina2XMLCFDITimbreFacil : DevExpress.XtraEditors.XtraForm
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
                DataTable dt = this.stpSelHeaderTimbreFacilTableAdapter1.GetData(pIdLoteCargaNomina, pTipoMovimiento);

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

        public frmxAsignarNomina2XMLCFDITimbreFacil()
        {
            InitializeComponent();
        }

        private void frmxAsignarNomina2XMLCFDITimbreFacil_Load(object sender, EventArgs e)
        {
            try
            {
                splashSMCargando.ShowWaitForm();
                // TODO: This line of code loads data into the 'dbSAICBPONominaCFDITimbreFacilDataSet1.stpSelFolioLoteCargaNominaTimbreFacilCFDI' table. You can move, or remove it, as needed.
                this.stpSelFolioLoteCargaNominaTimbreFacilCFDITableAdapter.Fill(this.dbSAICBPONominaCFDITimbreFacilDataSet1.stpSelFolioLoteCargaNominaTimbreFacilCFDI);
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

                dtFechaPago.EditValue = sFechaPagoAutomatica;   //asignar fecha de pago a la fecha final de la nómina

                //cargar informacion detallada LoteCargaNomina
                MostrarInfoDetalleLoteCargaNomina((long)cboFolioLoteCargaNomina.EditValue);
                //obtener informacion detallada enzabezado Timbre Facil
                ObtenerInfoEncabezadoTimbreFacil((long)cboFolioLoteCargaNomina.EditValue, sTipoMovimiento);

                //mostrar datos en base al IdLoteCargaNomina e IdTipoMovimiento
                this.stpSelNominaTimbreFacilCFDITableAdapter.Fill(this.dbSAICBPONominaCFDITimbreFacilDataSet1.stpSelNominaTimbreFacilCFDI, (long)cboFolioLoteCargaNomina.EditValue, sTipoMovimiento);
                //si existen registros
                if (this.dbSAICBPONominaCFDITimbreFacilDataSet1.stpSelNominaTimbreFacilCFDI.Count > 0)
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
                    XtraMessageBox.Show("¡El Lote de Nómina NO tiene registros para timbrar!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    //CONCEPTOS PAGO
                    //***PERCEPCIONES***
                    excell_app.addData(1, 79, "P", "");
                    excell_app.addData(1, 80, "\'001", "");
                    excell_app.addData(2, 79, "\'001", "");
                    excell_app.addData(2, 80, "Sueldos, Salarios Rayas y Jornales", "");

                    excell_app.addData(1, 81, "P", "");
                    excell_app.addData(1, 82, "\'002", "");
                    excell_app.addData(2, 81, "\'002", "");
                    excell_app.addData(2, 82, "Gratificacion Anual (Aguinaldo)", "");

                    excell_app.addData(1, 83, "P", "");
                    excell_app.addData(1, 84, "\'003", "");
                    excell_app.addData(2, 83, "\'003", "");
                    excell_app.addData(2, 84, "Participacion de los trabajadores en las utilidades PTU", "");

                    excell_app.addData(1, 85, "P", "");
                    excell_app.addData(1, 86, "\'004", "");
                    excell_app.addData(2, 85, "\'004", "");
                    excell_app.addData(2, 86, "Reembolso de Gastos Medicos Dentales y Hospitalarios", "");

                    excell_app.addData(1, 87, "P", "");
                    excell_app.addData(1, 88, "\'005", "");
                    excell_app.addData(2, 87, "\'005", "");
                    excell_app.addData(2, 88, "Fondo de Ahorro", "");

                    excell_app.addData(1, 89, "P", "");
                    excell_app.addData(1, 90, "\'006", "");
                    excell_app.addData(2, 89, "\'006", "");
                    excell_app.addData(2, 90, "Caja de Ahorro", "");

                    excell_app.addData(1, 91, "P", "");
                    excell_app.addData(1, 92, "\'007", "");
                    excell_app.addData(2, 91, "\'007", "");
                    excell_app.addData(2, 92, "Vales", "");

                    excell_app.addData(1, 93, "P", "");
                    excell_app.addData(1, 94, "\'008", "");
                    excell_app.addData(2, 93, "\'008", "");
                    excell_app.addData(2, 94, "Ayudas", "");

                    excell_app.addData(1, 95, "P", "");
                    excell_app.addData(1, 96, "\'009", "");
                    excell_app.addData(2, 95, "\'009", "");
                    excell_app.addData(2, 96, "Contribuciones a cargo del trabajador pagadas por el patron", "");

                    excell_app.addData(1, 97, "P", "");
                    excell_app.addData(1, 98, "\'010", "");
                    excell_app.addData(2, 97, "\'010", "");
                    excell_app.addData(2, 98, "Premios por puntualidad", "");

                    excell_app.addData(1, 99, "P", "");
                    excell_app.addData(1, 100, "\'011", "");
                    excell_app.addData(2, 99, "\'011", "");
                    excell_app.addData(2, 100, "Prima de Seguros de Vida", "");

                    excell_app.addData(1, 101, "P", "");
                    excell_app.addData(1, 102, "\'012", "");
                    excell_app.addData(2, 101, "\'012", "");
                    excell_app.addData(2, 102, "Seguro de Gastos Medicos Mayores", "");

                    excell_app.addData(1, 103, "P", "");
                    excell_app.addData(1, 104, "\'013", "");
                    excell_app.addData(2, 103, "\'013", "");
                    excell_app.addData(2, 104, "Coutas Sindicales Pagadas por el Patron", "");

                    excell_app.addData(1, 105, "P", "");
                    excell_app.addData(1, 106, "\'014", "");
                    excell_app.addData(2, 105, "\'014", "");
                    excell_app.addData(2, 106, "Subsidios por incapacidad", "");

                    excell_app.addData(1, 107, "P", "");
                    excell_app.addData(1, 108, "\'015", "");
                    excell_app.addData(2, 107, "\'015", "");
                    excell_app.addData(2, 108, "Becas para trabajadores y/o hijos", "");

                    excell_app.addData(1, 109, "P", "");
                    excell_app.addData(1, 110, "\'016", "");
                    excell_app.addData(2, 109, "\'016", "");
                    excell_app.addData(2, 110, "Otros", "");

                    excell_app.addData(1, 111, "P", "");
                    excell_app.addData(1, 112, "\'017", "");
                    excell_app.addData(2, 111, "\'017", "");
                    excell_app.addData(2, 112, "Subsidio para el empleo", "");

                    excell_app.addData(1, 113, "P", "");
                    excell_app.addData(1, 114, "\'018", "");
                    excell_app.addData(2, 113, "\'018", "");
                    excell_app.addData(2, 114, "Fomento al primer empleo", "");

                    excell_app.addData(1, 115, "P", "");
                    excell_app.addData(1, 116, "\'019", "");
                    excell_app.addData(2, 115, "\'019", "");
                    excell_app.addData(2, 116, "Horas Extra", "");

                    excell_app.addData(1, 117, "P", "");
                    excell_app.addData(1, 118, "\'020", "");
                    excell_app.addData(2, 117, "\'020", "");
                    excell_app.addData(2, 118, "Prima Dominical", "");

                    excell_app.addData(1, 119, "P", "");
                    excell_app.addData(1, 120, "\'021", "");
                    excell_app.addData(2, 119, "\'021", "");
                    excell_app.addData(2, 120, "Prima Vacacional", "");

                    excell_app.addData(1, 121, "P", "");
                    excell_app.addData(1, 122, "\'022", "");
                    excell_app.addData(2, 121, "\'022", "");
                    excell_app.addData(2, 122, "Prima por Antiguedad", "");

                    excell_app.addData(1, 123, "P", "");
                    excell_app.addData(1, 124, "\'023", "");
                    excell_app.addData(2, 123, "\'023", "");
                    excell_app.addData(2, 124, "Pagos por Separacion", "");

                    excell_app.addData(1, 125, "P", "");
                    excell_app.addData(1, 126, "\'024", "");
                    excell_app.addData(2, 125, "\'024", "");
                    excell_app.addData(2, 126, "Seguro de retiro", "");

                    excell_app.addData(1, 127, "P", "");
                    excell_app.addData(1, 128, "\'025", "");
                    excell_app.addData(2, 127, "\'025", "");
                    excell_app.addData(2, 128, "Indemnizaciones", "");

                    excell_app.addData(1, 129, "P", "");
                    excell_app.addData(1, 130, "\'026", "");
                    excell_app.addData(2, 129, "\'026", "");
                    excell_app.addData(2, 130, "Reembolso por funeral", "");

                    excell_app.addData(1, 131, "P", "");
                    excell_app.addData(1, 132, "\'027", "");
                    excell_app.addData(2, 131, "\'027", "");
                    excell_app.addData(2, 132, "Cuotas de Seguridad Social Pagadas por el patron", "");

                    excell_app.addData(1, 133, "P", "");
                    excell_app.addData(1, 134, "\'028", "");
                    excell_app.addData(2, 133, "\'028", "");
                    excell_app.addData(2, 134, "Comisiones", "");

                    excell_app.addData(1, 135, "P", "");
                    excell_app.addData(1, 136, "\'029", "");
                    excell_app.addData(2, 135, "\'029", "");
                    excell_app.addData(2, 136, "Vales de despensa", "");

                    excell_app.addData(1, 137, "P", "");
                    excell_app.addData(1, 138, "\'030", "");
                    excell_app.addData(2, 137, "\'030", "");
                    excell_app.addData(2, 138, "Vales de restaurante", "");

                    excell_app.addData(1, 139, "P", "");
                    excell_app.addData(1, 140, "\'031", "");
                    excell_app.addData(2, 139, "\'031", "");
                    excell_app.addData(2, 140, "Vales de gasolina", "");

                    excell_app.addData(1, 141, "P", "");
                    excell_app.addData(1, 142, "\'032", "");
                    excell_app.addData(2, 141, "\'032", "");
                    excell_app.addData(2, 142, "Vales de ropa", "");

                    excell_app.addData(1, 143, "P", "");
                    excell_app.addData(1, 144, "\'033", "");
                    excell_app.addData(2, 143, "\'033", "");
                    excell_app.addData(2, 144, "Ayuda para renta", "");

                    excell_app.addData(1, 145, "P", "");
                    excell_app.addData(1, 146, "\'034", "");
                    excell_app.addData(2, 145, "\'034", "");
                    excell_app.addData(2, 146, "Ayuda para artículos escolares", "");

                    excell_app.addData(1, 147, "P", "");
                    excell_app.addData(1, 148, "\'035", "");
                    excell_app.addData(2, 147, "\'035", "");
                    excell_app.addData(2, 148, "Ayuda para anteojos", "");

                    excell_app.addData(1, 149, "P", "");
                    excell_app.addData(1, 150, "\'036", "");
                    excell_app.addData(2, 149, "\'036", "");
                    excell_app.addData(2, 150, "Ayuda para transporte", "");

                    excell_app.addData(1, 151, "P", "");
                    excell_app.addData(1, 152, "\'037", "");
                    excell_app.addData(2, 151, "\'037", "");
                    excell_app.addData(2, 152, "Ayuda para gastos de funeral", "");

                    excell_app.addData(1, 153, "P", "");
                    excell_app.addData(1, 154, "\'038", "");
                    excell_app.addData(2, 153, "\'038", "");
                    excell_app.addData(2, 154, "Otros ingresos por salarios", "");

                    excell_app.addData(1, 155, "P", "");
                    excell_app.addData(1, 156, "\'039", "");
                    excell_app.addData(2, 155, "\'039", "");
                    excell_app.addData(2, 156, "Jubilaciones, pensiones o haberes de retiro", "");

                    //***DEDUCCIONES***
                    excell_app.addData(1, 157, "D", "");
                    excell_app.addData(1, 158, "\'001", "");
                    excell_app.addData(2, 157, "\'001", "");
                    excell_app.addData(2, 158, "Seguridad social", "");
                    //excell_app.addData(2, 158, "IMSS", "");

                    excell_app.addData(1, 159, "D", "");
                    excell_app.addData(1, 160, "\'002", "");
                    excell_app.addData(2, 159, "\'002", "");
                    excell_app.addData(2, 160, "ISR", "");

                    excell_app.addData(1, 161, "D", "");
                    excell_app.addData(1, 162, "\'003", "");
                    excell_app.addData(2, 161, "\'003", "");
                    //excell_app.addData(2, 162, "Aportacion a retiro, cesantia en edad avanzada y vejez", "");
                    excell_app.addData(2, 162, "RCV", "");

                    excell_app.addData(1, 163, "D", "");
                    excell_app.addData(1, 164, "\'004", "");
                    excell_app.addData(2, 163, "\'004", "");
                    excell_app.addData(2, 164, "Otro", "");

                    excell_app.addData(1, 165, "D", "");
                    excell_app.addData(1, 166, "\'005", "");
                    excell_app.addData(2, 165, "\'005", "");
                    excell_app.addData(2, 166, "Aportaciones a fondo de vivienda", "");

                    excell_app.addData(1, 167, "D", "");
                    excell_app.addData(1, 168, "\'006", "");
                    excell_app.addData(2, 167, "\'006", "");
                    excell_app.addData(2, 168, "Descuento por incapacidad", "");

                    excell_app.addData(1, 169, "D", "");
                    excell_app.addData(1, 170, "\'007", "");
                    excell_app.addData(2, 169, "\'007", "");
                    excell_app.addData(2, 170, "Pension Alimenticia", "");

                    excell_app.addData(1, 171, "D", "");
                    excell_app.addData(1, 172, "\'008", "");
                    excell_app.addData(2, 171, "\'008", "");
                    excell_app.addData(2, 172, "Renta", "");

                    excell_app.addData(1, 173, "D", "");
                    excell_app.addData(1, 174, "\'009", "");
                    excell_app.addData(2, 173, "\'009", "");
                    excell_app.addData(2, 174, "Prestamos provenientes del Fondo Nacional de la vivienda para los trabajadores", "");

                    excell_app.addData(1, 175, "D", "");
                    excell_app.addData(1, 176, "\'010", "");
                    excell_app.addData(2, 175, "\'010", "");
                    //excell_app.addData(2, 176, "Pago por credito de vivienda", "");
                    excell_app.addData(2, 176, "INFONAVIT", "");

                    excell_app.addData(1, 177, "D", "");
                    excell_app.addData(1, 178, "\'011", "");
                    excell_app.addData(2, 177, "\'011", "");
                    //excell_app.addData(2, 178, "Pago de abonos de Infonacot", "");
                    excell_app.addData(2, 178, "Prestamo Fonacot", "");

                    excell_app.addData(1, 179, "D", "");
                    excell_app.addData(1, 180, "\'012", "");
                    excell_app.addData(2, 179, "\'012", "");
                    excell_app.addData(2, 180, "Anticipo de Salarios", "");

                    excell_app.addData(1, 181, "D", "");
                    excell_app.addData(1, 182, "\'013", "");
                    excell_app.addData(2, 181, "\'013", "");
                    excell_app.addData(2, 182, "Pagos hechos con exceso al trabajador", "");

                    excell_app.addData(1, 183, "D", "");
                    excell_app.addData(1, 184, "\'014", "");
                    excell_app.addData(2, 183, "\'014", "");
                    excell_app.addData(2, 184, "Errores", "");

                    excell_app.addData(1, 185, "D", "");
                    excell_app.addData(1, 186, "\'015", "");
                    excell_app.addData(2, 185, "\'015", "");
                    excell_app.addData(2, 186, "Perdidas", "");

                    excell_app.addData(1, 187, "D", "");
                    excell_app.addData(1, 188, "\'016", "");
                    excell_app.addData(2, 187, "\'016", "");
                    excell_app.addData(2, 188, "Averias", "");

                    excell_app.addData(1, 189, "D", "");
                    excell_app.addData(1, 190, "\'017", "");
                    excell_app.addData(2, 189, "\'017", "");
                    excell_app.addData(2, 190, "Adquisicion de articulos producidos por la empresa o establecimiento", "");

                    excell_app.addData(1, 191, "D", "");
                    excell_app.addData(1, 192, "\'018", "");
                    excell_app.addData(2, 191, "\'018", "");
                    excell_app.addData(2, 192, "Cuotas para la constitucion y fomento de sociedades cooperativas y de cadas de ahorro", "");

                    excell_app.addData(1, 193, "D", "");
                    excell_app.addData(1, 194, "\'019", "");
                    excell_app.addData(2, 193, "\'019", "");
                    excell_app.addData(2, 194, "Cuotas sindicales", "");

                    excell_app.addData(1, 195, "D", "");
                    excell_app.addData(1, 196, "\'020", "");
                    excell_app.addData(2, 195, "\'020", "");
                    excell_app.addData(2, 196, "Ausencia (Ausentismo)", "");

                    excell_app.addData(1, 197, "D", "");
                    excell_app.addData(1, 198, "\'021", "");
                    excell_app.addData(2, 197, "\'021", "");
                    //excell_app.addData(2, 198, "Cuotas obrero Patronales", "");
                    excell_app.addData(2, 198, "IMSS", "");

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
                                foreach (stpSelDetalleNominaTimbreFacilCFDI_Result objDetalleNomina in context.stpSelDetalleNominaTimbreFacilCFDI((long)cboFolioLoteCargaNomina.EditValue, intPDOHeader, sTipoMovimiento))
                                {
                                    sNombreEmpleado = objDetalleNomina.NombreEmpleado;  //almacenar nombre empleado para errores

                                    excell_app.addData(intNoRenglonExcel, 1, pNoFolioSiguiente.ToString(), "");
                                    excell_app.addData(intNoRenglonExcel, 2, objDetalleNomina.Subtotal.ToString(), "");
                                    excell_app.addData(intNoRenglonExcel, 3, objDetalleNomina.Descuento.ToString(), "");
                                    excell_app.addData(intNoRenglonExcel, 4, objDetalleNomina.Total.ToString(), "");
                                    excell_app.addData(intNoRenglonExcel, 5, objDetalleNomina.MetodoPago, "");
                                    excell_app.addData(intNoRenglonExcel, 6, objInfoEncabezadoTimbreFacil.LeyendaLugarExpedicion, "");
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
                                    excell_app.addData(intNoRenglonExcel, 23, objDetalleNomina.IdTipoRegimen.ToString(), "");
                                    excell_app.addData(intNoRenglonExcel, 24, "\'" + objDetalleNomina.NSS.PadLeft(11, '0'), "");
                                    excell_app.addData(intNoRenglonExcel, 25, "!" + Conversiones.AgregarDiagonales2Fecha(Conversiones.ConvertirFechaAAAAMMDD(dtFechaPago.EditValue.ToString())), "");
                                    excell_app.addData(intNoRenglonExcel, 26, "!" + Conversiones.AgregarDiagonales2Fecha(Conversiones.ConvertirFechaAAAAMMDD(objDetalleNomina.FechaInicialPago.ToString())), "");
                                    excell_app.addData(intNoRenglonExcel, 27, "!" + Conversiones.AgregarDiagonales2Fecha(Conversiones.ConvertirFechaAAAAMMDD(objDetalleNomina.FechaFinalPago.ToString())), "");
                                    excell_app.addData(intNoRenglonExcel, 28, objDetalleNomina.NoDiasPagados.ToString(), "");
                                    excell_app.addData(intNoRenglonExcel, 29, objDetalleNomina.Departamento, "");
                                    excell_app.addData(intNoRenglonExcel, 30, objDetalleNomina.CLABE, "");
                                    excell_app.addData(intNoRenglonExcel, 31, objDetalleNomina.Banco, "");
                                    excell_app.addData(intNoRenglonExcel, 32, "!" + Conversiones.AgregarDiagonales2Fecha(Conversiones.ConvertirFechaAAAAMMDD(objDetalleNomina.FechaIngreso.ToString())), "");
                                    excell_app.addData(intNoRenglonExcel, 33, objDetalleNomina.Antiguedad.ToString(), "");
                                    excell_app.addData(intNoRenglonExcel, 34, objDetalleNomina.Puesto, "");
                                    excell_app.addData(intNoRenglonExcel, 35, objDetalleNomina.TipoContrato, "");
                                    excell_app.addData(intNoRenglonExcel, 36, objDetalleNomina.TipoJornada, "");
                                    excell_app.addData(intNoRenglonExcel, 37, objDetalleNomina.PeriodicidadPago, "");
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
                                    excell_app.addData(intNoRenglonExcel, 53, objDetalleNomina.DiasHorasExtrasDobles.ToString(), "");
                                    excell_app.addData(intNoRenglonExcel, 54, objDetalleNomina.TipoHorasExtrasDobles, "");
                                    excell_app.addData(intNoRenglonExcel, 55, 0.ToString(), "");       //***
                                    excell_app.addData(intNoRenglonExcel, 56, 0.ToString(), "");
                                    excell_app.addData(intNoRenglonExcel, 57, objDetalleNomina.DiasHorasExtrasDobles.ToString(), "");
                                    excell_app.addData(intNoRenglonExcel, 58, objDetalleNomina.TipoHorasExtrasDobles, "");
                                    excell_app.addData(intNoRenglonExcel, 59, 0.ToString(), "");       //***
                                    excell_app.addData(intNoRenglonExcel, 60, 0.ToString(), "");
                                    excell_app.addData(intNoRenglonExcel, 61, objDetalleNomina.DiasHorasExtrasDobles.ToString(), "");
                                    excell_app.addData(intNoRenglonExcel, 62, objDetalleNomina.TipoHorasExtrasDobles, "");
                                    excell_app.addData(intNoRenglonExcel, 63, 0.ToString(), "");       //***
                                    excell_app.addData(intNoRenglonExcel, 64, 0.ToString(), "");
                                    excell_app.addData(intNoRenglonExcel, 65, objDetalleNomina.DiasHorasExtrasDobles.ToString(), "");
                                    excell_app.addData(intNoRenglonExcel, 66, objDetalleNomina.TipoHorasExtrasDobles, "");
                                    excell_app.addData(intNoRenglonExcel, 67, 0.ToString(), "");       //***
                                    excell_app.addData(intNoRenglonExcel, 68, 0.ToString(), "");
                                    excell_app.addData(intNoRenglonExcel, 69, objDetalleNomina.DiasHorasExtrasDobles.ToString(), "");
                                    excell_app.addData(intNoRenglonExcel, 70, objDetalleNomina.TipoHorasExtrasDobles, "");
                                    excell_app.addData(intNoRenglonExcel, 71, 0.ToString(), "");       //***
                                    excell_app.addData(intNoRenglonExcel, 72, 0.ToString(), "");
                                    excell_app.addData(intNoRenglonExcel, 74, objDetalleNomina.CorreoElectronico, "");

                                    //inicializar columnas de importes gravados y exentos
                                    excell_app.assignInitialValue("0", "CA" + intNoRenglonExcel.ToString(), "GP" + intNoRenglonExcel.ToString());        //asignar valores iniciales en celdas

                                    //detalle Percepciones y Deducciones
                                    var DetallePercepcionesDeducciones = from row in db.stpSelPercepcionesDeduccionesGravadoExentoTimbreFacil((long)cboFolioLoteCargaNomina.EditValue, sTipoMovimiento).Where(row => row.IdPDOHeader == intPDOHeader)
                                                                         select row;

                                    foreach (var item in DetallePercepcionesDeducciones)
                                    {
                                        excell_app.addData(intNoRenglonExcel, item.NoColumnaGravadaLayoutTimbreFacil, item.MontoPDOGravado.ToString(), "");
                                        excell_app.addData(intNoRenglonExcel, item.NoColumnaExentaLayoutTimbreFacil, item.MontoPDOExento.ToString(), "");

                                        //registrar importe de ISR total
                                        if (item.ClasifConceptoCFDI.Equals("D") && item.ClaveConceptoCFDI.Equals("002"))
                                        {
                                            //ISR
                                            //excell_app.addData(intNoRenglonExcel, 73, item.MontoPDOGravado.ToString(), "");
                                            excell_app.addData(intNoRenglonExcel, 73, "0", "");
                                        }
                                    }

                                    //CORREO ELECTRONICO
                                    excell_app.addData(intNoRenglonExcel, 74, objDetalleNomina.CorreoElectronico, "");

                                    //acumuladores de Percepciones y Deducciones
                                    decMontoTotalPercepciones += objDetalleNomina.Subtotal;
                                    decMontoTotalDeducciones += objDetalleNomina.Descuento;
                                }
                            }
                            intNoRegistro++;    //incrementar contador registro
                            intNoRenglonExcel++;    //incrementar contador de renglon
                            pNoFolioSiguiente++;        //incrementar el Folio Siguiente

                        }   //if  chkListNominas.GetItemCheckState(i)
                    }  //for

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