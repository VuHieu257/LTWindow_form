using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_2
{
    internal class DonHangCT
    {
        public string MaDH {  get; set; }
        public string MaCTDH {  get; set; }
        public string MaSP { get; set; }
        public string TenSp { get; set; }
        public string DVTinh { get; set; }
        public string DonGia { get; set; }
        public double SoLuong { get; set; }

        public DonHangCT() { }
        public DonHangCT(string mactdh, string maDH, string maSP, string tenSp, string dVTinh, string donGia, double SoLuong)
        {
            MaCTDH = mactdh;
            MaDH = maDH;
            MaSP = maSP;
            TenSp = tenSp;
            DVTinh = dVTinh;
            DonGia = donGia;
            this.SoLuong = SoLuong;
        }
    }
}
