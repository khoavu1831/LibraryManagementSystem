using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Repository
{
    public class MucPhatRepository
    {
        private readonly LibraryDbContext _context;
        public MucPhatRepository(LibraryDbContext context) => _context = context;
        public List<MucPhat> GetAll() => _context.MucPhats.ToList();
        public MucPhat? GetById(int id) => _context.MucPhats.Find(id);

        public MucPhat? GetByName(string name) =>
            _context.MucPhats
                .AsNoTracking()
                .FirstOrDefault(mp => (mp.TenMucPhat ?? "").ToLower() == name.ToLower());

        public MucPhat Add(MucPhat mucPhat)
        {
            _context.MucPhats.Add(mucPhat);
            _context.SaveChanges();
            return mucPhat;
        }
        public MucPhat Update(MucPhat mucPhat)
        {
            var existingEntity = _context.MucPhats.Local.FirstOrDefault(e => e.IdMucPhat == mucPhat.IdMucPhat);
            if (existingEntity != null)
            {
                _context.Entry(existingEntity).State = EntityState.Detached;
            }

            _context.MucPhats.Update(mucPhat);
            _context.SaveChanges();
            return mucPhat;
        }

        public MucPhat? DeleteById(int id)
        {
            var mucPhat = GetById(id);
            if (mucPhat == null) return null;
            _context.MucPhats.Remove(mucPhat);
            _context.SaveChanges();
            return mucPhat;
        }

        public List<MucPhat> Search(string keyword) =>
            _context.MucPhats
                .AsNoTracking()
                .Where(mp => (mp.TenMucPhat ?? "").ToLower().Contains(keyword.ToLower()) ||
                             mp.SoTienPhat.ToString().Contains(keyword))
                .ToList();
        
    }
}