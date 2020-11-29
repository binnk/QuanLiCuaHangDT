using QLCH_UI.BUS;
using QLCH_UI.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QLCH_UI
{
    public partial class ImportProducts : Form
    {
        public ImportProducts(string masp, string ten_sp, string loai_sp, string gia_nhap, Image anh)
        {
            InitializeComponent();
            tb_masp.Text = masp;
            tb_loai_sp.Text = loai_sp;
            tb_gia_nhap.Text = gia_nhap;
            tb_ten_sp.Text = ten_sp;
            pictureBox1.Image = anh;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void lb_sl_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool check_error()
        {
            if (ProductBUS.Instance.gia_nhap(tb_gia_nhap.Text) == true) lb_gianhap_error.Visible = false;
            else
            {
                lb_gianhap_error.Visible = true;
                return (false);
            }
            if (ProductBUS.Instance.so_luong(tb_sl.Text) == true) lb_sl_error.Visible = false;
            else
            {
                lb_sl_error.Visible = true;
                return (false);
            }
            return (true);
        }
        private void btn_luu_customer_Click(object sender, EventArgs e)
        {
            if (check_error()==true)
            {
                WarehouseDTO a = new WarehouseDTO(tb_masp.Text, tb_ten_sp.Text, tb_loai_sp.Text, date_sp.Value, double.Parse(tb_gia_nhap.Text), int.Parse(tb_sl.Text));
                if (WareHouseBUS.Instance.ImportWarehouse(a))
                {
                    MessageBox.Show("Nhập hàng thành công");
                }
                else
                {
                    MessageBox.Show("Không nhập hàng thành công");
                }
                this.Close();
            }

        }
        private string GetFloat(string s)
        {
            string rs = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ',') rs += s[i];
            }
            return rs;
        }
        string gianhap = "0";
        private void tb_gia_nhap_TextChanged(object sender, EventArgs e)
        {
            if (tb_gia_nhap.Text.Length > 10) tb_gia_nhap.Text = Convert.ToDouble(gianhap).ToString("#,##0");
            if (tb_gia_nhap.Text.Length > 0)
            {
                foreach (char i in tb_gia_nhap.Text)
                {
                    if ((i > '9' || i < '0') && (i != ','))
                    {
                        tb_gia_nhap.Text = Convert.ToDouble(gianhap).ToString("#,##0");
                        break;
                    }
                }
                gianhap = GetFloat(tb_gia_nhap.Text);
                tb_gia_nhap.Text = Convert.ToDouble(GetFloat(tb_gia_nhap.Text)).ToString("#,##0");
                tb_gia_nhap.SelectionStart = tb_gia_nhap.Text.Length;
            }
        }
    }
}
