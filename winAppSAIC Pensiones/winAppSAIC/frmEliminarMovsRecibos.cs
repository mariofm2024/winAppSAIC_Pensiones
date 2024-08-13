using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace winAppSAIC
{
    public partial class frmEliminarMovsRecibos : Form
    {

        #region "Variables y Metodos Propios"
        
        private Int32 intNumRegistrosSA = 0;
        private Int32 intNumRegistrosSC = 0;
        private Int32 intNumRegistrosAhorro = 0;
        private string strMensajeError = "";

        /// <summary>
        /// Método para Activar o Desactivar botón Eliminar Recibos
        /// </summary>
        /// <param name="bFlag">Valor TRUE o FALSE</param>
        private void CambiarEstatusBotonEliminarRecibos(bool bFlag)
        {
            btnEliminarMovs.Enabled = bFlag;     //activar o desactivar boton para Eliminar Recibos
        }

        /// <summary>
        /// Método para cambiar el comportamiento de acceso a
        /// los controles Comboboxes Tenedora SA y Tenedora SC
        /// </summary>
        /// <param name="bFlag">Valor TRUE o FALSE</param>
        private void CambiarEstatusComboboxes(bool bFlag)
        {
            cboIdTenedoraSA.Enabled = bFlag;
            cboIdTenedoraSC.Enabled = !bFlag;

            if (this.gvLotesCargaNomina.DataSource != null)
            {
                this.gvLotesCargaNomina.DataSource = null;
            }
            else
            {
                this.gvLotesCargaNomina.Rows.Clear();
            }
        }

        /// <summary>
        /// Método que obtiene los registros de Lotes de Carga Nómina
        /// </summary>
        private void MostrarLoteCargaNomina()
        {
            try
            {
                //inicializar variables globales
                intNumRegistrosSA = 0;
                intNumRegistrosSC = 0;
                intNumRegistrosAhorro = 0;

                if (rbTenedoraSA.Checked == true)
                {
                    //mostrar Lotes Carga Nomina en base a parametros
                    this.stpSelLoteCargaNominaTableAdapter.ObtenerMovsLoteCargaNomina(this.dbSAICBPODataSet.stpSelLoteCargaNomina,
                                Convert.ToInt32(cboIdTenedoraSA.SelectedValue), Convert.ToInt32(cboIdCliente.SelectedValue),
                                Convert.ToInt16(dtFechaInicio.Value.Date.Year), Convert.ToByte(dtFechaInicio.Value.Date.Month),
                                Convert.ToByte(dtFechaInicio.Value.Date.Day),
                                Convert.ToInt16(dtFechaFin.Value.Year), Convert.ToByte(dtFechaFin.Value.Month),
                                Convert.ToByte(dtFechaFin.Value.Day),
                                Convert.ToByte(cboIdTipoPeriodoNomina.SelectedValue), Convert.ToInt16(cboIdOperador.SelectedValue));
                }
                else
                {
                    //mostrar Lotes Carga Nomina en base a parametros
                    this.stpSelLoteCargaNominaTableAdapter.ObtenerMovsLoteCargaNomina(this.dbSAICBPODataSet.stpSelLoteCargaNomina,
                                Convert.ToInt32(cboIdTenedoraSC.SelectedValue), Convert.ToInt32(cboIdCliente.SelectedValue),
                                Convert.ToInt16(dtFechaInicio.Value.Date.Year), Convert.ToByte(dtFechaInicio.Value.Date.Month),
                                Convert.ToByte(dtFechaInicio.Value.Date.Day),
                                Convert.ToInt16(dtFechaFin.Value.Year), Convert.ToByte(dtFechaFin.Value.Month),
                                Convert.ToByte(dtFechaFin.Value.Day),
                                Convert.ToByte(cboIdTipoPeriodoNomina.SelectedValue), Convert.ToInt16(cboIdOperador.SelectedValue));
                }
                //asociamos nuevamente el gridview a los datos
                gvLotesCargaNomina.DataSource = stpSelLoteCargaNominaBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método que visualiza los registros del Lote de Carga seleccionado
        /// </summary>
        private void VisualizarMovsNomina(Int64 pIdLoteCargaNomina)
        {
            try
            {
                strMensajeError = "";       //inicializar variable MensajeError
                if (rbTenedoraSA.Checked == true)
                {
                    //cargar informacion en el GridView SA en base a los parámetros
                    //definidos por el usuario
                    this.stpSelEliminarRecibosEmpleadosHeaderSATableAdapter.ObtenerRecibosEmpleadosHeaderSA(this.dbSAICBPODataSet.stpSelEliminarRecibosEmpleadosHeaderSA,
                        Convert.ToInt32(cboIdTenedoraSA.SelectedValue),
                        Convert.ToInt32(cboIdCliente.SelectedValue),
                        Convert.ToInt16(dtFechaInicio.Value.Date.Year),
                        Convert.ToByte(dtFechaInicio.Value.Month),
                        Convert.ToByte(dtFechaInicio.Value.Day),
                        Convert.ToInt16(dtFechaFin.Value.Date.Year),
                        Convert.ToByte(dtFechaFin.Value.Month),
                        Convert.ToByte(dtFechaFin.Value.Day),
                        Convert.ToByte(cboIdTipoPeriodoNomina.SelectedValue),
                        Convert.ToInt16(cboIdOperador.SelectedValue),
                        pIdLoteCargaNomina);

                    //asignar el No. de Registros SA obtenidos en la consulta
                    intNumRegistrosSA = this.dbSAICBPODataSet.stpSelEliminarRecibosEmpleadosHeaderSA.Count;

                    //verificar si NO existen registros en SA
                    if (intNumRegistrosSA == 0)
                    {
                        strMensajeError = "No existen Recibos de Nómina S.A." + "\n\n";
                        lblNumRegistrosSA.Text = "";
                    }
                    else
                        lblNumRegistrosSA.Text = "No. de Registros S.A. = " + intNumRegistrosSA.ToString();
                }
                else
                {
                    //cargar informacion en el GridView SC en base a los parámetros
                    //definidos por el usuario
                    this.stpSelEliminarRecibosEmpleadosHeaderSCTableAdapter.ObtenerRecibosEmpleadosHeaderSC(this.dbSAICBPODataSet.stpSelEliminarRecibosEmpleadosHeaderSC,
                        Convert.ToInt32(cboIdTenedoraSC.SelectedValue),
                        Convert.ToInt32(cboIdCliente.SelectedValue),
                       Convert.ToInt16(dtFechaInicio.Value.Date.Year),
                       Convert.ToByte(dtFechaInicio.Value.Month),
                       Convert.ToByte(dtFechaInicio.Value.Day),
                       Convert.ToInt16(dtFechaFin.Value.Date.Year),
                       Convert.ToByte(dtFechaFin.Value.Month),
                       Convert.ToByte(dtFechaFin.Value.Day),
                       Convert.ToByte(cboIdTipoPeriodoNomina.SelectedValue),
                       Convert.ToInt16(cboIdOperador.SelectedValue),
                       pIdLoteCargaNomina);

                    //asignar el No. de Registros SC obtenidos en la consulta
                    intNumRegistrosSC = this.dbSAICBPODataSet.stpSelEliminarRecibosEmpleadosHeaderSC.Count;

                    //verificar si NO existen registros en SC
                    if (intNumRegistrosSC == 0)
                    {
                        strMensajeError += "No Existen Recibos de Nómina S.C." + "\n\n";
                        lblNumRegistrosSC.Text = "";
                    }
                    else
                        lblNumRegistrosSC.Text = "No. de Registros S.C. = " + intNumRegistrosSC.ToString();
                }

                //cargar informacion en el GridView Ahorro en base a los parámetros
                //definidos por el usuario
                this.stpSelEliminarMovsHeaderAhorroTableAdapter.ObtenerMovsEmpleadosHeaderAhorro(this.dbSAICBPODataSet.stpSelEliminarMovsHeaderAhorro,
                    Convert.ToInt32(cboIdTenedoraSA.SelectedValue),
                    Convert.ToInt32(cboIdCliente.SelectedValue),
                   Convert.ToInt16(dtFechaInicio.Value.Date.Year),
                   Convert.ToByte(dtFechaInicio.Value.Month),
                   Convert.ToByte(dtFechaInicio.Value.Day),
                   Convert.ToInt16(dtFechaFin.Value.Date.Year),
                   Convert.ToByte(dtFechaFin.Value.Month),
                   Convert.ToByte(dtFechaFin.Value.Day),
                   Convert.ToByte(cboIdTipoPeriodoNomina.SelectedValue),
                   Convert.ToInt16(cboIdOperador.SelectedValue));

                //asignar el No. de Registros Ahorro obtenidos en la consulta
                intNumRegistrosAhorro = this.dbSAICBPODataSet.stpSelEliminarMovsHeaderAhorro.Count;

                //verificar si NO existen registros en Ahorro
                if (intNumRegistrosAhorro == 0)
                {
                    strMensajeError += "No Existen Registros de Ahorro";
                    lblNumMovsAhorro.Text = "";
                }
                else
                    lblNumMovsAhorro.Text = "No. de Registros de Ahorro = " + intNumRegistrosAhorro.ToString();

                //si existen registros en SA o SC habilitar o deshabilitar botón Eliminar Movs.
                if ((intNumRegistrosSA > 0) || (intNumRegistrosSC > 0))
                    CambiarEstatusBotonEliminarRecibos(true);      //habilitar boton Eliminar Recibos
                else
                    CambiarEstatusBotonEliminarRecibos(false);      //deshabilitar boton Eliminar Recibos
                
                //desplegar mensaje informativo
                if (strMensajeError.Length > 0)
                    MessageBox.Show(strMensajeError, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        public frmEliminarMovsRecibos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();        //cerrar pantalla
        }

        private void frmEliminarMovsRecibos_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dbSAICBPODataSet.stpSelTipoPeriodoNomina' table. You can move, or remove it, as needed.
                this.stpSelTipoPeriodoNominaTableAdapter.Fill(this.dbSAICBPODataSet.stpSelTipoPeriodoNomina);
                // TODO: This line of code loads data into the 'dbSAICBPODataSet.stpSelOperador' table. You can move, or remove it, as needed.
                this.stpSelOperadorTableAdapter.Fill(this.dbSAICBPODataSet.stpSelOperador);
                // TODO: This line of code loads data into the 'dbSAICBPODataSet.vwCatCliente' table. You can move, or remove it, as needed.
                this.vwCatClienteTableAdapter.Fill(this.dbSAICBPODataSet.vwCatCliente);
                // TODO: This line of code loads data into the 'dbSAICBPODataSet.vwCatTenedoraSC' table. You can move, or remove it, as needed.
                this.vwCatTenedoraSCTableAdapter.Fill(this.dbSAICBPODataSet.vwCatTenedoraSC);
                // TODO: This line of code loads data into the 'dbSAICBPODataSet.vwCatTenedoraSA' table. You can move, or remove it, as needed.
                this.vwCatTenedoraSATableAdapter.Fill(this.dbSAICBPODataSet.vwCatTenedoraSA);

                CambiarEstatusBotonEliminarRecibos(false);     //desactivar boton Eliminar Recibos
                //asignar valores de radio boton
                rbTenedoraSA.Checked = true;
                rbTenedoraSC.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbTenedoraSA_CheckedChanged(object sender, EventArgs e)
        {
            CambiarEstatusComboboxes(true);     //habilita combobox TenedoraSA, bloquea combobox TenedoraSC
        }

        private void rbTenedoraSC_CheckedChanged(object sender, EventArgs e)
        {
            CambiarEstatusComboboxes(false);    //bloquea combobox TenedoraSA, habilita combobox TenedoraSC
        }

        private void btnMostrarLotes_Click(object sender, EventArgs e)
        {
            if (dtFechaFin.Value.Date < dtFechaInicio.Value.Date)
                MessageBox.Show("La Fecha Final no puede ser menor a la Fecha Inicial", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MostrarLoteCargaNomina();
        }

        private void btnEliminarMovs_Click(object sender, EventArgs e)
        {
            //CambiarEstatusBotonAutorizarNominas(false);     //desactivar boton para Autorizar Nominas
            Int64 intIdLoteCargaNomina = 0;

            //si existen Lotes de Carga de Nomina en el gridview
            if (gvLotesCargaNomina.RowCount > 0)
            {
                //Obtener el Id del Lote de Carga Nomina
                //para asignarlo a los recibos
                intIdLoteCargaNomina = Convert.ToInt64(gvLotesCargaNomina.Rows[gvLotesCargaNomina.SelectedCells[0].RowIndex].Cells[0].Value);
                //Obtener el FolioLoteCArgaNomina
                string strFolioLoteCargaNomina = gvLotesCargaNomina.Rows[gvLotesCargaNomina.SelectedCells[0].RowIndex].Cells[1].Value.ToString();
                if (intIdLoteCargaNomina > 0)       //si seleccionamos un Lote de Carga Nomina
                {
                    try
                    {
                        //solicitar confirmacion
                        if (MessageBox.Show(String.Format("¿Está seguro que desea eliminar el Folio Lote de Carga Nómina {0}?", strFolioLoteCargaNomina), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                        {
                            //si existen registros HeaderSA, entonces eliminarlos
                            if (intNumRegistrosSA > 0)
                            {
                                this.stpSelEliminarRecibosEmpleadosHeaderSATableAdapter.EliminarRecibosEmpleadosHeaderSA(this.dbSAICBPODataSet.stpSelEliminarRecibosEmpleadosHeaderSA,
                                        Convert.ToInt32(cboIdTenedoraSA.SelectedValue),
                                        Convert.ToInt32(cboIdCliente.SelectedValue),
                                        Convert.ToInt16(dtFechaInicio.Value.Year),
                                        Convert.ToByte(dtFechaInicio.Value.Month),
                                        Convert.ToByte(dtFechaInicio.Value.Day),
                                        Convert.ToInt16(dtFechaFin.Value.Year),
                                        Convert.ToByte(dtFechaFin.Value.Month),
                                        Convert.ToByte(dtFechaFin.Value.Day),
                                        Convert.ToByte(cboIdTipoPeriodoNomina.SelectedValue),
                                        Convert.ToInt16(cboIdOperador.SelectedValue),
                                        intIdLoteCargaNomina,
                                        System.Security.Principal.WindowsIdentity.GetCurrent().Name);

                                //Eliminar Movs Ahorror en caso de que se cumpla la condicion
                                this.stpSelEliminarMovsHeaderAhorroTableAdapter.EliminarMovsEmpleadoHeaderAhorro(this.dbSAICBPODataSet.stpSelEliminarMovsHeaderAhorro,
                                        Convert.ToInt32(cboIdTenedoraSA.SelectedValue),
                                        Convert.ToInt32(cboIdCliente.SelectedValue),
                                        Convert.ToInt16(dtFechaInicio.Value.Year),
                                        Convert.ToByte(dtFechaInicio.Value.Month),
                                        Convert.ToByte(dtFechaInicio.Value.Day),
                                        Convert.ToInt16(dtFechaFin.Value.Year),
                                        Convert.ToByte(dtFechaFin.Value.Month),
                                        Convert.ToByte(dtFechaFin.Value.Day),
                                        Convert.ToByte(cboIdTipoPeriodoNomina.SelectedValue),
                                        Convert.ToInt16(cboIdOperador.SelectedValue),
                                        System.Security.Principal.WindowsIdentity.GetCurrent().Name);

                                lblNumRegistrosSA.Text = "";        //inicializar label
                            }

                            //si existen registros HeaderSC, entonces eliminarlos
                            if (intNumRegistrosSC > 0)
                            {
                                this.stpSelEliminarRecibosEmpleadosHeaderSCTableAdapter.EliminarRecibosEmpleadosHeaderSC(this.dbSAICBPODataSet.stpSelEliminarRecibosEmpleadosHeaderSC,
                                        Convert.ToInt32(cboIdTenedoraSC.SelectedValue),
                                        Convert.ToInt32(cboIdCliente.SelectedValue),
                                        Convert.ToInt16(dtFechaInicio.Value.Year),
                                        Convert.ToByte(dtFechaInicio.Value.Month),
                                        Convert.ToByte(dtFechaInicio.Value.Day),
                                        Convert.ToInt16(dtFechaFin.Value.Year),
                                        Convert.ToByte(dtFechaFin.Value.Month),
                                        Convert.ToByte(dtFechaFin.Value.Day),
                                        Convert.ToByte(cboIdTipoPeriodoNomina.SelectedValue),
                                        Convert.ToInt16(cboIdOperador.SelectedValue),
                                        intIdLoteCargaNomina,
                                        System.Security.Principal.WindowsIdentity.GetCurrent().Name);

                                //Eliminar Movs Ahorror en caso de que se cumpla la condicion
                                this.stpSelEliminarMovsHeaderAhorroTableAdapter.EliminarMovsEmpleadoHeaderAhorro(this.dbSAICBPODataSet.stpSelEliminarMovsHeaderAhorro,
                                        Convert.ToInt32(cboIdTenedoraSC.SelectedValue),
                                        Convert.ToInt32(cboIdCliente.SelectedValue),
                                        Convert.ToInt16(dtFechaInicio.Value.Year),
                                        Convert.ToByte(dtFechaInicio.Value.Month),
                                        Convert.ToByte(dtFechaInicio.Value.Day),
                                        Convert.ToInt16(dtFechaFin.Value.Year),
                                        Convert.ToByte(dtFechaFin.Value.Month),
                                        Convert.ToByte(dtFechaFin.Value.Day),
                                        Convert.ToByte(cboIdTipoPeriodoNomina.SelectedValue),
                                        Convert.ToInt16(cboIdOperador.SelectedValue),
                                        System.Security.Principal.WindowsIdentity.GetCurrent().Name);

                                lblNumRegistrosSC.Text = "";        //inicializar label
                            }

                            
                            MessageBox.Show("¡La eliminación de Nóminas ha sido exitosa!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        MostrarLoteCargaNomina();       //recargar grid con Lotes Carga Nomina
                        CambiarEstatusBotonEliminarRecibos(false);      //deshabilitar boton Eliminar Recibos
                    }
                }
            }   //gvLotesCargaNomina.RowCount > 0
            else
                MessageBox.Show("Seleccione un Folio Lote de Carga Nómina \n para obtener el reporte.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btnVisualizarMovs_Click(object sender, EventArgs e)
        {
            //CambiarEstatusBotonAutorizarNominas(false);     //desactivar boton para Autorizar Nominas
            Int64 intIdLoteCargaNomina = 0;

            //si existen Lotes de Carga de Nomina en el gridview
            if (gvLotesCargaNomina.RowCount > 0)
            {
                //Obtener el Id del Lote de Carga Nomina
                //para asignarlo a los recibos
                intIdLoteCargaNomina = Convert.ToInt64(gvLotesCargaNomina.Rows[gvLotesCargaNomina.SelectedCells[0].RowIndex].Cells[0].Value);

                if (intIdLoteCargaNomina > 0)       //si seleccionamos un Lote de Carga Nomina
                {
                    //Visualizar movs. de Nómina
                    VisualizarMovsNomina(intIdLoteCargaNomina);
                }
            }   //gvLotesCargaNomina.RowCount > 0
            else
                MessageBox.Show("Seleccione un Folio Lote de Carga Nómina \n para obtener el reporte.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
