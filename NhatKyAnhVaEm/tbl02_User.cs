namespace NhatKyAnhVaEm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl02_User
    {
        [Key]
        public int ID_User { get; set; }

        [StringLength(50)]
        public string TenUser { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(255)]
        public string Password { get; set; }
    }
}
