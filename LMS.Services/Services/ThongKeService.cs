using LMS.Data;
using LMS.Models.Dtos;
using LMS.Repository;
using LMS.Services;

namespace LMS.Views.LMS.Services.Services
{
    public class ThongKeService
    {
        private readonly PhieuPhatRepository _phieuPhatRepository;
        private readonly DocGiaService _docGiaService;
        private readonly PhieuNhapService _phieuNhapService;
        private readonly PhieuMuonService _phieuMuonService;
        private readonly TheThanhVienService _theThanhVienService;
        private readonly ChiTietPhieuMuonRepository _chiTietPhieuMuonRepository;

        public ThongKeService()
        {
            var context = new LibraryDbContext();
            var docGiaRepo = new Repository.DocGiaRepository(context);
            var theThanhVienRepo = new Repository.TheThanhVienRepository(context);
            _phieuPhatRepository = new Repository.PhieuPhatRepository(context);
            var phieuMuonRepo = new Repository.PhieuMuonRepository(context);
            var phieuNhapRepo = new Repository.PhieuNhapRepository(context);
            _docGiaService = new DocGiaService(context, docGiaRepo, theThanhVienRepo);
            _phieuMuonService = new PhieuMuonService(phieuMuonRepo);
            _phieuNhapService = new PhieuNhapService(phieuNhapRepo);
            _theThanhVienService = new TheThanhVienService(context, theThanhVienRepo);
            _chiTietPhieuMuonRepository = new ChiTietPhieuMuonRepository(context);
        }

        public Dictionary<string, int> getPhieuPhatTheoNam(int year)
        {
            var list = _phieuPhatRepository.GetAll()
                .Where(p => p.NgayLap.Year == year);

            var grouped = list.GroupBy(p => (p.NgayLap.Month - 1) / 3 + 1)
                              .Select(g => new { Quy = g.Key, SoLuong = g.Count() })
                              .ToDictionary(x => x.Quy, x => x.SoLuong);

            var result = new Dictionary<string, int>();
            for (int q = 1; q <= 4; q++)
                result[$"Quý {q}"] = grouped.ContainsKey(q) ? grouped[q] : 0;

            return result;
        }

        public Dictionary<string, int> getSachNhapTheoNam(int year)
        {
            var list = _phieuNhapService.GetAllPhieuNhap()
                .Where(p => p.NgayNhap.Year == year);

            var grouped = list.GroupBy(p => (p.NgayNhap.Month - 1) / 3 + 1)
                              .Select(g => new { Quy = g.Key, SoLuong = g.Sum(x => x.SoLuongSach) })
                              .ToDictionary(x => x.Quy, x => x.SoLuong);

            var result = new Dictionary<string, int>();
            for (int q = 1; q <= 4; q++)
                result[$"Quý {q}"] = grouped.ContainsKey(q) ? grouped[q] : 0;

            return result;
        }

        public Dictionary<string, int> getTheThanhVienTheoNam(int year)
        {
            var list = _theThanhVienService.GetAllTheThanhVien()
                .Where(c => c.NgayCap.Year == year);

            var grouped = list.GroupBy(c => (c.NgayCap.Month - 1) / 3 + 1)
                              .Select(g => new { Quy = g.Key, SoLuong = g.Count() })
                              .ToDictionary(x => x.Quy, x => x.SoLuong);

            var result = new Dictionary<string, int>();
            for (int q = 1; q <= 4; q++)
                result[$"Quý {q}"] = grouped.ContainsKey(q) ? grouped[q] : 0;

            return result;
        }

