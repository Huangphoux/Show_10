using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Show10.Models
{
    internal class PhieuThuTien
    {
        [Key]
        public required int MaPT { get; set; }
        public required int MaKH { get; set; }
        [Column(TypeName = "smalldatetime")]
        public required DateTime NgayThu { get; set; }
        [Column(TypeName = "money")]
        public required double SoTien { get; set; }
    }

    internal class PhieuThuTienContext : DbContext
    {
        public DbSet<PhieuThuTien> PhieuThuTiens { get; set; }

        public string DbPath { get; }

        public PhieuThuTienContext()
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
            modelBuilder.Entity<KhachHang>().HasData(
                new PhieuThuTien { MaPT=1, MaKH=1, NgayThu=new DateTime(2025, 05,08), SoTien=50000}
            );
        }
    }
}
