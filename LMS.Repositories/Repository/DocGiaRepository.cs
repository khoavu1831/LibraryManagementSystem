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