using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;

namespace LibraryManagementSystem.Repository
{
    public class VaiTroRepository
    {
        private readonly LibraryDbContext _context;
        public VaiTroRepository(LibraryDbContext context)
        {
            _context = context;
        }
        public List<VaiTro> GetAll()
        {
            return _context.VaiTros.ToList();
        }
        public VaiTro? GetById(int id)
        {
            return _context.VaiTros.Find(id);
        }
        public VaiTro Add(VaiTro vaiTro)
        {
            _context.VaiTros.Add(vaiTro);
            _context.SaveChanges();
            return vaiTro;
        }
        public VaiTro Update(VaiTro vaiTro)
        {
            _context.VaiTros.Update(vaiTro);
            _context.SaveChanges();
            return vaiTro;
        }
        public VaiTro? Delete(int id)
        {
            var vaiTro = GetById(id);
            if (vaiTro == null) return null;
            _context.VaiTros.Remove(vaiTro);
            _context.SaveChanges();
            return vaiTro;
        }
    }
}