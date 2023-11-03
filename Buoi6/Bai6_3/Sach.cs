using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_3
{
    internal class Sach
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string TacGia { get; set; }
        public double GiaSach { get; set; }
        public string MaLoai { get; set; }
        public string MaNXB { get; set; }
        public string NamXB { get; set; }
        public string MaNV { get; set; }
        public Sach() { }
        public Sach(string maSach, string tenSach, string tacGia, double giaSach, string maloai, string maNXB, string namXB, string maNV)
        {
            MaSach = maSach;
            TenSach = tenSach;
            TacGia = tacGia;
            GiaSach = giaSach;
            MaLoai = maloai;
            MaNXB = maNXB;
            NamXB = namXB;
            MaNV = maNV;
        }
    }
}
