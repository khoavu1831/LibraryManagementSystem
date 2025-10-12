using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;

namespace LibraryManagementSystem.Services
{
    public class PhieuMuonService
    {
        private readonly PhieuMuonRepository _phieuMuonRepo;
        private readonly ChiTietPhieuMuonRepository _chiTietRepo;
        private readonly BanSaoSachRepository _banSaoSachRepo;
        private readonly TheThanhVienRepository _theThanhVienRepo;

        private const int SO_SACH_MUON_TOI_DA = 5;

        public PhieuMuonService(
            PhieuMuonRepository phieuMuonRepo,
            ChiTietPhieuMuonRepository chiTietRepo,
            BanSaoSachRepository banSaoSachRepo,
            TheThanhVienRepository theThanhVienRepo)
        {
            _phieuMuonRepo = phieuMuonRepo;
            _chiTietRepo = chiTietRepo;
            _banSaoSachRepo = banSaoSachRepo;
            _theThanhVienRepo = theThanhVienRepo;
        }

        public List<PhieuMuon> GetAllPhieuMuon() => _phieuMuonRepo.GetAllWithDetails();

        public PhieuMuon? GetPhieuMuonById(int id) => _phieuMuonRepo.GetByIdWithDetails(id);

        public List<PhieuMuon> GetPhieuMuonDangMuon(int idTheThanhVien)
            => _phieuMuonRepo.GetDangMuonByTheThanhVien(idTheThanhVien);

        public List<PhieuMuon> GetPhieuQuaHan() => _phieuMuonRepo.GetPhieuQuaHan();

        public List<PhieuMuon> SearchPhieuMuon(string keyword) => _phieuMuonRepo.Search(keyword);
        public List<ChiTietPhieuMuon> GetChiTietByIdPhieuMuon(int idPhieuMuon)
        {
            return _chiTietRepo.GetByPhieuMuonId(idPhieuMuon);
        }
        public List<ChiTietPhieuMuon> GetChiTietTraByPhieuMuon(int idPhieuMuon)
        {
            return _chiTietRepo.GetByPhieuMuonId(idPhieuMuon)
                .Where(ct => ct.NgayTra != null) 
                .ToList();
        }
        public List<ChiTietPhieuMuon> GetChiTietChuaTra(int idPhieuMuon)
            => _chiTietRepo.GetChuaTraByPhieuMuonId(idPhieuMuon);

        public PhieuMuon TaoPhieuMuon(
            int idNhanVien,
            int idTheThanhVien,
            DateTime ngayMuon,
            DateTime ngayHenTra,
            List<string> danhSachIdBanSaoSach)
        {
            var theThanhVien = _theThanhVienRepo.GetById(idTheThanhVien);
            if (theThanhVien == null)
                throw new Exception("Thẻ thành viên không tồn tại.");

            switch (theThanhVien.TrangThai)
            {
                case TheThanhVien.TrangThaiEnum.BiKhoa:
                    throw new Exception("Thẻ thành viên đã bị khóa.");
                case TheThanhVien.TrangThaiEnum.HetHan:
                    throw new Exception("Thẻ thành viên đã hết hạn.");
            }

            var phieuDangMuon = _phieuMuonRepo.GetDangMuonByTheThanhVien(idTheThanhVien);
            var soSachDangMuon = phieuDangMuon
                .SelectMany(pm => pm.ChiTietPhieuMuons ?? new List<ChiTietPhieuMuon>())
                .Count(ct => ct.NgayTra == null);

            if (soSachDangMuon + danhSachIdBanSaoSach.Count > SO_SACH_MUON_TOI_DA)
                throw new Exception($"Vượt quá số lượng sách cho phép mượn ({SO_SACH_MUON_TOI_DA} cuốn).");

            var coSachQuaHan = phieuDangMuon.Any(pm => pm.NgayHenTra < DateTime.Now.Date);
            if (coSachQuaHan)
                throw new Exception("Thành viên có sách quá hạn chưa trả.");

            var danhSachBanSao = new List<BanSaoSach>();
            foreach (var idBanSao in danhSachIdBanSaoSach)
            {
                var banSao = _banSaoSachRepo.GetById(idBanSao);
                if (banSao == null)
                    throw new Exception($"Bản sao sách {idBanSao} không tồn tại.");

                if (banSao.TinhTrangSach != BanSaoSach.TinhTrangSachEnum.Tot)
                {
                    string tinhTrang = banSao.TinhTrangSach switch
                    {
                        BanSaoSach.TinhTrangSachEnum.ChoMuon => "đang được mượn",
                        BanSaoSach.TinhTrangSachEnum.Hong => "bị hỏng",
                        BanSaoSach.TinhTrangSachEnum.Mat => "đã mất",
                        _ => "không sẵn sàng"
                    };
                    throw new Exception($"Bản sao sách {idBanSao} {tinhTrang}, không thể mượn.");
                }

                danhSachBanSao.Add(banSao);
            }

            var phieuMuon = new PhieuMuon
            {
                IdNhanVien = idNhanVien,
                IdTheThanhVien = idTheThanhVien,
                NgayMuon = ngayMuon,
                NgayHenTra = ngayHenTra,
                TrangThai = PhieuMuon.TrangThaiEnum.DangMuon
            };

            var phieuMuonSaved = _phieuMuonRepo.Add(phieuMuon);

            foreach (var banSao in danhSachBanSao)
            {
                _chiTietRepo.Add(new ChiTietPhieuMuon
                {
                    IdPhieuMuon = phieuMuonSaved.IdPhieuMuon,
                    IdBanSaoSach = banSao.IdBanSaoSach,
                    NgayTra = null,
                    TinhTrangTra = null
                });

                banSao.TinhTrangSach = BanSaoSach.TinhTrangSachEnum.ChoMuon;
                _banSaoSachRepo.Update(banSao);
            }

            return phieuMuonSaved;
        }

