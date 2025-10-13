namespace LibraryManagementSystem.Helpers
{
    public static class HandleMessageBox
    {
        public static void HandleErrorMessage(string message)
        {
            MessageBox.Show($"{message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void HandleInformationMessage(string message)
        {
            MessageBox.Show($"{message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void HandleWarningMessage(string message)
        {
            MessageBox.Show($"{message}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}