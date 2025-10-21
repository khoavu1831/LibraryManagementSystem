using LMS.Data;
using LMS.Entities;
using Microsoft.EntityFrameworkCore;

namespace LMS.Repository
{
    public class MucPhatRepository
    {
        private readonly LibraryDbContext _context;
        public MucPhatRepository(LibraryDbContext context) => _context = context;
        public List<MucPhat> GetAll() => _context.MucPhats.Where(mp => mp.IsActive == 1).ToList();
        public MucPhat? GetById(int id) => _context.MucPhats.Find(id);

        public MucPhat? GetByName(string name) =>
            _context.MucPhats
                .AsNoTracking()
                .FirstOrDefault(mp => (mp.TenMucPhat ?? "").ToLower() == name.ToLower() && mp.IsActive == 1);

        public MucPhat Add(MucPhat mucPhat)
        {
            mucPhat.IsActive = 1;
            _context.MucPhats.Add(mucPhat);
            _context.SaveChanges();
            return mucPhat;
        }
        public MucPhat Update(MucPhat mucPhat)
        {
            var existingEntity = _context.MucPhats.Local
                .FirstOrDefault(e => e.IdMucPhat == mucPhat.IdMucPhat);
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
            var mucPhat = _context.MucPhats.Find(id); // Tìm cả đã xóa
            if (mucPhat == null) return null;

            mucPhat.IsActive = 0; // Đánh dấu đã xóa
            _context.SaveChanges();
            return mucPhat;
        }

        public List<MucPhat> Search(string keyword) =>
            _context.MucPhats
                .AsNoTracking()
                .Where(mp => mp.IsActive == 1 && // Chỉ tìm trong các bản ghi chưa xóa
                            ((mp.TenMucPhat ?? "").ToLower().Contains(keyword.ToLower()) ||
                             mp.SoTienPhat.ToString().Contains(keyword)))
                .ToList();

    }
}