        public void TraSach(
            int idChiTietPhieuMuon,
            DateTime ngayTra,
            ChiTietPhieuMuon.TinhTrangTraEnum tinhTrangTra)
        {
            var chiTiet = _chiTietRepo.GetById(idChiTietPhieuMuon);
            if (chiTiet == null)
                throw new Exception("Chi tiết phiếu mượn không tồn tại.");

            if (chiTiet.NgayTra != null)
                throw new Exception("Sách này đã được trả trước đó.");

            var phieuMuon = _phieuMuonRepo.GetByIdWithDetails(chiTiet.IdPhieuMuon);
            if (phieuMuon == null)
                throw new Exception("Phiếu mượn không tồn tại.");

            chiTiet.NgayTra = ngayTra;
            chiTiet.TinhTrangTra = tinhTrangTra;
            _chiTietRepo.Update(chiTiet);

            var banSao = _banSaoSachRepo.GetById(chiTiet.IdBanSaoSach);
            if (banSao != null)
            {
                banSao.TinhTrangSach = tinhTrangTra switch
                {
                    ChiTietPhieuMuon.TinhTrangTraEnum.Tot => BanSaoSach.TinhTrangSachEnum.Tot,
                    ChiTietPhieuMuon.TinhTrangTraEnum.HuHong => BanSaoSach.TinhTrangSachEnum.Hong,
                    ChiTietPhieuMuon.TinhTrangTraEnum.Mat => BanSaoSach.TinhTrangSachEnum.Mat,
                    _ => BanSaoSach.TinhTrangSachEnum.Tot
                };
                _banSaoSachRepo.Update(banSao);
            }

            var tatCaDaTra = phieuMuon.ChiTietPhieuMuons?.All(ct => ct.NgayTra != null) ?? false;
            if (tatCaDaTra)
            {
                phieuMuon.TrangThai = PhieuMuon.TrangThaiEnum.DaTra;
                _phieuMuonRepo.Update(phieuMuon);
            }
        }

        public void TraNhieuSach(List<(int IdChiTietPhieuMuon, DateTime NgayTra, ChiTietPhieuMuon.TinhTrangTraEnum TinhTrangTra)> danhSachTra)
        {
            if (danhSachTra == null || danhSachTra.Count == 0)
                throw new Exception("Danh sách trả sách không được rỗng.");

            foreach (var item in danhSachTra)
            {
                TraSach(item.IdChiTietPhieuMuon, item.NgayTra, item.TinhTrangTra);
            }
        }


