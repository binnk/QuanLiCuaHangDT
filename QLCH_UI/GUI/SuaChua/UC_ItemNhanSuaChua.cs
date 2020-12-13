using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;

namespace QLCH_UI
{
    public partial class UC_ItemNhanSuaChua : UserControl
    {

        public UC_ItemNhanSuaChua()
        {
            InitializeComponent();
            DanhSachLinhKien = new List<string>();
        }

        public string MaDon { get; set; }
        public string TenNV { get; set; }
        public string TenKH { get; set; }
        public string NgayNhan { get; set; }
        public List<string> DanhSachLinhKien { get; set; }

        public void setLabel(string str)
        {
            GunaLabel lb = new GunaLabel();
            lb.AutoSize = true;
            lb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb.ForeColor = System.Drawing.Color.Gray;
            lb.Size = new System.Drawing.Size(77, 25);
            lb.Text = str;

            flp_LinhKien.Controls.Add(lb);
        }

        public void addListFLPLinhKien()
        {   if (DanhSachLinhKien.Count >=2)
            {
                int count = DanhSachLinhKien.Count;
                this.Size = new Size(this.Size.Width, 76 + 20*count);
                
                flp_LinhKien.Size = new Size(237, 30+30*count);
            }
            foreach(string item in DanhSachLinhKien)
            {
                setLabel(item);
            }
        }

        public void setUC()
        {
            lb_MaDon.Text = MaDon;
            lb_NgayNhan.Text = NgayNhan;
            lb_TenKH.Text = TenKH;
            lb_TenNV.Text = TenNV;

            addListFLPLinhKien();
        }
        private void gunaLinePanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            fChonEdit form = new fChonEdit();
            form.ShowDialog();
        }
    }
}