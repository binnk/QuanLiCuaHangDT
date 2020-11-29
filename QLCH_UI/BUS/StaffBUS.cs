using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCH_UI.DAO;
using QLCH_UI.DTO;
using System.Data;
using System.Windows.Forms;

namespace QLCH_UI.BUS
{
    public class StaffBUS
    {
        private static StaffBUS instance;

        public static StaffBUS Instance
        {
            get
            {
                if (instance == null) instance = new StaffBUS();
                return StaffBUS.instance;
            }
            private set
            {
                StaffBUS.instance = value;
            }
        }
        private StaffBUS() { }
        public bool delete_staff(string ID,string user)
        {
            if (StaffDAO.Instance.delete_user(user)) return (StaffDAO.Instance.Delete(ID));
            else return (false);
        }
        public bool insert_staff(StaffDTO a, string username, string email, string password)
        {
            bool kt=StaffDAO.Instance.Insert(a);
            if (password != "")
            {
                Account.Instance.Register(username, email, password);
            }
            else
            {
                MessageBox.Show("Bạn đã không điền đầy đủ thông tin vui lòng đăng kí đầy đủ thông tin ở lần truy cập sau ở Phần đăng ký.");
            }
                return (kt);
        }

        public bool edit_staff(StaffDTO a, string username, string email)
        {
           if(email != "") StaffDAO.Instance.edit_userr(username, email);
            bool kt = StaffDAO.Instance.Edit(a);
            return (kt);
        }

        public string Check(string user, string password, string confirm, string email)
        {
            string result = "";
            if (password == "" && confirm == "" && email == "")
                return result;

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
                    result = "Vui lòng chọn mật khẩu khác.";
                    return result;
                }
            }
            if (user == "" || user == "Username")
            {
                result = "Vui lòng điền tên tài khoản.";
                return result;
            }
            string query = "SELECT * FROM account WHERE username = @user ;";
            string query_for_nv = "select * from nhan_vien where username = @user ;";
            DataTable rs_ac = ConnectSQL.Instance.ExecuteQuery(query, new object[] { user });
            DataTable rs_nv = ConnectSQL.Instance.ExecuteQuery(query_for_nv, new object[] { user });
            if (rs_ac.Rows.Count > 0 || rs_nv.Rows.Count > 1)
            {
                result = "Tên tài khoản đã tồn tại.";
                return result;
            }
            if (password != confirm || password == "")
            {
                result = "Xác nhận lại mật khẩu!";
                return result;
            }
            string queryy = "SELECT * FROM account WHERE email = @email ;";
            DataTable rss = ConnectSQL.Instance.ExecuteQuery(queryy, new object[] { email });

            if ((email.LastIndexOf("@gmail.com") + 10) != email.Length || email == "")
            {
                result = "Đây không phải là gmail!.";
                return result;
            }
            if (rss.Rows.Count > 0)
            {
                result = "Gmail đã tồn tại.";
                return result;
            }
           

            return result;
        }
        public string Check_email(string email)
        {
            string result = "";
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
            return result;
        }
    }
}
