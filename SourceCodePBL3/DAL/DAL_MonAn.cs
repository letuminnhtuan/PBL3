using SourceCodePBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCodePBL3.DAL
{
    class DAL_MonAn
    {
        private static DAL_MonAn _Instance;
        public static DAL_MonAn Instance
        {
            get
            {
                if (_Instance == null) _Instance = new DAL_MonAn();
                return _Instance;
            }
            private set { }
        }
        private DAL_MonAn()
        {
            
        }
        public List<LoaiMonAn> GetAllLoaiMonAn()
        {
            List<LoaiMonAn> data = new List<LoaiMonAn>();
            string query = "select * from LoaiMonAn";
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                data.Add(GetLoaiMAByDataRow(i));
            }
            return data;
        }
        public LoaiMonAn GetLoaiMAByDataRow(DataRow i)
        {
            return new LoaiMonAn
            {
                MaLoaiMonAn = i["MaLoaiMonAn"].ToString(),
                TenLoaiMonAn = i["TenLoaiMonAn"].ToString()
            };
        }
        public List<MonAn> GetAllMA()
        {
            List<MonAn> data = new List<MonAn>();
            string query = "select * from MonAn";
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                data.Add(GetMAByDataRow(i));
            }
            return data;
        }
        public MonAn GetMAByDataRow(DataRow i)
        {
            return new MonAn
            {
                MaLoaiMonAn = i["MaLoaiMonAn"].ToString(),
                MaMonAn = i["MaMonAn"].ToString(),
                TenMonAn = i["TenMonAn"].ToString(),
                GiaTien = Convert.ToDecimal(i["GiaTien"].ToString())
            };
        }
        public List<MonAn> GetMAByMaLoaiMonAn(string MaLoaiMonAn)
        {
            List<MonAn> data = new List<MonAn>();
            if (MaLoaiMonAn.Equals("All"))
            {
                data = GetAllMA();
            }
            else
            {
                foreach (MonAn i in GetAllMA())
                {
                    if (i.MaLoaiMonAn.Equals(MaLoaiMonAn)) data.Add(i);
                }
            }
            return data;
        }
        public void UpdateMA(MonAn MA)
        {
            string query = String.Format("update MonAn set MaLoaiMonAn = '{0}', TenMonAn = '{1}', GiaTien = {2} where MaMonAn = '{3}'", MA.MaLoaiMonAn, MA.TenMonAn, MA.GiaTien, MA.MaMonAn);
            DBHelper.Instance.ExecuteDB(query);
        }
        public void AddMA(MonAn MA)
        {
            string query = String.Format("insert into MonAn(MaLoaiMonAn, MaMonAn, TenMonAn, GiaTien) values ('{0}', '{1}', '{2}', {3})", MA.MaLoaiMonAn, MA.MaMonAn, MA.TenMonAn, MA.GiaTien);
            DBHelper.Instance.ExecuteDB(query);
        }
        public void DeleteMA(string MaMonAn)
        {
            string query = "delete from MonAn where MaMonAn = '" + MaMonAn + "'";
            DBHelper.Instance.ExecuteDB(query);
        }
    }
}
