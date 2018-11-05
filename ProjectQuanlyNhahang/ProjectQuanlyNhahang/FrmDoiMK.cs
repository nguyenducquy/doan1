using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ProjectQuanlyNhahang
{
    public partial class FrmDoiMK : DevExpress.XtraEditors.XtraForm
    {
        public FrmDoiMK()
        {
            InitializeComponent();
        }
        public FrmDoiMK(string t,string pass)
        {
            TK = t;
            password = pass;
            InitializeComponent();
        }
        string TK;
        string password;
        private void FrmDoiMK_Load(object sender, EventArgs e)
        {
            txtUser.Text = TK;
            txtPass.Text = password;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtNew.Text == txtXM.Text && txtNew.Text !=txtPass.Text)
            {
                RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
                TAIKHOAN nv = dbs.TAIKHOANs.FirstOrDefault(p => p.TenDangNhap == txtUser.Text);
                nv.MatKhau = txtNew.Text;
                MessageBox.Show("Đã cập nhật !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbs.SubmitChanges();
            }
            else
            {
               MessageBox.Show("Kiểm tra lại mật khẩu vừa nhập !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               txtNew.ResetText();
               txtXM.ResetText();
               txtNew.Focus();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}