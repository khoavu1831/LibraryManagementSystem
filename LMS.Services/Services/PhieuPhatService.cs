using LMS.Entities;
using LMS.Repository;

namespace LMS.Services
{
    public class PhieuPhatService
    {
        private readonly PhieuPhatRepository _phieuPhatRepository;
        
        public PhieuPhatService(PhieuPhatRepository phieuPhatRepository) 
            => _phieuPhatRepository = phieuPhatRepository;

        /// <summary>
        /// Lấy tất cả phiếu phạt với Include đầy đủ (dùng cho Excel export)
        /// </summary>
        public List<PhieuPhat> GetAllPhieuPhat() 
            => _phieuPhatRepository.GetAllWithIncludes();
        
        /// <summary>
        /// Lấy phiếu phạt theo ID
        /// </summary>
        public PhieuPhat? GetPhieuPhatById(int id) 
            => _phieuPhatRepository.GetById(id);
        
        /// <summary>
        /// Đếm tổng số phiếu phạt
        /// </summary>
        public int GetTotalRecords() 
            => _phieuPhatRepository.GetCount();
        
        /// <summary>
        /// Đếm tổng số phiếu phạt theo filter
        /// </summary>
        public int GetTotalRecordsByFilter(PhieuPhat.TrangThaiEnum? trangThai = null, string? keyword = null) 
            => _phieuPhatRepository.GetCountByFilter(trangThai, keyword);
        
        /// <summary>
        /// Lấy phiếu phạt có phân trang với filter
        /// </summary>
        public List<PhieuPhat> GetByPageWithFilter(int page, int pageSize, PhieuPhat.TrangThaiEnum? trangThai = null, string? keyword = null) 
            => _phieuPhatRepository.GetByPageWithFilter(page, pageSize, trangThai, keyword);
        
        /// <summary>
        /// Hủy phiếu phạt (chỉ cho phép hủy phiếu ở trạng thái Chưa thu)
        /// </summary>
        public void HuyPhieuPhat(int idPhieuPhat)
        {
            var pp = _phieuPhatRepository.GetById(idPhieuPhat);
            if (pp == null)
                throw new Exception("Không tìm thấy phiếu phạt.");

            if (pp.TrangThai != PhieuPhat.TrangThaiEnum.ChuaThu)
                throw new Exception("Phiếu phạt không ở trạng thái Chưa thu.");

            pp.TrangThai = PhieuPhat.TrangThaiEnum.DaHuy;
            _phieuPhatRepository.Update(pp);
        }
        
        /// <summary>
        /// Thanh toán phiếu phạt (đổi trạng thái từ Chưa thu sang Đã thu)
        /// </summary>
        public void ThanhToanPhieuPhat(int idPhieuPhat)
        {
            var pp = _phieuPhatRepository.GetById(idPhieuPhat);
            if (pp == null)
                throw new Exception("Không tìm thấy phiếu phạt.");

            if (pp.TrangThai != PhieuPhat.TrangThaiEnum.ChuaThu)
                throw new Exception("Phiếu phạt không ở trạng thái Chưa thu.");

            pp.TrangThai = PhieuPhat.TrangThaiEnum.DaThu;
            _phieuPhatRepository.Update(pp);
        }
    }
}

