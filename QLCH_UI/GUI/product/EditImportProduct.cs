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
using QLCH_UI.DAO;


namespace QLCH_UI
{
    public partial class EditImportProduct : Form
    {
        int soluong1 = 0;
        public EditImportProduct(string manhaphang, string tensp, string masanpham, string loaisp, DateTime ngay_nhap, int so_luong, string gia_nhap, string manguoinhap, Image img)
        {
            InitializeComponent();
            tb_manhaphang.Text = manhaphang;
            tb_masp.Text = masanpham;
            tb_ten_sp.Text = tensp;
            tb_loai_sp.Text = loaisp;
            date_sp.Value = ngay_nhap;
            tb_sl.Text = so_luong.ToString();
            double gia = double.Parse(gia_nhap);
            soluong1 = so_luong;
            tb_gia_nhap.Text = Convert.ToDouble(gia).ToString("#,##0");
            pictureBox1.Image = img;
            tb_manguoinhap.Text = manguoinhap;
        }
        public bool check_erro()
        {
            if (ProductBUS.Instance.so_luong(tb_sl.Text)) lb_sl_error.Visible = false;
            else
            {
                lb_sl_error.Visible = true;
                return (false);
            }
            if (ProductBUS.Instance.gia_nhap(GetFloat(tb_gia_nhap.Text))) lb_gianhap_error.Visible = false;
            else
            {
                lb_gianhap_error.Visible = true;
                return (false);
            }
            return (true);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string gianhap="0";
        private string GetFloat(string s)
        {
            string rs = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ',') rs += s[i];
            }
            return rs;
        }
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_luu_customer_Click_1(object sender, EventArgs e)
        {
            if (check_erro())
            {
                int a = int.Parse(tb_sl.Text);
                a = soluong1 - a;
                if (WareHouseBUS.Instance.kt_sl(a, tb_masp.Text))
                {
                    decimal tongtien = (decimal)(double.Parse(tb_gia_nhap.Text) * int.Parse(tb_sl.Text));
                    WarehouseDTO c = new WarehouseDTO(tb_manhaphang.Text, tb_manguoinhap.Text, tb_masp.Text, tb_ten_sp.Text, tb_loai_sp.Text, date_sp.Value, double.Parse(tb_gia_nhap.Text), int.Parse(tb_sl.Text), tongtien);
                    if (WareHouseBUS.Instance.edit(c)) MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Số lượng tồn kho không đủ hoặc sản phẩm không còn tồn tại");
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
