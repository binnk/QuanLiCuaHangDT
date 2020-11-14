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
        public bool insert_product(ProductDTO a)
        {
            return (ProductDAO.Instance.insert(a));
        }
        public bool delete_product(string ID)
        {
            return (ProductDAO.Instance.Delete(ID));
        }
    }
}
