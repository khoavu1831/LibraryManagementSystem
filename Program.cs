using LMS.Forms;
using LMS.Views.Forms;

namespace LMS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration

            ApplicationConfiguration.Initialize();
            using (var loginForm = new LoginForm())
            {
                var result = loginForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // Nhận quyền từ LoginForm
                    var userPermissions = loginForm.UserPermissions;

                    Application.Run(new MainForm(userPermissions));
                }
                else
                {
                    Application.Exit();
                }
            }
            //Application.Run(new MainForm());
        }
    }
}