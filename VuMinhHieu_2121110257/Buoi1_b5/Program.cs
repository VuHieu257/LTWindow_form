using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_b5
{
    internal class Program
    {
        //public static void NhapSV(String[] listSV,int n)
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        String sv;
        //        Console.Write("Nhap sinh vien {0} la:", i + 1);
        //        sv = Console.ReadLine();
        //        listSV[i] = sv;
        //    }
        //}
        public static String[] NhapSV(int n)
        {
            String[] SV = new String[n];
            for (int i = 0; i < n; i++)
            {
                String sv;
                Console.Write("Nhap sinh vien {0} la:", i + 1);
                sv = Console.ReadLine();
                SV[i] = sv;
            }
            return SV;
        }
        public static void XuatSV(String[] listSV,int n)
        {
            Console.WriteLine("Danh sach sv: ");
            foreach (string i in listSV)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            int n;
            Console.Write("nhap so luong sinh vien:");
            n=Convert.ToInt32(Console.ReadLine());

            String[] listSV = NhapSV(n);
                        
            XuatSV(listSV, n);
            Console.ReadKey(); 
        }
    }
}
