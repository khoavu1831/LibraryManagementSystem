using LMS.Data;
using LMS.Entities;
using Microsoft.EntityFrameworkCore;

namespace LMS.Repository
{
    public class NhanVienRepository
    {
        private readonly LibraryDbContext _context;
        public NhanVienRepository(LibraryDbContext context) => _context = context;
        public List<NhanVien> GetAll() => _context.NhanViens.ToList();
        public NhanVien? GetById(int id) => _context.NhanViens.Find(id);
        public NhanVien Add(NhanVien nhanVien)
        {
            _context.NhanViens.Add(nhanVien);
            _context.SaveChanges();
            return nhanVien;
        }

        public NhanVien AddNVTK(NhanVien nhanVien, TaiKhoan taiKhoan)
        {
            _context.TaiKhoans.Add(taiKhoan);
            _context.SaveChanges();
            nhanVien.IdTaiKhoan = taiKhoan.IdTaiKhoan;
            _context.NhanViens.Add(nhanVien);
            _context.SaveChanges();
            return nhanVien;
        }
        public NhanVien Update(NhanVien nhanVien)
        {
            var existing = _context.NhanViens.FirstOrDefault(x => x.IdNhanVien == nhanVien.IdNhanVien);
            if (existing == null)
                throw new Exception("Không tìm thấy nhân viên.");

            // Gán lại giá trị mới cho entity đã được track
            existing.TenNhanVien = nhanVien.TenNhanVien;
            existing.NgaySinh = nhanVien.NgaySinh;
            existing.DiaChi = nhanVien.DiaChi;
            existing.SDT = nhanVien.SDT;
            existing.Email = nhanVien.Email;

            _context.SaveChanges();
            return existing;
        }
        public NhanVien? Delete(int id)
        {
            var nhanVien = GetById(id);
            if (nhanVien == null) return null;
            _context.NhanViens.Remove(nhanVien);
            _context.SaveChanges();
            var taiKhoan = _context.TaiKhoans.Find(nhanVien.IdTaiKhoan)!;
            _context.TaiKhoans.Remove(taiKhoan);
            _context.SaveChanges();

            return nhanVien;
        }

        public List<NhanVien> Search(string keyword) =>
            _context.NhanViens
                .AsNoTracking()
                .Where(nv => (nv.TenNhanVien ?? "").ToLower().Contains(keyword.ToLower()) ||
                              (nv.DiaChi ?? "").ToLower().Contains(keyword.ToLower()) ||
                              (nv.SDT ?? "").Contains(keyword) ||
                              (nv.Email ?? "").ToLower().Contains(keyword.ToLower()))
                .ToList();
    }
}