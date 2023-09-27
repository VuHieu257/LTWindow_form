using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_02
{
    internal class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public double DiemTB { get; set; }
        public string Khoa { get; set; }

        public SinhVien() { }

        public SinhVien(string maSV, string hoTen, double diemTB, string khoa)
        {
            this.MaSV = maSV;
            this.HoTen = hoTen;
            this.DiemTB = diemTB;
            this.Khoa = khoa;
        }
        public void NhapSV()
        {
            Console.Write("nhap Ma sinh vien: ");
            MaSV = Console.ReadLine();
            Console.Write("nhap Ho Ten: ");
            HoTen = Console.ReadLine();
            Console.Write("nhap Diem TB: ");
            DiemTB = Convert.ToDouble(Console.ReadLine());
            Console.Write("nhap Khoa: ");
            Khoa = Console.ReadLine();
        }
        public void XuatSV()
        {
            Console.WriteLine("MaSV:{0},HoTen:{1},DiemTB:{2},Khoa:{3}", MaSV, HoTen, DiemTB, Khoa);
        }
        public List<SinhVien> NhapSinhVien()
        {
            Console.Write("Nhap so luong sinh vien:");
            int n = Convert.ToInt32(Console.ReadLine());
            List<SinhVien> listSinhVien = new List<SinhVien>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap Sinh Vien thu {0}:", i + 1);
                SinhVien sv = new SinhVien();
                sv.NhapSV();
                listSinhVien.Add(sv);
                Console.WriteLine("###################");
            }

            return listSinhVien;
        }
        public void xuatSinhVien(List<SinhVien> listSinhVien)
        {
            foreach (SinhVien sv in listSinhVien)
            {
                sv.XuatSV();
            }

}
        public void DSSVCNTT(List<SinhVien> listSinhVien)
        {
            List<SinhVien> listCNTT = listSinhVien.Where(p => p.Khoa == "CNTT").ToList();
            if (listCNTT.Count() == 0)
            {
                Console.WriteLine("Không có sinh viên khoa CNTT");
            }
            else
            {
                xuatSinhVien(listCNTT);
            }
        }
        public void DSSVDTB(List<SinhVien> listSinhVien)
        {
            List<SinhVien> listCNTT = listSinhVien.Where(p => p.DiemTB>=5).ToList();
            if (listCNTT.Count() == 0)
            {
                Console.WriteLine("Khong co sinh vien nao nho hon 5");
            }
            else
            {
                Console.WriteLine("Sinh Vien co diem lon hon 5");
                xuatSinhVien(listCNTT);
            }
        }
        public void DSSVDSapXepTB(List<SinhVien> listSinhVien)
        {
            List<SinhVien> listCNTT = listSinhVien.OrderBy(p => p.DiemTB).ToList();
            Console.WriteLine("Danh sach diem duoc sap xep");
            xuatSinhVien(listCNTT);   
        }
        public void DSSVD1_5(List<SinhVien> listSinhVien)
        {
            List<SinhVien> listCNTT = listSinhVien.Where(p => p.DiemTB >= 5).ToList();
            listCNTT.Where(p => p.Khoa == "CNTT").ToList();
            if (listCNTT.Count() == 0)
            {
                Console.WriteLine("Khong co sinh vien nao nho hon 5");
            }
            else
            {
                Console.WriteLine("Danh sach SV co diem lon hon 5 va thuoc khoa CNTT");
                xuatSinhVien(listCNTT);
            }
        }
        public void DSSVD1_6(List<SinhVien> listSinhVien)
        {
            List<SinhVien> listCNTT = listSinhVien.Where(p => p.Khoa == "CNTT").ToList();
            var oldest = listCNTT.Max(s => s.DiemTB);

            List<SinhVien> ljt = listCNTT.Where(p => p.DiemTB == oldest).ToList();
            if (listCNTT.Count() == 0)
            {
                Console.WriteLine("Khong co sinh vien nao nho hon 5");
            }
            else
            {
                Console.WriteLine("Danh sach SV co diem lon nhat va thuoc khoa CNTT");
                xuatSinhVien(ljt);
                
            }
        }
    }
}
