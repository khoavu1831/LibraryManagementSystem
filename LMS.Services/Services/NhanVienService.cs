using LMS.Entities;
using LMS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LMS.Services
{
    public class NhanVienService
    {
        private readonly NhanVienRepository _nhanVienRepository;
        public NhanVienService(NhanVienRepository nhanVienRepository) => _nhanVienRepository = nhanVienRepository;
        public List<Entities.NhanVien> getAllNhanVien() => _nhanVienRepository.GetAll();
        public Entities.NhanVien? GetNhanVienById(int id) => _nhanVienRepository.GetById(id);
        public NhanVien AddNhanVien(NhanVien nhanVien)
        {
            // Validate tên nhân viên
            if (string.IsNullOrEmpty(nhanVien.TenNhanVien))
                throw new Exception("Tên nhân viên không được để trống.");

            if (!Regex.IsMatch(nhanVien.TenNhanVien.Trim(), @"^[A-Za-zÀ-Ỹà-ỹ\s]{1,50}$"))
                throw new Exception("Tên nhân viên không hợp lệ. Không chứa số hoặc ký tự đặc biệt, tối đa 50 ký tự.");

            // Validate Email
            if (string.IsNullOrEmpty(nhanVien.Email))
                throw new Exception("Email không được để trống.");

            if (!Regex.IsMatch(nhanVien.Email.Trim(), @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$"))
                throw new Exception("Email không đúng định dạng.");

            // Validate địa chỉ
            if (string.IsNullOrEmpty(nhanVien.DiaChi))
                throw new Exception("Địa chỉ không được để trống.");

            if (!Regex.IsMatch(nhanVien.DiaChi.Trim(), @"^[A-Za-zÀ-Ỹà-ỹ0-9\s]{1,100}$"))
                throw new Exception("Địa chỉ không hợp lệ, không chứa ký tự đặc biệt.");

            // Validate số điện thoại
            if (string.IsNullOrEmpty(nhanVien.SDT))
                throw new Exception("Số điện thoại không được để trống.");

            if (!Regex.IsMatch(nhanVien.SDT.Trim(), @"^0\d{9}$"))
                throw new Exception("Số điện thoại phải gồm 10 chữ số và bắt đầu bằng số 0.");

            // Thêm nhân viên
            return _nhanVienRepository.Add(nhanVien);
        }


        public NhanVien AddNVTK(NhanVien nhanVien, TaiKhoan taiKhoan)
        {
            // Validate Nhân viên -----------------------------
            if (string.IsNullOrWhiteSpace(nhanVien.TenNhanVien))
                throw new Exception("Tên nhân viên không được để trống.");

            if (!Regex.IsMatch(nhanVien.TenNhanVien.Trim(), @"^[A-Za-zÀ-Ỹà-ỹ\s]{1,50}$"))
                throw new Exception("Tên nhân viên không hợp lệ. Không được chứa số hoặc ký tự đặc biệt.");

            if (string.IsNullOrWhiteSpace(nhanVien.Email))
                throw new Exception("Email không được để trống.");

            if (!Regex.IsMatch(nhanVien.Email.Trim(), @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$"))
                throw new Exception("Email không đúng định dạng.");

            if (string.IsNullOrWhiteSpace(nhanVien.DiaChi))
                throw new Exception("Địa chỉ không được để trống.");

            if (!Regex.IsMatch(nhanVien.DiaChi.Trim(), @"^[A-Za-zÀ-Ỹà-ỹ0-9\s]{1,100}$"))
                throw new Exception("Địa chỉ không hợp lệ. Không chứa ký tự đặc biệt.");

            if (string.IsNullOrWhiteSpace(nhanVien.SDT))
                throw new Exception("Số điện thoại không được để trống.");

            if (!Regex.IsMatch(nhanVien.SDT.Trim(), @"^0\d{9}$"))
                throw new Exception("Số điện thoại phải gồm 10 chữ số và bắt đầu bằng 0.");

            // Validate Tài khoản -----------------------------
            if (string.IsNullOrWhiteSpace(taiKhoan.TenTaiKhoan))
                throw new Exception("Tên tài khoản không được để trống.");

            if (!Regex.IsMatch(taiKhoan.TenTaiKhoan.Trim(), @"^[A-Za-z0-9]{4,20}$"))
                throw new Exception("Tên tài khoản chỉ chứa chữ và số, tối thiểu 4 ký tự và tối đa 20 ký tự.");

            if (string.IsNullOrWhiteSpace(taiKhoan.MatKhau))
                throw new Exception("Mật khẩu không được để trống.");

            if (!Regex.IsMatch(taiKhoan.MatKhau.Trim(), @"^[A-Za-z0-9@#$_!%^&*]{6,20}$"))
                throw new Exception("Mật khẩu phải từ 6-20 ký tự, cho phép ký tự đặc biệt.");

            // Thực hiện thêm -------------------------------
            return _nhanVienRepository.AddNVTK(nhanVien, taiKhoan);
        }

        public NhanVien UpdateNhanVien(NhanVien nhanVien)
        {
            if (nhanVien.IdNhanVien <= 0)
                throw new Exception("Nhân viên không hợp lệ.");

            // Validate dữ liệu
            if (string.IsNullOrWhiteSpace(nhanVien.TenNhanVien))
                throw new Exception("Tên nhân viên không được để trống.");

            if (!Regex.IsMatch(nhanVien.TenNhanVien.Trim(), @"^[A-Za-zÀ-Ỹà-ỹ\s]{1,50}$"))
                throw new Exception("Tên nhân viên không hợp lệ. Không chứa số và ký tự đặc biệt.");

            if (string.IsNullOrWhiteSpace(nhanVien.Email))
                throw new Exception("Email không được để trống.");

            if (!Regex.IsMatch(nhanVien.Email.Trim(), @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$"))
                throw new Exception("Email không đúng định dạng.");

            if (string.IsNullOrWhiteSpace(nhanVien.DiaChi))
                throw new Exception("Địa chỉ không được để trống.");

            if (!Regex.IsMatch(nhanVien.DiaChi.Trim(), @"^[A-Za-zÀ-Ỹà-ỹ0-9\s]{1,100}$"))
                throw new Exception("Địa chỉ không hợp lệ, không chứa ký tự đặc biệt.");

            if (string.IsNullOrWhiteSpace(nhanVien.SDT))
                throw new Exception("Số điện thoại không được để trống.");

            if (!Regex.IsMatch(nhanVien.SDT.Trim(), @"^0\d{9}$"))
                throw new Exception("Số điện thoại phải gồm 10 chữ số và bắt đầu bằng số 0.");

            // Cập nhật nhân viên
            return _nhanVienRepository.Update(nhanVien);
        }

        public Entities.NhanVien? DeleteNhanVien(int id) => _nhanVienRepository.Delete(id);
        public List<Entities.NhanVien> SearchNhanVien(string keyword) => _nhanVienRepository.Search(keyword);
    }
}
