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
using QLCH_UI.DAO;

namespace QLCH_UI
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
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
            if (ProductBUS.Instance.so_luong(tb_sl.Text) == true) lb_soluong_error.Visible = false;
            else
            {
                lb_soluong_error.Visible = true;
                return (false);
            }    
            return (true);
        }
   
        

        private void lb_tensp_error_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_masp_error_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_luu_customer_Click_1(object sender, EventArgs e)
        {
            int rs = 0;
            DataTable aa = ProductDAO.Instance.Productlist();
            for (int i = 0; i < aa.Rows.Count; i++)
            {
                string k = aa.Rows[i]["masp"].ToString();
                int l = k.Length;
                int tg = int.Parse(k.Substring(2, l - 2));
                if (tg > rs) rs = tg;
            }
            rs++;
            string p = "";
            if (cb_loaisp.Text == "Laptop") p = "LT";
            if (cb_loaisp.Text == "Điện thoại") p = "DT";
            if (cb_loaisp.Text == "Linh kiện") p = "LK";
            if (cb_loaisp.Text == "Phụ kiện") p = "PK";
            if (cb_loaisp.Text == "Khác") p = "SP";
            if (rs > 9) p = p + rs.ToString();
            else p = p + "0" + rs.ToString();
            if (tb_masp.Text=="") tb_masp.Text = p;
            if (check_error() == true)
            {
                if (kt == true)
                {
                    byte[] k = ProductBUS.Instance.ImageToByteArray(this.Text);
                    l = Convert.ToBase64String(k);
                }
                ProductDTO a = new ProductDTO(l, tb_masp.Text, tb_ten_sp.Text, cb_loaisp.Text, double.Parse(tb_gianhap.Text), double.Parse(tb_giaban.Text), int.Parse(tb_sl.Text), 1);
                if (ProductBUS.Instance.insert_product(a))
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Không thêm thành công");
                }
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool kt = false;
        string l= "iVBORw0KGgoAAAANSUhEUgAAAEAAAABACAYAAACqaXHeAAAC3ElEQVR4Xu2aO2gUURSGv2Sz2VWxCIg2sVVBQSws7bTSRlQSsLUUHwHBQmy0sLAQbMRCUgi21rHQymbZJg8VCyFgIwiKiUtikl2bO7B7c2fOmXHe3g9 + CJNz7tz / 353XnQWPx+PxeDyeUWaBFWAHGFRcfeCj8aRiRjFoVTUjmQdYVgxUVS3bZsccAWwDDcf2OtDXeLNTewBMSk0lpAU8cvgRsRuqaD5gSgpg3N03wh+poMRsSQWaAGpNlQJoA3NAF9gw6gK3zfHuQnXM28Q+aeTAYeHyvARMO/r2JfETuyFj2sp7kyXHN2FvEj+xGzJmTmE+0C2rtxYBdBXGA3Ws3loEsKEwHqhn9e6R/FTpKpAJVQhgRSoYIk4tVCSAl1LBEHZtokM4i3NAI+TJU0PLXOKk43/RcRlsJ/ETuyGCNvAC2ATWgIcJg5gWQlgMuREqPIBXjvEeS00htMx1vmPO9j3z982IW+FWEj+xG0K4F/GJ3ZWaU6KwAC6a1ZewAAbANWmQFJhM4id2g8VJYF0wPzBLb5ekwf6R3AM4BKwqzAfaBM5KgwJNo7jkGkALeK8wbWsNOB0x7nVTs57gsGkm8RO7wTCvMBum78Axa7wJ4JlV1weuhuzfRW4B3FGYlPQVOGHGOwgshNRtAReE+QTkEsD5FF+hbZsbnt9CXQ84I03MfIvi+onVcBz4pTCWhX4Cp4T5ZRrAAeCLYqJZ6htwJGKODUePiKahCbxTTDAPrYY8B5BlAM8VE8tTH8w30iaTAG4oJlSEOsB+a67jjjqRqIZz5kwtTaYovTWPwAGpBnAU+KGYRNF6PfQKPLUApoDPip2XRfNm4WXM8T8Ru2ECeKPYadn0JK0Anip2Vlbdd2wbwbU+t6uoZox4rsKyeKb4AKSCuuMDkArqjiuAvmNbXdjlzRXAJ8e2uqB6e1znH0tflswHzJpn7LTW+orUjvnkr0imPR6Px+Px/F/8BbXhWSFnrGbjAAAAAElFTkSuQmCC";
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
                kt = true;
            }
        }
    }
}
