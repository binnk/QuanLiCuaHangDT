using QLCH_UI.DAO;
using QLCH_UI.DTO;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace QLCH_UI.BUS
{
    public class ProductBUS
    {
        private static ProductBUS instance;

        public static ProductBUS Instance
        {
            get
            {
                if (instance == null) instance = new ProductBUS();
                return ProductBUS.instance;
            }
            private set
            {
                ProductBUS.instance = value;
            }
        }
        private ProductBUS() { }

        // kiem tra ma 
        public bool masp(string value)
        {
            int l = value.Length;
            if (l == 0) return (false);
            int k = 1;
            if (l > 9) return (false);
            for (int i = 0; i < l; i++)
            {
                if ((value[i] >= 65 && value[i] <= 90) || (value[i] >= 97 && value[i] <= 122) || (value[i] >= 48 && value[i] <= 57)) k = 1;
                else return (false);
            }
            return (true);
        }
        // kiem tra ten 
        public bool ten_sp(string value)
        {
            int l = value.Length;
            if (l > 49 || l == 0) return false;
            return (true);
        }
        //kiem tra loai_sp
        public bool loai_sp(string value)
        {
            int l = value.Length;
            if (l == 0) return (false);
            return (true);
        }
        //gia nhap
        public bool gia_nhap(string value)
        {
            int l = value.Length;
            if (l == 0) return (false);
            if (value[0] == '.') return (false);
            int d = 0;
            for (int i = 0; i < l; i++)
                if (value[i] == '.')
                {
                    d++;
                    if (d == 2) return (false);
                }
                else
                {
                    if ((value[i] < 48 || value[i] > 57) && (value[i] != ',')) return (false);
                }
            return (true);
        }
        // gia ban
        public bool gia_ban(string value)
        {
            int l = value.Length;
            if (l == 0) return (false);
            if (value[0] == '.') return (false);
            int d = 0;
            for (int i = 0; i < l; i++)
                if (value[i] == '.')
                {
                    d++;
                    if (d == 2) return (false);
                }
                else
                {
                    if ((value[i] < 48 || value[i] > 57) && (value[i] != ',')) return (false);
                }
            return (true);
        }
        // kiem tra so luong
        public bool so_luong(string value)
        {
            int l = value.Length;
            if (l == 0) return (false);
            for (int i = 0; i < l; i++)
                if (value[i] < 48 || value[i] > 57) return (false);
            return (true);
        }
        public Image ByteToImg (string byteString)
        {
            byte[] imgBytes = Convert.FromBase64String(byteString);
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
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

        public bool insert_product(ProductDTO a)
        {
            return (ProductDAO.Instance.insert(a));
        }
        public bool delete_product(string ID)
        {
            return (ProductDAO.Instance.Delete(ID));
        }
        public bool edit_product(ProductDTO a)
        {
            return (ProductDAO.Instance.Edit(a));
        }
    }
}
