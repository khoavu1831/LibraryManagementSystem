using Microsoft.EntityFrameworkCore;
using LMS.Data;
using LMS.Entities;
using System.Linq;

namespace LMS.Repository
{
    public class PhieuNhapRepository
    {
        private readonly LibraryDbContext _context;
        public PhieuNhapRepository(LibraryDbContext context) => _context = context;
        public List<PhieuNhap> GetAll()
        {
            return _context.PhieuNhaps
                .Include(pn => pn.NhanVien)
                .Include(pn => pn.NCC)
                .ToList();
        }
        public PhieuNhap? GetById(int id) => _context.PhieuNhaps.Find(id);
        public PhieuNhap Add(PhieuNhap phieuNhap)
        {
            _context.PhieuNhaps.Add(phieuNhap);
            _context.SaveChanges();
            return phieuNhap;
        }
        public PhieuNhap Update(PhieuNhap phieuNhap)
        {
            _context.PhieuNhaps.Update(phieuNhap);
            _context.SaveChanges();
            return phieuNhap;
        }
        public PhieuNhap? Delete(int id)
        {
            var phieuNhap = GetById(id);
            if (phieuNhap == null) return null;
            _context.PhieuNhaps.Remove(phieuNhap);
            _context.SaveChanges();
            return phieuNhap;
        }
        
        public List<PhieuNhap> Search(string keyword)
        {
            return _context.PhieuNhaps
                .Include(pn => pn.NCC)
                .Include(pn => pn.NhanVien)
                .Where(pn =>
                    (pn.NCC!.TenNCC != null && pn.NCC.TenNCC.Contains(keyword)) ||
                    (pn.NhanVien!.TenNhanVien != null && pn.NhanVien.TenNhanVien.Contains(keyword)))
                .OrderByDescending(pn => pn.NgayNhap)
                .ToList();
        }
        
        /// <summary>
        /// Đếm tổng số phiếu nhập
        /// </summary>
        public int GetCount() => _context.PhieuNhaps.Count();
        
        /// <summary>
        /// Đếm tổng số phiếu nhập theo filter
        /// </summary>
        public int GetCountByFilter(PhieuNhap.TrangThaiEnum? trangThai = null, string? keyword = null)
        {
            var query = _context.PhieuNhaps
                .Include(pn => pn.NCC)
                .Include(pn => pn.NhanVien)
                .AsQueryable();

            // Filter trạng thái
            if (trangThai.HasValue)
                query = query.Where(pn => pn.TrangThai == trangThai.Value);

            // Filter keyword (tên NCC HOẶC tên nhân viên)
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(pn =>
                    (pn.NCC!.TenNCC != null && pn.NCC.TenNCC.Contains(keyword)) ||
                    (pn.NhanVien!.TenNhanVien != null && pn.NhanVien.TenNhanVien.Contains(keyword)));
            }

            return query.Count();
        }
        
        /// <summary>
        /// Lấy phiếu nhập có phân trang với filter
        /// </summary>
        public List<PhieuNhap> GetByPageWithFilter(int page, int pageSize, PhieuNhap.TrangThaiEnum? trangThai = null, string? keyword = null)
        {
            var query = _context.PhieuNhaps
                .Include(pn => pn.NCC)
                .Include(pn => pn.NhanVien)
                .AsNoTracking()
                .AsQueryable();

            // Filter trạng thái
            if (trangThai.HasValue)
                query = query.Where(pn => pn.TrangThai == trangThai.Value);

            // Filter keyword (tên NCC HOẶC tên nhân viên)
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(pn =>
                    (pn.NCC!.TenNCC != null && pn.NCC.TenNCC.Contains(keyword)) ||
                    (pn.NhanVien!.TenNhanVien != null && pn.NhanVien.TenNhanVien.Contains(keyword)));
            }

            return query
                .OrderBy(pn => pn.NgayNhap)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }
        
        /// <summary>
        /// Lấy tất cả phiếu nhập với Include đầy đủ (dùng cho Excel export)
        /// </summary>
        public List<PhieuNhap> GetAllWithIncludes()
        {
            return _context.PhieuNhaps
                .Include(pn => pn.NCC)
                .Include(pn => pn.NhanVien)
                .Include(pn => pn.ChiTietPhieuNhaps!)
                    .ThenInclude(ct => ct.Sach)
                .AsNoTracking()
                .OrderByDescending(pn => pn.NgayNhap)
                .ToList();
        }
    }
}