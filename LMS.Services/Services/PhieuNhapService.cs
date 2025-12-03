using LMS.Entities;
using LMS.Models.Dtos;
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

        public List<string> ImportChiTietFromExcel(int idPhieuNhap, List<NhapSachExcelDto> rows)
        {
            if (_ctpnRepository == null || _bssRepository == null || _sachRepository == null)
                throw new InvalidOperationException("PhieuNhapService chưa được khởi tạo đầy đủ các repository để thực hiện import.");

            var errors = new List<string>();

            var phieuNhap = _pnRepository.GetById(idPhieuNhap);
            if (phieuNhap == null)
            {
                errors.Add("Không tìm thấy phiếu nhập.");
                return errors;
            }

            if (phieuNhap.TrangThai == PhieuNhap.TrangThaiEnum.DaHuy)
            {
                errors.Add("Phiếu nhập đã bị hủy, không thể thêm chi tiết.");
                return errors;
            }

            var validDetails = new List<(int IdSach, int SoLuong, decimal GiaTien, int RowNumber)>();

            for (int i = 0; i < rows.Count; i++)
            {
                var dto = rows[i];
                var rowNumber = i + 2;

                if (string.IsNullOrWhiteSpace(dto.MaSach))
                {
                    errors.Add($"Dòng {rowNumber}: Mã sách không được để trống.");
                    continue;
                }

                if (!dto.MaSach.StartsWith("S", StringComparison.OrdinalIgnoreCase) ||
                    !int.TryParse(dto.MaSach.Substring(1), out var idSach))
                {
                    errors.Add($"Dòng {rowNumber}: Mã sách '{dto.MaSach}' không hợp lệ. Định dạng đúng: S123.");
                    continue;
                }

                var sach = _sachRepository.GetById(idSach);
                if (sach == null)
                {
                    errors.Add($"Dòng {rowNumber}: Không tìm thấy sách với mã '{dto.MaSach}'.");
                    continue;
                }

                if (dto.SoLuongNhap <= 0)
                {
                    errors.Add($"Dòng {rowNumber}: Số lượng nhập phải lớn hơn 0.");
                    continue;
                }

                if (dto.GiaTien <= 0)
                {
                    errors.Add($"Dòng {rowNumber}: Giá tiền phải lớn hơn 0.");
                    continue;
                }

                validDetails.Add((idSach, dto.SoLuongNhap, dto.GiaTien, rowNumber));
            }

            if (validDetails.Count == 0)
            {
                if (errors.Count == 0)
                    errors.Add("Không có dòng dữ liệu hợp lệ để import.");
                return errors;
            }

            int tongSoLuongThem = 0;
            decimal tongTienThem = 0m;

            foreach (var detail in validDetails)
            {
                var ctpn = new ChiTietPhieuNhap
                {
                    IdPhieuNhap = phieuNhap.IdPhieuNhap,
                    IdSach = detail.IdSach,
                    SoLuong = detail.SoLuong,
                    GiaTien = detail.GiaTien
                };

                _ctpnRepository.Add(ctpn);

                var sach = _sachRepository.GetById(detail.IdSach);
                if (sach != null)
                {
                    sach.SoLuongBanSao += detail.SoLuong;
                    _sachRepository.Update(sach);
                }

                int existingCount = _bssRepository.GetCountBySach(detail.IdSach);

                for (int i = 1; i <= detail.SoLuong; i++)
                {
                    int nextIndex = existingCount + i;
                    string idBanSao = $"S{detail.IdSach}_{nextIndex}";
                    _bssRepository.Add(new BanSaoSach
                    {
                        IdBanSaoSach = idBanSao,
                        IdSach = detail.IdSach,
                        TinhTrangSach = BanSaoSach.TinhTrangSachEnum.Tot
                    });
                }

                tongSoLuongThem += detail.SoLuong;
                tongTienThem += detail.SoLuong * detail.GiaTien;
            }

            phieuNhap.SoLuongSach += tongSoLuongThem;
            phieuNhap.TongTienNhap += tongTienThem;
            _pnRepository.Update(phieuNhap);

            return errors;
        }
    }
}