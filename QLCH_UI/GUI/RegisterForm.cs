using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCH_UI;
using QLCH_UI.DAO;

namespace LoginUI
{
    public partial class RegisterForm : Form
    {

        public RegisterForm()
        {

            InitializeComponent();
        }
 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUser_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(textUser.Text) == "Username")
                textUser.Clear();
         

            // panel user + text chuyển màu
            panelUser.BackColor = Color.SteelBlue;
            textUser.ForeColor = Color.SteelBlue;


            panelPass.BackColor = Color.WhiteSmoke;
            textPass.ForeColor = Color.WhiteSmoke;

            panelEmail.BackColor = Color.WhiteSmoke;
            textEmail.ForeColor = Color.WhiteSmoke;

            panelCPass.BackColor = Color.WhiteSmoke;
            panelCPass.ForeColor = Color.WhiteSmoke;

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {

        }
        #region Di chuyển form login khi kéo logo form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
       
        private void lbRegister_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        #region
        private void textPass_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(textPass.Text) == "Password")
                textPass.Clear();


            textPass.PasswordChar = '•';
            panelUser.BackColor = Color.WhiteSmoke;
            textUser.ForeColor = Color.WhiteSmoke;


            panelPass.BackColor = Color.SteelBlue;
            textPass.ForeColor = Color.SteelBlue;

            panelEmail.BackColor = Color.WhiteSmoke;
            textEmail.ForeColor = Color.WhiteSmoke;

            panelCPass.BackColor = Color.WhiteSmoke;
            panelCPass.ForeColor = Color.WhiteSmoke;
        }

        private void textEmail_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(textEmail.Text) == "Email")
                textEmail.Clear();


            // panel user + text chuyển màu
            panelUser.BackColor = Color.WhiteSmoke;
            textUser.ForeColor = Color.WhiteSmoke;


            panelPass.BackColor = Color.WhiteSmoke;
            textPass.ForeColor = Color.WhiteSmoke;

            panelEmail.BackColor = Color.SteelBlue;
            textEmail.ForeColor = Color.SteelBlue;

            panelCPass.BackColor = Color.WhiteSmoke;
            panelCPass.ForeColor = Color.WhiteSmoke;
        }



        private void textCPass_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(textCPass.Text) == "Confirm password")
                textCPass.Clear();

            textCPass.PasswordChar = '•';
            // panel user + text chuyển màu
            panelUser.BackColor = Color.WhiteSmoke;
            textUser.ForeColor = Color.WhiteSmoke;


            panelPass.BackColor = Color.WhiteSmoke;
            textPass.ForeColor = Color.WhiteSmoke;

            panelEmail.BackColor = Color.WhiteSmoke;
            textEmail.ForeColor = Color.WhiteSmoke;

            panelCPass.BackColor = Color.SteelBlue;
            panelCPass.ForeColor = Color.SteelBlue;
        }
        #endregion

        #region Xử lý event enter, leave
        private void textUser_Enter(object sender, EventArgs e)
        {
            if (textUser.Text == "Username")
            {
                textUser.Text = "";
            }
        }

        private void textUser_Leave(object sender, EventArgs e)
        {
            if (textUser.Text == "")
            {
                textUser.Text = "Username";
            }
        }

        private void textEmail_Enter(object sender, EventArgs e)
        {
            if (textEmail.Text == "Email")
            {
                textEmail.Text = "";
            }
        }

        private void textEmail_Leave(object sender, EventArgs e)
        {
            if (textEmail.Text == "")
            {
                textEmail.Text = "Email";
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

        private void textPass_Leave(object sender, EventArgs e)
        {
            if (textPass.Text == "")
            {
                textPass.PasswordChar = '\0';
                textPass.Text = "Password";
            }
        }

        private void textCPass_Enter(object sender, EventArgs e)
        {
            if (textCPass.Text == "Confirm password")
            {
                textCPass.Text = "";
                textCPass.PasswordChar = '•';
            }
        }

        private void textCPass_Leave(object sender, EventArgs e)
        {
            if (textCPass.Text == "")
            {
                textCPass.PasswordChar = '\0';
                textCPass.Text = "Confirm password";
            }
        }
        #endregion 

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (Account.Instance.Check(textUser.Text, textPass.Text, textCPass.Text, textEmail.Text) != "")
            {
                label2.Text = Account.Instance.Check(textUser.Text, textPass.Text, textCPass.Text, textEmail.Text);
                label2.Visible = true;
            }
            else
            {
                if (Account.Instance.Register(textUser.Text.ToString(), textEmail.Text.ToString(), textPass.Text.ToString()) == 1)
                {
                    this.Close();
                    (new LoginForm()).Show();
                }
            }
        }

   
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            (new LoginForm()).Show();
        }

        private void textCPass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                this.Close();
                (new LoginForm()).Show();
            }
        }
    }
}
