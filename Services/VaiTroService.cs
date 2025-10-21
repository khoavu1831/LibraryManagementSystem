using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;
using System.Text.RegularExpressions;

namespace LibraryManagementSystem.Services
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

        public VaiTro? DeleteVaiTro(int id) => _vaiTroRepository.DeleteById(id);
    }
}