using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;

namespace LibraryManagementSystem.Repository
{
    public class PhieuPhatRepository
    {
        private readonly LibraryDbContext _context;
        public PhieuPhatRepository(LibraryDbContext context) => _context = context;
        public List<PhieuPhat> GetAll() => _context.PhieuPhats.ToList();
        public PhieuPhat? GetById(int id) => _context.PhieuPhats.Find(id);
        public PhieuPhat Add(PhieuPhat phieuPhat)
        {
            _context.PhieuPhats.Add(phieuPhat);
            _context.SaveChanges();
            return phieuPhat;
        }
        public PhieuPhat Update(PhieuPhat phieuPhat)
        {
            _context.PhieuPhats.Update(phieuPhat);
            _context.SaveChanges();
            return phieuPhat;
        }
        public PhieuPhat? Delete(int id)
        {
            var phieuPhat = GetById(id);
            if (phieuPhat == null) return null;
            _context.PhieuPhats.Remove(phieuPhat);
            _context.SaveChanges();
            return phieuPhat;
        }
    }
}