        public Dictionary<string, int> getSachMuonTheoNam(int year)
        {
            var list = _phieuMuonService.GetAllPhieuMuon()
                .Where(p => p.NgayMuon.Year == year)
                .Select(pm => _phieuMuonService.GetPhieuMuonChiTiet(pm.IdPhieuMuon)); // load chi tiết

            var grouped = list.GroupBy(p => (p.NgayMuon.Month - 1) / 3 + 1)
                              .Select(g => new { Quy = g.Key, SoLuong = g.Sum(x => x.ChiTietPhieuMuons?.Count ?? 0) })
                              .ToDictionary(x => x.Quy, x => x.SoLuong);

            var result = new Dictionary<string, int>();
            for (int q = 1; q <= 4; q++)
                result[$"Quý {q}"] = grouped.ContainsKey(q) ? grouped[q] : 0;

            return result;
        }

        public Dictionary<string, decimal> getSoTienPhatTheoNam(int year)
        {
            var list = _phieuPhatRepository.GetAll()
                .Where(p => p.NgayLap.Year == year);

            var grouped = list.GroupBy(p => (p.NgayLap.Month - 1) / 3 + 1)
                              .Select(g => new { Quy = g.Key, SoLuong = g.Sum(x => x.TienPhatPhaiNop) })
                              .ToDictionary(x => x.Quy, x => x.SoLuong);

            var result = new Dictionary<string, decimal>();
            for (int q = 1; q <= 4; q++)
                result[$"Quý {q}"] = grouped.ContainsKey(q) ? grouped[q] : 0m;

            return result;
        }
        public List<ThongKeNgayDto> ThongKeTheoNgay(DateTime from, DateTime to)
        {
            // 1. Lấy tất cả phiếu mượn trong khoảng ngày
            var phieuMuon = _phieuMuonService.GetAllForRevenue()
                .Where(pm => pm.NgayMuon.Date >= from.Date && pm.NgayMuon.Date <= to.Date)
                .ToList();

            // 2. Lấy tất cả chi tiết phiếu mượn
            var allChiTiet = phieuMuon.SelectMany(pm => pm.ChiTietPhieuMuons).ToList();

            // 3. Lấy tất cả chi tiết phiếu mượn đã trả trong khoảng
            var allChiTietTra = _chiTietPhieuMuonRepository.GetAll()
                .Where(ct => ct.NgayTra.HasValue &&
                             ct.NgayTra.Value.Date >= from.Date &&
                             ct.NgayTra.Value.Date <= to.Date)
                .ToList();

            // 4. Lấy chi tiết phiếu mượn quá hạn
            var phieuMuonTra = _phieuMuonService.GetAllForRevenue()
                .Where(pm => pm.NgayHenTra.Date >= from.Date && pm.NgayHenTra.Date <= to.Date)
                .ToList();

            var chiTietQuaHan = phieuMuonTra
                .SelectMany(pm => pm.ChiTietPhieuMuons
                    .Where(ct => !ct.NgayTra.HasValue || ct.NgayTra.Value.Date > pm.NgayHenTra.Date))
                .ToList();

            // 5. Tạo danh sách ngày trong khoảng
            int totalDays = (to.Date - from.Date).Days + 1;
            if ((to.Date - from.Date).Days + 1 > 365) totalDays = 365;

            var days = Enumerable.Range(0, totalDays)
                .Select(d => from.Date.AddDays(d))
                .ToList();

            // 6. Thống kê theo ngày và order by ngày
            var result = days
                .Select(day => new ThongKeNgayDto
                {
                    Ngay = day,
                    SoSachMuon = allChiTiet.Count(ct => ct.PhieuMuon.NgayMuon.Date == day),
                    SoSachTra = allChiTietTra.Count(ct => ct.NgayTra.Value.Date == day),
                    SoSachQuaHan = chiTietQuaHan.Count(ct => ct.PhieuMuon.NgayHenTra.Date == day)
                })
                .OrderBy(dto => dto.Ngay)
                .ToList();

            return result;
        }
        // -------------------- Theo tháng --------------------
        public List<ThongKeThangDto> ThongKeTheoKhoangThang(DateTime from, DateTime to)
        {
            var result = new List<ThongKeThangDto>();

            // 1. Xác định đầu tháng và cuối tháng
            var start = new DateTime(from.Year, from.Month, 1);
            var end = new DateTime(to.Year, to.Month, 1).AddMonths(1).AddDays(-1);

            // 2. Lấy tất cả phiếu mượn trong khoảng tháng
            var phieuMuon = _phieuMuonService.GetAllForRevenue()
                                .Where(pm => pm.NgayMuon.Date >= start.Date && pm.NgayMuon.Date <= end.Date)
                                .ToList();

            // 3. Lấy tất cả chi tiết phiếu mượn
            var allChiTiet = phieuMuon.SelectMany(pm => pm.ChiTietPhieuMuons).ToList();

            // 4. Lấy chi tiết phiếu mượn đã trả trong khoảng
            var allChiTietTra = _chiTietPhieuMuonRepository.GetAll()
                                .Where(ct => ct.NgayTra.HasValue
                                         && ct.NgayTra.Value.Date >= start.Date
                                         && ct.NgayTra.Value.Date <= end.Date)
                                .ToList();

            // 5. Lấy chi tiết phiếu mượn quá hạn trong khoảng
            var phieuMuonTra = _phieuMuonService.GetAllForRevenue()
                                 .Where(pm => pm.NgayHenTra.Date >= start.Date && pm.NgayHenTra.Date <= end.Date && pm.NgayHenTra <= DateTime.Now)
                                 .ToList();

            var chiTietQuaHan = phieuMuonTra
                                .SelectMany(pm => pm.ChiTietPhieuMuons
                                     .Where(ct => !ct.NgayTra.HasValue || ct.NgayTra.Value.Date > pm.NgayHenTra.Date))
                                .ToList();

            // 6. Tạo danh sách các tháng trong khoảng
            var months = new List<DateTime>();
            var current = start;
            while (current <= end)
            {
                months.Add(current);
                current = current.AddMonths(1);
            }

            // 7. Thống kê theo từng tháng
            result = months.Select(m => new ThongKeThangDto
            {
                Thang = m.Month + "/" + m.Year,
                SoSachMuon = allChiTiet.Count(ct => ct.PhieuMuon.NgayMuon.Month == m.Month && ct.PhieuMuon.NgayMuon.Year == m.Year),
                SoSachTra = allChiTietTra.Count(ct => ct.NgayTra.HasValue && ct.NgayTra.Value.Month == m.Month && ct.NgayTra.Value.Year == m.Year),
                SoSachQuaHan = chiTietQuaHan.Count(ct => ct.PhieuMuon.NgayHenTra.Month == m.Month && ct.PhieuMuon.NgayHenTra.Year == m.Year)
            }).ToList();

            return result;
        }


