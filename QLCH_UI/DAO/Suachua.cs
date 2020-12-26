using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH_UI.DAO
{
    class SuachuaDAO
    {
        private static SuachuaDAO  instance;

        public static SuachuaDAO Instance
        {
            get
            {
                if (instance == null) instance = new SuachuaDAO();
                return SuachuaDAO.instance;
            }
            private set
            {
                SuachuaDAO.instance = value;
            }
        }
        private SuachuaDAO() { }

        // Form repair
         public DataTable Load_HDSC( string tinhtrang)
         {
            string query;
            if (tinhtrang != "all")
            {
                 query = "select S.masc, S.ngay_nhan, K.ten_kh, N.ten_nv, S.tinh_trang, S.tri_gia  from SUA_CHUA S, KHACH_HANG K,NHAN_VIEN N "
                              + " where S.tinh_trang = '" + tinhtrang + "' and S.makh = K.makh and N.manv = S.manv";
            }
         else
            {
                query = "select S.masc, S.ngay_nhan, K.ten_kh, N.ten_nv, S.tinh_trang, S.tri_gia  from SUA_CHUA S, KHACH_HANG K,NHAN_VIEN N "
                              + " where S.makh = K.makh and N.manv = S.manv";
            }
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return dt;
         }
        public DataTable search_by_name_KH(string ten_kh, string tinhtrang)
        {
            string query;
            if (tinhtrang == "all")
            {
                query = "select S.masc, S.ngay_nhan, K.ten_kh, N.ten_nv, S.tinh_trang, S.tri_gia  from SUA_CHUA S, KHACH_HANG K,NHAN_VIEN N "
                                  + " where K.ten_kh like N'%" + ten_kh + "%' and S.makh = K.makh and N.manv = S.manv";
            }
            else
            {
                query = "select S.masc, S.ngay_nhan, K.ten_kh, N.ten_nv, S.tinh_trang, S.tri_gia  from SUA_CHUA S, KHACH_HANG K,NHAN_VIEN N "
                                  + " where K.ten_kh like N'%" + ten_kh + "%' and S.makh = K.makh and N.manv = S.manv and S.tinh_trang = '" + tinhtrang + "'";
            }
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return (dt);
        }
        // form chỉnh sửa trạng thái
        public string Tongtien_SC(string masc)
        {
            try
            {
                string query = "select sum(SAN_PHAM.gia_ban) as gia from CTSC, SAN_PHAM,SUA_CHUA "
                              + "where CTSC.malk = SAN_PHAM.masp and SUA_CHUA.masc = CTSC.masc and SUA_CHUA.masc = '" + masc + "'";
                DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
                return Convert.ToDouble(dt.Rows[0]["gia"]).ToString("#,##0");
            }
            catch
            {
                return "0";
            }
        }
        public string MaKH (string masc)
        {
            try
            {
                string query = " select KHACH_HANG.ten_kh from KHACH_HANG, SUA_CHUA"
                                +" where SUA_CHUA.makh = KHACH_HANG.makh and SUA_CHUA.masc = '"+masc+"'" ;
                DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
                return Convert.ToDouble(dt.Rows[0]["ten_kh"]).ToString();
            }
            catch
            {
                return "";
            }
        }
        public DataTable Load_CTSC(string masc)
        {
            string query = "select SAN_PHAM.ten_sp, SAN_PHAM.gia_ban, SAN_PHAM.masp, SUA_CHUA.tinh_trang from CTSC, SAN_PHAM,SUA_CHUA "
                           +"where CTSC.malk = SAN_PHAM.masp and SUA_CHUA.masc = CTSC.masc and SUA_CHUA.masc = '"+ masc+"'";
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return dt;
        }
        public string Load_Tinh_Trang(string masc)
        {
            try
            {
                string query = "select tinh_trang from SUA_CHUA where masc = '" + masc + "'";
                DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
                return dt.Rows[0]["tinh_trang"].ToString();
            }
            catch
            {
                return "";
            }
            
        }
       
        public AutoCompleteStringCollection SearchLK()
        {
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            string query = "select ten_sp from san_pham where so_luong > 0 and loai_sp = 'Linhkien'";
            DataTable rs = ConnectSQL.Instance.ExecuteQuery(query);
            foreach (DataRow row in rs.Rows)
            {
                data.Add(row["ten_sp"].ToString());
            }
            return data;
        }
        public DataTable Load_LK(string linhkien)
        {
            string query = "select masp, ten_sp, gia_ban from san_pham where ten_sp = '"+ linhkien +"'";
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return dt;
        }
        public void Delete_CTSC(string masc)
        {
            string query = "delete from CTSC where masc = '" + masc + "'";
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return ;
        }
        public void Delete_SC(string masc)
        {
            string query = "delete from SUA_CHUA where masc = '" + masc + "'";
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return;
        }
        public void Insert_CTSC(string masc, string malk)
        {
            string query = "insert into CTSC values ('"+ masc +"', '" + malk + "', '1')";
            int dt = ConnectSQL.Instance.ExecuteNonQuery(query);
            return;
        }
        public void Update_LK(string malk)
        {
            string query = "update SAN_PHAM set so_luong = so_luong - 1 where masp = '" + malk + "'";
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return;
        }
        public void Update_SUA_CHUA(string masc, string tinhtrang,string datetime,string tri_gia)
        {
            string query;
            if (tinhtrang == "thanhtoan")
            {
                query = "update SUA_CHUA set tinh_trang = '" + tinhtrang + "', ngay_giao = '"+ datetime +"' , tri_gia = '"+tri_gia+"' where masc = '" + masc + "'";
            }
            else
            {
                query = "update SUA_CHUA set tinh_trang = '" + tinhtrang + "' , tri_gia = '"+ tri_gia +"' where masc = '" + masc + "'";
            }
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return;
        }
        public void Update_KHACH_HANG(string makh, string doanhthu)
        {
            string query = "update KHACH_HANG set doanh_thu = doanh_thu +'"+doanhthu+"' where makh = '" + makh + "'";
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return;
        }
        // Form Xem thông tin 
        public DataTable Load_InforSC(string masc)
        {
            string query = "select K.ten_kh, k.dien_thoai, k.dia_chi, s.ngay_nhan, s.ngay_giao, s.tri_gia, s.ten_sp, s.loai_sp, s.ghi_chu , s.tinh_trang from SUA_CHUA S, KHACH_HANG K"
                           + " where S.makh = K.makh and s.masc = '" + masc + "'";
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return dt;
        }
        // Form Thêm sửa chửa
        public DataTable Load_infor_KH(string sdt)
        {
            string query = "select * from khach_hang where dien_thoai = '"+sdt+"'";
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return dt;
        }
        public string Get_MaKH()
        {
            int rs = 0;
            DataTable a = CustomersDAO.Instance.Customerslist();
            for (int i = 0; i < a.Rows.Count; i++)
            {
                string k = a.Rows[i]["Mã khách hàng"].ToString();
                int l = k.Length;
                int tg = int.Parse(k.Substring(2, l - 2));
                if (tg > rs) rs = tg;
            }
            rs++;
            string p = "";
            if (rs > 9) p = "KH" + rs.ToString();
            else p = "KH" + "0" + rs.ToString();
            return p;
        }
        public string Get_MaSC()
        {
            int rs = 0;
            DataTable a = SuachuaDAO.Instance.Load_HDSC("all");
            for (int i = 0; i < a.Rows.Count; i++)
            {
                string k = a.Rows[i]["masc"].ToString();
                int l = k.Length;
                int tg = int.Parse(k.Substring(2, l - 2));
                if (tg > rs) rs = tg;
            }
            rs++;
            string p = "";
            if (rs > 9) p = "SC" + rs.ToString();
            else p = "SC" + "0" + rs.ToString();
            return p;
        }
        public bool Insert_SUA_CHUA(string masc,string ngaynhan, string makh, string manv, 
            string tenmay, string loaimay, string ghichu)
        {
            
            string query = "insert into SUA_CHUA (masc,ngay_nhan,makh,manv,ten_sp,loai_sp, tri_gia, tinh_trang, ghi_chu)" +
                           " values" +
                           " ('"+masc+ "', '"+ngaynhan+ "', '"+makh+ "', '"+manv+ "', N'"+tenmay+ "', N'"+loaimay+ "', '0', 'chuasua', N'"+ghichu+"')";
            if (DAO.ConnectSQL.Instance.ExecuteNonQuery(query) == 1)
            {
                return true;
            }
            else
                return false;
        }
        public bool Insert_KHACH_HANG(string makh, string ten_kh, string ngay_sinh, string dia_chi,
            string dien_thoai, string gioi_tinh)
        {

            string query = "insert into KHACH_HANG values ('"+makh+"', N'"+ten_kh+"', '"+ngay_sinh+"', N'"+dia_chi+"', '"+dien_thoai+"', N'"+gioi_tinh+"', '0')";
            if (DAO.ConnectSQL.Instance.ExecuteNonQuery(query) == 1)
            {
                return true;
            }
            else
                return false;
        }
        //form updatethong tin may fEditRepair.cs
        public void Update_SC(string masc, string tenmay, string ghichu,string loai)
        {
            string query = "update SUA_CHUA set ten_sp = N'" + tenmay + "' , ghi_chu = N'"+ ghichu +"', loai_sp = '"+ loai +"' where masc = '" + masc + "'";
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return;
        }

        public DataTable list_sua_chua_date_to_date(string ngay1, string ngay2)
        {
            string query = string.Format("select * from sua_chua where ngay_giao>='{0}' and ngay_giao<='{1}' and tinh_trang = 'thanhtoan' order by ngay_nhan asc", ngay1, ngay2);
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}
