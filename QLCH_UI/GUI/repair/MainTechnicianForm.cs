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
             
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y );
             
              
                
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



        private void hideMenu()
        {

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
            openChildForm(new ViewProduct());
        }
    }
}
