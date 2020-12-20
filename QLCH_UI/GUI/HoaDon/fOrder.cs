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
    public partial class fOrder : Form
    {
        public fOrder()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            flowLayoutPanel1.Controls.Clear();
            DataTable a = DAO.HoadonDAO.Instance.Hoadonlist();
            for (int i = 0; i < a.Rows.Count; i++)
            {
                UC_ItemOrder items = new UC_ItemOrder();
                items.tenkh = a.Rows[i]["ten_kh"].ToString();
                items.tennv = a.Rows[i]["ten_nv"].ToString();
                items.madh = a.Rows[i]["mahd"].ToString();
                items.ngayhd = DateTime.Parse(a.Rows[i]["ngay_ban"].ToString()).ToString("dd-MM-yyyy");
                items.makh = a.Rows[i]["makh"].ToString();
                items.manv = a.Rows[i]["manv"].ToString();
                items.tri_gia = Convert.ToDouble(a.Rows[i]["tri_gia"]).ToString("#,##0");
                items.Set_UC();
                flowLayoutPanel1.Controls.Add(items);
            }
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

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "") Load();
            else
            {
                flowLayoutPanel1.Controls.Clear();
                DataTable a = DAO.HoadonDAO.Instance.Search(guna2TextBox1.Text);
                for (int i = 0; i < a.Rows.Count; i++)
                {
                    UC_ItemOrder items = new UC_ItemOrder();
                    items.tenkh = a.Rows[i]["ten_kh"].ToString();
                    items.tennv = a.Rows[i]["ten_nv"].ToString();
                    items.madh = a.Rows[i]["mahd"].ToString();
                    items.ngayhd = DateTime.Parse(a.Rows[i]["ngay_ban"].ToString()).ToString("dd-MM-yyyy");
                    items.makh = a.Rows[i]["makh"].ToString();
                    items.manv = a.Rows[i]["manv"].ToString();
                    items.tri_gia = Convert.ToDouble(a.Rows[i]["tri_gia"]).ToString("#,##0");
                    items.Set_UC();
                    flowLayoutPanel1.Controls.Add(items);
                }
            }
        }
    }
}
