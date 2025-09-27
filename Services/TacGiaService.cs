using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;

namespace LibraryManagementSystem.Services
{
    public class TacGiaService
    {
        private readonly TacGiaRepository _tacGiaRepository;
        public TacGiaService(TacGiaRepository tacGiaRepository) => _tacGiaRepository = tacGiaRepository;
        public List<TacGia> GetAllTacGia() => _tacGiaRepository.GetAll();
        public TacGia? GetTacGiaById(int id) => _tacGiaRepository.GetById(id);
        public TacGia AddTacGia(TacGia tacGia) => _tacGiaRepository.Add(tacGia);
        public TacGia UpdateTacGia(TacGia tacGia) => _tacGiaRepository.Update(tacGia);
        public TacGia? DeleteTacGia(int id) => _tacGiaRepository.DeleteById(id);
    }
}