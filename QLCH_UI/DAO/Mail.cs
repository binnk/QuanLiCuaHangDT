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
            string query = "SELECT mat_khau, email FROM account WHERE username = @user ;";
            DataTable rs = ConnectSQL.Instance.ExecuteQuery(query, new object[] { user });
            if (rs.Rows.Count <= 0) return false;
            Random r = new Random();
            OTP = r.Next(1000, 10000);
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(rs.Rows[0]["email"].ToString());
                mail.To.Add(rs.Rows[0][1].ToString());
                mail.Subject = "OTP FROM APP QUAN LI CUA HANG DIEN THOAI";
                mail.Body = "This is OTP for username " + user +" " + OTP;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("quanlicuahangdt@gmail.com", "buiminhhuy");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Mail Send. Get your OTP from email.");
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
