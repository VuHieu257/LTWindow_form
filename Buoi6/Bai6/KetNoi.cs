using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Bai6
{
    internal class KetNoi
    {
        String sqlConnect;
        public KetNoi() {
            sqlConnect = ConfigurationManager.ConnectionStrings["ChuoiKN"].ToString();
        }
        public SqlConnection GetConnect()
        {
            SqlConnection conn = new SqlConnection(sqlConnect);
            return conn;
        }
    }
}
