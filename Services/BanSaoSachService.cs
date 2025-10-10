using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;

namespace LibraryManagementSystem.Services
{
    public class BanSaoSachService
    {
        private readonly BanSaoSachRepository _bssRepository;
        public BanSaoSachService(BanSaoSachRepository bssRepository) => _bssRepository = bssRepository;
        public List<BanSaoSach> GetAllBanSaoSach() => _bssRepository.GetAll();
        public BanSaoSach? GetBanSaoSachById(string id) => _bssRepository.GetById(id);
        public List<BanSaoSach> GetBanSaoSachByPage(int page, int pageSize) => _bssRepository.GetByPage(page, pageSize);
        public int GetTotalRecords() => _bssRepository.GetCount();
        public BanSaoSach AddBanSaoSach(BanSaoSach BanSaoSach) => _bssRepository.Add(BanSaoSach);
        public BanSaoSach UpdateBanSaoSach(BanSaoSach BanSaoSach) => _bssRepository.Update(BanSaoSach);
        public BanSaoSach? DeleteBanSaoSach(string id) => _bssRepository.DeleteById(id);
    }
}