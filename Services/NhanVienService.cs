using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services
{
    public class NhanVienService
    {
        private readonly NhanVienRepository _nhanVienRepository;
        public NhanVienService(NhanVienRepository nhanVienRepository) => _nhanVienRepository = nhanVienRepository;
        public List<Entities.NhanVien> getAllNhanVien() => _nhanVienRepository.GetAll();
        public Entities.NhanVien? GetNhanVienById(int id) => _nhanVienRepository.GetById(id);
        public Entities.NhanVien AddNhanVien(NhanVien nhanVien) => _nhanVienRepository.Add(nhanVien);
        public Entities.NhanVien AddNVTK(NhanVien nhanVien, TaiKhoan taiKhoan) => _nhanVienRepository.AddNVTK(nhanVien, taiKhoan);
    }
}
