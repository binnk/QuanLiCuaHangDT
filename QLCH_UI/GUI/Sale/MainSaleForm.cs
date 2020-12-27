using LoginUI;
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
    public partial class MainSaleForm : Form
    {
        private string manv;
        public MainSaleForm(string manvv)
        {
            manv = manvv;
            InitializeComponent();
            lb_manv.Text = manv;
            lb_tennv.Text = DAO.Account.Instance.Get_Ten(manv);
            openChildForm(new fReviewSale(manv));
            pnInfo.Visible = false;
        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            panelChildForm.Controls.Add(childForm);
            // panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            openChildForm(new fReviewSale(manv));
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            SellForm f = new SellForm(manv);
            f.ShowDialog();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            openChildForm(new fProduct(manv));
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            openChildForm(new fViewCustomer());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (pnInfo.Visible == false)
            {
                pnInfo.Visible = true;
                pnInfo.BringToFront();
            }
            else
            {
                pnInfo.Visible = false;
            }
        }

        private void btnChangePW_Click(object sender, EventArgs e)
        {
            fChangePassword f = new fChangePassword(manv);
            f.ShowDialog();
            pnInfo.Visible = false;
        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {
            if (pnInfo.Visible == false)
            {
                pnInfo.Visible = true;
                pnInfo.BringToFront();
            }
            else
            {
                pnInfo.Visible = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Program.SetMainForm(new LoginForm());
            Program.ShowMainForm();
            this.Close();
        }
    }
}