        public PhieuMuon SuaPhieuMuon(
            int idPhieuMuon,
            DateTime ngayHenTraMoi,
            List<string> danhSachIdBanSaoSachMoi)
        {
            var phieuMuon = _phieuMuonRepo.GetByIdWithDetails(idPhieuMuon);
            if (phieuMuon == null)
                throw new Exception("Phiếu mượn không tồn tại.");

            if (phieuMuon.TrangThai != PhieuMuon.TrangThaiEnum.DangMuon)
                throw new Exception("Chỉ có thể sửa phiếu đang mượn.");

            if (ngayHenTraMoi <= phieuMuon.NgayMuon)
                throw new Exception("Ngày hạn trả phải sau ngày mượn.");

            var chiTietHienTai = phieuMuon.ChiTietPhieuMuons?
                .Where(ct => ct.NgayTra == null)
                .ToList() ?? new List<ChiTietPhieuMuon>();

            var idBanSaoHienTai = chiTietHienTai.Select(ct => ct.IdBanSaoSach).ToHashSet();
            var idBanSaoMoi = danhSachIdBanSaoSachMoi.ToHashSet();

            var idBanSaoCanXoa = idBanSaoHienTai.Except(idBanSaoMoi).ToList();

            var idBanSaoCanThem = idBanSaoMoi.Except(idBanSaoHienTai).ToList();

            var theThanhVien = _theThanhVienRepo.GetById(phieuMuon.IdTheThanhVien);
            if (theThanhVien == null)
                throw new Exception("Thẻ thành viên không tồn tại.");

            var phieuDangMuonKhac = _phieuMuonRepo.GetDangMuonByTheThanhVien(phieuMuon.IdTheThanhVien)
                .Where(pm => pm.IdPhieuMuon != idPhieuMuon)
                .ToList();

            var soSachDangMuonKhac = phieuDangMuonKhac
                .SelectMany(pm => pm.ChiTietPhieuMuons ?? new List<ChiTietPhieuMuon>())
                .Count(ct => ct.NgayTra == null);

            if (soSachDangMuonKhac + danhSachIdBanSaoSachMoi.Count > SO_SACH_MUON_TOI_DA)
                throw new Exception($"Vượt quá số lượng sách cho phép mượn ({SO_SACH_MUON_TOI_DA} cuốn).");

            foreach (var idBanSao in idBanSaoCanXoa)
            {
                var chiTiet = chiTietHienTai.FirstOrDefault(ct => ct.IdBanSaoSach == idBanSao);
                if (chiTiet != null)
                {
                    _chiTietRepo.Delete(chiTiet.IdChiTietPhieuMuon);

                    var banSao = _banSaoSachRepo.GetById(idBanSao);
                    if (banSao != null)
                    {
                        banSao.TinhTrangSach = BanSaoSach.TinhTrangSachEnum.Tot;
                        _banSaoSachRepo.Update(banSao);
                    }
                }
            }

            foreach (var idBanSao in idBanSaoCanThem)
            {
                var banSao = _banSaoSachRepo.GetById(idBanSao);
                if (banSao == null)
                    throw new Exception($"Bản sao sách {idBanSao} không tồn tại.");

                if (banSao.TinhTrangSach != BanSaoSach.TinhTrangSachEnum.Tot)
                {
                    string tinhTrang = banSao.TinhTrangSach switch
                    {
                        BanSaoSach.TinhTrangSachEnum.ChoMuon => "đang được mượn",
                        BanSaoSach.TinhTrangSachEnum.Hong => "bị hỏng",
                        BanSaoSach.TinhTrangSachEnum.Mat => "đã mất",
                        _ => "không sẵn sàng"
                    };
                    throw new Exception($"Bản sao sách {idBanSao} {tinhTrang}, không thể mượn.");
                }

                _chiTietRepo.Add(new ChiTietPhieuMuon
                {
                    IdPhieuMuon = phieuMuon.IdPhieuMuon,
                    IdBanSaoSach = banSao.IdBanSaoSach,
                    NgayTra = null,
                    TinhTrangTra = null
                });

                banSao.TinhTrangSach = BanSaoSach.TinhTrangSachEnum.ChoMuon;
                _banSaoSachRepo.Update(banSao);
            }

            phieuMuon.NgayHenTra = ngayHenTraMoi;
            _phieuMuonRepo.Update(phieuMuon);

            return phieuMuon;
        }

        public int CapNhatTrangThaiQuaHan()
        {
            var phieuQuaHan = _phieuMuonRepo.GetPhieuQuaHan();
            foreach (var phieu in phieuQuaHan)
            {
                phieu.TrangThai = PhieuMuon.TrangThaiEnum.QuaHan;
                _phieuMuonRepo.Update(phieu);
            }
            return phieuQuaHan.Count;
        }
    }
}
