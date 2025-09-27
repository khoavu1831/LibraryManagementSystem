using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;

namespace LibraryManagementSystem.Services
{
    public class NXBService
    {
        private readonly NXBRepository _nxbRepository;
        public NXBService(NXBRepository nxbRepository) => _nxbRepository = nxbRepository;
        public List<NXB> GetAllNXB() => _nxbRepository.GetAll();
        public NXB? GetNXBById(int id) => _nxbRepository.GetById(id);
        public NXB AddNXB(NXB nxb) => _nxbRepository.Add(nxb);
        public NXB UpdateNXB(NXB nxb) => _nxbRepository.Update(nxb);
        public NXB? DeleteNXB(int id) => _nxbRepository.DeleteById(id);
    }
}