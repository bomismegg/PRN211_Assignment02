using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BusinessObjects.Models
{

    public partial class Assignment2Context : DbContext
    {
        public Assignment2Context()
        {
        }

        public Assignment2Context(DbContextOptions<Assignment2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Member> Members { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<OrderDetail> OrderDetails { get; set; }

        public virtual DbSet<Product> Products { get; set; }

        private string GetConnectionString()
        {
            IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true, true).Build();
            return configuration["ConnectionStrings:DefaultConnectionString"];
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(GetConnectionString());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>(entity =>
            {
                entity.HasKey(e => e.MemberId).HasName("PK__Member__0CF04B18B2946EB4");

                entity.ToTable("Member");

                entity.Property(e => e.MemberId).ValueGeneratedNever();
                entity.Property(e => e.City)
                    .HasMaxLength(15)
                    .IsUnicode(false);
                entity.Property(e => e.CompanyName)
                    .HasMaxLength(40)
                    .IsUnicode(false);
                entity.Property(e => e.Country)
                    .HasMaxLength(15)
                    .IsUnicode(false);
                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.FullName).HasMaxLength(100);
                entity.Property(e => e.Password)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.OrderId).HasName("PK__Order__C3905BCF95A0ECFD");

                entity.ToTable("Order");

                entity.Property(e => e.OrderId).ValueGeneratedNever();
                entity.Property(e => e.Freight).HasColumnType("money");
                entity.Property(e => e.OrderDate).HasColumnType("datetime");
                entity.Property(e => e.RequireDate).HasColumnType("datetime");
                entity.Property(e => e.ShippedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Member).WithMany(p => p.Orders)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Member");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.ProductId }).HasName("PK__OrderDet__08D097A3EA778864");

                entity.ToTable("OrderDetail");

                entity.Property(e => e.UnitPrice).HasColumnType("money");

                entity.HasOne(d => d.Order).WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKOrderDetai221089");

                entity.HasOne(d => d.Product).WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKOrderDetai695517");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProductId).HasName("PK__Product__B40CC6CDD71B7B6F");

                entity.ToTable("Product");

                entity.Property(e => e.ProductId).ValueGeneratedNever();
                entity.Property(e => e.ProductName)
                    .HasMaxLength(40)
                    .IsUnicode(false);
                entity.Property(e => e.UnitPrice).HasColumnType("money");
                entity.Property(e => e.Weight)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

