using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_3
{
    internal class NhaXuatBan
    {
        public string MaNXB {  get; set; }
        public string TenNXB { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public NhaXuatBan() { }
        public NhaXuatBan(string maNXB, string tenNXB, string diaChi, string sDT, string email)
        {
            MaNXB = maNXB;
            TenNXB = tenNXB;
            DiaChi = diaChi;
            SDT = sDT;
            Email = email;
        }
    }
}
