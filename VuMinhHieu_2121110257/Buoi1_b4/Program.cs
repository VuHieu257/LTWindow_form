using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_b4
{
    internal class Program
    {
        public static bool CheckHinhTG(int a,int b,int c)
        {
            if(a+b>c && b+c>a && a+c>b) {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            int a,b,c;
            Console.Write("Nhap canh a:");
            a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap canh b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap canh c:");
            c = Convert.ToInt32(Console.ReadLine());
            if (CheckHinhTG(a, b, c) == true)
            {
                int p = a + b + c;
                int s = (int)(double)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("Chu vi tam giac:{0}\nDien tich tam giac:{1}", p, s);
            }else { Console.WriteLine("Nay khong phai tam giac"); }
            Console.ReadKey();
        }
    }
}

