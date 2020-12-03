using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCH_UI.DTO
{
    public class StaffDTO
    {
        public StaffDTO(string username, string manv, string ten_nv, DateTime ngay_sinh, string dia_chi, string dien_thoai, string gioi_tinh)
        {
            this.Username = username;
            this.Manv = manv;
            this.Ten_nv = ten_nv;
            this.Ngay_sinh = ngay_sinh;
            this.Dia_chi = dia_chi;
            this.Dien_thoai = dien_thoai;
            this.Gioi_tinh = gioi_tinh;
        }
        private string username;
        private string manv;
        private string ten_nv;
        private DateTime ngay_sinh;
        private string dia_chi;
        private string dien_thoai;
        private string gioi_tinh;

        public string Username { get => username; set => username = value; }
        public string Manv { get => manv; set => manv = value; }
        public string Ten_nv { get => ten_nv; set => ten_nv = value; }
        public DateTime Ngay_sinh { get => ngay_sinh; set => ngay_sinh = value; }
        public string Dia_chi { get => dia_chi; set => dia_chi = value; }
        public string Dien_thoai { get => dien_thoai; set => dien_thoai = value; }
        public string Gioi_tinh { get => gioi_tinh; set => gioi_tinh = value; }
    }
}
