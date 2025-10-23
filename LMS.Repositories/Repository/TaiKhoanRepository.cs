using LMS.Data;
using LMS.Entities;

namespace LMS.Repository
{
    public class TaiKhoanRepository
    {
        private readonly LibraryDbContext _context;
        public TaiKhoanRepository(LibraryDbContext context) => _context = context;
        public List<TaiKhoan> GetAll() => _context.TaiKhoans.ToList();
        public TaiKhoan? GetById(int id) => _context.TaiKhoans.Find(id);
        public TaiKhoan Add(TaiKhoan taiKhoan)
        {
            _context.TaiKhoans.Add(taiKhoan);
            _context.SaveChanges();
            return taiKhoan;
        }
        public TaiKhoan Update(TaiKhoan taiKhoan)
        {
            _context.TaiKhoans.Update(taiKhoan);
            _context.SaveChanges();
            return taiKhoan;
        }
        public TaiKhoan? Delete(int id)
        {
            var taiKhoan = GetById(id);
            if (taiKhoan == null) return null;
            _context.TaiKhoans.Remove(taiKhoan);
            _context.SaveChanges();
            return taiKhoan;
        }
    }
}