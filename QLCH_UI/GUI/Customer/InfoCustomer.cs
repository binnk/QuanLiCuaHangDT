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
    public partial class InfoCustomer : Form
    {
        public InfoCustomer(string makh,string tenkh,string STD,string diachi, string ngaysinh,string gioitinh)
        {
         

            InitializeComponent();
            string d="", m="", y="";
            int l = ngaysinh.Length;
            int dd = 0;
            for (int i = 0; i < l; i++)
            {
                if (ngaysinh[i] == ' ') break;
                if (ngaysinh[i] == '/') dd ++;
                else
                {
                    if (dd == 0) m = m + ngaysinh[i];
                    if (dd == 1) d = d + ngaysinh[i];
                    if (dd == 2) y = y + ngaysinh[i];
                }
            }
            string kq = d + '/' + m + '/' + y;
            lb_makh.Text = makh;
            lb_tenkh.Text = tenkh;
            lb_ngaysinh.Text = kq;
            lb_diachi.Text = diachi;
            lb_gioitinh.Text = gioitinh;
            lb_SDT.Text = STD;
        }

        private void icExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
