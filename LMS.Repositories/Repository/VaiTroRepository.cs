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
            var entity = _context.VaiTros.Find(id);
            if (entity != null)
            {
                _context.VaiTros.Remove(entity);
                _context.SaveChanges();  // Đảm bảo SaveChanges ở đây để commit xóa (bao gồm cascade)
                return entity;
            }
            return null;
        }
    }
}