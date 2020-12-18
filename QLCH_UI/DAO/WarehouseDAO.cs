using QLCH_UI.DTO;
using QLCH_UI.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Data;

namespace QLCH_UI.DAO
{
   
    class WarehouseDAO
    {
        private static WarehouseDAO instance;
        public static WarehouseDAO Instance
        {
            get
            {
                if (instance == null) instance = new WarehouseDAO();
                return WarehouseDAO.instance;
            }
            private set
            {
                WarehouseDAO.instance = value;
            }
        }
       
        private WarehouseDAO() { }
        public DataTable list_nhap_kho()
        {
            string query = "select * from nhap_kho";
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return (dt);
        }
        public DataTable viewinfoBill(string mahd)
        {
            string query = string.Format("select * from nhap_kho where manhaphang = '{0}'", mahd);
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return (dt);
        }
        public bool insert(WarehouseDTO a)
        {
            int result = 0;
            try
            {
                string query = string.Format("insert into nhap_kho(manhaphang,manguoinhap,masp,ten_sp,loai_sp,ngay_nhap,gia_nhap,so_luong,tong_tien) values ('{0}','{1}','{2}',N'{3}',N'{4}','{5}','{6}','{7}','{8}')", a.Manhaphang, a.Manguoinhap, a.Masp, a.Ten_sp, a.Loai_sp, a.Ngay_nhap, a.Gia_nhap, a.So_luong,a.Tong_tien);
                result = ConnectSQL.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (result == 0) return (false);
            else return (true);
        }

        public bool update_ton_kho(string masp, int a)
        {
            int result = 0;
            try
            {
                string query = string.Format("update san_pham set so_luong='{0}' where masp='{1}'", a, masp);
                result = ConnectSQL.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (result == 0) return (false);
            else return (true);
        }
        public bool delete(string mahd)
        {
            int result = 0;
            try
            {
                string query = string.Format("delete from nhap_kho where manhaphang='{0}'", mahd);
                result = ConnectSQL.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (result == 0) return (false);
            else return (true);
        }
        public bool edit(WarehouseDTO a)
        {
            int result = 0;
            try
            {
                string query = string.Format("update nhap_kho set manguoinhap='{0}', ngay_nhap='{1}', gia_nhap='{2}', so_luong='{3}', tong_tien='{4}' where manhaphang='{5}'", a.Manguoinhap, a.Ngay_nhap, a.Gia_nhap, a.So_luong, a.Tong_tien, a.Manhaphang);
                result = ConnectSQL.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (result == 0) return (false);
            else return (true);
        }

    }
}
