using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;

namespace LibraryManagementSystem.Services
{
    public class TheLoaiService
    {
        private readonly TheLoaiRepository _theLoaiRepository;
        public TheLoaiService(TheLoaiRepository theLoaiRepository) => _theLoaiRepository = theLoaiRepository;
        public List<TheLoai> GetAllTheLoai() => _theLoaiRepository.GetAll();
        public TheLoai? GetTheLoaiById(int id) => _theLoaiRepository.GetById(id);
        public TheLoai AddTheLoai(TheLoai theLoai) => _theLoaiRepository.Add(theLoai);
        public TheLoai UpdateTheLoai(TheLoai theLoai) => _theLoaiRepository.Update(theLoai);
        public TheLoai? DeleteTheLoai(int id) => _theLoaiRepository.DeleteById(id);
    }
}