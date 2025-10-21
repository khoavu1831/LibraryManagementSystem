using LMS.Data;
using LMS.Entities;
using Microsoft.EntityFrameworkCore;

namespace LMS.Repository
{
    public class NCCRepository
    {
        private readonly LibraryDbContext _context;
        public NCCRepository(LibraryDbContext context) => _context = context;
        public List<NCC> GetAll() => _context.NCCs.ToList();
        public NCC? GetById(int id) => _context.NCCs.Find(id);
        public NCC? GetByName(string name) =>
            _context.NCCs
                .AsNoTracking()
                .FirstOrDefault(ncc => (ncc.TenNCC ?? "").ToLower() == name.ToLower());
        public NCC? GetByPhone(string phone) =>
            _context.NCCs
                .AsNoTracking()
                .FirstOrDefault(ncc => ncc.SDT == phone);
        public NCC Add(NCC ncc)
        {
            _context.NCCs.Add(ncc);
            _context.SaveChanges();
            return ncc;
        }
        public NCC Update(NCC ncc)
        {
            var existingEntity = _context.NCCs.Local.FirstOrDefault(e => e.IdNCC == ncc.IdNCC);
            if (existingEntity != null)
            {
                _context.Entry(existingEntity).State = EntityState.Detached;
            }

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
        public List<NCC> Search(string keyword) =>
            _context.NCCs
                .AsNoTracking()
                .Where(ncc => (ncc.TenNCC ?? "").ToLower().Contains(keyword.ToLower()) ||
                              (ncc.DiaChi ?? "").ToLower().Contains(keyword.ToLower()) ||
                              (ncc.SDT ?? "").Contains(keyword))
                .ToList();
    }
}