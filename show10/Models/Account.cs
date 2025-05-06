using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Show10.Data_Access
{
    internal class AccountContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        public string DbPath { get; }

        public AccountContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "show10.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }

    public class Account
    {
        public required string Id { get; set; }
        public required string TenTK { get; set; }
        public required string MatKhau { get; set; }
        public required string HoTen { get; set; }
        public required string VaiTro { get; set; }
    }
}
