using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using _19_EntityFramework.Models;

namespace _19_EntityFramework.Data;

public partial class GerardoContext : DbContext
{
    public GerardoContext()
    {
    }

    public GerardoContext(DbContextOptions<GerardoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Repuesto> Repuestos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=192.168.0.197;Database=Gerardo;user=sa;password=1234;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.ProductoId).HasName("PK__Producto__A430AE834E8E8E2C");

            entity.ToTable("Producto");

            entity.Property(e => e.ProductoId).HasColumnName("ProductoID");
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Comentarios).HasColumnType("text");
            entity.Property(e => e.Costo).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Nombre)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.PrecioVenta).HasColumnType("decimal(12, 2)");
        });

        modelBuilder.Entity<Repuesto>(entity =>
        {
            entity.HasKey(e => e.RepuestoId).HasName("PK_Repuesto_1");

            entity.ToTable("Repuesto");

            entity.Property(e => e.RepuestoId).HasColumnName("RepuestoID");
            entity.Property(e => e.Comentarios).HasColumnType("text");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Precio).HasColumnType("decimal(12, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
