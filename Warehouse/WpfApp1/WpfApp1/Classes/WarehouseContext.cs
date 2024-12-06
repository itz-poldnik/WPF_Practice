using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WpfApp1.Classes;

public partial class WarehouseContext : DbContext
{
    public WarehouseContext()
    {
    }

    public WarehouseContext(DbContextOptions<WarehouseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Balance> Balances { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Shop> Shops { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }
    public object ItemsSourse { get; internal set; }
    public object Product { get; internal set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=44-9\\SQLEXPRESS;Database=Warehouse;TrustServerCertificate=True;Trusted_Connection=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Balance>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Balance");

            entity.Property(e => e.IdBalance)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_balance");
            entity.Property(e => e.IdProduct).HasColumnName("id_product");

            entity.HasOne(d => d.IdProductNavigation).WithMany()
                .HasForeignKey(d => d.IdProduct)
                .HasConstraintName("FK_Balance_Product");
        });

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.HasKey(e => e.IdInvoice);

            entity.ToTable("Invoice");

            entity.Property(e => e.IdInvoice).HasColumnName("id_invoice");
            entity.Property(e => e.IdProduct).HasColumnName("id_product");
            entity.Property(e => e.IdShop).HasColumnName("id_shop");

            entity.HasOne(d => d.IdProductNavigation).WithMany(p => p.Invoices)
                .HasForeignKey(d => d.IdProduct)
                .HasConstraintName("FK_Invoice_Product");

            entity.HasOne(d => d.IdShopNavigation).WithMany(p => p.Invoices)
                .HasForeignKey(d => d.IdShop)
                .HasConstraintName("FK_Invoice_Shop");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.IdOrder);

            entity.ToTable("Order");

            entity.Property(e => e.IdOrder).HasColumnName("id_order");
            entity.Property(e => e.IdProduct).HasColumnName("id_product");
            entity.Property(e => e.IdSupplier).HasColumnName("id_supplier");
            entity.Property(e => e.Price).HasColumnType("money");

            entity.HasOne(d => d.IdProductNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdProduct)
                .HasConstraintName("FK_Order_Product");

            entity.HasOne(d => d.IdSupplierNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdSupplier)
                .HasConstraintName("FK_Order_Supplier");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.IdProduct);

            entity.ToTable("Product");

            entity.Property(e => e.IdProduct).HasColumnName("id_product");
            entity.Property(e => e.IdSupplier).HasColumnName("id_supplier");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Unit).HasMaxLength(50);

            entity.HasOne(d => d.IdSupplierNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdSupplier)
                .HasConstraintName("FK_Product_Supplier");
        });

        modelBuilder.Entity<Shop>(entity =>
        {
            entity.HasKey(e => e.IdShop);

            entity.ToTable("Shop");

            entity.Property(e => e.IdShop).HasColumnName("id_shop");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(50);
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.IdSupplier);

            entity.ToTable("Supplier");

            entity.Property(e => e.IdSupplier).HasColumnName("id_supplier");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
