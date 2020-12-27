using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCH_UI.DAO
{
    class Account
    {
        private static Account instance;

        public static Account Instance
        {
            get { if (instance == null) instance = new Account(); return instance; }
            private set => instance = value;
        }

        private Account() { }
        public bool Login(string user, string password)
        {

            bool r = false;
            string pass = Encrypt.Instance.Hash(password);
            string query = "SELECT * FROM account WHERE username = N'" + user + "' AND mat_khau = N'" + pass + "' ";
            DataTable rs = ConnectSQL.Instance.ExecuteQuery(query);
            r = rs.Rows.Count > 0;
            int OTP = QLCH_UI.DAO.Mail.Instance.getOTP();
            if (r != true && OTP != 0)
            {
                if (OTP == Convert.ToInt32(password))
                    r = true;
            }
            return r;
        }
        public int Register(string user, string email, string password)
        {

            string pass = Encrypt.Instance.Hash(password);
            string query = "INSERT INTO account (username, email, mat_khau) VALUES ( @name , @email , @pass ); ";
            int rs = ConnectSQL.Instance.ExecuteNonQuery(query, new object[] { user, email, pass });
            return rs;
        }
        public string Check(string user, string password, string confirm, string email)
        {
            string result = "";
            

            foreach (char i in user)
            {
                if ((i < '0' || i > '9') && (i < 'a' || i > 'z') && (i < 'A' || i > 'Z'))
                {
                    result = "Please choose username provided by the admin.";
                    return result;
                }
            }
            foreach (char i in password)
            {
                if ((i < '0' || i > '9') && (i < 'a' || i > 'z') && (i < 'A' || i > 'Z'))
                {
                    result = "Please choose another password.";
                    return result;
                }
            }
            if (user == "" || user == "Username")
            {
                result = "Please fill username.";
                return result;
            }
            string query = "SELECT * FROM account WHERE username = @user ;";
            string query_for_nv = "select * from nhan_vien where username = @user ;";
            DataTable rs_ac = ConnectSQL.Instance.ExecuteQuery(query, new object[] { user });
            DataTable rs_nv = ConnectSQL.Instance.ExecuteQuery(query_for_nv, new object[] { user });
            if (rs_ac.Rows.Count > 0 || rs_nv.Rows.Count != 1)
            {
                result = "Username is already taken.Try another one.";
                return result;
            }
            string queryy = "SELECT * FROM account WHERE email = @email ;";
            DataTable rss = ConnectSQL.Instance.ExecuteQuery(queryy, new object[] { email });

            if ((email.LastIndexOf("@gmail.com") + 10) != email.Length || email == "")
            {
                result = "It is not gmail. Please choose another email.";
                return result;
            }
            if (rss.Rows.Count > 0)
            {
                result = "Email is already taken. Please choose another email.";
                return result;
            }
            if (password != confirm || password == "")
            {
                result = "Confirm your password!";
                return result;
            }
            
            return result;
        }
        public string Get_Loai_NV(string username)
        {
            string query = "select NHAN_VIEN.loainhanvien from ACCOUNT,NHAN_VIEN"
                    +" where ACCOUNT.username = NHAN_VIEN.username and ACCOUNT.username = '"+username+"'";
            DataTable rs = ConnectSQL.Instance.ExecuteQuery(query);
            try
            {
                return rs.Rows[0]["loainhanvien"].ToString();
            }
            catch
            {
                return "admin";
            }
        }
        public string Get_Ma_NV(string username)
        {
            string query = "select NHAN_VIEN.manv from ACCOUNT,NHAN_VIEN"
                    + " where ACCOUNT.username = NHAN_VIEN.username and ACCOUNT.username = '" + username + "'";
            DataTable rs = ConnectSQL.Instance.ExecuteQuery(query);
            try
            {
                return rs.Rows[0]["manv"].ToString();
            }
            catch
            {
                return "NV01";
            }
        }
        public bool Change_PW(string usermane,string pw)
        {
            string query = "update account set mat_khau = '"+pw+"'"+
                           " where username = '"+usermane+"' ";
           
            try
            {
                DataTable rs = ConnectSQL.Instance.ExecuteQuery(query);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public string Get_Username(string manv)
        {
            string query = "select ACCOUNT.username from ACCOUNT,NHAN_VIEN"
                    + " where ACCOUNT.username = NHAN_VIEN.username and  NHAN_VIEN.manv = '" + manv + "'";
            DataTable rs = ConnectSQL.Instance.ExecuteQuery(query);
            try
            {
                return rs.Rows[0]["username"].ToString();
            }
            catch
            {
                return "huy";
            }
        }
        public string Get_Ten(string manv)
        {
            string query = "select NHAN_VIEN.ten_nv from NHAN_VIEN"
                    + " where NHAN_VIEN.manv = '" + manv + "'";
            DataTable rs = ConnectSQL.Instance.ExecuteQuery(query);
            try
            {
                return rs.Rows[0]["ten_nv"].ToString();
            }
            catch
            {
                return "";
            }
        }
    }
}
