using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;

namespace LibraryManagementSystem.Repository
{
    public class DocGiaRepository
    {
        private readonly LibraryDbContext _context;
        public DocGiaRepository(LibraryDbContext context)
        {
            _context = context;
        }
        public List<DocGia> GetAll()
        {
            return _context.DocGias.ToList();
        }
        public DocGia? GetDocGiaById(int id)
        {
            return _context.DocGias.Find(id);
        }
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
            var docGia = GetDocGiaById(id);
            if (docGia == null) return null;
            _context.DocGias.Remove(docGia);
            _context.SaveChanges();
            return docGia;
        }
    }
}