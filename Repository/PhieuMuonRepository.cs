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
                .Include(pn => pn.TheThanhVien!)
                    .ThenInclude(tv => tv.DocGia)
                .ToList();
        }
        public PhieuMuon? GetById(int id) => _context.PhieuMuons.Find(id);

        public PhieuMuon? GetChiTiet(int idPhieuMuon)
        {
            return _context.PhieuMuons
                .Include(pm => pm.TheThanhVien!)
                    .ThenInclude(ttv => ttv.DocGia)
                .Include(pm => pm.ChiTietPhieuMuons!)
                    .ThenInclude(ct => ct.BanSaoSach!)
                        .ThenInclude(bss => bss.Sach)
                .FirstOrDefault(pm => pm.IdPhieuMuon == idPhieuMuon);
        }

        public ChiTietPhieuMuon? GetChiTietById(int idChiTiet)
        {
            return _context.ChiTietPhieuMuons
                .Include(ct => ct.PhieuMuon!)
                    .ThenInclude(pm => pm.ChiTietPhieuMuons)
                .Include(ct => ct.BanSaoSach!)
                .FirstOrDefault(ct => ct.IdChiTietPhieuMuon == idChiTiet);
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

        public void UpdateChiTiet(ChiTietPhieuMuon chiTiet)
        {
            _context.ChiTietPhieuMuons.Update(chiTiet);
            _context.SaveChanges();
        }

        public PhieuMuon? Delete(int id)
        {
            var phieuMuon = GetById(id);
            if (phieuMuon == null) return null;
            _context.PhieuMuons.Remove(phieuMuon);
            _context.SaveChanges();
            return phieuMuon;
        }
        public void UpdateBanSao(BanSaoSach bss)
        {
            _context.BanSaoSachs.Update(bss);
        }
        //public MucPhat? GetMucPhatTheoLoai(string loaiPhat)
        //{
        //    return _context.MucPhats.FirstOrDefault(m => m.LoaiPhat == loaiPhat);
        //}
        public void AddPhieuPhat(PhieuPhat pp)
        {
            _context.PhieuPhats.Add(pp);
        }
        public void AddChiTietPhieuPhat(ChiTietPhieuPhat ctpp)
        {
            _context.ChiTietPhieuPhats.Add(ctpp);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
