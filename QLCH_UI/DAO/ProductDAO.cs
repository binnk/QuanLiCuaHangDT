using QLCH_UI.DTO;
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
            //string query = "select * from san_pham";
            string query = "select masp as N'Mã sản phẩm',ten_sp as N'Tên sản phẩm',so_luong as N'Số lượng'  from san_pham";
            DataTable dt = ConnectSQL.Instance.ExecuteQuery(query);
            return (dt);
        }
        public byte[] ImageToByteArray(string a)
        {
            FileStream fs;
            fs = new FileStream(a, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
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
                throw ex;
            }
            if (result == 0) return (false);
            else return (true);
        }

        public bool Edit(ProductDTO a)
        {

            int result = 0;
            try
            {
                string query = string.Format("update san_pham set ten_sp= N'{0}', loai_sp= N'{1}', so_luong= '{2}', gia_nhap= '{3}', gia_ban= '{4}', img=N'{5}' where masp='{6}'", a.Ten_sp,a.Loai_sp,a.So_luong,a.Gia_nhap,a.Gia_ban,a.Anh);
                result = ConnectSQL.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
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
                byte[] k = ImageToByteArray(a.Anh);
                string l = Convert.ToBase64String(k);
                string query = string.Format("insert into san_pham(img,masp,ten_sp,loai_sp,so_luong,gia_nhap,gia_ban) values ('{0}','{1}',N'{2}',N'{3}','{4}','{5}','{6}')",l, a.Masp, a.Ten_sp, a.Loai_sp, a.So_luong, a.Gia_nhap, a.Gia_ban);
                result = ConnectSQL.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại");
            }
            if (result == 0) return (false);
            else return (true);
        }
      
    }
}
