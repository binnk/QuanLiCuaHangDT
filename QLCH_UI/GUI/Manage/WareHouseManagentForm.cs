using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCH_UI.BUS;
using QLCH_UI.DAO;
using QLCH_UI.DTO;

namespace QLCH_UI
{
    public partial class WareHouseManagentForm : Form
    {
        public WareHouseManagentForm()
        {
            InitializeComponent();
            load_kho();
        }
        public void load_kho()
        {
            dgvProducts.Rows.Clear();
            DataTable a = ProductDAO.Instance.Productlist();
            for (int i=0;i<a.Rows.Count;i++)
            {
                string img = a.Rows[i]["img"].ToString();
                string masp = a.Rows[i]["masp"].ToString();
                string tensp = a.Rows[i]["ten_sp"].ToString();
                string loai = a.Rows[i]["loai_sp"].ToString();
                string soluong = a.Rows[i]["so_luong"].ToString();
                double gianhap = double.Parse(a.Rows[i]["gia_nhap"].ToString());
                string gia_nhap = Convert.ToDouble(gianhap).ToString("#,##0");
                double giaban = double.Parse(a.Rows[i]["gia_ban"].ToString());
                string gia_ban = Convert.ToDouble(giaban).ToString("#,##0");
                Image imgg = ProductBUS.Instance.ByteToImg(img);
                dgvProducts.Rows.Add(imgg, masp, tensp, loai, soluong, gia_nhap, gia_ban);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvProducts.SelectedRows[0];
                string masp = row.Cells[1].Value.ToString();
                DataTable a = ProductDAO.Instance.viewinfo(masp);
                string ma_sp = a.Rows[0]["masp"].ToString();
                string ten_sp = a.Rows[0]["ten_sp"].ToString();
                string loai_sp = a.Rows[0]["loai_sp"].ToString();
                string gia = a.Rows[0]["gia_nhap"].ToString();
                Image anh = ProductBUS.Instance.ByteToImg(a.Rows[0]["img"].ToString());
                ImportProducts f = new ImportProducts(ma_sp, ten_sp, loai_sp, gia, anh);
                f.ShowDialog();
                load_kho();
            }
        }
    }
}
