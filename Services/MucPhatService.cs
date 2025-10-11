using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Repository;
using System.Text.RegularExpressions;

namespace LibraryManagementSystem.Services
{
    public class MucPhatService
    {
        private readonly MucPhatRepository _mucPhatRepository;
        public MucPhatService(MucPhatRepository mucPhatRepository) => _mucPhatRepository = mucPhatRepository;

        public List<MucPhat> GetAllMucPhat() => _mucPhatRepository.GetAll();
        public MucPhat? GetMucPhatById(int id) => _mucPhatRepository.GetById(id);
        public MucPhat AddMucPhat(MucPhat mucPhat) => _mucPhatRepository.Add(mucPhat);
        public MucPhat UpdateMucPhat(MucPhat mucPhat) => _mucPhatRepository.Update(mucPhat);
        public MucPhat? DeleteMucPhat(int id) => _mucPhatRepository.DeleteById(id);
        public List<MucPhat> SearchMucPhat(string keyword) => _mucPhatRepository.Search(keyword);
        public MucPhat Save(MucPhat mucPhat)
        {
            //tên
            if (string.IsNullOrEmpty(mucPhat.TenMucPhat))
                throw new Exception("Tên mức phạt không được để trống.");

            //số tiền
            if (mucPhat.SoTienPhat <= 0)
                throw new Exception("Số tiền phạt phải lớn hơn 0.");

            if (mucPhat.IdMucPhat != 0)
            {
                var existing = GetMucPhatById(mucPhat.IdMucPhat);
                if (existing != null)
                {
                    bool noChange =
                        existing.TenMucPhat?.Equals(mucPhat.TenMucPhat, StringComparison.OrdinalIgnoreCase) == true &&
                        existing.SoTienPhat == mucPhat.SoTienPhat &&
                        existing.MoTa == mucPhat.MoTa &&
                        existing.LoaiPhat == mucPhat.LoaiPhat;

                    if (noChange)
                        throw new Exception("Thông tin mức phạt giữ nguyên, không có thay đổi.");
                }
            }

            var existingMucPhatByName = _mucPhatRepository.GetByName(mucPhat.TenMucPhat ?? "");
            if (existingMucPhatByName != null && existingMucPhatByName.IdMucPhat != mucPhat.IdMucPhat)
                throw new Exception("Tên mức phạt đã tồn tại.");    

            if (mucPhat.IdMucPhat == 0)
                return AddMucPhat(mucPhat);
            else
                return UpdateMucPhat(mucPhat);
        }
    }
}