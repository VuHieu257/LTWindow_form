using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_2
{
    internal class LoaiSPDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter adapter = null;
        KetNoi Kn = new KetNoi();
        public LoaiSPDAO()
        {
            conn = Kn.GetConnect();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }
        public DataTable getList(int? makhoa = null)
        {
            string sql = "SELECT * FROM LoaiSP";
            cmd = new SqlCommand(sql, conn);
            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public int getCount()
        {
            string sql = "SELECT COUNT(MaLoai) FROM LoaiSP";
            cmd = new SqlCommand(sql, conn);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        public DataRow getRow(string maloai)
        {
            string sql = "SELECT *";
            sql += " FROM LoaiSP WHERE MaCTDH ='" + maloai + "'";
            cmd = new SqlCommand(sql, conn);
            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow row = dt.Rows[0];
            return row;
        }
        public void InsertSV(LoaiSP lsp)
        {
            string sql = "INSERT INTO LoaiSP(MaLoai,TenLoai,ChiTiet) VALUES(@MALOAI,@TENLOAI,@CHITIET)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MALOAI", lsp.MaLoai);
            cmd.Parameters.AddWithValue("@TENLOAI", lsp.TenLoai);
            cmd.Parameters.AddWithValue("@CHITIET", lsp.ChiTiet);
            cmd.ExecuteNonQuery();
        }
        public void UpdateSV(LoaiSP lsp)
        {
            string sql = "UPDATE LoaiSP SET MaLoai=@MALOAI,TenLoai=@TENLOAI,ChiTiet=@CHITIET";
            sql += " WHERE MaLoai=@MALOAI";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MALOAI", lsp.MaLoai);
            cmd.Parameters.AddWithValue("@TENLOAI", lsp.TenLoai);
            cmd.Parameters.AddWithValue("@CHITIET", lsp.ChiTiet);
            cmd.ExecuteNonQuery();

        }
        public void DeleteSV(string madhct)
        {
            string sql = "DELETE FROM LoaiSP WHERE MaLoai=@MALOAI";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MALOAI", madhct);
            cmd.ExecuteNonQuery();
        }
    }
}
