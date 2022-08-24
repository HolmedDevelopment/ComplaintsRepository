using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Login
{
    public partial class LoginContext : DbContext
    {
        public LoginContext()
            : base("name=LoginContext")
        {
        }

        public virtual DbSet<tblUser> tblUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblUser>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<tblUser>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<tblUser>()
                .Property(e => e.Company)
                .IsUnicode(false);

            modelBuilder.Entity<tblUser>()
                .Property(e => e.Passwd)
                .IsUnicode(false);
        }
    }
}