        public List<ThongKeQuyDto> ThongKeTheoQuy(int quyTu, int namTu, int quyDen, int namDen)
        {
            var result = new List<ThongKeQuyDto>();
            int monthStart1 = (quyTu - 1) * 3 + 1; // tháng bắt đầu tổng thể
            int monthEnd1 = (quyDen - 1) * 3 + 3;  // tháng kết thúc tổng thể
                                                   // đảm bảo không vượt 12
            monthStart1 = Math.Min(monthStart1, 12);
            monthEnd1 = Math.Min(monthEnd1, 12);

            // Xác định ngày bắt đầu và ngày kết thúc tổng thể
            DateTime startDate = new DateTime(namTu, monthStart1, 1);
            DateTime endDate = new DateTime(namDen, monthEnd1, DateTime.DaysInMonth(namDen, monthEnd1));

            // Lấy tất cả phiếu mượn trong khoảng
            var phieuMuon = _phieuMuonService.GetAllForRevenue()
                .Where(pm => pm.NgayMuon.Date >= startDate && pm.NgayMuon.Date <= endDate)
                .ToList();

            var allChiTiet = phieuMuon.SelectMany(pm => pm.ChiTietPhieuMuons).ToList();
            var allChiTietTra = allChiTiet.Where(ct => ct.NgayTra.HasValue && ct.NgayTra.Value.Date >= startDate && ct.NgayTra.Value.Date <= endDate).ToList();
            var chiTietQuaHan = allChiTiet.Where(ct => (!ct.NgayTra.HasValue || ct.NgayTra.Value.Date > ct.PhieuMuon.NgayHenTra.Date)
                                                      && ct.PhieuMuon.NgayHenTra.Date >= startDate
                                                      && ct.PhieuMuon.NgayHenTra.Date <= endDate
                                                      && ct.PhieuMuon.NgayHenTra.Date <= DateTime.Now).ToList();

            // Duyệt theo từng năm
            for (int year = namTu; year <= namDen; year++)
            {
                int qStart = (year == namTu) ? quyTu : 1;
                int qEnd = (year == namDen) ? quyDen : 4;

                for (int q = qStart; q <= qEnd; q++)
                {
                    int monthStart = (q - 1) * 3 + 1;
                    int monthEnd = Math.Min(monthStart + 2, 12);

                    var muon = allChiTiet.Count(ct => ct.PhieuMuon.NgayMuon.Year == year && ct.PhieuMuon.NgayMuon.Month >= monthStart && ct.PhieuMuon.NgayMuon.Month <= monthEnd);
                    var tra = allChiTietTra.Count(ct => ct.NgayTra.Value.Year == year && ct.NgayTra.Value.Month >= monthStart && ct.NgayTra.Value.Month <= monthEnd);
                    var quaHan = chiTietQuaHan.Count(ct => ct.PhieuMuon.NgayHenTra.Year == year && ct.PhieuMuon.NgayHenTra.Month >= monthStart && ct.PhieuMuon.NgayHenTra.Month <= monthEnd);

                    result.Add(new ThongKeQuyDto
                    {
                        Quy = $"Q{q}/{year}",
                        SoSachMuon = muon,
                        SoSachTra = tra,
                        SoSachQuaHan = quaHan
                    });
                }
            }

            return result;
        }





