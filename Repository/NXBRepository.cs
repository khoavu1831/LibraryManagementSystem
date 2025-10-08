using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Repository
{
    public class NXBRepository
    {
        public readonly LibraryDbContext _context;
        public NXBRepository(LibraryDbContext context) => _context = context;
        public List<NXB> GetAll() => _context.NXBs.ToList();
        public NXB? GetById(int id) => _context.NXBs.Find(id);
        public NXB? GetByName(string name) => 
            _context.NXBs
                .AsNoTracking()
                .FirstOrDefault(nxb => (nxb.TenNXB ?? "").ToLower() == name.ToLower());
        public NXB? GetByPhone(string phone) => 
            _context.NXBs
                .AsNoTracking()
                .FirstOrDefault(nxb => nxb.SDT == phone);
        public NXB Add(NXB nxb)
        {
            _context.NXBs.Add(nxb);
            _context.SaveChanges();
            return nxb;
        }
        public NXB Update(NXB nxb)
        {
            var existingEntity = _context.NXBs.Local.FirstOrDefault(e => e.IdNXB == nxb.IdNXB);
            if (existingEntity != null)
            {
                _context.Entry(existingEntity).State = EntityState.Detached;
            }

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
        public List<NXB> Search(string keyword) =>
            _context.NXBs
                .AsNoTracking()
                .Where(nxb => (nxb.TenNXB ?? "").ToLower().Contains(keyword.ToLower()) ||
                              (nxb.DiaChi ?? "").ToLower().Contains(keyword.ToLower()) ||
                              (nxb.SDT ?? "").Contains(keyword))
                .ToList();
    }
}