namespace QLKS
{
    partial class FormMenu
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.btndv = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnSDP = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSDP = new DevExpress.XtraBars.BarButtonItem();
            this.btnHSK = new DevExpress.XtraBars.BarButtonItem();
            this.btnNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnTT = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnLT = new DevExpress.XtraBars.BarButtonItem();
            this.LAD = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemHypertextLabel1 = new DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSDP,
            this.btnDSDP,
            this.btnLT,
            this.btnHSK,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.btnNV,
            this.btnTT,
            this.barStaticItem1,
            this.LAD,
            this.barStaticItem2,
            this.btndv});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 14;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHypertextLabel1});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.btndv),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem7)});
            this.bar1.Text = "Tools";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Hệ thống";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // btndv
            // 
            this.btndv.Caption = "Dịch vụ";
            this.btndv.Id = 13;
            this.btndv.Name = "btndv";
            this.btndv.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Cài đặt";
            this.barButtonItem6.Id = 5;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Help";
            this.barButtonItem7.Id = 6;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSDP),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDSDP),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHSK),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNV),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTT)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnSDP
            // 
            this.btnSDP.Caption = "Sơ Đồ Phòng";
            this.btnSDP.Id = 0;
            this.btnSDP.ImageOptions.SvgImage = global::QLKS.Properties.Resources.bo_appearance;
            this.btnSDP.Name = "btnSDP";
            this.btnSDP.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSDP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSDP_ItemClick);
            // 
            // btnDSDP
            // 
            this.btnDSDP.Caption = "Đặt Phòng";
            this.btnDSDP.Id = 1;
            this.btnDSDP.ImageOptions.SvgImage = global::QLKS.Properties.Resources.editcolors;
            this.btnDSDP.Name = "btnDSDP";
            this.btnDSDP.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDSDP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSDP_ItemClick);
            // 
            // btnHSK
            // 
            this.btnHSK.Caption = "Hồ Sơ Khách Hàng";
            this.btnHSK.Id = 3;
            this.btnHSK.ImageOptions.SvgImage = global::QLKS.Properties.Resources.bo_contact;
            this.btnHSK.Name = "btnHSK";
            this.btnHSK.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnHSK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHSK_ItemClick);
            // 
            // btnNV
            // 
            this.btnNV.Caption = "Thông Tin Nhân Viên";
            this.btnNV.Id = 7;
            this.btnNV.ImageOptions.SvgImage = global::QLKS.Properties.Resources.bo_contact1;
            this.btnNV.Name = "btnNV";
            this.btnNV.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNV_ItemClick);
            // 
            // btnTT
            // 
            this.btnTT.Caption = "Trả Phòng";
            this.btnTT.Id = 8;
            this.btnTT.ImageOptions.SvgImage = global::QLKS.Properties.Resources.business_dollarcircled;
            this.btnTT.Name = "btnTT";
            this.btnTT.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnTT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTT_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem2)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "  Welcom to Clique";
            this.barStaticItem1.Id = 9;
            this.barStaticItem1.ImageOptions.Image = global::QLKS.Properties.Resources.bolocalization_16x16;
            this.barStaticItem1.ImageOptions.LargeImage = global::QLKS.Properties.Resources.bolocalization_32x32;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "Đăng nhập";
            this.barStaticItem2.Id = 11;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barStaticItem2_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Appearance.BackColor = System.Drawing.Color.White;
            this.barDockControlTop.Appearance.BackColor2 = System.Drawing.Color.White;
            this.barDockControlTop.Appearance.Options.UseBackColor = true;
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1115, 70);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 667);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1115, 45);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 70);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 597);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1115, 70);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 597);
            // 
            // btnLT
            // 
            this.btnLT.Caption = "Lễ Tân";
            this.btnLT.Id = 2;
            this.btnLT.ImageOptions.SvgImage = global::QLKS.Properties.Resources.bo_lead1;
            this.btnLT.Name = "btnLT";
            this.btnLT.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnLT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLT_ItemClick);
            // 
            // LAD
            // 
            this.LAD.Caption = "Link";
            this.LAD.Edit = this.repositoryItemHypertextLabel1;
            this.LAD.Id = 10;
            this.LAD.Name = "LAD";
            // 
            // repositoryItemHypertextLabel1
            // 
            this.repositoryItemHypertextLabel1.Name = "repositoryItemHypertextLabel1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 597);
            this.panel1.TabIndex = 4;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 712);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMenu";
            this.Text = "Quản Lý Khách Sạn";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnSDP;
        private DevExpress.XtraBars.BarButtonItem btnDSDP;
        private DevExpress.XtraBars.BarButtonItem btnLT;
        private DevExpress.XtraBars.BarButtonItem btnHSK;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.BarButtonItem btnNV;
        private DevExpress.XtraBars.BarButtonItem btnTT;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarEditItem LAD;
        private DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel repositoryItemHypertextLabel1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarButtonItem btndv;
    }
}