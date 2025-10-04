using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;
using System.Text.RegularExpressions;

namespace LibraryManagementSystem.Services
{
    public class TheLoaiService
    {
        private readonly TheLoaiRepository _theLoaiRepository;
        public TheLoaiService(TheLoaiRepository theLoaiRepository) => _theLoaiRepository = theLoaiRepository;
        public List<TheLoai> GetAllTheLoai() => _theLoaiRepository.GetAll();
        public TheLoai? GetTheLoaiById(int id) => _theLoaiRepository.GetById(id);
        public TheLoai? GetTheLoaiByName(string name) => _theLoaiRepository.GetByName(name);
        public TheLoai AddTheLoai(TheLoai theLoai) => _theLoaiRepository.Add(theLoai);
        public TheLoai UpdateTheLoai(TheLoai theLoai) => _theLoaiRepository.Update(theLoai);
        public TheLoai? DeleteTheLoai(int id) => _theLoaiRepository.DeleteById(id);
        public TheLoai Save(TheLoai theLoai)
        {
            if (string.IsNullOrWhiteSpace(theLoai.TenTheloai)) 
                throw new Exception("Tên thể loại không được để trống.");

            if (Regex.IsMatch(theLoai.TenTheloai, @"\d"))
                throw new Exception("Tên thể loại không được chứa số.");

            if (theLoai.IdTheLoai != 0)
            {
                var existingTheLoai = GetTheLoaiById(theLoai.IdTheLoai);

                // StringComparison.OrdinalIgnoreCase: so sánh không phân biệt hoa thường
                if (existingTheLoai != null &&
                    existingTheLoai.TenTheloai?.Trim().Equals(theLoai.TenTheloai?.Trim(), StringComparison.OrdinalIgnoreCase) == true)
                {
                    throw new Exception("Tên thể loại giữ nguyên, không có thay đổi.");
                }
            }

            var existingTheLoaiByTen = GetTheLoaiByName(theLoai.TenTheloai ?? "");
            if (existingTheLoaiByTen != null && existingTheLoaiByTen.IdTheLoai != theLoai.IdTheLoai)
                throw new Exception("Thể loại đã tồn tại.");

            // IdTheLoai == 0: thêm mới; != 0: cập nhật
            if (theLoai.IdTheLoai == 0)
                return AddTheLoai(theLoai);
            else 
                return UpdateTheLoai(theLoai);
        }
        public List<TheLoai> Search(string keyword) => _theLoaiRepository.Search(keyword);
    }
}