﻿using SourceCode.DAL;
using SourceCode.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.BLL
{
    class BLL_QLHoaDon
    {
        QLTS db;
        private static BLL_QLHoaDon _Instance;
        public static BLL_QLHoaDon Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_QLHoaDon(new QLTS());
                return _Instance;
            }
            private set { }
        }
        private BLL_QLHoaDon(QLTS db)
        {
            this.db = db;
        }
        public List<HoaDon> GetAllHoaDon()
        {
            List<HoaDon> data = new List<HoaDon>();
            var list = db._HoaDon.Select(p => p);
            foreach (tHoaDon i in list)
            {
                data.Add(new HoaDon
                {
                    MaHoaDon = i.MaHoaDon,
                    MaBanAn = i.MaBanAn,
                    MaNVOrder = i.MaNVOrder,
                    NgayThanhToan = i.NgayThanhToan,
                    TrangThaiTT = i.TrangThaiTT,
                    TongTien = i.TongTien,
                    HinhThucTT = i.HinhThucTT
                });
            }
            return data;
        }
        public List<HoaDon> GetDSHoaDon(DateTime dateStart, DateTime dateEnd)
        {
            List<HoaDon> data = new List<HoaDon>();
            var list = db._HoaDon.Select(p => p).Where(p => p.NgayThanhToan.CompareTo(dateStart) == 1 && p.NgayThanhToan.CompareTo(dateEnd) == -1);
            foreach(tHoaDon i in list)
            {
                data.Add(new HoaDon
                {
                    MaHoaDon = i.MaHoaDon,
                    MaBanAn = i.MaBanAn,
                    MaNVOrder = i.MaNVOrder,
                    NgayThanhToan = i.NgayThanhToan,
                    TrangThaiTT = i.TrangThaiTT,
                    TongTien = i.TongTien,
                    HinhThucTT = i.HinhThucTT
                });
            }
            return data;
        }
    }
}
