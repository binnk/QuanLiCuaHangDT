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
    public partial class fImportManage : Form
    {
        public fImportManage()
        {
            InitializeComponent();
            loadImportManagement();
            //this.flowLayoutPanel1.Controls.Add(new UC_ItemImport());
            //this.flowLayoutPanel1.Controls.Add(new UC_ItemImport());
            //this.flowLayoutPanel1.Controls.Add(new UC_ItemImport());
        }
        public void loadImportManagement()
        {
            flowLayoutPanel1.Controls.Clear();
            DataTable a = WarehouseDAO.Instance.list_nhap_kho();
            for (int i = 0; i < a.Rows.Count; i++)
            {
                UC_ItemImport item = new UC_ItemImport(this);
                item.ngaynhap = DateTime.Parse(a.Rows[i]["ngay_nhap"].ToString()).ToString("dd - MM - yyyy");
                item.mahd = a.Rows[i]["manhaphang"].ToString();
                item.masp = a.Rows[i]["masp"].ToString();
                item.soluong = a.Rows[i]["so_luong"].ToString();
                item.tongtien = decimal.Parse(a.Rows[i]["tong_tien"].ToString());
                item.set_UC();
                flowLayoutPanel1.Controls.Add(item);
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
            if (tb_search.Text == "") loadImportManagement();
            else
            {
                flowLayoutPanel1.Controls.Clear();
                DataTable a = WarehouseDAO.Instance.search_hoadon_by_mahd(tb_search.Text);
                for (int i = 0; i < a.Rows.Count; i++)
                {
                    UC_ItemImport item = new UC_ItemImport(this);
                    item.ngaynhap = DateTime.Parse(a.Rows[i]["ngay_nhap"].ToString()).ToString("dd - MM - yyyy");
                    item.mahd = a.Rows[i]["manhaphang"].ToString();
                    item.masp = a.Rows[i]["masp"].ToString();
                    item.soluong = a.Rows[i]["so_luong"].ToString();
                    item.tongtien = decimal.Parse(a.Rows[i]["tong_tien"].ToString());
                    item.set_UC();
                    flowLayoutPanel1.Controls.Add(item);
                }
            }
        }

        private void fImportManage_Resize(object sender, EventArgs e)
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
