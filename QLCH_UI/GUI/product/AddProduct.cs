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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
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
            }
        }
        // kiem tra ma 
        public bool masp(string value)
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
        // kiem tra ten 
        public bool ten_sp(string value)
        {
            int l = value.Length;
            if (l > 49 || l == 0) return false;
            return (true);
        }
        //kiem tra loai_sp
        public bool loai_sp(string value)
        {
            int l = value.Length;
            if (l == 0) return (false);
            return (true);
        }
    
        //gia nhap
        public bool gia_nhap(string value)
        {
            int l = value.Length;
            if (value[0] == '.') return (false);
            if (l == 0) return (false);
            int d = 0;
            for (int i = 0; i < l; i++)
                if (value[i] == '.')
                {
                    d++;
                    if (d == 2) return (false);
                }
                else
                {
                    if (value[i] < 48 || value[i] > 57) return (false);
                }
            return (true);
        }
        // gia ban
        public bool gia_ban(string value)
        {
            int l = value.Length;
            if (value[0] == '.') return (false);
            if (l == 0) return (false);
            int d = 0;
            for (int i=0;i<l;i++)
                if (value[i]=='.')
                {
                    d++;
                    if (d == 2) return (false);
                }
                else
                {
                    if (value[i] < 48 || value[i] > 57) return (false);
                }
            return (true);
        }
       
        public bool check_error()
        {
            if (ten_sp(tb_ten_sp.Text) == true) lb_tensp_error.Visible = false;
            else
            {
                lb_tensp_error.Visible = true;
                return (false);
            }
            if (masp(tb_masp.Text) == true) lb_masp_error.Visible = false;
            else
            {
                lb_masp_error.Visible = true;
                return (false);
            }
            if (loai_sp(cb_loaisp.Text) == true) lb_loaisp_error.Visible = false;
            else
            {
                lb_loaisp_error.Visible = true;
                return (false);
            }
         
            if (gia_nhap(tb_gianhap.Text) == true) lb_gianhap_error.Visible = false;
            else
            {
                lb_gianhap_error.Visible = true;
                return (false);
            }
            if (gia_ban(tb_giaban.Text) == true) lb_giaban_error.Visible = false;
            else
            {
                lb_giaban_error.Visible = true;
                return (false);
            }
            return (true);
        }
   
        private void btn_luu_customer_Click(object sender, EventArgs e)
        {
            if (check_error()==true)
            {
                ProductDTO a = new ProductDTO(this.Text, tb_masp.Text, tb_ten_sp.Text, cb_loaisp.Text ,double.Parse(tb_gianhap.Text), double.Parse(tb_giaban.Text));
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

        private void lb_tensp_error_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
