using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Work.Models
{
    public partial class WorkContext : DbContext
    {
        public WorkContext()
        {
        }

        public WorkContext(DbContextOptions<WorkContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Blood> Blood { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-4U2QEMU\\SQLEXPRESS;Database=Work;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blood>(entity =>
            {
                entity.Property(e => e.DateCreated)
                    .HasColumnName("Date Created")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("Description ")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExamDate)
                    .HasColumnName(" Exam Date ")
                    .HasColumnType("datetime");

                entity.Property(e => e.Hematocrit)
                    .HasColumnName("Hematocrit ")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Hemoglobin).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.RedBloodCellCount)
                    .HasColumnName("Red Blood Cell Count")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ResultsDate)
                    .HasColumnName(" Results Date ")
                    .HasColumnType("datetime");

                entity.Property(e => e.WhiteBloodCellCount)
                    .HasColumnName("White Blood Cell Count")
                    .HasColumnType("decimal(10, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
