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
