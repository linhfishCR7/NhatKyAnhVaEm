namespace NhatKyAnhVaEm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl01_KyNiem
    {
        [Key]
        public int ID_KyNiem { get; set; }

        [StringLength(100)]
        public string TenKiNiem { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ThoiGian { get; set; }

        [StringLength(255)]
        public string HinhAnh { get; set; }

        public string NoiDung { get; set; }
    }
}
