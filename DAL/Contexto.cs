using EjemploEF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploEF.DAL
{
    public class Contexto : DbContext
    {
        public Contexto()
        {
        }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public virtual DbSet<Clientes> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlite(@"Data Source = Clientes.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.Property(p => p.ClienteId)
                   .IsRequired()
                   .HasMaxLength(100)
                   .IsUnicode(false);

                entity.Property(p => p.Nombre)
                   .IsRequired()
                   .HasMaxLength(100)
                   .IsUnicode(false);

                entity.ToTable("Clientes");

                entity.Property(p => p.Apellido)
                   .IsRequired()
                   .HasMaxLength(100)
                   .IsUnicode(false);
                entity.Property(p => p.Cedula)
                    .HasMaxLength(15)
                    .IsUnicode(false);
                entity.Property(p => p.Direccion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(p => p.FechaNacimiento).HasColumnType("date");


            });


        }

    }
}
