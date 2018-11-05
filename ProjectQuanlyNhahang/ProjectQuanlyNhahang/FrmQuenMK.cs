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
    public partial class FrmQuenMK : DevExpress.XtraEditors.XtraForm
    {
        public FrmQuenMK()
        {
            InitializeComponent();
        }

        private void btnlmk_Click(object sender, EventArgs e)
        {
             if (txtsdt.Text == "")

            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông Báo",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsdt.ResetText();
                txtsdt.Focus();
            }
            else
            {
                RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
                {
                    string MK = "";
                    var kq = from p in dbs.TAIKHOANs
                             where p.SoDienThoai == txtsdt.Text
                             select new
                             {
                                 p.MatKhau
                             };

                    if (kq.ToArray().Length > 0)
                    {
                        MK = kq.ToArray()[0].MatKhau;
                    }
                    if (MK != "")
                    {
                        DialogResult tl =
                      MessageBox.Show("Mật khẩu của quý khách: " + " " + MK, "Thông Báo", MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
                        if (tl == DialogResult.OK)
                        {
                            DialogResult tl1 =
                                MessageBox.Show("Bạn có muốn đăng nhập!", "Thông báo",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (tl1 == DialogResult.Yes)
                            {
                                Hide();
                                Form frmlg = new FrmLogin();
                                frmlg.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Số điện thoại không tồn tại", "Thông Báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                        txtsdt.ResetText();
                        txtsdt.Focus();
                    }
                }

            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            DialogResult tl =
                MessageBox.Show("Bạn có hủy bỏ!", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (tl == DialogResult.Yes)
                            this.Close();
        }

        private void FrmQuenMK_Load(object sender, EventArgs e)
        {

        }
    }
}