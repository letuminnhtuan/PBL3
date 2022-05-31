using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Demo_PBL.DAL
{
    class DBHelper
    {
        private SqlConnection cnn;
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
            cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Demo_PBL;Integrated Security=True");
        }
        // Get Records
        public DataTable GetRecords(string query)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(query, cnn);
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        // Add_Update_Delete
        public void ExecuteDB(string query)
        {
            SqlCommand cmd = new SqlCommand(query, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
