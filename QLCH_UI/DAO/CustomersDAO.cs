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
    public class CustomersDAO 
    {
        private static CustomersDAO instance;

        public static CustomersDAO Instance
        {
            get
            {
                if (instance == null) instance = new CustomersDAO();
                return CustomersDAO.instance;
            }
            private set
            {
                CustomersDAO.instance = value;
            }
        }
        private CustomersDAO() { }
        public DataTable Customerslist()
        {
            string query = "select makh as N'Mã khách hàng', ten_kh as N'Tên khách hàng', dien_thoai as 'SDT' from khach_hang";
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return (dt);
        }

        public DataTable ViewCustomer(string ID)
        {
            string query=string.Format("select * from khach_hang where makh='{0}'", ID);
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return (dt);
        }

        public bool Insert(CustomersDTO a)
        {
            int  result = 0;
            try
            {
                string query = string.Format("insert into khach_hang(makh,ten_kh,ngay_sinh,dia_chi,dien_thoai,gioi_tinh) values ('{0}',N'{1}','{2}','{3}','{4}',N'{5}')", a.Makh, a.Ten_kh, a.Ngay_sinh, a.Dia_chi, a.Dien_thoai, a.Gioi_tinh);
                result = ConnectSQL.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã khách đã tồn tại");
            }
            if (result == 0) return (false);
            else return (true);
        }

        public bool Edit(CustomersDTO a)
        {
           
            int result = 0;
            try
            {
                string query = string.Format("update khach_hang set ten_kh= N'{0}', ngay_sinh= '{1}', dia_chi= N'{2}', dien_thoai= '{3}', gioi_tinh= N'{4}' where makh='{5}'", a.Ten_kh, a.Ngay_sinh, a.Dia_chi, a.Dien_thoai, a.Gioi_tinh,a.Makh);
                result = ConnectSQL.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            if (result == 0) return (false);
            else return (true);
        }

        public bool Delete(string ID)
        {
            int result = 0;
            try
            {
                string query = string.Format("delete from khach_hang where makh= '{0}'", ID);
                result = ConnectSQL.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            if (result == 0) return (false);
            else return (true);
        }
    }
}
