using System.Text.RegularExpressions;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;

namespace LibraryManagementSystem.Services
{
    public class TacGiaService
    {
        private readonly TacGiaRepository _tacGiaRepository;
        public TacGiaService(TacGiaRepository tacGiaRepository) => _tacGiaRepository = tacGiaRepository;
        public List<TacGia> GetAllTacGia() => _tacGiaRepository.GetAll();
        public TacGia? GetTacGiaById(int id) => _tacGiaRepository.GetById(id);
        public TacGia? GetTacGiaByName(string name) => _tacGiaRepository.GetByName(name);
        public TacGia? GetTacGiaByBirth(DateTime ngaySinh) => _tacGiaRepository.GetByBirth(ngaySinh);
        public TacGia? GetTacGiaByNoiSinh(string noisinh) => _tacGiaRepository.GetByNoiSinh(noisinh);
        public TacGia? GetTacGiaByPhone(string sdt) => _tacGiaRepository.GetByPhone(sdt);

        public TacGia AddTacGia(TacGia tacGia) => _tacGiaRepository.Add(tacGia);
        public TacGia UpdateTacGia(TacGia tacGia) => _tacGiaRepository.Update(tacGia);
        public TacGia? DeleteTacGia(int id) => _tacGiaRepository.DeleteById(id);
        public TacGia Save(TacGia tacGia)
        {
            // Tên
            if (string.IsNullOrEmpty(tacGia.TenTacGia))
                throw new Exception("Tên tác giả không được để trống.");
            if (Regex.IsMatch(tacGia.TenTacGia, @"\d$"))
                throw new Exception("Tên tác giả không được chứa số.");

            // Ngày sinh
            if (tacGia.NgaySinh >= DateTime.Now)
                throw new Exception("Ngày sinh không hợp lệ");

            // Nơi sinh
            if (string.IsNullOrEmpty(tacGia.NoiSinh))
                throw new Exception("Nơi sinh tác giả không được để trống.");
            if (Regex.IsMatch(tacGia.NoiSinh, @"\d$"))
                throw new Exception("Nơi sinh không được chứa số.");

            // SDT
            if (string.IsNullOrEmpty(tacGia.SDT))
                throw new Exception("Số điện thoại không được để trống.");
            if (!Regex.IsMatch(tacGia.SDT, @"^0\d{9}$"))
                throw new Exception("Số điện thoại phải gồm 10 chữ số và bắt đầu bằng 0.");

            if (tacGia.IdTacGia != 0)
            {
                var existingTacGia = GetTacGiaById(tacGia.IdTacGia);

                if (existingTacGia != null &&
                    existingTacGia.TenTacGia?.Trim().Equals(tacGia.TenTacGia?.Trim(), StringComparison.OrdinalIgnoreCase) == true &&
                    existingTacGia.NgaySinh.Equals(tacGia.NgaySinh) &&
                    existingTacGia.NoiSinh?.Trim().Equals(tacGia.NoiSinh?.Trim(), StringComparison.OrdinalIgnoreCase) == true &&
                    existingTacGia.SDT?.Trim() == tacGia.SDT?.Trim())
                {
                    throw new Exception("Thông tin tác giả giữ nguyên, không có thay đổi.");
                }
            }

            var existingTacGiaByName = GetTacGiaByName(tacGia.TenTacGia ?? "");
            if (existingTacGiaByName != null && existingTacGiaByName.IdTacGia != tacGia.IdTacGia)
                throw new Exception("Tác giả đã tồn tại");

            var existingTacGiaByPhone = GetTacGiaByPhone(tacGia.SDT ?? "");
            if (existingTacGiaByPhone != null && existingTacGiaByPhone.IdTacGia != tacGia.IdTacGia)
                throw new Exception("Số điện thoại đã tồn tại");

            if (tacGia.IdTacGia == 0)
                return AddTacGia(tacGia);
            else
                return UpdateTacGia(tacGia);
        }
        public List<TacGia> SearchTacGia(string keyword) => _tacGiaRepository.Search(keyword);
    }
}