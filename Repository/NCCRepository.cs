using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;

namespace LibraryManagementSystem.Repository
{
    public class NCCRepository
    {
        private readonly LibraryDbContext _context;
        public NCCRepository(LibraryDbContext context) => _context = context;
        public List<NCC> GetAll() => _context.NCCs.ToList();
        public NCC? GetById(int id) => _context.NCCs.Find(id);
        public NCC Add(NCC ncc)
        {
            _context.NCCs.Add(ncc);
            _context.SaveChanges();
            return ncc;
        }
        public NCC Update(NCC ncc)
        {
            _context.NCCs.Update(ncc);
            _context.SaveChanges();
            return ncc;
        }
        public NCC? DeleteById(int id)
        {
            var ncc = GetById(id);
            if (ncc == null) return null;
            _context.NCCs.Remove(ncc);
            _context.SaveChanges();
            return ncc;
        }


    }
}