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
    public partial class UC_itemManageWH : UserControl
    {
        public UC_itemManageWH()
        {
            InitializeComponent();
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
