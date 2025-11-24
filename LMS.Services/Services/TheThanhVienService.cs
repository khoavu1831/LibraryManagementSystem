using LMS.Data;
using LMS.Entities;
using LMS.Repository;

namespace LMS.Views.LMS.Services.Services
{
    public class TheThanhVienService
    {
        private readonly LibraryDbContext _context;
        private readonly TheThanhVienRepository _theThanhVienRepository;

        public TheThanhVienService(LibraryDbContext context, TheThanhVienRepository theThanhVienRepository)
        {
            _context = context;
            _theThanhVienRepository = theThanhVienRepository;
        }

        // Lấy tất cả thẻ thành viên
        public List<TheThanhVien> GetAllTheThanhVien()
        {
            var list = _theThanhVienRepository.GetAll();
            foreach (var item in list)
            {
                if (item.NgayHetHan < DateTime.Now && item.TrangThai == TheThanhVien.TrangThaiEnum.HoatDong)
                {
                    item.TrangThai = TheThanhVien.TrangThaiEnum.HetHan;
                    UpdateTheThanhVien(item);
                }
            }
            return list;
        }

        public List<TheThanhVien> getByPage(int page, int pageSize, string keyword = "")
        {
            return _theThanhVienRepository.GetByPage(page, pageSize, keyword);
        }

        public int getCount(string keyword = "") => _theThanhVienRepository.getCount(keyword);
        // Lấy thẻ thành viên theo ID
        public TheThanhVien? GetTheThanhVienById(int id)
        {
            if (id <= 0)
                throw new ArgumentException("ID không hợp lệ.");

            return _theThanhVienRepository.GetById(id);
        }

        // Thêm thẻ thành viên
        public TheThanhVien AddTheThanhVien(TheThanhVien theThanhVien)
        {
            if (theThanhVien == null)
                throw new ArgumentNullException(nameof(theThanhVien), "Đối tượng TheThanhVien không được null.");

            // Validate ngày hết hạn
            if (theThanhVien.NgayHetHan <= DateTime.Today)
                throw new ArgumentException("Ngày hết hạn phải lớn hơn ngày hiện tại.");

            // Nếu muốn: check trùng ID docGia
            var exists = _theThanhVienRepository.GetAll()
                .Any(t => t.IdDocGia == theThanhVien.IdDocGia);
            if (exists)
                throw new InvalidOperationException("Độc giả này đã có thẻ thành viên.");

            // Thêm vào Db
            return _theThanhVienRepository.Add(theThanhVien);
        }

        // Cập nhật thẻ thành viên
        public TheThanhVien UpdateTheThanhVien(TheThanhVien theThanhVien)
        {
            if (theThanhVien == null)
                throw new ArgumentNullException(nameof(theThanhVien), "Đối tượng TheThanhVien không được null.");
            if (theThanhVien.IdTheThanhVien <= 0)
                throw new ArgumentException("ID không hợp lệ.");

            var existing = _theThanhVienRepository.GetById(theThanhVien.IdTheThanhVien);
            if (existing == null)
                throw new InvalidOperationException("Không tìm thấy thẻ thành viên để cập nhật.");

            // Cập nhật dữ liệu
            existing.NgayHetHan = theThanhVien.NgayHetHan;
            existing.IdDocGia = theThanhVien.IdDocGia;
            if (existing.NgayHetHan < existing.NgayCap)
            {
                throw new Exception("Ngày không hợp lệ");
            }


            return _theThanhVienRepository.Update(existing);
        }

        // Xóa thẻ thành viên theo ID
        public TheThanhVien? DeleteTheThanhVien(int id)
        {
            if (id <= 0)
                throw new ArgumentException("ID không hợp lệ.");

            var existing = _theThanhVienRepository.GetById(id);
            if (existing == null)
                throw new InvalidOperationException("Không tìm thấy thẻ thành viên để xóa.");

            return _theThanhVienRepository.Delete(id);
        }

        /// <summary>
        /// Tìm kiếm thẻ thành viên theo từ khóa (tên, mã thẻ, SĐT)
        /// Chỉ trả về thẻ đang hoạt động
        /// </summary>
        public List<TheThanhVien> TimKiemThanhVien(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword) || keyword.Length < 2)
                return new List<TheThanhVien>();

            var result = _theThanhVienRepository.Search(keyword)
                .Where(ttv => ttv.TrangThai == TheThanhVien.TrangThaiEnum.HoatDong)
                .OrderBy(ttv => ttv.DocGia?.TenDocGia)
                .Take(20)
                .ToList();

            return result;
        }
    }
}
