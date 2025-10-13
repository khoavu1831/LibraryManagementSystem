using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;
using System.Text.RegularExpressions;

namespace LibraryManagementSystem.Services
{
    public class VaiTroService
    {
        private readonly VaiTroRepository _vaiTroRepository;
        public VaiTroService(VaiTroRepository vaiTroRepository) => _vaiTroRepository = vaiTroRepository;
        public List<VaiTro> GetAllVaiTro() => _vaiTroRepository.GetAll();
        public VaiTro? GetVaiTroById(int id) => _vaiTroRepository.GetById(id);
        public Boolean AddVaiTro(VaiTro vaiTro)
        {
            if (string.IsNullOrEmpty(vaiTro.TenVaiTro))
            {
                MessageBox.Show(
                     "Tên vai trò không hợp lệ. Tên vai trò Không được để trống",
                     "Lỗi nhập liệu",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                 );
                return false;
            }

            if (!Regex.IsMatch(vaiTro.TenVaiTro, @"^[\p{L}\s]{1,20}$"))
            {
                MessageBox.Show(
                     "Tên vai trò không hợp lệ. Tên vai trò chỉ chứa chữ cái và có độ dài từ 1 đến 20 ký tự.",
                     "Lỗi nhập liệu",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                 );
                return false;
            }
            else
            {
                _vaiTroRepository.Add(vaiTro);
                return true;
            }
        }

        public Boolean UpdateVaiTro(VaiTro vaiTro)
        {
            if (string.IsNullOrEmpty(vaiTro.TenVaiTro))
            {
                MessageBox.Show(
                     "Tên vai trò không hợp lệ. Tên vai trò Không được để trống",
                     "Lỗi nhập liệu",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                 );
                return false;
            }

            if (!Regex.IsMatch(vaiTro.TenVaiTro, @"^[\p{L}\s]{1,20}$"))
            {
                MessageBox.Show(
                     "Tên vai trò không hợp lệ. Tên vai trò chỉ chứa chữ cái và có độ dài từ 1 đến 20 ký tự.",
                     "Lỗi nhập liệu",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                 );
                return false;
            } else
            {
                _vaiTroRepository.Update(vaiTro);
                return true;
            }

                
        }
       
        public VaiTro? DeleteVaiTro(int id) => _vaiTroRepository.DeleteById(id);
    }
}