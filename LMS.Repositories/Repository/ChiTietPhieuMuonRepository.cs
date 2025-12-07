using LMS.Data;
using LMS.Entities;
using Microsoft.EntityFrameworkCore;

namespace LMS.Repository
{
    public class ChiTietPhieuMuonRepository
    {
        private readonly LibraryDbContext _context;
        public ChiTietPhieuMuonRepository(LibraryDbContext context) => _context = context;
        public List<ChiTietPhieuMuon> GetAll() => _context.ChiTietPhieuMuons
                .AsNoTracking()
                .ToList();
        public ChiTietPhieuMuon? GetById(int id) => _context.ChiTietPhieuMuons.Find(id);
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