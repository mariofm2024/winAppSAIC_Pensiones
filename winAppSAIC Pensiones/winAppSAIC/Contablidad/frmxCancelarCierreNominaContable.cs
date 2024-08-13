using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using compLibreriaSAIC;
using compCatalogosSAIC;

namespace winAppSAIC.Contablidad
{
    public partial class frmxCancelarCierreNominaContable : DevExpress.XtraEditors.XtraForm
    {
        public frmxCancelarCierreNominaContable()
        {
            InitializeComponent();
        }

        #region "Metodos Propios"

        InfoDetalleCierreNominaContable objInfoDetalle;      //declarar objeto InfoDetalleLoteCargaNomina

        /// <summary>
        /// Método que actualiza el combobox LoteCargaNomina
        /// y limpia los controles
        /// </summary>
        private void InicializarFormulario()
        {
            //limpiar controles
            txtNombreComercialTenedora.Text = "";
            txtNombreComercialCliente.Text = "";
            txtNombreOperador.Text = "";
            txtPeriodoPago.Text = "";
            txtTipoNomina.Text = "";
            txtTipoPoliza.Text = "";
            txtNoPoliza.Text = "";
            txtFechaPoliza.Text = "";
            txtImportePoliza.Text = "";
            txtMesPago.Text = "";
            txtAnoPago.Text = "";
            txtObservaciones.Text = "";
            chkEstatusNominaContabilizada.Checked = false;

            //cboFolioLoteCargaNomina.EditValue = -1;
            btnEliminarNominaContabilizada.Enabled = false;
            // actualizar combobox LoteCargaNomina
            this.stpSelSolicitudFolioCierreNominaContabilizadaTableAdapter.Fill(this.dbSAICBPODataSet.stpSelSolicitudFolioCierreNominaContabilizada);
        }

                /// <summary>
        /// Método que despliega la Informacion Detallada
        /// del Lote Carga Nomina seleccionado
        /// </summary>
        private void MostrarInfoDetalleCierreNominaContable(long pIdLoteCargaNomina)
        {
            //cargar informacion detalla LoteCargaNomina
            DataTable dt = this.stpSelInfoDetalleCierreNominaContabilizadaTableAdapter1.GetData(pIdLoteCargaNomina);

            //crear objeto y pasar el DataTable para asignar los valores
            objInfoDetalle = InfoDetalleCierreNominaContableBD.ObtenerInfoDetalleCierreNominaContable(dt);

            //si existe el objeto entonces mostrar los valores
            if (objInfoDetalle != null)
            {
                txtNombreComercialTenedora.Text = objInfoDetalle.NombreComercialTenedora;
                txtNombreComercialCliente.Text = objInfoDetalle.NombreComercialCliente;
                txtNombreOperador.Text = objInfoDetalle.Operador;
                txtTipoNomina.Text = objInfoDetalle.TipoNomina;
                txtPeriodoPago.Text = objInfoDetalle.PeriodoPago;
                txtTipoPoliza.Text = objInfoDetalle.TipoPoliza;
                txtNoPoliza.Text = objInfoDetalle.FolioPoliza;
                txtFechaPoliza.Text = objInfoDetalle.FechaPoliza.ToShortDateString();
                txtImportePoliza.Text = objInfoDetalle.ImportePoliza.ToString("c");
                txtMesPago.Text = objInfoDetalle.MesPago;
                txtAnoPago.Text = objInfoDetalle.AnoPago;
                chkEstatusNominaContabilizada.Checked = objInfoDetalle.EstatusNominaContabilizada;
                txtObservaciones.Text = objInfoDetalle.Observaciones;

                //desbloqueo de boton Eliminar Nomina
                btnEliminarNominaContabilizada.Enabled = true;
            }
        }

        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();        //cerrar pantalla
        }

