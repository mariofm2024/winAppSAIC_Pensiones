namespace winAppSAIC.IMSS
{
    partial class frmActualizarMontosRecup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActualizarMontosRecup));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnFacturar = new System.Windows.Forms.ToolStripButton();
            this.btnDescargar = new System.Windows.Forms.ToolStripButton();
            this.txtLiga = new System.Windows.Forms.ToolStripTextBox();
            this.btnCargarArchivo = new System.Windows.Forms.ToolStripButton();
            this.btnCargarRecupe = new System.Windows.Forms.ToolStripButton();
            this.gvdInfonavit = new DevExpress.XtraGrid.GridControl();
            this.stpSelObtenerCreditosIMSSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSAICBPOActualizacionesIMSSDataSet = new winAppSAIC.IMSS.dbSAICBPOActualizacionesIMSSDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreEmpleadoCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNSS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRFC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCURP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoCredito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMontoRecuperar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stpSelObtenerCreditosIMSSTableAdapter = new winAppSAIC.IMSS.dbSAICBPOActualizacionesIMSSDataSetTableAdapters.stpSelObtenerCreditosIMSSTableAdapter();
            this.actualizacionesIMSSTableAdapter1 = new winAppSAIC.IMSS.dbSAICBPOActualizacionesIMSSDataSetTableAdapters.ActualizacionesIMSSTableAdapter();
            this.sfdRutaArchivo = new System.Windows.Forms.SaveFileDialog();
            this.ObtenerArchivo = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvdInfonavit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelObtenerCreditosIMSSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOActualizacionesIMSSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btnFacturar,
            this.btnDescargar,
            this.txtLiga,
            this.btnCargarArchivo,
            this.btnCargarRecupe});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(887, 25);
            this.toolStrip1.TabIndex = 3;
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
            // btnFacturar
            // 
            this.btnFacturar.Image = global::winAppSAIC.Properties.Resources.EliminarNomina32x32;
            this.btnFacturar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(145, 22);
            this.btnFacturar.Text = "Eliminar Recuperación";
            this.btnFacturar.ToolTipText = "Nuevo Control";
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnDescargar
            // 
            this.btnDescargar.Image = global::winAppSAIC.Properties.Resources.xls32x32;
            this.btnDescargar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(118, 22);
            this.btnDescargar.Text = "Descargar Layout";
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // txtLiga
            // 
            this.txtLiga.Name = "txtLiga";
            this.txtLiga.ReadOnly = true;
            this.txtLiga.Size = new System.Drawing.Size(100, 25);
            // 
            // btnCargarArchivo
            // 
            this.btnCargarArchivo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCargarArchivo.Image = global::winAppSAIC.Properties.Resources.ImprimirPreview;
            this.btnCargarArchivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCargarArchivo.Name = "btnCargarArchivo";
            this.btnCargarArchivo.Size = new System.Drawing.Size(23, 22);
            this.btnCargarArchivo.Text = "toolStripButton3";
            this.btnCargarArchivo.Click += new System.EventHandler(this.btnCargarArchivo_Click);
            // 
            // btnCargarRecupe
            // 
            this.btnCargarRecupe.Image = global::winAppSAIC.Properties.Resources.Button_Refresh_icon24x24;
            this.btnCargarRecupe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCargarRecupe.Name = "btnCargarRecupe";
            this.btnCargarRecupe.Size = new System.Drawing.Size(165, 22);
            this.btnCargarRecupe.Text = "Actualizar Recuperaciones";
            this.btnCargarRecupe.Click += new System.EventHandler(this.btnCargarRecupe_Click);
            // 
            // gvdInfonavit
            // 
            this.gvdInfonavit.DataSource = this.stpSelObtenerCreditosIMSSBindingSource;
            this.gvdInfonavit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvdInfonavit.Location = new System.Drawing.Point(0, 25);
            this.gvdInfonavit.MainView = this.gridView1;
            this.gvdInfonavit.Name = "gvdInfonavit";
            this.gvdInfonavit.Size = new System.Drawing.Size(887, 284);
            this.gvdInfonavit.TabIndex = 4;
            this.gvdInfonavit.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // stpSelObtenerCreditosIMSSBindingSource
            // 
            this.stpSelObtenerCreditosIMSSBindingSource.DataMember = "stpSelObtenerCreditosIMSS";
            this.stpSelObtenerCreditosIMSSBindingSource.DataSource = this.dbSAICBPOActualizacionesIMSSDataSet;
            // 
            // dbSAICBPOActualizacionesIMSSDataSet
            // 
            this.dbSAICBPOActualizacionesIMSSDataSet.DataSetName = "dbSAICBPOActualizacionesIMSSDataSet";
            this.dbSAICBPOActualizacionesIMSSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpleado,
            this.colNombreEmpleadoCompleto,
            this.colNSS,
            this.colRFC,
            this.colCURP,
            this.colNoCredito,
            this.colMontoRecuperar});
            this.gridView1.GridControl = this.gvdInfonavit;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdEmpleado
            // 
            this.colIdEmpleado.FieldName = "IdEmpleado";
            this.colIdEmpleado.Name = "colIdEmpleado";
            this.colIdEmpleado.Visible = true;
            this.colIdEmpleado.VisibleIndex = 0;
            this.colIdEmpleado.Width = 87;
            // 
            // colNombreEmpleadoCompleto
            // 
            this.colNombreEmpleadoCompleto.FieldName = "NombreEmpleadoCompleto";
            this.colNombreEmpleadoCompleto.Name = "colNombreEmpleadoCompleto";
            this.colNombreEmpleadoCompleto.Visible = true;
            this.colNombreEmpleadoCompleto.VisibleIndex = 1;
            this.colNombreEmpleadoCompleto.Width = 243;
            // 
            // colNSS
            // 
            this.colNSS.FieldName = "NSS";
            this.colNSS.Name = "colNSS";
            this.colNSS.Visible = true;
            this.colNSS.VisibleIndex = 2;
            this.colNSS.Width = 116;
            // 
            // colRFC
            // 
            this.colRFC.FieldName = "RFC";
            this.colRFC.Name = "colRFC";
            this.colRFC.Visible = true;
            this.colRFC.VisibleIndex = 3;
            this.colRFC.Width = 110;
            // 
            // colCURP
            // 
            this.colCURP.FieldName = "CURP";
            this.colCURP.Name = "colCURP";
            this.colCURP.Visible = true;
            this.colCURP.VisibleIndex = 4;
            this.colCURP.Width = 112;
            // 
            // colNoCredito
            // 
            this.colNoCredito.FieldName = "NoCredito";
            this.colNoCredito.Name = "colNoCredito";
            this.colNoCredito.Visible = true;
            this.colNoCredito.VisibleIndex = 5;
            this.colNoCredito.Width = 100;
            // 
            // colMontoRecuperar
            // 
            this.colMontoRecuperar.DisplayFormat.FormatString = "C2";
            this.colMontoRecuperar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMontoRecuperar.FieldName = "MontoRecuperar";
            this.colMontoRecuperar.Name = "colMontoRecuperar";
            this.colMontoRecuperar.Visible = true;
            this.colMontoRecuperar.VisibleIndex = 6;
            this.colMontoRecuperar.Width = 100;
            // 
            // stpSelObtenerCreditosIMSSTableAdapter
            // 
            this.stpSelObtenerCreditosIMSSTableAdapter.ClearBeforeFill = true;
            // 
            // sfdRutaArchivo
            // 
            this.sfdRutaArchivo.Filter = "Archivos de Excel | *.xls";
            this.sfdRutaArchivo.Title = "Guardar como...";
            // 
            // ObtenerArchivo
            // 
            this.ObtenerArchivo.FileName = "openFileDialog1";
            // 
            // frmActualizarMontosRecup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 309);
            this.ControlBox = false;
            this.Controls.Add(this.gvdInfonavit);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmActualizarMontosRecup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperaciones IMSS";
            this.Load += new System.EventHandler(this.frmActualizarMontosRecup_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvdInfonavit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stpSelObtenerCreditosIMSSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSAICBPOActualizacionesIMSSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnFacturar;
        private System.Windows.Forms.ToolStripButton btnCargarRecupe;
        private System.Windows.Forms.ToolStripTextBox txtLiga;
        private System.Windows.Forms.ToolStripButton btnCargarArchivo;
        private DevExpress.XtraGrid.GridControl gvdInfonavit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource stpSelObtenerCreditosIMSSBindingSource;
        private dbSAICBPOActualizacionesIMSSDataSet dbSAICBPOActualizacionesIMSSDataSet;
        private dbSAICBPOActualizacionesIMSSDataSetTableAdapters.stpSelObtenerCreditosIMSSTableAdapter stpSelObtenerCreditosIMSSTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreEmpleadoCompleto;
        private DevExpress.XtraGrid.Columns.GridColumn colNSS;
        private DevExpress.XtraGrid.Columns.GridColumn colRFC;
        private DevExpress.XtraGrid.Columns.GridColumn colCURP;
        private DevExpress.XtraGrid.Columns.GridColumn colNoCredito;
        private DevExpress.XtraGrid.Columns.GridColumn colMontoRecuperar;
        private System.Windows.Forms.ToolStripButton btnDescargar;
        private dbSAICBPOActualizacionesIMSSDataSetTableAdapters.ActualizacionesIMSSTableAdapter actualizacionesIMSSTableAdapter1;
        private System.Windows.Forms.SaveFileDialog sfdRutaArchivo;
        private System.Windows.Forms.OpenFileDialog ObtenerArchivo;
    }
}