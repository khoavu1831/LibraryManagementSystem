using LibraryManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Data
{
    public class LibraryDbContext : DbContext
    {
        private readonly string connectionString = @"server=localhost;port=3306;user=root;password=;database=library";
        public DbSet<Product> Products { get; set; }
        public DbSet<Sach> Sachs { get; set; }
        public DbSet<NXB> NXBs { get; set; }
        public DbSet<TheLoai> TheLoais { get; set; }
        public DbSet<TacGia> TacGias { get; set; }
        public DbSet<BanSaoSach> BanSaoSachs { get; set; }
        public DbSet<ChiTietPhieuMuon> ChiTietPhieuMuons { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            // Dùng gói Pomelo nên phải thêm tham số Version
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Sach_TheLoai
            modelBuilder.Entity<Sach>()
                .HasMany(s => s.TheLoais)
                .WithMany(t => t.Sachs)
                .UsingEntity<Dictionary<string, object>>(
                    "Sach_TheLoai",
                    j => j
                        .HasOne<TheLoai>()
                        .WithMany()
                        .HasForeignKey("IdTheLoai")
                        .OnDelete(DeleteBehavior.Cascade),
                    j => j
                        .HasOne<Sach>()
                        .WithMany()
                        .HasForeignKey("IdSach")
                        .OnDelete(DeleteBehavior.Cascade),
                    j =>
                    {
                        j.HasKey("IdSach", "IdTheLoai");
                        j.ToTable("Sach_TheLoai");
                    }
                );

            // Sach_TacGia
            modelBuilder.Entity<Sach>()
                .HasMany(s => s.TacGias)
                .WithMany(t => t.Sachs)
                .UsingEntity<Dictionary<string, object>>(
                    "Sach_TacGia",
                    j => j
                        .HasOne<TacGia>()
                        .WithMany()
                        .HasForeignKey("IdTacGia")
                        .OnDelete(DeleteBehavior.Cascade),
                    j => j
                        .HasOne<Sach>()
                        .WithMany()
                        .HasForeignKey("IdSach")
                        .OnDelete(DeleteBehavior.Cascade),
                    j =>
                    {
                        j.HasKey("IdSach", "IdTacGia");
                        j.ToTable("Sach_TacGia");
                    }
                );

            // BanSaoSach
            modelBuilder.Entity<BanSaoSach>()
                .Property(b => b.TinhTrangSach)
                .HasConversion<string>();

            // ChiTietPhieuMuon
            modelBuilder.Entity<ChiTietPhieuMuon>()
                .Property(c => c.TinhTrangTra)
                .HasConversion<string>();

        }
    }
}
