using System.Data.SqlClient;
using System.Data;

namespace Bai6_3
{
    internal class NhanVienDAO
    {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataAdapter adapter = null;
            KetNoi Kn = new KetNoi();
            public NhanVienDAO()
            {
                conn = Kn.GetConnect();
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
            }
            public DataTable getList()
            {
                string sql = "SELECT * FROM NhanVien";
                cmd = new SqlCommand(sql, conn);
                adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            public int getCount()
            {
                string sql = "SELECT COUNT(MaNV) FROM NhanVien";
                cmd = new SqlCommand(sql, conn);
                int count = (int)cmd.ExecuteScalar();
                return count;
            }
            public DataRow getRow(string manv)
            {
                string sql = "SELECT *";
                sql += " FROM NhanVien WHERE MaBXB ='" + manv + "'";
                cmd = new SqlCommand(sql, conn);
                adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                DataRow row = dt.Rows[0];
                return row;
            }
            public void InsertSV(NhanVien nv)
            {
                string sql = "INSERT INTO NhanVien(MaNV,TenNV,GioiTinh,SDT,Email) VALUES(@MANV,@TENNV,@GIOITINH,@DT,@EMAIL)";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MANV", nv.MaNV);
                cmd.Parameters.AddWithValue("@TENNV", nv.TenNV);
                cmd.Parameters.AddWithValue("@GIOITINH", nv.GioiTinh);
                cmd.Parameters.AddWithValue("@DT", nv.SDT);
                cmd.Parameters.AddWithValue("@EMAIL", nv.Email);
                cmd.ExecuteNonQuery();
            }
            public void UpdateSV(NhanVien nv)
            {
                string sql = "UPDATE NhanVien SET MaNV=@MANV,TenNV=@TENNV,GioiTinh=@GIOITINH,SDT=@DT,Email=@EMAIL";
                sql += "WHERE MaNV=@MANV";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MANV", nv.MaNV);
                cmd.Parameters.AddWithValue("@TENNV", nv.TenNV);
                cmd.Parameters.AddWithValue("@GIOITINH", nv.GioiTinh);
                cmd.Parameters.AddWithValue("@DT", nv.SDT);
                cmd.Parameters.AddWithValue("@EMAIL", nv.Email);
            cmd.ExecuteNonQuery();

            }
            public void DeleteSV(string manv)
            {
                string sql = "DELETE FROM NhanVien WHERE MaNV=@MANV";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MANV", manv);
                cmd.ExecuteNonQuery();
            }
        }
 }
