using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_02
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien();
            List<SinhVien> listSinhVien = sv.NhapSinhVien();
            Console.WriteLine("-----------------------------");
            sv.xuatSinhVien(listSinhVien);
            Console.WriteLine("-----------------------------");
            sv.DSSVCNTT(listSinhVien);
            Console.WriteLine("-----------------------------");
            sv.DSSVDTB(listSinhVien);
            Console.WriteLine("-----------------------------");
            sv.DSSVDSapXepTB(listSinhVien);
            Console.WriteLine("-----------------------------");
            sv.DSSVD1_5(listSinhVien);
            Console.WriteLine("-----------------------------");
            sv.DSSVD1_6(listSinhVien);
            Console.ReadKey();            
        }

    }
}
