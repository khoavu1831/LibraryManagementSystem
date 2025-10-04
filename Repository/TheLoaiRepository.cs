using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Repository
{
    public class TheLoaiRepository
    {
        private readonly LibraryDbContext _context;
        public TheLoaiRepository(LibraryDbContext context) => _context = context;
        public List<TheLoai> GetAll() => _context.TheLoais.ToList();
        public TheLoai? GetById(int id) => _context.TheLoais.Find(id);

        // AsNoTracking(): Tối ưu hiệu suất khi chỉ đọc dữ liệu, không cần theo dõi thay đổi
        public TheLoai? GetByName(string name) => 
            _context.TheLoais
             .AsNoTracking()
             .FirstOrDefault(tl => tl.TenTheloai == name);
        public TheLoai Add(TheLoai theLoai)
        {
            _context.TheLoais.Add(theLoai);
            _context.SaveChanges();
            return theLoai;
        }
        public TheLoai Update(TheLoai theLoai)
        {
            // Tránh lỗi theo dõi nhiều thực thể cùng một Id:
            var existingEntity = _context.TheLoais.Local.FirstOrDefault(e => e.IdTheLoai == theLoai.IdTheLoai);
            if (existingEntity != null)
            {
                _context.Entry(existingEntity).State = EntityState.Detached;
            }

            _context.TheLoais.Update(theLoai);
            _context.SaveChanges();
            return theLoai;
        }
        public TheLoai? DeleteById(int id)
        {
            var theLoai = GetById(id);
            if (theLoai == null) return null;
            _context.TheLoais.Remove(theLoai);
            _context.SaveChanges();
            return theLoai;
        }
        public List<TheLoai> Search(string keyword) =>
            _context.TheLoais
                .AsNoTracking()
                .Where(tl => (tl.TenTheloai ?? "").ToLower().Contains(keyword.ToLower()))
                .ToList();
    }
}