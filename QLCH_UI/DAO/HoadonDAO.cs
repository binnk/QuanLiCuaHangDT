using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCH_UI.DAO
{
    class HoadonDAO
    {
        private static HoadonDAO instance;

        public static HoadonDAO Instance
        {
            get
            {
                if (instance == null) instance = new HoadonDAO();
                return HoadonDAO.instance;
            }
            private set
            {
                HoadonDAO.instance = value;
            }
        }
        private HoadonDAO() { }
        public DataTable Hoadonlist()
        {
            string query = "select d.mahd,d.makh,d.manv,d.ngay_ban,d.tri_gia,k.ten_kh,n.ten_nv from HOA_DON d,KHACH_HANG k,NHAN_VIEN n"
                            + " where d.manv = n.manv and d.makh = k.makh";
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return (dt);
        }
        public DataTable Hoadon(string mahd)
        {
            string query = "select * from hoa_don where mahd ='" + mahd + "'";
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return (dt);
        }
        public DataTable CTHD(string mahd)
        {
            string query = "select CTHD.masp, SAN_PHAM.ten_sp, CTHD.so_luong, SAN_PHAM.gia_ban from CTHD, SAN_PHAM where mahd = '" + mahd + "' and CTHD.masp = SAN_PHAM.masp";
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return (dt);
        }
        public DataTable Khach_hang(string makh)
        {
            string query = "select * from khach_hang where makh ='" + makh + "'";
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return (dt);
        }
        public DataTable Nhan_vien(string manv)
        {
            string query = "select ten_nv from nhan_vien where manv ='" + manv + "'";
            
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return (dt);
        }
        public DataTable Search(string ss)
        {
            string query = "select d.mahd,d.makh,d.manv,d.ngay_ban,d.tri_gia,k.ten_kh,n.ten_nv from HOA_DON d,KHACH_HANG k,NHAN_VIEN n"
                            +" where(d.manv = n.manv and d.makh = k.makh) and(k.ten_kh like N'%"+ss+"%' or n.ten_nv like N'%"+ss+"%' or d.mahd like N'%"+ss+"%' or k.dien_thoai like N'%"+ss+"%')";

            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return (dt);
        }
        public DataTable listHD_date_to_date(string ngay1, string ngay2)
        { 
            string query = string.Format("select * from hoa_don where ngay_ban>='{0}' and ngay_ban<='{1}' order by ngay_ban asc",ngay1,ngay2);
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return (dt);
        }
    }
}
