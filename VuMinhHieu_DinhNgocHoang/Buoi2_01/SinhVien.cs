using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_01
{
    internal class SinhVien
    {
        public string MaSV {  get; set; }
        public string HoTen { get; set; }
        public double DiemTB { get; set; }
        public string Khoa { get; set; }

        public SinhVien() { }

        public SinhVien(string maSV, string hoTen, double diemTB, string khoa)
        {
            MaSV = maSV;
            HoTen = hoTen;
            DiemTB = diemTB;
            Khoa = khoa;
        }
        public void NhapSV()
        {
            Console.Write("nhap Ma sinh vien: ");
            MaSV = Console.ReadLine();
            Console.Write("nhap Ho Ten: ");
            HoTen = Console.ReadLine();
            Console.Write("nhap Diem TB: ");
            DiemTB=Convert.ToDouble(Console.ReadLine());
            Console.Write("nhap Khoa: ");
            Khoa=Console.ReadLine();
        }
        public void XuatSV()
        {
            Console.WriteLine("MaSV:{0},HoTen:{1},DiemTB:{2},Khoa:{3}", MaSV, HoTen, DiemTB, Khoa);
        }
    }
}
