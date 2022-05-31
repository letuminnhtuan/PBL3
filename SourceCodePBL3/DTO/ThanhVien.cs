using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCodePBL3.DTO
{
    class ThanhVien
    {
        public string LoaiThanhVien { get; set; }
        public string TenThanhVien { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public DateTime NgayLamViec { get; set; }
        public decimal Luong { get; set; }
        public string SDT { get; set; }
        public ThanhVien() { }
        public ThanhVien(ThanhVien TV)
        {
            this.LoaiThanhVien = TV.LoaiThanhVien;
            this.TenThanhVien = TV.TenThanhVien;
            this.TenDangNhap = TV.TenDangNhap;
            this.MatKhau = TV.MatKhau;
            this.NgayLamViec = TV.NgayLamViec;
            this.Luong = TV.Luong;
            this.SDT = TV.SDT;
        }
    }
}
