using LMS.Data;
using LMS.Entities;
using Microsoft.EntityFrameworkCore;

namespace LMS.Repository
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
        public List<PhieuMuon> GetAllForRevenue()
        {
            return _context.PhieuMuons
                //.Include(pn => pn.NhanVien)
                //.Include(pn => pn.TheThanhVien!)
                //.ThenInclude(tv => tv.DocGia)
                .Include(pn => pn.ChiTietPhieuMuons)
                .ToList();
        }

        /// <summary>
        /// Lấy tất cả phiếu mượn với Include đầy đủ (dùng cho Excel export)
        /// </summary>
        public List<PhieuMuon> GetAllWithIncludes()
        {
            return _context.PhieuMuons
                .Include(pm => pm.NhanVien)
                .Include(pm => pm.TheThanhVien!)
                    .ThenInclude(tv => tv.DocGia)
                .AsNoTracking()
                .OrderByDescending(pm => pm.NgayMuon)
                .ToList();
        }

        /// <summary>
        /// Đếm tổng số phiếu mượn
        /// </summary>
        public int GetCount() => _context.PhieuMuons.Count();

        /// <summary>
        /// Đếm tổng số phiếu mượn theo filter
        /// </summary>
        public int GetCountByFilter(PhieuMuon.TrangThaiEnum? trangThai = null, string? keyword = null)
        {
            var query = _context.PhieuMuons
                .Include(pm => pm.NhanVien)
                .Include(pm => pm.TheThanhVien!)
                    .ThenInclude(tv => tv.DocGia)
                .AsQueryable();

            // Filter trạng thái
            if (trangThai.HasValue)
                query = query.Where(pm => pm.TrangThai == trangThai.Value);

            // Filter keyword (tên độc giả HOẶC tên nhân viên)
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(pm =>
                    pm.TheThanhVien!.DocGia!.TenDocGia.Contains(keyword) ||
                    pm.NhanVien!.TenNhanVien.Contains(keyword));
            }

            return query.Count();
        }

        /// <summary>
        /// Lấy phiếu mượn có phân trang với filter
        /// </summary>
        public List<PhieuMuon> GetByPageWithFilter(int page, int pageSize, PhieuMuon.TrangThaiEnum? trangThai = null, string? keyword = null)
        {
            var query = _context.PhieuMuons
                .Include(pm => pm.NhanVien)
                .Include(pm => pm.TheThanhVien!)
                    .ThenInclude(tv => tv.DocGia)
                .AsNoTracking()
                .AsQueryable();

            // Filter trạng thái
            if (trangThai.HasValue)
                query = query.Where(pm => pm.TrangThai == trangThai.Value);

            // Filter keyword (tên độc giả HOẶC tên nhân viên)
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(pm =>
                    pm.TheThanhVien!.DocGia!.TenDocGia.Contains(keyword) ||
                    pm.NhanVien!.TenNhanVien.Contains(keyword));
            }

            return query
                .OrderByDescending(pm => pm.NgayMuon)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
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

        public PhieuPhat? GetOpenPhieuPhatByPhieuMuon(int idPhieuMuon)
        {
            return _context.PhieuPhats
                .Include(pp => pp.ChiTietPhieuPhats!)
                    .ThenInclude(ct => ct.ChiTietPhieuMuon!)
                        .ThenInclude(x => x.PhieuMuon)
                .FirstOrDefault(pp =>
                    pp.TrangThai == PhieuPhat.TrangThaiEnum.ChuaThu &&
                    pp.ChiTietPhieuPhats!.Any(ct => ct.ChiTietPhieuMuon!.IdPhieuMuon == idPhieuMuon));
        }

        public MucPhat? GetPerDayFine()
        {
            return _context.MucPhats
                .AsNoTracking()
                .FirstOrDefault(mp => mp.LoaiPhat == MucPhat.LoaiPhatEnum.PerDay && mp.IsActive == 1);
        }

        public MucPhat? GetMucPhatById(int id)
        {
            return _context.MucPhats
                .AsNoTracking()
                .FirstOrDefault(m => m.IdMucPhat == id && m.IsActive == 1);
        }

        public List<MucPhat> GetActiveFixedFines()
        {
            return _context.MucPhats
                .AsNoTracking()
                .Where(mp => mp.LoaiPhat == MucPhat.LoaiPhatEnum.Fixed && mp.IsActive == 1)
                .ToList();
        }

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
