using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;

namespace LibraryManagementSystem.Services
{
    public class DocGiaService
    {
        private readonly DocGiaRepository _docGiaRepository;
        public DocGiaService(DocGiaRepository docGiaRepository)
        {
            _docGiaRepository = docGiaRepository;
        }

        // Lấy toàn bộ độc giả
        public List<DocGia> GetAllDocGia()
        {
            return _docGiaRepository.GetAll();
        }

        // Lấy độc giả theo id
        public DocGia? GetDocGiaById(int id)
        {
            return _docGiaRepository.GetDocGiaById(id);
        }

        // Thêm độc giả
        public DocGia AddDocGia(DocGia docGia)
        {
            return _docGiaRepository.Add(docGia);
        }

        // Sửa độc giả
        public DocGia UpdateDocGia(DocGia docGia)
        {
            return _docGiaRepository.Update(docGia);
        }

        // Xóa độc giả
        public DocGia? DeleteDocGia(int id)
        {
            return _docGiaRepository.DeleteById(id);
        }

        // Tìm kiếm độc giả theo id
        public DocGia? SearchDocGiaById(int id)
        {
            return _docGiaRepository
                .GetAll()
                .Where(d => d.IdDocGia == id)
                .FirstOrDefault();
        }
    }
}