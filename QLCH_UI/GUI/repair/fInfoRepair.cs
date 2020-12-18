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
    public partial class fInfoRepair : Form
    {
        public fInfoRepair(string masc)
        {
            InitializeComponent();
            Load(masc);
        }
        private void Load(string masc)
        {
           DataTable infor = DAO.SuachuaDAO.Instance.Load_InforSC(masc);
            if (infor.Rows.Count != 1)
                return;
            lb_tenkh.Text = infor.Rows[0]["ten_kh"].ToString();
            lb_sdtkh.Text = infor.Rows[0]["dien_thoai"].ToString();
            lb_diachi.Text = infor.Rows[0]["dia_chi"].ToString();
            lb_ngaynhan.Text = DateTime.Parse(infor.Rows[0]["ngay_nhan"].ToString()).ToString("dd-MM-yyyy");
            if(infor.Rows[0]["tinh_trang"].ToString() == "thanhtoan")
            lb_ngaygiao.Text = DateTime.Parse(infor.Rows[0]["ngay_giao"].ToString()).ToString("dd-MM-yyyy");
            lb_tiensua.Text = DAO.SuachuaDAO.Instance.Tongtien_SC(masc);
            lb_madon.Text = masc;
            lb_tensp.Text = infor.Rows[0]["ten_sp"].ToString();
            lb_loaisp.Text = infor.Rows[0]["loai_sp"].ToString();
            lb_ghichu.Text = infor.Rows[0]["ghi_chu"].ToString();
            DataTable ct = DAO.SuachuaDAO.Instance.Load_CTSC(masc);
            for (int i =0; i < ct.Rows.Count; i++)
            {
                lb_linhkien.Text = lb_linhkien.Text + " " + ct.Rows[i]["ten_sp"].ToString();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
