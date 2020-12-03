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
        public lb_gioitinh(string manv,string tennv, string ngaysinh, string gioi_tinh, string sdt, string taikhoan, string email)
        {
            InitializeComponent();
            string d = "", m = "", y = "";
            int l = ngaysinh.Length;
            int dd = 0;
            for (int i = 0; i < l; i++)
            {
                if (ngaysinh[i] == ' ') break;
                if (ngaysinh[i] == '/') dd++;
                else
                {
                    if (dd == 0) m = m + ngaysinh[i];
                    if (dd == 1) d = d + ngaysinh[i];
                    if (dd == 2) y = y + ngaysinh[i];
                }
            }
            string kq = d + '/' + m + '/' + y;
            lb_manv.Text = manv;
            lb_tennv.Text = tennv;
            lb_ngaysinh.Text = kq;
            lb_gioi_tinh.Text = gioi_tinh;
            lb_sdt.Text = sdt;
            lb_taikhoan.Text = taikhoan;
            lb_email.Text = email;
        }

        private void icExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
