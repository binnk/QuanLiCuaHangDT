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
        public MainForm()
        {
            InitializeComponent();

           
        
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
             
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y );
             
              
                
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconTitleBox.IconChar = currentBtn.IconChar;
                iconTitleBox.IconColor = color;

                lbTitle.Text = currentBtn.Text;

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
            iconTitleBox.IconChar = IconChar.Home;
            iconTitleBox.IconColor = RGBColors.color8;
            lbTitle.Text = "Home";
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
        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            showMenu(panelProducts);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
        }

    
        private void btnManage_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            showMenu(panelManage);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color9);
        }

        private void iconTitleBox_Click(object sender, EventArgs e)
        {
            Reset();
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
            panelProducts.Visible = false;
            panelManage.Visible = false;
        }

        private void hideMenu()
        {
            if (panelProducts.Visible == true)
            {
                panelProducts.Visible = false;
            }
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
            dwgCustomers.Rows.Add(
                new object[]
                {
                    "KH01",
                    "Pham Tan Khang",
                    "123"
                }
            );
            dwgCustomers.Rows.Add(
              new object[]
              {
                    "KH02",
                    "Pham Tan Khangg",
                    "1233"
              }
             );
            dwgCustomers.Rows.Add(
                new object[]
                {
                            "KH03",
                            "Pham Tan Khanggg",
                            "12333"
                }
               );

        }


    }
}
