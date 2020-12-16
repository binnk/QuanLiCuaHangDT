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
using System.Data;
namespace QLCH_UI
{
    public partial class ImportManagementForm : Form
    {
        public ImportManagementForm()
        {
            InitializeComponent();
            loadImportManagement();
        }
        public void loadImportManagement()
        {
            
            DataTable a = WarehouseDAO.Instance.list_nhap_kho();
            dgvImportManagement.Rows.Clear();
            for (int i=0;i<a.Rows.Count;i++)
            {
                string ngaynhap = a.Rows[i]["ngay_nhap"].ToString();
                int l = ngaynhap.Length;
                string ngay_nhap="";
                for (int j=0;j<l;j++)
                {
                    if (ngaynhap[j] == ' ') break;
                    ngay_nhap = ngay_nhap + ngaynhap[j];
                }
                string manguoinhap = a.Rows[i]["manguoinhap"].ToString();
                string mahoadon = a.Rows[i]["manhaphang"].ToString();
                decimal tongtien = decimal.Parse(a.Rows[i]["tong_tien"].ToString());
                string tong_tien = Convert.ToDecimal(tongtien).ToString("#,##0");
                dgvImportManagement.Rows.Add(ngay_nhap, manguoinhap, mahoadon, tong_tien);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (dgvImportManagement.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvImportManagement.SelectedRows[0];
                string mahd = row.Cells[2].Value.ToString();
                DataTable a = WarehouseDAO.Instance.viewinfoBill(mahd);
                string ma_sp = a.Rows[0]["masp"].ToString();
                string ten_sp = a.Rows[0]["ten_sp"].ToString();
                string loai_sp = a.Rows[0]["loai_sp"].ToString();
                string gia = a.Rows[0]["gia_nhap"].ToString();
                string ngay_nhap = a.Rows[0]["ngay_nhap"].ToString();
                DateTime ngaynhap = DateTime.Parse(ngay_nhap);
                DataTable b = ProductDAO.Instance.viewinfo(ma_sp);
                Image anh = ProductBUS.Instance.ByteToImg(b.Rows[0]["img"].ToString());
                int soluongg = int.Parse(a.Rows[0]["so_luong"].ToString());
                string manguoinhap = a.Rows[0]["manguoinhap"].ToString();
                EditImportProduct f = new EditImportProduct(mahd, ten_sp, ma_sp,loai_sp,ngaynhap, soluongg, gia, manguoinhap, anh);
                f.ShowDialog();
                loadImportManagement();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvImportManagement.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvImportManagement.SelectedRows[0];
                string mahd = row.Cells[2].Value.ToString();
                DataTable a = WarehouseDAO.Instance.viewinfoBill(mahd);
                string masp = a.Rows[0]["masp"].ToString();
                WareHouseBUS.Instance.delete(mahd, masp);
                loadImportManagement();
            }
        }
    }
}