        private void frmxCancelarCierreNominaContable_Load(object sender, EventArgs e)
        {
            try
            {
                this.stpSelSolicitudFolioCierreNominaContabilizadaTableAdapter.Fill(this.dbSAICBPODataSet.stpSelSolicitudFolioCierreNominaContabilizada);

                // Set column widths according to their contents. 
                cboFolioLoteCargaNomina.Properties.View.BestFitColumns();
                // Specify the total dropdown width. 
                cboFolioLoteCargaNomina.Properties.PopupFormWidth = 900;

                btnEliminarNominaContabilizada.Enabled = false;      //bloqueo de botón Eliminar Nomina
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.txtObservaciones = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnEliminarNominaContabilizada = new DevExpress.XtraEditors.SimpleButton();
            this.txtPeriodoPago = new DevExpress.XtraEditors.TextEdit();
            this.txtNombreOperador = new DevExpress.XtraEditors.TextEdit();
            this.txtTipoNomina = new DevExpress.XtraEditors.TextEdit();
            this.lblFolio = new DevExpress.XtraEditors.LabelControl();
            this.txtNombreComercialCliente = new DevExpress.XtraEditors.TextEdit();
            this.txtNombreComercialTenedora = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cboFolioLoteCargaNomina = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpSelSolicitudFolioCierreNominaContabilizadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPODataSet = new winAppSAIC.dbSAICBPODataSet();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenedora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkEstatusNominaContabilizada = new DevExpress.XtraEditors.CheckEdit();
            this.txtTipoPoliza = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtNoPoliza = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtFechaPoliza = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtImportePoliza = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtAnoPago = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtMesPago = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.stpSelSolicitudFolioCierreNominaContabilizadaTableAdapter = new winAppSAIC.dbSAICBPODataSetTableAdapters.stpSelSolicitudFolioCierreNominaContabilizadaTableAdapter();
            this.stpSelInfoDetalleCierreNominaContabilizadaTableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpSelInfoDetalleCierreNominaContabilizadaTableAdapter();
            this.actualizacionesGeneralTableAdapter1 = new winAppSAIC.dbSAICBPOActualizacionesDataSetTableAdapters.ActualizacionesGeneralTableAdapter();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservaciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodoPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreOperador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoNomina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercialCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercialTenedora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFolioLoteCargaNomina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelSolicitudFolioCierreNominaContabilizadaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstatusNominaContabilizada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoPoliza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoPoliza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaPoliza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImportePoliza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnoPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMesPago.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(553, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::winAppSAIC.Properties.Resources.Salir24x24;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Enabled = false;
            this.txtObservaciones.Location = new System.Drawing.Point(136, 270);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtObservaciones.Properties.Appearance.Options.UseBackColor = true;
            this.txtObservaciones.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservaciones.Properties.MaxLength = 1024;
            this.txtObservaciones.Size = new System.Drawing.Size(406, 88);
            this.txtObservaciones.TabIndex = 26;
            this.txtObservaciones.TabStop = false;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(58, 270);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(71, 13);
            this.labelControl6.TabIndex = 25;
            this.labelControl6.Text = "Observaciones";
            // 
            // btnEliminarNominaContabilizada
            // 
            this.btnEliminarNominaContabilizada.Appearance.BackColor = System.Drawing.Color.White;
            this.btnEliminarNominaContabilizada.Appearance.Options.UseBackColor = true;
            this.btnEliminarNominaContabilizada.Appearance.Options.UseTextOptions = true;
            this.btnEliminarNominaContabilizada.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnEliminarNominaContabilizada.Image = global::winAppSAIC.Properties.Resources.EliminarNomina;
            this.btnEliminarNominaContabilizada.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnEliminarNominaContabilizada.Location = new System.Drawing.Point(402, 33);
            this.btnEliminarNominaContabilizada.LookAndFeel.SkinName = "VS2010";
            this.btnEliminarNominaContabilizada.Name = "btnEliminarNominaContabilizada";
            this.btnEliminarNominaContabilizada.Size = new System.Drawing.Size(140, 25);
            this.btnEliminarNominaContabilizada.TabIndex = 27;
            this.btnEliminarNominaContabilizada.Text = "Eliminar Contabilización";
            this.btnEliminarNominaContabilizada.Click += new System.EventHandler(this.btnEliminarNominaContabilizada_Click);
            // 
            // txtPeriodoPago
            // 
            this.txtPeriodoPago.Enabled = false;
            this.txtPeriodoPago.Location = new System.Drawing.Point(318, 141);
            this.txtPeriodoPago.Name = "txtPeriodoPago";
            this.txtPeriodoPago.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtPeriodoPago.Properties.Appearance.Options.UseBackColor = true;
            this.txtPeriodoPago.Size = new System.Drawing.Size(223, 20);
            this.txtPeriodoPago.TabIndex = 11;
            this.txtPeriodoPago.TabStop = false;
            // 
            // txtNombreOperador
            // 
            this.txtNombreOperador.Enabled = false;
            this.txtNombreOperador.Location = new System.Drawing.Point(135, 114);
            this.txtNombreOperador.Name = "txtNombreOperador";
            this.txtNombreOperador.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtNombreOperador.Properties.Appearance.Options.UseBackColor = true;
            this.txtNombreOperador.Size = new System.Drawing.Size(407, 20);
            this.txtNombreOperador.TabIndex = 7;
            this.txtNombreOperador.TabStop = false;
            // 
            // txtTipoNomina
            // 
            this.txtTipoNomina.Enabled = false;
            this.txtTipoNomina.Location = new System.Drawing.Point(135, 141);
            this.txtTipoNomina.Name = "txtTipoNomina";
            this.txtTipoNomina.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtTipoNomina.Properties.Appearance.Options.UseBackColor = true;
            this.txtTipoNomina.Size = new System.Drawing.Size(100, 20);
            this.txtTipoNomina.TabIndex = 9;
            this.txtTipoNomina.TabStop = false;
            // 
            // lblFolio
            // 
            this.lblFolio.Location = new System.Drawing.Point(13, 41);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(116, 13);
            this.lblFolio.TabIndex = 0;
            this.lblFolio.Text = "Folio Lote Carga Nómina";
            // 
            // txtNombreComercialCliente
            // 
            this.txtNombreComercialCliente.Enabled = false;
            this.txtNombreComercialCliente.Location = new System.Drawing.Point(135, 89);
            this.txtNombreComercialCliente.Name = "txtNombreComercialCliente";
            this.txtNombreComercialCliente.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtNombreComercialCliente.Properties.Appearance.Options.UseBackColor = true;
            this.txtNombreComercialCliente.Size = new System.Drawing.Size(407, 20);
            this.txtNombreComercialCliente.TabIndex = 5;
            this.txtNombreComercialCliente.TabStop = false;
            // 
            // txtNombreComercialTenedora
            // 
            this.txtNombreComercialTenedora.Enabled = false;
            this.txtNombreComercialTenedora.Location = new System.Drawing.Point(135, 64);
            this.txtNombreComercialTenedora.Name = "txtNombreComercialTenedora";
            this.txtNombreComercialTenedora.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtNombreComercialTenedora.Properties.Appearance.Options.UseBackColor = true;
            this.txtNombreComercialTenedora.Size = new System.Drawing.Size(407, 20);
            this.txtNombreComercialTenedora.TabIndex = 3;
            this.txtNombreComercialTenedora.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(83, 68);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Tenedora";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(71, 145);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(58, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Tipo Nómina";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(96, 93);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Cliente";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(276, 145);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 13);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Periodo";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(83, 118);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Operador";
            // 
            // cboFolioLoteCargaNomina
            // 
            this.cboFolioLoteCargaNomina.EditValue = "";
            this.cboFolioLoteCargaNomina.Location = new System.Drawing.Point(135, 38);
            this.cboFolioLoteCargaNomina.Name = "cboFolioLoteCargaNomina";
            this.cboFolioLoteCargaNomina.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.cboFolioLoteCargaNomina.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboFolioLoteCargaNomina.Properties.DataSource = this.stpSelSolicitudFolioCierreNominaContabilizadaBindingSource;
            this.cboFolioLoteCargaNomina.Properties.DisplayMember = "FolioLoteCargaNomina";
            this.cboFolioLoteCargaNomina.Properties.NullText = "";
            this.cboFolioLoteCargaNomina.Properties.ValueMember = "IdLoteCargaNomina";
            this.cboFolioLoteCargaNomina.Properties.View = this.gridLookUpEdit1View;
            this.cboFolioLoteCargaNomina.Size = new System.Drawing.Size(250, 20);
            this.cboFolioLoteCargaNomina.TabIndex = 1;
            this.cboFolioLoteCargaNomina.EditValueChanged += new System.EventHandler(this.cboFolioLoteCargaNomina_EditValueChanged);
            // 
            // stpSelSolicitudFolioCierreNominaContabilizadaBindingSource
            // 
            this.stpSelSolicitudFolioCierreNominaContabilizadaBindingSource.DataMember = "stpSelSolicitudFolioCierreNominaContabilizada";
            this.stpSelSolicitudFolioCierreNominaContabilizadaBindingSource.DataSource = this.dbSAICBPODataSet;
            // 
            // dbSAICBPODataSet
            // 
            this.dbSAICBPODataSet.DataSetName = "dbSAICBPODataSet";
            this.dbSAICBPODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.colTenedora,
            this.colCliente,
            this.colOperador});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsCustomization.AllowGroup = false;
            this.gridLookUpEdit1View.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridLookUpEdit1View.OptionsCustomization.AllowSort = false;
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.gridLookUpEdit1View.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn2, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "No. Lote";
            this.gridColumn2.FieldName = "IdLoteCargaNomina";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 22;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Folio Lote Carga Nómina";
            this.gridColumn3.FieldName = "FolioLoteCargaNomina";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 41;
            // 
            // colTenedora
            // 
            this.colTenedora.Caption = "Tenedora";
            this.colTenedora.FieldName = "Tenedora";
            this.colTenedora.Name = "colTenedora";
            this.colTenedora.Visible = true;
            this.colTenedora.VisibleIndex = 2;
            this.colTenedora.Width = 114;
            // 
            // colCliente
            // 
            this.colCliente.Caption = "Cliente";
            this.colCliente.FieldName = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.Visible = true;
            this.colCliente.VisibleIndex = 3;
            this.colCliente.Width = 173;
            // 
            // colOperador
            // 
            this.colOperador.FieldName = "Operador";
            this.colOperador.Name = "colOperador";
            this.colOperador.Visible = true;
            this.colOperador.VisibleIndex = 4;
            this.colOperador.Width = 150;
            // 
            // chkEstatusNominaContabilizada
            // 
            this.chkEstatusNominaContabilizada.Enabled = false;
            this.chkEstatusNominaContabilizada.Location = new System.Drawing.Point(134, 245);
            this.chkEstatusNominaContabilizada.Name = "chkEstatusNominaContabilizada";
            this.chkEstatusNominaContabilizada.Properties.Caption = "Contabilizada";
            this.chkEstatusNominaContabilizada.Size = new System.Drawing.Size(91, 19);
            this.chkEstatusNominaContabilizada.TabIndex = 24;
            this.chkEstatusNominaContabilizada.TabStop = false;
            // 
            // txtTipoPoliza
            // 
            this.txtTipoPoliza.Enabled = false;
            this.txtTipoPoliza.Location = new System.Drawing.Point(135, 167);
            this.txtTipoPoliza.Name = "txtTipoPoliza";
            this.txtTipoPoliza.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtTipoPoliza.Properties.Appearance.Options.UseBackColor = true;
            this.txtTipoPoliza.Size = new System.Drawing.Size(100, 20);
            this.txtTipoPoliza.TabIndex = 13;
            this.txtTipoPoliza.TabStop = false;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(79, 171);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(50, 13);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Tipo Póliza";
            // 
            // txtNoPoliza
            // 
            this.txtNoPoliza.Enabled = false;
            this.txtNoPoliza.Location = new System.Drawing.Point(318, 167);
            this.txtNoPoliza.Name = "txtNoPoliza";
            this.txtNoPoliza.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtNoPoliza.Properties.Appearance.Options.UseBackColor = true;
            this.txtNoPoliza.Size = new System.Drawing.Size(126, 20);
            this.txtNoPoliza.TabIndex = 15;
            this.txtNoPoliza.TabStop = false;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(250, 171);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(62, 13);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "No. de Póliza";
            // 
            // txtFechaPoliza
            // 
            this.txtFechaPoliza.Enabled = false;
            this.txtFechaPoliza.Location = new System.Drawing.Point(135, 193);
            this.txtFechaPoliza.Name = "txtFechaPoliza";
            this.txtFechaPoliza.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtFechaPoliza.Properties.Appearance.Options.UseBackColor = true;
            this.txtFechaPoliza.Size = new System.Drawing.Size(100, 20);
            this.txtFechaPoliza.TabIndex = 17;
            this.txtFechaPoliza.TabStop = false;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(70, 197);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(59, 13);
            this.labelControl9.TabIndex = 16;
            this.labelControl9.Text = "Fecha Póliza";
            // 
            // txtImportePoliza
            // 
            this.txtImportePoliza.Enabled = false;
            this.txtImportePoliza.Location = new System.Drawing.Point(318, 193);
            this.txtImportePoliza.Name = "txtImportePoliza";
            this.txtImportePoliza.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtImportePoliza.Properties.Appearance.Options.UseBackColor = true;
            this.txtImportePoliza.Size = new System.Drawing.Size(126, 20);
            this.txtImportePoliza.TabIndex = 19;
            this.txtImportePoliza.TabStop = false;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(244, 197);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(68, 13);
            this.labelControl10.TabIndex = 18;
            this.labelControl10.Text = "Importe Póliza";
            // 
            // txtAnoPago
            // 
            this.txtAnoPago.Enabled = false;
            this.txtAnoPago.Location = new System.Drawing.Point(319, 219);
            this.txtAnoPago.Name = "txtAnoPago";
            this.txtAnoPago.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtAnoPago.Properties.Appearance.Options.UseBackColor = true;
            this.txtAnoPago.Size = new System.Drawing.Size(126, 20);
            this.txtAnoPago.TabIndex = 23;
            this.txtAnoPago.TabStop = false;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(266, 222);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(46, 13);
            this.labelControl11.TabIndex = 22;
            this.labelControl11.Text = "Año Pago";
            // 
            // txtMesPago
            // 
            this.txtMesPago.Enabled = false;
            this.txtMesPago.Location = new System.Drawing.Point(136, 219);
            this.txtMesPago.Name = "txtMesPago";
            this.txtMesPago.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtMesPago.Properties.Appearance.Options.UseBackColor = true;
            this.txtMesPago.Size = new System.Drawing.Size(100, 20);
            this.txtMesPago.TabIndex = 21;
            this.txtMesPago.TabStop = false;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(83, 223);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(46, 13);
            this.labelControl12.TabIndex = 20;
            this.labelControl12.Text = "Mes Pago";
            // 
            // stpSelSolicitudFolioCierreNominaContabilizadaTableAdapter
            // 
            this.stpSelSolicitudFolioCierreNominaContabilizadaTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelInfoDetalleCierreNominaContabilizadaTableAdapter1
            // 
            this.stpSelInfoDetalleCierreNominaContabilizadaTableAdapter1.ClearBeforeFill = true;
            // 
            // frmxCancelarCierreNominaContable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 373);
            this.ControlBox = false;
            this.Controls.Add(this.txtAnoPago);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.txtMesPago);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.txtImportePoliza);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.txtFechaPoliza);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.txtNoPoliza);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtTipoPoliza);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.chkEstatusNominaContabilizada);
            this.Controls.Add(this.cboFolioLoteCargaNomina);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.btnEliminarNominaContabilizada);
            this.Controls.Add(this.txtPeriodoPago);
            this.Controls.Add(this.txtNombreOperador);
            this.Controls.Add(this.txtTipoNomina);
            this.Controls.Add(this.lblFolio);
            this.Controls.Add(this.txtNombreComercialCliente);
            this.Controls.Add(this.txtNombreComercialTenedora);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmxCancelarCierreNominaContable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelar Cierre Nómina Contable";
            this.Load += new System.EventHandler(this.frmxCancelarCierreNominaContable_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservaciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodoPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreOperador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoNomina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercialCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreComercialTenedora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFolioLoteCargaNomina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelSolicitudFolioCierreNominaContabilizadaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstatusNominaContabilizada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoPoliza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoPoliza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaPoliza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImportePoliza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnoPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMesPago.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cboFolioLoteCargaNomina_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //cargar informacion detallada InfoDetalleSolicitudCancelacionNomina
                MostrarInfoDetalleCierreNominaContable((long)cboFolioLoteCargaNomina.EditValue);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarNominaContabilizada_Click(object sender, EventArgs e)
        {
            //Obtener el Id del Lote de Carga Nomina
            //para asignarlo a los recibos
            long intIdLoteCargaNomina = (long)cboFolioLoteCargaNomina.EditValue;

            //Obtener el FolioLoteCArgaNomina
            string strFolioLoteCargaNomina = cboFolioLoteCargaNomina.Text;

            if (intIdLoteCargaNomina > 0)       //si seleccionamos un Lote de Carga Nomina
            {
                try
                {
                    //solicitar confirmacion
                    if (XtraMessageBox.Show(String.Format("¿Está seguro que desea cancelar la contabilización del Folio {0}?", strFolioLoteCargaNomina), "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                            //eliminar registro en CierreContable y cambiar EstatusNominaContabilizada = 0
                            //en LoteCargaNomina
                            this.actualizacionesGeneralTableAdapter1.stpUpdCancelarCierreNominaContabilizada(objInfoDetalle.IdTenedora, objInfoDetalle.IdCliente,
                                                        objInfoDetalle.FechaInicio, objInfoDetalle.FechaFin, objInfoDetalle.IdTipoPeriodoNomina,
                                                        objInfoDetalle.IdOperador, objInfoDetalle.IdLoteCargaNomina, objInfoDetalle.FolioLoteCargaNomina,
                                                        OperadorBD.OperadorGlobal.NombreUsuario);

                            XtraMessageBox.Show(String.Format("¡Se ha cancelado la contabilización del Folio {0}!", strFolioLoteCargaNomina), "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            //inicializar controles y actualizar combobox LoteCargaNomina
                            InicializarFormulario();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}