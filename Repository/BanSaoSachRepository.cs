using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;

namespace LibraryManagementSystem.Repository
{
    public class BanSaoSachRepository
    {
        private readonly LibraryDbContext _context;
        public BanSaoSachRepository(LibraryDbContext context) => _context = context;
        public List<BanSaoSach> GetAll() => _context.BanSaoSachs.ToList();
        public BanSaoSach? GetById(string id) => _context.BanSaoSachs.Find(id);
        public BanSaoSach Add(BanSaoSach banSaoSach)
        {
            _context.BanSaoSachs.Add(banSaoSach);
            _context.SaveChanges();
            return banSaoSach;
        }
        public BanSaoSach Update(BanSaoSach banSaoSach)
        {
            _context.BanSaoSachs.Update(banSaoSach);
            _context.SaveChanges();
            return banSaoSach;
        }
        public BanSaoSach? DeleteById(string id)
        {
            var banSaoSach = GetById(id);
            if (banSaoSach == null) return null;
            _context.BanSaoSachs.Remove(banSaoSach);
            _context.SaveChanges();
            return banSaoSach;
        }
    }
}