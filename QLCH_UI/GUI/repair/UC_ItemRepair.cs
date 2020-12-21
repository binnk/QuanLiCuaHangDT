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
    public partial class UC_ItemRepair : UserControl
    {
         private fRepair _parent;
        public UC_ItemRepair(fRepair parent)
        {
            _parent = parent;
            InitializeComponent();
            DanhSachLinhKien = new List<string>();
        }

        public string MaDon { get; set; }
        public string TenNV { get; set; }
        public string TenKH { get; set; }
        public string TinhTrang { get; set; }
        public string NgayNhan { get; set; }
        public string TriGia { get; set; }
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
            lb_GhiChu.Text = TriGia;
            switch (TinhTrang)
            {
                case "chuasua":
                    this.ic_TinhTrang.Image = Properties.Resources.icons8_cancel_32;
                    break;
                case "dangsua":
                    this.ic_TinhTrang.Image = Properties.Resources.icons8_maintenance_32;
                    break;
                case "daxong":
                    this.ic_TinhTrang.Image = Properties.Resources.icons8_ok_32;
                    break;
                case "thanhtoan":
                    this.ic_TinhTrang.Image = Properties.Resources.icons8_money_32;
                    break;
                case "loi":
                    this.ic_TinhTrang.Image = Properties.Resources.icons8_high_priority_32;
                    break;
                default:
                    break;
            }
            addListFLPLinhKien();
        }
        private void gunaLinePanel2_Paint(object sender, PaintEventArgs e)
        {
            //ic_TinhTrang.Image 
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (TinhTrang != "thanhtoan")
            {
                fSelectEdit form = new fSelectEdit(this.MaDon);
                form.ShowDialog();
                _parent.btviewall_Click(sender, e);
            }
        }

        private void gunaLinePanel3_DoubleClick(object sender, EventArgs e)
        {
            fInfoRepair form = new fInfoRepair(MaDon);
            form.ShowDialog();
        }
        //xoa
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if(TinhTrang != "thanhtoan")
            {
                DAO.SuachuaDAO.Instance.Delete_CTSC(MaDon);
                DAO.SuachuaDAO.Instance.Delete_SC(MaDon);
            }
            _parent.btviewall_Click(sender, e);
        }

        private void UC_ItemRepair_DoubleClick(object sender, EventArgs e)
        {
            fInfoRepair form = new fInfoRepair(MaDon);
            form.ShowDialog();
        }

        private void lb_MaDon_DoubleClick(object sender, EventArgs e)
        {
            fInfoRepair form = new fInfoRepair(MaDon);
            form.ShowDialog();
        }

        private void lb_NgayNhan_DoubleClick(object sender, EventArgs e)
        {
            fInfoRepair form = new fInfoRepair(MaDon);
            form.ShowDialog();
        }

        private void lb_TenKH_DoubleClick(object sender, EventArgs e)
        {
            fInfoRepair form = new fInfoRepair(MaDon);
            form.ShowDialog();
        }

        private void lb_TenNV_DoubleClick(object sender, EventArgs e)
        {
            fInfoRepair form = new fInfoRepair(MaDon);
            form.ShowDialog();
        }

        private void flp_LinhKien_DoubleClick(object sender, EventArgs e)
        {
            fInfoRepair form = new fInfoRepair(MaDon);
            form.ShowDialog();
        }

        private void lb_GhiChu_DoubleClick(object sender, EventArgs e)
        {
            fInfoRepair form = new fInfoRepair(MaDon);
            form.ShowDialog();
        }

        private void ic_TinhTrang_DoubleClick(object sender, EventArgs e)
        {
            fInfoRepair form = new fInfoRepair(MaDon);
            form.ShowDialog();
        }

        private void gunaLinePanel3_MouseEnter(object sender, EventArgs e)
        {
            gunaLinePanel3.BackColor = Color.FromArgb(220, 250, 252);
        }

        private void gunaLinePanel3_MouseLeave(object sender, EventArgs e)
        {
            gunaLinePanel3.BackColor = Color.White;
        }
    }
}