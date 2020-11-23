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
   
        private void btn_luu_customer_Click(object sender, EventArgs e)
        {
            if (check_error()==true)
            {
                byte[] k = ProductBUS.Instance.ImageToByteArray(this.Text);
                string l = Convert.ToBase64String(k);
                ProductDTO a = new ProductDTO(l, tb_masp.Text, tb_ten_sp.Text, cb_loaisp.Text ,double.Parse(tb_gianhap.Text), double.Parse(tb_giaban.Text),int.Parse(tb_sl.Text));
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

        private void lb_masp_error_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
