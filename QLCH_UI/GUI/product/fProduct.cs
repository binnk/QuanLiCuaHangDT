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
                    flowLayoutPanel1.Controls.Add(item);
                }
            }    
        }
        public fProduct()
        {
            InitializeComponent();
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
                        flowLayoutPanel1.Controls.Add(item);
                    }
                }
            }
        }
    }
}
