using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Model
{
    public partial class MyContext : DbContext
    {
        public MyContext()
            : base("name=DbContext")
        {
        }

        public virtual DbSet<tblComplaint> tblComplaints { get; set; }
        public virtual DbSet<tblComplaintType> tblComplaintTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblComplaint>()
                .Property(e => e.CustId)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplaint>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<tblComplaint>()
                .Property(e => e.ComplaintDescription)
                .IsUnicode(false);
        }
    }
}
