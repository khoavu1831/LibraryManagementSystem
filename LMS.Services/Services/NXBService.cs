using LMS.Entities;
using LMS.Repository;
using System.Text.RegularExpressions;

namespace LMS.Services
{
    public class NXBService
    {
        private readonly NXBRepository _nxbRepository;
        public NXBService(NXBRepository nxbRepository) => _nxbRepository = nxbRepository;
        public List<NXB> GetAllNXB() => _nxbRepository.GetAll();
        public NXB? GetNXBById(int id) => _nxbRepository.GetById(id);
        public NXB? GetNXBByName(string name) => _nxbRepository.GetByName(name);
        public NXB? GetNXBByPhone(string phone) => _nxbRepository.GetByPhone(phone);
        public NXB AddNXB(NXB nxb) => _nxbRepository.Add(nxb);
        public NXB UpdateNXB(NXB nxb) => _nxbRepository.Update(nxb);
        public NXB? DeleteNXB(int id) => _nxbRepository.DeleteById(id);
        public NXB Save(NXB nxb)
        {
            // Tên
            if (string.IsNullOrEmpty(nxb.TenNXB))
                throw new Exception("Tên NXB không được để trống.");

            // Địa chỉ
            if (string.IsNullOrEmpty(nxb.DiaChi))
                throw new Exception("Địa chỉ không được để trống.");
                
            // SDT
            if (string.IsNullOrEmpty(nxb.SDT))
                throw new Exception("Số điện thoại không được để trống.");

            if (!Regex.IsMatch(nxb.SDT, @"^0\d{9}$"))
                throw new Exception("Số điện thoại phải gồm 10 chữ số và bắt đầu bằng 0.");
            
            if (nxb.IdNXB != 0)
            {
                var existingNXB = GetNXBById(nxb.IdNXB);

                if (existingNXB != null &&
                    existingNXB.TenNXB?.Trim().Equals(nxb.TenNXB?.Trim(), StringComparison.OrdinalIgnoreCase) == true &&
                    existingNXB.DiaChi?.Trim().Equals(nxb.DiaChi?.Trim(), StringComparison.OrdinalIgnoreCase) == true &&
                    existingNXB.SDT?.Trim() == nxb.SDT?.Trim())
                {
                    throw new Exception("Thông tin nhà xuất bản giữ nguyên, không có thay đổi.");
                }
            }

            var existingNXBByName = GetNXBByName(nxb.TenNXB ?? "");
            if (existingNXBByName != null && existingNXBByName.IdNXB != nxb.IdNXB)
                throw new Exception("Nhà xuất bản đã tồn tại.");

            var existingNXBByPhone = GetNXBByPhone(nxb.SDT ?? "");
            if (existingNXBByPhone != null && existingNXBByPhone.IdNXB != nxb.IdNXB)
                throw new Exception("Số điện thoại đã tồn tại.");

            if (nxb.IdNXB == 0)
                return AddNXB(nxb);
            else
                return UpdateNXB(nxb);
        }
        public List<NXB> SearchNXB(string keyword) => _nxbRepository.Search(keyword);
    }
}