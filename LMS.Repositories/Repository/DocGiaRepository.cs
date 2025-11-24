using LMS.Data;
using LMS.Entities;
using System.ComponentModel;

namespace LMS.Repository
{
    public class DocGiaRepository
    {
        private readonly LibraryDbContext _context;
        public DocGiaRepository(LibraryDbContext context) => _context = context;
        public BindingList<DocGia> GetAll()
        {
            return new BindingList<DocGia>(_context.DocGias.ToList());
        }
        public int GetCount(string keyword = "")
        {
            var query = _context.DocGias
                .AsQueryable();

            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(d => d.TenDocGia.ToLower().Contains(keyword.ToLower()) || d.SDT.Contains(keyword) || d.Email.ToLower().Contains(keyword.ToLower()));
            }
            return query.Count();
        }
        public BindingList<DocGia> GetByPage(int page, int pageSize, string keyword = "")
        {
            var query = _context.DocGias.OrderBy(d => d.IdDocGia).AsQueryable();
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(d => d.TenDocGia.ToLower().Contains(keyword.ToLower()) || d.SDT.Contains(keyword) || d.Email.ToLower().Contains(keyword.ToLower()));
            }
            var list = query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();
            return new BindingList<DocGia>(list);
        }
        public DocGia? GetById(int id) => _context.DocGias.Find(id);
        public DocGia Add(DocGia docGia)
        {
            _context.DocGias.Add(docGia);
            _context.SaveChanges();
            return docGia;
        }
        public DocGia Update(DocGia docGia)
        {
            _context.DocGias.Update(docGia);
            _context.SaveChanges();
            return docGia;
        }
        public DocGia? DeleteById(int id)
        {
            var docGia = GetById(id);
            if (docGia == null) return null;
            _context.DocGias.Remove(docGia);
            _context.SaveChanges();
            return docGia;
        }
    }
}