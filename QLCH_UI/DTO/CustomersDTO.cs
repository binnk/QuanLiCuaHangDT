using System;
using System.Data;
using System.Web.UI.Design.WebControls;

namespace QLCH_UI.DTO
{
    public class CustomersDTO
    {
        public CustomersDTO(string makh, string ten_kh,DateTime ngay_sinh, string dia_chi, string dien_thoai, string gioi_tinh)
        {
            this.Makh = makh;
            this.Ten_kh = ten_kh;
            this.Ngay_sinh = ngay_sinh;
            this.Dia_chi = dia_chi;
            this.Dien_thoai = dien_thoai;
            this.Gioi_tinh = gioi_tinh;
        }
        private string makh;
        private string ten_kh;
        private DateTime ngay_sinh;
        private string dia_chi;
        private string dien_thoai;
        private string gioi_tinh;
        public string Makh { get => makh; set => makh = value; }
        public string Ten_kh { get => ten_kh; set => ten_kh = value; }
        public DateTime Ngay_sinh { get => ngay_sinh; set => ngay_sinh = value; }
        public string Dia_chi { get => dia_chi; set => dia_chi = value; }
        public string Dien_thoai { get => dien_thoai; set => dien_thoai = value; }
        public string Gioi_tinh { get => gioi_tinh; set => gioi_tinh = value; }
    }
}
