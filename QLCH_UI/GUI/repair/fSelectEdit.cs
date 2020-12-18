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
    public partial class fSelectEdit : Form
    {
        private string masc;
        public fSelectEdit(string massc)
        {
            InitializeComponent();
            masc = massc;
        }
       
        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            fEditRepair form = new fEditRepair(masc);
            form.ShowDialog();
            this.Close();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            this.Hide();
            fUpdateInfo form = new fUpdateInfo(masc);
            form.ShowDialog();
            this.Close();
        }
    }
}
