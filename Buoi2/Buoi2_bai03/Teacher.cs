using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_bai03
{
    internal class Teacher : person
    {
        public string MaGv { get; set; }
        public string Khoa { get; set; }
        public string ChucVu { get; set; }
        public Teacher() { }
        public Teacher(string magv,string khoa,string chuvu,string cmnd, string hoten, string diaChi) : base(cmnd, hoten, diaChi)
        {
            MaGv = magv;
            Khoa = khoa;
            ChucVu = chuvu;
        }
        public void NhapSD()
        {
            Console.Write("Nhap ma GV:");
            MaGv = Console.ReadLine();
            Console.Write("Nhap Chuc Vu:");
            ChucVu = Console.ReadLine();
            Console.Write("Nhap Khoa:");
            Khoa = Console.ReadLine();

        }
        public void XuatSD()
        {
            Console.WriteLine("MaSV:{0}\tDiemTB:{1}\tKhoa:{2}", MaGv, ChucVu, Khoa);
        }
    }
}
