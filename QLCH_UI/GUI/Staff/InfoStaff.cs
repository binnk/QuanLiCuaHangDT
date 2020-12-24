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
    public partial class lb_gioitinh : Form
    {
        public lb_gioitinh(string manv,string tennv, string ngaysinh, string gioi_tinh, string sdt, string taikhoan, string email,string dia_chi,string loainhanvien)
        {
            InitializeComponent();
            lb_manv.Text = manv;
            lb_tennv.Text = tennv;
            lb_ngaysinh.Text = ngaysinh;
            lb_gioi_tinh.Text = gioi_tinh;
            lb_sdt.Text = sdt;
            lb_taikhoan.Text = taikhoan;
            lb_email.Text = email;
            lb_diachi.Text = dia_chi;
            lb_loainv.Text = loainhanvien;
        }

        private void icExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_loainv_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
