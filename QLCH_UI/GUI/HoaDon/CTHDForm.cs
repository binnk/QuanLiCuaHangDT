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
    public partial class CTHDForm : Form
    {
        public CTHDForm(string mahd,string makh, string manv)
        {
            InitializeComponent();
            Load(mahd, makh, manv);
        }
        private void Load(string mahd, string makh,string manv)
        {
            DataTable kh = DAO.HoadonDAO.Instance.Khach_hang(makh);
                tbma_kh.Text = kh.Rows[0]["makh"].ToString();
                tbten_kh.Text = kh.Rows[0]["ten_kh"].ToString();
                tbdia_chi.Text = kh.Rows[0]["dia_chi"].ToString();
                tb_sdt.Text = kh.Rows[0]["dien_thoai"].ToString();
            DataTable hd = DAO.HoadonDAO.Instance.Hoadon(mahd);
                tbma_hd.Text = hd.Rows[0]["mahd"].ToString();
                tbngay_ban.Text =DateTime.Parse(hd.Rows[0]["ngay_ban"].ToString()).ToString("dd - MM - yyyy");
                lb_giam_gia.Text = "Giảm giá: " + Convert.ToDouble(hd.Rows[0]["giam_gia"]).ToString("#,##0");
                lb_tong_tien.Text = "Tổng tiền: " + Convert.ToDouble(hd.Rows[0]["tri_gia"]).ToString("#,##0");
            DataTable nv = DAO.HoadonDAO.Instance.Nhan_vien(manv);
                tbma_nv.Text = manv;
                tbten_nv.Text = nv.Rows[0]["ten_nv"].ToString();
            DataTable cthd = DAO.HoadonDAO.Instance.CTHD(mahd);
            for (int i = 0; i < cthd.Rows.Count; i++)
            {
                string masp = cthd.Rows[i]["masp"].ToString();
                string tensp = cthd.Rows[i]["ten_sp"].ToString();
                string soluong = cthd.Rows[i]["so_luong"].ToString();
                string dongia =Convert.ToDouble(cthd.Rows[i]["gia_ban"]).ToString("#,##0");
                string thanhtien =(Convert.ToDouble(cthd.Rows[i]["so_luong"])*Convert.ToDouble(cthd.Rows[i]["gia_ban"])).ToString("#,##0");
                dgvCTHD.Rows.Add(masp, tensp, soluong, dongia, thanhtien);
            }
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
