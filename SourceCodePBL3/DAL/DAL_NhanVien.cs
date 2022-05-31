using SourceCodePBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCodePBL3.DAL
{
    class DAL_NhanVien
    {
        private static DAL_NhanVien _Instance;
        public static DAL_NhanVien Instance
        {
            get
            {
                if (_Instance == null) _Instance = new DAL_NhanVien();
                return _Instance;
            }
            private set { }
        }
        private DAL_NhanVien()
        {
            
        }
        public List<ThanhVien> GetAllTV()
        {
            List<ThanhVien> data = new List<ThanhVien>();
            string query = "select * from ThanhVien";
            foreach(DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                data.Add(GetTVByDataRow(i));
            }
            return data;
        }
        public ThanhVien GetTVByDataRow(DataRow i)
        {
            return new ThanhVien
            {
                LoaiThanhVien = i["LoaiThanhVien"].ToString(),
                TenThanhVien = i["TenThanhVien"].ToString(),
                TenDangNhap = i["TenDangNhap"].ToString(),
                MatKhau = i["MatKhau"].ToString(),
                NgayLamViec = Convert.ToDateTime(i["NgayLamViec"].ToString()),
                Luong = Convert.ToDecimal(i["Luong"].ToString()),
                SDT = i["SDT"].ToString()
            };
        }
        public void UpdateTV(ThanhVien TV)
        {
            string query = String.Format("update ThanhVien set LoaiThanhVien = '{0}', TenThanhVien = '{1}', MatKhau = '{2}', " +
                "NgayLamViec = '{3}', Luong = '{4}', SDT = '{5}' where TenDangNhap = '{6}'", TV.LoaiThanhVien, TV.TenThanhVien, TV.MatKhau, TV.NgayLamViec, TV.Luong, TV.SDT, TV.TenDangNhap);
            DBHelper.Instance.ExecuteDB(query);
        }
        public void AddTV(ThanhVien TV)
        {
            string query = String.Format("insert into ThanhVien(LoaiThanhVien, TenThanhVien, TenDangNhap, MatKhau, NgayLamViec, Luong, SDT) " +
                "values ('{0}', '{1}', '{2}', '{3}', '{4}', {5}, '{6}')", TV.LoaiThanhVien, TV.TenThanhVien, TV.TenDangNhap, TV.MatKhau, TV.NgayLamViec, TV.Luong, TV.SDT);
            DBHelper.Instance.ExecuteDB(query);
        }
        public void DeleteTV(string TenDangNhap)
        {
            string query = "delete from ThanhVien where TenDangNhap = '" + TenDangNhap + "'";
            DBHelper.Instance.ExecuteDB(query);
        }
    }
}
