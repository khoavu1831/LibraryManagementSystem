using LMS.Data;
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
    }
}
