using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_b2
{
    
    internal class Program
    {
        public static bool Check(int year)
        {
            if (year % 400== 0 || (year % 4==0&& year % 100!=0)) {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            int year,month,day=0;
            Console.Write("Nhap thang:");
            month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap nam:");
            year =Convert.ToInt32(Console.ReadLine());
            switch(month)
            {
                case 1:case 3:case 5:case 7:case 8:case 10:case 12: day = 31;break;
                case 2:
                    {
                        if (Check(year) == true && month == 2)
                        {
                            day = 29;
                        }
                        else day = 28;
                    }
                    break;
                   
                case 4: case 6: case 9: case 11: day = 30; break;
            }
           
            Console.WriteLine("Trong thang {0} cua nam {1} co {2} ngay", month, year, day);
            Console.ReadKey();
        }
    }

}
