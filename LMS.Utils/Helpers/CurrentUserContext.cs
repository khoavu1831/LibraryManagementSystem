
using LMS.Entities;

namespace LMS.Helpers
{
    public static class CurrentUserContext
    {
        public static TaiKhoan? CurrentUser { get; private set; }
        public static List<int> CurrentQuyenIds { get; private set; } = new List<int>();

        public static void SetUser(TaiKhoan user)
        {
            CurrentUser = user;
        }

        public static void SetQuyenIds(List<int> quyenIds)
        {
            CurrentQuyenIds = quyenIds ?? new List<int>();
        }

        public static void Clear()
        {
            CurrentUser = null;
            CurrentQuyenIds.Clear();
        }

        public static bool HasQuyen(int quyenId)
        {
            return CurrentQuyenIds.Contains(quyenId);
        }
    }
}