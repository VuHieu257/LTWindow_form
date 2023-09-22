using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_b3
{
    internal class Program
    {
        public static int TongLe(int n)
        {
            int sum=0;
            for(int i = 1; i <= (2*n-1);i++)
                if (i % 2 != 0)
                {
                    sum += i;

                }
            return sum;
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap n:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tong cac so le:"+TongLe(n));
            Console.ReadKey();
        }
    }
}
