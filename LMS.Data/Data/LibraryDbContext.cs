using LMS.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Data
{
    public class LibraryDbContext : DbContext
    {
        private readonly string connectionString = @"server=localhost;port=3306;user=root;password=;database=library";
        public DbSet<Sach> Sachs { get; set; }
        public DbSet<NXB> NXBs { get; set; }
        public DbSet<TheLoai> TheLoais { get; set; }
        public DbSet<TacGia> TacGias { get; set; }
        public DbSet<BanSaoSach> BanSaoSachs { get; set; }
        public DbSet<DocGia> DocGias { get; set; }
        public DbSet<TheThanhVien> TheThanhViens { get; set; }
        public DbSet<NCC> NCCs { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
        public DbSet<Quyen> Quyens { get; set; }
        public DbSet<VaiTro> VaiTros { get; set; }
        public DbSet<MucPhat> MucPhats { get; set; }
        public DbSet<PhieuMuon> PhieuMuons { get; set; }
        public DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public DbSet<PhieuPhat> PhieuPhats { get; set; }
        public DbSet<ChiTietPhieuMuon> ChiTietPhieuMuons { get; set; }
        public DbSet<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }
        public DbSet<ChiTietPhieuPhat> ChiTietPhieuPhats { get; set; }
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

            // VaiTro_Quyen
            modelBuilder.Entity<VaiTro>()
                .HasMany(v => v.Quyens)
                .WithMany(q => q.VaiTros)
                .UsingEntity<Dictionary<string, object>>(
                    "VaiTro_Quyen",
                    j => j
                        .HasOne<Quyen>()
                        .WithMany()
                        .HasForeignKey("IdQuyen")
                        .OnDelete(DeleteBehavior.Cascade),
                    j => j
                        .HasOne<VaiTro>()
                        .WithMany()
                        .HasForeignKey("IdVaiTro")
                        .OnDelete(DeleteBehavior.Cascade),
                    j =>
                    {
                        j.HasKey("IdVaiTro", "IdQuyen");
                        j.ToTable("VaiTro_Quyen");
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

            // TheThanhVien
            modelBuilder.Entity<TheThanhVien>()
                .Property(t => t.TrangThai)
                .HasConversion<string>();

            // MucPhat
            modelBuilder.Entity<MucPhat>()
                .Property(m => m.LoaiPhat)
                .HasConversion<string>();

            // PhieuPhat
            modelBuilder.Entity<PhieuPhat>()
                .Property(p => p.TrangThai)
                .HasConversion<string>();

            // PhieuMuon
            modelBuilder.Entity<PhieuMuon>()
                .Property(p => p.TrangThai)
                .HasConversion<string>();

            // PhieuNhap
            modelBuilder.Entity<PhieuNhap>()
                .Property(p => p.LoaiPhieuNhap)
                .HasConversion<string>();
        }
    }
}
