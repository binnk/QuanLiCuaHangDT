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
    public partial class fManageWH : Form
    {
        private string manv;
        public fManageWH(string manvv)
        {
            manv = manvv;
            InitializeComponent();
            loadkho();
        }
        public void loadkho()
        {
            flowLayoutPanel1.Controls.Clear();
            DataTable a = ProductDAO.Instance.Productlist();
            for (int i=0;i<a.Rows.Count;i++)
            {
                int tontai = int.Parse(a.Rows[i]["ton_tai"].ToString());
                if (tontai == 1)
                {
                    UC_itemManageWH item = new UC_itemManageWH(this,manv);
                    item.img = a.Rows[i]["img"].ToString();
                    item.masp = a.Rows[i]["masp"].ToString();
                    item.tensp = a.Rows[i]["ten_sp"].ToString();
                    item.loai = a.Rows[i]["loai_sp"].ToString();
                    item.soluong = a.Rows[i]["so_luong"].ToString();
                    item.gianhap = decimal.Parse(a.Rows[i]["gia_nhap"].ToString());
                    item.giaban = decimal.Parse(a.Rows[i]["gia_ban"].ToString());
                    item.set_UC();
                    flowLayoutPanel1.Controls.Add(item);
                }
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

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            if (tb_search.Text == "") loadkho();
            else
            {
                flowLayoutPanel1.Controls.Clear();
                DataTable a = ProductDAO.Instance.search_product_by_name(tb_search.Text);
                for (int i = 0; i < a.Rows.Count; i++)
                {
                    int tontai = int.Parse(a.Rows[i]["ton_tai"].ToString());
                    if (tontai == 1)
                    {
                        UC_itemManageWH item = new UC_itemManageWH(this,manv);
                        item.img = a.Rows[i]["img"].ToString();
                        item.masp = a.Rows[i]["masp"].ToString();
                        item.tensp = a.Rows[i]["ten_sp"].ToString();
                        item.loai = a.Rows[i]["loai_sp"].ToString();
                        item.soluong = a.Rows[i]["so_luong"].ToString();
                        item.gianhap = decimal.Parse(a.Rows[i]["gia_nhap"].ToString());
                        item.giaban = decimal.Parse(a.Rows[i]["gia_ban"].ToString());
                        item.set_UC();
                        flowLayoutPanel1.Controls.Add(item);
                    }
                }
            }
        }

        private void fManageWH_Resize(object sender, EventArgs e)
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
