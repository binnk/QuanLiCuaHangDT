using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCH_UI.DAO;
using QLCH_UI.BUS;

namespace QLCH_UI
{
    public partial class fProduct : Form
    {
        private string manv;
        int d = 0;
        public void loadproduct()
        {
            flowLayoutPanel1.Controls.Clear();
            DataTable a = ProductDAO.Instance.Productlist();
            for (int i=0;i<a.Rows.Count;i++)
            {
                UC_ItemProduct item = new UC_ItemProduct(this);
                int ton_tai = int.Parse(a.Rows[i]["ton_tai"].ToString());
                if (ton_tai == 1)
                {
                    item.masp = a.Rows[i]["masp"].ToString();
                    item.tensp = a.Rows[i]["ten_sp"].ToString();
                    item.loaisp = a.Rows[i]["loai_sp"].ToString();
                    item.soluong = int.Parse(a.Rows[i]["so_luong"].ToString());
                    item.gianhap = double.Parse(a.Rows[i]["gia_nhap"].ToString());
                    item.giaban = double.Parse(a.Rows[i]["gia_ban"].ToString());
                    item.img = a.Rows[i]["img"].ToString();
                    item.set_UC();
                    if (d == 0) flowLayoutPanel1.Controls.Add(item);
                    if (d == 2 && item.loaisp != "Linh kiện") flowLayoutPanel1.Controls.Add(item);
                    if (d == 1 && item.loaisp == "Linh kiện") flowLayoutPanel1.Controls.Add(item);
                }
            }    
        }
        public fProduct(string manvv)
        {
            manv = manvv;
            InitializeComponent();
            DataTable p = StaffDAO.Instance.ViewStaff(manv);
            string loainv = p.Rows[0]["loainhanvien"].ToString();
            if (loainv == "admin") d = 0;
            if (loainv == "Kỹ thuật") d = 1;
            if (loainv == "Bán hàng") d = 2;
            loadproduct();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle = 0x02000000;
                return handleParam;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            (new AddProduct()).ShowDialog();
            loadproduct();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (tb_search.Text == "") loadproduct();
            else
            {
                flowLayoutPanel1.Controls.Clear();
                DataTable a = ProductDAO.Instance.search_product_by_name(tb_search.Text);
                for (int i = 0; i < a.Rows.Count; i++)
                {
                    UC_ItemProduct item = new UC_ItemProduct(this);
                    int ton_tai = int.Parse(a.Rows[i]["ton_tai"].ToString());
                    if (ton_tai == 1)
                    {
                        item.masp = a.Rows[i]["masp"].ToString();
                        item.tensp = a.Rows[i]["ten_sp"].ToString();
                        item.loaisp = a.Rows[i]["loai_sp"].ToString();
                        item.soluong = int.Parse(a.Rows[i]["so_luong"].ToString());
                        item.gianhap = double.Parse(a.Rows[i]["gia_nhap"].ToString());
                        item.giaban = double.Parse(a.Rows[i]["gia_ban"].ToString());
                        item.img = a.Rows[i]["img"].ToString();
                        item.set_UC();
                        //flowLayoutPanel1.Controls.Add(item);
                        if (d == 0) flowLayoutPanel1.Controls.Add(item);
                        if (d == 2 && item.loaisp != "Linh kiện") flowLayoutPanel1.Controls.Add(item);
                        if (d == 1 && item.loaisp == "Linh kiện") flowLayoutPanel1.Controls.Add(item);
                    }
                }
            }
        }

        private void btnThem_Resize(object sender, EventArgs e)
        {
            if (this.panel.Size.Height > 805)
            {
                this.guna2ShadowPanel1.Size = new Size(1600, 825);
            }
            else
            {
                this.guna2ShadowPanel1.Size = new Size(1525, 653);
            }
        }

        private void flowLayoutPanel1_Resize(object sender, EventArgs e)
        {

        }

        private void fProduct_Resize(object sender, EventArgs e)
        {
            if (this.panel.Size.Height > 805)
            {
                this.guna2ShadowPanel1.Size = new Size(1600, 825);
            }
            else
            {
                this.guna2ShadowPanel1.Size = new Size(1525, 653);
            }
        }
    }
}
