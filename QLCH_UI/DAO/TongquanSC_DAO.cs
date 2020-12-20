using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCH_UI.DAO
{
    class TongquanSC_DAO
    {
        private static TongquanSC_DAO instance;

        public static TongquanSC_DAO Instance
        {
            get
            {
                if (instance == null) instance = new TongquanSC_DAO();
                return TongquanSC_DAO.instance;
            }
            private set
            {
                TongquanSC_DAO.instance = value;
            }
        }
        private TongquanSC_DAO() { }
        public string Get_doanhthu(string manv)
        {
            string query = "select sum(tri_gia) as summ from SUA_CHUA where manv = '"+manv+"'";
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
            string query = "select count(*) as summ from SUA_CHUA where manv = '"+manv+"'";
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
            string query = "select count(*)  as summ from SUA_CHUA where manv = '"+manv+"' and ngay_nhan = '"+datetime+"'";
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
           
            try
            {
                return ( Convert.ToDouble(dt.Rows[0]["summ"])).ToString("#,##0");
            }
            catch (Exception e)
            {
                return "0";
            }
        }
        public DataTable History(string manv)
        {
            string query = "select s.masc, s.ngay_nhan, k.ten_kh, s.tri_gia from SUA_CHUA S, KHACH_HANG K"
                           +" where s.manv = '"+manv+"' and K.makh = S.makh";
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}
