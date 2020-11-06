using QLCH_UI.BUS;
using QLCH_UI.DAO;
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
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // hàm kiếm tra chuỗi
        public bool isnumber(string value, int k)
        {
            int l = value.Length;
            if (k == 1) l = l - 1;
            for (int i = 0; i < l; i++)
                if (!char.IsDigit(value[i])) return (false);
            return (true);
        }

        private void tb_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool kt = true;
            int k = 0;
            //kiểm tra ký tự vừa nhập
            if (e.KeyChar != '\b')
            {
                if (char.IsDigit(e.KeyChar))
                {
                    tb_phone.BackColor = Color.White;
                    lb_sdt_customer_erro.Visible = false;
                }
                else
                {
                    kt = false;
                    tb_phone.BackColor = Color.Red;
                    lb_sdt_customer_erro.Visible = true;
                }
            }
            else k = 1;
            // kiểm tra chuỗi
            if (isnumber(tb_phone.Text, k) == true)
            {
                tb_phone.BackColor = Color.White;
                lb_sdt_customer_erro.Visible = false;
            }
            else
            {
                tb_phone.BackColor = Color.Red;
                lb_sdt_customer_erro.Visible = true;
            }
            if (kt == false)
            {
                tb_phone.BackColor = Color.Red;
                lb_sdt_customer_erro.Visible = true;
            }
        }
        // kiem tra ma khach hang
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
            if (l > 12 || l==0) return (false);
            return (true);
        }
        // Kiem tra gioi tinh
        public bool gioi_tinh()
        {
            if (Radio_Nam.Checked == false && Radio_Nu.Checked == false) return (false);
            return (true);
        }
        // kiem tra ten khach hang
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
            if (makh(tb_makh.Text) == true) lb_makh_customer_erro.Visible = false;
            else lb_makh_customer_erro.Visible = true;
            if (ten_kh(tb_ten_kh.Text) == true) lb_tenkh_erro.Visible = false;
            else lb_tenkh_erro.Visible = true;
            if (gioi_tinh() == true) lb_gioi_tinh_erro.Visible = false;
            else lb_gioi_tinh_erro.Visible = true;
            if (dia_chi(tb_dia_chi.Text) == true) lb_diachi_erro.Visible = false;
            else lb_diachi_erro.Visible = true;
            if (SDT(tb_phone.Text) == true) lb_sdt_customer_erro.Visible = false;
            else lb_sdt_customer_erro.Visible = true;
            if (lb_makh_customer_erro.Visible == false
                && lb_tenkh_erro.Visible == false
                && lb_gioi_tinh_erro.Visible == false
                && lb_diachi_erro.Visible == false
                && lb_sdt_customer_erro.Visible == false) return (true);
            else return (false);
        }

        private void btn_luu_customer_Click(object sender, EventArgs e)
        {
            string a;
            if (check_erro() == true)
            {
                if (Radio_Nam.Checked == true) a = Radio_Nam.Text;
                else a = Radio_Nu.Text;
                CustomersDTO b = new CustomersDTO(tb_makh.Text, tb_ten_kh.Text, date_kh.Value, tb_phone.Text, tb_dia_chi.Text, a);
                if (CustomersBUS.Instance.insert_customer(b))
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

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
