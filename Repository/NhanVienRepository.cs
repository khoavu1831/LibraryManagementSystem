using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;

namespace LibraryManagementSystem.Repository
{
    public class NhanVienRepository
    {
        private readonly LibraryDbContext _context;
        public NhanVienRepository(LibraryDbContext context)
        {
            _context = context;
        }
        public List<NhanVien> GetAll()
        {
            return _context.NhanViens.ToList();
        }
        public NhanVien? GetById(int id)
        {
            return _context.NhanViens.Find(id);
        }
        public NhanVien Add(NhanVien nhanVien)
        {
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
            return nhanVien;
        }
    }
}