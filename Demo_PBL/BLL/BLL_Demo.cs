using Demo_PBL.DAL;
using Demo_PBL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_PBL.BLL
{
    class BLL_Demo
    {
        private static BLL_Demo _Instance;
        public static BLL_Demo Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_Demo();
                return _Instance;
            }
            private set { }
        }
        private BLL_Demo()
        {

        }
        // Log In
        public bool LogIn(string TK, string MK)
        {
            bool check = false;
            string query = "select * from Thanhvien where TenDangNhap = '" + TK + "'";
            if (DBHelper.Instance.GetRecords(query).Rows.Count == 1 && DBHelper.Instance.GetRecords(query).Rows[0]["MatKhau"].ToString().Equals(MK))
            {
                check = true;
            }
            return check;
        }
        public string Role(string TenDN)
        {
            string query = "select * from ThanhVien where TenDangNhap = '" + TenDN + "'";
            DataTable dt = DBHelper.Instance.GetRecords(query);
            return dt.Rows[0]["LoaiThanhVien"].ToString();
        }
        // Tai khoan
        public DataTable GetTK(string str)
        {
            string query = "select LoaiThanhVien, TenThanhVien, TenDangNhap, MatKhau from ThanhVien";
            if (str != "") query += " where TenDangNhap like '%" + str + "%'";
            return DBHelper.Instance.GetRecords(query);
        }
        // Hoa Don
        public DataTable GetHD(int index, string dateStart, string dateEnd)
        {
            string query = "select MaHoaDon, NgayThanhToan, TrangThaiTT, HinhThucTT, TongTien from HoaDon";
            if(index > 0)
            {
                query += " where NgayThanhToan > " + dateStart + " and NgayThanhToan < " + dateEnd;
            }
            return DBHelper.Instance.GetRecords(query);
        }
        // Nhan vien

        // Mon an
        public DataTable GetMA(string MaMonAn)
        {
            string query = "select * from MonAn";
            if (MaMonAn != "") query += " where MaMonAn = '" + MaMonAn + "'";
            return DBHelper.Instance.GetRecords(query);
        }
        public DataTable TimMA(string str)
        {
            string query = "select * from MonAn";
            if (str != "") query += " where TenMonAn like '%" + str + "%'";
            return DBHelper.Instance.GetRecords(query);
        }
        public void Add_UpdateMonAn(MonAn ma)
        {
            string MaLoai = DBHelper.Instance.GetRecords("select * from LoaiMonAn where TenLoaiMonAn = '" + ma.MaLoaiMonAn + "'").Rows[0]["MaLoaiMonAn"].ToString();
            string query = "select * from MonAn where MaMonAn = '" + ma + "'";
            string sql = "";
            if (DBHelper.Instance.GetRecords(query).Rows.Count == 0) // => add
            {
                sql = "insert into MonAn(MaLoaiMonAn, MaMonAn, TenMonAn, GiaTien) values ('" + MaLoai + "', '" + ma.MaMonAn + "', '" + ma.TenMonAn + "'," + ma.GiaTien + ")";
            }
            else
            {
                sql = "update MonAn set MaLoaiMonAn = '" + MaLoai + "', TenMonAn = '" + ma.TenMonAn + "', GiaTien = " + ma.GiaTien + " where MaMonAn = '" + ma.MaMonAn + "'";
            }
            DBHelper.Instance.ExecuteDB(sql);
        }
        // => List LoaiMonAn
        public List<CBBItem> ListLoaiMonAn()
        {
            List<CBBItem> data = new List<CBBItem>();
            string query = "select * from LoaiMonAn";
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                data.Add(new CBBItem { Key = i["MaLoaiMonAn"].ToString(), Value = i["TenLoaiMonAn"].ToString()});
            }
            return data;
        }
    }
}
