using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_2
{
    internal class DonHangDAO
    {

        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter adapter = null;
        KetNoi Kn = new KetNoi();
        public DonHangDAO()
        {
            conn = Kn.GetConnect();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }
        public DataTable getList(int? makhoa = null)
        {
            string sql = "SELECT * FROM DonHang";
            cmd = new SqlCommand(sql, conn);
            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public int getCount()
        {
            string sql = "SELECT COUNT(DonHang.MaDH) FROM DonHang INNER JOIN DonHangChiTiet ON DonHang.MaDH=DonHangChiTiet.MaDH";
            cmd = new SqlCommand(sql, conn);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        public DataRow getRow(string madh)
        {
            string sql = "SELECT *";
            sql += " FROM DonHang WHERE MaDH ='" + madh + "'";
            cmd = new SqlCommand(sql, conn);
            adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow row = dt.Rows[0];
            return row;
        }
        public void InsertSV(DonHang dh)
        {
            string sql = "INSERT INTO DonHang(MaDH,NgayGH,NgayDH,KieuDH,GhiCHu) VALUES(@MADH,@NGAYGH,@NGAYDH,@KIEMDH,@GHICHU)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MADH", dh.MaDH);
            cmd.Parameters.AddWithValue("@NGAYGH",dh.NgayGH);
            cmd.Parameters.AddWithValue("@NGAYDH",dh.NgayDH);
            cmd.Parameters.AddWithValue("@KIEMDH",dh.KieuDH);
            cmd.Parameters.AddWithValue("@GHICHU",dh.GhiCHu);
            cmd.ExecuteNonQuery();
        }
        public void UpdateSV(DonHang dh)
        {
            string sql = "UPDATE DonHang SET NgayGH=@NGAYGH,NgayDH=@NGAYDH,KieuDH=@KIEMDH,GhiCHu=@GHICHU";
            sql += " WHERE MaDH=@MADH";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MADH", dh.MaDH);
            cmd.Parameters.AddWithValue("@NGAYGH", dh.NgayGH);
            cmd.Parameters.AddWithValue("@NGAYDH", dh.NgayDH);
            cmd.Parameters.AddWithValue("@KIEMDH", dh.KieuDH);
            cmd.Parameters.AddWithValue("@GHICHU", dh.GhiCHu);
            cmd.ExecuteNonQuery();

        }
        public void DeleteSV(string madh)
        {
            string sql = "DELETE FROM DonHang WHERE MaDH=@MADH";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MADH", madh);
            cmd.ExecuteNonQuery();
        }
    }
}
