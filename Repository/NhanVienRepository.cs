using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Views.UserControls.QLNhanVien.TaiKhoan;

namespace LibraryManagementSystem.Repository
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
            _context.NhanViens.Update(nhanVien);
            _context.SaveChanges();
            return nhanVien;
        }
        public NhanVien? Delete(int id)
        {
            var nhanVien = GetById(id);
            if (nhanVien == null) return null;
            _context.NhanViens.Remove(nhanVien);
            _context.SaveChanges();
            var taiKhoan = _context.TaiKhoans.Find(nhanVien.IdTaiKhoan);
            _context.TaiKhoans.Remove(taiKhoan);
            _context.SaveChanges();

            return nhanVien;
        }
    }
}