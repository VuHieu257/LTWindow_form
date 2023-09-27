using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_bai03
{
    internal class student : person
    {

        public string MaSV { get; set; }
        public double DiemTB { get; set; }
        public string Khoa { get; set; }
        public student()
        {
        }

        public student(string masv, double diemtb,string khoa,string cmnd, string hoten, string diaChi) : base(cmnd, hoten, diaChi)
        {
            this.MaSV = masv;
            this.DiemTB = diemtb;
            this.Khoa = khoa;
        }


        public void NhapSD()
        {
            Console.Write("Nhap ma SV:");
            MaSV= Console.ReadLine();
            Console.Write("Nhap diem TB:");
            DiemTB =Convert.ToDouble( Console.ReadLine());
            Console.Write("Nhap Khoa:");
            Khoa = Console.ReadLine();

        }
        public void XuatSD()
        {
            Console.WriteLine("MaSV:{0}\tDiemTB:{1}\tKhoa:{2}", MaSV, DiemTB, Khoa);
        }
    }
}
