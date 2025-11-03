using LMS.Entities;
using LMS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LMS.Services
{
    internal class TaiKhoanService
    {
        private readonly TaiKhoanRepository _taiKhoanRepository;
        private VaiTroRepository repo;  // Giữ nguyên, nhưng không dùng ở đây

        public TaiKhoanService(TaiKhoanRepository taiKhoanRepository) => _taiKhoanRepository = taiKhoanRepository;

        public TaiKhoanService(VaiTroRepository repo)
        {
            this.repo = repo;
        }

        public List<Entities.TaiKhoan> getAllTaiKhoan() => _taiKhoanRepository.GetAll();
        public Entities.TaiKhoan? GetTaiKhoanById(int id) => _taiKhoanRepository.GetById(id);
        public Entities.TaiKhoan AddTaiKhoan(TaiKhoan taiKhoan) => _taiKhoanRepository.Add(taiKhoan);
        public TaiKhoan UpdateTaiKhoan(TaiKhoan taiKhoan)
        {
            if (string.IsNullOrWhiteSpace(taiKhoan.TenTaiKhoan) || string.IsNullOrWhiteSpace(taiKhoan.MatKhau))
                throw new Exception("Tài khoản hoặc mật khẩu không được để trống.");

            if (!Regex.IsMatch(taiKhoan.TenTaiKhoan, @"^[A-Za-z0-9]{1,20}$"))
                throw new Exception("Tên tài khoản chỉ được chứa chữ và số, tối đa 20 ký tự.");

            if (!Regex.IsMatch(taiKhoan.MatKhau, @"^[A-Za-z0-9]{1,20}$"))
                throw new Exception("Mật khẩu chỉ được chứa chữ và số, tối đa 20 ký tự.");

            return _taiKhoanRepository.Update(taiKhoan);
        }
        public Entities.TaiKhoan? DeleteTaiKhoan(int id) => _taiKhoanRepository.Delete(id);

        // THÊM PHƯƠNG THỨC AUTHENTICATE MỚI (nếu muốn dùng Service)
        public TaiKhoan? Authenticate(string username, string password) => _taiKhoanRepository.Authenticate(username, password);
    }
}