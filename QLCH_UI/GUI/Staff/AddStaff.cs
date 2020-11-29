using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCH_UI.DTO;
using QLCH_UI.DAO;
using QLCH_UI.BUS;

namespace QLCH_UI
{
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
        }
        public bool check_erro()
        {
            if (StaffBUS.Instance.Check(tb_user.Text,tb_password.Text,tb_confirmpassword.Text,tb_email.Text) == "") lb_password_error.Visible = false;
            else
            {
                MessageBox.Show(StaffBUS.Instance.Check(tb_user.Text, tb_password.Text, tb_confirmpassword.Text, tb_email.Text));
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
            return (true);
        }

   

        private void label10_Click(object sender, EventArgs e)
        {

        }

    
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_gioi_tinh_error_Click(object sender, EventArgs e)
        {

        }

        private void btn_luu_customer_Click(object sender, EventArgs e)
        {
            string a;
            if (check_erro() == true)
            {
                if (Radio_Nam.Checked == true) a = Radio_Nam.Text;
                else a = Radio_Nu.Text;
                StaffDTO b = new StaffDTO(tb_user.Text, tb_manv.Text, tb_ten_nv.Text, date_nv.Value, tb_dia_chi.Text, tb_phone.Text, a);
                if (StaffBUS.Instance.insert_staff(b, tb_user.Text, tb_email.Text, tb_password.Text) == true)
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
                this.Close();
            }
        }
    }
}
