using LMS.Data;
using LMS.Entities;
using Microsoft.EntityFrameworkCore;

namespace LMS.Repository
{
    public class TacGiaRepository
    {
        private readonly LibraryDbContext _context;
        public TacGiaRepository(LibraryDbContext context) => _context = context;
        public List<TacGia> GetAll() => _context.TacGias.ToList();
        public TacGia? GetById(int id) => _context.TacGias.Find(id);
        public TacGia? GetByName(string name) =>
                _context.TacGias
                 .AsNoTracking()
                 .FirstOrDefault(tg => (tg.TenTacGia ?? "").ToLower() == name.ToLower());
        public TacGia? GetByBirth(DateTime ngaySinh) =>
                _context.TacGias
                 .AsNoTracking()
                 .FirstOrDefault(tg => tg.NgaySinh == ngaySinh);
        public TacGia? GetByNoiSinh(string noiSinh) =>
                _context.TacGias
                 .AsNoTracking()
                 .FirstOrDefault(tg => (tg.NoiSinh ?? "").ToLower() == noiSinh.ToLower());
        public TacGia? GetByPhone(string sdt) =>
                _context.TacGias
                 .AsNoTracking()
                 .FirstOrDefault(tg => (tg.SDT ?? "").ToLower() == sdt.ToLower());

        public TacGia Add(TacGia tacGia)
        {
            _context.TacGias.Add(tacGia);
            _context.SaveChanges();
            return tacGia;
        }
        public TacGia Update(TacGia tacGia)
        {
            var existingEntity = _context.TacGias.FirstOrDefault(e => e.IdTacGia == tacGia.IdTacGia);
            if (existingEntity != null)
            {
                _context.Entry(existingEntity).State = EntityState.Detached;
            }

            _context.TacGias.Update(tacGia);
            _context.SaveChanges();
            return tacGia;
        }
        public TacGia? DeleteById(int id)
        {
            var tacGia = GetById(id);
            if (tacGia == null) return null;
            _context.TacGias.Remove(tacGia);
            _context.SaveChanges();
            return tacGia;
        }
        public List<TacGia> Search(string keyword) =>
            _context.TacGias
                .Where(tg => (tg.TenTacGia ?? "").ToLower().Contains(keyword.ToLower()) ||
                             (tg.NoiSinh ?? "").ToLower().Contains(keyword.ToLower()) ||
                             (tg.SDT ?? "").Contains(keyword))
                .ToList();
    }
}