using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;

namespace LibraryManagementSystem.Repository
{
    public class PhieuMuonRepository
    {
        private readonly LibraryDbContext _context;
        public PhieuMuonRepository(LibraryDbContext context)
        {
            _context = context;
        }
        public List<PhieuMuon> GetAll()
        {
            return _context.PhieuMuons.ToList();
        }
        public PhieuMuon? GetById(int id)
        {
            return _context.PhieuMuons.Find(id);
        }
        public PhieuMuon Add(PhieuMuon phieuMuon)
        {
            _context.PhieuMuons.Add(phieuMuon);
            _context.SaveChanges();
            return phieuMuon;
        }
        public PhieuMuon Update(PhieuMuon phieuMuon)
        {
            _context.PhieuMuons.Update(phieuMuon);
            _context.SaveChanges();
            return phieuMuon;
        }
        public PhieuMuon? Delete(int id)
        {
            var phieuMuon = GetById(id);
            if (phieuMuon == null) return null;
            _context.PhieuMuons.Remove(phieuMuon);
            _context.SaveChanges();
            return phieuMuon;
        }
    }
}