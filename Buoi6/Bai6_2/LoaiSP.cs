using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_2
{
    internal class LoaiSP
    {
        public string MaLoai {  get; set; }
        public string TenLoai {  get; set; }
        public string ChiTiet {  get; set; }
        public LoaiSP() { }
        public LoaiSP(string maLoai, string tenLoai, string chiTiet)
        {
            MaLoai = maLoai;
            TenLoai = tenLoai;
            ChiTiet = chiTiet;
        }
    }
}
