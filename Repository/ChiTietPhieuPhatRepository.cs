using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;

namespace LibraryManagementSystem.Repository
{
    public class ChiTietPhieuPhatRepository
    {
        private readonly LibraryDbContext _context;
        public ChiTietPhieuPhatRepository(LibraryDbContext context) => _context = context;
        public List<ChiTietPhieuPhat> GetAll() => _context.ChiTietPhieuPhats.ToList();
        public ChiTietPhieuPhat? GetById(int id) => _context.ChiTietPhieuPhats.Find(id);
        public ChiTietPhieuPhat Add(ChiTietPhieuPhat ctpp)
        {
            _context.ChiTietPhieuPhats.Add(ctpp);
            _context.SaveChanges();
            return ctpp;
        }
        public ChiTietPhieuPhat Update(ChiTietPhieuPhat ctpp)
        {
            _context.ChiTietPhieuPhats.Update(ctpp);
            _context.SaveChanges();
            return ctpp;
        }
        public ChiTietPhieuPhat? Delete(int id)
        {
            var ctpp = GetById(id);
            if (ctpp == null) return null;
            _context.ChiTietPhieuPhats.Remove(ctpp);
            _context.SaveChanges();
            return ctpp;
        }
    }
}