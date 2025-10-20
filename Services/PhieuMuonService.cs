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
        // public void TraSach(int idChiTietPhieuMuon, string tinhTrangTra)
        // {
        //     var ctp = _pmRepository.GetChiTietById(idChiTietPhieuMuon);
        //     if (ctp == null) return;

        //     var pm = ctp.PhieuMuon!;
        //     var bss = ctp.BanSaoSach!;

        //     // Gán tình trạng trả
        //     ctp.NgayTra = DateTime.Now;
        //     ctp.TinhTrangTra = tinhTrangTra switch
        //     {
        //         "Tốt" => ChiTietPhieuMuon.TinhTrangTraEnum.Tot,
        //         "Hư hỏng" or "Hỏng" => ChiTietPhieuMuon.TinhTrangTraEnum.HuHong,
        //         "Mất" => ChiTietPhieuMuon.TinhTrangTraEnum.Mat,
        //         _ => ChiTietPhieuMuon.TinhTrangTraEnum.Tot
        //     };

        //     // Cập nhật tình trạng bản sao
        //     bss.TinhTrangSach = ctp.TinhTrangTra switch
        //     {
        //         ChiTietPhieuMuon.TinhTrangTraEnum.Tot => BanSaoSach.TinhTrangSachEnum.Tot,
        //         ChiTietPhieuMuon.TinhTrangTraEnum.HuHong => BanSaoSach.TinhTrangSachEnum.Hong,
        //         ChiTietPhieuMuon.TinhTrangTraEnum.Mat => BanSaoSach.TinhTrangSachEnum.Mat,
        //         _ => BanSaoSach.TinhTrangSachEnum.Tot
        //     };

        //     _pmRepository.UpdateChiTiet(ctp);
        //     _pmRepository.UpdateBanSao(bss);

        //     //// ===== Xử lý phạt trả trễ =====
        //     //if (DateTime.Now > pm.NgayHenTra)
        //     //{
        //     //    int soNgayTre = (DateTime.Now - pm.NgayHenTra).Days;
        //     //    var mucPhatTre = _pmRepository.GetMucPhatTheoLoai("PerDay");
        //     //    if (mucPhatTre != null)
        //     //    {
        //     //        var pp = new PhieuPhat
        //     //        {
        //     //            NgayLap = DateTime.Now,
        //     //            LyDoPhat = $"Trễ {soNgayTre} ngày",
        //     //            TienPhatPhaiNop = mucPhatTre.SoTienPhat * soNgayTre,
        //     //            TrangThai = "ChuaThu"
        //     //        };
        //     //        _pmRepository.AddPhieuPhat(pp);
        //     //        _pmRepository.Save();

        //     //        var ctpp = new ChiTietPhieuPhat
        //     //        {
        //     //            IdPhieuPhat = pp.IdPhieuPhat,
        //     //            IdChiTietPhieuMuon = ctp.IdChiTietPhieuMuon,
        //     //            IdMucPhat = mucPhatTre.IdMucPhat,
        //     //            SoNgayTreHan = soNgayTre,
        //     //            TienPhatTra = mucPhatTre.SoTienPhat * soNgayTre
        //     //        };
        //     //        _pmRepository.AddChiTietPhieuPhat(ctpp);
        //     //    }
        //     //}

        //     //// ===== Xử lý phạt hư hỏng / mất =====
        //     //if (ctp.TinhTrangTra == ChiTietPhieuMuon.TinhTrangTraEnum.HuHong ||
        //     //    ctp.TinhTrangTra == ChiTietPhieuMuon.TinhTrangTraEnum.Mat)
        //     //{
        //     //    var mucPhatHong = _pmRepository.GetMucPhatTheoLoai("Fixed");
        //     //    if (mucPhatHong != null)
        //     //    {
        //     //        var pp = new PhieuPhat
        //     //        {
        //     //            NgayLap = DateTime.Now,
        //     //            LyDoPhat = $"Sách {ctp.TinhTrangTra.GetDisplayName()}",
        //     //            TienPhatPhaiNop = mucPhatHong.SoTienPhat,
        //     //            TrangThai = "ChuaThu"
        //     //        };
        //     //        _pmRepository.AddPhieuPhat(pp);
        //     //        _pmRepository.Save();

        //     //        var ctpp = new ChiTietPhieuPhat
        //     //        {
        //     //            IdPhieuPhat = pp.IdPhieuPhat,
        //     //            IdChiTietPhieuMuon = ctp.IdChiTietPhieuMuon,
        //     //            IdMucPhat = mucPhatHong.IdMucPhat,
        //     //            TienPhatTra = mucPhatHong.SoTienPhat
        //     //        };
        //     //        _pmRepository.AddChiTietPhieuPhat(ctpp);
        //     //    }
        //     //}

        //     // ===== Kiểm tra nếu đã trả hết =====
        //     if (pm.ChiTietPhieuMuons!.All(x => x.TinhTrangTra != ChiTietPhieuMuon.TinhTrangTraEnum.ChuaTra))
        //         pm.TrangThai = PhieuMuon.TrangThaiEnum.DaTra;

        //     _pmRepository.Update(pm);
        //     _pmRepository.Save();
        // }

        public class TraSachItem
        {
            public int IdChiTietPhieuMuon { get; set; }
            public string TinhTrangTra { get; set; } = "";
            public int? IdMucPhatFixed { get; set; }
        }

        // Services/PhieuMuonService.cs
        public void TraSachBulk(int idPhieuMuon, List<TraSachItem> items)
        {
            var pm = _pmRepository.GetChiTiet(idPhieuMuon);
            if (pm == null || items.Count == 0) return;

            var mucPhatPerDay = _pmRepository.GetPerDayFine();

            // 1) Tìm phiếu phạt “chưa thu” của phiếu mượn này (nếu có)
            var pp = _pmRepository.GetOpenPhieuPhatByPhieuMuon(idPhieuMuon);
            decimal tongTien = pp?.TienPhatPhaiNop ?? 0m;

            foreach (var item in items)
            {
                var ctp = _pmRepository.GetChiTietById(item.IdChiTietPhieuMuon);
                if (ctp == null) continue;

                var bss = ctp.BanSaoSach!;
                ctp.NgayTra = DateTime.Now;
                ctp.TinhTrangTra = item.TinhTrangTra switch
                {
                    "Tốt" => ChiTietPhieuMuon.TinhTrangTraEnum.Tot,
                    "Hư hỏng" or "Hỏng" or "Hư hỏng nhẹ" or "Hư hỏng vừa" or "Hư hỏng nặng" or "Hư hỏng nghiêm trọng"
                        => ChiTietPhieuMuon.TinhTrangTraEnum.HuHong,
                    "Mất" => ChiTietPhieuMuon.TinhTrangTraEnum.Mat,
                    _ => ChiTietPhieuMuon.TinhTrangTraEnum.Tot
                };
                bss.TinhTrangSach = ctp.TinhTrangTra == ChiTietPhieuMuon.TinhTrangTraEnum.Tot
                    ? BanSaoSach.TinhTrangSachEnum.Tot
                    : (ctp.TinhTrangTra == ChiTietPhieuMuon.TinhTrangTraEnum.Mat
                        ? BanSaoSach.TinhTrangSachEnum.Mat
                        : BanSaoSach.TinhTrangSachEnum.Hong);

                _pmRepository.UpdateChiTiet(ctp);
                _pmRepository.UpdateBanSao(bss);

                // 2) Khởi tạo phiếu phạt 1 lần duy nhất khi thật sự có khoản phạt
                void EnsurePhieuPhat()
                {
                    if (pp != null) return;
                    pp = new PhieuPhat
                    {
                        NgayLap = DateTime.Now,
                        LyDoPhat = "Phạt khi trả sách",
                        TienPhatPhaiNop = 0m,
                        TrangThai = PhieuPhat.TrangThaiEnum.ChuaThu
                    };
                    _pmRepository.AddPhieuPhat(pp);
                    _pmRepository.Save();
                }

                // Phạt trễ
                int soNgayTre = 0;
                if (ctp.NgayTra.HasValue)
                {
                    var ngayTra = ctp.NgayTra.Value.Date;
                    var henTra = pm.NgayHenTra.Date;
                    if (ngayTra > henTra) soNgayTre = (ngayTra - henTra).Days;
                }
                if (soNgayTre > 0 && mucPhatPerDay != null)
                {
                    EnsurePhieuPhat();
                    var soTienTre = mucPhatPerDay.SoTienPhat * soNgayTre;
                    _pmRepository.AddChiTietPhieuPhat(new ChiTietPhieuPhat
                    {
                        IdPhieuPhat = pp!.IdPhieuPhat,
                        IdChiTietPhieuMuon = ctp.IdChiTietPhieuMuon,
                        IdMucPhat = mucPhatPerDay.IdMucPhat,
                        SoNgayTreHen = soNgayTre,
                        TienPhatTra = soTienTre
                    });
                    tongTien += soTienTre;
                }

                // Phạt fixed
                if (item.IdMucPhatFixed.HasValue)
                {
                    var mf = _pmRepository.GetMucPhatById(item.IdMucPhatFixed.Value);
                    if (mf != null)
                    {
                        EnsurePhieuPhat();
                        _pmRepository.AddChiTietPhieuPhat(new ChiTietPhieuPhat
                        {
                            IdPhieuPhat = pp!.IdPhieuPhat,
                            IdChiTietPhieuMuon = ctp.IdChiTietPhieuMuon,
                            IdMucPhat = mf.IdMucPhat,
                            SoNgayTreHen = 0,
                            TienPhatTra = mf.SoTienPhat
                        });
                        tongTien += mf.SoTienPhat;
                    }
                }
            }

            if (pp != null)
            {
                pp.TienPhatPhaiNop = tongTien;   // cộng dồn
                _pmRepository.Save();
            }

            if (pm.ChiTietPhieuMuons!.All(x => x.TinhTrangTra != ChiTietPhieuMuon.TinhTrangTraEnum.ChuaTra))
                pm.TrangThai = PhieuMuon.TrangThaiEnum.DaTra;

            _pmRepository.Update(pm);
            _pmRepository.Save();
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

                    // ===== TỰ ĐỘNG XỬ LÝ PHẠT TRỄ HẠN =====
            var ngayTra = (ctp.NgayTra ?? DateTime.Now).Date;       // vừa gán phía trên
            var henTra = pm.NgayHenTra.Date;
            int soNgayTre = (ngayTra > henTra) ? (ngayTra - henTra).Days : 0;

            if (soNgayTre > 0)
            {
                var mucPhatTre = _pmRepository.GetPerDayFine();
                if (mucPhatTre != null)
                {
                    var soTien = mucPhatTre.SoTienPhat * soNgayTre;

                    var pp = new PhieuPhat
                    {
                        NgayLap = DateTime.Now,
                        LyDoPhat = $"Trễ {soNgayTre} ngày",
                        TienPhatPhaiNop = soTien,
                        TrangThai = PhieuPhat.TrangThaiEnum.ChuaThu
                    };
                    _pmRepository.AddPhieuPhat(pp);
                    _pmRepository.Save(); // để có IdPhieuPhat

                    var ctpp = new ChiTietPhieuPhat
                    {
                        IdPhieuPhat = pp.IdPhieuPhat,
                        IdChiTietPhieuMuon = ctp.IdChiTietPhieuMuon,
                        IdMucPhat = mucPhatTre.IdMucPhat,
                        SoNgayTreHen = soNgayTre,
                        TienPhatTra = soTien
                    };
                    _pmRepository.AddChiTietPhieuPhat(ctpp);
                    _pmRepository.Save(); // LƯU NGAY chi tiết phạt
                }
            }

            // ===== Kiểm tra nếu đã trả hết =====
            if (pm.ChiTietPhieuMuons!.All(x => x.TinhTrangTra != ChiTietPhieuMuon.TinhTrangTraEnum.ChuaTra))
                pm.TrangThai = PhieuMuon.TrangThaiEnum.DaTra;

            _pmRepository.Update(pm);
            _pmRepository.Save();
        }

        public void TraSachWithFixed(int idChiTietPhieuMuon, string tinhTrangTra, int? idMucPhatFixed)
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

            // Tính các khoản phạt cần tạo chi tiết
            var ngayTra = (ctp.NgayTra ?? DateTime.Now).Date;
            var henTra = pm.NgayHenTra.Date;
            int soNgayTre = (ngayTra > henTra) ? (ngayTra - henTra).Days : 0;

            var mucPhatPerDay = _pmRepository.GetPerDayFine();
            decimal soTienTre = (soNgayTre > 0 && mucPhatPerDay != null) ? mucPhatPerDay.SoTienPhat * soNgayTre : 0m;

            MucPhat? mucPhatFixed = null;
            if (ctp.TinhTrangTra != ChiTietPhieuMuon.TinhTrangTraEnum.Tot && idMucPhatFixed.HasValue)
            {
                mucPhatFixed = _pmRepository.GetMucPhatById(idMucPhatFixed.Value);
            }

            // Nếu không có khoản phạt nào → không tạo phiếu phạt
            if (soTienTre <= 0 && mucPhatFixed == null)
            {
                // Kiểm tra nếu đã trả hết
                if (pm.ChiTietPhieuMuons!.All(x => x.TinhTrangTra != ChiTietPhieuMuon.TinhTrangTraEnum.ChuaTra))
                    pm.TrangThai = PhieuMuon.TrangThaiEnum.DaTra;

                _pmRepository.Update(pm);
                _pmRepository.Save();
                return;
            }

            // Tạo phiếu phạt và các chi tiết
            var pp = new PhieuPhat
            {
                NgayLap = DateTime.Now,
                LyDoPhat = "Phạt khi trả sách",
                TienPhatPhaiNop = 0,
                TrangThai = PhieuPhat.TrangThaiEnum.ChuaThu
            };
            _pmRepository.AddPhieuPhat(pp);
            _pmRepository.Save(); // lấy Id

            if (soTienTre > 0 && mucPhatPerDay != null)
            {
                var ctppTre = new ChiTietPhieuPhat
                {
                    IdPhieuPhat = pp.IdPhieuPhat,
                    IdChiTietPhieuMuon = ctp.IdChiTietPhieuMuon,
                    IdMucPhat = mucPhatPerDay.IdMucPhat,
                    SoNgayTreHen = soNgayTre,
                    TienPhatTra = soTienTre
                };
                pp.TienPhatPhaiNop += soTienTre;
                _pmRepository.AddChiTietPhieuPhat(ctppTre);
            }

            if (mucPhatFixed != null)
            {
                var ctppFixed = new ChiTietPhieuPhat
                {
                    IdPhieuPhat = pp.IdPhieuPhat,
                    IdChiTietPhieuMuon = ctp.IdChiTietPhieuMuon,
                    IdMucPhat = mucPhatFixed.IdMucPhat,
                    SoNgayTreHen = 0,
                    TienPhatTra = mucPhatFixed.SoTienPhat
                };
                pp.TienPhatPhaiNop += mucPhatFixed.SoTienPhat;
                _pmRepository.AddChiTietPhieuPhat(ctppFixed);
            }

// -            _pmRepository.Update(pp);
            _pmRepository.Save();

            // Kiểm tra nếu đã trả hết
            if (pm.ChiTietPhieuMuons!.All(x => x.TinhTrangTra != ChiTietPhieuMuon.TinhTrangTraEnum.ChuaTra))
                pm.TrangThai = PhieuMuon.TrangThaiEnum.DaTra;

            _pmRepository.Update(pm);
            _pmRepository.Save();
        }
    }
}