using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Data
{
    public class LibraryDbContext : DbContext
    {
        private readonly string connectionString = @"
                                                   server=localhost;
                                                   port=3306;
                                                   user=root;
                                                   password=;
                                                   database=librarydbtest";
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            // Dùng gói Pomelo nên phải thêm tham số Version
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}
