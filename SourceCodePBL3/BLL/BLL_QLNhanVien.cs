using SourceCodePBL3.DAL;
using SourceCodePBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCodePBL3.BLL
{
    class BLL_QLNhanVien
    {
        private static BLL_QLNhanVien _Instance;
        public static BLL_QLNhanVien Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_QLNhanVien();
                return _Instance;
            }
            private set { }
        }
        private BLL_QLNhanVien()
        {

        }
        public ThanhVien LogIn(string username, string password)
        {
            ThanhVien TV = null;
            foreach (ThanhVien i in DAL_NhanVien.Instance.GetAllTV())
            {
                if (i.TenDangNhap.Equals(username) && i.MatKhau.Equals(password))
                {
                    TV = new ThanhVien(i);
                    break;
                }
            }
            return TV;
        }
        public ThanhVien GetTVByTenDangNhap(string TenDangNhap)
        {
            ThanhVien TV = null;
            foreach (ThanhVien i in DAL_NhanVien.Instance.GetAllTV())
            {
                if (i.TenDangNhap.Equals(TenDangNhap))
                {
                    TV = new ThanhVien(i);
                }
            }
            return TV;
        }
        public void AddUpdateTV(ThanhVien TV)
        {
            if(GetTVByTenDangNhap(TV.TenDangNhap) == null)
            {
                DAL_NhanVien.Instance.AddTV(TV);
            }
            else
            {
                DAL_NhanVien.Instance.UpdateTV(TV);
            }
        }
    }
}
