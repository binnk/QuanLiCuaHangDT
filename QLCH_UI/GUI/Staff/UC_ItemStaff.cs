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
    public partial class UC_ItemStaff : UserControl
    {
        public UC_ItemStaff()
        {
            InitializeComponent();
        }

        private void gunaLinePanel2_MouseEnter(object sender, EventArgs e)
        {
            gunaLinePanel2.BackColor = Color.FromArgb(220, 250, 252);
        }

        private void gunaLinePanel2_MouseLeave(object sender, EventArgs e)
        {
            gunaLinePanel2.BackColor = Color.White;
        }
    }
}
