using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B7_1
{
    internal class SinhVienDAO
    {
        QLSVDb db = new QLSVDb(); 
        public List<SinhVien>getList()
        {
            List<SinhVien> list =db.SinhViens.ToList();
            return list;
        }
        public int getCount()
        {
            return db.SinhViens.Count();
        }
        public SinhVien GetRow(string username)
        {
           SinhVien row=db.SinhViens.Where(m=>m.MaSV==username).First();
            return row;
        }
        public void Insert(SinhVien tv)
        {
            db.SinhViens.Add(tv);
            db.SaveChanges();
        }
        public void Update(SinhVien tv)
        {
            db.Entry(tv).State=EntityState.Modified;
            db.SaveChanges();
        }
        public void Delete(SinhVien tv)
        {
            db.SinhViens.Remove(tv);
            db.SaveChanges();
        }
    }
}
