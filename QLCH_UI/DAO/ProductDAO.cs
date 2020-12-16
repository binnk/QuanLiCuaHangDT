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
    public class ProductDAO
    {
        private static ProductDAO instance;

        public static ProductDAO Instance
        {
            get
            {
                if (instance == null) instance = new ProductDAO();
                return ProductDAO.instance;
            }
            private set
            {
                ProductDAO.instance = value;
            }
        }
        private ProductDAO() { }
        public DataTable Productlist()
        {
            string query = "select * from san_pham";
            //string query = "select masp as N'Mã sản phẩm',ten_sp as N'Tên sản phẩm',so_luong as N'Số lượng'  from san_pham";
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return (dt);
        }
    
        public bool Delete(string ID)
        {
            int result = 0;
            try
            {
                string query = string.Format("delete from san_pham where masp= '{0}'", ID);
                result = ConnectSQL.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (result == 0) return (false);
            else return (true);
        }
        public bool update_soluong(string ID,int so_luong)
        {
            int result = 0;
            try
            {
                string query = string.Format("update san_pham set so_luong=so_luong + '{0}' where masp='{1}'", so_luong,ID);
                result = ConnectSQL.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (result == 0) return (false);
            else return (true);
        }
        public bool Edit(ProductDTO a)
        {
            int result = 0;
            try
            {
              
                string query = string.Format("update san_pham set ten_sp= N'{0}', loai_sp= N'{1}', so_luong= '{2}', gia_nhap= '{3}', gia_ban= '{4}', img=N'{5}' where masp='{6}'", a.Ten_sp,a.Loai_sp,a.So_luong,a.Gia_nhap,a.Gia_ban,a.Anh,a.Masp);
                result = ConnectSQL.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (result == 0) return (false);
            else return (true);
        }

        public DataTable viewinfo(string ID)
        {
            string query = String.Format("select * from san_pham where masp='{0}'",ID);
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return (dt);
        }

        public bool insert(ProductDTO a)
        {
            int result = 0;
            try
            {
                string query = string.Format("insert into san_pham(img,masp,ten_sp,loai_sp,so_luong,gia_nhap,gia_ban) values ('{0}','{1}',N'{2}',N'{3}','{4}','{5}','{6}')",a.Anh, a.Masp, a.Ten_sp, a.Loai_sp, a.So_luong, a.Gia_nhap, a.Gia_ban);
                result = ConnectSQL.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại");
            }
            if (result == 0) return (false);
            else return (true);
        }
        public DataTable search_product_by_name(string ten_sp)
        {
            string query = string.Format("select * from san_pham where dbo.fuConvertToUnsign1(ten_sp) like N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", ten_sp);
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return (dt);
        }
        public DataTable search_product_by_masp(string masp)
        {
            string query = string.Format("select * from san_pham where dbo.fuConvertToUnsign1(masp) like N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", masp);
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return (dt);
        }
    }
}
