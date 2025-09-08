using LibraryManagementSystem.Data;
using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services
{
    public class CustomerService
    {
        public List<Customer> GetCustomers()
        {
            var dbcontext = new LibraryDbContext();
            return dbcontext.Customers.ToList();
        }
        public void AddCustomer(string name)
        {
            var dbcontext = new LibraryDbContext();
            var customer = new Customer();
            customer.Name = name;
            dbcontext.Customers.Add(customer);
            dbcontext.SaveChanges();
        }
        public Customer? GetCustomerById(int id)
        {
            var dbcontext = new LibraryDbContext();
            return dbcontext.Customers.FirstOrDefault(user => user.Id == id);
        }
    }
}
