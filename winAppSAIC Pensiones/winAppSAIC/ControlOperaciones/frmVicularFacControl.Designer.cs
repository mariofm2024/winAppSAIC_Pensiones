namespace winAppSAIC.ControlOperaciones
{
    partial class frmVicularFacControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVicularFacControl));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.stpFactSelFacturasARelacionarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOFactura = new winAppSAIC.Facturas.dbSAICBPOFactura();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdHeaderFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSolicitudFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdControlOperacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFacturador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocialFronting = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBeneficiario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocialBeneficiario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoBeneficiario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescTipoBeneficiario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMetodoPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClaveMetodoPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescMetodoPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescFormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoCambio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImporteConLetra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdHeaderFacturaRelacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoRelacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescTipoRelacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalDepositado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComentarios = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCompletoOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stpFactSelFacturasARelacionarTableAdapter = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelFacturasARelacionarTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.spSoloRespuesta1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.spSoloRespuesta();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelFacturasARelacionarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(799, 25);
            this.toolStrip1.TabIndex = 2;
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
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::winAppSAIC.Properties.Resources.businesspackage_additionalpackage_box_add_insert_negoci_2335;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(112, 22);
            this.toolStripButton2.Text = "Vincular Factura";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 25);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(799, 280);
            this.groupControl1.TabIndex = 47;
            this.groupControl1.Text = "Factura(s)  a Seleccionar";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.stpFactSelFacturasARelacionarBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(795, 258);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // stpFactSelFacturasARelacionarBindingSource
            // 
            this.stpFactSelFacturasARelacionarBindingSource.DataMember = "stpFactSelFacturasARelacionar";
            this.stpFactSelFacturasARelacionarBindingSource.DataSource = this.dbSAICBPOFactura;
            // 
            // dbSAICBPOFactura
            // 
            this.dbSAICBPOFactura.DataSetName = "dbSAICBPOFactura";
            this.dbSAICBPOFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdHeaderFactura,
            this.colIdSolicitudFactura,
            this.colIdControlOperacion,
            this.colIdFacturador,
            this.colRazonSocialFronting,
            this.colIdBeneficiario,
            this.colRazonSocialBeneficiario,
            this.colIdTipoBeneficiario,
            this.colDescTipoBeneficiario,
            this.colIdMetodoPago,
            this.colClaveMetodoPago,
            this.colDescMetodoPago,
            this.colIdFormaPago,
            this.colDescFormaPago,
            this.colIdMoneda,
            this.colTipoCambio,
            this.colFechaPago,
            this.colSubTotal,
            this.colIVA,
            this.colTotal,
            this.colImporteConLetra,
            this.colIdHeaderFacturaRelacion,
            this.colIdTipoRelacion,
            this.colDescTipoRelacion,
            this.colTotalDepositado,
            this.colIdEstatus,
            this.colDescEstatus,
            this.colComentarios,
            this.colIdOperador,
            this.colNombreCompletoOperador});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDescTipoRelacion, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colIdHeaderFactura
            // 
            this.colIdHeaderFactura.Caption = "Id Factura";
            this.colIdHeaderFactura.FieldName = "IdHeaderFactura";
            this.colIdHeaderFactura.Name = "colIdHeaderFactura";
            this.colIdHeaderFactura.Visible = true;
            this.colIdHeaderFactura.VisibleIndex = 1;
            // 
            // colIdSolicitudFactura
            // 
            this.colIdSolicitudFactura.Caption = "Id Solicitud";
            this.colIdSolicitudFactura.FieldName = "IdSolicitudFactura";
            this.colIdSolicitudFactura.Name = "colIdSolicitudFactura";
            this.colIdSolicitudFactura.Visible = true;
            this.colIdSolicitudFactura.VisibleIndex = 2;
            // 
            // colIdControlOperacion
            // 
            this.colIdControlOperacion.FieldName = "IdControlOperacion";
            this.colIdControlOperacion.Name = "colIdControlOperacion";
            // 
            // colIdFacturador
            // 
            this.colIdFacturador.FieldName = "IdFacturador";
            this.colIdFacturador.Name = "colIdFacturador";
            // 
            // colRazonSocialFronting
            // 
            this.colRazonSocialFronting.Caption = "Fronting";
            this.colRazonSocialFronting.FieldName = "NombreComercialFronting";
            this.colRazonSocialFronting.Name = "colRazonSocialFronting";
            this.colRazonSocialFronting.Visible = true;
            this.colRazonSocialFronting.VisibleIndex = 3;
            this.colRazonSocialFronting.Width = 206;
            // 
            // colIdBeneficiario
            // 
            this.colIdBeneficiario.FieldName = "IdBeneficiario";
            this.colIdBeneficiario.Name = "colIdBeneficiario";
            // 
            // colRazonSocialBeneficiario
            // 
            this.colRazonSocialBeneficiario.FieldName = "RazonSocialBeneficiario";
            this.colRazonSocialBeneficiario.Name = "colRazonSocialBeneficiario";
            // 
            // colIdTipoBeneficiario
            // 
            this.colIdTipoBeneficiario.FieldName = "IdTipoBeneficiario";
            this.colIdTipoBeneficiario.Name = "colIdTipoBeneficiario";
            // 
            // colDescTipoBeneficiario
            // 
            this.colDescTipoBeneficiario.FieldName = "DescTipoBeneficiario";
            this.colDescTipoBeneficiario.Name = "colDescTipoBeneficiario";
            // 
            // colIdMetodoPago
            // 
            this.colIdMetodoPago.FieldName = "IdMetodoPago";
            this.colIdMetodoPago.Name = "colIdMetodoPago";
            // 
            // colClaveMetodoPago
            // 
            this.colClaveMetodoPago.Caption = "Metodo de Pago";
            this.colClaveMetodoPago.FieldName = "ClaveMetodoPago";
            this.colClaveMetodoPago.Name = "colClaveMetodoPago";
            this.colClaveMetodoPago.Visible = true;
            this.colClaveMetodoPago.VisibleIndex = 9;
            this.colClaveMetodoPago.Width = 90;
            // 
            // colDescMetodoPago
            // 
            this.colDescMetodoPago.FieldName = "DescMetodoPago";
            this.colDescMetodoPago.Name = "colDescMetodoPago";
            // 
            // colIdFormaPago
            // 
            this.colIdFormaPago.FieldName = "IdFormaPago";
            this.colIdFormaPago.Name = "colIdFormaPago";
            // 
            // colDescFormaPago
            // 
            this.colDescFormaPago.Caption = "Forma Pago";
            this.colDescFormaPago.FieldName = "DescFormaPago";
            this.colDescFormaPago.Name = "colDescFormaPago";
            this.colDescFormaPago.Visible = true;
            this.colDescFormaPago.VisibleIndex = 10;
            this.colDescFormaPago.Width = 92;
            // 
            // colIdMoneda
            // 
            this.colIdMoneda.Caption = "Moneda";
            this.colIdMoneda.FieldName = "IdMoneda";
            this.colIdMoneda.Name = "colIdMoneda";
            this.colIdMoneda.Visible = true;
            this.colIdMoneda.VisibleIndex = 11;
            // 
            // colTipoCambio
            // 
            this.colTipoCambio.Caption = "Tipo de Cambio";
            this.colTipoCambio.DisplayFormat.FormatString = "C2";
            this.colTipoCambio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTipoCambio.FieldName = "TipoCambio";
            this.colTipoCambio.Name = "colTipoCambio";
            this.colTipoCambio.Visible = true;
            this.colTipoCambio.VisibleIndex = 12;
            this.colTipoCambio.Width = 87;
            // 
            // colFechaPago
            // 
            this.colFechaPago.FieldName = "FechaPago";
            this.colFechaPago.Name = "colFechaPago";
            this.colFechaPago.Visible = true;
            this.colFechaPago.VisibleIndex = 8;
            this.colFechaPago.Width = 126;
            // 
            // colSubTotal
            // 
            this.colSubTotal.Caption = "Sub-total";
            this.colSubTotal.DisplayFormat.FormatString = "C2";
            this.colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSubTotal.FieldName = "SubTotal";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.Visible = true;
            this.colSubTotal.VisibleIndex = 4;
            this.colSubTotal.Width = 74;
            // 
            // colIVA
            // 
            this.colIVA.DisplayFormat.FormatString = "C2";
            this.colIVA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIVA.FieldName = "IVA";
            this.colIVA.Name = "colIVA";
            this.colIVA.Visible = true;
            this.colIVA.VisibleIndex = 5;
            this.colIVA.Width = 91;
            // 
            // colTotal
            // 
            this.colTotal.DisplayFormat.FormatString = "C2";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 6;
            this.colTotal.Width = 95;
            // 
            // colImporteConLetra
            // 
            this.colImporteConLetra.FieldName = "ImporteConLetra";
            this.colImporteConLetra.Name = "colImporteConLetra";
            // 
            // colIdHeaderFacturaRelacion
            // 
            this.colIdHeaderFacturaRelacion.FieldName = "IdHeaderFacturaRelacion";
            this.colIdHeaderFacturaRelacion.Name = "colIdHeaderFacturaRelacion";
            // 
            // colIdTipoRelacion
            // 
            this.colIdTipoRelacion.FieldName = "IdTipoRelacion";
            this.colIdTipoRelacion.Name = "colIdTipoRelacion";
            // 
            // colDescTipoRelacion
            // 
            this.colDescTipoRelacion.Caption = "Tipo Relación";
            this.colDescTipoRelacion.FieldName = "DescTipoRelacion";
            this.colDescTipoRelacion.Name = "colDescTipoRelacion";
            this.colDescTipoRelacion.Visible = true;
            this.colDescTipoRelacion.VisibleIndex = 13;
            this.colDescTipoRelacion.Width = 93;
            // 
            // colTotalDepositado
            // 
            this.colTotalDepositado.Caption = "Total depositado";
            this.colTotalDepositado.DisplayFormat.FormatString = "C2";
            this.colTotalDepositado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalDepositado.FieldName = "TotalDepositado";
            this.colTotalDepositado.Name = "colTotalDepositado";
            this.colTotalDepositado.Visible = true;
            this.colTotalDepositado.VisibleIndex = 7;
            this.colTotalDepositado.Width = 119;
            // 
            // colIdEstatus
            // 
            this.colIdEstatus.FieldName = "IdEstatus";
            this.colIdEstatus.Name = "colIdEstatus";
            // 
            // colDescEstatus
            // 
            this.colDescEstatus.Caption = "Estatus";
            this.colDescEstatus.FieldName = "DescEstatus";
            this.colDescEstatus.Name = "colDescEstatus";
            this.colDescEstatus.Width = 88;
            // 
            // colComentarios
            // 
            this.colComentarios.Caption = "Comentarios";
            this.colComentarios.FieldName = "Comentarios";
            this.colComentarios.Name = "colComentarios";
            this.colComentarios.Visible = true;
            this.colComentarios.VisibleIndex = 14;
            this.colComentarios.Width = 114;
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
            this.colNombreCompletoOperador.VisibleIndex = 15;
            this.colNombreCompletoOperador.Width = 242;
            // 
            // stpFactSelFacturasARelacionarTableAdapter
            // 
            this.stpFactSelFacturasARelacionarTableAdapter.ClearBeforeFill = true;
            // 
            // frmVicularFacControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(799, 305);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmVicularFacControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vicular Facturas a un Control";
            this.Load += new System.EventHandler(this.frmVicularFacControl_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelFacturasARelacionarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdHeaderFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSolicitudFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colIdControlOperacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFacturador;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocialFronting;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBeneficiario;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocialBeneficiario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoBeneficiario;
        private DevExpress.XtraGrid.Columns.GridColumn colDescTipoBeneficiario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMetodoPago;
        private DevExpress.XtraGrid.Columns.GridColumn colClaveMetodoPago;
        private DevExpress.XtraGrid.Columns.GridColumn colDescMetodoPago;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFormaPago;
        private DevExpress.XtraGrid.Columns.GridColumn colDescFormaPago;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMoneda;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoCambio;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaPago;
        private DevExpress.XtraGrid.Columns.GridColumn colSubTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colIVA;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colImporteConLetra;
        private DevExpress.XtraGrid.Columns.GridColumn colIdHeaderFacturaRelacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoRelacion;
        private DevExpress.XtraGrid.Columns.GridColumn colDescTipoRelacion;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalDepositado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colDescEstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colComentarios;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOperador;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCompletoOperador;
        private System.Windows.Forms.BindingSource stpFactSelFacturasARelacionarBindingSource;
        private Facturas.dbSAICBPOFactura dbSAICBPOFactura;
        private Facturas.dbSAICBPOFacturaTableAdapters.stpFactSelFacturasARelacionarTableAdapter stpFactSelFacturasARelacionarTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Facturas.dbSAICBPOFacturaTableAdapters.spSoloRespuesta spSoloRespuesta1;
    }
}