using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using HagenApi.Data.Models;

namespace HagenApi.Data
{
    public partial class HagenContext : DbContext
    {
        public HagenContext()
        {
        }

        public HagenContext(DbContextOptions<HagenContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DatosUsuario> DatosUsuarios { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=SQL5107.site4now.net;Database=db_a83c03_hagendb;uid=db_a83c03_hagendb_admin;pwd=h4g3ns0ss;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DatosUsuario>(entity =>
            {
                entity.ToTable("DatosUsuario");

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

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

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

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.DatosUsuarios)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK_datosUsuario_usuario");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .IsClustered(false);

                entity.ToTable("Usuario");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Contrasena)
                    .IsUnicode(false)
                    .HasColumnName("contrasena");

                entity.Property(e => e.Correo)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaRegistro");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
