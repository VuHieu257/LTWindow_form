using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_b7
{
    internal class Program
    {
        public static bool CheckNT(int n)
        {
            if (n < 2) { return false; }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n%i == 0) {  return false; }                  
            }
            return true;
        }
        static void Main(string[] args)
        {
            int n ;
            Console.Write("Nhap n:");
            n=Convert.ToInt32(Console.ReadLine());
            Console.Write("So nguyen to tu 1 -> n:");
            for (int i = 1;i<=n;i++)
            {
                if(CheckNT(i)==true)
                {
                    Console.Write("\t"+i);
                }
            }
            Console.ReadKey();
        }
    }
}
