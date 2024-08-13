namespace winAppSAIC.Tesoreria
{
    partial class frmxMonitoreoSolicitudChequesMasivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxMonitoreoSolicitudChequesMasivos));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnCancelarSolicitud = new DevExpress.XtraBars.BarButtonItem();
            this.btnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gvSolicitudChequesMasivos = new DevExpress.XtraGrid.GridControl();
            this.stpSelSolicitudesChequesMasivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOTesoreriaDataSet = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdSolicitudChequeHeader = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdLoteCargaNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreComercialTenedora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreComercialCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBancoSolicitado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaInicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaFin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescTipoPeriodoNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoControl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stpSelSolicitudesChequesMasivosTableAdapter = new winAppSAIC.Tesoreria.dbSAICBPOTesoreriaDataSetTableAdapters.stpSelSolicitudesChequesMasivosTableAdapter();
            this.actualizacionesTesoreriaTableAdapter1 = new winAppSAIC.Tesoreria.dbSAICBPOActualizacionesTesoreriaDataSetTableAdapters.ActualizacionesTesoreriaTableAdapter();
            this.stpQueryTableAdapter1 = new winAppSAIC.dbSAICBPOReportesDataSetTableAdapters.stpQueryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSolicitudChequesMasivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelSolicitudesChequesMasivosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOTesoreriaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSalir,
            this.btnCancelarSolicitud});
            this.barManager1.MaxItemId = 2;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCancelarSolicitud, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSalir)});
            this.bar1.Text = "Tools";
            // 
            // btnCancelarSolicitud
            // 
            this.btnCancelarSolicitud.Caption = "Cancelar Solicitud";
            this.btnCancelarSolicitud.Id = 1;
            this.btnCancelarSolicitud.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarSolicitud.ImageOptions.Image")));
            this.btnCancelarSolicitud.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCancelarSolicitud.ImageOptions.LargeImage")));
            this.btnCancelarSolicitud.Name = "btnCancelarSolicitud";
            this.btnCancelarSolicitud.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancelarSolicitud_ItemClick);
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1008, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 562);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1008, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 531);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1008, 31);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 531);
            // 
            // gvSolicitudChequesMasivos
            // 
            this.gvSolicitudChequesMasivos.DataSource = this.stpSelSolicitudesChequesMasivosBindingSource;
            this.gvSolicitudChequesMasivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvSolicitudChequesMasivos.Location = new System.Drawing.Point(0, 31);
            this.gvSolicitudChequesMasivos.MainView = this.gridView1;
            this.gvSolicitudChequesMasivos.MenuManager = this.barManager1;
            this.gvSolicitudChequesMasivos.Name = "gvSolicitudChequesMasivos";
            this.gvSolicitudChequesMasivos.Size = new System.Drawing.Size(1008, 531);
            this.gvSolicitudChequesMasivos.TabIndex = 4;
            this.gvSolicitudChequesMasivos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gvSolicitudChequesMasivos.DoubleClick += new System.EventHandler(this.gvSolicitudChequesMasivos_DoubleClick);
            // 
            // stpSelSolicitudesChequesMasivosBindingSource
            // 
            this.stpSelSolicitudesChequesMasivosBindingSource.DataMember = "stpSelSolicitudesChequesMasivos";
            this.stpSelSolicitudesChequesMasivosBindingSource.DataSource = this.dbSAICBPOTesoreriaDataSet;
            // 
            // dbSAICBPOTesoreriaDataSet
            // 
            this.dbSAICBPOTesoreriaDataSet.DataSetName = "dbSAICBPOTesoreriaDataSet";
            this.dbSAICBPOTesoreriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdSolicitudChequeHeader,
            this.colIdLoteCargaNomina,
            this.colNombreComercialTenedora,
            this.colNombreComercialCliente,
            this.colBancoSolicitado,
            this.colOperador,
            this.colFechaInicio,
            this.colFechaFin,
            this.colDescTipoPeriodoNomina,
            this.colNoControl});
            this.gridView1.GridControl = this.gvSolicitudChequesMasivos;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdSolicitudChequeHeader
            // 
            this.colIdSolicitudChequeHeader.AppearanceCell.Options.UseTextOptions = true;
            this.colIdSolicitudChequeHeader.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdSolicitudChequeHeader.Caption = "Solicitud No.";
            this.colIdSolicitudChequeHeader.FieldName = "IdSolicitudChequeHeader";
            this.colIdSolicitudChequeHeader.Name = "colIdSolicitudChequeHeader";
            this.colIdSolicitudChequeHeader.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdSolicitudChequeHeader", "No. Solicitudes: {0}")});
            this.colIdSolicitudChequeHeader.Visible = true;
            this.colIdSolicitudChequeHeader.VisibleIndex = 0;
            this.colIdSolicitudChequeHeader.Width = 100;
            // 
            // colIdLoteCargaNomina
            // 
            this.colIdLoteCargaNomina.Caption = "Lote Nómina";
            this.colIdLoteCargaNomina.FieldName = "IdLoteCargaNomina";
            this.colIdLoteCargaNomina.Name = "colIdLoteCargaNomina";
            this.colIdLoteCargaNomina.Visible = true;
            this.colIdLoteCargaNomina.VisibleIndex = 2;
            // 
            // colNombreComercialTenedora
            // 
            this.colNombreComercialTenedora.Caption = "Tenedora";
            this.colNombreComercialTenedora.FieldName = "NombreComercialTenedora";
            this.colNombreComercialTenedora.Name = "colNombreComercialTenedora";
            this.colNombreComercialTenedora.Visible = true;
            this.colNombreComercialTenedora.VisibleIndex = 4;
            this.colNombreComercialTenedora.Width = 200;
            // 
            // colNombreComercialCliente
            // 
            this.colNombreComercialCliente.Caption = "Cliente";
            this.colNombreComercialCliente.FieldName = "NombreComercialCliente";
            this.colNombreComercialCliente.Name = "colNombreComercialCliente";
            this.colNombreComercialCliente.Visible = true;
            this.colNombreComercialCliente.VisibleIndex = 5;
            this.colNombreComercialCliente.Width = 200;
            // 
            // colBancoSolicitado
            // 
            this.colBancoSolicitado.FieldName = "BancoSolicitado";
            this.colBancoSolicitado.Name = "colBancoSolicitado";
            this.colBancoSolicitado.Visible = true;
            this.colBancoSolicitado.VisibleIndex = 6;
            this.colBancoSolicitado.Width = 150;
            // 
            // colOperador
            // 
            this.colOperador.FieldName = "Operador";
            this.colOperador.Name = "colOperador";
            this.colOperador.Visible = true;
            this.colOperador.VisibleIndex = 7;
            this.colOperador.Width = 150;
            // 
            // colFechaInicio
            // 
            this.colFechaInicio.FieldName = "FechaInicio";
            this.colFechaInicio.Name = "colFechaInicio";
            this.colFechaInicio.Visible = true;
            this.colFechaInicio.VisibleIndex = 8;
            // 
            // colFechaFin
            // 
            this.colFechaFin.FieldName = "FechaFin";
            this.colFechaFin.Name = "colFechaFin";
            this.colFechaFin.Visible = true;
            this.colFechaFin.VisibleIndex = 9;
            // 
            // colDescTipoPeriodoNomina
            // 
            this.colDescTipoPeriodoNomina.Caption = "Tipo Nómina";
            this.colDescTipoPeriodoNomina.FieldName = "DescTipoPeriodoNomina";
            this.colDescTipoPeriodoNomina.Name = "colDescTipoPeriodoNomina";
            this.colDescTipoPeriodoNomina.Visible = true;
            this.colDescTipoPeriodoNomina.VisibleIndex = 3;
            this.colDescTipoPeriodoNomina.Width = 100;
            // 
            // colNoControl
            // 
            this.colNoControl.AppearanceCell.Options.UseTextOptions = true;
            this.colNoControl.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNoControl.Caption = "No. Control Orden Pago";
            this.colNoControl.FieldName = "NoControl";
            this.colNoControl.Name = "colNoControl";
            this.colNoControl.Visible = true;
            this.colNoControl.VisibleIndex = 1;
            this.colNoControl.Width = 130;
            // 
            // stpSelSolicitudesChequesMasivosTableAdapter
            // 
            this.stpSelSolicitudesChequesMasivosTableAdapter.ClearBeforeFill = true;
            // 
            // frmxMonitoreoSolicitudChequesMasivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 562);
            this.ControlBox = false;
            this.Controls.Add(this.gvSolicitudChequesMasivos);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmxMonitoreoSolicitudChequesMasivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitoreo Solicitudes Cheques Masivos";
            this.Load += new System.EventHandler(this.frmxVisualizarSolicitudChequesMasivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSolicitudChequesMasivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelSolicitudesChequesMasivosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOTesoreriaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnSalir;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gvSolicitudChequesMasivos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dbSAICBPOTesoreriaDataSet dbSAICBPOTesoreriaDataSet;
        private System.Windows.Forms.BindingSource stpSelSolicitudesChequesMasivosBindingSource;
        private dbSAICBPOTesoreriaDataSetTableAdapters.stpSelSolicitudesChequesMasivosTableAdapter stpSelSolicitudesChequesMasivosTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSolicitudChequeHeader;
        private DevExpress.XtraGrid.Columns.GridColumn colIdLoteCargaNomina;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreComercialTenedora;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreComercialCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colBancoSolicitado;
        private DevExpress.XtraGrid.Columns.GridColumn colOperador;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaInicio;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaFin;
        private DevExpress.XtraGrid.Columns.GridColumn colDescTipoPeriodoNomina;
        private DevExpress.XtraGrid.Columns.GridColumn colNoControl;
        private dbSAICBPOActualizacionesTesoreriaDataSetTableAdapters.ActualizacionesTesoreriaTableAdapter actualizacionesTesoreriaTableAdapter1;
        private DevExpress.XtraBars.BarButtonItem btnCancelarSolicitud;
        private dbSAICBPOReportesDataSetTableAdapters.stpQueryTableAdapter stpQueryTableAdapter1;
    }
}