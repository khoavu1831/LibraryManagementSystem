using LMS.Data;
using LMS.Entities;
using LMS.Models.Dtos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LMS.Repository
{
    public class SachRepository
    {
        private readonly LibraryDbContext _context;
        public SachRepository(LibraryDbContext context) => _context = context;
        public List<Sach> GetAll()
        {
            return _context.Sachs
                .Include(s => s.NXB)
                .Include(s => s.TacGias)
                .Include(s => s.TheLoais)
                .ToList();
        }
        public Sach? GetById(int id)
        {
            return _context.Sachs
                .Include(s => s.NXB)
                .Include(s => s.TacGias)
                .Include(s => s.TheLoais)
                .FirstOrDefault(s => s.IdSach == id);
        }
        public Sach Add(Sach sach)
        {
            if (sach.TheLoais != null && sach.TheLoais.Any())
            {
                var theLoaiIds = sach.TheLoais
                    .Select(t => t.IdTheLoai)
                    .Distinct()
                    .ToList();

                sach.TheLoais = _context.TheLoais
                    .Where(t => theLoaiIds.Contains(t.IdTheLoai))
                    .ToList();
            }

            if (sach.TacGias != null && sach.TacGias.Any())
            {
                var tacGiaIds = sach.TacGias
                    .Select(t => t.IdTacGia)
                    .Distinct()
                    .ToList();

                sach.TacGias = _context.TacGias
                    .Where(t => tacGiaIds.Contains(t.IdTacGia))
                    .ToList();
            }

            if (sach.NXB != null)
            {
                var nxb = _context.NXBs.FirstOrDefault(x => x.IdNXB == sach.NXB.IdNXB);
                if (nxb != null)
                {
                    sach.NXB = nxb;
                    sach.IdNXB = nxb.IdNXB;
                }
            }

            _context.Sachs.Add(sach);
            _context.SaveChanges();
            return sach;
        }
        public Sach Update(Sach sach)
        {
            if (sach.TheLoais != null && sach.TheLoais.Any())
            {
                var theLoaiIds = sach.TheLoais
                    .Select(t => t.IdTheLoai)
                    .Distinct()
                    .ToList();

                sach.TheLoais = _context.TheLoais
                    .Where(t => theLoaiIds.Contains(t.IdTheLoai))
                    .ToList();
            }

            if (sach.TacGias != null && sach.TacGias.Any())
            {
                var tacGiaIds = sach.TacGias
                    .Select(t => t.IdTacGia)
                    .Distinct()
                    .ToList();

                sach.TacGias = _context.TacGias
                    .Where(t => tacGiaIds.Contains(t.IdTacGia))
                    .ToList();
            }

            if (sach.NXB != null)
            {
                var nxb = _context.NXBs.FirstOrDefault(x => x.IdNXB == sach.NXB.IdNXB);
                if (nxb != null)
                {
                    sach.NXB = nxb;
                    sach.IdNXB = nxb.IdNXB;
                }
            }

            _context.Sachs.Update(sach);
            _context.SaveChanges();
            return sach;
        }
        public Sach? DeleteById(int id)
        {
            var sach = GetById(id);
            if (sach == null) return null;
            _context.Sachs.Remove(sach);
            _context.SaveChanges();
            return sach;
        }

        public List<SachExcelDto> GetListExport()
        {
            return _context.Sachs
                .Include(s => s.NXB)
                .Include(s => s.TacGias)
                .Include(s => s.TheLoais)
                .Select(s => new SachExcelDto
                {
                    IdSach = s.IdSach,
                    MaSach = s.IdSachFormat,
                    TenSach = s.TenSach ?? string.Empty,
                    TenNXB = s.NXB!.TenNXB ?? string.Empty,
                    TheLoai = s.TheLoais != null
                        ? string.Join(", ", s.TheLoais.Select(tl => tl.TenTheloai))
                        : string.Empty,
                    TacGia = s.TacGias != null
                        ? string.Join(", ", s.TacGias.Select(tg => tg.TenTacGia))
                        : string.Empty,
                    NamXuatBan = s.NamXuatBan,
                    SoTrang = s.SoTrang,
                    SoLuongBanSao = s.SoLuongBanSao,
                    GiaTien = s.GiaTien,
                    MoTa = s.MoTa ?? string.Empty
                })
                .ToList();
        }

        public List<string> ImportFromExcel(List<SachExcelDto> rows)
        {
            var errors = new List<string>();
            var imported = new List<Sach>();

            for (int i = 0; i < rows.Count; i++)
            {
                var dto = rows[i];
                var rowNumber = i + 2; 

                try
                {
                    if (string.IsNullOrWhiteSpace(dto.TenSach))
                    {
                        errors.Add($"Dòng {rowNumber}: Tên sách không được để trống.");
                        continue;
                    }

                    if (string.IsNullOrWhiteSpace(dto.TenNXB))
                    {
                        errors.Add($"Dòng {rowNumber}: Tên nhà xuất bản không được để trống.");
                        continue;
                    }

                    var nxb = _context.NXBs.FirstOrDefault(x => x.TenNXB == dto.TenNXB);
                    if (nxb == null)
                    {
                        errors.Add($"Dòng {rowNumber}: Không tìm thấy nhà xuất bản '{dto.TenNXB}'.");
                        continue;
                    }

                    var theLoais = new List<TheLoai>();
                    if (!string.IsNullOrWhiteSpace(dto.TheLoai))
                    {
                        var tenTheLoais = dto.TheLoai
                            .Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(t => t.Trim())
                            .Where(t => !string.IsNullOrEmpty(t))
                            .ToList();

                        foreach (var ten in tenTheLoais)
                        {
                            var tl = _context.TheLoais.FirstOrDefault(x => x.TenTheloai == ten);
                            if (tl == null)
                            {
                                errors.Add($"Dòng {rowNumber}: Không tìm thấy thể loại '{ten}'.");
                                goto ContinueNextRow;
                            }
                            theLoais.Add(tl);
                        }
                    }

                    var tacGias = new List<TacGia>();
                    if (!string.IsNullOrWhiteSpace(dto.TacGia))
                    {
                        var tenTacGias = dto.TacGia
                            .Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(t => t.Trim())
                            .Where(t => !string.IsNullOrEmpty(t))
                            .ToList();

                        foreach (var ten in tenTacGias)
                        {
                            var tg = _context.TacGias.FirstOrDefault(x => x.TenTacGia == ten);
                            if (tg == null)
                            {
                                errors.Add($"Dòng {rowNumber}: Không tìm thấy tác giả '{ten}'.");
                                goto ContinueNextRow;
                            }
                            tacGias.Add(tg);
                        }
                    }

                    var normalizedTenSach = (dto.TenSach ?? string.Empty).Trim();

                    var existedInDb = _context.Sachs
                        .Include(s => s.NXB)
                        .Any(s =>
                            (s.TenSach ?? string.Empty).Trim() == normalizedTenSach &&
                            s.NXB != null &&
                            s.NXB.IdNXB == nxb.IdNXB &&
                            s.NamXuatBan == dto.NamXuatBan);

                    var existedInBatch = imported.Any(s =>
                        (s.TenSach ?? string.Empty).Trim() == normalizedTenSach &&
                        s.NXB != null &&
                        s.NXB.IdNXB == nxb.IdNXB &&
                        s.NamXuatBan == dto.NamXuatBan);

                    if (existedInDb || existedInBatch)
                    {
                        errors.Add($"Dòng {rowNumber}: Đầu sách '{dto.TenSach}' - NXB '{dto.TenNXB}' - Năm {dto.NamXuatBan} đã tồn tại.");
                        continue;
                    }

                    var sach = new Sach
                    {
                        TenSach = dto.TenSach,
                        NamXuatBan = dto.NamXuatBan,
                        SoTrang = dto.SoTrang,
                        GiaTien = dto.GiaTien,
                        MoTa = dto.MoTa,
                        NXB = nxb,
                        TheLoais = theLoais,
                        TacGias = tacGias
                    };

                    imported.Add(sach);

                    continue;

                ContinueNextRow:
                    continue;
                }
                catch (Exception ex)
                {
                    errors.Add($"Dòng {rowNumber}: Lỗi không xác định - {ex.Message}");
                }
            }

            if (imported.Count > 0)
            {
                _context.Sachs.AddRange(imported);
                _context.SaveChanges();
            }

            return errors;
        }
    }
}