using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Data
{
    public static class DatabaseManager
    {
        private static readonly string namedb = new LibraryDbContext().Database.GetDbConnection().Database;
        public static void CreateDatabase()
        {
            var dbcontext = new LibraryDbContext();
            var rs = dbcontext.Database.EnsureCreated();
            if (rs) MessageBox.Show($"created database {namedb}");
        }
        public static void DeleteDatabase()
        {
            var dbcontext = new LibraryDbContext();
            var rs = dbcontext.Database.EnsureDeleted();
            if (rs) MessageBox.Show($"droped database {namedb}");
        }
    }
}
