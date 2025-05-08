using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Show10.Models
{
    internal class HoaDonBanSach
    {
        [Key]
        public required int SoHD { get; set; }
        public required int MaSach { get; set; }
        public required int MaKH { get; set; }
        public required int SoLuong { get; set; }
        [Column(TypeName = "money")]
        public required double GiaBan { get; set; }
        public required DateTime NgayHD { get; set; }
    }

    internal class HoaDonBanSachContext : DbContext
    {
        public DbSet<HoaDonBanSach> HoaDonBanSachs{ get; set; }

        public string DbPath { get; }

        public HoaDonBanSachContext()
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
            modelBuilder.Entity<HoaDonBanSach>().HasData(
                new HoaDonBanSach { SoHD=1, MaKH=1, MaSach=1, GiaBan=50000, NgayHD=new DateTime(2025, 05, 08), SoLuong=1}
            );
        }

    }
}
