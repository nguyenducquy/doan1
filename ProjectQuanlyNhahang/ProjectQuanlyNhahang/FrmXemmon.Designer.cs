namespace ProjectQuanlyNhahang
{
    partial class FrmXemmon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmXemmon));
            this.label1 = new System.Windows.Forms.Label();
            this.labelMa = new System.Windows.Forms.Label();
            this.GridHoadonBH = new System.Windows.Forms.DataGridView();
            this.IDHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbTien = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridHoadonBH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(40, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 42);
            this.label1.TabIndex = 33;
            this.label1.Text = "Mã Bàn :";
            // 
            // labelMa
            // 
            this.labelMa.AutoSize = true;
            this.labelMa.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMa.Location = new System.Drawing.Point(216, 9);
            this.labelMa.Name = "labelMa";
            this.labelMa.Size = new System.Drawing.Size(126, 42);
            this.labelMa.TabIndex = 34;
            this.labelMa.Text = "label2";
            // 
            // GridHoadonBH
            // 
            this.GridHoadonBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridHoadonBH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDHD,
            this.Ngay,
            this.SanPham,
            this.SoLuong});
            this.GridHoadonBH.Location = new System.Drawing.Point(39, 72);
            this.GridHoadonBH.Name = "GridHoadonBH";
            this.GridHoadonBH.Size = new System.Drawing.Size(543, 317);
            this.GridHoadonBH.TabIndex = 35;
            // 
            // IDHD
            // 
            this.IDHD.DataPropertyName = "IDHD";
            this.IDHD.HeaderText = "Mã Hóa Đơn";
            this.IDHD.Name = "IDHD";
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "Ngay";
            this.Ngay.HeaderText = "Ngày ";
            this.Ngay.Name = "Ngay";
            this.Ngay.Width = 150;
            // 
            // SanPham
            // 
            this.SanPham.DataPropertyName = "SanPham";
            this.SanPham.HeaderText = "Sản Phẩm ";
            this.SanPham.Name = "SanPham";
            this.SanPham.Width = 150;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng ";
            this.SoLuong.Name = "SoLuong";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(386, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 36;
            this.label2.Text = "Thành Tiền";
            // 
            // cbbTien
            // 
            this.cbbTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTien.FormattingEnabled = true;
            this.cbbTien.Location = new System.Drawing.Point(476, 26);
            this.cbbTien.Name = "cbbTien";
            this.cbbTien.Size = new System.Drawing.Size(132, 27);
            this.cbbTien.TabIndex = 78;
            // 
            // FrmXemmon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(636, 401);
            this.Controls.Add(this.cbbTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GridHoadonBH);
            this.Controls.Add(this.labelMa);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmXemmon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem Món Ăn";
            this.Load += new System.EventHandler(this.FrmXemmon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridHoadonBH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMa;
        private System.Windows.Forms.DataGridView GridHoadonBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn SanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbTien;

    }
}