namespace ProjectQuanlyNhahang
{
    partial class FrmTimnv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTimnv));
            this.radioGioitinh = new System.Windows.Forms.RadioButton();
            this.radioSdt = new System.Windows.Forms.RadioButton();
            this.radioCmnd = new System.Windows.Forms.RadioButton();
            this.radioTen = new System.Windows.Forms.RadioButton();
            this.radioID = new System.Windows.Forms.RadioButton();
            this.ckbNu = new System.Windows.Forms.CheckBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.GridNhanvien = new System.Windows.Forms.DataGridView();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panelQuanli = new System.Windows.Forms.Panel();
            this.ckbNam = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhanViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nu = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Hinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridNhanvien)).BeginInit();
            this.panelQuanli.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioGioitinh
            // 
            this.radioGioitinh.AutoSize = true;
            this.radioGioitinh.Location = new System.Drawing.Point(369, 43);
            this.radioGioitinh.Name = "radioGioitinh";
            this.radioGioitinh.Size = new System.Drawing.Size(109, 17);
            this.radioGioitinh.TabIndex = 41;
            this.radioGioitinh.TabStop = true;
            this.radioGioitinh.Text = "Tìm Kiếm Giới Tính";
            this.radioGioitinh.UseVisualStyleBackColor = true;
            this.radioGioitinh.CheckedChanged += new System.EventHandler(this.radioGioitinh_CheckedChanged);
            // 
            // radioSdt
            // 
            this.radioSdt.AutoSize = true;
            this.radioSdt.Location = new System.Drawing.Point(369, 11);
            this.radioSdt.Name = "radioSdt";
            this.radioSdt.Size = new System.Drawing.Size(89, 17);
            this.radioSdt.TabIndex = 40;
            this.radioSdt.TabStop = true;
            this.radioSdt.Text = "Tìm Kiếm SĐT";
            this.radioSdt.UseVisualStyleBackColor = true;
            this.radioSdt.CheckedChanged += new System.EventHandler(this.radioSdt_CheckedChanged);
            // 
            // radioCmnd
            // 
            this.radioCmnd.AutoSize = true;
            this.radioCmnd.Location = new System.Drawing.Point(3, 73);
            this.radioCmnd.Name = "radioCmnd";
            this.radioCmnd.Size = new System.Drawing.Size(98, 17);
            this.radioCmnd.TabIndex = 39;
            this.radioCmnd.TabStop = true;
            this.radioCmnd.Text = "Tìm Kiếm CMND";
            this.radioCmnd.UseVisualStyleBackColor = true;
            this.radioCmnd.CheckedChanged += new System.EventHandler(this.radioCmnd_CheckedChanged);
            // 
            // radioTen
            // 
            this.radioTen.AutoSize = true;
            this.radioTen.Location = new System.Drawing.Point(3, 42);
            this.radioTen.Name = "radioTen";
            this.radioTen.Size = new System.Drawing.Size(87, 17);
            this.radioTen.TabIndex = 37;
            this.radioTen.TabStop = true;
            this.radioTen.Text = "Tìm Kiếm Tên";
            this.radioTen.UseVisualStyleBackColor = true;
            this.radioTen.CheckedChanged += new System.EventHandler(this.radioTen_CheckedChanged);
            // 
            // radioID
            // 
            this.radioID.AutoSize = true;
            this.radioID.Location = new System.Drawing.Point(3, 9);
            this.radioID.Name = "radioID";
            this.radioID.Size = new System.Drawing.Size(99, 17);
            this.radioID.TabIndex = 36;
            this.radioID.TabStop = true;
            this.radioID.Text = "Tìm Kiếm Mã NV";
            this.radioID.UseVisualStyleBackColor = true;
            this.radioID.CheckedChanged += new System.EventHandler(this.radioID_CheckedChanged);
            // 
            // ckbNu
            // 
            this.ckbNu.AutoSize = true;
            this.ckbNu.Location = new System.Drawing.Point(493, 44);
            this.ckbNu.Name = "ckbNu";
            this.ckbNu.Size = new System.Drawing.Size(40, 17);
            this.ckbNu.TabIndex = 30;
            this.ckbNu.Text = "Nữ";
            this.ckbNu.UseVisualStyleBackColor = true;
            this.ckbNu.CheckedChanged += new System.EventHandler(this.ckbNu_CheckedChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(493, 14);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 13);
            this.labelControl5.TabIndex = 27;
            this.labelControl5.Text = "Điện Thoại";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(109, 75);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(32, 13);
            this.labelControl6.TabIndex = 25;
            this.labelControl6.Text = "CMND";
            // 
            // GridNhanvien
            // 
            this.GridNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridNhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.HoTenNV,
            this.DiaChi,
            this.CMND,
            this.SoDienThoai,
            this.NgayNhanViec,
            this.Nu,
            this.Hinh});
            this.GridNhanvien.Location = new System.Drawing.Point(27, 220);
            this.GridNhanvien.Name = "GridNhanvien";
            this.GridNhanvien.Size = new System.Drawing.Size(993, 466);
            this.GridNhanvien.TabIndex = 27;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(559, 9);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(133, 21);
            this.txtSDT.TabIndex = 26;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(171, 69);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(133, 21);
            this.txtCMND.TabIndex = 24;
            this.txtCMND.TextChanged += new System.EventHandler(this.txtCMND_TextChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(109, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 13);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Họ và Tên";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(171, 39);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(149, 21);
            this.txtHoten.TabIndex = 20;
            this.txtHoten.TextChanged += new System.EventHandler(this.txtHoten_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(115, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(13, 13);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(171, 7);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(149, 21);
            this.txtID.TabIndex = 18;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // panelQuanli
            // 
            this.panelQuanli.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelQuanli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelQuanli.Controls.Add(this.ckbNam);
            this.panelQuanli.Controls.Add(this.radioGioitinh);
            this.panelQuanli.Controls.Add(this.radioSdt);
            this.panelQuanli.Controls.Add(this.radioCmnd);
            this.panelQuanli.Controls.Add(this.radioTen);
            this.panelQuanli.Controls.Add(this.radioID);
            this.panelQuanli.Controls.Add(this.ckbNu);
            this.panelQuanli.Controls.Add(this.labelControl5);
            this.panelQuanli.Controls.Add(this.txtSDT);
            this.panelQuanli.Controls.Add(this.labelControl6);
            this.panelQuanli.Controls.Add(this.txtCMND);
            this.panelQuanli.Controls.Add(this.labelControl2);
            this.panelQuanli.Controls.Add(this.txtHoten);
            this.panelQuanli.Controls.Add(this.labelControl1);
            this.panelQuanli.Controls.Add(this.txtID);
            this.panelQuanli.Location = new System.Drawing.Point(170, 86);
            this.panelQuanli.Name = "panelQuanli";
            this.panelQuanli.Size = new System.Drawing.Size(720, 107);
            this.panelQuanli.TabIndex = 28;
            // 
            // ckbNam
            // 
            this.ckbNam.AutoSize = true;
            this.ckbNam.Location = new System.Drawing.Point(549, 44);
            this.ckbNam.Name = "ckbNam";
            this.ckbNam.Size = new System.Drawing.Size(47, 17);
            this.ckbNam.TabIndex = 43;
            this.ckbNam.Text = "Nam";
            this.ckbNam.UseVisualStyleBackColor = true;
            this.ckbNam.CheckedChanged += new System.EventHandler(this.ckbNam_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(230, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 45);
            this.label1.TabIndex = 29;
            this.label1.Text = "Tìm Kiếm Thông Tin Nhân Viên";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // HoTenNV
            // 
            this.HoTenNV.DataPropertyName = "HoTenNV";
            this.HoTenNV.HeaderText = "Họ và Tên";
            this.HoTenNV.Name = "HoTenNV";
            this.HoTenNV.Width = 175;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 125;
            // 
            // CMND
            // 
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "CMND";
            this.CMND.Name = "CMND";
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "SDT";
            this.SoDienThoai.Name = "SoDienThoai";
            // 
            // NgayNhanViec
            // 
            this.NgayNhanViec.DataPropertyName = "NgayNhanViec";
            this.NgayNhanViec.HeaderText = "Ngày Nhận Việc";
            this.NgayNhanViec.Name = "NgayNhanViec";
            // 
            // Nu
            // 
            this.Nu.DataPropertyName = "Nu";
            this.Nu.HeaderText = "Nữ";
            this.Nu.Name = "Nu";
            this.Nu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Nu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Hinh
            // 
            this.Hinh.DataPropertyName = "Hinh";
            this.Hinh.HeaderText = "Hình Ảnh";
            this.Hinh.Name = "Hinh";
            this.Hinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Hinh.Width = 150;
            // 
            // FrmTimnv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(1046, 698);
            this.Controls.Add(this.GridNhanvien);
            this.Controls.Add(this.panelQuanli);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTimnv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TÌM KIẾM THÔNG TIN NHÂN VIÊN";
            this.Load += new System.EventHandler(this.FrmTimnv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridNhanvien)).EndInit();
            this.panelQuanli.ResumeLayout(false);
            this.panelQuanli.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioGioitinh;
        private System.Windows.Forms.RadioButton radioSdt;
        private System.Windows.Forms.RadioButton radioCmnd;
        private System.Windows.Forms.RadioButton radioTen;
        private System.Windows.Forms.RadioButton radioID;
        private System.Windows.Forms.CheckBox ckbNu;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.DataGridView GridNhanvien;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtCMND;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtHoten;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel panelQuanli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhanViec;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Nu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hinh;
    }
}