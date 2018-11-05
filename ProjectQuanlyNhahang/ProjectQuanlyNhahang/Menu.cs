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
    public partial class FrmMenu : DevExpress.XtraEditors.XtraForm
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void LoadData()
        {
            txtDongia.Enabled = false;
            txtMamon.Enabled = false;
            txtTenmon.Enabled = false;
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            var kq =
               from p in dbs.SANPHAMs //chọn những khách hàng trong bảng khách hàng 
               where p.TrangThai ==true
               select new
               {
                   p.ID,
                   p.TenSP,
                   p.DonGia,
               };
            dgvMenu.DataSource = kq;
        }
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void radioID_CheckedChanged(object sender, EventArgs e)
        {
           
            txtMamon.ResetText();
            txtTenmon.ResetText();
            txtDongia.ResetText();

            txtDongia.Enabled = false;
            txtMamon.Enabled = true;
            txtTenmon.Enabled = false;
    
        }

        private void radioTen_CheckedChanged(object sender, EventArgs e)
        {
            txtMamon.ResetText();
            txtTenmon.ResetText();
            txtDongia.ResetText();

            txtDongia.Enabled = false;
            txtMamon.Enabled = false;
            txtTenmon.Enabled = true;
    
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtMamon.ResetText();
            txtTenmon.ResetText();
            txtDongia.ResetText();

            txtDongia.Enabled = true;
            txtMamon.Enabled = false;
            txtTenmon.Enabled = false;
    
        }

        private void txtMamon_TextChanged(object sender, EventArgs e)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            try
            {
                var kq1 =
                   from p in dbs.SANPHAMs 
                   where p.ID == Convert.ToInt32(txtMamon.Text) && p.TrangThai == true
                   select new
                   {
                       p.ID,
                       p.TenSP,
                       p.DonGia,
                       p.Hinh,
                       
                   };

                dgvMenu.DataSource = kq1;
            }
            catch
            {
                DialogResult tl = MessageBox.Show("Xin mời nhập lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                if (tl == DialogResult.OK)
                    LoadData();
            }
        }

        private void txtTenmon_TextChanged(object sender, EventArgs e)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            var kq1 =
                  from p in dbs.SANPHAMs
                  where p.TenSP.StartsWith(txtTenmon.Text) && p.TrangThai == true
                  select new
                  {
                      p.ID,
                      p.TenSP,
                      p.DonGia,
                      p.Hinh,

                  };

            dgvMenu.DataSource = kq1;
        }

        private void txtDongia_TextChanged(object sender, EventArgs e)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            var kq1 =
               from p in dbs.SANPHAMs
               where p.DonGia < Convert.ToInt32(txtDongia.Text) && p.TrangThai == true
               select new
               {
                   p.ID,
                   p.TenSP,
                   p.DonGia,
                   p.Hinh,
               };

            dgvMenu.DataSource = kq1;
        }
    }
}