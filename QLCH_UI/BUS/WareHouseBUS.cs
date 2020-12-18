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
            public bool manguoinhap(string manguoinhap)
            {
                DataTable a = StaffDAO.Instance.Stafflist();
                for (int i=0;i<a.Rows.Count;i++)
                {
                    if (a.Rows[i]["manv"].ToString() == manguoinhap) return (true);
                }
                return (false);
            }
            public bool ImportWarehouse(WarehouseDTO a)
            {
                if (WarehouseDAO.Instance.insert(a) == true && ProductDAO.Instance.update_soluong(a.Masp, a.So_luong) == true) return (true);
                else return (false);
            }
        int sl_tonkho = -1;
     
        public bool kiemtra(int soluong, string masp)
        {
            DataTable c = ProductDAO.Instance.viewinfo(masp);
            if (int.Parse(c.Rows[0]["ton_tai"].ToString()) == 0) return (true);
            DataTable a = ProductDAO.Instance.viewinfo(masp);
            if (a.Rows.Count > 0)
            {
                int sl = int.Parse(a.Rows[0]["so_luong"].ToString());
                if (sl - soluong >= 0)
                {
                    sl_tonkho = -1;
                    sl_tonkho = sl - soluong;
                    return (true);
                }
                else return (false);
            }
            else return (true);
        }
            public bool kt_sl(int soluong,string masp)
            {
                DataTable c = ProductDAO.Instance.viewinfo(masp);
                if (int.Parse(c.Rows[0]["ton_tai"].ToString()) == 0) return (false);
                DataTable a = ProductDAO.Instance.viewinfo(masp);
                if (a.Rows.Count > 0)
                {
                    int sl = int.Parse(a.Rows[0]["so_luong"].ToString());
                    if (sl - soluong >= 0)
                    {
                        sl_tonkho = -1;
                        sl_tonkho = sl - soluong;
                        return (true);
                    }
                    else return (false);
                }
                return (false);
            }
        public bool edit(WarehouseDTO a)
        {
            DataTable c = ProductDAO.Instance.viewinfo(a.Masp);
            if (int.Parse(c.Rows[0]["ton_tai"].ToString()) == 0) return (false);
            if (WarehouseDAO.Instance.edit(a) && WarehouseDAO.Instance.update_ton_kho(a.Masp, sl_tonkho)) return (true);
            return (false);
        }
        public bool delete(string mahd, string masp)
        {
            DataTable a = WarehouseDAO.Instance.viewinfoBill(mahd);
            int soluong = int.Parse(a.Rows[0]["so_luong"].ToString());
            if (WareHouseBUS.Instance.kiemtra(soluong, masp))
            {
                if (sl_tonkho != -1) WarehouseDAO.Instance.update_ton_kho(masp, sl_tonkho);
                if (WarehouseDAO.Instance.delete(mahd))
                {
                    MessageBox.Show("Xóa thành công");
                    return (true);
                }
            }
            else
            {
                MessageBox.Show("Số lượng tồn kho không đủ");
                return (false);
            }
            return (false);
        }
    }
}
