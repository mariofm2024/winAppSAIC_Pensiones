﻿namespace winAppSAIC.Facturas
{
    partial class frmAdmonFacturasFCV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmonFacturasFCV));
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnDescargar = new System.Windows.Forms.ToolStripButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTenedora = new System.Windows.Forms.Label();
            this.grConceptos = new DevExpress.XtraEditors.GroupControl();
            this.gvConceptos = new DevExpress.XtraGrid.GridControl();
            this.stpFactSelDetailFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOFactura = new winAppSAIC.Facturas.dbSAICBPOFactura();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdDetailFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdHeaderFactura2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUnidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn43 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComplemento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioUnitario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colISN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProdSAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.stpFactSelFacturasARelacionarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnComprobante = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFronting = new System.Windows.Forms.TextBox();
            this.txtTipoBeneficiarios = new System.Windows.Forms.TextBox();
            this.txtFormaPago = new System.Windows.Forms.TextBox();
            this.txtBeneficiario = new System.Windows.Forms.TextBox();
            this.txtFechaPago = new System.Windows.Forms.TextBox();
            this.txtMetodoPago = new System.Windows.Forms.TextBox();
            this.txtTotalDeposito = new System.Windows.Forms.TextBox();
            this.txtMoneda = new System.Windows.Forms.TextBox();
            this.txtTipoCambio = new System.Windows.Forms.TextBox();
            this.txtBancoOrigen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBancoDestino = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMesAno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkContabilizado = new System.Windows.Forms.CheckBox();
            this.stpFactSelHeaderFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stpFactSelHeaderFacturasTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelHeaderFacturasTableAdapter();
            this.cbFacturas = new DevExpress.XtraEditors.GridLookUpEdit();
            this.dgvFacturas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdHeaderFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSolicitudFactura0 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeriea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFolio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocialFronting = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescTipoBeneficiario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RazonSocialBeneficiario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdControlOperacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCompletoOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstatus0 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stpFactSelDetailFacturasTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelDetailFacturasTableAdapter();
            this.validacionesGeneralTableAdapter1 = new winAppSAIC.Catalogos.dbSAICBPO_CatalogosValidacionDataSetTableAdapters.ValidacionesGeneralTableAdapter();
            this.seguridadTableAdapter1 = new winAppSAIC.NominaCFDI.dbSAICBPONominaCFDIDataSetTableAdapters.SeguridadTableAdapter();
            this.spSoloRespuesta1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.spSoloRespuesta();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdHeaderFactura3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSolicitudFactura1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdControlOperacion2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFacturador1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocialFronting2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBeneficiario1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocialBeneficiario1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoBeneficiario1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescTipoBeneficiario2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMetodoPago1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClaveMetodoPago1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescMetodoPago1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFormaPago1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescFormaPago1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMoneda2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoCambio2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaPago1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIVA3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImporteConLetra1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdHeaderFacturaRelacion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFolioInterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaGeneracionCFDI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUUID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstatusDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalDepositado1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoRelacion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescTipoRelacion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstatus2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescEstatus2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComentarios1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOperador2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCompletoOperador3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stpFactSelFacturasARelacionarSATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtIdSolicitud = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.stpFactSelFacturasARelacionarSATTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelFacturasARelacionarSATTableAdapter();
            this.stpFactSelFacturasARelacionarTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelFacturasARelacionarTableAdapter();
            this.stpFactSelComprobantesFacturaTableAdapter1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelComprobantesFacturaTableAdapter();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOperador = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grConceptos)).BeginInit();
            this.grConceptos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvConceptos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelDetailFacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelFacturasARelacionarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelHeaderFacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFacturas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelFacturasARelacionarSATBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btnDescargar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(844, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(53, 24);
            this.toolStripButton1.Text = "Salir";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // btnDescargar
            // 
            this.btnDescargar.Image = ((System.Drawing.Image)(resources.GetObject("btnDescargar.Image")));
            this.btnDescargar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(106, 24);
            this.btnDescargar.Text = "Decargar CFDI";
            this.btnDescargar.Visible = false;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(523, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 162;
            this.label7.Text = "Tipo Cambio:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(272, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 13);
            this.label13.TabIndex = 158;
            this.label13.Text = "Cliente / Tenedora:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(57, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 156;
            this.label12.Text = "Tipo Beneficiario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 148;
            this.label6.Text = "Moneda:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 146;
            this.label5.Text = "Método de Pago:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 144;
            this.label8.Text = "Forma de Pago:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(64, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 142;
            this.label14.Text = "Fecha de Pago:";
            // 
            // lblTenedora
            // 
            this.lblTenedora.AutoSize = true;
            this.lblTenedora.Location = new System.Drawing.Point(76, 55);
            this.lblTenedora.Name = "lblTenedora";
            this.lblTenedora.Size = new System.Drawing.Size(70, 13);
            this.lblTenedora.TabIndex = 138;
            this.lblTenedora.Text = "Facturadora:";
            // 
            // grConceptos
            // 
            this.grConceptos.Controls.Add(this.gvConceptos);
            this.grConceptos.Location = new System.Drawing.Point(12, 223);
            this.grConceptos.Name = "grConceptos";
            this.grConceptos.Size = new System.Drawing.Size(816, 132);
            this.grConceptos.TabIndex = 137;
            this.grConceptos.Text = "Conceptos";
            // 
            // gvConceptos
            // 
            this.gvConceptos.DataSource = this.stpFactSelDetailFacturasBindingSource;
            this.gvConceptos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvConceptos.Location = new System.Drawing.Point(2, 20);
            this.gvConceptos.MainView = this.gridView1;
            this.gvConceptos.Name = "gvConceptos";
            this.gvConceptos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemGridLookUpEdit1});
            this.gvConceptos.Size = new System.Drawing.Size(812, 110);
            this.gvConceptos.TabIndex = 20;
            this.gvConceptos.Tag = "";
            this.gvConceptos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // stpFactSelDetailFacturasBindingSource
            // 
            this.stpFactSelDetailFacturasBindingSource.DataMember = "stpFactSelDetailFacturas";
            this.stpFactSelDetailFacturasBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // dbSAICBPOFactura
            // 
            this.dbSAICBPOFactura.DataSetName = "dbSAICBPOFactura";
            this.dbSAICBPOFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdDetailFactura,
            this.colIdHeaderFactura2,
            this.colCantidad,
            this.colIdUnidad,
            this.colNombre,
            this.gridColumn43,
            this.colComplemento,
            this.colPrecioUnitario,
            this.colIVA,
            this.colTotal3,
            this.colISN,
            this.colProdSAT});
            this.gridView1.GridControl = this.gvConceptos;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, null, null, "C2"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, null, null, "C2"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", null, "C2")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdDetailFactura
            // 
            this.colIdDetailFactura.FieldName = "IdDetailFactura";
            this.colIdDetailFactura.Name = "colIdDetailFactura";
            // 
            // colIdHeaderFactura2
            // 
            this.colIdHeaderFactura2.FieldName = "IdHeaderFactura";
            this.colIdHeaderFactura2.Name = "colIdHeaderFactura2";
            // 
            // colCantidad
            // 
            this.colCantidad.Caption = "CANT.";
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 0;
            this.colCantidad.Width = 55;
            // 
            // colIdUnidad
            // 
            this.colIdUnidad.FieldName = "IdUnidad";
            this.colIdUnidad.Name = "colIdUnidad";
            // 
            // colNombre
            // 
            this.colNombre.Caption = "UNIDAD";
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            this.colNombre.Width = 81;
            // 
            // gridColumn43
            // 
            this.gridColumn43.Caption = "gridColumn43";
            this.gridColumn43.FieldName = "IdConceptoBeneficiario";
            this.gridColumn43.Name = "gridColumn43";
            // 
            // colComplemento
            // 
            this.colComplemento.Caption = "CONCEPTO";
            this.colComplemento.FieldName = "Complemento";
            this.colComplemento.Name = "colComplemento";
            this.colComplemento.Visible = true;
            this.colComplemento.VisibleIndex = 3;
            this.colComplemento.Width = 211;
            // 
            // colPrecioUnitario
            // 
            this.colPrecioUnitario.Caption = "PRECIO UNITARIO";
            this.colPrecioUnitario.DisplayFormat.FormatString = "c2";
            this.colPrecioUnitario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrecioUnitario.FieldName = "PrecioUnitario";
            this.colPrecioUnitario.Name = "colPrecioUnitario";
            this.colPrecioUnitario.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PrecioUnitario", "{0:c2}")});
            this.colPrecioUnitario.Visible = true;
            this.colPrecioUnitario.VisibleIndex = 4;
            this.colPrecioUnitario.Width = 125;
            // 
            // colIVA
            // 
            this.colIVA.DisplayFormat.FormatString = "c2";
            this.colIVA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIVA.FieldName = "IVA";
            this.colIVA.Name = "colIVA";
            this.colIVA.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IVA", "{0:c2}")});
            this.colIVA.Visible = true;
            this.colIVA.VisibleIndex = 5;
            this.colIVA.Width = 100;
            // 
            // colTotal3
            // 
            this.colTotal3.Caption = "TOTAL";
            this.colTotal3.DisplayFormat.FormatString = "c2";
            this.colTotal3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal3.FieldName = "Total";
            this.colTotal3.Name = "colTotal3";
            this.colTotal3.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:c2}")});
            this.colTotal3.Visible = true;
            this.colTotal3.VisibleIndex = 6;
            this.colTotal3.Width = 100;
            // 
            // colISN
            // 
            this.colISN.Caption = "RETENCION ISN";
            this.colISN.DisplayFormat.FormatString = "c2";
            this.colISN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colISN.FieldName = "Descuento";
            this.colISN.Name = "colISN";
            this.colISN.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Descuento", "{0:c2}")});
            this.colISN.Visible = true;
            this.colISN.VisibleIndex = 7;
            this.colISN.Width = 85;
            // 
            // colProdSAT
            // 
            this.colProdSAT.Caption = "PROD. SAT";
            this.colProdSAT.FieldName = "ProductoServicioSAT";
            this.colProdSAT.Name = "colProdSAT";
            this.colProdSAT.Visible = true;
            this.colProdSAT.VisibleIndex = 2;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.ValueMember = "DescConceptoInterno";
            this.repositoryItemGridLookUpEdit1.View = this.gridView5;
            // 
            // gridView5
            // 
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(84, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 163;
            this.label1.Text = "Facturas:";
            // 
            // stpFactSelFacturasARelacionarBindingSource
            // 
            this.stpFactSelFacturasARelacionarBindingSource.DataMember = "stpFactSelFacturasARelacionar";
            this.stpFactSelFacturasARelacionarBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // btnComprobante
            // 
            this.btnComprobante.Enabled = false;
            this.btnComprobante.ImageOptions.ImageUri.Uri = "Save;Size16x16";
            this.btnComprobante.Location = new System.Drawing.Point(608, 98);
            this.btnComprobante.Name = "btnComprobante";
            this.btnComprobante.Size = new System.Drawing.Size(143, 23);
            this.btnComprobante.TabIndex = 173;
            this.btnComprobante.Text = "Descargar Comprobante";
            this.btnComprobante.Click += new System.EventHandler(this.btnComprobante_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(512, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 180;
            this.label2.Text = "Total Deposito:";
            // 
            // txtFronting
            // 
            this.txtFronting.BackColor = System.Drawing.Color.LightYellow;
            this.txtFronting.Location = new System.Drawing.Point(143, 52);
            this.txtFronting.Name = "txtFronting";
            this.txtFronting.ReadOnly = true;
            this.txtFronting.Size = new System.Drawing.Size(628, 21);
            this.txtFronting.TabIndex = 186;
            // 
            // txtTipoBeneficiarios
            // 
            this.txtTipoBeneficiarios.BackColor = System.Drawing.Color.LightYellow;
            this.txtTipoBeneficiarios.Location = new System.Drawing.Point(143, 76);
            this.txtTipoBeneficiarios.Name = "txtTipoBeneficiarios";
            this.txtTipoBeneficiarios.ReadOnly = true;
            this.txtTipoBeneficiarios.Size = new System.Drawing.Size(123, 21);
            this.txtTipoBeneficiarios.TabIndex = 187;
            // 
            // txtFormaPago
            // 
            this.txtFormaPago.BackColor = System.Drawing.Color.LightYellow;
            this.txtFormaPago.Location = new System.Drawing.Point(369, 100);
            this.txtFormaPago.Name = "txtFormaPago";
            this.txtFormaPago.ReadOnly = true;
            this.txtFormaPago.Size = new System.Drawing.Size(135, 21);
            this.txtFormaPago.TabIndex = 188;
            // 
            // txtBeneficiario
            // 
            this.txtBeneficiario.BackColor = System.Drawing.Color.LightYellow;
            this.txtBeneficiario.Location = new System.Drawing.Point(369, 76);
            this.txtBeneficiario.Name = "txtBeneficiario";
            this.txtBeneficiario.ReadOnly = true;
            this.txtBeneficiario.Size = new System.Drawing.Size(402, 21);
            this.txtBeneficiario.TabIndex = 189;
            // 
            // txtFechaPago
            // 
            this.txtFechaPago.BackColor = System.Drawing.Color.LightYellow;
            this.txtFechaPago.Location = new System.Drawing.Point(143, 148);
            this.txtFechaPago.Name = "txtFechaPago";
            this.txtFechaPago.ReadOnly = true;
            this.txtFechaPago.Size = new System.Drawing.Size(123, 21);
            this.txtFechaPago.TabIndex = 192;
            // 
            // txtMetodoPago
            // 
            this.txtMetodoPago.BackColor = System.Drawing.Color.LightYellow;
            this.txtMetodoPago.Location = new System.Drawing.Point(143, 100);
            this.txtMetodoPago.Name = "txtMetodoPago";
            this.txtMetodoPago.ReadOnly = true;
            this.txtMetodoPago.Size = new System.Drawing.Size(123, 21);
            this.txtMetodoPago.TabIndex = 193;
            // 
            // txtTotalDeposito
            // 
            this.txtTotalDeposito.BackColor = System.Drawing.Color.LightYellow;
            this.txtTotalDeposito.Location = new System.Drawing.Point(590, 124);
            this.txtTotalDeposito.Name = "txtTotalDeposito";
            this.txtTotalDeposito.ReadOnly = true;
            this.txtTotalDeposito.Size = new System.Drawing.Size(181, 21);
            this.txtTotalDeposito.TabIndex = 194;
            // 
            // txtMoneda
            // 
            this.txtMoneda.BackColor = System.Drawing.Color.LightYellow;
            this.txtMoneda.Location = new System.Drawing.Point(369, 148);
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.ReadOnly = true;
            this.txtMoneda.Size = new System.Drawing.Size(135, 21);
            this.txtMoneda.TabIndex = 195;
            // 
            // txtTipoCambio
            // 
            this.txtTipoCambio.BackColor = System.Drawing.Color.LightYellow;
            this.txtTipoCambio.Location = new System.Drawing.Point(590, 148);
            this.txtTipoCambio.Name = "txtTipoCambio";
            this.txtTipoCambio.ReadOnly = true;
            this.txtTipoCambio.Size = new System.Drawing.Size(181, 21);
            this.txtTipoCambio.TabIndex = 196;
            // 
            // txtBancoOrigen
            // 
            this.txtBancoOrigen.BackColor = System.Drawing.Color.LightYellow;
            this.txtBancoOrigen.Location = new System.Drawing.Point(143, 124);
            this.txtBancoOrigen.Name = "txtBancoOrigen";
            this.txtBancoOrigen.ReadOnly = true;
            this.txtBancoOrigen.Size = new System.Drawing.Size(123, 21);
            this.txtBancoOrigen.TabIndex = 200;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 199;
            this.label4.Text = "Banco Origen:";
            // 
            // txtBancoDestino
            // 
            this.txtBancoDestino.BackColor = System.Drawing.Color.LightYellow;
            this.txtBancoDestino.Location = new System.Drawing.Point(369, 124);
            this.txtBancoDestino.Name = "txtBancoDestino";
            this.txtBancoDestino.ReadOnly = true;
            this.txtBancoDestino.Size = new System.Drawing.Size(135, 21);
            this.txtBancoDestino.TabIndex = 202;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(293, 127);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 13);
            this.label15.TabIndex = 201;
            this.label15.Text = "Banco Destino:";
            // 
            // txtMesAno
            // 
            this.txtMesAno.BackColor = System.Drawing.Color.LightYellow;
            this.txtMesAno.Location = new System.Drawing.Point(369, 172);
            this.txtMesAno.Name = "txtMesAno";
            this.txtMesAno.ReadOnly = true;
            this.txtMesAno.Size = new System.Drawing.Size(135, 21);
            this.txtMesAno.TabIndex = 204;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(252, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 13);
            this.label9.TabIndex = 203;
            this.label9.Text = "Mes/Año Contabilizado:";
            // 
            // chkContabilizado
            // 
            this.chkContabilizado.AutoSize = true;
            this.chkContabilizado.Enabled = false;
            this.chkContabilizado.Location = new System.Drawing.Point(143, 175);
            this.chkContabilizado.Name = "chkContabilizado";
            this.chkContabilizado.Size = new System.Drawing.Size(90, 17);
            this.chkContabilizado.TabIndex = 205;
            this.chkContabilizado.Text = "Contabilizado";
            this.chkContabilizado.UseVisualStyleBackColor = true;
            // 
            // stpFactSelHeaderFacturasBindingSource
            // 
            this.stpFactSelHeaderFacturasBindingSource.DataMember = "stpFactSelHeaderFacturas";
            this.stpFactSelHeaderFacturasBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // stpFactSelHeaderFacturasTableAdapter
            // 
            this.stpFactSelHeaderFacturasTableAdapter.ClearBeforeFill = true;
            // 
            // cbFacturas
            // 
            this.cbFacturas.Location = new System.Drawing.Point(143, 29);
            this.cbFacturas.Name = "cbFacturas";
            this.cbFacturas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFacturas.Properties.DataSource = this.stpFactSelHeaderFacturasBindingSource;
            this.cbFacturas.Properties.DisplayMember = "IdHeaderFactura";
            this.cbFacturas.Properties.NullText = "";
            this.cbFacturas.Properties.ValueMember = "IdHeaderFactura";
            this.cbFacturas.Properties.View = this.dgvFacturas;
            this.cbFacturas.Size = new System.Drawing.Size(123, 20);
            this.cbFacturas.TabIndex = 164;
            this.cbFacturas.EditValueChanged += new System.EventHandler(this.cbFacturas_EditValueChanged);
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdHeaderFactura,
            this.colIdSolicitudFactura0,
            this.colSeriea,
            this.colFolio,
            this.colRazonSocialFronting,
            this.colDescTipoBeneficiario,
            this.RazonSocialBeneficiario,
            this.colIdControlOperacion,
            this.colTotal,
            this.colDescEstatus,
            this.colNombreCompletoOperador,
            this.colIdEstatus0});
            this.dgvFacturas.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgvFacturas.OptionsView.ColumnAutoWidth = false;
            this.dgvFacturas.OptionsView.ShowGroupPanel = false;
            this.dgvFacturas.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.dgvFacturas_RowStyle);
            // 
            // colIdHeaderFactura
            // 
            this.colIdHeaderFactura.Caption = "Id Factura";
            this.colIdHeaderFactura.FieldName = "IdHeaderFactura";
            this.colIdHeaderFactura.Name = "colIdHeaderFactura";
            this.colIdHeaderFactura.Visible = true;
            this.colIdHeaderFactura.VisibleIndex = 0;
            this.colIdHeaderFactura.Width = 70;
            // 
            // colIdSolicitudFactura0
            // 
            this.colIdSolicitudFactura0.Caption = "Id Solicitud";
            this.colIdSolicitudFactura0.FieldName = "IdSolicitudFactura";
            this.colIdSolicitudFactura0.Name = "colIdSolicitudFactura0";
            this.colIdSolicitudFactura0.Visible = true;
            this.colIdSolicitudFactura0.VisibleIndex = 1;
            // 
            // colSeriea
            // 
            this.colSeriea.Caption = "Serie";
            this.colSeriea.FieldName = "Serie";
            this.colSeriea.Name = "colSeriea";
            this.colSeriea.Visible = true;
            this.colSeriea.VisibleIndex = 3;
            // 
            // colFolio
            // 
            this.colFolio.Caption = "Folio";
            this.colFolio.FieldName = "FolioInterno";
            this.colFolio.Name = "colFolio";
            this.colFolio.Visible = true;
            this.colFolio.VisibleIndex = 4;
            // 
            // colRazonSocialFronting
            // 
            this.colRazonSocialFronting.Caption = "Fronting";
            this.colRazonSocialFronting.FieldName = "NombreComercialFronting";
            this.colRazonSocialFronting.Name = "colRazonSocialFronting";
            this.colRazonSocialFronting.Visible = true;
            this.colRazonSocialFronting.VisibleIndex = 5;
            this.colRazonSocialFronting.Width = 331;
            // 
            // colDescTipoBeneficiario
            // 
            this.colDescTipoBeneficiario.Caption = "Tipo Beneficiario";
            this.colDescTipoBeneficiario.FieldName = "DescTipoBeneficiario";
            this.colDescTipoBeneficiario.Name = "colDescTipoBeneficiario";
            this.colDescTipoBeneficiario.Visible = true;
            this.colDescTipoBeneficiario.VisibleIndex = 7;
            this.colDescTipoBeneficiario.Width = 126;
            // 
            // RazonSocialBeneficiario
            // 
            this.RazonSocialBeneficiario.Caption = "Beneficiario";
            this.RazonSocialBeneficiario.FieldName = "NombreComercialBeneficiario";
            this.RazonSocialBeneficiario.Name = "RazonSocialBeneficiario";
            this.RazonSocialBeneficiario.Visible = true;
            this.RazonSocialBeneficiario.VisibleIndex = 6;
            this.RazonSocialBeneficiario.Width = 323;
            // 
            // colIdControlOperacion
            // 
            this.colIdControlOperacion.Caption = "No. Control";
            this.colIdControlOperacion.FieldName = "IdControlOperacion";
            this.colIdControlOperacion.Name = "colIdControlOperacion";
            this.colIdControlOperacion.Visible = true;
            this.colIdControlOperacion.VisibleIndex = 2;
            this.colIdControlOperacion.Width = 73;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "Total";
            this.colTotal.DisplayFormat.FormatString = "C2";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 8;
            this.colTotal.Width = 67;
            // 
            // colDescEstatus
            // 
            this.colDescEstatus.Caption = "Estatus";
            this.colDescEstatus.FieldName = "DescEstatus";
            this.colDescEstatus.Name = "colDescEstatus";
            this.colDescEstatus.Visible = true;
            this.colDescEstatus.VisibleIndex = 9;
            this.colDescEstatus.Width = 128;
            // 
            // colNombreCompletoOperador
            // 
            this.colNombreCompletoOperador.Caption = "Operador";
            this.colNombreCompletoOperador.FieldName = "NombreCompletoOperador";
            this.colNombreCompletoOperador.Name = "colNombreCompletoOperador";
            this.colNombreCompletoOperador.Visible = true;
            this.colNombreCompletoOperador.VisibleIndex = 10;
            this.colNombreCompletoOperador.Width = 221;
            // 
            // colIdEstatus0
            // 
            this.colIdEstatus0.Caption = "gridColumn1";
            this.colIdEstatus0.FieldName = "IdEstatus";
            this.colIdEstatus0.Name = "colIdEstatus0";
            // 
            // stpFactSelDetailFacturasTableAdapter
            // 
            this.stpFactSelDetailFacturasTableAdapter.ClearBeforeFill = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 359);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(816, 127);
            this.groupControl1.TabIndex = 167;
            this.groupControl1.Text = "Facturas Relacionadas SAT";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.stpFactSelFacturasARelacionarSATBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.gridView4;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(813, 105);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdHeaderFactura3,
            this.colIdSolicitudFactura1,
            this.colIdControlOperacion2,
            this.gridColumn2,
            this.gridColumn1,
            this.colIdFacturador1,
            this.colRazonSocialFronting2,
            this.colIdBeneficiario1,
            this.colRazonSocialBeneficiario1,
            this.colIdTipoBeneficiario1,
            this.colDescTipoBeneficiario2,
            this.colIdMetodoPago1,
            this.colClaveMetodoPago1,
            this.colDescMetodoPago1,
            this.colIdFormaPago1,
            this.colDescFormaPago1,
            this.colIdMoneda2,
            this.colTipoCambio2,
            this.colFechaPago1,
            this.colSubTotal,
            this.colIVA3,
            this.colTotal4,
            this.colImporteConLetra1,
            this.colIdHeaderFacturaRelacion1,
            this.colSerie,
            this.colFolioInterno,
            this.colFechaGeneracionCFDI,
            this.colUUID1,
            this.colEstatusDocumento,
            this.colTotalDepositado1,
            this.colIdTipoRelacion1,
            this.colDescTipoRelacion1,
            this.colIdEstatus2,
            this.colDescEstatus2,
            this.colComentarios1,
            this.colIdOperador2,
            this.colNombreCompletoOperador3});
            this.gridView4.GridControl = this.gridControl1;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsBehavior.Editable = false;
            this.gridView4.OptionsView.ColumnAutoWidth = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            this.gridView4.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSubTotal, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colIdHeaderFactura3
            // 
            this.colIdHeaderFactura3.Caption = "Id Factura";
            this.colIdHeaderFactura3.FieldName = "IdHeaderFactura";
            this.colIdHeaderFactura3.Name = "colIdHeaderFactura3";
            this.colIdHeaderFactura3.Visible = true;
            this.colIdHeaderFactura3.VisibleIndex = 0;
            // 
            // colIdSolicitudFactura1
            // 
            this.colIdSolicitudFactura1.Caption = "Id Solicitud";
            this.colIdSolicitudFactura1.FieldName = "IdSolicitudFactura";
            this.colIdSolicitudFactura1.Name = "colIdSolicitudFactura1";
            this.colIdSolicitudFactura1.Visible = true;
            this.colIdSolicitudFactura1.VisibleIndex = 1;
            // 
            // colIdControlOperacion2
            // 
            this.colIdControlOperacion2.Caption = "Id Control Operaciones";
            this.colIdControlOperacion2.FieldName = "IdControlOperacion";
            this.colIdControlOperacion2.Name = "colIdControlOperacion2";
            this.colIdControlOperacion2.Visible = true;
            this.colIdControlOperacion2.VisibleIndex = 2;
            this.colIdControlOperacion2.Width = 87;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Serie";
            this.gridColumn2.FieldName = "Serie";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Folio";
            this.gridColumn1.FieldName = "FolioInterno";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            // 
            // colIdFacturador1
            // 
            this.colIdFacturador1.FieldName = "IdFacturador";
            this.colIdFacturador1.Name = "colIdFacturador1";
            // 
            // colRazonSocialFronting2
            // 
            this.colRazonSocialFronting2.Caption = "Fronting";
            this.colRazonSocialFronting2.FieldName = "NombreComercialFronting";
            this.colRazonSocialFronting2.Name = "colRazonSocialFronting2";
            this.colRazonSocialFronting2.Visible = true;
            this.colRazonSocialFronting2.VisibleIndex = 5;
            this.colRazonSocialFronting2.Width = 193;
            // 
            // colIdBeneficiario1
            // 
            this.colIdBeneficiario1.FieldName = "IdBeneficiario";
            this.colIdBeneficiario1.Name = "colIdBeneficiario1";
            // 
            // colRazonSocialBeneficiario1
            // 
            this.colRazonSocialBeneficiario1.Caption = "Beneficiario";
            this.colRazonSocialBeneficiario1.FieldName = "NombreComercialBeneficiario";
            this.colRazonSocialBeneficiario1.Name = "colRazonSocialBeneficiario1";
            this.colRazonSocialBeneficiario1.Visible = true;
            this.colRazonSocialBeneficiario1.VisibleIndex = 6;
            this.colRazonSocialBeneficiario1.Width = 188;
            // 
            // colIdTipoBeneficiario1
            // 
            this.colIdTipoBeneficiario1.FieldName = "IdTipoBeneficiario";
            this.colIdTipoBeneficiario1.Name = "colIdTipoBeneficiario1";
            // 
            // colDescTipoBeneficiario2
            // 
            this.colDescTipoBeneficiario2.Caption = "Tipo Beneficiario";
            this.colDescTipoBeneficiario2.FieldName = "DescTipoBeneficiario";
            this.colDescTipoBeneficiario2.Name = "colDescTipoBeneficiario2";
            this.colDescTipoBeneficiario2.Visible = true;
            this.colDescTipoBeneficiario2.VisibleIndex = 7;
            this.colDescTipoBeneficiario2.Width = 86;
            // 
            // colIdMetodoPago1
            // 
            this.colIdMetodoPago1.FieldName = "IdMetodoPago";
            this.colIdMetodoPago1.Name = "colIdMetodoPago1";
            // 
            // colClaveMetodoPago1
            // 
            this.colClaveMetodoPago1.Caption = "Método de Pago";
            this.colClaveMetodoPago1.FieldName = "ClaveMetodoPago";
            this.colClaveMetodoPago1.Name = "colClaveMetodoPago1";
            this.colClaveMetodoPago1.Visible = true;
            this.colClaveMetodoPago1.VisibleIndex = 8;
            this.colClaveMetodoPago1.Width = 84;
            // 
            // colDescMetodoPago1
            // 
            this.colDescMetodoPago1.FieldName = "DescMetodoPago";
            this.colDescMetodoPago1.Name = "colDescMetodoPago1";
            // 
            // colIdFormaPago1
            // 
            this.colIdFormaPago1.FieldName = "IdFormaPago";
            this.colIdFormaPago1.Name = "colIdFormaPago1";
            // 
            // colDescFormaPago1
            // 
            this.colDescFormaPago1.Caption = "Forma de Pago";
            this.colDescFormaPago1.FieldName = "DescFormaPago";
            this.colDescFormaPago1.Name = "colDescFormaPago1";
            this.colDescFormaPago1.Visible = true;
            this.colDescFormaPago1.VisibleIndex = 9;
            // 
            // colIdMoneda2
            // 
            this.colIdMoneda2.Caption = "Moneda";
            this.colIdMoneda2.FieldName = "IdMoneda";
            this.colIdMoneda2.Name = "colIdMoneda2";
            this.colIdMoneda2.Visible = true;
            this.colIdMoneda2.VisibleIndex = 10;
            // 
            // colTipoCambio2
            // 
            this.colTipoCambio2.Caption = "Tipo Cambio";
            this.colTipoCambio2.DisplayFormat.FormatString = "C2";
            this.colTipoCambio2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTipoCambio2.FieldName = "TipoCambio";
            this.colTipoCambio2.Name = "colTipoCambio2";
            this.colTipoCambio2.Visible = true;
            this.colTipoCambio2.VisibleIndex = 11;
            // 
            // colFechaPago1
            // 
            this.colFechaPago1.Caption = "Fecha Pago";
            this.colFechaPago1.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.colFechaPago1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFechaPago1.FieldName = "FechaPago";
            this.colFechaPago1.Name = "colFechaPago1";
            this.colFechaPago1.Visible = true;
            this.colFechaPago1.VisibleIndex = 12;
            // 
            // colSubTotal
            // 
            this.colSubTotal.Caption = "Sub-total";
            this.colSubTotal.DisplayFormat.FormatString = "C2";
            this.colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSubTotal.FieldName = "SubTotal";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.Visible = true;
            this.colSubTotal.VisibleIndex = 13;
            // 
            // colIVA3
            // 
            this.colIVA3.DisplayFormat.FormatString = "C2";
            this.colIVA3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIVA3.FieldName = "IVA";
            this.colIVA3.Name = "colIVA3";
            this.colIVA3.Visible = true;
            this.colIVA3.VisibleIndex = 14;
            // 
            // colTotal4
            // 
            this.colTotal4.DisplayFormat.FormatString = "C2";
            this.colTotal4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal4.FieldName = "Total";
            this.colTotal4.Name = "colTotal4";
            this.colTotal4.Visible = true;
            this.colTotal4.VisibleIndex = 15;
            // 
            // colImporteConLetra1
            // 
            this.colImporteConLetra1.FieldName = "ImporteConLetra";
            this.colImporteConLetra1.Name = "colImporteConLetra1";
            // 
            // colIdHeaderFacturaRelacion1
            // 
            this.colIdHeaderFacturaRelacion1.Caption = "Id Factura Relacional";
            this.colIdHeaderFacturaRelacion1.FieldName = "IdHeaderFacturaRelacion";
            this.colIdHeaderFacturaRelacion1.Name = "colIdHeaderFacturaRelacion1";
            this.colIdHeaderFacturaRelacion1.Visible = true;
            this.colIdHeaderFacturaRelacion1.VisibleIndex = 16;
            // 
            // colSerie
            // 
            this.colSerie.FieldName = "Serie";
            this.colSerie.Name = "colSerie";
            this.colSerie.Visible = true;
            this.colSerie.VisibleIndex = 17;
            // 
            // colFolioInterno
            // 
            this.colFolioInterno.Caption = "Folio Interno";
            this.colFolioInterno.FieldName = "FolioInterno";
            this.colFolioInterno.Name = "colFolioInterno";
            this.colFolioInterno.Visible = true;
            this.colFolioInterno.VisibleIndex = 18;
            // 
            // colFechaGeneracionCFDI
            // 
            this.colFechaGeneracionCFDI.Caption = "Fecha Timbrado";
            this.colFechaGeneracionCFDI.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.colFechaGeneracionCFDI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFechaGeneracionCFDI.FieldName = "FechaGeneracionCFDI";
            this.colFechaGeneracionCFDI.Name = "colFechaGeneracionCFDI";
            this.colFechaGeneracionCFDI.Visible = true;
            this.colFechaGeneracionCFDI.VisibleIndex = 22;
            // 
            // colUUID1
            // 
            this.colUUID1.Caption = "UUID";
            this.colUUID1.FieldName = "UUID";
            this.colUUID1.Name = "colUUID1";
            this.colUUID1.Visible = true;
            this.colUUID1.VisibleIndex = 19;
            // 
            // colEstatusDocumento
            // 
            this.colEstatusDocumento.Caption = "Estatus del Timbre";
            this.colEstatusDocumento.FieldName = "EstatusDocumento";
            this.colEstatusDocumento.Name = "colEstatusDocumento";
            this.colEstatusDocumento.Visible = true;
            this.colEstatusDocumento.VisibleIndex = 23;
            // 
            // colTotalDepositado1
            // 
            this.colTotalDepositado1.Caption = "Total Deposito";
            this.colTotalDepositado1.FieldName = "TotalDepositado";
            this.colTotalDepositado1.Name = "colTotalDepositado1";
            this.colTotalDepositado1.Visible = true;
            this.colTotalDepositado1.VisibleIndex = 21;
            this.colTotalDepositado1.Width = 83;
            // 
            // colIdTipoRelacion1
            // 
            this.colIdTipoRelacion1.FieldName = "IdTipoRelacion";
            this.colIdTipoRelacion1.Name = "colIdTipoRelacion1";
            // 
            // colDescTipoRelacion1
            // 
            this.colDescTipoRelacion1.Caption = "Tipo Relación";
            this.colDescTipoRelacion1.FieldName = "DescTipoRelacion";
            this.colDescTipoRelacion1.Name = "colDescTipoRelacion1";
            this.colDescTipoRelacion1.Visible = true;
            this.colDescTipoRelacion1.VisibleIndex = 20;
            // 
            // colIdEstatus2
            // 
            this.colIdEstatus2.FieldName = "IdEstatus";
            this.colIdEstatus2.Name = "colIdEstatus2";
            // 
            // colDescEstatus2
            // 
            this.colDescEstatus2.Caption = "Estatus";
            this.colDescEstatus2.FieldName = "DescEstatus";
            this.colDescEstatus2.Name = "colDescEstatus2";
            this.colDescEstatus2.Visible = true;
            this.colDescEstatus2.VisibleIndex = 24;
            // 
            // colComentarios1
            // 
            this.colComentarios1.FieldName = "Comentarios";
            this.colComentarios1.Name = "colComentarios1";
            this.colComentarios1.Visible = true;
            this.colComentarios1.VisibleIndex = 25;
            this.colComentarios1.Width = 155;
            // 
            // colIdOperador2
            // 
            this.colIdOperador2.FieldName = "IdOperador";
            this.colIdOperador2.Name = "colIdOperador2";
            // 
            // colNombreCompletoOperador3
            // 
            this.colNombreCompletoOperador3.Caption = "Operador";
            this.colNombreCompletoOperador3.FieldName = "NombreCompletoOperador";
            this.colNombreCompletoOperador3.Name = "colNombreCompletoOperador3";
            this.colNombreCompletoOperador3.Visible = true;
            this.colNombreCompletoOperador3.VisibleIndex = 26;
            this.colNombreCompletoOperador3.Width = 199;
            // 
            // stpFactSelFacturasARelacionarSATBindingSource
            // 
            this.stpFactSelFacturasARelacionarSATBindingSource.DataMember = "stpFactSelFacturasARelacionarSAT";
            this.stpFactSelFacturasARelacionarSATBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // txtIdSolicitud
            // 
            this.txtIdSolicitud.BackColor = System.Drawing.Color.LightYellow;
            this.txtIdSolicitud.Location = new System.Drawing.Point(369, 29);
            this.txtIdSolicitud.Name = "txtIdSolicitud";
            this.txtIdSolicitud.ReadOnly = true;
            this.txtIdSolicitud.Size = new System.Drawing.Size(120, 21);
            this.txtIdSolicitud.TabIndex = 207;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 206;
            this.label3.Text = "No. Solicitud";
            // 
            // stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1
            // 
            this.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1.ClearBeforeFill = true;
            // 
            // txtEstatus
            // 
            this.txtEstatus.BackColor = System.Drawing.Color.LightYellow;
            this.txtEstatus.Location = new System.Drawing.Point(590, 172);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.ReadOnly = true;
            this.txtEstatus.Size = new System.Drawing.Size(181, 21);
            this.txtEstatus.TabIndex = 212;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(545, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 211;
            this.label10.Text = "Estatus:";
            // 
            // stpFactSelFacturasARelacionarSATTableAdapter
            // 
            this.stpFactSelFacturasARelacionarSATTableAdapter.ClearBeforeFill = true;
            // 
            // stpFactSelFacturasARelacionarTableAdapter
            // 
            this.stpFactSelFacturasARelacionarTableAdapter.ClearBeforeFill = true;
            // 
            // stpFactSelComprobantesFacturaTableAdapter1
            // 
            this.stpFactSelComprobantesFacturaTableAdapter1.ClearBeforeFill = true;
            // 
            // txtSerie
            // 
            this.txtSerie.BackColor = System.Drawing.Color.LightYellow;
            this.txtSerie.Location = new System.Drawing.Point(590, 28);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.ReadOnly = true;
            this.txtSerie.Size = new System.Drawing.Size(181, 21);
            this.txtSerie.TabIndex = 214;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(531, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 213;
            this.label11.Text = "Serie/Folio:";
            // 
            // txtOperador
            // 
            this.txtOperador.BackColor = System.Drawing.Color.LightYellow;
            this.txtOperador.Location = new System.Drawing.Point(143, 198);
            this.txtOperador.Name = "txtOperador";
            this.txtOperador.ReadOnly = true;
            this.txtOperador.Size = new System.Drawing.Size(361, 21);
            this.txtOperador.TabIndex = 216;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(89, 201);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 215;
            this.label16.Text = "Operador:\r\n";
            // 
            // frmAdmonFacturasFCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 498);
            this.ControlBox = false;
            this.Controls.Add(this.txtOperador);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtIdSolicitud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.chkContabilizado);
            this.Controls.Add(this.txtMesAno);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBancoDestino);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtBancoOrigen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTipoCambio);
            this.Controls.Add(this.txtMoneda);
            this.Controls.Add(this.txtTotalDeposito);
            this.Controls.Add(this.txtMetodoPago);
            this.Controls.Add(this.txtFechaPago);
            this.Controls.Add(this.txtBeneficiario);
            this.Controls.Add(this.txtFormaPago);
            this.Controls.Add(this.txtTipoBeneficiarios);
            this.Controls.Add(this.txtFronting);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnComprobante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblTenedora);
            this.Controls.Add(this.grConceptos);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cbFacturas);
            this.Name = "frmAdmonFacturasFCV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de Facturas / Control / Saldos";
            this.Load += new System.EventHandler(this.frmAdmonFacturas_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grConceptos)).EndInit();
            this.grConceptos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvConceptos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelDetailFacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelFacturasARelacionarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelHeaderFacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFacturas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelFacturasARelacionarSATBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnDescargar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblTenedora;
        private DevExpress.XtraEditors.GroupControl grConceptos;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnComprobante;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFronting;
        private System.Windows.Forms.TextBox txtTipoBeneficiarios;
        private System.Windows.Forms.TextBox txtFormaPago;
        private System.Windows.Forms.TextBox txtBeneficiario;
        private System.Windows.Forms.TextBox txtFechaPago;
        private System.Windows.Forms.TextBox txtMetodoPago;
        private System.Windows.Forms.TextBox txtTotalDeposito;
        private System.Windows.Forms.TextBox txtMoneda;
        private System.Windows.Forms.TextBox txtTipoCambio;
        private System.Windows.Forms.TextBox txtBancoOrigen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBancoDestino;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMesAno;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkContabilizado;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashSMCargando;
        private dbSAICBPOFactura dbSAICBPOFactura;
        private System.Windows.Forms.BindingSource stpFactSelHeaderFacturasBindingSource;
        private dbSAICBPOFacturaTableAdapters.stpFactSelHeaderFacturasTableAdapter stpFactSelHeaderFacturasTableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit cbFacturas;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvFacturas;
        private DevExpress.XtraGrid.Columns.GridColumn colIdHeaderFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocialFronting;
        private DevExpress.XtraGrid.Columns.GridColumn colDescTipoBeneficiario;
        private DevExpress.XtraGrid.Columns.GridColumn RazonSocialBeneficiario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdControlOperacion;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colDescEstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCompletoOperador;
        private System.Windows.Forms.BindingSource stpFactSelDetailFacturasBindingSource;
        private dbSAICBPOFacturaTableAdapters.stpFactSelDetailFacturasTableAdapter stpFactSelDetailFacturasTableAdapter;
        private winAppSAIC.Catalogos.dbSAICBPO_CatalogosValidacionDataSetTableAdapters.ValidacionesGeneralTableAdapter validacionesGeneralTableAdapter1;
        private NominaCFDI.dbSAICBPONominaCFDIDataSetTableAdapters.SeguridadTableAdapter seguridadTableAdapter1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashSMProcesando;
        private dbSAICBPOFacturaTableAdapters.spSoloRespuesta spSoloRespuesta1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private System.Windows.Forms.TextBox txtIdSolicitud;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSolicitudFactura0;
        private dbSAICBPOFacturaTableAdapters.stpFactSelDerechosAccesoOperadorFacturacionTableAdapter stpFactSelDerechosAccesoOperadorFacturacionTableAdapter1;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource stpFactSelFacturasARelacionarBindingSource;
        private System.Windows.Forms.BindingSource stpFactSelFacturasARelacionarSATBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdHeaderFactura3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSolicitudFactura1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdControlOperacion2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFacturador1;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocialFronting2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBeneficiario1;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocialBeneficiario1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoBeneficiario1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescTipoBeneficiario2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMetodoPago1;
        private DevExpress.XtraGrid.Columns.GridColumn colClaveMetodoPago1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescMetodoPago1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFormaPago1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescFormaPago1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMoneda2;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoCambio2;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaPago1;
        private DevExpress.XtraGrid.Columns.GridColumn colSubTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colIVA3;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal4;
        private DevExpress.XtraGrid.Columns.GridColumn colImporteConLetra1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdHeaderFacturaRelacion1;
        private DevExpress.XtraGrid.Columns.GridColumn colSerie;
        private DevExpress.XtraGrid.Columns.GridColumn colFolioInterno;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaGeneracionCFDI;
        private DevExpress.XtraGrid.Columns.GridColumn colUUID1;
        private DevExpress.XtraGrid.Columns.GridColumn colEstatusDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalDepositado1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoRelacion1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescTipoRelacion1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstatus2;
        private DevExpress.XtraGrid.Columns.GridColumn colDescEstatus2;
        private DevExpress.XtraGrid.Columns.GridColumn colComentarios1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOperador2;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCompletoOperador3;
        private dbSAICBPOFacturaTableAdapters.stpFactSelFacturasARelacionarSATTableAdapter stpFactSelFacturasARelacionarSATTableAdapter;
        private dbSAICBPOFacturaTableAdapters.stpFactSelFacturasARelacionarTableAdapter stpFactSelFacturasARelacionarTableAdapter;
        private dbSAICBPOFacturaTableAdapters.stpFactSelComprobantesFacturaTableAdapter stpFactSelComprobantesFacturaTableAdapter1;
        private DevExpress.XtraGrid.Columns.GridColumn colSeriea;
        private DevExpress.XtraGrid.Columns.GridColumn colFolio;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstatus0;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.GridControl gvConceptos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdDetailFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colIdHeaderFactura2;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUnidad;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn43;
        private DevExpress.XtraGrid.Columns.GridColumn colComplemento;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioUnitario;
        private DevExpress.XtraGrid.Columns.GridColumn colIVA;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal3;
        private DevExpress.XtraGrid.Columns.GridColumn colISN;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private System.Windows.Forms.TextBox txtOperador;
        private System.Windows.Forms.Label label16;
        private DevExpress.XtraGrid.Columns.GridColumn colProdSAT;   
    }
}