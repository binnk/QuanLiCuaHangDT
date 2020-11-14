using QLCH_UI.BUS;
using QLCH_UI.DAO;
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
            AddCustomer f = new AddCustomer();
            f.ShowDialog();
            loadcustomers();
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

        private void panelBotProducts_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {

            if (dgvCustomers.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvCustomers.SelectedRows[0];
                String ID = row.Cells[0].Value.ToString();
                string ma_kh = "";
                string ten_kh = "";
                string ngay_sinh = "";
                string dia_chi = "";
                string dien_thoai = "";
                string gioi_tinh = "";
                dgvCustomers.DataSource = CustomersDAO.Instance.ViewCustomer(ID);
                foreach (DataGridViewRow roww in dgvCustomers.Rows)
                {
                    string k = roww.Cells[0].Value.ToString();
                    if (ID == k)
                    {
                        ma_kh = roww.Cells[0].Value.ToString();
                        ten_kh = roww.Cells[1].Value.ToString();
                        ngay_sinh = roww.Cells[2].Value.ToString();
                        dien_thoai = roww.Cells[3].Value.ToString();
                        dia_chi = roww.Cells[4].Value.ToString();
                        gioi_tinh = roww.Cells[5].Value.ToString();
                        break;
                    }
                }
                DateTime ngay_sinhh = DateTime.Parse(ngay_sinh);
                EditCustomer f = new EditCustomer(ma_kh, ten_kh, ngay_sinhh, dia_chi, dien_thoai, gioi_tinh);
                f.ShowDialog();
                loadcustomers();
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
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

        private void btn_info_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvCustomers.SelectedRows[0];
                string ID = row.Cells[0].Value.ToString();
                DataTable a = CustomersDAO.Instance.ViewCustomer(ID);
                string makh = a.Rows[0]["Mã khách hàng"].ToString();
                string tenkh = a.Rows[0]["Tên khách hàng"].ToString();
                string SDT = a.Rows[0]["SDT"].ToString();
                string diachi = a.Rows[0]["Địa chỉ"].ToString();
                string ngaysinh = a.Rows[0]["Ngày sinh"].ToString();
                string gioitinh = a.Rows[0]["Giới tính"].ToString();
                InfoCustomer f = new InfoCustomer(makh, tenkh, SDT, diachi, ngaysinh, gioitinh);
                f.ShowDialog();
            }
        }
    }
}
