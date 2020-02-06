using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PracticeDatabaseFirst.Models
{
    public partial class ZooContext : DbContext
    {
        public ZooContext()
        {
        }

        public ZooContext(DbContextOptions<ZooContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categorie> Categorie { get; set; }
        public virtual DbSet<Ingrijitor> Ingrijitor { get; set; }
        public virtual DbSet<Sarcina> Sarcina { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorie>(entity =>
            {
                entity.Property(e => e.NumeCategorie)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ingrijitor>(entity =>
            {
                entity.Property(e => e.NumeIngrijitor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sarcina>(entity =>
            {
                entity.Property(e => e.NumeSarcina)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Categorie)
                    .WithMany(p => p.Sarcina)
                    .HasForeignKey(d => d.CategorieId)
                    .HasConstraintName("FK__Sarcina__Categor__276EDEB3");

                entity.HasOne(d => d.Ingrijitor)
                    .WithMany(p => p.Sarcina)
                    .HasForeignKey(d => d.IngrijitorId)
                    .HasConstraintName("FK__Sarcina__Ingriji__286302EC");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
