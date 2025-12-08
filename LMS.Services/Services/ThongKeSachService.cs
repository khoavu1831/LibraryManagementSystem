using LMS.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

public class ThongKeSachService
{
    private readonly ThongKeSachRepository _repo;

    public ThongKeSachService()
    {
        _repo = new ThongKeSachRepository();
    }

    // 1) TẠO DATATABLE GỬI LÊN UI
    public DataTable TaoBangThongKe(string loai, DateTime from, DateTime to)
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("Tên sách");
        dt.Columns.Add("Thể loại");
        dt.Columns.Add("Số lượng", typeof(int));
        dt.Columns.Add("Ngày");

        // ===== TỔNG SỐ SÁCH =====
        if (loai == "Tổng số sách")
        {
            var list = _repo.GetAllSach();

            foreach (var s in list)
            {
                dt.Rows.Add(
                    s.TenSach,
                    GetLoaiStr(s),
                    s.SoLuongBanSao,
                    DateTime.Now.ToShortDateString()
                );
            }
        }

        // ===== SÁCH ĐANG MƯỢN =====
        else if (loai == "Sách đang mượn")
        {
            var list = _repo.GetSachDangMuon(from, to);

            // GOM NHÓM THEO TEN + NGAY
            var grouped = list
                .GroupBy(x => new
                {
                    x.sach.TenSach,
                    Loai = GetLoaiStr(x.sach),
                    Ngay = x.ngay.Date
                })
                .Select(g => new
                {
                    TenSach = g.Key.TenSach,
                    TheLoai = g.Key.Loai,
                    SoLuong = g.Count(),
                    Ngay = g.Key.Ngay
                })
                .OrderBy(x => x.TenSach)
                .ThenBy(x => x.Ngay)
                .ToList();

            foreach (var item in grouped)
            {
                dt.Rows.Add(
                    item.TenSach,
                    item.TheLoai,
                    item.SoLuong,
                    item.Ngay.ToShortDateString()
                );
            }
        }


        // ===== SÁCH MẤT / HƯ HỎNG =====
        else if (loai == "Sách mất hoặc hư hỏng")
        {
            var list = _repo.GetSachMatHuHong(from, to);

            foreach (var item in list)
            {
                dt.Rows.Add(
                    item.sach.TenSach,
                    GetLoaiStr(item.sach),
                    1,
                    item.ngayTra?.ToShortDateString() ?? "Không có ngày"
                );
            }
        }

        // ===== SÁCH CHƯA MƯỢN =====
        else if (loai == "Sách chưa mượn")
        {
            var allBooks = _repo.GetAllSach();

            foreach (var s in allBooks)
            {
                int dangMuon = _repo.SoBanSaoDangMuonTheoSach(s.IdSach, from, to);

                int available = s.SoLuongBanSao - dangMuon;

                if (available > 0)
                {
                    dt.Rows.Add(
                        s.TenSach,
                        GetLoaiStr(s),
                        available,
                        DateTime.Now.ToShortDateString()
                    );
                }
            }
        }

        return dt;
    }

    // 2) TÍNH TỔNG CHO BIỂU ĐỒ (CHART)

    public Dictionary<string, int> TinhTongTatCaLoai(DateTime from, DateTime to, string selectedLoai, DataTable dt)
    {
        // Tổng số lượng từ DataGridView
        int SumFromDt()
        {
            if (dt == null) return 0;

            int sum = 0;
            foreach (DataRow r in dt.Rows)
            {
                if (int.TryParse(r["Số lượng"].ToString(), out int v))
                    sum += v;
            }
            return sum;
        }

        // ===== Giá trị gốc lấy trực tiếp từ DB =====
        int totalTong = _repo.TongSoSach();
        int totalDangMuon = _repo.SoSachDangMuon(from, to);
        int totalMatHuHong = _repo.SoSachMatHuHong(from, to);

        // ===== Tính sách chưa mượn đúng theo từng SÁCH =====
        int totalChuaMuon = 0;
        var allBooks = _repo.GetAllSach();

        foreach (var s in allBooks)
        {
            int dangMuon = _repo.SoBanSaoDangMuonTheoSach(s.IdSach, from, to);
            int available = s.SoLuongBanSao - dangMuon;

            if (available > 0)
                totalChuaMuon += available;
        }

        // Override từ DataTable (đúng số đang hiển thị)
        int fromDt = SumFromDt();

        return new Dictionary<string, int>
        {
            ["Tổng số lượng sách hiện có"] = (selectedLoai == "Tổng số sách") ? fromDt : totalTong,
            ["Số lượng sách đang mượn"] = (selectedLoai == "Sách đang mượn") ? fromDt : totalDangMuon,
            ["Số lượng sách mất hoặc hư hỏng"] = (selectedLoai == "Sách mất hoặc hư hỏng") ? fromDt : totalMatHuHong,
            ["Số lượng sách chưa mượn"] = (selectedLoai == "Sách chưa mượn") ? fromDt : totalChuaMuon
        };
    }

    private string GetLoaiStr(Sach s)
    {
        return string.Join(", ", s.TheLoais.Select(t => t.TenTheloai));
    }
}
