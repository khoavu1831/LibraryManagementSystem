using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;

namespace LibraryManagementSystem.Services
{
    public class MucPhatService
    {
        private readonly MucPhatRepository _mucPhatRepository;
        public MucPhatService(MucPhatRepository mucPhatRepository) => _mucPhatRepository = mucPhatRepository;
        public List<MucPhat> GetAllMucPhat() => _mucPhatRepository.GetAll();
        public MucPhat? GetMucPhatById(int id) => _mucPhatRepository.GetById(id);
        public MucPhat AddMucPhat(MucPhat MucPhat) => _mucPhatRepository.Add(MucPhat);
        public MucPhat UpdateMucPhat(MucPhat MucPhat) => _mucPhatRepository.Update(MucPhat);
        public MucPhat? DeleteMucPhat(int id) => _mucPhatRepository.DeleteById(id);
    }
}