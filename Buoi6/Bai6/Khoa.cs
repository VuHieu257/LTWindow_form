using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    internal class Khoa
    {
        public string MaKhoa {  get; set; }
        public string TenKhoa {  get; set; }
        public string GhiChu {  get; set; }

        public Khoa() { }
        public Khoa(string maKhoa, string tenKhoa, string ghiChu)
        {
            MaKhoa = maKhoa;
            TenKhoa = tenKhoa;
            GhiChu = ghiChu;
        }
    }
}
