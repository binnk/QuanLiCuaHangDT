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



        // kiem tra ma 
        public bool makh(string value)
        {
            int l = value.Length;
            if (l == 0) return (false);
            int k = 1;
            if (l > 9) return (false);
            for (int i = 0; i < l; i++)
            {
                if ((value[i] >= 65 && value[i] <= 90) || (value[i] >= 97 && value[i] <= 122) || (value[i] >= 48 && value[i] <= 57)) k = 1;
                else return (false);
            }
            return (true);
        }
        // kiem tra SDT
        public bool SDT(string value)
        {
            int l = value.Length;
            for (int i = 0; i < l; i++) if (value[i] < 48 || value[i] > 57) return (false);
            if (l > 12 || l == 0) return (false);
            return (true);
        }
        // Kiem tra gioi tinh
        public bool gioi_tinh()
        {
            if (Radio_Nam.Checked == false && Radio_Nu.Checked == false) return (false);
            return (true);
        }
        // kiem tra ten 
        public bool ten_kh(string value)
        {
            int l = value.Length;
            if (l > 49 || l == 0) return false;
            return (true);
        }
        // kiem tra dia chi
        public bool dia_chi(string value)
        {
            int l = value.Length;
            if (l > 99 || l == 0) return false;
            return (true);
        }
        // check_erro
        public bool check_erro()
        {
            if (ten_kh(tb_ten_kh.Text) == true) lb_tenkh_error.Visible = false;
            else
            {
                lb_tenkh_error.Visible = true;
                return (false);
            }
            if (gioi_tinh() == true) lb_gioitinh_error.Visible = false;
            else
            {
                lb_gioitinh_error.Visible = true;
                return (false);
            }
            if (SDT(tb_phone.Text) == true) lb_SDT_error.Visible = false;
            else
            {
                lb_SDT_error.Visible = true;
                return (false);
            }
            if (dia_chi(tb_dia_chi.Text) == true) lb_diachi_error.Visible = false;
            else
            {
                lb_diachi_error.Visible = true;
                return (false);
            }
            return (true);
        }
        private void btn_luu_customer_Click(object sender, EventArgs e)
        {
            if (check_erro() == true)
            {
                string a;
                if (Radio_Nam.Checked == true) a = Radio_Nam.Text;
                else a = Radio_Nu.Text;
                CustomersDTO b = new CustomersDTO(tb_makh.Text, tb_ten_kh.Text, date_kh.Value, tb_phone.Text, tb_dia_chi.Text, a);
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
