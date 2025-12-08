using LMS.Data;
using LMS.Entities;
using Microsoft.EntityFrameworkCore;

namespace LMS.Repository
{
    public class TheThanhVienRepository
    {
        private readonly LibraryDbContext _context;
        public TheThanhVienRepository(LibraryDbContext context) => _context = context;
        public List<TheThanhVien> GetAll() => _context.TheThanhViens.ToList();
        public int getCount(string keyword = "")
        {
            var query = _context.TheThanhViens.AsQueryable();
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(s => s.IdTheThanhVien.ToString().Equals(keyword) || s.IdDocGia.ToString().Equals(keyword));
            }
            return query.Count();
        }
        public List<TheThanhVien> GetByPage(int page, int pageSize, string keyword = "")
        {
            var query = _context.TheThanhViens.AsQueryable();
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(s => s.IdTheThanhVien.ToString().Equals(keyword) || s.IdDocGia.ToString().Equals(keyword));
            }
            return query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }
        public TheThanhVien? GetById(int id) => _context.TheThanhViens.Find(id);
        public List<TheThanhVien> Search(string keyword)
        {
            return _context.TheThanhViens
                .Include(ttv => ttv.DocGia)
                .Where(ttv =>
                    ttv.DocGia.TenDocGia.Contains(keyword) ||
                    ttv.IdTheThanhVien.ToString().Contains(keyword) ||
                    (ttv.DocGia.SDT != null && ttv.DocGia.SDT.Contains(keyword)))
                .ToList();
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