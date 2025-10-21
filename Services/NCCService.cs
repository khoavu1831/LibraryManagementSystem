 using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;
using System.Text.RegularExpressions;

namespace LibraryManagementSystem.Services
{
    public class NCCService
    {
        private readonly NCCRepository _nccRepository;
        public NCCService(NCCRepository nccRepository) => _nccRepository = nccRepository;
        public List<NCC> GetAllNCC() => _nccRepository.GetAll();
        public NCC? GetNCCById(int id) => _nccRepository.GetById(id);
        public NCC? GetNCCByName(string name) => _nccRepository.GetByName(name);
        public NCC? GetNCCByPhone(string phone) => _nccRepository.GetByPhone(phone);
        public NCC AddNCC(NCC ncc) => _nccRepository.Add(ncc);
        public NCC UpdateNCC(NCC ncc) => _nccRepository.Update(ncc);
        public NCC? DeleteNCC(int id) => _nccRepository.DeleteById(id);
        public NCC Save(NCC ncc)
        {
            // Tên
            if (string.IsNullOrEmpty(ncc.TenNCC))
                throw new Exception("Tên NCC không được để trống.");

            // Địa chỉ
            if (string.IsNullOrEmpty(ncc.DiaChi))
                throw new Exception("Địa chỉ không được để trống.");

            // SDT
            if (string.IsNullOrEmpty(ncc.SDT))
                throw new Exception("Số điện thoại không được để trống.");

            if (!Regex.IsMatch(ncc.SDT, @"^0\d{9}$"))
                throw new Exception("Số điện thoại phải gồm 10 chữ số và bắt đầu bằng 0.");

            if (ncc.IdNCC != 0)
            {
                var existingNXB = GetNCCById(ncc.IdNCC);

                if (existingNXB != null &&
                    existingNXB.TenNCC?.Trim().Equals(ncc.TenNCC?.Trim(), StringComparison.OrdinalIgnoreCase) == true &&
                    existingNXB.DiaChi?.Trim().Equals(ncc.DiaChi?.Trim(), StringComparison.OrdinalIgnoreCase) == true &&
                    existingNXB.SDT?.Trim() == ncc.SDT?.Trim())
                {
                    throw new Exception("Thông tin nhà cung cấp giữ nguyên, không có thay đổi.");
                }
            }

            var existingNXBByName = GetNCCByName(ncc.TenNCC ?? "");
            if (existingNXBByName != null && existingNXBByName.IdNCC != ncc.IdNCC)
                throw new Exception("Nhà cung cấp đã tồn tại.");

            var existingNXBByPhone = GetNCCByPhone(ncc.SDT ?? "");
            if (existingNXBByPhone != null && existingNXBByPhone.IdNCC != ncc.IdNCC)
                throw new Exception("Số điện thoại đã tồn tại.");

            if (ncc.IdNCC == 0)
                return AddNCC(ncc);
            else
                return UpdateNCC(ncc);
        }
        public List<NCC> SearchNCC(string keyword) => _nccRepository.Search(keyword);
    }
}