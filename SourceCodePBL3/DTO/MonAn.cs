using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCodePBL3.DTO
{
    class MonAn
    {
        public string MaLoaiMonAn { get; set; }
        public string MaMonAn { get; set; }
        public string TenMonAn { get; set; }
        public decimal GiaTien { get; set; }
        public MonAn() { }
        public MonAn(MonAn MA)
        {
            this.MaLoaiMonAn = MA.MaLoaiMonAn;
            this.MaMonAn = MA.MaMonAn;
            this.TenMonAn = MA.TenMonAn;
            this.GiaTien = MA.GiaTien;
        }
    }
}
