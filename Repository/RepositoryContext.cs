using System;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Guids;

#nullable disable

namespace Repository
{
    public partial class RepositoryContext : DbContext
    {
        public RepositoryContext()
        {
        }

        public RepositoryContext(DbContextOptions<RepositoryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder();
                builder.SetBasePath(Directory.GetCurrentDirectory());
                builder.AddJsonFile("appsetting.json");
                var config = builder.Build();
                string connectionString = config.GetConnectionString("SQLConnection");
                optionsBuilder.UseNpgsql(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Russian_Russia.1251");

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.UUID).HasName("guids_products_pkey");
                entity.ToTable("guids_products");
                entity.Property(e => e.UUID).ValueGeneratedNever().HasColumnName("uuid");
                entity.Property(e => e.Code).HasMaxLength(30).HasColumnName("code");
                entity.Property(e => e.Description).HasMaxLength(30).HasColumnName("description");
                entity.Property(e => e.Name).HasMaxLength(30).HasColumnName("name");
                entity.Property(e => e.NotValid).HasColumnName("notvalid");
                entity.Property(e => e.Owner).HasColumnName("owner");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UUID).HasName("guids_users_pkey");
                entity.ToTable("guids_users");
                entity.Property(e => e.UUID).ValueGeneratedNever().HasColumnName("uuid");
                entity.Property(e => e.Login).HasMaxLength(50).HasColumnName("login");
                entity.Property(e => e.Pass).HasMaxLength(8).HasColumnName("pass");
                entity.Property(e => e.Email).HasMaxLength(50).HasColumnName("email");
                entity.Property(e => e.Phone).HasMaxLength(20).HasColumnName("phone");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
