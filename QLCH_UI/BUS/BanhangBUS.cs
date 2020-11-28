using QLCH_UI.DAO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH_UI.BUS
{
    class BanhangBUS
    {
        private static BanhangBUS instance;

        public static BanhangBUS Instance
        {
            get { if (instance == null) instance = new BanhangBUS(); return instance; }
            private set => instance = value;
        }

        private BanhangBUS() { }
        //Autocomplete Search sản phẩm
        public AutoCompleteStringCollection SearchSP(List<string> list_item)
        {
            AutoCompleteStringCollection acsc = new AutoCompleteStringCollection();
            acsc = BanhangDAO.Instance.SearchSP(list_item);
            return acsc;
        }
        //Autocomplete Khách hàng
        public AutoCompleteStringCollection SearchKH()
        {
            AutoCompleteStringCollection acsc = new AutoCompleteStringCollection();
            acsc = BanhangDAO.Instance.SearchKH();
            return acsc;
        }
        //Xử lý trạng thái khách hàng
        public string ExistKH(string thongtin)
        {
           return BanhangDAO.Instance.ExistKH(thongtin);
        }
        // Thểm sản phẩm vào panel
        public List<string> LoadItem(string name)
        {
            List<string> rs = new List<string>();
            rs = BanhangDAO.Instance.LoadItem(name);
            return rs;
        }
        // Hàm lưu Hóa đơn
        public string SaveHD(string makh, string manv, string giam_gia, string tri_gia)
        {
            DateTime d = DateTime.Now;
            string nam = d.Year.ToString();
            string thang = d.Month.ToString();
            string ngay = d.Day.ToString();
            string ngayban = nam + "-" + thang + "-" + ngay;
            string mahd = BanhangDAO.Instance.GetMAHD();
           // MessageBox.Show(mahd +" "+ ngayban);
           int dem = BanhangDAO.Instance.SaveHD(mahd, makh, ngayban, manv, tri_gia, giam_gia);
           if(dem > 0)  return mahd;
            return "";
        }
        // Hàm lưu chi tiết hóa đơn
        public void SaveCTHD(string mahd, List<List<string>> cthd)
        {
            
            foreach(List<string> item in cthd)
            {  
                if (item[1] == "0") continue;
                string query = "INSERT INTO CTHD (mahd, masp, so_luong) VALUES "
                + "('" + mahd + "', '" + item[0] + "', '" + item[1] + "' )";
                BanhangDAO.Instance.SaveCTHD(query);
              //  MessageBox.Show(query);
            }
           
        }
        // hàm cập nhật kho
        public void UpdateKho(List<List<string>> cthd)
        {
            foreach( List<string> item in cthd)
            {
                string query = "UPDATE SAN_PHAM " +
                               "SET so_luong = so_luong - " + item[1]
                               + " WHERE masp = '" + item[0] + "';" ;
                BanhangDAO.Instance.UpdateKho(query);
            }
        }

        // 2 hàm hiển thị info khách hàng và sản phẩm
        public void  Infor_KH(string thongtin)
        {
            List<string> infor = BanhangDAO.Instance.Load_Infor_KH(thongtin);
            (new InfoCustomer(infor[0], infor[1], infor[2], infor[3], infor[4], infor[5])).ShowDialog();
        }
        public void Infor_SP(string thongtin)
        {
            List<string> infor = BanhangDAO.Instance.Load_Infor_SP(thongtin);
            Image anh = ProductBUS.Instance.ByteToImg(infor[4].ToString());
            (new InfoProduct(infor[0], infor[1], infor[2], infor[3], anh)).ShowDialog();
        }
    }
}
