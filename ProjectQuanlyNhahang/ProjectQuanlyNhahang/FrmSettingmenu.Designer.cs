namespace ProjectQuanlyNhahang
{
    partial class FrmSettingmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettingmenu));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnTim = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoad = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panelMonan = new DevExpress.XtraEditors.PanelControl();
            this.btnXoahinh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMamon = new System.Windows.Forms.RichTextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.picMonan = new System.Windows.Forms.PictureBox();
            this.txtTenmon = new System.Windows.Forms.RichTextBox();
            this.btnChonhinh = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDongia = new System.Windows.Forms.RichTextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.ID_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMON_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTimMon = new System.Windows.Forms.Panel();
            this.txtTimDonGia = new System.Windows.Forms.TextBox();
            this.txtTimTen = new System.Windows.Forms.TextBox();
            this.txtTimMa = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioLoai = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMonan)).BeginInit();
            this.panelMonan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMonan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.panelTimMon.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnLuu,
            this.btnTim,
            this.btnLoad});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(978, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 1;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 3;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 4;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.LargeImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnTim
            // 
            this.btnTim.Caption = "Tìm Kiếm ";
            this.btnTim.Id = 5;
            this.btnTim.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.ImageOptions.Image")));
            this.btnTim.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTim.ImageOptions.LargeImage")));
            this.btnTim.Name = "btnTim";
            this.btnTim.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTim_ItemClick);
            // 
            // btnLoad
            // 
            this.btnLoad.Caption = "Reload";
            this.btnLoad.Id = 6;
            this.btnLoad.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.ImageOptions.Image")));
            this.btnLoad.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLoad.ImageOptions.LargeImage")));
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoad_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup6,
            this.ribbonPageGroup5});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "QUẢN LÍ THỰC ĐƠN";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnThem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "                                           ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnXoa);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "                                 ";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnSua);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "                                             ";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnLoad);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "                                            ";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnLuu);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "                                      ";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnTim);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "                                 ";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 648);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(978, 31);
            // 
            // panelMonan
            // 
            this.panelMonan.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelMonan.Appearance.Options.UseBackColor = true;
            this.panelMonan.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.panelMonan.CausesValidation = false;
            this.panelMonan.ContentImage = ((System.Drawing.Image)(resources.GetObject("panelMonan.ContentImage")));
            this.panelMonan.ContentImageAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.panelMonan.Controls.Add(this.btnXoahinh);
            this.panelMonan.Controls.Add(this.label2);
            this.panelMonan.Controls.Add(this.txtMamon);
            this.panelMonan.Controls.Add(this.labelControl4);
            this.panelMonan.Controls.Add(this.picMonan);
            this.panelMonan.Controls.Add(this.txtTenmon);
            this.panelMonan.Controls.Add(this.btnChonhinh);
            this.panelMonan.Controls.Add(this.labelControl1);
            this.panelMonan.Controls.Add(this.labelControl3);
            this.panelMonan.Controls.Add(this.txtDongia);
            this.panelMonan.Controls.Add(this.labelControl2);
            this.panelMonan.Location = new System.Drawing.Point(645, 222);
            this.panelMonan.Name = "panelMonan";
            this.panelMonan.Size = new System.Drawing.Size(304, 403);
            this.panelMonan.TabIndex = 28;
            // 
            // btnXoahinh
            // 
            this.btnXoahinh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoahinh.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoahinh.Location = new System.Drawing.Point(196, 368);
            this.btnXoahinh.Name = "btnXoahinh";
            this.btnXoahinh.Size = new System.Drawing.Size(84, 30);
            this.btnXoahinh.TabIndex = 29;
            this.btnXoahinh.Text = "Xóa Hình";
            this.btnXoahinh.UseVisualStyleBackColor = true;
            this.btnXoahinh.Click += new System.EventHandler(this.btnXoahinh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCyan;
            this.label2.Font = new System.Drawing.Font("UVN Dung Dan", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(91, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 44);
            this.label2.TabIndex = 28;
            this.label2.Text = "Món Ăn";
            // 
            // txtMamon
            // 
            this.txtMamon.Location = new System.Drawing.Point(99, 69);
            this.txtMamon.Name = "txtMamon";
            this.txtMamon.Size = new System.Drawing.Size(154, 26);
            this.txtMamon.TabIndex = 26;
            this.txtMamon.Text = "";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(13, 73);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(80, 18);
            this.labelControl4.TabIndex = 27;
            this.labelControl4.Text = "Mã Món Ăn";
            // 
            // picMonan
            // 
            this.picMonan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMonan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMonan.Location = new System.Drawing.Point(141, 238);
            this.picMonan.Name = "picMonan";
            this.picMonan.Size = new System.Drawing.Size(112, 109);
            this.picMonan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMonan.TabIndex = 25;
            this.picMonan.TabStop = false;
            // 
            // txtTenmon
            // 
            this.txtTenmon.Location = new System.Drawing.Point(99, 131);
            this.txtTenmon.Name = "txtTenmon";
            this.txtTenmon.Size = new System.Drawing.Size(154, 26);
            this.txtTenmon.TabIndex = 16;
            this.txtTenmon.Text = "";
            // 
            // btnChonhinh
            // 
            this.btnChonhinh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChonhinh.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonhinh.Location = new System.Drawing.Point(94, 368);
            this.btnChonhinh.Name = "btnChonhinh";
            this.btnChonhinh.Size = new System.Drawing.Size(84, 30);
            this.btnChonhinh.TabIndex = 24;
            this.btnChonhinh.Text = "Chọn Hình";
            this.btnChonhinh.UseVisualStyleBackColor = true;
            this.btnChonhinh.Click += new System.EventHandler(this.btnChonhinh_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(13, 136);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 18);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "Tên Món";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(28, 274);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 18);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "Hình Ảnh ";
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(99, 188);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(154, 26);
            this.txtDongia.TabIndex = 19;
            this.txtDongia.Text = "";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(13, 191);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 18);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Đơn Giá";
            // 
            // dgvMenu
            // 
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_,
            this.TENMON_,
            this.DONGIA_,
            this.Hinh});
            this.dgvMenu.Location = new System.Drawing.Point(30, 222);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.Size = new System.Drawing.Size(592, 403);
            this.dgvMenu.TabIndex = 27;
            this.dgvMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellClick);
            // 
            // ID_
            // 
            this.ID_.DataPropertyName = "ID";
            this.ID_.HeaderText = "Mã Món";
            this.ID_.Name = "ID_";
            this.ID_.Width = 75;
            // 
            // TENMON_
            // 
            this.TENMON_.DataPropertyName = "TenSP";
            this.TENMON_.HeaderText = "Tên Món";
            this.TENMON_.Name = "TENMON_";
            this.TENMON_.Width = 200;
            // 
            // DONGIA_
            // 
            this.DONGIA_.DataPropertyName = "DONGIA";
            this.DONGIA_.HeaderText = "Đơn Giá";
            this.DONGIA_.Name = "DONGIA_";
            this.DONGIA_.Width = 125;
            // 
            // Hinh
            // 
            this.Hinh.DataPropertyName = "Hinh";
            this.Hinh.HeaderText = "Hình Ảnh";
            this.Hinh.Name = "Hinh";
            this.Hinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Hinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Hinh.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(301, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 45);
            this.label1.TabIndex = 29;
            this.label1.Text = "Danh Sách Thực Đơn";
            // 
            // panelTimMon
            // 
            this.panelTimMon.BackColor = System.Drawing.Color.LightCyan;
            this.panelTimMon.Controls.Add(this.txtTimDonGia);
            this.panelTimMon.Controls.Add(this.txtTimTen);
            this.panelTimMon.Controls.Add(this.txtTimMa);
            this.panelTimMon.Controls.Add(this.radioButton1);
            this.panelTimMon.Controls.Add(this.radioButton3);
            this.panelTimMon.Controls.Add(this.radioLoai);
            this.panelTimMon.Location = new System.Drawing.Point(533, 53);
            this.panelTimMon.Name = "panelTimMon";
            this.panelTimMon.Size = new System.Drawing.Size(444, 91);
            this.panelTimMon.TabIndex = 35;
            // 
            // txtTimDonGia
            // 
            this.txtTimDonGia.Location = new System.Drawing.Point(207, 66);
            this.txtTimDonGia.Name = "txtTimDonGia";
            this.txtTimDonGia.Size = new System.Drawing.Size(141, 21);
            this.txtTimDonGia.TabIndex = 44;
            this.txtTimDonGia.TextChanged += new System.EventHandler(this.txtTimDonGia_TextChanged);
            // 
            // txtTimTen
            // 
            this.txtTimTen.Location = new System.Drawing.Point(206, 37);
            this.txtTimTen.Name = "txtTimTen";
            this.txtTimTen.Size = new System.Drawing.Size(142, 21);
            this.txtTimTen.TabIndex = 43;
            this.txtTimTen.TextChanged += new System.EventHandler(this.txtTimTen_TextChanged);
            // 
            // txtTimMa
            // 
            this.txtTimMa.Location = new System.Drawing.Point(206, 10);
            this.txtTimMa.Name = "txtTimMa";
            this.txtTimMa.Size = new System.Drawing.Size(142, 21);
            this.txtTimMa.TabIndex = 42;
            this.txtTimMa.TextChanged += new System.EventHandler(this.txtTimMa_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(67, 11);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(122, 17);
            this.radioButton1.TabIndex = 36;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tìm Kiếm Mã Món Ăn";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(67, 40);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(110, 17);
            this.radioButton3.TabIndex = 37;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Tìm Kiếm Tên Món";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioLoai
            // 
            this.radioLoai.AutoSize = true;
            this.radioLoai.Location = new System.Drawing.Point(67, 67);
            this.radioLoai.Name = "radioLoai";
            this.radioLoai.Size = new System.Drawing.Size(110, 17);
            this.radioLoai.TabIndex = 38;
            this.radioLoai.TabStop = true;
            this.radioLoai.Text = "Tìm Kiếm Đơn Giá ";
            this.radioLoai.UseVisualStyleBackColor = true;
            this.radioLoai.CheckedChanged += new System.EventHandler(this.radioLoai_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmSettingmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(978, 679);
            this.Controls.Add(this.panelTimMon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelMonan);
            this.Controls.Add(this.dgvMenu);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSettingmenu";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "QUẢN LÍ THỰC ĐƠN";
            this.Load += new System.EventHandler(this.FrmSettingmenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMonan)).EndInit();
            this.panelMonan.ResumeLayout(false);
            this.panelMonan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMonan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.panelTimMon.ResumeLayout(false);
            this.panelTimMon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnTim;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraEditors.PanelControl panelMonan;
        private System.Windows.Forms.RichTextBox txtMamon;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.PictureBox picMonan;
        private System.Windows.Forms.RichTextBox txtTenmon;
        private System.Windows.Forms.Button btnChonhinh;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.RichTextBox txtDongia;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarButtonItem btnLoad;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelTimMon;
        private System.Windows.Forms.TextBox txtTimDonGia;
        private System.Windows.Forms.TextBox txtTimTen;
        private System.Windows.Forms.TextBox txtTimMa;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioLoai;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnXoahinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMON_;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hinh;
    }
}