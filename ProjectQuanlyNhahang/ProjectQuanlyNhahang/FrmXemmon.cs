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
    public partial class FrmXemmon : DevExpress.XtraEditors.XtraForm
    {
        public FrmXemmon()
        {
            InitializeComponent();
        }
        public FrmXemmon(string a)
        {
            id = a;
            InitializeComponent();
        }
        string id;
        private void FrmXemmon_Load(object sender, EventArgs e)
        {
            labelMa.Text = id;
            LoadData();
        }
        public void LoadData()
        {
            RestaurantManagerDataContext dbs = new RestaurantManagerDataContext();
            int thisRec1 = dbs.HOADONBHs.Where(P => P.MaBan == Convert.ToInt32(id)).ToList().Last().ID;   
            var kq1 =
                 from p in dbs.HOADONBHs
                 where p.ID == thisRec1
                 select p;
            cbbTien.DisplayMember = "TongTien";
            cbbTien.ValueMember = "ID";
            cbbTien.DataSource = kq1;

            int thisRec = dbs.HOADONBHs.Where(P => P.MaBan == Convert.ToInt32(id)).ToList().Last().ID;   
            var AllRecDetail = from t in dbs.CHITIETHDBHs           
                               where t.IDHD == thisRec
                               select new
                               {
                                  t.IDHD,
                                  t.Ngay,
                                  t.SanPham,
                                  t.SoLuong,
                                 
                               };

            GridHoadonBH.DataSource = AllRecDetail.ToList();
            GridHoadonBH.BackgroundColor = Color.White;
        }
    }
}