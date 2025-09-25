using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;

namespace LibraryManagementSystem.Repository
{
    public class TheLoaiRepository
    {
        private readonly LibraryDbContext _context;
        public TheLoaiRepository(LibraryDbContext context)
        {
            _context = context;
        }
        public List<TheLoai> GetAll()
        {
            return _context.TheLoais.ToList();
        }
        public TheLoai? GetById(int id)
        {
            return _context.TheLoais.Find(id);
        }
        public TheLoai Add(TheLoai theLoai)
        {
            _context.TheLoais.Add(theLoai);
            _context.SaveChanges();
            return theLoai;
        }
        public TheLoai Update(TheLoai theLoai)
        {
            _context.TheLoais.Update(theLoai);
            _context.SaveChanges();
            return theLoai;
        }
        public TheLoai? Delete(int id)
        {
            var theLoai = GetById(id);
            if (theLoai == null) return null;
            _context.TheLoais.Remove(theLoai);
            _context.SaveChanges();
            return theLoai;
        }
    }
}