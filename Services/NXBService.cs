using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;

namespace LibraryManagementSystem.Services
{
    public class NXBService
    {
        private readonly NXBRepository _nxbRepository;
        public NXBService(NXBRepository nxbRepository)
        {
            _nxbRepository = nxbRepository;
        }

        // Lấy toàn bộ NXB
        public List<NXB> GetAllNXB()
        {
            return _nxbRepository.GetAll();
        }

        // Lấy NXB bằng id
        public NXB? GetNXBById(int id)
        {
            return _nxbRepository.GetById(id);
        }

        // Thêm NXB
        public NXB AddNXB(NXB nxb)
        {
            return _nxbRepository.Add(nxb);
        }

        // Sửa NXB
        public NXB UpdateNXB(NXB nxb)
        {
            return _nxbRepository.Update(nxb);
        }

        // Tìm NXB theo id
        public NXB? SearchNXBById(int id)
        {
            return _nxbRepository
                .GetAll()
                .Where(n => n.IdNXB == id)
                .FirstOrDefault();
        }

        // Xóa NXB theo id
        public NXB? DeleteNXB(int id)
        {
            return _nxbRepository.DeleteById(id);
        }
    }
}