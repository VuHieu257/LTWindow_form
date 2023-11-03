using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    internal class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set;}
        public int MaKhoa {  get; set;}
        public double DiemTB {  get; set;}
        public SinhVien() { }
        public SinhVien(string masv, string hoTen, int maKhoa, double diemTB)
        {
            MaSV = masv;
            HoTen = hoTen;
            MaKhoa = maKhoa;
            DiemTB = diemTB;
        }
    }
}
