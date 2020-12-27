using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using LoginUI;
using Bunifu;


namespace QLCH_UI
{
    partial class MainForm : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public string manv;
     
        public MainForm(string manvv)
        {
          
            manv = manvv;
            InitializeComponent();
            lb_tennv.Text = DAO.Account.Instance.Get_Ten(manv);
            lb_manv.Text = manv ;
            openChildForm(new ReportForm());
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            customizeDesing();



        }



        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(231, 125, 108);
            public static Color color8 = Color.FromArgb(108, 125, 231);
            public static Color color9 = Color.FromArgb(70, 213, 161);

        }

        // Click button ở panel Menu thì button thay đổi
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {

                DisableButton();


                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;

                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);



                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();


                //panelTitle.BackColor = color;
                //btnExit.BackColor = color;
                //btnMaximize.BackColor = color;
                //btnMinimize.BackColor = color;

            }
        }

        // chuyển button về trạng thái ban đầu
        private void DisableButton()
        {
            if (currentBtn != null)
            {

                currentBtn.BackColor = Color.FromArgb(32, 45, 63);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        // về HOME
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;

        }



        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }



        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }



        #region Xử lý event Click các button
        private void iconBtnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }

        private void btnCartP_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            openChildForm(new fOrder());
        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            //dgvProducts.BringToFront();
            openChildForm(new fProduct(this.manv));


        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            //dgvCustomers.BringToFront();
            //panelBotCustomers.BringToFront();
        }


        private void btnManage_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            showMenu(panelManage);
        }

        private void itemEmployeeManage_Click(object sender, EventArgs e)
        {
            openChildForm(new fStaff());
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            openChildForm(new fViewCustomer());
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            openChildForm(new ReportForm());
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color9);
            (new SellForm(manv)).ShowDialog();

        }

        private void iconTitleBox_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion


        #region kéo, di chuyển form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion


        // cài đặt trạng thái ẩn các panel ban đầu
        private void customizeDesing()
        {
            //panelProducts.Visible = false;
            panelManage.Visible = false;
            pnInfo.Visible = false;
        }

        private void hideMenu()
        {
            //if (panelProducts.Visible == true)
            //{
            //    panelProducts.Visible = false;
            //}
            if (panelManage.Visible == true)
            {
                panelManage.Visible = false;
            }
        }


        private void showMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                //hideMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }


        private void panelCenter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            //dgvCustomers.Rows.Add(
            //    new object[]
            //    {
            //        "KH01",
            //        "Nguyen Van A",
            //        "123"
            //    }
            //);
            //dgvCustomers.Rows.Add(
            //  new object[]
            //  {
            //        "KH02",
            //        "Nguyen Van B",
            //        "1233"
            //  }
            // );
            //dgvCustomers.Rows.Add(
            //    new object[]
            //    {
            //        "KH03",
            //        "Nguyen Van C",
            //        "12333"
            //    }
            //   );

        }



        private void ỉtemListProducts_Click(object sender, EventArgs e)
        {
            //dgvProducts.BringToFront();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private Form activeForm = null;

        // Mở form gắn liền với panel main form

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
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void itemWareHouseManage_Click(object sender, EventArgs e)
        {
            openChildForm(new fManageWH(this.manv));

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            openChildForm(new fImportManage());
        }

        private void panelTitle_Paint(object sender, PaintEventArgs e)
        {

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

        private void pnInfo_Paint(object sender, PaintEventArgs e)
        {

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

        private void btnChangePW_Click(object sender, EventArgs e)
        {
            fChangePassword f = new fChangePassword(manv);
            f.ShowDialog();
            pnInfo.Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Program.SetMainForm( new LoginForm());
            Program.ShowMainForm();
            this.Close();
        }
    }
}
