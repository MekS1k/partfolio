using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace kursovaya
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Sotrudniki> Sotrudniki { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .Property(e => e.Cost)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Sotrudniki>()
                .Property(e => e.Zarplata)
                .HasPrecision(15, 2);

            modelBuilder.Entity<Sotrudniki>()
                .Property(e => e.Phone_number)
                .IsUnicode(false);

            modelBuilder.Entity<Sotrudniki>()
                .Property(e => e.Passport)
                .IsUnicode(false);
        }
    }
}
