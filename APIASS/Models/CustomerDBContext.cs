using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace APIASS.Models
{
    public partial class CustomerDBContext : DbContext
    {
        public CustomerDBContext()
        {
        }

        public CustomerDBContext(DbContextOptions<CustomerDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Buyers> Buyers { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Sellers> Sellers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-MESBIGN\\SQLEXPRESS;Initial Catalog=CustomerDB;User ID=sa;Password=pass@word1");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Buyers>(entity =>
            {
                entity.HasKey(e => e.Bid);

                entity.Property(e => e.Bid).HasColumnName("bid");

                entity.Property(e => e.Bemail).HasColumnName("bemail");

                entity.Property(e => e.Bname)
                    .IsRequired()
                    .HasColumnName("bname")
                    .HasMaxLength(20);

                entity.Property(e => e.Bpassword).HasColumnName("bpassword");

                entity.Property(e => e.Bphnum).HasColumnName("bphnum");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PK__Customer__D837D05FAD6DC6BE");

                entity.Property(e => e.Cid)
                    .HasColumnName("cid")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cname)
                    .HasColumnName("cname")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.Pid);

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Pname).HasColumnName("pname");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Stocknum).HasColumnName("stocknum");

                entity.Property(e => e.Subcatid).HasColumnName("subcatid");
            });

            modelBuilder.Entity<Sellers>(entity =>
            {
                entity.HasKey(e => e.Sid);

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Companyname).HasColumnName("companyname");

                entity.Property(e => e.Gstin).HasColumnName("gstin");

                entity.Property(e => e.PostalAddress).HasColumnName("postal_address");

                entity.Property(e => e.Semail).HasColumnName("semail");

                entity.Property(e => e.Sname)
                    .IsRequired()
                    .HasColumnName("sname")
                    .HasMaxLength(20);

                entity.Property(e => e.Spassword).HasColumnName("spassword");

                entity.Property(e => e.Sphnum).HasColumnName("sphnum");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
