using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCH_UI.DTO
{
    public class ProductDTO
    {
        public ProductDTO(string anh,string masp, string ten_sp,string loai_sp, double gia_nhap, double gia_ban, int so_luong)
        {
            this.Anh = anh;
            this.Masp = masp;
            this.Ten_sp = ten_sp;
            this.Loai_sp = loai_sp;
            this.Gia_nhap = gia_nhap;
            this.Gia_ban = gia_ban;
            this.so_luong = so_luong;
        }
        private int so_luong;
        private string anh;
        private string masp;
        private string ten_sp;
        private string loai_sp;
        private double gia_nhap;
        private double gia_ban;

      
        public string Masp { get => masp; set => masp = value; }
        public string Ten_sp { get => ten_sp; set => ten_sp = value; }
        public string Loai_sp { get => loai_sp; set => loai_sp = value; }
        public int So_luong { get => so_luong; set => so_luong = value; }
        public double Gia_nhap { get => gia_nhap; set => gia_nhap = value; }
        public double Gia_ban { get => gia_ban; set => gia_ban = value; }
        public string Anh { get => anh; set => anh = value; }
    }
}
