using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_2
{
    internal class SanPham
    {
        public string MaSP{ get; set; }
        public string MaLoai { get; set;}
        public string TenSP { get; set; }
        public string DVTinh{ get; set; }
        public double GiaMua { get; set; }
        public double GiaBan { get; set; }

        public SanPham() {  }

        public SanPham(string masp, string maLoai, string tenSP, string dVTinh, double giaMua, double giaBan)
        {
            MaSP = masp;
            MaLoai = maLoai;
            TenSP = tenSP;
            DVTinh = dVTinh;
            GiaMua = giaMua;
            GiaBan = giaBan;
        }
    }
}
