using LMS.Data;
using LMS.Entities;
using LMS.Repository;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace LMS.Services
{
    public class DocGiaService
    {
        private readonly DocGiaRepository _docGiaRepository;
        private readonly TheThanhVienRepository _theThanhVienRepository;
        private readonly LibraryDbContext _context;

        public DocGiaService(LibraryDbContext context, DocGiaRepository docGiaRepository, TheThanhVienRepository theThanhVienRepository)
        {
            _context = context; // context dùng để quản lý transaction
            _docGiaRepository = docGiaRepository;
            _theThanhVienRepository = theThanhVienRepository;
        }

        public BindingList<DocGia> GetAllDocGia() => _docGiaRepository.GetAll();

        public DocGia? GetDocGiaById(int id)
        {
            if (id <= 0)
                throw new ArgumentException("ID không hợp lệ.");

            return _docGiaRepository.GetById(id);
        }

        public DocGia AddDocGia(DocGia docGia)
        {
            ValidateDocGia(docGia, isNew: true);
            CheckDuplicate(docGia, isNew: true);

            using var transaction = _context.Database.BeginTransaction();
            try
            {
                // Thêm DocGia
                _docGiaRepository.Add(docGia);

                // Tạo Thẻ Thành Viên
                var theThanhVien = new TheThanhVien
                {
                    IdDocGia = docGia.IdDocGia,
                    NgayCap = DateTime.Now,
                    NgayHetHan = DateTime.Now.AddYears(1),
                    TrangThai = TheThanhVien.TrangThaiEnum.HoatDong
                };
                _theThanhVienRepository.Add(theThanhVien);

                transaction.Commit();
                return docGia;
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        public DocGia UpdateDocGia(DocGia docGia)
        {
            if (docGia.IdDocGia <= 0)
                throw new ArgumentException("ID không hợp lệ.");

            var existing = _docGiaRepository.GetById(docGia.IdDocGia);
            if (existing == null)
                throw new InvalidOperationException("Không tìm thấy độc giả để cập nhật.");

            ValidateDocGia(docGia, isNew: false);
            CheckDuplicate(docGia, isNew: false);
            return _docGiaRepository.Update(docGia);
        }

        public DocGia? DeleteDocGia(int id)
        {
            if (id <= 0)
                throw new ArgumentException("ID không hợp lệ.");

            var existing = _docGiaRepository.GetById(id);
            if (existing == null)
                throw new InvalidOperationException("Không tìm thấy độc giả để xóa.");

            return _docGiaRepository.DeleteById(id);
        }

        private void ValidateDocGia(DocGia docGia, bool isNew)
        {
            if (docGia == null)
                throw new ArgumentNullException(nameof(docGia), "Đối tượng DocGia không được null.");

            // Tên
            if (string.IsNullOrWhiteSpace(docGia.TenDocGia))
                throw new ArgumentException("Tên độc giả không được để trống.");
            if (docGia.TenDocGia.Length > 100)
                throw new ArgumentException("Tên độc giả quá dài (tối đa 100 ký tự).");

            // Địa chỉ
            if (string.IsNullOrWhiteSpace(docGia.DiaChi))
                throw new ArgumentException("Địa chỉ không được để trống.");
            if (docGia.DiaChi.Length > 200)
                throw new ArgumentException("Địa chỉ quá dài (tối đa 200 ký tự).");

            // Ngày sinh
            if (docGia.NgaySinh == default || docGia.NgaySinh >= DateTime.Today)
                throw new ArgumentException("Ngày sinh không hợp lệ.");
            var age = DateTime.Today.Year - docGia.NgaySinh.Year;
            if (age < 5 || age > 120)
                throw new ArgumentException("Độ tuổi độc giả phải từ 5 đến 120.");

            // SĐT
            if (string.IsNullOrWhiteSpace(docGia.SDT))
                throw new ArgumentException("Số điện thoại không được để trống.");
            if (!Regex.IsMatch(docGia.SDT, @"^\d{10,11}$"))
                throw new ArgumentException("Số điện thoại không hợp lệ (10-11 chữ số).");

            // Email
            if (string.IsNullOrWhiteSpace(docGia.Email))
                throw new ArgumentException("Email không được để trống.");
            if (!Regex.IsMatch(docGia.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new ArgumentException("Email không hợp lệ.");
        }

        private void CheckDuplicate(DocGia docGia, bool isNew)
        {
            var allDocGia = _docGiaRepository.GetAll();

            // Kiểm tra trùng email
            var emailDuplicate = allDocGia
                .Any(d => d.Email.Equals(docGia.Email, StringComparison.OrdinalIgnoreCase) &&
                          (isNew || d.IdDocGia != docGia.IdDocGia));
            if (emailDuplicate)
                throw new InvalidOperationException("Email đã tồn tại trong hệ thống.");

            // Kiểm tra trùng số điện thoại
            var sdtDuplicate = allDocGia
                .Any(d => d.SDT == docGia.SDT &&
                          (isNew || d.IdDocGia != docGia.IdDocGia));
            if (sdtDuplicate)
                throw new InvalidOperationException("Số điện thoại đã tồn tại trong hệ thống.");
        }
    }
}