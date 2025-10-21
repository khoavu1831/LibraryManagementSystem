using LMS.Entities;
using LMS.Repository;

namespace LMS.Services
{
    public class SachService
    {
        private readonly SachRepository _sachRepository;
        public SachService(SachRepository sachRepository) => _sachRepository = sachRepository;
        public List<Sach> GetAllSach() => _sachRepository.GetAll();
        public Sach? GetSachById(int id) => _sachRepository.GetById(id);
        public Sach AddSach(Sach sach) => _sachRepository.Add(sach);
    }
}