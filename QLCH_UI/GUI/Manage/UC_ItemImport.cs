using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCH_UI.DAO;
using QLCH_UI.BUS;
namespace QLCH_UI
{
    public partial class UC_ItemImport : UserControl
    {
        public UC_ItemImport(fImportManage parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public string ngaynhap;
        public string mahd;
        //public string manv;
        public decimal tongtien;
        public string masp;
        public string soluong;
        fImportManage _parent;
        public void set_UC()
        {
            lb_ngaynhap.Text = ngaynhap;
            lb_mahd.Text = mahd;
            lb_masp.Text = masp;
            lb_soluong.Text = soluong;
            //lb_manv.Text = manv;
            lb_trigia.Text =Convert.ToDecimal(tongtien).ToString("#,##0");
        }
        private void gunaLinePanel1_MouseEnter(object sender, EventArgs e)
        {
            gunaLinePanel1.BackColor = Color.FromArgb(220, 250, 252);
        }

        private void gunaLinePanel1_MouseLeave(object sender, EventArgs e)
        {
            gunaLinePanel1.BackColor = Color.White;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataTable a = WarehouseDAO.Instance.viewinfoBill(lb_mahd.Text);
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
            (new EditImportProduct(lb_mahd.Text, ten_sp, ma_sp, loai_sp, ngaynhap, soluongg, gia, manguoinhap, anh)).ShowDialog();
            _parent.loadImportManagement();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                // e.Cancel = true;
            }
            else
            {
                DataTable a = WarehouseDAO.Instance.viewinfoBill(mahd);
                string masp = a.Rows[0]["masp"].ToString();
                WareHouseBUS.Instance.delete(mahd, masp);
                _parent.loadImportManagement();
            }
        }
    }
}
