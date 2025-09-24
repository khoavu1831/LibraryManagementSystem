using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;

namespace LibraryManagementSystem.Repository
{
    public class NXBRepository
    {
        public readonly LibraryDbContext _context;
        public NXBRepository(LibraryDbContext context)
        {
            _context = context;
        }
        public List<NXB> GetAll()
        {
            return _context.NXBs.ToList();
        }
        public NXB? GetById(int id)
        {
            return _context.NXBs.Find(id);
        }
        public NXB Add(NXB nxb)
        {
            _context.NXBs.Add(nxb);
            _context.SaveChanges();
            return nxb;
        }
        public NXB Update(NXB nxb)
        {
            _context.NXBs.Update(nxb);
            _context.SaveChanges();
            return nxb;
        }
        public NXB? DeleteById(int id)
        {
            var nxb = GetById(id);
            if (nxb == null) return null;
            _context.NXBs.Remove(nxb);
            _context.SaveChanges();
            return nxb;
        }
    }
}