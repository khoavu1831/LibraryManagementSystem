using LMS.Data;
using LMS.Entities;
using Microsoft.EntityFrameworkCore;


namespace LMS.Repository
{
    public class VaiTroRepository
    {
        public readonly LibraryDbContext _context;
        public VaiTroRepository(LibraryDbContext context) => _context = context;
        public List<VaiTro> GetAll() => _context.VaiTros.ToList();
        public VaiTro? GetById(int id) => _context.VaiTros.Find(id);
        public VaiTro Add(VaiTro vaiTro)
        {
            _context.VaiTros.Add(vaiTro);
            _context.SaveChanges();
            return vaiTro;
        }
        public VaiTro Update(VaiTro vaiTro)
        {
            _context.VaiTros.Update(vaiTro);
            _context.SaveChanges();
            return vaiTro;
        }
        public VaiTro? DeleteById(int id)
        {
            var entity = _context.VaiTros.Find(id);
            if (entity != null)
            {
                _context.VaiTros.Remove(entity);
                _context.SaveChanges(); 
                return entity;
            }
            return null;
        }

        public async Task<List<string>> GetPermissionsByRoleIdAsync(int roleId)
        {
            var permissions = await _context.VaiTros
                .Include(v => v.Quyens)
                .Where(v => v.IdVaiTro == roleId)
                .SelectMany(v => v.Quyens)
                .Select(q => q.MaQuyen)
                .ToListAsync();

            return permissions;
        }

        public List<VaiTro> search(string keyword) =>
            _context.VaiTros
                .AsNoTracking()
                .Where(vt => (vt.TenVaiTro ?? "").ToLower().Contains(keyword.ToLower()))
                .ToList();

        public void AssignQuyenToVaiTro(int idVaiTro, List<int> quyenIds)
        {
            var vaiTro = GetById(idVaiTro);
            if (vaiTro == null)
            {
                throw new KeyNotFoundException($"Không tìm thấy vai trò với Id = {idVaiTro}");
            }

            if(vaiTro.Quyens != null)
            {
                vaiTro.Quyens.Clear();
            }
                
            foreach (var quyenId in quyenIds.Distinct())
            {
                var quyen = _context.Quyens.Find(quyenId);
                if (quyen != null)
                {
                    vaiTro.Quyens.Add(quyen);
                }
            }

            Update(vaiTro);
        }
    }
}