using Microsoft.EntityFrameworkCore;
using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;

namespace LibraryManagementSystem.Repository
{
    public class PhieuMuonRepository
    {
        private readonly LibraryDbContext _context;
        public PhieuMuonRepository(LibraryDbContext context) => _context = context;
        public List<PhieuMuon> GetAll()
        {
            return _context.PhieuMuons
                .Include(pn => pn.NhanVien)
                .Include(pn => pn.TheThanhVien)
                    .ThenInclude(tv => tv.DocGia)
                .ToList();
        }
        public PhieuMuon? GetById(int id) => _context.PhieuMuons.Find(id);
        public PhieuMuon Add(PhieuMuon PhieuMuon)
        {
            _context.PhieuMuons.Add(PhieuMuon);
            _context.SaveChanges();
            return PhieuMuon;
        }
        public PhieuMuon Update(PhieuMuon PhieuMuon)
        {
            _context.PhieuMuons.Update(PhieuMuon);
            _context.SaveChanges();
            return PhieuMuon;
        }
        public PhieuMuon? Delete(int id)
        {
            var PhieuMuon = GetById(id);
            if (PhieuMuon == null) return null;
            _context.PhieuMuons.Remove(PhieuMuon);
            _context.SaveChanges();
            return PhieuMuon;
        }
    }
}