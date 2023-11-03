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
    internal class ThanhVienDAO
    {
        QLSVDb db = new QLSVDb(); 
        public List<ThanhVien>getList()
        {
            List<ThanhVien> list =db.ThanhViens.ToList();
            return list;
        }
        public int getCount()
        {
            return db.ThanhViens.Count();
        }
        public ThanhVien GetRow(string username)
        {
           ThanhVien row=db.ThanhViens.Where(m=>m.UserName==username).First();
            return row;
        }
        public void Insert(ThanhVien tv)
        {
            db.ThanhViens.Add(tv);
            db.SaveChanges();
        }
        public void Update(ThanhVien tv)
        {
            db.Entry(tv).State=EntityState.Modified;
            db.SaveChanges();
        }
        public void Delete(ThanhVien tv)
        {
            db.ThanhViens.Remove(tv);
            db.SaveChanges();
        }
    }
}
