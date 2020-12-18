using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCH_UI.DTO
{
    public class WarehouseDTO
    {
        public WarehouseDTO(string manhaphang, string manguoinhap, string masp, string ten_sp, string loai_sp, DateTime ngay_nhap, double gia_nhap, int so_luong,decimal  tong_tien)
        {
            this.Manhaphang = manhaphang;
            this.Manguoinhap = manguoinhap;
            this.Masp = masp;
            this.Ten_sp = ten_sp;
            this.Loai_sp = loai_sp;
            this.Ngay_nhap = ngay_nhap;
            this.Gia_nhap = gia_nhap;
            this.So_luong = so_luong;
            this.Tong_tien = tong_tien;
        }
        private string manhaphang;
        private string manguoinhap;
        private DateTime ngay_nhap;
        private int so_luong;
        private string masp;
        private string ten_sp;
        private string loai_sp;
        private double gia_nhap;
        private decimal tong_tien;

        public DateTime Ngay_nhap { get => ngay_nhap; set => ngay_nhap = value; }
        public int So_luong { get => so_luong; set => so_luong = value; }
        public string Masp { get => masp; set => masp = value; }
        public string Ten_sp { get => ten_sp; set => ten_sp = value; }
        public string Loai_sp { get => loai_sp; set => loai_sp = value; }
        public double Gia_nhap { get => gia_nhap; set => gia_nhap = value; }
        public string Manhaphang { get => manhaphang; set => manhaphang = value; }
        public string Manguoinhap { get => manguoinhap; set => manguoinhap = value; }
        public decimal Tong_tien { get => tong_tien; set => tong_tien = value; }
    }
}
