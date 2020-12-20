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
            int rs = 0;
            DataTable a = StaffDAO.Instance.Stafflist();
            for (int i = 0; i < a.Rows.Count; i++)
            {
                string k = a.Rows[i]["manv"].ToString();
                int l = k.Length;
                int tg = int.Parse(k.Substring(2, l - 2));
                if (tg > rs) rs = tg;
            }
            rs++;
            string p = "";
            if (rs > 9) p = "NV" + rs.ToString();
            else p = "NV" + "0" + rs.ToString();
            InitializeComponent();
            tb_manv.Text = p;
        }
        public bool check_erro()
        {
            if (StaffBUS.Instance.Check(tb_user.Text,tb_password.Text,tb_confirmpassword.Text,tb_email.Text) == "") lb_password_error.Visible = false;
            else
            {
                lb_password_error.Text = StaffBUS.Instance.Check(tb_user.Text, tb_password.Text, tb_confirmpassword.Text, tb_email.Text);
                lb_password_error.Visible = true;
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
            else lb_loainv_error.Visible = false;
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



        private void lb_dia_chi_error_Click(object sender, EventArgs e)
        {

        }

        private void lb_sdt_error_Click(object sender, EventArgs e)
        {

        }

        private void tb_dia_chi_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void tb_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void gunaLinePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_luu_customer_Click_1(object sender, EventArgs e)
        {
            string a;
            if (check_erro() == true)
            {
                if (Radio_Nam.Checked == true) a = Radio_Nam.Text;
                else a = Radio_Nu.Text;
                StaffDTO b = new StaffDTO(tb_user.Text, tb_manv.Text, tb_ten_nv.Text, date_nv.Value, tb_dia_chi.Text, tb_phone.Text, a, cb_loainv.Text);
                if (StaffBUS.Instance.insert_staff(b, tb_user.Text, tb_email.Text, tb_password.Text) == true)
                {
                    MessageBox.Show("Thêm thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
                //this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
