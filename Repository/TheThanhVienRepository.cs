using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;

namespace LibraryManagementSystem.Repository
{
    public class TheThanhVienRepository
    {
        private readonly LibraryDbContext _context;
        public TheThanhVienRepository(LibraryDbContext context)
        {
            _context = context;
        }
        public List<TheThanhVien> GetAll()
        {
            return _context.TheThanhViens.ToList();
        }
        public TheThanhVien? GetById(int id)
        {
            return _context.TheThanhViens.Find(id);
        }
        public TheThanhVien Add(TheThanhVien theThanhVien)
        {
            _context.TheThanhViens.Add(theThanhVien);
            _context.SaveChanges();
            return theThanhVien;
        }
        public TheThanhVien Update(TheThanhVien theThanhVien)
        {
            _context.TheThanhViens.Update(theThanhVien);
            _context.SaveChanges();
            return theThanhVien;
        }
        public TheThanhVien? Delete(int id)
        {
            var theThanhVien = GetById(id);
            if (theThanhVien == null) return null;
            _context.TheThanhViens.Remove(theThanhVien);
            _context.SaveChanges();
            return theThanhVien;
        }
    }
}