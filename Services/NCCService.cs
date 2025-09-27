using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;

namespace LibraryManagementSystem.Services
{
    public class NCCService
    {
        private readonly NCCRepository _nccRepository;
        public NCCService(NCCRepository nccRepository) => _nccRepository = nccRepository;
        public List<NCC> GetAllNCC() => _nccRepository.GetAll();
        public NCC? GetNCCById(int id) => _nccRepository.GetById(id);
        public NCC AddNCC(NCC ncc) => _nccRepository.Add(ncc);
        public NCC UpdateNCC(NCC ncc) => _nccRepository.Update(ncc);
        public NCC? DeleteNCC(int id) => _nccRepository.DeleteById(id);
    }
}