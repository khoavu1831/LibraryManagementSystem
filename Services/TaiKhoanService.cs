using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Views.UserControls.QLNhanVien.VaiTro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services
{
    internal class TaiKhoanService
    {
        private readonly TaiKhoanRepository _taiKhoanRepository;
        private VaiTroRepository repo;

        public TaiKhoanService(TaiKhoanRepository taiKHoanRepository) => _taiKhoanRepository = taiKHoanRepository;

        public TaiKhoanService(VaiTroRepository repo)
        {
            this.repo = repo;
        }

        public List<Entities.TaiKhoan> getAllTaiKhoan() => _taiKhoanRepository.GetAll();
        public Entities.TaiKhoan? GetTaiKhoanById(int id) => _taiKhoanRepository.GetById(id);
        public Entities.TaiKhoan AddTaiKhoan(TaiKhoan taiKhoan) => _taiKhoanRepository.Add(taiKhoan);
        public Boolean UpdateTaiKhoan(TaiKhoan taiKhoan)
        {
            if (string.IsNullOrEmpty(taiKhoan.TenTaiKhoan) || string.IsNullOrEmpty(taiKhoan.MatKhau))
            {
                MessageBox.Show(
                     "Tài khoản hoặc mật khẩu không hợp lệ. Tài khoản hoặc mật khẩu Không được để trống",
                     "Lỗi nhập liệu",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                 );
                return false;
            }

            if (!Regex.IsMatch(taiKhoan.TenTaiKhoan, @"^[A-Za-z0-9]{1,20}$") || !Regex.IsMatch(taiKhoan.MatKhau, @"^[A-Za-z0-9]{1,20}$"))
            {
                MessageBox.Show(
                     "Tài khoản hoặc mật khẩu không hợp lệ. Tài khoản hoặc mật khẩu chỉ chứa chữ cái và có độ dài từ 1 đến 20 ký tự.",
                     "Lỗi nhập liệu",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                 );
                return false;
            }
            else
            {
                _taiKhoanRepository.Update(taiKhoan);
                return true;
            }
           
        }
        public Entities.TaiKhoan? DeleteTaiKhoan(int id) => _taiKhoanRepository.Delete(id);
    }
}
