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
    // 1) LẤY TOÀN BỘ SÁCH
    public List<Sach> GetAllSach()
    {
        return _db.Sachs
                  .Include(s => s.TheLoais)
                  .ToList();
    }
    // 2) SÁCH ĐANG MƯỢN
    public List<(Sach sach, DateTime ngay)> GetSachDangMuon(DateTime ngayFrom, DateTime ngayTo)
    {
        var sachQuery = _db.Sachs.Include(s => s.TheLoais);

        return (
            from ct in _db.ChiTietPhieuMuons
            join pm in _db.PhieuMuons
                on ct.IdPhieuMuon equals pm.IdPhieuMuon
            join bss in _db.BanSaoSachs
                on ct.IdBanSaoSach equals bss.IdBanSaoSach
            join s in sachQuery
                on bss.IdSach equals s.IdSach
            where
                ct.TinhTrangTra == ChiTietPhieuMuon.TinhTrangTraEnum.ChuaTra  // đang mượn
                && pm.NgayMuon >= ngayFrom
                && pm.NgayMuon <= ngayTo
            select new { sach = s, ngay = pm.NgayMuon }
        )
        .AsEnumerable()
        .Select(x => (x.sach, x.ngay))
        .ToList();
    }

    // 3) SÁCH MẤT / HƯ HỎNG
    public List<(Sach sach, DateTime? ngay)> GetSachMatHuHong(DateTime ngayFrom, DateTime ngayTo)
    {
        var sachQuery = _db.Sachs.Include(s => s.TheLoais);

        return (
            from ct in _db.ChiTietPhieuMuons
            join pm in _db.PhieuMuons
                on ct.IdPhieuMuon equals pm.IdPhieuMuon
            join bss in _db.BanSaoSachs
                on ct.IdBanSaoSach equals bss.IdBanSaoSach
            join s in sachQuery
                on bss.IdSach equals s.IdSach
            where
                (ct.TinhTrangTra == ChiTietPhieuMuon.TinhTrangTraEnum.Mat
                || ct.TinhTrangTra == ChiTietPhieuMuon.TinhTrangTraEnum.HuHong)
                && ct.NgayTra >= ngayFrom
                && ct.NgayTra <= ngayTo
            select new { sach = s, ngay = ct.NgayTra }
        )
        .AsEnumerable()
        .Select(x => (x.sach, x.ngay))
        .ToList();
    }


    // 4) SÁCH CHƯA MƯỢN
    public List<Sach> GetSachChuaMuon()
    {
        var sachDaMuonIds =
            _db.BanSaoSachs
               .Where(bss => _db.ChiTietPhieuMuons
                   .Any(ct => ct.IdBanSaoSach == bss.IdBanSaoSach))
               .Select(bss => bss.IdSach)
               .Distinct()
               .ToList();

        return _db.Sachs
                  .Include(s => s.TheLoais)
                  .Where(s => !sachDaMuonIds.Contains(s.IdSach))
                  .ToList();
    }
    // 5) TỔNG SỐ LƯỢNG SÁCH
    public int TongSoSach()
    {
        return _db.Sachs.Sum(s => s.SoLuongBanSao);
    }
    // 6) SỐ SÁCH ĐANG MƯỢN
    public int SoSachDangMuon()
    {
        return _db.ChiTietPhieuMuons
                  .Count(ct => ct.TinhTrangTra ==
                               ChiTietPhieuMuon.TinhTrangTraEnum.ChuaTra);
    }
    // 7) SỐ SÁCH MẤT HOẶC HƯ HỎNG
    public int SoSachMatHuHong()
    {
        return _db.ChiTietPhieuMuons
                  .Count(ct => ct.TinhTrangTra ==
                               ChiTietPhieuMuon.TinhTrangTraEnum.Mat
                            || ct.TinhTrangTra ==
                               ChiTietPhieuMuon.TinhTrangTraEnum.HuHong);
    }
}
