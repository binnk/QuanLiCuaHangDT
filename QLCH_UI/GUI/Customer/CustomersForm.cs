using QLCH_UI.BUS;
using QLCH_UI.DAO;
using QLCH_UI.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH_UI
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
            loadcustomers();
        }
        public void loadcustomers()
        {
            dgvCustomers.DataSource = CustomersDAO.Instance.Customerslist();

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddCustomerForm f = new AddCustomerForm();
            f.ShowDialog();
            loadcustomers();
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count>0)
            {
                DataGridViewRow row = dgvCustomers.SelectedRows[0];
                String ID = row.Cells[0].Value.ToString();
                string ma_kh = "";
                string ten_kh = "";
                string ngay_sinh = "";
                string dia_chi = "";
                string dien_thoai = "";
                string gioi_tinh = "";
                dgvCustomers.DataSource= CustomersDAO.Instance.ViewCustomer(ID);
                foreach(DataGridViewRow roww in dgvCustomers.Rows)
                {
                    string k = roww.Cells[0].Value.ToString();
                    if (ID == k)
                    {
                        ma_kh = roww.Cells[0].Value.ToString();
                        ten_kh = roww.Cells[1].Value.ToString();
                        ngay_sinh = roww.Cells[2].Value.ToString();
                        dia_chi = roww.Cells[3].Value.ToString();
                        dien_thoai = roww.Cells[4].Value.ToString();
                        gioi_tinh = roww.Cells[5].Value.ToString();
                        break;
                    }
                }
                DateTime ngay_sinhh = DateTime.Parse(ngay_sinh);
                EditCustomersForm f = new EditCustomersForm(ma_kh,ten_kh,ngay_sinhh,dia_chi,dien_thoai,gioi_tinh);
                f.ShowDialog();
                loadcustomers();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvCustomers.SelectedRows[0];
                string ID = row.Cells[0].Value.ToString();
                if (CustomersBUS.Instance.delete_customer(ID))
                {
                    MessageBox.Show("Xóa thành công");
                }    
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
                loadcustomers();
            }
        }
    }
}
