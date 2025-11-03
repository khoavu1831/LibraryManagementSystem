using LMS.Data;
using LMS.Entities;

namespace LMS.Repository
{
    public class TaiKhoanRepository
    {
        private readonly LibraryDbContext _context;
        public TaiKhoanRepository(LibraryDbContext context) => _context = context;

        public List<TaiKhoan> GetAll() => _context.TaiKhoans.ToList();
        public TaiKhoan? GetById(int id) => _context.TaiKhoans.Find(id);
        public TaiKhoan? Authenticate(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return null;

            return _context.TaiKhoans
                .FirstOrDefault(tk => tk.TenTaiKhoan == username && tk.MatKhau == password);
        }

        public TaiKhoan Add(TaiKhoan taiKhoan)
        {
            _context.TaiKhoans.Add(taiKhoan);
            _context.SaveChanges();
            return taiKhoan;
        }
        public TaiKhoan Update(TaiKhoan taiKhoan)
        {
            _context.TaiKhoans.Update(taiKhoan);
            _context.SaveChanges();
            return taiKhoan;
        }
        public TaiKhoan? Delete(int id)
        {
            var taiKhoan = GetById(id);
            if (taiKhoan == null) return null;
            _context.TaiKhoans.Remove(taiKhoan);
            _context.SaveChanges();
            return taiKhoan;
        }

        public List<int> GetQuyenIdsByVaiTroId(int vaiTroId)
        {
            // SQL raw: SELECT IdQuyen WHERE IdVaiTro = @p0 (parameter @p0 để tránh injection)
            var sql = "SELECT IdQuyen FROM vaitro_quyen WHERE IdVaiTro = {0}";  // Hoặc dùng @p0 cho EF Core cũ

            // Dùng Database.SqlQueryRaw<int>: Trả về IQueryable<int>, rồi ToList()
            return _context.Database
                .SqlQueryRaw<int>(sql, vaiTroId)  // {0} thay bằng vaiTroId an toàn
                .ToList();
        }
    }
}