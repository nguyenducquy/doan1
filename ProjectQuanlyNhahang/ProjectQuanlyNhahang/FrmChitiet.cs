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
    public partial class FrmChitiet : DevExpress.XtraEditors.XtraForm
    {
        public FrmChitiet(string benngoai)
        {
            BiennhantuF1 = benngoai;
            InitializeComponent();
        }
        string BiennhantuF1;
        private void FrmChitiet_Load(object sender, EventArgs e)
        {
            LbMa.Text = BiennhantuF1;
            LoadData();
        }
        public delegate void KieuDulieuTruyenRa(string a);
        public KieuDulieuTruyenRa cc;
        public void LoadData()
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            var kq =
               from p in dbs.CHITIETHDBHs //chọn những nvách hàng trong bảng nvách hàng
               where p.IDHD == Convert.ToInt32(LbMa.Text)
               select new
               {
                   p.IDHD,
                   p.Ngay,
                   p.SanPham,
                   p.SoLuong,
               };

            GridHoadonBH.DataSource = kq;
            //GridHoadonBH_CellClick(null, null);
        }
    }
}