using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;

namespace LibraryManagementSystem.Repository
{
    public class MucPhatRepository
    {
        private readonly LibraryDbContext _context;
        public MucPhatRepository(LibraryDbContext context)
        {
            _context = context;
        }
        public List<MucPhat> GetAll()
        {
            return _context.MucPhats.ToList();
        }
        public MucPhat? GetById(int id)
        {
            return _context.MucPhats.Find(id);
        }
        public MucPhat Add(MucPhat mucPhat)
        {
            _context.MucPhats.Add(mucPhat);
            _context.SaveChanges();
            return mucPhat;
        }
        public MucPhat Update(MucPhat mucPhat)
        {
            _context.MucPhats.Update(mucPhat);
            _context.SaveChanges();
            return mucPhat;
        }
        public MucPhat? Delete(int id)
        {
            var mucPhat = GetById(id);
            if (mucPhat == null) return null;
            _context.MucPhats.Remove(mucPhat);
            _context.SaveChanges();
            return mucPhat;
        }
    }
}