using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectQuanlyNhahang
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int isAdmin;  
        public void kiemTra()   //ham nay vua kiem tra tai khoan va mat khau  + truyen tai khoan, mat khau, quyen vao form main de phan quyen truy cap
        {
            try
            {
                string user = txtTenDangNhap.Text.Trim();
                string password = txtMatKhau.Text.Trim();
                // lay ra tai khoan trung voi txtTenDangNhap
                RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
                var kq =
                    from p in dbs.TAIKHOANs
                    where dbs.TAIKHOANs.Where(cls => cls.TenDangNhap == user & cls.TrangThai==true).Any()
                    select p;

                string pass = kq.ToList().FirstOrDefault(p=>p.TenDangNhap==txtTenDangNhap.Text).MatKhau;
                // lay mat khau tu ten dang nhap


                int role = Convert.ToInt32(kq.ToList().FirstOrDefault(p => p.TenDangNhap == txtTenDangNhap.Text).LoaiTK);        // lay quyen truy cap

                if (pass == txtMatKhau.Text)        // neu mat khau trung voi database
                {
                    // kiem tra quyen admin (1) ; nhan vien(0)
                    if (role == 4)
                    {
                        isAdmin = 4;
                    }
                    if(role==3)
                    {
                        isAdmin = 3;
                    }
                    if (role == 2)
                    {
                        isAdmin = 2;
                    }
                    if (role == 1)
                    {
                        isAdmin = 1;
                    }
                    this.Hide();
                    FrmMain m = new FrmMain(txtTenDangNhap.Text, txtMatKhau.Text, isAdmin);// khoi tao form co truyen tham so
                    m.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Tài khoản không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void dangki()
        {
            string tk = txtTK.Text.Trim();
            string mk = txtMK.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string ten = txtTen.Text.Trim();
            // lay ra tai khoan trung voi txtTenDangNhap
           
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            TAIKHOAN nv = new TAIKHOAN();// bang nhan vien
                //nv.nhanvienid = id;
                nv.TenDangNhap = tk;
                nv.MatKhau = mk;
                nv.NgayDangKi = DateTime.Now;
                nv.SoDienThoai = sdt;
                nv.HoTen = ten;
                nv.TrangThai = true;
                dbs.TAIKHOANs.InsertOnSubmit(nv);
                dbs.SubmitChanges();
                MessageBox.Show("Thêm thành công ! Hãy Liên Hệ Quản Lý Để Được Cấp Quyền", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

         }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmLogin.ActiveForm.Visible = true;
            kiemTra();
           
            
        }

        private void btnLogin_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtTenDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMatKhau.Focus();
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(null, null);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            FrmQuenMK quen = new FrmQuenMK();
            quen.ShowDialog();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            dangki();
             txtTK.ResetText();
             txtMK.ResetText();
             txtSDT.ResetText();
             txtTen.ResetText();
        }
    }
}
