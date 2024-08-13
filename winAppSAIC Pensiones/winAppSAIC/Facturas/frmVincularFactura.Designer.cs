namespace winAppSAIC.Facturas
{
    partial class frmVincularFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVincularFactura));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.dgvFacturasRelaciones = new DevExpress.XtraGrid.GridControl();
            this.stpFactSelFacturasARelacionarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOFactura = new winAppSAIC.Facturas.dbSAICBPOFactura();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdHeaderFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSolicitudFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdControlOperacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFolio = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.spSoloRespuesta1 = new winAppSAIC.Facturas.dbSAICBPOFacturaTableAdapters.spSoloRespuesta();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturasRelaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelFacturasARelacionarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
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
            this.toolStrip1.TabIndex = 6;
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
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 22);
            this.btnCancelar.Text = "Vincular Facturas(s)";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvFacturasRelaciones
            // 
            this.dgvFacturasRelaciones.DataSource = this.stpFactSelFacturasARelacionarBindingSource;
            this.dgvFacturasRelaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFacturasRelaciones.Location = new System.Drawing.Point(0, 25);
            this.dgvFacturasRelaciones.MainView = this.gridView3;
            this.dgvFacturasRelaciones.Name = "dgvFacturasRelaciones";
            this.dgvFacturasRelaciones.Size = new System.Drawing.Size(1016, 349);
            this.dgvFacturasRelaciones.TabIndex = 7;
            this.dgvFacturasRelaciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
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
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdHeaderFactura,
            this.colIdSolicitudFactura,
            this.colIdControlOperacion,
            this.colSerie,
            this.colFolio,
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
            this.gridView3.GridControl = this.dgvFacturasRelaciones;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsSelection.MultiSelect = true;
            this.gridView3.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView3.OptionsView.ColumnAutoWidth = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colIdHeaderFactura
            // 
            this.colIdHeaderFactura.Caption = "Id Facura";
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
            this.colIdControlOperacion.Caption = "Id Control de Operaciones";
            this.colIdControlOperacion.FieldName = "IdControlOperacion";
            this.colIdControlOperacion.Name = "colIdControlOperacion";
            this.colIdControlOperacion.Visible = true;
            this.colIdControlOperacion.VisibleIndex = 3;
            // 
            // colSerie
            // 
            this.colSerie.Caption = "Serie";
            this.colSerie.FieldName = "Serie";
            this.colSerie.Name = "colSerie";
            this.colSerie.Visible = true;
            this.colSerie.VisibleIndex = 4;
            // 
            // colFolio
            // 
            this.colFolio.Caption = "Folio Interno";
            this.colFolio.FieldName = "FolioInterno";
            this.colFolio.Name = "colFolio";
            this.colFolio.Visible = true;
            this.colFolio.VisibleIndex = 5;
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
            this.colRazonSocialFronting.VisibleIndex = 6;
            this.colRazonSocialFronting.Width = 299;
            // 
            // colIdBeneficiario
            // 
            this.colIdBeneficiario.FieldName = "IdBeneficiario";
            this.colIdBeneficiario.Name = "colIdBeneficiario";
            // 
            // colRazonSocialBeneficiario
            // 
            this.colRazonSocialBeneficiario.Caption = "Beneficiario";
            this.colRazonSocialBeneficiario.FieldName = "NombreComercialBeneficiario";
            this.colRazonSocialBeneficiario.Name = "colRazonSocialBeneficiario";
            this.colRazonSocialBeneficiario.Visible = true;
            this.colRazonSocialBeneficiario.VisibleIndex = 7;
            this.colRazonSocialBeneficiario.Width = 319;
            // 
            // colIdTipoBeneficiario
            // 
            this.colIdTipoBeneficiario.FieldName = "IdTipoBeneficiario";
            this.colIdTipoBeneficiario.Name = "colIdTipoBeneficiario";
            // 
            // colDescTipoBeneficiario
            // 
            this.colDescTipoBeneficiario.Caption = "Tipo Beneficiario";
            this.colDescTipoBeneficiario.FieldName = "DescTipoBeneficiario";
            this.colDescTipoBeneficiario.Name = "colDescTipoBeneficiario";
            this.colDescTipoBeneficiario.Visible = true;
            this.colDescTipoBeneficiario.VisibleIndex = 8;
            this.colDescTipoBeneficiario.Width = 98;
            // 
            // colIdMetodoPago
            // 
            this.colIdMetodoPago.FieldName = "IdMetodoPago";
            this.colIdMetodoPago.Name = "colIdMetodoPago";
            // 
            // colClaveMetodoPago
            // 
            this.colClaveMetodoPago.Caption = "Método de Pago";
            this.colClaveMetodoPago.FieldName = "ClaveMetodoPago";
            this.colClaveMetodoPago.Name = "colClaveMetodoPago";
            this.colClaveMetodoPago.Visible = true;
            this.colClaveMetodoPago.VisibleIndex = 9;
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
            this.colDescFormaPago.Caption = "Forma de Pago";
            this.colDescFormaPago.FieldName = "DescFormaPago";
            this.colDescFormaPago.Name = "colDescFormaPago";
            this.colDescFormaPago.Visible = true;
            this.colDescFormaPago.VisibleIndex = 10;
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
            this.colTipoCambio.Width = 88;
            // 
            // colFechaPago
            // 
            this.colFechaPago.Caption = "Fecha de Pago";
            this.colFechaPago.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.colFechaPago.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFechaPago.FieldName = "FechaPago";
            this.colFechaPago.Name = "colFechaPago";
            this.colFechaPago.Visible = true;
            this.colFechaPago.VisibleIndex = 13;
            this.colFechaPago.Width = 106;
            // 
            // colSubTotal
            // 
            this.colSubTotal.Caption = "Sub-total";
            this.colSubTotal.DisplayFormat.FormatString = "C2";
            this.colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSubTotal.FieldName = "SubTotal";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.Visible = true;
            this.colSubTotal.VisibleIndex = 14;
            // 
            // colIVA
            // 
            this.colIVA.DisplayFormat.FormatString = "C2";
            this.colIVA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIVA.FieldName = "IVA";
            this.colIVA.Name = "colIVA";
            this.colIVA.Visible = true;
            this.colIVA.VisibleIndex = 15;
            // 
            // colTotal
            // 
            this.colTotal.DisplayFormat.FormatString = "C2";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 16;
            // 
            // colImporteConLetra
            // 
            this.colImporteConLetra.FieldName = "ImporteConLetra";
            this.colImporteConLetra.Name = "colImporteConLetra";
            // 
            // colIdHeaderFacturaRelacion
            // 
            this.colIdHeaderFacturaRelacion.Caption = "Id Factura Relacionada";
            this.colIdHeaderFacturaRelacion.FieldName = "IdHeaderFacturaRelacion";
            this.colIdHeaderFacturaRelacion.Name = "colIdHeaderFacturaRelacion";
            this.colIdHeaderFacturaRelacion.Visible = true;
            this.colIdHeaderFacturaRelacion.VisibleIndex = 17;
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
            this.colDescTipoRelacion.VisibleIndex = 18;
            this.colDescTipoRelacion.Width = 219;
            // 
            // colTotalDepositado
            // 
            this.colTotalDepositado.Caption = "Total Depositado";
            this.colTotalDepositado.DisplayFormat.FormatString = "C2";
            this.colTotalDepositado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalDepositado.FieldName = "TotalDepositado";
            this.colTotalDepositado.Name = "colTotalDepositado";
            this.colTotalDepositado.Visible = true;
            this.colTotalDepositado.VisibleIndex = 19;
            this.colTotalDepositado.Width = 110;
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
            this.colDescEstatus.Visible = true;
            this.colDescEstatus.VisibleIndex = 20;
            this.colDescEstatus.Width = 128;
            // 
            // colComentarios
            // 
            this.colComentarios.Caption = "Comentarios";
            this.colComentarios.FieldName = "Comentarios";
            this.colComentarios.Name = "colComentarios";
            this.colComentarios.Visible = true;
            this.colComentarios.VisibleIndex = 21;
            this.colComentarios.Width = 264;
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
            this.colNombreCompletoOperador.VisibleIndex = 22;
            this.colNombreCompletoOperador.Width = 218;
            // 
            // stpFactSelFacturasARelacionarTableAdapter
            // 
            this.stpFactSelFacturasARelacionarTableAdapter.ClearBeforeFill = true;
            // 
            // frmVincularFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 374);
            this.ControlBox = false;
            this.Controls.Add(this.dgvFacturasRelaciones);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmVincularFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vicular Factura(s)";
            this.Load += new System.EventHandler(this.frmVincularFactura_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturasRelaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpFactSelFacturasARelacionarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private DevExpress.XtraGrid.GridControl dgvFacturasRelaciones;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.BindingSource stpFactSelFacturasARelacionarBindingSource;
        private dbSAICBPOFactura dbSAICBPOFactura;
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
        private dbSAICBPOFacturaTableAdapters.stpFactSelFacturasARelacionarTableAdapter stpFactSelFacturasARelacionarTableAdapter;
        private dbSAICBPOFacturaTableAdapters.spSoloRespuesta spSoloRespuesta1;
        private DevExpress.XtraGrid.Columns.GridColumn colSerie;
        private DevExpress.XtraGrid.Columns.GridColumn colFolio;
    }
}