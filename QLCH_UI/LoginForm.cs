using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Design;
using QLCH_UI;
using System.Runtime.InteropServices;

namespace LoginUI
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

   

        private void textBox2_TextChanged(object sender, EventArgs e)
        { 
        }


        #region text, panel chuyển màu khi click vào textbox
        private void textUser_Click(object sender, EventArgs e)
        {


            // panel user + text chuyển màu
            panel1.BackColor = Color.SteelBlue;
            textUser.ForeColor = Color.SteelBlue;


            panel2.BackColor = Color.WhiteSmoke;
            textPass.ForeColor = Color.WhiteSmoke;


          
        }

        private void textPass_Click(object sender, EventArgs e)
        {

            panel1.BackColor = Color.WhiteSmoke;
            textUser.ForeColor = Color.WhiteSmoke;


            panel2.BackColor = Color.SteelBlue;
            textPass.ForeColor = Color.SteelBlue;


     
        }

        #endregion
        private void textUser_TextChanged(object sender, EventArgs e)
        {

        }

        // tạo main form, ẩn form Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (MainForm mainForm= new MainForm())
                mainForm.ShowDialog();
          

        }
        // tạo form register, ẩn form Login
        private void lCreateAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            using (RegisterForm registerForm = new RegisterForm())
                registerForm.ShowDialog();
            this.Show();


        }


        #region Event Enter and Leave when click text user, password
   
        private void textUser_Leave(object sender, EventArgs e)
        {
            if (textUser.Text =="")
            {
                textUser.Text = "Username";
            }
        }

        private void textUser_Enter(object sender, EventArgs e)
        {
            if (textUser.Text == "Username")
            {
                textUser.Text = "";
            }
        }

        private void textPass_Leave(object sender, EventArgs e)
        {
            if (textPass.Text == "")
            {
                textPass.PasswordChar = '\0';
                textPass.Text = "Password";
            }
        }

        private void textPass_Enter(object sender, EventArgs e)
        {
            if (textPass.Text == "Password")
            {
                textPass.Text = "";
                textPass.PasswordChar = '•';
            }
        }
        #endregion


        /*
         * Di chuyển form login khi kéo logo for
         */
        #region Di chuyển form login khi kéo logo form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void picLogin_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion


        // Đóng form
        private void xLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
