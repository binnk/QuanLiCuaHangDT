using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCH_UI.DAO
{
    class BaocaoDAO
    {
        private static BaocaoDAO instance;

        public static BaocaoDAO Instance
        {
            get
            {
                if (instance == null) instance = new BaocaoDAO();
                return BaocaoDAO.instance;
            }
            private set
            {
                BaocaoDAO.instance = value;
            }
        }
        private BaocaoDAO() { }
        public string Get_Doanh_thu(string date1, string date2)
        {
            string query = "select sum(tri_gia) as summ from HOA_DON where ngay_ban >= '" + date1 + "' and  ngay_ban <= '" + date2 + "'";
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            string queryy = "select sum(tri_gia) as summ from SUA_CHUA where tinh_trang = 'thanhtoan' and ngay_giao >= '" + date1 + "' and  ngay_giao <= '" + date2 + "'";
            DataTable dtt = ConnectSQL.Instance.ExecuteQuery(queryy);

            try
            {
                return (Convert.ToDouble(dtt.Rows[0]["summ"])+Convert.ToDouble(dt.Rows[0]["summ"])).ToString("#,##0");
            }
            catch ( Exception e)
            {
                return "0";
            }
            
        }
        public string Get_So_HD(string date1, string date2)
        {
            string query = "select count(*) as summ from HOA_DON where ngay_ban >= '" + date1 + "' and ngay_ban <= '" + date2 + "'";
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            string queryy = "select count(*) as summ from SUA_CHUA where tinh_trang = 'thanhtoan' and ngay_giao >= '" + date1 + "' and  ngay_giao <= '" + date2 + "'";
            DataTable dtt = ConnectSQL.Instance.ExecuteQuery(queryy);
            try
            {
                return (Convert.ToDouble(dtt.Rows[0]["summ"])+Convert.ToDouble(dt.Rows[0]["summ"])).ToString("#,##0");
            }
            catch
            {
                return "0";
            }
        }
        public string Get_So_SP(string date1, string date2)
        {
            string query = "select sum(so_luong) as sum from HOA_DON, CTHD where HOA_DON.mahd = CTHD.mahd and ngay_ban >= '" + date1 + "' and ngay_ban <= '" + date2 + "'";
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);

            try
            {
                return Convert.ToDouble(dt.Rows[0]["sum"]).ToString("#,##0");
            }
            catch(Exception e)
             {
                return "0";
            }
        }
        public string Get_So_KH()
        {
            string query = "select count(*) as sum from KHACH_HANG";
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            try
            {
                return Convert.ToDouble(dt.Rows[0]["sum"]).ToString("#,##0");
            }
            catch (Exception e)
            {
                return "0";
            }
        }
        public DataTable Get_Top_3_KH(string date1, string date2)
        {
            string query =  "select T.makh, KHACH_HANG.ten_kh, T.doanh_thu from "+
                            "(select top 3 HOA_DON.makh, sum(HOA_DON.tri_gia) as doanh_thu from KHACH_HANG , HOA_DON "+
                            "where (ngay_ban between '"+ date1 +"' and '"+ date2 +"') "+
                            "and (HOA_DON.makh = KHACH_HANG.makh)"+
                            "group by HOA_DON.makh "+
                            "order by SUM(HOA_DON.tri_gia) desc) as T, KHACH_HANG "+
                            "where T.makh = KHACH_HANG.makh";
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable Get_Top_4_SP(string date1, string date2)
        {
            string query = "select SAN_PHAM.ten_sp , SAN_PHAM.img , T.sum "+
                            "from"+
                            "(select  top 4 CTHD.masp, sum(CTHD.so_luong) as 'sum' "+
                            "from CTHD, HOA_DON "+
                            "where ngay_ban between '"+ date1 +"' and '"+ date2 +"'" +
                            "and HOA_DON.mahd = CTHD.mahd "+
                            "group by CTHD.masp " +
                            "order by  SUM(CTHD.so_luong) desc) as T, SAN_PHAM "+
                            "where SAN_PHAM.masp = T.masp and SAN_PHAM.loai_sp <> 'linhkien' "+
                            "order by T.sum desc";
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return dt;
        }
        //loi nhuan ban hang
        public DataTable Revenue_Year_BH()
        {
            string query = "select sum(tri_gia) as doanh_thu, MONTH(ngay_ban) as thang from hoa_don group by month(ngay_ban)";
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);

            return dt;
        }
        //loi nhuan sua chua
        public DataTable Revenue_Year_SC()
        {
            string query = "select sum(tri_gia) as doanh_thu, month(ngay_giao) as thang from SUA_CHUA where tinh_trang ='thanhtoan' group by MONTH(ngay_giao)";
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);

            return dt;
        }
        // loi nhuan ban hang
        public DataTable Revenue_Month_BH(string month)
        {
            string query = "select sum(tri_gia) as doanh_thu, Day(ngay_ban) as ngay from hoa_don where MONTH(ngay_ban) = '"+ month +"' group by day(ngay_ban)";
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return dt;
        }
        // loi nhuan sua chua
        public DataTable Revenue_Month_SC(string month)
        {
            string query = " select sum(tri_gia) as doanh_thu, Day(ngay_giao) as ngay from SUA_CHUA where MONTH(ngay_giao) = '"+ month + "' and tinh_trang= 'thanhtoan' group by day(ngay_giao)";
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}
