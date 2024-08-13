namespace winAppSAIC.Catalogos
{
    partial class frmxPeriodosCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxPeriodosCliente));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSALIR = new System.Windows.Forms.ToolStripButton();
            this.btnCargar = new System.Windows.Forms.ToolStripButton();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnBorrar = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.gridPeriodoCliente = new DevExpress.XtraGrid.GridControl();
            this.periodoClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAIC_Catalogos = new winAppSAIC.Catalogos.dbSAIC_Catalogos();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdPeriodoCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreComercial1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocial1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPeriodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescTipoPeriodoNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoPeriodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaInicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaFin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnoFiscal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.txtNodiaPago = new DevExpress.XtraEditors.SpinEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.dtFechaPago = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lblIdPeriodo = new DevExpress.XtraEditors.SpinEdit();
            this.txtNoPeriodo = new DevExpress.XtraEditors.SpinEdit();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.chePPeriodos = new DevExpress.XtraEditors.CheckEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.cboIdClienteProveedor = new DevExpress.XtraEditors.GridLookUpEdit();
            this.vwFactBeneficiarioClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOFactura = new winAppSAIC.Facturas.dbSAICBPOFactura();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreComercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbTipoPeriodo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpFactSelTipoPeriodoNominaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTipoPeriodoNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescTipoPeriodoNomina1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vwFactBeneficiarioClienteTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.vwFactBeneficiarioClienteTableAdapter();
            this.periodoClienteTableAdapter = new winAppSAIC.Catalogos.dbSAIC_CatalogosTableAdapters.PeriodoClienteTableAdapter();
            this.stpFactSelTipoPeriodoNominaTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelTipoPeriodoNominaTableAdapter();
            this.txtAnoFiscal = new DevExpress.XtraEditors.SpinEdit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.sidePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPeriodoCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodoClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAIC_Catalogos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNodiaPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblIdPeriodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoPeriodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chePPeriodos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdClienteProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFactBeneficiarioClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoPeriodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelTipoPeriodoNominaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnoFiscal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSALIR,
            this.btnCargar,
            this.btnActualizar,
            this.btnCancelar,
            this.btnBorrar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(781, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSALIR
            // 
            this.btnSALIR.Image = global::winAppSAIC.Properties.Resources.Salir24x24;
            this.btnSALIR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(49, 22);
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Image = global::winAppSAIC.Properties.Resources.if_23_1714931;
            this.btnCargar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(62, 22);
            this.btnCargar.Text = "Cargar";
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = global::winAppSAIC.Properties.Resources.saveHS;
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(79, 22);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = global::winAppSAIC.Properties.Resources.Borrar1;
            this.btnBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(70, 22);
            this.btnBorrar.Text = "Eliminar";
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sidePanel2);
            this.panel1.Controls.Add(this.sidePanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 389);
            this.panel1.TabIndex = 1;
            // 
            // sidePanel2
            // 
            this.sidePanel2.Controls.Add(this.gridPeriodoCliente);
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel2.Location = new System.Drawing.Point(0, 108);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(781, 281);
            this.sidePanel2.TabIndex = 1;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // gridPeriodoCliente
            // 
            this.gridPeriodoCliente.DataSource = this.periodoClienteBindingSource;
            this.gridPeriodoCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPeriodoCliente.Location = new System.Drawing.Point(0, 0);
            this.gridPeriodoCliente.MainView = this.gridView1;
            this.gridPeriodoCliente.Name = "gridPeriodoCliente";
            this.gridPeriodoCliente.Size = new System.Drawing.Size(781, 281);
            this.gridPeriodoCliente.TabIndex = 7;
            this.gridPeriodoCliente.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridPeriodoCliente.DoubleClick += new System.EventHandler(this.gridPeriodoCliente_DoubleClick);
            // 
            // periodoClienteBindingSource
            // 
            this.periodoClienteBindingSource.DataMember = "PeriodoCliente";
            this.periodoClienteBindingSource.DataSource = this.dbSAIC_Catalogos;
            // 
            // dbSAIC_Catalogos
            // 
            this.dbSAIC_Catalogos.DataSetName = "dbSAIC_Catalogos";
            this.dbSAIC_Catalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPeriodoCliente,
            this.colIdCliente,
            this.colNombreComercial1,
            this.colRazonSocial1,
            this.colIdPeriodo,
            this.colDescTipoPeriodoNomina,
            this.colNoPeriodo,
            this.colFechaInicio,
            this.colFechaFin,
            this.colAnoFiscal,
            this.colFechaPago,
            this.colIdEstatus,
            this.colUsuarioCreacion,
            this.colFechaCreacion,
            this.colFechaModificacion,
            this.colUsuarioModificacion});
            this.gridView1.GridControl = this.gridPeriodoCliente;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdPeriodoCliente
            // 
            this.colIdPeriodoCliente.Caption = "Id";
            this.colIdPeriodoCliente.FieldName = "IdPeriodoCliente";
            this.colIdPeriodoCliente.Name = "colIdPeriodoCliente";
            this.colIdPeriodoCliente.Visible = true;
            this.colIdPeriodoCliente.VisibleIndex = 0;
            this.colIdPeriodoCliente.Width = 48;
            // 
            // colIdCliente
            // 
            this.colIdCliente.FieldName = "IdCliente";
            this.colIdCliente.Name = "colIdCliente";
            // 
            // colNombreComercial1
            // 
            this.colNombreComercial1.FieldName = "NombreComercial";
            this.colNombreComercial1.Name = "colNombreComercial1";
            this.colNombreComercial1.Visible = true;
            this.colNombreComercial1.VisibleIndex = 1;
            this.colNombreComercial1.Width = 207;
            // 
            // colRazonSocial1
            // 
            this.colRazonSocial1.FieldName = "RazonSocial";
            this.colRazonSocial1.Name = "colRazonSocial1";
            this.colRazonSocial1.Visible = true;
            this.colRazonSocial1.VisibleIndex = 2;
            this.colRazonSocial1.Width = 77;
            // 
            // colIdPeriodo
            // 
            this.colIdPeriodo.FieldName = "IdPeriodo";
            this.colIdPeriodo.Name = "colIdPeriodo";
            // 
            // colDescTipoPeriodoNomina
            // 
            this.colDescTipoPeriodoNomina.Caption = "Periodo";
            this.colDescTipoPeriodoNomina.FieldName = "DescTipoPeriodoNomina";
            this.colDescTipoPeriodoNomina.Name = "colDescTipoPeriodoNomina";
            this.colDescTipoPeriodoNomina.Visible = true;
            this.colDescTipoPeriodoNomina.VisibleIndex = 3;
            this.colDescTipoPeriodoNomina.Width = 93;
            // 
            // colNoPeriodo
            // 
            this.colNoPeriodo.Caption = "No. Periodo";
            this.colNoPeriodo.FieldName = "NoPeriodo";
            this.colNoPeriodo.Name = "colNoPeriodo";
            this.colNoPeriodo.Visible = true;
            this.colNoPeriodo.VisibleIndex = 4;
            // 
            // colFechaInicio
            // 
            this.colFechaInicio.FieldName = "FechaInicio";
            this.colFechaInicio.Name = "colFechaInicio";
            this.colFechaInicio.Visible = true;
            this.colFechaInicio.VisibleIndex = 5;
            this.colFechaInicio.Width = 67;
            // 
            // colFechaFin
            // 
            this.colFechaFin.FieldName = "FechaFin";
            this.colFechaFin.Name = "colFechaFin";
            this.colFechaFin.Visible = true;
            this.colFechaFin.VisibleIndex = 6;
            this.colFechaFin.Width = 67;
            // 
            // colAnoFiscal
            // 
            this.colAnoFiscal.Caption = "Año Fiscal";
            this.colAnoFiscal.FieldName = "AnoFiscal";
            this.colAnoFiscal.Name = "colAnoFiscal";
            this.colAnoFiscal.Visible = true;
            this.colAnoFiscal.VisibleIndex = 8;
            this.colAnoFiscal.Width = 63;
            // 
            // colFechaPago
            // 
            this.colFechaPago.Caption = "Fecha Pago";
            this.colFechaPago.FieldName = "FechaPago";
            this.colFechaPago.Name = "colFechaPago";
            this.colFechaPago.Visible = true;
            this.colFechaPago.VisibleIndex = 7;
            this.colFechaPago.Width = 71;
            // 
            // colIdEstatus
            // 
            this.colIdEstatus.FieldName = "IdEstatus";
            this.colIdEstatus.Name = "colIdEstatus";
            // 
            // colUsuarioCreacion
            // 
            this.colUsuarioCreacion.FieldName = "UsuarioCreacion";
            this.colUsuarioCreacion.Name = "colUsuarioCreacion";
            this.colUsuarioCreacion.Visible = true;
            this.colUsuarioCreacion.VisibleIndex = 9;
            this.colUsuarioCreacion.Width = 76;
            // 
            // colFechaCreacion
            // 
            this.colFechaCreacion.FieldName = "FechaCreacion";
            this.colFechaCreacion.Name = "colFechaCreacion";
            this.colFechaCreacion.Visible = true;
            this.colFechaCreacion.VisibleIndex = 10;
            this.colFechaCreacion.Width = 71;
            // 
            // colFechaModificacion
            // 
            this.colFechaModificacion.FieldName = "FechaModificacion";
            this.colFechaModificacion.Name = "colFechaModificacion";
            this.colFechaModificacion.Visible = true;
            this.colFechaModificacion.VisibleIndex = 12;
            this.colFechaModificacion.Width = 99;
            // 
            // colUsuarioModificacion
            // 
            this.colUsuarioModificacion.FieldName = "UsuarioModificacion";
            this.colUsuarioModificacion.Name = "colUsuarioModificacion";
            this.colUsuarioModificacion.Visible = true;
            this.colUsuarioModificacion.VisibleIndex = 11;
            this.colUsuarioModificacion.Width = 71;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.txtAnoFiscal);
            this.sidePanel1.Controls.Add(this.txtNodiaPago);
            this.sidePanel1.Controls.Add(this.label6);
            this.sidePanel1.Controls.Add(this.dtFechaPago);
            this.sidePanel1.Controls.Add(this.label5);
            this.sidePanel1.Controls.Add(this.lblIdPeriodo);
            this.sidePanel1.Controls.Add(this.txtNoPeriodo);
            this.sidePanel1.Controls.Add(this.lblCantidad);
            this.sidePanel1.Controls.Add(this.chePPeriodos);
            this.sidePanel1.Controls.Add(this.label3);
            this.sidePanel1.Controls.Add(this.dtFechaFin);
            this.sidePanel1.Controls.Add(this.label2);
            this.sidePanel1.Controls.Add(this.dtFechaInicio);
            this.sidePanel1.Controls.Add(this.label4);
            this.sidePanel1.Controls.Add(this.labelControl1);
            this.sidePanel1.Controls.Add(this.label1);
            this.sidePanel1.Controls.Add(this.cboIdClienteProveedor);
            this.sidePanel1.Controls.Add(this.cbTipoPeriodo);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(781, 108);
            this.sidePanel1.TabIndex = 0;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // txtNodiaPago
            // 
            this.txtNodiaPago.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtNodiaPago.Location = new System.Drawing.Point(124, 73);
            this.txtNodiaPago.Name = "txtNodiaPago";
            this.txtNodiaPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNodiaPago.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtNodiaPago.Properties.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtNodiaPago.Properties.MinValue = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.txtNodiaPago.Size = new System.Drawing.Size(82, 20);
            this.txtNodiaPago.TabIndex = 6;
            this.txtNodiaPago.Tag = "No. Periodo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 136;
            this.label6.Text = "Días Pago:";
            // 
            // dtFechaPago
            // 
            this.dtFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaPago.Location = new System.Drawing.Point(470, 47);
            this.dtFechaPago.Name = "dtFechaPago";
            this.dtFechaPago.Size = new System.Drawing.Size(99, 20);
            this.dtFechaPago.TabIndex = 4;
            this.dtFechaPago.Tag = "Fecha de Fin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 134;
            this.label5.Text = "Fecha Pago:";
            // 
            // lblIdPeriodo
            // 
            this.lblIdPeriodo.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.lblIdPeriodo.Location = new System.Drawing.Point(124, -1);
            this.lblIdPeriodo.Name = "lblIdPeriodo";
            this.lblIdPeriodo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lblIdPeriodo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.lblIdPeriodo.Size = new System.Drawing.Size(53, 20);
            this.lblIdPeriodo.TabIndex = 132;
            this.lblIdPeriodo.Tag = "No. Periodo";
            this.lblIdPeriodo.Visible = false;
            // 
            // txtNoPeriodo
            // 
            this.txtNoPeriodo.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNoPeriodo.Location = new System.Drawing.Point(290, 73);
            this.txtNoPeriodo.Name = "txtNoPeriodo";
            this.txtNoPeriodo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNoPeriodo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtNoPeriodo.Size = new System.Drawing.Size(82, 20);
            this.txtNoPeriodo.TabIndex = 7;
            this.txtNoPeriodo.Tag = "No. Periodo";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(218, 76);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(66, 13);
            this.lblCantidad.TabIndex = 129;
            this.lblCantidad.Text = "No. Periodo:";
            // 
            // chePPeriodos
            // 
            this.chePPeriodos.Location = new System.Drawing.Point(470, 73);
            this.chePPeriodos.Name = "chePPeriodos";
            this.chePPeriodos.Properties.Caption = "Periodico";
            this.chePPeriodos.Size = new System.Drawing.Size(75, 19);
            this.chePPeriodos.TabIndex = 8;
            this.chePPeriodos.CheckedChanged += new System.EventHandler(this.chePPeriodos_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(581, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 126;
            this.label3.Text = "Año Fiscal:";
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFin.Location = new System.Drawing.Point(290, 47);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(99, 20);
            this.dtFechaFin.TabIndex = 3;
            this.dtFechaFin.Tag = "Fecha de Fin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 124;
            this.label2.Text = "Fecha Fin:";
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInicio.Location = new System.Drawing.Point(124, 47);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(95, 20);
            this.dtFechaInicio.TabIndex = 2;
            this.dtFechaInicio.Tag = "Fecha de Inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 123;
            this.label4.Text = "Fecha Inicio:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(577, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Tipo Periodo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cliente:";
            // 
            // cboIdClienteProveedor
            // 
            this.cboIdClienteProveedor.Location = new System.Drawing.Point(124, 21);
            this.cboIdClienteProveedor.Name = "cboIdClienteProveedor";
            this.cboIdClienteProveedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboIdClienteProveedor.Properties.DataSource = this.vwFactBeneficiarioClienteBindingSource;
            this.cboIdClienteProveedor.Properties.DisplayMember = "NombreComercial";
            this.cboIdClienteProveedor.Properties.NullText = "";
            this.cboIdClienteProveedor.Properties.ValueMember = "IdMatrizCliente";
            this.cboIdClienteProveedor.Properties.View = this.gridLookUpEdit1View;
            this.cboIdClienteProveedor.Size = new System.Drawing.Size(444, 20);
            this.cboIdClienteProveedor.TabIndex = 0;
            this.cboIdClienteProveedor.Tag = "Cliente";
            this.cboIdClienteProveedor.EditValueChanged += new System.EventHandler(this.cboIdClienteProveedor_EditValueChanged);
            // 
            // vwFactBeneficiarioClienteBindingSource
            // 
            this.vwFactBeneficiarioClienteBindingSource.DataMember = "vwFactBeneficiarioCliente";
            this.vwFactBeneficiarioClienteBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // dbSAICBPOFactura
            // 
            this.dbSAICBPOFactura.DataSetName = "dbSAICBPOFactura";
            this.dbSAICBPOFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.colNombreComercial,
            this.colRazonSocial});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.gridLookUpEdit1View.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Id, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "IdMatrizCliente";
            this.Id.Name = "Id";
            this.Id.Visible = true;
            this.Id.VisibleIndex = 0;
            this.Id.Width = 111;
            // 
            // colNombreComercial
            // 
            this.colNombreComercial.FieldName = "NombreComercial";
            this.colNombreComercial.Name = "colNombreComercial";
            this.colNombreComercial.Visible = true;
            this.colNombreComercial.VisibleIndex = 1;
            this.colNombreComercial.Width = 575;
            // 
            // colRazonSocial
            // 
            this.colRazonSocial.Caption = "RazónSocial";
            this.colRazonSocial.FieldName = "RazonSocial";
            this.colRazonSocial.Name = "colRazonSocial";
            this.colRazonSocial.Visible = true;
            this.colRazonSocial.VisibleIndex = 2;
            this.colRazonSocial.Width = 374;
            // 
            // cbTipoPeriodo
            // 
            this.cbTipoPeriodo.Location = new System.Drawing.Point(646, 21);
            this.cbTipoPeriodo.Name = "cbTipoPeriodo";
            this.cbTipoPeriodo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoPeriodo.Properties.DataSource = this.stpFactSelTipoPeriodoNominaBindingSource;
            this.cbTipoPeriodo.Properties.DisplayMember = "DescTipoPeriodoNomina";
            this.cbTipoPeriodo.Properties.NullText = "";
            this.cbTipoPeriodo.Properties.PopupSizeable = false;
            this.cbTipoPeriodo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbTipoPeriodo.Properties.ValueMember = "IdTipoPeriodoNomina";
            this.cbTipoPeriodo.Properties.View = this.gridView2;
            this.cbTipoPeriodo.Size = new System.Drawing.Size(100, 20);
            this.cbTipoPeriodo.TabIndex = 1;
            this.cbTipoPeriodo.Tag = "Tipo Periodo";
            // 
            // stpFactSelTipoPeriodoNominaBindingSource
            // 
            this.stpFactSelTipoPeriodoNominaBindingSource.DataMember = "stpFactSelTipoPeriodoNomina";
            this.stpFactSelTipoPeriodoNominaBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTipoPeriodoNomina,
            this.colDescTipoPeriodoNomina1});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colIdTipoPeriodoNomina
            // 
            this.colIdTipoPeriodoNomina.FieldName = "IdTipoPeriodoNomina";
            this.colIdTipoPeriodoNomina.Name = "colIdTipoPeriodoNomina";
            // 
            // colDescTipoPeriodoNomina1
            // 
            this.colDescTipoPeriodoNomina1.Caption = "Tipo Periodo";
            this.colDescTipoPeriodoNomina1.FieldName = "DescTipoPeriodoNomina";
            this.colDescTipoPeriodoNomina1.Name = "colDescTipoPeriodoNomina1";
            this.colDescTipoPeriodoNomina1.Visible = true;
            this.colDescTipoPeriodoNomina1.VisibleIndex = 0;
            // 
            // vwFactBeneficiarioClienteTableAdapter
            // 
            this.vwFactBeneficiarioClienteTableAdapter.ClearBeforeFill = true;
            // 
            // periodoClienteTableAdapter
            // 
            this.periodoClienteTableAdapter.ClearBeforeFill = true;
            // 
            // stpFactSelTipoPeriodoNominaTableAdapter
            // 
            this.stpFactSelTipoPeriodoNominaTableAdapter.ClearBeforeFill = true;
            // 
            // txtAnoFiscal
            // 
            this.txtAnoFiscal.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtAnoFiscal.Location = new System.Drawing.Point(646, 47);
            this.txtAnoFiscal.Name = "txtAnoFiscal";
            this.txtAnoFiscal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtAnoFiscal.Size = new System.Drawing.Size(100, 20);
            this.txtAnoFiscal.TabIndex = 5;
            // 
            // frmxPeriodosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 414);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmxPeriodosCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Periodos de Clientes";
            this.Load += new System.EventHandler(this.frmxPeriodosCliente_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.sidePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPeriodoCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodoClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAIC_Catalogos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNodiaPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblIdPeriodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoPeriodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chePPeriodos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboIdClienteProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFactBeneficiarioClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoPeriodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelTipoPeriodoNominaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnoFiscal.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSALIR;
        private System.Windows.Forms.ToolStripButton btnCargar;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GridLookUpEdit cboIdClienteProveedor;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private Facturas.dbSAICBPOFactura dbSAICBPOFactura;
        private System.Windows.Forms.BindingSource vwFactBeneficiarioClienteBindingSource;
        private Facturas.dbSAICBPOFacturaTableAdapters.vwFactBeneficiarioClienteTableAdapter vwFactBeneficiarioClienteTableAdapter;
        private DevExpress.XtraGrid.GridControl gridPeriodoCliente;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreComercial;
        private dbSAIC_Catalogos dbSAIC_Catalogos;
        private System.Windows.Forms.BindingSource periodoClienteBindingSource;
        private dbSAIC_CatalogosTableAdapters.PeriodoClienteTableAdapter periodoClienteTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPeriodoCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreComercial1;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocial1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPeriodo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescTipoPeriodoNomina;
        private DevExpress.XtraGrid.Columns.GridColumn colNoPeriodo;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaInicio;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaFin;
        private DevExpress.XtraGrid.Columns.GridColumn colAnoFiscal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioModificacion;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource stpFactSelTipoPeriodoNominaBindingSource;
        private Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelTipoPeriodoNominaTableAdapter stpFactSelTipoPeriodoNominaTableAdapter;
        private DevExpress.XtraEditors.CheckEdit chePPeriodos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private DevExpress.XtraEditors.SpinEdit txtNoPeriodo;
        private System.Windows.Forms.Label lblCantidad;
        private DevExpress.XtraEditors.GridLookUpEdit cbTipoPeriodo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoPeriodoNomina;
        private DevExpress.XtraGrid.Columns.GridColumn colDescTipoPeriodoNomina1;
        private System.Windows.Forms.ToolStripButton btnBorrar;
        private DevExpress.XtraEditors.SpinEdit lblIdPeriodo;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private DevExpress.XtraEditors.SpinEdit txtNodiaPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtFechaPago;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaPago;
        private DevExpress.XtraEditors.SpinEdit txtAnoFiscal;
    }
}