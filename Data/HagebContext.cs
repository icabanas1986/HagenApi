using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using HagenApi.Data.Models;

namespace HagenApi.Data
{
    public partial class HagebContext : DbContext
    {
        public HagebContext()
        {
        }

        public HagebContext(DbContextOptions<HagebContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Registro> Registros { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=SQL5107.site4now.net;Database=db_a83c03_hagendb;uid=db_a83c03_hagendb_admin;pwd=h4g3ns0ss;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Registro>(entity =>
            {
                entity.ToTable("Registro");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AceptaTerminos).HasColumnName("aceptaTerminos");

                entity.Property(e => e.Apellido1)
                    .IsUnicode(false)
                    .HasColumnName("apellido1");

                entity.Property(e => e.Apellido2)
                    .IsUnicode(false)
                    .HasColumnName("apellido2");

                entity.Property(e => e.Contraseña)
                    .IsUnicode(false)
                    .HasColumnName("contraseña");

                entity.Property(e => e.Direccion)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Email)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.EstadoCivil).HasColumnName("estadoCivil");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaActualizacion");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaNacimiento");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaRegistro");

                entity.Property(e => e.Municipio).HasColumnName("municipio");

                entity.Property(e => e.Nacionalidad).HasColumnName("nacionalidad");

                entity.Property(e => e.Nombre1)
                    .IsUnicode(false)
                    .HasColumnName("nombre1");

                entity.Property(e => e.Nombre2)
                    .IsUnicode(false)
                    .HasColumnName("nombre2");

                entity.Property(e => e.Pais).HasColumnName("pais");

                entity.Property(e => e.Telefono)
                    .IsUnicode(false)
                    .HasColumnName("telefono");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
