using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bai6_2;

namespace Bai6_3
{
    internal class LoaiSachDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter adapter = null;
        KetNoi Kn = new KetNoi();
        public LoaiSachDAO()
        {
            conn = Kn.GetConnect();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }
        public DataTable getList()
        {
            string sql = "SELECT * FROM LoaiSach";
            cmd = new SqlCommand(sql, conn);
            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public int getCount()
        {
            string sql = "SELECT COUNT(MaLoai) FROM LoaiSach";
            cmd = new SqlCommand(sql, conn);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        public DataRow getRow(string maloai)
        {
            string sql = "SELECT *";
            sql += " FROM LoaiSach WHERE MaLoai ='" + maloai + "'";
            cmd = new SqlCommand(sql, conn);
            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow row = dt.Rows[0];
            return row;
        }
        public void InsertSV(LoaiSach ls)
        {
            string sql = "INSERT INTO LoaiSach(MaLoai,TenLoai) VALUES(@MALOAI,@TENLOAI)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MALOAI", ls.MaLoai);
            cmd.Parameters.AddWithValue("@TENLOAI", ls.TenLoai);
            cmd.ExecuteNonQuery();
        }
        public void UpdateSV(LoaiSach lsp)
        {
            string sql = "UPDATE LoaiSach SET MaLoai=@MALOAI,TenLoai=@TENLOAI";
            sql += " WHERE MaLoai=@MALOAI";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MALOAI", lsp.MaLoai);
            cmd.Parameters.AddWithValue("@TENLOAI", lsp.TenLoai);
            cmd.ExecuteNonQuery();

        }
        public void DeleteSV(string maloai)
        {
            string sql = "DELETE FROM LoaiSach WHERE MaLoai=@MALOAI";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MALOAI", maloai);
            cmd.ExecuteNonQuery();
        }
    }
}
