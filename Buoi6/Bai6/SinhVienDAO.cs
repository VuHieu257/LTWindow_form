using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    internal class SinhVienDAO
    {
        SqlConnection conn=null;
        SqlCommand cmd=null;
        SqlDataAdapter adapter=null;
        KetNoi Kn = new KetNoi();
        public SinhVienDAO()
        {
            conn=Kn.GetConnect();
            if(conn.State==ConnectionState.Closed)
                conn.Open();
        }
        public DataTable getList(int? makhoa=null)
        {
            string sql = null;
            if(makhoa==null)
            {
                sql = "SELECT SinhVien.MaSV,SinhVien.HoTen,SinhVien.DiemTB,Khoa.TenKhoa";
                sql += " FROM SinhVien INNER JOIN Khoa ON Khoa.Makhoa=SinhVien.Makhoa";
            }else
            {
                sql = "SELECT SinhVien.MaSV,SinhVien.HoTen,SinhVien.DiemTB,Khoa.TenKhoa";
                sql += " FROM SinhVien INNER JOIN Khoa ON Khoa.Makhoa=SinhVien.Makhoa WHERE SinhVien.MaKhoa ='" + makhoa+"'";
            }
            cmd = new SqlCommand(sql,conn);
            adapter=new SqlDataAdapter(cmd);
            DataTable dt=new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public int getCount()
        {
            string sql = "SELECT COUNT(SinhVien.MaSV) FROM SinhVien INNER JOIN Khoa ON Khoa.Makhoa=SinhVien.MaKhoa";
            cmd = new SqlCommand(sql,conn);
            int count=(int)cmd.ExecuteScalar();
            return count;
        }
        public DataRow getRow(string masv)
        {
            string sql = "SELECT SinhVien.MaSV,SinhVien.HoTen,SinhVien.DiemTB,Khoa.TenKhoa";
            sql += " FROM SinhVien INNER JOIN Khoa ON Khoa.Makhoa=SinhVien.Makhoa WHERE SinhVien.MaSV ='" + masv + "'";
            cmd = new SqlCommand(sql, conn);
            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow row = dt.Rows[0];
            return row;
        }
        public void InsertSV(SinhVien sv)
        {
            string sql = "INSERT INTO SinhVien(MaSV,HoTen,Makhoa,DiemTB) VALUES(@MASV,@HOTEN,@MAKHOA,@DIEMTB)";
            cmd=new SqlCommand(sql,conn);
            cmd.Parameters.AddWithValue("@MASV", sv.MaSV);
            cmd.Parameters.AddWithValue("@HOTEN", sv.HoTen);
            cmd.Parameters.AddWithValue("@MAKHOA", sv.MaKhoa);
            cmd.Parameters.AddWithValue("@DIEMTB", sv.DiemTB);
            cmd.ExecuteNonQuery();
        }
        public void UpdateSV(SinhVien sv)
        {
            string sql = "UPDATE SinhVien SET HoTen=@HoTEN,MaKhoa=@MAKHOA,DiemTB=@DIEMTB";
            sql += "WHERE MaSV=@MASV";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MASV", sv.MaSV);
            cmd.Parameters.AddWithValue("@HOTEN", sv.HoTen);
            cmd.Parameters.AddWithValue("@MAKHOA", sv.MaKhoa);
            cmd.Parameters.AddWithValue("@DIEMTB", sv.DiemTB);
            cmd.ExecuteNonQuery();

        }
        public void DeleteSV(string masv)
        {
            string sql = "DELETE FROM SinhVien WHERE MaSV=@MASV";
            cmd = new SqlCommand(sql,conn);
            cmd.Parameters.AddWithValue("@MASV", masv);
            cmd.ExecuteNonQuery ();
        }
    }
}
