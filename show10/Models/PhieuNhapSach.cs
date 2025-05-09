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
    internal class PhieuNhapSach
    {
        [Key]
        public required int MaPN { get; set; }
        public required int MaSach { get; set; }
        public required int SoLuong { get; set; }
        [Column(TypeName = "money")]
        public required double GiaNhap { get; set; }
        public required DateTime NgayNhap { get; set; }
    }

    internal class PhieuNhapSachContext : DbContext
    {
        public DbSet<PhieuNhapSach> PhieuNhapSachs { get; set; }

        public string DbPath { get; }

        public PhieuNhapSachContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "show10.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=show10.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PhieuNhapSach>().HasData(
                new PhieuNhapSach { MaPN=1, MaSach=1, GiaNhap=50000, NgayNhap=new DateTime(2025,05,08), SoLuong=12}
            );
        }

    }
}
