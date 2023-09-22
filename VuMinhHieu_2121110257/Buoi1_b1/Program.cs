using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_b1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.Write("Nhap so a:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap so b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tong hai so a và b là:" + (a + b));
            Console.WriteLine("Hieu hai so a và b là:" + (a - b));
            Console.WriteLine("Tich hai so a và b là:" + (a * b));
            if (b != 0)
            {
                Console.WriteLine("Thuong hai so a và b là:" + (a / b));
            }
            else { Console.WriteLine("So b phai lon hon 0"); }
            Console.ReadKey();
        }
    }
}
