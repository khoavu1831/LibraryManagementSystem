using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;

namespace LibraryManagementSystem.Repository
{
    public class QuyenRepository
    {
        private readonly LibraryDbContext _context;
        public QuyenRepository(LibraryDbContext context) => _context = context;
        public List<Quyen> GetAll() => _context.Quyens.ToList();
        public Quyen? GetById(int id) => _context.Quyens.Find(id);
        public Quyen Add(Quyen quyen)
        {
            _context.Quyens.Add(quyen);
            _context.SaveChanges();
            return quyen;
        }
        public Quyen Update(Quyen quyen)
        {
            _context.Quyens.Update(quyen);
            _context.SaveChanges();
            return quyen;
        }
        public Quyen? DeleteById(int id)
        {
            var quyen = GetById(id);
            if (quyen == null) return null;
            _context.Quyens.Remove(quyen);
            _context.SaveChanges();
            return quyen;
        }
    }
}