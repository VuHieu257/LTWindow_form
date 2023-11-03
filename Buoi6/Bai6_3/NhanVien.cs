using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_3
{
    internal class NhanVien
    {
        public string MaNV {  get; set; }
        public string TenNV {  get; set; }
        public string GioiTinh {  get; set; }
        public string SDT {  get; set; }
        public string Email {  get; set; }

        public NhanVien() { }
        public NhanVien(string maNV, string tenNV, string gioiTinh, string sDT, string email)
        {
            MaNV = maNV;
            TenNV = tenNV;
            GioiTinh = gioiTinh;
            SDT = sDT;
            Email = email;
        }
    }
}
