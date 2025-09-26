using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository.Interfaces;

namespace LibraryManagementSystem.Services
{
    public class NXBService
    {
        private readonly IRepository<NXB> _nxbRepository;
        public NXBService(IRepository<NXB> nxbRepository)
        {
            _nxbRepository = nxbRepository;
        }
        public async Task<IEnumerable<NXB>> GetAllAsync() => await _nxbRepository.GetAllAsync();
        public async Task<NXB?> GetByIdAsync(int id) => await _nxbRepository.GetByIdAsync(id);
        public async Task<NXB> AddAsync(NXB nxb) => await _nxbRepository.AddAsync(nxb);
        public async Task<NXB> UpdateAsync(NXB nxb) => await _nxbRepository.UpdateAsync(nxb);
        public async Task<NXB?> DeleteByIdAsync(int id) => await _nxbRepository.DeleteByIdAsync(id);
    }
}