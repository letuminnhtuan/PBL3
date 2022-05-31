using SourceCodePBL3.DAL;
using SourceCodePBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCodePBL3.BLL
{
    class BLL_QLMonAn
    {
        private static BLL_QLMonAn _Instance;
        public static BLL_QLMonAn Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_QLMonAn();
                return _Instance;
            }
            private set { }
        }
        private BLL_QLMonAn()
        {

        }
        public List<CBBItem> GetLoaiMonAn()
        {
            List<CBBItem> data = new List<CBBItem>();
            foreach(LoaiMonAn i in DAL_MonAn.Instance.GetAllLoaiMonAn())
            {
                data.Add(new CBBItem { Key = i.MaLoaiMonAn, Value = i.TenLoaiMonAn });
            }
            return data;
        }
        public List<MonAn> GetDSMonAn(string MaLoaiMonAn, string txt)
        {
            List<MonAn> data = new List<MonAn>();
            if (txt.Equals(""))
            {
                data = DAL_MonAn.Instance.GetMAByMaLoaiMonAn(MaLoaiMonAn);
            }
            else
            {
                foreach(MonAn i in DAL_MonAn.Instance.GetMAByMaLoaiMonAn(MaLoaiMonAn))
                {
                    if (i.TenMonAn.Contains(txt)) data.Add(i);
                }
            }
            return data;
        }
        public MonAn GetMonAnByMaMonAn(string MaMonAn)
        {
            MonAn MA = null;
            foreach(MonAn i in DAL_MonAn.Instance.GetAllMA())
            {
                if (i.MaMonAn.Equals(MaMonAn))
                {
                    MA = new MonAn(i);
                    break;
                }
            }
            return MA;
        }
        public void AddUpdateMA(MonAn MA)
        {
            if (GetMonAnByMaMonAn(MA.MaMonAn) == null)
            {
                DAL_MonAn.Instance.AddMA(MA);
            }
            else
            {
                DAL_MonAn.Instance.UpdateMA(MA);
            }
        }
        public void DeleteMA(string MaMonAn)
        {
            DAL_MonAn.Instance.DeleteMA(MaMonAn);
        }
    }
}
