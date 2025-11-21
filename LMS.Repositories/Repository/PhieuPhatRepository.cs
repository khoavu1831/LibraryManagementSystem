using LMS.Data;
using LMS.Entities;
using Microsoft.EntityFrameworkCore;

namespace LMS.Repository
{
    public class PhieuPhatRepository
    {
        private readonly LibraryDbContext _context;
        public PhieuPhatRepository(LibraryDbContext context) => _context = context;
        
        public List<PhieuPhat> GetAll() => _context.PhieuPhats.ToList();
        
        public PhieuPhat? GetById(int id) => _context.PhieuPhats.Find(id);
        
        /// <summary>
        /// Lấy tất cả phiếu phạt với Include đầy đủ (dùng cho Excel export)
        /// </summary>
        public List<PhieuPhat> GetAllWithIncludes()
        {
            return _context.PhieuPhats
                .Include(pp => pp.ChiTietPhieuPhats!)
                    .ThenInclude(ct => ct.ChiTietPhieuMuon!)
                        .ThenInclude(ctpm => ctpm.PhieuMuon!)
                            .ThenInclude(pm => pm.TheThanhVien!)
                                .ThenInclude(ttv => ttv.DocGia)
                .AsNoTracking()
                .OrderByDescending(pp => pp.NgayLap)
                .ToList();
        }
        
        /// <summary>
        /// Đếm tổng số phiếu phạt
        /// </summary>
        public int GetCount() => _context.PhieuPhats.Count();
        
        /// <summary>
        /// Đếm tổng số phiếu phạt theo filter
        /// </summary>
        public int GetCountByFilter(PhieuPhat.TrangThaiEnum? trangThai = null, string? keyword = null)
        {
            var query = _context.PhieuPhats
                .Include(pp => pp.ChiTietPhieuPhats!)
                    .ThenInclude(ct => ct.ChiTietPhieuMuon!)
                        .ThenInclude(ctpm => ctpm.PhieuMuon!)
                            .ThenInclude(pm => pm.TheThanhVien!)
                                .ThenInclude(ttv => ttv.DocGia)
                .AsQueryable();

            // Filter trạng thái
            if (trangThai.HasValue)
                query = query.Where(pp => pp.TrangThai == trangThai.Value);

            // Filter keyword (tên độc giả)
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(pp =>
                    pp.ChiTietPhieuPhats!.Any(ctpp =>
                        ctpp.ChiTietPhieuMuon!.PhieuMuon!.TheThanhVien!.DocGia!.TenDocGia
                            .Contains(keyword)));
            }

            return query.Count();
        }
        
        /// <summary>
        /// Lấy phiếu phạt có phân trang với filter
        /// </summary>
        public List<PhieuPhat> GetByPageWithFilter(int page, int pageSize, PhieuPhat.TrangThaiEnum? trangThai = null, string? keyword = null)
        {
            var query = _context.PhieuPhats
                .Include(pp => pp.ChiTietPhieuPhats!)
                    .ThenInclude(ct => ct.ChiTietPhieuMuon!)
                        .ThenInclude(ctpm => ctpm.PhieuMuon!)
                            .ThenInclude(pm => pm.TheThanhVien!)
                                .ThenInclude(ttv => ttv.DocGia)
                .AsNoTracking()
                .AsQueryable();

            // Filter trạng thái
            if (trangThai.HasValue)
                query = query.Where(pp => pp.TrangThai == trangThai.Value);

            // Filter keyword (tên độc giả)
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(pp =>
                    pp.ChiTietPhieuPhats!.Any(ctpp =>
                        ctpp.ChiTietPhieuMuon!.PhieuMuon!.TheThanhVien!.DocGia!.TenDocGia
                            .Contains(keyword)));
            }

            return query
                .OrderByDescending(pp => pp.NgayLap)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }
        
        public PhieuPhat Add(PhieuPhat phieuPhat)
        {
            _context.PhieuPhats.Add(phieuPhat);
            _context.SaveChanges();
            return phieuPhat;
        }
        
        public PhieuPhat Update(PhieuPhat phieuPhat)
        {
            _context.PhieuPhats.Update(phieuPhat);
            _context.SaveChanges();
            return phieuPhat;
        }
        
        public PhieuPhat? Delete(int id)
        {
            var phieuPhat = GetById(id);
            if (phieuPhat == null) return null;
            _context.PhieuPhats.Remove(phieuPhat);
            _context.SaveChanges();
            return phieuPhat;
        }
    }
}