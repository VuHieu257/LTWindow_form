using Bai6_2;
using System.Data.SqlClient;
using System.Data;

namespace Bai6_3
{
    internal class NhaXuatBanDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter adapter = null;
        KetNoi Kn = new KetNoi();
        public NhaXuatBanDAO()
        {
            conn = Kn.GetConnect();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }
        public DataTable getList()
        {
            string sql = "SELECT * FROM NhaXuatBan";
            cmd = new SqlCommand(sql, conn);
            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public int getCount()
        {
            string sql = "SELECT COUNT(MaNXB) FROM NhaXuatBan";
            cmd = new SqlCommand(sql, conn);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        public DataRow getRow(string manxb)
        {
            string sql = "SELECT *";
            sql += " FROM NhaXuatBan WHERE MaBXB ='" + manxb + "'";
            cmd = new SqlCommand(sql, conn);
            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow row = dt.Rows[0];
            return row;
        }
        public void InsertSV(NhaXuatBan nxb)
        {
            string sql = "INSERT INTO NhaXuatBan(MaNXB,TenNXB,DiaChi,SDT,Email) VALUES(@MANXB,@TENNXB,@DIACHI,@DT,@EMAIL)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MANXB", nxb.MaNXB);
            cmd.Parameters.AddWithValue("@TENNXB", nxb.TenNXB);
            cmd.Parameters.AddWithValue("@DIACHI", nxb.DiaChi);
            cmd.Parameters.AddWithValue("@DT", nxb.SDT);
            cmd.Parameters.AddWithValue("@EMAIL", nxb.Email);
            cmd.ExecuteNonQuery();
        }
        public void UpdateSV(NhaXuatBan nxb)
        {
            string sql = "UPDATE NhaXuatBan SET MaNXB=@MANXB,TenNXB=@TENNXB,DiaChi=@DIACHI,SDT=@DT,Email=@EMAIL";
            sql += " WHERE MaNXB=@MANXB";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MANXB", nxb.MaNXB);
            cmd.Parameters.AddWithValue("@TENNXB", nxb.TenNXB);
            cmd.Parameters.AddWithValue("@DIACHI", nxb.DiaChi);
            cmd.Parameters.AddWithValue("@DT", nxb.SDT);
            cmd.Parameters.AddWithValue("@EMAIL", nxb.Email);
            cmd.ExecuteNonQuery();

        }
        public void DeleteSV(string manxb)
        {
            string sql = "DELETE FROM NhaXuatBan WHERE MaNXB=@MANXB";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MANXB", manxb);
            cmd.ExecuteNonQuery();
        }
    }
}