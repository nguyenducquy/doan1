namespace ProjectQuanlyNhahang
{
    partial class FrmChitiet
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
            this.label1 = new System.Windows.Forms.Label();
            this.GridHoadonBH = new System.Windows.Forms.DataGridView();
            this.IDHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.LbMa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridHoadonBH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "CHI TIẾT HÓA ĐƠN:";
            // 
            // GridHoadonBH
            // 
            this.GridHoadonBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridHoadonBH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDHD,
            this.Ngay,
            this.SanPham,
            this.SoLuong,
            this.TongTien});
            this.GridHoadonBH.Location = new System.Drawing.Point(43, 59);
            this.GridHoadonBH.Name = "GridHoadonBH";
            this.GridHoadonBH.Size = new System.Drawing.Size(543, 317);
            this.GridHoadonBH.TabIndex = 4;
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
            // 
            // SanPham
            // 
            this.SanPham.DataPropertyName = "SanPham";
            this.SanPham.HeaderText = "Sản Phẩm ";
            this.SanPham.Name = "SanPham";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng ";
            this.SoLuong.Name = "SoLuong";
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng Tiền ";
            this.TongTien.Name = "TongTien";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(448, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 39);
            this.label2.TabIndex = 6;
            // 
            // LbMa
            // 
            this.LbMa.AutoSize = true;
            this.LbMa.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMa.Location = new System.Drawing.Point(424, 12);
            this.LbMa.Name = "LbMa";
            this.LbMa.Size = new System.Drawing.Size(115, 39);
            this.LbMa.TabIndex = 7;
            this.LbMa.Text = "label3";
            // 
            // FrmChitiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 391);
            this.Controls.Add(this.LbMa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridHoadonBH);
            this.Name = "FrmChitiet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHI TIẾT HÓA ĐƠN";
            this.Load += new System.EventHandler(this.FrmChitiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridHoadonBH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridHoadonBH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn SanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
    }
}