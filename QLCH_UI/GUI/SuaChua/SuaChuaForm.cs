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
    public partial class SuaChuaForm : Form
    {
        public SuaChuaForm()
        {
            InitializeComponent();
            LoadDonSuaChua();

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

        public void LoadDonSuaChua()
        {
            UC_ItemNhanSuaChua items = new UC_ItemNhanSuaChua();
            items.MaDon = "MD01";
            items.NgayNhan = "03/07/2020";
            items.TenKH = "Pham Tan Khang";
            items.TenNV = "Pham Minh Triet";
            items.DanhSachLinhKien.Add("Man hinh samsung");
            items.DanhSachLinhKien.Add("Pin samsung");
            items.DanhSachLinhKien.Add("Sac samsung");
            items.DanhSachLinhKien.Add("Main samsung");
            items.setUC();

            UC_ItemNhanSuaChua item2 = new UC_ItemNhanSuaChua();
            item2.MaDon = "MD02";
            item2.NgayNhan = "19/07/2020";
            item2.TenKH = "Pham Tan Khang";
            item2.TenNV = "Bui Minh Huy";
            item2.DanhSachLinhKien.Add("Man hinh samsung");
            item2.DanhSachLinhKien.Add("Pin samsung");
            item2.setUC();
            flowLayoutPanel1.Controls.Add(items);
            flowLayoutPanel1.Controls.Add(item2);

            UC_ItemNhanSuaChua item3 = new UC_ItemNhanSuaChua();
            item3.MaDon = "MD02";
            item3.NgayNhan = "19/07/2020";
            item3.TenKH = "Pham Tan Khang";
            item3.TenNV = "Bui Minh Huy";
            item3.DanhSachLinhKien.Add("Man hinh samsung");
            item3.DanhSachLinhKien.Add("Pin samsung");
            item3.setUC();
            flowLayoutPanel1.Controls.Add(items);
            flowLayoutPanel1.Controls.Add(item2);
        }



        private void btnThem_Click_1(object sender, EventArgs e)
        {
            fThemDonSuaChua form = new fThemDonSuaChua();
            form.ShowDialog();
        }
    }
}
