using QLCH_UI.BUS;
using QLCH_UI.DTO;
using QLCH_UI.DAO;
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
    public partial class EditProduct : Form
    {
        bool kt = true;
        string imgg="";
        public EditProduct(string anh, string masp,string ten_sp,string loai_sp,double gia_nhap,double gia_ban)
        {
            InitializeComponent();
            pictureBox1.Image = ProductBUS.Instance.ByteToImg(anh);
            tb_masp.Text = masp;
            tb_ten_sp.Text = ten_sp;
            tb_giaban.Text = gia_ban.ToString();
            tb_gianhap.Text = gia_nhap.ToString();
            cb_loaisp.Text = loai_sp;
            imgg = anh;
        }
        public bool check_error()
        {
            if (ProductBUS.Instance.ten_sp(tb_ten_sp.Text) == true) lb_tensp_error.Visible = false;
            else
            {
                lb_tensp_error.Visible = true;
                return (false);
            }
            if (ProductBUS.Instance.masp(tb_masp.Text) == true) lb_masp_error.Visible = false;
            else
            {
                lb_masp_error.Visible = true;
                return (false);
            }
            if (ProductBUS.Instance.loai_sp(cb_loaisp.Text) == true) lb_loaisp_error.Visible = false;
            else
            {
                lb_loaisp_error.Visible = true;
                return (false);
            }

            if (ProductBUS.Instance.gia_nhap(tb_gianhap.Text) == true) lb_gianhap_error.Visible = false;
            else
            {
                lb_gianhap_error.Visible = true;
                return (false);
            }
            if (ProductBUS.Instance.gia_ban(tb_giaban.Text) == true) lb_giaban_error.Visible = false;
            else
            {
                lb_giaban_error.Visible = true;
                return (false);
            }
            return (true);
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
        private void tb_gianhap_TextChanged(object sender, EventArgs e)
        {
            if (tb_gianhap.Text.Length > 10) tb_gianhap.Text = Convert.ToDouble(gianhap).ToString("#,##0");
            if (tb_gianhap.Text.Length > 0)
            {
                foreach (char i in tb_gianhap.Text)
                {
                    if ((i > '9' || i < '0') && (i != ','))
                    {
                        tb_gianhap.Text = Convert.ToDouble(gianhap).ToString("#,##0");
                        break;
                    }
                }
                gianhap = GetFloat(tb_gianhap.Text);
                tb_gianhap.Text = Convert.ToDouble(GetFloat(tb_gianhap.Text)).ToString("#,##0");
                tb_gianhap.SelectionStart = tb_gianhap.Text.Length;
            }
        }
        string giaban = "0";
        private void tb_giaban_TextChanged(object sender, EventArgs e)
        {
            if (tb_giaban.Text.Length > 10) tb_giaban.Text = Convert.ToDouble(giaban).ToString("#,##0");
            if (tb_giaban.Text.Length > 0)
            {
                foreach (char i in tb_giaban.Text)
                {
                    if ((i > '9' || i < '0') && (i != ','))
                    {
                        tb_giaban.Text = Convert.ToDouble(giaban).ToString("#,##0");
                        break;
                    }
                }
                giaban = GetFloat(tb_giaban.Text);
                tb_giaban.Text = Convert.ToDouble(GetFloat(tb_giaban.Text)).ToString("#,##0");
                tb_giaban.SelectionStart = tb_giaban.Text.Length;
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFile.FileName);
                this.Text = openFile.FileName;
                kt = false;
            }
        }

        private void btn_luu_customer_Click_1(object sender, EventArgs e)
        {
            if (check_error() == true)
            {
                DataTable c = ProductDAO.Instance.viewinfo(tb_masp.Text);
                int so_luong = int.Parse(c.Rows[0]["so_luong"].ToString());
                ProductDTO a;
                if (kt == true)
                {
                    a = new ProductDTO(imgg, tb_masp.Text, tb_ten_sp.Text, cb_loaisp.Text, double.Parse(tb_gianhap.Text), double.Parse(tb_giaban.Text), so_luong, 1);
                }
                else
                {
                    byte[] k = ProductBUS.Instance.ImageToByteArray(this.Text);
                    string l = Convert.ToBase64String(k);
                    a = new ProductDTO(l, tb_masp.Text, tb_ten_sp.Text, cb_loaisp.Text, double.Parse(tb_gianhap.Text), double.Parse(tb_giaban.Text), so_luong, 1);
                }
                if (ProductBUS.Instance.edit_product(a))
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Không sửa thành công");
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

        private void tb_gianhap_TextChanged_1(object sender, EventArgs e)
        {
            if (tb_gianhap.Text.Length > 10) tb_gianhap.Text = Convert.ToDouble(gianhap).ToString("#,##0");
            if (tb_gianhap.Text.Length > 0)
            {
                foreach (char i in tb_gianhap.Text)
                {
                    if ((i > '9' || i < '0') && (i != ','))
                    {
                        tb_gianhap.Text = Convert.ToDouble(gianhap).ToString("#,##0");
                        break;
                    }
                }
                gianhap = GetFloat(tb_gianhap.Text);
                tb_gianhap.Text = Convert.ToDouble(GetFloat(tb_gianhap.Text)).ToString("#,##0");
                tb_gianhap.SelectionStart = tb_gianhap.Text.Length;
            }
        }

        private void tb_giaban_TextChanged_1(object sender, EventArgs e)
        {
            if (tb_giaban.Text.Length > 10) tb_giaban.Text = Convert.ToDouble(giaban).ToString("#,##0");
            if (tb_giaban.Text.Length > 0)
            {
                foreach (char i in tb_giaban.Text)
                {
                    if ((i > '9' || i < '0') && (i != ','))
                    {
                        tb_giaban.Text = Convert.ToDouble(giaban).ToString("#,##0");
                        break;
                    }
                }
                giaban = GetFloat(tb_giaban.Text);
                tb_giaban.Text = Convert.ToDouble(GetFloat(tb_giaban.Text)).ToString("#,##0");
                tb_giaban.SelectionStart = tb_giaban.Text.Length;
            }
        }
    }
}
