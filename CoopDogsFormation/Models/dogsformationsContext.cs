using System;
using CoopDogsFormation.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CoopDogsFormation.Models
{
    public partial class dogsformationsContext : DbContext
    {

        public dogsformationsContext()
        {
        }

        public dogsformationsContext(DbContextOptions<dogsformationsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChapterFormation> ChapterFormations { get; set; }
        public virtual DbSet<Formation> Formations { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserAdmin> UserAdmins { get; set; }
        public virtual DbSet<UserFormation> UserFormations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL(BddConnect.ConnectChain);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChapterFormation>(entity =>
            {
                entity.HasKey(e => e.IdChapter)
                    .HasName("PRIMARY");

                entity.ToTable("chapter_formation");

                entity.HasIndex(e => e.IdFormation, "formation_chapter_idx");

                entity.HasIndex(e => e.UrlVideo, "url_video_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.IdChapter).HasColumnName("id_chapter");

                entity.Property(e => e.ChapterNumber).HasColumnName("chapter_number");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.IdFormation).HasColumnName("id_formation");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.Property(e => e.UrlVideo)
                    .HasMaxLength(255)
                    .HasColumnName("url_video");

                entity.HasOne(d => d.IdFormationNavigation)
                    .WithMany(p => p.ChapterFormations)
                    .HasForeignKey(d => d.IdFormation)
                    .HasConstraintName("formation_chapter");
            });

            modelBuilder.Entity<Formation>(entity =>
            {
                entity.HasKey(e => e.IdFormations)
                    .HasName("PRIMARY");

                entity.ToTable("formations");

                entity.HasIndex(e => e.Title, "Title_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.IdFormations).HasColumnName("idFormations");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.HasIndex(e => e.Username, "username_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AllFormationAccess)
                    .HasColumnType("tinyint")
                    .HasColumnName("all_formation_access");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("firstname");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("lastname");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("password");

                entity.Property(e => e.TraceNote).HasColumnName("trace_note");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<UserAdmin>(entity =>
            {
                entity.ToTable("user_admin");

                entity.HasIndex(e => e.Username, "username_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<UserFormation>(entity =>
            {
                entity.HasKey(e => new { e.IdUser, e.IdFormation })
                    .HasName("PRIMARY");

                entity.ToTable("user_formation");

                entity.HasIndex(e => e.IdFormation, "idFormation_idx");

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.HasOne(d => d.IdFormationNavigation)
                    .WithMany(p => p.UserFormations)
                    .HasForeignKey(d => d.IdFormation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("idFormation");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.UserFormations)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("idUser");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
