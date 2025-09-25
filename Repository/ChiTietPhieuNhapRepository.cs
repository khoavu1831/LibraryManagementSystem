using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;

namespace LibraryManagementSystem.Repository
{
    public class ChiTietPhieuNhapRepository
    {
        private readonly LibraryDbContext _context;
        public ChiTietPhieuNhapRepository(LibraryDbContext context)
        {
            _context = context;
        }
        public List<ChiTietPhieuNhap> GetAll()
        {
            return _context.ChiTietPhieuNhaps.ToList();
        }
        public ChiTietPhieuNhap? GetById(int id)
        {
            return _context.ChiTietPhieuNhaps.Find(id);
        }
        public ChiTietPhieuNhap Add(ChiTietPhieuNhap ctpn)
        {
            _context.ChiTietPhieuNhaps.Add(ctpn);
            _context.SaveChanges();
            return ctpn;
        }
        public ChiTietPhieuNhap Update(ChiTietPhieuNhap ctpn)
        {
            _context.ChiTietPhieuNhaps.Update(ctpn);
            _context.SaveChanges();
            return ctpn;
        }
        public ChiTietPhieuNhap? Delete(int id)
        {
            var ctpn = GetById(id);
            if (ctpn == null) return null;
            _context.ChiTietPhieuNhaps.Remove(ctpn);
            _context.SaveChanges();
            return ctpn;
        }
    }
}