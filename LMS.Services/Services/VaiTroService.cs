using LMS.Entities;
using LMS.Repository;
using System.Text.RegularExpressions;

namespace LMS.Services
{
    public class VaiTroService
    {
        private readonly VaiTroRepository _vaiTroRepository;
        public VaiTroService(VaiTroRepository vaiTroRepository) => _vaiTroRepository = vaiTroRepository;
        public List<VaiTro> GetAllVaiTro() => _vaiTroRepository.GetAll();
        public VaiTro? GetVaiTroById(int id) => _vaiTroRepository.GetById(id);
        public VaiTro AddVaiTro(VaiTro vaiTro)
        {
            if (string.IsNullOrWhiteSpace(vaiTro.TenVaiTro))
                throw new Exception("Tên vai trò không được để trống.");

            if (!Regex.IsMatch(vaiTro.TenVaiTro, @"^[\p{L}\s]{1,20}$"))
                throw new Exception("Tên vai trò chỉ được chứa chữ cái và tối đa 20 ký tự.");

            return _vaiTroRepository.Add(vaiTro);
        }

        public VaiTro UpdateVaiTro(VaiTro vaiTro)
        {
            if (string.IsNullOrWhiteSpace(vaiTro.TenVaiTro))
                throw new Exception("Tên vai trò không được để trống.");

            if (!Regex.IsMatch(vaiTro.TenVaiTro, @"^[\p{L}\s]{1,20}$"))
                throw new Exception("Tên vai trò chỉ được chứa chữ cái và tối đa 20 ký tự.");

            return _vaiTroRepository.Update(vaiTro);
        }

        public void AssignQuyenToVaiTro(int idVaiTro, List<int> quyenIds)
        {
            if (idVaiTro <= 0)
                throw new ArgumentException("Id vai trò không hợp lệ.");
            if (quyenIds == null || !quyenIds.Any())
                throw new ArgumentException("Danh sách quyền không được rỗng.");

            // Kiểm tra tất cả quyenIds có tồn tại không (tùy chọn)
            var allQuyenIds = _vaiTroRepository._context.Quyens.Select(q => q.IdQuyen).ToList();
            var invalidIds = quyenIds.Where(id => !allQuyenIds.Contains(id)).ToList();
            if (invalidIds.Any())
                throw new ArgumentException($"Các quyền không tồn tại: {string.Join(", ", invalidIds)}");

            _vaiTroRepository.AssignQuyenToVaiTro(idVaiTro, quyenIds);
        }

        public VaiTro? DeleteVaiTro(int id) => _vaiTroRepository.DeleteById(id);
        public List<VaiTro> SearchVaiTro(string keyword) => _vaiTroRepository.search(keyword);
    }
}