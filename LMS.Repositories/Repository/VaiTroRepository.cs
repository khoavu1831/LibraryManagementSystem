using LMS.Data;
using LMS.Entities;

namespace LMS.Repository
{
    public class VaiTroRepository
    {
        private readonly LibraryDbContext _context;
        public VaiTroRepository(LibraryDbContext context) => _context = context;
        public List<VaiTro> GetAll() => _context.VaiTros.ToList();
        public VaiTro? GetById(int id) => _context.VaiTros.Find(id);
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
        public VaiTro? DeleteById(int id)
        {
            var vaiTro = GetById(id);
            if (vaiTro == null) return null;
            _context.VaiTros.Remove(vaiTro);
            _context.SaveChanges();
            return vaiTro;
        }
    }
}