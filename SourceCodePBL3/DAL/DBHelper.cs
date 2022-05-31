using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCodePBL3.DAL
{
    class DBHelper
    {
        SqlConnection cnn;
        private static DBHelper _Instance;
        public static DBHelper Instance
        {
            get
            {
                if (_Instance == null) _Instance = new DBHelper();
                return _Instance;
            }
            private set { }
        }
        private DBHelper()
        {
            string s = @"Data Source=.\SQLEXPRESS;Initial Catalog=Demo_PBL;Integrated Security=True";
            cnn = new SqlConnection(s);
        }
        public void ExecuteDB(string query)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public DataTable GetRecords(string query)
        {
            DataTable dt = new DataTable();
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, cnn);
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
    }
}
