using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_2
{
    internal class LoaiSach
    {
        public string MaLoai {  get; set; }
        public string TenLoai {  get; set; }
        public LoaiSach() { }
        public LoaiSach(string maLoai, string tenLoai)
        {
            MaLoai = maLoai;
            TenLoai = tenLoai;
        }
    }
}
