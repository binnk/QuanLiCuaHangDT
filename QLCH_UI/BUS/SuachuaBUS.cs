using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCH_UI.BUS
{
    class SuachuaBUS
    {
        private static SuachuaBUS instance;

        public static SuachuaBUS Instance
        {
            get
            {
                if (instance == null) instance = new SuachuaBUS();
                return SuachuaBUS.instance;
            }
            private set
            {
                SuachuaBUS.instance = value;
            }
        }
        private SuachuaBUS() { }
        public string Check_fault(string hoten, string sdt, string diachi, string tenmay, string ghichu)
        {
            string fault = "";
            if(hoten.Length > 40 || hoten.Length == 0)
            {
                fault = "Tên quá dài hoặc trống.";
                return fault;
            }
            if (sdt.Length > 11 || sdt.Length == 0)
            {
                fault = "Số điện thoại không hợp lệ hoặc trống.";
                return fault;
            }
            foreach( char i in sdt)
            {
                if(i < '0' || i>'9')
                {
                    fault = "Số điện thoại không hợp lệ.";
                    return fault;
                }
            }    
            if (diachi.Length > 90 || diachi.Length == 0)
            {
                fault = "Địa chỉ quá dài hoặc trống.";
                return fault;
            }
            if (tenmay.Length > 50 || tenmay.Length == 0)
            {
                fault = "Tên máy quá dài hoặc trống.";
                return fault;
            }
            if (ghichu.Length > 900 )
            {
                fault = "Ghi chú quá dài.";
                return fault;
            }
            return fault;
        }
    }
}
