using LMS.Entities;
using LMS.Models.Dtos;
using LMS.Repository;

namespace LMS.Services
{
    public class BanSaoSachService
    {
        private readonly BanSaoSachRepository _bssRepository;
        public BanSaoSachService(BanSaoSachRepository bssRepository) => _bssRepository = bssRepository;
        public List<BanSaoSach> GetAllBanSaoSach() => _bssRepository.GetAll();
        public List<LMS.Models.Dtos.BanSaoSachExcelDto> GetListExport()
        {
            return _bssRepository.GetAll().Select(s => new Models.Dtos.BanSaoSachExcelDto
            {
                IdBanSaoSach = s.IdBanSaoSach,
                IdSach = s.IdSach,
                TenSach = s.Sach.TenSach,
                TinhTrangSach = (BanSaoSachExcelDto.TinhTrangSachEnum)s.TinhTrangSach
            }).ToList();
        }
        public BanSaoSach? GetBanSaoSachById(string id) => _bssRepository.GetById(id);
        public List<BanSaoSach> GetBanSaoSachByPage(int page, int pageSize, string keyword = "") => _bssRepository.GetByPage(page, pageSize, keyword);
        public int GetTotalRecords(string keyword) => _bssRepository.GetCount(keyword);
        public List<BanSaoSach> GetBanSaoSachByTinhTrang(BanSaoSach.TinhTrangSachEnum tinhTrang) => _bssRepository.GetAll()
            .Where(bss => bss.TinhTrangSach == tinhTrang)
            .ToList();
        public BanSaoSach AddBanSaoSach(BanSaoSach BanSaoSach) => _bssRepository.Add(BanSaoSach);
        public BanSaoSach UpdateBanSaoSach(BanSaoSach BanSaoSach) => _bssRepository.Update(BanSaoSach);
        public void UpdateTinhTrang(string idBanSao, BanSaoSach.TinhTrangSachEnum tinhTrang)
        {
            var bss = _bssRepository.GetById(idBanSao);
            if (bss == null)
                throw new Exception($"Không tìm thấy bản sao sách có ID: {idBanSao}");

            bss.TinhTrangSach = tinhTrang;
            _bssRepository.Update(bss);
        }
        public BanSaoSach? DeleteBanSaoSach(string id) => _bssRepository.DeleteById(id);
    }
}