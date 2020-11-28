using QLCH_UI.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH_UI.DAO
{
    class Mail
    {
        private static Mail instance;

        public static Mail Instance
        {
            get { if (instance == null) instance = new Mail(); return instance; }
            private set => instance = value;
        }

        private Mail() { }
        int OTP = 0;
        public bool SendMail(string user)
        {
            string query = "SELECT mat_khau,displayname FROM account WHERE username = @user ;";
            DataTable rs = ConnectSQL.Instance.ExecuteQuery(query, new object[] { user });
            if (rs.Rows.Count <= 0) return false;
            Random r = new Random();
            OTP = r.Next(1000, 10000);
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("buiminhhuyqnam@gmail.com");
                mail.To.Add(rs.Rows[0][1].ToString());
                mail.Subject = "OTP FROM APP QUAN LI CUA HANG DIEN THOAI";
                mail.Body = "This is OTP for username " + user +" " + OTP;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("buiminhhuyqnam@gmail.com", "password");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return true;
        }
        public int getOTP()
        {
            return OTP;
        }
    }
}
