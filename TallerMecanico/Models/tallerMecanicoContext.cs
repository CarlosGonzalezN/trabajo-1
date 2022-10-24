using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TallerMecanico.Models
{
    public partial class tallerMecanicoContext : DbContext
    {
        public tallerMecanicoContext()
        {
        }

        public tallerMecanicoContext(DbContextOptions<tallerMecanicoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Auto> Autos { get; set; } = null!;
        public virtual DbSet<Categorium> Categoria { get; set; } = null!;
        public virtual DbSet<Estado> Estados { get; set; } = null!;
        public virtual DbSet<Ordentaller> Ordentallers { get; set; } = null!;
        public virtual DbSet<Taller> Tallers { get; set; } = null!;
        public virtual DbSet<Tecnico> Tecnicos { get; set; } = null!;
        public virtual DbSet<Titular> Titular { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("cadenaSQL");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auto>(entity =>
            {
                entity.ToTable("AUTO");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Año).HasColumnName("año");

                entity.Property(e => e.Color)
                    .HasMaxLength(10)
                    .HasColumnName("color")
                    .IsFixedLength();

                entity.Property(e => e.IdTitular).HasColumnName("idTitular");

                entity.Property(e => e.Marca)
                    .HasMaxLength(15)
                    .HasColumnName("marca")
                    .IsFixedLength();

                entity.Property(e => e.Modelo)
                    .HasMaxLength(15)
                    .HasColumnName("modelo")
                    .IsFixedLength();

                entity.Property(e => e.NChasis)
                    .HasMaxLength(25)
                    .HasColumnName("nChasis")
                    .IsFixedLength();

                entity.Property(e => e.Patente)
                    .HasMaxLength(10)
                    .HasColumnName("patente")
                    .IsFixedLength();

                entity.HasOne(d => d.oTitular)
                    .WithMany(p => p.Autos)
                    .HasForeignKey(d => d.IdTitular)
                    .HasConstraintName("FK_AUTO_TITULAR");
            });

            modelBuilder.Entity<Categorium>(entity =>
            {
                entity.ToTable("CATEGORIA");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .HasColumnName("descripcion")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.ToTable("ESTADO");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(15)
                    .HasColumnName("descripcion")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Ordentaller>(entity =>
            {
                entity.ToTable("ORDENTALLER");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(250)
                    .HasColumnName("descripcion")
                    .IsFixedLength();

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("endDate");

                entity.Property(e => e.IdAuto).HasColumnName("idAuto");

                entity.Property(e => e.IdCategoria).HasColumnName("idCategoria");

                entity.Property(e => e.IdEstado).HasColumnName("idEstado");

                entity.Property(e => e.IdTaller).HasColumnName("idTaller");

                entity.Property(e => e.IdTecnico).HasColumnName("idTecnico");

                entity.Property(e => e.Km).HasColumnName("km");

                entity.Property(e => e.Solucion)
                    .HasMaxLength(250)
                    .HasColumnName("solucion")
                    .IsFixedLength();

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("startDate");

                entity.HasOne(d => d.IdAutoNavigation)
                    .WithMany(p => p.Ordentallers)
                    .HasForeignKey(d => d.IdAuto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ORDENTALLER_AUTO");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Ordentallers)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ORDENTALLER_CATEGORIA");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Ordentallers)
                    .HasForeignKey(d => d.IdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ORDENTALLER_ESTADO");

                entity.HasOne(d => d.IdTallerNavigation)
                    .WithMany(p => p.Ordentallers)
                    .HasForeignKey(d => d.IdTaller)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ORDENTALLER_TALLER");

                entity.HasOne(d => d.IdTecnicoNavigation)
                    .WithMany(p => p.Ordentallers)
                    .HasForeignKey(d => d.IdTecnico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ORDENTALLER_Tecnico");
            });

            modelBuilder.Entity<Taller>(entity =>
            {
                entity.ToTable("TALLER");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Cuit)
                    .HasMaxLength(20)
                    .HasColumnName("cuit")
                    .IsFixedLength();

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .HasColumnName("direccion")
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(20)
                    .HasColumnName("nombre")
                    .IsFixedLength();

                entity.Property(e => e.Telefono)
                    .HasMaxLength(12)
                    .HasColumnName("telefono")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Tecnico>(entity =>
            {
                entity.ToTable("TECNICO");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(20)
                    .HasColumnName("apellido")
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(20)
                    .HasColumnName("nombre")
                    .IsFixedLength();

                entity.Property(e => e.Rol)
                    .HasMaxLength(10)
                    .HasColumnName("rol")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Titular>(entity =>
            {
                entity.ToTable("TITULAR");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(20)
                    .HasColumnName("apellido")
                    .IsFixedLength();

                entity.Property(e => e.Correo)
                    .HasMaxLength(100)
                    .HasColumnName("correo")
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(20)
                    .HasColumnName("nombre")
                    .IsFixedLength();

                entity.Property(e => e.Telefono)
                    .HasMaxLength(12)
                    .HasColumnName("telefono")
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
