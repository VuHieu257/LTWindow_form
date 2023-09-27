using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_bai03
{
    internal class person
    {
        public string CMND {  get; set; }
        public string HoTen { get; set;}
        public string DiaChi { get; set;}
        public person() { }
        public person(string cmnd, string hoten, string diaChi)
        {
            CMND = cmnd;
            HoTen = hoten;
            DiaChi = diaChi;
        }
    }
}
