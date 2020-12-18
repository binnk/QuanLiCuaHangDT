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
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
            Load_Hoadon();
        }
        private void Load_Hoadon()
        {
            dgvOrders.Rows.Clear();
            DataTable a = DAO.HoadonDAO.Instance.Hoadonlist();
            for (int i = 0; i < a.Rows.Count; i++)
            {
                string madh = a.Rows[i]["mahd"].ToString();
                string ngay = a.Rows[i]["ngay_ban"].ToString();
                string makh = a.Rows[i]["makh"].ToString();
                string manv = a.Rows[i]["manv"].ToString();
                string trigia = Convert.ToDouble(a.Rows[i]["tri_gia"]).ToString("#,##0");
                dgvOrders.Rows.Add( madh, ngay, makh, manv, trigia);
            }
        }

        private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string mahd = dgvOrders.SelectedRows[0].Cells[0].Value.ToString();
            string makh = dgvOrders.SelectedRows[0].Cells[2].Value.ToString();
            string manv = dgvOrders.SelectedRows[0].Cells[3].Value.ToString();
            (new CTHDForm(mahd, makh, manv)).ShowDialog();
        }
    }
}
