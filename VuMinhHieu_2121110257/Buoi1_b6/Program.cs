using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_b6
{
    internal class Program
    {
        public static void GiaiPT(double a, double b,double c)
        {
            double dl=b*b-4*a*c;
            if (dl < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else
            {
                if (dl == 0) {
                    Console.WriteLine("Phuong trinh co hai nghiem kep la:x1=x2=" + (-b / (2 * a)));
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(dl) / (2 * a)), x2 = (-b - Math.Sqrt(dl) / (2 * a));
                    Console.WriteLine("Phuong trinh co hai nghiem phan biet la:x1={0}, x2={1}", x1, x2);
                }
            }
        }
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("Nhap gia tri a:");
            a=Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap gia tri b:");
            b= Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap gia tri c:");
            c = Convert.ToDouble(Console.ReadLine());
            GiaiPT(a, b, c);
            Console.ReadKey();
        }
    }
}
