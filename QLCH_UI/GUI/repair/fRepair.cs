using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH_UI
{
    public partial class fRepair : Form
    {
        private string tinhtrang = "all";
        private string manv;
        public fRepair(string manvv)
        {
            manv = manvv;
            InitializeComponent();
            LoadDonSuaChua("all");

        }

        // hàm xử lí form nhấp nháy
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle = 0x02000000;
                return handleParam;
            }
        }

        public void LoadDonSuaChua(string tinhtrang)
        {
            flowLayoutPanel1.Controls.Clear();
            DataTable sc = DAO.SuachuaDAO.Instance.Load_HDSC(tinhtrang);
            for (int i = 0; i < sc.Rows.Count; i++)
            {
                UC_ItemRepair items = new UC_ItemRepair(this);
                items.MaDon = sc.Rows[i]["masc"].ToString();
                items.NgayNhan = DateTime.Parse(sc.Rows[i]["ngay_nhan"].ToString()).ToString("dd-MM-yyyy");
                items.TenKH = sc.Rows[i]["ten_kh"].ToString();
                items.TenNV = sc.Rows[i]["ten_nv"].ToString();
                items.TinhTrang = sc.Rows[i]["tinh_trang"].ToString();
                items.TriGia = DAO.SuachuaDAO.Instance.Tongtien_SC(items.MaDon);
                DataTable ctsc = DAO.SuachuaDAO.Instance.Load_CTSC(items.MaDon);
                for (int j = 0; j < ctsc.Rows.Count; j++)
                {
                    items.DanhSachLinhKien.Add(ctsc.Rows[j]["ten_sp"].ToString());
                }
                items.setUC();
                flowLayoutPanel1.Controls.Add(items);
            }
           
        }



        private void btnThem_Click_1(object sender, EventArgs e)
        {
            fAddRepair form = new fAddRepair(manv);
            form.ShowDialog();
            LoadDonSuaChua(tinhtrang);
        }

        public void btviewall_Click(object sender, EventArgs e)
        {
            LoadDonSuaChua("all");
            tinhtrang = "all";
        }

        private void btview_chuasua_Click(object sender, EventArgs e)
        {
            LoadDonSuaChua("chuasua");
            tinhtrang = "chuasua";
        }

        private void btview_dangsua_Click(object sender, EventArgs e)
        {
            LoadDonSuaChua("dangsua");
            tinhtrang = "dangsua";
        }

        private void btview_daxong_Click(object sender, EventArgs e)
        {
            LoadDonSuaChua("daxong");
            tinhtrang = "daxong";
        }

        private void btview_thanhtoan_Click(object sender, EventArgs e)
        {
            LoadDonSuaChua("thanhtoan");
            tinhtrang = "thanhtoan";
        }
        private void bt_loi_Click(object sender, EventArgs e)
        {
            LoadDonSuaChua("loi");
            tinhtrang = "loi";
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "") LoadDonSuaChua(tinhtrang);
            else
            {
                flowLayoutPanel1.Controls.Clear();
                DataTable sc = DAO.SuachuaDAO.Instance.search_by_name_KH(guna2TextBox1.Text,tinhtrang);
                for(int i =0; i< sc.Rows.Count; i++)
                {
                    UC_ItemRepair items = new UC_ItemRepair(this);
                    items.MaDon = sc.Rows[i]["masc"].ToString();
                    items.NgayNhan = DateTime.Parse(sc.Rows[i]["ngay_nhan"].ToString()).ToString("dd-MM-yyyy");
                    items.TenKH = sc.Rows[i]["ten_kh"].ToString();
                    items.TenNV = sc.Rows[i]["ten_nv"].ToString();
                    items.TinhTrang = sc.Rows[i]["tinh_trang"].ToString();
                    items.TriGia = DAO.SuachuaDAO.Instance.Tongtien_SC(items.MaDon);
                    DataTable ctsc = DAO.SuachuaDAO.Instance.Load_CTSC(items.MaDon);
                    for (int j = 0; j < ctsc.Rows.Count; j++)
                    {
                        items.DanhSachLinhKien.Add(ctsc.Rows[j]["ten_sp"].ToString());
                    }
                    items.setUC();
                    flowLayoutPanel1.Controls.Add(items);
                }
            }
        }

        private void flowLayoutPanel1_Resize(object sender, EventArgs e)
        {
      
        }

        private void fRepair_Resize(object sender, EventArgs e)
        {
            if (this.panel.Size.Height > 805)
            {
                this.guna2ShadowPanel1.Size = new Size(1600, 800);
            }
            else
            {
                this.guna2ShadowPanel1.Size = new Size(1525, 625);
            }
        }
    }
}
