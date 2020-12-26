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
    public partial class UC_itemManageWH : UserControl
    {
        public string img;
        public string masp;
        public string tensp;
        public string loai;
        public string soluong;
        public decimal gianhap;
        public decimal giaban;
        fManageWH _parent;
        public string manv;
        public UC_itemManageWH(fManageWH parent,string manvv)
        {
            manv = manvv;
            InitializeComponent();
            _parent = parent;
        }

        public void set_UC()
        {
            gunaPictureBox1.Image = ProductBUS.Instance.ByteToImg(img);
            lb_masp.Text = masp;
            lb_tensp.Text = tensp;
            lb_loai.Text = loai;
            lb_soluong.Text = soluong;
            lb_gianhap.Text= Convert.ToDecimal(gianhap).ToString("#,##0");
            lb_giaban.Text= Convert.ToDecimal(giaban).ToString("#,##0");
        }

        private void gunaLinePanel1_MouseEnter(object sender, EventArgs e)
        {
            gunaLinePanel1.BackColor = Color.FromArgb(220, 250, 252);
        }

        private void gunaLinePanel1_MouseLeave(object sender, EventArgs e)
        {
            gunaLinePanel1.BackColor = Color.White;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            (new  ImportProducts(masp, tensp, loai, gianhap.ToString(), gunaPictureBox1.Image,manv)).ShowDialog();
            _parent.loadkho();
        }

        private void gunaLinePanel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lb_masp_Click(object sender, EventArgs e)
        {

        }

        private void lb_tensp_Click(object sender, EventArgs e)
        {

        }

        private void lb_loai_Click(object sender, EventArgs e)
        {

        }

        private void lb_soluong_Click(object sender, EventArgs e)
        {

        }

        private void lb_gianhap_Click(object sender, EventArgs e)
        {

        }

        private void lb_giaban_Click(object sender, EventArgs e)
        {

        }
    }
}
