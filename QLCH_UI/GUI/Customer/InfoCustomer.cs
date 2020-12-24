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
           
            lb_makh.Text = makh;
            lb_tenkh.Text = tenkh;
            lb_ngaysinh.Text = ngaysinh;
            lb_diachi.Text = diachi;
            lb_gioitinh.Text = gioitinh;
            lb_SDT.Text = STD;
        }

        private void icExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
