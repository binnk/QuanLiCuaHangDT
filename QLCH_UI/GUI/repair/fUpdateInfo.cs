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
    public partial class fUpdateInfo : Form
    {
        private double tongtien = 0;
        private string masc;
        public fUpdateInfo(string massc)
        {
            masc = massc;
            InitializeComponent();
            load(masc);
            tbTimKiem.AutoCompleteCustomSource = DAO.SuachuaDAO.Instance.SearchLK();
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

        //test
        public void load( string masc)
        {
            DataTable ct = DAO.SuachuaDAO.Instance.Load_CTSC(masc);
            for (int i = 0; i < ct.Rows.Count; i++)
            {
                UC_UI_DS_Item item = new UC_UI_DS_Item(this);
                item.malk = ct.Rows[i]["masp"].ToString();
                item.tenlk = ct.Rows[i]["ten_sp"].ToString();
                item.gia = Convert.ToDouble(ct.Rows[i]["gia_ban"]);
                tongtien += item.gia;
                item.Set_LK();
                this.fpn_ItemsLinhKien.Controls.Add(item);
            }
            lb_tongtien.Text = tongtien.ToString("#,##0");
            if(DAO.SuachuaDAO.Instance.Load_Tinh_Trang(masc) == "chuasua")
            {
                rbChuaSua.Checked = true;
            }
            if (DAO.SuachuaDAO.Instance.Load_Tinh_Trang(masc) == "dangsua")
            {
                rbDangSua.Checked = true;
            }
            if (DAO.SuachuaDAO.Instance.Load_Tinh_Trang(masc) == "daxong")
            {
                rbDaXong.Checked = true;
            }
            if (DAO.SuachuaDAO.Instance.Load_Tinh_Trang(masc) == "thanhtoan")
            {
                rbThanhToan.Checked = true;
            }
            if (DAO.SuachuaDAO.Instance.Load_Tinh_Trang(masc) == "loi")
            {
                rbLoi.Checked = true;
            }
        }
         public void Delete_item(double giatien)
        {
            tongtien -= giatien;
            lb_tongtien.Text = tongtien.ToString("#,##0");
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataTable lk = DAO.SuachuaDAO.Instance.Load_LK(tbTimKiem.Text);
            for (int i =0; i<lk.Rows.Count; i++)
            {
                UC_UI_DS_Item item = new UC_UI_DS_Item(this);
                item.malk = lk.Rows[i]["masp"].ToString();
                item.tenlk = lk.Rows[i]["ten_sp"].ToString();
                item.gia = Convert.ToDouble(lk.Rows[i]["gia_ban"]);
                tongtien += item.gia;
                item.Set_LK();
                this.fpn_ItemsLinhKien.Controls.Add(item);
            }
            lb_tongtien.Text = tongtien.ToString("#,##0");
        }
        //HUY
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Luu
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string year = DateTime.Now.Year.ToString();
            string month = DateTime.Now.Month.ToString();
            string day = DateTime.Now.Day.ToString();
            DAO.SuachuaDAO.Instance.Delete_CTSC(masc);
            if( rbThanhToan.Checked == true)
            {
                DAO.SuachuaDAO.Instance.Update_SUA_CHUA(masc, "thanhtoan", year + "-" + month + "-" + day,tongtien.ToString());
                foreach (UC_UI_DS_Item items in this.fpn_ItemsLinhKien.Controls )
                {
                    DAO.SuachuaDAO.Instance.Insert_CTSC(masc, items.malk);
                    DAO.SuachuaDAO.Instance.Update_LK(items.malk);
                    //MessageBox.Show(year + month + day);
                    
                }
                DAO.SuachuaDAO.Instance.Update_KHACH_HANG(DAO.SuachuaDAO.Instance.MaKH(masc),DAO.SuachuaDAO.Instance.Tongtien_SC(masc));
            }
            if (rbChuaSua.Checked == true)
            {
                DAO.SuachuaDAO.Instance.Update_SUA_CHUA(masc, "chuasua", year + month + day,tongtien.ToString());
                foreach (UC_UI_DS_Item items in this.fpn_ItemsLinhKien.Controls)
                {
                    DAO.SuachuaDAO.Instance.Insert_CTSC(masc, items.malk);
                    
                }
            }
            if (rbDaXong.Checked == true)
            {
                DAO.SuachuaDAO.Instance.Update_SUA_CHUA(masc, "daxong", year + month + day,tongtien.ToString());
                foreach (UC_UI_DS_Item items in this.fpn_ItemsLinhKien.Controls)
                {
                    DAO.SuachuaDAO.Instance.Insert_CTSC(masc, items.malk);
                    
                }
            }
            if (rbDangSua.Checked == true)
            {
                DAO.SuachuaDAO.Instance.Update_SUA_CHUA(masc, "dangsua", year + month + day,tongtien.ToString());
                foreach (UC_UI_DS_Item items in this.fpn_ItemsLinhKien.Controls)
                {
                    DAO.SuachuaDAO.Instance.Insert_CTSC(masc, items.malk);
                    
                }
            }
            if (rbLoi.Checked == true)
            {
                DAO.SuachuaDAO.Instance.Update_SUA_CHUA(masc, "loi", year + month + day,tongtien.ToString());
                foreach (UC_UI_DS_Item items in this.fpn_ItemsLinhKien.Controls)
                {
                    DAO.SuachuaDAO.Instance.Insert_CTSC(masc, items.malk);
                   
                }
            }
            this.Close();
        }
    }
}
