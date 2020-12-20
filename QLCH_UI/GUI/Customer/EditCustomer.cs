using QLCH_UI.BUS;
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
    public partial class EditCustomer : Form
    {
        public EditCustomer(string ma_kh, string tenkh, DateTime ngay_sinh, string dia_chi, string dien_thoai, string gioi_tinh)
        {
            InitializeComponent();
            tb_makh.Text = ma_kh;
            tb_ten_kh.Text = tenkh;
            date_kh.Value = ngay_sinh;
            tb_dia_chi.Text = dia_chi;
            tb_phone.Text = dien_thoai;
            if (gioi_tinh == "Nam") Radio_Nam.Checked = true;
            else Radio_Nu.Checked = true;
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lb_gioi_tinh_erro_Click(object sender, EventArgs e)
        {

        }

        private void Radio_Nu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Radio_Nam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // check_erro
        public bool check_erro()
        {
            if (CustomersBUS.Instance.ten_kh(tb_ten_kh.Text) == true) lb_tenkh_error.Visible = false;
            else
            {
                lb_tenkh_error.Visible = true;
                return (false);
            }
            if (CustomersBUS.Instance.gioi_tinh(Radio_Nam.Checked,Radio_Nu.Checked) == true) lb_gioitinh_error.Visible = false;
            else
            {
                lb_gioitinh_error.Visible = true;
                return (false);
            }
            if (CustomersBUS.Instance.SDT(tb_phone.Text) == true) lb_SDT_error.Visible = false;
            else
            {
                lb_SDT_error.Visible = true;
                return (false);
            }
            if (CustomersBUS.Instance.dia_chi(tb_dia_chi.Text) == true) lb_diachi_error.Visible = false;
            else
            {
                lb_diachi_error.Visible = true;
                return (false);
            }
            return (true);
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_luu_customer_Click_1(object sender, EventArgs e)
        {
            if (check_erro() == true)
            {
                string a;
                if (Radio_Nam.Checked == true) a = Radio_Nam.Text;
                else a = Radio_Nu.Text;
                CustomersDTO b = new CustomersDTO(tb_makh.Text, tb_ten_kh.Text, date_kh.Value, tb_dia_chi.Text, tb_phone.Text, a);
                if (CustomersBUS.Instance.edit_customer(b) == true)
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
    }
}
