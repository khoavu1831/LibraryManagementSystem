using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;

namespace LibraryManagementSystem.Services
{
    public class SachService
    {
        private readonly SachRepository _sachRepository;
        public SachService(SachRepository sachRepository)
        {
            _sachRepository = sachRepository;
        }

        // Lấy tất cả sách
        public List<Sach> GetAllSach()
        {
            return _sachRepository.GetAll();
        }

        // Lấy sách theo id
        public Sach? GetSachById(string id)
        {
            return _sachRepository.GetById(id);
        }

        // Cập nhật sách
        public Sach UpdateSach(Sach sach)
        {
            return _sachRepository.Update(sach);
        }

        // Thêm sách
        public Sach AddSach(Sach sach)
        {
            return _sachRepository.Add(sach);
        }

        // Xóa sách
        public Sach? DeleteSach(string id)
        {
            return _sachRepository.DeleteById(id);
        }

        // Tìm kiếm sách theo id
        public Sach? SearchSachById(string id)
        {
            return _sachRepository
                .GetAll()
                .Where(s => s.IdSach == id)
                .FirstOrDefault();
        }
    }
}