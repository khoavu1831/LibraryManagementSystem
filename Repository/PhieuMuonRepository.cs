using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Repository
{
    public class PhieuMuonRepository
    {
        private readonly LibraryDbContext _context;
        public PhieuMuonRepository(LibraryDbContext context) => _context = context;

        public List<PhieuMuon> GetAll() => _context.PhieuMuons.ToList();

        public PhieuMuon? GetById(int id) => _context.PhieuMuons.Find(id);

        public PhieuMuon? GetByIdWithDetails(int id)
        {
            return _context.PhieuMuons
                .Include(pm => pm.ChiTietPhieuMuons)
                    .ThenInclude(ct => ct.BanSaoSach)
                .Include(pm => pm.TheThanhVien)
                .Include(pm => pm.NhanVien)
                .FirstOrDefault(pm => pm.IdPhieuMuon == id);
        }

        public List<PhieuMuon> GetDangMuonByTheThanhVien(int idTheThanhVien)
        {
            return _context.PhieuMuons
                .Include(pm => pm.ChiTietPhieuMuons)
                    .ThenInclude(ct => ct.BanSaoSach)
                .Where(pm => pm.IdTheThanhVien == idTheThanhVien
                    && pm.TrangThai == PhieuMuon.TrangThaiEnum.DangMuon)
                .ToList();
        }

        public List<PhieuMuon> GetPhieuQuaHan()
        {
            var today = DateTime.Now.Date;
            return _context.PhieuMuons
                .Include(pm => pm.ChiTietPhieuMuons)
                .Include(pm => pm.TheThanhVien)
                .Where(pm => pm.TrangThai == PhieuMuon.TrangThaiEnum.DangMuon
                    && pm.NgayHenTra < today)
                .ToList();
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

        public List<PhieuMuon> Search(string keyword)
        {
            return _context.PhieuMuons
                .Include(pm => pm.TheThanhVien)
                    .ThenInclude(tv => tv.DocGias)
                .Include(pm => pm.NhanVien)
                .Include(pm => pm.ChiTietPhieuMuons)
                .Where(pm =>
                    (pm.TheThanhVien != null &&
                     pm.TheThanhVien.DocGias != null &&
                     pm.TheThanhVien.DocGias.TenDocGia != null &&
                     pm.TheThanhVien.DocGias.TenDocGia.Contains(keyword)) ||
                    (pm.NhanVien != null &&
                     pm.NhanVien.TenNhanVien != null &&
                     pm.NhanVien.TenNhanVien.Contains(keyword)))
                .ToList();
        }

        public List<PhieuMuon> GetAllWithDetails()
        {
            return _context.PhieuMuons
                .Include(pm => pm.ChiTietPhieuMuons)
                    .ThenInclude(ct => ct.BanSaoSach)
                .Include(pm => pm.TheThanhVien)
                    .ThenInclude(tv => tv.DocGias) 
                .Include(pm => pm.NhanVien)
                .OrderBy(pm => pm.IdPhieuMuon)   
                .ToList();
        }
    }
}
