using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong sinh vien:");
            int n=Convert.ToInt32(Console.ReadLine());
            SinhVien[] arr=new SinhVien[n];
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Nhap Sinh Vien thu {0}:",i+1);
                arr[i] = new SinhVien();
                arr[i].NhapSV();
                Console.WriteLine("###################");
            }
            foreach(SinhVien sv in arr) {
                sv.XuatSV();
                Console.WriteLine("###################");
            }
            Console.ReadKey();
        }
    }
}
