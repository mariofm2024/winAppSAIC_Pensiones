using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using compCatalogosSAIC;
using System.Diagnostics;

namespace winAppSAIC.Juridico
{
    public partial class XtraActualizacionMasivaEmpleados : DevExpress.XtraEditors.XtraForm
    {
        tools.dsc dsc = new tools.dsc();
        String stLog;
        String[] StTitulos_FechaIngreso;
        String[] StTitulos_Puesto;
        String[] StTitulos_Departamento;
        String[] StTitulos_CorreElectronico;
        String[] StTitulos_Funciones;
        String[] StTitulos_Cliente_Tenedora;
        String[] StTitulos_CentroDeCosto;
        String[] StTitulos_Direccion;
        String[] StTitulos_Fiscal;
        String[] StTitulos_TipoContrato;
        String[] StTitulos_NombreEmpleado;
        String[] StTitulos_SalarioDiarioCliente;

        public XtraActualizacionMasivaEmpleados()
        {
            InitializeComponent();
        }

        private void XtraActualizacionMasivaEmpleados_Load(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager3.ShowWaitForm();

                stpSelObtenerEmpleado_ActualizacionMasivaTableAdapter1.Fill(dbSAICBPOActualizacionesIMSSDataSet1.stpSelObtenerEmpleado_ActualizacionMasiva, 0);
                vwCatTenedoraSATableAdapter1.Fill(dbSAICBPODataSet1.vwCatTenedoraSA);
                stpSelClientesConfidencialTableAdapter.Fill(dbSAICBPOCatalogosDataSet1.stpSelClientesConfidencial, true);
                iniTitulosExcel();
                habilitarOpciones();
                cboIdCliente.Properties.PopupFormWidth = 700;
                cboIdTenedora.Properties.PopupFormWidth = 700;
                if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
            }
            catch (Exception ex)
            {
                if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                XtraMessageBox.Show("No se puede cagar la informacion. " + ex.Message, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iniTitulosExcel()
        {
            StTitulos_FechaIngreso = new String[]
           {
                "IdEmpleado",
                "NombreEmpleadoCompleto",
                "NSS",
                "RFC",
                "CURP",
                "FechaIngresoCliente",
                "FechaIngresoContrato"};

            StTitulos_Puesto = new String[]
            {
                "IdEmpleado",
                "NombreEmpleadoCompleto",
                "NSS",
                "RFC",
                "CURP",
                "PuestoCliente",
                "PuestoContrato"};

            StTitulos_Departamento = new String[]
           {
                "IdEmpleado",
                "NombreEmpleadoCompleto",
                "NSS",
                "RFC",
                "CURP",
                "DepartamentoCliente",
                "DepartamentoContrato"};

            StTitulos_CorreElectronico = new String[]
            {
                "IdEmpleado",
                "NombreEmpleadoCompleto",
                "NSS",
                "RFC",
                "CURP",
                "CorreoElectronico"};

            StTitulos_Funciones = new String[]
           {
                "IdEmpleado",
                "NombreEmpleadoCompleto",
                "NSS",
                "RFC",
                "CURP",
                "FuncionesEmpleado"};

            StTitulos_Cliente_Tenedora = new String[]
            {
                "IdEmpleado",
                "NombreEmpleadoCompleto",
                "NSS",
                "RFC",
                "CURP"};

            StTitulos_CentroDeCosto = new String[]
         {
                "IdEmpleado",
                "NombreEmpleadoCompleto",
                "NSS",
                "RFC",
                "CURP",
                "CentroDeCosto"};

            StTitulos_Direccion = new String[]
         {
                "IdEmpleado",
                "NombreEmpleadoCompleto",
                "NSS",
                "RFC",
                "CURP",
                "Calle",
                "NoExterior",
                "NoInterior",
                "Colonia",
                "CodigoPostal",
                "NombreDelegacionMunicipio",
                "Estado"};

            StTitulos_Fiscal = new String[] {
                "IdEmpleado",
                "NombreEmpleadoCompleto",
                "NSS",
                "RFC",
                "CURP",
                "CodigoPostal"
            };

            StTitulos_TipoContrato = new String[] {
                "IdEmpleado",
                "NombreEmpleadoCompleto",
                "NSS",
                "RFC",
                "CURP",
                "Tipo Contrato",
                "Fecha Inicio Contrato CIT",
                "Tiempo Contrato CIT"
            };

            StTitulos_NombreEmpleado = new String[] {
                "IdEmpleado",
                "NombreEmpleadoCompleto",
                "NSS",
                "RFC",
                "CURP",
                "APaternoEmpleado",
                "AMaternoEmpleado",
                "NombreEmpleado"
            };

            StTitulos_SalarioDiarioCliente = new String[] {
                "IdEmpleado",
                "NombreEmpleadoCompleto",
                "NSS",
                "RFC",
                "CURP",
                "SalarioDiarioCliente"
            };
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            rdioCorreo.Enabled = true;
            rdioPuesto.Enabled = true;
            rdioDepartamento.Enabled = true;
            rdioFunciones.Enabled = true;
            rdioFechaIngreso.Enabled = true;
            rdioCliente.Enabled = true;
            rdioTenedora.Enabled = true;
            rdioCentroDeCosto.Enabled = true;
            rbCentroDeTrabajo.Enabled = true;
            rbParticular.Enabled = true;
            rbFiscal.Enabled = true;
            rdioTipoContrato.Enabled = true;
            rdioNombreEmpleado.Enabled = true;
            rdioSalarioDiarioCliente.Enabled = true;

            gridControl1EmpleadosExcel.DataSource = null;
            lblEmpleadosConError.Text = "0";
            lblRegistrosSeleccionados.Text = "0";
            lblTotaldeEmpleados.Text = "0";
            gridControl1EmpleadosExcel.DataSource = null;
        }

        private void rdioFechaContrato_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdioCliente_CheckedChanged(object sender, EventArgs e)
        {
            desCheckOpcionesDireccion();
            if (cboIdCliente.Enabled)
                cboIdCliente.Enabled = false;
            else
                cboIdCliente.Enabled = true;
        }

        private void rdioTenedora_CheckedChanged(object sender, EventArgs e)
        {
            desCheckOpcionesDireccion();
            if (cboIdTenedora.Enabled)
                cboIdTenedora.Enabled = false;
            else
                cboIdTenedora.Enabled = true;
        }

        private void btnDescargarLayout_Click(object sender, EventArgs e)
        {
            ObtenerArchivoLayout();
        }

        /// <summary>
        /// Obtener datos filtrados
        /// </summary>
        private void ObtenerDatosFiltrados()
        {

            gridView1.Columns[0].Visible = true; //IdEmpleado
            gridView1.Columns[1].Visible = true; //NombreEmpleadoCompleto
            gridView1.Columns[2].Visible = true; //NSS
            gridView1.Columns[3].Visible = true; //RFC
            gridView1.Columns[4].Visible = true; //CURP

            gridView1.Columns[5].Visible = false; //FechaIngresoCliente
            gridView1.Columns[6].Visible = false; //FechaIngresoContrato
            gridView1.Columns[7].Visible = false; //PuestoCliente
            gridView1.Columns[8].Visible = false; //PuestoContrato
            gridView1.Columns[9].Visible = false; //DepartamentoCliente
            gridView1.Columns[10].Visible = false; //DepartamentoContrato
            gridView1.Columns[11].Visible = false; //FuncionesEmpleado
            gridView1.Columns[12].Visible = false; //CorreoElectronico
            gridView1.Columns[13].Visible = false; //CentroDeCosto

            gridView1.Columns[14].Visible = false;//Calle
            gridView1.Columns[15].Visible = false;//NoExterior
            gridView1.Columns[16].Visible = false;//NoInterior
            gridView1.Columns[17].Visible = false;//Colonia
            gridView1.Columns[18].Visible = false;//CodigoPostal
            gridView1.Columns[19].Visible = false;//NombreDelegacionMunicipio   
            gridView1.Columns[20].Visible = false;//IdEstado

            gridView1.Columns[21].Visible = false;//
            gridView1.Columns[22].Visible = false;//
            gridView1.Columns[23].Visible = false;//

            gridView1.Columns[24].Visible = false;//
            gridView1.Columns[25].Visible = false;//
            gridView1.Columns[26].Visible = false;//

            gridView1.Columns[27].Visible = false;//

            if (rdioFechaIngreso.Checked)
            {
                gridView1.Columns[5].Visible = true; //FechaIngresoCliente
                gridView1.Columns[6].Visible = true; //FechaIngresoContrato
                gridView1.Columns[5].VisibleIndex = 5;
                gridView1.Columns[6].VisibleIndex = 6;
            }
            else if (rdioPuesto.Checked)
            {
                gridView1.Columns[7].Visible = true; //PuestoCliente
                gridView1.Columns[8].Visible = true; //PuestoContrato
                gridView1.Columns[7].VisibleIndex = 7;
                gridView1.Columns[8].VisibleIndex = 8;
            }
            else if (rdioDepartamento.Checked)
            {
                gridView1.Columns[9].Visible = true; //DepartamentoCliente
                gridView1.Columns[10].Visible = true; //DepartamentoContrato
                gridView1.Columns[9].VisibleIndex = 9;
                gridView1.Columns[10].VisibleIndex = 10;
            }
            else if (rdioFunciones.Checked)
            {
                gridView1.Columns[11].Visible = true; //FuncionesEmpleado
                gridView1.Columns[11].VisibleIndex = 11;
            }
            else if (rdioCorreo.Checked)
            {
                gridView1.Columns[12].Visible = true; //CorreoElectronico
                gridView1.Columns[12].VisibleIndex = 12;
            }
            else if (rdioCentroDeCosto.Checked)
            {
                gridView1.Columns[13].Visible = true; //CentroDeCosto
                gridView1.Columns[13].VisibleIndex = 12;
            }
            else if (rbCentroDeTrabajo.Checked || rbParticular.Checked)
            {
                gridView1.Columns[14].Visible = true;//Calle
                gridView1.Columns[14].VisibleIndex = 14;//Calle

                gridView1.Columns[15].Visible = true;//NoExterior
                gridView1.Columns[15].VisibleIndex = 15;//NoExterior

                gridView1.Columns[16].Visible = true;//NoInterior
                gridView1.Columns[16].VisibleIndex = 16;//NoInterior

                gridView1.Columns[17].Visible = true;//Colonia
                gridView1.Columns[17].VisibleIndex = 17;//Colonia

                gridView1.Columns[18].Visible = true;//CodigoPostal
                gridView1.Columns[18].VisibleIndex = 18;//CodigoPostal

                gridView1.Columns[19].Visible = true;//NombreDelegacionMunicipio
                gridView1.Columns[19].VisibleIndex = 19;//NombreDelegacionMunicipio

                gridView1.Columns[20].Visible = true;//IdEstado
                gridView1.Columns[20].VisibleIndex = 20;//IdEstado
            }
            else if (rbFiscal.Checked)
            {
                gridView1.Columns[18].Visible = true;//CodigoPostal
                gridView1.Columns[18].VisibleIndex = 18;//CodigoPostal
            }
            else if (rdioTipoContrato.Checked)
            {
                gridView1.Columns[21].Visible = true;//
                gridView1.Columns[21].VisibleIndex = 21;//

                gridView1.Columns[22].Visible = true;//
                gridView1.Columns[22].VisibleIndex = 22;//

                gridView1.Columns[23].Visible = true;//
                gridView1.Columns[23].VisibleIndex = 23;//
            }
            else if (rdioNombreEmpleado.Checked)
            {
                gridView1.Columns[24].Visible = true;//
                gridView1.Columns[24].VisibleIndex = 24;

                gridView1.Columns[25].Visible = true;//
                gridView1.Columns[25].VisibleIndex = 25;

                gridView1.Columns[26].Visible = true;//
                gridView1.Columns[26].VisibleIndex = 26;
            }
            else if (rdioSalarioDiarioCliente.Checked)
            {
                gridView1.Columns[27].Visible = true;//
                gridView1.Columns[27].VisibleIndex = 27;
            }

            //for (int i = 0; i < gridView1.Columns.Count; i++)
            //{
            //    gridView1.Columns[i].VisibleIndex = i;
            //}

        }

        private void btnValidarInformacion_Click(object sender, EventArgs e)
        {
            flagValidacionConErrores = false;
            txtNumEmpleados.Text = "0";
            txtEmpleadosConError.Text = "0";
            txtSeleccionados.Text = "0";

            if (rdioCorreo.Checked || rdioPuesto.Checked || rdioDepartamento.Checked ||
                rdioFunciones.Checked || rdioCliente.Checked || rdioFechaIngreso.Checked ||
               rdioTenedora.Checked || rdioCentroDeCosto.Checked ||
               rbCentroDeTrabajo.Checked || rbParticular.Checked || rbFiscal.Checked
               || rdioTipoContrato.Checked || rdioNombreEmpleado.Checked || rdioSalarioDiarioCliente.Checked)
            {
                if (rdioCliente.Checked && cboIdCliente.EditValue == null)
                {
                    XtraMessageBox.Show("Seleccione un Cliente para continuar."
                                 , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboIdCliente.Focus();
                }
                else if (rdioTenedora.Checked && cboIdTenedora.EditValue == null)
                {
                    XtraMessageBox.Show("Seleccione una Tenedora para continuar."
                                  , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboIdTenedora.Focus();
                }
                else
                {
                    if (String.IsNullOrEmpty(txtRutaArchivo.Text))
                    {
                        stLog = dsc.addLog(stLog, "Obteniendo Excel");
                        ObtenerArchivo.Filter = "Excel Files (*.xls;*.xlsm;*.xlsb;*.xlsx)|*.xls;*.xlsm;*.xlsb;*.xlsx";
                        ObtenerArchivo.ShowDialog();

                        if (File.Exists(ObtenerArchivo.FileName))
                        {
                            txtRutaArchivo.Text = ObtenerArchivo.FileName;
                            stLog = dsc.addLog(stLog, "Excel: " + ObtenerArchivo.FileName);
                        }
                        else
                        {
                            ObtenerArchivo.FileName = String.Empty;
                            txtRutaArchivo.Text = String.Empty;
                        }
                    }

                    if (!String.IsNullOrEmpty(ObtenerArchivo.FileName))
                    {
                        if (File.Exists(txtRutaArchivo.Text))
                        {
                            splashScreenManager3.ShowWaitForm();

                            String stUltimaColumna = String.Empty;
                            String stLasColumnas = String.Empty;

                            stUltimaColumna = ObtenerUlitmaColumna();
                            stLasColumnas = ObtenerTitulos();

                            stLog = dsc.addLog(stLog, "Obteniendo Columnas");

                            splashScreenManager3.SetWaitFormDescription("Obteniendo Informacion");
                            stLog = dsc.addLog(stLog, "Obteniendo Informacion");

                            DataTable dtArchivoEmpleado = dsc.ConvertExcelToDataTable(txtRutaArchivo.Text, stUltimaColumna);
                            dtArchivoEmpleado = quitarVacios(dtArchivoEmpleado);

                            if (dtArchivoEmpleado.Rows.Count > 2)
                            {
                                //Validar titulos
                                String stLasColumnasArchivo = String.Empty;

                                foreach (DataColumn item in dtArchivoEmpleado.Columns) { stLasColumnasArchivo += item.ColumnName; }

                                splashScreenManager3.SetWaitFormDescription("Validando Columnas");
                                stLog = dsc.addLog(stLog, "Validando Columnas");

                                if (dsc.fonetica(stLasColumnas, stLasColumnasArchivo))
                                {

                                    //**********************Validar Informacion**********************
                                    validarInformacionLayOut(dtArchivoEmpleado);
                                    //**********************Validar Informacion**********************

                                    txtRutaArchivo.Text = String.Empty;

                                    stLog = dsc.addLog(stLog, "Proceso de Validacion Terminado");
                                    splashScreenManager3.SetWaitFormDescription("Proceso Terminado");

                                    if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }


                                    XtraMessageBox.Show(flagValidacionConErrores ? "Validacion Terminada con Errores." : "Validacion Termianda"
                                    , "SAIC", MessageBoxButtons.OK, flagValidacionConErrores ? MessageBoxIcon.Warning : MessageBoxIcon.Information);

                                }
                                else
                                {
                                    if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                                    XtraMessageBox.Show("El LayOut que se selecciono no contiene la estructura correcta, por favor seleccione unLayOut valido."
                                 , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                                XtraMessageBox.Show("El Archivo No cuenta con Informacion minima para Masivo (3)"
                                  , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                            XtraMessageBox.Show("No existe el Archivo seleccionado: " + txtRutaArchivo.Text
                                  , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }


            }
            else
            {
                MessageBox.Show("Selecione una caracteristica para validar el LayOut", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private DataTable quitarVacios(DataTable dtArchivoEmpleado)
        {
            DataTable dtResutado = new DataTable();
            dtResutado = dtArchivoEmpleado.Clone();

            var res = from x in dtArchivoEmpleado.AsEnumerable()
                      where x.Field<String>("Id Empleado") != ""
                      select x;

            if (res.Count() > 0)
            {
                dtResutado = res.CopyToDataTable();
            }

            return dtResutado;
        }

        private String ObtenerUlitmaColumna()
        {
            String stUltimaColumna = String.Empty;

            if (rdioFechaIngreso.Checked || rdioPuesto.Checked || rdioDepartamento.Checked)
            {
                stUltimaColumna = "G";
            }
            else if (rdioCorreo.Checked || rdioFunciones.Checked || rdioCentroDeCosto.Checked || rbFiscal.Checked || rdioSalarioDiarioCliente.Checked)
            {
                stUltimaColumna = "F";
            }
            else if (rbCentroDeTrabajo.Checked || rbParticular.Checked)
            {
                stUltimaColumna = "L";
            }
            else if (rdioTipoContrato.Checked || rdioNombreEmpleado.Checked)
            {
                stUltimaColumna = "H";
            }
            else
            {
                stUltimaColumna = "E";
            }

            return stUltimaColumna;
        }

        private String ObtenerTitulos()
        {
            String[] titulos;
            String stTitulos;

            if (rdioFechaIngreso.Checked)
            {
                titulos = StTitulos_FechaIngreso;
            }
            else if (rdioPuesto.Checked)
            {
                titulos = StTitulos_Puesto;
            }
            else if (rdioDepartamento.Checked)
            {
                titulos = StTitulos_Departamento;
            }
            else if (rdioCorreo.Checked)
            {
                titulos = StTitulos_CorreElectronico;
            }
            else if (rdioFunciones.Checked)
            {
                titulos = StTitulos_Funciones;
            }
            else if (rdioTenedora.Checked || rdioCliente.Checked)
            {
                titulos = StTitulos_Cliente_Tenedora;
            }
            else if (rdioCentroDeCosto.Checked)
            {
                titulos = StTitulos_CentroDeCosto;
            }
            else if (rbCentroDeTrabajo.Checked || rbParticular.Checked)
            {
                titulos = StTitulos_Direccion;
            }
            else if (rbFiscal.Checked)
            {
                titulos = StTitulos_Fiscal;
            }
            else if (rdioTipoContrato.Checked)
            {
                titulos = StTitulos_TipoContrato;
            }
            else if (rdioNombreEmpleado.Checked)
            {
                titulos = StTitulos_NombreEmpleado;
            }
            else if (rdioSalarioDiarioCliente.Checked)
            {
                titulos = StTitulos_SalarioDiarioCliente;
            }
            else
            {
                titulos = new string[0];
            }

            stTitulos = String.Join("", titulos).ToUpper().Replace(" ", "");
            return stTitulos;
        }

        Boolean flagValidacionConErrores = false;

        private void validarInformacionLayOut(DataTable dtArchivoEmpleado)
        {
            gridControl1EmpleadosExcel.DataSource = null;

            gCtrlEmpleadosFiltrados.Visible = true;
            DataTable stEmpleadosBase = dsc.deGridViewaDataTable(gridView1);
            gCtrlEmpleadosFiltrados.Visible = false;
            DataTable dtEmpleadosResultado = dtArchivoEmpleado.Clone();

            if (rdioTipoContrato.Checked)
            {
                dtEmpleadosResultado.Columns.Add("Fecha Vigencia CIT", typeof(DateTime));
            }

            dtEmpleadosResultado.Columns.Add("Errores", typeof(String));
            int iNumErrores = 0;
            int iConta = 0;

            foreach (DataRow unRow in dtArchivoEmpleado.Rows)
            {
                iConta++;
                splashScreenManager3.SetWaitFormDescription(iConta + " de " + dtArchivoEmpleado.Rows.Count);

                String stError = String.Empty;
                DataRow[] existeEmpleado = stEmpleadosBase.Select("IdEmpleado = " + "'" + unRow[0] + "'");

                DataRow drEmpleado = dtEmpleadosResultado.NewRow();

                if (existeEmpleado.Length > 0)
                {
                    if (existeEmpleado[0].ItemArray[2].ToString() + existeEmpleado[0].ItemArray[3].ToString() + existeEmpleado[0].ItemArray[4].ToString() ==
                            unRow["NSS"].ToString() + unRow["RFC"].ToString() + unRow["CURP"].ToString())
                    {
                        if (rdioFechaIngreso.Checked)
                        {
                            stError = valInfoFechaIngreso(unRow);
                            drEmpleado["Fecha Ingreso Cliente"] = unRow["Fecha Ingreso Cliente"].ToString();
                            drEmpleado["Fecha Ingreso Contrato"] = unRow["Fecha Ingreso Contrato"].ToString();
                        }
                        else if (rdioPuesto.Checked)
                        {
                            stError = valInfoPuesto(unRow);
                            drEmpleado["Puesto Cliente"] = unRow["Puesto Cliente"].ToString();
                            drEmpleado["Puesto Contrato"] = unRow["Puesto Contrato"].ToString();
                        }
                        else if (rdioDepartamento.Checked)
                        {
                            stError = valInfoDepartamento(unRow);
                            drEmpleado["Departamento Cliente"] = unRow["Departamento Cliente"].ToString();
                            drEmpleado["Departamento Contrato"] = unRow["Departamento Contrato"].ToString();
                        }
                        else if (rdioFunciones.Checked)
                        {
                            stError = valInfoFunciones(unRow);
                            drEmpleado["Funciones Empleado"] = unRow["Funciones Empleado"].ToString();
                        }
                        else if (rdioCorreo.Checked)
                        {
                            stError = valInfoCorreoElectronico(unRow);
                            drEmpleado["Correo Electronico"] = unRow["Correo Electronico"].ToString();
                        }
                        else if (rdioCliente.Checked || rdioTenedora.Checked)
                        {
                            int idCliente = 0;
                            int idTenedora = 0;

                            idCliente = cboIdCliente.EditValue == null ? 0 : Convert.ToInt32(cboIdCliente.EditValue.ToString());
                            idTenedora = cboIdTenedora.EditValue == null ? 0 : Convert.ToInt32(cboIdTenedora.EditValue.ToString());

                            stError = valInfoClienteTenedora(unRow, idCliente, idTenedora);
                        }
                        else if (rdioCentroDeCosto.Checked)
                        {
                            stError = valInfoCentroDeCosto(unRow);
                            drEmpleado["Centro De Costo"] = unRow["Centro De Costo"].ToString();
                        }
                        else if (rbCentroDeTrabajo.Checked || rbParticular.Checked)
                        {
                            stError = valInfoDireccion(unRow);
                            drEmpleado["Calle"] = unRow["Calle"].ToString();
                            drEmpleado["NoExterior"] = unRow["NoExterior"].ToString();
                            drEmpleado["NoInterior"] = unRow["NoInterior"].ToString();
                            drEmpleado["Colonia"] = unRow["Colonia"].ToString();
                            drEmpleado["CodigoPostal"] = unRow["CodigoPostal"].ToString();
                            drEmpleado["NombreDelegacionMunicipio"] = unRow["NombreDelegacionMunicipio"].ToString();
                            drEmpleado["Estado"] = unRow["Estado"].ToString();
                        }
                        else if (rbFiscal.Checked)
                        {
                            stError = valInfoDireccionFiscal(unRow);
                            drEmpleado["CODIGOPOSTAL"] = unRow["CodigoPostal"].ToString();
                        }
                        else if (rdioTipoContrato.Checked)
                        {
                            stError = valInfoTipoContrato(unRow);
                            drEmpleado["Tipo Contrato"] = unRow["Tipo Contrato"].ToString();
                            drEmpleado["Fecha Inicio Contrato CIT"] = unRow["Fecha Inicio Contrato CIT"].ToString();
                            drEmpleado["Tiempo Contrato CIT"] = unRow["Tiempo Contrato CIT"].ToString();
                            drEmpleado["Fecha Vigencia CIT"] = dVigenciaContratoCit;
                        }
                        else if (rdioNombreEmpleado.Checked)
                        {
                            stError = valInfoNombreEmpleado(unRow);
                            drEmpleado["APaternoEmpleado"] = unRow["APaternoEmpleado"].ToString();
                            drEmpleado["AMaternoEmpleado"] = unRow["AMaternoEmpleado"].ToString();
                            drEmpleado["NombreEmpleado"] = unRow["NombreEmpleado"].ToString();
                        }
                        else if (rdioSalarioDiarioCliente.Checked)
                        {
                            stError = valSalarioDiarioCliente(unRow);
                            drEmpleado["SalarioDiarioCliente"] = unRow["SalarioDiarioCliente"].ToString();
                        }
                    }
                    else
                    {
                        flagValidacionConErrores = true;
                        stError = "Los datos del empleado NSS, RFC o CURP con coinciden con los de SAIC";
                    }
                }
                else
                {
                    flagValidacionConErrores = true;
                    stError = "No existe el empleado en SAIC";
                }

                if (!String.IsNullOrEmpty(stError)) { iNumErrores++; }

                drEmpleado["Id Empleado"] = unRow["Id Empleado"];
                drEmpleado["Nombre Empleado Completo"] = unRow["Nombre Empleado Completo"];
                drEmpleado["NSS"] = unRow["NSS"].ToString();
                drEmpleado["RFC"] = unRow["RFC"].ToString();
                drEmpleado["CURP"] = unRow["CURP"].ToString();
                drEmpleado["Errores"] = stError;

                dtEmpleadosResultado.Rows.Add(drEmpleado);
            }


            rdioCorreo.Enabled = rdioCorreo.Checked;
            rdioPuesto.Enabled = rdioPuesto.Checked;
            rdioDepartamento.Enabled = rdioDepartamento.Checked;
            rdioFunciones.Enabled = rdioFunciones.Checked;
            rdioFechaIngreso.Enabled = rdioFechaIngreso.Checked;
            rdioCliente.Enabled = rdioCliente.Checked;
            rdioTenedora.Enabled = rdioTenedora.Checked;
            rdioCentroDeCosto.Enabled = rdioCentroDeCosto.Checked;
            rdioTipoContrato.Enabled = rdioTipoContrato.Checked;
            rdioNombreEmpleado.Enabled = rdioNombreEmpleado.Checked;
            rdioSalarioDiarioCliente.Enabled = rdioSalarioDiarioCliente.Checked;

            txtNumEmpleados.Text = dtEmpleadosResultado.Rows.Count.ToString();

            txtEmpleadosConError.Text = (from x in dtEmpleadosResultado.AsEnumerable()
                                         where !String.IsNullOrEmpty(x.Field<String>("Errores"))
                                         select x).ToList().Count().ToString();



            gridView2Empleados.Columns.Clear();

            gridControl1EmpleadosExcel.DataSource = dtEmpleadosResultado;

            rbCentroDeTrabajo.Enabled = rbCentroDeTrabajo.Checked;
            rbParticular.Enabled = rbParticular.Checked;
            rbFiscal.Enabled = rbFiscal.Checked;

            //if (rbCentroDeTrabajo.Checked || rbParticular.Checked || rbFiscal.Checked)
            //{
            //    rbCentroDeTrabajo.Enabled = true;
            //    rbParticular.Enabled = true;
            //    rbFiscal.Enabled = true;
            //}
            //else
            //{
            //    rbCentroDeTrabajo.Enabled = false;
            //    rbParticular.Enabled = false;
            //    rbFiscal.Enabled = false;
            //}
        }

        private String valInfoFechaIngreso(DataRow dtUnRow)
        {
            int idEmpleado = 0;
            String stError = String.Empty;
            DateTime dtFCliente = new DateTime();
            DateTime dtFContrato = new DateTime();
            DateTime? stFechaVigenciaContrato = new DateTime(1900, 01, 01);
            int.TryParse(dtUnRow["Id Empleado"].ToString(), out idEmpleado);
            DateTime.TryParse(dtUnRow["Fecha Ingreso Cliente"].ToString(), out dtFCliente);
            DateTime.TryParse(dtUnRow["Fecha Ingreso Contrato"].ToString(), out dtFContrato);

            if (dtFCliente.ToShortDateString() == "01/01/0001" || dtFContrato.ToShortDateString() == "01/01/0001")
            {
                stError = "Fecha Ingreso Cliente o Fecha Ingreso Contrato tiene un valor invalido.";
            }
            else
            {
                stpSelValidacionActualizacionEmpleadosMasivaTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelValidacionActualizacionEmpleadosMasiva,
                    "FECHA DE INGRESO",
                    idEmpleado,
                    dtFCliente,
                    dtFContrato,
                    String.Empty,
                    String.Empty,
                    String.Empty,
                    String.Empty,
                    String.Empty,
                    String.Empty,
                    0,
                    0,
                    String.Empty,
                    String.Empty,
                    String.Empty,
                    String.Empty,
                    String.Empty,
                    String.Empty,
                    String.Empty,
                    String.Empty,
                    String.Empty, // Tipo Contrato,
                    new DateTime(), // fecha inicio Contrato CIT
                    0, // Tiempo Contrato

                    String.Empty, //APaternoEmpleado
                    String.Empty, //AMaternoEmpleado
                    String.Empty, //NombreEmpleado
                    0, // Salario Diario Cliente
                    ref stFechaVigenciaContrato,
                    ref stError
                    );
            }

            if (!String.IsNullOrEmpty(stError)) { flagValidacionConErrores = true; }

            return stError;
        }

        private String valInfoPuesto(DataRow dtUnRow)
        {
            int idEmpleado = 0;
            String stError = String.Empty;
            int.TryParse(dtUnRow["Id Empleado"].ToString(), out idEmpleado);
            DateTime? stFechaVigenciaContrato = new DateTime(1900, 01, 01);

            stpSelValidacionActualizacionEmpleadosMasivaTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelValidacionActualizacionEmpleadosMasiva,
                   "PUESTO",
                   idEmpleado,
                   DateTime.Now,
                   DateTime.Now,
                   dtUnRow["Puesto Cliente"].ToString().ToUpper(),
                   dtUnRow["Puesto Contrato"].ToString().ToUpper(),
                   String.Empty,
                   String.Empty,
                   String.Empty,
                   String.Empty,
                   0,
                   0,
                   String.Empty,
                   String.Empty,
                   String.Empty,
                   String.Empty,
                   String.Empty,
                   String.Empty,
                   String.Empty,
                   String.Empty,
                   String.Empty, // Tipo Contrato,
                   new DateTime(), // fecha inicio Contrato CIT
                   0, // Tiempo Contrato

                   String.Empty, //APaternoEmpleado
                   String.Empty, //AMaternoEmpleado
                   String.Empty, //NombreEmpleado
                   0, // Salario Diario Cliente

                   ref stFechaVigenciaContrato,
                   ref stError
                   );

            if (!String.IsNullOrEmpty(stError)) { flagValidacionConErrores = true; }

            return stError;
        }

        private String valInfoDepartamento(DataRow dtUnRow)
        {
            int idEmpleado = 0;
            String stError = String.Empty;
            int.TryParse(dtUnRow["Id Empleado"].ToString(), out idEmpleado);
            DateTime? stFechaVigenciaContrato = new DateTime(1900, 01, 01);
            stpSelValidacionActualizacionEmpleadosMasivaTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelValidacionActualizacionEmpleadosMasiva,
                   "DEPARTAMENTO",
                   idEmpleado,
                   DateTime.Now,
                   DateTime.Now,
                   String.Empty,
                   String.Empty,
                   dtUnRow["Departamento Cliente"].ToString().ToUpper(),
                   dtUnRow["Departamento Cliente"].ToString().ToUpper(),
                   String.Empty,
                   String.Empty,
                   0,
                   0,
                   String.Empty,
                   String.Empty,
                   String.Empty,
                   String.Empty,
                   String.Empty,
                   String.Empty,
                   String.Empty,
                   String.Empty,
                   String.Empty, // Tipo Contrato,
                    new DateTime(), // fecha inicio Contrato CIT
                    0, // Tiempo Contrato

                   String.Empty, //APaternoEmpleado
                   String.Empty, //AMaternoEmpleado
                   String.Empty, //NombreEmpleado
                   0, // Salario Diario Cliente

                   ref stFechaVigenciaContrato,
                   ref stError
                   );

            if (!String.IsNullOrEmpty(stError)) { flagValidacionConErrores = true; }

            return stError;

        }

        private String valInfoFunciones(DataRow dtUnRow)
        {
            int idEmpleado = 0;
            String stError = String.Empty;
            int.TryParse(dtUnRow["Id Empleado"].ToString(), out idEmpleado);
            DateTime? stFechaVigenciaContrato = new DateTime(1900, 01, 01);
            stpSelValidacionActualizacionEmpleadosMasivaTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelValidacionActualizacionEmpleadosMasiva,
                   "FUNCIONES",
                   idEmpleado,
                   DateTime.Now,
                   DateTime.Now,
                   String.Empty,
                   String.Empty,
                   String.Empty,
                   String.Empty,
                   dtUnRow["Funciones Empleado"].ToString().ToUpper(),
                   String.Empty,
                   0,
                   0,
                   String.Empty,
                   String.Empty,
                   String.Empty,
                   String.Empty,
                   String.Empty,
                   String.Empty,
                   String.Empty,
                   String.Empty,
                   String.Empty, // Tipo Contrato,
                   new DateTime(), // fecha inicio Contrato CIT
                   0, // Tiempo Contrato

                   String.Empty, //APaternoEmpleado
                   String.Empty, //AMaternoEmpleado
                   String.Empty, //NombreEmpleado
                   0, // Salario Diario Cliente

                   ref stFechaVigenciaContrato,
                   ref stError
                   );

            if (!String.IsNullOrEmpty(stError)) { flagValidacionConErrores = true; }

            return stError;

        }

        private String valInfoCorreoElectronico(DataRow dtUnRow)
        {
            int idEmpleado = 0;
            String stError = String.Empty;
            String stCorreoElectronico = String.Empty;
            String stRegExEmail = String.Empty;
            int.TryParse(dtUnRow["Id Empleado"].ToString(), out idEmpleado);
            DateTime? stFechaVigenciaContrato = new DateTime(1900, 01, 01);
            stCorreoElectronico = dtUnRow["Correo Electronico"].ToString();

            if (!String.IsNullOrEmpty(stCorreoElectronico))
            {
                stpSelParametroRegExTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelParametroRegEx, "EMAIL");

                if (dbSAICBPOCatalogosDataSet1.stpSelParametroRegEx.Rows.Count > 0)
                {
                    stRegExEmail = dbSAICBPOCatalogosDataSet1.stpSelParametroRegEx.Rows[0]["ValorParametro"].ToString();
                }
                else
                {
                    stRegExEmail = tools.dsc.emailPattern;
                }

                if (!dsc.validarRFC(stCorreoElectronico.ToLower(), stRegExEmail))
                {
                    flagValidacionConErrores = true;
                    stError = "Correo Electronico no contiene una estructura valida.";
                }
            }

            if (String.IsNullOrEmpty(stError))
            {
                stpSelValidacionActualizacionEmpleadosMasivaTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelValidacionActualizacionEmpleadosMasiva,
               "CORREO",
               idEmpleado,
               DateTime.Now,
               DateTime.Now,
               String.Empty,
               String.Empty,
               String.Empty,
               String.Empty,
               String.Empty,
               stCorreoElectronico,
               0,
               0,
               String.Empty,
               String.Empty,
               String.Empty,
               String.Empty,
               String.Empty,
               String.Empty,
               String.Empty,
               String.Empty,
               String.Empty, // Tipo Contrato,
               new DateTime(), // fecha inicio Contrato CIT
               0, // Tiempo Contrato

               String.Empty, //APaternoEmpleado
               String.Empty, //AMaternoEmpleado
               String.Empty, //NombreEmpleado
               0, // Salario Diario Cliente

               ref stFechaVigenciaContrato,
               ref stError
               );
            }

            if (!String.IsNullOrEmpty(stError)) { flagValidacionConErrores = true; }
            return stError;

        }

        private String valInfoClienteTenedora(DataRow dtUnRow, int idCliente, int idTenedora)
        {
            int idEmpleado = 0;
            String stError = String.Empty;
            String stCorreoElectronico = String.Empty;
            DateTime? stFechaVigenciaContrato = new DateTime(1900, 01, 01);
            int.TryParse(dtUnRow["Id Empleado"].ToString(), out idEmpleado);

            stpSelValidacionActualizacionEmpleadosMasivaTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelValidacionActualizacionEmpleadosMasiva,
               "CLIENTE-TENEDORA",
               idEmpleado,
               DateTime.Now,
               DateTime.Now,
               String.Empty,
               String.Empty,
               String.Empty,
               String.Empty,
               String.Empty,
               String.Empty,
               idCliente,
               idTenedora,
               String.Empty,
               String.Empty,
               String.Empty,
               String.Empty,
               String.Empty,
               String.Empty,
               String.Empty,
               String.Empty,
               String.Empty, // Tipo Contrato,
               new DateTime(), // fecha inicio Contrato CIT
               0, // Tiempo Contrato

               String.Empty, //APaternoEmpleado
               String.Empty, //AMaternoEmpleado
               String.Empty, //NombreEmpleado
               0, // Salario Diario Cliente

              ref stFechaVigenciaContrato,
               ref stError
               );

            if (!String.IsNullOrEmpty(stError)) { flagValidacionConErrores = true; }
            return stError;
        }

        private String valInfoCentroDeCosto(DataRow dtUnRow)
        {
            int idEmpleado = 0;
            String stError = String.Empty;
            String stCentroDeCosto = String.Empty;
            DateTime? stFechaVigenciaContrato = new DateTime(1900, 01, 01);
            stCentroDeCosto = dtUnRow["Centro De Costo"].ToString();

            int.TryParse(dtUnRow["Id Empleado"].ToString(), out idEmpleado);

            stpSelValidacionActualizacionEmpleadosMasivaTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelValidacionActualizacionEmpleadosMasiva,
               "Centro de Costo",
               idEmpleado,
               DateTime.Now,
               DateTime.Now,
               String.Empty,
               String.Empty,
               String.Empty,
               String.Empty,
               String.Empty,
               String.Empty,
               0,
               0,
               stCentroDeCosto,
               String.Empty,
               String.Empty,
               String.Empty,
               String.Empty,
               String.Empty,
               String.Empty,
               String.Empty,

              String.Empty, // Tipo Contrato,
              new DateTime(), // fecha inicio Contrato CIT
              0, // Tiempo Contrato

              String.Empty, //APaternoEmpleado
              String.Empty, //AMaternoEmpleado
              String.Empty, //NombreEmpleado
              0, // Salario Diario Cliente

              ref stFechaVigenciaContrato,

               ref stError
               );

            if (!String.IsNullOrEmpty(stError)) { flagValidacionConErrores = true; }
            return stError;
        }


        private String valInfoDireccion(DataRow dtUnRow)
        {
            int idEmpleado = 0;
            String stError = String.Empty;
            DateTime? stFechaVigenciaContrato = new DateTime(1900, 01, 01);
            int.TryParse(dtUnRow["Id Empleado"].ToString(), out idEmpleado);

            stpSelValidacionActualizacionEmpleadosMasivaTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelValidacionActualizacionEmpleadosMasiva,
              "Direccion",
              idEmpleado,
              DateTime.Now,
              DateTime.Now,
              String.Empty,
              String.Empty,
              String.Empty,
              String.Empty,
              String.Empty,
              String.Empty,
              0,
              0,
              String.Empty,
              dtUnRow["Calle"].ToString(),
              dtUnRow["NoExterior"].ToString(),
              dtUnRow["NoInterior"].ToString(),
              dtUnRow["Colonia"].ToString(),
              dtUnRow["CodigoPostal"].ToString(),
              dtUnRow["NombreDelegacionMunicipio"].ToString(),
              dtUnRow["Estado"].ToString(),

              String.Empty, // Tipo Contrato,
              new DateTime(), // fecha inicio Contrato CIT
              0, // Tiempo Contrato

              String.Empty, //APaternoEmpleado
              String.Empty, //AMaternoEmpleado
              String.Empty, //NombreEmpleado
              0, // Salario Diario Cliente
              ref stFechaVigenciaContrato,
              ref stError
              );

            if (!String.IsNullOrEmpty(stError)) { flagValidacionConErrores = true; }
            return stError;

        }

        private String valInfoDireccionFiscal(DataRow dtUnRow)
        {
            int idEmpleado = 0;
            String stError = String.Empty;
            DateTime? stFechaVigenciaContrato = new DateTime(1900, 01, 01);

            int.TryParse(dtUnRow["Id Empleado"].ToString(), out idEmpleado);

            stpSelValidacionActualizacionEmpleadosMasivaTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelValidacionActualizacionEmpleadosMasiva,
              "Fiscal",//@pTipoActualizacion
              idEmpleado, //@pIdEmpleado
              DateTime.Now,//@pFechaIngreso_Cliente
              DateTime.Now, //@pFechaIngreso_Contrato
              String.Empty, //@pPuesto_Cliente
              String.Empty, //@pPuesto_Contrato
              String.Empty, //@pDepartamento_Cliente
              String.Empty, //@pDepartamento_Contrato
              String.Empty, //@pFunciones
              String.Empty, //@CorreoElectronico
              0, //@pIdCliente
              0, // IdTenedora
              String.Empty, //@pCentoDeCosto
              String.Empty, //@pCalle
              String.Empty, //@pNoExterior
              String.Empty, //@pNoInterior
              String.Empty, //Colonia
              dtUnRow["CodigoPostal"].ToString(),
              String.Empty,
              String.Empty,

              String.Empty, // Tipo Contrato,
              new DateTime(), // fecha inicio Contrato CIT
              0, // Tiempo Contrato

              String.Empty, //APaternoEmpleado
              String.Empty, //AMaternoEmpleado
              String.Empty, //NombreEmpleado
              0, // Salario Diario Cliente
              ref stFechaVigenciaContrato,
              ref stError
              );

            if (!String.IsNullOrEmpty(stError)) { flagValidacionConErrores = true; }
            return stError;
        }

        DateTime dVigenciaContratoCit = new DateTime(1900, 01, 01);

        private String valInfoTipoContrato(DataRow dtUnRow)
        {

            //dtUnRow.Columns.Add("Errores", typeof(String));
            //dtUnRow.Columns.Add("Fecha Vigencia CIT", typeof(DateTime));
            Boolean flagTaMuyBien = true;
            int idEmpleado = 0;
            int iTiempoContrato = 0;
            DateTime dtFechaInicioContrato = new DateTime(1900, 01, 01);
            String stError = String.Empty;
            DateTime? stFechaVigenciaContrato = new DateTime(1900, 01, 01);

            int.TryParse(dtUnRow["Id Empleado"].ToString(), out idEmpleado);

            if (dtUnRow["Tipo Contrato"].ToString() == "DETERMINADO" || dtUnRow["Tipo Contrato"].ToString() == "OBRA")
            {
                if (!int.TryParse(dtUnRow["Tiempo Contrato CIT"].ToString(), out iTiempoContrato))
                {
                    stError = "Tiempo Contrato Cit, Invalida";
                    flagTaMuyBien = false;
                }

                if (!DateTime.TryParse(dtUnRow["Fecha Inicio Contrato CIT"].ToString(), out dtFechaInicioContrato))
                {
                    stError = "Fecha Inicio Contrato CIT, Invalida";
                    flagTaMuyBien = false;
                }
            }

            int.TryParse(dtUnRow["Tiempo Contrato CIT"].ToString(), out iTiempoContrato);
            DateTime.TryParse(dtUnRow["Fecha Inicio Contrato CIT"].ToString(), out dtFechaInicioContrato);
            if (flagTaMuyBien)
            {

                stpSelValidacionActualizacionEmpleadosMasivaTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelValidacionActualizacionEmpleadosMasiva,
                  "Tipo Contrato",//@pTipoActualizacion
                  idEmpleado, //@pIdEmpleado
                  DateTime.Now,//@pFechaIngreso_Cliente
                  DateTime.Now, //@pFechaIngreso_Contrato
                  String.Empty, //@pPuesto_Cliente
                  String.Empty, //@pPuesto_Contrato
                  String.Empty, //@pDepartamento_Cliente
                  String.Empty, //@pDepartamento_Contrato
                  String.Empty, //@pFunciones
                  String.Empty, //@CorreoElectronico
                  0, //@pIdCliente
                  0, // IdTenedora
                  String.Empty, //@pCentoDeCosto
                  String.Empty, //@pCalle
                  String.Empty, //@pNoExterior
                  String.Empty, //@pNoInterior
                  String.Empty, //Colonia
                  String.Empty,
                  String.Empty,
                  String.Empty,

                  dtUnRow["Tipo Contrato"].ToString(),
                  dtFechaInicioContrato,
                  iTiempoContrato,

                  String.Empty,
                  String.Empty,
                  String.Empty,
                  0, // Salario Diario Cliente
                  ref stFechaVigenciaContrato,
                  ref stError
                  );

            }
            //DateTime dVigencia = new DateTime();
            DateTime.TryParse(stFechaVigenciaContrato.ToString(), out dVigenciaContratoCit);

            if (!String.IsNullOrEmpty(stError)) { flagValidacionConErrores = true; }
            return stError;
        }


        private String valInfoNombreEmpleado(DataRow dtUnRow)
        {
            int idEmpleado = 0;
            int iTiempoContrato = 0;

            String stError = String.Empty;
            DateTime? stFechaVigenciaContrato = new DateTime(1900, 01, 01);
            int.TryParse(dtUnRow["Id Empleado"].ToString(), out idEmpleado);

            stpSelValidacionActualizacionEmpleadosMasivaTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelValidacionActualizacionEmpleadosMasiva,
              "Nombre Empleado",//@pTipoActualizacion
              idEmpleado, //@pIdEmpleado
              DateTime.Now,//@pFechaIngreso_Cliente
              DateTime.Now, //@pFechaIngreso_Contrato
              String.Empty, //@pPuesto_Cliente
              String.Empty, //@pPuesto_Contrato
              String.Empty, //@pDepartamento_Cliente
              String.Empty, //@pDepartamento_Contrato
              String.Empty, //@pFunciones
              String.Empty, //@CorreoElectronico
              0, //@pIdCliente
              0, // IdTenedora
              String.Empty, //@pCentoDeCosto
              String.Empty, //@pCalle
              String.Empty, //@pNoExterior
              String.Empty, //@pNoInterior
              String.Empty, //Colonia
              String.Empty,
              String.Empty,
              String.Empty,

              String.Empty, // Tipo Contrato,
              new DateTime(), // fecha inicio Contrato CIT
              0, // Tiempo Contrato

              dtUnRow["APaternoEmpleado"].ToString(), //APaternoEmpleado
              dtUnRow["AMaternoEmpleado"].ToString(), //AMaternoEmpleado
              dtUnRow["NombreEmpleado"].ToString(), //NombreEmpleado
              0, // Salario Diario Cliente

              ref stFechaVigenciaContrato,
              ref stError
              );

            if (!String.IsNullOrEmpty(stError)) { flagValidacionConErrores = true; }
            return stError;
        }

        private String valSalarioDiarioCliente(DataRow dtUnRow)
        {
            int idEmpleado = 0;
            String stError = String.Empty;
            DateTime? stFechaVigenciaContrato = new DateTime(1900, 01, 01);
            int.TryParse(dtUnRow["Id Empleado"].ToString(), out idEmpleado);
            decimal dcSalarioDiarioCliente = 0;

            if (decimal.TryParse(dtUnRow["SalarioDiarioCliente"].ToString(), out dcSalarioDiarioCliente))
            {
                stpSelValidacionActualizacionEmpleadosMasivaTableAdapter1.Fill(dbSAICBPOCatalogosDataSet1.stpSelValidacionActualizacionEmpleadosMasiva,
              "Salario Diario Cliente",//@pTipoActualizacion
              idEmpleado, //@pIdEmpleado
              DateTime.Now,//@pFechaIngreso_Cliente
              DateTime.Now, //@pFechaIngreso_Contrato
              String.Empty, //@pPuesto_Cliente
              String.Empty, //@pPuesto_Contrato
              String.Empty, //@pDepartamento_Cliente
              String.Empty, //@pDepartamento_Contrato
              String.Empty, //@pFunciones
              String.Empty, //@CorreoElectronico
              0, //@pIdCliente
              0, // IdTenedora
              String.Empty, //@pCentoDeCosto
              String.Empty, //@pCalle
              String.Empty, //@pNoExterior
              String.Empty, //@pNoInterior
              String.Empty, //Colonia
              String.Empty,
              String.Empty,
              String.Empty,

              String.Empty, // Tipo Contrato,
              new DateTime(), // fecha inicio Contrato CIT
              0, // Tiempo Contrato

             String.Empty, //APaternoEmpleado
             String.Empty, //AMaternoEmpleado
              String.Empty, //NombreEmpleado

              dcSalarioDiarioCliente,

              ref stFechaVigenciaContrato,
              ref stError
              );
            }
            else
            {
                stError = "El Salario Diario Cliente no es Numerico.";
            }

            if (!String.IsNullOrEmpty(stError)) { flagValidacionConErrores = true; }
            return stError;
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            gridView2Empleados.SelectAll();
        }

        private void btnDesSelectAll_Click(object sender, EventArgs e)
        {
            DeseleccionarTodo();
        }

        private void DeseleccionarTodo()
        {
            for (int i = 0; i < gridView2Empleados.RowCount; i++)
                gridView2Empleados.UnselectRow(i);
        }

        private void gridViewEmpleados_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            for (int i = 0; i < gridView2Empleados.RowCount; i++)
            {
                if (gridView2Empleados.GetDataRow(i)["Errores"].ToString() != String.Empty)
                {
                    gridView2Empleados.UnselectRow(i);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager3.ShowWaitForm();
                stLog = dsc.iniLog("Actualizacion Masiva de Empleados", OperadorBD.OperadorGlobal.NombreUsuario);
                stLog = dsc.addLog(stLog, "Proceso de Actualizacion");
                int iConta = 0;
                int? iOk = 0;

                int[] iEmpleadosSeleccionados = gridView2Empleados.GetSelectedRows();

                int iCuantosPorActualizar = 0;

                iCuantosPorActualizar = (from x in dsc.deGridViewaDataTable(gridView2Empleados).AsEnumerable()
                                         where String.IsNullOrEmpty(x.Field<String>("Errores"))
                                         select x).ToList().Count;

                for (int i = 0; i < gridView2Empleados.RowCount; i++)
                {
                    DataRow unRow = gridView2Empleados.GetDataRow(i);

                    if (String.IsNullOrEmpty(unRow["Errores"].ToString()))
                    {
                        try
                        {
                            splashScreenManager3.SetWaitFormDescription("Actualizando: " + iConta + " de " + iCuantosPorActualizar);
                            stLog = dsc.addLog(stLog, "Actualizando: " + iConta + " de " + iCuantosPorActualizar);

                            int idTenedora = 0;
                            int idCliente = 0;
                            int idEmpleado = 0;

                            int.TryParse(unRow["ID EMPLEADO"].ToString(), out idEmpleado);

                            DateTime stFechaIngresoCliente = new DateTime();
                            DateTime stFechaIngresoContrato = new DateTime();
                            String stPuestoCliente = String.Empty;
                            String stPuestoContrato = String.Empty;
                            String stDepartamentoCliente = String.Empty;
                            String stDepartamentoContrato = String.Empty;
                            String stFunciones = String.Empty;
                            String stCorreoElectronico = String.Empty;
                            String stTipoActualizacion = String.Empty;
                            String stCentroDeCosto = String.Empty;

                            String sCalle = String.Empty;
                            String sNoExterior = String.Empty;
                            String sNoInterior = String.Empty;
                            String sColonia = String.Empty;
                            String sCodigoPostal = String.Empty;
                            String sNombreDelegacionMunicipio = String.Empty;

                            String sEstado = String.Empty;

                            String TipoContrato = String.Empty;
                            DateTime FechaInicioContratoCIT = new DateTime(1900, 01, 01);
                            int TiempoContratoCIT = 0;
                            String APaternoEmpleado = String.Empty;
                            String AMaternoEmpleado = String.Empty;
                            String NombreEmpleado = String.Empty;

                            Decimal dcSalarioDiarioCliente = 0;


                            if (rdioFechaIngreso.Checked)
                            {
                                stTipoActualizacion = "FECHA INGRESO";

                                DateTime.TryParse(unRow["FECHA INGRESO CLIENTE"].ToString(), out stFechaIngresoCliente);
                                DateTime.TryParse(unRow["FECHA INGRESO CONTRATO"].ToString(), out stFechaIngresoContrato);
                            }
                            else if (rdioPuesto.Checked)
                            {
                                stTipoActualizacion = "PUESTO";
                                stPuestoCliente = unRow["PUESTO CLIENTE"].ToString();
                                stPuestoContrato = unRow["PUESTO CONTRATO"].ToString();
                            }
                            else if (rdioDepartamento.Checked)
                            {
                                stTipoActualizacion = "DEPARTAMENTO";
                                stDepartamentoCliente = unRow["DEPARTAMENTO CLIENTE"].ToString();
                                stDepartamentoContrato = unRow["DEPARTAMENTO CONTRATO"].ToString();
                            }
                            else if (rdioFunciones.Checked)
                            {
                                stTipoActualizacion = "FUNCIONES";
                                stFunciones = unRow["FUNCIONES EMPLEADO"].ToString();
                            }
                            else if (rdioCorreo.Checked)
                            {
                                stTipoActualizacion = "CORREO";
                                stCorreoElectronico = unRow["CORREO ELECTRONICO"].ToString();
                            }
                            else if (rdioCliente.Checked)
                            {
                                stTipoActualizacion = "CLIENTE";
                                int.TryParse(cboIdCliente.EditValue.ToString(), out idCliente);
                            }
                            else if (rdioTenedora.Checked)
                            {
                                stTipoActualizacion = "TENEDORA";
                                int.TryParse(cboIdTenedora.EditValue.ToString(), out idTenedora);
                            }
                            else if (rdioCentroDeCosto.Checked)
                            {
                                stTipoActualizacion = "CENTRO DE COSTO";
                                stCentroDeCosto = unRow["CENTRO DE COSTO"].ToString();
                            }
                            else if (rbCentroDeTrabajo.Checked || rbParticular.Checked)
                            {
                                stTipoActualizacion = "DIRECCION";

                                sCalle = unRow["CALLE"].ToString();
                                sNoExterior = unRow["NOEXTERIOR"].ToString();
                                sNoInterior = unRow["NOINTERIOR"].ToString();
                                sColonia = unRow["COLONIA"].ToString();
                                sCodigoPostal = unRow["CODIGOPOSTAL"].ToString();
                                sNombreDelegacionMunicipio = unRow["NOMBREDELEGACIONMUNICIPIO"].ToString();
                                sEstado = unRow["ESTADO"].ToString();

                            }
                            else if (rbFiscal.Checked)
                            {
                                stTipoActualizacion = "DIRECCION";
                                sCodigoPostal = unRow["CODIGOPOSTAL"].ToString();
                            }
                            else if (rdioTipoContrato.Checked)
                            {
                                stTipoActualizacion = "TIPO CONTRATO";
                                TipoContrato = unRow["Tipo Contrato"].ToString();
                                DateTime.TryParse(unRow["Fecha Inicio Contrato CIT"].ToString(), out FechaInicioContratoCIT);
                                int.TryParse(unRow["Tiempo Contrato CIT"].ToString(), out TiempoContratoCIT);
                            }
                            else if (rdioNombreEmpleado.Checked)
                            {
                                stTipoActualizacion = "NOMBRE EMPLEADO";
                                APaternoEmpleado = unRow["APaternoEmpleado"].ToString();
                                AMaternoEmpleado = unRow["AMaternoEmpleado"].ToString();
                                NombreEmpleado = unRow["NombreEmpleado"].ToString();
                            }
                            else if (rdioSalarioDiarioCliente.Checked)
                            {
                                stTipoActualizacion = "SALARIO DIARIO CLIENTE";
                                decimal.TryParse(unRow["SalarioDiarioCliente"].ToString(), out dcSalarioDiarioCliente);
                            }

                            queriesTableAdapter1.stpUpdActualizacionMasivaEmpleados(
                            stTipoActualizacion,
                            idEmpleado,
                            stFechaIngresoCliente,
                            stFechaIngresoContrato,
                            stPuestoCliente,
                            stPuestoContrato,
                            stDepartamentoCliente,
                            stDepartamentoContrato,
                            stFunciones,
                            stCorreoElectronico,
                            idTenedora,
                            idCliente,
                            stCentroDeCosto,

                            rbCentroDeTrabajo.Checked,
                            rbParticular.Checked,
                            rbFiscal.Checked,

                            sCalle,
                            sNoExterior,
                            sNoInterior,
                            sColonia,
                            sCodigoPostal,
                            sNombreDelegacionMunicipio,
                            sEstado,
                            TipoContrato,
                            FechaInicioContratoCIT,
                            TiempoContratoCIT,
                            APaternoEmpleado,
                            AMaternoEmpleado,
                            NombreEmpleado,
                            dcSalarioDiarioCliente,

                            OperadorBD.OperadorGlobal.NombreUsuario,
                            ref iOk
                            );

                            if (iOk == 1)
                            {
                                unRow["Errores"] = "Actualizado";
                                ////sCodigoPostal = gridView2Empleados.GetDataRow(gridView2Empleados.GetSelectedRows()[i])["CodigoPostal"].ToString();
                                ////gridView2Empleados.GetDataRow(gridView2Empleados.GetSelectedRows()[i])["Errores"] = "Actualizado";
                                ////sCodigoPostal = gridView2Empleados.GetRowCellValue(iEmpleadosSeleccionados[i], gridView2Empleados.Columns["CODIGOPOSTAL"]).ToString();
                                //gridView2Empleados.SetRowCellValue(iEmpleadosSeleccionados[i], gridView2Empleados.Columns["Errores"], "Actualizado " + idEmpleado.ToString());
                            }
                            else
                            {
                                unRow["Errores"] = "No fue posible Actualizar";
                                //gridView2Empleados.SetRowCellValue(iEmpleadosSeleccionados[i], "Errores", "No fue posible Actualizar");
                            }

                            iConta++;
                        }
                        catch (Exception ex)
                        {
                            unRow["Errores"] = "Error: " + ex.Message;
                            //gridView2Empleados.GetDataRow(gridView2Empleados.GetSelectedRows()[i])["Errores"] = "Error: " + ex.Message;
                        }
                    }


                }

                //DeseleccionarTodo();

                if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }

                stLog = dsc.addLog(stLog, "Proceso de Actualización Terminado");
                MessageBox.Show("Empleados Actualizados: " + iConta, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //stpSelObtenerEmpleado_ActualizacionMasivaTableAdapter1.Fill(dbSAICBPOActualizacionesIMSSDataSet1.stpSelObtenerEmpleado_ActualizacionMasiva, 0);
            }
            catch (Exception ex)
            {
                stLog = dsc.addLog(stLog, "Error en Proceso: " + ex.Message);
                stLog = dsc.finLog(stLog);
                dsc.guardarLog(stLog);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void habilitarOpciones()
        {
            Boolean flageHabilitarTenedora = false;
            Boolean flageHabilitarCliente = false;
            Boolean flageHabilitarFechaIngreso = false;
            Boolean flageHabilitarDirecciones = false;

            this.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1.Fill(this.dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion, OperadorBD.OperadorGlobal.IdOperador, "ModificacionEmpleadosMasivos.Botones", "btnActualizacionMasiva");
            if (dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion.Rows.Count > 0)
            {
                Boolean.TryParse(dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion.Rows[0]["Consultar"].ToString(), out flageHabilitarTenedora);
                Boolean.TryParse(dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion.Rows[0]["Actualizar"].ToString(), out flageHabilitarCliente);
                Boolean.TryParse(dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion.Rows[0]["Insertar"].ToString(), out flageHabilitarFechaIngreso);
                Boolean.TryParse(dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion.Rows[0]["Eliminar"].ToString(), out flageHabilitarDirecciones);
                //Boolean.TryParse(dbSAICBPOFactura1.stpFactSelDerechosAccesoOperadorFacturacion.Rows[0]["Habilitar"].ToString(), out flageHabilitarCliente);
            }
            else
            {
                flageHabilitarTenedora = false;
                flageHabilitarCliente = false;
                flageHabilitarFechaIngreso = false;
                flageHabilitarDirecciones = false;
                //flageHabilitarCliente = false;
            }

            rdioTenedora.Visible = flageHabilitarTenedora;
            cboIdTenedora.Visible = flageHabilitarTenedora;

            rdioCliente.Visible = flageHabilitarCliente;
            cboIdCliente.Visible = flageHabilitarCliente;

            rdioFechaIngreso.Visible = flageHabilitarFechaIngreso;

            gBoxDirecciones.Visible = flageHabilitarDirecciones;
            rbCentroDeTrabajo.Visible = flageHabilitarDirecciones;
            rbParticular.Visible = flageHabilitarDirecciones;
            rbFiscal.Visible = flageHabilitarDirecciones;
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            ObtenerArchivoLayout();
        }


        private void ObtenerArchivoLayout()
        {
            if (rdioCorreo.Checked || rdioPuesto.Checked || rdioDepartamento.Checked ||
                rdioFunciones.Checked || rdioCliente.Checked || rdioFechaIngreso.Checked ||
               rdioTenedora.Checked || rdioCentroDeCosto.Checked ||
               rbCentroDeTrabajo.Checked || rbParticular.Checked || rbFiscal.Checked
               || rdioTipoContrato.Checked || rdioNombreEmpleado.Checked || rdioSalarioDiarioCliente.Checked)
            {
                splashScreenManager3.ShowWaitForm();
                stpSelObtenerEmpleado_ActualizacionMasivaTableAdapter1.Fill(dbSAICBPOActualizacionesIMSSDataSet1.stpSelObtenerEmpleado_ActualizacionMasiva, 0);
                gCtrlEmpleadosFiltrados.Visible = true;
                tools.dsc dsc = new tools.dsc();
                DataTable dtResultado = new DataTable();
                ObtenerDatosFiltrados();

                String stRutaSaic = String.Empty;
                stRutaSaic = dsc.stRutaSAICJuridico;

                dsc.CheckandCreateFolder(stRutaSaic);
                stRutaSaic += "Juridico Empleados - " + " " + nombreSeleccion() + " " + dsc.nombreAleatorio() + ".xlsx";
                if (splashScreenManager3.IsSplashFormVisible) { splashScreenManager3.CloseWaitForm(); }
                gCtrlEmpleadosFiltrados.ExportToXlsx(stRutaSaic);

                gCtrlEmpleadosFiltrados.Visible = false;


                XtraMessageBox.Show("Descarga con exito." + Environment.NewLine + "Ruta: " + stRutaSaic, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Selecione una Opción para descargar el archivo LayOut", "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private String nombreSeleccion()
        {
            String sResultado = String.Empty;

            if (rdioCorreo.Checked)
            {
                sResultado = rdioCorreo.Text;
            }
            else if (rdioPuesto.Checked)
            {
                sResultado = rdioPuesto.Text;
            }
            else if (rdioDepartamento.Checked)
            {
                sResultado = rdioDepartamento.Text;
            }
            else if (rdioFunciones.Checked)
            {
                sResultado = rdioFunciones.Text;
            }
            else if (rdioCliente.Checked)
            {
                sResultado = rdioCliente.Text;
            }
            else if (rdioFechaIngreso.Checked)
            {
                sResultado = rdioFechaIngreso.Text;
            }
            else if (rdioTenedora.Checked)
            {
                sResultado = rdioTenedora.Text;
            }
            else if (rdioCentroDeCosto.Checked)
            {
                sResultado = rdioCentroDeCosto.Text;
            }
            else if (rbCentroDeTrabajo.Checked)
            {
                sResultado = rbCentroDeTrabajo.Text;
            }
            else if (rbParticular.Checked)
            {
                sResultado = rbParticular.Text;
            }
            else if (rbFiscal.Checked)
            {
                sResultado = rbFiscal.Text;
            }
            else if (rdioTipoContrato.Checked)
            {
                sResultado = rdioTipoContrato.Text;
            }
            else if (rdioNombreEmpleado.Checked)
            {
                sResultado = rdioNombreEmpleado.Text;
            }
            else if (rdioSalarioDiarioCliente.Checked)
            {
                sResultado = rdioSalarioDiarioCliente.Text;
            }
            else
            {
                sResultado = String.Empty;
            }

            return sResultado;
        }

        private void CheckBoxDCentroTrabajo_CheckedChanged(object sender, EventArgs e)
        {
            desCheckOpciones();
        }

        private void CheckBoxDParticular_CheckedChanged(object sender, EventArgs e)
        {
            desCheckOpciones();
        }

        private void CheckBoxDFiscal_CheckedChanged(object sender, EventArgs e)
        {
            desCheckOpciones();
        }


        private void desCheckOpciones()
        {
            rdioCorreo.Checked = false;
            rdioPuesto.Checked = false;
            rdioFunciones.Checked = false;
            rdioDepartamento.Checked = false;
            rdioCentroDeCosto.Checked = false;
            rdioFechaIngreso.Checked = false;
            rdioCliente.Checked = false;
            rdioTenedora.Checked = false;

            rdioSalarioDiarioCliente.Checked = false;
            rdioNombreEmpleado.Checked = false;
            rdioTipoContrato.Checked = false;

        }

        private void desCheckOpcionesDireccion()
        {
            rbCentroDeTrabajo.Checked = false;
            rbParticular.Checked = false;
            rbFiscal.Checked = false;
            rbCentroDeTrabajo.Checked = false;
            rbParticular.Checked = false;
            rbFiscal.Checked = false;
        }

        private void rdioCorreo_CheckedChanged(object sender, EventArgs e)
        {
            desCheckOpcionesDireccion();
        }

        private void rdioPuesto_CheckedChanged(object sender, EventArgs e)
        {
            desCheckOpcionesDireccion();
        }

        private void rdioFunciones_CheckedChanged(object sender, EventArgs e)
        {
            desCheckOpcionesDireccion();
        }

        private void rdioDepartamento_CheckedChanged(object sender, EventArgs e)
        {
            desCheckOpcionesDireccion();
        }

        private void rdioCentroDeCosto_CheckedChanged(object sender, EventArgs e)
        {
            desCheckOpcionesDireccion();
        }

        private void rdioFechaIngreso_CheckedChanged(object sender, EventArgs e)
        {
            desCheckOpcionesDireccion();
        }
        private void rdioTipoContrato_CheckedChanged(object sender, EventArgs e)
        {
            desCheckOpcionesDireccion();
        }


        private void rdioNombreEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            desCheckOpcionesDireccion();
        }

        private void rdioSalarioDiarioCliente_CheckedChanged(object sender, EventArgs e)
        {
            desCheckOpcionesDireccion();
        }

        private void rbCentroDeTrabajo_CheckedChanged(object sender, EventArgs e)
        {
            desCheckOpciones();
        }

        private void rbParticular_CheckedChanged(object sender, EventArgs e)
        {
            desCheckOpciones();
        }

        private void rbFiscal_CheckedChanged(object sender, EventArgs e)
        {
            desCheckOpciones();
        }

        private void btnAbrirCarpeta_Click(object sender, EventArgs e)
        {
            dsc.CheckandCreateFolder(dsc.stRutaSAICJuridico);
            Process.Start(dsc.stRutaSAICJuridico);
        }

        private void gridView2_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            for (int i = 0; i < gridView2Empleados.RowCount; i++)
            {
                if (gridView2Empleados.GetDataRow(i)["Errores"].ToString() != String.Empty)
                {
                    gridView2Empleados.UnselectRow(i);
                }
            }

            txtSeleccionados.Text = (from x in dsc.deGridViewaDataTable(gridView2Empleados).AsEnumerable()
                                     where String.IsNullOrEmpty(x.Field<String>("Errores"))
                                     select x).ToList().Count.ToString();
        }

        private void btnDescargarErrores_Click(object sender, EventArgs e)
        {
            dsc.CheckandCreateFolder(dsc.stRutaSAICJuridico);
            String stRutaSaicErrores = dsc.stRutaSAICJuridico + "Masivo Errores Empleados - " + " " + nombreSeleccion() + " " + dsc.nombreAleatorio() + ".xlsx";
            gridControl1EmpleadosExcel.ExportToXlsx(stRutaSaicErrores);
            XtraMessageBox.Show("Descarga con exito." + Environment.NewLine + "Ruta: " + stRutaSaicErrores, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void gridView2Empleados_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {

        }


    }
}