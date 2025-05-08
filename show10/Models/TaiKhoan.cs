using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Show10.Data_Access
{
    public class TaiKhoan
    {
        [Key]
        public required string TenTK { get; set; }
        public required string MatKhau { get; set; }
        public required string HoTen { get; set; }
        public required string VaiTro { get; set; }
    }

    internal class TaiKhoanContext : DbContext
    {
        public DbSet<TaiKhoan> TaiKhoans { get; set; }

        public string DbPath { get; }

        public TaiKhoanContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "show10.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaiKhoan>().HasData(
                new TaiKhoan { TenTK = "admin", MatKhau = "123", HoTen = "Trương Hoàng Phúc", VaiTro = "admin" },
                new TaiKhoan { TenTK = "user", MatKhau = "123", HoTen = "Phúc Hoàng Trương", VaiTro = "user" }
            );
        }
    }

    
}