        // -------------------- Theo năm --------------------
        public List<ThongKeNamDto> ThongKeTheoNam(int fromYear, int toYear)
        {
            var result = new List<ThongKeNamDto>();

            // Lấy tất cả phiếu mượn trong khoảng từYear -> toYear
            var phieuMuonTrongKhoang = _phieuMuonService.GetAllForRevenue()
                .Where(pm => pm.NgayMuon.Year >= fromYear && pm.NgayMuon.Year <= toYear)
                .ToList();

            var allChiTiet = phieuMuonTrongKhoang.SelectMany(pm => pm.ChiTietPhieuMuons).ToList();

            for (int year = fromYear; year <= toYear; year++)
            {
                // Chi tiết đã trả trong năm
                var chiTietTra = allChiTiet
                    .Where(ct => ct.NgayTra.HasValue && ct.NgayTra.Value.Year == year)
                    .ToList();

                // Chi tiết quá hạn trong năm
                var chiTietQuaHan = allChiTiet
                    .Where(ct => (!ct.NgayTra.HasValue || ct.NgayTra.Value.Date > ct.PhieuMuon.NgayHenTra.Date)
                                 && ct.PhieuMuon.NgayHenTra.Year == year
                                 && ct.PhieuMuon.NgayHenTra.Date <= DateTime.Now
                                 )
                    .ToList();

                // Thống kê số sách mượn trong năm
                var chiTietMuon = allChiTiet
                    .Where(ct => ct.PhieuMuon.NgayMuon.Year == year)
                    .ToList();

                result.Add(new ThongKeNamDto
                {
                    Nam = year,
                    SoSachMuon = chiTietMuon.Count,
                    SoSachTra = chiTietTra.Count,
                    SoSachQuaHan = chiTietQuaHan.Count
                });
            }

            return result;
        }

    }
}
