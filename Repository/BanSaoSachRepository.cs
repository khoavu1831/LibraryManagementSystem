using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Repository
{
    public class BanSaoSachRepository
    {
        private readonly LibraryDbContext _context;
        public BanSaoSachRepository(LibraryDbContext context) => _context = context;
        public List<BanSaoSach> GetAll() => _context.BanSaoSachs.Include(bss => bss.Sach).ToList();
        public BanSaoSach? GetById(string id) => _context.BanSaoSachs.Find(id);
        public int GetCountBySach(int idSach) => _context.BanSaoSachs.Count(b => b.IdSach == idSach);
        public int GetCount() => _context.BanSaoSachs.Count();
        public List<BanSaoSach> GetByPage(int page, int pageSize)
        {
            return _context.BanSaoSachs
                .Include(bss => bss.Sach)
                .OrderBy(bss => bss.IdBanSaoSach)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }
        public BanSaoSach Add(BanSaoSach banSaoSach)
        {
            _context.BanSaoSachs.Add(banSaoSach);
            _context.SaveChanges();
            return banSaoSach;
        }
        public List<BanSaoSach> AddRange(List<BanSaoSach> banSaoSachList)
        {
            _context.BanSaoSachs.AddRange(banSaoSachList);
            _context.SaveChanges();
            return banSaoSachList;
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