namespace winAppSAIC.Catalogos
{
    partial class frmxCatalogosGenerales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxCatalogosGenerales));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splitContainerControl1 = new System.Windows.Forms.SplitContainer();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navGenerales = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiEstatus = new DevExpress.XtraNavBar.NavBarItem();
            this.navGeneralesSAT = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiRegimenFiscalSAT = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiPeriodicidadSAT = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiTipoContratoSAT = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiTipoJornadaSAT = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiTipoNominaSAT = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiMatrizTenedora = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiTenedora = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiCFDIsPagadora = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
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
            this.btnSalir});
            this.barManager1.MaxItemId = 1;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSalir, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnSalir
            // 
            this.btnSalir.Caption = "Salir";
            this.btnSalir.Id = 0;
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.LargeImage")));
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalir_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(789, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 402);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(789, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 376);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(789, 26);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 376);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 26);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.navBarControl1);
            this.splitContainerControl1.Size = new System.Drawing.Size(789, 376);
            this.splitContainerControl1.SplitterDistance = 179;
            this.splitContainerControl1.TabIndex = 4;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navGenerales;
            this.navBarControl1.Appearance.Item.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarControl1.Appearance.Item.Options.UseFont = true;
            this.navBarControl1.Appearance.ItemActive.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarControl1.Appearance.ItemActive.Options.UseFont = true;
            this.navBarControl1.Appearance.ItemDisabled.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarControl1.Appearance.ItemDisabled.Options.UseFont = true;
            this.navBarControl1.Appearance.ItemHotTracked.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarControl1.Appearance.ItemHotTracked.Options.UseFont = true;
            this.navBarControl1.Appearance.ItemPressed.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarControl1.Appearance.ItemPressed.Options.UseFont = true;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navGenerales,
            this.navGeneralesSAT});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbiMatrizTenedora,
            this.nbiTenedora,
            this.nbiCFDIsPagadora,
            this.nbiEstatus,
            this.nbiPeriodicidadSAT,
            this.nbiRegimenFiscalSAT,
            this.nbiTipoContratoSAT,
            this.nbiTipoJornadaSAT,
            this.nbiTipoNominaSAT});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 179;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(179, 376);
            this.navBarControl1.TabIndex = 1;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinExplorerBarViewInfoRegistrator("Metropolis");
            // 
            // navGenerales
            // 
            this.navGenerales.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navGenerales.Appearance.Options.UseFont = true;
            this.navGenerales.Caption = "Generales";
            this.navGenerales.Expanded = true;
            this.navGenerales.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiEstatus)});
            this.navGenerales.Name = "navGenerales";
            this.navGenerales.SmallImage = ((System.Drawing.Image)(resources.GetObject("navGenerales.SmallImage")));
            // 
            // nbiEstatus
            // 
            this.nbiEstatus.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbiEstatus.Appearance.Options.UseFont = true;
            this.nbiEstatus.Caption = "Estatus";
            this.nbiEstatus.Name = "nbiEstatus";
            this.nbiEstatus.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiEstatus_LinkClicked);
            // 
            // navGeneralesSAT
            // 
            this.navGeneralesSAT.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.navGeneralesSAT.Appearance.Options.UseFont = true;
            this.navGeneralesSAT.Caption = "Generales SAT-CFDI";
            this.navGeneralesSAT.Expanded = true;
            this.navGeneralesSAT.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiRegimenFiscalSAT),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiPeriodicidadSAT),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiTipoContratoSAT),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiTipoJornadaSAT),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiTipoNominaSAT)});
            this.navGeneralesSAT.Name = "navGeneralesSAT";
            // 
            // nbiRegimenFiscalSAT
            // 
            this.nbiRegimenFiscalSAT.Caption = "Régimen Fiscal";
            this.nbiRegimenFiscalSAT.Name = "nbiRegimenFiscalSAT";
            this.nbiRegimenFiscalSAT.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiRegimenFiscalSAT_LinkClicked);
            // 
            // nbiPeriodicidadSAT
            // 
            this.nbiPeriodicidadSAT.Caption = "Periodicidad de Pago";
            this.nbiPeriodicidadSAT.Name = "nbiPeriodicidadSAT";
            this.nbiPeriodicidadSAT.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiPeriodicidadSAT_LinkClicked);
            // 
            // nbiTipoContratoSAT
            // 
            this.nbiTipoContratoSAT.Caption = "Tipo Contrato";
            this.nbiTipoContratoSAT.Name = "nbiTipoContratoSAT";
            this.nbiTipoContratoSAT.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiTipoContratoSAT_LinkClicked);
            // 
            // nbiTipoJornadaSAT
            // 
            this.nbiTipoJornadaSAT.Caption = "Tipo Jornada";
            this.nbiTipoJornadaSAT.Name = "nbiTipoJornadaSAT";
            this.nbiTipoJornadaSAT.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiTipoJornadaSAT_LinkClicked);
            // 
            // nbiTipoNominaSAT
            // 
            this.nbiTipoNominaSAT.Caption = "Tipo Nómina";
            this.nbiTipoNominaSAT.Name = "nbiTipoNominaSAT";
            this.nbiTipoNominaSAT.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiTipoNominaSAT_LinkClicked);
            // 
            // nbiMatrizTenedora
            // 
            this.nbiMatrizTenedora.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbiMatrizTenedora.Appearance.Options.UseFont = true;
            this.nbiMatrizTenedora.Caption = "Matriz Tenedora";
            this.nbiMatrizTenedora.Name = "nbiMatrizTenedora";
            // 
            // nbiTenedora
            // 
            this.nbiTenedora.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbiTenedora.Appearance.Options.UseFont = true;
            this.nbiTenedora.Caption = "Tenedora";
            this.nbiTenedora.Name = "nbiTenedora";
            // 
            // nbiCFDIsPagadora
            // 
            this.nbiCFDIsPagadora.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbiCFDIsPagadora.Appearance.Options.UseFont = true;
            this.nbiCFDIsPagadora.Caption = "CFDIs por Pagadora";
            this.nbiCFDIsPagadora.Name = "nbiCFDIsPagadora";
            this.nbiCFDIsPagadora.Visible = false;
            // 
            // frmxCatalogosGenerales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 402);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmxCatalogosGenerales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogos Generales";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
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
        private System.Windows.Forms.SplitContainer splitContainerControl1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarItem nbiMatrizTenedora;
        private DevExpress.XtraNavBar.NavBarItem nbiTenedora;
        private DevExpress.XtraNavBar.NavBarGroup navGenerales;
        private DevExpress.XtraNavBar.NavBarItem nbiEstatus;
        private DevExpress.XtraNavBar.NavBarItem nbiCFDIsPagadora;
        private DevExpress.XtraNavBar.NavBarGroup navGeneralesSAT;
        private DevExpress.XtraNavBar.NavBarItem nbiPeriodicidadSAT;
        private DevExpress.XtraNavBar.NavBarItem nbiRegimenFiscalSAT;
        private DevExpress.XtraNavBar.NavBarItem nbiTipoContratoSAT;
        private DevExpress.XtraNavBar.NavBarItem nbiTipoJornadaSAT;
        private DevExpress.XtraNavBar.NavBarItem nbiTipoNominaSAT;
    }
}