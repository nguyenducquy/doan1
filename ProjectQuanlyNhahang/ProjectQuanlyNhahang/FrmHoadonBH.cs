using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace ProjectQuanlyNhahang
{
    public partial class FrmHoadonBH : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmHoadonBH()
        {
            InitializeComponent();
        }
        string BiennhanF2;
        private void FrmHoadonBH_Load(object sender, EventArgs e)
        {
            LoadData();
            //GridHoadonBH_CellClick(null, null);
        }
        public void LoadData()
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            var kq =
               from p in dbs.HOADONBHs //chọn những nvách hàng trong bảng nvách hàng 
               select new
               {
                   p.ID,
                   p.MaNV,
                   p.MaBan,
                   p.MaKH,
               };

            GridHoadonBH.DataSource = kq;
            //GridHoadonBH_CellClick(null, null);
        }

        private void btnHoadon1_ItemClick(object sender, ItemClickEventArgs e)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            var kq =
               from p in dbs.HOADONBHs
               where p.TrangThai == false
               select new
               {
                   p.ID,
                   p.MaNV,
                   p.MaBan,
                   p.MaKH,
               };

            GridHoadonBH.DataSource = kq;
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            var kq =
               from p in dbs.HOADONBHs
               where p.TrangThai == true
               select new
               {
                   p.ID,
                   p.MaNV,
                   p.MaBan,
                   p.MaKH,
               };

            GridHoadonBH.DataSource = kq;
        }

        private void btnChitiet_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmChitiet f2 = new FrmChitiet(textBox2.Text);
            //f2.cc = new FrmChitiet.KieuDulieuTruyenRa(nhancc);
            f2.ShowDialog();
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            int r = GridHoadonBH.CurrentCell.RowIndex;
            string strID = GridHoadonBH.Rows[r].Cells[0].Value.ToString();
            HOADONBH kh = dbs.HOADONBHs.Single(p => p.ID.ToString() == strID);
            dbs.SubmitChanges();
            LoadData();
        }
        public void nhancc(string b)
        {
            BiennhanF2 = b;
            textBox2.Text = BiennhanF2;
        }
        private void GridHoadonBH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = GridHoadonBH.CurrentCell.RowIndex;
            textBox2.Text = GridHoadonBH.Rows[r].Cells[0].Value.ToString();
        }
    }
}