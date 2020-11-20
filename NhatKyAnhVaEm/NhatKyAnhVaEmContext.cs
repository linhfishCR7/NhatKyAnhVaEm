namespace NhatKyAnhVaEm
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NhatKyAnhVaEmContext : DbContext
    {
        public NhatKyAnhVaEmContext()
            : base("name=NhatKyAnhVaEmContext")
        {
        }

        public virtual DbSet<tbl01_KyNiem> tbl01_KyNiem { get; set; }
        public virtual DbSet<tbl02_User> tbl02_User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
