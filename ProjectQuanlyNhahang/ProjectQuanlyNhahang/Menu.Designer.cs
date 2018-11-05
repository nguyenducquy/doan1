namespace ProjectQuanlyNhahang
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.panelMonan = new DevExpress.XtraEditors.PanelControl();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioTen = new System.Windows.Forms.RadioButton();
            this.radioID = new System.Windows.Forms.RadioButton();
            this.txtMamon = new System.Windows.Forms.RichTextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenmon = new System.Windows.Forms.RichTextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDongia = new System.Windows.Forms.RichTextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.ID_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMON_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hinh = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelMonan)).BeginInit();
            this.panelMonan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 45);
            this.label1.TabIndex = 32;
            this.label1.Text = "Danh Sách Thực Đơn";
            // 
            // panelMonan
            // 
            this.panelMonan.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelMonan.Appearance.Options.UseBackColor = true;
            this.panelMonan.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.panelMonan.Controls.Add(this.radioButton2);
            this.panelMonan.Controls.Add(this.radioTen);
            this.panelMonan.Controls.Add(this.radioID);
            this.panelMonan.Controls.Add(this.txtMamon);
            this.panelMonan.Controls.Add(this.labelControl4);
            this.panelMonan.Controls.Add(this.txtTenmon);
            this.panelMonan.Controls.Add(this.labelControl1);
            this.panelMonan.Controls.Add(this.txtDongia);
            this.panelMonan.Controls.Add(this.labelControl2);
            this.panelMonan.Location = new System.Drawing.Point(123, 67);
            this.panelMonan.Name = "panelMonan";
            this.panelMonan.Size = new System.Drawing.Size(405, 133);
            this.panelMonan.TabIndex = 31;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(20, 84);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(107, 17);
            this.radioButton2.TabIndex = 39;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tìm Kiếm Đơn Giá";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioTen
            // 
            this.radioTen.AutoSize = true;
            this.radioTen.Location = new System.Drawing.Point(20, 48);
            this.radioTen.Name = "radioTen";
            this.radioTen.Size = new System.Drawing.Size(110, 17);
            this.radioTen.TabIndex = 38;
            this.radioTen.TabStop = true;
            this.radioTen.Text = "Tìm Kiếm Tên Món";
            this.radioTen.UseVisualStyleBackColor = true;
            this.radioTen.CheckedChanged += new System.EventHandler(this.radioTen_CheckedChanged);
            // 
            // radioID
            // 
            this.radioID.AutoSize = true;
            this.radioID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radioID.Location = new System.Drawing.Point(20, 15);
            this.radioID.Name = "radioID";
            this.radioID.Size = new System.Drawing.Size(106, 17);
            this.radioID.TabIndex = 37;
            this.radioID.TabStop = true;
            this.radioID.Text = "Tìm Kiếm Mã Món";
            this.radioID.UseVisualStyleBackColor = false;
            this.radioID.CheckedChanged += new System.EventHandler(this.radioID_CheckedChanged);
            // 
            // txtMamon
            // 
            this.txtMamon.Location = new System.Drawing.Point(232, 13);
            this.txtMamon.Name = "txtMamon";
            this.txtMamon.Size = new System.Drawing.Size(154, 26);
            this.txtMamon.TabIndex = 26;
            this.txtMamon.Text = "";
            this.txtMamon.TextChanged += new System.EventHandler(this.txtMamon_TextChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(146, 15);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(80, 18);
            this.labelControl4.TabIndex = 27;
            this.labelControl4.Text = "Mã Món Ăn";
            // 
            // txtTenmon
            // 
            this.txtTenmon.Location = new System.Drawing.Point(232, 45);
            this.txtTenmon.Name = "txtTenmon";
            this.txtTenmon.Size = new System.Drawing.Size(154, 26);
            this.txtTenmon.TabIndex = 16;
            this.txtTenmon.Text = "";
            this.txtTenmon.TextChanged += new System.EventHandler(this.txtTenmon_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(146, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 18);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "Tên Món";
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(232, 83);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(154, 26);
            this.txtDongia.TabIndex = 19;
            this.txtDongia.Text = "";
            this.txtDongia.TextChanged += new System.EventHandler(this.txtDongia_TextChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(146, 82);
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
            this.dgvMenu.Location = new System.Drawing.Point(22, 206);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.Size = new System.Drawing.Size(587, 369);
            this.dgvMenu.TabIndex = 30;
            // 
            // ID_
            // 
            this.ID_.DataPropertyName = "ID";
            this.ID_.HeaderText = "Mã Món";
            this.ID_.Name = "ID_";
            // 
            // TENMON_
            // 
            this.TENMON_.DataPropertyName = "TenSP";
            this.TENMON_.HeaderText = "Tên Món";
            this.TENMON_.Name = "TENMON_";
            this.TENMON_.Width = 150;
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
            this.Hinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Hinh.Width = 175;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(631, 607);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelMonan);
            this.Controls.Add(this.dgvMenu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelMonan)).EndInit();
            this.panelMonan.ResumeLayout(false);
            this.panelMonan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelMonan;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioTen;
        private System.Windows.Forms.RadioButton radioID;
        private System.Windows.Forms.RichTextBox txtMamon;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.RichTextBox txtTenmon;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.RichTextBox txtDongia;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMON_;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA_;
        private System.Windows.Forms.DataGridViewImageColumn Hinh;

    }
}