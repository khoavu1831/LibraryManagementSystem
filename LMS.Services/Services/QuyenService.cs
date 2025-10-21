using LMS.Entities;
using LMS.Repository;

namespace LMS.Services
{
    public class QuyenService
    {
        private readonly QuyenRepository _quyenRepository;
        public QuyenService(QuyenRepository quyenRepository) => _quyenRepository = quyenRepository;
        public List<Quyen> GetAllQuyen() => _quyenRepository.GetAll();
        public Quyen? GetQuyenById(int id) => _quyenRepository.GetById(id);
        public Quyen AddQuyen(Quyen quyen) => _quyenRepository.Add(quyen);
        public Quyen UpdateQuyen(Quyen quyen) => _quyenRepository.Update(quyen);
        public Quyen? DeleteQuyen(int id) => _quyenRepository.DeleteById(id);
    }
}