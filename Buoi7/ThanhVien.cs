namespace B7_1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThanhVien")]

    public partial class ThanhVien
    {
        [Key]
        [StringLength(100)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string PassWord { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }


        [Required]
        [StringLength(10)]
        public string Number { get; set; }

        [Required]
        [StringLength(10)]
        public string Quyen { get; set; }
    }
}
