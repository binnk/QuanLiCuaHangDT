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
    public partial class InfoProduct : Form
    {
        public InfoProduct(string masp,string tensp,string loaisp,string gia,Image anh)
        {
            InitializeComponent();
            lb_masp.Text = masp;
            lb_tensp.Text = tensp;
            lb_loaisp.Text = loaisp;
            lb_giasp.Text = Convert.ToDouble(gia).ToString("#,##0");
            pictureBox1.Image = anh;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void icExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
