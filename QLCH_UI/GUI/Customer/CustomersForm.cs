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
                DataTable a = CustomersDAO.Instance.ViewCustomer(ID);
                ma_kh = a.Rows[0]["makh"].ToString();
                ten_kh = a.Rows[0]["ten_kh"].ToString();
                ngay_sinh = a.Rows[0]["ngay_sinh"].ToString();
                dien_thoai = a.Rows[0]["dien_thoai"].ToString();
                dia_chi = a.Rows[0]["dia_chi"].ToString();
                gioi_tinh = a.Rows[0]["gioi_tinh"].ToString();
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
                string makh = a.Rows[0]["makh"].ToString();
                string tenkh = a.Rows[0]["ten_kh"].ToString();
                string SDT = a.Rows[0]["dien_thoai"].ToString();
                string diachi = a.Rows[0]["dia_chi"].ToString();
                string ngaysinh = a.Rows[0]["ngay_sinh"].ToString();
                string gioitinh = a.Rows[0]["gioi_tinh"].ToString();
                InfoCustomer f = new InfoCustomer(makh, tenkh, SDT, diachi, ngaysinh, gioitinh);
                f.ShowDialog();
            }
        }

        private void dgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvCustomers.SelectedRows[0];
                string ID = row.Cells[0].Value.ToString();
                DataTable a = CustomersDAO.Instance.ViewCustomer(ID);
                string makh = a.Rows[0]["makh"].ToString();
                string tenkh = a.Rows[0]["ten_kh"].ToString();
                string SDT = a.Rows[0]["dien_thoai"].ToString();
                string diachi = a.Rows[0]["dia_chi"].ToString();
                string ngaysinh = a.Rows[0]["ngay_sinh"].ToString();
                string gioitinh = a.Rows[0]["gioi_tinh"].ToString();
                InfoCustomer f = new InfoCustomer(makh, tenkh, SDT, diachi, ngaysinh, gioitinh);
                f.ShowDialog();
            }
        }
    }
}
