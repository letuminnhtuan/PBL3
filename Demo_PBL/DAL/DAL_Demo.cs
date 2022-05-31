using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Demo_PBL.DAL
{
    class DAL_Demo
    {
        public string Connection_String = @"Data Source=.\SQLEXPRESS;Initial Catalog=Demo_PBL;Integrated Security=True";
        private static DAL_Demo _Instance;
        public static DAL_Demo Instance
        {
            get
            {
                if (_Instance == null) _Instance = new DAL_Demo();
                return _Instance;
            }
            private set { }
        }
        public SqlConnection cnn;
        private DAL_Demo()
        {
            cnn = new SqlConnection(Connection_String);
        }
    }
}
