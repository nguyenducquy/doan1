namespace ProjectQuanlyNhahang
{
    partial class FrmDatmon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDatmon));
            this.txtSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnOrder = new System.Windows.Forms.Button();
            this.cmbBan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.Label();
            this.cmbNhanVien = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.txtDateCheckIn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lsbThucUong = new System.Windows.Forms.ListBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.cmbLoaiThucUong = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCafeCategory = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCafe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flpOrder = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvMenu1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUndo = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbKH = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(266, 384);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(75, 21);
            this.txtSoLuong.TabIndex = 74;
            this.txtSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnOrder
            // 
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.Blue;
            this.btnOrder.Location = new System.Drawing.Point(762, 287);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(94, 63);
            this.btnOrder.TabIndex = 73;
            this.btnOrder.Text = "Order Mới";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // cmbBan
            // 
            this.cmbBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBan.FormattingEnabled = true;
            this.cmbBan.Location = new System.Drawing.Point(724, 213);
            this.cmbBan.Name = "cmbBan";
            this.cmbBan.Size = new System.Drawing.Size(132, 27);
            this.cmbBan.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(606, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 22);
            this.label6.TabIndex = 71;
            this.label6.Text = "Bàn";
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s.Location = new System.Drawing.Point(606, 164);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(92, 22);
            this.s.TabIndex = 70;
            this.s.Text = "Nhân viên";
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNhanVien.FormattingEnabled = true;
            this.cmbNhanVien.Location = new System.Drawing.Point(724, 159);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(132, 27);
            this.cmbNhanVien.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(348, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 22);
            this.label4.TabIndex = 68;
            this.label4.Text = "Tổng cộng: ";
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ForeColor = System.Drawing.Color.Red;
            this.btnHoaDon.Location = new System.Drawing.Point(621, 287);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(97, 64);
            this.btnHoaDon.TabIndex = 67;
            this.btnHoaDon.Text = "Đặt Bàn";
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click_1);
            // 
            // txtSum
            // 
            this.txtSum.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSum.Location = new System.Drawing.Point(461, 379);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(150, 29);
            this.txtSum.TabIndex = 66;
            // 
            // txtDateCheckIn
            // 
            this.txtDateCheckIn.Location = new System.Drawing.Point(229, 709);
            this.txtDateCheckIn.Name = "txtDateCheckIn";
            this.txtDateCheckIn.Size = new System.Drawing.Size(175, 21);
            this.txtDateCheckIn.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(188, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 62;
            this.label2.Text = "Số lượng";
            // 
            // lsbThucUong
            // 
            this.lsbThucUong.FormattingEnabled = true;
            this.lsbThucUong.Location = new System.Drawing.Point(27, 106);
            this.lsbThucUong.Name = "lsbThucUong";
            this.lsbThucUong.Size = new System.Drawing.Size(265, 264);
            this.lsbThucUong.TabIndex = 61;
            this.lsbThucUong.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lsbThucUong_MouseClick_1);
            this.lsbThucUong.SelectedIndexChanged += new System.EventHandler(this.lsbThucUong_SelectedIndexChanged);
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(61, 376);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(76, 36);
            this.btnChon.TabIndex = 60;
            this.btnChon.Text = "Chọn món";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click_1);
            // 
            // cmbLoaiThucUong
            // 
            this.cmbLoaiThucUong.FormattingEnabled = true;
            this.cmbLoaiThucUong.Location = new System.Drawing.Point(157, 60);
            this.cmbLoaiThucUong.Name = "cmbLoaiThucUong";
            this.cmbLoaiThucUong.Size = new System.Drawing.Size(121, 21);
            this.cmbLoaiThucUong.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UVN Bach Dang", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(33, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 27);
            this.label3.TabIndex = 57;
            this.label3.Text = "Chọn Món Ăn";
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "            Giá";
            this.price.Name = "price";
            this.price.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // idCafeCategory
            // 
            this.idCafeCategory.DataPropertyName = "idCafeCategory";
            this.idCafeCategory.HeaderText = "Loại thức uống";
            this.idCafeCategory.Name = "idCafeCategory";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Tên thức uống";
            this.name.Name = "name";
            // 
            // idCafe
            // 
            this.idCafe.DataPropertyName = "idCafe";
            this.idCafe.Frozen = true;
            this.idCafe.HeaderText = "Mã thức uống";
            this.idCafe.Name = "idCafe";
            // 
            // flpOrder
            // 
            this.flpOrder.AutoScroll = true;
            this.flpOrder.Location = new System.Drawing.Point(319, 106);
            this.flpOrder.Name = "flpOrder";
            this.flpOrder.Size = new System.Drawing.Size(281, 264);
            this.flpOrder.TabIndex = 63;
            // 
            // dgvMenu1
            // 
            this.dgvMenu1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCafe,
            this.name,
            this.idCafeCategory,
            this.price});
            this.dgvMenu1.Location = new System.Drawing.Point(319, 106);
            this.dgvMenu1.Name = "dgvMenu1";
            this.dgvMenu1.Size = new System.Drawing.Size(10, 10);
            this.dgvMenu1.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(356, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐẶT MÓN";
            // 
            // btnUndo
            // 
            this.btnUndo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.Image")));
            this.btnUndo.Location = new System.Drawing.Point(557, 60);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(43, 42);
            this.btnUndo.TabIndex = 75;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click_1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(286, 57);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(43, 42);
            this.btnRefresh.TabIndex = 76;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(606, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 22);
            this.label5.TabIndex = 78;
            this.label5.Text = "Khách Hàng";
            // 
            // cmbKH
            // 
            this.cmbKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKH.FormattingEnabled = true;
            this.cmbKH.Location = new System.Drawing.Point(724, 106);
            this.cmbKH.Name = "cmbKH";
            this.cmbKH.Size = new System.Drawing.Size(132, 27);
            this.cmbKH.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(547, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 79;
            this.label7.Text = "label7";
            // 
            // FrmDatmon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(868, 421);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbKH);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.cmbBan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.s);
            this.Controls.Add(this.cmbNhanVien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnHoaDon);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.txtDateCheckIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lsbThucUong);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.cmbLoaiThucUong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flpOrder);
            this.Controls.Add(this.dgvMenu1);
            this.Controls.Add(this.label1);
            this.Name = "FrmDatmon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDatmon";
            this.Load += new System.EventHandler(this.FrmDatmon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtSoLuong;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.ComboBox cmbBan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.ComboBox cmbNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.TextBox txtDateCheckIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsbThucUong;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.ComboBox cmbLoaiThucUong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewComboBoxColumn idCafeCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCafe;
        private System.Windows.Forms.FlowLayoutPanel flpOrder;
        private System.Windows.Forms.DataGridView dgvMenu1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnUndo;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbKH;
        private System.Windows.Forms.Label label7;

    }
}