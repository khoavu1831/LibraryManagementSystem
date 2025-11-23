using LMS.Entities;
using LMS.Repository;

namespace LMS.Services
{
    public class PhieuNhapService
    {
        private readonly PhieuNhapRepository _pnRepository;
        private readonly ChiTietPhieuNhapRepository? _ctpnRepository;
        private readonly BanSaoSachRepository? _bssRepository;
        private readonly SachRepository? _sachRepository;
        public PhieuNhapService(PhieuNhapRepository pnRepository)
        {
            _pnRepository = pnRepository;
        }
        public PhieuNhapService(PhieuNhapRepository pnRepository, ChiTietPhieuNhapRepository ctpnRepository, BanSaoSachRepository bssRepository, SachRepository sachRepository)
        {
            _pnRepository = pnRepository;
            _ctpnRepository = ctpnRepository;
            _bssRepository = bssRepository;
            _sachRepository = sachRepository;
        }
        public List<PhieuNhap> GetAllPhieuNhap() => _pnRepository.GetAll();
        
        /// <summary>
        /// Lấy tất cả phiếu nhập với Include đầy đủ (dùng cho Excel export)
        /// </summary>
        public List<PhieuNhap> GetAllPhieuNhapWithIncludes() => _pnRepository.GetAllWithIncludes();
        
        /// <summary>
        /// Đếm tổng số phiếu nhập
        /// </summary>
        public int GetTotalRecords() => _pnRepository.GetCount();
        
        /// <summary>
        /// Đếm tổng số phiếu nhập theo filter
        /// </summary>
        public int GetTotalRecordsByFilter(PhieuNhap.TrangThaiEnum? trangThai = null, string? keyword = null) 
            => _pnRepository.GetCountByFilter(trangThai, keyword);
        
        /// <summary>
        /// Lấy phiếu nhập có phân trang với filter
        /// </summary>
        public List<PhieuNhap> GetByPageWithFilter(int page, int pageSize, PhieuNhap.TrangThaiEnum? trangThai = null, string? keyword = null) 
            => _pnRepository.GetByPageWithFilter(page, pageSize, trangThai, keyword);
        
        public List<PhieuNhap> TimKiemPhieuNhap(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return _pnRepository.GetAll();
            
            return _pnRepository.Search(keyword);
        }
        
        public void HuyPhieuNhap(int idPhieuNhap)
        {
            var phieuNhap = _pnRepository.GetById(idPhieuNhap);
            if (phieuNhap == null)
                throw new Exception("Không tìm thấy phiếu nhập!");
            
            if (phieuNhap.TrangThai == PhieuNhap.TrangThaiEnum.DaHuy)
                throw new Exception("Phiếu nhập đã được hủy trước đó!");
            
            phieuNhap.TrangThai = PhieuNhap.TrangThaiEnum.DaHuy;
            _pnRepository.Update(phieuNhap);
        }
        
        public void AddPhieuNhap(PhieuNhap phieuNhap, List<(int IdSach, int SoLuong, decimal GiaTien)> chiTiet)
        {
            _pnRepository?.Add(phieuNhap);

            foreach (var ct in chiTiet)
            {
                var ctpn = new ChiTietPhieuNhap
                {
                    IdPhieuNhap = phieuNhap.IdPhieuNhap,
                    IdSach = ct.IdSach,
                    SoLuong = ct.SoLuong,
                    GiaTien = ct.GiaTien
                };
                _ctpnRepository?.Add(ctpn);

                var sach = _sachRepository?.GetById(ct.IdSach);
                if (sach != null)
                {
                    sach.SoLuongBanSao += ct.SoLuong;
                    _sachRepository?.Update(sach);
                }

                int existingCount = _bssRepository!.GetCountBySach(ct.IdSach);
                
                // Sinh bản sao sách
                for (int i = 1; i <= ct.SoLuong; i++)
                {
                    int nextIndex = existingCount + i;
                    string idBanSao = $"S{ct.IdSach}_{nextIndex}";
                    _bssRepository.Add(new BanSaoSach
                    {
                        IdBanSaoSach = idBanSao,
                        IdSach = ct.IdSach,
                        TinhTrangSach = BanSaoSach.TinhTrangSachEnum.Tot
                    });
                }
            }
        }
    }
}