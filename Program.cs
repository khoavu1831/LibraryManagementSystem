using LibraryManagementSystem.Data;

namespace LibraryManagementSystem
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
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Forms.LoginForm());

            Data.DatabaseManager.DeleteDatabase();
            Data.DatabaseManager.CreateDatabase();
            var test = new Services.CustomerService();
            test.AddCustomer("kaiwu");
            test.AddCustomer("kaiwu1");
            test.AddCustomer("kaiwu2");
            test.AddCustomer("kaiwu3");
            test.AddCustomer("kaiwu4");

            MessageBox.Show("Tim thay khach hang" + test.GetCustomerById(2).Name);
            var customers = test.GetCustomers();
            string message = String.Join(Environment.NewLine, customers.Select(c => $"{c.Id} + {c.Name}"));
            MessageBox.Show(message);
        }
    }
    
}