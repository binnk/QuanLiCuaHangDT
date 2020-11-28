using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCH_UI.BUS;
namespace QLCH_UI
{    // NOTE: 
     //tạo 1 hàm bên sell from đê lưu trạng thái cuả item dùng cho việc thanh toan lưu dữ liệu
    public partial class UC_Item : UserControl
    {   
        // lưu trữ trạng thái của label số lượng để canh chỉnh việc tăng giảm tbx số lượng
        string soluong = "1";
        // giá trị tối đa mà có thể mua
        int sl_ton = 1;
        // Form cha cho việc truy xuất hàm bên form cha
        private SellForm _parent ;
        public UC_Item(SellForm parent,string nameitem)
        {
            InitializeComponent();
            this._parent = parent;
            Load(nameitem);
        }
        // Đổ dữ liệu vào label texbox
        private new void Load(string nameitem)
        {
            List<string> item = BanhangBUS.Instance.LoadItem(nameitem);
            
                lbMaSP.Text = item[0];
                lbTenSP.Text = item[1];
                lbDonGia.Text = Convert.ToDouble(item[2]).ToString("#,##0");
                lbtien.Text =  Convert.ToDouble(item[2]).ToString("#,##0");
            sl_ton = Convert.ToInt32(item[3]);
            this._parent.UpdateTT(lbMaSP.Text,"0",tbxSLuong.Text, GetFloat(lbDonGia.Text));

        }
        #region Xử lý tăng giảm số lượng
        // Tăng
        private void icBtnTang_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(tbxSLuong.Text);
            if(s < sl_ton) s++;
            tbxSLuong.Text = s.ToString();
            double dongia = Convert.ToDouble(GetFloat(lbDonGia.Text));
            lbtien.Text = (s * dongia).ToString("#,##0");
            this._parent.UpdateTT(lbMaSP.Text,soluong, tbxSLuong.Text , GetFloat(lbDonGia.Text));
            soluong = tbxSLuong.Text;
        }
        //Giảm
        private void icBtnGiam_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(tbxSLuong.Text);
            double dongia = Convert.ToDouble(GetFloat(lbDonGia.Text));
            if(s > 0) s--;
            tbxSLuong.Text = s.ToString();
            lbtien.Text = (s * dongia).ToString("#,##0");
            this._parent.UpdateTT(lbMaSP.Text, soluong, tbxSLuong.Text, GetFloat(lbDonGia.Text));
            soluong = tbxSLuong.Text;
        }
        //Nhập vào số lượng
        private void tbxSLuong_TextChanged(object sender, EventArgs e)
        {
          foreach(char i in tbxSLuong.Text)
            {
                if (i > '9' || i < '0')
                {
                    tbxSLuong.Text = soluong;
                    break;
                }
            }
          
            int s = Convert.ToInt32(soluong);
            if (tbxSLuong.Text.Length > 0)
            {
                if(Convert.ToInt32(tbxSLuong.Text) <= sl_ton)
                s = Convert.ToInt32(tbxSLuong.Text);

                double dongia = Convert.ToDouble(GetFloat(lbDonGia.Text));
                lbtien.Text = (s * dongia).ToString("#,##0");
                this._parent.UpdateTT(lbMaSP.Text, soluong, tbxSLuong.Text,GetFloat(lbDonGia.Text));
                soluong = tbxSLuong.Text;
            }
        }
        //Click chuột
        private void tbxSLuong_Click(object sender, EventArgs e)
        {
           soluong = tbxSLuong.Text;
        }
        #endregion
        #region Xóa item
        private void icBtnXoa_Click(object sender, EventArgs e)
        {
            this._parent.UpdateTT(lbMaSP.Text, soluong, "0", lbDonGia.Text);
            this._parent.dropItem(lbTenSP.Text);
            cancel();
        }
         private void cancel()
        {
           this.Parent.Controls.Remove(this);

        }
        #endregion
        private void iconButton1_Click(object sender, EventArgs e)
        {
           
            BanhangBUS.Instance.Infor_SP(lbMaSP.Text);
        }
        private string GetFloat(string s)
        {
            string rs = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ',') rs += s[i];
            }
            return rs;
        }

    }
}
