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
    public partial class UC_ItemCustomer : UserControl
    {
        public UC_ItemCustomer()
        {
            InitializeComponent();
        }
        //edit
        private void btnEdit_Click(object sender, EventArgs e)
        {
            (new EditCustomer("","",(DateTime.Now),"","","")).ShowDialog();
        }
        //xoa
        private void gunaButton3_Click(object sender, EventArgs e)
        {
            // Xóa SQL
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {
            (new InfoCustomer("", "", "", "", "", "")).ShowDialog();
        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {
            (new InfoCustomer("", "", "", "", "", "")).ShowDialog();
        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {
            (new InfoCustomer("", "", "", "", "", "")).ShowDialog();
        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {
           (new InfoCustomer("", "", "", "", "", "")).ShowDialog();
        }

        private void gunaLabel7_Click(object sender, EventArgs e)
        {
            (new InfoCustomer("", "", "", "", "", "")).ShowDialog();
        }

        private void gunaLinePanel1_Click(object sender, EventArgs e)
        {
            (new InfoCustomer("", "", "", "", "", "")).ShowDialog();
        }

        private void gunaLinePanel1_MouseEnter(object sender, EventArgs e)
        {
            gunaLinePanel1.BackColor = Color.FromArgb(220, 250, 252);
        }

        private void gunaLinePanel1_MouseLeave(object sender, EventArgs e)
        {
            gunaLinePanel1.BackColor = Color.White;
        }
    }
}
