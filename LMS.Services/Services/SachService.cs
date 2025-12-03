using LMS.Entities;
using LMS.Models.Dtos;
using LMS.Repository;
using System.Collections.Generic;

namespace LMS.Services
{
    public class SachService
    {
        private readonly SachRepository _sachRepository;
        public SachService(SachRepository sachRepository) => _sachRepository = sachRepository;
        public List<Sach> GetAllSach() => _sachRepository.GetAll();
        public Sach? GetSachById(int id) => _sachRepository.GetById(id);
        public Sach AddSach(Sach sach) => _sachRepository.Add(sach);
        public Sach UpdateSach(Sach sach) => _sachRepository.Update(sach);

        public List<SachExcelDto> GetListExport() => _sachRepository.GetListExport();
        public List<string> ImportFromExcel(List<SachExcelDto> rows) => _sachRepository.ImportFromExcel(rows);
    }
}