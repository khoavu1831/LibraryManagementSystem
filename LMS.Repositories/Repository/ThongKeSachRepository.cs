using LMS.Data;
using LMS.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

public class ThongKeSachRepository
{
    private readonly LibraryDbContext _db;

    public ThongKeSachRepository()
    {
        _db = new LibraryDbContext();
    }

    public List<Sach> GetAllSach()
    {
        return _db.Sachs
                  .Include(s => s.TheLoais)
                  .ToList();
    }

    public List<(Sach sach, DateTime ngay)> GetSachDangMuon(DateTime ngayFrom, DateTime ngayTo)
    {
        var fromDate = ngayFrom.Date;
        var toDate = ngayTo.Date;

        var query =
            from ct in _db.ChiTietPhieuMuons
            join pm in _db.PhieuMuons on ct.IdPhieuMuon equals pm.IdPhieuMuon
            join bss in _db.BanSaoSachs on ct.IdBanSaoSach equals bss.IdBanSaoSach
            join s in _db.Sachs.Include(x => x.TheLoais) on bss.IdSach equals s.IdSach
            where ct.TinhTrangTra == ChiTietPhieuMuon.TinhTrangTraEnum.ChuaTra
               && pm.NgayMuon.Date >= fromDate
               && pm.NgayMuon.Date <= toDate
            select new
            {
                sach = s,
                ngay = pm.NgayMuon.Date
            };

        return query
            .AsEnumerable()
            .Select(x => (x.sach, x.ngay))
            .ToList();
    }

    public List<(Sach sach, DateTime? ngayTra)> GetSachMatHuHong(DateTime ngayFrom, DateTime ngayTo)
    {
        var fromDate = ngayFrom.Date;
        var toDate = ngayTo.Date;

        var query =
            from ct in _db.ChiTietPhieuMuons
            join pm in _db.PhieuMuons on ct.IdPhieuMuon equals pm.IdPhieuMuon
            join bss in _db.BanSaoSachs on ct.IdBanSaoSach equals bss.IdBanSaoSach
            join s in _db.Sachs.Include(x => x.TheLoais) on bss.IdSach equals s.IdSach
            where
                ct.NgayTra.HasValue
                && ct.NgayTra.Value.Date >= fromDate
                && ct.NgayTra.Value.Date <= toDate
                && (
                    ct.TinhTrangTra == ChiTietPhieuMuon.TinhTrangTraEnum.Mat
                    || ct.TinhTrangTra == ChiTietPhieuMuon.TinhTrangTraEnum.HuHong
                    || _db.ChiTietPhieuPhats.Any(p => p.IdChiTietPhieuMuon == ct.IdChiTietPhieuMuon)
                )
            select new
            {
                sach = s,
                ngay = ct.NgayTra
            };

        return query
            .AsEnumerable()
            .Select(x => (x.sach, x.ngay))
            .ToList();
    }


    public int SoBanSaoDangMuonTheoSach(int idSach, DateTime ngayFrom, DateTime ngayTo)
    {
        return (from ct in _db.ChiTietPhieuMuons
                join pm in _db.PhieuMuons on ct.IdPhieuMuon equals pm.IdPhieuMuon
                join bss in _db.BanSaoSachs on ct.IdBanSaoSach equals bss.IdBanSaoSach
                where bss.IdSach == idSach
                      && ct.TinhTrangTra == ChiTietPhieuMuon.TinhTrangTraEnum.ChuaTra
                      && pm.NgayMuon >= ngayFrom
                      && pm.NgayMuon <= ngayTo
                select ct).Count();
    }



    public int TongSoSach()
    {
        return _db.Sachs.Sum(s => s.SoLuongBanSao);
    }

    public int SoSachDangMuon()
    {
        return _db.ChiTietPhieuMuons
                  .Count(ct => ct.TinhTrangTra == ChiTietPhieuMuon.TinhTrangTraEnum.ChuaTra);
    }

    public int SoSachDangMuon(DateTime ngayFrom, DateTime ngayTo)
    {
        var fromDate = ngayFrom.Date;
        var toDate = ngayTo.Date;

        return _db.ChiTietPhieuMuons
                  .Join(_db.PhieuMuons, ct => ct.IdPhieuMuon, pm => pm.IdPhieuMuon, (ct, pm) => new { ct, pm })
                  .Count(x => x.ct.TinhTrangTra == ChiTietPhieuMuon.TinhTrangTraEnum.ChuaTra
                           && x.pm.NgayMuon.Date >= fromDate
                           && x.pm.NgayMuon.Date <= toDate);
    }

    public int SoSachMatHuHong()
    {
        return _db.ChiTietPhieuMuons
                  .Count(ct =>
                        ct.TinhTrangTra == ChiTietPhieuMuon.TinhTrangTraEnum.Mat ||
                        ct.TinhTrangTra == ChiTietPhieuMuon.TinhTrangTraEnum.HuHong
                       || _db.ChiTietPhieuPhats.Any(p => p.IdChiTietPhieuMuon == ct.IdChiTietPhieuMuon)
                       );
    }

    public int SoSachMatHuHong(DateTime ngayFrom, DateTime ngayTo)
    {
        var fromDate = ngayFrom.Date;
        var toDate = ngayTo.Date;

        var q = _db.ChiTietPhieuMuons
            .Where(ct => ct.NgayTra.HasValue
                      && ct.NgayTra.Value.Date >= fromDate
                      && ct.NgayTra.Value.Date <= toDate)
            .ToList();

        int count = q.Count(ct =>
            ct.TinhTrangTra == ChiTietPhieuMuon.TinhTrangTraEnum.Mat
            || ct.TinhTrangTra == ChiTietPhieuMuon.TinhTrangTraEnum.HuHong
            || _db.ChiTietPhieuPhats.Any(p => p.IdChiTietPhieuMuon == ct.IdChiTietPhieuMuon)
        );

        return count;
    }
}
