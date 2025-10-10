using System.Data.Entity;
using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;

namespace LibraryManagementSystem.Repository
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
    }
}