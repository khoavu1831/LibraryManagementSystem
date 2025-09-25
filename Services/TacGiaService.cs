using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;

namespace LibraryManagementSystem.Services
{
    public class TacGiaService
    {
        private readonly TacGiaRepository _tacGiaRepository;
        public TacGiaService(TacGiaRepository tacGiaRepository)
        {
            _tacGiaRepository = tacGiaRepository;
        }

        // Lấy toàn bộ
        public List<TacGia> GetAllTacGia()
        {
            return _tacGiaRepository.GetAll();
        }

        // Lấy theo id
        public TacGia? GetTacGiaById(int id)
        {
            return _tacGiaRepository.GetById(id);
        }
        
        // Thêm
        // Sửa
        // Xóa 
    }
}