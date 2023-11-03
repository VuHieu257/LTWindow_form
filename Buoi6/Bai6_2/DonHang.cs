using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_2
{
    internal class DonHang
    {
        public string MaDH { get; set; }
        public string NgayGH {  get; set; }
        public string NgayDH {  get; set; }
        public string KieuDH {  get; set; }
        public string GhiCHu {  get; set; }
        public DonHang() { }
        public DonHang(string maDH,string ngayGH, string ngayDH, string kieuDH, string ghiCHu)
        {
            MaDH = maDH;
            NgayGH = ngayGH;
            NgayDH = ngayDH;
            KieuDH = kieuDH;
            GhiCHu = ghiCHu;
        }
    }
}
