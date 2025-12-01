using LMS.Data;
using LMS.Entities;
using Microsoft.EntityFrameworkCore;

namespace LMS.Repository
{
    public class BanSaoSachRepository
    {
        private readonly LibraryDbContext _context;
        public BanSaoSachRepository(LibraryDbContext context) => _context = context;
        public List<BanSaoSach> GetAll() => _context.BanSaoSachs.Include(bss => bss.Sach).ToList();
        public BanSaoSach? GetById(string id) => _context.BanSaoSachs.Find(id);
        public int GetCountBySach(int idSach) => _context.BanSaoSachs.Count(b => b.IdSach == idSach);
        public int GetCount(string keyword = "")
        {
            var query = _context.BanSaoSachs
                .Include(bss => bss.Sach)
                .AsQueryable();

            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(bss => bss.Sach!.TenSach.ToLower().Contains(keyword.ToLower()));
            }

            return query.Count();
        }
        public List<BanSaoSach> GetByPage(int page, int pageSize, string keyword = "")
        {
            // L?y t?t c? BanSaoSach
            var query = _context.BanSaoSachs
                .Include(bss => bss.Sach)
                .OrderBy(bss => bss.IdBanSaoSach)
                .AsQueryable();

            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(bss =>
            bss.Sach!.TenSach!.ToLower().Contains(keyword.ToLower()) ||
            bss.TinhTrangSach.ToString().ToLower().Contains(keyword.ToLower()));
            }

            // Ph�n trang
            return query
                .Skip((page - 1) * pageSize) // b? c�c b?n ghi tr??c trang hi?n t?i
                .Take(pageSize)              // l?y ?�ng s? b?n ghi m?i trang
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