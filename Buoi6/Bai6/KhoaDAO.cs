using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    internal class KhoaDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        KetNoi kn = new KetNoi();
        public KhoaDAO()
        {
            conn = kn.GetConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public DataTable getList()
        {
            string sql = "SELECT * FROM Khoa";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            return dt;
        }

        public int getCount()
        {
            string sql = "SELECT COUNT(Khoa.MaKhoa) FROM Khoa INNER JOIN SinhVien ON Khoa.MaKhoa=SinhVien.MaKhoa";
            cmd = new SqlCommand(sql, conn);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        public DataRow getRow(string makhoa)
        {
            string sql = "SELECT Khoa.MaKhoa, Khoa.TenKhoa, Khoa.GhiChu";
            sql += "FROM Khoa INNER JOIN SinhVien ON SinhVien.TenKhoa=Khoa.TenKhoa WHERE SinhVien.MaKhoa='" + makhoa + "'";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            DataRow row = dt.Rows[0];
            return row;
        }
        public void InsertTwo(Khoa kh)
        {
            string sql = "INSERT INTO Khoa(MaKhoa,TenKhoa,GhiChu) VALUES(@MAKHOA,@TENKHOA,@GHICHU)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MAKHOA", kh.MaKhoa);
            cmd.Parameters.AddWithValue("@TENKHOA", kh.TenKhoa);
            cmd.Parameters.AddWithValue("@GHICHU", kh.GhiChu);
            cmd.ExecuteNonQuery();
        }
        public void UpdateTwo(Khoa kh)
        {
            string sql = "UPDATE Khoa SET TenKhoa=@TENKHOA, GhiChu=@GHICHU WHERE MaKhoa=@MAKHOA";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MAKHOA", kh.MaKhoa);
            cmd.Parameters.AddWithValue("@TENKHOA", kh.TenKhoa);
            cmd.Parameters.AddWithValue("@GHICHU", kh.GhiChu);
            cmd.ExecuteNonQuery();
        }
        public void DeleteTwo(string makhoa)
        {
            string sql = "DELETE FROM Khoa WHERE MaKhoa=@MAKHOA";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MAKHOA", makhoa);
            cmd.ExecuteNonQuery();
        }
    }
    //internal class KhoaDAO
    //{
    //    SqlConnection conn = null;
    //    SqlCommand cmd = null;
    //    SqlDataAdapter adapter = null;
    //    KetNoi Kn = new KetNoi();
    //    public DataTable getList()
    //    {
    //        conn=Kn.GetConnect();
    //        string sql = "SELECT*FROM Khoa" ;
    //        cmd = new SqlCommand(sql, conn);
    //        adapter = new SqlDataAdapter(cmd);
    //        DataTable dt = new DataTable();
    //        adapter.Fill(dt);
    //        return dt;
    //    }
    //    public void InsertKhoa(Khoa kh)
    //    {

    //        string sql = "INSERT INTO Khoa(MaKhoa,TenKhoa,GhiChu) VALUES(@MAKHOA,@TENKHOA,@GHICHU)";
    //        cmd = new SqlCommand(sql, conn);
    //        cmd.Parameters.AddWithValue("@MAKHOA", kh.MaKhoa);
    //        cmd.Parameters.AddWithValue("@TENKHOA", kh.TenKhoa);
    //        cmd.Parameters.AddWithValue("@GHICHU", kh.GhiChu);
    //        cmd.ExecuteNonQuery();

    //    }
    //    public void UpdateKhoa(Khoa k)
    //    {
    //        string sql = "UPDATE Khoa SET MaKhoa=@MAKHOA,TenKhoa=@TENKHOA,GhiChu=@GHICHU";
    //        sql += "WHERE MaKhoa=@MAKHOA";
    //        cmd = new SqlCommand(sql, conn);
    //        cmd.Parameters.AddWithValue("@MAKHOA", k.MaKhoa);
    //        cmd.Parameters.AddWithValue("@TENKHOA", k.TenKhoa);
    //        cmd.Parameters.AddWithValue("@GHICHU", k.GhiChu);
    //        cmd.ExecuteNonQuery();
    //    }
    //    public void DeleteKhoa(string makhoa)
    //    {
    //        string sql = "DELETE FROM Khoa WHERE MaKhoa=@MAKHOA";
    //        cmd = new SqlCommand(sql, conn);
    //        cmd.Parameters.AddWithValue("@MAKHOA", makhoa);
    //        cmd.ExecuteNonQuery();
    //    }
    //    //public int getCount()
    //    //{
    //    //    string sql = "SELECT COUNT(SinhVien.MaSV) FROM SinhVien INNER JOIH Khoa ON Khoa.Makhoa=SinhVien.MaKhoa";
    //    //    cmd = new SqlCommand(sql, conn);
    //    //    int count = (int)cmd.ExecuteScalar();
    //    //    return count;
    //    //}
    //    //public void InsertSV(SinhVien sv)
    //    //{
    //    //    string sql = "INSER INTO SinhVien(MaSV,HoTen,Makhoa,DiemTB) VALUES(@MASV,@HOTEN,@MAKHOA,@DIEMTB)";
    //    //    cmd = new SqlCommand(sql, conn);
    //    //    cmd.Parameters.AddWithValue("@MASV", sv.MaSV);
    //    //    cmd.Parameters.AddWithValue("@HOTEN", sv.HoTen);
    //    //    cmd.Parameters.AddWithValue("@MAKHOA", sv.MaKhoa);
    //    //    cmd.Parameters.AddWithValue("@DIEMTB", sv.DiemTB);
    //    //    cmd.ExecuteNonQuery();
    //    //}
    //    //public void UpdateSV(SinhVien sv)
    //    //{
    //    //    string sql = "UPDATE SinhVien SET HoTen=@HoTEN,MaKhoa=@MAKHOA,DiemTB=@DIEMTB";
    //    //    sql += "WHERE MaSV=@MASV";
    //    //    cmd = new SqlCommand(sql, conn);
    //    //    cmd.Parameters.AddWithValue("@MASV", sv.MaSV);
    //    //    cmd.Parameters.AddWithValue("@HOTEN", sv.HoTen);
    //    //    cmd.Parameters.AddWithValue("@MAKHOA", sv.MaKhoa);
    //    //    cmd.Parameters.AddWithValue("@DIEMTB", sv.DiemTB);
    //    //    cmd.ExecuteNonQuery();

    //    //}
    //    //public void DeleteSV(string masv)
    //    //{
    //    //    string sql = "DELET FROM SinhVien WHERE MaSV=@MASV";
    //    //    cmd = new SqlCommand(sql, conn);
    //    //    cmd.Parameters.AddWithValue("@MASV", masv);
    //    //    cmd.ExecuteNonQuery();
    //    //}

    //}
}
