using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;

namespace LibraryManagementSystem.Services
{
    public class DocGiaService
    {
        private readonly DocGiaRepository _docGiaRepository;
        public DocGiaService(DocGiaRepository docGiaRepository) => _docGiaRepository = docGiaRepository;
        public List<DocGia> GetAllDocGia() => _docGiaRepository.GetAll();
        public DocGia? GetDocGiaById(int id) => _docGiaRepository.GetById(id);
        public DocGia AddDocGia(DocGia docGia) => _docGiaRepository.Add(docGia);
        public DocGia UpdateDocGia(DocGia docGia) => _docGiaRepository.Update(docGia);
        public DocGia? DeleteDocGia(int id) => _docGiaRepository.DeleteById(id);
    }
}