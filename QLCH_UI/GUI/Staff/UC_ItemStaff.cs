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
    public partial class UC_ItemStaff : UserControl
    {
        fStaff _parent;
        public UC_ItemStaff(fStaff parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public string manv { get; set; }
        public string tenv { get; set; }
        public string SDT { get; set; }
        public string chucvu { get; set; }
        public string diachi { get; set; }
        public void set_UC()
        {
            lb_manv.Text = manv;
            lb_tennv.Text = tenv;
            lb_sdt.Text = SDT;
            lb_chucvu.Text = chucvu;
            lb_diachi.Text = diachi;
        }
        private void gunaLinePanel2_MouseEnter(object sender, EventArgs e)
        {
            gunaLinePanel2.BackColor = Color.FromArgb(220, 250, 252);
        }

        private void gunaLinePanel2_MouseLeave(object sender, EventArgs e)
        {
            gunaLinePanel2.BackColor = Color.White;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataTable a = StaffDAO.Instance.ViewStaff(manv);
            string user = a.Rows[0]["username"].ToString();
            DataTable c = StaffDAO.Instance.viewuser(user);
            DateTime b = DateTime.Parse(a.Rows[0]["ngay_sinh"].ToString());
            string mail = "";
            if (c.Rows.Count>0) mail = c.Rows[0]["email"].ToString();
            string gioitinh = a.Rows[0]["gioi_tinh"].ToString();
            (new EditStaff(manv, tenv,b,gioitinh,SDT,diachi,user,mail)).ShowDialog();
            _parent.loadstaff();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                // e.Cancel = true;
            }
            else
            {
                StaffDAO.Instance.Delete(manv);
            }
            _parent.loadstaff();
        }

        private void gunaLinePanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lb_manv_Click(object sender, EventArgs e)
        {
            DataTable a = StaffDAO.Instance.ViewStaff(manv);
            string b = DateTime.Parse(a.Rows[0]["ngay_sinh"].ToString()).ToString("dd - MM - yyyy");
            string gioitinh = a.Rows[0]["gioi_tinh"].ToString();
            string user = a.Rows[0]["username"].ToString();
            DataTable c = StaffDAO.Instance.viewuser(user);
            string email = "";
            if (c.Rows.Count > 0) email = c.Rows[0]["email"].ToString();
            (new lb_gioitinh(manv, tenv, b, gioitinh, SDT, user, email, diachi, chucvu)).ShowDialog();
        }

        private void gunaLinePanel2_Click(object sender, EventArgs e)
        {
            DataTable a = StaffDAO.Instance.ViewStaff(manv);
            string b = DateTime.Parse(a.Rows[0]["ngay_sinh"].ToString()).ToString("dd - MM - yyyy");
            string gioitinh = a.Rows[0]["gioi_tinh"].ToString();
            string user = a.Rows[0]["username"].ToString();
            DataTable c = StaffDAO.Instance.viewuser(user);
            string email = "";
            if (c.Rows.Count > 0) email = c.Rows[0]["email"].ToString();
            (new lb_gioitinh(manv,tenv,b,gioitinh,SDT,user,email,diachi,chucvu)).ShowDialog();
        }

        private void lb_tennv_Click(object sender, EventArgs e)
        {
            DataTable a = StaffDAO.Instance.ViewStaff(manv);
            string b = DateTime.Parse(a.Rows[0]["ngay_sinh"].ToString()).ToString("dd - MM - yyyy");
            string gioitinh = a.Rows[0]["gioi_tinh"].ToString();
            string user = a.Rows[0]["username"].ToString();
            DataTable c = StaffDAO.Instance.viewuser(user);
            string email = "";
            if (c.Rows.Count > 0) email = c.Rows[0]["email"].ToString();
            (new lb_gioitinh(manv, tenv, b, gioitinh, SDT, user, email, diachi, chucvu)).ShowDialog();
        }

        private void lb_sdt_Click(object sender, EventArgs e)
        {
            DataTable a = StaffDAO.Instance.ViewStaff(manv);
            string b = DateTime.Parse(a.Rows[0]["ngay_sinh"].ToString()).ToString("dd - MM - yyyy");
            string gioitinh = a.Rows[0]["gioi_tinh"].ToString();
            string user = a.Rows[0]["username"].ToString();
            DataTable c = StaffDAO.Instance.viewuser(user);
            string email = "";
            if (c.Rows.Count > 0) email = c.Rows[0]["email"].ToString();
            (new lb_gioitinh(manv, tenv, b, gioitinh, SDT, user, email, diachi, chucvu)).ShowDialog();
        }

        private void lb_chucvu_Click(object sender, EventArgs e)
        {
            DataTable a = StaffDAO.Instance.ViewStaff(manv);
            string b = DateTime.Parse(a.Rows[0]["ngay_sinh"].ToString()).ToString("dd - MM - yyyy");
            string gioitinh = a.Rows[0]["gioi_tinh"].ToString();
            string user = a.Rows[0]["username"].ToString();
            DataTable c = StaffDAO.Instance.viewuser(user);
            string email = "";
            if (c.Rows.Count > 0) email = c.Rows[0]["email"].ToString();
            (new lb_gioitinh(manv, tenv, b, gioitinh, SDT, user, email, diachi, chucvu)).ShowDialog();
        }

        private void lb_diachi_Click(object sender, EventArgs e)
        {
            DataTable a = StaffDAO.Instance.ViewStaff(manv);
            string b = DateTime.Parse(a.Rows[0]["ngay_sinh"].ToString()).ToString("dd - MM - yyyy");
            string gioitinh = a.Rows[0]["gioi_tinh"].ToString();
            string user = a.Rows[0]["username"].ToString();
            DataTable c = StaffDAO.Instance.viewuser(user);
            string email = "";
            if (c.Rows.Count > 0) email = c.Rows[0]["email"].ToString();
            (new lb_gioitinh(manv, tenv, b, gioitinh, SDT, user, email, diachi, chucvu)).ShowDialog();
        }
    }
}
