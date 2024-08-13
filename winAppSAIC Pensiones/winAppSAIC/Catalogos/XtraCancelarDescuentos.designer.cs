namespace winAppSAIC.Catalogos
{
    partial class XtraCancelarDescuentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraCancelarDescuentos));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.btnCanDesc = new DevExpress.XtraBars.BarButtonItem();
            this.btnFiltrar = new DevExpress.XtraBars.BarButtonItem();
            this.btnEfiltro = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tbDescuentos = new DevExpress.XtraGrid.GridControl();
            this.stpSelObtenerDescuentosFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOFactura = new winAppSAIC.Facturas.dbSAICBPOFactura();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpleadoDescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreEmpleadoCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoDescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescTipoDescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoPeriodoNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescTipoPeriodoNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaInicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaFin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMatrizCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGrupoCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtFechaIni = new System.Windows.Forms.DateTimePicker();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.splashSMCargando = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::winAppSAIC.SplashDeCarga), true, true);
            this.stpSelObtenerDescuentosFTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpSelObtenerDescuentosFTableAdapter();
            this.spSoloRespuesta1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.spSoloRespuesta();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescuentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelObtenerDescuentosFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            this.sidePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSalir,
            this.barButtonItem2,
            this.btnCanDesc,
            this.btnFiltrar,
            this.btnEfiltro});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSalir),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCanDesc),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnFiltrar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEfiltro)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnSalir
            // 
            this.btnSalir.Caption = "Salir";
            this.btnSalir.Id = 0;
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.LargeImage")));
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalir_ItemClick);
            // 
            // btnCanDesc
            // 
            this.btnCanDesc.Caption = "Cancelar Descuetos";
            this.btnCanDesc.Id = 2;
            this.btnCanDesc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCanDesc.ImageOptions.Image")));
            this.btnCanDesc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCanDesc.ImageOptions.LargeImage")));
            this.btnCanDesc.Name = "btnCanDesc";
            this.btnCanDesc.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnCanDesc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCanDesc_ItemClick);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Caption = "Filtrar";
            this.btnFiltrar.Id = 3;
            this.btnFiltrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.ImageOptions.Image")));
            this.btnFiltrar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.ImageOptions.LargeImage")));
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnFiltrar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFiltrar_ItemClick);
            // 
            // btnEfiltro
            // 
            this.btnEfiltro.Caption = "Eliminar Filtro";
            this.btnEfiltro.Id = 4;
            this.btnEfiltro.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEfiltro.ImageOptions.Image")));
            this.btnEfiltro.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEfiltro.ImageOptions.LargeImage")));
            this.btnEfiltro.Name = "btnEfiltro";
            this.btnEfiltro.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnEfiltro.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEfiltro_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(899, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 420);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(899, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 396);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(899, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 396);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.tbDescuentos);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(899, 353);
            this.panelControl1.TabIndex = 4;
            // 
            // tbDescuentos
            // 
            this.tbDescuentos.DataSource = this.stpSelObtenerDescuentosFBindingSource;
            this.tbDescuentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDescuentos.Location = new System.Drawing.Point(2, 2);
            this.tbDescuentos.MainView = this.gridView1;
            this.tbDescuentos.MenuManager = this.barManager1;
            this.tbDescuentos.Name = "tbDescuentos";
            this.tbDescuentos.Size = new System.Drawing.Size(895, 349);
            this.tbDescuentos.TabIndex = 0;
            this.tbDescuentos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // stpSelObtenerDescuentosFBindingSource
            // 
            this.stpSelObtenerDescuentosFBindingSource.DataMember = "stpSelObtenerDescuentosF";
            this.stpSelObtenerDescuentosFBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // dbSAICBPOFactura
            // 
            this.dbSAICBPOFactura.DataSetName = "dbSAICBPOFactura";
            this.dbSAICBPOFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpleadoDescuento,
            this.colIdEmpleado,
            this.colNombreEmpleadoCompleto,
            this.colIdTipoDescuento,
            this.colDescTipoDescuento,
            this.colIdTipoPeriodoNomina,
            this.colDescTipoPeriodoNomina,
            this.colMonto,
            this.colFechaInicio,
            this.colFechaFin,
            this.colObservaciones,
            this.colIdEstatus,
            this.colDescEstatus,
            this.colIdCliente,
            this.colNCliente,
            this.colIdMatrizCliente,
            this.colNGrupoCliente});
            this.gridView1.GridControl = this.tbDescuentos;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdEmpleadoDescuento
            // 
            this.colIdEmpleadoDescuento.Caption = "Id";
            this.colIdEmpleadoDescuento.FieldName = "IdEmpleadoDescuento";
            this.colIdEmpleadoDescuento.Name = "colIdEmpleadoDescuento";
            this.colIdEmpleadoDescuento.Visible = true;
            this.colIdEmpleadoDescuento.VisibleIndex = 1;
            this.colIdEmpleadoDescuento.Width = 77;
            // 
            // colIdEmpleado
            // 
            this.colIdEmpleado.Caption = "ID Empleado";
            this.colIdEmpleado.FieldName = "IdEmpleado";
            this.colIdEmpleado.Name = "colIdEmpleado";
            this.colIdEmpleado.Visible = true;
            this.colIdEmpleado.VisibleIndex = 2;
            this.colIdEmpleado.Width = 98;
            // 
            // colNombreEmpleadoCompleto
            // 
            this.colNombreEmpleadoCompleto.Caption = "Nombre Empleado";
            this.colNombreEmpleadoCompleto.FieldName = "NombreEmpleadoCompleto";
            this.colNombreEmpleadoCompleto.Name = "colNombreEmpleadoCompleto";
            this.colNombreEmpleadoCompleto.Visible = true;
            this.colNombreEmpleadoCompleto.VisibleIndex = 3;
            this.colNombreEmpleadoCompleto.Width = 190;
            // 
            // colIdTipoDescuento
            // 
            this.colIdTipoDescuento.FieldName = "IdTipoDescuento";
            this.colIdTipoDescuento.Name = "colIdTipoDescuento";
            this.colIdTipoDescuento.Width = 31;
            // 
            // colDescTipoDescuento
            // 
            this.colDescTipoDescuento.Caption = "Descuento";
            this.colDescTipoDescuento.FieldName = "DescTipoDescuento";
            this.colDescTipoDescuento.Name = "colDescTipoDescuento";
            this.colDescTipoDescuento.Visible = true;
            this.colDescTipoDescuento.VisibleIndex = 4;
            this.colDescTipoDescuento.Width = 116;
            // 
            // colIdTipoPeriodoNomina
            // 
            this.colIdTipoPeriodoNomina.FieldName = "IdTipoPeriodoNomina";
            this.colIdTipoPeriodoNomina.Name = "colIdTipoPeriodoNomina";
            this.colIdTipoPeriodoNomina.Width = 31;
            // 
            // colDescTipoPeriodoNomina
            // 
            this.colDescTipoPeriodoNomina.Caption = "Periodo";
            this.colDescTipoPeriodoNomina.FieldName = "DescTipoPeriodoNomina";
            this.colDescTipoPeriodoNomina.Name = "colDescTipoPeriodoNomina";
            this.colDescTipoPeriodoNomina.Visible = true;
            this.colDescTipoPeriodoNomina.VisibleIndex = 6;
            this.colDescTipoPeriodoNomina.Width = 143;
            // 
            // colMonto
            // 
            this.colMonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMonto.FieldName = "Monto";
            this.colMonto.Name = "colMonto";
            this.colMonto.Visible = true;
            this.colMonto.VisibleIndex = 5;
            this.colMonto.Width = 111;
            // 
            // colFechaInicio
            // 
            this.colFechaInicio.FieldName = "FechaInicio";
            this.colFechaInicio.Name = "colFechaInicio";
            this.colFechaInicio.Visible = true;
            this.colFechaInicio.VisibleIndex = 7;
            this.colFechaInicio.Width = 100;
            // 
            // colFechaFin
            // 
            this.colFechaFin.FieldName = "FechaFin";
            this.colFechaFin.Name = "colFechaFin";
            this.colFechaFin.Visible = true;
            this.colFechaFin.VisibleIndex = 8;
            this.colFechaFin.Width = 87;
            // 
            // colObservaciones
            // 
            this.colObservaciones.FieldName = "Observaciones";
            this.colObservaciones.Name = "colObservaciones";
            this.colObservaciones.Visible = true;
            this.colObservaciones.VisibleIndex = 9;
            this.colObservaciones.Width = 91;
            // 
            // colIdEstatus
            // 
            this.colIdEstatus.FieldName = "IdEstatus";
            this.colIdEstatus.Name = "colIdEstatus";
            this.colIdEstatus.Width = 31;
            // 
            // colDescEstatus
            // 
            this.colDescEstatus.Caption = "Estatus";
            this.colDescEstatus.FieldName = "DescEstatus";
            this.colDescEstatus.Name = "colDescEstatus";
            this.colDescEstatus.Visible = true;
            this.colDescEstatus.VisibleIndex = 10;
            this.colDescEstatus.Width = 82;
            // 
            // colIdCliente
            // 
            this.colIdCliente.FieldName = "IdCliente";
            this.colIdCliente.Name = "colIdCliente";
            this.colIdCliente.Width = 31;
            // 
            // colNCliente
            // 
            this.colNCliente.Caption = "Cliente";
            this.colNCliente.FieldName = "NCliente";
            this.colNCliente.Name = "colNCliente";
            this.colNCliente.Visible = true;
            this.colNCliente.VisibleIndex = 11;
            this.colNCliente.Width = 185;
            // 
            // colIdMatrizCliente
            // 
            this.colIdMatrizCliente.FieldName = "IdMatrizCliente";
            this.colIdMatrizCliente.Name = "colIdMatrizCliente";
            this.colIdMatrizCliente.Width = 31;
            // 
            // colNGrupoCliente
            // 
            this.colNGrupoCliente.Caption = "Grupo Cliente";
            this.colNGrupoCliente.FieldName = "NGrupoCliente";
            this.colNGrupoCliente.Name = "colNGrupoCliente";
            this.colNGrupoCliente.Visible = true;
            this.colNGrupoCliente.VisibleIndex = 12;
            this.colNGrupoCliente.Width = 213;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.dtFechaFin);
            this.sidePanel1.Controls.Add(this.label2);
            this.sidePanel1.Controls.Add(this.label4);
            this.sidePanel1.Controls.Add(this.dtFechaIni);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel1.Location = new System.Drawing.Point(0, 24);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(899, 43);
            this.sidePanel1.TabIndex = 5;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFin.Location = new System.Drawing.Point(311, 12);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(114, 21);
            this.dtFechaFin.TabIndex = 99;
            this.dtFechaFin.Tag = "Fecha de Pago";
            this.dtFechaFin.Value = new System.DateTime(2018, 6, 4, 10, 45, 4, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 100;
            this.label2.Text = "Fecha de Fin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 98;
            this.label4.Text = "Fecha de Inicio:";
            // 
            // dtFechaIni
            // 
            this.dtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaIni.Location = new System.Drawing.Point(101, 12);
            this.dtFechaIni.Name = "dtFechaIni";
            this.dtFechaIni.Size = new System.Drawing.Size(114, 21);
            this.dtFechaIni.TabIndex = 97;
            this.dtFechaIni.Tag = "Fecha de Pago";
            this.dtFechaIni.Value = new System.DateTime(2018, 6, 4, 10, 44, 56, 0);
            // 
            // sidePanel2
            // 
            this.sidePanel2.Controls.Add(this.panelControl1);
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel2.Location = new System.Drawing.Point(0, 67);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(899, 353);
            this.sidePanel2.TabIndex = 6;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // splashSMCargando
            // 
            this.splashSMCargando.ClosingDelay = 500;
            // 
            // stpSelObtenerDescuentosFTableAdapter
            // 
            this.stpSelObtenerDescuentosFTableAdapter.ClearBeforeFill = true;
            // 
            // XtraCancelarDescuentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 420);
            this.Controls.Add(this.sidePanel2);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XtraCancelarDescuentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelar Descuentos";
            this.Load += new System.EventHandler(this.XtraCancelarDescuentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbDescuentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelObtenerDescuentosFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            this.sidePanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnSalir;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl tbDescuentos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtFechaIni;
        private DevExpress.XtraBars.BarButtonItem btnCanDesc;
        private DevExpress.XtraBars.BarButtonItem btnFiltrar;
        private DevExpress.XtraBars.BarButtonItem btnEfiltro;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashSMCargando;
        private System.Windows.Forms.BindingSource stpSelObtenerDescuentosFBindingSource;
        private Facturas.dbSAICBPOFactura dbSAICBPOFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpleadoDescuento;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreEmpleadoCompleto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoDescuento;
        private DevExpress.XtraGrid.Columns.GridColumn colDescTipoDescuento;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoPeriodoNomina;
        private DevExpress.XtraGrid.Columns.GridColumn colDescTipoPeriodoNomina;
        private DevExpress.XtraGrid.Columns.GridColumn colMonto;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaInicio;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaFin;
        private DevExpress.XtraGrid.Columns.GridColumn colObservaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colDescEstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colNCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMatrizCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colNGrupoCliente;
        private Facturas.dbSAICBPOFacturaTableAdapters.stpSelObtenerDescuentosFTableAdapter stpSelObtenerDescuentosFTableAdapter;
        private Facturas.dbSAICBPOFacturaTableAdapters.spSoloRespuesta spSoloRespuesta1;
    }
}