using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;

namespace LibraryManagementSystem.Services
{
    public class NCCService
    {
        private readonly NCCRepository _nccRepository;
        public NCCService(NCCRepository nccRepository)
        {
            _nccRepository = nccRepository;
        }

        // Lấy toàn bộ ncc
        public List<NCC> GetAllNCC()
        {
            return _nccRepository.GetAll();
        }

        // Lấy ncc theo id
        public NCC? GetNCCById(int id)
        {
            return _nccRepository.GetById(id);
        }

        // Thêm ncc
        public NCC AddNCC(NCC ncc)
        {
            return _nccRepository.Add(ncc);
        }

        // Sửa ncc
        public NCC UpdateNCC(NCC ncc)
        {
            return _nccRepository.Update(ncc);
        }

        // Xóa ncc
        public NCC? DeleteNCC(int id)
        {
            return _nccRepository.DeleteById(id);
        }

        // Tìm kiếm ncc theo id
        public NCC? SearchNCCById(int id)
        {
            return _nccRepository
                .GetAll()
                .Where(n => n.IdNCC == id)
                .FirstOrDefault();
        }
    }
}