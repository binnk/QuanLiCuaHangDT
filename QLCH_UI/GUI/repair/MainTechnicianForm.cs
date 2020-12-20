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
    partial class MainTechnicianForm : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private string manv;
        public MainTechnicianForm(string manvv)
        {
            manv = manvv;
            InitializeComponent();

           
        
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            openChildForm(new fReviewTech(manv));



        }







        // chuyển button về trạng thái ban đầu

     

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

   

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }



        #region Xử lý event Click các button

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

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm !=null)
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




        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSuaChua_Click(object sender, EventArgs e)
        {
            openChildForm(new fRepair(manv));   
        }

        private void btnLinhKien_Click(object sender, EventArgs e)
        {
            openChildForm(new fProduct());
        }

        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            openChildForm(new fReviewTech(manv));
        }
    }
}
