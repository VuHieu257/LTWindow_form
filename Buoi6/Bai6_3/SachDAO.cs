using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_3
{
    internal class SachDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter adapter = null;
        KetNoi Kn = new KetNoi();
        public SachDAO()
        {
            conn = Kn.GetConnect();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }
        public DataTable getList(int? manv = null)
        {
            string sql = null;
            if (manv == null)
            {
                sql = "SELECT Sach.MaSach,Sach.TenSach,Sach.TacGia,Sach.Gia,LoaiSach.TenLoai,NhaXuatBan.TenNXB,Sach.NamXB,NhanVien.TenNV \r\n";
                sql += " FROM Sach INNER JOIN NhanVien ON NhanVien.MaNV=Sach.MaNV INNER JOIN NhaXuatBan ON NhaXuatBan.MaNXB=Sach.MaNXB INNER JOIN LoaiSach ON LoaiSach.MaLoai=Sach.MaLoai";
            }
            else
            {
                sql = "SELECT Sach.MaSach,Sach.TenSach,Sach.TacGia,Sach.Gia,LoaiSach.TenLoai,NhaXuatBan.TenNXB,Sach.NamXB,NhanVien.TenNV \r\n";
                sql += " FROM Sach INNER JOIN NhanVien ON NhanVien.MaNV=Sach.MaNV INNER JOIN NhaXuatBan ON NhaXuatBan.MaNXB=Sach.MaNXB INNER JOIN LoaiSach ON LoaiSach.MaLoai=Sach.MaLoai WHERE Sach.MaSach='" + manv + "'";

            }
            cmd = new SqlCommand(sql, conn);
            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public int getCount()
        {
            string sql = "SELECT COUNT(MaSach) FROM Sach ";
            cmd = new SqlCommand(sql, conn);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        public DataRow getRow(string masach)
        {

            string sql = "SELECT Sach.MaSach,Sach.TenSach,Sach.TacGia,Sach.Gia,LoaiSach.TenLoai,NhaXuatBan.TenNXB,Sach.NamXB,NhanVien.TenNV ";

            sql += " FROM Sach INNER JOIN NhanVien ON NhanVien.MaNV=Sach.MaNV INNER JOIN NhaXuatBan ON NhaXuatBan.MaNXB=Sach.MaNXB INNER JOIN LoaiSach ON LoaiSach.MaLoai=Sach.MaLoai WHERE Sach.MaSach ='" + masach + "'";
            cmd = new SqlCommand(sql, conn);
            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow row = dt.Rows[0];
            return row;
        }
        public void InsertSV(Sach s)
        {
            string sql = "INSERT INTO Sach(MaSach,TenSach,TacGia,GiaSach,MaLoai,MaNXB,NamXB,MaNV) VALUES(@MASACH,@TENSACH,@TACGIA,@GIASACH,@MALOAI,@MANXB,@NAXB,@MANV)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MASACH", s.MaSach);
            cmd.Parameters.AddWithValue("@TENSACH", s.TenSach);
            cmd.Parameters.AddWithValue("@TACGIA", s.TacGia);
            cmd.Parameters.AddWithValue("@GIASACH", s.GiaSach);
            cmd.Parameters.AddWithValue("@MALOAI", s.MaLoai);
            cmd.Parameters.AddWithValue("@MANXB", s.MaNXB);
            cmd.Parameters.AddWithValue("@NAXB", s.NamXB);
            cmd.Parameters.AddWithValue("@MANV", s.MaNV);
            cmd.ExecuteNonQuery();
        }
        public void UpdateSV(Sach s)
        {
            string sql = "UPDATE Sach SET MaSach=@MASACH,TenSach=@TENSACH,TacGia=@TACGIA,GiaSach=@GIASACH,MaLoai=@MALOAI,MaNXB=@MANXB,NamXB=@NAXB,MaNV=@MANV";
            sql += " WHERE MaSach=@MASACH";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MASACH", s.MaSach);
            cmd.Parameters.AddWithValue("@TENSACH", s.TenSach);
            cmd.Parameters.AddWithValue("@TACGIA", s.TacGia);
            cmd.Parameters.AddWithValue("@GIASACH", s.GiaSach);
            cmd.Parameters.AddWithValue("@MALOAI", s.MaLoai);
            cmd.Parameters.AddWithValue("@MANXB", s.MaNXB);
            cmd.Parameters.AddWithValue("@NAXB", s.NamXB);
            cmd.Parameters.AddWithValue("@MANV", s.MaNV);
            cmd.ExecuteNonQuery();

        }
        public void DeleteSV(string masach)
        {
            string sql = "DELETE FROM Sach WHERE MaSach=@MASACH";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MASACH", masach);
            cmd.ExecuteNonQuery();
        }
    }
}
