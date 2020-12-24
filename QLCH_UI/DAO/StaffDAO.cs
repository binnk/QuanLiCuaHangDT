using QLCH_UI.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QLCH_UI.DAO
{
    public class StaffDAO
    {
        private static StaffDAO instance;

        public static StaffDAO Instance
        {
            get
            {
                if (instance == null) instance = new StaffDAO();
                return StaffDAO.instance;
            }
            private set
            {
                StaffDAO.instance = value;
            }
        }
        private StaffDAO() { }
        public DataTable Stafflist()
        {
            string query = "select * from nhan_vien";
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return (dt);
        }

        public bool delete_user(string user)
        {
            int result = 0;
            try
            {
                string query = string.Format("delete from account where username= '{0}'", user);
                result = ConnectSQL.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           // if (result == 0) return (false);
           // else 
            return (true);
        }

        public DataTable ViewStaff(string ID)
        {
            string query = string.Format("select * from nhan_vien where manv='{0}'", ID);
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return (dt);
        }

        public bool Insert(StaffDTO a)
        {
            int result = 0;
            try
            {
                string query = string.Format("insert into nhan_vien(username,manv,ten_nv,ngay_sinh,dia_chi,dien_thoai,gioi_tinh,loainhanvien) values ('{0}','{1}',N'{2}','{3}','{4}','{5}',N'{6}',N'{7}')", a.Username, a.Manv, a.Ten_nv, a.Ngay_sinh, a.Dia_chi, a.Dien_thoai, a.Gioi_tinh,a.Loainhanvien);
                result = ConnectSQL.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại");
            }
            if (result == 0) return (false);
            else return (true);
        }

        public bool Edit(StaffDTO a)
        {

            int result = 0;
            try
            {
                string query = string.Format("update nhan_vien set username='{0}', ten_nv= N'{1}', ngay_sinh= '{2}', dia_chi= N'{3}', dien_thoai= '{4}', gioi_tinh= N'{5}',loainhanvien= N'{6}' where manv='{7}'", a.Username, a.Ten_nv, a.Ngay_sinh, a.Dia_chi, a.Dien_thoai, a.Gioi_tinh, a.Loainhanvien, a.Manv);
                result = ConnectSQL.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (result == 0) return (false);
            else return (true);
        }
        //------
        public DataTable viewuser(string user)
        {
            string query = string.Format("select * from account where username='{0}'", user);
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return (dt);
        }
        //public bool edit_userr
        public bool edit_userr(string user, string email)
        {
            int result = 0;
            try
            {
                string query = string.Format("update account set email='{0}' where username='{1}'", email, user);
                result = ConnectSQL.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (result == 0) return (false);
            else return (true);
        }
        public bool Delete(string ID)
        {
            int result = 0;
            try
            {
                string query = string.Format("delete from nhan_vien where manv= '{0}'", ID);
                result = ConnectSQL.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (result == 0) return (false);
            else return (true);
        }

        public DataTable search_staff_by_name(string ten_nv)
        {
            string query = string.Format("select * from nhan_vien where dbo.fuConvertToUnsign1(ten_nv) like N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", ten_nv);
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return (dt);
        }
    }
}
