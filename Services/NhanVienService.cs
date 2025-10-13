using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Views.UserControls.QLNhanVien.TaiKhoan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryManagementSystem.Services
{
    public class NhanVienService
    {
        private readonly NhanVienRepository _nhanVienRepository;
        public NhanVienService(NhanVienRepository nhanVienRepository) => _nhanVienRepository = nhanVienRepository;
        public List<Entities.NhanVien> getAllNhanVien() => _nhanVienRepository.GetAll();
        public Entities.NhanVien? GetNhanVienById(int id) => _nhanVienRepository.GetById(id);
        public Boolean AddNhanVien(NhanVien nhanVien)
        {
            if (string.IsNullOrEmpty(nhanVien.TenNhanVien))
            {
                MessageBox.Show(
                     "Tên nhân viên không hợp lệ. Tên nhân viên  Không được để trống",
                     "Lỗi nhập liệu",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                 );
                return false;
            }

            if (string.IsNullOrEmpty(nhanVien.Email))
            {
                MessageBox.Show(
                     "Email không hợp lệ. Email Không được để trống",
                     "Lỗi nhập liệu",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                 );
                return false;
            }

            if (string.IsNullOrEmpty(nhanVien.DiaChi))
            {
                MessageBox.Show(
                     "Địa chỉ không hợp lệ. Địa chỉ Không được để trống",
                     "Lỗi nhập liệu",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                 );
                return false;
            }

            if (string.IsNullOrEmpty(nhanVien.SDT))
            {
                MessageBox.Show(
                     "Số điện thoại không hợp lệ. Số điện thoại Không được để trống",
                     "Lỗi nhập liệu",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                 );
                return false;
            }

            if (!Regex.IsMatch(nhanVien.TenNhanVien, @"^[A-Za-zÀ-Ỹà-ỹ\s]{1,50}$"))
            {
                MessageBox.Show(
                     "Họ và tên không hợp lệ.",
                     "Lỗi nhập liệu",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                 );
                return false;
            }
            if (!Regex.IsMatch(nhanVien.DiaChi, @"^[A-Za-zÀ-Ỹà-ỹ0-9\s]{1,30}$"))
            {
                MessageBox.Show(
                     "Địa chỉ không hợp lệ, không được chứa ký tự đặc biệt.",
                     "Lỗi nhập liệu",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                 );
                return false;
            }
            if (!Regex.IsMatch(nhanVien.SDT, @"^0\d{9}$"))
            {
                MessageBox.Show(
                     "Số điện thoại phải gồm 10 chữ số và bắt đầu bằng 0.",
                     "Lỗi nhập liệu",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                 );
                return false;
            }
            if (!Regex.IsMatch(nhanVien.Email, @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$"))
            {
                MessageBox.Show(
                     "Email không đúng định dạng.",
                     "Lỗi nhập liệu",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                 );
                return false;
            }
            else
            {
                _nhanVienRepository.Add(nhanVien);
                return true;
            }
            
        }
       
        public Boolean AddNVTK(NhanVien nhanVien, TaiKhoan taiKhoan)
        {
            if (string.IsNullOrEmpty(nhanVien.TenNhanVien))
            {
                MessageBox.Show(
                     "Tên nhân viên không hợp lệ. Tên nhân viên  Không được để trống",
                     "Lỗi nhập liệu",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                 );
                return false;
            }

            else if (string.IsNullOrEmpty(nhanVien.Email))
            {
                MessageBox.Show(
                     "Email không hợp lệ. Email Không được để trống",
                     "Lỗi nhập liệu",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                 );
                return false;
            }

            else if (string.IsNullOrEmpty(nhanVien.DiaChi))
            {
                MessageBox.Show(
                     "Địa chỉ không hợp lệ. Địa chỉ Không được để trống",
                     "Lỗi nhập liệu",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                 );
                return false;
            }

            else if (string.IsNullOrEmpty(nhanVien.SDT))
            {
                MessageBox.Show(
                     "Số điện thoại không hợp lệ. Số điện thoại Không được để trống",
                     "Lỗi nhập liệu",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                 );
                return false;
            }
            else if (string.IsNullOrEmpty(taiKhoan.TenTaiKhoan))
            {
                MessageBox.Show(
                     "Tài khoản không hợp lệ. Tài khoản Không được để trống",
                     "Lỗi nhập liệu",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                 );
                return false;
            }
            else if (string.IsNullOrEmpty(taiKhoan.MatKhau))
            {
                MessageBox.Show(
                     "Mật khẩu không hợp lệ. Mật khẩu Không được để trống",
                     "Lỗi nhập liệu",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                 );
                return false;
            }

            else if (!Regex.IsMatch(nhanVien.TenNhanVien, @"^[A-Za-zÀ-Ỹà-ỹ\s]{1,50}$"))
            {
                MessageBox.Show(
                     "Họ và tên không hợp lệ.",
                     "Lỗi nhập liệu",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                 );
                return false;
            }
            else if (!Regex.IsMatch(nhanVien.DiaChi, @"^[A-Za-zÀ-Ỹà-ỹ0-9\s]{1,30}$"))
            {
                MessageBox.Show(
                     "Địa chỉ không hợp lệ, không được chứa ký tự đặc biệt.",
                     "Lỗi nhập liệu",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                 );
                return false;
            }
            else if (!Regex.IsMatch(nhanVien.SDT, @"^0\d{9}$"))
            {
                MessageBox.Show(
                     "Số điện thoại phải gồm 10 chữ số và bắt đầu bằng 0.",
                     "Lỗi nhập liệu",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                 );
                return false;
            }
            else if (!Regex.IsMatch(nhanVien.Email, @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$"))
            {
                MessageBox.Show(
                     "Email không đúng định dạng.",
                     "Lỗi nhập liệu",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                 );
                return false;
            }
            else if (!Regex.IsMatch(taiKhoan.TenTaiKhoan, @"^[A-Za-z0-9]{1,20}$"))
            {
                MessageBox.Show(
                     "Tài khoản chỉ chứa chữ và số, tối đa 20 ký tự.",
                     "Lỗi nhập liệu",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                 );
                return false;
            }
            else if (!Regex.IsMatch(taiKhoan.MatKhau, @"^[A-Za-z0-9@#$_!%^&*]{1,20}$"))
            {
                MessageBox.Show(
                     "Mật khẩu không hợp lệ, tối đa 20 ký tự.",
                     "Lỗi nhập liệu",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                 );
                return false;
            }
            else
            {
                _nhanVienRepository.AddNVTK(nhanVien, taiKhoan);
                return true;
            }
        }
        public Entities.NhanVien UpdateNhanVien(NhanVien nhanVien) => _nhanVienRepository.Update(nhanVien);
        public Entities.NhanVien? DeleteNhanVien(int id) => _nhanVienRepository.Delete(id);
    }
}
