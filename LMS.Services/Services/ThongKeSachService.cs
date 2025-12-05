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

 
    // TẠO DATATABLE GỬI LÊN UI
    public DataTable TaoBangThongKe(string loai, DateTime from, DateTime to)
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("Tên sách");
        dt.Columns.Add("Thể loại");
        dt.Columns.Add("Số lượng");
        dt.Columns.Add("Ngày");

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
        else if (loai == "Sách đang mượn")
        {
            List<(Sach sach, DateTime ngay)> list = _repo.GetSachDangMuon(from, to);

            foreach (var item in list)
            {
                dt.Rows.Add(
                    item.sach.TenSach,
                    GetLoaiStr(item.sach),
                    1,
                    item.ngay.ToShortDateString() ?? ""
                );
            }
        }
        else if (loai == "Sách mất hoặc hư hỏng")
        {
            var list = _repo.GetSachMatHuHong(from, to);

            foreach (var item in list)
            {
                dt.Rows.Add(
                    item.sach.TenSach,
                    GetLoaiStr(item.sach),
                    1,
                    item.ngay?.ToShortDateString() ?? "Không có ngày"
                );
            }
        }


        else if (loai == "Sách chưa mượn")
        {
            var list = _repo.GetSachChuaMuon();

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

        return dt;
    }
    // DỮ LIỆU TỔNG QUAN CHO BIỂU ĐỒ (CHART)
    public Dictionary<string, int> TinhTongTatCaLoai()
    {
        return new Dictionary<string, int>()
        {
            { "Tổng số lượng sách hiện có", _repo.TongSoSach() },
            { "Số lượng sách đang mượn", _repo.SoSachDangMuon() },
            { "Số lượng sách mất hoặc hư hỏng", _repo.SoSachMatHuHong() },
            { "Số lượng sách chưa mượn", _repo.TongSoSach() - _repo.SoSachDangMuon() }
        };
    }
    private string GetLoaiStr(Sach s)
    {
        return string.Join(", ", s.TheLoais.Select(t => t.TenTheloai));
    }
    
}
