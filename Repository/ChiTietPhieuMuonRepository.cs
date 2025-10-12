using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Repository
{
    public class ChiTietPhieuMuonRepository
    {
        private readonly LibraryDbContext _context;
        public ChiTietPhieuMuonRepository(LibraryDbContext context) => _context = context;

        public List<ChiTietPhieuMuon> GetAll() => _context.ChiTietPhieuMuons.ToList();

        public ChiTietPhieuMuon? GetById(int id)
        {
            return _context.ChiTietPhieuMuons
                .Include(ct => ct.BanSaoSach)
                    .ThenInclude(bs => bs.Sach)
                .Include(ct => ct.PhieuMuon)
                .FirstOrDefault(ct => ct.IdChiTietPhieuMuon == id);
        }

        public List<ChiTietPhieuMuon> GetByPhieuMuonId(int idPhieuMuon)
        {
            return _context.ChiTietPhieuMuons
                .Include(ct => ct.BanSaoSach)
                .Where(ct => ct.IdPhieuMuon == idPhieuMuon)
                .ToList();
        }

        public List<ChiTietPhieuMuon> GetChuaTraByPhieuMuonId(int idPhieuMuon)
        {
            return _context.ChiTietPhieuMuons
                .Include(ct => ct.BanSaoSach)
                    .ThenInclude(bs => bs.Sach)
                .Where(ct => ct.IdPhieuMuon == idPhieuMuon && ct.NgayTra == null)
                .ToList();
        }


        public ChiTietPhieuMuon Add(ChiTietPhieuMuon ctpm)
        {
            _context.ChiTietPhieuMuons.Add(ctpm);
            _context.SaveChanges();
            return ctpm;
        }

        public ChiTietPhieuMuon Update(ChiTietPhieuMuon ctpm)
        {
            _context.ChiTietPhieuMuons.Update(ctpm);
            _context.SaveChanges();
            return ctpm;
        }

        public ChiTietPhieuMuon? Delete(int id)
        {
            var ctpm = GetById(id);
            if (ctpm == null) return null;
            _context.ChiTietPhieuMuons.Remove(ctpm);
            _context.SaveChanges();
            return ctpm;
        }
    }
}
