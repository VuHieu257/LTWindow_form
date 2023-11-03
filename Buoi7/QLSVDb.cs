using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace B7_1
{
    public partial class QLSVDb : DbContext
    {
        public QLSVDb()
            : base("name=ChuoiKN")
        {
        }

        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<ThanhVien> ThanhViens { get; set; }
    }
}
