using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_2
{
    internal class KetNoi
    {
        String sqlConnect;
        public KetNoi()
        {
            sqlConnect = ConfigurationManager.ConnectionStrings["ChuoiKN"].ToString();
        }
        public SqlConnection GetConnect()
        {
            SqlConnection conn = new SqlConnection(sqlConnect);
            return conn;
        }
    }
}
