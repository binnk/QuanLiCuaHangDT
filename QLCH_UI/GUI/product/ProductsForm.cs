using QLCH_UI.BUS;
using QLCH_UI.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH_UI
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
            load_product();
        }


  

        public void load_product()
        {
            dgvProducts.Rows.Clear();
            DataTable a = ProductDAO.Instance.Productlist();
            for (int i=0;i<a.Rows.Count;i++)
            {
                string anh = a.Rows[i]["img"].ToString();
                string masp = a.Rows[i]["masp"].ToString();
                string tensp = a.Rows[i]["ten_sp"].ToString();
                string soluong = a.Rows[i]["so_luong"].ToString();
                int ton_tai = int.Parse(a.Rows[i]["ton_tai"].ToString());
                if (ton_tai == 1) dgvProducts.Rows.Add(ProductBUS.Instance.ByteToImg(anh), masp, tensp, soluong);
            }
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct f = new AddProduct();
            f.ShowDialog();
            load_product();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count>0)
            {
                DataGridViewRow row = dgvProducts.SelectedRows[0];
                String ID = row.Cells[1].Value.ToString();
                string masp = "";
                string ten_sp = "";
                string loai_sp = "";
                double gia_nhap = 0;
                double gia_ban = 0;
                string img = "";
                DataTable a = ProductDAO.Instance.viewinfo(ID);
                masp = a.Rows[0]["masp"].ToString();
                ten_sp = a.Rows[0]["ten_sp"].ToString();
                loai_sp = a.Rows[0]["loai_sp"].ToString();
                gia_nhap = (double)a.Rows[0]["gia_nhap"];
                gia_ban = (double)a.Rows[0]["gia_ban"];
                img = a.Rows[0]["img"].ToString();
                EditProduct f = new EditProduct(img,masp,ten_sp,loai_sp,gia_nhap,gia_ban);
                f.ShowDialog();
                load_product();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvProducts.SelectedRows[0];
                string ID = row.Cells[1].Value.ToString();
                if (ProductBUS.Instance.delete_product(ID))
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
                load_product();
            }
        }

        private void dgvProducts_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {  
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProducts_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvProducts.SelectedRows[0];
                string masp = row.Cells[1].Value.ToString();
                DataTable a = ProductDAO.Instance.viewinfo(masp);
                string ma_sp = a.Rows[0]["masp"].ToString();
                string ten_sp = a.Rows[0]["ten_sp"].ToString();
                string loai_sp = a.Rows[0]["loai_sp"].ToString();
                string gia = a.Rows[0]["gia_ban"].ToString();
                Image anh = ProductBUS.Instance.ByteToImg(a.Rows[0]["img"].ToString());
                InfoProduct f = new InfoProduct(ma_sp, ten_sp, loai_sp, gia, anh);
                f.ShowDialog();

            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (tb_search.Text == "") load_product();
            else
            {
                DataTable a = ProductDAO.Instance.search_product_by_masp(tb_search.Text);
                DataTable b = ProductDAO.Instance.search_product_by_name(tb_search.Text);
                dgvProducts.Rows.Clear();
                for (int i = 0; i < a.Rows.Count; i++)
                {
                    Image img = ProductBUS.Instance.ByteToImg(a.Rows[i]["img"].ToString());
                    string masp = a.Rows[i]["masp"].ToString();
                    string tensp = a.Rows[i]["ten_sp"].ToString();
                    string soluong = a.Rows[i]["so_luong"].ToString();
                    int ton_tai = int.Parse(a.Rows[i]["ton_tai"].ToString());
                    if (ton_tai == 1) dgvProducts.Rows.Add(img,masp,tensp,soluong);
                }
                for (int i = 0; i < b.Rows.Count; i++)
                {
                    Image img = ProductBUS.Instance.ByteToImg(b.Rows[i]["img"].ToString());
                    string masp = b.Rows[i]["masp"].ToString();
                    string tensp = b.Rows[i]["ten_sp"].ToString();
                    string soluong = b.Rows[i]["so_luong"].ToString();
                    int ton_tai = int.Parse(b.Rows[i]["ton_tai"].ToString());
                    if (ton_tai == 1)dgvProducts.Rows.Add(img,masp, tensp, soluong);
                }
            }    
        }
    }
}
