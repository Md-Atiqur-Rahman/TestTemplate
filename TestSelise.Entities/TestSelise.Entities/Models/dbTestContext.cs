using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TestSelise.Entities.Models
{
    public partial class dbTestContext : DbContext
    {
        public dbTestContext()
        {
        }

        public dbTestContext(DbContextOptions<dbTestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CommonCode> CommonCodes { get; set; }
        public virtual DbSet<DocumentInfo> DocumentInfos { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<UserInfo> UserInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-ICMG8LV;Database=dbTest;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<CommonCode>(entity =>
            {
                entity.ToTable("Common_Code");

                entity.Property(e => e.CommonCodeId).HasColumnName("Common_Code_Id");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<DocumentInfo>(entity =>
            {
                entity.ToTable("DocumentInfo");

                entity.Property(e => e.RecStatus).IsUnicode(false);
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("Person");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("date")
                    .HasColumnName("Date_Of_Birth");

                entity.Property(e => e.DivisionId).HasColumnName("Division_Id");

                entity.Property(e => e.Photo).IsUnicode(false);
            });

            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("UserInfo");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.HashPassword).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.PasswordSalt).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
