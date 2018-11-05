namespace ProjectQuanlyNhahang
{
    partial class FrmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhachHang));
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
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
            this.GridNhanvien = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nu = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panelQuanli = new System.Windows.Forms.Panel();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.btnChonhinh = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.picNhanvien = new System.Windows.Forms.PictureBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.ckbNu = new System.Windows.Forms.CheckBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTimKH = new System.Windows.Forms.Panel();
            this.ckbTimnam = new System.Windows.Forms.CheckBox();
            this.ckbTimnu = new System.Windows.Forms.CheckBox();
            this.txtTimSDT = new System.Windows.Forms.TextBox();
            this.txtTimDiachi = new System.Windows.Forms.TextBox();
            this.txtTimTen = new System.Windows.Forms.TextBox();
            this.txtTimMa = new System.Windows.Forms.TextBox();
            this.radioID = new System.Windows.Forms.RadioButton();
            this.radioTen = new System.Windows.Forms.RadioButton();
            this.radioLoai = new System.Windows.Forms.RadioButton();
            this.radioSdt = new System.Windows.Forms.RadioButton();
            this.radioGioitinh = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnXoahinh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridNhanvien)).BeginInit();
            this.panelQuanli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanvien)).BeginInit();
            this.panelTimKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 708);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1010, 31);
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
            this.ribbon.MaxItemId = 8;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1010, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
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
            this.btnLuu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnTim
            // 
            this.btnTim.Caption = "Tìm Kiếm ";
            this.btnTim.Id = 6;
            this.btnTim.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.ImageOptions.Image")));
            this.btnTim.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTim.ImageOptions.LargeImage")));
            this.btnTim.Name = "btnTim";
            this.btnTim.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTim.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // btnLoad
            // 
            this.btnLoad.Caption = "Reload";
            this.btnLoad.Id = 7;
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
            this.ribbonPage1.Text = "QUẢN LÝ DANH SÁCH KHÁCH HÀNG ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnThem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "                                     ";
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
            this.ribbonPageGroup3.Text = "                                   ";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnLuu);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "                                       ";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnLoad);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "                                           ";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnTim);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "                                               ";
            // 
            // GridNhanvien
            // 
            this.GridNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridNhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.HoTenKH,
            this.SoDT,
            this.DiaChi,
            this.Hinh,
            this.Nu});
            this.GridNhanvien.Location = new System.Drawing.Point(39, 338);
            this.GridNhanvien.Name = "GridNhanvien";
            this.GridNhanvien.Size = new System.Drawing.Size(935, 356);
            this.GridNhanvien.TabIndex = 29;
            this.GridNhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridNhanvien_CellClick);
            this.GridNhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridNhanvien_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ID.Width = 150;
            // 
            // HoTenKH
            // 
            this.HoTenKH.DataPropertyName = "TenKH";
            this.HoTenKH.HeaderText = "Họ và Tên";
            this.HoTenKH.Name = "HoTenKH";
            this.HoTenKH.Width = 150;
            // 
            // SoDT
            // 
            this.SoDT.DataPropertyName = "SoDienThoai";
            this.SoDT.HeaderText = "Số Điện Thoại";
            this.SoDT.Name = "SoDT";
            this.SoDT.Width = 150;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 150;
            // 
            // Hinh
            // 
            this.Hinh.DataPropertyName = "Hinh";
            this.Hinh.HeaderText = "Hình Ảnh";
            this.Hinh.Name = "Hinh";
            this.Hinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Hinh.Width = 200;
            // 
            // Nu
            // 
            this.Nu.DataPropertyName = "Nu";
            this.Nu.HeaderText = "Nữ";
            this.Nu.Name = "Nu";
            // 
            // panelQuanli
            // 
            this.panelQuanli.BackColor = System.Drawing.Color.LightCyan;
            this.panelQuanli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelQuanli.Controls.Add(this.btnXoahinh);
            this.panelQuanli.Controls.Add(this.txtDiachi);
            this.panelQuanli.Controls.Add(this.btnChonhinh);
            this.panelQuanli.Controls.Add(this.labelControl7);
            this.panelQuanli.Controls.Add(this.picNhanvien);
            this.panelQuanli.Controls.Add(this.labelControl8);
            this.panelQuanli.Controls.Add(this.ckbNu);
            this.panelQuanli.Controls.Add(this.labelControl5);
            this.panelQuanli.Controls.Add(this.txtSDT);
            this.panelQuanli.Controls.Add(this.labelControl2);
            this.panelQuanli.Controls.Add(this.txtHoten);
            this.panelQuanli.Controls.Add(this.labelControl1);
            this.panelQuanli.Controls.Add(this.txtID);
            this.panelQuanli.Location = new System.Drawing.Point(167, 225);
            this.panelQuanli.Name = "panelQuanli";
            this.panelQuanli.Size = new System.Drawing.Size(659, 107);
            this.panelQuanli.TabIndex = 30;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(66, 72);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(149, 21);
            this.txtDiachi.TabIndex = 46;
            // 
            // btnChonhinh
            // 
            this.btnChonhinh.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.btnChonhinh.AppearanceDisabled.Options.UseBackColor = true;
            this.btnChonhinh.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnChonhinh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnChonhinh.Location = new System.Drawing.Point(487, 72);
            this.btnChonhinh.Name = "btnChonhinh";
            this.btnChonhinh.Size = new System.Drawing.Size(75, 23);
            this.btnChonhinh.TabIndex = 45;
            this.btnChonhinh.Text = "Chọn Hình";
            this.btnChonhinh.Click += new System.EventHandler(this.btnChonhinh_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(510, 16);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(43, 13);
            this.labelControl7.TabIndex = 44;
            this.labelControl7.Text = "Hình Ảnh";
            // 
            // picNhanvien
            // 
            this.picNhanvien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picNhanvien.Location = new System.Drawing.Point(568, 3);
            this.picNhanvien.Name = "picNhanvien";
            this.picNhanvien.Size = new System.Drawing.Size(77, 99);
            this.picNhanvien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNhanvien.TabIndex = 43;
            this.picNhanvien.TabStop = false;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(10, 72);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(34, 13);
            this.labelControl8.TabIndex = 34;
            this.labelControl8.Text = "Địa Chỉ";
            // 
            // ckbNu
            // 
            this.ckbNu.AutoSize = true;
            this.ckbNu.Location = new System.Drawing.Point(296, 41);
            this.ckbNu.Name = "ckbNu";
            this.ckbNu.Size = new System.Drawing.Size(40, 17);
            this.ckbNu.TabIndex = 30;
            this.ckbNu.Text = "Nữ";
            this.ckbNu.UseVisualStyleBackColor = true;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(296, 15);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(51, 13);
            this.labelControl5.TabIndex = 27;
            this.labelControl5.Text = "Điện Thoại";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(353, 13);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(133, 21);
            this.txtSDT.TabIndex = 26;
            this.txtSDT.Leave += new System.EventHandler(this.txtSDT_Leave_1);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 45);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 13);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Họ và Tên";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(66, 39);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(149, 21);
            this.txtHoten.TabIndex = 20;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 13);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(66, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(149, 21);
            this.txtID.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(289, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 45);
            this.label1.TabIndex = 31;
            this.label1.Text = "Danh Sách Khách Hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelTimKH
            // 
            this.panelTimKH.BackColor = System.Drawing.Color.LightCyan;
            this.panelTimKH.Controls.Add(this.ckbTimnam);
            this.panelTimKH.Controls.Add(this.ckbTimnu);
            this.panelTimKH.Controls.Add(this.txtTimSDT);
            this.panelTimKH.Controls.Add(this.txtTimDiachi);
            this.panelTimKH.Controls.Add(this.txtTimTen);
            this.panelTimKH.Controls.Add(this.txtTimMa);
            this.panelTimKH.Controls.Add(this.radioID);
            this.panelTimKH.Controls.Add(this.radioTen);
            this.panelTimKH.Controls.Add(this.radioLoai);
            this.panelTimKH.Controls.Add(this.radioSdt);
            this.panelTimKH.Controls.Add(this.radioGioitinh);
            this.panelTimKH.Location = new System.Drawing.Point(534, 53);
            this.panelTimKH.Name = "panelTimKH";
            this.panelTimKH.Size = new System.Drawing.Size(476, 90);
            this.panelTimKH.TabIndex = 34;
            // 
            // ckbTimnam
            // 
            this.ckbTimnam.AutoSize = true;
            this.ckbTimnam.Location = new System.Drawing.Point(420, 38);
            this.ckbTimnam.Name = "ckbTimnam";
            this.ckbTimnam.Size = new System.Drawing.Size(47, 17);
            this.ckbTimnam.TabIndex = 47;
            this.ckbTimnam.Text = "Nam";
            this.ckbTimnam.UseVisualStyleBackColor = true;
            this.ckbTimnam.CheckedChanged += new System.EventHandler(this.ckbTimnam_CheckedChanged);
            // 
            // ckbTimnu
            // 
            this.ckbTimnu.AutoSize = true;
            this.ckbTimnu.Location = new System.Drawing.Point(365, 38);
            this.ckbTimnu.Name = "ckbTimnu";
            this.ckbTimnu.Size = new System.Drawing.Size(40, 17);
            this.ckbTimnu.TabIndex = 46;
            this.ckbTimnu.Text = "Nữ";
            this.ckbTimnu.UseVisualStyleBackColor = true;
            this.ckbTimnu.CheckedChanged += new System.EventHandler(this.ckbTimnu_CheckedChanged);
            // 
            // txtTimSDT
            // 
            this.txtTimSDT.Location = new System.Drawing.Point(365, 4);
            this.txtTimSDT.Name = "txtTimSDT";
            this.txtTimSDT.Size = new System.Drawing.Size(95, 21);
            this.txtTimSDT.TabIndex = 45;
            this.txtTimSDT.TextChanged += new System.EventHandler(this.txtTimSDT_TextChanged);
            // 
            // txtTimDiachi
            // 
            this.txtTimDiachi.Location = new System.Drawing.Point(111, 66);
            this.txtTimDiachi.Name = "txtTimDiachi";
            this.txtTimDiachi.Size = new System.Drawing.Size(116, 21);
            this.txtTimDiachi.TabIndex = 44;
            this.txtTimDiachi.TextChanged += new System.EventHandler(this.txtTimDiachi_TextChanged);
            // 
            // txtTimTen
            // 
            this.txtTimTen.Location = new System.Drawing.Point(111, 36);
            this.txtTimTen.Name = "txtTimTen";
            this.txtTimTen.Size = new System.Drawing.Size(116, 21);
            this.txtTimTen.TabIndex = 43;
            this.txtTimTen.TextChanged += new System.EventHandler(this.txtTimTen_TextChanged);
            // 
            // txtTimMa
            // 
            this.txtTimMa.Location = new System.Drawing.Point(111, 3);
            this.txtTimMa.Name = "txtTimMa";
            this.txtTimMa.Size = new System.Drawing.Size(116, 21);
            this.txtTimMa.TabIndex = 42;
            this.txtTimMa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // radioID
            // 
            this.radioID.AutoSize = true;
            this.radioID.Location = new System.Drawing.Point(7, 4);
            this.radioID.Name = "radioID";
            this.radioID.Size = new System.Drawing.Size(99, 17);
            this.radioID.TabIndex = 36;
            this.radioID.TabStop = true;
            this.radioID.Text = "Tìm Kiếm Mã KH";
            this.radioID.UseVisualStyleBackColor = true;
            this.radioID.CheckedChanged += new System.EventHandler(this.radioID_CheckedChanged);
            // 
            // radioTen
            // 
            this.radioTen.AutoSize = true;
            this.radioTen.Location = new System.Drawing.Point(7, 37);
            this.radioTen.Name = "radioTen";
            this.radioTen.Size = new System.Drawing.Size(87, 17);
            this.radioTen.TabIndex = 37;
            this.radioTen.TabStop = true;
            this.radioTen.Text = "Tìm Kiếm Tên";
            this.radioTen.UseVisualStyleBackColor = true;
            this.radioTen.CheckedChanged += new System.EventHandler(this.radioTen_CheckedChanged);
            // 
            // radioLoai
            // 
            this.radioLoai.AutoSize = true;
            this.radioLoai.Location = new System.Drawing.Point(7, 67);
            this.radioLoai.Name = "radioLoai";
            this.radioLoai.Size = new System.Drawing.Size(106, 17);
            this.radioLoai.TabIndex = 38;
            this.radioLoai.TabStop = true;
            this.radioLoai.Text = "Tìm Kiếm Địa Chỉ ";
            this.radioLoai.UseVisualStyleBackColor = true;
            this.radioLoai.CheckedChanged += new System.EventHandler(this.radioLoai_CheckedChanged);
            // 
            // radioSdt
            // 
            this.radioSdt.AutoSize = true;
            this.radioSdt.Location = new System.Drawing.Point(254, 4);
            this.radioSdt.Name = "radioSdt";
            this.radioSdt.Size = new System.Drawing.Size(89, 17);
            this.radioSdt.TabIndex = 40;
            this.radioSdt.TabStop = true;
            this.radioSdt.Text = "Tìm Kiếm SĐT";
            this.radioSdt.UseVisualStyleBackColor = true;
            this.radioSdt.CheckedChanged += new System.EventHandler(this.radioSdt_CheckedChanged);
            // 
            // radioGioitinh
            // 
            this.radioGioitinh.AutoSize = true;
            this.radioGioitinh.Location = new System.Drawing.Point(254, 36);
            this.radioGioitinh.Name = "radioGioitinh";
            this.radioGioitinh.Size = new System.Drawing.Size(109, 17);
            this.radioGioitinh.TabIndex = 41;
            this.radioGioitinh.TabStop = true;
            this.radioGioitinh.Text = "Tìm Kiếm Giới Tính";
            this.radioGioitinh.UseVisualStyleBackColor = true;
            this.radioGioitinh.CheckedChanged += new System.EventHandler(this.radioGioitinh_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnXoahinh
            // 
            this.btnXoahinh.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.btnXoahinh.AppearanceDisabled.Options.UseBackColor = true;
            this.btnXoahinh.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnXoahinh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnXoahinh.Location = new System.Drawing.Point(487, 43);
            this.btnXoahinh.Name = "btnXoahinh";
            this.btnXoahinh.Size = new System.Drawing.Size(75, 23);
            this.btnXoahinh.TabIndex = 47;
            this.btnXoahinh.Text = "Xóa Hình";
            this.btnXoahinh.Click += new System.EventHandler(this.btnXoahinh_Click);
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(1010, 739);
            this.Controls.Add(this.panelTimKH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridNhanvien);
            this.Controls.Add(this.panelQuanli);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmKhachHang";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "QUẢN LÍ DANH SÁCH KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.FrmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridNhanvien)).EndInit();
            this.panelQuanli.ResumeLayout(false);
            this.panelQuanli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanvien)).EndInit();
            this.panelTimKH.ResumeLayout(false);
            this.panelTimKH.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private System.Windows.Forms.DataGridView GridNhanvien;
        private System.Windows.Forms.Panel panelQuanli;
        private System.Windows.Forms.CheckBox ckbNu;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox txtSDT;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtHoten;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnChonhinh;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.PictureBox picNhanvien;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Panel panelTimKH;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnTim;
        private DevExpress.XtraBars.BarButtonItem btnLoad;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private System.Windows.Forms.CheckBox ckbTimnam;
        private System.Windows.Forms.CheckBox ckbTimnu;
        private System.Windows.Forms.TextBox txtTimSDT;
        private System.Windows.Forms.TextBox txtTimDiachi;
        private System.Windows.Forms.TextBox txtTimTen;
        private System.Windows.Forms.TextBox txtTimMa;
        private System.Windows.Forms.RadioButton radioID;
        private System.Windows.Forms.RadioButton radioTen;
        private System.Windows.Forms.RadioButton radioLoai;
        private System.Windows.Forms.RadioButton radioSdt;
        private System.Windows.Forms.RadioButton radioGioitinh;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hinh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Nu;
        private DevExpress.XtraEditors.SimpleButton btnXoahinh;
    }
}