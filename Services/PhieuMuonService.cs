using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;

namespace LibraryManagementSystem.Services
{
    public class PhieuMuonService
    {
        private readonly PhieuMuonRepository _pmRepository;
        private readonly ChiTietPhieuMuonRepository? _ctpmRepository;
        private readonly BanSaoSachRepository? _bssRepository;
        public PhieuMuonService(PhieuMuonRepository pmRepository)
        {
            _pmRepository = pmRepository;
        }
        public PhieuMuonService(PhieuMuonRepository pmRepository, ChiTietPhieuMuonRepository ctpmRepository, BanSaoSachRepository bssRepository)
        {
            _pmRepository = pmRepository;
            _ctpmRepository = ctpmRepository;
            _bssRepository = bssRepository;
        }
        public List<PhieuMuon> GetAllPhieuMuon() => _pmRepository.GetAll();
        public PhieuMuon AddPhieuMuon(PhieuMuon pm, List<string> danhSachBanSao)
        {
            // 1. Thêm phiếu mượn
            var addedPhieu = _pmRepository.Add(pm);

            // 2. Tạo chi tiết phiếu mượn cho từng bản sao
            foreach (var idBanSao in danhSachBanSao)
            {
                var ct = new ChiTietPhieuMuon
                {
                    IdPhieuMuon = addedPhieu.IdPhieuMuon,
                    IdBanSaoSach = idBanSao,
                    NgayTra = null,
                    TinhTrangTra = null
                };
                _ctpmRepository!.Add(ct);

                // 3. Cập nhật trạng thái bản sao
                var bss = _bssRepository!.GetById(idBanSao);
                if (bss != null)
                {
                    bss.TinhTrangSach = BanSaoSach.TinhTrangSachEnum.ChoMuon;
                    _bssRepository.Update(bss);
                }
            }

            return addedPhieu;
        }
    }
}