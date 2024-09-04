using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Business.Entities;

namespace Business.Data
{
    public partial class MangoProductAPIContext : DbContext
    {
        public MangoProductAPIContext()
        {
        }

        public MangoProductAPIContext(DbContextOptions<MangoProductAPIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Coupon> Coupons { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<StaticParam> StaticParams { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=MangoProductAPI;Integrated Security=True;Trust Server Certificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StaticParam>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("StaticParam");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Key)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
