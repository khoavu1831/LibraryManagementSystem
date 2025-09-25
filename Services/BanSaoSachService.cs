using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;

namespace LibraryManagementSystem.Services
{
    public class BanSaoSachService
    {
        private readonly BanSaoSachRepository _banSaoSachRepository;
        public BanSaoSachService(BanSaoSachRepository banSaoSachRepository)
        {
            _banSaoSachRepository = banSaoSachRepository;
        }

        // Lấy toàn bộ 
        public List<BanSaoSach> GetAllBanSaoSach()
        {
            return _banSaoSachRepository.GetAll();
        }

        // Lấy theo id
        public BanSaoSach? GetBanSaoSachById(string id)
        {
            return _banSaoSachRepository.GetById(id);
        }

        // Thêm 
        public BanSaoSach AddBanSaoSach(BanSaoSach banSaoSach)
        {
            return _banSaoSachRepository.Add(banSaoSach);
        }

        // Sửa 
        // Xóa 
        // Tìm kiếm
        

    }

}