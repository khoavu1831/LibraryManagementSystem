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
        public PhieuNhapService(PhieuNhapRepository pnRepository, ChiTietPhieuNhapRepository ctpnRepository, BanSaoSachRepository bssRepository)
        {
            _pnRepository = pnRepository;
            _ctpnRepository = ctpnRepository;
            _bssRepository = bssRepository;
        }
        public void NhapSach(PhieuNhap pn, List<ChiTietPhieuNhap> ctpnList)
        {
            _pnRepository.Add(pn);

            foreach (var ctpn in ctpnList)
            {
                ctpn.IdPhieuNhap = pn.IdPhieuNhap;
                _ctpnRepository.Add(ctpn);

                int lastIndex = _bssRepository.GetCountBySach(ctpn.IdSach);
                var bssList = new List<BanSaoSach>();

                for (int i = 1; i <= ctpn.SoLuong; i++)
                {
                    bssList.Add(new BanSaoSach
                    {
                        IdBanSaoSach = $"S{ctpn.IdSach}_{lastIndex + i}",
                        IdSach = ctpn.IdSach,
                        TinhTrangSach = BanSaoSach.TinhTrangSachEnum.Tot
                    });
                }

                _bssRepository.AddRange(bssList);
            }
        }
    }
}