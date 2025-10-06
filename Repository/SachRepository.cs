using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Repository
{
    public class SachRepository
    {
        private readonly LibraryDbContext _context;
        public SachRepository(LibraryDbContext context) => _context = context;
        public List<Sach> GetAll()
        {
            return _context.Sachs
                .Include(s => s.NXB)
                .Include(s => s.TacGias)
                .Include(s => s.TheLoais)
                .ToList();
        }
        public Sach? GetById(int id) => _context.Sachs.Find(id);
        public Sach Add(Sach sach)
        {
            _context.Sachs.Add(sach);
            _context.SaveChanges();
            return sach;
        }
        public Sach Update(Sach sach)
        {
            _context.Sachs.Update(sach);
            _context.SaveChanges();
            return sach;
        }
        public Sach? DeleteById(int id)
        {
            var sach = GetById(id);
            if (sach == null) return null;
            _context.Sachs.Remove(sach);
            _context.SaveChanges();
            return sach;
        }
    }
}