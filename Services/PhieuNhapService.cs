using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;

namespace LibraryManagementSystem.Services
{
    public class PhieuNhapService
    {
        private readonly PhieuNhapRepository _pnRepository;
        private readonly ChiTietPhieuNhapRepository _ctpnRepository;
        private readonly BanSaoSachRepository _bssRepository;
        private readonly SachRepository _sachRepository;
        public PhieuNhapService(PhieuNhapRepository pnRepository, ChiTietPhieuNhapRepository ctpnRepository, BanSaoSachRepository bssRepository, SachRepository sachRepository)
        {
            _pnRepository = pnRepository;
            _ctpnRepository = ctpnRepository;
            _bssRepository = bssRepository;
            _sachRepository = sachRepository;
        }
        public void AddPhieuNhap(PhieuNhap phieuNhap, List<(int IdSach, int SoLuong, decimal GiaTien)> chiTiet)
        {
            _pnRepository.Add(phieuNhap);

            foreach (var ct in chiTiet)
            {
                var ctpn = new ChiTietPhieuNhap
                {
                    IdPhieuNhap = phieuNhap.IdPhieuNhap,
                    IdSach = ct.IdSach,
                    SoLuong = ct.SoLuong,
                    GiaTien = ct.GiaTien
                };
                _ctpnRepository.Add(ctpn);

                var sach = _sachRepository.GetById(ct.IdSach);
                if (sach != null)
                {
                    sach.SoLuongBanSao += ct.SoLuong;
                    _sachRepository.Update(sach);
                }

                int existingCount = _bssRepository.GetCountBySach(ct.IdSach);
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