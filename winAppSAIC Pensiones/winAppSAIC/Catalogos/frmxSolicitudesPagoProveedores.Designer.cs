namespace winAppSAIC.Catalogos
{
    partial class frmxSolicitudesPagoProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxSolicitudesPagoProveedores));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnGuardarSol = new DevExpress.XtraEditors.SimpleButton();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtDato = new DevExpress.XtraEditors.TextEdit();
            this.txtIdAreaOperativa = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.gdSolicitudesHead = new DevExpress.XtraGrid.GridControl();
            this.stpSelSolicitudPagoProveedHeaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAIC_Catalogos = new winAppSAIC.Catalogos.dbSAIC_Catalogos();
            this.grMovimientos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOLICITUD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAREA_OPERATIVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOMBRE_OPERADOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFECHA_SOLICITUD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMONTO_TOTAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMONTO_PAGADO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAVANCE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colESTATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFECHA_CREACION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.gpoSolicitud = new DevExpress.XtraEditors.GroupControl();
            this.gdEstatusSolicitud = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label9 = new System.Windows.Forms.Label();
            this.GpoDetControlGasto = new System.Windows.Forms.GroupBox();
            this.CmdGuardaPago = new DevExpress.XtraEditors.SimpleButton();
            this.txtIdPago = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gdTipoPagoProveedor = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdEstatusPago = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdEmpresaDPago = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblEstatusPago = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.spiMontoConcepto = new DevExpress.XtraEditors.SpinEdit();
            this.gdCliente = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSolicitud = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFechaSolicitud = new DevExpress.XtraEditors.DateEdit();
            this.cmbArea = new DevExpress.XtraEditors.GridLookUpEdit();
            this.stpAreaOpTipoPagoProvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOCatalogosDataSet = new winAppSAIC.dbSAICBPOCatalogosDataSet();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.gdSolicitudesDetail = new DevExpress.XtraGrid.GridControl();
            this.stpSelSolicitudPagoProveedDetailBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SOLICITUD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PAGO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AREA_OPERATIVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TIPO_DE_PAGO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EMPRESA_DE_PAGO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CLIENTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MONTO_A_PAGAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ESTATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.stpSelSolicitudPagoProveedDetailBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stpSelSolicitudPagoProveedDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwHeadSolicitudPagoProveedorBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.vwHeadSolicitudPagoProveedorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vwHeadSolicitudPagoProveedorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vwHeadSolicitudPagoProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stpAreaOpTipoPagoProvTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpAreaOpTipoPagoProvTableAdapter();
            this.dbSAICBPO_CatalogosValidacionDataSet1 = new winAppSAIC.Catalogos.dbSAICBPO_CatalogosValidacionDataSet();
            this.validacionesGeneralTableAdapter1 = new winAppSAIC.Catalogos.dbSAICBPO_CatalogosValidacionDataSetTableAdapters.ValidacionesGeneralTableAdapter();
            this.vwHeadSolicitudPagoProveedorTableAdapter = new winAppSAIC.Catalogos.dbSAIC_CatalogosTableAdapters.vwHeadSolicitudPagoProveedorTableAdapter();
            this.vwHeadSolicitudPagoProveedorTableAdapter1 = new winAppSAIC.Catalogos.dbSAIC_CatalogosTableAdapters.vwHeadSolicitudPagoProveedorTableAdapter();
            this.dbSAICCatalogosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stpSelSolicitudPagoProveedHeaderTableAdapter = new winAppSAIC.Catalogos.dbSAIC_CatalogosTableAdapters.stpSelSolicitudPagoProveedHeaderTableAdapter();
            this.dbSAICBPOCatalogosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stpSelSolicitudPagoProveedDetailTableAdapter = new winAppSAIC.Catalogos.dbSAIC_CatalogosTableAdapters.stpSelSolicitudPagoProveedDetailTableAdapter();
            this.stpSelSolicitudPagoProveedDetailTableAdapter1 = new winAppSAIC.Catalogos.dbSAIC_CatalogosTableAdapters.stpSelSolicitudPagoProveedDetailTableAdapter();
            this.dbSAICCatalogosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stpSelEstatusTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelEstatusTableAdapter();
            this.stpSelEstatusIdTableAdapter1 = new winAppSAIC.dbSAICBPOCatalogosDataSetTableAdapters.stpSelEstatusIdTableAdapter();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDato.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdAreaOperativa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdSolicitudesHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelSolicitudPagoProveedHeaderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAIC_Catalogos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grMovimientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpoSolicitud)).BeginInit();
            this.gpoSolicitud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdEstatusSolicitud.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            this.GpoDetControlGasto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdTipoPagoProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdEstatusPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdEmpresaDPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spiMontoConcepto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSolicitud.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaSolicitud.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaSolicitud.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbArea.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpAreaOpTipoPagoProvBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdSolicitudesDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelSolicitudPagoProveedDetailBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelSolicitudPagoProveedDetailBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelSolicitudPagoProveedDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwHeadSolicitudPagoProveedorBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwHeadSolicitudPagoProveedorBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwHeadSolicitudPagoProveedorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwHeadSolicitudPagoProveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPO_CatalogosValidacionDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICCatalogosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICCatalogosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1969, 32);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(73, 29);
            this.toolStripButton1.Text = "Salir";
            // 
            // btnGuardarSol
            // 
            this.btnGuardarSol.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarSol.ImageOptions.Image")));
            this.btnGuardarSol.Location = new System.Drawing.Point(7, 78);
            this.btnGuardarSol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarSol.Name = "btnGuardarSol";
            this.btnGuardarSol.Size = new System.Drawing.Size(155, 32);
            this.btnGuardarSol.TabIndex = 2;
            this.btnGuardarSol.Text = "Guardar solicitud";
            this.btnGuardarSol.Click += new System.EventHandler(this.btnGuardarSol_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(7, 35);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(155, 32);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nueva solicitud";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 32);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1969, 931);
            this.splitContainer1.SplitterDistance = 1753;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 136;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txtDato);
            this.splitContainer2.Panel1.Controls.Add(this.txtIdAreaOperativa);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(1753, 931);
            this.splitContainer2.SplitterDistance = 39;
            this.splitContainer2.SplitterWidth = 6;
            this.splitContainer2.TabIndex = 125;
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(877, 4);
            this.txtDato.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDato.Name = "txtDato";
            this.txtDato.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtDato.Properties.Appearance.Options.UseBackColor = true;
            this.txtDato.Size = new System.Drawing.Size(239, 26);
            this.txtDato.TabIndex = 126;
            this.txtDato.TabStop = false;
            this.txtDato.Tag = "Descripción";
            // 
            // txtIdAreaOperativa
            // 
            this.txtIdAreaOperativa.Location = new System.Drawing.Point(780, 6);
            this.txtIdAreaOperativa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdAreaOperativa.Name = "txtIdAreaOperativa";
            this.txtIdAreaOperativa.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtIdAreaOperativa.Properties.Appearance.Options.UseBackColor = true;
            this.txtIdAreaOperativa.Size = new System.Drawing.Size(89, 26);
            this.txtIdAreaOperativa.TabIndex = 125;
            this.txtIdAreaOperativa.TabStop = false;
            this.txtIdAreaOperativa.Tag = "Descripción";
            this.txtIdAreaOperativa.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(253, 20);
            this.label7.TabIndex = 123;
            this.label7.Text = "Solicitudes de pago a proveedores";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.gdSolicitudesHead);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(1753, 886);
            this.splitContainer3.SplitterDistance = 152;
            this.splitContainer3.SplitterWidth = 6;
            this.splitContainer3.TabIndex = 1;
            // 
            // gdSolicitudesHead
            // 
            this.gdSolicitudesHead.DataSource = this.stpSelSolicitudPagoProveedHeaderBindingSource;
            this.gdSolicitudesHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdSolicitudesHead.Location = new System.Drawing.Point(0, 0);
            this.gdSolicitudesHead.MainView = this.grMovimientos;
            this.gdSolicitudesHead.Name = "gdSolicitudesHead";
            this.gdSolicitudesHead.Size = new System.Drawing.Size(1753, 152);
            this.gdSolicitudesHead.TabIndex = 7;
            this.gdSolicitudesHead.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grMovimientos});
            this.gdSolicitudesHead.Click += new System.EventHandler(this.gdSolicitudesHead_Click);
            this.gdSolicitudesHead.DoubleClick += new System.EventHandler(this.gdSolicitudesHead_DoubleClick);
            // 
            // stpSelSolicitudPagoProveedHeaderBindingSource
            // 
            this.stpSelSolicitudPagoProveedHeaderBindingSource.DataMember = "stpSelSolicitudPagoProveedHeader";
            this.stpSelSolicitudPagoProveedHeaderBindingSource.DataSource = this.dbSAIC_Catalogos;
            // 
            // dbSAIC_Catalogos
            // 
            this.dbSAIC_Catalogos.DataSetName = "dbSAIC_Catalogos";
            this.dbSAIC_Catalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grMovimientos
            // 
            this.grMovimientos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOLICITUD,
            this.colAREA_OPERATIVA,
            this.colNOMBRE_OPERADOR,
            this.colFECHA_SOLICITUD,
            this.colMONTO_TOTAL,
            this.colMONTO_PAGADO,
            this.colAVANCE,
            this.colESTATUS,
            this.colFECHA_CREACION});
            this.grMovimientos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grMovimientos.GridControl = this.gdSolicitudesHead;
            this.grMovimientos.Name = "grMovimientos";
            this.grMovimientos.OptionsBehavior.Editable = false;
            this.grMovimientos.OptionsBehavior.ReadOnly = true;
            this.grMovimientos.OptionsView.ColumnAutoWidth = false;
            this.grMovimientos.OptionsView.ShowAutoFilterRow = true;
            this.grMovimientos.OptionsView.ShowGroupPanel = false;
            // 
            // colSOLICITUD
            // 
            this.colSOLICITUD.FieldName = "SOLICITUD";
            this.colSOLICITUD.Name = "colSOLICITUD";
            this.colSOLICITUD.Visible = true;
            this.colSOLICITUD.VisibleIndex = 0;
            this.colSOLICITUD.Width = 65;
            // 
            // colAREA_OPERATIVA
            // 
            this.colAREA_OPERATIVA.FieldName = "AREA_OPERATIVA";
            this.colAREA_OPERATIVA.Name = "colAREA_OPERATIVA";
            this.colAREA_OPERATIVA.Visible = true;
            this.colAREA_OPERATIVA.VisibleIndex = 1;
            this.colAREA_OPERATIVA.Width = 211;
            // 
            // colNOMBRE_OPERADOR
            // 
            this.colNOMBRE_OPERADOR.FieldName = "NOMBRE_OPERADOR";
            this.colNOMBRE_OPERADOR.Name = "colNOMBRE_OPERADOR";
            this.colNOMBRE_OPERADOR.Visible = true;
            this.colNOMBRE_OPERADOR.VisibleIndex = 2;
            this.colNOMBRE_OPERADOR.Width = 223;
            // 
            // colFECHA_SOLICITUD
            // 
            this.colFECHA_SOLICITUD.FieldName = "FECHA_SOLICITUD";
            this.colFECHA_SOLICITUD.Name = "colFECHA_SOLICITUD";
            this.colFECHA_SOLICITUD.Visible = true;
            this.colFECHA_SOLICITUD.VisibleIndex = 3;
            this.colFECHA_SOLICITUD.Width = 108;
            // 
            // colMONTO_TOTAL
            // 
            this.colMONTO_TOTAL.FieldName = "MONTO_TOTAL";
            this.colMONTO_TOTAL.Name = "colMONTO_TOTAL";
            this.colMONTO_TOTAL.Visible = true;
            this.colMONTO_TOTAL.VisibleIndex = 4;
            this.colMONTO_TOTAL.Width = 116;
            // 
            // colMONTO_PAGADO
            // 
            this.colMONTO_PAGADO.FieldName = "MONTO_PAGADO";
            this.colMONTO_PAGADO.Name = "colMONTO_PAGADO";
            this.colMONTO_PAGADO.Visible = true;
            this.colMONTO_PAGADO.VisibleIndex = 5;
            this.colMONTO_PAGADO.Width = 106;
            // 
            // colAVANCE
            // 
            this.colAVANCE.FieldName = "AVANCE";
            this.colAVANCE.Name = "colAVANCE";
            this.colAVANCE.Visible = true;
            this.colAVANCE.VisibleIndex = 6;
            this.colAVANCE.Width = 61;
            // 
            // colESTATUS
            // 
            this.colESTATUS.FieldName = "ESTATUS";
            this.colESTATUS.Name = "colESTATUS";
            this.colESTATUS.Visible = true;
            this.colESTATUS.VisibleIndex = 7;
            this.colESTATUS.Width = 189;
            // 
            // colFECHA_CREACION
            // 
            this.colFECHA_CREACION.FieldName = "FECHA_CREACION";
            this.colFECHA_CREACION.Name = "colFECHA_CREACION";
            this.colFECHA_CREACION.Visible = true;
            this.colFECHA_CREACION.VisibleIndex = 8;
            this.colFECHA_CREACION.Width = 115;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.gpoSolicitud);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.groupControl4);
            this.splitContainer4.Size = new System.Drawing.Size(1753, 728);
            this.splitContainer4.SplitterDistance = 187;
            this.splitContainer4.SplitterWidth = 6;
            this.splitContainer4.TabIndex = 0;
            // 
            // gpoSolicitud
            // 
            this.gpoSolicitud.Controls.Add(this.gdEstatusSolicitud);
            this.gpoSolicitud.Controls.Add(this.label9);
            this.gpoSolicitud.Controls.Add(this.GpoDetControlGasto);
            this.gpoSolicitud.Controls.Add(this.TxtSolicitud);
            this.gpoSolicitud.Controls.Add(this.label1);
            this.gpoSolicitud.Controls.Add(this.label3);
            this.gpoSolicitud.Controls.Add(this.dtFechaSolicitud);
            this.gpoSolicitud.Controls.Add(this.cmbArea);
            this.gpoSolicitud.Controls.Add(this.label2);
            this.gpoSolicitud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpoSolicitud.Enabled = false;
            this.gpoSolicitud.Location = new System.Drawing.Point(0, 0);
            this.gpoSolicitud.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpoSolicitud.Name = "gpoSolicitud";
            this.gpoSolicitud.Size = new System.Drawing.Size(1753, 187);
            this.gpoSolicitud.TabIndex = 131;
            this.gpoSolicitud.Text = "Solicitud";
            // 
            // gdEstatusSolicitud
            // 
            this.gdEstatusSolicitud.EditValue = "\"\"";
            this.gdEstatusSolicitud.Enabled = false;
            this.gdEstatusSolicitud.Location = new System.Drawing.Point(1216, 36);
            this.gdEstatusSolicitud.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gdEstatusSolicitud.Name = "gdEstatusSolicitud";
            this.gdEstatusSolicitud.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gdEstatusSolicitud.Properties.View = this.gridView6;
            this.gdEstatusSolicitud.Size = new System.Drawing.Size(329, 26);
            this.gdEstatusSolicitud.TabIndex = 145;
            // 
            // gridView6
            // 
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1105, 38);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 19);
            this.label9.TabIndex = 144;
            this.label9.Text = "Estatus Solic:";
            // 
            // GpoDetControlGasto
            // 
            this.GpoDetControlGasto.Controls.Add(this.CmdGuardaPago);
            this.GpoDetControlGasto.Controls.Add(this.txtIdPago);
            this.GpoDetControlGasto.Controls.Add(this.label4);
            this.GpoDetControlGasto.Controls.Add(this.label10);
            this.GpoDetControlGasto.Controls.Add(this.gdTipoPagoProveedor);
            this.GpoDetControlGasto.Controls.Add(this.gdEstatusPago);
            this.GpoDetControlGasto.Controls.Add(this.gdEmpresaDPago);
            this.GpoDetControlGasto.Controls.Add(this.lblEstatusPago);
            this.GpoDetControlGasto.Controls.Add(this.label5);
            this.GpoDetControlGasto.Controls.Add(this.label8);
            this.GpoDetControlGasto.Controls.Add(this.spiMontoConcepto);
            this.GpoDetControlGasto.Controls.Add(this.gdCliente);
            this.GpoDetControlGasto.Controls.Add(this.label6);
            this.GpoDetControlGasto.Enabled = false;
            this.GpoDetControlGasto.Location = new System.Drawing.Point(3, 78);
            this.GpoDetControlGasto.Name = "GpoDetControlGasto";
            this.GpoDetControlGasto.Size = new System.Drawing.Size(1625, 103);
            this.GpoDetControlGasto.TabIndex = 141;
            this.GpoDetControlGasto.TabStop = false;
            this.GpoDetControlGasto.Text = "Pago";
            // 
            // CmdGuardaPago
            // 
            this.CmdGuardaPago.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CmdGuardaPago.ImageOptions.Image")));
            this.CmdGuardaPago.Location = new System.Drawing.Point(1520, 41);
            this.CmdGuardaPago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmdGuardaPago.Name = "CmdGuardaPago";
            this.CmdGuardaPago.Size = new System.Drawing.Size(98, 35);
            this.CmdGuardaPago.TabIndex = 7;
            this.CmdGuardaPago.Text = "Guardar";
            this.CmdGuardaPago.Click += new System.EventHandler(this.CmdGuardaPago_Click);
            // 
            // txtIdPago
            // 
            this.txtIdPago.Enabled = false;
            this.txtIdPago.Location = new System.Drawing.Point(96, 28);
            this.txtIdPago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdPago.Name = "txtIdPago";
            this.txtIdPago.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtIdPago.Properties.Appearance.Options.UseBackColor = true;
            this.txtIdPago.Size = new System.Drawing.Size(77, 26);
            this.txtIdPago.TabIndex = 146;
            this.txtIdPago.TabStop = false;
            this.txtIdPago.Tag = "Descripción";
            this.txtIdPago.EditValueChanged += new System.EventHandler(this.txtIdPago_EditValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 132;
            this.label4.Text = "Tipo de Pago:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 32);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 19);
            this.label10.TabIndex = 145;
            this.label10.Text = "No. Pago:";
            // 
            // gdTipoPagoProveedor
            // 
            this.gdTipoPagoProveedor.EditValue = "";
            this.gdTipoPagoProveedor.Location = new System.Drawing.Point(305, 29);
            this.gdTipoPagoProveedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gdTipoPagoProveedor.Name = "gdTipoPagoProveedor";
            this.gdTipoPagoProveedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gdTipoPagoProveedor.Properties.DisplayMember = "DescTipoPagoProveedor";
            this.gdTipoPagoProveedor.Properties.ValueMember = "IdTipoPagoProveedor";
            this.gdTipoPagoProveedor.Properties.View = this.gridView3;
            this.gdTipoPagoProveedor.Size = new System.Drawing.Size(196, 26);
            this.gdTipoPagoProveedor.TabIndex = 3;
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gdEstatusPago
            // 
            this.gdEstatusPago.EditValue = "";
            this.gdEstatusPago.Enabled = false;
            this.gdEstatusPago.Location = new System.Drawing.Point(1213, 25);
            this.gdEstatusPago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gdEstatusPago.Name = "gdEstatusPago";
            this.gdEstatusPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gdEstatusPago.Properties.View = this.gridView2;
            this.gdEstatusPago.Size = new System.Drawing.Size(251, 26);
            this.gdEstatusPago.TabIndex = 144;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gdEmpresaDPago
            // 
            this.gdEmpresaDPago.Location = new System.Drawing.Point(700, 29);
            this.gdEmpresaDPago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gdEmpresaDPago.Name = "gdEmpresaDPago";
            this.gdEmpresaDPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gdEmpresaDPago.Properties.DisplayMember = "NombreComercial";
            this.gdEmpresaDPago.Properties.ValueMember = "IdTenedora";
            this.gdEmpresaDPago.Properties.View = this.gridView4;
            this.gdEmpresaDPago.Size = new System.Drawing.Size(362, 26);
            this.gdEmpresaDPago.TabIndex = 4;
            // 
            // gridView4
            // 
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // lblEstatusPago
            // 
            this.lblEstatusPago.AutoSize = true;
            this.lblEstatusPago.Location = new System.Drawing.Point(1078, 28);
            this.lblEstatusPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstatusPago.Name = "lblEstatusPago";
            this.lblEstatusPago.Size = new System.Drawing.Size(127, 19);
            this.lblEstatusPago.TabIndex = 143;
            this.lblEstatusPago.Text = "Estatus de Pago:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(554, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 19);
            this.label5.TabIndex = 134;
            this.label5.Text = "Empresa de pago:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 68);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 19);
            this.label8.TabIndex = 142;
            this.label8.Text = "Cliente:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // spiMontoConcepto
            // 
            this.spiMontoConcepto.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spiMontoConcepto.Location = new System.Drawing.Point(912, 65);
            this.spiMontoConcepto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.spiMontoConcepto.Name = "spiMontoConcepto";
            this.spiMontoConcepto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spiMontoConcepto.Size = new System.Drawing.Size(150, 26);
            this.spiMontoConcepto.TabIndex = 6;
            // 
            // gdCliente
            // 
            this.gdCliente.Location = new System.Drawing.Point(305, 65);
            this.gdCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gdCliente.Name = "gdCliente";
            this.gdCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gdCliente.Properties.View = this.gridView5;
            this.gdCliente.Size = new System.Drawing.Size(355, 26);
            this.gdCliente.TabIndex = 5;
            this.gdCliente.EditValueChanged += new System.EventHandler(this.gdCliente_EditValueChanged);
            // 
            // gridView5
            // 
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(845, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 136;
            this.label6.Text = "Monto:";
            // 
            // TxtSolicitud
            // 
            this.TxtSolicitud.Enabled = false;
            this.TxtSolicitud.Location = new System.Drawing.Point(96, 35);
            this.TxtSolicitud.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSolicitud.Name = "TxtSolicitud";
            this.TxtSolicitud.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtSolicitud.Properties.Appearance.Options.UseBackColor = true;
            this.TxtSolicitud.Size = new System.Drawing.Size(196, 26);
            this.TxtSolicitud.TabIndex = 126;
            this.TxtSolicitud.TabStop = false;
            this.TxtSolicitud.Tag = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 125;
            this.label1.Text = "Solicitud:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 140;
            this.label3.Text = "Area:";
            // 
            // dtFechaSolicitud
            // 
            this.dtFechaSolicitud.EditValue = null;
            this.dtFechaSolicitud.Location = new System.Drawing.Point(893, 35);
            this.dtFechaSolicitud.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtFechaSolicitud.Name = "dtFechaSolicitud";
            this.dtFechaSolicitud.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaSolicitud.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaSolicitud.Size = new System.Drawing.Size(150, 26);
            this.dtFechaSolicitud.TabIndex = 1;
            this.dtFechaSolicitud.EditValueChanged += new System.EventHandler(this.dtFechaSolicitud_EditValueChanged);
            // 
            // cmbArea
            // 
            this.cmbArea.EditValue = "";
            this.cmbArea.Enabled = false;
            this.cmbArea.Location = new System.Drawing.Point(362, 36);
            this.cmbArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbArea.Properties.Appearance.Options.UseBackColor = true;
            this.cmbArea.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbArea.Properties.DataSource = this.stpAreaOpTipoPagoProvBindingSource;
            this.cmbArea.Properties.DisplayMember = "DescAreaOperativa";
            this.cmbArea.Properties.ValueMember = "IdAreaOperativa";
            this.cmbArea.Properties.View = this.gridLookUpEdit1View;
            this.cmbArea.Size = new System.Drawing.Size(375, 26);
            this.cmbArea.TabIndex = 139;
            // 
            // stpAreaOpTipoPagoProvBindingSource
            // 
            this.stpAreaOpTipoPagoProvBindingSource.DataMember = "stpAreaOpTipoPagoProv";
            this.stpAreaOpTipoPagoProvBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet;
            // 
            // dbSAICBPOCatalogosDataSet
            // 
            this.dbSAICBPOCatalogosDataSet.DataSetName = "dbSAICBPOCatalogosDataSet";
            this.dbSAICBPOCatalogosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(754, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 128;
            this.label2.Text = "Fecha Solicitud:";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.gdSolicitudesDetail);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(0, 0);
            this.groupControl4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(1753, 535);
            this.groupControl4.TabIndex = 1;
            this.groupControl4.Text = "Detalle de Pagos";
            // 
            // gdSolicitudesDetail
            // 
            this.gdSolicitudesDetail.DataSource = this.stpSelSolicitudPagoProveedDetailBindingSource2;
            this.gdSolicitudesDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdSolicitudesDetail.Location = new System.Drawing.Point(3, 30);
            this.gdSolicitudesDetail.MainView = this.gridView1;
            this.gdSolicitudesDetail.Name = "gdSolicitudesDetail";
            this.gdSolicitudesDetail.Size = new System.Drawing.Size(1747, 502);
            this.gdSolicitudesDetail.TabIndex = 8;
            this.gdSolicitudesDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gdSolicitudesDetail.Click += new System.EventHandler(this.gdSolicitudesDetail_Click);
            this.gdSolicitudesDetail.DoubleClick += new System.EventHandler(this.gdSolicitudesDetail_DoubleClick);
            // 
            // stpSelSolicitudPagoProveedDetailBindingSource2
            // 
            this.stpSelSolicitudPagoProveedDetailBindingSource2.DataMember = "stpSelSolicitudPagoProveedDetail";
            this.stpSelSolicitudPagoProveedDetailBindingSource2.DataSource = this.dbSAIC_Catalogos;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SOLICITUD,
            this.PAGO,
            this.AREA_OPERATIVA,
            this.TIPO_DE_PAGO,
            this.EMPRESA_DE_PAGO,
            this.CLIENTE,
            this.MONTO_A_PAGAR,
            this.ESTATUS,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gdSolicitudesDetail;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // SOLICITUD
            // 
            this.SOLICITUD.Caption = "SOLICITUD";
            this.SOLICITUD.FieldName = "IdSolicitudPagoProveedor";
            this.SOLICITUD.Name = "SOLICITUD";
            this.SOLICITUD.Visible = true;
            this.SOLICITUD.VisibleIndex = 0;
            this.SOLICITUD.Width = 60;
            // 
            // PAGO
            // 
            this.PAGO.Caption = "PAGO";
            this.PAGO.FieldName = "PAGO";
            this.PAGO.Name = "PAGO";
            this.PAGO.Visible = true;
            this.PAGO.VisibleIndex = 1;
            this.PAGO.Width = 47;
            // 
            // AREA_OPERATIVA
            // 
            this.AREA_OPERATIVA.Caption = "AREA_OPERATIVA";
            this.AREA_OPERATIVA.FieldName = "AREA_OPERATIVA";
            this.AREA_OPERATIVA.Name = "AREA_OPERATIVA";
            this.AREA_OPERATIVA.Visible = true;
            this.AREA_OPERATIVA.VisibleIndex = 2;
            this.AREA_OPERATIVA.Width = 195;
            // 
            // TIPO_DE_PAGO
            // 
            this.TIPO_DE_PAGO.Caption = "TIPO_DE_PAGO";
            this.TIPO_DE_PAGO.FieldName = "TIPO_DE_PAGO";
            this.TIPO_DE_PAGO.Name = "TIPO_DE_PAGO";
            this.TIPO_DE_PAGO.Visible = true;
            this.TIPO_DE_PAGO.VisibleIndex = 3;
            this.TIPO_DE_PAGO.Width = 166;
            // 
            // EMPRESA_DE_PAGO
            // 
            this.EMPRESA_DE_PAGO.Caption = "EMPRESA_DE_PAGO";
            this.EMPRESA_DE_PAGO.FieldName = "EMPRESA_DE_PAGO";
            this.EMPRESA_DE_PAGO.Name = "EMPRESA_DE_PAGO";
            this.EMPRESA_DE_PAGO.Visible = true;
            this.EMPRESA_DE_PAGO.VisibleIndex = 4;
            this.EMPRESA_DE_PAGO.Width = 167;
            // 
            // CLIENTE
            // 
            this.CLIENTE.Caption = "CLIENTE";
            this.CLIENTE.FieldName = "CLIENTE";
            this.CLIENTE.Name = "CLIENTE";
            this.CLIENTE.Visible = true;
            this.CLIENTE.VisibleIndex = 5;
            this.CLIENTE.Width = 132;
            // 
            // MONTO_A_PAGAR
            // 
            this.MONTO_A_PAGAR.Caption = "MONTO_A_PAGAR";
            this.MONTO_A_PAGAR.FieldName = "MONTO_A_PAGAR";
            this.MONTO_A_PAGAR.Name = "MONTO_A_PAGAR";
            this.MONTO_A_PAGAR.Visible = true;
            this.MONTO_A_PAGAR.VisibleIndex = 6;
            this.MONTO_A_PAGAR.Width = 106;
            // 
            // ESTATUS
            // 
            this.ESTATUS.Caption = "ESTATUS";
            this.ESTATUS.FieldName = "ESTATUS";
            this.ESTATUS.Name = "ESTATUS";
            this.ESTATUS.Visible = true;
            this.ESTATUS.VisibleIndex = 7;
            this.ESTATUS.Width = 128;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "IdAreaOperativa";
            this.gridColumn1.FieldName = "IdAreaOperativa";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "IdTipoPagoProveedor";
            this.gridColumn2.FieldName = "IdTipoPagoProveedor";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "IdSolicitudPagoProveedor";
            this.gridColumn3.FieldName = "IdSolicitudPagoProveedor";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "IdEstatus";
            this.gridColumn4.FieldName = "IdEstatus";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "IdCliente";
            this.gridColumn5.FieldName = "IdCliente";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnNuevo);
            this.groupControl1.Controls.Add(this.btnGuardarSol);
            this.groupControl1.Location = new System.Drawing.Point(14, 45);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(173, 211);
            this.groupControl1.TabIndex = 139;
            // 
            // stpSelSolicitudPagoProveedDetailBindingSource1
            // 
            this.stpSelSolicitudPagoProveedDetailBindingSource1.DataMember = "stpSelSolicitudPagoProveedDetail";
            this.stpSelSolicitudPagoProveedDetailBindingSource1.DataSource = this.dbSAIC_Catalogos;
            // 
            // stpSelSolicitudPagoProveedDetailBindingSource
            // 
            this.stpSelSolicitudPagoProveedDetailBindingSource.DataMember = "stpSelSolicitudPagoProveedDetail";
            this.stpSelSolicitudPagoProveedDetailBindingSource.DataSource = this.dbSAIC_Catalogos;
            // 
            // vwHeadSolicitudPagoProveedorBindingSource3
            // 
            this.vwHeadSolicitudPagoProveedorBindingSource3.DataMember = "vwHeadSolicitudPagoProveedor";
            this.vwHeadSolicitudPagoProveedorBindingSource3.DataSource = this.dbSAIC_Catalogos;
            // 
            // vwHeadSolicitudPagoProveedorBindingSource2
            // 
            this.vwHeadSolicitudPagoProveedorBindingSource2.DataMember = "vwHeadSolicitudPagoProveedor";
            this.vwHeadSolicitudPagoProveedorBindingSource2.DataSource = this.dbSAIC_Catalogos;
            // 
            // vwHeadSolicitudPagoProveedorBindingSource1
            // 
            this.vwHeadSolicitudPagoProveedorBindingSource1.DataMember = "vwHeadSolicitudPagoProveedor";
            this.vwHeadSolicitudPagoProveedorBindingSource1.DataSource = this.dbSAIC_Catalogos;
            // 
            // vwHeadSolicitudPagoProveedorBindingSource
            // 
            this.vwHeadSolicitudPagoProveedorBindingSource.DataMember = "vwHeadSolicitudPagoProveedor";
            this.vwHeadSolicitudPagoProveedorBindingSource.DataSource = this.dbSAIC_Catalogos;
            // 
            // stpAreaOpTipoPagoProvTableAdapter1
            // 
            this.stpAreaOpTipoPagoProvTableAdapter1.ClearBeforeFill = true;
            // 
            // dbSAICBPO_CatalogosValidacionDataSet1
            // 
            this.dbSAICBPO_CatalogosValidacionDataSet1.DataSetName = "dbSAICBPO_CatalogosValidacionDataSet";
            this.dbSAICBPO_CatalogosValidacionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwHeadSolicitudPagoProveedorTableAdapter
            // 
            this.vwHeadSolicitudPagoProveedorTableAdapter.ClearBeforeFill = true;
            // 
            // vwHeadSolicitudPagoProveedorTableAdapter1
            // 
            this.vwHeadSolicitudPagoProveedorTableAdapter1.ClearBeforeFill = true;
            // 
            // dbSAICCatalogosBindingSource
            // 
            this.dbSAICCatalogosBindingSource.DataSource = this.dbSAIC_Catalogos;
            this.dbSAICCatalogosBindingSource.Position = 0;
            // 
            // stpSelSolicitudPagoProveedHeaderTableAdapter
            // 
            this.stpSelSolicitudPagoProveedHeaderTableAdapter.ClearBeforeFill = true;
            // 
            // dbSAICBPOCatalogosDataSetBindingSource
            // 
            this.dbSAICBPOCatalogosDataSetBindingSource.DataSource = this.dbSAICBPOCatalogosDataSet;
            this.dbSAICBPOCatalogosDataSetBindingSource.Position = 0;
            // 
            // stpSelSolicitudPagoProveedDetailTableAdapter
            // 
            this.stpSelSolicitudPagoProveedDetailTableAdapter.ClearBeforeFill = true;
            // 
            // stpSelSolicitudPagoProveedDetailTableAdapter1
            // 
            this.stpSelSolicitudPagoProveedDetailTableAdapter1.ClearBeforeFill = true;
            // 
            // dbSAICCatalogosBindingSource1
            // 
            this.dbSAICCatalogosBindingSource1.DataSource = this.dbSAIC_Catalogos;
            this.dbSAICCatalogosBindingSource1.Position = 0;
            // 
            // stpSelEstatusTableAdapter1
            // 
            this.stpSelEstatusTableAdapter1.ClearBeforeFill = true;
            // 
            // stpSelEstatusIdTableAdapter1
            // 
            this.stpSelEstatusIdTableAdapter1.ClearBeforeFill = true;
            // 
            // frmxSolicitudesPagoProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1969, 963);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmxSolicitudesPagoProveedores";
            this.Text = "Solicitudes de pago a proveedores";
            this.Load += new System.EventHandler(this.frmxSolicitudesPagoProveedores_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDato.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdAreaOperativa.Properties)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdSolicitudesHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelSolicitudPagoProveedHeaderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAIC_Catalogos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grMovimientos)).EndInit();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gpoSolicitud)).EndInit();
            this.gpoSolicitud.ResumeLayout(false);
            this.gpoSolicitud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdEstatusSolicitud.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            this.GpoDetControlGasto.ResumeLayout(false);
            this.GpoDetControlGasto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdTipoPagoProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdEstatusPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdEmpresaDPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spiMontoConcepto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSolicitud.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaSolicitud.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaSolicitud.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbArea.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpAreaOpTipoPagoProvBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdSolicitudesDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelSolicitudPagoProveedDetailBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stpSelSolicitudPagoProveedDetailBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelSolicitudPagoProveedDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwHeadSolicitudPagoProveedorBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwHeadSolicitudPagoProveedorBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwHeadSolicitudPagoProveedorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwHeadSolicitudPagoProveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPO_CatalogosValidacionDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICCatalogosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOCatalogosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICCatalogosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private DevExpress.XtraEditors.SimpleButton btnNuevo;
        private DevExpress.XtraEditors.SimpleButton btnGuardarSol;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.GridLookUpEdit gdEmpresaDPago;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.GridLookUpEdit gdTipoPagoProveedor;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.GroupControl gpoSolicitud;
        private DevExpress.XtraEditors.TextEdit TxtSolicitud;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit dtFechaSolicitud;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton CmdGuardaPago;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SpinEdit spiMontoConcepto;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.GridLookUpEdit gdCliente;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.GridLookUpEdit cmbArea;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit txtDato;
        private DevExpress.XtraEditors.TextEdit txtIdAreaOperativa;
        private dbSAICBPOCatalogosDataSet dbSAICBPOCatalogosDataSet;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpAreaOpTipoPagoProvTableAdapter stpAreaOpTipoPagoProvTableAdapter1;
        private System.Windows.Forms.BindingSource stpAreaOpTipoPagoProvBindingSource;
        private dbSAICBPO_CatalogosValidacionDataSet dbSAICBPO_CatalogosValidacionDataSet1;
        private dbSAICBPO_CatalogosValidacionDataSetTableAdapters.ValidacionesGeneralTableAdapter validacionesGeneralTableAdapter1;
        private dbSAIC_Catalogos dbSAIC_Catalogos;
        private System.Windows.Forms.BindingSource vwHeadSolicitudPagoProveedorBindingSource;
        private dbSAIC_CatalogosTableAdapters.vwHeadSolicitudPagoProveedorTableAdapter vwHeadSolicitudPagoProveedorTableAdapter;
        private dbSAIC_CatalogosTableAdapters.vwHeadSolicitudPagoProveedorTableAdapter vwHeadSolicitudPagoProveedorTableAdapter1;
        private DevExpress.XtraGrid.GridControl gdSolicitudesHead;
        private System.Windows.Forms.BindingSource vwHeadSolicitudPagoProveedorBindingSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView grMovimientos;
        private System.Windows.Forms.BindingSource vwHeadSolicitudPagoProveedorBindingSource2;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLICITUD;
        private DevExpress.XtraGrid.Columns.GridColumn colAREA_OPERATIVA;
        private DevExpress.XtraGrid.Columns.GridColumn colNOMBRE_OPERADOR;
        private DevExpress.XtraGrid.Columns.GridColumn colFECHA_SOLICITUD;
        private DevExpress.XtraGrid.Columns.GridColumn colMONTO_TOTAL;
        private DevExpress.XtraGrid.Columns.GridColumn colESTATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colFECHA_CREACION;
        private System.Windows.Forms.BindingSource dbSAICCatalogosBindingSource;
        private System.Windows.Forms.BindingSource vwHeadSolicitudPagoProveedorBindingSource3;
        private System.Windows.Forms.BindingSource stpSelSolicitudPagoProveedHeaderBindingSource;
        private dbSAIC_CatalogosTableAdapters.stpSelSolicitudPagoProveedHeaderTableAdapter stpSelSolicitudPagoProveedHeaderTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMONTO_PAGADO;
        private DevExpress.XtraGrid.Columns.GridColumn colAVANCE;
        private System.Windows.Forms.BindingSource stpSelSolicitudPagoProveedDetailBindingSource;
        private System.Windows.Forms.BindingSource dbSAICBPOCatalogosDataSetBindingSource;
        private dbSAIC_CatalogosTableAdapters.stpSelSolicitudPagoProveedDetailTableAdapter stpSelSolicitudPagoProveedDetailTableAdapter;
        private dbSAIC_CatalogosTableAdapters.stpSelSolicitudPagoProveedDetailTableAdapter stpSelSolicitudPagoProveedDetailTableAdapter1;
        private DevExpress.XtraGrid.GridControl gdSolicitudesDetail;
        private System.Windows.Forms.BindingSource stpSelSolicitudPagoProveedDetailBindingSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn PAGO;
        private DevExpress.XtraGrid.Columns.GridColumn AREA_OPERATIVA;
        private DevExpress.XtraGrid.Columns.GridColumn TIPO_DE_PAGO;
        private DevExpress.XtraGrid.Columns.GridColumn EMPRESA_DE_PAGO;
        private DevExpress.XtraGrid.Columns.GridColumn CLIENTE;
        private DevExpress.XtraGrid.Columns.GridColumn MONTO_A_PAGAR;
        private System.Windows.Forms.BindingSource dbSAICCatalogosBindingSource1;
        private System.Windows.Forms.BindingSource stpSelSolicitudPagoProveedDetailBindingSource2;
        private DevExpress.XtraGrid.Columns.GridColumn ESTATUS;
        private DevExpress.XtraEditors.GridLookUpEdit gdEstatusPago;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Label lblEstatusPago;
        private DevExpress.XtraEditors.TextEdit txtIdPago;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraGrid.Columns.GridColumn SOLICITUD;
        private System.Windows.Forms.GroupBox GpoDetControlGasto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.GridLookUpEdit gdEstatusSolicitud;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private System.Windows.Forms.Label label9;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelEstatusTableAdapter stpSelEstatusTableAdapter1;
        private dbSAICBPOCatalogosDataSetTableAdapters.stpSelEstatusIdTableAdapter stpSelEstatusIdTableAdapter1;
        //private dbSAICBPOCatalogosDataSetTableAdapters.stpAreaOpTipoPagoProvTableAdapter stpAreaOpTipoPagoProvTableAdapter1;
        //private System.Windows.Forms.BindingSource stpAreaOpTipoPagoProvBindingSource;
        //private dbSAICBPOCatalogosDataSetTableAdapters.vwCatAreaOperativaTableAdapter vwCatAreaOperativaTableAdapter1;
        //private System.Windows.Forms.BindingSource vwCatAreaOperativaBindingSource;
        //private System.Windows.Forms.BindingSource vwCatTenedoraMatrizBindingSource;
        //private dbSAICBPOCatalogosDataSetTableAdapters.vwCatTenedoraMatrizTableAdapter vwCatTenedoraMatrizTableAdapter;
        //private dbSAICBPODataSetTableAdapters.vwCatTenedoraMatrizTableAdapter vwCatTenedoraMatrizTableAdapter1;
    }
}