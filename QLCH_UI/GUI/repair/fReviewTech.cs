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
    public partial class fReviewTech : Form
    {
        private string manv;
        public fReviewTech(string manvv)
        {
            manv = manvv;
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            lb_sanpham.Text = DAO.TongquanSC_DAO.Instance.Get_dontrongngay(manv);
            lb_hoadon.Text = DAO.TongquanSC_DAO.Instance.Get_sohoadon(manv);
            lb_doanh_thu.Text = DAO.TongquanSC_DAO.Instance.Get_doanhthu(manv);
            DataTable a = DAO.TongquanSC_DAO.Instance.History(manv);
            for(int  i = 0; i < a.Rows.Count; i++)
            {
                string masc = a.Rows[i]["masc"].ToString();
                string ngay = DateTime.Parse(a.Rows[i]["ngay_nhan"].ToString()).ToString("dd-MM-yyyy");
                string makh = a.Rows[i]["ten_kh"].ToString();
                string trigia = Convert.ToDouble(a.Rows[i]["tri_gia"]).ToString("#,##0");
                dgvOrders.Rows.Add(masc, ngay, makh, trigia);
            }    
        }

        private void fReviewTech_Resize(object sender, EventArgs e)
        {
            if (this.Height > 805)
            {
                this.guna2CustomGradientPanel5.Size = new Size(1600, 695);
            }
            else
            {
                this.guna2CustomGradientPanel5.Size = new Size(1529, 500);
            }
        }
    }
}
