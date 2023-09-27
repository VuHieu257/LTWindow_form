using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_bai03
{
    internal class Program
    {
        private static List<student> NhapDSSD()
        {
            System.Console.WriteLine("Nhap so sinh vien:");
            int n=Convert.ToInt32(Console.ReadLine());
            List<student> listSD = new List<student>();
            Console.WriteLine("---Nhap danh sach sinh vien----");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap sinh vien thu {0}:", i + 1);
                student sd = new student();
                sd.NhapSD();
                listSD.Add(sd);
            }
            return listSD;
        }
        private static void XuatDSSD(List<student> listSD)
        {
            foreach(student sv in listSD)
            {
                sv.XuatSD();
            }
        }
        private static List<Teacher> NhapDSTC()
        {
            System.Console.WriteLine("Nhap so Giao Vien:");
            int n = Convert.ToInt32(Console.ReadLine());
            List<Teacher> listSD = new List<Teacher>();
            Console.WriteLine("---Nhap danh sach Teacher----");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap sinh vien thu {0}:", i + 1);
                Teacher sd = new Teacher();
                sd.NhapSD();
                listSD.Add(sd);
            }
            return listSD;
        }
        private static void XuatDSTC(List<Teacher> listTC)
        {
            foreach (Teacher gv in listTC)
            {
                gv.XuatSD();
            }
        }
        private static  void TimKiemSV(List<student> listSD)
        {
            List<student> students=listSD.Where(p=>p.Khoa=="CNTT").ToList();
            if(students.Count==0) {
                Console.WriteLine("Khong co sinh vien khoa CNTT");

            }
            else
            {
                XuatDSSD(students);
            }
        }
        private static void TimKiemSV_DTB(List<student> listSD)
        {
            List<student> students = listSD.Where(p => p.Khoa == "CNTT").ToList();
            var s= students.Where(p => p.DiemTB < 5).ToList();
            if (s.Count == 0)
            {
                Console.WriteLine("Khong co sinh vien khoa CNTT");

            }
            else
            {
                XuatDSSD(s);
            }
        }
        private static void TimKiemGV(List<Teacher> listTC)
        {
            List<Teacher> T = listTC.Where(p => p.DiaChi == "Quan 9").ToList();
           
            if (T.Count == 0)
            {
                Console.WriteLine("Khong co giao vien o quan 9");

            }
            else
            {
                XuatDSTC(T);
            }
        }
        private static void TimKiemGV_12(List<Teacher> listTC)
        {
            List<Teacher> T = listTC.Where(p => p.MaGv == "CHN060286").ToList();

            if (T.Count == 0)
            {
                Console.WriteLine("Khong co giao vien co magv CHN060286");

            }
            else
            {
                XuatDSTC(T);
            }
        }
        private static void DSSVD3_6(List<student> listSinhVien)
        {
            List<student> listCNTT = listSinhVien.Where(p => p.Khoa == "CNTT").ToList();
            var oldest = listCNTT.Max(s => s.DiemTB);

            List<student> ljt = listCNTT.Where(p => p.DiemTB == oldest).ToList();
            if (listCNTT.Count() == 0)
            {
                Console.WriteLine("Khong co sinh vien nao nho hon 5");
            }
            else
            {
                Console.WriteLine("Danh sach SV co diem lon nhat va thuoc khoa CNTT");
                XuatDSSD(ljt);

            }
        }
        static void Main(string[] args)
        {
            List<student> st = NhapDSSD();
            List<Teacher> tc = NhapDSTC();
            XuatDSSD(st);
            XuatDSTC(tc);
            TimKiemSV(st);
            TimKiemGV(tc);
            TimKiemSV_DTB(st);
            TimKiemGV_12(tc);
            DSSVD3_6(st);
            Console.ReadKey();

        }
    }
}
