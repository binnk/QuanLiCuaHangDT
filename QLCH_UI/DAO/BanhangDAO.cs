using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH_UI.DAO
{
    class BanhangDAO
    {
        private static BanhangDAO instance;

        public static BanhangDAO Instance
        {
            get { if (instance == null) instance = new BanhangDAO(); return instance; }
            private set => instance = value;
        }

        private BanhangDAO() { }
        //Load dữ liệu lên và loại bỏ những thứ có trong list_item SellFrom
        public AutoCompleteStringCollection SearchSP(List<string> list_item)
        {
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            string query = "select ten_sp from san_pham where so_luong > 0";
            DataTable rs = ConnectSQL.Instance.ExecuteQuery(query);
            foreach (DataRow row in rs.Rows)
            {
                data.Add(row["ten_sp"].ToString());
            }
            foreach(string item in list_item)
            {
                if (data.Contains(item))
                    data.Remove(item);
            }
            
            return data;
        }
        public AutoCompleteStringCollection SearchKH()
        {
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            string query = "select ten_kh, dien_thoai from khach_hang";
            DataTable rs = ConnectSQL.Instance.ExecuteQuery(query);
            foreach (DataRow row in rs.Rows)
            {
                data.Add(row["ten_kh"].ToString());
                data.Add(row["dien_thoai"].ToString());
            }
            return data;
        }
        public string ExistKH(string thongtin)
        {
            string ketqua ="";
            string query = "select makh from khach_hang " +
                "where dien_thoai = '" + thongtin + "' OR ten_kh = '" + thongtin + "'";
            DataTable rs = ConnectSQL.Instance.ExecuteQuery(query);
            foreach (DataRow row in rs.Rows)
            {
                 ketqua = row["makh"].ToString();
                
            }
            return ketqua;
        }
       
        // Load vao trong UC_item
        public List<string> LoadItem(string name)
        {
            List<string> r = new List<string>();
            string query = "select * from san_pham where ten_sp = '" + name+"'";
            DataTable rs = ConnectSQL.Instance.ExecuteQuery(query);
            foreach (DataRow row in rs.Rows)
            {
                r.Add(row["masp"].ToString());
                r.Add(row["ten_sp"].ToString());
                r.Add(row["gia_ban"].ToString());
                r.Add(row["so_luong"].ToString());
            }
            return r;
        }
        // lấy mã hóa đơn tiếp theo
        public string GetMAHD()
        {
            string mahd = "HD";
            string query = "select * from HOA_DON;";
           
            DataTable ma = ConnectSQL.Instance.ExecuteQuery(query);

            if (ma.Rows.Count == 0) return "HD01";
            if (ma.Rows.Count < 9) return mahd + "0" + (ma.Rows.Count+1).ToString();
            return mahd + (ma.Rows.Count + 1).ToString();

        }
        public int  SaveHD(string mahd, string makh, string ngayban, 
                            string manv, string tri_gia, string giam_gia)
        {
            string query = "INSERT INTO HOA_DON (mahd, makh, ngay_ban, manv, tri_gia, giam_gia) " +
                           "VALUES ( @mahd , @makh , @ngay_ban , @manv , @tri_gia , @giam_gia );";
            int dem = ConnectSQL.Instance.ExecuteNonQuery(query, new object[] { mahd, makh, ngayban, manv, tri_gia, giam_gia });
            string q = "UPDATE KHACH_HANG SET doanh_thu = doanh_thu +'" + tri_gia + "' WHERE makh ='" + makh + "'";
             dem = ConnectSQL.Instance.ExecuteNonQuery(q);
            return dem;
        }
        public void SaveCTHD(string query)
        {
            int dem = ConnectSQL.Instance.ExecuteNonQuery(query);
            
        }
        public void UpdateKho(string query)
        {
            int dem = ConnectSQL.Instance.ExecuteNonQuery(query);
        }
        // hiển thị thông tin
        public List<string> Load_Infor_KH(string thongtin)
        {
            List<string> r = new List<string>();
            string query = "select * from khach_hang " +
                "where dien_thoai = '" + thongtin + "' OR ten_kh = '" + thongtin + "'";
            DataTable rs = ConnectSQL.Instance.ExecuteQuery(query);
            foreach (DataRow row in rs.Rows)
            {
                r.Add(row["makh"].ToString());
                r.Add(row["ten_kh"].ToString());
                r.Add(row["dien_thoai"].ToString());
                r.Add(row["dia_chi"].ToString());
                r.Add(row["ngay_sinh"].ToString());
                r.Add(row["gioi_tinh"].ToString());
            }
            return r;
        }
        public List<string> Load_Infor_SP(string thongtin)
        {
            List<string> r = new List<string>();
            string query = "select masp, ten_sp, loai_sp, gia_ban, img from san_pham " +
                "where masp = '" + thongtin + "'";
            DataTable rs = ConnectSQL.Instance.ExecuteQuery(query);
            foreach (DataRow row in rs.Rows)
            {
                r.Add(row["masp"].ToString());
                r.Add(row["ten_sp"].ToString());
                r.Add(row["loai_sp"].ToString());
                r.Add(row["gia_ban"].ToString());
                r.Add(row["img"].ToString());

            }
            return r;
        }
    }
}
