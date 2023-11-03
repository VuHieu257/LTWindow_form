using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_2
{
    internal class DonHangCTDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter adapter = null;
        KetNoi Kn = new KetNoi();
        public DonHangCTDAO()
        {
            conn = Kn.GetConnect();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }
        public DataTable getList(int? makhoa = null)
        {
            string sql = "SELECT * FROM DonHangChiTiet";
            cmd = new SqlCommand(sql, conn);
            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public int getCount()
        {
            string sql = "SELECT COUNT(MaCTDH) FROM DonHangChiTiet";
            cmd = new SqlCommand(sql, conn);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        public DataRow getRow(string madhct)
        {
            string sql = "SELECT *";
            sql += " FROM DonHangChiTiet WHERE MaCTDH ='" + madhct + "'";
            cmd = new SqlCommand(sql, conn);
            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow row = dt.Rows[0];
            return row;
        }
        public void InsertSV(DonHangCT dhct)
        {
            string sql = "INSERT INTO DonHangChiTiet(MaDH,MaCTDH,MaSP,TenSp,DVTinh,DonGia,GhiChu) VALUES(@MaDH,@MACTDH,@MASP,@TENSP,@DVTINH,@DONGIA,@GHICHU)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaDH", dhct.MaDH);
            cmd.Parameters.AddWithValue("@MACTDH", dhct.MaCTDH);
            cmd.Parameters.AddWithValue("@MASP", dhct.MaSP);
            cmd.Parameters.AddWithValue("@TENSP", dhct.TenSp);
            cmd.Parameters.AddWithValue("@DVTINH", dhct.DVTinh);
            cmd.Parameters.AddWithValue("@DONGIA", dhct.DonGia);
            cmd.ExecuteNonQuery();
        }
        public void UpdateSV(DonHangCT dhct)
        {
            string sql = "UPDATE DonHangChiTiet SET MaDH=@MADH,MaCTDH=@MACTDH,MaSP=@MASP,TenSp=@TENSP,DVTinh=@DVTINH,DonGia=@DONGIA,GhiChu=@GHICHU";
            sql += " WHERE MaCTDH=@MACTDH";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MADH", dhct.MaDH);
            cmd.Parameters.AddWithValue("@MACTDH", dhct.MaCTDH);
            cmd.Parameters.AddWithValue("@MASP", dhct.MaSP);
            cmd.Parameters.AddWithValue("@TENSP", dhct.TenSp);
            cmd.Parameters.AddWithValue("@DVTINH", dhct.DVTinh);
            cmd.Parameters.AddWithValue("@DONGIA", dhct.DonGia);
            cmd.ExecuteNonQuery();

        }
        public void DeleteSV(string madhct)
        {
            string sql = "DELETE FROM DonHangChiTiet WHERE MaCTDH=@MACTDH";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MACTDH", madhct);
            cmd.ExecuteNonQuery();
        }
    }
}
