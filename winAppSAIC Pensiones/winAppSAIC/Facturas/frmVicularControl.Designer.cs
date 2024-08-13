namespace winAppSAIC.Facturas
{
    partial class frmVicularControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVicularControl));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.stpFactSelControlOperacionesVincularFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOFactura = new winAppSAIC.Facturas.dbSAICBPOFactura();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdControlOperaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocial1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMontoOperacion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreBanco1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocial2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMontoOperacion2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreBanco2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocial3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMontoOperacion3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreBanco3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocialSC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAsimilados = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescTipoPeriodoNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaInicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaFin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAlimentos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAsimilados = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalComision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalCAsimilados = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoCambio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaOperacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFronting1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBanco1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFronting2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBanco2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFronting3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBanco3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoPeriodoNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTenedoraSC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalImpuestos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalObligaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCompletoOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocialCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stpFactSelControlOperacionesVincularFacturaTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelControlOperacionesVincularFacturaTableAdapter();
            this.spSoloRespuesta1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.spSoloRespuesta();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelControlOperacionesVincularFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1016, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(49, 22);
            this.toolStripButton1.Text = "Salir";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::winAppSAIC.Properties.Resources._1486485557_add_create_new_more_plus_81188;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 22);
            this.btnCancelar.Text = "Vincular Control(es)";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.stpFactSelControlOperacionesVincularFacturaBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 25);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1016, 268);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // stpFactSelControlOperacionesVincularFacturaBindingSource
            // 
            this.stpFactSelControlOperacionesVincularFacturaBindingSource.DataMember = "stpFactSelControlOperacionesVincularFactura";
            this.stpFactSelControlOperacionesVincularFacturaBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // dbSAICBPOFactura
            // 
            this.dbSAICBPOFactura.DataSetName = "dbSAICBPOFactura";
            this.dbSAICBPOFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdControlOperaciones,
            this.colDescripcion,
            this.colRazonSocial1,
            this.colMontoOperacion1,
            this.colNombreBanco1,
            this.colRazonSocial2,
            this.colMontoOperacion2,
            this.colNombreBanco2,
            this.colRazonSocial3,
            this.colMontoOperacion3,
            this.colNombreBanco3,
            this.colRazonSocialSC,
            this.colAsimilados,
            this.colDescTipoPeriodoNomina,
            this.colFechaInicio,
            this.colFechaFin,
            this.colTotalNomina,
            this.colTotalAlimentos,
            this.colTotalAsimilados,
            this.colTotalComision,
            this.colTotalCAsimilados,
            this.colSubtotal,
            this.colIVA,
            this.colTotal,
            this.colIdMoneda,
            this.colTipoCambio,
            this.colFechaOperacion,
            this.colIdCliente,
            this.colIdFronting1,
            this.colIdBanco1,
            this.colIdFronting2,
            this.colIdBanco2,
            this.colIdFronting3,
            this.colIdBanco3,
            this.colIdTipoPeriodoNomina,
            this.colIdTenedoraSC,
            this.colTotalImpuestos,
            this.colTotalObligaciones,
            this.colIdEstatus,
            this.colIdOperador,
            this.colNombreCompletoOperador,
            this.colRazonSocialCliente});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colFechaInicio, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colIdControlOperaciones
            // 
            this.colIdControlOperaciones.Caption = "Id Control";
            this.colIdControlOperaciones.FieldName = "IdControlOperaciones";
            this.colIdControlOperaciones.Name = "colIdControlOperaciones";
            this.colIdControlOperaciones.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdControlOperaciones", "Controles: {0}")});
            this.colIdControlOperaciones.Visible = true;
            this.colIdControlOperaciones.VisibleIndex = 1;
            this.colIdControlOperaciones.Width = 59;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripción";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 2;
            this.colDescripcion.Width = 177;
            // 
            // colRazonSocial1
            // 
            this.colRazonSocial1.Caption = "Fronting 1";
            this.colRazonSocial1.FieldName = "NombreComercial1";
            this.colRazonSocial1.Name = "colRazonSocial1";
            this.colRazonSocial1.Visible = true;
            this.colRazonSocial1.VisibleIndex = 3;
            this.colRazonSocial1.Width = 256;
            // 
            // colMontoOperacion1
            // 
            this.colMontoOperacion1.Caption = "Monto";
            this.colMontoOperacion1.DisplayFormat.FormatString = "C2";
            this.colMontoOperacion1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMontoOperacion1.FieldName = "MontoOperacion1";
            this.colMontoOperacion1.Name = "colMontoOperacion1";
            this.colMontoOperacion1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MontoOperacion1", "{0:C2}")});
            this.colMontoOperacion1.Visible = true;
            this.colMontoOperacion1.VisibleIndex = 4;
            this.colMontoOperacion1.Width = 71;
            // 
            // colNombreBanco1
            // 
            this.colNombreBanco1.Caption = "Banco";
            this.colNombreBanco1.FieldName = "NombreBanco1";
            this.colNombreBanco1.Name = "colNombreBanco1";
            this.colNombreBanco1.Visible = true;
            this.colNombreBanco1.VisibleIndex = 5;
            this.colNombreBanco1.Width = 95;
            // 
            // colRazonSocial2
            // 
            this.colRazonSocial2.Caption = "Fronting 2";
            this.colRazonSocial2.FieldName = "NombreComercial2";
            this.colRazonSocial2.Name = "colRazonSocial2";
            this.colRazonSocial2.Visible = true;
            this.colRazonSocial2.VisibleIndex = 6;
            this.colRazonSocial2.Width = 259;
            // 
            // colMontoOperacion2
            // 
            this.colMontoOperacion2.Caption = "Monto";
            this.colMontoOperacion2.DisplayFormat.FormatString = "C2";
            this.colMontoOperacion2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMontoOperacion2.FieldName = "MontoOperacion2";
            this.colMontoOperacion2.Name = "colMontoOperacion2";
            this.colMontoOperacion2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MontoOperacion2", "{0:C2}")});
            this.colMontoOperacion2.Visible = true;
            this.colMontoOperacion2.VisibleIndex = 7;
            // 
            // colNombreBanco2
            // 
            this.colNombreBanco2.Caption = "Banco";
            this.colNombreBanco2.FieldName = "NombreBanco2";
            this.colNombreBanco2.Name = "colNombreBanco2";
            this.colNombreBanco2.Visible = true;
            this.colNombreBanco2.VisibleIndex = 8;
            this.colNombreBanco2.Width = 102;
            // 
            // colRazonSocial3
            // 
            this.colRazonSocial3.Caption = "Fronting 3";
            this.colRazonSocial3.FieldName = "NombreComercial3";
            this.colRazonSocial3.Name = "colRazonSocial3";
            this.colRazonSocial3.Visible = true;
            this.colRazonSocial3.VisibleIndex = 9;
            this.colRazonSocial3.Width = 275;
            // 
            // colMontoOperacion3
            // 
            this.colMontoOperacion3.Caption = "Monto";
            this.colMontoOperacion3.DisplayFormat.FormatString = "C2";
            this.colMontoOperacion3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMontoOperacion3.FieldName = "MontoOperacion3";
            this.colMontoOperacion3.Name = "colMontoOperacion3";
            this.colMontoOperacion3.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MontoOperacion3", "{0:C2}")});
            this.colMontoOperacion3.Visible = true;
            this.colMontoOperacion3.VisibleIndex = 10;
            // 
            // colNombreBanco3
            // 
            this.colNombreBanco3.Caption = "Banco";
            this.colNombreBanco3.FieldName = "NombreBanco3";
            this.colNombreBanco3.Name = "colNombreBanco3";
            this.colNombreBanco3.Visible = true;
            this.colNombreBanco3.VisibleIndex = 11;
            // 
            // colRazonSocialSC
            // 
            this.colRazonSocialSC.Caption = "SC";
            this.colRazonSocialSC.FieldName = "NombreComercialSC";
            this.colRazonSocialSC.Name = "colRazonSocialSC";
            this.colRazonSocialSC.Visible = true;
            this.colRazonSocialSC.VisibleIndex = 12;
            this.colRazonSocialSC.Width = 233;
            // 
            // colAsimilados
            // 
            this.colAsimilados.Caption = "Asimilados";
            this.colAsimilados.FieldName = "NombreComercialA";
            this.colAsimilados.Name = "colAsimilados";
            this.colAsimilados.Visible = true;
            this.colAsimilados.VisibleIndex = 13;
            this.colAsimilados.Width = 271;
            // 
            // colDescTipoPeriodoNomina
            // 
            this.colDescTipoPeriodoNomina.Caption = "Tipo Nómina";
            this.colDescTipoPeriodoNomina.FieldName = "DescTipoPeriodoNomina";
            this.colDescTipoPeriodoNomina.Name = "colDescTipoPeriodoNomina";
            this.colDescTipoPeriodoNomina.Visible = true;
            this.colDescTipoPeriodoNomina.VisibleIndex = 14;
            this.colDescTipoPeriodoNomina.Width = 110;
            // 
            // colFechaInicio
            // 
            this.colFechaInicio.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.colFechaInicio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFechaInicio.FieldName = "FechaInicio";
            this.colFechaInicio.Name = "colFechaInicio";
            this.colFechaInicio.Visible = true;
            this.colFechaInicio.VisibleIndex = 15;
            this.colFechaInicio.Width = 83;
            // 
            // colFechaFin
            // 
            this.colFechaFin.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.colFechaFin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFechaFin.FieldName = "FechaFin";
            this.colFechaFin.Name = "colFechaFin";
            this.colFechaFin.Visible = true;
            this.colFechaFin.VisibleIndex = 16;
            this.colFechaFin.Width = 90;
            // 
            // colTotalNomina
            // 
            this.colTotalNomina.Caption = "Total Nómina";
            this.colTotalNomina.DisplayFormat.FormatString = "C2";
            this.colTotalNomina.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalNomina.FieldName = "TotalNomina";
            this.colTotalNomina.Name = "colTotalNomina";
            this.colTotalNomina.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalNomina", "{0:C2}")});
            this.colTotalNomina.Visible = true;
            this.colTotalNomina.VisibleIndex = 17;
            this.colTotalNomina.Width = 100;
            // 
            // colTotalAlimentos
            // 
            this.colTotalAlimentos.Caption = "Total Alimentos";
            this.colTotalAlimentos.DisplayFormat.FormatString = "C2";
            this.colTotalAlimentos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalAlimentos.FieldName = "TotalAlimentos";
            this.colTotalAlimentos.Name = "colTotalAlimentos";
            this.colTotalAlimentos.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalAlimentos", "{0:C2}")});
            this.colTotalAlimentos.Visible = true;
            this.colTotalAlimentos.VisibleIndex = 18;
            this.colTotalAlimentos.Width = 97;
            // 
            // colTotalAsimilados
            // 
            this.colTotalAsimilados.Caption = "Total Asimilados";
            this.colTotalAsimilados.DisplayFormat.FormatString = "C2";
            this.colTotalAsimilados.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalAsimilados.FieldName = "TotalAsimilados";
            this.colTotalAsimilados.Name = "colTotalAsimilados";
            this.colTotalAsimilados.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalAsimilados", "{0:C2}")});
            this.colTotalAsimilados.Visible = true;
            this.colTotalAsimilados.VisibleIndex = 19;
            this.colTotalAsimilados.Width = 102;
            // 
            // colTotalComision
            // 
            this.colTotalComision.Caption = "Total Comisión";
            this.colTotalComision.DisplayFormat.FormatString = "C2";
            this.colTotalComision.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalComision.FieldName = "TotalComision";
            this.colTotalComision.Name = "colTotalComision";
            this.colTotalComision.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalComision", "{0:C2}")});
            this.colTotalComision.Visible = true;
            this.colTotalComision.VisibleIndex = 20;
            this.colTotalComision.Width = 94;
            // 
            // colTotalCAsimilados
            // 
            this.colTotalCAsimilados.Caption = "Comisión Asimilados";
            this.colTotalCAsimilados.DisplayFormat.FormatString = "C2";
            this.colTotalCAsimilados.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalCAsimilados.FieldName = "TotalCAsimilados";
            this.colTotalCAsimilados.Name = "colTotalCAsimilados";
            this.colTotalCAsimilados.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalCAsimilados", "{0:C2}")});
            this.colTotalCAsimilados.Visible = true;
            this.colTotalCAsimilados.VisibleIndex = 21;
            this.colTotalCAsimilados.Width = 94;
            // 
            // colSubtotal
            // 
            this.colSubtotal.DisplayFormat.FormatString = "C2";
            this.colSubtotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSubtotal.FieldName = "Subtotal";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Subtotal", "{0:C2}")});
            this.colSubtotal.Visible = true;
            this.colSubtotal.VisibleIndex = 22;
            this.colSubtotal.Width = 96;
            // 
            // colIVA
            // 
            this.colIVA.DisplayFormat.FormatString = "C2";
            this.colIVA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIVA.FieldName = "IVA";
            this.colIVA.Name = "colIVA";
            this.colIVA.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IVA", "{0:C2}")});
            this.colIVA.Visible = true;
            this.colIVA.VisibleIndex = 23;
            // 
            // colTotal
            // 
            this.colTotal.DisplayFormat.FormatString = "C2";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:C2}")});
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 24;
            // 
            // colIdMoneda
            // 
            this.colIdMoneda.Caption = "Moneda";
            this.colIdMoneda.FieldName = "IdMoneda";
            this.colIdMoneda.Name = "colIdMoneda";
            this.colIdMoneda.Visible = true;
            this.colIdMoneda.VisibleIndex = 25;
            // 
            // colTipoCambio
            // 
            this.colTipoCambio.Caption = "Tipo Cambio";
            this.colTipoCambio.DisplayFormat.FormatString = "C2";
            this.colTipoCambio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTipoCambio.FieldName = "TipoCambio";
            this.colTipoCambio.Name = "colTipoCambio";
            this.colTipoCambio.Visible = true;
            this.colTipoCambio.VisibleIndex = 26;
            // 
            // colFechaOperacion
            // 
            this.colFechaOperacion.Caption = "Fecha Operación";
            this.colFechaOperacion.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.colFechaOperacion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFechaOperacion.FieldName = "FechaOperacion";
            this.colFechaOperacion.Name = "colFechaOperacion";
            this.colFechaOperacion.Visible = true;
            this.colFechaOperacion.VisibleIndex = 27;
            this.colFechaOperacion.Width = 96;
            // 
            // colIdCliente
            // 
            this.colIdCliente.FieldName = "IdCliente";
            this.colIdCliente.Name = "colIdCliente";
            // 
            // colIdFronting1
            // 
            this.colIdFronting1.FieldName = "IdFronting1";
            this.colIdFronting1.Name = "colIdFronting1";
            // 
            // colIdBanco1
            // 
            this.colIdBanco1.FieldName = "IdBanco1";
            this.colIdBanco1.Name = "colIdBanco1";
            // 
            // colIdFronting2
            // 
            this.colIdFronting2.FieldName = "IdFronting2";
            this.colIdFronting2.Name = "colIdFronting2";
            // 
            // colIdBanco2
            // 
            this.colIdBanco2.FieldName = "IdBanco2";
            this.colIdBanco2.Name = "colIdBanco2";
            // 
            // colIdFronting3
            // 
            this.colIdFronting3.FieldName = "IdFronting3";
            this.colIdFronting3.Name = "colIdFronting3";
            // 
            // colIdBanco3
            // 
            this.colIdBanco3.FieldName = "IdBanco3";
            this.colIdBanco3.Name = "colIdBanco3";
            // 
            // colIdTipoPeriodoNomina
            // 
            this.colIdTipoPeriodoNomina.FieldName = "IdTipoPeriodoNomina";
            this.colIdTipoPeriodoNomina.Name = "colIdTipoPeriodoNomina";
            // 
            // colIdTenedoraSC
            // 
            this.colIdTenedoraSC.FieldName = "IdTenedoraSC";
            this.colIdTenedoraSC.Name = "colIdTenedoraSC";
            // 
            // colTotalImpuestos
            // 
            this.colTotalImpuestos.FieldName = "TotalImpuestos";
            this.colTotalImpuestos.Name = "colTotalImpuestos";
            // 
            // colTotalObligaciones
            // 
            this.colTotalObligaciones.FieldName = "TotalObligaciones";
            this.colTotalObligaciones.Name = "colTotalObligaciones";
            // 
            // colIdEstatus
            // 
            this.colIdEstatus.FieldName = "IdEstatus";
            this.colIdEstatus.Name = "colIdEstatus";
            // 
            // colIdOperador
            // 
            this.colIdOperador.FieldName = "IdOperador";
            this.colIdOperador.Name = "colIdOperador";
            // 
            // colNombreCompletoOperador
            // 
            this.colNombreCompletoOperador.Caption = "Operador";
            this.colNombreCompletoOperador.FieldName = "NombreCompletoOperador";
            this.colNombreCompletoOperador.Name = "colNombreCompletoOperador";
            this.colNombreCompletoOperador.Visible = true;
            this.colNombreCompletoOperador.VisibleIndex = 28;
            this.colNombreCompletoOperador.Width = 123;
            // 
            // colRazonSocialCliente
            // 
            this.colRazonSocialCliente.FieldName = "RazonSocialCliente";
            this.colRazonSocialCliente.Name = "colRazonSocialCliente";
            // 
            // stpFactSelControlOperacionesVincularFacturaTableAdapter
            // 
            this.stpFactSelControlOperacionesVincularFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // frmVicularControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 293);
            this.ControlBox = false;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmVicularControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vicular Control(es)";
            this.Load += new System.EventHandler(this.frmVicularControl_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelControlOperacionesVincularFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdControlOperaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFronting1;
        private DevExpress.XtraGrid.Columns.GridColumn colMontoOperacion1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBanco1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFronting2;
        private DevExpress.XtraGrid.Columns.GridColumn colMontoOperacion2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBanco2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFronting3;
        private DevExpress.XtraGrid.Columns.GridColumn colMontoOperacion3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBanco3;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaOperacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaInicio;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaFin;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoPeriodoNomina;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTenedoraSC;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalNomina;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAlimentos;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAsimilados;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalImpuestos;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalObligaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalComision;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalCAsimilados;
        private DevExpress.XtraGrid.Columns.GridColumn colSubtotal;
        private DevExpress.XtraGrid.Columns.GridColumn colIVA;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMoneda;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoCambio;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOperador;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocial1;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocial2;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocial3;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreBanco1;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreBanco2;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreBanco3;
        private DevExpress.XtraGrid.Columns.GridColumn colDescTipoPeriodoNomina;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocialSC;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCompletoOperador;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocialCliente;
        private dbSAICBPOFactura dbSAICBPOFactura;
        private System.Windows.Forms.BindingSource stpFactSelControlOperacionesVincularFacturaBindingSource;
        private dbSAICBPOFacturaTableAdapters.stpFactSelControlOperacionesVincularFacturaTableAdapter stpFactSelControlOperacionesVincularFacturaTableAdapter;
        private dbSAICBPOFacturaTableAdapters.spSoloRespuesta spSoloRespuesta1;
        private DevExpress.XtraGrid.Columns.GridColumn colAsimilados;
    }
}