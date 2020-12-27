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
    public partial class fChangePassword : Form
    {
        private string manv;
        public fChangePassword(string manvv)
        {
            manv = manvv;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if(tbcmk.Text == tbmk.Text)
            {
                if(DAO.Account.Instance.Change_PW(DAO.Account.Instance.Get_Username(manv), DAO.Encrypt.Instance.Hash(tbcmk.Text)))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
            else
            {
                label3.Visible = true;
                label3.Text = "Xác nhận lại mật khẩu.";
            }
        }

        private void gunaLinePanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
