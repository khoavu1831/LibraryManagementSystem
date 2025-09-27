using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;

namespace LibraryManagementSystem.Services
{
    public class VaiTroService
    {
        private readonly VaiTroRepository _vaiTroRepository;
        public VaiTroService(VaiTroRepository vaiTroRepository) => _vaiTroRepository = vaiTroRepository;
        public List<VaiTro> GetAllVaiTro() => _vaiTroRepository.GetAll();
        public VaiTro? GetVaiTroById(int id) => _vaiTroRepository.GetById(id);
        public VaiTro AddVaiTro(VaiTro vaiTro) => _vaiTroRepository.Add(vaiTro);
        public VaiTro UpdateVaiTro(VaiTro vaiTro) => _vaiTroRepository.Update(vaiTro);
        public VaiTro? DeleteVaiTro(int id) => _vaiTroRepository.DeleteById(id);
    }
}