using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCH_UI.DAO;
using QLCH_UI.DTO;
using QLCH_UI.BUS;

namespace QLCH_UI
{
    public partial class StaffsForm : Form
    {
        public StaffsForm()
        {
            InitializeComponent();
            loadstaff();
        }

        public void loadstaff()
        {
            dgvStaffs.Rows.Clear();
            DataTable a = StaffDAO.Instance.Stafflist();
            for (int i = 0; i < a.Rows.Count; i++)
            {
                string manv = a.Rows[i]["manv"].ToString();
                string tennv = a.Rows[i]["ten_nv"].ToString();
                string sdt = a.Rows[i]["dien_thoai"].ToString();
                dgvStaffs.Rows.Add(manv, tennv, sdt);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStaff f = new AddStaff();
            f.ShowDialog();
            loadstaff();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvStaffs.SelectedRows.Count > 0 )
            {
                DataGridViewRow row = dgvStaffs.SelectedRows[0];
                String ID = row.Cells[0].Value.ToString();
                string ma_nv = "";
                string ten_nv = "";
                string ngay_sinh = "";
                string dia_chi = "";
                string dien_thoai = "";
                string gioi_tinh = "";
                string user = "";
                DataTable a = StaffDAO.Instance.ViewStaff(ID);
                ma_nv = a.Rows[0]["manv"].ToString();
                ten_nv = a.Rows[0]["ten_nv"].ToString();
                ngay_sinh = a.Rows[0]["ngay_sinh"].ToString();
                dien_thoai = a.Rows[0]["dien_thoai"].ToString();
                dia_chi = a.Rows[0]["dia_chi"].ToString();
                gioi_tinh = a.Rows[0]["gioi_tinh"].ToString();
                user = a.Rows[0]["username"].ToString();
                DateTime ngay_sinhh = DateTime.Parse(ngay_sinh);
                DataTable b = StaffDAO.Instance.viewuser(user);
                string email = "";
                if (b.Rows.Count > 0) email = b.Rows[0]["email"].ToString();
                EditStaff f = new EditStaff(ma_nv,ten_nv,ngay_sinhh,gioi_tinh,dien_thoai,dia_chi,user,email);
                f.ShowDialog();
                loadstaff();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStaffs.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvStaffs.SelectedRows[0];
                string ID = row.Cells[0].Value.ToString();
                DataTable b = StaffDAO.Instance.ViewStaff(ID);
                string user = b.Rows[0]["username"].ToString();
                if (StaffBUS.Instance.delete_staff(ID,user))
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
                loadstaff();
            }
        }

        private void dgvStaffs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStaffs.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvStaffs.SelectedRows[0];
                string ID = row.Cells[0].Value.ToString();
                DataTable a = StaffDAO.Instance.ViewStaff(ID);
                DataTable b = StaffDAO.Instance.viewuser(a.Rows[0]["username"].ToString());
                string manv = a.Rows[0]["manv"].ToString();
                string tennv = a.Rows[0]["ten_nv"].ToString();
                string ngaysinh = a.Rows[0]["ngay_sinh"].ToString();
                string diachi = a.Rows[0]["dia_chi"].ToString();
                string dienthoai = a.Rows[0]["dien_thoai"].ToString();
                string gioitinh = a.Rows[0]["gioi_tinh"].ToString();
                string user = a.Rows[0]["username"].ToString();
                string email = "";
                if(b.Rows.Count > 0 )  email = b.Rows[0]["email"].ToString();
                lb_gioitinh f = new lb_gioitinh(manv,tennv,ngaysinh,gioitinh,dienthoai,user,email);
                f.ShowDialog();
            }
        }
    }
}
