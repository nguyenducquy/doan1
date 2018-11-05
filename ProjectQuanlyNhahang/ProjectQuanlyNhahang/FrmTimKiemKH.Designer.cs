namespace ProjectQuanlyNhahang
{
    partial class FrmTimKiemKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTimKiemKH));
            this.label1 = new System.Windows.Forms.Label();
            this.GridNhanvien = new System.Windows.Forms.DataGridView();
            this.panelQuanli = new System.Windows.Forms.Panel();
            this.ckbNam = new System.Windows.Forms.CheckBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.radioGioitinh = new System.Windows.Forms.RadioButton();
            this.radioSdt = new System.Windows.Forms.RadioButton();
            this.radioDiachi = new System.Windows.Forms.RadioButton();
            this.radioTen = new System.Windows.Forms.RadioButton();
            this.radioID = new System.Windows.Forms.RadioButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.ckbNu = new System.Windows.Forms.CheckBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nu = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridNhanvien)).BeginInit();
            this.panelQuanli.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(300, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 45);
            this.label1.TabIndex = 34;
            this.label1.Text = "Danh Sách Khách Hàng";
            // 
            // GridNhanvien
            // 
            this.GridNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridNhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.HoTenKH,
            this.SoDT,
            this.Hinh,
            this.SoDienThoai,
            this.Nu});
            this.GridNhanvien.Location = new System.Drawing.Point(32, 185);
            this.GridNhanvien.Name = "GridNhanvien";
            this.GridNhanvien.Size = new System.Drawing.Size(939, 356);
            this.GridNhanvien.TabIndex = 32;
            // 
            // panelQuanli
            // 
            this.panelQuanli.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelQuanli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelQuanli.Controls.Add(this.ckbNam);
            this.panelQuanli.Controls.Add(this.txtDiachi);
            this.panelQuanli.Controls.Add(this.radioGioitinh);
            this.panelQuanli.Controls.Add(this.radioSdt);
            this.panelQuanli.Controls.Add(this.radioDiachi);
            this.panelQuanli.Controls.Add(this.radioTen);
            this.panelQuanli.Controls.Add(this.radioID);
            this.panelQuanli.Controls.Add(this.labelControl8);
            this.panelQuanli.Controls.Add(this.ckbNu);
            this.panelQuanli.Controls.Add(this.labelControl5);
            this.panelQuanli.Controls.Add(this.txtSDT);
            this.panelQuanli.Controls.Add(this.labelControl2);
            this.panelQuanli.Controls.Add(this.txtHoten);
            this.panelQuanli.Controls.Add(this.labelControl1);
            this.panelQuanli.Controls.Add(this.txtID);
            this.panelQuanli.Location = new System.Drawing.Point(162, 72);
            this.panelQuanli.Name = "panelQuanli";
            this.panelQuanli.Size = new System.Drawing.Size(699, 107);
            this.panelQuanli.TabIndex = 33;
            // 
            // ckbNam
            // 
            this.ckbNam.AutoSize = true;
            this.ckbNam.Location = new System.Drawing.Point(550, 50);
            this.ckbNam.Name = "ckbNam";
            this.ckbNam.Size = new System.Drawing.Size(47, 17);
            this.ckbNam.TabIndex = 47;
            this.ckbNam.Text = "Nam";
            this.ckbNam.UseVisualStyleBackColor = true;
            this.ckbNam.CheckedChanged += new System.EventHandler(this.ckbNam_CheckedChanged);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(182, 68);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(149, 21);
            this.txtDiachi.TabIndex = 46;
            this.txtDiachi.TextChanged += new System.EventHandler(this.txtDiachi_TextChanged);
            // 
            // radioGioitinh
            // 
            this.radioGioitinh.AutoSize = true;
            this.radioGioitinh.Location = new System.Drawing.Point(360, 48);
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
            this.radioSdt.Location = new System.Drawing.Point(360, 9);
            this.radioSdt.Name = "radioSdt";
            this.radioSdt.Size = new System.Drawing.Size(89, 17);
            this.radioSdt.TabIndex = 40;
            this.radioSdt.TabStop = true;
            this.radioSdt.Text = "Tìm Kiếm SĐT";
            this.radioSdt.UseVisualStyleBackColor = true;
            this.radioSdt.CheckedChanged += new System.EventHandler(this.radioSdt_CheckedChanged);
            // 
            // radioDiachi
            // 
            this.radioDiachi.AutoSize = true;
            this.radioDiachi.Location = new System.Drawing.Point(14, 65);
            this.radioDiachi.Name = "radioDiachi";
            this.radioDiachi.Size = new System.Drawing.Size(106, 17);
            this.radioDiachi.TabIndex = 38;
            this.radioDiachi.TabStop = true;
            this.radioDiachi.Text = "Tìm Kiếm Địa Chỉ ";
            this.radioDiachi.UseVisualStyleBackColor = true;
            this.radioDiachi.CheckedChanged += new System.EventHandler(this.radioLoai_CheckedChanged);
            // 
            // radioTen
            // 
            this.radioTen.AutoSize = true;
            this.radioTen.Location = new System.Drawing.Point(14, 38);
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
            this.radioID.Location = new System.Drawing.Point(14, 10);
            this.radioID.Name = "radioID";
            this.radioID.Size = new System.Drawing.Size(99, 17);
            this.radioID.TabIndex = 36;
            this.radioID.TabStop = true;
            this.radioID.Text = "Tìm Kiếm Mã NV";
            this.radioID.UseVisualStyleBackColor = true;
            this.radioID.CheckedChanged += new System.EventHandler(this.radioID_CheckedChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(126, 68);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(34, 13);
            this.labelControl8.TabIndex = 34;
            this.labelControl8.Text = "Địa Chỉ";
            // 
            // ckbNu
            // 
            this.ckbNu.AutoSize = true;
            this.ckbNu.Location = new System.Drawing.Point(491, 50);
            this.ckbNu.Name = "ckbNu";
            this.ckbNu.Size = new System.Drawing.Size(40, 17);
            this.ckbNu.TabIndex = 30;
            this.ckbNu.Text = "Nữ";
            this.ckbNu.UseVisualStyleBackColor = true;
            this.ckbNu.CheckedChanged += new System.EventHandler(this.ckbNu_CheckedChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(491, 11);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(51, 13);
            this.labelControl5.TabIndex = 27;
            this.labelControl5.Text = "Điện Thoại";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(548, 9);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(133, 21);
            this.txtSDT.TabIndex = 26;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(128, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 13);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Họ và Tên";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(182, 35);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(149, 21);
            this.txtHoten.TabIndex = 20;
            this.txtHoten.TextChanged += new System.EventHandler(this.txtHoten_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(131, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 13);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(182, 8);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(149, 21);
            this.txtID.TabIndex = 18;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
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
            // Hinh
            // 
            this.Hinh.DataPropertyName = "Hinh";
            this.Hinh.HeaderText = "Hình Ảnh";
            this.Hinh.Name = "Hinh";
            this.Hinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Hinh.Width = 200;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "DiaChi";
            this.SoDienThoai.HeaderText = "Địa Chỉ";
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.Width = 150;
            // 
            // Nu
            // 
            this.Nu.DataPropertyName = "Nu";
            this.Nu.HeaderText = "Nữ";
            this.Nu.Name = "Nu";
            // 
            // FrmTimKiemKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(998, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridNhanvien);
            this.Controls.Add(this.panelQuanli);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTimKiemKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TÌM KIẾM KHÁCH HÀNG ";
            this.Load += new System.EventHandler(this.FrmTimKiemKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridNhanvien)).EndInit();
            this.panelQuanli.ResumeLayout(false);
            this.panelQuanli.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridNhanvien;
        private System.Windows.Forms.Panel panelQuanli;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.RadioButton radioGioitinh;
        private System.Windows.Forms.RadioButton radioSdt;
        private System.Windows.Forms.RadioButton radioDiachi;
        private System.Windows.Forms.RadioButton radioTen;
        private System.Windows.Forms.RadioButton radioID;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.CheckBox ckbNu;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox txtSDT;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtHoten;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.CheckBox ckbNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Nu;
    }
}