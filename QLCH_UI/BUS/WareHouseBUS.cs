using QLCH_UI.DTO;
using QLCH_UI.DAO;
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
    public class WareHouseBUS
    {
            private static WareHouseBUS instance;
            public static WareHouseBUS Instance
            {
                get
                {
                    if (instance == null) instance = new WareHouseBUS();
                    return WareHouseBUS.instance;
                }
                private set
                {
                    WareHouseBUS.instance = value;
                }
            }
            private WareHouseBUS() { }
            public bool ImportWarehouse(WarehouseDTO a)
            {
                if (WarehouseDAO.Instance.insert(a) == true && ProductDAO.Instance.update_soluong(a.Masp, a.So_luong) == true) return (true);
                else return (false);
            }
    }
}
