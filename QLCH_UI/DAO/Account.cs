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

            string pass = Encrypt.Instance.Hash(password);
            string query = "SELECT * FROM account WHERE username = N'" + user + "' AND mat_khau = N'" + pass + "' ";
            DataTable rs = ConnectSQL.Instance.ExecuteQuery(query);
            return rs.Rows.Count > 0;
        }
        public int Register(string user, string email, string password)
        {

            string pass = Encrypt.Instance.Hash(password);
            string query = "INSERT INTO account (username, displayname, mat_khau) VALUES ( @name , @email , @pass ); ";
            int rs = ConnectSQL.Instance.ExecuteNonQuery(query, new object[] { user, email, pass });
            return rs;
        }
        public bool Check(string user)
        {


            string query = "SELECT * FROM account WHERE username = @user ;";
            DataTable rs = ConnectSQL.Instance.ExecuteQuery(query, new object[] { user });
            return rs.Rows.Count > 0;
        }
    }
}
