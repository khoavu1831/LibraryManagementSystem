using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;

namespace LibraryManagementSystem.Repository
{
    public class TacGiaRepository
    {
        private readonly LibraryDbContext _context;
        public TacGiaRepository(LibraryDbContext context)
        {
            _context = context;
        }
        public List<TacGia> GetAll()
        {
            return _context.TacGias.ToList();
        }
        public TacGia? GetById(int id)
        {
            return _context.TacGias.Find(id);
        }
        public TacGia Update(TacGia tacGia)
        {
            _context.TacGias.Update(tacGia);
            _context.SaveChanges();
            return tacGia;
        }
        public TacGia Add(TacGia tacGia)
        {
            _context.TacGias.Add(tacGia);
            _context.SaveChanges();
            return tacGia;
        }
        public TacGia? DeleteById(int id)
        {
            var tacGia = GetById(id);
            if (tacGia == null) return null;
            _context.TacGias.Remove(tacGia);
            _context.SaveChanges();
            return tacGia;
        }
    }
}