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
            if (value[0] == '.') return (false);
            if (l == 0) return (false);
            int d = 0;
            for (int i = 0; i < l; i++)
                if (value[i] == '.')
                {
                    d++;
                    if (d == 2) return (false);
                }
                else
                {
                    if (value[i] < 48 || value[i] > 57) return (false);
                }
            return (true);
        }
        // gia ban
        public bool gia_ban(string value)
        {
            int l = value.Length;
            if (value[0] == '.') return (false);
            if (l == 0) return (false);
            int d = 0;
            for (int i = 0; i < l; i++)
                if (value[i] == '.')
                {
                    d++;
                    if (d == 2) return (false);
                }
                else
                {
                    if (value[i] < 48 || value[i] > 57) return (false);
                }
            return (true);
        }

        private ProductBUS() { }
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
