using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCH_UI.BUS;
using QLCH_UI.DTO;

namespace QLCH_UI
{
    public partial class EditStaff : Form
    {
        public EditStaff(string manv, string tennv, DateTime ngaysinh, string gioitinh, string sdt, string diachi, string user, string email)
        {
            InitializeComponent();
            tb_manv.Text = manv;
            tb_ten_nv.Text = tennv;
            date_nv.Value = ngaysinh;
            tb_dia_chi.Text = diachi;
            tb_phone.Text = sdt;
            if (gioitinh == "Nam") Radio_Nam.Checked = true;
            else Radio_Nu.Checked = true;
            tb_user.Text = user;
            tb_email.Text = email;
            if (email == "") tb_email.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // check_erro
        public bool check_erro()
        {
            string a = "";
            a = StaffBUS.Instance.Check_email(tb_email.Text);
            if ((a!= "" || a!= "Email is already taken. Please choose another email.") && tb_email.ReadOnly == false) lb_email_error.Visible = false;
            else
            {
                lb_email_error.Visible = true;
                return (false);
            }

            if (CustomersBUS.Instance.makh(tb_manv.Text) == true) lb_manv_error.Visible = false;
            else
            {
                lb_manv_error.Visible = true;
                return (false);
            }
            if (CustomersBUS.Instance.ten_kh(tb_ten_nv.Text) == true) lb_ten_nv_error.Visible = false;
            else
            {
                lb_ten_nv_error.Visible = true;
                return (false);
            }
            if (CustomersBUS.Instance.gioi_tinh(Radio_Nam.Checked, Radio_Nu.Checked) == true) lb_gioi_tinh_error.Visible = false;
            else
            {
                lb_gioi_tinh_error.Visible = true;
                return (false);
            }
            if (CustomersBUS.Instance.SDT(tb_phone.Text) == true) lb_sdt_error.Visible = false;
            else
            {
                lb_sdt_error.Visible = true;
                return (false);
            }
            if (CustomersBUS.Instance.dia_chi(tb_dia_chi.Text) == true) lb_dia_chi_error.Visible = false;
            else
            {
                lb_dia_chi_error.Visible = true;
                return (false);
            }
            if (cb_loainv.Text == "")
            {
                lb_loainv_error.Visible = true;
                return (false);
            }
            else lb_loainv_error.Visible = true;
            return (true);
        }




        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EditStaff_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_luu_customer_Click_1(object sender, EventArgs e)
        {
            if (check_erro() == true)
            {
                string a;
                if (Radio_Nam.Checked == true) a = Radio_Nam.Text;
                else a = Radio_Nu.Text;
                StaffDTO b = new StaffDTO(tb_user.Text, tb_manv.Text, tb_ten_nv.Text, date_nv.Value, tb_dia_chi.Text, tb_phone.Text, a, cb_loainv.Text);
                if (StaffBUS.Instance.edit_staff(b, tb_user.Text, tb_email.Text) == true)
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Sửa không thành công");
                }
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
