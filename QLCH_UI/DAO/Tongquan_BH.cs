using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCH_UI.DAO
{
    class Tongquan_BH
    {
        private static Tongquan_BH instance;

        public static Tongquan_BH Instance
        {
            get
            {
                if (instance == null) instance = new Tongquan_BH();
                return Tongquan_BH.instance;
            }
            private set
            {
                Tongquan_BH.instance = value;
            }
        }
        private Tongquan_BH() { }
        public string Get_doanhthu(string manv)
        {
            string query = "select sum(tri_gia) as summ from hoa_don where manv = '" + manv + "'";
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);

            try
            {
                return (Convert.ToDouble(dt.Rows[0]["summ"])).ToString("#,##0");
            }
            catch (Exception e)
            {
                return "0";
            }
        }
        public string Get_sohoadon(string manv)
        {
            string query = "select count(*) as summ from hoa_don where manv = '" + manv + "'";
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);


            try
            {
                return (Convert.ToDouble(dt.Rows[0]["summ"])).ToString("#,##0");
            }
            catch (Exception e)
            {
                return "0";
            }
        }
        public string Get_dontrongngay(string manv)
        {
            string datetime = DateTime.Now.ToString("yyyy-MM-dd");
            string query = "select count(*)  as summ from hoa_don where manv = '" + manv + "' and ngay_ban = '" + datetime + "'";
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);

            try
            {
                return (Convert.ToDouble(dt.Rows[0]["summ"])).ToString("#,##0");
            }
            catch (Exception e)
            {
                return "0";
            }
        }
        public DataTable History(string manv)
        {
            string query = "select s.mahd, s.ngay_ban, k.ten_kh, s.tri_gia from hoa_don S, KHACH_HANG K"
                           + " where s.manv = '" + manv + "' and K.makh = S.makh";
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}
