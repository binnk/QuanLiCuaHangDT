using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH_UI
{
    public partial class UC_ItemOrder : UserControl
    {   
        public string  madh { get; set; }
        public string tenkh { get; set; }
        public string tennv { get; set; }
        public string ngayhd { get; set; }
        public string manv { get; set; }
        public string makh { get; set; }
        public string tri_gia { get; set; }
        public UC_ItemOrder()
        {
            InitializeComponent();
        }

        public void Set_UC()
        {
            lb_madh.Text = madh ;
            lb_ngayhd.Text = ngayhd ;
            lb_manv.Text = tennv ;
            lb_makh.Text = tenkh ;
            lb_trigia.Text = tri_gia;
        }
        private void gunaLabel2_Click(object sender, EventArgs e)
        {
            (new CTHDForm(madh, makh, manv)).ShowDialog();
        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {
            (new CTHDForm(madh, makh, manv)).ShowDialog();
        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {
            (new CTHDForm(madh, makh, manv)).ShowDialog();
        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {
            (new CTHDForm(madh, makh, manv)).ShowDialog();
        }

        private void gunaLabel7_Click(object sender, EventArgs e)
        {
            (new CTHDForm(madh, makh, manv)).ShowDialog();
        }

        private void gunaLinePanel1_Click(object sender, EventArgs e)
        {
            (new CTHDForm(madh, makh, manv)).ShowDialog();
        }
    }
}
