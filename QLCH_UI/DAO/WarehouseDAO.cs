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
        public bool insert(WarehouseDTO a)
        {
            int result = 0;
            try
            {
                string query = string.Format("insert into nhap_kho(masp,ten_sp,loai_sp,ngay_nhap,gia_nhap,so_luong) values ('{0}',N'{1}',N'{2}','{3}','{4}','{5}')", a.Masp,a.Ten_sp,a.Loai_sp,a.Ngay_nhap,a.Gia_nhap,a.So_luong);
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
