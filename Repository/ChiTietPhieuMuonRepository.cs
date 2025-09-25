using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;

namespace LibraryManagementSystem.Repository
{
    public class ChiTietPhieuMuonRepository
    {
        private readonly LibraryDbContext _context;
        public ChiTietPhieuMuonRepository(LibraryDbContext context)
        {
            _context = context;
        }
        public List<ChiTietPhieuMuon> GetAll()
        {
            return _context.ChiTietPhieuMuons.ToList();
        }
        public ChiTietPhieuMuon? GetById(int id)
        {
            return _context.ChiTietPhieuMuons.Find(id);
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