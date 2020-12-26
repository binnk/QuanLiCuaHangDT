using QLCH_UI.DAO;
using QLCH_UI.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH_UI.BUS
{
    public class CustomersBUS
    {
        private static CustomersBUS instance;

        public static CustomersBUS Instance
        {
            get
            {
                if (instance == null) instance = new CustomersBUS();
                return CustomersBUS.instance;
            }
            private set
            {
                CustomersBUS.instance = value;
            }
        }
        private CustomersBUS() { }

        // kiem tra ma 
        public bool makh(string value)
        {
            int l = value.Length;
            if (l == 0) return (false);
            int k = 1;
            if (l > 9) return (false);
            for (int i = 0; i < l; i++)
            {
                if ((value[i] >= 65 && value[i] <= 90) || (value[i] >= 97 && value[i] <= 122) || (value[i] >= 48 && value[i] <= 57)) k = 1;
                else return (false);
            }
            return (true);
        }
        // kiem tra SDT
        public bool SDT(string value)
        {
            DataTable a = CustomersDAO.Instance.Customerslist();
            for (int i=0;i<a.Rows.Count;i++)
            {
                if (a.Rows[i]["dien_thoai"].ToString() == value) return (false);
            }    
            int l = value.Length;
            for (int i = 0; i < l; i++) if (value[i] < 48 || value[i] > 57) return (false);
            if (l > 12 || l == 0) return (false);
            return (true);
        }
        // Kiem tra gioi tinh
        public bool gioi_tinh(bool a, bool b)
        {
            if (a == false && b == false) return (false);
            return (true);
        }
        // kiem tra ten 
        public bool ten_kh(string value)
        {
            int l = value.Length;
            if (l > 49 || l == 0) return false;
            return (true);
        }
        // kiem tra dia chi
        public bool dia_chi(string value)
        {
            int l = value.Length;
            if (l > 99 || l == 0) return false;
            return (true);
        }
        public DataTable customerlist()
        {
            return CustomersDAO.Instance.Customerslist();
        }
        public bool insert_customer(CustomersDTO a)
        {
            return (CustomersDAO.Instance.Insert(a));
        }
        public bool edit_customer(CustomersDTO a)
        {
            return (CustomersDAO.Instance.Edit(a));
        }
        public bool delete_customer(string ID)
        {
            return (CustomersDAO.Instance.Delete(ID));
        }
    }
}
