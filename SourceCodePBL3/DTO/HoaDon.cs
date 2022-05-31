using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCodePBL3.DTO
{
    class HoaDon
    {
        public string MaHoaDon { get; set; }
        public string MaBanAn { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public decimal TongTien { get; set; }
        public string MaNhanVienOrder { get; set; }
        public bool TrangThaiTT { get; set; }
        public string HinhThucTT { get; set; }
    }
}
