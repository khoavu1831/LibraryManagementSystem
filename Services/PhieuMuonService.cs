using LibraryManagementSystem.Data;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Helpers;
using LibraryManagementSystem.Repository;
using Microsoft.EntityFrameworkCore;

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
        public PhieuMuon? GetPhieuMuonChiTiet(int idPhieuMuon) => _pmRepository.GetChiTiet(idPhieuMuon);
        public PhieuMuon AddPhieuMuon(PhieuMuon pm, List<string> danhSachBanSao)
        {
            // Thêm phiếu mượn
            var addedPhieu = _pmRepository.Add(pm);

            // Tạo chi tiết phiếu mượn cho từng bản sao
            foreach (var idBanSao in danhSachBanSao)
            {
                var ct = new ChiTietPhieuMuon
                {
                    IdPhieuMuon = addedPhieu.IdPhieuMuon,
                    IdBanSaoSach = idBanSao,
                    NgayTra = null,
                    TinhTrangTra = ChiTietPhieuMuon.TinhTrangTraEnum.ChuaTra
                };
                _ctpmRepository!.Add(ct);

                // Cập nhật trạng thái bản sao
                var bss = _bssRepository!.GetById(idBanSao);
                if (bss != null)
                {
                    bss.TinhTrangSach = BanSaoSach.TinhTrangSachEnum.ChoMuon;
                    _bssRepository.Update(bss);
                }
            }

            return addedPhieu;
        }
        public void TraSach(int idChiTietPhieuMuon, string tinhTrangTra)
        {
            var ctp = _pmRepository.GetChiTietById(idChiTietPhieuMuon);
            if (ctp == null) return;

            var pm = ctp.PhieuMuon!;
            var bss = ctp.BanSaoSach!;

            // Gán tình trạng trả
            ctp.NgayTra = DateTime.Now;
            ctp.TinhTrangTra = tinhTrangTra switch
            {
                "Tốt" => ChiTietPhieuMuon.TinhTrangTraEnum.Tot,
                "Hư hỏng" or "Hỏng" => ChiTietPhieuMuon.TinhTrangTraEnum.HuHong,
                "Mất" => ChiTietPhieuMuon.TinhTrangTraEnum.Mat,
                _ => ChiTietPhieuMuon.TinhTrangTraEnum.Tot
            };

            // Cập nhật tình trạng bản sao
            bss.TinhTrangSach = ctp.TinhTrangTra switch
            {
                ChiTietPhieuMuon.TinhTrangTraEnum.Tot => BanSaoSach.TinhTrangSachEnum.Tot,
                ChiTietPhieuMuon.TinhTrangTraEnum.HuHong => BanSaoSach.TinhTrangSachEnum.Hong,
                ChiTietPhieuMuon.TinhTrangTraEnum.Mat => BanSaoSach.TinhTrangSachEnum.Mat,
                _ => BanSaoSach.TinhTrangSachEnum.Tot
            };

            _pmRepository.UpdateChiTiet(ctp);
            _pmRepository.UpdateBanSao(bss);

            //// ===== Xử lý phạt trả trễ =====
            //if (DateTime.Now > pm.NgayHenTra)
            //{
            //    int soNgayTre = (DateTime.Now - pm.NgayHenTra).Days;
            //    var mucPhatTre = _pmRepository.GetMucPhatTheoLoai("PerDay");
            //    if (mucPhatTre != null)
            //    {
            //        var pp = new PhieuPhat
            //        {
            //            NgayLap = DateTime.Now,
            //            LyDoPhat = $"Trễ {soNgayTre} ngày",
            //            TienPhatPhaiNop = mucPhatTre.SoTienPhat * soNgayTre,
            //            TrangThai = "ChuaThu"
            //        };
            //        _pmRepository.AddPhieuPhat(pp);
            //        _pmRepository.Save();

            //        var ctpp = new ChiTietPhieuPhat
            //        {
            //            IdPhieuPhat = pp.IdPhieuPhat,
            //            IdChiTietPhieuMuon = ctp.IdChiTietPhieuMuon,
            //            IdMucPhat = mucPhatTre.IdMucPhat,
            //            SoNgayTreHan = soNgayTre,
            //            TienPhatTra = mucPhatTre.SoTienPhat * soNgayTre
            //        };
            //        _pmRepository.AddChiTietPhieuPhat(ctpp);
            //    }
            //}

            //// ===== Xử lý phạt hư hỏng / mất =====
            //if (ctp.TinhTrangTra == ChiTietPhieuMuon.TinhTrangTraEnum.HuHong ||
            //    ctp.TinhTrangTra == ChiTietPhieuMuon.TinhTrangTraEnum.Mat)
            //{
            //    var mucPhatHong = _pmRepository.GetMucPhatTheoLoai("Fixed");
            //    if (mucPhatHong != null)
            //    {
            //        var pp = new PhieuPhat
            //        {
            //            NgayLap = DateTime.Now,
            //            LyDoPhat = $"Sách {ctp.TinhTrangTra.GetDisplayName()}",
            //            TienPhatPhaiNop = mucPhatHong.SoTienPhat,
            //            TrangThai = "ChuaThu"
            //        };
            //        _pmRepository.AddPhieuPhat(pp);
            //        _pmRepository.Save();

            //        var ctpp = new ChiTietPhieuPhat
            //        {
            //            IdPhieuPhat = pp.IdPhieuPhat,
            //            IdChiTietPhieuMuon = ctp.IdChiTietPhieuMuon,
            //            IdMucPhat = mucPhatHong.IdMucPhat,
            //            TienPhatTra = mucPhatHong.SoTienPhat
            //        };
            //        _pmRepository.AddChiTietPhieuPhat(ctpp);
            //    }
            //}

            // ===== Kiểm tra nếu đã trả hết =====
            if (pm.ChiTietPhieuMuons!.All(x => x.TinhTrangTra != ChiTietPhieuMuon.TinhTrangTraEnum.ChuaTra))
                pm.TrangThai = PhieuMuon.TrangThaiEnum.DaTra;

            _pmRepository.Update(pm);
            _pmRepository.Save();
        }
    }
}