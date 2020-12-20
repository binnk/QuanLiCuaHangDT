using QLCH_UI.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Xuất hóa đơn
//CHƯA THÊM NHÂN VIÊN
namespace QLCH_UI
{
    public partial class SellForm : Form
    {
        #region Khởi tạo
        private string manv ;
        public SellForm(string manvv)
        {
            manv = manvv;
            InitializeComponent();
        }
        //danh sach chua cac item da duoc them vao
        List<string> list_item = new List<string>();
        // Autoconplete Search san pham
        private void SellForm_Load(object sender, EventArgs e)
        {
            tbThemSP.AutoCompleteCustomSource = BanhangBUS.Instance.SearchSP(list_item);
            tbThemKH.AutoCompleteCustomSource = BanhangBUS.Instance.SearchKH();
            //new GUI.Printhd("HD03").ShowDialog();
        }
        #endregion
        #region Đổ item vào panel
        public void dropItem(string ten_sp)
        {
            for (int i = 0; i < list_item.Count; i++)
            {
                if (list_item[i] == ten_sp)
                    list_item.RemoveAt(i);
            }
        }
        private void addItem()
        {
            UC_Item listItems = new UC_Item(this, tbThemSP.Text);
            flpItems.Controls.Add(listItems);
            list_item.Add(tbThemSP.Text);
            tbThemSP.AutoCompleteCustomSource = BanhangBUS.Instance.SearchSP(list_item);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //check xem cos tonf tai hay ko
            if (BanhangBUS.Instance.LoadItem(tbThemSP.Text).Count > 0)
            {
                addItem();
                tbThemSP.Text = "";
            }
        }
        #endregion
        #region Xử lý các UI cơ bản
        private void tbThemSP_MouseClick(object sender, MouseEventArgs e)
        {
            tbThemSP.AutoCompleteCustomSource = BanhangBUS.Instance.SearchSP(list_item);
            tbThemSP.Text = "";
            tbThemSP.ForeColor = Color.Gray;
        }
        private void tbThemKH_Click(object sender, EventArgs e)
        {
           if(tbThemKH.Text == "Thêm khách hàng vào đơn"|| tbThemKH.Text == "*Thêm khách hàng vào đơn")
                tbThemKH.Text = "";
            tbThemKH.ForeColor = Color.Gray;
        }
        private void tbThemSP_Enter(object sender, EventArgs e)
        {
            if (tbThemSP.Text == "Thêm sản phẩm vào đơn")
            {
                tbThemSP.Text = "";
            }
        }
        private void tbThemSP_Leave(object sender, EventArgs e)
        {
            if (tbThemSP.Text == "")
            {
                tbThemSP.Text = "Thêm sản phẩm vào đơn";
            }
        }
        private void icExit_Click(object sender, EventArgs e)
        {
            this.Close();
           // this.ParentForm.ShowDialog();
        }
        private bool check()
        {
            if (flpItems.Controls.Count == 0) 
            {
                tbThemSP.ForeColor = Color.Red;
                tbThemSP.Text = "*Thêm sản phẩm vào đơn";
                return false; 
            }
            if(BanhangBUS.Instance.ExistKH(tbThemKH.Text) == "")
            {
                tbThemKH.ForeColor = Color.Red;
                tbThemKH.Text = "*Thêm khách hàng vào đơn";
                return false;
            }
            if(Convert.ToDouble(GetFloat(tbtien_khach_dua.Text)) < Convert.ToDouble(GetFloat(lbkhach_phai_tra.Text)) )
            {
                tbtien_khach_dua.ForeColor = Color.Red;
                return false;
            }
            return true;
        }
        #endregion
        #region update ben phan thanh toan
        public void UpdateTT(string masp,string sl_cu,string sl_moi, string dongia)
        {
            updateCTHD(masp, sl_moi, dongia);
            lbso_luong.Text = (Convert.ToDouble(GetFloat(lbso_luong.Text))- Convert.ToDouble(sl_cu) + Convert.ToInt32(sl_moi)).ToString("#,##0");
            lbtong_tien.Text = (Convert.ToDouble(GetFloat(lbtong_tien.Text)) - Convert.ToDouble(sl_cu)*Convert.ToDouble(dongia) + Convert.ToDouble(sl_moi)* Convert.ToDouble(dongia)).ToString("#,##0");
            lbkhach_phai_tra.Text = (Convert.ToDouble( GetFloat(lbtong_tien.Text)) - Convert.ToDouble(GetFloat(tbgiam_gia.Text))).ToString("#,##0");
        }
        string giam_gia = "0";
        private void tbgiam_gia_TextChanged(object sender, EventArgs e)
        {
            if (tbgiam_gia.Text.Length > 12) tbgiam_gia.Text = Convert.ToDouble(giam_gia).ToString("#,##0");
            if (tbgiam_gia.Text.Length > 0)
            {
                foreach (char i in tbgiam_gia.Text)
                {
                    if ((i > '9' || i < '0') && (i != ','))
                    {
                        tbgiam_gia.Text = Convert.ToDouble(giam_gia).ToString("#,##0");
                        break;
                    }
                }
                giam_gia = GetFloat(tbgiam_gia.Text);
                lbkhach_phai_tra.Text = (Convert.ToDouble(GetFloat(lbtong_tien.Text)) - Convert.ToDouble(GetFloat(tbgiam_gia.Text))).ToString("#,##0");
              tbgiam_gia.Text = Convert.ToDouble(GetFloat(tbgiam_gia.Text)).ToString("#,##0");
                tbgiam_gia.SelectionStart = tbgiam_gia.Text.Length;
            }
        }
        string tien_khach_dua = "0";
        private void tbtien_khach_dua_TextChanged(object sender, EventArgs e)
        {
            if (tbtien_khach_dua.Text.Length > 12) tbtien_khach_dua.Text = Convert.ToDouble(tien_khach_dua).ToString("#,##0");
            tbtien_khach_dua.ForeColor = Color.Black;
            if (tbtien_khach_dua.Text.Length > 0)
            {
                foreach (char i in tbtien_khach_dua.Text)
                {
                    if ((i > '9' || i < '0') && (i != ','))
                    {
                        tbtien_khach_dua.Text = Convert.ToDouble(tien_khach_dua).ToString("#,##0");
                        break;
                    }
                }
                tien_khach_dua = GetFloat(tbtien_khach_dua.Text);
                lbtien_thua.Text = (Convert.ToDouble(GetFloat(tbtien_khach_dua.Text)) - Convert.ToDouble(GetFloat(lbkhach_phai_tra.Text))).ToString("#,##0");
                tbtien_khach_dua.Text = Convert.ToDouble(GetFloat(tbtien_khach_dua.Text)).ToString("#,##0");
                tbtien_khach_dua.SelectionStart = tbtien_khach_dua.Text.Length;
            }
        }
        private void lbkhach_phai_tra_TextChanged(object sender, EventArgs e)
        {
            lbtien_thua.Text = (Convert.ToDouble(GetFloat(tbtien_khach_dua.Text)) - Convert.ToDouble(GetFloat(lbkhach_phai_tra.Text))).ToString("#,##0");
        }
        #region Hàm lưu trữ trạng thái của các item phục vụ cho việc lưu hóa đơn và xử lí sự kiện bt thanh toan click
        
