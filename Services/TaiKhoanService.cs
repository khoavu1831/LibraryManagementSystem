using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public Entities.TaiKhoan UpdateTaiKhoan(TaiKhoan taiKhoan) => _taiKhoanRepository.Update(taiKhoan);
    }
}
