using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCH_UI.DAO;
namespace QLCH_UI
{
    public partial class fViewCustomer : Form
    {
   
        public fViewCustomer()
        {
            InitializeComponent();
            loadcustomer();
        }
        public void loadcustomer()
        {
            flowLayoutPanel1.Controls.Clear();
            DataTable a = CustomersDAO.Instance.Customerslist();
            for (int i=0;i<a.Rows.Count;i++)
            {
                UC_ItemCustomer item = new UC_ItemCustomer(this);
                item.makh = a.Rows[i]["makh"].ToString();
                item.tenkh = a.Rows[i]["ten_kh"].ToString();
                item.sdt = a.Rows[i]["dien_thoai"].ToString();
                item.gioitinh = a.Rows[i]["gioi_tinh"].ToString();
                item.diachi = a.Rows[i]["dia_chi"].ToString();
                item.set_UC();
                flowLayoutPanel1.Controls.Add(item);
            }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle = 0x02000000;
                return handleParam;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            (new AddCustomer()).ShowDialog();
            loadcustomer();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (tb_search.Text == "") loadcustomer();
            else
            {
                flowLayoutPanel1.Controls.Clear();
                DataTable a = CustomersDAO.Instance.search_customer_by_name(tb_search.Text);
                for (int i = 0; i < a.Rows.Count; i++)
                {
                    UC_ItemCustomer item = new UC_ItemCustomer(this);
                    item.makh = a.Rows[i]["makh"].ToString();
                    item.tenkh = a.Rows[i]["ten_kh"].ToString();
                    item.sdt = a.Rows[i]["dien_thoai"].ToString();
                    item.gioitinh = a.Rows[i]["gioi_tinh"].ToString();
                    item.diachi = a.Rows[i]["dia_chi"].ToString();
                    item.set_UC();
                    flowLayoutPanel1.Controls.Add(item);
                }
            }

        }

        private void flowLayoutPanel1_Resize(object sender, EventArgs e)
        {

        }

        private void fViewCustomer_Resize(object sender, EventArgs e)
        {
            if(this.panel.Size.Height > 805)
            {
                this.guna2ShadowPanel1.Size = new Size(1600, 825);
            }
            else
            {
                this.guna2ShadowPanel1.Size = new Size(1525, 653);
            }

        }
    }
}
