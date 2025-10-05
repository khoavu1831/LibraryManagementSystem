using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;

namespace LibraryManagementSystem.Services
{
    public class SachService
    {
        private readonly SachRepository _sachRepository;
        public SachService(SachRepository sachRepository) => _sachRepository = sachRepository;
        public List<Sach> GetAllSach() => _sachRepository.GetAll();
        public Sach AddSach(Sach sach) => _sachRepository.Add(sach);
    }
}