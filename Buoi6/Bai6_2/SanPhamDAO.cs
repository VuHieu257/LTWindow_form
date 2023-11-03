using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_2
{
    internal class SanPhamDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter adapter = null;
        KetNoi Kn = new KetNoi();
        public SanPhamDAO()
        {
            conn = Kn.GetConnect();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }
        public DataTable getList()
        {
            string sql = "SELECT * FROM SanPham";
            cmd = new SqlCommand(sql, conn);
            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public int getCount()
        {
            string sql = "SELECT COUNT(MaSP) FROM SanPham";
            cmd = new SqlCommand(sql, conn);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        public DataRow getRow(string maloai)
        {
            string sql = "SELECT SanPham.MaSP, SanPham.MaLoai, SanPham.TenSP,SanPham.DVTinh,SanPham.GiaMua,SanPham.GiaBan";
            sql += "FROM SanPham INNER JOIN LoaiSP ON LoaiSP.TenLoai=SanPham.TenLoai WHERE SanPham.MaLoai='" + maloai + "'";
            cmd = new SqlCommand(sql, conn);
            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow row = dt.Rows[0];
            return row;
        }
        public void InsertSV(SanPham sp)
        {
            string sql = "INSERT INTO SanPham(MaSP,MaLoai,TenSP,DVTinh,GiaMua,GiaBan) VALUES(@MASP,@MALOAI,@TENSP,@DVTINH,@GIAMUA,@GIABAN)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MASP", sp.MaSP);
            cmd.Parameters.AddWithValue("@MALOAI", sp.MaLoai);
            cmd.Parameters.AddWithValue("@TENSP", sp.TenSP);
            cmd.Parameters.AddWithValue("@DVTINH", sp.DVTinh);
            cmd.Parameters.AddWithValue("@GIAMUA", sp.GiaMua);
            cmd.Parameters.AddWithValue("@GIABAN", sp.GiaBan);
            cmd.ExecuteNonQuery();
        }
        public void UpdateSV(SanPham sp)
        {
            string sql = "UPDATE SanPham SET MaSP=@MASP,MaLoai=@MALOAI,TenSP=@TENSP,DVTinh=@DVTINH,GiaMua=@GIAMUA,GiaBan=@GIABAN";
            sql += " WHERE MaSP=@MASP";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MASP", sp.MaSP);
            cmd.Parameters.AddWithValue("@MALOAI", sp.MaLoai);
            cmd.Parameters.AddWithValue("@TENSP", sp.TenSP);
            cmd.Parameters.AddWithValue("@DVTINH", sp.DVTinh);
            cmd.Parameters.AddWithValue("@GIAMUA", sp.GiaMua);
            cmd.Parameters.AddWithValue("@GIABAN", sp.GiaBan);
            cmd.ExecuteNonQuery();

        }
        public void DeleteSV(string masp)
        {
            string sql = "DELETE FROM SanPham WHERE MaSP=@MASP";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MASP", masp);
            cmd.ExecuteNonQuery();
        }
    }
}
