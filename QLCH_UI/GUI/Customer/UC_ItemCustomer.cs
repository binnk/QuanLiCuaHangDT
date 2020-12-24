using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCH_UI.DAO;

namespace QLCH_UI
{
    public partial class UC_ItemCustomer : UserControl
    {
        public string makh { get; set; }
        public string tenkh { get; set; }
        public string sdt { get; set; }
        public string gioitinh { get; set; }
        public string diachi { get; set; }
        private fViewCustomer _parent;

        public UC_ItemCustomer(fViewCustomer parent)
        {
            _parent = parent;
            InitializeComponent();
        }

        public void set_UC()
        {
            lb_makh.Text = makh;
            lb_tenkh.Text = tenkh;
            lb_SDT.Text = sdt;
            lb_gioitinh.Text = gioitinh;
            lb_diachi.Text = diachi;
        }
        //edit
        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataTable a = CustomersDAO.Instance.ViewCustomer(makh);
            DateTime b = DateTime.Parse(a.Rows[0]["ngay_sinh"].ToString());
            (new EditCustomer(makh,tenkh,b,diachi,sdt,gioitinh)).ShowDialog();
            _parent.loadcustomer();
        }
        //xoa
        private void gunaButton3_Click(object sender, EventArgs e)
        {
            // Xóa SQL
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng?","Thông báo",MessageBoxButtons.OKCancel)!=System.Windows.Forms.DialogResult.OK)
            {
               // e.Cancel = true;
            }   
            else
            {
                CustomersDAO.Instance.Delete(makh);
            }
            _parent.loadcustomer();
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {
            DataTable a = CustomersDAO.Instance.ViewCustomer(makh);
            string b = DateTime.Parse(a.Rows[0]["ngay_sinh"].ToString()).ToString("dd - MM - yyyy");
            (new InfoCustomer(makh, tenkh, sdt, diachi, b, gioitinh)).ShowDialog();
        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {
            DataTable a = CustomersDAO.Instance.ViewCustomer(makh);
            string b = DateTime.Parse(a.Rows[0]["ngay_sinh"].ToString()).ToString("dd - MM - yyyy");
            (new InfoCustomer(makh, tenkh, sdt, diachi, b, gioitinh)).ShowDialog();
        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {
            DataTable a = CustomersDAO.Instance.ViewCustomer(makh);
            string b = DateTime.Parse(a.Rows[0]["ngay_sinh"].ToString()).ToString("dd - MM - yyyy");
            (new InfoCustomer(makh, tenkh, sdt, diachi, b, gioitinh)).ShowDialog();
        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {
            DataTable a = CustomersDAO.Instance.ViewCustomer(makh);
            string b = DateTime.Parse(a.Rows[0]["ngay_sinh"].ToString()).ToString("dd - MM - yyyy");
            (new InfoCustomer(makh, tenkh, sdt, diachi, b, gioitinh)).ShowDialog();
        }

        private void gunaLabel7_Click(object sender, EventArgs e)
        {
            DataTable a = CustomersDAO.Instance.ViewCustomer(makh);
            string b = DateTime.Parse(a.Rows[0]["ngay_sinh"].ToString()).ToString("dd - MM - yyyy");
            (new InfoCustomer(makh, tenkh, sdt, diachi, b, gioitinh)).ShowDialog();
        }

        private void gunaLinePanel1_Click(object sender, EventArgs e)
        {
            DataTable a = CustomersDAO.Instance.ViewCustomer(makh);
            string b = DateTime.Parse(a.Rows[0]["ngay_sinh"].ToString()).ToString("dd - MM - yyyy");
            (new InfoCustomer(makh, tenkh, sdt, diachi, b, gioitinh)).ShowDialog();
        }

        private void gunaLinePanel1_MouseEnter(object sender, EventArgs e)
        {
            gunaLinePanel1.BackColor = Color.FromArgb(220, 250, 252);
        }

        private void gunaLinePanel1_MouseLeave(object sender, EventArgs e)
        {
            gunaLinePanel1.BackColor = Color.White;
        }

        private void gunaLinePanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