        List<List<string>> CTHD  = new List<List<string>>();
        private void updateCTHD(string masp, string soluong, string dongia)
        {
            bool edit = false;
            foreach( List<string> sp in CTHD)
            {
                if(sp.Count == 3)
                {
                    if (sp[0] == masp)
                    {
                        sp[1] = soluong;
                        sp[2] = dongia;
                       // if (Convert.ToInt32(soluong) == 0) CTHD.RemoveAt();
                        edit = true;
                    }
                }
            }
            if(edit == false)
            {
                List<string> newitem = new List<string>() ;
                newitem.Add(masp);
                newitem.Add(soluong);
                newitem.Add(dongia);
                CTHD.Add(newitem);
            }
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {  
            if (check())
            {
                string mahd = "";
                // hàm gọi ra để lưu hóa đơn -- chưa hoàn thành cập nhật NV
                if (BanhangBUS.Instance.ExistKH(tbThemKH.Text) != "")
                {
                    string Makh = BanhangBUS.Instance.ExistKH(tbThemKH.Text);
                    mahd = BanhangBUS.Instance.SaveHD(Makh, manv,GetFloat(tbgiam_gia.Text), GetFloat(lbkhach_phai_tra.Text));

                }
                //Lưu chi tiết hóa đơn
                if (mahd != "")
                    BanhangBUS.Instance.SaveCTHD(mahd, CTHD);
                //Cập nhật lại kho
                BanhangBUS.Instance.UpdateKho(CTHD);
                //goi form in hoadon
                new GUI.Sell.Printhd(mahd).Show();
                // Xóa dữ liệu trên màn hình
                ClearAll();
            }
        }
        private void ClearAll()
        {
            CTHD.Clear();
            list_item.Clear();
            flpItems.Controls.Clear();
            giam_gia = "0";
            tien_khach_dua = "0";
            lbso_luong.Text = "0";
            lbtong_tien.Text = "0";
            tbgiam_gia.Text = "0";
            lbkhach_phai_tra.Text = "0";
            lbtien_thua.Text = "0";
            tbtien_khach_dua.Text = "0";
            tbThemSP.Text = "Thêm sản phẩm vào đơn";
            tbThemKH.Text = "Thêm khách hàng vào đơn";
        }



        #endregion

        #endregion
        #region Xử lý tìm kiếm khách hàng
        private void tbThemKH_TextChanged(object sender, EventArgs e)
        {
            if(BanhangBUS.Instance.ExistKH(tbThemKH.Text) != "")
            {
                iconPictureBox1.Enabled = false;
                iconPictureBox2.Enabled = false;
                iconButton1.Visible = true;
                
            }
            else
            {
                iconPictureBox1.Enabled = true;
                iconPictureBox2.Enabled = true;
                iconButton1.Visible = false;
            }
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (BanhangBUS.Instance.ExistKH(tbThemKH.Text) != "")
            // MessageBox.Show("Thông tin khách hàng");
            {
                BanhangBUS.Instance.Infor_KH(tbThemKH.Text);
            }   
        }
        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Thêm khách hàng");
            (new AddCustomer()).ShowDialog();
        }
        #endregion
        private string GetFloat(string s)
        {
            string rs ="";
            for(int i = 0; i< s.Length; i++)
            {
                if (s[i] != ',') rs += s[i];
            }
            return rs;
        }

    }
}
