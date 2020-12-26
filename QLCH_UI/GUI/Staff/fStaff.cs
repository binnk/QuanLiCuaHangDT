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
    public partial class fStaff : Form
    {
        public fStaff()
        {
            InitializeComponent();
            //this.flowLayoutPanel1.Controls.Add(new UC_ItemStaff());
            loadstaff();
        }
        public void loadstaff()
        {
            flowLayoutPanel1.Controls.Clear();
            DataTable a = StaffDAO.Instance.Stafflist();
            for (int i = 0; i < a.Rows.Count; i++)
            {
                UC_ItemStaff item = new UC_ItemStaff(this);
                item.chucvu = a.Rows[i]["loainhanvien"].ToString();
                if (item.chucvu != "admin")
                {
                    item.manv = a.Rows[i]["manv"].ToString();
                    item.tenv = a.Rows[i]["ten_nv"].ToString();
                    item.SDT = a.Rows[i]["dien_thoai"].ToString();
                    item.diachi = a.Rows[i]["dia_chi"].ToString();
                    item.set_UC();
                    flowLayoutPanel1.Controls.Add(item);
                }
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
            (new AddStaff()).ShowDialog();
            loadstaff();
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            if (tb_search.Text == "") loadstaff();
            else
            {
                flowLayoutPanel1.Controls.Clear();
                DataTable a = StaffDAO.Instance.search_staff_by_name(tb_search.Text);
                for (int i = 0; i < a.Rows.Count; i++)
                {
                    UC_ItemStaff item = new UC_ItemStaff(this);
                    item.chucvu = a.Rows[i]["loainhanvien"].ToString();
                    if (item.chucvu != "admin")
                    {
                        item.manv = a.Rows[i]["manv"].ToString();
                        item.tenv = a.Rows[i]["ten_nv"].ToString();
                        item.SDT = a.Rows[i]["dien_thoai"].ToString();
                        item.diachi = a.Rows[i]["dia_chi"].ToString();
                        item.set_UC();
                        flowLayoutPanel1.Controls.Add(item);
                    }
                }
            }
        }

        private void guna2ShadowPanel1_Resize(object sender, EventArgs e)
        {
            if (this.panel.Size.Height > 805)
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
