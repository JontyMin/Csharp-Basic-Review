namespace Libraries.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class home_db : DbContext
    {
        public home_db()
            : base("name=home_db")
        {
        }

        public virtual DbSet<C__EFMigrationsHistory> C__EFMigrationsHistory { get; set; }
        public virtual DbSet<grades> grades { get; set; }
        public virtual DbSet<Student> Student { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<grades>()
                .HasMany(e => e.Student)
                .WithRequired(e => e.grades)
                .HasForeignKey(e => e.Gid)
                .WillCascadeOnDelete(false);
        }
    }
}
